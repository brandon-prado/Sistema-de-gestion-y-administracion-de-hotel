Imports Oracle.DataAccess.Client

Public Class Folio
    Private idFolio As Integer
    Private idUsuario As Integer
    Private idReservacion As Integer
    Private cantidadCargoExtra As Double
    Private cantidadCargoTotal As Double
    Private cantidadPago As Double
    Private estado As String
    Private nota As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idFolio = 0
        idUsuario = 0
        idReservacion = 0
        cantidadCargoExtra = 0.0
        cantidadCargoTotal = 0.0
        cantidadPago = 0.0
        nota = ""
        estado = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idFolioD As Integer, ByVal idUsuarioD As Integer, ByVal idReservacionD As Integer, ByVal cantidadCargoExtraD As Double, ByVal cantidadCargoTotalD As Double, ByVal cantidadPagoD As Double, ByVal notaD As String, ByVal estadoD As String)
        idFolio = idFolioD
        idUsuario = idUsuarioD
        idReservacion = idReservacionD
        cantidadCargoExtra = cantidadCargoExtraD
        cantidadCargoTotal = cantidadCargoTotalD
        cantidadPago = cantidadPagoD
        nota = notaD
        estado = estadoD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdFolio() As Integer
        Get
            Return idFolio
        End Get
        Set(ByVal Value As Integer)
            idFolio = Value
        End Set
    End Property

    Public Property GetSetIdUsuario() As Integer
        Get
            Return idUsuario
        End Get
        Set(ByVal Value As Integer)
            idUsuario = Value
        End Set
    End Property

    Public Property GetSetIdReservacion() As Integer
        Get
            Return idReservacion
        End Get
        Set(ByVal Value As Integer)
            idReservacion = Value
        End Set
    End Property

    Public Property GetSetCantidadCargoExtra() As Double
        Get
            Return cantidadCargoExtra
        End Get
        Set(ByVal Value As Double)
            cantidadCargoExtra = Value
        End Set
    End Property

    Public Property GetSetCantidadCargoTotal() As Double
        Get
            Return cantidadCargoTotal
        End Get
        Set(ByVal Value As Double)
            cantidadCargoTotal = Value
        End Set
    End Property

    Public Property GetSetCantidadPago() As Double
        Get
            Return cantidadPago
        End Get
        Set(ByVal Value As Double)
            cantidadPago = Value
        End Set
    End Property

    Public Property GetSetNota() As String
        Get
            Return nota
        End Get
        Set(ByVal Value As String)
            nota = Value
        End Set
    End Property

    Public Property GetSetEstado() As String
        Get
            Return estado
        End Get
        Set(ByVal Value As String)
            estado = Value
        End Set
    End Property

    'Método que actualiza la cantidad de cargo extra
    Public Sub ActualizarCargoExtraEnFolio()
        Try
            strSql = "UPDATE Folio SET cantidad_cargo_extra = " & cantidadCargoExtra & " WHERE id_folio = " & idFolio
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método que actualiza la cantidad de cargo total
    Public Sub ActualizarCargoTotalEnFolio()
        Try
            strSql = "UPDATE Folio SET cantidad_cargo_total = " & cantidadCargoTotal & " WHERE id_folio = " & idFolio
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método que actualiza la cantidad pagada
    Public Sub ActualizarCantidadPagadaEnFolio()
        Try
            strSql = "UPDATE Folio SET cantidad_pagada = " & cantidadPago & " WHERE id_folio = " & idFolio
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Función que consulta sí existe un folio y regresa un TRUE o FALSE
    Public Function ConsultaUnFolio() As Boolean

        strSql = "SELECT id_folio FROM Folio WHERE id_folio = " & idFolio

            ConsultaUnFolio = False
            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count = 1 Then
                ConsultaUnFolio = True
            End If


    End Function

    'Función que valida sí un folio tiene dependencias (Sí un cargo extra o un pago depende de un registro de folio)
    Public Function ValidaFolioCargoExtraYPago() As Boolean
        ValidaFolioCargoExtraYPago = False
        Try
            strSql = "SELECT * FROM Cargo_extra WHERE id_folio = " & idFolio
            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count >= 1 Then
                ValidaFolioCargoExtraYPago = True
            End If

            strSql = "SELECT * FROM Pago WHERE id_folio = " & idFolio
            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count >= 1 Then
                ValidaFolioCargoExtraYPago = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Método que cambia el estado de un folio
    Public Sub CambiaEstadoFolio()
        Try
            strSql = "UPDATE Folio SET estado_folio = '" & estado & "' WHERE id_folio = " & idFolio
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método que actualiza la fecha de un folio
    Public Sub ActualizaFechaFolio()
        Try
            strSql = "UPDATE Folio SET fecha_folio = SYSDATE WHERE id_folio = " & idFolio
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Modo superUsuario, eliminar un folio en cascada
    Public Sub EliminaFolioCascada()
        Try
            strSql = "DELETE Folio WHERE id_folio = " & idFolio & " CASCADE"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método que recaba los datos del folio y los muestra en pantalla -> Label o Txt--
    Public Sub ConsultaDatosBasicosFolio()
        Try
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT fecha_hora_folio, estado_folio, nota_folio, nombre_usuario ||' '|| paterno_usuario ||' '|| materno_usuario AS ""USUARIO"",
                                                    nombre_cliente ||' '|| paterno_cliente ||' '|| materno_cliente AS ""CLIENTE""
                                                    FROM Folio, Reservacion, Usuario, Cliente
                                                    WHERE Folio.id_reservacion = Reservacion.id_reservacion
                                                    AND Folio.id_usuario = Usuario.id_usuario
                                                    AND Reservacion.id_cliente = Cliente.id_cliente
                                                    AND Folio.id_folio = " & FrmAdministracionFolio.idFolio, cnx)

            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmAdministracionFolio.TxtFechaHoraFolio.Text = registro("fecha_hora_folio").ToString
                FrmAdministracionFolio.TxtEstadoFolio.Text = registro("estado_folio").ToString
                FrmNota.TxtNota.Text = registro("estado_folio").ToString
                FrmAdministracionFolio.TxtAtendidoPor.Text = registro("USUARIO").ToString
                FrmAdministracionFolio.TxtNombreCliente.Text = registro("CLIENTE").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Método que recaba la cantidad total de las habitaciones (dia * precio de habitacion)
    Public Sub CantidadTotalHabitaciones()
        Try
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT rh.id_reservacion, SUM(ROUND((rh.check_out_prog - rh.check_in_prog), 2) * h.precio_habitacion) As ""PRECIO TOTAL""	
                                                    FROM Reservacion_has_Habitacion rh, Habitacion h, Reservacion r
                                                    WHERE rh.numero_habitacion = h.numero_habitacion
                                                    AND rh.id_reservacion = r.id_reservacion
                                                    AND rh.id_reservacion = " & FrmAdministracionFolio.idReservacion & "
                                                    AND rh.estado_reservacion <> 'Cancelada'
                                                    GROUP BY rh.id_reservacion", cnx)

            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmAdministracionFolio.precioTotalHabitaciones = registro("PRECIO TOTAL").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Método que recaba la cantidad total de cargos extra
    Public Sub CantidadTotalCargosExtra()
        Try
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT id_folio, SUM(precio_total) As ""CARGO TOTAL""	
                                                    FROM Cargo_extra
                                                    WHERE id_folio = " & FrmAdministracionFolio.idFolio & "
                                                    GROUP BY id_folio", cnx)

            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmAdministracionFolio.precioTotalCargosExtra = registro("CARGO TOTAL").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

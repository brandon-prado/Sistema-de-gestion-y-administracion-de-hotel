Imports Oracle.DataAccess.Client
Public Class Turno
    Private idTurno As Integer
    Private idUsuario As Integer
    Private cantidadInicialCaja As Double
    Private cantidadActualCaja As Double
    Private cantidadCierreCaja As Double
    'Private fechaHoraApetura As String
    'Private fechaHoraCierre As String
    Private notaCaja As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idTurno = 0
        idUsuario = 0
        cantidadInicialCaja = 0.0
        cantidadActualCaja = 0.0
        cantidadCierreCaja = 0.0
        notaCaja = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idTurnoD As Integer, ByVal idUsuarioD As Integer, ByVal cantidadInicialCajaD As Double, ByVal cantidadActualCajaD As Double, ByVal cantidadCierreCajaD As Double, ByVal notaCajaD As String)
        idTurno = idTurnoD
        idUsuario = idUsuarioD
        cantidadInicialCaja = cantidadInicialCajaD
        cantidadActualCaja = cantidadActualCajaD
        cantidadCierreCaja = cantidadCierreCajaD
        notaCaja = notaCajaD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdTurno() As Integer
        Get
            Return idTurno
        End Get
        Set(ByVal Value As Integer)
            idTurno = Value
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

    Public Property GetSetCantidadInicialCaja() As Double
        Get
            Return cantidadInicialCaja
        End Get
        Set(ByVal Value As Double)
            cantidadInicialCaja = Value
        End Set
    End Property

    Public Property GetSetCantidadActualCaja() As Double
        Get
            Return cantidadActualCaja
        End Get
        Set(ByVal Value As Double)
            cantidadActualCaja = Value
        End Set
    End Property

    Public Property GetSetCantidadCierreCaja() As Double
        Get
            Return cantidadCierreCaja
        End Get
        Set(ByVal Value As Double)
            cantidadCierreCaja = Value
        End Set
    End Property

    Public Property GetSetNotaCaja() As String
        Get
            Return notaCaja
        End Get
        Set(ByVal Value As String)
            notaCaja = Value
        End Set
    End Property

    'Funcion que consulta todos los registros de la tabla Turno
    Public Function ConsultaTodosTurnos() As Object
        strSql = "SELECT * FROM Vista_Todos_Turnos"
        ConsultaTodosTurnos = xCnx.objetoDataAdapter(strSql)
    End Function

    'Método que llena el DGV de turno
    Public Sub PoblarDataGridTurno(ByVal DGVTurnos As DataGridView)
        Try
            'Llama a la función ConsultaTodosTurnos para llenar el DGV
            DGVTurnos.DataSource = ConsultaTodosTurnos()
            DGVTurnos.Refresh()
            'Cambiar la anchura de una columna de la tabla del DGV
            'DGVTurnos.Columns.Item(4).Width = 240
        Catch ex As Exception

        End Try

    End Sub

    'Método que inserta un turno
    Public Sub InsertaTurno()
        strSql = "BEGIN Turno_Insertar (" & idUsuario & ", " & cantidadInicialCaja & ", " & cantidadActualCaja & ", " & cantidadCierreCaja & ", SYSDATE, NULL, '" & notaCaja & "'); END;"
        xCnx.objetoCommand(strSql)
    End Sub

    'HAY QUE ACTUALIZAR ESTE METODO PORQUE ESTA MAL EL FIN DE TURNO, EL INICIO SE VUELVE A ACTUALIZAR
    'Y NO NODE ACTUALIZAR
    'Método que actualiza datos de un turno
    Public Sub ActualizarTurno()
        strSql = "BEGIN Turno_Actualizar (" & idTurno & ", " & idUsuario & ", " & cantidadInicialCaja & ", " & cantidadActualCaja & ", " & cantidadCierreCaja & ", SYSDATE, '" & notaCaja & "'); END;"
        xCnx.objetoCommand(strSql)
    End Sub

    'Función que consulta sí existe un turno y regresa un TRUE o FALSE
    Public Function ConsultaUnTurno() As Boolean
        strSql = "SELECT id_turno FROM Turno WHERE id_turno = " & idTurno

        ConsultaUnTurno = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            ConsultaUnTurno = True
        End If
    End Function

    'Función que valida sí un turno tiene dependencias (Sí un egreso depende de un registro de turno)
    Public Function ValidaTurnoConEgreso() As Boolean
        strSql = "SELECT * FROM Egreso WHERE id_turno = " & idTurno
        ValidaTurnoConEgreso = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaTurnoConEgreso = True
        End If
    End Function

    'Método que elimina un turno de la tabla Turno
    Public Sub EliminarTurno()
        strSql = "BEGIN Turno_Eliminar (" & idTurno & "); END;"
        xCnx.objetoCommand(strSql)
    End Sub

    'Metodo para consultar la cantidad de apertura en caja
    Public Sub MostrarCantidadAperturaCaja()
        Try
            'Obtiene la cantidad actual en caja
            Dim xDT As New DataTable
            Dim sql As New OracleDataAdapter("SELECT cantidad_inicial_turno 
                                                    FROM Turno
                                                    WHERE id_turno = " & idTurnoActual, cnx)
            sql.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmTurno.TxtCantidadApertura.Text = Format(Val(registro("cantidad_inicial_turno").ToString), "####,###0.00")
                ModuloGlobal.cantidadFondoEnCaja = Val(registro("cantidad_inicial_turno").ToString)
            Next

            If xDT.Rows.Count = 0 Then
                FrmTurno.TxtCantidadApertura.Text = "0.0"
                ModuloGlobal.cantidadFondoEnCaja = 0.0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Metodo para consultar la cantidad actual en caja
    Public Sub MostrarCantidadActualCaja()
        Try
            'Obtiene la cantidad actual en caja
            Dim xDT As New DataTable
            Dim sql As New OracleDataAdapter("SELECT cantidad_actual_turno 
                                                    FROM Turno
                                                    WHERE id_turno = " & idTurnoActual, cnx)
            sql.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmTurno.TxtCantidadActual.Text = Format(Val(registro("cantidad_actual_turno").ToString), "####,###0.00")
                ModuloGlobal.cantidadActualEnCaja = Val(registro("cantidad_actual_turno").ToString)
            Next

            If xDT.Rows.Count = 0 Then
                FrmTurno.TxtCantidadActual.Text = "0.0"
                ModuloGlobal.cantidadActualEnCaja = 0.0
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Función que valida sí hay egresos registrados en el turno
    Public Function ValidaEgresosEnTurno() As Boolean
        Dim xDT As New DataTable
        ValidaEgresosEnTurno = False
        Try
            strSql = "SELECT id_egreso FROM Egreso WHERE id_turno = " & idTurnoActual

            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count >= 1 Then
                ValidaEgresosEnTurno = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Metodo para consultar la cantidad de retiro en caja
    Public Sub MostrarCantidadRetiroCaja()
        Try
            If ValidaEgresosEnTurno() = False Then
                FrmTurno.TxtCantidadRetiro.Text = "0"
                ModuloGlobal.cantidadRetiroEnCaja = 0
            End If

            'Obtiene la cantidad retiro en caja
            Dim xDT As New DataTable
            Dim sql As New OracleDataAdapter("SELECT SUM(cantidad_egreso) As ""RETIRO""
                                                    FROM Egreso
                                                    WHERE id_turno = " & idTurnoActual, cnx)
            sql.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmTurno.TxtCantidadRetiro.Text = Format(Val(registro("RETIRO").ToString), "####,###0.00")
                ModuloGlobal.cantidadRetiroEnCaja = Val(registro("RETIRO"))
            Next



        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
    End Sub
End Class

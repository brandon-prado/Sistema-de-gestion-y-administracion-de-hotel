Imports Oracle.DataAccess.Client
Public Class Reservacion
    Private idReservacion As Integer
    Private idUsuario As Integer
    Private idCliente As Integer
    Private notaReservacion As String
    'Private estadoReservacion As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idReservacion = 0
        idUsuario = 0
        idCliente = 0
        notaReservacion = ""
        'estadoReservacion = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idReservacionD As Integer, ByVal idUsuarioD As Integer, ByVal idClienteD As Integer, ByVal notaReservacionD As String)
        idReservacion = idReservacionD
        idUsuario = idUsuarioD
        idCliente = idClienteD
        notaReservacion = notaReservacionD
        'estadoReservacion = estadoReservacionD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdReservacion() As Integer
        Get
            Return idReservacion
        End Get
        Set(ByVal Value As Integer)
            idReservacion = Value
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

    Public Property GetSetIdCliente() As Integer
        Get
            Return idCliente
        End Get
        Set(ByVal Value As Integer)
            idCliente = Value
        End Set
    End Property

    Public Property GetSetNotaReservacion() As String
        Get
            Return notaReservacion
        End Get
        Set(ByVal Value As String)
            notaReservacion = Value
        End Set
    End Property

    'Public Property GetSetEstadoReservacion() As String
    '    Get
    '        Return estadoReservacion
    '    End Get
    '    Set(ByVal Value As String)
    '        estadoReservacion = Value
    '    End Set
    'End Property

    'Método que inserta una Reservacion
    Public Sub InsertaReservacion()
        Try
            strSql = "BEGIN Reservacion_Insertar (" & idUsuario & ", " & idCliente & ", SYSDATE, '" & notaReservacion & "'); End;"
            xCnx.objetoCommand(strSql)

            Dim xDT As New DataTable
            Dim conector As New OracleDataAdapter("SELECT MAX(id_reservacion) FROM Reservacion", cnx)
            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                idReservacion = registro("MAX(id_reservacion)")
            Next

            'Crea automaticamente un folio ligado a la reservacion
            strSql = "BEGIN FolioReserv_Insertar (" & idReservacion & ", " & idUsuario & ", SYSDATE, 'Activo', NULL); End;"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método que actualiza una Reservacion
    Public Sub ActualizaReservacion()
        strSql = "BEGIN Reservacion_Actualizar (" & idReservacion & ", " & idUsuario & ", " & idCliente & ", '" & notaReservacion & "'); End;"
        xCnx.objetoCommand(strSql)
    End Sub

    'Función que consulta sí existe una reservación y regresa un TRUE o FALSE
    Public Function ConsultaUnaReservacion() As Boolean
        strSql = "SELECT id_reservacion FROM Reservacion WHERE id_reservacion = " & idReservacion

        ConsultaUnaReservacion = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            ConsultaUnaReservacion = True
        End If
    End Function

    'Función que valida sí una reservacion tiene dependencias
    Public Function ValidaReservacionConReserHasHab() As Boolean
        strSql = "SELECT * FROM Reservacion_has_Habitacion WHERE id_cliente = " & idCliente
        ValidaReservacionConReserHasHab = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaReservacionConReserHasHab = True
        End If
    End Function

    'Método que elimina una reservacion
    Public Sub EliminarReservacion()
        'Elimina el folio dependiente de la reservacion
        strSql = "DELETE FROM Folio Where id_reservacion = " & idReservacion
        xCnx.objetoCommand(strSql)
        'Ya sin ninguna dependencia, se procede a borrar la reservacion
        strSql = "DELETE FROM Reservacion WHERE id_reservacion = " & idReservacion
        xCnx.objetoCommand(strSql)
    End Sub
End Class

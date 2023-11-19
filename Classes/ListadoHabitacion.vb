Public Class ListadoHabitacion
    Private filtro As String

    'Método constructor vacío
    Public Sub New()
        filtro = ""

    End Sub

    'Método constructor con valores proporcionados al instanciar el objeto 
    Public Sub New(ByVal datoFiltro As String)
        'Aquí datoFiltro los datos
        filtro = datoFiltro
    End Sub

    'Métodos get y set
    Public Property getSetFiltro() As String
        Get
            Return filtro
        End Get
        Set(ByVal Value As String)
            filtro = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODAS LAS HABITACIONES
    Public Function ConsultaTodasHabitaciones() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Todas_Habitaciones"

        ConsultaTodasHabitaciones = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE CONSULTA LAS HABITACIONES DISPONIBLES
    Public Function ConsultaHabitacionesDisponibles() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Habitaciones_Disponibles"

        ConsultaHabitacionesDisponibles = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE CONSULTA LAS HBAITACIONES OCUPADAS
    Public Function ConsultaHabitacionesOcupadas() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Habitaciones_Ocupadas"

        ConsultaHabitacionesOcupadas = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE CONSULTA LAS HABITACIONES QUE ESTAN EN MANTENIMINETO
    Public Function ConsultaHabitacionesMantenimiento() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Habitaciones_Limp"

        ConsultaHabitacionesMantenimiento = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE CONSULTA LAS HABITACIONES QUE ESTAN INAVILITADAS
    Public Function ConsultaHabitacionesInhactivas() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Habitaciones_Inhab"

        ConsultaHabitacionesInhactivas = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO USUARIO POR MEDIO DEL MÉTODO QUE CONSULTA LOS DATOS DE ACUERDO AL FILTRO    Public Sub PoblarDataGridUsuarios(ByVal DGVUsuarios As DataGridView)
    Public Sub PoblarDataGridHabiraciones(ByVal DGVUsuarios As DataGridView)
        If filtro.ToString = "TODAS" Then
            DGVUsuarios.DataSource = ConsultaTodasHabitaciones()
            DGVUsuarios.Columns(1).Visible = False
            DGVUsuarios.Refresh()
        ElseIf filtro.ToString = "DISPONIBLES" Then
            DGVUsuarios.DataSource = ConsultaHabitacionesDisponibles()
            DGVUsuarios.Refresh()
        ElseIf filtro.ToString = "OCUPADAS" Then
            DGVUsuarios.DataSource = ConsultaHabitacionesOcupadas()
            DGVUsuarios.Refresh()
        ElseIf filtro.ToString = "MANTENIMIENTO" Then
            DGVUsuarios.DataSource = ConsultaHabitacionesMantenimiento()
            DGVUsuarios.Refresh()
        ElseIf filtro.ToString = "INACTIVA" Then
            DGVUsuarios.DataSource = ConsultaHabitacionesInhactivas()
            DGVUsuarios.Refresh()
        End If
        'DGVUsuarios.Columns.Item(0).Width = 135
        'DGVUsuarios.Columns.Item(1).Width = 98
    End Sub
End Class

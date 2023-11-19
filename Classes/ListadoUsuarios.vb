Public Class ListadoUsuarios
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

    'MÉTODO QUE CONSULTA TODOS LOS USUARIOS
    Public Function ConsultaTodosUsuarios() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Todos_Usuarios"

        ConsultaTodosUsuarios = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA USUARIOS QUE TIENEN ACCESO AL SISTEMA
    Public Function ConsultaUsuariosConAcceso() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Usuarios_Acceso"

        ConsultaUsuariosConAcceso = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA USUARIOS QUE NO TIENEN ACCESO AL SISTEMA
    Public Function ConsultaUsuariosSinAcceso() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Usuarios_SinAcceso"

        ConsultaUsuariosSinAcceso = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE CONSULTA TODOS LOS DATOS DE LA TABLA USUARIOS QUE NO TIENEN ACCESO AL SISTEMA
    Public Function ConsultaUsuariosInactivos() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Usuarios_Desactivados"

        ConsultaUsuariosInactivos = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO USUARIO POR MEDIO DEL MÉTODO QUE CONSULTA LOS DATOS DE ACUERDO AL FILTRO    Public Sub PoblarDataGridUsuarios(ByVal DGVUsuarios As DataGridView)
    Public Sub PoblarDataGridUsuarios(ByVal DGVUsuarios As DataGridView)
        If filtro.ToString = "TODO" Then
            DGVUsuarios.DataSource = ConsultaTodosUsuarios()
            DGVUsuarios.Refresh()
        ElseIf filtro.ToString = "ACCESO" Then
            DGVUsuarios.DataSource = ConsultaUsuariosConAcceso()
            DGVUsuarios.Refresh()
        ElseIf filtro.ToString = "NOACCESO" Then
            DGVUsuarios.DataSource = ConsultaUsuariosSinAcceso()
            DGVUsuarios.Refresh()
        ElseIf filtro.ToString = "INACTIVO" Then
            DGVUsuarios.DataSource = ConsultaUsuariosInactivos()
            DGVUsuarios.Refresh()
        End If
        'DGVUsuarios.Columns.Item(0).Width = 135
        'DGVUsuarios.Columns.Item(1).Width = 98
    End Sub

End Class

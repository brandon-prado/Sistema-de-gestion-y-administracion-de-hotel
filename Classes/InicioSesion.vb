Public Class InicioSesion
    'VARIABLES UTILIZADAS EN INICIO DE SESIÓN
    Private usuario As String
    Private contrasena As String
    'VARIABLES UTILIZADAS PARA LAS CONSULTAS A LA BD
    Private strSQL As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacio
    Public Sub New()
        usuario = ""
        contrasena = ""
    End Sub

    'Constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal usuarioD As String, ByVal contrasenaD As String)
        'Aquí recibimos los datos
        usuario = usuarioD
        contrasena = contrasenaD
    End Sub

    'Métodos get y set para iniciar sesión
    Public Property GetSetUser() As String
        Get
            Return usuario
        End Get
        Set(ByVal Value As String)
            usuario = Value
        End Set
    End Property

    Public Property GetSetContrasena() As String
        Get
            Return contrasena
        End Get
        Set(ByVal Value As String)
            contrasena = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA EL USUARIO INGRESADO Y COMPRUEBA SI EXISTE O NO
    Public Function ConsultaUsuario() As Boolean
        ConsultaUsuario = False
        Try
            strSQL = "SELECT usuario FROM Usuario WHERE usuario = '" & usuario & "'"


            xDT = xCnx.objetoDataAdapter(strSQL)
            If xDT.Rows.Count = 1 Then
                ConsultaUsuario = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'MÉTODO QUE CONSULTA EL USUARIO Y CONTRASEÑA INGRESADO Y COMPRUEBA SI ESTAN CORRECTOS
    Public Function ConsultaUsuarioContrasena() As Boolean
        strSQL = "SELECT usuario, contrasena FROM Usuario " &
                 "WHERE usuario = '" & usuario & "' " &
                 "AND contrasena = '" & contrasena & "'"

        ConsultaUsuarioContrasena = False
        Try
            xDT = xCnx.objetoDataAdapter(strSQL)
            If xDT.Rows.Count = 1 Then
                ConsultaUsuarioContrasena = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'MÉTODO QUE CONSULTA EL USUARIO ESTA ACTIVO
    Public Function ConsultaSiEstaActivo() As Boolean
        strSQL = "SELECT usuario FROM Usuario WHERE estado_usuario = 'Activo' AND usuario = '" & usuario & "'"

        ConsultaSiEstaActivo = False
        Try
            xDT = xCnx.objetoDataAdapter(strSQL)
            If xDT.Rows.Count = 1 Then
                ConsultaSiEstaActivo = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'MÉTODO QUE CONSULTA EL USUARIO si tiene acceso o no al sistema
    Public Function ConsultaSiTieneAcceso() As Boolean
        strSQL = "SELECT usuario FROM Usuario WHERE tiene_acceso_sistema = 'Si' AND usuario = '" & usuario & "'"

        ConsultaSiTieneAcceso = False
        Try
            xDT = xCnx.objetoDataAdapter(strSQL)
            If xDT.Rows.Count = 1 Then
                ConsultaSiTieneAcceso = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'MÉTODO QUE CONSULTA EL USUARIO si el usuario por medio de la autorizacion es administrador o lider
    Public Function ConsultaSiTieneAccesoAdmin() As Boolean
        strSQL = "SELECT u.nombre_usuario, r.nombre_rol FROM Usuario u, Rol r WHERE u.id_rol = r.id_rol AND r.nombre_rol = 'Administrador' AND u.usuario = '" & usuario & "'"

        ConsultaSiTieneAccesoAdmin = False
        Try
            xDT = xCnx.objetoDataAdapter(strSQL)
            If xDT.Rows.Count = 1 Then
                ConsultaSiTieneAccesoAdmin = True
            End If
        Catch ex As Exception

        End Try

    End Function
    Public Function ConsultaSiTieneAccesoEncarg() As Boolean
        strSQL = "SELECT u.nombre_usuario, r.nombre_rol FROM Usuario u, Rol r WHERE u.id_rol = r.id_rol AND r.nombre_rol = 'Encargado' AND u.usuario = '" & usuario & "'"

        ConsultaSiTieneAccesoEncarg = False
        Try
            xDT = xCnx.objetoDataAdapter(strSQL)
            If xDT.Rows.Count = 1 Then
                ConsultaSiTieneAccesoEncarg = True
            End If
        Catch ex As Exception

        End Try

    End Function

End Class


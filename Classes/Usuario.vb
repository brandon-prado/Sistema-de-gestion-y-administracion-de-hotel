Imports Oracle.DataAccess.Client

Public Class Usuario
    Private idUsuario As Integer
    Private idGenero As Integer
    Private idRol As Integer
    Private nombreUsuario As String
    Private paternoUsuario As String
    Private maternoUsuario As String
    Private telefonoUsuario As String
    Private identificacionUsuario As String
    Private direccionUsuario As String
    'Private fechaIngresoUsuario As String
    Private accesoSistemaUsuario As String
    Private usuario As String
    Private contrasena As String
    Private estadoUsuario As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idUsuario = 0
        idGenero = 0
        idRol = 0
        nombreUsuario = ""
        paternoUsuario = ""
        maternoUsuario = ""
        telefonoUsuario = ""
        identificacionUsuario = ""
        direccionUsuario = ""
        'fechaIngresoUsuario = ""
        accesoSistemaUsuario = ""
        usuario = ""
        contrasena = ""
        estadoUsuario = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idUsuarioD As Integer, ByVal idGeneroD As Integer, ByVal idRolD As Integer, ByVal nombreUsuarioD As String, ByVal paternoUsuarioD As String, ByVal maternoUsuarioD As String, ByVal telefonoUsuarioD As String, ByVal identificacionUsuarioD As String, ByVal direccionUsuarioD As String, ByVal accesoSistemaUsuarioD As String, ByVal usuarioD As String, ByVal contrasenaD As String, ByVal estadoUsuarioD As String)
        idUsuario = idUsuarioD
        idGenero = idGeneroD
        idRol = idRolD
        nombreUsuario = nombreUsuarioD
        paternoUsuario = paternoUsuarioD
        maternoUsuario = maternoUsuarioD
        telefonoUsuario = telefonoUsuarioD
        identificacionUsuario = identificacionUsuarioD
        direccionUsuario = direccionUsuarioD
        'fechaIngresoUsuario = fechaIngresoUsuarioD
        accesoSistemaUsuario = accesoSistemaUsuarioD
        usuario = usuarioD
        contrasena = contrasenaD
        estadoUsuario = estadoUsuarioD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdUsuario() As Integer
        Get
            Return idUsuario
        End Get
        Set(ByVal Value As Integer)
            idUsuario = Value
        End Set
    End Property

    Public Property GetSetIdRol() As Integer
        Get
            Return idRol
        End Get
        Set(ByVal Value As Integer)
            idRol = Value
        End Set
    End Property

    Public Property GetSetIdGenero() As Integer
        Get
            Return idGenero
        End Get
        Set(ByVal Value As Integer)
            idGenero = Value
        End Set
    End Property

    Public Property GetSetNombreUsuario() As String
        Get
            Return nombreUsuario
        End Get
        Set(ByVal Value As String)
            nombreUsuario = Value
        End Set
    End Property

    Public Property GetSetPaternoUsuario() As String
        Get
            Return paternoUsuario
        End Get
        Set(ByVal Value As String)
            paternoUsuario = Value
        End Set
    End Property

    Public Property GetSetMaternoUsuario() As String
        Get
            Return maternoUsuario
        End Get
        Set(ByVal Value As String)
            maternoUsuario = Value
        End Set
    End Property

    Public Property GetSetTelefonoUsuario() As String
        Get
            Return telefonoUsuario
        End Get
        Set(ByVal Value As String)
            telefonoUsuario = Value
        End Set
    End Property

    Public Property GetSetIdentificacionUsuario() As String
        Get
            Return identificacionUsuario
        End Get
        Set(ByVal Value As String)
            identificacionUsuario = Value
        End Set
    End Property

    Public Property GetSetDireccionUsuario() As String
        Get
            Return direccionUsuario
        End Get
        Set(ByVal Value As String)
            direccionUsuario = Value
        End Set
    End Property

    'Public Property GetSetFechaIngresoUsuario() As String
    '    Get
    '        Return fechaIngresoUsuario
    '    End Get
    '    Set(ByVal Value As String)
    '        fechaIngresoUsuario = Value
    '    End Set
    'End Property

    Public Property GetSetAccesoSistemaUsuario() As String
        Get
            Return accesoSistemaUsuario
        End Get
        Set(ByVal Value As String)
            accesoSistemaUsuario = Value
        End Set
    End Property

    Public Property GetSetUsuario() As String
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

    Public Property GetSetEstadoUsuario() As String
        Get
            Return estadoUsuario
        End Get
        Set(ByVal Value As String)
            estadoUsuario = Value
        End Set
    End Property

    'Funcion que consulta todos los registros de la tabla Usuario
    Public Function ConsultaTodosUsuarios() As Object
        strSql = "SELECT * FROM Vista_Todos_Usuarios"
        ConsultaTodosUsuarios = xCnx.objetoDataAdapter(strSql)
    End Function

    'Método que llena el DGV de usuario
    Public Sub PoblarDataGridUsuario(ByVal DGVUsuarios As DataGridView)
        'Llama a la función ConsultaTodo para llenar el DGV
        DGVUsuarios.DataSource = ConsultaTodosUsuarios()
        DGVUsuarios.Refresh()
        'Cambiar la anchura de una columna de la tabla del DGV
        'DGUsuarios.Columns.Item(4).Width = 240
    End Sub

    'Método que inserta un usuario
    Public Sub InsertaUsuario()
        strSql = "BEGIN Usuario_Insertar (" & idGenero & ", " & idRol & ", '" & nombreUsuario & "', '" &
                            paternoUsuario & "', '" & maternoUsuario & "', '" & telefonoUsuario & "', '" &
                            identificacionUsuario & "', '" & direccionUsuario & "', SYSDATE, '" & accesoSistemaUsuario & "', '" &
                            usuario & "', '" & contrasena & "', '" & estadoUsuario & "'); End;"
        xCnx.objetoCommand(strSql)
        FrmListadoUsuarios.ActualizarDGV()
    End Sub

    'Método que actualiza datos de un usuario
    Public Sub ActualizarUsuario()
        strSql = "BEGIN Usuario_Actualizar (" & idUsuario & ", " & idGenero & ", " & idRol & ", '" & nombreUsuario & "', '" &
                            paternoUsuario & "', '" & maternoUsuario & "', '" & telefonoUsuario & "', '" &
                            identificacionUsuario & "', '" & direccionUsuario & "', '" & accesoSistemaUsuario & "', '" &
                            usuario & "', '" & contrasena & "', '" & estadoUsuario & "'); End;"

        xCnx.objetoCommand(strSql)
        FrmListadoUsuarios.ActualizarDGV()
    End Sub

    'Función que consulta sí existe un usuario y regresa un TRUE o FALSE
    Public Function ConsultaUnUsuario() As Boolean
        strSql = "SELECT id_usuario FROM Usuario WHERE id_usuario = " & idUsuario

        ConsultaUnUsuario = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            ConsultaUnUsuario = True
        End If
    End Function

    'Función que valida sí un usuario tiene dependencias (Sí una reservacion, folio o turno depende de un registro de usuario)
    Public Function ValidaUsuarioReservFolTurno() As Boolean
        strSql = "SELECT * FROM Reservacion WHERE id_usuario = " & idUsuario
        ValidaUsuarioReservFolTurno = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaUsuarioReservFolTurno = True
        End If

        strSql = "SELECT * FROM Folio WHERE id_usuario = " & idUsuario
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaUsuarioReservFolTurno = True
        End If

        strSql = "SELECT * FROM Turno WHERE id_usuario = " & idUsuario
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaUsuarioReservFolTurno = True
        End If
    End Function

    'Función que valida sí un usuario que se va a ***INSERTAR*** no tenga el mismo telefono que otro registro
    Public Function ValidaTelefUsuarioInsertar() As Boolean
        strSql = "SELECT * FROM Usuario WHERE telefono_usuario = '" & telefonoUsuario & "'"
        ValidaTelefUsuarioInsertar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaTelefUsuarioInsertar = True
        End If
    End Function

    'Función que valida sí un usuario que se va a ***ACTUALIZAR*** no tenga el mismo telefono que otro registro
    Public Function ValidaTelefUsuarioActualizar() As Boolean
        strSql = "SELECT * FROM Usuario WHERE telefono_usuario = '" & telefonoUsuario & "' AND id_usuario = " & idUsuario
        ValidaTelefUsuarioActualizar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaTelefUsuarioActualizar = True
        End If
    End Function

    'Función que valida sí un usuario que se va a ***INSERTAR*** no tenga la misma identificacion que otro registro
    Public Function ValidaIdentUsuarioInsertar() As Boolean
        strSql = "SELECT * FROM Usuario WHERE identificacion_usuario = '" & identificacionUsuario & "'"
        ValidaIdentUsuarioInsertar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaIdentUsuarioInsertar = True
        End If
    End Function

    'Función que valida sí un usuario que se va a ***ACTUALIZAR*** no tenga la misma identificacion que otro registro
    Public Function ValidaIdentUsuarioActualizar() As Boolean
        strSql = "SELECT * FROM Usuario WHERE identificacion_usuario = '" & identificacionUsuario & "' AND id_usuario = " & idUsuario
        ValidaIdentUsuarioActualizar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaIdentUsuarioActualizar = True
        End If
    End Function

    'Función que valida sí un usuario que se va a ***INSERTAR*** no tenga el mismo user que otro registro
    Public Function ValidaUserUsuarioInsertar() As Boolean
        strSql = "SELECT * FROM Usuario WHERE usuario = '" & usuario & "'"
        ValidaUserUsuarioInsertar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaUserUsuarioInsertar = True
        End If
    End Function

    'Función que valida sí un usuario que se va a ***ACTUALIZAR*** no tenga el mismo user que otro registro
    Public Function ValidaUserUsuarioActualizar() As Boolean
        strSql = "SELECT * FROM Usuario WHERE usuario = '" & usuario & "' AND id_usuario = " & idUsuario
        ValidaUserUsuarioActualizar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaUserUsuarioActualizar = True
        End If
    End Function

    'Método que elimina un usuario
    Public Sub EliminarUsuario()
        strSql = "BEGIN Usuario_Eliminar (" & idUsuario & "); END;"
        xCnx.objetoCommand(strSql)
        FrmListadoUsuarios.ActualizarDGV()
    End Sub

    'Método para poblar el ComboBox de Géneros en el Formulario de Usuario
    Public Sub PoblarComboBoxGenero()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter
        Try
            strSql = "SELECT nombre_genero FROM Genero ORDER BY nombre_genero"
            conector = New OracleDataAdapter(strSql, cnx)

            conector.Fill(xDT)
            With FrmAdministracionUsuarios.CBGenero
                .DataSource = xDT
                .DisplayMember = "id_genero"
                .ValueMember = "nombre_genero"
            End With
        Catch ex As Exception

        End Try

    End Sub

    'Método para poblar el ComboBox de Roles en el Formulario de Usuario
    Public Sub PoblarComboBoxRoles()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter
        Try
            strSql = "SELECT nombre_rol FROM Rol ORDER BY nombre_rol"
            conector = New OracleDataAdapter(strSql, cnx)

            conector.Fill(xDT)
            With FrmAdministracionUsuarios.CBRol
                .DataSource = xDT
                .DisplayMember = "id_rol"
                .ValueMember = "nombre_rol"
            End With
        Catch ex As Exception

        End Try

    End Sub

    'Método para saber que ID le pertenece cada género seleccionado desde el CB 
    Public Sub IdSeleccionadoEnCBGenero()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter
        Try
            strSql = "SELECT id_genero FROM Genero WHERE nombre_genero = '" & FrmAdministracionUsuarios.CBGenero.SelectedValue.ToString & "'"
            conector = New OracleDataAdapter(strSql, cnx)
            conector.Fill(xDT)

            For Each registro As DataRow In xDT.Rows
                FrmAdministracionUsuarios.idGenero = registro("id_genero").ToString
            Next
        Catch ex As Exception

        End Try

    End Sub

    'Método para saber que ID le pertenece cada rol seleccionado desde el CB 
    Public Sub IdSeleccionadoEnCBRol()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter
        Try
            strSql = "SELECT id_rol FROM Rol WHERE nombre_rol = '" & FrmAdministracionUsuarios.CBRol.SelectedValue.ToString & "'"
            conector = New OracleDataAdapter(strSql, cnx)
            conector.Fill(xDT)

            For Each registro As DataRow In xDT.Rows
                FrmAdministracionUsuarios.idRol = registro("id_rol").ToString
            Next
        Catch ex As Exception

        End Try

    End Sub
End Class

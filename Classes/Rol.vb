Imports Oracle.DataAccess.Client
Public Class Rol
    Private idRol As Integer
    Private idPermiso As Integer
    Private nombreRol As String
    Private descripcionRol As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idRol = 0
        idPermiso = 0
        nombreRol = ""
        descripcionRol = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idRolD As Integer, ByVal idPermisoD As Integer, ByVal nombreRolD As String, ByVal descripcionRolD As String)
        idRol = idRolD
        idPermiso = idPermisoD
        nombreRol = nombreRolD
        descripcionRol = descripcionRolD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdRol() As Integer
        Get
            Return idRol
        End Get
        Set(ByVal Value As Integer)
            idRol = Value
        End Set
    End Property

    Public Property GetSetIdPermiso() As Integer
        Get
            Return idPermiso
        End Get
        Set(ByVal Value As Integer)
            idPermiso = Value
        End Set
    End Property

    Public Property GetSetNombreRol() As String
        Get
            Return nombreRol
        End Get
        Set(ByVal Value As String)
            nombreRol = Value
        End Set
    End Property

    Public Property GetSetDescripcionRol() As String
        Get
            Return descripcionRol
        End Get
        Set(ByVal Value As String)
            descripcionRol = Value
        End Set
    End Property

    'Funcion que consulta todos los registros de la tabla Rol
    Public Function ConsultaTodosRoles() As Object
        strSql = "SELECT * FROM Vista_Todos_Roles"
        ConsultaTodosRoles = xCnx.objetoDataAdapter(strSql)
    End Function

    'Método que llena el DGV de rol
    Public Sub PoblarDataGridRol(ByVal DGVRoles As DataGridView)
        'Llama a la función ConsultaTodosRoles para llenar el DGV
        DGVRoles.DataSource = ConsultaTodosRoles()
        DGVRoles.Refresh()
        'Cambiar la anchura de una columna de la tabla del DGV
        DGVRoles.Columns.Item(4).Width = 240
    End Sub

    'Método que inserta un rol
    Public Sub InsertaRol()
        strSql = "BEGIN Rol_Insertar (" & idPermiso & ", '" & nombreRol & "', '" & descripcionRol & "'); END;"
        'strSql = "INSERT INTO Rol (id_permiso, nombre_rol, descripcion_rol) VALUES (" & idPermiso & ", '" & nombreRol & "', '" & descripcionRol & "')"
        xCnx.objetoCommand(strSql)
        'Recarga los cambios realizados para los formularios abiertos
        ModuloGlobal.RecargarCBRol()
    End Sub

    'Método que actualiza datos de un rol
    Public Sub ActualizarRol()
        strSql = "BEGIN Rol_Actualizar (" & idRol & ", " & idPermiso & ", '" & nombreRol & "', '" & descripcionRol & "'); END;"
        'strSql = "UPDATE Rol SET id_permiso = " & idPermiso & ", nombre_rol = '" & nombreRol & "', descripcion_rol = '" & descripcionRol & "' WHERE id_rol = " & idRol
        xCnx.objetoCommand(strSql)
        'Recarga los cambios realizados para los formularios abiertos
        ModuloGlobal.RecargarCBRol()
    End Sub

    'Función que consulta sí existe un rol y regresa un TRUE o FALSE
    Public Function ConsultaUnRol() As Boolean
        strSql = "SELECT id_rol FROM Rol WHERE id_rol = " & idRol

        ConsultaUnRol = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            ConsultaUnRol = True
        End If
    End Function

    'Función que valida sí un rol tiene dependencias (Sí un usuario depende de un registro de rol)
    Public Function ValidaRolConUsuario() As Boolean
        strSql = "SELECT * FROM Usuario WHERE id_rol = " & idRol
        ValidaRolConUsuario = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaRolConUsuario = True
        End If
    End Function

    'Función que valida sí un ROL que se va a ***INSERTAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombreRolInsertar() As Boolean
        strSql = "SELECT * FROM Rol WHERE nombre_rol = '" & nombreRol & "'"
        ValidaNombreRolInsertar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaNombreRolInsertar = True
        End If
    End Function

    'Función que valida sí un ROL que se va a ***ACTUALIZAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombreRolActualizar() As Boolean
        strSql = "SELECT * FROM Rol WHERE nombre_rol = '" & nombreRol & "' AND id_rol = " & idRol
        ValidaNombreRolActualizar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaNombreRolActualizar = True
        End If
    End Function

    'Método que elimina un rol de la tabla Rol
    Public Sub EliminarRol()
        strSql = "BEGIN Rol_Eliminar (" & idRol & "); END;"
        'strSql = "DELETE FROM Rol WHERE id_rol = " & idRol
        xCnx.objetoCommand(strSql)
        'Recarga los cambios realizados para los formularios abiertos
        ModuloGlobal.RecargarCBRol()
    End Sub

    'Método para poblar el ComboBox de Permisos en el Formulario de Rol
    Public Sub PoblarComboBoxPermiso()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT nivel_permiso FROM Permiso ORDER BY nivel_permiso"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With FrmRol.CBNivelPermiso
            .DataSource = xDT
            .DisplayMember = "id_permiso"
            .ValueMember = "nivel_permiso"
        End With
    End Sub

    'Método para saber que ID le pertenece cada nivel de permiso seleccionado desde el CB de la tabla Permiso
    Public Sub IdSeleccionadoEnCB()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter
        Try
            strSql = "SELECT id_permiso FROM Permiso WHERE nivel_permiso = '" & FrmRol.CBNivelPermiso.SelectedValue.ToString & "'"
            conector = New OracleDataAdapter(strSql, cnx)
            conector.Fill(xDT)

            For Each registro As DataRow In xDT.Rows
                FrmRol.idPermiso = registro("id_permiso").ToString
            Next
        Catch ex As Exception

        End Try

    End Sub
End Class

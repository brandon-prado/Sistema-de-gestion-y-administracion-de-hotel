Public Class Permiso
    Private idPermiso As Integer
    Private nivelPermiso As String
    Private descripcionPermiso As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idPermiso = 0
        nivelPermiso = ""
        descripcionPermiso = ""
    End Sub

    'Constructor cargado on parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idPermisoD As Integer, ByVal nivelPermisoD As String, ByVal descripcionPermisoD As String)
        idPermiso = idPermisoD
        nivelPermiso = nivelPermisoD
        descripcionPermiso = descripcionPermisoD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdPermiso() As Integer
        Get
            Return idPermiso
        End Get
        Set(ByVal Value As Integer)
            idPermiso = Value
        End Set
    End Property

    Public Property GetSetNivelPermiso() As String
        Get
            Return nivelPermiso
        End Get
        Set(ByVal Value As String)
            nivelPermiso = Value
        End Set
    End Property

    Public Property GetSetDescripcionPermiso() As String
        Get
            Return descripcionPermiso
        End Get
        Set(ByVal Value As String)
            descripcionPermiso = Value
        End Set
    End Property

    'Funcion que consulta todos los registros de la tabla Permiso
    Public Function ConsultaTodosPermisos() As Object
        strSql = "SELECT * FROM Vista_Todos_Permisos"
        ConsultaTodosPermisos = xCnx.objetoDataAdapter(strSql)
    End Function

    'Método que llena el DGV de permisos
    Public Sub PoblarDataGridPermiso(ByVal DGVPermisos As DataGridView)
        'Llama a la función ConsultaTodosPermisos para llenar el DGV
        DGVPermisos.DataSource = ConsultaTodosPermisos()
        DGVPermisos.Refresh()
        'Cambiar la anchura de una columna de la tabla del DGV
        DGVPermisos.Columns.Item(2).Width = 290
    End Sub

    'Método que inserta un permiso
    Public Sub InsertaPermiso()
        strSql = "BEGIN Permiso_Insertar ('" & nivelPermiso & "', '" & descripcionPermiso & "'); END;"
        xCnx.objetoCommand(strSql)
        'Recarga los cambios realizados para los formularios abiertos
        ModuloGlobal.RecargarCBPermiso()
    End Sub

    'Método que actualiza datos de un permiso
    Public Sub ActualizarPermiso()
        strSql = "BEGIN Permiso_Actualizar (" & idPermiso & ", '" & nivelPermiso & "', '" & descripcionPermiso & "'); END;"
        xCnx.objetoCommand(strSql)
        'Recarga los cambios realizados para los formularios abiertos
        ModuloGlobal.RecargarCBPermiso()
    End Sub

    'Función que consulta sí existe un permiso y regresa un TRUE o FALSE
    Public Function ConsultaUnPermiso() As Boolean
        strSql = "SELECT id_permiso FROM Permiso WHERE id_permiso = " & idPermiso

        ConsultaUnPermiso = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            ConsultaUnPermiso = True
        End If
    End Function

    'Función que valida sí un permiso tiene dependencias (Sí un rol depende de un registro de permiso)
    Public Function ValidaPermisoConRol() As Boolean
        strSql = "SELECT * FROM Rol WHERE id_permiso = " & idPermiso
        ValidaPermisoConRol = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaPermisoConRol = True
        End If
    End Function

    'Función que valida sí un PERMISO que se va a ***INSERTAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombrePermisoInsertar() As Boolean
        strSql = "SELECT * FROM Permiso WHERE nivel_permiso = '" & nivelPermiso & "'"
        ValidaNombrePermisoInsertar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaNombrePermisoInsertar = True
        End If
    End Function

    'Función que valida sí un PERMISO que se va a ***ACTUALIZAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombrePermisoActualizar() As Boolean
        strSql = "SELECT * FROM Permiso WHERE nivel_permiso = '" & nivelPermiso & "' AND id_permiso = " & idPermiso
        ValidaNombrePermisoActualizar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaNombrePermisoActualizar = True
        End If
    End Function

    'Método que elimina un registro de la tabla Permiso
    Public Sub EliminarPermiso()
        strSql = "BEGIN Permiso_Eliminar (" & idPermiso & "); END;"
        xCnx.objetoCommand(strSql)
        'Recarga los cambios realizados para los formularios abiertos
        ModuloGlobal.RecargarCBPermiso()
    End Sub
End Class


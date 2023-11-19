Public Class TipoHabitacion
    Private idTipoHab As Integer
    Private nomTipoHab As String
    Private desTipoHab As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idTipoHab = 0
        nomTipoHab = ""
        desTipoHab = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idTipoHabD As Integer, ByVal nomTipoHabD As String, ByVal desTipoHabD As String)
        idTipoHab = idTipoHabD
        nomTipoHab = nomTipoHabD
        desTipoHab = desTipoHabD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdTipoHab() As Integer
        Get
            Return idTipoHab
        End Get
        Set(value As Integer)
            idTipoHab = value
        End Set
    End Property

    Public Property GetSetNomTipoHab() As String
        Get
            Return nomTipoHab
        End Get
        Set(value As String)
            nomTipoHab = value
        End Set
    End Property

    Public Property GetSetDesTipoHab() As String
        Get
            Return desTipoHab
        End Get
        Set(value As String)
            desTipoHab = value
        End Set
    End Property

    'Funcion que consulta todos los registros de la tabla Tipo_Habitacion
    Public Function ConsultaTodoTipoHabitacion() As Object
        strSql = "SELECT * FROM Vista_Tipo_Habitacion"
        ConsultaTodoTipoHabitacion = xCnx.objetoDataAdapter(strSql)
    End Function

    'Método que llena el DGV de tipo de habitacion
    Public Sub PoblarDataGridTipoHabitacion(ByVal DGVTipoHabitacion As DataGridView)
        'Llama a la función ConsultaTodoTipoHabitacion para llenar el DGV
        DGVTipoHabitacion.DataSource = ConsultaTodoTipoHabitacion()
        DGVTipoHabitacion.Refresh()
    End Sub

    'Método que inserta un tipo de habitacion
    Public Sub InsertarTipoHabitacion()
        strSql = "BEGIN Tipo_Habitacion_Insertar ('" & nomTipoHab & "', '" & desTipoHab & "'); End;"
        xCnx.objetoCommand(strSql)
    End Sub

    'Método que actualiza un tipo de habitacion
    Public Sub ActualizarTipoHabitacion()
        strSql = "BEGIN Tipo_Habitacion_Actualizar (" & idTipoHab & ", '" & nomTipoHab & "', '" & desTipoHab & "'); End;"
        xCnx.objetoCommand(strSql)
    End Sub

    'Metodo que comprueba si existe un tipo de habitacion y regresa un TRUE o FALSE
    Public Function ConsultaTipoHab() As Boolean
        strSql = "SELECT id_tipo_hab FROM Tipo_Habitacion WHERE id_tipo_hab = " & idTipoHab

        ConsultaTipoHab = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            ConsultaTipoHab = True
        End If
    End Function

    'Funcion que valida si un tipo de habitacion tine dependencias
    Public Function ValidaTipoHab() As Boolean
        strSql = "SELECT * FROM Habitacion WHERE id_tipo_hab = " & idTipoHab
        ValidaTipoHab = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaTipoHab = True
        End If
    End Function

    'Función que valida sí un TIPO DE HABITACIÓN que se va a ***INSERTAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombreTipHabInsertar() As Boolean
        strSql = "SELECT * FROM Tipo_Habitacion WHERE nombre_tipo_hab = '" & nomTipoHab & "'"
        ValidaNombreTipHabInsertar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaNombreTipHabInsertar = True
        End If
    End Function

    'Función que valida sí un TIPO DE HABITACIÓN que se va a ***ACTUALIZAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombreTipHabActualizar() As Boolean
        strSql = "SELECT * FROM Tipo_Habitacion WHERE nombre_tipo_hab = '" & nomTipoHab & "' AND id_tipo_hab = " & idTipoHab
        ValidaNombreTipHabActualizar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaNombreTipHabActualizar = True
        End If
    End Function

    'Método que elimina un tipo de habitacion
    Public Sub EliminarTipoHabitacion()
        strSql = "BEGIN Tipo_Habitacion_Eliminar (" & idTipoHab & "); END;"
        xCnx.objetoCommand(strSql)
    End Sub
End Class

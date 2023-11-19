Public Class Genero
    Private idGenero As Integer
    Private nombreGenero As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Public Sub New()
        idGenero = 0
        nombreGenero = ""
    End Sub

    Public Sub New(ByVal idGeneroD As Integer, ByVal nombreGeneroD As String)
        idGenero = idGeneroD
        nombreGenero = nombreGeneroD
    End Sub

    Public Property GetSetIdGenero() As Integer
        Get
            Return idGenero
        End Get
        Set(ByVal Value As Integer)
            idGenero = Value
        End Set
    End Property

    Public Property GetSetGenero() As String
        Get
            Return nombreGenero
        End Get
        Set(ByVal Value As String)
            nombreGenero = Value
        End Set
    End Property

    Public Function ConsultaTodosGeneros() As Object
        strSql = "SELECT * FROM Vista_Todos_Generos"
        ConsultaTodosGeneros = xCnx.objetoDataAdapter(strSql)
    End Function

    Public Sub PoblarDataGridGenero(ByVal DGVGeneros As DataGridView)
        DGVGeneros.DataSource = ConsultaTodosGeneros()
        DGVGeneros.Refresh()
        'Cambiar la anchura de una columna de la tabla del DGV
        DGVGeneros.Columns.Item(1).Width = 250
    End Sub

    Public Sub InsertaGenero()
        strSql = "BEGIN Genero_Insertar ('" & nombreGenero & "'); END;"
        xCnx.objetoCommand(strSql)
        'Recarga los cambios realizados para los formularios abiertos
        ModuloGlobal.RecargarCBGenero()
    End Sub

    Public Sub ActualizarGenero()
        strSql = "BEGIN Genero_Actualizar (" & idGenero & ", '" & nombreGenero & "'); END;"
        xCnx.objetoCommand(strSql)
        'Recarga los cambios realizados para los formularios abiertos
        ModuloGlobal.RecargarCBGenero()
    End Sub

    Public Function ConsultaUnGenero() As Boolean
        strSql = "SELECT id_genero FROM Genero WHERE id_genero = " & idGenero

        ConsultaUnGenero = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count = 1 Then
            ConsultaUnGenero = True
        End If
    End Function

    Public Function ValidaGeneroUsuarioCliente() As Boolean
        strSql = "SELECT * FROM Usuario WHERE id_genero = " & idGenero
        ValidaGeneroUsuarioCliente = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaGeneroUsuarioCliente = True
        End If

        strSql = "SELECT * FROM Cliente WHERE id_genero = " & idGenero
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaGeneroUsuarioCliente = True
        End If
    End Function

    'Función que valida sí un género que se va a ***INSERTAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombreGeneroInsertar() As Boolean
        strSql = "SELECT * FROM Genero WHERE nombre_genero = '" & nombreGenero & "'"
        ValidaNombreGeneroInsertar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaNombreGeneroInsertar = True
        End If
    End Function

    'Función que valida sí un género que se va a ***ACTUALIZAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombreGeneroActualizar() As Boolean
        strSql = "SELECT * FROM Genero WHERE nombre_genero = '" & nombreGenero & "' AND id_genero = " & idGenero
        ValidaNombreGeneroActualizar = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count = 1 Then
            ValidaNombreGeneroActualizar = True
        End If
    End Function

    Public Sub EliminarGenero()
        strSql = "BEGIN Genero_Eliminar (" & idGenero & "); END;"
        xCnx.objetoCommand(strSql)
        'Recarga los cambios realizados para los formularios abiertos
        ModuloGlobal.RecargarCBGenero()
    End Sub
End Class
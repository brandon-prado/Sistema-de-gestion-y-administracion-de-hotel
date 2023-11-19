Public Class MetodoPago
    'VARIABLES UTILIZADAS EN METODO DE PAGO
    Private idMetodo As Integer
    Private nombreMetPago As String
    Private descripcion As String
    'VARIABLES UTILIZADAS PARA LAS CONSULTAS A LA BD
    Private strSQL As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacio
    Public Sub New()
        idMetodo = 0
        nombreMetPago = ""
        descripcion = ""
    End Sub

    'Constructor con valores proporcionados al instanciar el objeto
    Public Sub New(ByVal IdMetodoD As Integer, ByVal nom_Met_PagoD As String, ByVal DescripcionD As String)
        'Aquí recibimos los datos
        idMetodo = IdMetodoD
        nombreMetPago = nom_Met_PagoD
        descripcion = DescripcionD
    End Sub

    'Métodos get y set para iniciar sesión
    Public Property GetSetIdMetodo() As Integer
        Get
            Return idMetodo
        End Get
        Set(ByVal Value As Integer)
            idMetodo = Value
        End Set
    End Property
    Public Property GetSetnomMetPago() As String
        Get
            Return nombreMetPago
        End Get
        Set(ByVal Value As String)
            nombreMetPago = Value
        End Set
    End Property

    Public Property GetSetDescripcion() As String
        Get
            Return descripcion
        End Get
        Set(ByVal Value As String)
            descripcion = Value
        End Set
    End Property

    'MÉTODO QUE CONSULTA TODOS LOS METODOS DE PAGO
    Public Function ConsultaTodosMetPago() As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Todos_Met_Pago"
        ConsultaTodosMetPago = xCnx.objetoDataAdapter(strSQL)
    End Function

    'MÉTODO QUE LLENA DE INFORMACIÓN EL DGV DEL FORMULARIO METODO DE PAGO POR MEDIO DEL MÉTODO CONSULTATODO()
    Public Sub PoblarDataGridMetPgo(ByVal DGVMetPago As DataGridView)
        DGVMetPago.DataSource = ConsultaTodosMetPago()
        DGVMetPago.Refresh()
        'DGVMetPago.Columns.Item(4).Width = 240
        'DGVUsuarios.Columns.Item(0).Width = 135
        'DGVUsuarios.Columns.Item(1).Width = 98
    End Sub

    'MÉTODO QUE INSERTA LOS METODOS DE PAGO
    Public Sub InsertaMetodo()
        strSQL = "BEGIN Metodo_Pago_Insertar ('" & nombreMetPago & "', '" & descripcion & "'); END;"
        xCnx.objetoCommand(strSQL)
    End Sub

    'MÉTODO QUE elimina LOS METODOS DE PAGO
    Public Sub EliminarMetodo()
        strSQL = "BEGIN Metodo_Pago_Eliminar (" & idMetodo & "); END;"
        xCnx.objetoCommand(strSQL)
    End Sub

    'MÉTODO QUE actualiza LOS METODOS DE PAGO
    Public Sub ActualizarMetodo()
        strSQL = "BEGIN Metodo_Pago_Actualizar (" & idMetodo & ", '" & nombreMetPago & "', '" & descripcion & "'); END;"
        xCnx.objetoCommand(strSQL)
    End Sub

    'CONSULTA SI EXISTE UN METODO
    Public Function ConsultaUnMetodo() As Boolean
        strSQL = "SELECT id_Metodo_pago FROM Metodo_pago WHERE id_Metodo_pago = " & IdMetodo

        ConsultaUnMetodo = False
        xDT = xCnx.objetoDataAdapter(strSQL)
        If xDT.Rows.Count = 1 Then
            ConsultaUnMetodo = True
        End If
    End Function

    'Función que valida sí un MÉTODO DE PAGO que se va a ***INSERTAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombreMetPagInsertar() As Boolean
        strSQL = "SELECT * FROM Metodo_Pago WHERE nombre_met_pago = '" & nombreMetPago & "'"
        ValidaNombreMetPagInsertar = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            ValidaNombreMetPagInsertar = True
        End If
    End Function

    'Función que valida sí un MÉTODO DE PAGO que se va a ***ACTUALIZAR*** no tenga el mismo NOMBRE que otro registro
    Public Function ValidaNombreMetPagActualizar() As Boolean
        strSQL = "SELECT * FROM Metodo_Pago WHERE nombre_met_pago = '" & nombreMetPago & "' AND id_metodo_pago = " & idMetodo
        ValidaNombreMetPagActualizar = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count = 1 Then
            ValidaNombreMetPagActualizar = True
        End If
    End Function

    'CONSULTA SI UN METODO DE PAGO TIENE DEPENDENCIAS
    Public Function ValidaMetPagoConPago() As Boolean
        strSQL = "SELECT * FROM Pago WHERE id_metodo_pago = " & idMetodo
        ValidaMetPagoConPago = False
        xDT = xCnx.objetoDataAdapter(strSQL)

        If xDT.Rows.Count >= 1 Then
            ValidaMetPagoConPago = True
        End If
    End Function
End Class

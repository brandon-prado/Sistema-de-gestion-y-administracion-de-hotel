Imports Oracle.DataAccess.Client

Public Class Cliente
    Private idCliente As Integer
    Private idGenero As Integer
    Private nombreCliente As String
    Private paternoCliente As String
    Private maternoCliente As String
    Private telefonoCliente As String
    Private identificacionCliente As String
    Private notaCliente As String
    Private estadoCliente As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idCliente = 0
        idGenero = 0
        nombreCliente = ""
        paternoCliente = ""
        maternoCliente = ""
        telefonoCliente = ""
        identificacionCliente = ""
        notaCliente = ""
        estadoCliente = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idClienteD As Integer, ByVal idGeneroD As Integer, ByVal nombreClienteD As String, ByVal paternoClienteD As String, ByVal MaternoClienteD As String, ByVal telefonoClienteD As String, ByVal identificacionClienteD As String, ByVal notaClienteD As String, ByVal estadoClienteD As String)
        idCliente = idClienteD
        idGenero = idGeneroD
        nombreCliente = nombreClienteD
        paternoCliente = paternoClienteD
        maternoCliente = MaternoClienteD
        telefonoCliente = telefonoClienteD
        identificacionCliente = identificacionClienteD
        notaCliente = notaClienteD
        estadoCliente = estadoClienteD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdCliente() As Integer
        Get
            Return idCliente
        End Get
        Set(ByVal Value As Integer)
            idCliente = Value
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

    Public Property GetSetNombreCliente() As String
        Get
            Return nombreCliente
        End Get
        Set(ByVal Value As String)
            nombreCliente = Value
        End Set
    End Property

    Public Property GetSetPaternoCliente() As String
        Get
            Return paternoCliente
        End Get
        Set(ByVal Value As String)
            paternoCliente = Value
        End Set
    End Property

    Public Property GetSetMaternoCliente() As String
        Get
            Return maternoCliente
        End Get
        Set(ByVal Value As String)
            maternoCliente = Value
        End Set
    End Property

    Public Property GetSetTelefonoCliente() As String
        Get
            Return telefonoCliente
        End Get
        Set(ByVal Value As String)
            telefonoCliente = Value
        End Set
    End Property

    Public Property GetSetIdentificacionCliente() As String
        Get
            Return identificacionCliente
        End Get
        Set(ByVal Value As String)
            identificacionCliente = Value
        End Set
    End Property

    Public Property GetSetNotaCliente() As String
        Get
            Return notaCliente
        End Get
        Set(ByVal Value As String)
            notaCliente = Value
        End Set
    End Property

    Public Property GetSetEstadoCliente() As String
        Get
            Return estadoCliente
        End Get
        Set(ByVal Value As String)
            estadoCliente = Value
        End Set
    End Property

    'Funcion que consulta todos los registros de la tabla Cliente
    Public Function ConsultaTodosClientes() As Object

        strSql = "SELECT * FROM Vista_Todos_Clientes"

            ConsultaTodosClientes = xCnx.objetoDataAdapter(strSql)


    End Function

    'Método que llena el DGV de cliente
    Public Sub PoblarDataGridCliente(ByVal DGVClientes As DataGridView)
        'Llama a la función ConsultaTodo para llenar el DGV
        DGVClientes.DataSource = ConsultaTodosClientes()
        DGVClientes.Refresh()
        'Cambiar la anchura de una columna de la tabla del DGV
        'DGUsuarios.Columns.Item(4).Width = 240
    End Sub

    'Método que inserta un cliente
    Public Sub InsertaCliente()
        Try
            strSql = "BEGIN Cliente_Insertar (" & idGenero & ", '" & nombreCliente & "', '" &
                            paternoCliente & "', '" & maternoCliente & "', '" & telefonoCliente & "', '" &
                            identificacionCliente & "', '" & notaCliente & "', '" & estadoCliente & "'); End;"
            xCnx.objetoCommand(strSql)
            FrmListadoClientes.ActualizarDGV()
            FrmSeleccionarCliente.ConsultaTodosClientes()
        Catch ex As Exception

        End Try

    End Sub

    'Método que actualiza datos de un cliente
    Public Sub ActualizarCliente()
        Try
            strSql = "BEGIN Cliente_Actualizar (" & idCliente & ", " & idGenero & ", '" & nombreCliente & "', '" &
                            paternoCliente & "', '" & maternoCliente & "', '" & telefonoCliente & "', '" &
                            identificacionCliente & "', '" & notaCliente & "', '" & estadoCliente & "'); End;"
            xCnx.objetoCommand(strSql)
            FrmListadoClientes.ActualizarDGV()
            FrmSeleccionarCliente.ConsultaTodosClientes()
        Catch ex As Exception

        End Try

    End Sub

    'Función que consulta sí existe un cliente y regresa un TRUE o FALSE
    Public Function ConsultaUnCliente() As Boolean
        ConsultaUnCliente = False
        Try
            strSql = "SELECT id_cliente FROM Cliente WHERE id_cliente = " & idCliente


            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count = 1 Then
                ConsultaUnCliente = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Función que valida sí un cliente tiene dependencias (Sí una reservacion depende de un registro de cliente)
    Public Function ValidaClienteReservacion() As Boolean
        ValidaClienteReservacion = False
        Try
            strSql = "SELECT * FROM Reservacion WHERE id_cliente = " & idCliente

            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count >= 1 Then
                ValidaClienteReservacion = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Función que valida sí un cliente que se va a ***INSERTAR*** no tenga el mismo telefono que otro registro
    Public Function ValidaTelefonoInsertar() As Boolean
        ValidaTelefonoInsertar = False
        Try
            strSql = "SELECT * FROM Cliente WHERE telefono_cliente = '" & telefonoCliente & "'"

            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count = 1 Then
                ValidaTelefonoInsertar = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Función que valida sí un cliente que se va a ***INSERTAR*** no tenga la misma identificacion que otro registro
    Public Function ValidaIdentificacionInsertar() As Boolean
        ValidaIdentificacionInsertar = False
        Try
            strSql = "SELECT * FROM Cliente WHERE identificacion_cliente = '" & identificacionCliente & "'"

            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count = 1 Then
                ValidaIdentificacionInsertar = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Función que valida sí un cliente que se va a ***ACTUALIZAR*** no tenga el mismo telefono que otro registro
    Public Function ValidaTelefonoActualizar() As Boolean
        ValidaTelefonoActualizar = False
        Try
            strSql = "SELECT * FROM Cliente WHERE telefono_cliente = '" & telefonoCliente & "' AND id_cliente = " & idCliente

            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count = 1 Then
                ValidaTelefonoActualizar = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Función que valida sí un cliente que se va a ***ACTUALIZAR*** no tenga la misma identificacion que otro registro
    Public Function ValidaIdentificacionActualizar() As Boolean
        ValidaIdentificacionActualizar = False
        Try
            strSql = "SELECT * FROM Cliente WHERE identificacion_cliente = '" & identificacionCliente & "' AND id_cliente = " & idCliente

            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count = 1 Then
                ValidaIdentificacionActualizar = True
            End If
        Catch ex As Exception

        End Try
    End Function

    'Método que elimina un cliente
    Public Sub EliminarCliente()
        Try
            strSql = "BEGIN Cliente_Eliminar (" & idCliente & "); END;"
            xCnx.objetoCommand(strSql)
            FrmListadoClientes.ActualizarDGV()
            FrmSeleccionarCliente.ConsultaTodosClientes()
        Catch ex As Exception

        End Try

    End Sub

    'Método para poblar el ComboBox de Géneros en el Formulario de Cliente
    Public Sub PoblarComboBoxGenero()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter
        Try
            strSql = "SELECT nombre_genero FROM Genero ORDER BY nombre_genero"
            conector = New OracleDataAdapter(strSql, cnx)

            conector.Fill(xDT)
            With FrmAdministracionClientes.CBGenero
                .DataSource = xDT
                .DisplayMember = "id_genero"
                .ValueMember = "nombre_genero"
            End With

            With FrmRegistroCliente.CBGenero
                .DataSource = xDT
                .DisplayMember = "id_genero"
                .ValueMember = "nombre_genero"
            End With
        Catch ex As Exception

        End Try

    End Sub

    'Método para saber que ID le pertenece cada género seleccionado desde el CB 
    Public Sub IdSeleccionadoEnCBGenero()
        Try
            Dim xDT As New DataTable
            Dim conector = New OracleDataAdapter

            strSql = "SELECT id_genero FROM Genero WHERE nombre_genero = '" & FrmAdministracionClientes.CBGenero.SelectedValue.ToString & "'"
            conector = New OracleDataAdapter(strSql, cnx)
            conector.Fill(xDT)

            For Each registro As DataRow In xDT.Rows
                FrmAdministracionClientes.idGenero = registro("id_genero").ToString
                FrmRegistroCliente.idGenero = registro("id_genero").ToString
            Next
        Catch ex As Exception

        End Try

    End Sub
End Class

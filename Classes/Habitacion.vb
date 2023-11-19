Imports Oracle.DataAccess.Client

Public Class Habitacion
    Private numeroHab As Integer
    Private idtipoHab As Integer
    Private precioHab As Double
    Private estadoHab As String
    Private capacidadHab As Integer
    Private descripcionHab As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Métodos GET y SET
    Public Property GetSetNumHabitacion() As Integer
        Get
            Return numeroHab
        End Get
        Set(ByVal Value As Integer)
            numeroHab = Value
        End Set
    End Property

    Public Property GetSetIdTipoHab() As Integer
        Get
            Return idtipoHab
        End Get
        Set(ByVal Value As Integer)
            idtipoHab = Value
        End Set
    End Property

    Public Property GetSetPrecioHab() As Double
        Get
            Return precioHab
        End Get
        Set(ByVal Value As Double)
            precioHab = Value
        End Set
    End Property

    Public Property GetSetEstadoHab() As String
        Get
            Return estadoHab
        End Get
        Set(ByVal Value As String)
            estadoHab = Value
        End Set
    End Property

    Public Property GetSetCapacidadHab() As Integer
        Get
            Return capacidadHab
        End Get
        Set(ByVal Value As Integer)
            capacidadHab = Value
        End Set
    End Property

    Public Property GetSetDescripcionHab() As String
        Get
            Return descripcionHab
        End Get
        Set(ByVal Value As String)
            descripcionHab = Value
        End Set
    End Property

    'Constructor vacío
    Public Sub New()
        numeroHab = 0
        idtipoHab = 0
        precioHab = 0.0
        estadoHab = ""
        capacidadHab = 0
        descripcionHab = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal numeroHabD As Integer, ByVal idtipoHabD As Integer, ByVal precioHabD As Double, ByVal estadoHabD As String, ByVal capacidadHabD As Integer, ByVal descripcionHabD As String)
        numeroHab = numeroHabD
        idtipoHab = idtipoHabD
        precioHab = precioHabD
        estadoHab = estadoHabD
        capacidadHab = capacidadHabD
        descripcionHab = descripcionHabD
    End Sub

    'Funcion que consulta todos los registros de la tabla Usuario
    Public Function ConsultaTodaHabitacion() As Object
        strSql = "SELECT * FROM Vista_Todas_Habitaciones"
        ConsultaTodaHabitacion = xCnx.objetoDataAdapter(strSql)
    End Function

    'Método que llena el DGV de usuario
    Public Sub PoblarDataGridHabitacion(ByVal DGVHabitacion As DataGridView)
        'Llama a la función ConsultaTodo para llenar el DGV
        DGVHabitacion.DataSource = ConsultaTodaHabitacion()
        DGVHabitacion.Refresh()
        'Cambiar la anchura de una columna de la tabla del DGV
        'DGUsuarios.Columns.Item(4).Width = 240
    End Sub

    'Método que inserta una habitacion
    Public Sub InsertaHabitacion()
        Try
            strSql = "BEGIN Habitacion_Insertar (" & numeroHab & ", " & idtipoHab & ", " & precioHab & ", '" & estadoHab & "', 
                                            " & capacidadHab & ", '" & descripcionHab & "'); END;"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método que actualiza una habitacion
    Public Sub Actualizahabitacion()
        Try
            strSql = "BEGIN Habitacion_Actualizar (" & numeroHab & ", " & idtipoHab & ", " & precioHab & ", '" & estadoHab & "', 
                                            " & capacidadHab & ", '" & descripcionHab & "'); END;"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Función que consulta sí existe una habitacion y regresa un TRUE o FALSE
    Public Function ConsultaUnaHabitacion() As Boolean
        ConsultaUnaHabitacion = False
        Try
            strSql = "SELECT numero_habitacion FROM Habitacion WHERE numero_habitacion = " & numeroHab


            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count = 1 Then
                ConsultaUnaHabitacion = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Funcion que valida si una habitacion tine dependencias
    Public Function ValidaHabitacion() As Boolean

        strSql = "SELECT * FROM Reservacion_has_Habitacion WHERE numero_habitacion = " & numeroHab
            ValidaHabitacion = False
            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count >= 1 Then
                ValidaHabitacion = True
            End If


    End Function

    'Método que elimina una habitacion
    Public Sub EliminarHabitacion()
        Try
            strSql = "BEGIN Habitacion_Eliminar (" & numeroHab & "); END;"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método para poblar el ComboBox de Tipo de hbaitacion en el Formulario de Habitacion
    Public Sub PoblarComboBoxTipo()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter
        Try
            strSql = "SELECT nombre_tipo_hab FROM Tipo_Habitacion ORDER BY nombre_tipo_hab"
            conector = New OracleDataAdapter(strSql, cnx)

            conector.Fill(xDT)
            With FrmAdministrarHabitacion.CBTipo
                .DataSource = xDT
                .DisplayMember = "id_tipo_hab"
                .ValueMember = "nombre_tipo_hab"
            End With
        Catch ex As Exception

        End Try
    End Sub

    'Método para saber que ID le pertenece cada tipo de habitacion seleccionado desde el CB 
    Public Sub IdSeleccionadoEnCBTipo()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter
        Try
            strSql = "SELECT id_tipo_hab FROM Tipo_Habitacion WHERE nombre_tipo_hab = '" & FrmAdministrarHabitacion.CBTipo.SelectedValue.ToString & "'"
            conector = New OracleDataAdapter(strSql, cnx)
            conector.Fill(xDT)

            For Each registro As DataRow In xDT.Rows
                FrmAdministrarHabitacion.idtipohab = registro("id_tipo_hab").ToString
            Next
        Catch ex As Exception

        End Try

    End Sub

End Class


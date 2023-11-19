Public Class CargoExtra
    Private idCargoExtra As Integer
    Private idFolio As Integer
    Private concepto As String
    Private cantidad As Integer
    Private precioUnitario As Double
    Private precioTotal As Double
    Private numeroHabitacion As Integer

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idCargoExtra = 0
        idFolio = 0
        concepto = ""
        cantidad = 0
        precioUnitario = 0.0
        precioTotal = 0.0
        numeroHabitacion = 0
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idCargoExtraD As Integer, ByVal idFolioD As Integer, ByVal conceptoD As String, ByVal cantidadD As Double, ByVal precioUnitarioD As Double, ByVal precioTotalD As Double, ByVal numeroHabitacionD As Integer)
        idCargoExtra = idCargoExtraD
        idFolio = idFolioD
        concepto = conceptoD
        cantidad = cantidadD
        precioUnitario = precioUnitarioD
        precioTotal = precioTotalD
        numeroHabitacion = numeroHabitacionD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdCargoExtra() As Integer
        Get
            Return idCargoExtra
        End Get
        Set(ByVal Value As Integer)
            idCargoExtra = Value
        End Set
    End Property

    Public Property GetSetIdFolio() As Integer
        Get
            Return idFolio
        End Get
        Set(ByVal Value As Integer)
            idFolio = Value
        End Set
    End Property

    Public Property GetSetConcepto() As String
        Get
            Return concepto
        End Get
        Set(ByVal Value As String)
            concepto = Value
        End Set
    End Property

    Public Property GetSetCantidad() As Integer
        Get
            Return cantidad
        End Get
        Set(ByVal Value As Integer)
            cantidad = Value
        End Set
    End Property

    Public Property GetSetPrecioUnitario() As Double
        Get
            Return precioUnitario
        End Get
        Set(ByVal Value As Double)
            precioUnitario = Value
        End Set
    End Property

    Public Property GetSetPrecioTotal() As Double
        Get
            Return precioTotal
        End Get
        Set(ByVal Value As Double)
            precioTotal = Value
        End Set
    End Property

    Public Property GetSetNumHabitacion() As Integer
        Get
            Return numeroHabitacion
        End Get
        Set(ByVal Value As Integer)
            numeroHabitacion = Value
        End Set
    End Property

    'Método que inserta un CARGO EXTRA
    Public Sub InsertaCargoExtra()
        Try
            'strSql = "BEGIN Cargo_Extra_Insertar (" & idFolio & ", '" & concepto & "', " & cantidad & ", " & precioUnitario & ", " & precioTotal & ", SYSDATE); End;"
            strSql = "INSERT INTO Cargo_extra (id_folio, concepto, cantidad, precio_unitario, precio_total, fecha_hora, numero_habitacion) VALUES (" & idFolio & ", '" & concepto & "', " & cantidad & ", " & precioUnitario & ", " & precioTotal & ", SYSDATE, " & numeroHabitacion & ")"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método que ACTUALIZA un CARGO EXTRA
    Public Sub ActualizaCargoExtra()
        Try
            strSql = "UPDATE Cargo_extra SET concepto = '" & concepto & "', cantidad = " & cantidad & ", precio_unitario = " & precioUnitario & ", precio_total = " & precioTotal & " WHERE id_cargo_extra = " & idCargoExtra
            'strSql = "BEGIN Cargo_Extra_Actualiza (" & idCargoExtra & ", " & idFolio & ", '" & concepto & "', " & cantidad & ", " & precioUnitario & ", " & precioTotal & "); End;"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Función que consulta sí existe y regresa un TRUE o FALSE
    Public Function ConsultaUnCargoExtra() As Boolean
        ConsultaUnCargoExtra = False
        Try
            strSql = "SELECT id_cargo_extra FROM Cargo_extra WHERE id_cargo_extra = " & idCargoExtra


            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count = 1 Then
                ConsultaUnCargoExtra = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Método que elimina un cargo extra
    Public Sub EliminarCargoExtra()
        Try
            strSql = "DELETE Cargo_extra WHERE id_cargo_extra = " & idCargoExtra
            'strSql = "BEGIN Cargo_Extra_Eliminar (" & idCargoExtra & "); END;"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub
End Class

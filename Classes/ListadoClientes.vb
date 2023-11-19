Public Class ListadoClientes
    'Método constructor vacío
    Public Sub New()
    End Sub

    'MÉTODO QUE CONSULTA TODOS LOS CLIENTES
    Public Function ConsultaTodosClientes(ByVal DGVClientes As DataGridView) As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Todos_Clientes"

        ConsultaTodosClientes = xCnx.objetoDataAdapter(strSQL)

        DGVClientes.DataSource = ConsultaTodosClientes
        'Ocultar columna de ID de cliente y género
        DGVClientes.Columns(0).Visible = False
        DGVClientes.Columns(1).Visible = False
        DGVClientes.Refresh()
    End Function

    'MÉTODO QUE CONSULTA LOS CLIENTES ACTIVOS
    Public Function ConsultaClientesActivos(ByVal DGVClientes As DataGridView) As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Clientes_Activos"

        ConsultaClientesActivos = xCnx.objetoDataAdapter(strSQL)

        DGVClientes.DataSource = ConsultaClientesActivos
        'Ocultar columna de ID de cliente y género
        DGVClientes.Columns(0).Visible = False
        DGVClientes.Columns(1).Visible = False
        DGVClientes.Refresh()
    End Function

    'MÉTODO QUE CONSULTA LOS CLIENTES DESACTIVADOS
    Public Function ConsultaClientesDesactivados(ByVal DGVClientes As DataGridView) As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Clientes_Desactivados"

        ConsultaClientesDesactivados = xCnx.objetoDataAdapter(strSQL)

        DGVClientes.DataSource = ConsultaClientesDesactivados
        'Ocultar columna de ID de cliente y género
        DGVClientes.Columns(0).Visible = False
        DGVClientes.Columns(1).Visible = False
        DGVClientes.Refresh()
    End Function

    'MÉTODO QUE CONSULTA LOS CLIENTES CON CHECK OUT
    Public Function ConsultaClientesConCheckOut(ByVal DGVClientes As DataGridView) As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Clientes_CheckOut"

        ConsultaClientesConCheckOut = xCnx.objetoDataAdapter(strSQL)

        DGVClientes.DataSource = ConsultaClientesConCheckOut
        'Ocultar columna de ID de cliente y género
        DGVClientes.Columns(0).Visible = False
        DGVClientes.Columns(1).Visible = False
        DGVClientes.Refresh()
    End Function

    'MÉTODO QUE CONSULTA LOS CLIENTES CON CHECK OUT EN UNA FECHA DETERMINADA
    Public Function ConsultaClientesConCheckOutFecha(ByVal DGVClientes As DataGridView, fechaInicial As String, fechaFinal As String) As Object
        Dim strSQL As String
        Dim xCnx As New Oracle
        'Try
        strSQL = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"",
                    c.nombre_cliente AS ""NOMBRE"", c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA"", rh.check_in_prog As ""CHECK IN"", rh.check_out_prog AS ""CHECK OUT""
                 FROM Cliente c, Genero g, Reservacion r, Reservacion_has_Habitacion rh
                 WHERE c.id_genero = g.id_genero
                 AND c.id_cliente = r.id_cliente
                 AND r.id_reservacion = rh.id_reservacion
                 AND rh.check_in_real >= '" & fechaInicial.ToString & "'
                 AND rh.check_out_real <= '" & fechaFinal.ToString & "'
                 ORDER BY rh.check_in_prog"

            ConsultaClientesConCheckOutFecha = xCnx.objetoDataAdapter(strSQL)

            DGVClientes.DataSource = ConsultaClientesConCheckOutFecha
            'Ocultar columna de ID de cliente y género
            DGVClientes.Columns(0).Visible = False
            DGVClientes.Columns(1).Visible = False
            DGVClientes.Refresh()
        'Catch ex As Exception

        'End Try

    End Function
End Class

Public Class FrmSeleccionarCliente
    Public idCliente As Integer
    Public nombreCliente As String

    Private strSql As String
    Private xCnx As New Oracle
    Private Sub FrmSeleccionarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True
        'Cargar primero el formulario y luego seguir
        Application.DoEvents()
        'Poblar el DGV
        ConsultaTodosClientes()
        'Ocultar columna de ID de cliente y género
        DGVClientes.Columns(0).Visible = False
        DGVClientes.Columns(1).Visible = False
        'Busqueda por defecto
        CBBuscarPor.Text = "Nombre"
        'Desactiva boton de aceptar
        BtnAceptar.Visible = False
    End Sub

    'MÉTODO QUE CONSULTA TODOS LOS CLIENTES
    Public Sub ConsultaTodosClientes()
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"", c.nombre_cliente AS ""NOMBRE"", 
                    c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA""
                    FROM Cliente c, Genero g
                    WHERE c.id_genero = g.id_genero
                    AND c.estado_cliente <> 'Desactivado'
                    ORDER BY c.nombre_cliente"

        DGVClientes.DataSource = xCnx.objetoDataAdapter(strSQL)
        DGVClientes.Refresh()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub TxtDatoBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtDatoBuscar.TextChanged
        Dim datoB As String
        'El dato ingresado es convertido en minúscula
        datoB = LCase(TxtDatoBuscar.Text)

        If CBBuscarPor.Text = "Nombre" Then
            strSql = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"",
                    c.nombre_cliente AS ""NOMBRE"", c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA""
                 FROM Cliente c, Genero g
                 WHERE c.id_genero = g.id_genero
                 AND c.estado_cliente <> 'Desactivado'
                 AND lower(c.nombre_cliente) LIKE '%" & datoB & "%'"
            DGVClientes.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVClientes.Refresh()

        ElseIf CBBuscarPor.Text = "Apellido paterno" Then
            strSql = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"",
                    c.nombre_cliente AS ""NOMBRE"", c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA""
                 FROM Cliente c, Genero g
                 WHERE c.id_genero = g.id_genero
                 AND c.estado_cliente <> 'Desactivado'
                 AND lower(c.paterno_cliente) LIKE '%" & datoB & "%'"
            DGVClientes.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVClientes.Refresh()

        ElseIf CBBuscarPor.Text = "Apellido materno" Then
            strSql = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"",
                    c.nombre_cliente AS ""NOMBRE"", c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA""
                 FROM Cliente c, Genero g
                 WHERE c.id_genero = g.id_genero
                 AND c.estado_cliente <> 'Desactivado'
                 AND lower(c.materno_cliente) LIKE '%" & datoB & "%'"
            DGVClientes.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVClientes.Refresh()

        ElseIf CBBuscarPor.Text = "Identificación" Then
            strSql = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"",
                    c.nombre_cliente AS ""NOMBRE"", c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA""
                 FROM Cliente c, Genero g
                 WHERE c.id_genero = g.id_genero
                 AND c.estado_cliente <> 'Desactivado'
                 AND lower(c.identificacion_cliente) LIKE '%" & datoB & "%'"
            DGVClientes.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVClientes.Refresh()
        End If
    End Sub

    Private Sub BtnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles BtnLimpiarBusqueda.Click
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub CBBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscarPor.SelectedIndexChanged
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub DGVClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick
        Dim renglon As Integer
        renglon = DGVClientes.CurrentCellAddress.Y
        Try
            idCliente = DGVClientes.Rows(renglon).Cells(0).Value
            nombreCliente = DGVClientes.Rows(renglon).Cells(2).Value + " " + DGVClientes.Rows(renglon).Cells(3).Value + " " + DGVClientes.Rows(renglon).Cells(4).Value
            'Activa boton de aceptar
            BtnAceptar.Visible = True
        Catch ex As Exception
            'MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        FrmCargando.MostarConTiempoEnCargar(300)
        FrmRegistroReservacion.TxtNombreCliente.Text = nombreCliente
        FrmRegistroReservacion.BtnCrearReservacion.Enabled = True
        FrmRegistroReservacion.BtnNotaReservacion.Enabled = True
        'Desctiva boton de aceptar
        BtnAceptar.Visible = False
        Me.Hide()
    End Sub

    Private Sub BtnRegistrarCliente_Click(sender As Object, e As EventArgs) Handles BtnRegistrarCliente.Click
        abiertoDesde = "SeleccionarCliente"
        FrmCargando.MostarConTiempoEnCargar(300)
        FrmRegistroCliente.Show()
    End Sub

    Private Sub TxtDatoBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatoBuscar.KeyPress
        If CBBuscarPor.Text = "Nombre" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Apellido paterno" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Apellido materno" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Identificación" Then
            SoloNumero(e)
        End If
    End Sub

    Private Sub FrmSeleccionarCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAceptar.PerformClick()
        End If
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmGenero.Close()
        FrmRegistroCliente.Close()
    End Sub

    Private Sub FrmSeleccionarCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "RegistroReserv" Then
            FrmRegistroReservacion.Activate()
            FrmRegistroReservacion.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub
End Class
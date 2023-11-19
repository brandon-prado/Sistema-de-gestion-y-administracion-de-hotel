Public Class FrmRegistroCliente
    Public cliente As New Cliente
    Private idCliente As Integer
    Public idGenero As Integer

    Private Sub FrmRegistroCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        'Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para regresar a la ventana anterior")
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Registar o actualizar género")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Limpiar caja de texto")

        'Poblar el comboBox de género
        cliente.PoblarComboBoxGenero()
        cliente.IdSeleccionadoEnCBGenero()

        'CB Estado
        CBEstado.Text = "Activo"
        CBEstado.Enabled = False
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        idCliente = 0
        idGenero = 0
        TxtNombreCliente.Text = ""
        TxtPaternoCliente.Text = ""
        TxtMaternoCliente.Text = ""
        TxtTelefonoCliente.Text = ""
        TxtIdentificacionCliente.Text = ""
        TxtNotaCliente.Text = ""
        CBEstado.Text = ""
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If idGenero = 0 Or TxtNombreCliente.Text = "" Or TxtPaternoCliente.Text = "" Or TxtMaternoCliente.Text = "" Or TxtTelefonoCliente.Text = "" Or TxtIdentificacionCliente.Text = "" Or CBEstado.Text = "" Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            If Len(TxtTelefonoCliente.Text) < 10 Or Len(TxtIdentificacionCliente.Text) < 13 Then
                FrmAviso.LbMensaje.Text = "El teléfono debe tener 10 números válidos y la identificación 13 números válidos"
                FrmAviso.Show()
                ComprobarDatos = False
            Else
                ComprobarDatos = True
            End If
        End If
    End Function

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        FrmCargando.MostarConTiempoEnCargar(400)
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim cliente As New Cliente(idCliente, idGenero, TxtNombreCliente.Text, TxtPaternoCliente.Text, TxtMaternoCliente.Text, TxtTelefonoCliente.Text, TxtIdentificacionCliente.Text, TxtNotaCliente.Text, CBEstado.Text)
                If cliente.ConsultaUnCliente() Then
                    'Valida que no tenga una identificacion igual
                    If cliente.ValidaIdentificacionActualizar = False Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE LA IDENTIFICACIÓN YA SE HA REGISTRADO CON OTRO CLIENTE"
                        FrmAviso.Show()

                    ElseIf cliente.ValidaTelefonoActualizar = False Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE EL TELÉFONO YA SE HA REGISTRADO CON OTRO CLIENTE"
                        FrmAviso.Show()
                    Else
                        'Si el cliente se encuentra registrado, se modifica la información
                        cliente.ActualizarCliente()
                        FrmCorrecto.LbMensaje.Text = "CLIENTE MODIFICADO CORRECTAMENTE"
                        FrmCorrecto.Show()
                        Me.Close()
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    End If

                Else
                    'Valida que no tenga una identificacion igual
                    If cliente.ValidaIdentificacionInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE REGISTRAR PORQUE LA IDENTIFICACIÓN YA SE HA REGISTRADO CON OTRO CLIENTE"
                        FrmAviso.Show()

                    ElseIf cliente.ValidaTelefonoInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE REGISTRAR PORQUE EL TELÉFONO YA SE HA REGISTRADO CON OTRO CLIENTE"
                        FrmAviso.Show()
                    Else
                        'Si el cliente NO está registrado, lo inserta como uno nuevo
                        cliente.InsertaCliente()
                        FrmCorrecto.LbMensaje.Text = "CLIENTE REGISTRADO CORRECTAMENTE"
                        FrmCorrecto.Show()
                        Me.Close()
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    End If


                End If
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        ' FrmListadoClientes.Show()
        Me.Close()
        FrmGenero.Close()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub CBGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBGenero.SelectedIndexChanged
        cliente.IdSeleccionadoEnCBGenero()
    End Sub

    Private Sub BtnAgregarNivelPermiso_Click(sender As Object, e As EventArgs) Handles BtnAgregarNivelPermiso.Click
        FrmGenero.Show()
    End Sub

    Private Sub TxtNombreCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreCliente.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtPaternoCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPaternoCliente.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtMaternoCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMaternoCliente.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtTelefonoCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefonoCliente.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtIdentificacionCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtIdentificacionCliente.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtNotaCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNotaCliente.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub FrmRegistroCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmGenero.Close()
    End Sub

    Private Sub FrmRegistroCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "SeleccionarCliente" Then
            FrmSeleccionarCliente.Activate()
            FrmSeleccionarCliente.Show()
        ElseIf abiertoDesde = "ListadoClientes" Then
            FrmListadoClientes.Activate()
            FrmListadoClientes.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub
End Class
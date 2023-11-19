Public Class FrmAdministracionClientes
    Public cliente As New Cliente
    Public idCliente As Integer
    Public idGenero As Integer

    Private Sub FrmAdministracionClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True
        'Hora y fecha del sistema
        FechaHora.Enabled = True
        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString
        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'Poblar DGV
        cliente.PoblarDataGridCliente(DGVClientes)
        'Ocultar columna de ID de cliente y género
        DGVClientes.Columns(0).Visible = False
        DGVClientes.Columns(1).Visible = False

        'Poblar el comboBox de género
        'cliente.PoblarComboBoxGenero()
        'Saber que Id tiene el genero incialmente
        cliente.IdSeleccionadoEnCBGenero()

        TimerOcultar.Start()
    End Sub

    Private Sub DGVClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellContentClick
        Dim renglon As Integer
        renglon = DGVClientes.CurrentCellAddress.Y

        Try
            idCliente = DGVClientes.Rows(renglon).Cells(0).Value
            idGenero = DGVClientes.Rows(renglon).Cells(1).Value
            TxtNombreCliente.Text = DGVClientes.Rows(renglon).Cells(2).Value
            TxtPaternoCliente.Text = DGVClientes.Rows(renglon).Cells(3).Value
            TxtMaternoCliente.Text = DGVClientes.Rows(renglon).Cells(4).Value
            CBGenero.Text = DGVClientes.Rows(renglon).Cells(5).Value
            TxtTelefonoCliente.Text = DGVClientes.Rows(renglon).Cells(6).Value
            TxtIdentificacionCliente.Text = DGVClientes.Rows(renglon).Cells(7).Value
            CBEstado.Text = DGVClientes.Rows(renglon).Cells(8).Value
            If IsDBNull(DGVClientes.Rows(renglon).Cells(9).Value) Then
                TxtNotaCliente.Text = ""
            Else
                TxtNotaCliente.Text = DGVClientes.Rows(renglon).Cells(9).Value
            End If


        Catch ex As Exception
            'MsgBox("ERROR: " & ex.Message)
        End Try
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
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campo correspondientes"
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
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim cliente As New Cliente(idCliente, idGenero, TxtNombreCliente.Text, TxtPaternoCliente.Text, TxtMaternoCliente.Text, TxtTelefonoCliente.Text, TxtIdentificacionCliente.Text, TxtNotaCliente.Text, CBEstado.Text)
                If cliente.ConsultaUnCliente() Then
                    'Valida que no tenga una identificacion igual
                    If cliente.ValidaIdentificacionActualizar = False And cliente.ValidaIdentificacionInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE LA IDENTIFICACIÓN YA SE HA REGISTRADO CON OTRO CLIENTE"
                        FrmAviso.Show()

                    ElseIf cliente.ValidaTelefonoActualizar = False And cliente.ValidaTelefonoInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE EL TELÉFONO YA SE HA REGISTRADO CON OTRO CLIENTE"
                        FrmAviso.Show()
                    Else
                        'Si el cliente se encuentra registrado, se modifica la información
                        cliente.ActualizarCliente()
                        FrmCorrecto.LbMensaje.Text = "CLIENTE MODIFICADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV 
                        cliente.PoblarDataGridCliente(DGVClientes)
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

                        'Actualizar DGV 
                        cliente.PoblarDataGridCliente(DGVClientes)
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    End If


                End If

            End If
        Catch ex As Exception
            MsgBox("Algún dato causa conflicto: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim cliente As New Cliente(idCliente, idGenero, TxtNombreCliente.Text, TxtPaternoCliente.Text, TxtMaternoCliente.Text, TxtTelefonoCliente.Text, TxtIdentificacionCliente.Text, TxtNotaCliente.Text, CBEstado.Text)

                If cliente.ConsultaUnCliente() Then
                    'Consulta que ninguna reservacion dependa del cliente
                    If cliente.ValidaClienteReservacion() Then
                        FrmAviso.LbMensaje.Text = "No se puede eliminar el cliente: '" & TxtNombreCliente.Text & "' porque tiene una o más dependencias"
                        FrmAviso.Show()
                    Else
                        'Sí ninguna reservacion depende del cliente se pide confirmar la acción de borrado
                        If MessageBox.Show("¿Estás seguro de que quieres eliminar el cliente '" & TxtNombreCliente.Text & "'?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Llamamos al método que elimina el registro del permiso
                            cliente.EliminarCliente()
                            FrmCorrecto.LbMensaje.Text = "Cliente ELIMINADO correctamente"
                            FrmCorrecto.Show()
                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            cliente.PoblarDataGridCliente(DGVClientes)
                        End If
                    End If
                Else
                    FrmAviso.LbMensaje.Text = "No existe el cliente"
                    FrmAviso.Show()
                End If
                'Limpiamos caja de texto
                'Call BtnLimpiar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Activate()
        FrmMenuPrincipal.Show()
        ModuloGlobal.modoSuperUsuario = False
        Me.Close()
        FrmListadoClientes.Close()
        FrmGenero.Close()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmGenero.Close()
    End Sub

    Private Sub FrmAdministracionClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "ListadoClientes" Then
            FrmListadoClientes.Show()
            FrmListadoClientes.Activate()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmCargando.MostarConTiempoEnCargar(500)
            FrmListadoUsuarios.Show()
            FrmListadoUsuarios.Activate()
            Me.Close()
            FrmListadoClientes.Close()
            FrmGenero.Close()
        Else
            FrmCargando.MostarConTiempoEnCargar(500)
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Me, Nothing)
            FrmAutorizacion.Show()
            FrmAutorizacion.Activate()
            FrmListadoClientes.Close()
            FrmGenero.Close()
        End If
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
        FrmCerrarSesion.Activate()
    End Sub

    Private Sub CBGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBGenero.SelectedIndexChanged
        'Identificar el Id seleccionado del CBGenero
        cliente.IdSeleccionadoEnCBGenero()
    End Sub

    Private Sub BtnAgregarNivelPermiso_Click(sender As Object, e As EventArgs) Handles BtnAgregarNivelPermiso.Click
        FrmGenero.Activate()
        FrmGenero.Show()
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(500)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()

        ModuloGlobal.modoSuperUsuario = False
        Me.Close()
        FrmListadoClientes.Close()
        FrmGenero.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(500)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()

        ModuloGlobal.modoSuperUsuario = False
        Me.Close()
        FrmGenero.Close()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(500)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()

        ModuloGlobal.modoSuperUsuario = False
        Me.Close()
        FrmListadoClientes.Close()
        FrmGenero.Close()
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



    Private Sub TimerOcultar_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If TimerOcultar.Interval = 8000 Then
            PBAlt.Visible = False
            LabelAlt.Visible = False
        End If
    End Sub

    Private Sub FrmAdministracionClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs)

    End Sub
End Class
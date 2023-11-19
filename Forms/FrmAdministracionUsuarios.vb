Public Class FrmAdministracionUsuarios
    Public usuario As New Usuario
    Public idUsuario As Integer
    Public idGenero As Integer
    Public idRol As Integer

    Private Sub FrmAdministracionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        usuario.PoblarDataGridUsuario(DGVUsuarios)
        'Ocultar columna de ID de usuario, genero, rol y contraseña
        DGVUsuarios.Columns(0).Visible = False
        DGVUsuarios.Columns(1).Visible = False
        DGVUsuarios.Columns(2).Visible = False
        DGVUsuarios.Columns(14).Visible = False

        ''Poblar el comboBox de género y rol
        'usuario.PoblarComboBoxGenero()
        'usuario.PoblarComboBoxRoles()

        'Saber que Id tiene el genero y rol incialmente
        usuario.IdSeleccionadoEnCBGenero()
        usuario.IdSeleccionadoEnCBRol()
    End Sub

    Private Sub DGVUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsuarios.CellContentClick
        Dim renglon As Integer
        renglon = DGVUsuarios.CurrentCellAddress.Y

        Try
            'Llenar las cajas de texto al seleccionar un resgistro del DGV
            idUsuario = DGVUsuarios.Rows(renglon).Cells(0).Value
            idGenero = DGVUsuarios.Rows(renglon).Cells(1).Value

            TxtNombreUsuario.Text = DGVUsuarios.Rows(renglon).Cells(4).Value
            TxtPaternoUsuario.Text = DGVUsuarios.Rows(renglon).Cells(5).Value
            TxtMaternoUsuario.Text = DGVUsuarios.Rows(renglon).Cells(6).Value
            CBGenero.Text = DGVUsuarios.Rows(renglon).Cells(7).Value
            TxtTelefonoUsuario.Text = DGVUsuarios.Rows(renglon).Cells(8).Value
            TxtIdentificacionUsuario.Text = DGVUsuarios.Rows(renglon).Cells(9).Value
            TxtDireccionUsuario.Text = DGVUsuarios.Rows(renglon).Cells(10).Value
            DateTimeFechaIngreso.Text = DGVUsuarios.Rows(renglon).Cells(11).Value
            If (DGVUsuarios.Rows(renglon).Cells(12).Value).Equals("Si") Then
                RBTieneAccesoSistema.Checked = True
                RBNoTieneAccesoSistema.Checked = False
            ElseIf (DGVUsuarios.Rows(renglon).Cells(12).Value).Equals("No") Then
                RBTieneAccesoSistema.Checked = False
                RBNoTieneAccesoSistema.Checked = True
            End If

            If IsDBNull(DGVUsuarios.Rows(renglon).Cells(13).Value) Then
                TxtUsuario.Text = ""
            Else
                TxtUsuario.Text = DGVUsuarios.Rows(renglon).Cells(13).Value
            End If

            If IsDBNull(DGVUsuarios.Rows(renglon).Cells(14).Value) Then
                TxtContrasena.Text = ""
            Else
                TxtContrasena.Text = DGVUsuarios.Rows(renglon).Cells(14).Value
            End If

            CBEstado.Text = DGVUsuarios.Rows(renglon).Cells(15).Value
            idRol = DGVUsuarios.Rows(renglon).Cells(2).Value
            CBRol.Text = DGVUsuarios.Rows(renglon).Cells(3).Value


        Catch ex As Exception
            ' MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        idUsuario = 0
        idGenero = 0
        idRol = 0
        CBRol.Text = ""
        TxtNombreUsuario.Text = ""
        TxtPaternoUsuario.Text = ""
        TxtMaternoUsuario.Text = ""
        CBGenero.Text = ""
        TxtTelefonoUsuario.Text = ""
        TxtIdentificacionUsuario.Text = ""
        TxtDireccionUsuario.Text = ""
        DateTimeFechaIngreso.Text = ""
        RBTieneAccesoSistema.Checked = False
        RBNoTieneAccesoSistema.Checked = False
        TxtUsuario.Text = ""
        TxtContrasena.Text = ""
        CBEstado.Text = ""
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If idGenero = 0 Or idRol = 0 Or TxtNombreUsuario.Text = "" Or TxtPaternoUsuario.Text = "" Or TxtMaternoUsuario.Text = "" Or TxtTelefonoUsuario.Text = "" Or TxtIdentificacionUsuario.Text = "" Or TxtDireccionUsuario.Text = "" Or CBEstado.Text = "" Or RBTieneAccesoSistema.Checked = False And RBNoTieneAccesoSistema.Checked = False Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            If Len(TxtTelefonoUsuario.Text) < 10 Or Len(TxtIdentificacionUsuario.Text) < 13 Then
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
                Dim tieneAcceso As String = "No"
                If RBTieneAccesoSistema.Checked = True And RBNoTieneAccesoSistema.Checked = False Then
                    tieneAcceso = "Si"
                ElseIf RBTieneAccesoSistema.Checked = False And RBNoTieneAccesoSistema.Checked = True Then
                    tieneAcceso = "No"
                End If
                Dim usuario As New Usuario(idUsuario, idGenero, idRol, TxtNombreUsuario.Text, TxtPaternoUsuario.Text, TxtMaternoUsuario.Text, TxtTelefonoUsuario.Text, TxtIdentificacionUsuario.Text, TxtDireccionUsuario.Text, tieneAcceso, TxtUsuario.Text, TxtContrasena.Text, CBEstado.Text)
                If usuario.ConsultaUnUsuario() Then
                    If usuario.ValidaIdentUsuarioActualizar = False And usuario.ValidaIdentUsuarioInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE LA IDENTIFICACIÓN YA SE HA REGISTRADO CON OTRO USUARIO"
                        FrmAviso.Show()

                    ElseIf usuario.ValidaTelefUsuarioActualizar = False And usuario.ValidaTelefUsuarioInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE EL TELÉFONO YA SE HA REGISTRADO CON OTRO USUARIO"
                        FrmAviso.Show()

                    ElseIf usuario.ValidaUserUsuarioActualizar = False And usuario.ValidaUserUsuarioInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE EL USER YA ESTÁ EN USO CON OTRO USUARIO"
                        FrmAviso.Show()

                    Else
                        'Si el usuario se encuentra registrado, se modifica la información
                        usuario.ActualizarUsuario()
                        FrmCorrecto.LbMensaje.Text = "USUARIO MODIFICADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV
                        usuario.PoblarDataGridUsuario(DGVUsuarios)
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    End If

                Else
                    If usuario.ValidaIdentUsuarioInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE REGISTRAR PORQUE LA IDENTIFICACIÓN YA SE HA REGISTRADO CON OTRO USUARIO"
                        FrmAviso.Show()

                    ElseIf usuario.ValidaTelefUsuarioInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE REGISTRAR PORQUE EL TELÉFONO YA SE HA REGISTRADO CON OTRO USUARIO"
                        FrmAviso.Show()

                    ElseIf usuario.ValidaUserUsuarioInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE REGISTRAR PORQUE EL USER YA ESTÁ EN USO CON OTRO USUARIO"
                        FrmAviso.Show()
                    Else
                        'Si el usuario NO está registrado, lo inserta como uno nuevo
                        usuario.InsertaUsuario()
                        FrmCorrecto.LbMensaje.Text = "REGISTRADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV
                        usuario.PoblarDataGridUsuario(DGVUsuarios)
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)

                    End If

                End If

            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim tieneAcceso As String = "No"
                If RBTieneAccesoSistema.Checked = True And RBNoTieneAccesoSistema.Checked = False Then
                    tieneAcceso = "Si"
                ElseIf RBTieneAccesoSistema.Checked = False And RBNoTieneAccesoSistema.Checked = True Then
                    tieneAcceso = "No"
                End If

                Dim usuario As New Usuario(idUsuario, idGenero, idRol, TxtNombreUsuario.Text, TxtPaternoUsuario.Text, TxtMaternoUsuario.Text, TxtTelefonoUsuario.Text, TxtIdentificacionUsuario.Text, TxtDireccionUsuario.Text, tieneAcceso, TxtUsuario.Text, TxtContrasena.Text, CBEstado.Text)

                If usuario.ConsultaUnUsuario() Then
                    'Consulta que ninguna reservacion, folio o turno dependa del usuario
                    If usuario.ValidaUsuarioReservFolTurno() Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ELIMINAR EL USUARIO: '" & TxtNombreUsuario.Text & "' PORQUE TIENE UNO O MÁS DEPENDENCIAS!"
                        FrmAviso.Show()
                    Else
                        'Sí ningún usuario depende del rol se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL USUARIO '" & TxtNombreUsuario.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Llamamos al método que elimina el registro del permiso
                            usuario.EliminarUsuario()
                            FrmCorrecto.LbMensaje.Text = "USUARIO ELIMINADO CORRECTAMENTE!"
                            FrmCorrecto.Show()
                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            usuario.PoblarDataGridUsuario(DGVUsuarios)
                        End If
                    End If
                Else
                    FrmAviso.LbMensaje.Text = "No existe el usuario"
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
        Me.Close()
        FrmGenero.Close()
        FrmRol.Close()
        FrmListadoUsuarios.Close()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs)
        FrmListadoUsuarios.Show()
        Me.Close()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs)
        'FrmCargando.MostarConTiempoEnCargar(400)
        'FrmListadoUsuarios.Show()
        'Me.Close()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        Me.Close()
        cnx.Close()
        FrmInicioSesión.Show()
    End Sub

    Private Sub CBGenero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBGenero.SelectedIndexChanged
        usuario.IdSeleccionadoEnCBGenero()
    End Sub

    Private Sub CBRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBRol.SelectedIndexChanged
        'If CBRol.Text = "Empleado" Then

        '    RBTieneAccesoSistema.Enabled = False
        '    RBNoTieneAccesoSistema.Enabled = False
        '    If TxtUsuario.Text <> "" And TxtContrasena.Text <> "" Then
        '        If MessageBox.Show("¿ESTÁS SEGURO, SI CONTINUAS EL USUARIO Y CONTRASEÑA SERÁN BORRADOS'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '            RBTieneAccesoSistema.Enabled = False
        '            RBNoTieneAccesoSistema.Enabled = False
        '            RBNoTieneAccesoSistema.Checked = True
        '            TxtUsuario.Text = ""
        '            TxtContrasena.Text = ""
        '        Else
        '            CBRol.Text = ""
        '        End If
        '    Else
        '        RBNoTieneAccesoSistema.Checked = True
        '    End If
        'Else
        '    RBTieneAccesoSistema.Enabled = True
        '    RBNoTieneAccesoSistema.Enabled = True
        'End If
        usuario.IdSeleccionadoEnCBRol()
    End Sub

    Private Sub CbMostrarOcultarContrasena_CheckedChanged(sender As Object, e As EventArgs) Handles CbMostrarOcultarContrasena.CheckedChanged
        If CbMostrarOcultarContrasena.Checked = True Then
            TxtContrasena.UseSystemPasswordChar = False
        Else
            TxtContrasena.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnAgregarNivelPermiso_Click(sender As Object, e As EventArgs) Handles BtnAgregarGenero.Click
        FrmCargando.MostarConTiempoEnCargar(200)
        FrmGenero.Activate()
        FrmGenero.Show()
    End Sub

    Private Sub RBNoTieneAccesoSistema_CheckedChanged(sender As Object, e As EventArgs) Handles RBNoTieneAccesoSistema.CheckedChanged
        TxtUsuario.Enabled = False
        TxtContrasena.Enabled = False
    End Sub

    Private Sub RBTieneAccesoSistema_CheckedChanged(sender As Object, e As EventArgs) Handles RBTieneAccesoSistema.CheckedChanged
        TxtUsuario.Enabled = True
        TxtContrasena.Enabled = True
    End Sub

    Private Sub BtnCerrarSesion_Click_1(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
    End Sub

    Private Sub BtnAgregarRol_Click(sender As Object, e As EventArgs) Handles BtnAgregarRol.Click
        FrmCargando.MostarConTiempoEnCargar(200)
        FrmRol.Activate()
        FrmRol.Show()
    End Sub

    Private Sub CBEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEstado.SelectedIndexChanged
        'If CBEstado.Text = "Activo" And CBRol.Text = "Empleado" Then
        '    RBTieneAccesoSistema.Enabled = False
        '    RBNoTieneAccesoSistema.Enabled = False
        'ElseIf CBEstado.Text = "Desactivado" And CBRol.Text = "Empleado" Then
        '    RBTieneAccesoSistema.Enabled = False
        '    RBNoTieneAccesoSistema.Enabled = False
        'End If

        If CBEstado.Text = "Desactivado" Then
            'CBEstado.Text = "Desactivado"
            RBTieneAccesoSistema.Checked = False
            RBNoTieneAccesoSistema.Checked = True

            RBTieneAccesoSistema.Enabled = False
            RBNoTieneAccesoSistema.Enabled = False
        ElseIf CBEstado.Text = "Activo" Then
            'CBEstado.Text = "Activo"
            RBTieneAccesoSistema.Enabled = True
            RBNoTieneAccesoSistema.Enabled = True
            'If CBRol.Text = "Empleado" Then
            '    RBTieneAccesoSistema.Enabled = False
            '    RBNoTieneAccesoSistema.Enabled = False
            'End If

            If TxtUsuario.Text <> "" And TxtContrasena.Text <> "" Then
                RBTieneAccesoSistema.Checked = True
                RBNoTieneAccesoSistema.Checked = False

                RBTieneAccesoSistema.Enabled = True
                RBNoTieneAccesoSistema.Enabled = True
            Else
                RBTieneAccesoSistema.Checked = False
                RBNoTieneAccesoSistema.Checked = True

                RBTieneAccesoSistema.Enabled = True
                RBNoTieneAccesoSistema.Enabled = True
            End If
        End If
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
        Me.Close()
        FrmGenero.Close()
        FrmRol.Close()
        FrmListadoUsuarios.Close()
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        Me.Close()
        FrmGenero.Close()
        FrmRol.Close()
        FrmListadoUsuarios.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        Me.Close()
        FrmGenero.Close()
        FrmRol.Close()
        FrmListadoUsuarios.Close()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        Me.Close()
        FrmGenero.Close()
        FrmRol.Close()
        FrmListadoUsuarios.Close()
    End Sub

    Private Sub TxtNombreUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreUsuario.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtPaternoUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPaternoUsuario.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtMaternoUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMaternoUsuario.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtTelefonoUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefonoUsuario.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtIdentificacionUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtIdentificacionUsuario.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtDireccionUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccionUsuario.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub TxtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsuario.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub TxtContrasena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContrasena.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmGenero.Close()
        FrmRol.Close()
        FrmPermiso.Close()
    End Sub

    Private Sub FrmAdministracionUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "ListadoUsuarios" Then
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub

    Private Sub TimerOcultar_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If TimerOcultar.Interval = 8000 Then
            PBAlt.Visible = False
            LabelAlt.Visible = False
        End If
    End Sub

    Private Sub FrmAdministracionUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub
End Class
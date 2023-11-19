Public Class FrmMenuAdministracion
    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub FrmMenuAdministracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()
        BtnUsuarios.Select()

    End Sub

    Private Sub BtnCerrarSesion_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        'cnx.Close()
        FrmInicioSesión.Show()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmListadoUsuarios.Close()
        FrmListadoClientes.Close()
        FrmListadoHabitaciones.Close()
        FrmListadoFolio.Close()
        FrmAdministracionFolio.Close()
        FrmListadoCobros.Close()
        FrmTurno.Close()
        FrmReportes.Close()
        FrmAcercaDe.Close()
    End Sub

    Private Sub BtnPantallaInicio_Click_1(sender As Object, e As EventArgs)
        abiertoDesde = ""
        'If ModuloGlobal.BuscarFormularioActivo("FrmMenuPrincipal") Then
        FrmCargando.MostarConTiempoEnCargar(700)
            FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
        ' Else
        ' FrmCargando.MostarConTiempoEnCargar(800)
        '     FrmMenuPrincipal.Activate()
        '  FrmMenuPrincipal.Show()
        '  End If
        CerrarVentanasCascada()
        ModuloGlobal.modoSuperUsuario = False
        Me.Close()
    End Sub

    Private Sub BtnRegresar_Click_1(sender As Object, e As EventArgs)
        If ModuloGlobal.BuscarFormularioActivo("FrmMenuPrincipal") Then
            FrmCargando.MostarConTiempoEnCargar(300)
            FrmMenuPrincipal.Show()
        Else
            FrmCargando.MostarConTiempoEnCargar(500)
            FrmMenuPrincipal.Show()
        End If
        CerrarVentanasCascada()
        ModuloGlobal.modoSuperUsuario = False
        Me.Hide()
    End Sub

    Private Sub BtnCerrarSesion_Click_2(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Activate()
        FrmCerrarSesion.Show()
    End Sub


    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        abiertoDesde = "MenuAdmin"
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            ' If ModuloGlobal.BuscarFormularioActivo("FrmListadoUsuarios") Then
            'FrmCargando.MostarConTiempoEnCargar(700)
            'FrmListadoUsuarios.Activate()
            'FrmListadoUsuarios.Show()
            'Else
            FrmCargando.MostarConTiempoEnCargar(700)
            FrmListadoUsuarios.Activate()
                FrmListadoUsuarios.Show()
            '  End If
        Else
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Nothing, Nothing)
            FrmAutorizacion.Activate()
            FrmAutorizacion.Show()
        End If

    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs)
        abiertoDesde = "MenuAdmin"
        'If ModuloGlobal.BuscarFormularioActivo("FrmListadoUsuarios") Then
        FrmCargando.MostarConTiempoEnCargar(700)
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
        'Else
        'FrmCargando.MostarConTiempoEnCargar(800)
        'FrmListadoUsuarios.Activate()
        'FrmListadoUsuarios.Show()
        'End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'If ModuloGlobal.BuscarFormularioActivo("FrmListadoClientes") Then
        '    FrmCargando.MostarConTiempoEnCargar(300)
        '    FrmListadoClientes.Show()
        'Else
        '    FrmCargando.MostarConTiempoEnCargar(900)
        '    FrmListadoClientes.Show()
        'End If
        abiertoDesde = "MenuAdmin"
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
    End Sub

    Private Sub BtnCaja_Click(sender As Object, e As EventArgs) Handles BtnCaja.Click
        'If ModuloGlobal.BuscarFormularioActivo("FrmTurno") Then
        'FrmCargando.MostarConTiempoEnCargar(700)
        'FrmTurno.Activate()
        ' FrmTurno.Show()
        ' Else
        FrmCargando.MostarConTiempoEnCargar(800)
            FrmTurno.Activate()
            FrmTurno.Show()
        ' End If
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs)
        abiertoDesde = "MenuAdmin"
        ' If ModuloGlobal.BuscarFormularioActivo("FrmListadoClientes") Then
        'FrmCargando.MostarConTiempoEnCargar(300)
        ' FrmListadoClientes.Activate()
        ' FrmListadoClientes.Show()
        ' Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Show()
            FrmListadoClientes.Activate()
        ' End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnHabitacion.Click
        abiertoDesde = "MenuAdmin"
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 
        FrmMetodoPago.Show()
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = "MenuAdmin"
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        CerrarVentanasCascada()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs)
        abiertoDesde = "MenuAdmin"
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
    End Sub

    Private Sub FrmMenuAdministracion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ModuloGlobal.modoSuperUsuario = False
        If cerradoDesde <> "CierreTotal" Then
            FrmMenuPrincipal.Show()
        End If
        CerrarVentanasCascada()
    End Sub

    Private Sub BtnCobro_Click(sender As Object, e As EventArgs) Handles BtnCobro.Click
        abiertoDesde = "MenuAdmin"
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmListadoCobros.Activate()
        FrmListadoCobros.Show()
    End Sub

    Private Sub BtnAdministracion_Click(sender As Object, e As EventArgs) Handles BtnAdministracion.Click
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmReportes.Activate()
        FrmReportes.Show()
    End Sub

    Private Sub BtnAcercaDe_Click(sender As Object, e As EventArgs) Handles BtnAcercaDe.Click
        abiertoDesde = "MenuAdmin"
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmAcercaDe.Activate()
        FrmAcercaDe.Show()
    End Sub

    Private Sub BtnAdminFolio_Click(sender As Object, e As EventArgs) Handles BtnAdminFolio.Click
        abiertoDesde = "MenuAdmin"
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
    End Sub
End Class
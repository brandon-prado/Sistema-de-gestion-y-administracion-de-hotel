Public Class FrmReportes
    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs) Handles BtnPantallaInicio.Click
        'If ModuloGlobal.BuscarFormularioActivo("FrmMenuPrincipal") Then
        'FrmCargando.MostarConTiempoEnCargar(300)
        'FrmMenuPrincipal.Show()
        'Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Activate()
        FrmMenuPrincipal.Show()
        'End If
        'FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        If nombreRol = "Contador" Then
            Me.Close()
        Else
            FrmMenuAdministracion.Show()
            Me.Close()
        End If

    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs) Handles BtnPantallaUsuarios.Click
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmListadoUsuarios.Show()
            Me.Close()
            'AQUI FALTA CERRAR TODAS LAS VENTANAS QUE DEPENDAN DE ESTE FORM
        Else
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Nothing, Me)
            FrmAutorizacion.Show()
        End If
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaHabitaciones.Click
        'If ModuloGlobal.BuscarFormularioActivo("FrmAdministrarHabitacion") Then
        'FrmCargando.MostarConTiempoEnCargar(500)
        'FrmListadoHabitaciones.Show()

        'Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
        ' End If
        'FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs) Handles BtnPantallaClientes.Click
        'If ModuloGlobal.BuscarFormularioActivo("FrmListadoClientes") Then
        'FrmCargando.MostarConTiempoEnCargar(500)
        'FrmListadoClientes.Show()

        ' Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        ' End If
        'FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaReservaciones.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        'FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub FrmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs) Handles BtnPantallaFolios.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        Me.Close()
    End Sub

    Private Sub BtnTurno_Click(sender As Object, e As EventArgs) Handles BtnTurno.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        Try
            FrmTurno.turno.PoblarDataGridTurno(FrmTurno.DGVTurnos)
            FrmTurno.ImprimirReporteTurno()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnReservaciones_Click(sender As Object, e As EventArgs) Handles BtnReservaciones.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        FrmListadoReservaciones.PoblarDGVTodasReservaciones()
        FrmListadoReservaciones.ImprimirReporteReservaciones()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnTodosClientes.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        FrmListadoClientes.clientes.ConsultaTodosClientes(FrmListadoClientes.DGVListadoClientes)
        FrmListadoClientes.ImprimirReporteReservaciones("Todo")
    End Sub

    Private Sub BtnClientesActivos_Click(sender As Object, e As EventArgs) Handles BtnClientesActivos.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        FrmListadoClientes.clientes.ConsultaClientesActivos(FrmListadoClientes.DGVListadoClientes)
        FrmListadoClientes.ImprimirReporteReservaciones("Activos")
    End Sub

    Private Sub BtnClientesCheckOut_Click(sender As Object, e As EventArgs) Handles BtnClientesCheckOut.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        FrmListadoClientes.clientes.ConsultaClientesConCheckOut(FrmListadoClientes.DGVListadoClientes)
        FrmListadoClientes.ImprimirReporteReservaciones("CheckOut")
    End Sub

    Private Sub BtnClientesDesactivados_Click(sender As Object, e As EventArgs) Handles BtnClientesDesactivados.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        FrmListadoClientes.clientes.ConsultaClientesDesactivados(FrmListadoClientes.DGVListadoClientes)
        FrmListadoClientes.ImprimirReporteReservaciones("Desactivado")
    End Sub

    Private Sub FrmReportes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If nombreRol = "Contador" Then
            'If MsgBox("¿ESTÁS SEGURO (A) DE CERRAR SESIÓN", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ' Me.Hide()
            FrmInicioSesión.Show()
            ' Else
            ' e.Cancel = True
            ' End If
        Else
            FrmMenuAdministracion.Show()
            '   Me.Hide()
        End If
    End Sub

    Private Sub BtnReservacionFecha_Click(sender As Object, e As EventArgs) Handles BtnReservacionFecha.Click
        'FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        If nombreRol = "Contador" Then
            abiertoDesde = "Reportes"
            MsgBox("ABRIENDO APARTADO PARA IMPRIMIR REPORTES DE RESERVACIÓN, NO TIENES PRIVILEGIO PARA MODIFICAR, SOLO DE LECTURA", vbInformation)
            FrmListadoReservaciones.Show()
            FrmListadoReservaciones.BtnPantallaInicio.Enabled = False
            FrmListadoReservaciones.BtnPantallaUsuarios.Enabled = False
            FrmListadoReservaciones.BtnPantallaHabitaciones.Enabled = False
            FrmListadoReservaciones.BtnPantallaClientes.Enabled = False
            FrmListadoReservaciones.BtnPantallaReservaciones.Enabled = False
            FrmListadoReservaciones.BtnPantallaFolios.Enabled = False
            FrmListadoReservaciones.BtnConfirmarCheckInReal.Visible = False
            FrmListadoReservaciones.BtnConfirmarCheckOutReal.Visible = False
            FrmListadoReservaciones.BtnConfirmarCheckOutReal.Visible = False
            FrmListadoReservaciones.BtnCalendario.Visible = False
            FrmListadoReservaciones.BtnNuevaReservacion.Visible = False
            FrmListadoReservaciones.BtnModificarReservacion.Visible = False
            Me.Hide()
        ElseIf nombreRol = "Administrador" Or nombreRol = "Encargado" Then
            FrmListadoReservaciones.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub BtnTodosUsuarios_Click(sender As Object, e As EventArgs) Handles BtnTodosUsuarios.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        FrmListadoUsuarios.usuarios.getSetFiltro = "TODO"
        FrmListadoUsuarios.usuarios.PoblarDataGridUsuarios(FrmListadoUsuarios.DGVListadoUsuarios)
        FrmListadoUsuarios.ImprimirReporteUsuarios()
    End Sub

    Private Sub BtnCobrosFecha_Click(sender As Object, e As EventArgs) Handles BtnCobrosFecha.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        FrmListadoCobros.Activate()
        FrmListadoCobros.Show()
    End Sub

    Private Sub BtnTodoCobros_Click(sender As Object, e As EventArgs) Handles BtnTodoCobros.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        FrmListadoCobros.modoImpresion = "Todo"
        FrmListadoCobros.PoblarDGVTodoIngresos()
        FrmListadoCobros.ImprimirReporteIngreso()
    End Sub

    Private Sub BtnTodoEgreso_Click(sender As Object, e As EventArgs) Handles BtnTodoEgreso.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        FrmListadoEgreso.modoImpresion = "Todo"
        FrmListadoEgreso.PoblarDGVTodosEgresos()
        FrmListadoEgreso.ImprimirReporteEgreso()
    End Sub

    Private Sub BtnEgresosFecha_Click(sender As Object, e As EventArgs) Handles BtnEgresosFecha.Click
        'FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        If nombreRol = "Contador" Then
            abiertoDesde = "Reportes"
            MsgBox("ABRIENDO APARTADO PARA IMPRIMIR REPORTES DE EGRESOS, NO TIENES PRIVILEGIO PARA MODIFICAR, SOLO DE LECTURA", vbInformation)
            FrmListadoEgreso.Show()
            FrmListadoEgreso.BtnPantallaInicio.Enabled = False
            FrmListadoEgreso.BtnPantallaUsuarios.Enabled = False
            FrmListadoEgreso.BtnPantallaHabitaciones.Enabled = False
            FrmListadoEgreso.BtnPantallaClientes.Enabled = False
            FrmListadoEgreso.BtnPantallaReservaciones.Enabled = False
            FrmListadoEgreso.BtnPantallaFolios.Enabled = False
            Me.Hide()
        ElseIf nombreRol = "Administrador" Or nombreRol = "Encargado" Then
            FrmListadoEgreso.Activate()
            FrmListadoEgreso.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub BtnClientesFecha_Click(sender As Object, e As EventArgs)
        ComprobarEstadoIncial()
    End Sub

    Private Sub BtnCerrarSesion_Click_1(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
    End Sub

    Private Sub BtnTurnoFecha_Click(sender As Object, e As EventArgs)
        ComprobarEstadoIncial()
    End Sub
End Class
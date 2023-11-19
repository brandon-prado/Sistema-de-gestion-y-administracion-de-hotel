Public Class FrmCalendarioReservaciones
    Public reservacion As New ReservacionHasHabitacion
    Public penalizacion As String = "No"
    Public idReservacion As Integer
    Public numeroHabitacion As Integer
    Private fechaHoy As Date = Format(CDate(Today), "dd/MM/yy")

    Dim fechaInicio As Date
    Dim fechaFin As Date

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar.DateChanged
        'Obtener la fecha de la selección hecha
        fechaInicio = MonthCalendar.SelectionStart
        fechaFin = MonthCalendar.SelectionEnd
        'Formatear fecha para que Oracle la reconozca
        fechaInicio = Format(fechaInicio, "dd/MM/yyyy")
        fechaFin = Format(fechaFin, "dd/MM/yyyy")
        'Asignar valor obtenido a los txt de inicio y fin
        TxtFechaInicial.Text = fechaInicio
        TxtFechaFinal.Text = fechaFin
    End Sub

    Private Sub ListaRangoReservaciones()
        Dim strSql As String
        Dim xCnx As New Oracle
        Try
            strSql = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", r.id_cliente AS ""ID CLIENTE"", r.id_usuario AS ""ID USUARIO"", 
                        rh.check_in_prog AS ""CHECK IN PROGRAMADO"", rh.check_out_prog AS ""CHECK OUT PROGRAMADO"", rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"",
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"", c.nombre_cliente AS ""NOMBRE"",
                        h.precio_habitacion AS ""PRECIO X NOCHE"", 
                        h.capacidad_habitacion AS ""CAPACIDAD"", th.nombre_tipo_hab AS ""TIPO DE HABITACIÓN"", rh.check_in_real AS ""CHECK IN REAL"", rh.check_out_real AS ""CHECK OUT REAL"",  
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", 
                        rh.estado_reservacion AS ""ESTADO RESERVACIÓN"", r.nota_reservacion AS ""NOTA""
                      FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
                      WHERE rh.numero_habitacion = h.numero_habitacion
                      AND h.id_tipo_hab = th.id_tipo_hab
                      AND rh.id_reservacion = r.id_reservacion
                      AND r.id_usuario = u.id_usuario
                      AND r.id_cliente = c.id_cliente
                      AND rh.check_in_prog >= TO_DATE ('" & fechaInicio & " 12:00:00 AM', 'DD/MM/YYYY HH:MI:SS AM')
                      AND rh.check_in_prog <= TO_DATE ('" & fechaFin & " 11:59:59 PM', 'DD/MM/YYYY HH:MI:SS PM')
                      OR rh.check_in_prog = TO_DATE ('" & fechaInicio & "', 'DD/MM/YYYY')
                      ORDER BY rh.check_in_prog ASC"

            DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
            'OCULTAR COLUMNA DEL DGV INNECESARIAS
            DGVListadoReservaciones.Columns(0).Visible = False
            DGVListadoReservaciones.Columns(1).Visible = False
            DGVListadoReservaciones.Columns(2).Visible = False
            DGVListadoReservaciones.Columns(9).Visible = False
            DGVListadoReservaciones.Refresh()
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmCalendarioReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'Datos iniciales
        fechaInicio = fechaHoy
        fechaFin = fechaHoy
        TxtFechaInicial.Text = fechaHoy
        TxtFechaFinal.Text = fechaHoy
        ListaRangoReservaciones()

        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarReservacion.Visible = False

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
        FrmRegistroReservacion.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
            FrmRegistroReservacion.Close()
            Me.Hide()
        Else
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Me, Nothing)
            FrmListadoUsuarios.Activate()
            FrmAutorizacion.Show()
        End If
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
        FrmRegistroReservacion.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        FrmRegistroReservacion.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        FrmRegistroReservacion.Close()
        Me.Close()
    End Sub

    Private Sub BtnConfirmarCheckInReal_Click(sender As Object, e As EventArgs)
        Try
            reservacion.GetSetIdReservacion = idReservacion
            reservacion.GetSetNumeroHabitacion = numeroHabitacion
            reservacion.ConfirmarCheckInReal()
            ListaRangoReservaciones()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnNuevaReservacion_Click(sender As Object, e As EventArgs) Handles BtnNuevaReservacion.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        'Bloquear fecha, esta se desbloquea una vez que se selecciona el cliente para la reservacion, PASO 1
        FrmRegistroReservacion.DateTimeFechaIngreso.Enabled = False
        FrmRegistroReservacion.DateTimeFechaSalida.Enabled = False
        FrmRegistroReservacion.BtnConfirmaFechaProgramada.Enabled = False

        'Bloquea controles del tercer paso, este se desbloquea hasta completar el segundo paso
        FrmRegistroReservacion.BntAsignarHabitacion.Enabled = False
        FrmRegistroReservacion.BtnQuitarHabitacion.Enabled = False

        'Ocultar Check 1, 2 y 3, estos se mostrarán conforme se vayan completando los pasos 1, 2 y 3
        FrmRegistroReservacion.CheckPaso1.Visible = False
        FrmRegistroReservacion.CheckPaso2.Visible = False
        FrmRegistroReservacion.CheckPaso3.Visible = False

        'Ocultar aviso, este se hace visible cuando se hace la primera asignación de habitación
        FrmRegistroReservacion.LbAviso2.Visible = False
        FrmRegistroReservacion.LbAviso3.Visible = False

        'Estado inicial para nuev areservación
        FrmRegistroReservacion.idReservacion = 0
        FrmRegistroReservacion.TxtNombreCliente.Text = ""
        'HABILITA Paso 1
        FrmRegistroReservacion.BtnSeleccionarCliente.Enabled = True
        FrmRegistroReservacion.BtnCrearReservacion.Enabled = False
        FrmRegistroReservacion.BtnNotaReservacion.Enabled = False
        'INHABILITA Paso 2 y 3
        FrmRegistroReservacion.DateTimeFechaIngreso.Enabled = False
        FrmRegistroReservacion.DateTimeFechaSalida.Enabled = False
        FrmRegistroReservacion.BtnConfirmaFechaProgramada.Enabled = False
        FrmRegistroReservacion.DGVHabitacionesDisponibles.DataSource = ""
        FrmRegistroReservacion.DGVHabitacionesAsignadas.DataSource = ""
        FrmRegistroReservacion.DGVDatoHabitacion.DataSource = ""
        'Desactiva boton de modificacion
        BtnModificarReservacion.Visible = False
        'Bloquear boton de modificar
        BtnModificarReservacion.Visible = False
        FrmRegistroReservacion.Show()
        'Permiso para salir, mientras no se realice el paso 1
        FrmRegistroReservacion.permisoSalir = True
        'Abierto desde
        abiertoDesde = "Calendario"
        'Cerrar ventana actual
        Me.Hide()
    End Sub

    Private Sub DGVListadoReservaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListadoReservaciones.CellContentClick
        Dim renglon As Integer
        renglon = DGVListadoReservaciones.CurrentCellAddress.Y
        FrmAdministracionClientes.cliente.PoblarComboBoxGenero()
        Try
            idReservacion = DGVListadoReservaciones.Rows(renglon).Cells(0).Value
            FrmRegistroReservacion.idReservacion = DGVListadoReservaciones.Rows(renglon).Cells(0).Value
            FrmRegistroReservacion.TxtNombreCliente.Text = DGVListadoReservaciones.Rows(renglon).Cells(6).Value
            numeroHabitacion = DGVListadoReservaciones.Rows(renglon).Cells(5).Value
            'checkInProg = DGVListadoReservaciones.Rows(renglon).Cells(12).Value
            'Inhabilita Paso 1
            FrmRegistroReservacion.BtnSeleccionarCliente.Enabled = False
            FrmRegistroReservacion.BtnCrearReservacion.Enabled = False
            FrmRegistroReservacion.BtnNotaReservacion.Enabled = False
            'Habilita Paso 2 y 3
            FrmRegistroReservacion.DateTimeFechaIngreso.Enabled = True
            FrmRegistroReservacion.DateTimeFechaSalida.Enabled = True
            FrmRegistroReservacion.BtnConfirmaFechaProgramada.Enabled = True
            FrmRegistroReservacion.PoblarDGVHabitacionesAsignadas()
            'Activar boton de modificacion
            BtnModificarReservacion.Visible = True
            'Si no tiene check in real, se activa el boton que hace ese procedimiento de asignar el check in real
            'If IsDBNull(DGVListadoReservaciones.Rows(renglon).Cells(13).Value) Then
            '    If DGVListadoReservaciones.Rows(renglon).Cells(16).Value = "Cancelada" Then
            '        BtnConfirmarCheckInReal.Visible = False
            '    Else
            '        BtnConfirmarCheckInReal.Visible = True
            '    End If

            'Else
            '    BtnConfirmarCheckInReal.Visible = False
            'End If
            'bloquear modificacion si ya hay check in
            If IsDBNull(DGVListadoReservaciones.Rows(renglon).Cells(14).Value) And IsDBNull(DGVListadoReservaciones.Rows(renglon).Cells(15).Value) Then
                BtnModificarReservacion.Visible = True
            Else
                BtnModificarReservacion.Visible = False
            End If
        Catch ex As Exception
            ' MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub MonthCalendar_MouseCaptureChanged(sender As Object, e As EventArgs) Handles MonthCalendar.MouseCaptureChanged
        ListaRangoReservaciones()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Activate()
        FrmCerrarSesion.Show()
    End Sub

    'Private Sub MonthCalendar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MonthCalendar.KeyPress
    '    ListaRangoReservaciones()
    'End Sub

    Private Sub DGVListadoReservaciones_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVListadoReservaciones.CellFormatting
        If e.ColumnIndex = 16 Then
            Dim row As DataGridViewCell = DGVListadoReservaciones(e.ColumnIndex, e.RowIndex)
            Select Case row.Value
                Case "Activa"
                    row.Style.BackColor = Color.Green
                    row.Style.ForeColor = Color.White
                Case "Check Out"
                    row.Style.BackColor = Color.Aquamarine
                Case "Cancelada"
                    row.Style.BackColor = Color.Red
                    row.Style.ForeColor = Color.White
            End Select
        End If
    End Sub

    Private Sub BtnModificarReservacion_Click(sender As Object, e As EventArgs) Handles BtnModificarReservacion.Click
        If ModuloGlobal.BuscarFormularioActivo("FrmRegistroReservacion") Then
            FrmCargando.MostarConTiempoEnCargar(500)
            FrmRegistroReservacion.Show()

        Else
            FrmCargando.MostarConTiempoEnCargar(900)
            FrmRegistroReservacion.Show()
        End If
        penalizacion = "Si"
        'Permiso para salir, mientras no se realice el paso 1
        FrmRegistroReservacion.permisoSalir = True
        'Abierto desde
        abiertoDesde = "Calendario"
        'Desactivar boton de modificacion
        BtnModificarReservacion.Visible = False
        Me.Hide()
    End Sub

    Private Sub FrmCalendarioReservaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnNuevaReservacion.PerformClick()
        End If
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CerrarVentanasCascada()
        FrmRegistroReservacion.Close()
        FrmSeleccionarCliente.Close()
    End Sub

    Private Sub FrmCalendarioReservaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "ListadoReservaciones" Then
            FrmListadoReservaciones.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub
End Class
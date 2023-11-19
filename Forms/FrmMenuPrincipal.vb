Public Class FrmMenuPrincipal
    Private strSql As String
    Private xCnx As New Oracle
    Private fechaHoy As Date = Format(CDate(Today), "dd/MM/yy")

    Private Sub FrmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        OcultarEnCascada()

        FrmCerrarSesion.Show()
    End Sub

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar primero el formulario y luego seguir
        Application.DoEvents()
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True
        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        Me.ToolTip1.SetToolTip(Me.BtnCerrarSesion, "Cerrar ventana y sesión en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnReservaciones, "Clic para mostrar y registrar reservaciones en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnClientes, "Clic para mostrar y registrar clientes en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnHabitaciones, "Clic para mostrar las habitaciones del sistema")
        Me.ToolTip1.SetToolTip(Me.BtnFolios, "Clic para mostrar y registrar folios en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnServicioExtra, "Clic para mostrar y registrar servicios prestados al cliente")
        Me.ToolTip1.SetToolTip(Me.BtnCobro, "Clic para mostrar y registrar cobros en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnCaja, "Clic para mostrar a detalle los montos de caja en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnAdministracion, "Clic para mostrar y administras aspectos en el sistema")
        Me.ToolTip1.SetToolTip(Me.DGVCheckInProg, "Información de Check In programados a partir del día de hoy en el sistema")
        Me.ToolTip1.SetToolTip(Me.DGVCheckOutProg, "Información de Check Out programados a partir del día de hoy en el sistema")
        Me.ToolTip1.SetToolTip(Me.BtnCerrarSesion, "Clic para cerrar sesión en el sistema")

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        ReservacionesDelDiaCI()
        ReservacionesDelDiaCO()
    End Sub

    Private Sub BtnAdministracion_Click(sender As Object, e As EventArgs) Handles BtnAdministracion.Click
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Then
            If ModuloGlobal.BuscarFormularioActivo("FrmMenuAdministracion") Then
                FrmCargando.MostarConTiempoEnCargar(700)
                FrmMenuAdministracion.Activate()
                FrmMenuAdministracion.Show()
            Else
                FrmCargando.MostarConTiempoEnCargar(1000)
                FrmMenuAdministracion.Activate()
                FrmMenuAdministracion.Show()
            End If
            Me.Hide()
        Else
            FrmAutorizacion.Formulario(FrmMenuAdministracion, Me, Nothing)
            FrmAutorizacion.Activate()
            FrmAutorizacion.Show()
        End If
    End Sub

    Private Sub FechaHora_Tick_1(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()

    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        abiertoDesde = "MenuPrincipal"
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
    End Sub

    Private Sub BtnCaja_Click(sender As Object, e As EventArgs) Handles BtnCaja.Click
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmTurno.Activate()
        FrmTurno.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmMetodoPago.Show()
    End Sub

    Private Sub BtnReservaciones_Click(sender As Object, e As EventArgs) Handles BtnReservaciones.Click
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FrmSeleccionarCliente.Show()

    End Sub

    Private Sub BtnHabitaciones_Click(sender As Object, e As EventArgs) Handles BtnHabitaciones.Click
        abiertoDesde = "MenuPrincipal"
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
    End Sub

    Private Sub BtnServicioExtra_Click(sender As Object, e As EventArgs) Handles BtnServicioExtra.Click
        abiertoDesde = "MenuPrincipal"
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmCargoExtra.Activate()
        FrmCargoExtra.Show()
    End Sub

    'MÉTODO QUE CONSULTA LOS CLIENTES CON CHECK OUT EN UNA FECHA DETERMINADA
    Public Sub ReservacionesDelDiaCI()
        Try
            'MsgBox(fechaHoy)
            Dim fecha As String = fechaHoy.ToString & "00:00"
            strSql = "SELECT rh.numero_habitacion AS ""NÚMERO HABITACIÓN"", rh.check_in_prog AS ""CHECK IN PROG."", 
                    c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE""
                  FROM Folio f, Reservacion r, Cliente c, Reservacion_has_Habitacion rh
                  WHERE f.id_reservacion = r.id_reservacion
                  AND r.id_cliente = c.id_cliente
                  AND rh.id_reservacion = r.id_reservacion
                  AND rh.check_in_prog >= '" & fechaHoy & "'
                  AND rh.estado_reservacion = 'Activa'
                  AND rh.check_in_real IS NULL
                  ORDER BY rh.check_in_prog DESC"

            DGVCheckInProg.DataSource = xCnx.objetoDataAdapter(strSql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'OCULTAR COLUMNA DEL DGV ID
        'DGVListadoReservaciones.Columns(0).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    'MÉTODO QUE CONSULTA LOS CLIENTES CON CHECK OUT EN UNA FECHA DETERMINADA
    Public Sub ReservacionesDelDiaCO()
        Try
            strSql = "SELECT rh.numero_habitacion AS ""NÚMERO HABITACIÓN"", rh.check_out_prog AS ""CHECK OUT PROG."", 
                c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE""
                FROM Folio f, Reservacion r, Cliente c, Reservacion_has_Habitacion rh
                WHERE f.id_reservacion = r.id_reservacion
                AND r.id_cliente = c.id_cliente
                AND rh.id_reservacion = r.id_reservacion
                AND rh.check_out_prog >= SYSDATE
                AND rh.estado_reservacion = 'Activa' 
                AND rh.check_out_real IS NULL
                ORDER BY rh.check_in_prog DESC"

            DGVCheckOutProg.DataSource = xCnx.objetoDataAdapter(strSql)
        Catch ex As Exception

        End Try


        'OCULTAR COLUMNA DEL DGV ID
        'DGVListadoReservaciones.Columns(0).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    Private Sub DateTimeFechaCI_ValueChanged(sender As Object, e As EventArgs)
        ReservacionesDelDiaCI()
    End Sub

    Private Sub DateTimeFechaCO_ValueChanged(sender As Object, e As EventArgs)
        ReservacionesDelDiaCO()
    End Sub

    Private Sub BtnFolios_Click(sender As Object, e As EventArgs) Handles BtnFolios.Click
        abiertoDesde = "MenuPrincipal"
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
    End Sub

    Private Sub BtnCobro_Click(sender As Object, e As EventArgs) Handles BtnCobro.Click
        FrmCargando.MostarConTiempoEnCargar(800)
        abiertoDesde = "MenuPrincipal"
        FrmAdministracionFolio.Activate()
        FrmAdministracionFolio.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        MsgBox(idTurnoActual)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) 
        FrmCierreTurno.show
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)
        FrmMetodoPago.Show()
    End Sub

    Private Sub DGVCheckInProg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCheckInProg.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVCheckOutProg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCheckOutProg.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
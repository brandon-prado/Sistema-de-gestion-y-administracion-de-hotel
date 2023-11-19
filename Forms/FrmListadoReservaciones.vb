Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Oracle.DataAccess.Client

Public Class FrmListadoReservaciones
    Public reservacion As New ReservacionHasHabitacion
    Public penalizacion As String = "No"
    Public idReservacion As Integer
    Public numeroHabitacion As Integer
    Public idCliente As Integer
    Private modoImpresion As String = "Todo"
    'Obtener la fecha actual
    Private fechaHoy As Date = Format(CDate(Today), "dd/MM/yy")
    'Private fechaHoy As Date = Format(Today, "dd/MM/yy hh:mm")
    Private checkInProg As Date
    Private checkOutProg As Date

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Private Sub BtnNuevaReservacion_Click(sender As Object, e As EventArgs) Handles BtnNuevaReservacion.Click
        FrmCargando.Close()
        FrmCargando.MostarConTiempoEnCargar(700)

        'Activa primer paso
        FrmRegistroReservacion.BtnSeleccionarCliente.Enabled = True

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
        'FrmRegistroReservacion.BtnSeleccionarCliente.Enabled = True
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
        abiertoDesde = "Listado"
        'Cerrar ventana actual
        Me.Hide()
    End Sub

    Private Sub FrmListadoReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarReservacion.Visible = False

        'Poblar el DGV
        RbMostrarTodasReservaciones.Checked = True

        'BOTON DE CONFIRMAR CHECK IN y CHECK OUT
        BtnConfirmarCheckInReal.Enabled = False
        BtnConfirmarCheckOutReal.Enabled = False
    End Sub

    'Método que muestra en el DGV todas las reservaciones realizadas
    Public Sub PoblarDGVTodasReservaciones()
        strSql = "SELECT * FROM Vista_Todo_Reserv_Has_Hab"

        DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoReservaciones.Columns(0).Visible = False
        DGVListadoReservaciones.Columns(1).Visible = False
        DGVListadoReservaciones.Columns(2).Visible = False
        DGVListadoReservaciones.Columns(7).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    'Método que muestra en el DGV las reservaciones con estado activo
    Private Sub PoblarDGVReservacionesActivas()
        'ESTA CONSULTA UTILIZA UNA SUBCONSULTA PARA RESTAR UN CONJUNTO
        strSql = "SELECT * FROM Vista_Reserv_Has_Hab_Activa"

        DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoReservaciones.Columns(0).Visible = False
        DGVListadoReservaciones.Columns(1).Visible = False
        DGVListadoReservaciones.Columns(2).Visible = False
        DGVListadoReservaciones.Columns(7).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    'Método que muestra en el DGV las reservaciones con estado Cancelado
    Private Sub PoblarDGVReservacionesCanceladas()
        'ESTA CONSULTA UTILIZA UNA SUBCONSULTA PARA RESTAR UN CONJUNTO
        strSql = "SELECT * FROM Vista_Reserv_Has_Hab_Cancelada"

        DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoReservaciones.Columns(0).Visible = False
        DGVListadoReservaciones.Columns(1).Visible = False
        DGVListadoReservaciones.Columns(2).Visible = False
        DGVListadoReservaciones.Columns(7).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    'Método que muestra en el DGV las reservaciones con estado Cancelado
    Private Sub PoblarDGVReservacionesConCheckOut()
        'ESTA CONSULTA UTILIZA UNA SUBCONSULTA PARA RESTAR UN CONJUNTO
        strSql = "SELECT * FROM Vista_Reserv_Has_Hab_CheckOut"

        DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
        ' DGVListadoReservaciones.Refresh()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        If nombreRol = "Contador" Then
            FrmReportes.Show()
            Me.Close()
        End If
        Me.Close()
        FrmCargando.Close()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Activate()
        FrmCerrarSesion.Show()
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub RbMostrarTodasReservaciones_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarTodasReservaciones.CheckedChanged
        modoImpresion = "Todo"
        PoblarDGVTodasReservaciones()
    End Sub

    Private Sub DGVListadoReservaciones_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGVListadoReservaciones.CellFormatting
        Try
            If e.ColumnIndex = 17 Then
                Dim row As DataGridViewCell = DGVListadoReservaciones(e.ColumnIndex, e.RowIndex)
                Select Case row.Value
                    Case "Activa"
                        row.Style.BackColor = Color.Green
                        row.Style.ForeColor = Color.White
                    Case "Check Out"
                        row.Style.BackColor = Color.Aquamarine
                        row.Style.ForeColor = Color.Black
                    Case "Cancelada"
                        row.Style.BackColor = Color.Red
                        row.Style.ForeColor = Color.White
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RbMostrarReservacionesActivas_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarReservacionesActivas.CheckedChanged
        modoImpresion = "Activas"
        PoblarDGVReservacionesActivas()
    End Sub

    Private Sub RbMostrarReservacionesCanceladas_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarReservacionesCanceladas.CheckedChanged
        modoImpresion = "Canceladas"
        PoblarDGVReservacionesCanceladas()
    End Sub

    Private Sub RbMostrarReservacionesConCheckOut_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarReservacionesConCheckOut.CheckedChanged
        modoImpresion = "Todo Check Out"
        PoblarDGVReservacionesConCheckOut()
    End Sub

    Private Sub CBBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscarPor.SelectedIndexChanged
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub TxtDatoBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtDatoBuscar.TextChanged
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim datoB As String

        RbMostrarTodasReservaciones.Checked = True

        'El dato ingresado es convertido en minúscula
        datoB = LCase(TxtDatoBuscar.Text)

        If CBBuscarPor.Text = "Nombre" Then
            strSql = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", r.id_cliente AS ""ID CLIENTE"", r.id_usuario AS ""ID USUARIO"", r.fecha_hora_reservacion AS ""FECHA DE LA RESERVACIÓN"", 
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"", c.nombre_cliente AS ""NOMBRE"",
                        rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", h.precio_habitacion AS ""PRECIO X NOCHE"", 
                        h.capacidad_habitacion AS ""CAPACIDAD"", th.nombre_tipo_hab AS ""TIPO DE HABITACIÓN"", rh.check_in_prog AS ""CHECK IN PROGRAMADO"",
                        rh.check_out_prog AS ""CHECK OUT PROGRAMADO"", rh.check_in_real AS ""CHECK IN REAL"", rh.check_out_real AS ""CHECK OUT REAL"",  
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", 
                        rh.estado_reservacion AS ""ESTADO RESERVACIÓN"", r.nota_reservacion AS ""NOTA""
                      FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
                      WHERE rh.numero_habitacion = h.numero_habitacion
                      AND h.id_tipo_hab = th.id_tipo_hab
                      AND rh.id_reservacion = r.id_reservacion
                      AND r.id_usuario = u.id_usuario
                      AND r.id_cliente = c.id_cliente
                      AND lower(c.nombre_cliente) LIKE '%" & datoB & "%'
                      ORDER BY rh.check_in_prog DESC"

            DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoReservaciones.Refresh()

        ElseIf CBBuscarPor.Text = "Identificación" Then
            strSql = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", r.id_cliente AS ""ID CLIENTE"", r.id_usuario AS ""ID USUARIO"", r.fecha_hora_reservacion AS ""FECHA DE LA RESERVACIÓN"", 
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"", c.nombre_cliente AS ""NOMBRE"",
                        rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", h.precio_habitacion AS ""PRECIO X NOCHE"", 
                        h.capacidad_habitacion AS ""CAPACIDAD"", th.nombre_tipo_hab AS ""TIPO DE HABITACIÓN"", rh.check_in_prog AS ""CHECK IN PROGRAMADO"",
                        rh.check_out_prog AS ""CHECK OUT PROGRAMADO"", rh.check_in_real AS ""CHECK IN REAL"", rh.check_out_real AS ""CHECK OUT REAL"",  
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", 
                        rh.estado_reservacion AS ""ESTADO RESERVACIÓN"", r.nota_reservacion AS ""NOTA""
                      FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
                      WHERE rh.numero_habitacion = h.numero_habitacion
                      AND h.id_tipo_hab = th.id_tipo_hab
                      AND rh.id_reservacion = r.id_reservacion
                      AND r.id_usuario = u.id_usuario
                      AND r.id_cliente = c.id_cliente
                      AND lower(c.identificacion_cliente) LIKE '%" & datoB & "%'
                      ORDER BY rh.check_in_prog DESC"
            DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoReservaciones.Refresh()

        ElseIf CBBuscarPor.Text = "Teléfono" Then
            strSql = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", r.id_cliente AS ""ID CLIENTE"", r.id_usuario AS ""ID USUARIO"", r.fecha_hora_reservacion AS ""FECHA DE LA RESERVACIÓN"", 
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"", c.nombre_cliente AS ""NOMBRE"",
                        rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", h.precio_habitacion AS ""PRECIO X NOCHE"", 
                        h.capacidad_habitacion AS ""CAPACIDAD"", th.nombre_tipo_hab AS ""TIPO DE HABITACIÓN"", rh.check_in_prog AS ""CHECK IN PROGRAMADO"",
                        rh.check_out_prog AS ""CHECK OUT PROGRAMADO"", rh.check_in_real AS ""CHECK IN REAL"", rh.check_out_real AS ""CHECK OUT REAL"",  
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", 
                        rh.estado_reservacion AS ""ESTADO RESERVACIÓN"", r.nota_reservacion AS ""NOTA""
                      FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
                      WHERE rh.numero_habitacion = h.numero_habitacion
                      AND h.id_tipo_hab = th.id_tipo_hab
                      AND rh.id_reservacion = r.id_reservacion
                      AND r.id_usuario = u.id_usuario
                      AND r.id_cliente = c.id_cliente
                      AND lower(c.telefono_cliente) LIKE '%" & datoB & "%'
                      ORDER BY rh.check_in_prog DESC"
            DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoReservaciones.Refresh()

        ElseIf CBBuscarPor.Text = "Número de habitación" Then
            strSql = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", r.id_cliente AS ""ID CLIENTE"", r.id_usuario AS ""ID USUARIO"", r.fecha_hora_reservacion AS ""FECHA DE LA RESERVACIÓN"", 
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"", c.nombre_cliente AS ""NOMBRE"",
                        rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", h.precio_habitacion AS ""PRECIO X NOCHE"", 
                        h.capacidad_habitacion AS ""CAPACIDAD"", th.nombre_tipo_hab AS ""TIPO DE HABITACIÓN"", rh.check_in_prog AS ""CHECK IN PROGRAMADO"",
                        rh.check_out_prog AS ""CHECK OUT PROGRAMADO"", rh.check_in_real AS ""CHECK IN REAL"", rh.check_out_real AS ""CHECK OUT REAL"",  
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", 
                        rh.estado_reservacion AS ""ESTADO RESERVACIÓN"", r.nota_reservacion AS ""NOTA""
                      FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
                      WHERE rh.numero_habitacion = h.numero_habitacion
                      AND h.id_tipo_hab = th.id_tipo_hab
                      AND rh.id_reservacion = r.id_reservacion
                      AND r.id_usuario = u.id_usuario
                      AND r.id_cliente = c.id_cliente
                      AND rh.numero_habitacion = '" & datoB & "'
                      ORDER BY rh.check_in_prog DESC"
            DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoReservaciones.Refresh()
        End If
    End Sub

    Private Sub BtnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles BtnLimpiarBusqueda.Click
        TxtDatoBuscar.Text = ""
    End Sub

    'MÉTODO QUE CONSULTA LOS CLIENTES CON CHECK OUT EN UNA FECHA DETERMINADA
    Public Sub ConsultaRangoReservacionesCheckOut()
        strSql = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", r.id_cliente AS ""ID CLIENTE"", r.id_usuario AS ""ID USUARIO"", r.fecha_hora_reservacion AS ""FECHA DE LA RESERVACIÓN"", 
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"", c.nombre_cliente AS ""NOMBRE"",
                        rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", h.precio_habitacion AS ""PRECIO X NOCHE"", 
                        h.capacidad_habitacion AS ""CAPACIDAD"", th.nombre_tipo_hab AS ""TIPO DE HABITACIÓN"", rh.check_in_prog AS ""CHECK IN PROGRAMADO"",
                        rh.check_out_prog AS ""CHECK OUT PROGRAMADO"", rh.check_in_real AS ""CHECK IN REAL"", rh.check_out_real AS ""CHECK OUT REAL"",  
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", 
                        rh.estado_reservacion AS ""ESTADO RESERVACIÓN"", r.nota_reservacion AS ""NOTA""
                      FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
                      WHERE rh.numero_habitacion = h.numero_habitacion
                      AND h.id_tipo_hab = th.id_tipo_hab
                      AND rh.id_reservacion = r.id_reservacion
                      AND r.id_usuario = u.id_usuario
                      AND r.id_cliente = c.id_cliente
                 AND rh.check_in_real >= '" & DateTimeFechaInicial.Text & "'
                 AND rh.check_out_real <= '" & DateTimeFechaFinal.Text & "'
                 AND rh.estado_reservacion = 'Check Out'
                 ORDER BY rh.check_in_prog DESC"

        DGVListadoReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)

        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoReservaciones.Columns(0).Visible = False
        DGVListadoReservaciones.Columns(1).Visible = False
        DGVListadoReservaciones.Columns(2).Visible = False
        DGVListadoReservaciones.Columns(7).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    Private Sub BtnBuscarReservaciones_Click(sender As Object, e As EventArgs) Handles BtnBuscarReservaciones.Click
        modoImpresion = "RangoFecha"
        RbMostrarReservacionesConCheckOut.Checked = True
        If DateTimeFechaInicial.Text = "" And DateTimeFechaFinal.Text = "" Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            ConsultaRangoReservacionesCheckOut()
        End If
    End Sub

    Private Sub DGVListadoReservaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListadoReservaciones.CellContentClick
        Dim renglon As Integer
        renglon = DGVListadoReservaciones.CurrentCellAddress.Y
        FrmAdministracionClientes.cliente.PoblarComboBoxGenero()
        Try
            If nombreRol <> "Contador" Then
                idReservacion = DGVListadoReservaciones.Rows(renglon).Cells(0).Value
                FrmRegistroReservacion.idReservacion = DGVListadoReservaciones.Rows(renglon).Cells(0).Value
                idCliente = DGVListadoReservaciones.Rows(renglon).Cells(1).Value
                FrmRegistroReservacion.TxtNombreCliente.Text = DGVListadoReservaciones.Rows(renglon).Cells(4).Value
                numeroHabitacion = DGVListadoReservaciones.Rows(renglon).Cells(8).Value
                checkInProg = DGVListadoReservaciones.Rows(renglon).Cells(12).Value
                checkOutProg = DGVListadoReservaciones.Rows(renglon).Cells(13).Value
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


                If IsDBNull(DGVListadoReservaciones.Rows(renglon).Cells(14).Value) Then
                    If DGVListadoReservaciones.Rows(renglon).Cells(17).Value = "Cancelada" Then
                        BtnConfirmarCheckInReal.Enabled = False
                    Else
                        If IsDBNull(DGVListadoReservaciones.Rows(renglon).Cells(15).Value) And IsDBNull(DGVListadoReservaciones.Rows(renglon).Cells(14).Value) Then
                            BtnConfirmarCheckInReal.Enabled = True
                            BtnConfirmarCheckOutReal.Enabled = False
                        End If

                    End If
                    BtnConfirmarCheckOutReal.Enabled = False
                Else
                    BtnConfirmarCheckInReal.Enabled = False
                    If DGVListadoReservaciones.Rows(renglon).Cells(17).Value = "Activa" Then
                        'Si no tiene check out real Y EL CHECK IN RELA ESTA LLENO, se activa el boton que hace ese procedimiento de asignar el check out real
                        If IsDBNull(DGVListadoReservaciones.Rows(renglon).Cells(15).Value) Then
                            BtnConfirmarCheckInReal.Enabled = False
                            BtnConfirmarCheckOutReal.Enabled = True
                        End If

                    End If

                End If

                'bloquear modificacion si ya hay check in
                If IsDBNull(DGVListadoReservaciones.Rows(renglon).Cells(14).Value) And IsDBNull(DGVListadoReservaciones.Rows(renglon).Cells(15).Value) Then
                    BtnModificarReservacion.Visible = True
                Else
                    BtnModificarReservacion.Visible = False
                End If
            End If



        Catch ex As Exception
            ' MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnModificarReservacion_Click(sender As Object, e As EventArgs) Handles BtnModificarReservacion.Click
        'If ModuloGlobal.BuscarFormularioActivo("FrmRegistroReservacion") Then
        'FrmCargando.MostarConTiempoEnCargar(500)
        'FrmRegistroReservacion.Show()

        'Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmRegistroReservacion.Show()
        'End If
        penalizacion = "Si"
        'Permiso para salir, mientras no se realice el paso 1
        FrmRegistroReservacion.permisoSalir = True
        'Abierto desde
        abiertoDesde = "Listado"
        'Desactivar boton de modificacion
        BtnModificarReservacion.Visible = False

    End Sub

    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs) Handles BtnPantallaInicio.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Activate()
        FrmMenuPrincipal.Show()
        FrmRegistroReservacion.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs) Handles BtnPantallaUsuarios.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
            FrmRegistroReservacion.Close()
            Me.Hide()
        Else
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Me, Nothing)
            FrmAutorizacion.Activate()
            FrmAutorizacion.Show()
        End If
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaHabitaciones.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
        FrmRegistroReservacion.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs) Handles BtnPantallaClientes.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        FrmRegistroReservacion.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs) Handles BtnPantallaFolios.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        FrmRegistroReservacion.Close()
        Me.Close()
    End Sub

    Private Sub BtnConfirmarCheckInReal_Click(sender As Object, e As EventArgs) Handles BtnConfirmarCheckInReal.Click
        If Date.Now >= checkInProg And Date.Now <= checkOutProg Then
            reservacion.GetSetIdReservacion = idReservacion
            reservacion.GetSetNumeroHabitacion = numeroHabitacion
            reservacion.ConfirmarCheckInReal()
            PoblarDGVTodasReservaciones()
        ElseIf Date.Now > checkInProg And Date.Now > checkOutProg Then
            Dim pregunta As String = MsgBox("RESERVACIÓN FUERA DE TIEMPO " + vbCr + vbCr + " ¿QUÉ DESEAS REALIZAR? " + vbCr + vbCr + "-> SÍ - FORZAR CHECK IN DE HABITACIÓN." + vbCr + "-> NO - NO HACER NADA." + vbCr + "-> CANCELAR - CANCELAR RESERVACIÓN DE HABITACIÓN.", MessageBoxButtons.YesNoCancel + vbQuestion)
            If pregunta = vbYes Then
                reservacion.GetSetIdReservacion = idReservacion
                reservacion.GetSetNumeroHabitacion = numeroHabitacion
                reservacion.ConfirmarCheckInReal()
                PoblarDGVTodasReservaciones()
            ElseIf pregunta = vbCancel Then
                reservacion.GetSetIdReservacion = idReservacion
                reservacion.GetSetNumeroHabitacion = numeroHabitacion
                CancelarHabEnReservHasHab()
                PoblarDGVTodasReservaciones()
            End If
        Else
            MsgBox("AUN NO ES TIEMPO DE HACER CHECK In", vbExclamation)
        End If
        'Actualiza DGV MenuPrincipal
        ActualizarDGVMenuPrincipal()
        BtnConfirmarCheckInReal.Enabled = False
    End Sub

    Private Sub BtnConfirmarCheckOutReal_Click(sender As Object, e As EventArgs) Handles BtnConfirmarCheckOutReal.Click
        If Date.Now > checkInProg And Date.Now <= checkOutProg Then
            If ChecarAdeudoCliente() Then
                FrmAviso.LbMensaje.Text = "NO SE PUEDE REALIZAR CHECK OUT, HAY CARGOS PENDIENTES DE PAGAR, VE AL APARTADO DE PAGO"
                FrmAviso.Show()
            Else
                reservacion.GetSetIdReservacion = idReservacion
                reservacion.GetSetNumeroHabitacion = numeroHabitacion
                reservacion.ConfirmaCheckOutReal()
                ActualizarClienteConCheckOut()
                PoblarDGVTodasReservaciones()
            End If

        ElseIf Date.Now > checkInProg And Date.Now > checkOutProg Then
            Dim pregunta As String = MsgBox("CHECK OUT FUERA DE TIEMPO " + vbCr + vbCr + " ¿QUÉ DESEAS REALIZAR? " + vbCr + vbCr + "-> SÍ - FORZAR CHECK OUT DE HABITACIÓN." + vbCr + "-> NO - NO HACER NADA.", MessageBoxButtons.YesNo + vbQuestion)
            If pregunta = vbYes Then
                If ChecarAdeudoCliente() Then
                    FrmAviso.LbMensaje.Text = "NO SE PUEDE REALIZAR CHECK OUT, HAY CARGOS PENDIENTES DE PAGAR, VE AL APARTADO DE PAGO"
                    FrmAviso.Show()
                Else
                    reservacion.GetSetIdReservacion = idReservacion
                    reservacion.GetSetNumeroHabitacion = numeroHabitacion
                    reservacion.ConfirmaCheckOutReal()
                    ActualizarClienteConCheckOut()
                    PoblarDGVTodasReservaciones()
                End If
            End If
        Else
            MsgBox("AUN NO ES TIEMPO DE HACER CHECK OUT", vbExclamation)
        End If
        'Actualiza DGV MenuPrincipal
        ActualizarDGVMenuPrincipal()
        BtnConfirmarCheckOutReal.Enabled = False
    End Sub

    'Checar si un cliente tiene habitaciones activas para ponerlo ocn check out

    Public Function ConsultaSiSigueTeniendoReservacion() As Boolean
        strSql = "Select rh.numero_habitacion 
From Reservacion r, Reservacion_has_Habitacion rh, Cliente c
Where r.id_reservacion = rh.id_reservacion
And r.id_cliente = c.id_cliente
And rh.estado_reservacion = 'Activa'
And r.id_cliente = " & idCliente


        ConsultaSiSigueTeniendoReservacion = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count >= 1 Then
            ConsultaSiSigueTeniendoReservacion = True
        End If
    End Function

    'Poner un cliente con estado check out o activo
    Public Sub ActualizarClienteConCheckOut()
        If ConsultaSiSigueTeniendoReservacion() Then
            'Pone el cliente como activo
            strSql = "UPDATE Cliente SET estado_cliente = 'Activo' WHERE id_cliente = " & idCliente
            xCnx.objetoCommand(strSql)
        Else
            'Pone el cliente como check out
            strSql = "UPDATE Cliente SET estado_cliente = 'Check Out' WHERE id_cliente = " & idCliente
            xCnx.objetoCommand(strSql)
        End If
    End Sub

    'Checar si un liente tiene adeudo y denegar check out
    Public Function ChecarAdeudoCliente() As Boolean
        CantidadPagadaDeudora()
        Dim cantidadTotal As Double = precioTotalCargosExtra + precioTotalHabitaciones

        ChecarAdeudoCliente = False
        If (cantidadTotal - cantidadPagada) > 0 Then
            ChecarAdeudoCliente = True
        End If
    End Function


    'Método que consulta si la cuenta esta pagada, no pagada o parcialmente pagada
    Public cantidadPagada As Double
    Public precioTotalCargosExtra As Double
    Public precioTotalHabitaciones As Double


    Public Sub CantidadPagadaDeudora()
        Try
            Dim xDT As New DataTable
            Dim str As New OracleDataAdapter("SELECT id_folio, SUM(cantidad_pago) As ""CANTIDAD PAGADA""	
                                                    FROM Pago
                                                    WHERE id_folio = " & idReservacion & "
                                                    GROUP BY id_folio", cnx)

            str.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                cantidadPagada = registro("CANTIDAD PAGADA").ToString
            Next

            Dim xDT2 As New DataTable
            Dim str2 As New OracleDataAdapter("SELECT rh.id_reservacion, SUM(ROUND((rh.check_out_prog - rh.check_in_prog), 2) * h.precio_habitacion) As ""PRECIO TOTAL""	
                                                    FROM Reservacion_has_Habitacion rh, Habitacion h, Reservacion r
                                                    WHERE rh.numero_habitacion = h.numero_habitacion
                                                    AND rh.id_reservacion = r.id_reservacion
                                                    AND estado_reservacion = 'Activa'
                                                    AND rh.id_reservacion = " & idReservacion & "
                                                    GROUP BY rh.id_reservacion", cnx)

            str2.Fill(xDT2)
            For Each registro As DataRow In xDT2.Rows
                precioTotalHabitaciones = registro("PRECIO TOTAL").ToString
            Next

            Dim xDT3 As New DataTable
            Dim str3 As New OracleDataAdapter("SELECT id_folio, SUM(precio_total) As ""CARGO TOTAL""	
                                                    FROM Cargo_extra
                                                    WHERE id_folio = " & idReservacion & "
                                                    GROUP BY id_folio", cnx)

            str3.Fill(xDT3)
            For Each registro As DataRow In xDT3.Rows
                precioTotalCargosExtra = registro("CARGO TOTAL").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Checa si no tiene mas habitaciones, entonces se cancela la reservacion y el folio
    Public Function ConsultaSiTieneMasHabitaciones() As Boolean
        strSql = "SELECT id_reservacion 
                    FROM Reservacion_has_Habitacion 
                    WHERE id_reservacion = " & idReservacion & " AND estado_reservacion = 'Activa'"


        ConsultaSiTieneMasHabitaciones = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count >= 1 Then
            ConsultaSiTieneMasHabitaciones = True
        End If
    End Function



    'Método que cancela una habitacion
    Public Sub CancelarHabEnReservHasHab()
        strSql = "UPDATE Reservacion_has_Habitacion Set estado_reservacion = 'Cancelada' WHERE id_reservacion = " & idReservacion & " AND numero_habitacion = " & numeroHabitacion
        xCnx.objetoCommand(strSql)
        If ConsultaSiSigueOcupada() Then
            'Pone la habitacion como disponible
            strSql = "UPDATE Habitacion SET estado_habitacion = 'Ocupada' WHERE numero_habitacion = " & numeroHabitacion
            xCnx.objetoCommand(strSql)
        Else
            'Pone la habitacion como disponible
            strSql = "UPDATE Habitacion SET estado_habitacion = 'Disponible' WHERE numero_habitacion = " & numeroHabitacion
            xCnx.objetoCommand(strSql)
        End If
        'Actualiza estado de folio o lo cancela
        If ConsultaSiTieneMasHabitaciones() Then
            'Pone la reservacion como activa
            strSql = "UPDATE Folio SET estado_folio = 'Activo' WHERE id_folio = " & idReservacion
            xCnx.objetoCommand(strSql)
        Else
            'Pone la reservacion como cancelada
            strSql = "UPDATE Folio SET estado_folio = 'Cancelada' WHERE id_folio = " & idReservacion
            xCnx.objetoCommand(strSql)
        End If
    End Sub

    Public Function ConsultaSiSigueOcupada() As Boolean
        strSql = "SELECT numero_habitacion 
                    FROM Reservacion_has_Habitacion 
                    WHERE numero_habitacion = " & numeroHabitacion & " AND check_out_real IS NULL"


        ConsultaSiSigueOcupada = False
        xDT = xCnx.objetoDataAdapter(strSql)
        If xDT.Rows.Count >= 1 Then
            ConsultaSiSigueOcupada = True
        End If
    End Function

    Private Sub DateTimeFechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeFechaInicial.ValueChanged

    End Sub

    Private Sub TxtDatoBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatoBuscar.KeyPress
        If CBBuscarPor.Text = "Nombre" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Identificación" Then
            SoloNumero(e)
        ElseIf CBBuscarPor.Text = "Teléfono" Then
            SoloNumero(e)
        ElseIf CBBuscarPor.Text = "Número de habitación" Then
            SoloNumero(e)
        End If
    End Sub

    Private Sub BtnCalendario_Click(sender As Object, e As EventArgs) Handles BtnCalendario.Click
        abiertoDesde = "ListadoReservaciones"
        FrmCargando.MostarConTiempoEnCargar(600)
        FrmCalendarioReservaciones.Show()
        Me.Close()
    End Sub

    'Funcion para obtener el tamaño de las columnas del DGV
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            If i = 0 Or i = 1 Or i = 2 Or i = 7 Then
            Else
                values(i) = CSng(dg.Columns(i).Width)
            End If
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Try
            'Se crea documento PDFTable con el numero de columnas del DGV
            Dim dataTable As New PdfPTable(DGVListadoReservaciones.ColumnCount)
            'Propiedades del documento
            dataTable.DefaultCell.Padding = 3
            Dim headerWidth As Single() = GetColumnasSize(DGVListadoReservaciones)
            dataTable.SetWidths(headerWidth)
            dataTable.WidthPercentage = 100
            dataTable.DefaultCell.BorderWidth = 2
            dataTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
            'Encabezado del PDF
            Dim encabezado As New Paragraph("REPORTE DE RESERVACIONES", New Font(Font.Name = "Tahoma", 20, Font.Bold))
            'Se creael texto debajo del encabezado
            Dim texto As New Phrase
            'Modo de impresion
            'Se creael texto debajo del encabezado
            If modoImpresion = "Todo" Then
                texto = New Phrase("Reporte de todas las reservaciones generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            ElseIf modoImpresion = "Activas" Then
                texto = New Phrase("Reporte de todas las reservaciones activas generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            ElseIf modoImpresion = "Canceladas" Then
                texto = New Phrase("Reporte de todas las reservaciones canceladas generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            ElseIf modoImpresion = "Todo Check Out" Then
                texto = New Phrase("Reporte de todas las reservaciones con Check Out generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            ElseIf modoImpresion = "RangoFecha" Then
                Dim rangoFecha As String = DateTimeFechaInicial.Text + " a " + DateTimeFechaFinal.Text
                texto = New Phrase("Reporte de todas las reservaciones con Check Out (Con rango de fecha de " + rangoFecha + " ) generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            End If
            'Se captura los nombres de las columnas del DGV
            dataTable.AddCell("")
            dataTable.AddCell("")
            dataTable.AddCell("")
            dataTable.AddCell("FECHA RESERVACIÓN")
            dataTable.AddCell("CLIENTE")
            dataTable.AddCell("TELÉFONO")
            dataTable.AddCell("IDENTIFICACIÓN")
            dataTable.AddCell("")
            dataTable.AddCell("NÚM. HABITACIÓN")
            dataTable.AddCell("PRECIO X NOCHE")
            dataTable.AddCell("CAPACIDAD")
            dataTable.AddCell("TIPO HAB.")
            dataTable.AddCell("CHECK IN PROG.")
            dataTable.AddCell("CHECK OUT PROG.")
            dataTable.AddCell("CHECK IN REAL")
            dataTable.AddCell("CHECK OUT REAL")
            dataTable.AddCell("ATENDIDO POR")
            dataTable.AddCell("ESTADO")
            dataTable.AddCell("NOTA")
            'Se obtiene el valor de cada celda de la tabla
            For i As Integer = 0 To DGVListadoReservaciones.RowCount - 1
                For j As Integer = 0 To DGVListadoReservaciones.ColumnCount - 1
                    'If i = 0 Or i = 1 Or i = 2 Or i = 7 Then
                    'Else
                    If IsDBNull(DGVListadoReservaciones.Rows(i).Cells(j).Value) Then
                        dataTable.AddCell("Sin dato")
                    Else
                        If CStr(DGVListadoReservaciones(j, i).Value) = "" Then
                        Else
                            dataTable.AddCell(DGVListadoReservaciones(j, i).Value.ToString())
                        End If
                    End If
                    'End If

                Next
                dataTable.CompleteRow()
            Next

            'Obtener imagen para agregar al documento PDF
            Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance("C:\IDEA Software\imgLogo\logo.png")
            'image1.ScalePercent(50.0F)
            image.ScaleAbsoluteWidth(150)
            image.ScaleAbsoluteHeight(150)
            image.Alignment = Image.ALIGN_CENTER

            'Datos de contacto 
            Dim datoDeContacto = New Paragraph("Hotel Posada Favela" + vbCr + "Calle Melchor Ocampo #43, Zona Centro C. P. 27980" + vbCr + "Parras de la Fuente, Coahuila, México." + vbCr + "842 422 3566" + vbCr + "posadafavela@gmail.com", New Font(Font.Name = "Tahoma", 14, Font.Bold))
            datoDeContacto.Alignment = Element.ALIGN_CENTER

            'Se agrega el PDFTable todos los datos generados
            document.Add(encabezado)
            document.Add(texto)
            document.Add(dataTable)
            document.Add(image)
            document.Add(datoDeContacto)
        Catch ex As Exception
            '  MsgBox("Error al generar PDF: " & ex.Message)
        End Try
    End Sub

    Public Sub ImprimirReporteReservaciones()
        Try
            'Mandar a generar el docuemnto
            Dim documento As New Document(PageSize.A2.Rotate(), 10, 10, 10, 10)
            'Path que guarda el documento en la direccion de reportes 
            Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de Reservaciones.pdf"
            Dim file As New FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(documento, file)
            documento.Open()
            ExportarDatosPDF(documento)
            documento.Close()
            Process.Start(fileName)
        Catch ex As Exception
            MsgBox("Error al generar PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaReservaciones.Click

    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        ImprimirReporteReservaciones()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmRegistroReservacion.Close()
        FrmSeleccionarCliente.Close()
        FrmRegistroCliente.Close()
        FrmGenero.Close()
    End Sub

    Private Sub FrmListadoReservaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "MenuPrincipal" Then
            FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""

        If nombreRol = "Contador" Then
            FrmReportes.Activate()
            FrmReportes.Show()
        End If
    End Sub
End Class
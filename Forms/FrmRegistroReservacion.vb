Imports Oracle.DataAccess.Client

Public Class FrmRegistroReservacion
    Private reservacion As New Reservacion
    Private reservHasHab As New ReservacionHasHabitacion
    Public idReservacion As Integer
    Public numeroHabitacion As Integer
    Public fechaIngresoSeleccionada As String
    Public fechaSalidaSeleccionada As String
    Public permisoSalir As Boolean = False


    'Obtener la fecha actual y siguiente del sistema con formato
    Private fechaHoy As Date = Format(CDate(Today), "dd/MM/yy")
    Private fechaManana As Date = Format(DateAdd("d", 1, Today), "dd/MM/yy")

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Private Sub FrmRegistroReservacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para regresar a la ventana anterior y cancelar la reservación")
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Clic para registar la reservación")
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para cancelar la reservación, antes deberás quitar las habitaciones asignadas")

        'Bloquea el campo donde se muestra el nombre del cliente
        TxtNombreCliente.Enabled = False

        'Estado incial del Check in y check out, con la fecha actual
        DateTimeFechaIngreso.Value = fechaHoy
        DateTimeFechaSalida.Value = fechaManana

        'Oculto boton de modificar fecha
        BtnCorregirFecha.Visible = False

        'Bloquear botones
        BntAsignarHabitacion.Enabled = False
        BtnQuitarHabitacion.Enabled = False
    End Sub

    'Método que asigna la fecha actual al formulario
    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    'Funcion que nos dice que si la reservacion activa tiene habitaciones asignadas
    'esto nos ayudara por si queremos cancelar el proceso actual de reservacion
    Public Function ConsultaSiTieneHabAsignadas() As Boolean
        strSql = "SELECT * FROM Reservacion_has_Habitacion WHERE id_reservacion = " & idReservacion
        ConsultaSiTieneHabAsignadas = False
        Try
            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count >= 1 Then
                ConsultaSiTieneHabAsignadas = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Botón de regresa, si hay una reservación activa, pregunta para poder cancelar, en base a la funcion anterior de consulta si tiene habitaciones asignadas
    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs)
        Try
            'Se confirma si se quiere cancelar el proceso
            If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE CANCELAR LA RESERVACIÓN?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If ConsultaSiTieneHabAsignadas() Then
                    FrmAviso.LbMensaje.Text = "ELIMINA LAS HABITACIONES ASIGNADAS PARA CANCELAR"
                    FrmAviso.Show()
                Else
                    'Elimina la reservacion activa
                    reservacion.EliminarReservacion()
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Método que me permite seleccionar o buscar un cliente para realizar la reservacion, PASO 1
    Private Sub BtnSeleccionarCliente_Click(sender As Object, e As EventArgs) Handles BtnSeleccionarCliente.Click
        abiertoDesde = "RegistroReserv"
        FrmSeleccionarCliente.Show()
    End Sub

    'Método que me permite agregar una nota a la reservación del cliente seleccionado en el PASO 1
    Private Sub BtnNotaReservacion_Click(sender As Object, e As EventArgs) Handles BtnNotaReservacion.Click
        FrmNota.Show()
    End Sub

    'Función que me permite validar los requerimientos para completar el PASO 1
    Private Function ComprobarDatosPaso1() As Boolean
        ComprobarDatosPaso1 = False
        If FrmSeleccionarCliente.idCliente = 0 Or ModuloGlobal.idUsuario = 0 Then
            FrmAviso.LbMensaje.Text = "FALTAN DATOS, COMPRUEBA LOS CAMPOS CORRESPONDIENTES"
            FrmAviso.Show()
        Else
            ComprobarDatosPaso1 = True
        End If
    End Function

    'Método para crear una reservacion, PASO 1. Es pura inserción, no hay actualización
    Private Sub BtnCrearReservacion_Click(sender As Object, e As EventArgs) Handles BtnCrearReservacion.Click
        Try
            If ComprobarDatosPaso1() Then
                permisoSalir = False
                'Instanciar el objeto
                Dim reservacion As New Reservacion(idReservacion, ModuloGlobal.idUsuario, FrmSeleccionarCliente.idCliente, FrmNota.nota)
                'Insertar la reservación
                reservacion.InsertaReservacion()
                FrmCorrecto.LbMensaje.Text = "RESERVACIÓN REGISTRADA CORRECTAMENTE, AHORA ESPECÍFICA EL CHECK IN Y CHECK OUT PROGRAMADO"
                FrmCorrecto.Show()
                'Activa check 1 terminado
                CheckPaso1.Visible = True
                'Inhabilita Paso 1
                BtnSeleccionarCliente.Enabled = False
                BtnCrearReservacion.Enabled = False
                BtnNotaReservacion.Enabled = False
                'Habilita Paso 2
                DateTimeFechaIngreso.Enabled = True
                DateTimeFechaSalida.Enabled = True
                BtnConfirmaFechaProgramada.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    'Metodo para guardar en la variable local la fecha de ingreso
    Private Sub DateTimeFechaIngreso_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeFechaIngreso.ValueChanged
        fechaIngresoSeleccionada = Format(DateTimeFechaIngreso.Value, "dd/MM/yy")
    End Sub

    'Metodo para guardar en la variable local la fecha de salida
    Private Sub DateTimeFechaSalida_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeFechaSalida.ValueChanged
        fechaSalidaSeleccionada = Format(DateTimeFechaSalida.Value, "dd/MM/yy")
    End Sub

    'Función que nos permite validar las fechas ingresadas para mostrar las habitaciones disponibles
    Private Function ComprobarDatosPaso2() As Boolean
        ComprobarDatosPaso2 = False
        If DateTimeFechaIngreso.ToString = "" Or DateTimeFechaSalida.ToString = "" Then
            FrmAviso.LbMensaje.Text = "NO HAY NINGÚN DATO INGRESADO EN LA FECHA DE ENTRADA Y SALIDA"
            FrmAviso.Show()
        ElseIf (DateTimeFechaIngreso.Value > DateTimeFechaSalida.Value) Then
            FrmAviso.LbMensaje.Text = "LA FECHA DE CHECK IN (" & DateTimeFechaIngreso.Value & ") ES MAYOR A LA FECHA DE CHECK OUT (" & DateTimeFechaSalida.Value & ")"
            FrmAviso.Show()
        ElseIf (DateTimeFechaIngreso.Value < fechaHoy Or DateTimeFechaSalida.Value < fechaHoy) Then
            FrmAviso.LbMensaje.Text = "NO SE PUEDE HACER UNA RESERVACIÓN SI LA FECHA YA PASO"
            FrmAviso.Show()
        ElseIf (DateTimeFechaIngreso.Value = DateTimeFechaSalida.Value) Then
            FrmAviso.LbMensaje.Text = "EL TIEMPO ENTRE EL CHECK IN (" & DateTimeFechaIngreso.Value & ") Y EL CHECK OUT (" & DateTimeFechaSalida.Value & ") NO PUEDE SER IGUAL"
            FrmAviso.Show()
        ElseIf DateDiff("d", DateTimeFechaIngreso.Value, DateTimeFechaSalida.Value) > 365 Then
            FrmAviso.LbMensaje.Text = "EL TIEMPO DE RESERVACIÓN NO PUEDE SER MAYOR A UN AÑO (365 DÍAS)"
            FrmAviso.Show()
        Else
            ComprobarDatosPaso2 = True
        End If
    End Function

    'Método que muestra la imagen de la habitación seleccionada de los 2 DGV (Disponibles - Parcialmente disponibles y asignadas)
    Private Sub ObtenerImagen()
        'Mostrar imagen de la habitacion
        Try
            'Habitacion seleccionada
            LbHabitacionSeleccionada.Text = "Habitación seleccionada: " & numeroHabitacion
            Using stream As New System.IO.FileStream("C:\IDEA Software\imgHabitaciones\" & numeroHabitacion & ".png", IO.FileMode.Open)
                PBImagenHabitacion.Image = Image.FromStream(stream)
            End Using


        Catch ex As Exception
            'Si la habitacion no tiene ninguna imagen, se muestra la que esta por defecto
            PBImagenHabitacion.Image = My.Resources.habitacion
        End Try
    End Sub

    'Método que muestra en el DGV las habitaciones totalmente disponibles y tambien muestra las que ya estan asignadas siempre y cuando sean compatibles en la fecha de check in y check out ingresado
    Private Sub PoblarDGVHabitacionesDisponibles()
        Try
            'ESTA CONSULTA UTILIZA UNA SUBCONSULTA PARA RESTAR UN CONJUNTO
            strSql = "SELECT h.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", th.nombre_tipo_hab AS ""TIPO HABITACIÓN"",
                    h.precio_habitacion AS ""PRECIO X NOCHE"", h.capacidad_habitacion AS ""CAPACIDAD"", h.descripcion_habitacion AS ""DESCRIPCIÓN""
                  FROM Habitacion h, Tipo_Habitacion th
                  WHERE h.id_tipo_hab = th.id_tipo_hab
                  AND NOT EXISTS (SELECT NULL
                                  FROM Reservacion_has_Habitacion rh
                                  WHERE rh.numero_habitacion = h.numero_habitacion
                                  AND TO_DATE ('" & DateTimeFechaIngreso.Text & " 14:00', 'DD/MM/YY HH24:MI') <= rh.check_out_prog
                                  AND TO_DATE ('" & DateTimeFechaSalida.Text & " 13:59', 'DD/MM/YY HH24:MI') >= rh.check_in_prog
                                  AND rh.estado_reservacion <> 'Cancelada'
                                  AND rh.estado_reservacion <> 'Check Out'
                                  )
                  AND h.estado_habitacion <> 'Inactiva'
                  AND h.estado_habitacion <> 'Limpieza'
                  ORDER BY h.numero_habitacion"

            DGVHabitacionesDisponibles.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVHabitacionesDisponibles.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    'Método que depende del DGV Hab disponible, muestra la informacion del registro seleccionado de aquel DGV
    Private Sub PoblarDGVDatoHabitacion()
        Try
            strSql = "SELECT 'Está ocupada desde:   '|| TO_DATE(rh.check_in_prog, 'DD/MM/YY HH24:MI') ||'   14:00 hrs   hasta:   '|| TO_DATE(rh.check_out_prog, 'DD/MM/YY HH24:MI') ||'   13:59 hrs,   por el cliente:   '|| c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente ||'   ('|| c.telefono_cliente ||').'  AS ""INFORMACIÓN DE LA HABITACIÓN""
                    FROM Reservacion_has_Habitacion rh, Reservacion r, Cliente c
                    WHERE rh.id_reservacion = r.id_reservacion
                    AND r.id_cliente = c.id_cliente
                    AND rh.check_in_real IS NULL
                    AND rh.check_out_real IS NULL
                    AND rh.numero_habitacion = " & numeroHabitacion & "
                    AND rh.estado_reservacion <> 'Cancelada'
                    ORDER BY rh.check_in_prog ASC"


            DGVDatoHabitacion.DataSource = xCnx.objetoDataAdapter(strSql)
            'Cambiar la anchura de una columna de la tabla del DGV
            DGVDatoHabitacion.Columns.Item(0).Width = 1000
            DGVDatoHabitacion.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    'Acciones del DGV de habitaciones disponibles al seleccionar un registro
    Private Sub DGVHabitacionesDisponibles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHabitacionesDisponibles.CellContentClick
        Dim renglon As Integer
        renglon = DGVHabitacionesDisponibles.CurrentCellAddress.Y
        Try
            'Asignamos a nuestra variable local el numero de la habitación
            numeroHabitacion = DGVHabitacionesDisponibles.Rows(renglon).Cells(0).Value

            'POBLAR DGV DEL DATO DE LA HABITACION QUE SE SELECCIONO EN EL DGV DE PARCIALMENTE DISPONIBLE
            PoblarDGVDatoHabitacion()

            'Se manda hablar el metodo que cargara la imagen de la habitacion correspondiente
            ObtenerImagen()

            'Habilita el boton de asignar habitacion, pero sigue bloqueando el de quitar
            LbAgregarHabitacion.BackColor = Color.FromArgb(72, 215, 194)
            LbQuitarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
            BntAsignarHabitacion.Enabled = True
            BtnQuitarHabitacion.Enabled = False
        Catch ex As Exception
            'MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnConfirmaFechaProgramada_Click(sender As Object, e As EventArgs) Handles BtnConfirmaFechaProgramada.Click
        Try
            If ComprobarDatosPaso2() Then
                'Bloquea botones de asignar y quitar, hasta que se interactue con los DGV de habitaciones
                BntAsignarHabitacion.Enabled = False
                BtnQuitarHabitacion.Enabled = False
                DGVHabitacionesDisponibles.Enabled = True
                'Activa check 2 terminado
                CheckPaso2.Visible = True
                'Desactiva check 3 
                CheckPaso3.Visible = False
                'BORRAR EL DGV DE DATOS DE HABITACION
                DGVDatoHabitacion.DataSource = ""
                'Borra numero de habitacion seleccionado anteriormente
                numeroHabitacion = 0
                'Borra la imagen de la habitacion y su Label
                PBImagenHabitacion.Image = My.Resources.habitacion
                LbHabitacionSeleccionada.Text = "Habitación seleccionada: Ninguna"
                'Quita color de los Label
                LbAgregarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
                LbQuitarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
                'POBLAR DGV CON LA INFORMACION
                PoblarDGVHabitacionesDisponibles()
                'Inhabilitar campos de fecha
                DateTimeFechaIngreso.Enabled = False
                DateTimeFechaSalida.Enabled = False
                'Inhabilitar boton de confirmar fecha
                BtnConfirmaFechaProgramada.Enabled = False
                'Visible boton de modificar fecha
                BtnCorregirFecha.Visible = True
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    'Método que muestra en el DGV Habitaciones asignadas todas aquellas que lo son
    Public Sub PoblarDGVHabitacionesAsignadas()
        Try
            strSql = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", th.nombre_tipo_hab AS ""TIPO HABITACIÓN"",
                    h.precio_habitacion AS ""PRECIO X NOCHE"", h.capacidad_habitacion AS ""CAPACIDAD"", h.descripcion_habitacion AS ""DESCRIPCIÓN"",
                    TO_DATE(rh.check_in_prog, 'DD/MM/YY HH24:MI') AS ""CHECK IN PROGRAMADO"", TO_DATE(rh.check_out_prog, 'DD/MM/YY HH24:MI') AS ""CHECK OUT PROGRAMADO"",
                    rh.estado_reservacion AS ""ESTADO""
                  FROM Habitacion h, Tipo_Habitacion th, Reservacion_has_Habitacion rh
                  WHERE h.id_tipo_hab = th.id_tipo_hab
                  AND rh.numero_habitacion = h.numero_habitacion
                  AND rh.check_out_real IS NULL
                  AND rh.id_reservacion = " & idReservacion & " ORDER BY h.numero_habitacion ASC"

            DGVHabitacionesAsignadas.DataSource = xCnx.objetoDataAdapter(strSql)
            'OCULTAR COLUMNA DEL DGV ID
            DGVHabitacionesAsignadas.Columns(0).Visible = False
            DGVHabitacionesAsignadas.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    'Acciones del DGV Habitaciones asignadas al momento de seleccionar un registro
    Private Sub DGVHabitacionesAsignadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHabitacionesAsignadas.CellContentClick
        Dim renglon As Integer
        renglon = DGVHabitacionesAsignadas.CurrentCellAddress.Y
        Try
            'Agregar el valor de la reservacion y numero de habitacion a su variable local para poder hacer modificaciones
            idReservacion = DGVHabitacionesAsignadas.Rows(renglon).Cells(0).Value
            numeroHabitacion = DGVHabitacionesAsignadas.Rows(renglon).Cells(1).Value

            'Se manda hablar el metodo que cargara la imagen de la habitacion correspondiente
            ObtenerImagen()

            'POBLAR DGV DEL DATO DE LA HABITACION QUE SE SELECCIONO EN EL DGV DE PARCIALMENTE DISPONIBLE
            PoblarDGVDatoHabitacion()

            'Habilita el boton de quitar habitacion y bloquea el boton de asignar
            BntAsignarHabitacion.Enabled = False
            BtnQuitarHabitacion.Enabled = True
            LbAgregarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
            LbQuitarHabitacion.BackColor = Color.FromArgb(239, 111, 51)
        Catch ex As Exception
            'MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    'Método que busca el ID Activo para la reservación en curso
    Private Sub BuscaIdActivolReservacion()
        Dim xDT As New DataTable

        Try
            Dim conector As New OracleDataAdapter("SELECT MAX(id_reservacion) FROM Reservacion", cnx)
            conector.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                idReservacion = registro("MAX(id_reservacion)")
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub ActualizarDatosPago()
        FrmAdministracionFolio.folio.ConsultaDatosBasicosFolio()
        FrmAdministracionFolio.ConsultaHabLigadasAFolio()
        FrmAdministracionFolio.folio.CantidadTotalHabitaciones()
        FrmAdministracionFolio.folio.CantidadTotalCargosExtra()
        FrmAdministracionFolio.AsignarCantidadALabel()
        'FrmAdministracionFolio.EstadoCuenta()
    End Sub

    'Método que permite asignar la habitacion ya sea del DGV Totalmente disponible o del DGV Parcialmente disponible (del ultimo que se haya seleccionado)
    Private Sub BntAsignarHabitacion_Click(sender As Object, e As EventArgs) Handles BntAsignarHabitacion.Click
        Try
            'Llamar al metodo que nos dice que id de reservacion tiene el proceso actual
            BuscaIdActivolReservacion()
            'Instanciar el objeto
            Dim reservHasHab As New ReservacionHasHabitacion(idReservacion, numeroHabitacion, fechaIngresoSeleccionada + " 14:00", fechaSalidaSeleccionada + " 13:59")
            reservHasHab.InsertaReservHasHab()
            FrmCorrecto.LbMensaje.Text = "HABITACIÓN: " & numeroHabitacion & " ASIGNADA CORRECTAMENTE POR LA FECHA DE:  " & DateTimeFechaIngreso.Value & "   A   " & DateTimeFechaSalida.Value
            FrmCorrecto.Show()
            'Activa check 3 terminado
            CheckPaso3.Visible = True
            'Activa check 2 no terminado
            CheckPaso2.Visible = False
            'Actualizar DGV
            'PoblarDGVHabitacionesDisponibles()
            'Poblar DGV de habitaciones asignadas
            PoblarDGVHabitacionesAsignadas()
            'Deshabilitar DGV TDisponibles y PDisponibles, estas estaran activas hasta que se complete el paso 2 otra vez
            DGVHabitacionesDisponibles.DataSource = ""
            DGVDatoHabitacion.DataSource = ""
            'Borra fechas anteriores y asigna la actual y la de mañana
            'DateTimeFechaIngreso.Text = fechaHoy
            'DateTimeFechaSalida.Text = fechaManana
            'Borra habitacion seleccionada
            numeroHabitacion = 0
            'Mostrar avisos para guardar, cancelar o seguir escogiendo
            LbAviso2.Visible = True
            LbAviso3.Visible = True
            'Inhabilita los botones de agregar y quitar hasta que se interactue de nuevo con los DGV de Habitaciones
            BntAsignarHabitacion.Enabled = False
            BtnQuitarHabitacion.Enabled = False
            'Habilita campos de fecha y el boton de confirmar y oculta boton de modificar fecha
            DateTimeFechaIngreso.Enabled = True
            DateTimeFechaSalida.Enabled = True
            BtnConfirmaFechaProgramada.Enabled = True
            BtnCorregirFecha.Visible = False
            'Quita la imagen de la habitacion y su Label
            PBImagenHabitacion.Image = My.Resources.habitacion
            LbHabitacionSeleccionada.Text = "Habitación seleccionada: Ninguna"
            'Quita color de los Label
            LbAgregarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
            LbQuitarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
            'ACTUALIZA DGV de listado de reservaciones
            FrmListadoReservaciones.RbMostrarTodasReservaciones.Checked = True
            FrmListadoReservaciones.PoblarDGVTodasReservaciones()
            'Actualiza DGV MenuPrincipal
            ActualizarDGVMenuPrincipal()
            'Actualiza datos de pago
            'ActualizarDatosPago()
            abiertoDesde = ""
            FrmAdministracionFolio.Close()

        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    'Funcion que mermite validar datos para poder quitar una habitación previamente asignada a la reservación activa
    Private Function ComprobarDatosPaso3Borrar() As Boolean
        ComprobarDatosPaso3Borrar = False
        If numeroHabitacion = 0 And idReservacion = 0 Then
            FrmAviso.LbMensaje.Text = "SELECCIONA LA HABITACIÓN QUE DESEA QUITAR DE LA RESERVACIÓN"
            FrmAviso.Show()
        Else
            ComprobarDatosPaso3Borrar = True
        End If
    End Function

    'Metodo para poder quitar una habitación previamente asignada a la reservación activa 
    Private Sub BtnQuitarHabitacion_Click(sender As Object, e As EventArgs) Handles BtnQuitarHabitacion.Click
        Try
            If ComprobarDatosPaso3Borrar() Then
                'Modificacion de atributos del objeto nstanciado, para cambiar por medio de SET el idReservacion y numeroHabitacion
                reservHasHab.GetSetIdReservacion = idReservacion
                reservHasHab.GetSetNumeroHabitacion = numeroHabitacion
                If reservHasHab.ConsultaUnaReservHasHab() Then
                    If FrmListadoReservaciones.penalizacion = "No" Then
                        reservHasHab.EliminarReservHasHab()
                        FrmCorrecto.LbMensaje.Text = "SE HA QUITADO LA HABITACIÓN: " & numeroHabitacion & " DE LA RESERVACIÓN"
                        FrmCorrecto.Show()
                        'Poblar DGV de habitaciones asignadas
                        PoblarDGVHabitacionesAsignadas()
                        'Actualizar DGV
                        'PoblarDGVHabitacionesDisponibles()
                        'PoblarDGVDatoHabitacion()
                        'Quita color de los Label
                        LbAgregarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
                        LbQuitarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
                        'Deshabilitar DGV TDisponibles y PDisponibles, estas estaran activas hasta que se complete el paso 2 otra vez
                        DGVHabitacionesDisponibles.DataSource = ""
                        DGVDatoHabitacion.DataSource = ""
                        'Borra habitacion seleccionada
                        numeroHabitacion = 0
                        'Inhabilita el boton de quitar habitacion
                        BtnQuitarHabitacion.Enabled = False
                        'Quita la imagen de la habitacion y su Label
                        PBImagenHabitacion.Image = My.Resources.habitacion
                        LbHabitacionSeleccionada.Text = "Habitación seleccionada: Ninguna"
                        'Actualiza datos de pago
                        'ActualizarDatosPago()
                        abiertoDesde = ""
                        FrmAdministracionFolio.Close()

                    ElseIf FrmListadoReservaciones.penalizacion = "Si" Then
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE CANCELAR LA RESERVACIÓN, ESTO PUEDE GENERAR UN COBRO EXTRA?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Modificacion de atributos del objeto nstanciado, para cambiar por medio de SET el idReservacion y numeroHabitacion
                            reservHasHab.GetSetIdReservacion = idReservacion
                            reservHasHab.GetSetNumeroHabitacion = numeroHabitacion
                            reservHasHab.CancelarHabEnReservHasHab()
                            FrmCorrecto.LbMensaje.Text = "SE HA CANCELADO LA HABITACIÓN: " & numeroHabitacion & " DE LA RESERVACIÓN"
                            FrmCorrecto.Show()
                            PoblarDGVHabitacionesAsignadas()
                            DGVDatoHabitacion.DataSource = ""
                            'Inhabilita el boton de quitar habitacion
                            BtnQuitarHabitacion.Enabled = False
                            'Actualiza datos de pago
                            'ActualizarDatosPago()
                            FrmAdministracionFolio.Close()
                        End If
                    End If
                    'ACTUALIZA DGV de listado de reservaciones
                    FrmListadoReservaciones.RbMostrarTodasReservaciones.Checked = True
                    FrmListadoReservaciones.PoblarDGVTodasReservaciones()
                    'Actualiza DGV MenuPrincipal
                    ActualizarDGVMenuPrincipal()
                Else
                    FrmAviso.LbMensaje.Text = "LA RESERVACIÓN CON LA HABITACIÓN NO EXISTE"
                    FrmAviso.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
        End Try

    End Sub

    'Método que manda el mensaje de reservacion exitosa, ya que todo el proceso ya se hizo, siempre y cuando tenga una habitacion como minimo asignada
    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        If ConsultaSiTieneHabAsignadas() Then
            If permisoSalir = True Then
                FrmCorrecto.LbMensaje.Text = "CAMBIOS REALIZADOS"
                FrmCorrecto.Show()
            Else
                FrmCorrecto.LbMensaje.Text = "RESERVACIÓN CONFIRMADA, ¡GRACIAS POR TU PREFERENCIA!"
                FrmCorrecto.Show()
            End If

            'Limpia datos de la reservación
            idReservacion = 0
            numeroHabitacion = 0
            fechaIngresoSeleccionada = ""
            fechaSalidaSeleccionada = ""
            'Actualiza DGV MenuPrincipal
            ActualizarDGVMenuPrincipal()
            Me.Close()
        Else
            FrmAviso.LbMensaje.Text = "FALTAN PASOS PARA CONFIRMAR LA RESERVACIÓN"
            FrmAviso.Show()
        End If

    End Sub

    'Método que sirve por si queremos salir de la reservacion en curso, primero se deben eliminar las habitaciones asignadas
    'cuando ya no tenga ninguna asignada, se procede a borrar la reservacion actual, ya que este proceso no puede estar en segundo plano o en espera
    Private Sub CancelarReservacion()
        Try
            BuscaIdActivolReservacion()
            If permisoSalir = True Then
                Me.Close()
            Else
                'Se confirma si se quiere cancelar el proceso
                If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE CANCELAR EL PROCESO?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    If ConsultaSiTieneHabAsignadas() Then
                        FrmAviso.LbMensaje.Text = "ELIMINA LAS HABITACIONES ASIGNADAS PARA CANCELAR LA RESERVACIÓN"
                        FrmAviso.Show()
                    Else
                        'Elimina la reservacion activa
                        reservacion.GetSetIdReservacion = idReservacion
                        reservacion.EliminarReservacion()
                        idReservacion = 0
                        numeroHabitacion = 0
                        fechaIngresoSeleccionada = ""
                        fechaSalidaSeleccionada = ""
                        BtnCrearReservacion.Enabled = False
                        FrmNota.Close()
                        'Actualiza DGV MenuPrincipal
                        ActualizarDGVMenuPrincipal()
                        Me.Close()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnRegresar_Click_1(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Try
            CancelarReservacion()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub FrmRegistroReservacion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub BtnCorregirFecha_Click(sender As Object, e As EventArgs) Handles BtnCorregirFecha.Click
        'Habilitar campos de fecha
        DateTimeFechaIngreso.Enabled = True
        DateTimeFechaSalida.Enabled = True
        BtnConfirmaFechaProgramada.Enabled = True
        'Borrar resultados en el DGV de habitaciones disponibles
        DGVHabitacionesDisponibles.DataSource = ""
        DGVDatoHabitacion.DataSource = ""
        'Ocultar boton de modificar fecha
        BtnCorregirFecha.Visible = False
        'Borra la imagen de la habitacion y su Label
        PBImagenHabitacion.Image = My.Resources.habitacion
        LbHabitacionSeleccionada.Text = "Habitación seleccionada: Ninguna"
        'Quita color de los Label
        LbAgregarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
        LbQuitarHabitacion.BackColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MsgBox("id reservacion: " & idReservacion & " numero habitacion: " & numeroHabitacion)
    End Sub

    Private Sub FrmRegistroReservacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmGenero.Close()
        FrmRegistroCliente.Close()
        FrmSeleccionarCliente.Close()
        FrmNota.Close()
    End Sub

    Private Sub FrmRegistroReservacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "Listado" Then
            FrmListadoReservaciones.Show()
        ElseIf abiertoDesde = "Calendario" Then
            FrmCalendarioReservaciones.Show()
        Else
            FrmListadoReservaciones.Show()
        End If
        abiertoDesde = ""
        CerrarVentanasCascada()
    End Sub

    Private Sub DGVDatoHabitacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDatoHabitacion.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
Public Class FrmSeleccionarFolio
    Public idFolio As Integer
    Public idReservacion As Integer
    Public numeroHabitacion As Integer
    Public datoReservacion As String

    Private strSql As String
    Private xCnx As New Oracle
    Private Sub FrmSeleccionarFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True
        'Cargar primero el formulario y luego seguir
        Application.DoEvents()
        'Poblar el DGV
        ConsultaTodasReservaciones()
        ''Ocultar columna de ID de cliente y género
        'DGVClientes.Columns(0).Visible = False
        'DGVClientes.Columns(1).Visible = False
        'Busqueda por defecto
        CBBuscarPor.Text = "Nombre"
        'Desactiva boton de aceptar
        BtnMostrarDeTodas.Visible = False
        BtnAceptar.Visible = False
    End Sub

    'MÉTODO QUE CONSULTA TODOS LAS RESERVACIONES
    Public Sub ConsultaTodasReservaciones()
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT * FROM Vista_Todas_Reserv_Carg_Extra"

        DGVReservaciones.DataSource = xCnx.objetoDataAdapter(strSQL)
        DGVReservaciones.Refresh()

        'Ocultar columna de ID de folio, usuario, nombre, paterno, 
        DGVReservaciones.Columns(0).Visible = False
        DGVReservaciones.Columns(1).Visible = False
        DGVReservaciones.Columns(4).Visible = False
        DGVReservaciones.Columns(5).Visible = False
    End Sub

    'MÉTODO QUE CONSULTA TODAS LAS HABITACIONES LIGADAS A LA RESERVACION SELECCIONADA
    Public Sub ConsultaHabLigadasAReserv()
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", th.nombre_tipo_hab AS ""TIPO HABITACIÓN"",
                    h.precio_habitacion AS ""PRECIO X NOCHE"", h.capacidad_habitacion AS ""CAPACIDAD"", h.descripcion_habitacion AS ""DESCRIPCIÓN"",
                    TO_DATE(rh.check_in_prog, 'DD/MM/YY HH24:MI') AS ""CHECK IN PROGRAMADO"", TO_DATE(rh.check_out_prog, 'DD/MM/YY HH24:MI') AS ""CHECK OUT PROGRAMADO"",
                    rh.estado_reservacion AS ""ESTADO""
                  FROM Habitacion h, Tipo_Habitacion th, Reservacion_has_Habitacion rh
                  WHERE h.id_tipo_hab = th.id_tipo_hab
                  AND rh.numero_habitacion = h.numero_habitacion
                  AND rh.id_reservacion = " & idReservacion & " 
                  ORDER BY h.numero_habitacion ASC"

        DGVHabitacionesLigadasReserv.DataSource = xCnx.objetoDataAdapter(strSQL)
        'Ocultar columna de ID
        DGVHabitacionesLigadasReserv.Columns(0).Visible = False
        DGVHabitacionesLigadasReserv.Refresh()


    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub TxtDatoBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtDatoBuscar.TextChanged
        Dim datoB As String
        'El dato ingresado es convertido en minúscula
        datoB = LCase(TxtDatoBuscar.Text)

        If CBBuscarPor.Text = "Nombre cliente" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_usuario AS ""ID USUARIO"", f.id_reservacion AS ""NÚMERO DE RESERVACIÓN"",
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.nombre_cliente, c.paterno_cliente, c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR""
                    FROM Folio f, Reservacion r, Usuario u, Cliente c, Reservacion_has_Habitacion rh
                    WHERE f.id_reservacion = r.id_reservacion
                    AND f.id_usuario = u.id_usuario
                    AND r.id_cliente = c.id_cliente
                    AND rh.id_reservacion = r.id_reservacion
                    AND rh.estado_reservacion <> 'Cancelada'
                    AND rh.estado_reservacion <> 'Check Out'
                    AND lower(c.nombre_cliente) LIKE '%" & datoB & "%'
                    GROUP BY f.id_folio, f.id_usuario, f.id_reservacion, c.nombre_cliente, c.paterno_cliente, c.materno_cliente, c.telefono_cliente, c.identificacion_cliente, u.nombre_usuario,  u.paterno_usuario, u.materno_usuario"
            DGVReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVReservaciones.Refresh()

        ElseIf CBBuscarPor.Text = "Apellido paterno cliente" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_usuario AS ""ID USUARIO"", f.id_reservacion AS ""NÚMERO DE RESERVACIÓN"",
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.nombre_cliente, c.paterno_cliente, c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR""
                    FROM Folio f, Reservacion r, Usuario u, Cliente c, Reservacion_has_Habitacion rh
                    WHERE f.id_reservacion = r.id_reservacion
                    AND f.id_usuario = u.id_usuario
                    AND r.id_cliente = c.id_cliente
                    AND rh.id_reservacion = r.id_reservacion
                    AND rh.estado_reservacion <> 'Cancelada'
                    AND rh.estado_reservacion <> 'Check Out'
                    AND lower(c.paterno_cliente) LIKE '%" & datoB & "%'
                    GROUP BY f.id_folio, f.id_usuario, f.id_reservacion, c.nombre_cliente, c.paterno_cliente, c.materno_cliente, c.telefono_cliente, c.identificacion_cliente, u.nombre_usuario,  u.paterno_usuario, u.materno_usuario"
            DGVReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVReservaciones.Refresh()

        ElseIf CBBuscarPor.Text = "Identificación cliente" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_usuario AS ""ID USUARIO"", f.id_reservacion AS ""NÚMERO DE RESERVACIÓN"",
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.nombre_cliente, c.paterno_cliente, c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR""
                    FROM Folio f, Reservacion r, Usuario u, Cliente c, Reservacion_has_Habitacion rh
                    WHERE f.id_reservacion = r.id_reservacion
                    AND f.id_usuario = u.id_usuario
                    AND r.id_cliente = c.id_cliente
                    AND rh.id_reservacion = r.id_reservacion
                    AND rh.estado_reservacion <> 'Cancelada'
                    AND rh.estado_reservacion <> 'Check Out'
                    AND lower(c.identificacion_cliente) LIKE '%" & datoB & "%'
                    GROUP BY f.id_folio, f.id_usuario, f.id_reservacion, c.nombre_cliente, c.paterno_cliente, c.materno_cliente, c.telefono_cliente, c.identificacion_cliente, u.nombre_usuario,  u.paterno_usuario, u.materno_usuario"
            DGVReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVReservaciones.Refresh()

        ElseIf CBBuscarPor.Text = "Teléfono cliente" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_usuario AS ""ID USUARIO"", f.id_reservacion AS ""NÚMERO DE RESERVACIÓN"",
                        c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", c.nombre_cliente, c.paterno_cliente, c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                        u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR""
                    FROM Folio f, Reservacion r, Usuario u, Cliente c, Reservacion_has_Habitacion rh
                    WHERE f.id_reservacion = r.id_reservacion
                    AND f.id_usuario = u.id_usuario
                    AND r.id_cliente = c.id_cliente
                    AND rh.id_reservacion = r.id_reservacion
                    AND rh.estado_reservacion <> 'Cancelada'
                    AND rh.estado_reservacion <> 'Check Out'
                    AND lower(c.telefono_cliente) LIKE '%" & datoB & "%'
                    GROUP BY f.id_folio, f.id_usuario, f.id_reservacion, c.nombre_cliente, c.paterno_cliente, c.materno_cliente, c.telefono_cliente, c.identificacion_cliente, u.nombre_usuario,  u.paterno_usuario, u.materno_usuario"
            DGVReservaciones.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVReservaciones.Refresh()
        End If
    End Sub

    Private Sub BtnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles BtnLimpiarBusqueda.Click
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub CBBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscarPor.SelectedIndexChanged
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub DGVReservaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVReservaciones.CellContentClick
        Dim renglon As Integer
        renglon = DGVReservaciones.CurrentCellAddress.Y
        Try
            idFolio = DGVReservaciones.Rows(renglon).Cells(0).Value
            idReservacion = DGVReservaciones.Rows(renglon).Cells(2).Value
            datoReservacion = DGVReservaciones.Rows(renglon).Cells(2).Value & " | " & DGVReservaciones.Rows(renglon).Cells(0).Value & " | " & DGVReservaciones.Rows(renglon).Cells(3).Value
            'Poblar DGV Habitaciones ligadas
            ConsultaHabLigadasAReserv()

            If abiertoDesde = "CargoExtra" Then
                BtnMostrarDeTodas.Visible = True
                BtnAceptar.Visible = False
                Me.ToolTip1.SetToolTip(Me.BtnMostrarDeTodas, "Clic para mostrar todos los cargos extran (ALT + T)")
            ElseIf abiertoDesde = "AdminFolio" Then
                BtnMostrarDeTodas.Visible = False
                BtnAceptar.Text = "Seleccionar folio"
                BtnAceptar.Visible = True
                Me.ToolTip1.SetToolTip(Me.BtnAceptar, "Clic para seleccionar el folio (ALT + A)")
            End If

        Catch ex As Exception
            ' MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        FrmCargando.MostarConTiempoEnCargar(400)
        If abiertoDesde = "CargoExtra" Then
            ' FrmCargoExtra.cargo.GetSetIdFolio = idFolio
            FrmCargoExtra.idFolio = idFolio
            FrmCargoExtra.TxtDatoReservacion.Text = datoReservacion
            FrmCargoExtra.CargarDGVCargoHab()
            'FrmCargoExtra.PoblarComboHabitacion()
            FrmCargoExtra.TxtNumHab.Text = numeroHabitacion
            BtnAceptar.Visible = False
            BtnMostrarDeTodas.Visible = False
            'aCTIVA CONTROLES DE CARGO EXTRA
            FrmCargoExtra.TxtConceptoCargoExtra.Enabled = True
            FrmCargoExtra.TxtPrecioUnitario.Enabled = True
            FrmCargoExtra.TxtCantidad.Enabled = True
            FrmCargoExtra.BtnRegistrar.Enabled = True
            FrmCargoExtra.BtnEliminar.Enabled = True
            FrmCargoExtra.BtnLimpiar.Enabled = True
            FrmCargoExtra.BtnMostrarDeTodas.Enabled = True
            'FrmCargoExtra.CBNumHabitacion.Enabled = True
            FrmCargoExtra.TimerOcultar.Start()
            FrmCargoExtra.LabelAlt.Visible = True
            FrmCargoExtra.PBAlt.Visible = True
            Me.Close()
        ElseIf abiertoDesde = "AdminFolio" Then
            FrmAdministracionFolio.Limpiar()
            FrmAdministracionFolio.idFolio = idFolio
            FrmAdministracionFolio.idReservacion = idReservacion
            FrmAdministracionFolio.TxtDatoReservacion.Text = datoReservacion
            FrmAdministracionFolio.folio.ConsultaDatosBasicosFolio()
            FrmAdministracionFolio.ConsultaHabLigadasAFolio()
            FrmAdministracionFolio.folio.CantidadTotalHabitaciones()
            FrmAdministracionFolio.folio.CantidadTotalCargosExtra()
            FrmAdministracionFolio.AsignarCantidadALabel()
            FrmAdministracionFolio.EstadoCuenta()
            FrmAdministracionFolio.BtnAgregarCargoExtra.Enabled = False
            FrmAdministracionFolio.BtnPago.Enabled = True
            FrmAdministracionFolio.BtnTodosCargosExtra.Enabled = True
            Me.Close()
        End If
        cancelada = "No"
    End Sub

    Private Sub DGVHabitacionesLigadasReserv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHabitacionesLigadasReserv.CellContentClick
        Dim renglon As Integer
        renglon = DGVHabitacionesLigadasReserv.CurrentCellAddress.Y
        Try
            numeroHabitacion = DGVHabitacionesLigadasReserv.Rows(renglon).Cells(1).Value
            FrmCargoExtra.numeroHabitacion = DGVHabitacionesLigadasReserv.Rows(renglon).Cells(1).Value
            If DGVHabitacionesLigadasReserv.Rows(renglon).Cells(8).Value = "Cancelada" Then
                'Desactivar boton de aceptar
                BtnAceptar.Visible = False
            Else
                'Activa boton de aceptar
                BtnAceptar.Visible = True
                Me.ToolTip1.SetToolTip(Me.BtnAceptar, "Clic para mostrar los cargos extra de la habitación seleccionada (ALT + A)")
            End If

        Catch ex As Exception
            'MsgBox("ERROR: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnMostrarDeTodas_Click(sender As Object, e As EventArgs) Handles BtnMostrarDeTodas.Click
        FrmCargando.MostarConTiempoEnCargar(400)
        ' FrmCargoExtra.cargo.GetSetIdFolio = idFolio
        FrmCargoExtra.idFolio = idFolio
        FrmCargoExtra.TxtDatoReservacion.Text = datoReservacion
        FrmCargoExtra.CargarDGVCargoTodo()
        'FrmCargoExtra.PoblarComboHabitacion()
        FrmCargoExtra.TxtNumHab.Text = "Todo"
        'FrmCargoExtra.CBNumHabitacion.Text = "Todas"
        'Desctiva boton
        BtnAceptar.Visible = False
        BtnMostrarDeTodas.Visible = False
        'aCTIVA CONTROLES DE CARGO EXTRA
        FrmCargoExtra.TxtConceptoCargoExtra.Enabled = True
        FrmCargoExtra.TxtPrecioUnitario.Enabled = True
        FrmCargoExtra.TxtCantidad.Enabled = True
        FrmCargoExtra.BtnRegistrar.Enabled = False
        FrmCargoExtra.BtnEliminar.Enabled = False
        FrmCargoExtra.BtnLimpiar.Enabled = True
        'FrmCargoExtra.CBNumHabitacion.Enabled = True
        FrmCargoExtra.BtnMostrarDeTodas.Enabled = True
        FrmCargoExtra.TimerOcultar.Start()
        FrmCargoExtra.LabelAlt.Visible = True
        FrmCargoExtra.PBAlt.Visible = True
        Me.Close()
    End Sub

    Private Sub TxtDatoBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatoBuscar.KeyPress
        If CBBuscarPor.Text = "Nombre cliente" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Apellido paterno cliente" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Identificación cliente" Then
            SoloNumero(e)
        ElseIf CBBuscarPor.Text = "Teléfono cliente" Then
            SoloNumero(e)
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub FrmSeleccionarFolio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "CargoExtra" Then
            FrmCargoExtra.Activate()
            FrmCargoExtra.Show()
        ElseIf abiertoDesde = "AdminFolio" Then
            FrmAdministracionFolio.Activate()
            FrmAdministracionFolio.Show()
        End If
        abiertoDesde = ""
    End Sub
End Class
Imports Oracle.DataAccess.Client

Public Class FrmAdministracionFolio
    Public folio As New Folio
    Public idFolio As Integer
    Public idReservacion As Integer
    Public numeroHabitacion As Integer
    Public precioTotalHabitaciones As Double
    Public precioTotalCargosExtra As Double
    Public precioTotalReservacion As Double
    Public cantidadPagada As Double

    Private strSql As String
    Private xCnx As New Oracle

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs) Handles BtnPantallaInicio.Click
        abiertoDesde = ""
        'If ModuloGlobal.BuscarFormularioActivo("FrmMenuPrincipal") Then
        '    FrmCargando.MostarConTiempoEnCargar(300)
        '   FrmMenuPrincipal.Activate()
        '   FrmMenuPrincipal.Show()
        'Else
        FrmCargando.MostarConTiempoEnCargar(500)
            FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
            'End If
            'FrmAdministracionClientes.Close()
            Me.Close()
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs) Handles BtnPantallaUsuarios.Click
        abiertoDesde = ""
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmCargando.MostarConTiempoEnCargar(500)
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
            Me.Close()
            'AQUI FALTA CERRAR TODAS LAS VENTANAS QUE DEPENDAN DE ESTE FORM
        Else
            FrmCargando.MostarConTiempoEnCargar(500)
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Nothing, Me)
            FrmAutorizacion.Activate()
            FrmAutorizacion.Show()
        End If

    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaHabitaciones.Click
        abiertoDesde = ""
        'If ModuloGlobal.BuscarFormularioActivo("FrmAdministrarHabitacion") Then
        ' FrmCargando.MostarConTiempoEnCargar(500)

        ' FrmListadoHabitaciones.Show()
        ' FrmListadoHabitaciones.Activate()

        ' Else
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmListadoHabitaciones.Show()
            FrmListadoHabitaciones.Activate()
        'End If
        'FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs) Handles BtnPantallaClientes.Click
        abiertoDesde = ""
        'If ModuloGlobal.BuscarFormularioActivo("FrmListadoClientes") Then
        'FrmCargando.MostarConTiempoEnCargar(500)
        'FrmListadoClientes.Activate()
        'FrmListadoClientes.Show()

        'Else
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        ' End If
        'FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaReservaciones.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(800)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        'FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub FrmAdministracionFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'Estado inicial de la imagen de la habitacion
        PBImagenHabitacion.Image = My.Resources.habitacion

        BtnAgregarCargoExtra.Enabled = False
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmSeleccionarFolio.Close()
        FrmPago.Close()
        FrmMetodoPago.Close()
        FrmCantidadPagar.Close()
        FrmCargoExtra.Close()
        FrmCambio.Close()
    End Sub

    Private Sub FrmAdministracionFolio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "MenuPrincipal" Then
            FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
        ElseIf abiertoDesde = "ListadoFolio" Then
            FrmListadoFolio.Activate()
            FrmListadoFolio.Show()

        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub

    Private Sub BtnBuscarFolio_Click(sender As Object, e As EventArgs) Handles BtnBuscarFolio.Click
        abiertoDesde = "AdminFolio"
        FrmSeleccionarFolio.Activate()
        FrmSeleccionarFolio.Show()
        FrmPago.Close()
        FrmCantidadPagar.Close()
    End Sub

    'MÉTODO QUE CONSULTA TODAS LAS HABITACIONES LIGADAS A LA RESERVACION SELECCIONADA
    Public Sub ConsultaHabLigadasAFolio()
        Dim strSQL As String
        Dim xCnx As New Oracle
        strSQL = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", th.nombre_tipo_hab AS ""TIPO HABITACIÓN"",
                    h.precio_habitacion AS ""PRECIO X NOCHE"", h.capacidad_habitacion AS ""CAPACIDAD"", h.descripcion_habitacion AS ""DESCRIPCIÓN"",
                    TO_DATE(rh.check_in_prog, 'DD/MM/YY HH24:MI') AS ""CHECK IN PROGRAMADO"", ROUND((rh.check_out_prog - rh.check_in_prog), 2) AS ""DÍA/S DE ESTANCIA"", TO_DATE(rh.check_out_prog, 'DD/MM/YY HH24:MI') AS ""CHECK OUT PROGRAMADO"",
                    rh.estado_reservacion AS ""ESTADO""
                  FROM Habitacion h, Tipo_Habitacion th, Reservacion_has_Habitacion rh
                  WHERE h.id_tipo_hab = th.id_tipo_hab
                  AND rh.numero_habitacion = h.numero_habitacion
                  AND rh.id_reservacion = " & idReservacion & " 
                  ORDER BY h.numero_habitacion ASC"

        DGVHabitacionesLigadas.DataSource = xCnx.objetoDataAdapter(strSQL)
        'Ocultar columna de ID
        DGVHabitacionesLigadas.Columns(0).Visible = False
        DGVHabitacionesLigadas.Refresh()
    End Sub

    'Método que muestra la imagen de la habitación seleccionada 
    Private Sub ObtenerImagen()
        'Mostrar imagen de la habitacion
        Try
            Using stream As New System.IO.FileStream("C:\IDEA Software\imgHabitaciones\" & numeroHabitacion & ".png", IO.FileMode.Open)
                PBImagenHabitacion.Image = Image.FromStream(stream)
            End Using
        Catch ex As Exception
            'Si la habitacion no tiene ninguna imagen, se muestra la que esta por defecto
            PBImagenHabitacion.Image = My.Resources.habitacion
        End Try
    End Sub

    Private Sub DGVHabitacionesLigadas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHabitacionesLigadas.CellContentClick
        Dim renglon As Integer
        renglon = DGVHabitacionesLigadas.CurrentCellAddress.Y
        Try
            'Agregar el valor a su variable local 
            numeroHabitacion = DGVHabitacionesLigadas.Rows(renglon).Cells(1).Value
            numeroHabitacion = DGVHabitacionesLigadas.Rows(renglon).Cells(1).Value

            'Se manda hablar el metodo que cargara la imagen de la habitacion correspondiente
            ObtenerImagen()

            'Si la habitacion esta cancelada, no mostrar nada de cargo extra
            If DGVHabitacionesLigadas.Rows(renglon).Cells(9).Value = "Cancelada" Or DGVHabitacionesLigadas.Rows(renglon).Cells(9).Value = "Check Out" Then
                DGVCargosExtra.DataSource = ""
                If DGVHabitacionesLigadas.Rows(renglon).Cells(9).Value = "Check Out" Then
                    'Cargos extra de la habitacion seleccionada
                    ConsultaCargosExtraHabitacion()
                End If
                BtnAgregarCargoExtra.Enabled = False
            Else
                'Cargos extra de la habitacion seleccionada
                ConsultaCargosExtraHabitacion()
                BtnAgregarCargoExtra.Enabled = True
            End If


        Catch ex As Exception
            'MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Public Sub Limpiar()
        idFolio = 0
        idReservacion = 0
        precioTotalHabitaciones = 0
        precioTotalCargosExtra = 0
        precioTotalReservacion = 0
        TxtDatoReservacion.Text = ""
        TxtFechaHoraFolio.Text = ""
        TxtEstadoFolio.Text = ""
        TxtAtendidoPor.Text = ""
        TxtNombreCliente.Text = ""
        DGVHabitacionesLigadas.DataSource = ""
        DGVCargosExtra.DataSource = ""
        TxtCantidadTotalHabitaciones.Text = ""
        TxtCantidadTotalCargoExtra.Text = ""
        TxtCantidadCargoTotal.Text = ""
        PBImagenHabitacion.Image = My.Resources.habitacion
    End Sub

    'Funcion que consulta todos los cargos extra a un folio en especifico
    Public Sub ConsultaCargosExtraTodo()
        strSql = "SELECT id_cargo_extra AS ""ID CARGO EXTRA"", id_folio AS ""ID FOLIO"", fecha_hora AS ""FECHA"", concepto AS ""CONCEPTO"",
                    numero_habitacion AS ""NÚMERO DE HABITACIÓN"", cantidad AS ""CANTIDAD"",  precio_unitario AS ""PRECIO UNITARIO $"", precio_total AS ""PRECIO TOTAL $""
                    FROM Cargo_extra
                    WHERE id_folio = " & idFolio & " 
                    ORDER BY fecha_hora DESC"
        DGVCargosExtra.DataSource = xCnx.objetoDataAdapter(strSql)
        'Ocultar columna de ID
        DGVCargosExtra.Columns(0).Visible = False
        DGVCargosExtra.Columns(1).Visible = False
    End Sub

    'Funcion que consulta todos los cargos extra a un folio en especifico
    Public Sub ConsultaCargosExtraHabitacion()
        strSql = "SELECT id_cargo_extra AS ""ID CARGO EXTRA"", id_folio AS ""ID FOLIO"", fecha_hora AS ""FECHA"", concepto AS ""CONCEPTO"",
                    numero_habitacion AS ""NÚMERO DE HABITACIÓN"", cantidad AS ""CANTIDAD"",  precio_unitario AS ""PRECIO UNITARIO $"", precio_total AS ""PRECIO TOTAL $""
                    FROM Cargo_extra
                    WHERE id_folio = " & idFolio & "
                    AND numero_habitacion = " & numeroHabitacion & "
                    ORDER BY fecha_hora DESC"

        DGVCargosExtra.DataSource = xCnx.objetoDataAdapter(strSql)
        'Ocultar columna de ID
        DGVCargosExtra.Columns(0).Visible = False
        DGVCargosExtra.Columns(1).Visible = False
        DGVCargosExtra.Refresh()
    End Sub

    Private Sub BtnTodosCargosExtra_Click(sender As Object, e As EventArgs) Handles BtnTodosCargosExtra.Click
        FrmCargando.MostarConTiempoEnCargar(200)
        ConsultaCargosExtraTodo()
        BtnAgregarCargoExtra.Enabled = False
    End Sub

    Public Sub AsignarCantidadALabel()
        TxtCantidadTotalHabitaciones.Text = Format(precioTotalHabitaciones, "####,###0.00")
        TxtCantidadTotalCargoExtra.Text = Format(precioTotalCargosExtra, "####,###0.00")
        precioTotalReservacion = precioTotalHabitaciones + precioTotalCargosExtra
        TxtCantidadCargoTotal.Text = Format(precioTotalReservacion, "####,###0.00")
    End Sub

    Private Sub BtnAgregarCargoExtra_Click(sender As Object, e As EventArgs) Handles BtnAgregarCargoExtra.Click
        abiertoDesde = "AdminFolio"
        FrmCargando.MostarConTiempoEnCargar(500)
        FrmCargoExtra.idFolio = idFolio
        FrmCargoExtra.TxtNumHab.Text = numeroHabitacion
        FrmCargoExtra.numeroHabitacion = numeroHabitacion
        FrmCargoExtra.TxtDatoReservacion.Text = TxtDatoReservacion.Text
        FrmCargoExtra.CargarDGVCargoHab()

        'ACTIVA CONTROLES DE CARGO EXTRA
        FrmCargoExtra.TxtConceptoCargoExtra.Enabled = True
        FrmCargoExtra.TxtPrecioUnitario.Enabled = True
        FrmCargoExtra.TxtCantidad.Enabled = True
        FrmCargoExtra.BtnRegistrar.Enabled = True
        FrmCargoExtra.BtnEliminar.Enabled = True
        FrmCargoExtra.BtnLimpiar.Enabled = True
        FrmCargoExtra.BtnMostrarDeTodas.Enabled = True
        FrmCargoExtra.Activate()
        FrmCargoExtra.Show()
    End Sub

    Private Sub BtnPago_Click(sender As Object, e As EventArgs) Handles BtnPago.Click
        abiertoDesde = "AdminFolio"
        FrmCargando.MostarConTiempoEnCargar(500)
        FrmPago.idFolio = idFolio
        FrmPago.idReservacion = idReservacion
        FrmPago.TxtDatoReservacion.Text = TxtDatoReservacion.Text
        FrmPago.Activate()
        FrmPago.Show()
    End Sub

    Private Sub FrmAdministracionFolio_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnPago.PerformClick()
        End If
    End Sub

    'Función que valida sí hay cobros registrados a esa reservacion/folio
    Public Function ValidaPagosAReservacion() As Boolean
        Dim xDT As New DataTable
        strSql = "SELECT cantidad_pago FROM Pago WHERE id_folio = " & idFolio
        ValidaPagosAReservacion = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaPagosAReservacion = True
        End If
    End Function

    Public Sub CantidadPagadaCliente()
        cantidadPagada = 0
        Dim xDT2 As New DataTable
        Dim totales As New OracleDataAdapter

        totales = New OracleDataAdapter("SELECT SUM(cantidad_pago) AS ""CANTIDAD PAGADA"" FROM Pago WHERE id_folio = " & idFolio, cnx)

        totales.Fill(xDT2)
        For Each registro As DataRow In xDT2.Rows
            cantidadPagada = registro("CANTIDAD PAGADA")
        Next
    End Sub

    'Método que consulta si la cuenta esta pagada, no pagada o parcialmente pagada
    Public Sub EstadoCuenta()

        Try
            If ValidaPagosAReservacion() = False Then
                cantidadPagada = 0
                LabelEstadoPago.Text = "No pagado"
                PBEstadoPago.Image = My.Resources.noCompleto
                'FRM PAGO
                FrmPago.LabelEstadoPago.Text = "No pagado"
                FrmPago.PBEstadoPago.Image = My.Resources.noCompleto
            End If

            CantidadPagadaCliente()

            'Si la cantidad pagada es mayor a 0 y menor a la cantidad total entonces se pone como pago parcial
            If cantidadPagada > 0 And cantidadPagada < precioTotalReservacion Then
                LabelEstadoPago.Text = "Pendiente"
                PBEstadoPago.Image = My.Resources.pagoParcial
                'FRM PAGO
                FrmPago.LabelEstadoPago.Text = "Pendiente"
                FrmPago.PBEstadoPago.Image = My.Resources.pagoParcial
                'Si la cantidad pagada es 0 entonces es no pagado
                'ElseIf cantidadPagada = 0 Then
                '    LabelEstadoPago.Text = "No pagado"
                '    PBEstadoPago.Image = My.Resources.noCompleto
                '    'Si la cantidad pagada es igual al precio total, etntoces es pagada
            ElseIf cantidadPagada = precioTotalReservacion Then
                LabelEstadoPago.Text = "Pagado"
                PBEstadoPago.Image = My.Resources.completo
                'FRM PAGO
                FrmPago.LabelEstadoPago.Text = "Pagado"
                FrmPago.PBEstadoPago.Image = My.Resources.completo
                'Si la cantidad pagada es 0 entonces es no pagado
                ' cantidadPagada = 0
            ElseIf cantidadPagada = 0 Then
                LabelEstadoPago.Text = "No pagado"
                PBEstadoPago.Image = My.Resources.noCompleto
                'FRM PAGO
                FrmPago.LabelEstadoPago.Text = "No pagado"
                FrmPago.PBEstadoPago.Image = My.Resources.noCompleto
            End If

        Catch ex As Exception


        End Try
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs) Handles BtnPantallaFolios.Click

    End Sub

    Private Sub DGVCargosExtra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCargosExtra.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
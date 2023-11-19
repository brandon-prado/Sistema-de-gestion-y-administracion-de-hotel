Public Class FrmListadoFolio
    Public idFolio As Integer
    Public idReservacion As Integer
    Public datoReservacion As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable
    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        'If ModuloGlobal.BuscarFormularioActivo("FrmMenuPrincipal") Then
        'FrmCargando.MostarConTiempoEnCargar(300)
        'FrmMenuPrincipal.Activate()
        'FrmMenuPrincipal.Show()
        'Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
        'End If
        FrmAdministracionFolio.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
            FrmAdministracionFolio.Close()
            Me.Close()
        Else
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Nothing, Me)
            FrmAutorizacion.Activate()
            FrmAutorizacion.Show()
            FrmAdministracionFolio.Close()
        End If

    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        ' If ModuloGlobal.BuscarFormularioActivo("FrmAdministrarHabitacion") Then
        'FrmCargando.MostarConTiempoEnCargar(500)
        'FrmListadoHabitaciones.Activate()
        'FrmListadoHabitaciones.Show()

        'Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Activate()
            FrmListadoHabitaciones.Show()
        'End If
        FrmAdministracionFolio.Close()
        Me.Close()
    End Sub

    Private Sub BtnCliente_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        'If ModuloGlobal.BuscarFormularioActivo("FrmListadoClientes") Then
        'FrmCargando.MostarConTiempoEnCargar(500)
        'FrmListadoClientes.Activate()
        'FrmListadoClientes.Show()

        'Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
            FrmListadoClientes.Show()
        'End If
        FrmAdministracionFolio.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        FrmAdministracionFolio.Close()
        Me.Close()
    End Sub

    Private Sub FrmListadoFolio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'Poblar el DGV
        RbMostrarTodosFolios.Checked = True

        'Ocultar si no se ha seleccionado ningun registro
        BtnHabitacionesAsignadas.Visible = False
        BtnResumenFolio.Visible = False
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs)
        Me.Close()
        FrmAdministracionFolio.Close()
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

    Private Sub CBBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscarPor.SelectedIndexChanged
        TxtDatoBuscar.Text = ""
    End Sub

    'Método que muestra en el DGV todas los folios del sistema
    Public Sub PoblarDGVTodoFolios()
        strSql = "SELECT * FROM Vista_Todo_Folio"

        DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoFolios.Columns(0).Visible = False
        DGVListadoFolios.Columns(1).Visible = False
        DGVListadoFolios.Columns(4).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    Private Sub RbMostrarTodosFolios_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarTodosFolios.CheckedChanged
        DGVListadoFolios.DataSource = ""
        PoblarDGVTodoFolios()
    End Sub

    'Método que muestra en el DGV todas los folios activos del sistema
    Public Sub PoblarDGVFoliosActivos()
        strSql = "SELECT * FROM Vista_Folios_Activo"

        DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoFolios.Columns(0).Visible = False
        DGVListadoFolios.Columns(1).Visible = False
        DGVListadoFolios.Columns(4).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    Private Sub RbMostrarFoliosActivos_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarFoliosActivos.CheckedChanged
        PoblarDGVFoliosActivos()
    End Sub

    'Método que muestra en el DGV todas los folios completos del sistema
    Public Sub PoblarDGVFoliosCompletos()
        strSql = "SELECT * FROM Vista_Folios_Completados"

        DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoFolios.Columns(0).Visible = False
        DGVListadoFolios.Columns(1).Visible = False
        DGVListadoFolios.Columns(4).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    Private Sub RbMostrarFoliosCompletos_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarFoliosCompletos.CheckedChanged
        PoblarDGVFoliosCompletos()
    End Sub

    'Método que muestra en el DGV todas los folios pendientes del sistema
    Public Sub PoblarDGVFoliosPendientes()
        strSql = "SELECT * FROM Vista_Folios_Pendientes"

        DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoFolios.Columns(0).Visible = False
        DGVListadoFolios.Columns(1).Visible = False
        DGVListadoFolios.Columns(4).Visible = False
    End Sub

    Private Sub RbMostrarFoliosPendientes_CheckedChanged(sender As Object, e As EventArgs)
        PoblarDGVFoliosPendientes()
    End Sub

    'Método que muestra en el DGV todos los folios de un rango de fecha determinada con la fecha de registro del sistema
    Public Sub PoblarDGVFoliosRangoFecha()
        strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_reservacion AS ""ID RESERVACIÓN"", r.fecha_hora_reservacion AS ""FECHA RESERVACIÓN"", f.fecha_hora_folio AS ""FECHA FOLIO"", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", 
                    c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                    u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", estado_folio AS ""ESTADO"",
                    f.nota_folio AS ""NOTA""
                    FROM Folio f, Reservacion r, Cliente c, Usuario u
                    WHERE f.id_reservacion = r.id_reservacion
                    AND r.id_cliente = c.id_cliente
                    AND f.id_usuario = u.id_usuario
                    AND r.fecha_hora_reservacion >= '" & DateTimeFechaInicial.Text & "' 
                    AND r.fecha_hora_reservacion <= '" & DateTimeFechaFinal.Text & "'  
                    ORDER BY r.fecha_hora_reservacion"

        DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoFolios.Columns(0).Visible = False
        DGVListadoFolios.Columns(1).Visible = False
        DGVListadoFolios.Columns(4).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    Private Sub BtnBuscarReservaciones_Click(sender As Object, e As EventArgs) Handles BtnBuscarReservaciones.Click
        RbMostrarTodosFolios.Checked = True
        FrmCargando.MostarConTiempoEnCargar(500)
        If DateTimeFechaInicial.Text = "" And DateTimeFechaFinal.Text = "" Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            PoblarDGVFoliosRangoFecha()
        End If
    End Sub

    Private Sub TxtDatoBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtDatoBuscar.TextChanged
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim datoB As String

        RbMostrarTodosFolios.Checked = True

        'El dato ingresado es convertido en minúscula
        datoB = LCase(TxtDatoBuscar.Text)

        If CBBuscarPor.Text = "Nombre de cliente" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_reservacion AS ""ID RESERVACIÓN"", r.fecha_hora_reservacion AS ""FECHA RESERVACIÓN"", f.fecha_hora_folio AS ""FECHA FOLIO"", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", 
                    c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                    u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", estado_folio AS ""ESTADO"",
                    f.nota_folio AS ""NOTA""
                    FROM Folio f, Reservacion r, Cliente c, Usuario u
                    WHERE f.id_reservacion = r.id_reservacion
                    AND r.id_cliente = c.id_cliente
                    AND f.id_usuario = u.id_usuario
                        AND lower(c.nombre_cliente) LIKE '%" & datoB & "%'
                        ORDER BY r.fecha_hora_reservacion"

            DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoFolios.Refresh()

        ElseIf CBBuscarPor.Text = "Apellido paterno de cliente" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_reservacion AS ""ID RESERVACIÓN"", r.fecha_hora_reservacion AS ""FECHA RESERVACIÓN"", f.fecha_hora_folio AS ""FECHA FOLIO"", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", 
                    c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                    u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", estado_folio AS ""ESTADO"",
                    f.nota_folio AS ""NOTA""
                    FROM Folio f, Reservacion r, Cliente c, Usuario u
                    WHERE f.id_reservacion = r.id_reservacion
                    AND r.id_cliente = c.id_cliente
                    AND f.id_usuario = u.id_usuario
                        AND lower(c.paterno_cliente) LIKE '%" & datoB & "%'
                        ORDER BY r.fecha_hora_reservacion"

            DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoFolios.Refresh()

        ElseIf CBBuscarPor.Text = "Apellido materno de cliente" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_reservacion AS ""ID RESERVACIÓN"", r.fecha_hora_reservacion AS ""FECHA RESERVACIÓN"", f.fecha_hora_folio AS ""FECHA FOLIO"", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", 
                    c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                    u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", estado_folio AS ""ESTADO"",
                    f.nota_folio AS ""NOTA""
                    FROM Folio f, Reservacion r, Cliente c, Usuario u
                    WHERE f.id_reservacion = r.id_reservacion
                    AND r.id_cliente = c.id_cliente
                    AND f.id_usuario = u.id_usuario
                        AND lower(c.materno_cliente) LIKE '%" & datoB & "%'
                        ORDER BY r.fecha_hora_reservacion"

            DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoFolios.Refresh()

        ElseIf CBBuscarPor.Text = "Identificación de cliente" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_reservacion AS ""ID RESERVACIÓN"", r.fecha_hora_reservacion AS ""FECHA RESERVACIÓN"", f.fecha_hora_folio AS ""FECHA FOLIO"", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", 
                    c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                    u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", estado_folio AS ""ESTADO"",
                    f.nota_folio AS ""NOTA""
                    FROM Folio f, Reservacion r, Cliente c, Usuario u
                    WHERE f.id_reservacion = r.id_reservacion
                    AND r.id_cliente = c.id_cliente
                    AND f.id_usuario = u.id_usuario
                      AND lower(c.identificacion_cliente) LIKE '%" & datoB & "%'
                      ORDER BY r.fecha_hora_reservacion"
            DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoFolios.Refresh()

        ElseIf CBBuscarPor.Text = "Teléfono de cliente" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_reservacion AS ""ID RESERVACIÓN"", r.fecha_hora_reservacion AS ""FECHA RESERVACIÓN"", f.fecha_hora_folio AS ""FECHA FOLIO"", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", 
                    c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                    u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", estado_folio AS ""ESTADO"",
                    f.nota_folio AS ""NOTA""
                    FROM Folio f, Reservacion r, Cliente c, Usuario u
                    WHERE f.id_reservacion = r.id_reservacion
                    AND r.id_cliente = c.id_cliente
                    AND f.id_usuario = u.id_usuario
                      AND lower(c.telefono_cliente) LIKE '%" & datoB & "%'
                      ORDER BY r.fecha_hora_reservacion"
            DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoFolios.Refresh()

        ElseIf CBBuscarPor.Text = "Nombre de usuario" Then
            strSql = "SELECT f.id_folio AS ""ID FOLIO"", f.id_reservacion AS ""ID RESERVACIÓN"", r.fecha_hora_reservacion AS ""FECHA RESERVACIÓN"", f.fecha_hora_folio AS ""FECHA FOLIO"", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS ""NOMBRE DEL CLIENTE"", 
                    c.telefono_cliente AS ""TELÉFONO CLIENTE"", c.identificacion_cliente AS ""IDENTIFICACIÓN CLIENTE"",
                    u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""ATENDIDO POR"", estado_folio AS ""ESTADO"",
                    f.nota_folio AS ""NOTA""
                    FROM Folio f, Reservacion r, Cliente c, Usuario u
                    WHERE f.id_reservacion = r.id_reservacion
                    AND r.id_cliente = c.id_cliente
                    AND f.id_usuario = u.id_usuario
                      AND lower(u.nombre_usuario) LIKE '%" & datoB & "%'
                      ORDER BY r.fecha_hora_reservacion"
            DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoFolios.Refresh()
        End If
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoFolios.Columns(0).Visible = False
        DGVListadoFolios.Columns(1).Visible = False
        DGVListadoFolios.Columns(4).Visible = False
    End Sub

    Private Sub BtnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles BtnLimpiarBusqueda.Click
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub BtnHabitacionesAsignadas_Click(sender As Object, e As EventArgs) Handles BtnHabitacionesAsignadas.Click
        FrmCargando.MostarConTiempoEnCargar(500)
        FrmHabitacionesAsignadas.Activate()
        FrmHabitacionesAsignadas.Show()
        BtnHabitacionesAsignadas.Visible = False
    End Sub

    Private Sub BtnResumenFolio_Click(sender As Object, e As EventArgs) Handles BtnResumenFolio.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        abiertoDesde = "ListadoFolio"

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

        BtnHabitacionesAsignadas.Visible = False
        BtnResumenFolio.Visible = False
        FrmAdministracionFolio.Show()
        Me.Hide()
    End Sub

    Private Sub TxtDatoBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatoBuscar.KeyPress
        If CBBuscarPor.Text = "Nombre de cliente" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Apellido paterno de cliente" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Apellido materno de cliente" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Identificación de cliente" Then
            SoloNumero(e)
        ElseIf CBBuscarPor.Text = "Teléfono de cliente" Then
            SoloNumero(e)
        ElseIf CBBuscarPor.Text = "Nombre de usuario" Then
            SoloLetrasSinApostrofe(e)
        End If
    End Sub

    Private Sub DGVListadoFolios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListadoFolios.CellContentClick

        Dim renglon As Integer
        renglon = DGVListadoFolios.CurrentCellAddress.Y
        Try
            'Agregar el valor de numero de habitacion a su variable local externa 
            FrmHabitacionesAsignadas.idReservacion = DGVListadoFolios.Rows(renglon).Cells(1).Value
            FrmHabitacionesAsignadas.PoblarDGVHabitacionesAsignadas()
            'Variables para poder hacer la modificacion
            idFolio = DGVListadoFolios.Rows(renglon).Cells(0).Value
            idReservacion = DGVListadoFolios.Rows(renglon).Cells(1).Value
            datoReservacion = DGVListadoFolios.Rows(renglon).Cells(1).Value & " | " & DGVListadoFolios.Rows(renglon).Cells(0).Value & " | " & DGVListadoFolios.Rows(renglon).Cells(5).Value

            'Habilita boton para ver habitaciones asignadas
            BtnHabitacionesAsignadas.Visible = True
            'Habilita boton de resumen de folio
            BtnResumenFolio.Visible = True
            If DGVListadoFolios.Rows(renglon).Cells(9).Value = "Cancelada" Then
                cancelada = "Si"
            ElseIf DGVListadoFolios.Rows(renglon).Cells(8).Value = "Activa" Then
                cancelada = "No"
            End If
        Catch ex As Exception
            'MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnModificarFolio_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RbMostrarFoliosCancelados_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarFoliosCancelados.CheckedChanged
        strSql = "SELECT * FROM Vista_Folios_Cancelados"

        DGVListadoFolios.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVListadoFolios.Columns(0).Visible = False
        DGVListadoFolios.Columns(1).Visible = False
        DGVListadoFolios.Columns(4).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmHabitacionesAsignadas.Close()
        FrmAdministracionFolio.Close()
    End Sub

    Private Sub FrmListadoFolio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "MenuPrincipal" Then
            FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
        ElseIf abiertoDesde = "MenuAdmin" Then
            FrmMenuAdministracion.Activate()
            FrmMenuAdministracion.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
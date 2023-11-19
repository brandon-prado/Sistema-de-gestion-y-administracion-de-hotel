Public Class FrmListadoHabitaciones
    'Instanciar el objeto
    Private habitaciones As New ListadoHabitacion
    Private numeroHabitacion As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FrmListadoHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'PROVAR EL DVG
        RbMostrarTodasHabitaciones.Checked = True
        habitaciones.getSetFiltro = "TODAS"
        habitaciones.PoblarDataGridHabiraciones(DGVListadoHabitacion)
        'ocualtar columnas
        DGVListadoHabitacion.Columns(1).Visible = False

        MostrarOcultarBotones()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub MostrarOcultarBotones()
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            'Habilita boton de modificar
            BtnModificarHabitacion.Visible = True
            'Habilita boton de nuevo
            BtnNuevaHabitacion.Visible = True
        Else
            'No muestra boton de modificar
            BtnModificarHabitacion.Visible = False
            'No muestra boton de modificar
            BtnNuevaHabitacion.Visible = False
        End If
    End Sub

    Public Sub RefrescarDGV()
        RbMostrarTodasHabitaciones.Checked = True
        habitaciones.getSetFiltro = "TODAS"
        habitaciones.PoblarDataGridHabiraciones(DGVListadoHabitacion)
    End Sub

    Private Sub RbMostrarTodasHabitaciones_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarTodasHabitaciones.CheckedChanged
        habitaciones.getSetFiltro = "TODAS"
        habitaciones.PoblarDataGridHabiraciones(DGVListadoHabitacion)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarHabitacion.Visible = False
        PBImagenHabitacion.Image = My.Resources.habitacion
    End Sub

    Private Sub RbMostrarHabitacionesDisponibles_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarHabitacionesDisponibles.CheckedChanged
        habitaciones.getSetFiltro = "DISPONIBLES"
        habitaciones.PoblarDataGridHabiraciones(DGVListadoHabitacion)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarHabitacion.Visible = False
        PBImagenHabitacion.Image = My.Resources.habitacion
    End Sub

    Private Sub RbMostrarHabitacionesOcupadas_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarHabitacionesOcupadas.CheckedChanged
        habitaciones.getSetFiltro = "OCUPADAS"
        habitaciones.PoblarDataGridHabiraciones(DGVListadoHabitacion)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarHabitacion.Visible = False
        PBImagenHabitacion.Image = My.Resources.habitacion
    End Sub

    Private Sub RbMostrarHabitacionesMantenimineto_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarHabitacionesMantenimineto.CheckedChanged
        habitaciones.getSetFiltro = "MANTENIMIENTO"
        habitaciones.PoblarDataGridHabiraciones(DGVListadoHabitacion)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarHabitacion.Visible = False
        PBImagenHabitacion.Image = My.Resources.habitacion
    End Sub

    Private Sub RbMostrarHabitacionesInactivas_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarHabitacionesInactivas.CheckedChanged
        habitaciones.getSetFiltro = "INACTIVA"
        habitaciones.PoblarDataGridHabiraciones(DGVListadoHabitacion)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarHabitacion.Visible = False
        PBImagenHabitacion.Image = My.Resources.habitacion
    End Sub

    Private Sub ObtenerImagen()
        Using stream As New System.IO.FileStream("C:\IDEA Software\imgHabitaciones\" & numeroHabitacion & ".png", IO.FileMode.Open)
            PBImagenHabitacion.Image = Image.FromStream(stream)
        End Using
    End Sub

    Private Sub DGVListadoHabitacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListadoHabitacion.CellContentClick
        Dim renglon As Integer
        renglon = DGVListadoHabitacion.CurrentCellAddress.Y

        Try
            'Llenar las cajas de texto al seleccionar un resgistro del DGV
            FrmAdministrarHabitacion.TxtNumero.Text = DGVListadoHabitacion.Rows(renglon).Cells(0).Value
            FrmAdministrarHabitacion.numHabitacion = DGVListadoHabitacion.Rows(renglon).Cells(0).Value
            FrmAdministrarHabitacion.idtipohab = DGVListadoHabitacion.Rows(renglon).Cells(1).Value
            FrmAdministrarHabitacion.CBTipo.Text = DGVListadoHabitacion.Rows(renglon).Cells(2).Value
            FrmAdministrarHabitacion.TxtPrecio.Text = DGVListadoHabitacion.Rows(renglon).Cells(3).Value
            FrmAdministrarHabitacion.CBEstado.Text = DGVListadoHabitacion.Rows(renglon).Cells(4).Value
            FrmAdministrarHabitacion.TxtCapacidad.Text = DGVListadoHabitacion.Rows(renglon).Cells(5).Value
            If IsDBNull(DGVListadoHabitacion.Rows(renglon).Cells(6).Value) Then
                FrmAdministrarHabitacion.TxtDescripcion.Text = ""
            Else
                FrmAdministrarHabitacion.TxtDescripcion.Text = DGVListadoHabitacion.Rows(renglon).Cells(6).Value
            End If

            MostrarOcultarBotones()

            Try
                numeroHabitacion = DGVListadoHabitacion.Rows(renglon).Cells(0).Value
                'Se manda hablar el metodo que cargara la imagen de la habitacion correspondiente
                ObtenerImagen()
                'BtnEliminarImagen.Enabled = True
            Catch ex As Exception
                'Si la habitacion no tiene ninguna imagen, se muestra la que esta por defecto
                PBImagenHabitacion.Image = My.Resources.habitacion
                'BtnEliminarImagen.Enabled = False
            End Try
            FrmAdministrarHabitacion.ObtenerImagen()
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub TxtDatoBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtDatoBuscar.TextChanged
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim datoB As String

        RbMostrarTodasHabitaciones.Checked = True
        Try
            'El dato ingresado es convertido en minúscula
            datoB = LCase(TxtDatoBuscar.Text)

            If CBBuscarPor.Text = "Tipo" Then
                strSql = "SELECT h.numero_habitacion AS ""NÚMERO"", t.id_tipo_hab AS ""ID TIPO HABITACIÓN"", t.nombre_tipo_hab AS ""TIPO"",
                        h.precio_habitacion AS ""PRECIO"", h.estado_habitacion AS ""ESTADO"", h.capacidad_habitacion AS ""CAPACIDAD"",
                        h.descripcion_habitacion AS ""DESCRIPCIÓN""
                      FROM Habitacion h, Tipo_Habitacion t
                      WHERE h.id_tipo_hab = t.id_tipo_hab
                      AND lower(t.nombre_tipo_hab) LIKE '%" & datoB & "%'"

                DGVListadoHabitacion.DataSource = xCnx.objetoDataAdapter(strSql)
                DGVListadoHabitacion.Refresh()

            ElseIf CBBuscarPor.Text = "Número" Then
                strSql = "SELECT h.numero_habitacion AS ""NÚMERO"", t.id_tipo_hab AS ""ID TIPO HABITACIÓN"", t.nombre_tipo_hab AS ""TIPO"",
                        h.precio_habitacion AS ""PRECIO"", h.estado_habitacion AS ""ESTADO"", h.capacidad_habitacion AS ""CAPACIDAD"",
                        h.descripcion_habitacion AS ""DESCRIPCIÓN""
                      FROM Habitacion h, Tipo_Habitacion t
                      WHERE h.id_tipo_hab = t.id_tipo_hab
                      AND lower(h.numero_habitacion) LIKE '%" & datoB & "%'"

                DGVListadoHabitacion.DataSource = xCnx.objetoDataAdapter(strSql)
                DGVListadoHabitacion.Refresh()

            ElseIf CBBuscarPor.Text = "Precio" Then
                strSql = "SELECT h.numero_habitacion AS ""NÚMERO"", t.id_tipo_hab AS ""ID TIPO HABITACIÓN"", t.nombre_tipo_hab AS ""TIPO"",
                        h.precio_habitacion AS ""PRECIO"", h.estado_habitacion AS ""ESTADO"", h.capacidad_habitacion AS ""CAPACIDAD"",
                        h.descripcion_habitacion AS ""DESCRIPCIÓN""
                      FROM Habitacion h, Tipo_Habitacion t
                      WHERE h.id_tipo_hab = t.id_tipo_hab
                      AND h.precio_habitacion <= '" & datoB & "'"

                DGVListadoHabitacion.DataSource = xCnx.objetoDataAdapter(strSql)
                DGVListadoHabitacion.Refresh()

            ElseIf CBBuscarPor.Text = "Capacidad" Then
                strSql = "SELECT h.numero_habitacion AS ""NÚMERO"", t.id_tipo_hab AS ""ID TIPO HABITACIÓN"", t.nombre_tipo_hab AS ""TIPO"",
                        h.precio_habitacion AS ""PRECIO"", h.estado_habitacion AS ""ESTADO"", h.capacidad_habitacion AS ""CAPACIDAD"",
                        h.descripcion_habitacion AS ""DESCRIPCIÓN""
                      FROM Habitacion h, Tipo_Habitacion t
                      WHERE h.id_tipo_hab = t.id_tipo_hab
                      AND h.capacidad_habitacion >= '" & datoB & "'"

                DGVListadoHabitacion.DataSource = xCnx.objetoDataAdapter(strSql)
                DGVListadoHabitacion.Refresh()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles BtnLimpiarBusqueda.Click
        TxtDatoBuscar.Text = ""
    End Sub


    Private Sub BtnNuevaHabitacion_Click(sender As Object, e As EventArgs) Handles BtnNuevaHabitacion.Click
        'FrmAdministrarHabitacion.habitacion.PoblarComboBoxTipo()
        'FrmAdministrarHabitacion.habitacion.PoblarComboBoxEstado()
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmAdministrarHabitacion.TxtNumero.Text = ""
        FrmAdministrarHabitacion.idtipohab = 0
        FrmAdministrarHabitacion.TxtPrecio.Text = ""
        FrmAdministrarHabitacion.CBEstado.Text = ""
        FrmAdministrarHabitacion.TxtCapacidad.Text = ""
        FrmAdministrarHabitacion.TxtDescripcion.Text = ""
        FrmAdministrarHabitacion.PBImagenHabitacion.Image = Nothing
        FrmAdministrarHabitacion.PBImagenHabitacion.BackgroundImage = My.Resources.habitacion
        FrmAdministrarHabitacion.PBImagenHabitacion.SizeMode = PictureBoxSizeMode.StretchImage
        FrmAdministrarHabitacion.BtnEliminarImagen.Enabled = False
        'Bloquear boton de modificar
        BtnModificarHabitacion.Visible = False
        FrmAdministrarHabitacion.Show()
        Me.Hide()
    End Sub


    Private Sub BtnModificarHabitacion_Click_1(sender As Object, e As EventArgs) Handles BtnModificarHabitacion.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmAdministrarHabitacion.Show()
        Me.Hide()
        'Desactivar boton
        BtnModificarHabitacion.Visible = False
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

    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs) Handles BtnPantallaInicio.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Activate()
        FrmMenuPrincipal.Show()
        Me.Close()
        FrmAdministrarHabitacion.Close()
        FrmTipoHabitacion.Close()
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs) Handles BtnPantallaUsuarios.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
            Me.Close()
            FrmAdministrarHabitacion.Close()
            FrmTipoHabitacion.Close()
        Else
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Nothing, Me)
            FrmAutorizacion.Activate()
            FrmAutorizacion.Show()
            FrmAdministrarHabitacion.Close()
            FrmTipoHabitacion.Close()
        End If

    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaHabitaciones.Click

    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs) Handles BtnPantallaClientes.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        Me.Close()
        FrmAdministrarHabitacion.Close()
        FrmTipoHabitacion.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaReservaciones.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        Me.Close()
        FrmAdministrarHabitacion.Close()
        FrmTipoHabitacion.Close()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs) Handles BtnPantallaFolios.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        Me.Close()
        FrmAdministrarHabitacion.Close()
        FrmTipoHabitacion.Close()
    End Sub

    Private Sub TxtDatoBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatoBuscar.KeyPress
        If CBBuscarPor.Text = "Tipo" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Número" Then
            SoloNumero(e)
        ElseIf CBBuscarPor.Text = "Precio" Then
            SoloNumeroYDecimal(TxtDatoBuscar, e)
        ElseIf CBBuscarPor.Text = "Capacidad" Then
            SoloNumero(e)
        End If
    End Sub

    Private Sub CBBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscarPor.SelectedIndexChanged
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmTipoHabitacion.Close()
        FrmAdministrarHabitacion.Close()
    End Sub

    Private Sub FrmListadoHabitaciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'ModuloGlobal.modoSuperUsuario = False
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
End Class
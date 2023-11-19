Public Class FrmAdministrarHabitacion
    Private habitacion As New Habitacion
    Public numHabitacion As Integer
    Public idtipohab As Integer
    Private Sub FrmAdministrarHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'Poblar DGV
        habitacion.PoblarDataGridHabitacion(DGVHabitacion)
        'Ocultar columna de ID de tipo habitacion
        DGVHabitacion.Columns(1).Visible = False

        'Poblar el comboBox de género y rol
        habitacion.PoblarComboBoxTipo()
        habitacion.IdSeleccionadoEnCBTipo()

        BtnEliminarImagen.Enabled = False

        TimerOcultar.Start()
    End Sub

    Public Sub ObtenerImagen()
        Using stream As New System.IO.FileStream("C:\IDEA Software\imgHabitaciones\" & numHabitacion & ".png", IO.FileMode.Open)
            PBImagenHabitacion.Image = Image.FromStream(stream)
        End Using
    End Sub


    Private Sub DGVHabitacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHabitacion.CellContentClick
        Dim renglon As Integer
        renglon = DGVHabitacion.CurrentCellAddress.Y

        Try
            'Llenar las cajas de texto al seleccionar un resgistro del DGV
            TxtNumero.Text = DGVHabitacion.Rows(renglon).Cells(0).Value
            numHabitacion = DGVHabitacion.Rows(renglon).Cells(0).Value
            idtipohab = DGVHabitacion.Rows(renglon).Cells(1).Value
            CBTipo.Text = DGVHabitacion.Rows(renglon).Cells(2).Value
            TxtPrecio.Text = DGVHabitacion.Rows(renglon).Cells(3).Value
            CBEstado.Text = DGVHabitacion.Rows(renglon).Cells(4).Value
            TxtCapacidad.Text = DGVHabitacion.Rows(renglon).Cells(5).Value
            If IsDBNull(DGVHabitacion.Rows(renglon).Cells(6).Value) Then
                TxtDescripcion.Text = ""
            Else
                TxtDescripcion.Text = DGVHabitacion.Rows(renglon).Cells(6).Value
            End If

            Try
                'Se manda hablar el metodo que cargara la imagen de la habitacion correspondiente
                ObtenerImagen()
                BtnEliminarImagen.Enabled = True
            Catch ex As Exception
                'Si la habitacion no tiene ninguna imagen, se muestra la que esta por defecto
                PBImagenHabitacion.Image = My.Resources.habitacion
                BtnEliminarImagen.Enabled = False
            End Try

        Catch ex As Exception
            ' MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNumero.Text = ""
        idtipohab = 0
        TxtPrecio.Text = ""
        CBEstado.Text = ""
        TxtCapacidad.Text = ""
        TxtDescripcion.Text = ""
        PBImagenHabitacion.Image = Nothing
        PBImagenHabitacion.BackgroundImage = My.Resources.habitacion
        PBImagenHabitacion.SizeMode = PictureBoxSizeMode.StretchImage
        BtnEliminarImagen.Enabled = False
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If TxtNumero.Text = "" Or idtipohab = 0 Or TxtPrecio.Text = "" Or CBEstado.Text = "" Or TxtCapacidad.Text = "" Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            If Val(TxtPrecio.Text) > 999999999 Then
                FrmAviso.LbMensaje.Text = "PRECIO DE HABITACIÓN EXCEDIDO, NO SE PUEDE ARRIBA DE $999,999,999.00"
                FrmAviso.Show()
            Else
                ComprobarDatos = True
            End If

        End If
    End Function

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs)
        FrmMenuAdministracion.Show()
        Me.Hide()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Try
            If ComprobarDatos() Then
                'Inicializar el objeto
                Dim habitacion As New Habitacion(TxtNumero.Text, idtipohab, TxtPrecio.Text, CBEstado.Text, TxtCapacidad.Text, TxtDescripcion.Text)
                If habitacion.ConsultaUnaHabitacion() Then
                    'si la habitacion se encuantra registrada se modifica la informacion
                    habitacion.Actualizahabitacion()
                    FrmCorrecto.LbMensaje.Text = "HABITACIÓN MODIFICADA CORRECTAMENTE"
                    FrmCorrecto.Show()
                Else
                    'si la habitacion NO se encuantra registrada se registra la informacion
                    habitacion.InsertaHabitacion()
                    FrmCorrecto.LbMensaje.Text = "REGISTRADA CORRECTAMENTE"
                    FrmCorrecto.Show()
                End If
                'Actualizar DGV
                habitacion.PoblarDataGridHabitacion(DGVHabitacion)
                FrmListadoHabitaciones.RefrescarDGV()
                'Limpiamos caja de texto
                Call BtnLimpiar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If ComprobarDatos() Then
                'instanciar el objeto
                Dim habitacion As New Habitacion(TxtNumero.Text, idtipohab, TxtPrecio.Text, CBEstado.Text, TxtCapacidad.Text, TxtDescripcion.Text)
                If habitacion.ConsultaUnaHabitacion() Then
                    'consulta que no tenga dependencias a la habitacion
                    If habitacion.ValidaHabitacion() Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ELIMINAR LA HABITACION: '" & TxtNumero.Text & "' PORQUE TIENE UNO O MÁS DEPENDENCIAS!"
                        FrmAviso.Show()
                    Else
                        'si nunguna habitacion depende de alguien mas se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR LA HABITACION '" & TxtNumero.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Llamamos al método que elimina el registro de la habitacion
                            habitacion.EliminarHabitacion()
                            FrmCorrecto.LbMensaje.Text = "HABITACION ELIMINADA CORRECTAMENTE!"
                            FrmCorrecto.Show()
                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            habitacion.PoblarDataGridHabitacion(DGVHabitacion)
                            FrmListadoHabitaciones.RefrescarDGV()
                        End If
                    End If
                Else
                    FrmAviso.LbMensaje.Text = "No existe la habitacion"
                    FrmAviso.Show()
                End If
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        FrmMenuAdministracion.Show()
        Me.Close()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnRegresar_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        FrmListadoHabitaciones.Show()
    End Sub

    Private Sub BtnCargarImagen_Click(sender As Object, e As EventArgs) Handles BtnCargarImagen.Click
        Try
            If OpenFileDialog.ShowDialog() = DialogResult.OK Then
                PBImagenHabitacion.BackgroundImage = Nothing
                PBImagenHabitacion.Image = New Bitmap(OpenFileDialog.FileName)
                PBImagenHabitacion.SizeMode = PictureBoxSizeMode.StretchImage

                'Se checa si existe el directorio
                If System.IO.Directory.Exists("C:\IDEA Software\imgHabitaciones\") Then

                    'Si la imagen SI existe entonces la elimina y guarda la nueva imagen correspondiente a la habitacion
                    If System.IO.File.Exists("C:\IDEA Software\imgHabitaciones\" & numHabitacion & ".png") Then

                        Try
                            'Elimina
                            My.Computer.FileSystem.DeleteFile("C:\IDEA Software\imgHabitaciones\" & numHabitacion & ".png")

                            'Guarda 
                            PBImagenHabitacion.Image.Save("C:\IDEA Software\imgHabitaciones\" & numHabitacion & ".png", PBImagenHabitacion.Image.RawFormat)

                            BtnEliminarImagen.Enabled = True
                        Catch ex As Exception
                            MsgBox("Error al actualizar: " & ex.Message)
                        End Try

                    Else

                        'Si existe el directorio, y la imagen NO existe entonces guarda la imagen correspondiente a la habitacion
                        Try
                            'Guarda la imagen seleccionada con el nombre igual al numero de la habitacion
                            PBImagenHabitacion.Image.Save("C:\IDEA Software\imgHabitaciones\" & numHabitacion & ".png", PBImagenHabitacion.Image.RawFormat)
                            BtnEliminarImagen.Enabled = True
                        Catch ex As Exception
                            MsgBox("Error al guardar: " & ex.Message)
                        End Try

                    End If

                Else
                    'Si no existe el directorio, se crea uno nuevo y se procede a guardar la imagen de la habitacion
                    My.Computer.FileSystem.CreateDirectory("C:\IDEA Software\imgHabitaciones\")

                    Try
                        'Guarda la imagen seleccionada con el nombre igual al numero de la habitacion
                        PBImagenHabitacion.Image.Save("C:\IDEA Software\imgHabitaciones\" & numHabitacion & ".png", PBImagenHabitacion.Image.RawFormat)
                    Catch ex As Exception
                        MsgBox("Error al guardar: " & ex.Message)
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al guardar: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminarImagen_Click(sender As Object, e As EventArgs) Handles BtnEliminarImagen.Click
        Try
            If MessageBox.Show("¿ESTÁS SEGURO DE ELIMINAR LA IMAGEN DE LA HABITACIÓN?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                'Elimina
                My.Computer.FileSystem.DeleteFile("C:\IDEA Software\imgHabitaciones\" & numHabitacion & ".png")
                PBImagenHabitacion.Image = My.Resources.habitacion
                BtnEliminarImagen.Enabled = False
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtNumero_TextChanged(sender As Object, e As EventArgs) Handles TxtNumero.TextChanged
        numHabitacion = Val(TxtNumero.Text)
    End Sub

    Private Sub CBTipo_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CBTipo.SelectedIndexChanged
        habitacion.IdSeleccionadoEnCBTipo()
    End Sub

    Private Sub BtnTipo_Click(sender As Object, e As EventArgs) Handles BtnTipo.Click
        FrmCargando.MostarConTiempoEnCargar(200)
        FrmTipoHabitacion.Activate()
        FrmTipoHabitacion.Show()
    End Sub

    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Activate()
        FrmMenuPrincipal.Show()
        Me.Close()
        FrmTipoHabitacion.Close()
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmCargando.MostarConTiempoEnCargar(700)
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
            Me.Close()
            FrmTipoHabitacion.Close()
        Else
            FrmCargando.MostarConTiempoEnCargar(700)
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Nothing, Me)
            FrmAutorizacion.Show()
            FrmTipoHabitacion.Close()
        End If

    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        Me.Close()
        FrmTipoHabitacion.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        Me.Close()
        FrmTipoHabitacion.Close()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        Me.Close()
        FrmTipoHabitacion.Close()
    End Sub

    Private Sub TxtNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumero.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtPrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecio.KeyPress
        SoloNumeroYDecimal(TxtPrecio, e)
    End Sub

    Private Sub TxtCapacidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCapacidad.KeyPress
        SoloNumero(e)
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmTipoHabitacion.Close()
    End Sub

    Private Sub FrmAdministrarHabitacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "ListadoHabitaciones" Then
            FrmListadoHabitaciones.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub

    Private Sub TimerOcultar_Tick(sender As Object, e As EventArgs) Handles TimerOcultar.Tick
        If TimerOcultar.Interval = 8000 Then
            PBAlt.Visible = False
            LabelAlt.Visible = False
        End If
    End Sub

    Private Sub FrmAdministrarHabitacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Activate()
        FrmCerrarSesion.Show()
    End Sub
End Class
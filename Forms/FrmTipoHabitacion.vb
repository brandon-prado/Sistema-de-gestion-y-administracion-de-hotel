Public Class FrmTipoHabitacion
    Private tipoHabitacion As New TipoHabitacion
    Private idTipoHab As Integer

    Private Sub FrmTipoHabitacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        'Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para regresar a la ventana anterior")
        'Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Registar o actualizar género")
        'Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar el género")
        'Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Limpiar caja de texto")

        'Poblar DGV
        tipoHabitacion.PoblarDataGridTipoHabitacion(DGVTipoHabitacion)
        'Ocultar columna de ID
        DGVTipoHabitacion.Columns(0).Visible = False
    End Sub

    Private Sub DGVTipoHabitacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTipoHabitacion.CellContentClick
        Dim renglon As Integer
        Try
            renglon = DGVTipoHabitacion.CurrentCellAddress.Y

            idTipoHab = DGVTipoHabitacion.Rows(renglon).Cells(0).Value
            TxtNombreTipo.Text = DGVTipoHabitacion.Rows(renglon).Cells(1).Value
            If IsDBNull(DGVTipoHabitacion.Rows(renglon).Cells(2).Value) Then
                TxtDescripcionTipo.Text = ""
            Else
                TxtDescripcionTipo.Text = DGVTipoHabitacion.Rows(renglon).Cells(2).Value
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        idTipoHab = 0
        TxtNombreTipo.Text = ""
        TxtDescripcionTipo.Text = ""
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If TxtNombreTipo.Text = "" Then
            FrmAviso.LbMensaje.Text = "FALTAN DATOS, COMPRUEBA LOS CAMPOS CORRESPONDIENTES"
            FrmAviso.Show()
            'ElseIf TxtDescripcionTipo.Text = "" Then
            'FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            'FrmAviso.Show()
        Else
            ComprobarDatos = True
        End If
    End Function

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Try
            If ComprobarDatos() Then
                'iniciar el objeto
                Dim tipoHabitacion As New TipoHabitacion(idTipoHab, TxtNombreTipo.Text, TxtDescripcionTipo.Text)
                If tipoHabitacion.ConsultaTipoHab() Then
                    If tipoHabitacion.ValidaNombreTipHabActualizar = False And tipoHabitacion.ValidaNombreTipHabInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE YA HAY OTRO TIPO DE HABITACIÓN CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'si el tipo de habitacion se encuentra registrado, se modifica la informacion
                        tipoHabitacion.ActualizarTipoHabitacion()
                        FrmCorrecto.LbMensaje.Text = "TIPO DE HABITACIÓN MODIFICADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Género
                        tipoHabitacion.PoblarDataGridTipoHabitacion(DGVTipoHabitacion)
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    End If

                Else
                    If tipoHabitacion.ValidaNombreTipHabInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE REGISTRAR PORQUE YA HAY OTRO TIPO DE HABITACIÓN CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'Si el tipo de habitacion NO está registrado, lo inserta como uno nuevo
                        tipoHabitacion.InsertarTipoHabitacion()
                        FrmCorrecto.LbMensaje.Text = "TIPO DE HABITACIÓN: '" & TxtNombreTipo.Text & "' REGISTRADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Género
                        tipoHabitacion.PoblarDataGridTipoHabitacion(DGVTipoHabitacion)
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    End If

                End If

            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim tipoHabitacion As New TipoHabitacion(idTipoHab, TxtNombreTipo.Text, TxtDescripcionTipo.Text)
                If tipoHabitacion.ConsultaTipoHab() Then
                    'Consulta que NO DEPENDA DE NADIE
                    If tipoHabitacion.ValidaTipoHab() Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ELIMINAR EL TIPO DE HABITACIÓN: '" & TxtNombreTipo.Text & "' PORQUE TIENE UNO O MÁS HABITACIONES QUE DEPENDEN DE ÉSTE MISMO!"
                        FrmAviso.Show()
                    Else
                        'Sí ninguna tabla depende de tipo de habitacion se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL TIPO DE HABITACIÓN: '" & TxtNombreTipo.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Llamamos al método que elimina el registro del tipo de habitacion
                            tipoHabitacion.EliminarTipoHabitacion()
                            FrmCorrecto.LbMensaje.Text = "TIPO DE HABITACIÓN ELIMINADO CORRECTAMENTE"
                            FrmCorrecto.Show()
                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            tipoHabitacion.PoblarDataGridTipoHabitacion(DGVTipoHabitacion)
                        End If
                    End If
                Else
                    FrmAviso.LbMensaje.Text = "NO EXISTE EL TIPO DE HABITACIÓN"
                    FrmAviso.Show()
                End If
                'Actualizar DGV de tipo de habitacion
                tipoHabitacion.PoblarDataGridTipoHabitacion(DGVTipoHabitacion)
                'Limpiamos las caja de texto
                Call BtnLimpiar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub TxtNombreTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreTipo.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtDescripcionTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcionTipo.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub FrmTipoHabitacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub
End Class
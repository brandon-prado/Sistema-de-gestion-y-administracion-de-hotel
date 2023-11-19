Public Class FrmGenero
    Private genero As New Genero
    Private idGenero As Integer

    Private Sub FrmGenero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para regresar a la ventana anterior")
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Registar o actualizar género")
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar el género")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Limpiar caja de texto")

        'Poblar DGV
        genero.PoblarDataGridGenero(DGVGeneros)
        'Ocultar columna de ID
        DGVGeneros.Columns(0).Visible = False
    End Sub

    Private Sub DGVGeneros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVGeneros.CellContentClick
        Dim renglon As Integer
        Try
            renglon = DGVGeneros.CurrentCellAddress.Y

            idGenero = DGVGeneros.Rows(renglon).Cells(0).Value
            TxtNombreGenero.Text = DGVGeneros.Rows(renglon).Cells(1).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        idGenero = 0
        TxtNombreGenero.Text = ""
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If TxtNombreGenero.Text = "" Then
            FrmAviso.LbMensaje.Text = "FALTAN DATOS, COMPRUEBA LOS CAMPOS CORRESPONDIENTES"
            FrmAviso.Show()
        Else
            ComprobarDatos = True
        End If
    End Function

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim genero As New Genero(idGenero, TxtNombreGenero.Text)
                If genero.ConsultaUnGenero() Then
                    If genero.ValidaNombreGeneroActualizar = False And genero.ValidaNombreGeneroInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE YA HAY OTRO GÉNERO CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'Si el género se encuentra registrado, se modifica la información
                        genero.ActualizarGenero()
                        FrmCorrecto.LbMensaje.Text = "GÉNERO MODIFICADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Género
                        genero.PoblarDataGridGenero(DGVGeneros)
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    End If
                Else
                    If genero.ValidaNombreGeneroInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE INSERTAR PORQUE YA HAY OTRO GÉNERO CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'Si el genero NO está registrado, lo inserta como uno nuevo
                        genero.InsertaGenero()
                        FrmCorrecto.LbMensaje.Text = "GÉNERO: '" & TxtNombreGenero.Text & "' REGISTRADO CORRECTAMENTE!"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Género
                        genero.PoblarDataGridGenero(DGVGeneros)
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
                Dim genero As New Genero(idGenero, TxtNombreGenero.Text)
                If genero.ConsultaUnGenero() Then
                    'Consulta que ningún usuario o cliente dependa del género
                    If genero.ValidaGeneroUsuarioCliente() Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ELIMINAR EL GÉNERO: '" & TxtNombreGenero.Text & "' PORQUE TIENE UNO O MÁS PERSONAS QUE DEPENDEN DE ÉSTE MISMO!"
                        FrmAviso.Show()
                    Else
                        'Sí ninguna persona depende del género se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL GÉNERO '" & TxtNombreGenero.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Llamamos al método que elimina el registro del género
                            genero.EliminarGenero()
                            FrmCorrecto.LbMensaje.Text = "GÉNERO ELIMINADO CORRECTAMENTE!"
                            FrmCorrecto.Show()
                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            genero.PoblarDataGridGenero(DGVGeneros)
                        End If
                    End If
                Else
                    FrmAviso.LbMensaje.Text = "NO EXISTE EL GÉNERO"
                    FrmAviso.Show()
                End If
                'Actualizar DGV de Género
                genero.PoblarDataGridGenero(DGVGeneros)
                'Limpiamos caja de texto
                Call BtnLimpiar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub TxtNombreGenero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreGenero.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub FrmGenero_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub
End Class
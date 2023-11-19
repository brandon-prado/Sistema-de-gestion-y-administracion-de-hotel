Public Class FrmMetodoPago

    Private metodo As New MetodoPago
    Public idMetodo As Integer

    Private Sub FrmMetodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Poblar DGV
        metodo.PoblarDataGridMetPgo(DGVMetPago)
        'Ocultar columna de ID
        DGVMetPago.Columns(0).Visible = False
    End Sub

    Private Sub DGVMetodos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVMetPago.CellContentClick
        Dim renglon As Integer
        Try
            renglon = DGVMetPago.CurrentCellAddress.Y
            'Llenar las cajas de texto al seleccionar un resgistro del DGV
            idMetodo = DGVMetPago.Rows(renglon).Cells(0).Value
            TxtMetPago.Text = DGVMetPago.Rows(renglon).Cells(1).Value
            If IsDBNull(DGVMetPago.Rows(renglon).Cells(2).Value) Then
                TxtDescripcionPago.Text = ""
            Else
                TxtDescripcionPago.Text = DGVMetPago.Rows(renglon).Cells(2).Value
            End If
        Catch ex As Exception

        End Try


    End Sub
    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles Btnlimpiar.Click
        idMetodo = 0
        TxtMetPago.Text = ""
        TxtDescripcionPago.Text = ""
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If TxtMetPago.Text = "" Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            ComprobarDatos = True
        End If
    End Function

    Private Sub btn_registrar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim metodo As New MetodoPago(idMetodo, TxtMetPago.Text, TxtDescripcionPago.Text)
                If metodo.ConsultaUnMetodo() Then
                    If metodo.ValidaNombreMetPagActualizar = False And metodo.ValidaNombreMetPagInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE YA HAY OTRO MÉTODO DE PAGO CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'Si el metodo de pago se encuentra registrado, se modifica la información
                        metodo.ActualizarMetodo()
                        FrmCorrecto.LbMensaje.Text = "METODO DE PAGO MODIFICADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Permiso
                        metodo.PoblarDataGridMetPgo(DGVMetPago)
                        'Limpiamos caja de texto
                        Call btn_limpiar_Click(sender, e)
                    End If

                Else
                    If metodo.ValidaNombreMetPagInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE REGISTRAR PORQUE YA HAY OTRO MÉTODO DE PAGO CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'Si el permiso NO está registrado, lo inserta como uno nuevo
                        metodo.InsertaMetodo()
                        FrmCorrecto.LbMensaje.Text = "REGISTRADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Permiso
                        metodo.PoblarDataGridMetPgo(DGVMetPago)
                        'Limpiamos caja de texto
                        Call btn_limpiar_Click(sender, e)
                    End If

                End If

            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim metodo As New MetodoPago(idMetodo, TxtMetPago.Text, TxtDescripcionPago.Text)
                If metodo.ConsultaUnMetodo() Then

                    If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL METODO DE PAGO '" & TxtMetPago.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                        'Llamamos al método que elimina el registro del permiso
                        metodo.EliminarMetodo()
                        FrmCorrecto.LbMensaje.Text = "METODO ELIMINADO CORRECTAMENTE!"
                        FrmCorrecto.Show()
                        'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                        metodo.PoblarDataGridMetPgo(DGVMetPago)
                    End If
                End If
            Else
                FrmAviso.LbMensaje.Text = "No existe el método"
                FrmAviso.Show()
            End If
            'Actualizar DGV de Permiso
            Metodo.PoblarDataGridMetPgo(DGVMetPago)
            'Limpiamos caja de texto
            Call btn_limpiar_Click(sender, e)
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnRegresar_Click_1(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        'Limpiamos caja de texto
        Call btn_limpiar_Click(sender, e)
    End Sub

    Private Sub TxtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMetPago.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtDescripcionPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcionPago.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub FrmMetodoPago_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAgregar.PerformClick()
        End If
    End Sub
End Class


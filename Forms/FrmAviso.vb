Public Class FrmAviso
    Private Sub BtnSi_Click(sender As Object, e As EventArgs) Handles BtnSi.Click
        Me.Close()
    End Sub

    Private Sub FrmAviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub LbMensaje_Click(sender As Object, e As EventArgs) Handles LbMensaje.Click

    End Sub

    Private Sub FrmAviso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSi.PerformClick()
        End If
    End Sub
End Class
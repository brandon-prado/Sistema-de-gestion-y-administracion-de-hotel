Public Class FrmSalida
    Private Sub BtnSi_Click(sender As Object, e As EventArgs) Handles BtnSi.Click
        FrmInicioSesión.Close()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Close()
        FrmInicioSesión.Activate()
        FrmInicioSesión.Show()
    End Sub
End Class
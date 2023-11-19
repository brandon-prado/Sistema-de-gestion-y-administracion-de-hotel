Public Class FrmCargando
    Private tiempo As Double

    Public Sub MostarConTiempoEnCargar(tiempoD As Double)
        tiempo = tiempoD
        Me.Show()
    End Sub

    Private Sub TimerCerrar_Tick(sender As Object, e As EventArgs) Handles TimerCerrar.Tick
        If TimerCerrar.Interval = tiempo Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmCargando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerCerrar.Interval = tiempo
        TimerCerrar.Start()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
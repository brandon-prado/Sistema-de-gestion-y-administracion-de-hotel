Public Class FrmAutorizacion
    Private formularioAbrir As Form
    Private formularioOcultar As Form
    Private formularioCerrar As Form

    Public Sub Formulario(formularioA As Form, formularioO As Form, formularioC As Form)
        formularioAbrir = formularioA
        formularioOcultar = formularioO
        formularioCerrar = formularioC
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub BtnAcceder_Click(sender As Object, e As EventArgs) Handles BtnAcceder.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        AutorizacionAdministrativa(formularioAbrir, formularioOcultar, formularioCerrar)
    End Sub

    Private Sub CbMostrarOcultarContrasena_CheckedChanged(sender As Object, e As EventArgs) Handles CbMostrarOcultarContrasena.CheckedChanged
        If CbMostrarOcultarContrasena.Checked = True Then
            TxtContrasena.UseSystemPasswordChar = False
        Else
            TxtContrasena.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtUsuario.Text = ""
        TxtContrasena.Text = ""
    End Sub

    Private Sub FrmAutorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TxtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsuario.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub TxtContrasena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContrasena.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub FrmAutorizacion_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAcceder.PerformClick()
        End If
    End Sub

    Private Sub TxtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAcceder.PerformClick()
        End If
    End Sub

    Private Sub TxtContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAcceder.PerformClick()
        End If
    End Sub
End Class
Public Class FrmCierreTurno
    Public turnoC As New CierreTurno
    Public cantidadRequerida As Double
    Public cantidadCapturada As Double
    Public cantidadDiferencia As Double

    Private Sub TxtCantidadCapturada_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidadCapturada.TextChanged
        cantidadCapturada = Val(TxtCantidadCapturada.Text)
        cantidadRequerida = Val(TxtCantidadRequerida.Text)
        cantidadDiferencia = Val(TxtCantidadDiferencia.Text)

        If TxtCantidadCapturada.Text = "" Then
            TxtCantidadDiferencia.Text = ""
        Else
            cantidadDiferencia = cantidadCapturada - cantidadRequerida
            TxtCantidadDiferencia.Text = cantidadDiferencia
            If cantidadDiferencia < 0 Then
                TxtCantidadDiferencia.BackColor = Color.FromArgb(229, 53, 16)
            Else
                TxtCantidadDiferencia.BackColor = Color.FromArgb(114, 173, 111)
            End If
        End If

    End Sub

    Private Sub FrmCierreTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hora y fecha del sistema
        FechaHora.Enabled = True

        turnoC.CantidadActualCaja()

        FrmNota.Close()
    End Sub

    Private Sub TxtCantidadCapturada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidadCapturada.KeyPress
        SoloNumeroYDecimal(TxtCantidadCapturada, e)
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If TxtCantidadCapturada.Text = "" And TxtCantidadRequerida.Text = "" And TxtCantidadDiferencia.Text = "" Then
            FrmAviso.LbMensaje.Text = "FALTAN DATOS, CORROBORA LA INFORMACIÓN E INTENTA NUEVAMENTE"
            FrmAviso.Show()
            ComprobarDatos = False
        ElseIf TxtCantidadRequerida.Text = "" Then
            FrmAviso.LbMensaje.Text = "LA CANTIDAD REQUERIDA NO ESTÁ ESPECÍFICADA"
            FrmAviso.Show()
            ComprobarDatos = False
        ElseIf TxtCantidadCapturada.Text = "" Then
            FrmAviso.LbMensaje.Text = "INGRESA LA CANTIDAD ACTUAL CAPTURADA EN CAJA"
            FrmAviso.Show()
            ComprobarDatos = False
        ElseIf TxtCantidadDiferencia.Text = "" Then
            FrmAviso.LbMensaje.Text = "NO SE ENCUENTRA CALCULADA LA DIFERENCIA"
            FrmAviso.Show()
            ComprobarDatos = False
        ElseIf TxtCantidadCapturada.Text = "." Then
            TxtCantidadCapturada.Text = ""
            ComprobarDatos = False
            FrmAviso.LbMensaje.Text = "ESPECÍFICA LA CANTIDAD DE CIERRE CAPTURADA EN CAJA CORRECTAMENTE"
            FrmAviso.Show()
        Else
            If cantidadCapturada = 0 Then
                TxtCantidadCapturada.Text = "0"
            End If

            If MessageBox.Show("¿ES CORRECTA LA CANTIDAD CAPTURADA $" & TxtCantidadCapturada.Text & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                ComprobarDatos = True
            Else
                TxtCantidadCapturada.Text = ""
                ComprobarDatos = False
            End If

        End If
    End Function

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        cerradoDesde = "CierreTotal"
        'FrmCargando.MostarConTiempoEnCargar(400)
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim turnoC As New CierreTurno(TxtCantidadCapturada.Text, FrmNota.TxtNota.Text)
                turnoC.CierraTurno()
                'Encriptar base de datos
                If encriptada = "No" Then
                    EncriptarBD()
                    encriptada = "Si"
                End If
                'Abrir el Inicio de sesion
                FrmInicioSesión.Show()
                CerrarEnCascada()
                FrmCerrarSesion.Close()

                Limpiar()

                cnx.Close()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CerrarVentanasCascada()

    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnNota_Click(sender As Object, e As EventArgs) Handles BtnNota.Click
        FrmCargando.MostarConTiempoEnCargar(200)
        FrmNota.Activate()
        FrmNota.Show()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        FrmMenuPrincipal.Show()
        FrmNota.Close()
        Me.Close()
    End Sub

    Private Sub Limpiar()
        cantidadRequerida = 0
        cantidadCapturada = 0
        cantidadDiferencia = 0
        TxtCantidadRequerida.Text = ""
        TxtCantidadCapturada.Text = ""
        TxtCantidadDiferencia.Text = ""
        cerradoDesde = ""
    End Sub

    Private Sub FrmCierreTurno_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub
End Class
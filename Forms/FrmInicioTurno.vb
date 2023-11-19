Public Class FrmInicioTurno
    Public turno As New InicioTurno
    Private cantidadInicial As Double
    Private Sub FrmInicioTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Hora y fecha del sistema
        FechaHora.Enabled = True
    End Sub

    Private Sub FechaHora_Tick_1(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub TxtCantidadInicialCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidadInicialCaja.KeyPress
        SoloNumeroYDecimal(TxtCantidadInicialCaja, e)
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If TxtCantidadInicialCaja.Text = "" Then
            FrmAviso.LbMensaje.Text = "INGRESA LA CANTIDAD INICIAL EN CAJA"
            FrmAviso.Show()
            ComprobarDatos = False
        ElseIf TxtCantidadInicialCaja.Text = "." Then
            TxtCantidadInicialCaja.Text = ""
            ComprobarDatos = False
            FrmAviso.LbMensaje.Text = "ESPECÍFICA LA CANTIDAD INICIAL EN CAJA CORRECTAMENTE"
            FrmAviso.Show()
        ElseIf cantidadInicial <= 0.99999 And cantidadInicial >= 0.00001 Or cantidadInicial <= 0.999999 And cantidadInicial >= 0.000001 Then
            TxtCantidadInicialCaja.Text = ""
            ComprobarDatos = False
            FrmAviso.LbMensaje.Text = "ESPECÍFICA LA CANTIDAD INICIAL EN CAJA CON UNA CANTIDAD MAYOR Ó ESPECÍFICA QUE INICIA EN 0"
            FrmAviso.Show()
        Else
            If cantidadInicial = 0 Then
                TxtCantidadInicialCaja.Text = "0"
            End If

            If cantidadInicial < 100000 Then
                If MessageBox.Show("¿ES CORRECTA LA CANTIDAD INICIAL $" & TxtCantidadInicialCaja.Text & "?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    ComprobarDatos = True
                Else
                    TxtCantidadInicialCaja.Text = ""
                    ComprobarDatos = False
                End If
            Else
                FrmAviso.LbMensaje.Text = "LA CANTIDAD INICIAL EN CAJA NO PUEDE SER MAYOR A LOS $100,000.00"
                FrmAviso.Show()
            End If


        End If
    End Function

    Private Sub Limpiar()
        cantidadInicial = 0
        TxtCantidadInicialCaja.Text = ""
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        ' FrmCargando.MostarConTiempoEnCargar(400)
        Try
            If ComprobarDatos() Then
                'If TxtCantidadInicialCaja.Text = 0 Then
                '    FrmMenuPrincipal.Show()
                '    sinTurno = True
                '    Me.Close()
                'Else
                'Instanciar el objeto
                Dim turno As New InicioTurno(TxtCantidadInicialCaja.Text, TxtCantidadInicialCaja.Text)
                turno.InsertaTurno()
                Me.Close()
                'Abrir el menu principal
                If ModuloGlobal.BuscarFormularioActivo("FrmMenuPrincipal") Then
                    FrmCargando.MostarConTiempoEnCargar(300)
                    FrmMenuPrincipal.Show()
                Else
                    FrmCargando.MostarConTiempoEnCargar(1000)
                    FrmMenuPrincipal.Show()
                End If
                Limpiar()
                'End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtCantidadInicialCaja_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidadInicialCaja.TextChanged
        cantidadInicial = Val(TxtCantidadInicialCaja.Text)
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        If encriptada = "No" Then
            EncriptarBD()
            encriptada = "Si"
        End If
        FrmInicioSesión.Show()
    End Sub

    Private Sub FrmInicioTurno_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub
End Class
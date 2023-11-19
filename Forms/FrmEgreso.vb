Public Class FrmEgreso
    Private egreso As New Egreso
    Public idEgreso As Integer
    Public idTurno As Integer

    Private Sub FrmEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        egreso.PoblarDataGridEgreso(DGVEgreso)
        CBCaja.Text = idTurnoActual
        'Ocultar columna de ID de rol y permiso
        DGVEgreso.Columns(0).Visible = False
    End Sub

    Private Sub MostrarOcultarBotones()
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            BtnTodosEgresos.Visible = True
        Else
            BtnTodosEgresos.Visible = False
        End If
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        'CBCaja.Text = ""
        TxtCantidadRetirar.Text = ""
        TxtConcepto.Text = ""
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub DGVEgreso_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEgreso.CellContentClick
        Dim renglon As Integer
        renglon = DGVEgreso.CurrentCellAddress.Y
        Try
            'Llenar las cajas de texto al seleccionar un resgistro del DGV
            ' idEgreso = DGVEgreso.Rows(renglon).Cells(0).Value
            '  idTurno = DGVEgreso.Rows(renglon).Cells(1).Value
            '  TxtCantRetiro.Text = DGVEgreso.Rows(renglon).Cells(2).Value
            '  TxtConcepto.Text = DGVEgreso.Rows(renglon).Cells(3).Value
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If CBCaja.Text = 0 Or TxtCantidadRetirar.Text = "" Or TxtConcepto.Text = "" Then
            FrmAviso.LbMensaje.Text = "FALTAN DATOS, COMPRUEBA LOS CAMPOS CORRESPONDIENTES"
            FrmAviso.Show()
        ElseIf TxtCantidadRetirar.Text = 0 Then
            TxtCantidadRetirar.Text = ""
            ComprobarDatos = False
            FrmAviso.LbMensaje.Text = "ESPECÍFICA LA CANTIDAD CORRECTAMENTE (DEBE SER MAYOR A 0)"
            FrmAviso.Show()
        Else
            ComprobarDatos = True
        End If
    End Function

    Private Sub BtnAutorizar_Click(sender As Object, e As EventArgs) Handles BtnAutorizar.Click
        FrmCargando.MostarConTiempoEnCargar(300)
        Try
            If ComprobarDatos() Then
                'instancear el objeto
                If TxtCantidadRetirar.Text = "." Then
                    'TxtCantidadRetirar.Text = ""
                    FrmAviso.LbMensaje.Text = "ESPECÍFICA LA CANTIDAD CORRECTAMENTE"
                    FrmAviso.Show()

                Else
                    Dim egreso As New Egreso(idEgreso, CBCaja.Text, TxtCantidadRetirar.Text, TxtConcepto.Text)
                    'If egreso.ConsultaUnEgreso() Then
                    'Si el TURNO NO está registrado, lo inserta como uno nuevo
                    egreso.InsertaEgreso()

                    'End If
                    'Actualizar DGV 
                    egreso.PoblarDataGridEgreso(DGVEgreso)
                    FrmTurno.turno.PoblarDataGridTurno(FrmTurno.DGVTurnos)
                    'Limpiamos caja de texto
                    Call BtnLimpiar_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            TxtCantidadRetirar.Text = ""
            FrmAviso.LbMensaje.Text = "ESPECÍFICA LA CANTIDAD CORRECTAMENTE"
            FrmAviso.Show()
        End Try
    End Sub

    Private Sub BtnTodosEgresos_Click(sender As Object, e As EventArgs) Handles BtnTodosEgresos.Click
        abiertoDesde = "EgresoTurno"
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoEgreso.Activate()
        FrmListadoEgreso.Show()
        Me.Hide()
    End Sub

    Private Sub TxtConcepto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtConcepto.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub TxtCantidadRetirar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidadRetirar.KeyPress
        SoloNumeroYDecimal(TxtCantidadRetirar, e)
    End Sub

    Private Sub FrmEgreso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAutorizar.PerformClick()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abiertoDesde = "EgresoTurno"
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoCobros.Activate()
        FrmListadoCobros.Show()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmListadoEgreso.Close()
        FrmListadoCobros.Close()
    End Sub

    Private Sub FrmEgreso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "Turno" Then
            FrmTurno.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub
End Class
Public Class FrmInicioSesión
    Public Sub New()
        'Formulario
        InitializeComponent()
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True
        'Solucionar pantalla completa
        'Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub FrmInicioSesión_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'TxtUsuario.Text = "brandon"
        'TxtContrasena.Text = "123"
        ComprobarEstadoIncial()

    End Sub

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        'Me.ToolTip1.SetToolTip(Me.BtnCerrar, "Cerrar programa")
        Me.ToolTip1.SetToolTip(Me.CbMostrarOcultarContrasena, "Clic para mostrar/ocultar la contraseña")
        Me.ToolTip1.SetToolTip(Me.BtnAcceder, "Clic para acceder al sistema")
    End Sub

    Private Sub CbMostrarOcultarContrasena_CheckedChanged_1(sender As Object, e As EventArgs) Handles CbMostrarOcultarContrasena.CheckedChanged
        If CbMostrarOcultarContrasena.Checked = True Then
            TxtContrasena.UseSystemPasswordChar = False
        Else
            TxtContrasena.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BtnAcceder_Click_1(sender As Object, e As EventArgs) Handles BtnAcceder.Click
        'FrmCargando.MostarConTiempoEnCargar(400)
        'Desencriptar base de datos
        DesencriptarBD()
        encriptada = "No"
        Try
            If TxtUsuario.Text = "" And TxtContrasena.Text = "" Then
                FrmAviso.LbMensaje.Text = "El campo USUARIO Y CONTRASEÑA están vacíos"
                If encriptada = "No" Then
                    EncriptarBD()
                    encriptada = "Si"
                End If

                FrmAviso.Show()
                'MsgBox("El campo USUARIO Y CONTRASEÑA están vacíos", MsgBoxStyle.Exclamation)
            ElseIf TxtUsuario.Text = "" Then
                FrmAviso.LbMensaje.Text = "El campo EMPLEADO está vacío"
                FrmAviso.Show()
                If encriptada = "No" Then
                    EncriptarBD()
                    encriptada = "Si"
                End If
                'MsgBox("El campo EMPLEADO está vacío", MsgBoxStyle.Exclamation)
            ElseIf TxtContrasena.Text = "" Then
                FrmAviso.LbMensaje.Text = "El campo CONTRASEÑA está vacío"
                FrmAviso.Show()
                If encriptada = "No" Then
                    EncriptarBD()
                    encriptada = "Si"
                End If
                'MsgBox("El campo CONTRASEÑA está vacío", MsgBoxStyle.Exclamation)
            Else
                'Instanciamos la clase y le pasamos como parámetros los 2 datos de las cajas de texto
                Dim sesion As New InicioSesion(TxtUsuario.Text, TxtContrasena.Text)
                DesencriptarBD()
                If sesion.ConsultaUsuario() = False Then
                    FrmAviso.LbMensaje.Text = "El usuario NO EXISTE"
                    FrmAviso.Show()
                    If encriptada = "No" Then
                        EncriptarBD()
                        encriptada = "Si"
                    End If
                    'MsgBox("El usuario NO EXISTE", MsgBoxStyle.Exclamation)
                    TxtUsuario.Text = vbNullString
                    TxtContrasena.Text = ""
                ElseIf sesion.ConsultaUsuario() = True Then
                    If sesion.ConsultaSiEstaActivo Then
                        If sesion.ConsultaSiTieneAcceso Then
                            If sesion.ConsultaUsuarioContrasena() = False Then
                                FrmAviso.LbMensaje.Text = "La contraseña ESTÁ INCORRECTA"
                                FrmAviso.Show()
                                If encriptada = "No" Then
                                    EncriptarBD()
                                    encriptada = "Si"
                                End If
                                'MsgBox("La contraseña ESTÁ INCORRECTA", MsgBoxStyle.Exclamation)
                            Else
                                'Informacion del usuario para asignar nombre a los formularios
                                ModuloGlobal.consultaNombreDeUsuario()
                                TxtContrasena.Text = ""
                                Me.Hide()
                                If nombreRol = "Contador" Then
                                    FrmReportes.Show()
                                    FrmReportes.BtnPantallaInicio.Enabled = False
                                    FrmReportes.BtnPantallaUsuarios.Enabled = False
                                    FrmReportes.BtnPantallaHabitaciones.Enabled = False
                                    FrmReportes.BtnPantallaClientes.Enabled = False
                                    FrmReportes.BtnPantallaReservaciones.Enabled = False
                                    FrmReportes.BtnPantallaFolios.Enabled = False
                                Else
                                    'Consulta si hay un turno pendiente
                                    If FrmInicioTurno.turno.ValidaTurnoPendiente() = True Then
                                        FrmAviso.LbMensaje.Text = "HAY UN TURNO PENDIENTE, RESTAURANDO SISTEMA CON LA INFORMACIÓN CORRESPONDIENTE"
                                        FrmAviso.Show()
                                        FrmMenuPrincipal.Show()
                                    Else
                                        FrmInicioTurno.Show()
                                    End If
                                End If


                            End If
                        Else
                            FrmAviso.LbMensaje.Text = "ESTE USUARIO NO TIENE ACCESO AL SISTEMA"
                            FrmAviso.Show()
                            If encriptada = "No" Then
                                EncriptarBD()
                                encriptada = "Si"
                            End If
                        End If
                    Else
                        FrmAviso.LbMensaje.Text = "ESTE USUARIO ESTA DESACTIVADO"
                        FrmAviso.Show()
                        If encriptada = "No" Then
                            EncriptarBD()
                            encriptada = "Si"
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            FrmAviso.LbMensaje.Text = "ERROR"
            FrmAviso.Show()
            If encriptada = "No" Then
                EncriptarBD()
                encriptada = "Si"
            End If
            'MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        'Me.Hide()
        'FrmMenuPrincipal.Show()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        FrmSalida.Show()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtUsuario.Text = ""
        TxtContrasena.Text = ""
    End Sub

    Private Sub TxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuario.TextChanged

    End Sub

    Private Sub TxtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUsuario.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub TxtContrasena_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtContrasena.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub FrmInicioSesión_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAcceder.PerformClick()
        End If
    End Sub

    Private Sub FrmInicioSesión_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If encriptada = "No" Then
            EncriptarBD()
        End If

    End Sub
End Class
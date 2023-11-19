Public Class FrmPermiso
    Private permiso As New Permiso
    Private idPermiso As Integer

    Private Sub FrmPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para regresar a la ventana anterior")
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Registar o actualizar género")
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar el género")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Limpiar caja de texto")

        'Poblar DGV
        permiso.PoblarDataGridPermiso(DGVPermisos)
        'Ocultar columna de ID
        DGVPermisos.Columns(0).Visible = False
    End Sub

    Private Sub DGVPermisos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPermisos.CellContentClick
        Dim renglon As Integer
        Try
            renglon = DGVPermisos.CurrentCellAddress.Y

            'Llenar las cajas de texto al seleccionar un resgistro del DGV
            idPermiso = DGVPermisos.Rows(renglon).Cells(0).Value
            TxtNivelPermiso.Text = DGVPermisos.Rows(renglon).Cells(1).Value
            TxtDescripcion.Text = DGVPermisos.Rows(renglon).Cells(2).Value
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        idPermiso = 0
        TxtNivelPermiso.Text = ""
        TxtDescripcion.Text = ""
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If TxtNivelPermiso.Text = "" Or TxtDescripcion.Text = "" Then
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
                Dim permiso As New Permiso(idPermiso, TxtNivelPermiso.Text, TxtDescripcion.Text)
                If permiso.ConsultaUnPermiso() Then
                    If permiso.ValidaNombrePermisoActualizar = False And permiso.ValidaNombrePermisoInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE YA HAY OTRO PERMISO CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'Si el permiso se encuentra registrado, se modifica la información
                        permiso.ActualizarPermiso()
                        FrmCorrecto.LbMensaje.Text = "PERMISO MODIFICADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Permiso
                        permiso.PoblarDataGridPermiso(DGVPermisos)
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    End If

                Else
                    If permiso.ValidaNombrePermisoInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE REGISTRAR PORQUE YA HAY OTRO PERMISO CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'Si el permiso NO está registrado, lo inserta como uno nuevo
                        permiso.InsertaPermiso()
                        FrmCorrecto.LbMensaje.Text = "PERMISO REGISTRADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Permiso
                        permiso.PoblarDataGridPermiso(DGVPermisos)
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
                Dim permiso As New Permiso(idPermiso, TxtNivelPermiso.Text, TxtDescripcion.Text)
                If permiso.ConsultaUnPermiso() Then
                    'Consulta que ningún rol dependa del permiso
                    If permiso.ValidaPermisoConRol() Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ELIMINAR EL PERMISO: '" & TxtNivelPermiso.Text & "' PORQUE TIENE UNO O MÁS ROLES QUE DEPENDEN DE ÉSTE MISMO!"
                        FrmAviso.Show()
                    Else
                        'Sí ningún rol depende del permiso se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL PERMISO '" & TxtNivelPermiso.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Llamamos al método que elimina el registro del permiso
                            permiso.EliminarPermiso()
                            FrmCorrecto.LbMensaje.Text = "PERMISO ELIMINADO CORRECTAMENTE!"
                            FrmCorrecto.Show()
                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            permiso.PoblarDataGridPermiso(DGVPermisos)
                        End If
                    End If
                Else
                    FrmAviso.LbMensaje.Text = "NO EXISTE EL PERMISO"
                    FrmAviso.Show()
                End If
                'Actualizar DGV de Permiso
                permiso.PoblarDataGridPermiso(DGVPermisos)
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

    Private Sub TxtNivelPermiso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNivelPermiso.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub FrmPermiso_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub

    Private Sub FrmPermiso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "Rol" Then
            FrmRol.Activate()
            FrmRol.Show()
        End If
        abiertoDesde = ""
    End Sub
End Class
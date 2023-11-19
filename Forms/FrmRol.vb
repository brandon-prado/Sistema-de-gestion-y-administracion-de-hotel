Public Class FrmRol
    Public rol As New Rol
    Private idRol As Integer
    Public idPermiso As Integer

    Private Sub FrmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para regresar a la ventana anterior")
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Registar o actualizar género")
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar el género")
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Limpiar caja de texto")

        'Poblar DGV
        rol.PoblarDataGridRol(DGVRoles)
        'Ocultar columna de ID de rol y permiso
        DGVRoles.Columns(0).Visible = False
        DGVRoles.Columns(1).Visible = False

        'Poblar el comboBox de permisos
        rol.PoblarComboBoxPermiso()
        'Saber que Id le corresponde inicialmente
        rol.IdSeleccionadoEnCB()
    End Sub

    Private Sub DGVRoles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVRoles.CellContentClick
        Dim renglon As Integer
        Try
            renglon = DGVRoles.CurrentCellAddress.Y

            'Llenar las cajas de texto al seleccionar un resgistro del DGV
            idRol = DGVRoles.Rows(renglon).Cells(0).Value
            idPermiso = DGVRoles.Rows(renglon).Cells(1).Value
            CBNivelPermiso.Text = DGVRoles.Rows(renglon).Cells(2).Value
            TxtRol.Text = DGVRoles.Rows(renglon).Cells(3).Value

            If IsDBNull(DGVRoles.Rows(renglon).Cells(4).Value) Then
                TxtDescripcion.Text = ""
            Else
                TxtDescripcion.Text = DGVRoles.Rows(renglon).Cells(4).Value
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        idRol = 0
        idPermiso = 0
        CBNivelPermiso.Text = ""
        TxtRol.Text = ""
        TxtDescripcion.Text = ""
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If idPermiso = 0 Or CBNivelPermiso.Text = "" Or TxtRol.Text = "" Then
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
                Dim rol As New Rol(idRol, idPermiso, TxtRol.Text, TxtDescripcion.Text)
                If rol.ConsultaUnRol() Then
                    If rol.ValidaNombreRolActualizar = False And rol.ValidaNombreRolInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ACTUALIZAR PORQUE YA HAY OTRO ROL CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'Si el rol se encuentra registrado, se modifica la información
                        rol.ActualizarRol()
                        FrmCorrecto.LbMensaje.Text = "ROL MODIFICADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Permiso
                        rol.PoblarDataGridRol(DGVRoles)
                        'Limpiamos caja de texto
                        Call BtnLimpiar_Click(sender, e)
                    End If

                Else
                    If rol.ValidaNombreRolInsertar Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE REGISTRAR PORQUE YA HAY OTRO ROL CON EL MISMO NOMBRE"
                        FrmAviso.Show()
                    Else
                        'Si el rol NO está registrado, lo inserta como uno nuevo
                        rol.InsertaRol()
                        FrmCorrecto.LbMensaje.Text = "REGISTRADO CORRECTAMENTE"
                        FrmCorrecto.Show()

                        'Actualizar DGV de Permiso
                        rol.PoblarDataGridRol(DGVRoles)
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
                Dim rol As New Rol(idRol, idPermiso, TxtRol.Text, TxtDescripcion.Text)
                If rol.ConsultaUnRol() Then
                    'Consulta que ningún usuario dependa del rol
                    If rol.ValidaRolConUsuario() Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ELIMINAR EL ROL: '" & TxtRol.Text & "' PORQUE TIENE UNO O MÁS USUARIOS QUE DEPENDEN DE ÉSTE MISMO!"
                        FrmAviso.Show()
                    Else
                        'Sí ningún usuario depende del rol se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL ROL '" & TxtRol.Text & "'?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Llamamos al método que elimina el registro del permiso
                            rol.EliminarRol()
                            FrmCorrecto.LbMensaje.Text = "ROL ELIMINADO CORRECTAMENTE!"
                            FrmCorrecto.Show()
                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            rol.PoblarDataGridRol(DGVRoles)
                        End If
                    End If
                Else
                    FrmAviso.LbMensaje.Text = "NO EXISTE EL ROL"
                    FrmAviso.Show()
                End If
                'Actualizar DGV de rol
                rol.PoblarDataGridRol(DGVRoles)
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

    Private Sub BtnAgregarNivelPermiso_Click(sender As Object, e As EventArgs) Handles BtnAgregarNivelPermiso.Click
        abiertoDesde = "Rol"
        FrmPermiso.Show()
    End Sub

    Private Sub CBNivelPermiso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBNivelPermiso.SelectedIndexChanged
        rol.IdSeleccionadoEnCB()
    End Sub

    Private Sub TxtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRol.KeyPress
        SoloLetrasSinApostrofe(e)
    End Sub

    Private Sub TxtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        SoloLetrasYNumerosSinApostrofe(e)
    End Sub

    Private Sub FrmRol_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRegistrar.PerformClick()
        End If
    End Sub
End Class
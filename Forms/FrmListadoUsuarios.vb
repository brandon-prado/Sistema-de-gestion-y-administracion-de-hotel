Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class FrmListadoUsuarios
    'Instanciar el objeto
    Public usuarios As New ListadoUsuarios
    Private modoImpresion As String = "Todo"

    Private Sub FrmListadoUsuarios_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'Poblar el DGV
        RbMostrarTodos.Checked = True
        usuarios.getSetFiltro = "TODO"
        usuarios.PoblarDataGridUsuarios(DGVListadoUsuarios)
        'OCULTAR COLUMNA DEL ID de usuario, genero, rol y contraseña
        DGVListadoUsuarios.Columns(0).Visible = False
        DGVListadoUsuarios.Columns(1).Visible = False
        DGVListadoUsuarios.Columns(2).Visible = False
        DGVListadoUsuarios.Columns(14).Visible = False
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub BtnRegresar_Click_1(sender As Object, e As EventArgs)
        'If ModuloGlobal.BuscarFormularioActivo("FrmMenuAdministracion") Then
        '    FrmCargando.MostarConTiempoEnCargar(300)
        '    FrmMenuAdministracion.Show()
        'Else
        '    FrmCargando.MostarConTiempoEnCargar(1000)
        '    FrmMenuAdministracion.Show()
        'End If
        ModuloGlobal.modoSuperUsuario = False
        Me.Hide()
    End Sub

    Private Sub BtnPantallaUsuarios_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPantallaInicio_Click_1(sender As Object, e As EventArgs)
        abiertoDesde = ""
        'If ModuloGlobal.BuscarFormularioActivo("FrmMenuPrincipal") Then
        'FrmCargando.MostarConTiempoEnCargar(300)
        'FrmMenuPrincipal.Activate()
        'FrmMenuPrincipal.Show()
        'Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Activate()
        FrmMenuPrincipal.Show()
        'End If
        FrmAdministracionUsuarios.Close()
        Me.Close()
    End Sub

    Private Sub BtnCerrarSesion_Click_1(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
    End Sub

    Private Sub BtnNuevoUsuario_Click_1(sender As Object, e As EventArgs) Handles BtnNuevoUsuario.Click
        abiertoDesde = "ListadoUsuarios"
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmAdministracionUsuarios.usuario.PoblarComboBoxGenero()
        FrmAdministracionUsuarios.usuario.PoblarComboBoxRoles()

        FrmAdministracionUsuarios.idUsuario = 0
        FrmAdministracionUsuarios.idGenero = 0
        FrmAdministracionUsuarios.idRol = 0
        FrmAdministracionUsuarios.CBRol.Text = ""
        FrmAdministracionUsuarios.TxtNombreUsuario.Text = ""
        FrmAdministracionUsuarios.TxtPaternoUsuario.Text = ""
        FrmAdministracionUsuarios.TxtMaternoUsuario.Text = ""
        FrmAdministracionUsuarios.CBGenero.Text = ""
        FrmAdministracionUsuarios.TxtTelefonoUsuario.Text = ""
        FrmAdministracionUsuarios.TxtIdentificacionUsuario.Text = ""
        FrmAdministracionUsuarios.TxtDireccionUsuario.Text = ""
        FrmAdministracionUsuarios.DateTimeFechaIngreso.Text = ""
        FrmAdministracionUsuarios.RBTieneAccesoSistema.Checked = False
        FrmAdministracionUsuarios.RBNoTieneAccesoSistema.Checked = False
        FrmAdministracionUsuarios.TxtUsuario.Text = ""
        FrmAdministracionUsuarios.TxtContrasena.Text = ""
        FrmAdministracionUsuarios.CBEstado.Text = ""
        'Bloquear boton de modificar
        BtnModificarUsuario.Visible = False
        FrmAdministracionUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub BtnModificarUsuario_Click_1(sender As Object, e As EventArgs) Handles BtnModificarUsuario.Click
        abiertoDesde = "ListadoUsuarios"
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmAdministracionUsuarios.Show()
        Me.Hide()
        'Desactivar boton
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub FechaHora_Tick_1(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub RbMostrarAccesoSistema_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarAccesoSistema.CheckedChanged
        usuarios.getSetFiltro = "ACCESO"
        usuarios.PoblarDataGridUsuarios(DGVListadoUsuarios)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub RbMostrarSinAcceso_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarSinAcceso.CheckedChanged
        usuarios.getSetFiltro = "NOACCESO"
        usuarios.PoblarDataGridUsuarios(DGVListadoUsuarios)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub RbMostrarTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarTodos.CheckedChanged
        usuarios.getSetFiltro = "TODO"
        usuarios.PoblarDataGridUsuarios(DGVListadoUsuarios)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub RbMostrarInactivos_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarInactivos.CheckedChanged
        usuarios.getSetFiltro = "INACTIVO"
        usuarios.PoblarDataGridUsuarios(DGVListadoUsuarios)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub DGVListadoUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListadoUsuarios.CellContentClick
        Dim renglon As Integer
        renglon = DGVListadoUsuarios.CurrentCellAddress.Y
        FrmAdministracionUsuarios.usuario.PoblarComboBoxGenero()
        FrmAdministracionUsuarios.usuario.PoblarComboBoxRoles()
        Try
            'Llenar las cajas de texto al seleccionar un resgistro del DGV
            FrmAdministracionUsuarios.idUsuario = DGVListadoUsuarios.Rows(renglon).Cells(0).Value
            FrmAdministracionUsuarios.idGenero = DGVListadoUsuarios.Rows(renglon).Cells(1).Value
            FrmAdministracionUsuarios.idRol = DGVListadoUsuarios.Rows(renglon).Cells(2).Value
            FrmAdministracionUsuarios.CBRol.Text = DGVListadoUsuarios.Rows(renglon).Cells(3).Value
            FrmAdministracionUsuarios.TxtNombreUsuario.Text = DGVListadoUsuarios.Rows(renglon).Cells(4).Value
            FrmAdministracionUsuarios.TxtPaternoUsuario.Text = DGVListadoUsuarios.Rows(renglon).Cells(5).Value
            FrmAdministracionUsuarios.TxtMaternoUsuario.Text = DGVListadoUsuarios.Rows(renglon).Cells(6).Value
            FrmAdministracionUsuarios.CBGenero.Text = DGVListadoUsuarios.Rows(renglon).Cells(7).Value
            FrmAdministracionUsuarios.TxtTelefonoUsuario.Text = DGVListadoUsuarios.Rows(renglon).Cells(8).Value
            FrmAdministracionUsuarios.TxtIdentificacionUsuario.Text = DGVListadoUsuarios.Rows(renglon).Cells(9).Value
            FrmAdministracionUsuarios.TxtDireccionUsuario.Text = DGVListadoUsuarios.Rows(renglon).Cells(10).Value
            FrmAdministracionUsuarios.DateTimeFechaIngreso.Text = DGVListadoUsuarios.Rows(renglon).Cells(11).Value
            If (DGVListadoUsuarios.Rows(renglon).Cells(12).Value).Equals("Si") Then
                FrmAdministracionUsuarios.RBTieneAccesoSistema.Checked = True
                FrmAdministracionUsuarios.RBNoTieneAccesoSistema.Checked = False
            ElseIf (DGVListadoUsuarios.Rows(renglon).Cells(12).Value).Equals("No") Then
                FrmAdministracionUsuarios.RBTieneAccesoSistema.Checked = False
                FrmAdministracionUsuarios.RBNoTieneAccesoSistema.Checked = True
            End If

            If IsDBNull(DGVListadoUsuarios.Rows(renglon).Cells(13).Value) Then
                FrmAdministracionUsuarios.TxtUsuario.Text = ""
            Else
                FrmAdministracionUsuarios.TxtUsuario.Text = DGVListadoUsuarios.Rows(renglon).Cells(13).Value
            End If

            If IsDBNull(DGVListadoUsuarios.Rows(renglon).Cells(14).Value) Then
                FrmAdministracionUsuarios.TxtContrasena.Text = ""
            Else
                FrmAdministracionUsuarios.TxtContrasena.Text = DGVListadoUsuarios.Rows(renglon).Cells(14).Value
            End If
            FrmAdministracionUsuarios.CBEstado.Text = DGVListadoUsuarios.Rows(renglon).Cells(15).Value
            'Una vez seleccionado el registro, activar el botón de Modificar o eliminar
            BtnModificarUsuario.Visible = True
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DGVListadoUsuarios_CellFormatting(sender As Object, e As DataGridViewCellEventArgs)

        'If e.ColumnIndex = 10 Then
        '    Dim row As DataGridViewRow = DGVListadoUsuarios.Rows(e.RowIndex)

        '    If CStr(row.Cells(2).Value) = "Desactivado" Then
        '        row.DefaultCellStyle.BackColor = Color.Red
        '    End If

        'End If

        'If e.ColumnIndex = 9 Then
        '    Dim row As DataGridViewRow = DGVListadoUsuarios.Rows(e.RowIndex)

        '    If CStr(row.Cells(1).Value) = "Activo" Then
        '        row.DefaultCellStyle.BackColor = Color.Green
        '    End If

        'End If
        'If DGVListadoUsuarios.Columns(e.ColumnIndex).Name = "estado_usuario" Then
        '    Dim row As DataGridViewRow = DGVListadoUsuarios.Rows(e.RowIndex)

        '    If CStr(row.Cells(9).Value) = "Desactivado" Then
        '        row.DefaultCellStyle.BackColor = Color.Red
        '    End If

        'End If

        'If DGVListadoUsuarios.Columns(e.ColumnIndex).Name = "estado_usuario" Then
        '    Dim row As DataGridViewRow = DGVListadoUsuarios.Rows(e.RowIndex)

        '    If CStr(row.Cells(9).Value) = "Activo" Then
        '        row.DefaultCellStyle.BackColor = Color.Green
        '    End If

        'End If

    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        FrmAdministracionUsuarios.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        FrmAdministracionUsuarios.Close()
        Me.Close()
    End Sub

    'Método que recarga los DGV de listado usuarios, esto al hacer una modificacion en Administracion de Usuarios
    Public Sub ActualizarDGV()
        If RbMostrarAccesoSistema.Checked = True Then
            usuarios.getSetFiltro = "ACCESO"
            usuarios.PoblarDataGridUsuarios(DGVListadoUsuarios)
        ElseIf RbMostrarSinAcceso.Checked = True Then
            usuarios.getSetFiltro = "NOACCESO"
            usuarios.PoblarDataGridUsuarios(DGVListadoUsuarios)
        ElseIf RbMostrarTodos.Checked = True Then
            usuarios.getSetFiltro = "TODO"
            usuarios.PoblarDataGridUsuarios(DGVListadoUsuarios)
        ElseIf RbMostrarInactivos.Checked = True Then
            usuarios.getSetFiltro = "INACTIVO"
            usuarios.PoblarDataGridUsuarios(DGVListadoUsuarios)
        End If
    End Sub

    Private Sub BtnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles BtnLimpiarBusqueda.Click
        TxtDatoBuscar.Text = ""
    End Sub

    'Busqueda en tiempo real
    Private Sub TxtDatoBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtDatoBuscar.TextChanged
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim datoB As String

        RbMostrarTodos.Checked = True

        'El dato ingresado es convertido en minúscula
        datoB = LCase(TxtDatoBuscar.Text)

        If CBBuscarPor.Text = "Nombre" Then
            strSql = "SELECT u.id_usuario AS ""ID USUARIO"", g.id_genero AS ""ID GÉNERO"", r.id_rol AS ""ID ROL"", 
                        r.nombre_rol AS ""ROL"", u.nombre_usuario AS ""NOMBRE"", u.paterno_usuario AS ""APELLIDO PATERNO"", 
                        u.materno_usuario AS ""APELLIDO MATERNO"", g.nombre_genero AS ""GÉNERO"", 
                        u.telefono_usuario AS ""TELÉFONO"", u.identificacion_usuario AS ""IDENTIFICACIÓN"", 
                        u.direccion_usuario AS ""DIRECCIÓN"", u.fecha_ingreso AS ""FECHA DE INGRESO"", 
                        u.tiene_acceso_sistema AS ""¿TIENE ACCESO?"", u.usuario AS ""USUARIO"", 
                        u.contrasena AS ""CONTRASEÑA"", u.estado_usuario AS ""ESTADO""
                     FROM Usuario u, Rol r, Genero g
                     WHERE u.id_rol = r.id_rol
                     AND u.id_genero = g.id_genero
                     AND lower(u.nombre_usuario) LIKE '%" & datoB & "%'"

            DGVListadoUsuarios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoUsuarios.Refresh()

        ElseIf CBBuscarPor.Text = "Apellido paterno" Then
            strSql = "SELECT u.id_usuario AS ""ID USUARIO"", g.id_genero AS ""ID GÉNERO"", r.id_rol AS ""ID ROL"", 
                        r.nombre_rol AS ""ROL"", u.nombre_usuario AS ""NOMBRE"", u.paterno_usuario AS ""APELLIDO PATERNO"", 
                        u.materno_usuario AS ""APELLIDO MATERNO"", g.nombre_genero AS ""GÉNERO"", 
                        u.telefono_usuario AS ""TELÉFONO"", u.identificacion_usuario AS ""IDENTIFICACIÓN"", 
                        u.direccion_usuario AS ""DIRECCIÓN"", u.fecha_ingreso AS ""FECHA DE INGRESO"", 
                        u.tiene_acceso_sistema AS ""¿TIENE ACCESO?"", u.usuario AS ""USUARIO"", 
                        u.contrasena AS ""CONTRASEÑA"", u.estado_usuario AS ""ESTADO""
                     FROM Usuario u, Rol r, Genero g
                     WHERE u.id_rol = r.id_rol
                     AND u.id_genero = g.id_genero
                     AND lower(u.paterno_usuario) LIKE '%" & datoB & "%'"
            DGVListadoUsuarios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoUsuarios.Refresh()

        ElseIf CBBuscarPor.Text = "Apellido materno" Then
            strSql = "SELECT u.id_usuario AS ""ID USUARIO"", g.id_genero AS ""ID GÉNERO"", r.id_rol AS ""ID ROL"", 
                        r.nombre_rol AS ""ROL"", u.nombre_usuario AS ""NOMBRE"", u.paterno_usuario AS ""APELLIDO PATERNO"", 
                        u.materno_usuario AS ""APELLIDO MATERNO"", g.nombre_genero AS ""GÉNERO"", 
                        u.telefono_usuario AS ""TELÉFONO"", u.identificacion_usuario AS ""IDENTIFICACIÓN"", 
                        u.direccion_usuario AS ""DIRECCIÓN"", u.fecha_ingreso AS ""FECHA DE INGRESO"", 
                        u.tiene_acceso_sistema AS ""¿TIENE ACCESO?"", u.usuario AS ""USUARIO"", 
                        u.contrasena AS ""CONTRASEÑA"", u.estado_usuario AS ""ESTADO""
                     FROM Usuario u, Rol r, Genero g
                     WHERE u.id_rol = r.id_rol
                     AND u.id_genero = g.id_genero
                     AND lower(u.materno_usuario) LIKE '%" & datoB & "%'"
            DGVListadoUsuarios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoUsuarios.Refresh()

        ElseIf CBBuscarPor.Text = "Usuario" Then
            strSql = "SELECT u.id_usuario AS ""ID USUARIO"", g.id_genero AS ""ID GÉNERO"", r.id_rol AS ""ID ROL"", 
                        r.nombre_rol AS ""ROL"", u.nombre_usuario AS ""NOMBRE"", u.paterno_usuario AS ""APELLIDO PATERNO"", 
                        u.materno_usuario AS ""APELLIDO MATERNO"", g.nombre_genero AS ""GÉNERO"", 
                        u.telefono_usuario AS ""TELÉFONO"", u.identificacion_usuario AS ""IDENTIFICACIÓN"", 
                        u.direccion_usuario AS ""DIRECCIÓN"", u.fecha_ingreso AS ""FECHA DE INGRESO"", 
                        u.tiene_acceso_sistema AS ""¿TIENE ACCESO?"", u.usuario AS ""USUARIO"", 
                        u.contrasena AS ""CONTRASEÑA"", u.estado_usuario AS ""ESTADO""
                     FROM Usuario u, Rol r, Genero g
                     WHERE u.id_rol = r.id_rol
                     AND u.id_genero = g.id_genero
                     AND lower(u.usuario) LIKE '%" & datoB & "%'"
            DGVListadoUsuarios.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoUsuarios.Refresh()
        End If
    End Sub

    Private Sub CBBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscarPor.SelectedIndexChanged
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
        'FrmRegistroReservacion.Close()
        FrmAdministracionUsuarios.Close()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        ' FrmRegistroReservacion.Close()
        FrmAdministracionUsuarios.Close()
        Me.Close()
    End Sub

    Private Sub TxtDatoBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatoBuscar.KeyPress
        If CBBuscarPor.Text = "Nombre" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Apellido paterno" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Apellido materno" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Usuario" Then
            SoloLetrasSinApostrofe(e)
        End If
    End Sub

    'Funcion para obtener el tamaño de las columnas del DGV
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            If i = 0 Or i = 1 Or i = 2 Or i = 12 Or i = 13 Or i = 14 Then
            Else
                values(i) = CSng(dg.Columns(i).Width)
            End If
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Try
            'Se crea documento PDFTable con el numero de columnas del DGV
            Dim dataTable As New PdfPTable(DGVListadoUsuarios.ColumnCount)
            'Propiedades del documento
            dataTable.DefaultCell.Padding = 3
            Dim headerWidth As Single() = GetColumnasSize(DGVListadoUsuarios)
            dataTable.SetWidths(headerWidth)
            dataTable.WidthPercentage = 100
            dataTable.DefaultCell.BorderWidth = 2
            dataTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
            'Encabezado del PDF
            Dim encabezado As New Paragraph("REPORTE DE USUARIOS DEL SISTEMA", New Font(Font.Name = "Tahoma", 20, Font.Bold))
            'Se creael texto debajo del encabezado
            Dim texto As New Phrase
            'Modo de impresion
            'Se creael texto debajo del encabezado
            texto = New Phrase("Reporte de todos los usuarios del sistema generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            'Se captura los nombres de las columnas del DGV
            dataTable.AddCell("")
            dataTable.AddCell("")
            dataTable.AddCell("")
            dataTable.AddCell("ROL")
            dataTable.AddCell("NOMBRE")
            dataTable.AddCell("PATERNO")
            dataTable.AddCell("MATERNO")
            dataTable.AddCell("GÉNERO")
            dataTable.AddCell("TELÉFONO")
            dataTable.AddCell("IDENTIF.")
            dataTable.AddCell("DIRECCIÓN")
            dataTable.AddCell("FECHA DE INGRESO")
            dataTable.AddCell("")
            dataTable.AddCell("")
            dataTable.AddCell("")
            dataTable.AddCell("ESTADO")
            'Se obtiene el valor de cada celda de la tabla
            For i As Integer = 0 To DGVListadoUsuarios.RowCount - 1
                For j As Integer = 0 To DGVListadoUsuarios.ColumnCount - 1
                    'If i = 0 Or i = 1 Or i = 2 Or i = 7 Then
                    'Else
                    If IsDBNull(DGVListadoUsuarios.Rows(i).Cells(j).Value) Then
                        dataTable.AddCell("Sin dato")
                    Else
                        If CStr(DGVListadoUsuarios(j, i).Value) = "" Then
                        Else
                            dataTable.AddCell(DGVListadoUsuarios(j, i).Value.ToString())
                        End If
                    End If
                    'End If

                Next
                dataTable.CompleteRow()
            Next

            'Obtener imagen para agregar al documento PDF
            Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance("C:\IDEA Software\imgLogo\logo.png")
            'image1.ScalePercent(50.0F)
            image.ScaleAbsoluteWidth(150)
            image.ScaleAbsoluteHeight(150)
            image.Alignment = image.ALIGN_CENTER

            'Datos de contacto 
            Dim datoDeContacto = New Paragraph("Hotel Posada Favela" + vbCr + "Calle Melchor Ocampo #43, Zona Centro C. P. 27980" + vbCr + "Parras de la Fuente, Coahuila, México." + vbCr + "842 422 3566" + vbCr + "posadafavela@gmail.com", New Font(Font.Name = "Tahoma", 14, Font.Bold))
            datoDeContacto.Alignment = Element.ALIGN_CENTER

            'Se agrega el PDFTable todos los datos generados
            document.Add(encabezado)
            document.Add(texto)
            document.Add(dataTable)
            document.Add(image)
            document.Add(datoDeContacto)
        Catch ex As Exception
            '  MsgBox("Error al generar PDF: " & ex.Message)
        End Try
    End Sub

    Public Sub ImprimirReporteUsuarios()
        Try
            'Mandar a generar el docuemnto
            Dim documento As New Document(PageSize.A3.Rotate(), 10, 10, 10, 10)
            'Path que guarda el documento en la direccion de reportes 
            Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de Usuarios del Sistema.pdf"
            Dim file As New FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(documento, file)
            documento.Open()
            ExportarDatosPDF(documento)
            documento.Close()
            Process.Start(fileName)
        Catch ex As Exception
            MsgBox("Error al generar PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        ImprimirReporteUsuarios()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Activate()
        FrmCerrarSesion.Show()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmAdministracionUsuarios.Close()
        FrmGenero.Close()
        FrmRol.Close()
        FrmPermiso.Close()
    End Sub

    Private Sub FrmListadoUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "MenuAmin" Then
            FrmMenuAdministracion.Activate()
            FrmMenuAdministracion.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub
End Class
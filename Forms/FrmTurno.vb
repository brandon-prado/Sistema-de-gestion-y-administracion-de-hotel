Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class FrmTurno
    Public turno As New Turno()
    Private idTurno As Integer
    Public idUsuario As Integer
    ' Variable a nivel de clase para recordar en qué punto nos hemos quedado
    Dim i As Integer = 0

    Private Sub FrmTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Formulario
        'InitializeComponent()
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True
        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        'Application.DoEvents()

        'ToolTip para mostrar información de referencia al momento de colocar el mouse 
        'encima de un botón, imagen, etc.
        'Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para regresar a la ventana anterior")
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Eliminar el turno")

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Poblar DGV
        turno.PoblarDataGridTurno(DGVTurnos)
        'Ocultar columna de ID de turno y usuario, y nombre porque se empalma con el nombre completo
        DGVTurnos.Columns(0).Visible = False
        DGVTurnos.Columns(1).Visible = False
        'DGVTurnos.Columns(4).Visible = False

        'TxtCantidadRetiro.Text = "0.0"
        'Cargar informacion en caja
        turno.MostrarCantidadActualCaja()
        turno.MostrarCantidadAperturaCaja()
        turno.MostrarCantidadRetiroCaja()


        MostrarOcultarBotones()
        BtnCerrarSesionSinCorte.Visible = False
    End Sub

    Private Sub MostrarOcultarBotones()
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            '  BtnEliminar.Visible = True
            ' BtnCerrarSesionSinCorte.Visible = True
        Else
            BtnEliminar.Visible = False
            BtnCerrarSesionSinCorte.Visible = False
        End If
    End Sub

    Private Sub DGVTurnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTurnos.CellContentClick
        Dim renglon As Integer
        renglon = DGVTurnos.CurrentCellAddress.Y
        Try
            idTurno = DGVTurnos.Rows(renglon).Cells(0).Value
            idUsuario = DGVTurnos.Rows(renglon).Cells(1).Value


        Catch ex As Exception
            'MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnAgregarNota_Click(sender As Object, e As EventArgs)
        FrmNota.Show()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs)
        idTurno = 0
        idUsuario = 0
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If idUsuario = 0 Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            ComprobarDatos = True
        End If
    End Function

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Try
            If ComprobarDatos() Then
                'Instanciar el objeto
                Dim turno As New Turno
                turno.GetSetIdTurno = idTurno
                turno.GetSetIdUsuario = idUsuario
                If turno.ConsultaUnTurno() Then
                    'Consulta que ninguna reservacion dependa del cliente
                    If turno.ValidaTurnoConEgreso() Then
                        FrmAviso.LbMensaje.Text = "NO SE PUEDE ELIMINAR EL TURNO PORQUE TIENE UNO O MÁS DEPENDENCIAS!"
                        FrmAviso.Show()
                    Else
                        'Sí ningun egreso depende del turno se pide confirmar la acción de borrado
                        If MessageBox.Show("¿ESTÁ SEGURO DE QUE QUIERE BORRAR EL TURNO?", "CONFIRMAR", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                            'Llamamos al método que elimina el registro del permiso
                            turno.EliminarTurno()
                            FrmCorrecto.LbMensaje.Text = "TURNO ELIMINADO CORRECTAMENTE!"
                            FrmCorrecto.Show()
                            'Llamamnos al método para poblar el DGV para que se vea la eliminación del registro
                            turno.PoblarDataGridTurno(DGVTurnos)
                        End If
                    End If
                Else
                    FrmAviso.LbMensaje.Text = "No existe el turno"
                    FrmAviso.Show()
                End If
                'Limpiamos caja de texto
                'Call BtnLimpiar_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox("ALGÚN DATO CAUSA CONFLICTO: " & ex.Message)
        End Try
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs)
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Activate()
        FrmMenuPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs)
        'FrmMenuAdministracion.Show()
        Me.Close()
        'Limpiamos caja de texto
        Call BtnLimpiar_Click(sender, e)
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs)
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
            Me.Close()
            'AQUI FALTAN LOS FORMULARIO QUE DEPENDEN ESTE FORM, SE DEBEN CERRAR - CLOSE
        Else
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Nothing, Me)
            FrmAutorizacion.Activate()
            FrmAutorizacion.Show()
            'AQUI FALTAN LOS FORMULARIO QUE DEPENDEN ESTE FORM, SE DEBEN CERRAR - CLOSE
        End If

    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
    End Sub

    Public Sub ImprimirReporteTurno()
        Try
            'Mandar a generar el docuemnto
            Dim documento As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el documento en la direccion de reportes 
            Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de turno.pdf"
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

    'Funcion para obtener el tamaño de las columnas del DGV
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 2 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Try
            'Se crea documento PDFTable con el numero de columnas del DGV
            Dim dataTable As New PdfPTable(DGVTurnos.ColumnCount)
            'Propiedades del documento
            dataTable.DefaultCell.Padding = 3
            Dim headerWidth As Single() = GetColumnasSize(DGVTurnos)
            dataTable.SetWidths(headerWidth)
            dataTable.WidthPercentage = 100
            dataTable.DefaultCell.BorderWidth = 2
            dataTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
            'Encabezado del PDF
            Dim encabezado As New Paragraph("REPORTE DE TURNOS", New Font(Font.Name = "Tahoma", 20, Font.Bold))
            'Se creael texto debajo del encabezado
            Dim texto As New Phrase("Reporte de turnos generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            'Se captura los nombres de las columnas del DGV
            dataTable.AddCell("")
            dataTable.AddCell("")
            dataTable.AddCell("Inicio Turno")
            dataTable.AddCell("Cierre Turno")
            dataTable.AddCell("Usuario")
            dataTable.AddCell("Cantidad inicial")
            dataTable.AddCell("Cantidad actual")
            dataTable.AddCell("Cantidad capturada")
            dataTable.AddCell("Cantidad diferencia")
            dataTable.AddCell("Nota")
            'Se obtiene el valor de cada celda de la tabla
            For i As Integer = 0 To DGVTurnos.RowCount - 1
                For j As Integer = 0 To DGVTurnos.ColumnCount - 1
                    If IsDBNull(DGVTurnos.Rows(i).Cells(j).Value) Then
                        dataTable.AddCell("Sin dato")
                    Else
                        If CStr(DGVTurnos(j, i).Value) = "" Then
                        Else
                            dataTable.AddCell(DGVTurnos(j, i).Value.ToString())
                        End If
                    End If
                Next
                dataTable.CompleteRow()
            Next

            'Obtener imagen para agregar al documento PDF
            Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance("C:\IDEA Software\imgLogo\logo.png")
            'image1.ScalePercent(50.0F)
            image.ScaleAbsoluteWidth(150)
            image.ScaleAbsoluteHeight(150)
            image.Alignment = Image.ALIGN_CENTER

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

    Private Sub BtnRetiroManual_Click(sender As Object, e As EventArgs) Handles BtnRetiroManual.Click
        abiertoDesde = "Turno"
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmEgreso.Show()
    End Sub

    Private Sub FrmTurno_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnRetiroManual.PerformClick()
        End If
    End Sub

    Private Sub BtnVerIngresos_Click(sender As Object, e As EventArgs) Handles BtnVerIngresos.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        abiertoDesde = "Turno"
        FrmListadoCobros.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        abiertoDesde = "Turno"
        FrmListadoEgreso.Show()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmListadoEgreso.Close()
        FrmEgreso.Close()
        FrmListadoCobros.Close()
    End Sub

    Private Sub FrmTurno_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "MenuPrincipal" Then
            FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
        ElseIf abiertoDesde = "MenuAdmin" Then
            FrmMenuAdministracion.Activate()
            FrmMenuAdministracion.Show()
        End If
        CerrarVentanasCascada()
        abiertoDesde = ""
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
        Me.Close()
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs)
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        Me.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        Me.Close()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs)
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        Me.Close()
    End Sub

    Private Sub BtnImprimirIngreso_Click(sender As Object, e As EventArgs) Handles BtnImprimirIngreso.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        ImprimirReporteTurno()
    End Sub
End Class
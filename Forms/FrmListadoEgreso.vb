Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Oracle.DataAccess.Client

Public Class FrmListadoEgreso

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Public totalEgreso As Double
    Public totalEgresoFecha As Double

    Public modoImpresion As String = "Todo"


    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs) Handles BtnPantallaInicio.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmMenuPrincipal.Activate()
        FrmMenuPrincipal.Show()
        FrmEgreso.Close()
        FrmTurno.Close()
        FrmMenuAdministracion.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs) Handles BtnPantallaUsuarios.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
            FrmEgreso.Close()
            FrmTurno.Close()
            Me.Hide()
        Else
            FrmEgreso.Close()
            FrmTurno.Close()
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Me, Nothing)
            FrmAutorizacion.Activate()
            FrmAutorizacion.Show()
        End If
    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaHabitaciones.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoHabitaciones.Activate()
        FrmListadoHabitaciones.Show()
        FrmEgreso.Close()
        FrmTurno.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaClientes_Click(sender As Object, e As EventArgs) Handles BtnPantallaClientes.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoClientes.Activate()
        FrmListadoClientes.Show()
        FrmEgreso.Close()
        FrmTurno.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs) Handles BtnPantallaReservaciones.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        FrmEgreso.Close()
        FrmTurno.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs) Handles BtnPantallaFolios.Click
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        FrmEgreso.Close()
        FrmTurno.Close()
        Me.Close()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        If nombreRol = "Contador" Then
            FrmReportes.Show()
            Me.Close()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub FrmListadoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True

        'Hora y fecha del sistema
        FechaHora.Enabled = True

        'Mostrar nombre completo del usuario
        LbUsuario.Text = nombreUsuario.ToString & vbCr & paternoUsuario.ToString & " " & maternoUsuario.ToString
        LbRol.Text = nombreRol.ToString

        'Cargar primero el formulario y luego seguir
        Application.DoEvents()

        'Cargar el DGV
        PoblarDGVTodosEgresos()
    End Sub

    Private Sub FechaHora_Tick_1(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    'Método que muestra en el DGV todos los egresos realizados
    Public Sub PoblarDGVTodosEgresos()
        strSql = "SELECT * FROM Vista_Egreso"

        DGVEgresos.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVEgresos.Columns(0).Visible = False
        DGVEgresos.Refresh()
    End Sub

    'MÉTODO QUE CONSULTA TODOS LOS EGRESOS EN UNA FECHA DETERMINADA
    Public Sub ConsultaRangoEgreso()
        strSql = "SELECT e.id_egreso AS ""ID EGRESO"", e.id_turno AS ""TURNO"", e.fecha_hora_egreso AS ""FECHA DE EGRESO"",
                    e.cantidad_egreso AS ""CANTIDAD DE EGRESO $"", e.concepto AS ""CONCEPTO DE EGRESO"",
                    u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS ""USUARIO QUE REALIZÓ EL RETIRO""
                    FROM Egreso e, Turno t, Usuario u
                    WHERE e.id_turno = t.id_turno
                    AND t.id_usuario = u.id_usuario
                    AND e.fecha_hora_egreso >= '" & DateTimeFechaInicial.Text & "'
                    AND e.fecha_hora_egreso <= '" & DateTimeFechaFinal.Text & "'
                    ORDER BY fecha_hora_egreso DESC"

        DGVEgresos.DataSource = xCnx.objetoDataAdapter(strSql)

        'OCULTAR COLUMNA DEL DGV ID
        DGVEgresos.Columns(0).Visible = False
    End Sub

    Private Sub BtnBuscarReservaciones_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If DateTimeFechaInicial.Text = "" And DateTimeFechaFinal.Text = "" Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            modoImpresion = "Fecha"
            ConsultaRangoEgreso()
        End If
    End Sub

    Private Sub BtnVerTodos_Click(sender As Object, e As EventArgs) Handles BtnVerTodos.Click
        FrmCargando.MostarConTiempoEnCargar(500)
        modoImpresion = "Todo"
        PoblarDGVTodosEgresos()
    End Sub

    'Funcion para obtener el tamaño de las columnas del DGV
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Try
            'Se crea documento PDFTable con el numero de columnas del DGV
            Dim dataTable As New PdfPTable(DGVEgresos.ColumnCount)
            'Propiedades del documento
            dataTable.DefaultCell.Padding = 3
            Dim headerWidth As Single() = GetColumnasSize(DGVEgresos)
            dataTable.SetWidths(headerWidth)
            dataTable.WidthPercentage = 100
            dataTable.DefaultCell.BorderWidth = 2
            dataTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
            'Encabezado del PDF
            Dim encabezado As New Paragraph("REPORTE DE EGRESOS", New Font(Font.Name = "Tahoma", 20, Font.Bold))
            'Se creael texto debajo del encabezado
            Dim texto As New Phrase
            'Modo de impresion
            'OBTENER CANTIDADES
            CantidadTotalEgreso()
            CantidadTotalEgresoFecha()
            Dim estadisticoTotal As String = "Cantidad total de egresos: $" & Format(totalEgreso, "####,###0.00") & vbCr + vbCr
            Dim estadisticoFecha As String = "Cantidad total de egresos a la fecha deseada: $" & Format(totalEgresoFecha, "####,###0.00") & vbCr + vbCr

            Dim estadistico As New Phrase
            'Se creael texto debajo del encabezado
            If modoImpresion = "Todo" Then
                texto = New Phrase("Reporte de todos los egresos generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
                estadistico = New Phrase(estadisticoTotal, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            ElseIf modoImpresion = "Fecha" Then
                Dim rangoFecha As String = DateTimeFechaInicial.Text + " a " + DateTimeFechaFinal.Text
                texto = New Phrase("Reporte de todos los engresos (Con rango de fecha de " + rangoFecha + " ) generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
                'Se crea el dato estadistico
                estadistico = New Phrase(estadisticoFecha, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            End If
            'Se captura los nombres de las columnas del DGV
            dataTable.AddCell("NÚMERO DE EGRESO")
            dataTable.AddCell("NÚMERO DE TURNO")
            dataTable.AddCell("FECHA DE EGRESO")
            dataTable.AddCell("CANTIDAD DE EGRESO")
            dataTable.AddCell("CONCEPTO DE EGRESO")
            dataTable.AddCell("USUARIO QUE REALIZÓ EL RETIRO")
            'Se obtiene el valor de cada celda de la tabla
            For i As Integer = 0 To DGVEgresos.RowCount - 1
                For j As Integer = 0 To DGVEgresos.ColumnCount - 1
                    'If i = 0 Or i = 1 Or i = 2 Or i = 7 Then
                    'Else
                    If IsDBNull(DGVEgresos.Rows(i).Cells(j).Value) Then
                        dataTable.AddCell("Sin dato")
                    Else
                        If CStr(DGVEgresos(j, i).Value) = "" Then
                        Else
                            dataTable.AddCell(DGVEgresos(j, i).Value.ToString())
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
            document.Add(estadistico)
            document.Add(image)
            document.Add(datoDeContacto)
        Catch ex As Exception
            '  MsgBox("Error al generar PDF: " & ex.Message)
        End Try
    End Sub

    Public Sub CantidadTotalEgreso()
        totalEgreso = 0
        Try
            Dim xDT As New DataTable
            Dim totales As New OracleDataAdapter

            totales = New OracleDataAdapter("SELECT SUM(cantidad_egreso) As Total FROM Egreso", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                totalEgreso = registro("Total")
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CantidadTotalEgresoFecha()
        totalEgresoFecha = 0
        Try
            Dim xDT As New DataTable
            Dim totales As New OracleDataAdapter

            totales = New OracleDataAdapter("SELECT SUM(cantidad_egreso) As Total 
                                            FROM Egreso  
                                            WHERE fecha_hora_egreso >= '" & DateTimeFechaInicial.Text & "'
                                            AND fecha_hora_egreso <= '" & DateTimeFechaFinal.Text & "'", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                totalEgresoFecha = registro("Total")
            Next

            If xDT.Rows.Count = 0 Then
                totalEgresoFecha = 0
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub ImprimirReporteEgreso()
        Try
            'Mandar a generar el docuemnto
            Dim documento As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el documento en la direccion de reportes 
            Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de Egresos.pdf"
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

    Private Sub BtnImprimirIngreso_Click(sender As Object, e As EventArgs) Handles BtnImprimirIngreso.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        ImprimirReporteEgreso()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
    End Sub

    Private Sub FrmListadoEgreso_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "Turno" Then
            FrmTurno.Activate()
            FrmTurno.Show()
        ElseIf abiertoDesde = "EgresoTurno" Then
            FrmEgreso.Activate()
            FrmEgreso.Show()
        End If
        abiertoDesde = ""

        If nombreRol = "Contador" Then
            FrmReportes.Activate()
            FrmReportes.Show()
        End If
    End Sub

    Private Sub DGVEgresos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVEgresos.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
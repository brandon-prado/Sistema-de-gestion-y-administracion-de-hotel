Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Oracle.DataAccess.Client

Public Class FrmListadoCobros
    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Public totalEfectivoTarjeta As Double
    Public totalEfectivo As Double
    Public totalTarjeta As Double
    Public totalEfectivoTarjetaFecha As Double

    Public modoImpresion As String = "Todo"

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    'Método que muestra en el DGV todas los ingresos de tarjeta y efectivo
    Public Sub PoblarDGVTodoIngresos()
        strSql = "SELECT p.id_pago AS ""NÚMERO DE TRANSACCIÓN"", p.id_folio AS ""NÚMERO DE RESERVACIÓN"", p.id_metodo_pago AS ""ID MÉT. PAGO"",
                    p.cantidad_pago ""INGRESO"", mp.nombre_met_pago AS ""MÉTODO DE PAGO"", p.fecha_hora_pago AS ""FECHA DE TRANSACCIÓN""
                    FROM Pago p, Metodo_pago mp
                    WHERE p.id_metodo_pago = mp.id_metodo_pago
                    ORDER BY fecha_hora_pago DESC"

        DGVIngresos.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVIngresos.Columns(2).Visible = False
    End Sub

    'Método que muestra en el DGV todas los ingresos en efectivo
    Public Sub PoblarDGVIngresosEfectivo()
        strSql = "SELECT p.id_pago AS ""NÚMERO DE TRANSACCIÓN"", p.id_folio AS ""NÚMERO DE RESERVACIÓN"", p.id_metodo_pago AS ""ID MÉT. PAGO"",
                    p.cantidad_pago ""INGRESO"", mp.nombre_met_pago AS ""MÉTODO DE PAGO"", p.fecha_hora_pago AS ""FECHA DE TRANSACCIÓN""
                    FROM Pago p, Metodo_pago mp
                    WHERE p.id_metodo_pago = mp.id_metodo_pago
                    AND mp.nombre_met_pago = 'Efectivo'
                    ORDER BY fecha_hora_pago DESC"

        DGVIngresos.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVIngresos.Columns(2).Visible = False
    End Sub

    'Método que muestra en el DGV todas los ingresos con tarjeta
    Public Sub PoblarDGVIngresosTarjeta()
        strSql = "SELECT p.id_pago AS ""NÚMERO DE TRANSACCIÓN"", p.id_folio AS ""NÚMERO DE RESERVACIÓN"", p.id_metodo_pago AS ""ID MÉT. PAGO"",
                    p.cantidad_pago ""INGRESO"", mp.nombre_met_pago AS ""MÉTODO DE PAGO"", p.fecha_hora_pago AS ""FECHA DE TRANSACCIÓN""
                    FROM Pago p, Metodo_pago mp
                    WHERE p.id_metodo_pago = mp.id_metodo_pago
                    AND mp.nombre_met_pago = 'Tarjeta'
                    ORDER BY fecha_hora_pago DESC"

        DGVIngresos.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVIngresos.Columns(2).Visible = False
    End Sub

    'Método que muestra en el DGV todas los ingresos por rango de fecha
    Public Sub PoblarDGVTodoIngresoFecha()
        strSql = "SELECT p.id_pago AS ""NÚMERO DE TRANSACCIÓN"", p.id_folio AS ""NÚMERO DE RESERVACIÓN"", p.id_metodo_pago AS ""ID MÉT. PAGO"",
                    p.cantidad_pago ""INGRESO"", mp.nombre_met_pago AS ""MÉTODO DE PAGO"", p.fecha_hora_pago AS ""FECHA DE TRANSACCIÓN""
                    FROM Pago p, Metodo_pago mp
                    WHERE p.id_metodo_pago = mp.id_metodo_pago
                    AND p.fecha_hora_pago >= '" & DateTimeFechaInicial.Text & "'
                    AND p.fecha_hora_pago <= '" & DateTimeFechaFinal.Text & "'
                    ORDER BY fecha_hora_pago DESC"

        DGVIngresos.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        DGVIngresos.Columns(2).Visible = False
    End Sub

    Private Sub RBTodo_CheckedChanged(sender As Object, e As EventArgs) Handles RBTodo.CheckedChanged
        modoImpresion = "Todo"
        PoblarDGVTodoIngresos()
    End Sub

    Private Sub RbEfectivo_CheckedChanged(sender As Object, e As EventArgs) Handles RbEfectivo.CheckedChanged
        modoImpresion = "Efectivo"
        PoblarDGVIngresosEfectivo()
    End Sub

    Private Sub RbTarjeta_CheckedChanged(sender As Object, e As EventArgs) Handles RbTarjeta.CheckedChanged
        modoImpresion = "Tarjeta"
        PoblarDGVIngresosTarjeta()
    End Sub

    Private Sub BtnBuscarReservaciones_Click(sender As Object, e As EventArgs) Handles BtnBuscarReservaciones.Click
        If DateTimeFechaInicial.Text = "" And DateTimeFechaFinal.Text = "" Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            modoImpresion = "RangoFecha"
            'RBTodo.Checked = True
            PoblarDGVTodoIngresoFecha()
        End If
    End Sub

    Private Sub FrmListadoCobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Activar doble buffer para evitar parpadeo con lo graficos del formulario
        Me.DoubleBuffered = True
        'Poblar el DGV
        RBTodo.Checked = True
    End Sub

    'Funcion para obtener el tamaño de las columnas del DGV
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            If i = 2 Then
            Else
                values(i) = CSng(dg.Columns(i).Width)
            End If
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Try
            'Se crea documento PDFTable con el numero de columnas del DGV
            Dim dataTable As New PdfPTable(DGVIngresos.ColumnCount)
            'Propiedades del documento
            dataTable.DefaultCell.Padding = 3
            Dim headerWidth As Single() = GetColumnasSize(DGVIngresos)
            dataTable.SetWidths(headerWidth)
            dataTable.WidthPercentage = 100
            dataTable.DefaultCell.BorderWidth = 2
            dataTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
            'Encabezado del PDF
            Dim encabezado As New Paragraph("REPORTE DE INGRESOS", New Font(Font.Name = "Tahoma", 20, Font.Bold))
            'Se creael texto debajo del encabezado
            Dim texto As New Phrase
            'Modo de impresion
            'OBTENER CANTIDADES
            TotalEfectivoYTarjetaFecha()
            TotalEnTarjeta()
            TotalEnEfectivo()
            TotalEfectivoYTarjeta()
            Dim estadisticoTotal As String = "Cantidad total de ingresos (Tarjeta - Efectivo): $" & Format(totalEfectivoTarjeta, "####,###0.00") & vbCr +
                                        "Cantidad total Tarjeta: $" & Format(totalTarjeta, "####,###0.00") & vbCr +
                                        "Cantidad total Efectivo: $" & Format(totalEfectivo, "####,###0.00") & vbCr + vbCr
            Dim estadisticoEfectivo As String = "Cantidad total Efectivo: $" & Format(totalEfectivo, "####,###0.00") & vbCr + vbCr
            Dim estadisticoTarjeta As String = "Cantidad total Tarjeta: $" & Format(totalTarjeta, "####,###0.00") & vbCr + vbCr
            Dim estadisticoFecha As String = "Cantidad total de ingresos (Tarjeta - Efectivo) a la fecha deseada: $" & Format(totalEfectivoTarjetaFecha, "####,###0.00") & vbCr + vbCr

            Dim estadistico As New Phrase
        'Se creael texto debajo del encabezado
        If modoImpresion = "Todo" Then
            texto = New Phrase("Reporte de todos los ingresos generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            estadistico = New Phrase(estadisticoTotal, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        ElseIf modoImpresion = "Efectivo" Then
            texto = New Phrase("Reporte de todos los ingresos en efectivo generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            estadistico = New Phrase(estadisticoEfectivo, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        ElseIf modoImpresion = "Tarjeta" Then
            texto = New Phrase("Reporte de todas los ingresos por tarjeta generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            estadistico = New Phrase(estadisticoTarjeta, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        ElseIf modoImpresion = "RangoFecha" Then
            Dim rangoFecha As String = DateTimeFechaInicial.Text + " a " + DateTimeFechaFinal.Text
            texto = New Phrase("Reporte de todos los ingresos (Con rango de fecha de " + rangoFecha + " ) generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
            'Se crea el dato estadistico
            estadistico = New Phrase(estadisticoFecha, New Font(Font.Name = "Tahoma", 14, Font.Bold))
        End If
        'Se captura los nombres de las columnas del DGV
        DataTable.AddCell("NÚMERO DE TRANSACCIÓN")
        DataTable.AddCell("NÚMERO DE RESERVACIÓN")
        DataTable.AddCell("")
        DataTable.AddCell("INGRESO")
        DataTable.AddCell("MÉTODO DE PAGO")
        DataTable.AddCell("FECHA DE TRANSACCIÓN")
        'Se obtiene el valor de cada celda de la tabla
        For i As Integer = 0 To DGVIngresos.RowCount - 1
            For j As Integer = 0 To DGVIngresos.ColumnCount - 1
                'If i = 0 Or i = 1 Or i = 2 Or i = 7 Then
                'Else
                If IsDBNull(DGVIngresos.Rows(i).Cells(j).Value) Then
                    DataTable.AddCell("Sin dato")
                Else
                    If CStr(DGVIngresos(j, i).Value) = "" Then
                    Else
                        DataTable.AddCell(DGVIngresos(j, i).Value.ToString())
                    End If
                End If
                'End If

            Next
            DataTable.CompleteRow()
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
        Document.Add(encabezado)
        Document.Add(texto)
        Document.Add(DataTable)
        Document.Add(estadistico)
        Document.Add(image)
        Document.Add(datoDeContacto)
        Catch ex As Exception
        '  MsgBox("Error al generar PDF: " & ex.Message)
        End Try
    End Sub

    Public Sub TotalEfectivoYTarjeta()
        totalEfectivoTarjeta = 0
        Try
            Dim xDT As New DataTable
            Dim totales As New OracleDataAdapter

            totales = New OracleDataAdapter("SELECT SUM(cantidad_pago) As Total FROM Pago", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                totalEfectivoTarjeta = registro("Total")
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub TotalEnEfectivo()
        totalEfectivo = 0
        Try
            Dim xDT As New DataTable
            Dim totales As New OracleDataAdapter

            totales = New OracleDataAdapter("SELECT SUM(cantidad_pago) As Total 
                                            FROM Pago p, Metodo_pago mp
                                            WHERE p.id_metodo_pago = mp.id_metodo_pago
                                            AND mp.nombre_met_pago = 'Efectivo'", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                totalEfectivo = registro("Total")
            Next

            If xDT.Rows.Count = 0 Then
                totalEfectivo = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub TotalEnTarjeta()
        totalTarjeta = 0
        Try
            Dim xDT As New DataTable
            Dim totales As New OracleDataAdapter

            totales = New OracleDataAdapter("SELECT SUM(cantidad_pago) As Total 
                                         FROM Pago p, Metodo_pago mp
                                       WHERE p.id_metodo_pago = mp.id_metodo_pago
                                            AND mp.nombre_met_pago = 'Tarjeta'", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                totalTarjeta = registro("Total")
            Next

            If xDT.Rows.Count = 0 Then
                totalTarjeta = 0
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub TotalEfectivoYTarjetaFecha()
        totalEfectivoTarjetaFecha = 0
        Try
            Dim xDT As New DataTable
            Dim totales As New OracleDataAdapter

            totales = New OracleDataAdapter("SELECT SUM(cantidad_pago) As Total 
                                            FROM Pago  
                                            WHERE fecha_hora_pago >= '" & DateTimeFechaInicial.Text & "'
                                            AND fecha_hora_pago <= '" & DateTimeFechaFinal.Text & "'", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                totalEfectivoTarjetaFecha = registro("Total")
            Next

            If xDT.Rows.Count = 0 Then
                totalEfectivoTarjetaFecha = 0
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub ImprimirReporteIngreso()
        Try
            'Mandar a generar el docuemnto
            Dim documento As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el documento en la direccion de reportes 
            Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de Ingresos.pdf"
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
        ImprimirReporteIngreso()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub FrmListadoCobros_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "Turno" Then
            FrmTurno.Activate()
            FrmTurno.Show()
        ElseIf abiertoDesde = "EgresoTurno" Then
            FrmEgreso.Activate()
            FrmEgreso.Show()
        ElseIf abiertoDesde = "MenuAdmin" Then
            FrmMenuAdministracion.Activate()
            FrmMenuAdministracion.Show()
        End If
        abiertoDesde = ""
    End Sub

    Private Sub DGVIngresos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVIngresos.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
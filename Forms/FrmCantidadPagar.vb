Imports Oracle.DataAccess.Client
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class FrmCantidadPagar
    Public idMetodoPago As Integer
    Public idPago As Integer
    Public cambio As Double
    Public pagoCompleto As Boolean = False

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Private Sub FrmCantidadPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PoblarComboBoxMetPago()
        IdSeleccionadoEnCB()
    End Sub

    'Método para poblar el ComboBox de metodo de pago
    Public Sub PoblarComboBoxMetPago()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter

        strSql = "SELECT nombre_met_pago FROM Metodo_pago ORDER BY nombre_met_pago"
        conector = New OracleDataAdapter(strSql, cnx)

        conector.Fill(xDT)
        With CBMetodoPago
            .DataSource = xDT
            .DisplayMember = "id_metodo_pago"
            .ValueMember = "nombre_met_pago"
        End With
    End Sub

    'Método para saber que ID le pertenece 
    Public Sub IdSeleccionadoEnCB()
        Dim xDT As New DataTable
        Dim conector = New OracleDataAdapter
        Try
            strSql = "SELECT id_metodo_pago FROM Metodo_pago WHERE nombre_met_pago = '" & CBMetodoPago.SelectedValue.ToString & "'"
            conector = New OracleDataAdapter(strSql, cnx)
            conector.Fill(xDT)

            For Each registro As DataRow In xDT.Rows
                idMetodoPago = registro("id_metodo_pago").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CBMetodoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMetodoPago.SelectedIndexChanged
        IdSeleccionadoEnCB()
        If idMetodoPago = 2 Then
            Btn1000.Enabled = False
            Btn500.Enabled = False
            Btn200.Enabled = False
            Btn100.Enabled = False
            TxtCantidadRecibida.Enabled = False
        Else
            Btn1000.Enabled = True
            Btn500.Enabled = True
            Btn200.Enabled = True
            Btn100.Enabled = True
            TxtCantidadRecibida.Enabled = True
        End If
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        FrmMetodoPago.Close()
        FrmPago.Activate()
        FrmPago.Show()

    End Sub

    Private Sub TxtCantidadRecibida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidadRecibida.KeyPress
        SoloNumeroYDecimal(TxtCantidadRecibida, e)
    End Sub

    Private Function ComprobarDatos() As Boolean
        ComprobarDatos = False
        If idMetodoPago = 0 Or CBMetodoPago.Text = "" Or FrmPago.idFolio = 0 Or TxtCantidadRecibida.Text = "" Then
            FrmAviso.LbMensaje.Text = "FALTAN DATOS, COMPRUEBA LOS CAMPOS CORRESPONDIENTES"
            FrmAviso.Show()
        Else
            If TxtCantidadRecibida.Text = "." Then
                TxtCantidadRecibida.Text = ""
                FrmAviso.LbMensaje.Text = "INGRESA UNA CANTIDAD VÁLIDA"
                FrmAviso.Show()
                ComprobarDatos = False
            Else
                ComprobarDatos = True
            End If

        End If
    End Function

    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        FrmCargando.MostarConTiempoEnCargar(500)
        'Dim cantidadRecibida As Double
        'Dim cantidadRestante As Double
        'cantidadRecibida = Val(TxtCantidadRecibida.Text)
        'cantidadRestante = Val(FrmPago.TxtCantidadRestante.Text)
        Try
            If ComprobarDatos() Then

                If cancelada = "No" Then
                    If Val(TxtCantidadRecibida.Text) > FrmPago.cantidadRestante Then
                        cambio = Val(TxtCantidadRecibida.Text) - Val(FrmPago.cantidadRestante)
                        InsertaPago(FrmPago.cantidadRestante)
                        If pagoCompleto = False Then
                            FrmCambio.LabelMensaje.Text = "$" & cambio
                            FrmCambio.Show()
                        End If

                        'MsgBox("ENTREGA AL CLIENTE SU CAMBIO DE: $" & cambio)
                    ElseIf Val(FrmPago.cantidadRestante) >= Val(TxtCantidadRecibida.Text) Then
                        InsertaPago(Val(TxtCantidadRecibida.Text))
                    End If

                    ImprimirTicket()
                ElseIf cancelada = "Si" Then
                    InsertaPago(Val(TxtCantidadRecibida.Text))
                    ImprimirTicket()
                End If

            End If
            Me.Close()
            pagoCompleto = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Método que inserta un pago
    Public Sub InsertaPago(ByVal nCantidad As Double)
        Try
            strSql = "BEGIN pago_Insertar (" & FrmPago.idFolio & ", " & idMetodoPago & ", " & nCantidad & ", SYSDATE); END;"
            xCnx.objetoCommand(strSql)
            FrmPago.CargarTodaInformacion()

            'Metodo para actualizar dinero en caja
            Dim turno As New Turno()
            turno.MostrarCantidadActualCaja()
            strSql = "UPDATE Turno SET cantidad_actual_turno = " & ModuloGlobal.cantidadActualEnCaja + nCantidad & " WHERE id_turno = " & idTurnoActual
            xCnx.objetoCommand(strSql)
            FrmTurno.turno.MostrarCantidadActualCaja()
            FrmTurno.turno.MostrarCantidadAperturaCaja()
            FrmTurno.turno.MostrarCantidadRetiroCaja()
            FrmAdministracionFolio.EstadoCuenta()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnAgregarMetPago_Click(sender As Object, e As EventArgs) Handles BtnAgregarMetPago.Click
        FrmMetodoPago.Show()
    End Sub

    Private Sub FrmCantidadPagar_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnPagar.PerformClick()
        End If
    End Sub

    Private Sub Btn1000_Click(sender As Object, e As EventArgs) Handles Btn1000.Click
        TxtCantidadRecibida.Text = "1000"
        'Limpiamos caja de texto
        Call BtnPagar_Click(sender, e)
    End Sub

    Private Sub Btn500_Click(sender As Object, e As EventArgs) Handles Btn500.Click
        TxtCantidadRecibida.Text = "500"
        'Limpiamos caja de texto
        Call BtnPagar_Click(sender, e)
    End Sub

    Private Sub Btn200_Click(sender As Object, e As EventArgs) Handles Btn200.Click
        TxtCantidadRecibida.Text = "200"
        'Limpiamos caja de texto
        Call BtnPagar_Click(sender, e)
    End Sub

    Private Sub Btn100_Click(sender As Object, e As EventArgs) Handles Btn100.Click
        TxtCantidadRecibida.Text = "100"
        'Limpiamos caja de texto
        Call BtnPagar_Click(sender, e)
    End Sub

    Private Sub BtnPagoCompleto_Click(sender As Object, e As EventArgs) Handles BtnPagoCompleto.Click
        pagoCompleto = True
        TxtCantidadRecibida.Text = FrmPago.cantidadRestante
        'Limpiamos caja de texto
        Call BtnPagar_Click(sender, e)
    End Sub

    'Impresion de ticket
    Public Sub ImprimirTicket()
        Try
            ComprobarEstadoIncial()
            'Mandar a generar el docuemnto
            Dim documento As New Document(PageSize.A6, 10, 10, 10, 10)
            'Path que guarda el documento en la direccion de TICKETS 
            Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Ticket.pdf"
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

    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim datoEncabezado As String = "TICKET" + vbCr + "HOTEL POSADA FAVELA"
        Dim datoTicket As String = "---------------------------------------------------------" + vbCr +
                                    "Fecha: " & FrmAdministracionFolio.LbFecha.Text & " " & FrmAdministracionFolio.LbHora.Text & vbCr + "Atendido por: " + nombreCompletoUser + vbCr
        Dim datoPago As String = ""
        If cancelada = "No" Then
            datoPago += "---------------------------------------------------------" + vbCr +
                                   "DATOS DE PAGO" + vbCr +
                                   "---------------------------------------------------------" + vbCr +
                                   " Precio total de las habitación/es: $" & FrmPago.TxtCantidadTotalHabitaciones.Text & vbCr +
                                   " Precio total de cargo/s extra: $" & FrmPago.TxtCantidadTotalCargoExtra.Text & vbCr +
                                   " Cantidad de cargo total: $" & FrmPago.TxtCantidadCargoTotal.Text & vbCr +
                                   "---------------------------------------------------------" + vbCr +
                                   " Cantidad pagada en este momento: $" & Format(Val(TxtCantidadRecibida.Text), "####,###0.00") & vbCr +
                                   " Cambio: $" & Format(cambio, "####,###0.00") & vbCr +
                                   "---------------------------------------------------------" + vbCr +
                                   " Cantidad pagada acumulada: $" & FrmPago.TxtCantidadPagadaXCliente.Text & vbCr +
                                   " Cantidad restante: $" & FrmPago.TxtCantidadRestante.Text & vbCr +
                                   "---------------------------------------------------------" + vbCr +
                                   "¡GRACIAS POR TU PREFERENCIA!" + vbCr +
                                   "---------------------------------------------------------" + vbCr + vbCr + vbCr
        ElseIf cancelada = "Si" Then
            datoPago += "---------------------------------------------------------" + vbCr +
                                   "DATOS DE PAGO" + vbCr +
                                   "---------------------------------------------------------" + vbCr +
                                   " Precio total de las habitación/es: $" & FrmPago.TxtCantidadTotalHabitaciones.Text & vbCr +
                                   " Precio total de cargo/s extra: $" & FrmPago.TxtCantidadTotalCargoExtra.Text & vbCr +
                                   " Cantidad de cargo total: $" & FrmPago.TxtCantidadCargoTotal.Text & vbCr +
                                   "---------------------------------------------------------" + vbCr +
                                   " Cantidad pagada en este momento POR CANCELACIÓN: $" & Format(Val(TxtCantidadRecibida.Text), "####,###0.00") & vbCr +
                                   " Cambio: $" & Format(cambio, "####,###0.00") & vbCr +
                                   "---------------------------------------------------------" + vbCr +
                                   " Cantidad pagada acumulada POR CANCELACIÓN: $" & FrmPago.TxtCantidadPagadaXCliente.Text & vbCr +
                                   "---------------------------------------------------------" + vbCr +
                                   "¡GRACIAS POR TU PREFERENCIA!" + vbCr +
                                   "---------------------------------------------------------" + vbCr + vbCr + vbCr
        End If

        Try
            'Encabezado del PDF
            Dim encabezado As New Paragraph(datoEncabezado, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            encabezado.Alignment = Element.ALIGN_CENTER
            'Se creael texto debajo del encabezado
            Dim informacion As New Phrase(datoTicket, New Font(Font.Name = "Tahoma", 8, Font.Bold))
            'dato cobrado
            Dim pago As New Phrase(datoPago, New Font(Font.Name = "Tahoma", 8, Font.Bold))
            'Obtener imagen para agregar al documento PDF
            Dim image As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance("C:\IDEA Software\imgLogo\logo.png")
            'image1.ScalePercent(50.0F)
            image.ScaleAbsoluteWidth(50)
            image.ScaleAbsoluteHeight(50)
            image.Alignment = Image.ALIGN_CENTER

            'Datos de contacto 
            Dim datoDeContacto = New Paragraph("Hotel Posada Favela" + vbCr + "Calle Melchor Ocampo #43, Zona Centro C. P. 27980" + vbCr + "Parras de la Fuente, Coahuila, México." + vbCr + "842 422 3566" + vbCr + "posadafavela@gmail.com", New Font(Font.Name = "Tahoma", 8, Font.Bold))
            datoDeContacto.Alignment = Element.ALIGN_CENTER

            'Se agrega el PDFTable todos los datos generados
            document.Add(encabezado)
            document.Add(informacion)
            document.Add(pago)
            document.Add(image)
            document.Add(datoDeContacto)
        Catch ex As Exception
            '  MsgBox("Error al generar PDF: " & ex.Message)
        End Try
    End Sub

    Private Sub FrmCantidadPagar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "Pago" Then
            FrmMetodoPago.Close()
            FrmPago.Activate()
            FrmPago.Show()
        End If
        abiertoDesde = ""
    End Sub
End Class
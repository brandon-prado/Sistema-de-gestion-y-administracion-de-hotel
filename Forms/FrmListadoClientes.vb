Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Oracle.DataAccess.Client

Public Class FrmListadoClientes
    'Instanciar el objeto
    Public clientes As New ListadoClientes
    Public totalClientes As Integer
    Public clientesActivos As Integer
    Public clientesDesactivados As Integer
    Public clientesCheckOut As Integer
    Public clientesCheckOutRango As Integer
    Private modoImpresion As String = "Todo"
    'Public DGVListadoClientes As DataGridViewCellEventArgs

    Private Sub FrmListadoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        RbMostrarTodosClientes.Checked = True
        clientes.ConsultaTodosClientes(DGVListadoClientes)

        'Ocultar columna de ID de cliente y género
        'DGVListadoClientes.Columns(0).Visible = False
        'DGVListadoClientes.Columns(1).Visible = False

        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub FechaHora_Tick(sender As Object, e As EventArgs) Handles FechaHora.Tick
        LbHora.Text = DateTime.Now.ToString("hh:mm:ss")
        LbFecha.Text = DateTime.Now.ToLongDateString()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnPantallaInicio_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        If ModuloGlobal.BuscarFormularioActivo("FrmMenuPrincipal") Then
            FrmCargando.MostarConTiempoEnCargar(700)
            FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
        Else
            FrmCargando.MostarConTiempoEnCargar(700)
            FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
        End If
        FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Show()
    End Sub

    Private Sub RbMostrarTodosClientes_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarTodosClientes.CheckedChanged
        modoImpresion = "Todo"
        FrmCargando.MostarConTiempoEnCargar(700)
        clientes.ConsultaTodosClientes(DGVListadoClientes)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub RbMostrarClientesActivos_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarClientesActivos.CheckedChanged
        modoImpresion = "Activos"
        FrmCargando.MostarConTiempoEnCargar(700)
        clientes.ConsultaClientesActivos(DGVListadoClientes)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub RbMostrarClientesCheckOut_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarClientesCheckOut.CheckedChanged
        modoImpresion = "CheckOut"
        FrmCargando.MostarConTiempoEnCargar(700)
        clientes.ConsultaClientesConCheckOut(DGVListadoClientes)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub RbMostrarClientesDesactivados_CheckedChanged(sender As Object, e As EventArgs) Handles RbMostrarClientesDesactivados.CheckedChanged
        modoImpresion = "Desactivado"
        FrmCargando.MostarConTiempoEnCargar(700)
        clientes.ConsultaClientesDesactivados(DGVListadoClientes)
        'Ocultar boton de modificar si no se ha seleccionado ningun registro
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub BtnBuscarClientes_Click(sender As Object, e As EventArgs) Handles BtnBuscarClientes.Click
        modoImpresion = "RangoFecha"
        RbMostrarClientesCheckOut.Checked = True
        If DateTimeFechaInicial.Text = "" And DateTimeFechaFinal.Text = "" Then
            FrmAviso.LbMensaje.Text = "Faltan datos, comprueba los campos correspondientes"
            FrmAviso.Show()
        Else
            clientes.ConsultaClientesConCheckOutFecha(DGVListadoClientes, DateTimeFechaInicial.Text, DateTimeFechaFinal.Text)
        End If
    End Sub

    Private Sub BtnModificarUsuario_Click(sender As Object, e As EventArgs) Handles BtnModificarUsuario.Click
        abiertoDesde = "ListadoClientes"
        'If ModuloGlobal.BuscarFormularioActivo("FrmAdministracionClientes") Then
        'FrmCargando.MostarConTiempoEnCargar(500)
        'FrmAdministracionClientes.Show()

        ' Else
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmAdministracionClientes.Show()
        'End If
        'Una vez precionado, otra vez bloquear
        BtnModificarUsuario.Visible = False
        Me.Hide()
    End Sub

    Private Sub BtnNuevoUsuario_Click(sender As Object, e As EventArgs) Handles BtnNuevoUsuario.Click
        abiertoDesde = "ListadoClientes"
        FrmAdministracionClientes.cliente.PoblarComboBoxGenero()
        'If ModuloGlobal.BuscarFormularioActivo("FrmRegistroCliente") Then
        FrmCargando.MostarConTiempoEnCargar(500)
            FrmRegistroCliente.Show()

        'Else
        'FrmCargando.MostarConTiempoEnCargar(900)
        'FrmRegistroCliente.Show()
        'End If
        'Bloquear boton de modificar
        BtnModificarUsuario.Visible = False
    End Sub

    Private Sub DGVListadoClientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVListadoClientes.CellContentClick
        Dim renglon As Integer
        renglon = DGVListadoClientes.CurrentCellAddress.Y
        FrmAdministracionClientes.cliente.PoblarComboBoxGenero()
        Try
            FrmAdministracionClientes.idCliente = DGVListadoClientes.Rows(renglon).Cells(0).Value
            FrmAdministracionClientes.idGenero = DGVListadoClientes.Rows(renglon).Cells(1).Value
            FrmAdministracionClientes.TxtNombreCliente.Text = DGVListadoClientes.Rows(renglon).Cells(2).Value
            FrmAdministracionClientes.TxtPaternoCliente.Text = DGVListadoClientes.Rows(renglon).Cells(3).Value
            FrmAdministracionClientes.TxtMaternoCliente.Text = DGVListadoClientes.Rows(renglon).Cells(4).Value
            FrmAdministracionClientes.CBGenero.Text = DGVListadoClientes.Rows(renglon).Cells(5).Value
            FrmAdministracionClientes.TxtTelefonoCliente.Text = DGVListadoClientes.Rows(renglon).Cells(6).Value
            FrmAdministracionClientes.TxtIdentificacionCliente.Text = DGVListadoClientes.Rows(renglon).Cells(7).Value
            FrmAdministracionClientes.CBEstado.Text = DGVListadoClientes.Rows(renglon).Cells(8).Value
            If IsDBNull(DGVListadoClientes.Rows(renglon).Cells(9).Value) Then
                FrmAdministracionClientes.TxtNotaCliente.Text = ""
            Else
                FrmAdministracionClientes.TxtNotaCliente.Text = DGVListadoClientes.Rows(renglon).Cells(9).Value
            End If
            'Una vez seleccionado el registro, activar el botón de Modificar o eliminar
            BtnModificarUsuario.Visible = True
        Catch ex As Exception
            ' MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub

    'Método que recarga los DGV de listado clientes, esto al hacer una modificacion en Administracion de Clientes
    Public Sub ActualizarDGV()
        If RbMostrarTodosClientes.Checked = True Then
            clientes.ConsultaTodosClientes(DGVListadoClientes)
        ElseIf RbMostrarClientesActivos.Checked = True Then
            clientes.ConsultaClientesActivos(DGVListadoClientes)
        ElseIf RbMostrarClientesCheckOut.Checked = True Then
            clientes.ConsultaClientesConCheckOut(DGVListadoClientes)
        ElseIf RbMostrarClientesDesactivados.Checked = True Then
            clientes.ConsultaClientesDesactivados(DGVListadoClientes)
        End If
    End Sub

    'Busqueda en tiempo real
    Private Sub TxtDatoBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtDatoBuscar.TextChanged
        Dim strSql As String
        Dim xCnx As New Oracle
        Dim datoB As String

        RbMostrarTodosClientes.Checked = True

        'El dato ingresado es convertido en minúscula
        datoB = LCase(TxtDatoBuscar.Text)

        If CBBuscarPor.Text = "Nombre" Then
            strSql = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"",
                    c.nombre_cliente AS ""NOMBRE"", c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA""
                 FROM Cliente c, Genero g
                 WHERE c.id_genero = g.id_genero
                 AND lower(c.nombre_cliente) LIKE '%" & datoB & "%'"
            DGVListadoClientes.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoClientes.Refresh()

        ElseIf CBBuscarPor.Text = "Apellido paterno" Then
            strSql = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"",
                    c.nombre_cliente AS ""NOMBRE"", c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA""
                 FROM Cliente c, Genero g
                 WHERE c.id_genero = g.id_genero
                 AND lower(c.paterno_cliente) LIKE '%" & datoB & "%'"
            DGVListadoClientes.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoClientes.Refresh()

        ElseIf CBBuscarPor.Text = "Apellido materno" Then
            strSql = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"",
                    c.nombre_cliente AS ""NOMBRE"", c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA""
                 FROM Cliente c, Genero g
                 WHERE c.id_genero = g.id_genero
                 AND lower(c.materno_cliente) LIKE '%" & datoB & "%'"
            DGVListadoClientes.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoClientes.Refresh()

        ElseIf CBBuscarPor.Text = "Identificación" Then
            strSql = "SELECT c.id_cliente AS ""ID CLIENTE"", g.id_genero AS ""ID GÉNERO"",
                    c.nombre_cliente AS ""NOMBRE"", c.paterno_cliente AS ""APELLIDO PATERNO"", c.materno_cliente AS ""APELLIDO MATERNO"", 
                    g.nombre_genero AS ""GÉNERO"", c.telefono_cliente AS ""TELÉFONO"", c.identificacion_cliente AS ""IDENTIFICACIÓN"",
                    c.estado_cliente AS ""ESTADO"", c.nota_cliente AS ""NOTA""
                 FROM Cliente c, Genero g
                 WHERE c.id_genero = g.id_genero
                 AND lower(c.identificacion_cliente) LIKE '%" & datoB & "%'"
            DGVListadoClientes.DataSource = xCnx.objetoDataAdapter(strSql)
            DGVListadoClientes.Refresh()
        End If
    End Sub

    Private Sub BtnLimpiarBusqueda_Click(sender As Object, e As EventArgs) Handles BtnLimpiarBusqueda.Click
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub CBBuscarPor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBBuscarPor.SelectedIndexChanged
        TxtDatoBuscar.Text = ""
    End Sub

    Private Sub DateTimeFechaInicial_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeFechaInicial.ValueChanged

    End Sub

    Private Sub DateTimeFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles DateTimeFechaFinal.ValueChanged

    End Sub

    Private Sub BtnPantallaHabitaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        'If ModuloGlobal.BuscarFormularioActivo("FrmAdministrarHabitacion") Then
        FrmCargando.MostarConTiempoEnCargar(700)
            FrmListadoHabitaciones.Activate()
            FrmListadoHabitaciones.Show()
        'Else
        ' FrmCargando.MostarConTiempoEnCargar(700)
        '  FrmListadoHabitaciones.Show()
        ' FrmListadoHabitaciones.Activate()
        ' End If
        FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnPantallaReservaciones_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoReservaciones.Activate()
        FrmListadoReservaciones.Show()
        FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub BtnPantallaUsuarios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        If ModuloGlobal.nombreRol = "Administrador" Or ModuloGlobal.nombreRol = "Encargado" Or ModuloGlobal.modoSuperUsuario = True Then
            FrmListadoUsuarios.Activate()
            FrmListadoUsuarios.Show()
            FrmAdministracionClientes.Close()
            Me.Close()
        Else
            FrmAutorizacion.Formulario(FrmListadoUsuarios, Nothing, Me)
            FrmAutorizacion.Activate()
            FrmAutorizacion.Show()
        End If

    End Sub

    Private Sub BtnPantallaFolios_Click(sender As Object, e As EventArgs)
        abiertoDesde = ""
        FrmCargando.MostarConTiempoEnCargar(700)
        FrmListadoFolio.Activate()
        FrmListadoFolio.Show()
        FrmAdministracionClientes.Close()
        Me.Close()
    End Sub

    Private Sub TxtDatoBuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDatoBuscar.KeyPress
        If CBBuscarPor.Text = "Nombre" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Apellido paterno" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Apellido materno" Then
            SoloLetrasSinApostrofe(e)
        ElseIf CBBuscarPor.Text = "Identificación" Then
            SoloNumero(e)
        End If
    End Sub

    'Funcion para obtener el tamaño de las columnas del DGV
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            If i = 0 Or i = 1 Then
            Else
                values(i) = CSng(dg.Columns(i).Width)
            End If
        Next
        Return values
    End Function

    Public Sub ExportarDatosPDF(ByVal document As Document, ByVal filtro As String)
        Try
            'Se crea documento PDFTable con el numero de columnas del DGV
            Dim dataTable As New PdfPTable(DGVListadoClientes.ColumnCount)
            'Propiedades del documento
            dataTable.DefaultCell.Padding = 3
            Dim headerWidth As Single() = GetColumnasSize(DGVListadoClientes)
            dataTable.SetWidths(headerWidth)
            dataTable.WidthPercentage = 100
            dataTable.DefaultCell.BorderWidth = 2
            dataTable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER

            Dim encabezado As New Paragraph
            Dim texto As New Phrase
            Dim estadistico As New Phrase

            TotalesClientes()

            If filtro = "Todo" Or modoImpresion = "Todos" Then
                'Encabezado del PDF
                encabezado = New Paragraph("REPORTE DE TODOS LOS CLIENTES", New Font(Font.Name = "Tahoma", 20, Font.Bold))
                'Se creael texto debajo del encabezado
                texto = New Phrase("Reporte de todos los clientes generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
                'Se crea el dato estadistico
                estadistico = New Phrase("Cantidad total de clientes registrados: " & totalClientes & vbCr & "Cantidad total de clientes activos: " & clientesActivos & vbCr & "Cantidad total de clientes con Check Out: " & clientesCheckOut & vbCr & "Cantidad total de clientes desactivados: " & clientesDesactivados & vbCr & vbCr & vbCr, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            ElseIf filtro = "Activos" Or modoImpresion = "Activos" Then
                'Encabezado del PDF
                encabezado = New Paragraph("REPORTE DE CLIENTES ACTIVOS", New Font(Font.Name = "Tahoma", 20, Font.Bold))
                'Se creael texto debajo del encabezado
                texto = New Phrase("Reporte de clientes activos generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
                'Se crea el dato estadistico
                estadistico = New Phrase("Cantidad total de clientes activos: " & clientesActivos & vbCr & vbCr & vbCr, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            ElseIf filtro = "CheckOut" Or modoImpresion = "CheckOut" Then
                filtro = "CheckOut"
                'Encabezado del PDF
                encabezado = New Paragraph("REPORTE DE CLIENTES CON CHECK OUT", New Font(Font.Name = "Tahoma", 20, Font.Bold))
                'Se creael texto debajo del encabezado
                texto = New Phrase("Reporte de cliente con check out generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
                'Se crea el dato estadistico
                estadistico = New Phrase("")
                'estadistico = New Phrase("Cantidad total de clientes con Check Out: " & clientesCheckOut & vbCr & vbCr & vbCr, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            ElseIf filtro = "Desactivado" Or modoImpresion = "Desactivado" Then
                'Encabezado del PDF
                encabezado = New Paragraph("REPORTE DE CLIENTES DESACTIVADOS", New Font(Font.Name = "Tahoma", 20, Font.Bold))
                'Se creael texto debajo del encabezado
                texto = New Phrase("Reporte de clientes desactivados generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
                'Se crea el dato estadistico
                estadistico = New Phrase("Cantidad total de clientes desactivados: " & clientesDesactivados & vbCr & vbCr & vbCr, New Font(Font.Name = "Tahoma", 14, Font.Bold))
            ElseIf modoImpresion = "RangoFecha" Then
                filtro = "CheckOut"
                Dim rangoFecha As String = DateTimeFechaInicial.Text + " a " + DateTimeFechaFinal.Text
                'Encabezado del PDF
                encabezado = New Paragraph("REPORTE DE CLIENTES - CHECK OUT CON RANGO DE FECHA DE (" & rangoFecha & ")", New Font(Font.Name = "Tahoma", 16, Font.Bold))
                'Se creael texto debajo del encabezado
                texto = New Phrase("Reporte de clientes con Check Out generado por: " + nombreCompletoUser + " a fecha de: " + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
                'Se crea el dato estadistico
                estadistico = New Phrase("")
            End If

            'Se captura los nombres de las columnas del DGV
            dataTable.AddCell("")
            dataTable.AddCell("")
            dataTable.AddCell("NOMBRE")
            dataTable.AddCell("PATERNO")
            dataTable.AddCell("MATERNO")
            dataTable.AddCell("GÉNERO")
            dataTable.AddCell("TELÉFONO")
            dataTable.AddCell("IDENTIF.")
            dataTable.AddCell("ESTADO")
            dataTable.AddCell("NOTA")
            If filtro = "CheckOut" Then
                dataTable.AddCell("CHECK IN")
                dataTable.AddCell("CHECK OUT")
            End If
            'Se obtiene el valor de cada celda de la tabla
            For i As Integer = 0 To DGVListadoClientes.RowCount - 1
                For j As Integer = 0 To DGVListadoClientes.ColumnCount - 1
                    'If i = 0 Or i = 1 Then
                    ' Else
                    If IsDBNull(DGVListadoClientes.Rows(i).Cells(j).Value) Then
                            dataTable.AddCell("Sin dato")
                        Else
                            If CStr(DGVListadoClientes(j, i).Value) = "" Then
                            Else
                                dataTable.AddCell(DGVListadoClientes(j, i).Value.ToString())
                            End If
                        End If
                    ' End If

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
            document.Add(estadistico)
            document.Add(image)
            document.Add(datoDeContacto)

        Catch ex As Exception
            '  MsgBox("Error al generar PDF: " & ex.Message)
        End Try
    End Sub

    Public Sub ImprimirReporteReservaciones(ByVal filtro As String)
        Try
            'Mandar a generar el docuemnto
            Dim documento As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el documento en la direccion de reportes 
            Dim fileName As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte de Clientes.pdf"
            Dim file As New FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(documento, file)
            documento.Open()
            ExportarDatosPDF(documento, filtro)
            documento.Close()
            Process.Start(fileName)
        Catch ex As Exception
            MsgBox("Error al generar PDF: " & ex.Message)
        End Try
    End Sub


    Public Sub TotalesClientes()
        Try
            Dim xDT As New DataTable
            Dim totales As New OracleDataAdapter

            totales = New OracleDataAdapter("SELECT COUNT(id_cliente) As Total FROM Cliente", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                totalClientes = registro("Total")
            Next

            totales = New OracleDataAdapter("SELECT COUNT(id_cliente) As Total FROM Cliente WHERE estado_cliente = 'Activo'", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                clientesActivos = registro("Total")
            Next

            totales = New OracleDataAdapter("SELECT COUNT(id_cliente) As Total FROM Cliente WHERE estado_cliente = 'Desactivado'", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                clientesDesactivados = registro("Total")
            Next

            totales = New OracleDataAdapter("SELECT COUNT(id_cliente) As Total FROM Cliente WHERE estado_cliente = 'Check Out'", cnx)
            totales.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                clientesCheckOut = registro("Total")
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        FrmCargando.MostarConTiempoEnCargar(700)
        ComprobarEstadoIncial()
        ImprimirReporteReservaciones(modoImpresion)
    End Sub

    Private Sub BtnCerrarSesion_Click_1(sender As Object, e As EventArgs)
        FrmCerrarSesion.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión " & nombreUsuario & "?"
        FrmCerrarSesion.Activate()
        FrmCerrarSesion.Show()
    End Sub

    Private Sub CerrarVentanasCascada()
        FrmRegistroCliente.Close()
        FrmAdministracionClientes.Close()
        FrmGenero.Close()
    End Sub

    Private Sub FrmListadoClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
End Class
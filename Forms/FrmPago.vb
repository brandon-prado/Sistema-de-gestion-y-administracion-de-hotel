Imports Oracle.DataAccess.Client

Public Class FrmPago
    Public idFolio As Integer
    Public idReservacion As Integer
    Public precioTotalHabitaciones As Double
    Public precioTotalCargosExtra As Double
    Public precioTotalReservacion As Double
    Public cantidadPagada As Double
    Public cantidadRestante As Double

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        abiertoDesde = "Pago"
        FrmCargando.MostarConTiempoEnCargar(400)
        FrmCantidadPagar.Show()
        If cancelada = "Si" Then
            FrmCantidadPagar.Btn100.Enabled = False
            FrmCantidadPagar.Btn200.Enabled = False
            FrmCantidadPagar.Btn500.Enabled = False
            FrmCantidadPagar.Btn1000.Enabled = False
            FrmCantidadPagar.BtnPagoCompleto.Enabled = False
        ElseIf cancelada = "No" Then
            FrmCantidadPagar.Btn100.Enabled = True
            FrmCantidadPagar.Btn200.Enabled = True
            FrmCantidadPagar.Btn500.Enabled = True
            FrmCantidadPagar.Btn1000.Enabled = True
            FrmCantidadPagar.BtnPagoCompleto.Enabled = True
        End If
    End Sub

    Private Sub FrmPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTodaInformacion()
    End Sub

    Public Sub CargarTodaInformacion()
        CantidadTotalHabitaciones()
        CantidadTotalCargosExtra()
        CantidadTotalPagada()
        AsignarCantidadALabel()
        PoblarDGVPagos()
    End Sub

    'Método que recaba la cantidad total de las habitaciones (dia * precio de habitacion)
    Public Sub CantidadTotalHabitaciones()
        Try
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT rh.id_reservacion, SUM(ROUND((rh.check_out_prog - rh.check_in_prog), 2) * h.precio_habitacion) As ""PRECIO TOTAL""	
                                                    FROM Reservacion_has_Habitacion rh, Habitacion h, Reservacion r
                                                    WHERE rh.numero_habitacion = h.numero_habitacion
                                                    AND rh.id_reservacion = r.id_reservacion
                                                    AND rh.id_reservacion = " & idReservacion & "
                                                    AND rh.estado_reservacion <> 'Cancelada'
                                                    GROUP BY rh.id_reservacion", cnx)

            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                precioTotalHabitaciones = registro("PRECIO TOTAL").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Método que recaba la cantidad total de cargos extra
    Public Sub CantidadTotalCargosExtra()
        Try
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT id_folio, SUM(precio_total) As ""CARGO TOTAL""	
                                                    FROM Cargo_extra
                                                    WHERE id_folio = " & idFolio & "
                                                    GROUP BY id_folio", cnx)

            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                precioTotalCargosExtra = registro("CARGO TOTAL").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Método que recaba la cantidad total de pagada por el cliente
    Public Sub CantidadTotalPagada()
        Try
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT id_folio, SUM(cantidad_pago) As ""CANTIDAD PAGADA""	
                                                    FROM Pago
                                                    WHERE id_folio = " & idFolio & "
                                                    GROUP BY id_folio", cnx)

            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                cantidadPagada = registro("CANTIDAD PAGADA").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Metodo que suma las dos cantidades totales de cargo extra y cargo de habitaciones y les da formato
    Public Sub AsignarCantidadALabel()
        TxtCantidadTotalHabitaciones.Text = Format(precioTotalHabitaciones, "####,###0.00")
        TxtCantidadTotalCargoExtra.Text = Format(precioTotalCargosExtra, "####,###0.00")
        precioTotalReservacion = precioTotalHabitaciones + precioTotalCargosExtra
        TxtCantidadCargoTotal.Text = Format(precioTotalReservacion, "####,###0.00")
        TxtCantidadPagadaXCliente.Text = Format(cantidadPagada, "####,###0.00")

        If cantidadPagada < precioTotalReservacion Then
            Dim diferencia As Double = precioTotalReservacion - cantidadPagada
            TxtCantidadRestante.Text = Format(diferencia, "####,###0.00")
            cantidadRestante = diferencia
            LabelCantidadRestante.Visible = True
            TxtCantidadRestante.Visible = True
        Else
            Dim diferencia As Double = precioTotalReservacion - cantidadPagada
            TxtCantidadRestante.Text = Format(diferencia, "####,###0.00")
            cantidadRestante = diferencia
            LabelCantidadRestante.Visible = False
            TxtCantidadRestante.Visible = False
            LabelDinero.Visible = False
        End If

        If cantidadPagada >= precioTotalReservacion Then
            BtnPagar.Enabled = False
        End If

        If cancelada = "Si" Then
            BtnPagar.Enabled = True
        End If

    End Sub

    'Método que muestra en el DGV todos los pagos realizados por el cliente
    Public Sub PoblarDGVPagos()
        strSql = "SELECT p.fecha_hora_pago AS ""FECHA/HORA DE PAGO"", p.id_folio AS ""NÚMERO DE FOLIO"", p.cantidad_pago AS ""CANTIDAD DE PAGO"", 
                    mp.nombre_met_pago AS ""MÉTODO DE PAGO"" FROM Pago p, Metodo_pago mp 
                    WHERE p.id_metodo_pago = mp.id_metodo_pago
                    AND p.id_folio = " & idFolio & "
                    ORDER BY p.fecha_hora_pago DESC"

        DGVPagos.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        'DGVListadoFolios.Columns(0).Visible = False
        ' DGVListadoReservaciones.Refresh()
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
        FrmCantidadPagar.Close()
        FrmMetodoPago.Close()
    End Sub

    Private Sub FrmPago_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnPagar.PerformClick()
        End If
    End Sub

    Private Sub TxtCantidadRestante_Click(sender As Object, e As EventArgs) Handles TxtCantidadRestante.Click

    End Sub

    Private Sub FrmPago_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If abiertoDesde = "AdminFolio" Then
            FrmAdministracionFolio.Activate()
            FrmAdministracionFolio.Show()
        End If
        FrmMetodoPago.Close()
        FrmCantidadPagar.Close()
        FrmCambio.Close()
        abiertoDesde = ""
        cancelada = "No"
    End Sub

    Private Sub DGVPagos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPagos.CellContentClick
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        MsgBox(cancelada)
    End Sub
End Class
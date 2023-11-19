Public Class FrmHabitacionesAsignadas
    Public numeroHabitacion As Integer
    Public idReservacion As Integer

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Close()
    End Sub

    Private Sub FrmHabitacionesAsignadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PBImagenHabitacion.Image = My.Resources.habitacion
    End Sub

    'Método que muestra en el DGV Habitaciones asignadas todas aquellas que lo son
    Public Sub PoblarDGVHabitacionesAsignadas()
        strSql = "SELECT rh.id_reservacion AS ""ID RESERVACIÓN"", rh.numero_habitacion AS ""NÚMERO DE HABITACIÓN"", th.nombre_tipo_hab AS ""TIPO HABITACIÓN"",
                    h.precio_habitacion AS ""PRECIO X NOCHE"", h.capacidad_habitacion AS ""CAPACIDAD"", h.descripcion_habitacion AS ""DESCRIPCIÓN"",
                    TO_DATE(rh.check_in_prog, 'DD/MM/YY HH24:MI') AS ""CHECK IN PROGRAMADO"", TO_DATE(rh.check_out_prog, 'DD/MM/YY HH24:MI') AS ""CHECK OUT PROGRAMADO"",
                    TO_DATE(rh.check_in_real, 'DD/MM/YY HH24:MI') AS ""CHECK IN REAL"", TO_DATE(rh.check_out_real, 'DD/MM/YY HH24:MI') AS ""CHECK OUT REAL"",
                    rh.estado_reservacion AS ""ESTADO""
                  FROM Habitacion h, Tipo_Habitacion th, Reservacion_has_Habitacion rh
                  WHERE h.id_tipo_hab = th.id_tipo_hab
                  AND rh.numero_habitacion = h.numero_habitacion
                  AND rh.id_reservacion = " & idReservacion & " ORDER BY h.numero_habitacion ASC"

        DGVHabitaciones.DataSource = xCnx.objetoDataAdapter(strSql)
        'OCULTAR COLUMNA DEL DGV ID
        'DGVHabitaciones.Columns(0).Visible = False
        DGVHabitaciones.Refresh()
    End Sub

    'Método que muestra la imagen de la habitación seleccionada 
    Private Sub ObtenerImagen()
        'Mostrar imagen de la habitacion
        Try
            Using stream As New System.IO.FileStream("C:\IDEA Software\imgHabitaciones\" & numeroHabitacion & ".png", IO.FileMode.Open)
                PBImagenHabitacion.Image = Image.FromStream(stream)
            End Using
        Catch ex As Exception
            'Si la habitacion no tiene ninguna imagen, se muestra la que esta por defecto
            PBImagenHabitacion.Image = My.Resources.habitacion
        End Try
    End Sub

    Private Sub DGVHabitaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHabitaciones.CellContentClick
        Dim renglon As Integer
        renglon = DGVHabitaciones.CurrentCellAddress.Y
        Try
            'Agregar el valor de numero de habitacion a su variable local 
            numeroHabitacion = DGVHabitaciones.Rows(renglon).Cells(1).Value

            'Se manda hablar el metodo que cargara la imagen de la habitacion correspondiente
            ObtenerImagen()

        Catch ex As Exception
            'MsgBox("ERROR: " & ex.Message)
        End Try
    End Sub
End Class
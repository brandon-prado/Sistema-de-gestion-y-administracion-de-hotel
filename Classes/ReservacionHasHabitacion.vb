Public Class ReservacionHasHabitacion
    Private idReservacion As Integer
    Private numeroHabitacion As Integer
    Private checkInProg As String
    Private checkOutprog As String
    Private checkInReal As String
    Private checkOutReal As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idReservacion = 0
        numeroHabitacion = 0
        checkInProg = ""
        checkOutprog = ""
        checkInReal = ""
        checkOutReal = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idReservacionD As Integer, ByVal numeroHabitacionD As Integer, ByVal checkInProgD As String, ByVal checkOutprogD As String)
        idReservacion = idReservacionD
        numeroHabitacion = numeroHabitacionD
        checkInProg = checkInProgD
        checkOutprog = checkOutprogD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdReservacion() As Integer
        Get
            Return idReservacion
        End Get
        Set(ByVal Value As Integer)
            idReservacion = Value
        End Set
    End Property

    Public Property GetSetNumeroHabitacion() As Integer
        Get
            Return numeroHabitacion
        End Get
        Set(ByVal Value As Integer)
            numeroHabitacion = Value
        End Set
    End Property

    Public Property GetSetCheckInProg() As String
        Get
            Return nombreRol
        End Get
        Set(ByVal Value As String)
            nombreRol = Value
        End Set
    End Property

    Public Property GetSetCheckOutProg() As String
        Get
            Return checkOutprog
        End Get
        Set(ByVal Value As String)
            checkOutprog = Value
        End Set
    End Property

    Public Property GetSetCheckInReal() As String
        Get
            Return checkInReal
        End Get
        Set(ByVal Value As String)
            checkInReal = Value
        End Set
    End Property

    Public Property GetSetCheckOutReal() As String
        Get
            Return checkOutReal
        End Get
        Set(ByVal Value As String)
            checkOutReal = Value
        End Set
    End Property

    'Funcion que consulta todos los registros de la tabla Reservacion_has_Habitacion
    Public Function ConsultaTodoReservHasHab() As Object
        ConsultaTodoReservHasHab = ""
        Try
            strSql = "SELECT * FROM Vista_Todo_Reserv_has_Hab"
            ConsultaTodoReservHasHab = xCnx.objetoDataAdapter(strSql)
        Catch ex As Exception

        End Try

    End Function

    'Método que inserta cundo la habitacion esta totalmente disponible
    Public Sub InsertaReservHasHab()
        Try
            'Inserta la habitacion con el folio respectivo
            'strSql = "BEGIN Reserv_has_Habit_Insertar (" & numeroHabitacion & ", " & idReservacion & ", TO_DATE('" & checkInProg & "' 14:00, DD/MM/YY HH24:MI), TO_DATE('" & checkOutprog & "' 13:59, DD/MM/YY HH24:MI), NULL, NULL); END;"
            strSql = "BEGIN Reserv_has_Habit_Insertar (" & numeroHabitacion & ", " & idReservacion & ", '" & checkInProg & "', '" & checkOutprog & "', NULL, NULL, 'Activa'); END;"
            xCnx.objetoCommand(strSql)
            'Pone la habitacion como ocupada
            strSql = "UPDATE Habitacion SET estado_habitacion = 'Ocupada' WHERE numero_habitacion = " & numeroHabitacion
            xCnx.objetoCommand(strSql)
            'Pone el cliente como activo
            strSql = "UPDATE Cliente SET estado_cliente = 'Activo' WHERE id_cliente = " & FrmSeleccionarCliente.idCliente
            xCnx.objetoCommand(strSql)
            'Pone la reservacion como activa
            strSql = "UPDATE Folio SET estado_folio = 'Activo' WHERE id_folio = " & idReservacion
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método que actualiza
    'Public Sub ActualizarReservHasHab()
    '    'strSql = "BEGIN Reserv_has_Habit_Actualizar (" & numeroHabitacion & ", " & idReservacion & ", TO_DATE('" & checkInProg & "', 'DD/MM/YYYY HH24:MI'), TO_DATE('" & checkOutprog & "', 'DD/MM/YYYY HH24:MI'), TO_DATE('" & checkInReal & "', 'DD/MM/YYYY HH24:MI'),  TO_DATE('" & checkOutReal & "', 'DD/MM/YYYY HH24:MI')); END;"
    '    'xCnx.objetoCommand(strSql)
    'End Sub

    'Función que consulta sí existe
    Public Function ConsultaUnaReservHasHab() As Boolean
        ConsultaUnaReservHasHab = False
        Try
            strSql = "SELECT id_reservacion, numero_habitacion 
                    FROM Reservacion_has_Habitacion 
                    WHERE id_reservacion = " & idReservacion & " AND numero_habitacion = " & numeroHabitacion


            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count >= 1 Then
                ConsultaUnaReservHasHab = True
            End If
        Catch ex As Exception

        End Try

    End Function

    Public Function ConsultaSiSigueOcupada() As Boolean
        ConsultaSiSigueOcupada = False
        Try
            strSql = "SELECT numero_habitacion 
                    FROM Reservacion_has_Habitacion 
                    WHERE numero_habitacion = " & numeroHabitacion & " AND check_out_real IS NULL"



            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count >= 1 Then
                ConsultaSiSigueOcupada = True
            End If
        Catch ex As Exception

        End Try

    End Function

    Public Function ConsultaSiSigueActivoFolio() As Boolean
        ConsultaSiSigueActivoFolio = False
        Try
            strSql = "SELECT id_reservacion 
                    FROM Reservacion_has_Habitacion 
                    WHERE id_reservacion = " & idReservacion & " AND check_out_real IS NULL"



            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count >= 1 Then
                ConsultaSiSigueActivoFolio = True
            End If
        Catch ex As Exception

        End Try

    End Function



    'Método que elimina una habitacion de una Reservacion has Habitacion
    Public Sub EliminarReservHasHab()
        Try
            strSql = "BEGIN Reserv_has_Habit_Eliminar (" & numeroHabitacion & ", " & idReservacion & "); END;"
            xCnx.objetoCommand(strSql)
            If ConsultaSiSigueOcupada() Then
                'Pone la habitacion como ocupada
                strSql = "UPDATE Habitacion SET estado_habitacion = 'Ocupada' WHERE numero_habitacion = " & numeroHabitacion
                xCnx.objetoCommand(strSql)
            Else
                'Pone la habitacion como disponible
                strSql = "UPDATE Habitacion SET estado_habitacion = 'Disponible' WHERE numero_habitacion = " & numeroHabitacion
                xCnx.objetoCommand(strSql)
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Checa si no tiene mas habitaciones, entonces se cancela la reservacion y el folio
    Public Function ConsultaSiTieneMasHabitaciones() As Boolean
        strSql = "SELECT id_reservacion 
                    FROM Reservacion_has_Habitacion 
                    WHERE id_reservacion = " & idReservacion & " AND estado_reservacion = 'Activa'"


        ConsultaSiTieneMasHabitaciones = False
        Try
            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count >= 1 Then
                ConsultaSiTieneMasHabitaciones = True
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Function

    'Método que cancela una habitacion
    Public Sub CancelarHabEnReservHasHab()
        Try
            strSql = "UPDATE Reservacion_has_Habitacion SET estado_reservacion = 'Cancelada' WHERE id_reservacion = " & idReservacion & " AND numero_habitacion = " & numeroHabitacion
            xCnx.objetoCommand(strSql)
            If ConsultaSiSigueOcupada() Then
                'Pone la habitacion como disponible
                strSql = "UPDATE Habitacion SET estado_habitacion = 'Ocupada' WHERE numero_habitacion = " & numeroHabitacion
                xCnx.objetoCommand(strSql)
            Else
                'Pone la habitacion como disponible
                strSql = "UPDATE Habitacion SET estado_habitacion = 'Disponible' WHERE numero_habitacion = " & numeroHabitacion
                xCnx.objetoCommand(strSql)
            End If

            'Actualiza estado de folio o lo cancela
            If ConsultaSiTieneMasHabitaciones() Then
                'Pone la reservacion como activa
                strSql = "UPDATE Folio SET estado_folio = 'Activo' WHERE id_folio = " & idReservacion
                xCnx.objetoCommand(strSql)
            Else
                'Pone la reservacion como cancelada
                strSql = "UPDATE Folio SET estado_folio = 'Cancelada' WHERE id_folio = " & idReservacion
                xCnx.objetoCommand(strSql)
            End If
        Catch ex As Exception

        End Try

    End Sub

    'Método que confirma check in real de una habitacion
    Public Sub ConfirmarCheckInReal()
        Try
            strSql = "UPDATE Reservacion_has_Habitacion SET check_in_real = SYSDATE WHERE id_reservacion = " & idReservacion & " AND numero_habitacion = " & numeroHabitacion
            xCnx.objetoCommand(strSql)
            MsgBox("Check IN Confirmado")
        Catch ex As Exception

        End Try

    End Sub

    'Método que actualiza la reservación con check out real
    Public Sub ConfirmaCheckOutReal()
        Try
            strSql = "UPDATE Reservacion_has_Habitacion Set check_out_real = SYSDATE, estado_reservacion = 'Check Out' WHERE id_reservacion = " & idReservacion & " AND numero_habitacion = " & numeroHabitacion
            xCnx.objetoCommand(strSql)
            If ConsultaSiSigueOcupada() Then
                'Pone la habitacion como disponible
                strSql = "UPDATE Habitacion SET estado_habitacion = 'Ocupada' WHERE numero_habitacion = " & numeroHabitacion
                xCnx.objetoCommand(strSql)
            Else
                'Pone la habitacion como disponible
                strSql = "UPDATE Habitacion SET estado_habitacion = 'Disponible' WHERE numero_habitacion = " & numeroHabitacion
                xCnx.objetoCommand(strSql)
            End If
            'Pone el folio como completado si ya tienes todas sus habitaciones con check out real
            If ConsultaSiSigueActivoFolio() Then
                'Pone el folio como activo
                strSql = "UPDATE Folio SET estado_folio = 'Activo' WHERE id_folio = " & idReservacion
                xCnx.objetoCommand(strSql)
            Else
                'Pone el folio como completado
                strSql = "UPDATE Folio SET estado_folio = 'Completado' WHERE id_folio = " & idReservacion
                xCnx.objetoCommand(strSql)
            End If
        Catch ex As Exception

        End Try

    End Sub
End Class

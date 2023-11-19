Imports Oracle.DataAccess.Client

Public Class InicioTurno
    Private cantidadInicialTurno As Double
    Private cantidadActualTurno As Double

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Public Sub New()
        cantidadInicialTurno = 0.0
        cantidadActualTurno = 0.0
    End Sub

    Public Sub New(ByVal cantidadInicialTurnoD As Double, ByVal cantidadActualTurnoD As Double)
        cantidadInicialTurno = cantidadInicialTurnoD
        cantidadActualTurno = cantidadActualTurnoD
    End Sub

    'Métodos GET y SET
    Public Property GetSetCantidadInicialTurno() As Double
        Get
            Return cantidadInicialTurno
        End Get
        Set(ByVal Value As Double)
            cantidadInicialTurno = Value
        End Set
    End Property

    Public Property GetSetCantidadActualTurno() As Double
        Get
            Return cantidadActualTurno
        End Get
        Set(ByVal Value As Double)
            cantidadActualTurno = Value
        End Set
    End Property

    'Metodo para insertar el turno
    Public Sub InsertaTurno()
        Try
            strSql = "INSERT INTO Turno (id_usuario, cantidad_inicial_turno, cantidad_actual_turno, fecha_hora_apertura)
                    VALUES (" & idUsuario & ", " & cantidadInicialTurno & ", " & cantidadActualTurno & ", SYSDATE)"
            xCnx.objetoCommand(strSql)
            'Obtiene el id del turno actual
            Dim xDT2 As New DataTable
            Dim conector As New OracleDataAdapter("SELECT MAX(id_turno) FROM Turno", cnx)
            conector.Fill(xDT2)
            For Each registro As DataRow In xDT2.Rows
                idTurnoActual = registro("MAX(id_turno)")
            Next
        Catch ex As Exception

        End Try

    End Sub


    'Metodo para actualizar la cantidad del turno, ir sumando lo que recibe del turno actual
    Public Sub CantidadTotalCargosExtra(ByVal nCantidad As Double)
        Dim cantidadActual As Double
        Dim cantidadNueva As Double
        Try
            'Obtiene la cantidad actual en caja
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT cantidad_actual_turno 
                                                    FROM Cargo_extra
                                                    WHERE id_turno = " & idTurnoActual, cnx)
            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                cantidadActual = registro("cantidad_actual_turno").ToString
            Next

            'Hace la suma de cantidad actual + la cantidad que recibe 
            cantidadNueva = cantidadActual + nCantidad

            'Actualiza la cantidad actual en el turno correspondiente
            strSql = "UPDATE Turno SET cantidad_actual_turno = " & cantidadNueva & " WHERE id_turno = " & idTurnoActual
            xCnx.objetoCommand(strSql)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Metodo que comprueba si no hay un turno pendiente y si lo hay, continuar con ese
    Public Function ValidaTurnoPendiente() As Boolean
        strSql = "SELECT MAX(id_turno), fecha_hora_cierre from turno WHERE fecha_hora_cierre IS NULL GROUP BY fecha_hora_cierre"
        ValidaTurnoPendiente = False
        Try
            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count = 1 Then
                ValidaTurnoPendiente = True
                'Obtiene el id del turno pendiente para continuar con el
                Dim xDT2 As New DataTable
                Dim conector As New OracleDataAdapter("SELECT MAX(id_turno) FROM Turno", cnx)
                conector.Fill(xDT2)
                For Each registro As DataRow In xDT2.Rows
                    idTurnoActual = registro("MAX(id_turno)")
                Next
            End If
        Catch ex As Exception

        End Try

    End Function
End Class

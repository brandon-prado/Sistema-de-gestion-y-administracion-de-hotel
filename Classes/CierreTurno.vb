Imports Oracle.DataAccess.Client

Public Class CierreTurno
    Private cantidadCierreTurno As Double
    Private notaCierreTurno As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Public Sub New()
        cantidadCierreTurno = 0.0
        notaCierreTurno = ""
    End Sub

    Public Sub New(ByVal cantidadCierreTurnoD As Double, ByVal notaCierreTurnoD As String)
        cantidadCierreTurno = cantidadCierreTurnoD
        notaCierreTurno = notaCierreTurnoD
    End Sub

    'Métodos GET y SET
    Public Property GetSetCantidadCierreTurno() As Double
        Get
            Return cantidadCierreTurno
        End Get
        Set(ByVal Value As Double)
            cantidadCierreTurno = Value
        End Set
    End Property

    Public Property GetSetNotaTurno() As String
        Get
            Return notaCierreTurno
        End Get
        Set(ByVal Value As String)
            notaCierreTurno = Value
        End Set
    End Property

    'Metodo para cerrar turno, hace una actualizacion
    Public Sub CierraTurno()
        Try
            'Actualiza la cantidad actual en el turno correspondiente
            strSql = "UPDATE Turno SET cantidad_cierre_turno = " & cantidadCierreTurno & ", fecha_hora_cierre = SYSDATE, nota_turno = '" & notaCierreTurno & "' WHERE id_turno = " & idTurnoActual
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Metodo para consultar la cantidad actual en caja
    Public Sub CantidadActualCaja()
        Try
            'Obtiene la cantidad actual en caja
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT cantidad_actual_turno 
                                                    FROM Turno
                                                    WHERE id_turno = " & idTurnoActual, cnx)
            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                FrmCierreTurno.cantidadRequerida = registro("cantidad_actual_turno").ToString
                FrmCierreTurno.TxtCantidadRequerida.Text = registro("cantidad_actual_turno").ToString
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

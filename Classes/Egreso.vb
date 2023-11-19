Imports Oracle.DataAccess.Client
Public Class Egreso
    Private idEgreso As Integer
    Private idTurno As Integer
    Private cantEgreso As Double
    'private fechaEgreso as String
    Private concepto As String

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    'Constructor vacío
    Public Sub New()
        idEgreso = 0
        idTurno = 0
        cantEgreso = 0.0
        concepto = ""
    End Sub

    'Constructor cargado con parámetros enviados al instanciar el objeto
    Public Sub New(ByVal idEgresoD As Integer, ByVal idTurnoD As Integer, ByVal cantEgresoD As Double, ByVal conceptoD As String)
        idEgreso = idEgresoD
        idTurno = idTurnoD
        cantEgreso = cantEgresoD
        concepto = conceptoD
    End Sub

    'Métodos GET y SET
    Public Property GetSetIdEgreso() As Integer
        Get
            Return idEgreso
        End Get
        Set(ByVal Value As Integer)
            idEgreso = Value
        End Set
    End Property

    'Métodos GET y SET
    Public Property GetSetIdTurno() As Integer
        Get
            Return idTurno
        End Get
        Set(ByVal Value As Integer)
            idTurno = Value
        End Set
    End Property

    'Métodos GET y SET
    Public Property GetSetCantidadEgreso() As Double
        Get
            Return cantEgreso
        End Get
        Set(ByVal Value As Double)
            cantEgreso = Value
        End Set
    End Property

    'Métodos GET y SET
    Public Property GetSetConcepto() As String
        Get
            Return concepto
        End Get
        Set(ByVal Value As String)
            concepto = Value
        End Set
    End Property

    'Método que inserta un Egreso
    Public Sub InsertaEgreso()
        Try
            FrmTurno.turno.MostrarCantidadActualCaja()
            FrmTurno.turno.MostrarCantidadAperturaCaja()
            FrmTurno.turno.MostrarCantidadRetiroCaja()


            Dim diferenciaActualYRetiro As Double

            If cantEgreso > cantidadActualEnCaja Then
                FrmAviso.LbMensaje.Text = "NO PUEDES RETIRAR UNA CANTIDAD MAYOR A LA ACTUAL EN CAJA"
                FrmAviso.Show()
            ElseIf (cantidadActualEnCaja - cantEgreso) < cantidadFondoEnCaja Then
                FrmAviso.LbMensaje.Text = "NO PUEDES RETIRAR UNA CANTIDAD MAYOR QUE DEJE LA CAJA CON MENOS CANTIDAD QUE EL FONDO INICIAL"
                FrmAviso.Show()
            Else
                diferenciaActualYRetiro = cantidadActualEnCaja - cantEgreso
                strSql = "BEGIN Egreso_Insertar (" & idTurno & ", " & cantEgreso & ", SYSDATE, '" & concepto & "'); End;"
                xCnx.objetoCommand(strSql)

                strSql = "UPDATE Turno SET cantidad_actual_turno = " & diferenciaActualYRetiro & " WHERE id_turno = " & idTurnoActual
                xCnx.objetoCommand(strSql)
                FrmCorrecto.LbMensaje.Text = "Egreso Autorizado"
                FrmCorrecto.Show()
            End If

            FrmTurno.turno.MostrarCantidadActualCaja()
            FrmTurno.turno.MostrarCantidadAperturaCaja()
            FrmTurno.turno.MostrarCantidadRetiroCaja()
            'Dim renglon As Integer
            'renglon = FrmTurno.DGVTurnos.CurrentCellAddress.Y
            'If FrmTurno.DGVTurnos.Rows(renglon).Cells(7).Value > 2000 And cantEgreso < FrmTurno.DGVTurnos.Rows(renglon).Cells(7).Value Then
            '    strSql = "UPDATE Turno SET cantidad_actual_turno = cantidad_actual_turno -" & cantEgreso & " WHERE id_turno = " & idTurno & ""
            '    xCnx.objetoCommand(strSql)
            'End If

            'PoblarDataGridTurno(FrmTurno.DGVTurnos)
        Catch ex As Exception

        End Try

    End Sub


    ''Método que llena el DGV de turno
    'Public Sub PoblarDataGridTurno(ByVal DGVTurnos As DataGridView)
    '    'Llama a la función ConsultaTodosTurnos para llenar el DGV
    '    DGVTurnos.DataSource = ConsultaTodosTurnos()
    '    DGVTurnos.Refresh()
    '    'Cambiar la anchura de una columna de la tabla del DGV
    '    DGVTurnos.Columns.Item(4).Width = 240
    'End Sub

    'Método que actualiza un Egreso
    Public Sub ActualizaEgreso()
        Try
            strSql = "BEGIN Egreso_Actualizar (" & idTurno & ", " & cantEgreso & ", SYSDATE, '" & concepto & "'); End;"
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Método que elimina un Egreso
    Public Sub EliminarEgreso()
        Try
            strSql = "DELETE FROM Egreso Where id_egreso = " & idEgreso
            xCnx.objetoCommand(strSql)
        Catch ex As Exception

        End Try

    End Sub

    'Función que consulta sí existe un egreso y regresa un TRUE o FALSE
    Public Function ConsultaUnEgreso() As Boolean
        ConsultaUnEgreso = False
        Try
            strSql = "SELECT id_egreso FROM Egreso WHERE id_egreso = " & idEgreso


            xDT = xCnx.objetoDataAdapter(strSql)
            If xDT.Rows.Count = 1 Then
                ConsultaUnEgreso = True
            End If
        Catch ex As Exception

        End Try

    End Function

    'Función que valida sí un egreso tiene dependencias
    Public Function ValidaEgreso() As Boolean
        ValidaEgreso = False
        Try
            strSql = "SELECT * FROM Egreso WHERE id_egreso = " & idEgreso

            xDT = xCnx.objetoDataAdapter(strSql)

            If xDT.Rows.Count >= 1 Then
                ValidaEgreso = True
            End If
        Catch ex As Exception

        End Try

    End Function

    ''Método para saber que ID le pertenece cada nivel de permiso seleccionado desde el CB de la tabla Permiso
    'Public Sub IdSeleccionadoEnCB()
    '    Dim xDT As New DataTable
    '    Dim conector = New OracleDataAdapter

    '    strSql = "SELECT id_turno FROM Turno WHERE id_turno = '" & FrmEgreso.CBCaja.SelectedValue.ToString & "'"
    '    conector = New OracleDataAdapter(strSql, cnx)
    '    conector.Fill(xDT)

    '    For Each registro As DataRow In xDT.Rows
    '        FrmEgreso.idTurno = registro("id_turno").ToString
    '    Next
    'End Sub

    'Funcion que consulta todos los registros de la tabla Egreso
    Public Function ConsultaTodosEgresos() As Object

        strSql = "SELECT id_egreso AS ""ID EGRESO"", id_turno AS ""TURNO"", cantidad_egreso AS ""CANTIDAD DE EGRESO $"",
		 fecha_hora_egreso AS ""FECHA DE EGRESO"", concepto AS ""CONCEPTO DE EGRESO""
        FROM Egreso
        WHERE id_turno = " & idTurnoActual & "
        ORDER BY fecha_hora_egreso DESC"
            ConsultaTodosEgresos = xCnx.objetoDataAdapter(strSql)


    End Function

    'Método que llena el DGV de egreso
    Public Sub PoblarDataGridEgreso(ByVal DGVEgreso As DataGridView)
        'Llama a la función ConsultaTodosTurnos para llenar el DGV
        DGVEgreso.DataSource = ConsultaTodosEgresos()
        'Ocultar columna de ID 
        DGVEgreso.Columns(0).Visible = False
        DGVEgreso.Refresh()
    End Sub
End Class

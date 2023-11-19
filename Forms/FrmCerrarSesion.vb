Imports Oracle.DataAccess.Client

Public Class FrmCerrarSesion
    Private cantidadActualComprobar As Double

    Private strSql As String
    Private xCnx As New Oracle
    Private xDT As DataTable

    Private Sub BtnSi_Click(sender As Object, e As EventArgs) Handles BtnSi.Click
        Try
            ModuloGlobal.cerradoDesde = "CerrarSesion"
            FrmCargando.MostarConTiempoEnCargar(500)
            If nombreRol <> "Contador" Then
                If MovimientoTurno() = False Then
                    If ValidaTurnoEgreso() Then
                        OcultarEnCascada()

                        FrmCierreTurno.Show()
                        FrmMenuPrincipal.Hide()

                    Else

                        CerrarEnCascada()
                        EliminarTurnoSinMovimientos()

                        FrmInicioSesión.Show()
                        CerrarEnCascada()
                        If encriptada = "No" Then
                            EncriptarBD()
                            encriptada = "Si"
                        End If
                        'Encriptar base de datos
                        'EncriptarBD()
                        sinTurno = False
                    End If

                ElseIf MovimientoTurno() = True Then
                    OcultarEnCascada()

                    FrmCierreTurno.Show()
                    'FrmMenuPrincipal.Hide()
                End If
            Else
                CerrarEnCascada()
                'Encriptar base de datos
                'EncriptarBD()
                If encriptada = "No" Then
                    EncriptarBD()
                    encriptada = "Si"
                End If
                FrmInicioSesión.Show()
                CerrarEnCascada()
            End If
            'FrmMenuPrincipal.Close()
            'FrmCierreTurno.Close()
            ' ModuloGlobal.cerradoDesde = ""

            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    'Método que consulta la cantidad actual en caja
    Private Function MovimientoTurno() As Boolean
        MovimientoTurno = False
        Try
            Dim xDT As New DataTable
            Dim nombreUs As New OracleDataAdapter("SELECT cantidad_actual_turno AS ""ACTUAL"" FROM Turno WHERE id_turno = " & idTurnoActual, cnx)

            nombreUs.Fill(xDT)
            For Each registro As DataRow In xDT.Rows
                cantidadActualComprobar = registro("ACTUAL")
            Next

            If xDT.Rows.Count = 0 Then
                cantidadActualComprobar = 0
            End If

            'Si la cantidad actual es mayor a 0, la funcion retorna true
            If cantidadActualComprobar > 0 Then
                MovimientoTurno = True
            Else
                MovimientoTurno = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    'Método SI EL TURNO TIENE DEPENDENCIAS PARA PODER O NO ELIMINAR
    Public Function ValidaTurnoEgreso() As Boolean
        strSql = "SELECT * FROM Egreso WHERE id_turno = " & idTurnoActual
        ValidaTurnoEgreso = False
        xDT = xCnx.objetoDataAdapter(strSql)

        If xDT.Rows.Count >= 1 Then
            ValidaTurnoEgreso = True
        End If
    End Function

    'Método que elimina un turno, si no tiene ningun movimiento
    Public Sub EliminarTurnoSinMovimientos()
        strSql = "BEGIN Turno_Eliminar (" & idTurnoActual & "); END;"
        xCnx.objetoCommand(strSql)
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        Me.Close()
        If nombreRol <> "Contador" Then
            FrmMenuPrincipal.Activate()
            FrmMenuPrincipal.Show()
        End If


    End Sub

    Private Sub FrmCerrarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
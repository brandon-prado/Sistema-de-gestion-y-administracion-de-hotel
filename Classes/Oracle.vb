Imports Oracle.DataAccess.Client

Public Class Oracle
    Public Sub New()
        'Conexión a Oracle con el Usuario  
        cnx = New OracleConnection("Data Source = XE; User Id = hotel; Password = hotel;")

        If cnx.State <> ConnectionState.Open Then
            Try
                cnx.Open() 'Abrir la base de datos en caso de que la conexión sea exitosa
            Catch ex As Exception

                Throw New Exception("No se puedo conectar a la Base de Datos, contacte al D.B.A." & ex.Message)
            End Try
        End If
    End Sub

    'Método para efectuar consultas a base de datos recibiendo el string del DML
    Public Function objetoDataAdapter(ByVal sqlcmd As String) As DataTable

        Dim DA As OracleDataAdapter
        Dim DT As DataTable
        Try
            DA = New OracleDataAdapter(sqlcmd, cnx)
            DT = New DataTable
            DA.Fill(DT)
            Return DT
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        End Try
        DT.Dispose()
    End Function

    'Método que ejecuta un comando INSERT, UPDATE o DELETE a base de datos
    Public Sub objetoCommand(ByVal strcmd As String)
        Dim sqlcmd As New OracleCommand(strcmd, cnx)
        Try
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)

            sqlcmd.Dispose()
        End Try
    End Sub

    'Método para efectuar lecturas y generar recordset de datos
    'todos los select invocan este método y aqui se ejecutan
    Function objetoDataReader(ByVal strcmd As String) As OracleDataReader
        Dim sqlcmd As New OracleCommand(strcmd, cnx)
        Dim resultadoSQL As OracleDataReader = sqlcmd.ExecuteReader()
        Try
            Return resultadoSQL
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function

    'Método que ejecuta una función de grupo a la base de datos
    'cuando se hace un GROUP BY en el select
    Public Function objetoScalar(ByVal strcmd As String) As Object
        Dim sqlcmd As New OracleCommand(strcmd, cnx)
        Try
            objetoScalar = sqlcmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception("Error: " & ex.Message)
        Finally
            sqlcmd.Dispose()
        End Try
    End Function
End Class



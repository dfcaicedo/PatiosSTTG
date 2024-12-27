Imports MySql.Data.MySqlClient

Public Class CostoPatios
    Public Property fechainicial As DateTime
    Public Property fechasalida As DateTime
    Public Property tipovehiculo As Integer
    Public Property tiposervicio As Integer
    Public Property tipocliente As Integer
    Public Property entrada As Long
    Public Property parqueadero As Int16
    Public Property valores As New List(Of Int64)
    Public Property agnos As New List(Of Int32)
    Dim connectionstring As String = (New db).getConnectionString
    Public Sub New(entrada As Long)
        Using cnt As New MySqlConnection(connectionstring)
            Try
                cnt.Open()
                Using cmd As MySqlCommand = cnt.CreateCommand
                    cmd.CommandText = $"
                    select 
	                    par_codi, ent_codi, ent_entr,now(), tse_codi, tiv_codi, tic_codi 
                    from 
	                    co_entr 
                    inner join cl_usua on (co_entr.usu_cont=cl_usua.usu_cont)
                    where co_entr.ent_codi={entrada}"
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        While lector.Read
                            parqueadero = lector.GetInt32(0)
                            entrada = lector.GetInt64(1)
                            fechainicial = lector.GetDateTime(2)
                            fechasalida = lector.GetDateTime(3)
                            tiposervicio = lector.GetInt32(4)
                            tipovehiculo = lector.GetInt32(5)
                            tipocliente = lector.GetInt32(6)
                        End While
                    End Using
                    cmd.CommandText = $"select tar_agno, tar_cost from co_tari where par_codi={parqueadero} and 
                tiv_codi={tipovehiculo} and tse_codi={tiposervicio} and tic_codi={tipocliente} and 
                tar_agno>=year(@fechai) and tar_agno<=year(@fechaf) order by tar_agno"
                    cmd.Parameters.AddWithValue("@fechai", fechainicial)
                    cmd.Parameters.AddWithValue("@fechaf", fechasalida)
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        While lector.Read
                            agnos.Add(lector.GetInt32(0))
                            valores.Add(lector.GetInt64(1))
                        End While
                    End Using
                End Using
            Catch ex As Exception

            End Try

        End Using
    End Sub
    Public Function getFechaMin(f1 As Date, f2 As Date) As Date
        If f1 > f2 Then
            Return f2
        Else
            Return f1
        End If

    End Function
    Public Function getFechaMax(f1 As Date, f2 As Date) As Date
        If f1 > f2 Then
            Return f1
        Else
            Return f2
        End If
    End Function
    Public Function getCosto() As Long
        Dim fei As Date, fef As Date
        fei = fechainicial
        Dim c As Int16 = 0
        Dim acu As Int64 = 0
        For Each agno As Int64 In valores
            fei = getFechaMax(New Date(agnos.Item(c), 1, 1), fei)
            fef = getFechaMin(New Date(agnos.Item(c), 12, 31, 23, 59, 59), fechasalida)
            Dim dif As TimeSpan
            dif = fef - fei
            acu += valores.Item(c) * Math.Ceiling(dif.TotalDays)
            fei = New Date(agnos.Item(c) + 1, 1, 1)
            c += 1
        Next
        Return acu
    End Function

End Class

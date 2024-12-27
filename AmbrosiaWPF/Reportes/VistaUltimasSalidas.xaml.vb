Imports MySql.Data.MySqlClient

Public Class VistaUltimasSalidas
    ReadOnly park As Int64
    Dim ent As List(Of Model_Id_Desc)

    Public Sub New(park As Int64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.park = park
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim db As New db
        Dim cnt As New MySqlConnection(db.getConnectionString)
        Dim cmd As New MySqlCommand("select ent_codi, concat(ent_plac,'-',ent_sali) from co_entr where ent_sali is not null and par_codi = @park order by ent_codi desc limit 0,500", cnt)
        cmd.Parameters.AddWithValue("@park", Me.park)
        ent = New List(Of Model_Id_Desc)
        Try
            cnt.Open()
            Dim lector As MySqlDataReader = cmd.ExecuteReader
            While lector.Read
                Dim q As New Model_Id_Desc
                q.id = lector.GetValue(0)
                q.desc = lector.GetValue(1)
                ent.Add(q)
            End While
            lector.Close()
            cnt.Close()
            Me.Lista.ItemsSource = ent
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Lista_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles Lista.SelectionChanged
        Dim ent As Int64
        ent = e.AddedItems(0).id
        If MsgBox("Desea generar la salida con placa " & e.AddedItems(0).desc, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim q As New RPTSalidas(ent)
            q.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class

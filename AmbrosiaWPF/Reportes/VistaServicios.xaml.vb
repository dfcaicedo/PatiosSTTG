Imports MySql.Data.MySqlClient

Public Class VistaServicios
    ReadOnly park As Int64
    Dim ent As List(Of Model_Id_Desc)

    Public Sub New(park As Int64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.park = park
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim db As New db
        Dim cnt As New MySqlConnection(db.getConnectionString)
        Dim cmd As New MySqlCommand("select usu_cont,concat(usu_codi, '-',usu_nomb) from cl_usua where usu_cont in (select usu_codi from co_serv ) order by usu_nomb", cnt)

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
        Dim cedula() As String = e.AddedItems(0).desc.ToString.Split("-")
        If MsgBox("Desea generar el recibo del servicio para " & e.AddedItems(0).desc, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim q As New RptServiciosFRM(cedula(0))
            q.ShowDialog()
            Me.Close()
        End If
    End Sub

End Class

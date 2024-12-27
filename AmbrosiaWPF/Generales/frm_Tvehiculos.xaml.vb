Imports MySql.Data.MySqlClient

Public Class frm_Tvehiculos
    Dim valor As Int64
    Dim db As New db
    Dim list As New List(Of Model_Id_Desc)
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim cnt As MySqlConnection
        cnt = New MySqlConnection(db.getConnectionString)
        Dim cmd As New MySqlCommand("select tiv_codi, tiv_nomb from vh_tipos order by tiv_codi", cnt)
        Dim flag As Boolean = True
        Try
            cnt.Open()
            Dim lector As MySqlDataReader = cmd.ExecuteReader
            While lector.Read
                Dim q As New Model_Id_Desc()
                If flag Then
                    flag = False
                    Me.valor = lector.GetValue(0)
                End If
                q.id = lector.GetValue(0)
                q.desc = lector.GetValue(1)
                list.Add(q)
            End While
            lector.Close()
            Me.ListaTipo.ItemsSource = list
        Catch ex As Exception

        End Try

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Function getvalor() As Int64
        Return Me.valor
    End Function

    Private Sub ListaTipo_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles ListaTipo.SelectionChanged
        Me.valor = e.AddedItems(0).id
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class

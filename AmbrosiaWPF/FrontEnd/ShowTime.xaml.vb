Imports MySql.Data.MySqlClient

Public Class ShowTiMe
    Public Sub New(entrada As Int64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim db As New db
        Dim costo As New ProcesoCostos(entrada)
        Dim cs As String = db.getConnectionString
        Dim cnt As New MySqlConnection(cs)
        Dim fechae As DateTime, fechaa As DateTime
        Dim cmd As New MySqlCommand("Select ent_entr, now() from co_entr where ent_codi =@entrada", cnt)
        Dim lector As MySqlDataReader
        cmd.Parameters.AddWithValue("@entrada", entrada)
        Try
            cnt.Open()
            lector = cmd.ExecuteReader
            While lector.Read
                fechae = lector.GetValue(0)
                fechaa = lector.GetValue(1)
            End While
            lector.Close()
            cnt.Close()
            Dim lapso As TimeSpan
            lapso = fechaa - fechae
            Dim dias As Int32
            Dim horas As Int32
            Dim minutos As Int32
            dias = Math.Floor(lapso.TotalDays)
            horas = Math.Floor(lapso.TotalHours) - 24 * dias
            minutos = Math.Ceiling(lapso.TotalMinutes) - (dias * 24 * 60) - horas * 60
            lblDias.Content = dias
            lblHoras.Content = horas
            lblMinutos.Content = minutos
            Me.lblCosto.Content = costo.getCosto(fechaa)

        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try
        Dim cost As New ProcesoCostos(entrada)
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub
End Class

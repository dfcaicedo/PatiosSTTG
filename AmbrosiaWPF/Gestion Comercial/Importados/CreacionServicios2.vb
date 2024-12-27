Public Class CreacionServicios2
    Dim user As String
    Dim db As New db
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user

        Me.Co_tserTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub CreacionServicios2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_tser' Puede moverla o quitarla según sea necesario.
        Me.Co_tserTableAdapter.Fill(Me.ambrosia_proDataSet.co_tser)
        Me.DateTimePicker1.MinDate = (New db).getvalue("select now() from dual")
    End Sub
    Dim valid As Boolean = False
    Public Function getvalid() As Boolean
        Return Me.valid
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.valid = True
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.DateTimePicker2.MinDate = Me.DateTimePicker1.Value.AddDays(1)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            Me.TextBox1.Text = Convert.ToInt64(db.getvalue("Select avg(ser_cost) from co_serv where tse_codi=@servicio", "@servicio", Me.ListBox1.SelectedValue))
        Catch ex As Exception

        End Try

    End Sub
End Class
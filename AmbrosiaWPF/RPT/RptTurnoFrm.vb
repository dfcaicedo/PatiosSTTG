Public Class RptTurnoFrm
    Private ReadOnly park As Int64
    Public Sub New(park As Int64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.park = park
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.CrystalReportViewer1.ReportSource = Nothing
        Dim db As New db
        Me.TurnosrptTableAdapter1.Connection = db.getconnection
    End Sub
    Private Sub RptTurnoFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.DateTimePicker2.Value > Me.DateTimePicker1.Value Then
            Me.TurnosrptTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.turnosrpt, Me.park, Me.DateTimePicker1.Value, Me.DateTimePicker2.Value)
            If Me.CheckBox1.Checked Then
                Me.TurnosCompleto1.SetDataSource(Me.Ambrosiapark_proDataSet1)
                Me.CrystalReportViewer1.ReportSource = Me.TurnosCompleto1
                Me.CrystalReportViewer1.RefreshReport()
            Else
                Me.TurnosResumen1.SetDataSource(Me.Ambrosiapark_proDataSet1)
                Me.CrystalReportViewer1.ReportSource = Me.TurnosResumen1
                Me.CrystalReportViewer1.RefreshReport()
            End If
        End If

    End Sub
End Class
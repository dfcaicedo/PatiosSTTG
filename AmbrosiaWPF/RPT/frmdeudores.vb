Public Class frmdeudores
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim db As New db
        Me.DeudoresviewTableAdapter1.Connection = db.getconnection
        Me.DeudoresviewTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.deudoresview)
        Me.deudoresreport1.SetDataSource(Me.Ambrosiapark_proDataSet1)


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmdeudores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.ReportSource = Me.deudoresreport1
        Me.CrystalReportViewer1.RefreshReport()

    End Sub
End Class
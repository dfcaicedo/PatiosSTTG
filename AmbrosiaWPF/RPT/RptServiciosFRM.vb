Public Class RptServiciosFRM
    Public ReadOnly cedula As String
    Dim db As New db
    Public Sub New(cedula As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.TextBox1.Text = cedula
        Me.TextBox1.ReadOnly = True
        Me.Ambrosiapark_proDataSet1.EnforceConstraints = False
        Me.RptServiciosTATableAdapter1.Connection = db.getconnection

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.RptServiciosTATableAdapter1.Connection = db.getconnection
        Me.Ambrosiapark_proDataSet1.EnforceConstraints = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub RptServiciosFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Me.TextBox1.Text <> "" Then
            Me.RptServiciosTATableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.RptServiciosTA, Me.TextBox1.Text)
            Me.ServiciosRPT1.SetDataSource(Me.Ambrosiapark_proDataSet1)
            Me.CrystalReportViewer1.ReportSource = Me.ServiciosRPT1
            Me.CrystalReportViewer1.RefreshReport()
            Me.CrystalReportViewer1.PrintReport()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Me.RptServiciosTATableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.RptServiciosTA, Me.TextBox1.Text)
            Me.ServiciosRPT1.SetDataSource(Me.Ambrosiapark_proDataSet1)
            Me.CrystalReportViewer1.ReportSource = Me.ServiciosRPT1
            Me.CrystalReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
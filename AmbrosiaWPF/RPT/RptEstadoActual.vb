Public Class RptEstadoActual
    Public Sub New()
        Dim db As New db
        Dim cs As String = db.getConnectionString
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.EstadoActualTableAdapter1.Connection = New MySql.Data.MySqlClient.MySqlConnection(cs)
        Me.EstadoActualTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.EstadoActual)

        Me.EstadoActual1.SetDataSource(Me.Ambrosiapark_proDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.EstadoActual1
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub RptEstadoActual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.RefreshReport()
        Me.CrystalReportViewer1.PrintReport()
        If MsgBox("Desea Cerrar el reporte", MsgBoxStyle.YesNo, "Control de Parqueadero") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
Public Class EntradasRPT
    Public Sub New(entradas As Int64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.RptEntradaTableAdapter1.Connection = New MySql.Data.MySqlClient.MySqlConnection((New db).getConnectionString)
        Me.RptEntradaTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.RptEntrada, entradas)
        Me.Entradas1.SetDataSource(Me.Ambrosiapark_proDataSet1)
        Me.CrystalReportViewer1.RefreshReport()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub EntradasRPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.PrintReport()
        If (MsgBox("Desea cerrar el reporte", MsgBoxStyle.YesNo, "Control de Parqueaderos") = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
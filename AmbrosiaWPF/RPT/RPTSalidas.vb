Public Class RPTSalidas


    Public Sub New(entrada As Int64)
        Dim db As New db
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        Dim cs As String = db.getConnectionString

        Em_parkTableAdapter1.Connection.ConnectionString = cs
        Em_parkTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.em_park)
        Cl_usuaTableAdapter1.Connection.ConnectionString = cs
        Cl_usuaTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.cl_usua)
        Cl_tipoTableAdapter1.Connection.ConnectionString = cs
        Cl_tipoTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.cl_tipo)
        Co_tserTableAdapter1.Connection.ConnectionString = cs
        Co_tserTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.co_tser)
        Vh_tiposTableAdapter1.Connection.ConnectionString = cs
        Vh_tiposTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.vh_tipos)
        Me.Rpt_salidaTableAdapter1.Connection.ConnectionString = cs
        Me.Rpt_salidaTableAdapter1.FillByEntrada(Me.Ambrosiapark_proDataSet1.rpt_salida, entrada)
        Me.SalidasRPT1.SetDataSource(Me.Ambrosiapark_proDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.SalidasRPT1
        Me.CrystalReportViewer1.RefreshReport()


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub RPTSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CrystalReportViewer1.RefreshReport()
        Me.CrystalReportViewer1.PrintReport()
        If MsgBox("Desea cerrar el reporte", MsgBoxStyle.YesNo, "Control de Parqueaderos") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
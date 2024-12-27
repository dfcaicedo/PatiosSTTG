Public Class SaldosFRM
    Public ReadOnly saldo As Int64
    Public Sub New(saldo As Int64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.saldo = saldo
        Me.SaldorptTableAdapter1.Connection = (New db).getconnection
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub SaldosFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SaldorptTableAdapter1.Fill(Me.Ambrosiapark_proDataSet1.saldorpt, Me.saldo)
        Me.rptsaldos1.SetDataSource(Me.Ambrosiapark_proDataSet1)
        Me.CrystalReportViewer1.ReportSource = Me.rptsaldos1
        Me.CrystalReportViewer1.RefreshReport()
        Me.CrystalReportViewer1.PrintReport()
        If MsgBox("Desea cerrar el reporte", MsgBoxStyle.YesNo, "Control de parqueaderos") = MsgBoxResult.Yes Then
            Me.Close()

        End If

    End Sub
End Class
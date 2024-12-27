<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradasRPT
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Entradas1 = New AmbrosiaWPF.Entradas()
        Me.Ambrosiapark_proDataSet1 = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.RptEntradaTableAdapter1 = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.RptEntradaTableAdapter()
        CType(Me.Ambrosiapark_proDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.Entradas1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(749, 715)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Ambrosiapark_proDataSet1
        '
        Me.Ambrosiapark_proDataSet1.DataSetName = "ambrosiapark_proDataSet"
        Me.Ambrosiapark_proDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RptEntradaTableAdapter1
        '
        Me.RptEntradaTableAdapter1.ClearBeforeFill = True
        '
        'EntradasRPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 715)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "EntradasRPT"
        Me.Text = "EntradasRPT"
        CType(Me.Ambrosiapark_proDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Entradas1 As Entradas
    Friend WithEvents Ambrosiapark_proDataSet1 As ambrosiapark_proDataSet
    Friend WithEvents RptEntradaTableAdapter1 As ambrosiapark_proDataSetTableAdapters.RptEntradaTableAdapter
End Class

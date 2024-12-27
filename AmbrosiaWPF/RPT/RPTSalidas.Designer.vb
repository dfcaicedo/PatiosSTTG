<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RPTSalidas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SalidasRPT1 = New AmbrosiaWPF.SalidasRPT()
        Me.Rpt_salidaTableAdapter1 = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.rpt_salidaTableAdapter()
        Me.Em_parkTableAdapter1 = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter()
        Me.Cl_tipoTableAdapter1 = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.cl_tipoTableAdapter()
        Me.Co_tserTableAdapter1 = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter()
        Me.Cl_usuaTableAdapter1 = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter()
        Me.Ambrosiapark_proDataSet1 = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.Vh_tiposTableAdapter1 = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter()
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
        Me.CrystalReportViewer1.ReportSource = Me.SalidasRPT1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(827, 490)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'Rpt_salidaTableAdapter1
        '
        Me.Rpt_salidaTableAdapter1.ClearBeforeFill = True
        '
        'Em_parkTableAdapter1
        '
        Me.Em_parkTableAdapter1.ClearBeforeFill = True
        '
        'Cl_tipoTableAdapter1
        '
        Me.Cl_tipoTableAdapter1.ClearBeforeFill = True
        '
        'Co_tserTableAdapter1
        '
        Me.Co_tserTableAdapter1.ClearBeforeFill = True
        '
        'Cl_usuaTableAdapter1
        '
        Me.Cl_usuaTableAdapter1.ClearBeforeFill = True
        '
        'Ambrosiapark_proDataSet1
        '
        Me.Ambrosiapark_proDataSet1.DataSetName = "ambrosiapark_proDataSet"
        Me.Ambrosiapark_proDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vh_tiposTableAdapter1
        '
        Me.Vh_tiposTableAdapter1.ClearBeforeFill = True
        '
        'RPTSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 490)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "RPTSalidas"
        Me.Text = "RPTSalidas"
        CType(Me.Ambrosiapark_proDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SalidasRPT1 As SalidasRPT
    Friend WithEvents Rpt_salidaTableAdapter1 As ambrosiapark_proDataSetTableAdapters.rpt_salidaTableAdapter
    Friend WithEvents Em_parkTableAdapter1 As ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter
    Friend WithEvents Cl_tipoTableAdapter1 As ambrosiapark_proDataSetTableAdapters.cl_tipoTableAdapter
    Friend WithEvents Co_tserTableAdapter1 As ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter
    Friend WithEvents Cl_usuaTableAdapter1 As ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter
    Friend WithEvents Ambrosiapark_proDataSet1 As ambrosiapark_proDataSet
    Friend WithEvents Vh_tiposTableAdapter1 As ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class testCostos
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(testCostos))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.EmparkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ambrosia_proDataSet = New ambrosiapark_proDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Em_parkTableAdapter = New ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.CltipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cl_tipoTableAdapter = New ambrosiapark_proDataSetTableAdapters.cl_tipoTableAdapter()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.CotserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Co_tserTableAdapter = New ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.VhtiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vh_tiposTableAdapter = New ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter()
        CType(Me.EmparkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CltipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VhtiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 299)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Probar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.EmparkBindingSource
        Me.ListBox1.DisplayMember = "PAR_NOMB"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(92, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(239, 56)
        Me.ListBox1.TabIndex = 1
        Me.ListBox1.ValueMember = "PAR_CODI"
        '
        'EmparkBindingSource
        '
        Me.EmparkBindingSource.DataMember = "em_park"
        Me.EmparkBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'Ambrosia_proDataSet
        '
        Me.ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Parqueaderos"
        '
        'Em_parkTableAdapter
        '
        Me.Em_parkTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo Cliente"
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.CltipoBindingSource
        Me.ListBox2.DisplayMember = "TIC_NOMB"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(92, 78)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(239, 56)
        Me.ListBox2.TabIndex = 3
        Me.ListBox2.ValueMember = "TIC_CODI"
        '
        'CltipoBindingSource
        '
        Me.CltipoBindingSource.DataMember = "cl_tipo"
        Me.CltipoBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'Cl_tipoTableAdapter
        '
        Me.Cl_tipoTableAdapter.ClearBeforeFill = True
        '
        'ListBox3
        '
        Me.ListBox3.DataSource = Me.VhtiposBindingSource
        Me.ListBox3.DisplayMember = "TIV_NOMB"
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(92, 140)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(239, 56)
        Me.ListBox3.TabIndex = 5
        Me.ListBox3.ValueMember = "TIV_CODI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tipo Vehiculo"
        '
        'ListBox4
        '
        Me.ListBox4.DataSource = Me.CotserBindingSource
        Me.ListBox4.DisplayMember = "TSE_NOMB"
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(92, 202)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(239, 56)
        Me.ListBox4.TabIndex = 7
        Me.ListBox4.ValueMember = "TSE_CODI"
        '
        'CotserBindingSource
        '
        Me.CotserBindingSource.DataMember = "co_tser"
        Me.CotserBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo Servicio"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Estancia"
        '
        'Co_tserTableAdapter
        '
        Me.Co_tserTableAdapter.ClearBeforeFill = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(92, 266)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(162, 20)
        Me.TextBox1.TabIndex = 8
        '
        'VhtiposBindingSource
        '
        Me.VhtiposBindingSource.DataMember = "vh_tipos"
        Me.VhtiposBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'Vh_tiposTableAdapter
        '
        Me.Vh_tiposTableAdapter.ClearBeforeFill = True
        '
        'testCostos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 334)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "testCostos"
        Me.Text = "testCostos"
        CType(Me.EmparkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CltipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VhtiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents EmparkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_parkTableAdapter As ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents CltipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cl_tipoTableAdapter As ambrosiapark_proDataSetTableAdapters.cl_tipoTableAdapter
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CotserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_tserTableAdapter As ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents VhtiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vh_tiposTableAdapter As ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter
End Class

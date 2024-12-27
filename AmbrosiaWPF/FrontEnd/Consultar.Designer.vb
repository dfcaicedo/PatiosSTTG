<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar
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
        Dim USU_CONTLabel As System.Windows.Forms.Label
        Dim ENT_ENTRLabel As System.Windows.Forms.Label
        Dim ENT_PLACLabel As System.Windows.Forms.Label
        Dim TSE_CODILabel As System.Windows.Forms.Label
        Dim TIV_CODILabel As System.Windows.Forms.Label
        Dim ENT_COMMLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar))
        Me.Ambrosiapark_proDataSet = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.Co_entrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Co_entrTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.co_entrTableAdapter()
        Me.TableAdapterManager = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Cl_usuaTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter()
        Me.Co_tserTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter()
        Me.Vh_tiposTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter()
        Me.Co_entrBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.Co_entrBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.USU_CONTListBox = New System.Windows.Forms.ListBox()
        Me.ClusuaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENT_ENTRLabel1 = New System.Windows.Forms.Label()
        Me.ENT_PLACTextBox = New System.Windows.Forms.TextBox()
        Me.TSE_CODIListBox = New System.Windows.Forms.ListBox()
        Me.CotserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIV_CODIListBox = New System.Windows.Forms.ListBox()
        Me.VhtiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENT_COMMTextBox = New System.Windows.Forms.TextBox()
        USU_CONTLabel = New System.Windows.Forms.Label()
        ENT_ENTRLabel = New System.Windows.Forms.Label()
        ENT_PLACLabel = New System.Windows.Forms.Label()
        TSE_CODILabel = New System.Windows.Forms.Label()
        TIV_CODILabel = New System.Windows.Forms.Label()
        ENT_COMMLabel = New System.Windows.Forms.Label()
        CType(Me.Ambrosiapark_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_entrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_entrBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Co_entrBindingNavigator.SuspendLayout()
        CType(Me.ClusuaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VhtiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USU_CONTLabel
        '
        USU_CONTLabel.AutoSize = True
        USU_CONTLabel.Location = New System.Drawing.Point(25, 70)
        USU_CONTLabel.Name = "USU_CONTLabel"
        USU_CONTLabel.Size = New System.Drawing.Size(55, 17)
        USU_CONTLabel.TabIndex = 1
        USU_CONTLabel.Text = "Cliente:"
        '
        'ENT_ENTRLabel
        '
        ENT_ENTRLabel.AutoSize = True
        ENT_ENTRLabel.Location = New System.Drawing.Point(25, 169)
        ENT_ENTRLabel.Name = "ENT_ENTRLabel"
        ENT_ENTRLabel.Size = New System.Drawing.Size(62, 17)
        ENT_ENTRLabel.TabIndex = 3
        ENT_ENTRLabel.Text = "Entrada:"
        '
        'ENT_PLACLabel
        '
        ENT_PLACLabel.AutoSize = True
        ENT_PLACLabel.Location = New System.Drawing.Point(25, 198)
        ENT_PLACLabel.Name = "ENT_PLACLabel"
        ENT_PLACLabel.Size = New System.Drawing.Size(47, 17)
        ENT_PLACLabel.TabIndex = 5
        ENT_PLACLabel.Text = "Placa:"
        '
        'TSE_CODILabel
        '
        TSE_CODILabel.AutoSize = True
        TSE_CODILabel.Location = New System.Drawing.Point(25, 223)
        TSE_CODILabel.Name = "TSE_CODILabel"
        TSE_CODILabel.Size = New System.Drawing.Size(114, 17)
        TSE_CODILabel.TabIndex = 7
        TSE_CODILabel.Text = "Tipo de Servicio:"
        '
        'TIV_CODILabel
        '
        TIV_CODILabel.AutoSize = True
        TIV_CODILabel.Location = New System.Drawing.Point(25, 325)
        TIV_CODILabel.Name = "TIV_CODILabel"
        TIV_CODILabel.Size = New System.Drawing.Size(94, 17)
        TIV_CODILabel.TabIndex = 9
        TIV_CODILabel.Text = "Tipo Vehiculo"
        '
        'ENT_COMMLabel
        '
        ENT_COMMLabel.AutoSize = True
        ENT_COMMLabel.Location = New System.Drawing.Point(25, 430)
        ENT_COMMLabel.Name = "ENT_COMMLabel"
        ENT_COMMLabel.Size = New System.Drawing.Size(95, 17)
        ENT_COMMLabel.TabIndex = 11
        ENT_COMMLabel.Text = "Comentarios: "
        '
        'Ambrosiapark_proDataSet
        '
        Me.Ambrosiapark_proDataSet.DataSetName = "ambrosiapark_proDataSet"
        Me.Ambrosiapark_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Co_entrBindingSource
        '
        Me.Co_entrBindingSource.DataMember = "co_entr"
        Me.Co_entrBindingSource.DataSource = Me.Ambrosiapark_proDataSet
        '
        'Co_entrTableAdapter
        '
        Me.Co_entrTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.au_dtranTableAdapter = Nothing
        Me.TableAdapterManager.au_transTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cl_saldoTableAdapter = Nothing
        Me.TableAdapterManager.cl_tipoTableAdapter = Nothing
        Me.TableAdapterManager.cl_usuaTableAdapter = Me.Cl_usuaTableAdapter
        Me.TableAdapterManager.cl_usvhTableAdapter = Nothing
        Me.TableAdapterManager.co_dcmaxTableAdapter = Nothing
        Me.TableAdapterManager.co_denvaTableAdapter = Nothing
        Me.TableAdapterManager.co_dpecoTableAdapter = Nothing
        Me.TableAdapterManager.co_dpernTableAdapter = Nothing
        Me.TableAdapterManager.co_dvalaTableAdapter = Nothing
        Me.TableAdapterManager.co_entrTableAdapter = Me.Co_entrTableAdapter
        Me.TableAdapterManager.co_servTableAdapter = Nothing
        Me.TableAdapterManager.co_tariTableAdapter = Nothing
        Me.TableAdapterManager.co_tserTableAdapter = Me.Co_tserTableAdapter
        Me.TableAdapterManager.co_tvalaTableAdapter = Nothing
        Me.TableAdapterManager.co_valadiTableAdapter = Nothing
        Me.TableAdapterManager.em_capaTableAdapter = Nothing
        Me.TableAdapterManager.em_cargTableAdapter = Nothing
        Me.TableAdapterManager.em_datenTableAdapter = Nothing
        Me.TableAdapterManager.em_dmodTableAdapter = Nothing
        Me.TableAdapterManager.em_drptTableAdapter = Nothing
        Me.TableAdapterManager.em_dticTableAdapter = Nothing
        Me.TableAdapterManager.em_emplTableAdapter = Nothing
        Me.TableAdapterManager.em_moacTableAdapter = Nothing
        Me.TableAdapterManager.em_moduTableAdapter = Nothing
        Me.TableAdapterManager.em_paptTableAdapter = Nothing
        Me.TableAdapterManager.em_parkTableAdapter = Nothing
        Me.TableAdapterManager.em_repoTableAdapter = Nothing
        Me.TableAdapterManager.em_tdatTableAdapter = Nothing
        Me.TableAdapterManager.em_tideTableAdapter = Nothing
        Me.TableAdapterManager.gn_diasTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Me.Vh_tiposTableAdapter
        '
        'Cl_usuaTableAdapter
        '
        Me.Cl_usuaTableAdapter.ClearBeforeFill = True
        '
        'Co_tserTableAdapter
        '
        Me.Co_tserTableAdapter.ClearBeforeFill = True
        '
        'Vh_tiposTableAdapter
        '
        Me.Vh_tiposTableAdapter.ClearBeforeFill = True
        '
        'Co_entrBindingNavigator
        '
        Me.Co_entrBindingNavigator.AddNewItem = Nothing
        Me.Co_entrBindingNavigator.BindingSource = Me.Co_entrBindingSource
        Me.Co_entrBindingNavigator.CountItem = Nothing
        Me.Co_entrBindingNavigator.DeleteItem = Nothing
        Me.Co_entrBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Co_entrBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Co_entrBindingNavigatorSaveItem})
        Me.Co_entrBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Co_entrBindingNavigator.MoveFirstItem = Nothing
        Me.Co_entrBindingNavigator.MoveLastItem = Nothing
        Me.Co_entrBindingNavigator.MoveNextItem = Nothing
        Me.Co_entrBindingNavigator.MovePreviousItem = Nothing
        Me.Co_entrBindingNavigator.Name = "Co_entrBindingNavigator"
        Me.Co_entrBindingNavigator.PositionItem = Nothing
        Me.Co_entrBindingNavigator.Size = New System.Drawing.Size(502, 27)
        Me.Co_entrBindingNavigator.TabIndex = 0
        Me.Co_entrBindingNavigator.Text = "BindingNavigator1"
        '
        'Co_entrBindingNavigatorSaveItem
        '
        Me.Co_entrBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Co_entrBindingNavigatorSaveItem.Image = CType(resources.GetObject("Co_entrBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Co_entrBindingNavigatorSaveItem.Name = "Co_entrBindingNavigatorSaveItem"
        Me.Co_entrBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Co_entrBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'USU_CONTListBox
        '
        Me.USU_CONTListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Co_entrBindingSource, "USU_CONT", True))
        Me.USU_CONTListBox.DataSource = Me.ClusuaBindingSource
        Me.USU_CONTListBox.DisplayMember = "USU_NOMB"
        Me.USU_CONTListBox.FormattingEnabled = True
        Me.USU_CONTListBox.ItemHeight = 16
        Me.USU_CONTListBox.Location = New System.Drawing.Point(143, 70)
        Me.USU_CONTListBox.Name = "USU_CONTListBox"
        Me.USU_CONTListBox.Size = New System.Drawing.Size(328, 84)
        Me.USU_CONTListBox.TabIndex = 2
        Me.USU_CONTListBox.ValueMember = "USU_CONT"
        '
        'ClusuaBindingSource
        '
        Me.ClusuaBindingSource.DataMember = "cl_usua"
        Me.ClusuaBindingSource.DataSource = Me.Ambrosiapark_proDataSet
        '
        'ENT_ENTRLabel1
        '
        Me.ENT_ENTRLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_entrBindingSource, "ENT_ENTR", True))
        Me.ENT_ENTRLabel1.Location = New System.Drawing.Point(143, 169)
        Me.ENT_ENTRLabel1.Name = "ENT_ENTRLabel1"
        Me.ENT_ENTRLabel1.Size = New System.Drawing.Size(120, 23)
        Me.ENT_ENTRLabel1.TabIndex = 4
        Me.ENT_ENTRLabel1.Text = "Label1"
        '
        'ENT_PLACTextBox
        '
        Me.ENT_PLACTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_entrBindingSource, "ENT_PLAC", True))
        Me.ENT_PLACTextBox.Location = New System.Drawing.Point(143, 195)
        Me.ENT_PLACTextBox.Name = "ENT_PLACTextBox"
        Me.ENT_PLACTextBox.Size = New System.Drawing.Size(120, 22)
        Me.ENT_PLACTextBox.TabIndex = 6
        '
        'TSE_CODIListBox
        '
        Me.TSE_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Co_entrBindingSource, "TSE_CODI", True))
        Me.TSE_CODIListBox.DataSource = Me.CotserBindingSource
        Me.TSE_CODIListBox.DisplayMember = "TSE_NOMB"
        Me.TSE_CODIListBox.FormattingEnabled = True
        Me.TSE_CODIListBox.ItemHeight = 16
        Me.TSE_CODIListBox.Location = New System.Drawing.Point(143, 223)
        Me.TSE_CODIListBox.Name = "TSE_CODIListBox"
        Me.TSE_CODIListBox.Size = New System.Drawing.Size(120, 84)
        Me.TSE_CODIListBox.TabIndex = 8
        Me.TSE_CODIListBox.ValueMember = "TSE_CODI"
        '
        'CotserBindingSource
        '
        Me.CotserBindingSource.DataMember = "co_tser"
        Me.CotserBindingSource.DataSource = Me.Ambrosiapark_proDataSet
        '
        'TIV_CODIListBox
        '
        Me.TIV_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Co_entrBindingSource, "TIV_CODI", True))
        Me.TIV_CODIListBox.DataSource = Me.VhtiposBindingSource
        Me.TIV_CODIListBox.DisplayMember = "TIV_NOMB"
        Me.TIV_CODIListBox.FormattingEnabled = True
        Me.TIV_CODIListBox.ItemHeight = 16
        Me.TIV_CODIListBox.Location = New System.Drawing.Point(143, 325)
        Me.TIV_CODIListBox.Name = "TIV_CODIListBox"
        Me.TIV_CODIListBox.Size = New System.Drawing.Size(120, 84)
        Me.TIV_CODIListBox.TabIndex = 10
        Me.TIV_CODIListBox.ValueMember = "TIV_CODI"
        '
        'VhtiposBindingSource
        '
        Me.VhtiposBindingSource.DataMember = "vh_tipos"
        Me.VhtiposBindingSource.DataSource = Me.Ambrosiapark_proDataSet
        '
        'ENT_COMMTextBox
        '
        Me.ENT_COMMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_entrBindingSource, "ENT_COMM", True))
        Me.ENT_COMMTextBox.Location = New System.Drawing.Point(143, 427)
        Me.ENT_COMMTextBox.Name = "ENT_COMMTextBox"
        Me.ENT_COMMTextBox.Size = New System.Drawing.Size(328, 22)
        Me.ENT_COMMTextBox.TabIndex = 12
        '
        'Consultar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 514)
        Me.Controls.Add(USU_CONTLabel)
        Me.Controls.Add(Me.USU_CONTListBox)
        Me.Controls.Add(ENT_ENTRLabel)
        Me.Controls.Add(Me.ENT_ENTRLabel1)
        Me.Controls.Add(ENT_PLACLabel)
        Me.Controls.Add(Me.ENT_PLACTextBox)
        Me.Controls.Add(TSE_CODILabel)
        Me.Controls.Add(Me.TSE_CODIListBox)
        Me.Controls.Add(TIV_CODILabel)
        Me.Controls.Add(Me.TIV_CODIListBox)
        Me.Controls.Add(ENT_COMMLabel)
        Me.Controls.Add(Me.ENT_COMMTextBox)
        Me.Controls.Add(Me.Co_entrBindingNavigator)
        Me.Name = "Consultar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar"
        CType(Me.Ambrosiapark_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_entrBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_entrBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Co_entrBindingNavigator.ResumeLayout(False)
        Me.Co_entrBindingNavigator.PerformLayout()
        CType(Me.ClusuaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VhtiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ambrosiapark_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Co_entrBindingSource As Forms.BindingSource
    Friend WithEvents Co_entrTableAdapter As ambrosiapark_proDataSetTableAdapters.co_entrTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Co_entrBindingNavigator As Forms.BindingNavigator
    Friend WithEvents Co_entrBindingNavigatorSaveItem As Forms.ToolStripButton
    Friend WithEvents Cl_usuaTableAdapter As ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter
    Friend WithEvents USU_CONTListBox As Forms.ListBox
    Friend WithEvents ENT_ENTRLabel1 As Forms.Label
    Friend WithEvents ENT_PLACTextBox As Forms.TextBox
    Friend WithEvents TSE_CODIListBox As Forms.ListBox
    Friend WithEvents TIV_CODIListBox As Forms.ListBox
    Friend WithEvents ENT_COMMTextBox As Forms.TextBox
    Friend WithEvents ClusuaBindingSource As Forms.BindingSource
    Friend WithEvents Co_tserTableAdapter As ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter
    Friend WithEvents CotserBindingSource As Forms.BindingSource
    Friend WithEvents Vh_tiposTableAdapter As ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter
    Friend WithEvents VhtiposBindingSource As Forms.BindingSource
End Class

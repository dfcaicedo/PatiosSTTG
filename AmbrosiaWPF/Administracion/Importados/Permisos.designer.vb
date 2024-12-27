<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Permisos
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
        Me.components = New System.ComponentModel.Container()
        Dim CAR_CODILabel As System.Windows.Forms.Label
        Dim CAR_NOMBLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Permisos))
        Me.Ambrosia_proDataSet = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.Em_cargBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Em_cargTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_cargTableAdapter()
        Me.TableAdapterManager = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Em_dmodTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_dmodTableAdapter()
        Me.Em_moduTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_moduTableAdapter()
        Me.Em_cargBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Em_cargBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CAR_CODITextBox = New System.Windows.Forms.TextBox()
        Me.CAR_NOMBTextBox = New System.Windows.Forms.TextBox()
        Me.Em_dmodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Em_dmodDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EmmoduBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmrepoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Em_repoTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_repoTableAdapter()
        Me.Em_drptBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Em_drptTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_drptTableAdapter()
        CAR_CODILabel = New System.Windows.Forms.Label()
        CAR_NOMBLabel = New System.Windows.Forms.Label()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_cargBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_cargBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Em_cargBindingNavigator.SuspendLayout()
        CType(Me.Em_dmodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_dmodDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmmoduBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmrepoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_drptBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CAR_CODILabel
        '
        CAR_CODILabel.AutoSize = True
        CAR_CODILabel.Location = New System.Drawing.Point(25, 48)
        CAR_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CAR_CODILabel.Name = "CAR_CODILabel"
        CAR_CODILabel.Size = New System.Drawing.Size(94, 17)
        CAR_CODILabel.TabIndex = 1
        CAR_CODILabel.Text = "Código Cargo"
        '
        'CAR_NOMBLabel
        '
        CAR_NOMBLabel.AutoSize = True
        CAR_NOMBLabel.Location = New System.Drawing.Point(25, 80)
        CAR_NOMBLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CAR_NOMBLabel.Name = "CAR_NOMBLabel"
        CAR_NOMBLabel.Size = New System.Drawing.Size(100, 17)
        CAR_NOMBLabel.TabIndex = 3
        CAR_NOMBLabel.Text = "Nombre Cargo"
        '
        'Ambrosia_proDataSet
        '
        Me.Ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.Ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Em_cargBindingSource
        '
        Me.Em_cargBindingSource.DataMember = "em_carg"
        Me.Em_cargBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Em_cargTableAdapter
        '
        Me.Em_cargTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.au_dtranTableAdapter = Nothing
        Me.TableAdapterManager.au_transTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cl_saldoTableAdapter = Nothing
        Me.TableAdapterManager.cl_tipoTableAdapter = Nothing
        Me.TableAdapterManager.cl_usuaTableAdapter = Nothing
        Me.TableAdapterManager.cl_usvhTableAdapter = Nothing
        Me.TableAdapterManager.co_dcmaxTableAdapter = Nothing
        Me.TableAdapterManager.co_denvaTableAdapter = Nothing
        Me.TableAdapterManager.co_dpecoTableAdapter = Nothing
        Me.TableAdapterManager.co_dpernTableAdapter = Nothing
        Me.TableAdapterManager.co_dvalaTableAdapter = Nothing
        Me.TableAdapterManager.co_entrTableAdapter = Nothing
        Me.TableAdapterManager.co_servTableAdapter = Nothing
        Me.TableAdapterManager.co_tariTableAdapter = Nothing
        Me.TableAdapterManager.co_tserTableAdapter = Nothing
        Me.TableAdapterManager.co_tvalaTableAdapter = Nothing
        Me.TableAdapterManager.co_valadiTableAdapter = Nothing
        Me.TableAdapterManager.em_capaTableAdapter = Nothing
        Me.TableAdapterManager.em_cargTableAdapter = Me.Em_cargTableAdapter
        Me.TableAdapterManager.em_datenTableAdapter = Nothing
        Me.TableAdapterManager.em_dmodTableAdapter = Me.Em_dmodTableAdapter
        Me.TableAdapterManager.em_drptTableAdapter = Nothing
        Me.TableAdapterManager.em_dticTableAdapter = Nothing
        Me.TableAdapterManager.em_emplTableAdapter = Nothing
        Me.TableAdapterManager.em_moacTableAdapter = Nothing
        Me.TableAdapterManager.em_moduTableAdapter = Me.Em_moduTableAdapter
        Me.TableAdapterManager.em_paptTableAdapter = Nothing
        Me.TableAdapterManager.em_parkTableAdapter = Nothing
        Me.TableAdapterManager.em_repoTableAdapter = Nothing
        Me.TableAdapterManager.em_tdatTableAdapter = Nothing
        Me.TableAdapterManager.em_tideTableAdapter = Nothing
        Me.TableAdapterManager.gn_diasTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Em_dmodTableAdapter
        '
        Me.Em_dmodTableAdapter.ClearBeforeFill = True
        '
        'Em_moduTableAdapter
        '
        Me.Em_moduTableAdapter.ClearBeforeFill = True
        '
        'Em_cargBindingNavigator
        '
        Me.Em_cargBindingNavigator.AddNewItem = Nothing
        Me.Em_cargBindingNavigator.BindingSource = Me.Em_cargBindingSource
        Me.Em_cargBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Em_cargBindingNavigator.DeleteItem = Nothing
        Me.Em_cargBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Em_cargBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Em_cargBindingNavigatorSaveItem})
        Me.Em_cargBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Em_cargBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Em_cargBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Em_cargBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Em_cargBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Em_cargBindingNavigator.Name = "Em_cargBindingNavigator"
        Me.Em_cargBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Em_cargBindingNavigator.Size = New System.Drawing.Size(727, 27)
        Me.Em_cargBindingNavigator.TabIndex = 0
        Me.Em_cargBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Em_cargBindingNavigatorSaveItem
        '
        Me.Em_cargBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Em_cargBindingNavigatorSaveItem.Image = CType(resources.GetObject("Em_cargBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Em_cargBindingNavigatorSaveItem.Name = "Em_cargBindingNavigatorSaveItem"
        Me.Em_cargBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Em_cargBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'CAR_CODITextBox
        '
        Me.CAR_CODITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_cargBindingSource, "CAR_CODI", True))
        Me.CAR_CODITextBox.Location = New System.Drawing.Point(131, 44)
        Me.CAR_CODITextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CAR_CODITextBox.Name = "CAR_CODITextBox"
        Me.CAR_CODITextBox.ReadOnly = True
        Me.CAR_CODITextBox.Size = New System.Drawing.Size(132, 22)
        Me.CAR_CODITextBox.TabIndex = 2
        '
        'CAR_NOMBTextBox
        '
        Me.CAR_NOMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_cargBindingSource, "CAR_NOMB", True))
        Me.CAR_NOMBTextBox.Location = New System.Drawing.Point(131, 76)
        Me.CAR_NOMBTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CAR_NOMBTextBox.Name = "CAR_NOMBTextBox"
        Me.CAR_NOMBTextBox.ReadOnly = True
        Me.CAR_NOMBTextBox.Size = New System.Drawing.Size(533, 22)
        Me.CAR_NOMBTextBox.TabIndex = 4
        '
        'Em_dmodBindingSource
        '
        Me.Em_dmodBindingSource.DataMember = "EM_DMOD_IBFK_1"
        Me.Em_dmodBindingSource.DataSource = Me.Em_cargBindingSource
        '
        'Em_dmodDataGridView
        '
        Me.Em_dmodDataGridView.AutoGenerateColumns = False
        Me.Em_dmodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Em_dmodDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Em_dmodDataGridView.DataSource = Me.Em_dmodBindingSource
        Me.Em_dmodDataGridView.Location = New System.Drawing.Point(29, 108)
        Me.Em_dmodDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Em_dmodDataGridView.Name = "Em_dmodDataGridView"
        Me.Em_dmodDataGridView.RowHeadersWidth = 51
        Me.Em_dmodDataGridView.Size = New System.Drawing.Size(636, 250)
        Me.Em_dmodDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "MOD_CODI"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.EmmoduBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "MOD_NOMB"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Módulo"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "MOD_CODI"
        '
        'EmmoduBindingSource
        '
        Me.EmmoduBindingSource.DataMember = "em_modu"
        Me.EmmoduBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CAR_CODI"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CAR_CODI"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EMP_NUSU"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EMP_NUSU"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'EmrepoBindingSource
        '
        Me.EmrepoBindingSource.DataMember = "em_repo"
        Me.EmrepoBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Em_repoTableAdapter
        '
        Me.Em_repoTableAdapter.ClearBeforeFill = True
        '
        'Em_drptBindingSource
        '
        Me.Em_drptBindingSource.DataMember = "em_drpt_ibfk_1"
        Me.Em_drptBindingSource.DataSource = Me.Em_cargBindingSource
        '
        'Em_drptTableAdapter
        '
        Me.Em_drptTableAdapter.ClearBeforeFill = True
        '
        'Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 381)
        Me.Controls.Add(Me.Em_dmodDataGridView)
        Me.Controls.Add(CAR_CODILabel)
        Me.Controls.Add(Me.CAR_CODITextBox)
        Me.Controls.Add(CAR_NOMBLabel)
        Me.Controls.Add(Me.CAR_NOMBTextBox)
        Me.Controls.Add(Me.Em_cargBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Permisos"
        Me.Text = "Permisos"
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_cargBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_cargBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Em_cargBindingNavigator.ResumeLayout(False)
        Me.Em_cargBindingNavigator.PerformLayout()
        CType(Me.Em_dmodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_dmodDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmmoduBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmrepoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_drptBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Em_cargBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_cargTableAdapter As ambrosiapark_proDataSetTableAdapters.em_cargTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Em_cargBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Em_cargBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CAR_CODITextBox As System.Windows.Forms.TextBox
    Friend WithEvents CAR_NOMBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_dmodTableAdapter As ambrosiapark_proDataSetTableAdapters.em_dmodTableAdapter
    Friend WithEvents Em_dmodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_moduTableAdapter As ambrosiapark_proDataSetTableAdapters.em_moduTableAdapter
    Friend WithEvents Em_dmodDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmmoduBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmrepoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_repoTableAdapter As ambrosiapark_proDataSetTableAdapters.em_repoTableAdapter
    Friend WithEvents Em_drptBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_drptTableAdapter As ambrosiapark_proDataSetTableAdapters.em_drptTableAdapter
End Class

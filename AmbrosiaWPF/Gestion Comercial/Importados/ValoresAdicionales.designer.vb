<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValoresAdicionales
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
        Dim TVA_CONTLabel As System.Windows.Forms.Label
        Dim TVA_NOMBLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ValoresAdicionales))
        Me.Ambrosia_proDataSet = New ambrosiapark_proDataSet()
        Me.Co_tvalaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Co_tvalaTableAdapter = New ambrosiapark_proDataSetTableAdapters.co_tvalaTableAdapter()
        Me.TableAdapterManager = New ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Co_valadiTableAdapter = New ambrosiapark_proDataSetTableAdapters.co_valadiTableAdapter()
        Me.Co_tvalaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Co_tvalaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TVA_CONTTextBox = New System.Windows.Forms.TextBox()
        Me.TVA_NOMBTextBox = New System.Windows.Forms.TextBox()
        Me.Co_valadiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Co_valadiDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EmparkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Em_parkTableAdapter = New ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter()
        TVA_CONTLabel = New System.Windows.Forms.Label()
        TVA_NOMBLabel = New System.Windows.Forms.Label()
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_tvalaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_tvalaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Co_tvalaBindingNavigator.SuspendLayout()
        CType(Me.Co_valadiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_valadiDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmparkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TVA_CONTLabel
        '
        TVA_CONTLabel.AutoSize = True
        TVA_CONTLabel.Location = New System.Drawing.Point(32, 64)
        TVA_CONTLabel.Name = "TVA_CONTLabel"
        TVA_CONTLabel.Size = New System.Drawing.Size(40, 13)
        TVA_CONTLabel.TabIndex = 1
        TVA_CONTLabel.Text = "Código"
        '
        'TVA_NOMBLabel
        '
        TVA_NOMBLabel.AutoSize = True
        TVA_NOMBLabel.Location = New System.Drawing.Point(32, 90)
        TVA_NOMBLabel.Name = "TVA_NOMBLabel"
        TVA_NOMBLabel.Size = New System.Drawing.Size(89, 13)
        TVA_NOMBLabel.TabIndex = 3
        TVA_NOMBLabel.Text = "Tipo de Adicional"
        '
        'Ambrosia_proDataSet
        '
        Me.ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Co_tvalaBindingSource
        '
        Me.Co_tvalaBindingSource.DataMember = "co_tvala"
        Me.Co_tvalaBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'Co_tvalaTableAdapter
        '
        Me.Co_tvalaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        Me.TableAdapterManager.co_tvalaTableAdapter = Me.Co_tvalaTableAdapter
        Me.TableAdapterManager.co_valadiTableAdapter = Me.Co_valadiTableAdapter
        Me.TableAdapterManager.em_cargTableAdapter = Nothing
        Me.TableAdapterManager.em_dmodTableAdapter = Nothing
        Me.TableAdapterManager.em_drptTableAdapter = Nothing
        Me.TableAdapterManager.em_emplTableAdapter = Nothing
        Me.TableAdapterManager.em_moacTableAdapter = Nothing
        Me.TableAdapterManager.em_moduTableAdapter = Nothing
        Me.TableAdapterManager.em_paptTableAdapter = Nothing
        Me.TableAdapterManager.em_parkTableAdapter = Nothing
        Me.TableAdapterManager.em_repoTableAdapter = Nothing
        Me.TableAdapterManager.em_tdatTableAdapter = Nothing
        Me.TableAdapterManager.em_tideTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Co_valadiTableAdapter
        '
        Me.Co_valadiTableAdapter.ClearBeforeFill = True
        '
        'Co_tvalaBindingNavigator
        '
        Me.Co_tvalaBindingNavigator.AddNewItem = Nothing
        Me.Co_tvalaBindingNavigator.BindingSource = Me.Co_tvalaBindingSource
        Me.Co_tvalaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Co_tvalaBindingNavigator.DeleteItem = Nothing
        Me.Co_tvalaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Co_tvalaBindingNavigatorSaveItem})
        Me.Co_tvalaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Co_tvalaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Co_tvalaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Co_tvalaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Co_tvalaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Co_tvalaBindingNavigator.Name = "Co_tvalaBindingNavigator"
        Me.Co_tvalaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Co_tvalaBindingNavigator.Size = New System.Drawing.Size(704, 25)
        Me.Co_tvalaBindingNavigator.TabIndex = 0
        Me.Co_tvalaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Co_tvalaBindingNavigatorSaveItem
        '
        Me.Co_tvalaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Co_tvalaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Co_tvalaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Co_tvalaBindingNavigatorSaveItem.Name = "Co_tvalaBindingNavigatorSaveItem"
        Me.Co_tvalaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Co_tvalaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TVA_CONTTextBox
        '
        Me.TVA_CONTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_tvalaBindingSource, "TVA_CONT", True))
        Me.TVA_CONTTextBox.Location = New System.Drawing.Point(123, 61)
        Me.TVA_CONTTextBox.Name = "TVA_CONTTextBox"
        Me.TVA_CONTTextBox.ReadOnly = True
        Me.TVA_CONTTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TVA_CONTTextBox.TabIndex = 2
        '
        'TVA_NOMBTextBox
        '
        Me.TVA_NOMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_tvalaBindingSource, "TVA_NOMB", True))
        Me.TVA_NOMBTextBox.Location = New System.Drawing.Point(123, 87)
        Me.TVA_NOMBTextBox.Name = "TVA_NOMBTextBox"
        Me.TVA_NOMBTextBox.ReadOnly = True
        Me.TVA_NOMBTextBox.Size = New System.Drawing.Size(561, 20)
        Me.TVA_NOMBTextBox.TabIndex = 4
        '
        'Co_valadiBindingSource
        '
        Me.Co_valadiBindingSource.DataMember = "CO_VALADI_IBFK_1"
        Me.Co_valadiBindingSource.DataSource = Me.Co_tvalaBindingSource
        '
        'Co_valadiDataGridView
        '
        Me.Co_valadiDataGridView.AutoGenerateColumns = False
        Me.Co_valadiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Co_valadiDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn4})
        Me.Co_valadiDataGridView.DataSource = Me.Co_valadiBindingSource
        Me.Co_valadiDataGridView.Location = New System.Drawing.Point(35, 113)
        Me.Co_valadiDataGridView.Name = "Co_valadiDataGridView"
        Me.Co_valadiDataGridView.Size = New System.Drawing.Size(649, 254)
        Me.Co_valadiDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "VAL_CONT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PAR_CODI"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.EmparkBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "PAR_NOMB"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Parqueadero"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "PAR_CODI"
        '
        'EmparkBindingSource
        '
        Me.EmparkBindingSource.DataMember = "em_park"
        Me.EmparkBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "VAL_DESC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Descripción del Adicional"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Configurar"
        Me.Column1.Name = "Column1"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "VAL_ACTI"
        Me.DataGridViewCheckBoxColumn1.FalseValue = "false"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn1.IndeterminateValue = "false"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.TrueValue = "true"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TVA_CONT"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TVA_CONT"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'Em_parkTableAdapter
        '
        Me.Em_parkTableAdapter.ClearBeforeFill = True
        '
        'ValoresAdicionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 379)
        Me.Controls.Add(Me.Co_valadiDataGridView)
        Me.Controls.Add(TVA_CONTLabel)
        Me.Controls.Add(Me.TVA_CONTTextBox)
        Me.Controls.Add(TVA_NOMBLabel)
        Me.Controls.Add(Me.TVA_NOMBTextBox)
        Me.Controls.Add(Me.Co_tvalaBindingNavigator)
        Me.Name = "ValoresAdicionales"
        Me.Text = "Valores Adicionales"
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_tvalaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_tvalaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Co_tvalaBindingNavigator.ResumeLayout(False)
        Me.Co_tvalaBindingNavigator.PerformLayout()
        CType(Me.Co_valadiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_valadiDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmparkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Co_tvalaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_tvalaTableAdapter As ambrosiapark_proDataSetTableAdapters.co_tvalaTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Co_tvalaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Co_tvalaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TVA_CONTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TVA_NOMBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Co_valadiTableAdapter As ambrosiapark_proDataSetTableAdapters.co_valadiTableAdapter
    Friend WithEvents Co_valadiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_valadiDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmparkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_parkTableAdapter As ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

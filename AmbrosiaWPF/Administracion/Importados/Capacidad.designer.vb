<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Capacidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Capacidad))
        Dim PAR_CODILabel As System.Windows.Forms.Label
        Dim PAR_NOMBLabel As System.Windows.Forms.Label
        Dim PAR_DIRELabel As System.Windows.Forms.Label

        Me.Ambrosia_proDataSet = New ambrosiapark_proDataSet()
        Me.Em_parkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Em_parkTableAdapter = New ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter()
        Me.TableAdapterManager = New ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Em_parkBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Em_parkBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PAR_CODITextBox = New System.Windows.Forms.TextBox()
        Me.PAR_NOMBTextBox = New System.Windows.Forms.TextBox()
        Me.PAR_DIRETextBox = New System.Windows.Forms.TextBox()
        Me.Em_capaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Em_capaTableAdapter = New ambrosiapark_proDataSetTableAdapters.em_capaTableAdapter()
        Me.Em_capaDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmcapaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VhtiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vh_tiposTableAdapter = New ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        PAR_CODILabel = New System.Windows.Forms.Label()
        PAR_NOMBLabel = New System.Windows.Forms.Label()
        PAR_DIRELabel = New System.Windows.Forms.Label()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_parkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_parkBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Em_parkBindingNavigator.SuspendLayout()
        CType(Me.Em_capaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_capaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmcapaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VhtiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ambrosia_proDataSet
        '
        Me.Ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.Ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Em_parkBindingSource
        '
        Me.Em_parkBindingSource.DataMember = "em_park"
        Me.Em_parkBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Em_parkTableAdapter
        '
        Me.Em_parkTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
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
        Me.TableAdapterManager.em_capaTableAdapter = Me.Em_capaTableAdapter
        Me.TableAdapterManager.em_cargTableAdapter = Nothing
        Me.TableAdapterManager.em_datenTableAdapter = Nothing
        Me.TableAdapterManager.em_dmodTableAdapter = Nothing
        Me.TableAdapterManager.em_drptTableAdapter = Nothing
        Me.TableAdapterManager.em_emplTableAdapter = Nothing
        Me.TableAdapterManager.em_moacTableAdapter = Nothing
        Me.TableAdapterManager.em_moduTableAdapter = Nothing
        Me.TableAdapterManager.em_paptTableAdapter = Nothing
        Me.TableAdapterManager.em_parkTableAdapter = Me.Em_parkTableAdapter
        Me.TableAdapterManager.em_repoTableAdapter = Nothing
        Me.TableAdapterManager.em_tdatTableAdapter = Nothing
        Me.TableAdapterManager.em_tideTableAdapter = Nothing
        Me.TableAdapterManager.gn_diasTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Me.Vh_tiposTableAdapter
        '
        'Em_parkBindingNavigator
        '
        Me.Em_parkBindingNavigator.AddNewItem = Nothing
        Me.Em_parkBindingNavigator.BindingSource = Me.Em_parkBindingSource
        Me.Em_parkBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Em_parkBindingNavigator.DeleteItem = Nothing
        Me.Em_parkBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Em_parkBindingNavigatorSaveItem})
        Me.Em_parkBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Em_parkBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Em_parkBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Em_parkBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Em_parkBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Em_parkBindingNavigator.Name = "Em_parkBindingNavigator"
        Me.Em_parkBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Em_parkBindingNavigator.Size = New System.Drawing.Size(645, 25)
        Me.Em_parkBindingNavigator.TabIndex = 0
        Me.Em_parkBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Em_parkBindingNavigatorSaveItem
        '
        Me.Em_parkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Em_parkBindingNavigatorSaveItem.Image = CType(resources.GetObject("Em_parkBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Em_parkBindingNavigatorSaveItem.Name = "Em_parkBindingNavigatorSaveItem"
        Me.Em_parkBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Em_parkBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PAR_CODILabel
        '
        PAR_CODILabel.AutoSize = True
        PAR_CODILabel.Location = New System.Drawing.Point(34, 68)
        PAR_CODILabel.Name = "PAR_CODILabel"
        PAR_CODILabel.Size = New System.Drawing.Size(43, 13)
        PAR_CODILabel.TabIndex = 1
        PAR_CODILabel.Text = "Código:"
        '
        'PAR_CODITextBox
        '
        Me.PAR_CODITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_CODI", True))
        Me.PAR_CODITextBox.Location = New System.Drawing.Point(107, 65)
        Me.PAR_CODITextBox.Name = "PAR_CODITextBox"
        Me.PAR_CODITextBox.ReadOnly = True
        Me.PAR_CODITextBox.Size = New System.Drawing.Size(100, 20)
        Me.PAR_CODITextBox.TabIndex = 2
        '
        'PAR_NOMBLabel
        '
        PAR_NOMBLabel.AutoSize = True
        PAR_NOMBLabel.Location = New System.Drawing.Point(34, 94)
        PAR_NOMBLabel.Name = "PAR_NOMBLabel"
        PAR_NOMBLabel.Size = New System.Drawing.Size(44, 13)
        PAR_NOMBLabel.TabIndex = 3
        PAR_NOMBLabel.Text = "Nombre"
        '
        'PAR_NOMBTextBox
        '
        Me.PAR_NOMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_NOMB", True))
        Me.PAR_NOMBTextBox.Location = New System.Drawing.Point(107, 91)
        Me.PAR_NOMBTextBox.Name = "PAR_NOMBTextBox"
        Me.PAR_NOMBTextBox.ReadOnly = True
        Me.PAR_NOMBTextBox.Size = New System.Drawing.Size(526, 20)
        Me.PAR_NOMBTextBox.TabIndex = 4
        '
        'PAR_DIRELabel
        '
        PAR_DIRELabel.AutoSize = True
        PAR_DIRELabel.Location = New System.Drawing.Point(34, 120)
        PAR_DIRELabel.Name = "PAR_DIRELabel"
        PAR_DIRELabel.Size = New System.Drawing.Size(52, 13)
        PAR_DIRELabel.TabIndex = 5
        PAR_DIRELabel.Text = "Dirección"
        '
        'PAR_DIRETextBox
        '
        Me.PAR_DIRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_DIRE", True))
        Me.PAR_DIRETextBox.Location = New System.Drawing.Point(107, 117)
        Me.PAR_DIRETextBox.Name = "PAR_DIRETextBox"
        Me.PAR_DIRETextBox.ReadOnly = True
        Me.PAR_DIRETextBox.Size = New System.Drawing.Size(526, 20)
        Me.PAR_DIRETextBox.TabIndex = 6
        '
        'Em_capaBindingSource
        '
        Me.Em_capaBindingSource.DataMember = "em_capa_ibfk_1"
        Me.Em_capaBindingSource.DataSource = Me.Em_parkBindingSource
        '
        'Em_capaTableAdapter
        '
        Me.Em_capaTableAdapter.ClearBeforeFill = True
        '
        'Em_capaDataGridView
        '
        Me.Em_capaDataGridView.AutoGenerateColumns = False
        Me.Em_capaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Em_capaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5})
        Me.Em_capaDataGridView.DataSource = Me.Em_capaBindingSource
        Me.Em_capaDataGridView.Location = New System.Drawing.Point(37, 154)
        Me.Em_capaDataGridView.Name = "Em_capaDataGridView"
        Me.Em_capaDataGridView.Size = New System.Drawing.Size(596, 229)
        Me.Em_capaDataGridView.TabIndex = 7
        '
        'EmcapaBindingSource
        '
        Me.EmcapaBindingSource.DataMember = "em_capa"
        Me.EmcapaBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'VhtiposBindingSource
        '
        Me.VhtiposBindingSource.DataMember = "vh_tipos"
        Me.VhtiposBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Vh_tiposTableAdapter
        '
        Me.Vh_tiposTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cap_codi"
        Me.DataGridViewTextBoxColumn1.HeaderText = "cap_codi"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "par_codi"
        Me.DataGridViewTextBoxColumn2.HeaderText = "par_codi"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tiv_codi"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.VhtiposBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "TIV_NOMB"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Tipo de Vehiculo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "TIV_CODI"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cap_cant"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad soportada"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "cap_limi"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Limitar la entrada "
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "emp_nusu"
        Me.DataGridViewTextBoxColumn5.HeaderText = "emp_nusu"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'Capacidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 399)
        Me.Controls.Add(Me.Em_capaDataGridView)
        Me.Controls.Add(PAR_CODILabel)
        Me.Controls.Add(Me.PAR_CODITextBox)
        Me.Controls.Add(PAR_NOMBLabel)
        Me.Controls.Add(Me.PAR_NOMBTextBox)
        Me.Controls.Add(PAR_DIRELabel)
        Me.Controls.Add(Me.PAR_DIRETextBox)
        Me.Controls.Add(Me.Em_parkBindingNavigator)
        Me.Name = "Capacidad"
        Me.Text = "Capacidad del Parqueadero"
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_parkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_parkBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Em_parkBindingNavigator.ResumeLayout(False)
        Me.Em_parkBindingNavigator.PerformLayout()
        CType(Me.Em_capaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_capaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmcapaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VhtiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Em_parkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_parkTableAdapter As ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Em_parkBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Em_parkBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PAR_CODITextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAR_NOMBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAR_DIRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_capaTableAdapter As ambrosiapark_proDataSetTableAdapters.em_capaTableAdapter
    Friend WithEvents Em_capaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vh_tiposTableAdapter As ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter
    Friend WithEvents Em_capaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmcapaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VhtiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

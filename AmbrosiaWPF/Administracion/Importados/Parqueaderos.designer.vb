<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parqueaderos
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
        Dim PAR_CODILabel As System.Windows.Forms.Label
        Dim PAR_NOMBLabel As System.Windows.Forms.Label
        Dim PAR_DIRELabel As System.Windows.Forms.Label
        Dim PAR_TELELabel As System.Windows.Forms.Label
        Dim PAR_NITLabel As System.Windows.Forms.Label
        Dim PAR_COMSLabel As System.Windows.Forms.Label
        Dim PAR_COMILabel As System.Windows.Forms.Label
        Dim Emp_nusuLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parqueaderos))
        Me.Ambrosia_proDataSet = New ambrosiapark_proDataSet()
        Me.Em_parkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Em_parkTableAdapter = New ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter()
        Me.TableAdapterManager = New ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Em_parkBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Em_parkBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PAR_CODITextBox = New System.Windows.Forms.TextBox()
        Me.PAR_NOMBTextBox = New System.Windows.Forms.TextBox()
        Me.PAR_DIRETextBox = New System.Windows.Forms.TextBox()
        Me.PAR_TELETextBox = New System.Windows.Forms.TextBox()
        Me.PAR_NITTextBox = New System.Windows.Forms.TextBox()
        Me.PAR_COMSTextBox = New System.Windows.Forms.TextBox()
        Me.PAR_COMITextBox = New System.Windows.Forms.TextBox()
        Me.Emp_nusuTextBox = New System.Windows.Forms.TextBox()
        Me.Em_datenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Em_datenTableAdapter = New ambrosiapark_proDataSetTableAdapters.em_datenTableAdapter()
        Me.Em_datenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GndiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gn_diasTableAdapter = New ambrosiapark_proDataSetTableAdapters.gn_diasTableAdapter()
        PAR_CODILabel = New System.Windows.Forms.Label()
        PAR_NOMBLabel = New System.Windows.Forms.Label()
        PAR_DIRELabel = New System.Windows.Forms.Label()
        PAR_TELELabel = New System.Windows.Forms.Label()
        PAR_NITLabel = New System.Windows.Forms.Label()
        PAR_COMSLabel = New System.Windows.Forms.Label()
        PAR_COMILabel = New System.Windows.Forms.Label()
        Emp_nusuLabel = New System.Windows.Forms.Label()
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_parkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_parkBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Em_parkBindingNavigator.SuspendLayout()
        CType(Me.Em_datenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_datenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GndiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PAR_CODILabel
        '
        PAR_CODILabel.AutoSize = True
        PAR_CODILabel.Location = New System.Drawing.Point(16, 63)
        PAR_CODILabel.Name = "PAR_CODILabel"
        PAR_CODILabel.Size = New System.Drawing.Size(43, 13)
        PAR_CODILabel.TabIndex = 1
        PAR_CODILabel.Text = "Código:"
        '
        'PAR_NOMBLabel
        '
        PAR_NOMBLabel.AutoSize = True
        PAR_NOMBLabel.Location = New System.Drawing.Point(16, 89)
        PAR_NOMBLabel.Name = "PAR_NOMBLabel"
        PAR_NOMBLabel.Size = New System.Drawing.Size(128, 13)
        PAR_NOMBLabel.TabIndex = 3
        PAR_NOMBLabel.Text = "Nombre del Parqueadero:"
        '
        'PAR_DIRELabel
        '
        PAR_DIRELabel.AutoSize = True
        PAR_DIRELabel.Location = New System.Drawing.Point(16, 115)
        PAR_DIRELabel.Name = "PAR_DIRELabel"
        PAR_DIRELabel.Size = New System.Drawing.Size(55, 13)
        PAR_DIRELabel.TabIndex = 5
        PAR_DIRELabel.Text = "Dirección:"
        '
        'PAR_TELELabel
        '
        PAR_TELELabel.AutoSize = True
        PAR_TELELabel.Location = New System.Drawing.Point(16, 141)
        PAR_TELELabel.Name = "PAR_TELELabel"
        PAR_TELELabel.Size = New System.Drawing.Size(55, 13)
        PAR_TELELabel.TabIndex = 7
        PAR_TELELabel.Text = "Teléfono :"
        '
        'PAR_NITLabel
        '
        PAR_NITLabel.AutoSize = True
        PAR_NITLabel.Location = New System.Drawing.Point(16, 167)
        PAR_NITLabel.Name = "PAR_NITLabel"
        PAR_NITLabel.Size = New System.Drawing.Size(31, 13)
        PAR_NITLabel.TabIndex = 9
        PAR_NITLabel.Text = "NIT :"
        '
        'PAR_COMSLabel
        '
        PAR_COMSLabel.AutoSize = True
        PAR_COMSLabel.Location = New System.Drawing.Point(16, 193)
        PAR_COMSLabel.Name = "PAR_COMSLabel"
        PAR_COMSLabel.Size = New System.Drawing.Size(92, 13)
        PAR_COMSLabel.TabIndex = 11
        PAR_COMSLabel.Text = "Mensaje Superior:"
        '
        'PAR_COMILabel
        '
        PAR_COMILabel.AutoSize = True
        PAR_COMILabel.Location = New System.Drawing.Point(16, 219)
        PAR_COMILabel.Name = "PAR_COMILabel"
        PAR_COMILabel.Size = New System.Drawing.Size(85, 13)
        PAR_COMILabel.TabIndex = 13
        PAR_COMILabel.Text = "Mensaje Inferior:"
        '
        'Emp_nusuLabel
        '
        Emp_nusuLabel.AutoSize = True
        Emp_nusuLabel.Location = New System.Drawing.Point(388, 31)
        Emp_nusuLabel.Name = "Emp_nusuLabel"
        Emp_nusuLabel.Size = New System.Drawing.Size(101, 13)
        Emp_nusuLabel.TabIndex = 17
        Emp_nusuLabel.Text = "Última modificación:"
        '
        'Ambrosia_proDataSet
        '
        Me.ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Em_parkBindingSource
        '
        Me.Em_parkBindingSource.DataMember = "em_park"
        Me.Em_parkBindingSource.DataSource = Me.ambrosia_proDataSet
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
        '   Me.TableAdapterManager.co_saldosTableAdapter = Nothing
        Me.TableAdapterManager.co_servTableAdapter = Nothing
        Me.TableAdapterManager.co_tariTableAdapter = Nothing
        ' Me.TableAdapterManager.co_tentTableAdapter = Nothing
        Me.TableAdapterManager.co_tserTableAdapter = Nothing
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
        Me.TableAdapterManager.em_parkTableAdapter = Me.Em_parkTableAdapter
        Me.TableAdapterManager.em_repoTableAdapter = Nothing
        Me.TableAdapterManager.em_tdatTableAdapter = Nothing
        Me.TableAdapterManager.em_tideTableAdapter = Nothing
        Me.TableAdapterManager.gn_diasTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Em_parkBindingNavigator
        '
        Me.Em_parkBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Em_parkBindingNavigator.BindingSource = Me.Em_parkBindingSource
        Me.Em_parkBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Em_parkBindingNavigator.DeleteItem = Nothing
        Me.Em_parkBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Em_parkBindingNavigatorSaveItem})
        Me.Em_parkBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Em_parkBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Em_parkBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Em_parkBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Em_parkBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Em_parkBindingNavigator.Name = "Em_parkBindingNavigator"
        Me.Em_parkBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Em_parkBindingNavigator.Size = New System.Drawing.Size(648, 25)
        Me.Em_parkBindingNavigator.TabIndex = 0
        Me.Em_parkBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'Em_parkBindingNavigatorSaveItem
        '
        Me.Em_parkBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Em_parkBindingNavigatorSaveItem.Image = CType(resources.GetObject("Em_parkBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Em_parkBindingNavigatorSaveItem.Name = "Em_parkBindingNavigatorSaveItem"
        Me.Em_parkBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Em_parkBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PAR_CODITextBox
        '
        Me.PAR_CODITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_CODI", True))
        Me.PAR_CODITextBox.Location = New System.Drawing.Point(161, 60)
        Me.PAR_CODITextBox.Name = "PAR_CODITextBox"
        Me.PAR_CODITextBox.ReadOnly = True
        Me.PAR_CODITextBox.Size = New System.Drawing.Size(205, 20)
        Me.PAR_CODITextBox.TabIndex = 0
        '
        'PAR_NOMBTextBox
        '
        Me.PAR_NOMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_NOMB", True))
        Me.PAR_NOMBTextBox.Location = New System.Drawing.Point(161, 86)
        Me.PAR_NOMBTextBox.Name = "PAR_NOMBTextBox"
        Me.PAR_NOMBTextBox.Size = New System.Drawing.Size(205, 20)
        Me.PAR_NOMBTextBox.TabIndex = 1
        '
        'PAR_DIRETextBox
        '
        Me.PAR_DIRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_DIRE", True))
        Me.PAR_DIRETextBox.Location = New System.Drawing.Point(161, 112)
        Me.PAR_DIRETextBox.Name = "PAR_DIRETextBox"
        Me.PAR_DIRETextBox.Size = New System.Drawing.Size(205, 20)
        Me.PAR_DIRETextBox.TabIndex = 2
        '
        'PAR_TELETextBox
        '
        Me.PAR_TELETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_TELE", True))
        Me.PAR_TELETextBox.Location = New System.Drawing.Point(161, 138)
        Me.PAR_TELETextBox.Name = "PAR_TELETextBox"
        Me.PAR_TELETextBox.Size = New System.Drawing.Size(205, 20)
        Me.PAR_TELETextBox.TabIndex = 3
        '
        'PAR_NITTextBox
        '
        Me.PAR_NITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_NIT", True))
        Me.PAR_NITTextBox.Location = New System.Drawing.Point(161, 164)
        Me.PAR_NITTextBox.Name = "PAR_NITTextBox"
        Me.PAR_NITTextBox.Size = New System.Drawing.Size(205, 20)
        Me.PAR_NITTextBox.TabIndex = 4
        '
        'PAR_COMSTextBox
        '
        Me.PAR_COMSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_COMS", True))
        Me.PAR_COMSTextBox.Location = New System.Drawing.Point(161, 190)
        Me.PAR_COMSTextBox.Name = "PAR_COMSTextBox"
        Me.PAR_COMSTextBox.Size = New System.Drawing.Size(205, 20)
        Me.PAR_COMSTextBox.TabIndex = 5
        '
        'PAR_COMITextBox
        '
        Me.PAR_COMITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_COMI", True))
        Me.PAR_COMITextBox.Location = New System.Drawing.Point(161, 216)
        Me.PAR_COMITextBox.Name = "PAR_COMITextBox"
        Me.PAR_COMITextBox.Size = New System.Drawing.Size(205, 20)
        Me.PAR_COMITextBox.TabIndex = 6
        '
        'Emp_nusuTextBox
        '
        Me.Emp_nusuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "emp_nusu", True))
        Me.Emp_nusuTextBox.Location = New System.Drawing.Point(495, 28)
        Me.Emp_nusuTextBox.Name = "Emp_nusuTextBox"
        Me.Emp_nusuTextBox.ReadOnly = True
        Me.Emp_nusuTextBox.Size = New System.Drawing.Size(120, 20)
        Me.Emp_nusuTextBox.TabIndex = 18
        '
        'Em_datenBindingSource
        '
        Me.Em_datenBindingSource.DataMember = "em_daten_ibfk_2"
        Me.Em_datenBindingSource.DataSource = Me.Em_parkBindingSource
        '
        'Em_datenTableAdapter
        '
        Me.Em_datenTableAdapter.ClearBeforeFill = True
        '
        'Em_datenDataGridView
        '
        Me.Em_datenDataGridView.AutoGenerateColumns = False
        Me.Em_datenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Em_datenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Em_datenDataGridView.DataSource = Me.Em_datenBindingSource
        Me.Em_datenDataGridView.Location = New System.Drawing.Point(19, 242)
        Me.Em_datenDataGridView.Name = "Em_datenDataGridView"
        Me.Em_datenDataGridView.Size = New System.Drawing.Size(454, 278)
        Me.Em_datenDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "dat_Cont"
        Me.DataGridViewTextBoxColumn1.HeaderText = "dat_Cont"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dia_cont"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.GndiasBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "DIA_DESC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Día"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "DIA_CONT"
        '
        'GndiasBindingSource
        '
        Me.GndiasBindingSource.DataMember = "gn_dias"
        Me.GndiasBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "dat_hini"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hora Inicio de Atención"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "dat_hfina"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Hora Fin de Atención"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Gn_diasTableAdapter
        '
        Me.Gn_diasTableAdapter.ClearBeforeFill = True
        '
        'Parqueaderos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 528)
        Me.Controls.Add(Me.Em_datenDataGridView)
        Me.Controls.Add(PAR_CODILabel)
        Me.Controls.Add(Me.PAR_CODITextBox)
        Me.Controls.Add(PAR_NOMBLabel)
        Me.Controls.Add(Me.PAR_NOMBTextBox)
        Me.Controls.Add(PAR_DIRELabel)
        Me.Controls.Add(Me.PAR_DIRETextBox)
        Me.Controls.Add(PAR_TELELabel)
        Me.Controls.Add(Me.PAR_TELETextBox)
        Me.Controls.Add(PAR_NITLabel)
        Me.Controls.Add(Me.PAR_NITTextBox)
        Me.Controls.Add(PAR_COMSLabel)
        Me.Controls.Add(Me.PAR_COMSTextBox)
        Me.Controls.Add(PAR_COMILabel)
        Me.Controls.Add(Me.PAR_COMITextBox)
        Me.Controls.Add(Emp_nusuLabel)
        Me.Controls.Add(Me.Emp_nusuTextBox)
        Me.Controls.Add(Me.Em_parkBindingNavigator)
        Me.Name = "Parqueaderos"
        Me.Text = "Parqueaderos"
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_parkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_parkBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Em_parkBindingNavigator.ResumeLayout(False)
        Me.Em_parkBindingNavigator.PerformLayout()
        CType(Me.Em_datenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_datenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GndiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Em_parkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_parkTableAdapter As ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Em_parkBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents PAR_TELETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAR_NITTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAR_COMSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAR_COMITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Emp_nusuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_datenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_datenTableAdapter As ambrosiapark_proDataSetTableAdapters.em_datenTableAdapter
    Friend WithEvents Em_datenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GndiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gn_diasTableAdapter As ambrosiapark_proDataSetTableAdapters.gn_diasTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

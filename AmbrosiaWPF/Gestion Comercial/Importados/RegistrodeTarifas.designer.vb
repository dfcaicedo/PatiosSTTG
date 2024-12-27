<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrodeTarifas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrodeTarifas))
        Me.Em_parkBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Em_parkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ambrosia_proDataSet = New ambrosiapark_proDataSet()
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
        Me.Co_tariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Co_tariDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CltipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.VhtiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.CotserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Em_parkTableAdapter = New ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter()
        Me.TableAdapterManager = New ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Co_tariTableAdapter = New ambrosiapark_proDataSetTableAdapters.co_tariTableAdapter()
        Me.Cl_tipoTableAdapter = New ambrosiapark_proDataSetTableAdapters.cl_tipoTableAdapter()
        Me.Vh_tiposTableAdapter = New ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter()
        Me.Co_tserTableAdapter = New ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter()
        PAR_CODILabel = New System.Windows.Forms.Label()
        PAR_NOMBLabel = New System.Windows.Forms.Label()
        PAR_DIRELabel = New System.Windows.Forms.Label()
        PAR_TELELabel = New System.Windows.Forms.Label()
        PAR_NITLabel = New System.Windows.Forms.Label()
        CType(Me.Em_parkBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Em_parkBindingNavigator.SuspendLayout()
        CType(Me.Em_parkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_tariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_tariDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CltipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VhtiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PAR_CODILabel
        '
        PAR_CODILabel.AutoSize = True
        PAR_CODILabel.Location = New System.Drawing.Point(30, 76)
        PAR_CODILabel.Name = "PAR_CODILabel"
        PAR_CODILabel.Size = New System.Drawing.Size(43, 13)
        PAR_CODILabel.TabIndex = 1
        PAR_CODILabel.Text = "Código:"
        '
        'PAR_NOMBLabel
        '
        PAR_NOMBLabel.AutoSize = True
        PAR_NOMBLabel.Location = New System.Drawing.Point(209, 76)
        PAR_NOMBLabel.Name = "PAR_NOMBLabel"
        PAR_NOMBLabel.Size = New System.Drawing.Size(47, 13)
        PAR_NOMBLabel.TabIndex = 3
        PAR_NOMBLabel.Text = "Nombre:"
        '
        'PAR_DIRELabel
        '
        PAR_DIRELabel.AutoSize = True
        PAR_DIRELabel.Location = New System.Drawing.Point(30, 104)
        PAR_DIRELabel.Name = "PAR_DIRELabel"
        PAR_DIRELabel.Size = New System.Drawing.Size(55, 13)
        PAR_DIRELabel.TabIndex = 5
        PAR_DIRELabel.Text = "Dirección:"
        '
        'PAR_TELELabel
        '
        PAR_TELELabel.AutoSize = True
        PAR_TELELabel.Location = New System.Drawing.Point(30, 130)
        PAR_TELELabel.Name = "PAR_TELELabel"
        PAR_TELELabel.Size = New System.Drawing.Size(52, 13)
        PAR_TELELabel.TabIndex = 7
        PAR_TELELabel.Text = "Teléfono:"
        '
        'PAR_NITLabel
        '
        PAR_NITLabel.AutoSize = True
        PAR_NITLabel.Location = New System.Drawing.Point(30, 157)
        PAR_NITLabel.Name = "PAR_NITLabel"
        PAR_NITLabel.Size = New System.Drawing.Size(28, 13)
        PAR_NITLabel.TabIndex = 9
        PAR_NITLabel.Text = "NIT:"
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
        Me.Em_parkBindingNavigator.Size = New System.Drawing.Size(827, 25)
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
        'Em_parkBindingSource
        '
        Me.Em_parkBindingSource.DataMember = "em_park"
        Me.Em_parkBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'Ambrosia_proDataSet
        '
        Me.ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.PAR_CODITextBox.Location = New System.Drawing.Point(103, 73)
        Me.PAR_CODITextBox.Name = "PAR_CODITextBox"
        Me.PAR_CODITextBox.ReadOnly = True
        Me.PAR_CODITextBox.Size = New System.Drawing.Size(100, 20)
        Me.PAR_CODITextBox.TabIndex = 2
        '
        'PAR_NOMBTextBox
        '
        Me.PAR_NOMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_NOMB", True))
        Me.PAR_NOMBTextBox.Location = New System.Drawing.Point(282, 73)
        Me.PAR_NOMBTextBox.Name = "PAR_NOMBTextBox"
        Me.PAR_NOMBTextBox.ReadOnly = True
        Me.PAR_NOMBTextBox.Size = New System.Drawing.Size(513, 20)
        Me.PAR_NOMBTextBox.TabIndex = 4
        '
        'PAR_DIRETextBox
        '
        Me.PAR_DIRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_DIRE", True))
        Me.PAR_DIRETextBox.Location = New System.Drawing.Point(103, 101)
        Me.PAR_DIRETextBox.Name = "PAR_DIRETextBox"
        Me.PAR_DIRETextBox.ReadOnly = True
        Me.PAR_DIRETextBox.Size = New System.Drawing.Size(692, 20)
        Me.PAR_DIRETextBox.TabIndex = 6
        '
        'PAR_TELETextBox
        '
        Me.PAR_TELETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_TELE", True))
        Me.PAR_TELETextBox.Location = New System.Drawing.Point(103, 127)
        Me.PAR_TELETextBox.Name = "PAR_TELETextBox"
        Me.PAR_TELETextBox.ReadOnly = True
        Me.PAR_TELETextBox.Size = New System.Drawing.Size(692, 20)
        Me.PAR_TELETextBox.TabIndex = 8
        '
        'PAR_NITTextBox
        '
        Me.PAR_NITTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_parkBindingSource, "PAR_NIT", True))
        Me.PAR_NITTextBox.Location = New System.Drawing.Point(103, 154)
        Me.PAR_NITTextBox.Name = "PAR_NITTextBox"
        Me.PAR_NITTextBox.ReadOnly = True
        Me.PAR_NITTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PAR_NITTextBox.TabIndex = 10
        '
        'Co_tariBindingSource
        '
        Me.Co_tariBindingSource.DataMember = "CO_TARI_IBFK_4"
        Me.Co_tariBindingSource.DataSource = Me.Em_parkBindingSource
        '
        'Co_tariDataGridView
        '
        Me.Co_tariDataGridView.AllowUserToDeleteRows = False
        Me.Co_tariDataGridView.AutoGenerateColumns = False
        Me.Co_tariDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Co_tariDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewTextBoxColumn13})
        Me.Co_tariDataGridView.DataSource = Me.Co_tariBindingSource
        Me.Co_tariDataGridView.Location = New System.Drawing.Point(33, 193)
        Me.Co_tariDataGridView.Name = "Co_tariDataGridView"
        Me.Co_tariDataGridView.Size = New System.Drawing.Size(782, 284)
        Me.Co_tariDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TAR_CODI"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TAR_CODI"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TIC_CODI"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.CltipoBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "TIC_NOMB"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tipo de Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "TIC_CODI"
        '
        'CltipoBindingSource
        '
        Me.CltipoBindingSource.DataMember = "cl_tipo"
        Me.CltipoBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "PAR_CODI"
        Me.DataGridViewTextBoxColumn2.HeaderText = "PAR_CODI"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TIV_CODI"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.VhtiposBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "TIV_NOMB"
        Me.DataGridViewTextBoxColumn3.HeaderText = "T. Vehículo "
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "TIV_CODI"
        '
        'VhtiposBindingSource
        '
        Me.VhtiposBindingSource.DataMember = "vh_tipos"
        Me.VhtiposBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TSE_CODI"
        Me.DataGridViewTextBoxColumn10.DataSource = Me.CotserBindingSource
        Me.DataGridViewTextBoxColumn10.DisplayMember = "TSE_NOMB"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Tipo Servicio"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn10.ValueMember = "TSE_CODI"
        '
        'CotserBindingSource
        '
        Me.CotserBindingSource.DataMember = "co_tser"
        Me.CotserBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TAR_LAPS"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fracción"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TAR_COST"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Costo Fracción"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 80
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "TAR_ACTI"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Activo"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "EMP_NUSU"
        Me.DataGridViewTextBoxColumn13.HeaderText = "EMP_NUSU"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'Em_parkTableAdapter
        '
        Me.Em_parkTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.co_tariTableAdapter = Me.Co_tariTableAdapter

        Me.TableAdapterManager.co_tserTableAdapter = Nothing
        Me.TableAdapterManager.co_tvalaTableAdapter = Nothing
        Me.TableAdapterManager.co_valadiTableAdapter = Nothing
        Me.TableAdapterManager.em_cargTableAdapter = Nothing
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
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Co_tariTableAdapter
        '
        Me.Co_tariTableAdapter.ClearBeforeFill = True
        '
        'Cl_tipoTableAdapter
        '
        Me.Cl_tipoTableAdapter.ClearBeforeFill = True
        '
        'Vh_tiposTableAdapter
        '
        Me.Vh_tiposTableAdapter.ClearBeforeFill = True
        '
        'Co_tserTableAdapter
        '
        Me.Co_tserTableAdapter.ClearBeforeFill = True
        '
        'RegistrodeTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 489)
        Me.Controls.Add(Me.Co_tariDataGridView)
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
        Me.Controls.Add(Me.Em_parkBindingNavigator)
        Me.Name = "RegistrodeTarifas"
        Me.Text = "RegistrodeTarifas"
        CType(Me.Em_parkBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Em_parkBindingNavigator.ResumeLayout(False)
        Me.Em_parkBindingNavigator.PerformLayout()
        CType(Me.Em_parkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_tariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_tariDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CltipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VhtiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Co_tariTableAdapter As ambrosiapark_proDataSetTableAdapters.co_tariTableAdapter
    Friend WithEvents Co_tariBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_tariDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CltipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cl_tipoTableAdapter As ambrosiapark_proDataSetTableAdapters.cl_tipoTableAdapter
    Friend WithEvents VhtiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vh_tiposTableAdapter As ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter
    Friend WithEvents CotserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_tserTableAdapter As ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

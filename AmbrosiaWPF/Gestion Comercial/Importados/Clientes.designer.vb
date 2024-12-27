<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim USU_CODILabel As System.Windows.Forms.Label
        Dim TII_CODILabel As System.Windows.Forms.Label
        Dim USU_NOMBLabel As System.Windows.Forms.Label
        Dim USU_DIRELabel As System.Windows.Forms.Label
        Dim USU_TELELabel As System.Windows.Forms.Label
        Dim TIC_CODILabel As System.Windows.Forms.Label
        Dim USU_DEFALabel As System.Windows.Forms.Label
        Dim EMP_NUSULabel As System.Windows.Forms.Label
        Dim USU_SALDLabel As System.Windows.Forms.Label
        Dim USU_CARTELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.Ambrosia_proDataSet = New ambrosiapark_proDataSet()
        Me.Cl_usuaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cl_usuaTableAdapter = New ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter()
        Me.TableAdapterManager = New ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Cl_tipoTableAdapter = New ambrosiapark_proDataSetTableAdapters.cl_tipoTableAdapter()
        Me.Cl_usvhTableAdapter = New ambrosiapark_proDataSetTableAdapters.cl_usvhTableAdapter()
        Me.Em_tideTableAdapter = New ambrosiapark_proDataSetTableAdapters.em_tideTableAdapter()
        Me.Cl_usuaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Cl_usuaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.USU_CONTTextBox = New System.Windows.Forms.TextBox()
        Me.USU_CODITextBox = New System.Windows.Forms.TextBox()
        Me.TII_CODIListBox = New System.Windows.Forms.ListBox()
        Me.EmtideBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USU_NOMBTextBox = New System.Windows.Forms.TextBox()
        Me.USU_DIRETextBox = New System.Windows.Forms.TextBox()
        Me.USU_TELETextBox = New System.Windows.Forms.TextBox()
        Me.TIC_CODIListBox = New System.Windows.Forms.ListBox()
        Me.CltipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.USU_DEFACheckBox = New System.Windows.Forms.CheckBox()
        Me.EMP_NUSUTextBox = New System.Windows.Forms.TextBox()
        Me.USU_SALDTextBox = New System.Windows.Forms.TextBox()
        Me.USU_CARTECheckBox = New System.Windows.Forms.CheckBox()
        Me.Cl_usvhBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cl_usvhDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DocumentoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DocumentoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByPlacaToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PlacaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PlacaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByPlacaToolStripButton = New System.Windows.Forms.ToolStripButton()
        USU_CONTLabel = New System.Windows.Forms.Label()
        USU_CODILabel = New System.Windows.Forms.Label()
        TII_CODILabel = New System.Windows.Forms.Label()
        USU_NOMBLabel = New System.Windows.Forms.Label()
        USU_DIRELabel = New System.Windows.Forms.Label()
        USU_TELELabel = New System.Windows.Forms.Label()
        TIC_CODILabel = New System.Windows.Forms.Label()
        USU_DEFALabel = New System.Windows.Forms.Label()
        EMP_NUSULabel = New System.Windows.Forms.Label()
        USU_SALDLabel = New System.Windows.Forms.Label()
        USU_CARTELabel = New System.Windows.Forms.Label()
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cl_usuaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cl_usuaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cl_usuaBindingNavigator.SuspendLayout()
        CType(Me.EmtideBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CltipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cl_usvhBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cl_usvhDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.FillByPlacaToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'USU_CONTLabel
        '
        USU_CONTLabel.AutoSize = True
        USU_CONTLabel.Location = New System.Drawing.Point(21, 100)
        USU_CONTLabel.Name = "USU_CONTLabel"
        USU_CONTLabel.Size = New System.Drawing.Size(79, 13)
        USU_CONTLabel.TabIndex = 1
        USU_CONTLabel.Text = "Código Interno:"
        '
        'USU_CODILabel
        '
        USU_CODILabel.AutoSize = True
        USU_CODILabel.Location = New System.Drawing.Point(21, 126)
        USU_CODILabel.Name = "USU_CODILabel"
        USU_CODILabel.Size = New System.Drawing.Size(93, 13)
        USU_CODILabel.TabIndex = 3
        USU_CODILabel.Text = "No. Identificación:"
        '
        'TII_CODILabel
        '
        TII_CODILabel.AutoSize = True
        TII_CODILabel.Location = New System.Drawing.Point(21, 149)
        TII_CODILabel.Name = "TII_CODILabel"
        TII_CODILabel.Size = New System.Drawing.Size(94, 13)
        TII_CODILabel.TabIndex = 5
        TII_CODILabel.Text = "Tipo Identificación"
        '
        'USU_NOMBLabel
        '
        USU_NOMBLabel.AutoSize = True
        USU_NOMBLabel.Location = New System.Drawing.Point(21, 202)
        USU_NOMBLabel.Name = "USU_NOMBLabel"
        USU_NOMBLabel.Size = New System.Drawing.Size(94, 13)
        USU_NOMBLabel.TabIndex = 7
        USU_NOMBLabel.Text = "Nombre Completo:"
        '
        'USU_DIRELabel
        '
        USU_DIRELabel.AutoSize = True
        USU_DIRELabel.Location = New System.Drawing.Point(21, 228)
        USU_DIRELabel.Name = "USU_DIRELabel"
        USU_DIRELabel.Size = New System.Drawing.Size(55, 13)
        USU_DIRELabel.TabIndex = 9
        USU_DIRELabel.Text = "Dirección:"
        '
        'USU_TELELabel
        '
        USU_TELELabel.AutoSize = True
        USU_TELELabel.Location = New System.Drawing.Point(21, 254)
        USU_TELELabel.Name = "USU_TELELabel"
        USU_TELELabel.Size = New System.Drawing.Size(52, 13)
        USU_TELELabel.TabIndex = 11
        USU_TELELabel.Text = "Teléfono:"
        '
        'TIC_CODILabel
        '
        TIC_CODILabel.AutoSize = True
        TIC_CODILabel.Location = New System.Drawing.Point(21, 277)
        TIC_CODILabel.Name = "TIC_CODILabel"
        TIC_CODILabel.Size = New System.Drawing.Size(81, 13)
        TIC_CODILabel.TabIndex = 13
        TIC_CODILabel.Text = "Tipo de Cliente:"
        '
        'USU_DEFALabel
        '
        USU_DEFALabel.AutoSize = True
        USU_DEFALabel.Location = New System.Drawing.Point(21, 343)
        USU_DEFALabel.Name = "USU_DEFALabel"
        USU_DEFALabel.Size = New System.Drawing.Size(103, 13)
        USU_DEFALabel.TabIndex = 15
        USU_DEFALabel.Text = "Usuario por defecto:"
        '
        'EMP_NUSULabel
        '
        EMP_NUSULabel.AutoSize = True
        EMP_NUSULabel.Location = New System.Drawing.Point(458, 97)
        EMP_NUSULabel.Name = "EMP_NUSULabel"
        EMP_NUSULabel.Size = New System.Drawing.Size(50, 13)
        EMP_NUSULabel.TabIndex = 17
        EMP_NUSULabel.Text = "Modificó:"
        '
        'USU_SALDLabel
        '
        USU_SALDLabel.AutoSize = True
        USU_SALDLabel.Location = New System.Drawing.Point(161, 343)
        USU_SALDLabel.Name = "USU_SALDLabel"
        USU_SALDLabel.Size = New System.Drawing.Size(91, 13)
        USU_SALDLabel.TabIndex = 19
        USU_SALDLabel.Text = "Saldo de Usuario:"
        '
        'USU_CARTELabel
        '
        USU_CARTELabel.AutoSize = True
        USU_CARTELabel.Location = New System.Drawing.Point(399, 343)
        USU_CARTELabel.Name = "USU_CARTELabel"
        USU_CARTELabel.Size = New System.Drawing.Size(110, 13)
        USU_CARTELabel.TabIndex = 21
        USU_CARTELabel.Text = "Aplica pago Posterior:"
        '
        'Ambrosia_proDataSet
        '
        Me.ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cl_usuaBindingSource
        '
        Me.Cl_usuaBindingSource.DataMember = "cl_usua"
        Me.Cl_usuaBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'Cl_usuaTableAdapter
        '
        Me.Cl_usuaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.cl_saldoTableAdapter = Nothing
        Me.TableAdapterManager.cl_tipoTableAdapter = Me.Cl_tipoTableAdapter
        Me.TableAdapterManager.cl_usuaTableAdapter = Me.Cl_usuaTableAdapter
        Me.TableAdapterManager.cl_usvhTableAdapter = Me.Cl_usvhTableAdapter
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
        Me.TableAdapterManager.em_tideTableAdapter = Me.Em_tideTableAdapter
        Me.TableAdapterManager.gn_diasTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Cl_tipoTableAdapter
        '
        Me.Cl_tipoTableAdapter.ClearBeforeFill = True
        '
        'Cl_usvhTableAdapter
        '
        Me.Cl_usvhTableAdapter.ClearBeforeFill = True
        '
        'Em_tideTableAdapter
        '
        Me.Em_tideTableAdapter.ClearBeforeFill = True
        '
        'Cl_usuaBindingNavigator
        '
        Me.Cl_usuaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Cl_usuaBindingNavigator.BindingSource = Me.Cl_usuaBindingSource
        Me.Cl_usuaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Cl_usuaBindingNavigator.DeleteItem = Nothing
        Me.Cl_usuaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Cl_usuaBindingNavigatorSaveItem})
        Me.Cl_usuaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Cl_usuaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Cl_usuaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Cl_usuaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Cl_usuaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Cl_usuaBindingNavigator.Name = "Cl_usuaBindingNavigator"
        Me.Cl_usuaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Cl_usuaBindingNavigator.Size = New System.Drawing.Size(671, 25)
        Me.Cl_usuaBindingNavigator.TabIndex = 0
        Me.Cl_usuaBindingNavigator.Text = "BindingNavigator1"
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
        'Cl_usuaBindingNavigatorSaveItem
        '
        Me.Cl_usuaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cl_usuaBindingNavigatorSaveItem.Image = CType(resources.GetObject("Cl_usuaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cl_usuaBindingNavigatorSaveItem.Name = "Cl_usuaBindingNavigatorSaveItem"
        Me.Cl_usuaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Cl_usuaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'USU_CONTTextBox
        '
        Me.USU_CONTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cl_usuaBindingSource, "USU_CONT", True))
        Me.USU_CONTTextBox.Location = New System.Drawing.Point(132, 97)
        Me.USU_CONTTextBox.Name = "USU_CONTTextBox"
        Me.USU_CONTTextBox.ReadOnly = True
        Me.USU_CONTTextBox.Size = New System.Drawing.Size(120, 20)
        Me.USU_CONTTextBox.TabIndex = 2
        '
        'USU_CODITextBox
        '
        Me.USU_CODITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cl_usuaBindingSource, "USU_CODI", True))
        Me.USU_CODITextBox.Location = New System.Drawing.Point(132, 123)
        Me.USU_CODITextBox.Name = "USU_CODITextBox"
        Me.USU_CODITextBox.Size = New System.Drawing.Size(120, 20)
        Me.USU_CODITextBox.TabIndex = 0
        '
        'TII_CODIListBox
        '
        Me.TII_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Cl_usuaBindingSource, "TII_CODI", True))
        Me.TII_CODIListBox.DataSource = Me.EmtideBindingSource
        Me.TII_CODIListBox.DisplayMember = "TII_NOMB"
        Me.TII_CODIListBox.FormattingEnabled = True
        Me.TII_CODIListBox.Location = New System.Drawing.Point(132, 149)
        Me.TII_CODIListBox.Name = "TII_CODIListBox"
        Me.TII_CODIListBox.Size = New System.Drawing.Size(120, 43)
        Me.TII_CODIListBox.TabIndex = 1
        Me.TII_CODIListBox.ValueMember = "TII_CODI"
        '
        'EmtideBindingSource
        '
        Me.EmtideBindingSource.DataMember = "em_tide"
        Me.EmtideBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'USU_NOMBTextBox
        '
        Me.USU_NOMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cl_usuaBindingSource, "USU_NOMB", True))
        Me.USU_NOMBTextBox.Location = New System.Drawing.Point(132, 199)
        Me.USU_NOMBTextBox.Name = "USU_NOMBTextBox"
        Me.USU_NOMBTextBox.Size = New System.Drawing.Size(376, 20)
        Me.USU_NOMBTextBox.TabIndex = 2
        '
        'USU_DIRETextBox
        '
        Me.USU_DIRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cl_usuaBindingSource, "USU_DIRE", True))
        Me.USU_DIRETextBox.Location = New System.Drawing.Point(132, 225)
        Me.USU_DIRETextBox.Name = "USU_DIRETextBox"
        Me.USU_DIRETextBox.Size = New System.Drawing.Size(376, 20)
        Me.USU_DIRETextBox.TabIndex = 3
        '
        'USU_TELETextBox
        '
        Me.USU_TELETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cl_usuaBindingSource, "USU_TELE", True))
        Me.USU_TELETextBox.Location = New System.Drawing.Point(132, 251)
        Me.USU_TELETextBox.Name = "USU_TELETextBox"
        Me.USU_TELETextBox.Size = New System.Drawing.Size(120, 20)
        Me.USU_TELETextBox.TabIndex = 4
        '
        'TIC_CODIListBox
        '
        Me.TIC_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Cl_usuaBindingSource, "TIC_CODI", True))
        Me.TIC_CODIListBox.DataSource = Me.CltipoBindingSource
        Me.TIC_CODIListBox.DisplayMember = "TIC_NOMB"
        Me.TIC_CODIListBox.FormattingEnabled = True
        Me.TIC_CODIListBox.Location = New System.Drawing.Point(132, 277)
        Me.TIC_CODIListBox.Name = "TIC_CODIListBox"
        Me.TIC_CODIListBox.Size = New System.Drawing.Size(376, 56)
        Me.TIC_CODIListBox.TabIndex = 5
        Me.TIC_CODIListBox.ValueMember = "TIC_CODI"
        '
        'CltipoBindingSource
        '
        Me.CltipoBindingSource.DataMember = "cl_tipo"
        Me.CltipoBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'USU_DEFACheckBox
        '
        Me.USU_DEFACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Cl_usuaBindingSource, "USU_DEFA", True))
        Me.USU_DEFACheckBox.Location = New System.Drawing.Point(132, 338)
        Me.USU_DEFACheckBox.Name = "USU_DEFACheckBox"
        Me.USU_DEFACheckBox.Size = New System.Drawing.Size(23, 24)
        Me.USU_DEFACheckBox.TabIndex = 6
        Me.USU_DEFACheckBox.UseVisualStyleBackColor = True
        '
        'EMP_NUSUTextBox
        '
        Me.EMP_NUSUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cl_usuaBindingSource, "EMP_NUSU", True))
        Me.EMP_NUSUTextBox.Location = New System.Drawing.Point(531, 94)
        Me.EMP_NUSUTextBox.Name = "EMP_NUSUTextBox"
        Me.EMP_NUSUTextBox.ReadOnly = True
        Me.EMP_NUSUTextBox.Size = New System.Drawing.Size(120, 20)
        Me.EMP_NUSUTextBox.TabIndex = 18
        '
        'USU_SALDTextBox
        '
        Me.USU_SALDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cl_usuaBindingSource, "USU_SALD", True))
        Me.USU_SALDTextBox.Location = New System.Drawing.Point(272, 340)
        Me.USU_SALDTextBox.Name = "USU_SALDTextBox"
        Me.USU_SALDTextBox.ReadOnly = True
        Me.USU_SALDTextBox.Size = New System.Drawing.Size(120, 20)
        Me.USU_SALDTextBox.TabIndex = 20
        '
        'USU_CARTECheckBox
        '
        Me.USU_CARTECheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Cl_usuaBindingSource, "USU_CARTE", True))
        Me.USU_CARTECheckBox.Location = New System.Drawing.Point(510, 338)
        Me.USU_CARTECheckBox.Name = "USU_CARTECheckBox"
        Me.USU_CARTECheckBox.Size = New System.Drawing.Size(120, 24)
        Me.USU_CARTECheckBox.TabIndex = 7
        Me.USU_CARTECheckBox.UseVisualStyleBackColor = True
        '
        'Cl_usvhBindingSource
        '
        Me.Cl_usvhBindingSource.DataMember = "CL_USVH_IBFK_1"
        Me.Cl_usvhBindingSource.DataSource = Me.Cl_usuaBindingSource
        '
        'Cl_usvhDataGridView
        '
        Me.Cl_usvhDataGridView.AllowUserToDeleteRows = False
        Me.Cl_usvhDataGridView.AutoGenerateColumns = False
        Me.Cl_usvhDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cl_usvhDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5})
        Me.Cl_usvhDataGridView.DataSource = Me.Cl_usvhBindingSource
        Me.Cl_usvhDataGridView.Location = New System.Drawing.Point(24, 366)
        Me.Cl_usvhDataGridView.Name = "Cl_usvhDataGridView"
        Me.Cl_usvhDataGridView.Size = New System.Drawing.Size(626, 223)
        Me.Cl_usvhDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "USU_CONT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "USU_CONT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "USV_PLACA"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Placa de Vehiculo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "USV_FACT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "USV_FACT"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "USU_FDES"
        Me.DataGridViewTextBoxColumn4.HeaderText = "USU_FDES"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "USV_ACTI"
        Me.DataGridViewCheckBoxColumn1.FalseValue = "false"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Placa Activa"
        Me.DataGridViewCheckBoxColumn1.IndeterminateValue = "false"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.TrueValue = "true"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "EMP_NUSU"
        Me.DataGridViewTextBoxColumn5.HeaderText = "EMP_NUSU"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DocumentoToolStripLabel, Me.DocumentoToolStripTextBox, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(671, 25)
        Me.FillByToolStrip.TabIndex = 24
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'DocumentoToolStripLabel
        '
        Me.DocumentoToolStripLabel.Name = "DocumentoToolStripLabel"
        Me.DocumentoToolStripLabel.Size = New System.Drawing.Size(73, 22)
        Me.DocumentoToolStripLabel.Text = "Documento:"
        '
        'DocumentoToolStripTextBox
        '
        Me.DocumentoToolStripTextBox.Name = "DocumentoToolStripTextBox"
        Me.DocumentoToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.FillByToolStripButton.Text = "Consultar"
        '
        'FillByPlacaToolStrip
        '
        Me.FillByPlacaToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlacaToolStripLabel, Me.PlacaToolStripTextBox, Me.FillByPlacaToolStripButton})
        Me.FillByPlacaToolStrip.Location = New System.Drawing.Point(0, 50)
        Me.FillByPlacaToolStrip.Name = "FillByPlacaToolStrip"
        Me.FillByPlacaToolStrip.Size = New System.Drawing.Size(671, 25)
        Me.FillByPlacaToolStrip.TabIndex = 25
        Me.FillByPlacaToolStrip.Text = "FillByPlacaToolStrip"
        '
        'PlacaToolStripLabel
        '
        Me.PlacaToolStripLabel.Name = "PlacaToolStripLabel"
        Me.PlacaToolStripLabel.Size = New System.Drawing.Size(38, 22)
        Me.PlacaToolStripLabel.Text = "Placa:"
        '
        'PlacaToolStripTextBox
        '
        Me.PlacaToolStripTextBox.Name = "PlacaToolStripTextBox"
        Me.PlacaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByPlacaToolStripButton
        '
        Me.FillByPlacaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByPlacaToolStripButton.Name = "FillByPlacaToolStripButton"
        Me.FillByPlacaToolStripButton.Size = New System.Drawing.Size(62, 22)
        Me.FillByPlacaToolStripButton.Text = "Consultar"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 609)
        Me.Controls.Add(Me.FillByPlacaToolStrip)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Cl_usvhDataGridView)
        Me.Controls.Add(USU_CONTLabel)
        Me.Controls.Add(Me.USU_CONTTextBox)
        Me.Controls.Add(USU_CODILabel)
        Me.Controls.Add(Me.USU_CODITextBox)
        Me.Controls.Add(TII_CODILabel)
        Me.Controls.Add(Me.TII_CODIListBox)
        Me.Controls.Add(USU_NOMBLabel)
        Me.Controls.Add(Me.USU_NOMBTextBox)
        Me.Controls.Add(USU_DIRELabel)
        Me.Controls.Add(Me.USU_DIRETextBox)
        Me.Controls.Add(USU_TELELabel)
        Me.Controls.Add(Me.USU_TELETextBox)
        Me.Controls.Add(TIC_CODILabel)
        Me.Controls.Add(Me.TIC_CODIListBox)
        Me.Controls.Add(USU_DEFALabel)
        Me.Controls.Add(Me.USU_DEFACheckBox)
        Me.Controls.Add(EMP_NUSULabel)
        Me.Controls.Add(Me.EMP_NUSUTextBox)
        Me.Controls.Add(USU_SALDLabel)
        Me.Controls.Add(Me.USU_SALDTextBox)
        Me.Controls.Add(USU_CARTELabel)
        Me.Controls.Add(Me.USU_CARTECheckBox)
        Me.Controls.Add(Me.Cl_usuaBindingNavigator)
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cl_usuaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cl_usuaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cl_usuaBindingNavigator.ResumeLayout(False)
        Me.Cl_usuaBindingNavigator.PerformLayout()
        CType(Me.EmtideBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CltipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cl_usvhBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cl_usvhDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.FillByPlacaToolStrip.ResumeLayout(False)
        Me.FillByPlacaToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Cl_usuaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cl_usuaTableAdapter As ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cl_usuaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Cl_usuaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents USU_CONTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USU_CODITextBox As System.Windows.Forms.TextBox
    Friend WithEvents TII_CODIListBox As System.Windows.Forms.ListBox
    Friend WithEvents USU_NOMBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USU_DIRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents USU_TELETextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIC_CODIListBox As System.Windows.Forms.ListBox
    Friend WithEvents USU_DEFACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents EMP_NUSUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USU_SALDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USU_CARTECheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Em_tideTableAdapter As ambrosiapark_proDataSetTableAdapters.em_tideTableAdapter
    Friend WithEvents EmtideBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cl_tipoTableAdapter As ambrosiapark_proDataSetTableAdapters.cl_tipoTableAdapter
    Friend WithEvents CltipoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cl_usvhTableAdapter As ambrosiapark_proDataSetTableAdapters.cl_usvhTableAdapter
    Friend WithEvents Cl_usvhBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cl_usvhDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents DocumentoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DocumentoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByPlacaToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PlacaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PlacaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByPlacaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim TII_CODILabel As System.Windows.Forms.Label
        Dim EMP_CODILabel As System.Windows.Forms.Label
        Dim EMP_NOMBLabel As System.Windows.Forms.Label
        Dim EMP_DIRELabel As System.Windows.Forms.Label
        Dim EMP_TELELabel As System.Windows.Forms.Label
        Dim EMP_NUSULabel As System.Windows.Forms.Label
        Dim EMP_PASSLabel As System.Windows.Forms.Label
        Dim EMP_ESTALabel As System.Windows.Forms.Label
        Dim CAR_CODILabel As System.Windows.Forms.Label
        Dim Emp_modiLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.Ambrosia_proDataSet = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.Em_emplBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Em_emplTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_emplTableAdapter()
        Me.TableAdapterManager = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Em_cargTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_cargTableAdapter()
        Me.Em_tideTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_tideTableAdapter()
        Me.Em_emplBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Em_emplBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TII_CODIListBox = New System.Windows.Forms.ListBox()
        Me.EmtideBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMP_CODITextBox = New System.Windows.Forms.TextBox()
        Me.EMP_NOMBTextBox = New System.Windows.Forms.TextBox()
        Me.EMP_DIRETextBox = New System.Windows.Forms.TextBox()
        Me.EMP_TELETextBox = New System.Windows.Forms.TextBox()
        Me.EMP_NUSUTextBox = New System.Windows.Forms.TextBox()
        Me.EMP_PASSTextBox = New System.Windows.Forms.TextBox()
        Me.EMP_ESTACheckBox = New System.Windows.Forms.CheckBox()
        Me.CAR_CODIListBox = New System.Windows.Forms.ListBox()
        Me.EmcargBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Emp_modiTextBox = New System.Windows.Forms.TextBox()
        Me.FillByIdentificacionToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CodigoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.CodigoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByIdentificacionToolStripButton = New System.Windows.Forms.ToolStripButton()
        TII_CODILabel = New System.Windows.Forms.Label()
        EMP_CODILabel = New System.Windows.Forms.Label()
        EMP_NOMBLabel = New System.Windows.Forms.Label()
        EMP_DIRELabel = New System.Windows.Forms.Label()
        EMP_TELELabel = New System.Windows.Forms.Label()
        EMP_NUSULabel = New System.Windows.Forms.Label()
        EMP_PASSLabel = New System.Windows.Forms.Label()
        EMP_ESTALabel = New System.Windows.Forms.Label()
        CAR_CODILabel = New System.Windows.Forms.Label()
        Emp_modiLabel = New System.Windows.Forms.Label()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_emplBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_emplBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Em_emplBindingNavigator.SuspendLayout()
        CType(Me.EmtideBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmcargBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByIdentificacionToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TII_CODILabel
        '
        TII_CODILabel.AutoSize = True
        TII_CODILabel.Location = New System.Drawing.Point(59, 81)
        TII_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TII_CODILabel.Name = "TII_CODILabel"
        TII_CODILabel.Size = New System.Drawing.Size(146, 17)
        TII_CODILabel.TabIndex = 1
        TII_CODILabel.Text = "Tipo de Identificación:"
        '
        'EMP_CODILabel
        '
        EMP_CODILabel.AutoSize = True
        EMP_CODILabel.Location = New System.Drawing.Point(59, 166)
        EMP_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMP_CODILabel.Name = "EMP_CODILabel"
        EMP_CODILabel.Size = New System.Drawing.Size(168, 17)
        EMP_CODILabel.TabIndex = 3
        EMP_CODILabel.Text = "Número de Identificación:"
        '
        'EMP_NOMBLabel
        '
        EMP_NOMBLabel.AutoSize = True
        EMP_NOMBLabel.Location = New System.Drawing.Point(59, 198)
        EMP_NOMBLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMP_NOMBLabel.Name = "EMP_NOMBLabel"
        EMP_NOMBLabel.Size = New System.Drawing.Size(125, 17)
        EMP_NOMBLabel.TabIndex = 5
        EMP_NOMBLabel.Text = "Nombre Completo:"
        '
        'EMP_DIRELabel
        '
        EMP_DIRELabel.AutoSize = True
        EMP_DIRELabel.Location = New System.Drawing.Point(59, 230)
        EMP_DIRELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMP_DIRELabel.Name = "EMP_DIRELabel"
        EMP_DIRELabel.Size = New System.Drawing.Size(71, 17)
        EMP_DIRELabel.TabIndex = 7
        EMP_DIRELabel.Text = "Dirección:"
        '
        'EMP_TELELabel
        '
        EMP_TELELabel.AutoSize = True
        EMP_TELELabel.Location = New System.Drawing.Point(59, 262)
        EMP_TELELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMP_TELELabel.Name = "EMP_TELELabel"
        EMP_TELELabel.Size = New System.Drawing.Size(68, 17)
        EMP_TELELabel.TabIndex = 9
        EMP_TELELabel.Text = "Telefono:"
        '
        'EMP_NUSULabel
        '
        EMP_NUSULabel.AutoSize = True
        EMP_NUSULabel.Location = New System.Drawing.Point(59, 294)
        EMP_NUSULabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMP_NUSULabel.Name = "EMP_NUSULabel"
        EMP_NUSULabel.Size = New System.Drawing.Size(47, 17)
        EMP_NUSULabel.TabIndex = 11
        EMP_NUSULabel.Text = "Login:"
        '
        'EMP_PASSLabel
        '
        EMP_PASSLabel.AutoSize = True
        EMP_PASSLabel.Location = New System.Drawing.Point(59, 326)
        EMP_PASSLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMP_PASSLabel.Name = "EMP_PASSLabel"
        EMP_PASSLabel.Size = New System.Drawing.Size(85, 17)
        EMP_PASSLabel.TabIndex = 13
        EMP_PASSLabel.Text = "Contraseña:"
        '
        'EMP_ESTALabel
        '
        EMP_ESTALabel.AutoSize = True
        EMP_ESTALabel.Location = New System.Drawing.Point(59, 361)
        EMP_ESTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMP_ESTALabel.Name = "EMP_ESTALabel"
        EMP_ESTALabel.Size = New System.Drawing.Size(56, 17)
        EMP_ESTALabel.TabIndex = 15
        EMP_ESTALabel.Text = "Estado:"
        '
        'CAR_CODILabel
        '
        CAR_CODILabel.AutoSize = True
        CAR_CODILabel.Location = New System.Drawing.Point(59, 391)
        CAR_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CAR_CODILabel.Name = "CAR_CODILabel"
        CAR_CODILabel.Size = New System.Drawing.Size(50, 17)
        CAR_CODILabel.TabIndex = 17
        CAR_CODILabel.Text = "Cargo:"
        '
        'Emp_modiLabel
        '
        Emp_modiLabel.AutoSize = True
        Emp_modiLabel.Location = New System.Drawing.Point(524, 65)
        Emp_modiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Emp_modiLabel.Name = "Emp_modiLabel"
        Emp_modiLabel.Size = New System.Drawing.Size(64, 17)
        Emp_modiLabel.TabIndex = 20
        Emp_modiLabel.Text = "Modificó:"
        '
        'Ambrosia_proDataSet
        '
        Me.Ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.Ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Em_emplBindingSource
        '
        Me.Em_emplBindingSource.DataMember = "em_empl"
        Me.Em_emplBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Em_emplTableAdapter
        '
        Me.Em_emplTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.em_dmodTableAdapter = Nothing
        Me.TableAdapterManager.em_drptTableAdapter = Nothing
        Me.TableAdapterManager.em_dticTableAdapter = Nothing
        Me.TableAdapterManager.em_emplTableAdapter = Me.Em_emplTableAdapter
        Me.TableAdapterManager.em_moacTableAdapter = Nothing
        Me.TableAdapterManager.em_moduTableAdapter = Nothing
        Me.TableAdapterManager.em_paptTableAdapter = Nothing
        Me.TableAdapterManager.em_parkTableAdapter = Nothing
        Me.TableAdapterManager.em_repoTableAdapter = Nothing
        Me.TableAdapterManager.em_tdatTableAdapter = Nothing
        Me.TableAdapterManager.em_tideTableAdapter = Me.Em_tideTableAdapter
        Me.TableAdapterManager.gn_diasTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Em_cargTableAdapter
        '
        Me.Em_cargTableAdapter.ClearBeforeFill = True
        '
        'Em_tideTableAdapter
        '
        Me.Em_tideTableAdapter.ClearBeforeFill = True
        '
        'Em_emplBindingNavigator
        '
        Me.Em_emplBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Em_emplBindingNavigator.BindingSource = Me.Em_emplBindingSource
        Me.Em_emplBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Em_emplBindingNavigator.DeleteItem = Nothing
        Me.Em_emplBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Em_emplBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Em_emplBindingNavigatorSaveItem})
        Me.Em_emplBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Em_emplBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Em_emplBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Em_emplBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Em_emplBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Em_emplBindingNavigator.Name = "Em_emplBindingNavigator"
        Me.Em_emplBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Em_emplBindingNavigator.Size = New System.Drawing.Size(788, 31)
        Me.Em_emplBindingNavigator.TabIndex = 0
        Me.Em_emplBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'Em_emplBindingNavigatorSaveItem
        '
        Me.Em_emplBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Em_emplBindingNavigatorSaveItem.Image = CType(resources.GetObject("Em_emplBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Em_emplBindingNavigatorSaveItem.Name = "Em_emplBindingNavigatorSaveItem"
        Me.Em_emplBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.Em_emplBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TII_CODIListBox
        '
        Me.TII_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Em_emplBindingSource, "TII_CODI", True))
        Me.TII_CODIListBox.DataSource = Me.EmtideBindingSource
        Me.TII_CODIListBox.DisplayMember = "TII_NOMB"
        Me.TII_CODIListBox.FormattingEnabled = True
        Me.TII_CODIListBox.ItemHeight = 16
        Me.TII_CODIListBox.Location = New System.Drawing.Point(235, 81)
        Me.TII_CODIListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TII_CODIListBox.Name = "TII_CODIListBox"
        Me.TII_CODIListBox.Size = New System.Drawing.Size(159, 68)
        Me.TII_CODIListBox.TabIndex = 0
        Me.TII_CODIListBox.ValueMember = "TII_CODI"
        '
        'EmtideBindingSource
        '
        Me.EmtideBindingSource.DataMember = "em_tide"
        Me.EmtideBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'EMP_CODITextBox
        '
        Me.EMP_CODITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_emplBindingSource, "EMP_CODI", True))
        Me.EMP_CODITextBox.Location = New System.Drawing.Point(235, 162)
        Me.EMP_CODITextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EMP_CODITextBox.Name = "EMP_CODITextBox"
        Me.EMP_CODITextBox.Size = New System.Drawing.Size(159, 22)
        Me.EMP_CODITextBox.TabIndex = 1
        '
        'EMP_NOMBTextBox
        '
        Me.EMP_NOMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_emplBindingSource, "EMP_NOMB", True))
        Me.EMP_NOMBTextBox.Location = New System.Drawing.Point(235, 194)
        Me.EMP_NOMBTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EMP_NOMBTextBox.Name = "EMP_NOMBTextBox"
        Me.EMP_NOMBTextBox.Size = New System.Drawing.Size(525, 22)
        Me.EMP_NOMBTextBox.TabIndex = 2
        '
        'EMP_DIRETextBox
        '
        Me.EMP_DIRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_emplBindingSource, "EMP_DIRE", True))
        Me.EMP_DIRETextBox.Location = New System.Drawing.Point(235, 226)
        Me.EMP_DIRETextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EMP_DIRETextBox.Name = "EMP_DIRETextBox"
        Me.EMP_DIRETextBox.Size = New System.Drawing.Size(525, 22)
        Me.EMP_DIRETextBox.TabIndex = 3
        '
        'EMP_TELETextBox
        '
        Me.EMP_TELETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_emplBindingSource, "EMP_TELE", True))
        Me.EMP_TELETextBox.Location = New System.Drawing.Point(235, 258)
        Me.EMP_TELETextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EMP_TELETextBox.Name = "EMP_TELETextBox"
        Me.EMP_TELETextBox.Size = New System.Drawing.Size(159, 22)
        Me.EMP_TELETextBox.TabIndex = 4
        '
        'EMP_NUSUTextBox
        '
        Me.EMP_NUSUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_emplBindingSource, "EMP_NUSU", True))
        Me.EMP_NUSUTextBox.Location = New System.Drawing.Point(235, 290)
        Me.EMP_NUSUTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EMP_NUSUTextBox.Name = "EMP_NUSUTextBox"
        Me.EMP_NUSUTextBox.Size = New System.Drawing.Size(159, 22)
        Me.EMP_NUSUTextBox.TabIndex = 5
        '
        'EMP_PASSTextBox
        '
        Me.EMP_PASSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_emplBindingSource, "EMP_PASS", True))
        Me.EMP_PASSTextBox.Location = New System.Drawing.Point(235, 322)
        Me.EMP_PASSTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EMP_PASSTextBox.Name = "EMP_PASSTextBox"
        Me.EMP_PASSTextBox.ReadOnly = True
        Me.EMP_PASSTextBox.Size = New System.Drawing.Size(159, 22)
        Me.EMP_PASSTextBox.TabIndex = 14
        Me.EMP_PASSTextBox.UseSystemPasswordChar = True
        '
        'EMP_ESTACheckBox
        '
        Me.EMP_ESTACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Em_emplBindingSource, "EMP_ESTA", True))
        Me.EMP_ESTACheckBox.Location = New System.Drawing.Point(235, 354)
        Me.EMP_ESTACheckBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EMP_ESTACheckBox.Name = "EMP_ESTACheckBox"
        Me.EMP_ESTACheckBox.Size = New System.Drawing.Size(160, 30)
        Me.EMP_ESTACheckBox.TabIndex = 7
        Me.EMP_ESTACheckBox.UseVisualStyleBackColor = True
        '
        'CAR_CODIListBox
        '
        Me.CAR_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Em_emplBindingSource, "CAR_CODI", True))
        Me.CAR_CODIListBox.DataSource = Me.EmcargBindingSource
        Me.CAR_CODIListBox.DisplayMember = "CAR_NOMB"
        Me.CAR_CODIListBox.FormattingEnabled = True
        Me.CAR_CODIListBox.ItemHeight = 16
        Me.CAR_CODIListBox.Location = New System.Drawing.Point(235, 391)
        Me.CAR_CODIListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CAR_CODIListBox.Name = "CAR_CODIListBox"
        Me.CAR_CODIListBox.Size = New System.Drawing.Size(159, 68)
        Me.CAR_CODIListBox.TabIndex = 8
        Me.CAR_CODIListBox.ValueMember = "CAR_CODI"
        '
        'EmcargBindingSource
        '
        Me.EmcargBindingSource.DataMember = "em_carg"
        Me.EmcargBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(403, 320)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cambiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Emp_modiTextBox
        '
        Me.Emp_modiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Em_emplBindingSource, "emp_modi", True))
        Me.Emp_modiTextBox.Location = New System.Drawing.Point(605, 62)
        Me.Emp_modiTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Emp_modiTextBox.Name = "Emp_modiTextBox"
        Me.Emp_modiTextBox.ReadOnly = True
        Me.Emp_modiTextBox.Size = New System.Drawing.Size(136, 22)
        Me.Emp_modiTextBox.TabIndex = 21
        '
        'FillByIdentificacionToolStrip
        '
        Me.FillByIdentificacionToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.FillByIdentificacionToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CodigoToolStripLabel, Me.CodigoToolStripTextBox, Me.FillByIdentificacionToolStripButton})
        Me.FillByIdentificacionToolStrip.Location = New System.Drawing.Point(0, 31)
        Me.FillByIdentificacionToolStrip.Name = "FillByIdentificacionToolStrip"
        Me.FillByIdentificacionToolStrip.Size = New System.Drawing.Size(788, 31)
        Me.FillByIdentificacionToolStrip.TabIndex = 22
        Me.FillByIdentificacionToolStrip.Text = "FillByIdentificacionToolStrip"
        '
        'CodigoToolStripLabel
        '
        Me.CodigoToolStripLabel.Name = "CodigoToolStripLabel"
        Me.CodigoToolStripLabel.Size = New System.Drawing.Size(160, 28)
        Me.CodigoToolStripLabel.Text = "Número Identificación:"
        '
        'CodigoToolStripTextBox
        '
        Me.CodigoToolStripTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CodigoToolStripTextBox.Name = "CodigoToolStripTextBox"
        Me.CodigoToolStripTextBox.Size = New System.Drawing.Size(132, 31)
        '
        'FillByIdentificacionToolStripButton
        '
        Me.FillByIdentificacionToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByIdentificacionToolStripButton.Name = "FillByIdentificacionToolStripButton"
        Me.FillByIdentificacionToolStripButton.Size = New System.Drawing.Size(73, 28)
        Me.FillByIdentificacionToolStripButton.Text = "consultar"
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 484)
        Me.Controls.Add(Me.FillByIdentificacionToolStrip)
        Me.Controls.Add(Emp_modiLabel)
        Me.Controls.Add(Me.Emp_modiTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(TII_CODILabel)
        Me.Controls.Add(Me.TII_CODIListBox)
        Me.Controls.Add(EMP_CODILabel)
        Me.Controls.Add(Me.EMP_CODITextBox)
        Me.Controls.Add(EMP_NOMBLabel)
        Me.Controls.Add(Me.EMP_NOMBTextBox)
        Me.Controls.Add(EMP_DIRELabel)
        Me.Controls.Add(Me.EMP_DIRETextBox)
        Me.Controls.Add(EMP_TELELabel)
        Me.Controls.Add(Me.EMP_TELETextBox)
        Me.Controls.Add(EMP_NUSULabel)
        Me.Controls.Add(Me.EMP_NUSUTextBox)
        Me.Controls.Add(EMP_PASSLabel)
        Me.Controls.Add(Me.EMP_PASSTextBox)
        Me.Controls.Add(EMP_ESTALabel)
        Me.Controls.Add(Me.EMP_ESTACheckBox)
        Me.Controls.Add(CAR_CODILabel)
        Me.Controls.Add(Me.CAR_CODIListBox)
        Me.Controls.Add(Me.Em_emplBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_emplBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_emplBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Em_emplBindingNavigator.ResumeLayout(False)
        Me.Em_emplBindingNavigator.PerformLayout()
        CType(Me.EmtideBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmcargBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByIdentificacionToolStrip.ResumeLayout(False)
        Me.FillByIdentificacionToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Em_emplBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_emplTableAdapter As ambrosiapark_proDataSetTableAdapters.em_emplTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Em_emplBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Em_emplBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TII_CODIListBox As System.Windows.Forms.ListBox
    Friend WithEvents EMP_CODITextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMP_NOMBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMP_DIRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMP_TELETextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMP_NUSUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMP_PASSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMP_ESTACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CAR_CODIListBox As System.Windows.Forms.ListBox
    Friend WithEvents Em_tideTableAdapter As ambrosiapark_proDataSetTableAdapters.em_tideTableAdapter
    Friend WithEvents EmtideBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_cargTableAdapter As ambrosiapark_proDataSetTableAdapters.em_cargTableAdapter
    Friend WithEvents EmcargBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Emp_modiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FillByIdentificacionToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CodigoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents CodigoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByIdentificacionToolStripButton As System.Windows.Forms.ToolStripButton
End Class

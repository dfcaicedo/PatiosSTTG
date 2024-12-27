<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servicios
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
        Dim SER_CODILabel As System.Windows.Forms.Label
        Dim TSE_CODILabel As System.Windows.Forms.Label
        Dim SER_FECILabel As System.Windows.Forms.Label
        Dim SER_FECFLabel As System.Windows.Forms.Label
        Dim COMENTARIOLabel As System.Windows.Forms.Label
        Dim USU_CODILabel As System.Windows.Forms.Label
        Dim SER_COSTLabel As System.Windows.Forms.Label
        Dim EMP_NUSULabel As System.Windows.Forms.Label
        Dim SER_ESTALabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servicios))
        Me.Ambrosia_proDataSet = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.Co_servBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Co_servTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.co_servTableAdapter()
        Me.TableAdapterManager = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Co_servBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cl_tipoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SER_CODITextBox = New System.Windows.Forms.TextBox()
        Me.TSE_CODIListBox = New System.Windows.Forms.ListBox()
        Me.CotserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SER_FECIDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SER_FECFDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.COMENTARIOTextBox = New System.Windows.Forms.TextBox()
        Me.USU_CODIListBox = New System.Windows.Forms.ListBox()
        Me.ClientesviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SER_COSTTextBox = New System.Windows.Forms.TextBox()
        Me.EMP_NUSUTextBox = New System.Windows.Forms.TextBox()
        Me.SER_ESTACheckBox = New System.Windows.Forms.CheckBox()
        Me.Co_tserTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Clientes_viewTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.Clientes_viewTableAdapter()
        SER_CODILabel = New System.Windows.Forms.Label()
        TSE_CODILabel = New System.Windows.Forms.Label()
        SER_FECILabel = New System.Windows.Forms.Label()
        SER_FECFLabel = New System.Windows.Forms.Label()
        COMENTARIOLabel = New System.Windows.Forms.Label()
        USU_CODILabel = New System.Windows.Forms.Label()
        SER_COSTLabel = New System.Windows.Forms.Label()
        EMP_NUSULabel = New System.Windows.Forms.Label()
        SER_ESTALabel = New System.Windows.Forms.Label()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_servBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_servBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Co_servBindingNavigator.SuspendLayout()
        CType(Me.CotserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SER_CODILabel
        '
        SER_CODILabel.AutoSize = True
        SER_CODILabel.Location = New System.Drawing.Point(36, 118)
        SER_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SER_CODILabel.Name = "SER_CODILabel"
        SER_CODILabel.Size = New System.Drawing.Size(56, 17)
        SER_CODILabel.TabIndex = 1
        SER_CODILabel.Text = "Código:"
        '
        'TSE_CODILabel
        '
        TSE_CODILabel.AutoSize = True
        TSE_CODILabel.Location = New System.Drawing.Point(36, 146)
        TSE_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TSE_CODILabel.Name = "TSE_CODILabel"
        TSE_CODILabel.Size = New System.Drawing.Size(114, 17)
        TSE_CODILabel.TabIndex = 3
        TSE_CODILabel.Text = "Tipo de Servicio:"
        '
        'SER_FECILabel
        '
        SER_FECILabel.AutoSize = True
        SER_FECILabel.Location = New System.Drawing.Point(36, 228)
        SER_FECILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SER_FECILabel.Name = "SER_FECILabel"
        SER_FECILabel.Size = New System.Drawing.Size(87, 17)
        SER_FECILabel.TabIndex = 5
        SER_FECILabel.Text = "Fecha Inicio:"
        '
        'SER_FECFLabel
        '
        SER_FECFLabel.AutoSize = True
        SER_FECFLabel.Location = New System.Drawing.Point(36, 260)
        SER_FECFLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SER_FECFLabel.Name = "SER_FECFLabel"
        SER_FECFLabel.Size = New System.Drawing.Size(129, 17)
        SER_FECFLabel.TabIndex = 7
        SER_FECFLabel.Text = "Fecha Finalización:"
        '
        'COMENTARIOLabel
        '
        COMENTARIOLabel.AutoSize = True
        COMENTARIOLabel.Location = New System.Drawing.Point(36, 290)
        COMENTARIOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        COMENTARIOLabel.Name = "COMENTARIOLabel"
        COMENTARIOLabel.Size = New System.Drawing.Size(91, 17)
        COMENTARIOLabel.TabIndex = 9
        COMENTARIOLabel.Text = "Comentarios:"
        '
        'USU_CODILabel
        '
        USU_CODILabel.AutoSize = True
        USU_CODILabel.Location = New System.Drawing.Point(36, 351)
        USU_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        USU_CODILabel.Name = "USU_CODILabel"
        USU_CODILabel.Size = New System.Drawing.Size(55, 17)
        USU_CODILabel.TabIndex = 11
        USU_CODILabel.Text = "Cliente:"
        '
        'SER_COSTLabel
        '
        SER_COSTLabel.AutoSize = True
        SER_COSTLabel.Location = New System.Drawing.Point(36, 448)
        SER_COSTLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SER_COSTLabel.Name = "SER_COSTLabel"
        SER_COSTLabel.Size = New System.Drawing.Size(48, 17)
        SER_COSTLabel.TabIndex = 13
        SER_COSTLabel.Text = "Costo:"
        '
        'EMP_NUSULabel
        '
        EMP_NUSULabel.AutoSize = True
        EMP_NUSULabel.Location = New System.Drawing.Point(597, 75)
        EMP_NUSULabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMP_NUSULabel.Name = "EMP_NUSULabel"
        EMP_NUSULabel.Size = New System.Drawing.Size(64, 17)
        EMP_NUSULabel.TabIndex = 15
        EMP_NUSULabel.Text = "Modifico:"
        '
        'SER_ESTALabel
        '
        SER_ESTALabel.AutoSize = True
        SER_ESTALabel.Location = New System.Drawing.Point(36, 492)
        SER_ESTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SER_ESTALabel.Name = "SER_ESTALabel"
        SER_ESTALabel.Size = New System.Drawing.Size(50, 17)
        SER_ESTALabel.TabIndex = 17
        SER_ESTALabel.Text = "Activo:"
        '
        'Ambrosia_proDataSet
        '
        Me.Ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.Ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Co_servBindingSource
        '
        Me.Co_servBindingSource.DataMember = "co_serv"
        Me.Co_servBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Co_servTableAdapter
        '
        Me.Co_servTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.co_servTableAdapter = Me.Co_servTableAdapter
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
        Me.TableAdapterManager.em_tideTableAdapter = Nothing
        Me.TableAdapterManager.gn_diasTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Co_servBindingNavigator
        '
        Me.Co_servBindingNavigator.AddNewItem = Nothing
        Me.Co_servBindingNavigator.BindingSource = Me.Co_servBindingSource
        Me.Co_servBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Co_servBindingNavigator.DeleteItem = Nothing
        Me.Co_servBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Co_servBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Cl_tipoBindingNavigatorSaveItem})
        Me.Co_servBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Co_servBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Co_servBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Co_servBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Co_servBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Co_servBindingNavigator.Name = "Co_servBindingNavigator"
        Me.Co_servBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Co_servBindingNavigator.Size = New System.Drawing.Size(925, 27)
        Me.Co_servBindingNavigator.TabIndex = 0
        Me.Co_servBindingNavigator.Text = "BindingNavigator1"
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
        'Cl_tipoBindingNavigatorSaveItem
        '
        Me.Cl_tipoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cl_tipoBindingNavigatorSaveItem.Image = CType(resources.GetObject("Cl_tipoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Cl_tipoBindingNavigatorSaveItem.Name = "Cl_tipoBindingNavigatorSaveItem"
        Me.Cl_tipoBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Cl_tipoBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'SER_CODITextBox
        '
        Me.SER_CODITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_servBindingSource, "SER_CODI", True))
        Me.SER_CODITextBox.Enabled = False
        Me.SER_CODITextBox.Location = New System.Drawing.Point(175, 114)
        Me.SER_CODITextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SER_CODITextBox.Name = "SER_CODITextBox"
        Me.SER_CODITextBox.ReadOnly = True
        Me.SER_CODITextBox.Size = New System.Drawing.Size(265, 22)
        Me.SER_CODITextBox.TabIndex = 2
        '
        'TSE_CODIListBox
        '
        Me.TSE_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Co_servBindingSource, "TSE_CODI", True))
        Me.TSE_CODIListBox.DataSource = Me.CotserBindingSource
        Me.TSE_CODIListBox.DisplayMember = "TSE_NOMB"
        Me.TSE_CODIListBox.Enabled = False
        Me.TSE_CODIListBox.FormattingEnabled = True
        Me.TSE_CODIListBox.ItemHeight = 16
        Me.TSE_CODIListBox.Location = New System.Drawing.Point(175, 146)
        Me.TSE_CODIListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TSE_CODIListBox.Name = "TSE_CODIListBox"
        Me.TSE_CODIListBox.Size = New System.Drawing.Size(265, 68)
        Me.TSE_CODIListBox.TabIndex = 4
        Me.TSE_CODIListBox.ValueMember = "TSE_CODI"
        '
        'CotserBindingSource
        '
        Me.CotserBindingSource.DataMember = "co_tser"
        Me.CotserBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'SER_FECIDateTimePicker
        '
        Me.SER_FECIDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Co_servBindingSource, "SER_FECI", True))
        Me.SER_FECIDateTimePicker.Enabled = False
        Me.SER_FECIDateTimePicker.Location = New System.Drawing.Point(175, 223)
        Me.SER_FECIDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.SER_FECIDateTimePicker.Name = "SER_FECIDateTimePicker"
        Me.SER_FECIDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.SER_FECIDateTimePicker.TabIndex = 6
        '
        'SER_FECFDateTimePicker
        '
        Me.SER_FECFDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Co_servBindingSource, "SER_FECF", True))
        Me.SER_FECFDateTimePicker.Enabled = False
        Me.SER_FECFDateTimePicker.Location = New System.Drawing.Point(175, 255)
        Me.SER_FECFDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.SER_FECFDateTimePicker.Name = "SER_FECFDateTimePicker"
        Me.SER_FECFDateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.SER_FECFDateTimePicker.TabIndex = 8
        '
        'COMENTARIOTextBox
        '
        Me.COMENTARIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_servBindingSource, "COMENTARIO", True))
        Me.COMENTARIOTextBox.Enabled = False
        Me.COMENTARIOTextBox.Location = New System.Drawing.Point(175, 287)
        Me.COMENTARIOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.COMENTARIOTextBox.Multiline = True
        Me.COMENTARIOTextBox.Name = "COMENTARIOTextBox"
        Me.COMENTARIOTextBox.Size = New System.Drawing.Size(265, 56)
        Me.COMENTARIOTextBox.TabIndex = 10
        '
        'USU_CODIListBox
        '
        Me.USU_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Co_servBindingSource, "USU_CODI", True))
        Me.USU_CODIListBox.DataSource = Me.ClientesviewBindingSource
        Me.USU_CODIListBox.DisplayMember = "Mostrar"
        Me.USU_CODIListBox.Enabled = False
        Me.USU_CODIListBox.FormattingEnabled = True
        Me.USU_CODIListBox.ItemHeight = 16
        Me.USU_CODIListBox.Location = New System.Drawing.Point(175, 351)
        Me.USU_CODIListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.USU_CODIListBox.Name = "USU_CODIListBox"
        Me.USU_CODIListBox.Size = New System.Drawing.Size(265, 84)
        Me.USU_CODIListBox.TabIndex = 12
        Me.USU_CODIListBox.ValueMember = "USU_CONT"
        '
        'ClientesviewBindingSource
        '
        Me.ClientesviewBindingSource.DataMember = "Clientes_view"
        Me.ClientesviewBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'SER_COSTTextBox
        '
        Me.SER_COSTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_servBindingSource, "SER_COST", True))
        Me.SER_COSTTextBox.Enabled = False
        Me.SER_COSTTextBox.Location = New System.Drawing.Point(175, 444)
        Me.SER_COSTTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SER_COSTTextBox.Name = "SER_COSTTextBox"
        Me.SER_COSTTextBox.ReadOnly = True
        Me.SER_COSTTextBox.Size = New System.Drawing.Size(265, 22)
        Me.SER_COSTTextBox.TabIndex = 14
        '
        'EMP_NUSUTextBox
        '
        Me.EMP_NUSUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_servBindingSource, "EMP_NUSU", True))
        Me.EMP_NUSUTextBox.Location = New System.Drawing.Point(716, 71)
        Me.EMP_NUSUTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.EMP_NUSUTextBox.Name = "EMP_NUSUTextBox"
        Me.EMP_NUSUTextBox.ReadOnly = True
        Me.EMP_NUSUTextBox.Size = New System.Drawing.Size(116, 22)
        Me.EMP_NUSUTextBox.TabIndex = 16
        '
        'SER_ESTACheckBox
        '
        Me.SER_ESTACheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Co_servBindingSource, "SER_ESTA", True))
        Me.SER_ESTACheckBox.Enabled = False
        Me.SER_ESTACheckBox.Location = New System.Drawing.Point(175, 486)
        Me.SER_ESTACheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SER_ESTACheckBox.Name = "SER_ESTACheckBox"
        Me.SER_ESTACheckBox.Size = New System.Drawing.Size(139, 30)
        Me.SER_ESTACheckBox.TabIndex = 18
        Me.SER_ESTACheckBox.UseVisualStyleBackColor = True
        '
        'Co_tserTableAdapter
        '
        Me.Co_tserTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 27)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(925, 27)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(137, 24)
        Me.ToolStripLabel1.Text = "Documento Cliente"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(132, 27)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(75, 24)
        Me.ToolStripButton1.Text = "Consultar"
        '
        'Clientes_viewTableAdapter
        '
        Me.Clientes_viewTableAdapter.ClearBeforeFill = True
        '
        'Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 624)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(SER_ESTALabel)
        Me.Controls.Add(Me.SER_ESTACheckBox)
        Me.Controls.Add(SER_CODILabel)
        Me.Controls.Add(Me.SER_CODITextBox)
        Me.Controls.Add(TSE_CODILabel)
        Me.Controls.Add(Me.TSE_CODIListBox)
        Me.Controls.Add(SER_FECILabel)
        Me.Controls.Add(Me.SER_FECIDateTimePicker)
        Me.Controls.Add(SER_FECFLabel)
        Me.Controls.Add(Me.SER_FECFDateTimePicker)
        Me.Controls.Add(COMENTARIOLabel)
        Me.Controls.Add(Me.COMENTARIOTextBox)
        Me.Controls.Add(USU_CODILabel)
        Me.Controls.Add(Me.USU_CODIListBox)
        Me.Controls.Add(SER_COSTLabel)
        Me.Controls.Add(Me.SER_COSTTextBox)
        Me.Controls.Add(EMP_NUSULabel)
        Me.Controls.Add(Me.EMP_NUSUTextBox)
        Me.Controls.Add(Me.Co_servBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Servicios"
        Me.Text = "Servicios Activos"
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_servBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_servBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Co_servBindingNavigator.ResumeLayout(False)
        Me.Co_servBindingNavigator.PerformLayout()
        CType(Me.CotserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Co_servBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_servTableAdapter As ambrosiapark_proDataSetTableAdapters.co_servTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Co_servBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SER_CODITextBox As System.Windows.Forms.TextBox
    Friend WithEvents TSE_CODIListBox As System.Windows.Forms.ListBox
    Friend WithEvents SER_FECIDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SER_FECFDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents COMENTARIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents USU_CODIListBox As System.Windows.Forms.ListBox
    Friend WithEvents SER_COSTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMP_NUSUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientesviewBindingSource As System.Windows.Forms.BindingSource
    '  Friend WithEvents Clientes_viewTableAdapter As AmbrosiaPark_Pro.ambrosiapark_proDataSetTableAdapters.Clientes_viewTableAdapter
    Friend WithEvents SER_ESTACheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CotserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_tserTableAdapter As ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Cl_tipoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Clientes_viewTableAdapter As ambrosiapark_proDataSetTableAdapters.Clientes_viewTableAdapter
End Class

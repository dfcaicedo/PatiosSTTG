<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada
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
        Dim ENT_CODILabel As System.Windows.Forms.Label
        Dim USU_CONTLabel As System.Windows.Forms.Label
        Dim ENT_ENTRLabel As System.Windows.Forms.Label
        Dim ENT_PLACLabel As System.Windows.Forms.Label
        Dim TSE_CODILabel As System.Windows.Forms.Label
        Dim TIV_CODILabel As System.Windows.Forms.Label
        Dim ENT_COMMLabel As System.Windows.Forms.Label
        Dim AUD_NUSULabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrada))
        Me.Ambrosia_proDataSet = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.Co_entrBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Co_entrTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.co_entrTableAdapter()
        Me.TableAdapterManager = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Cl_usuaTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter()
        Me.Co_tserTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter()
        Me.Vh_tiposTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter()
        Me.Co_entrBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Co_entrBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ENT_CODITextBox = New System.Windows.Forms.TextBox()
        Me.USU_CONTListBox = New System.Windows.Forms.ListBox()
        Me.ClusuaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENT_ENTRDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ENT_PLACTextBox = New System.Windows.Forms.TextBox()
        Me.TSE_CODIListBox = New System.Windows.Forms.ListBox()
        Me.CotserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIV_CODIListBox = New System.Windows.Forms.ListBox()
        Me.VhtiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ENT_COMMTextBox = New System.Windows.Forms.TextBox()
        Me.AUD_NUSUTextBox = New System.Windows.Forms.TextBox()
        ENT_CODILabel = New System.Windows.Forms.Label()
        USU_CONTLabel = New System.Windows.Forms.Label()
        ENT_ENTRLabel = New System.Windows.Forms.Label()
        ENT_PLACLabel = New System.Windows.Forms.Label()
        TSE_CODILabel = New System.Windows.Forms.Label()
        TIV_CODILabel = New System.Windows.Forms.Label()
        ENT_COMMLabel = New System.Windows.Forms.Label()
        AUD_NUSULabel = New System.Windows.Forms.Label()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_entrBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_entrBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Co_entrBindingNavigator.SuspendLayout()
        CType(Me.ClusuaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VhtiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ENT_CODILabel
        '
        ENT_CODILabel.AutoSize = True
        ENT_CODILabel.Location = New System.Drawing.Point(33, 59)
        ENT_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ENT_CODILabel.Name = "ENT_CODILabel"
        ENT_CODILabel.Size = New System.Drawing.Size(52, 17)
        ENT_CODILabel.TabIndex = 1
        ENT_CODILabel.Text = "Código"
        '
        'USU_CONTLabel
        '
        USU_CONTLabel.AutoSize = True
        USU_CONTLabel.Location = New System.Drawing.Point(33, 87)
        USU_CONTLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        USU_CONTLabel.Name = "USU_CONTLabel"
        USU_CONTLabel.Size = New System.Drawing.Size(55, 17)
        USU_CONTLabel.TabIndex = 3
        USU_CONTLabel.Text = "Cliente:"
        '
        'ENT_ENTRLabel
        '
        ENT_ENTRLabel.AutoSize = True
        ENT_ENTRLabel.Location = New System.Drawing.Point(33, 218)
        ENT_ENTRLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ENT_ENTRLabel.Name = "ENT_ENTRLabel"
        ENT_ENTRLabel.Size = New System.Drawing.Size(101, 17)
        ENT_ENTRLabel.TabIndex = 5
        ENT_ENTRLabel.Text = "Fecha Entrada"
        '
        'ENT_PLACLabel
        '
        ENT_PLACLabel.AutoSize = True
        ENT_PLACLabel.Location = New System.Drawing.Point(33, 249)
        ENT_PLACLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ENT_PLACLabel.Name = "ENT_PLACLabel"
        ENT_PLACLabel.Size = New System.Drawing.Size(43, 17)
        ENT_PLACLabel.TabIndex = 7
        ENT_PLACLabel.Text = "Placa"
        '
        'TSE_CODILabel
        '
        TSE_CODILabel.AutoSize = True
        TSE_CODILabel.Location = New System.Drawing.Point(33, 277)
        TSE_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TSE_CODILabel.Name = "TSE_CODILabel"
        TSE_CODILabel.Size = New System.Drawing.Size(110, 17)
        TSE_CODILabel.TabIndex = 9
        TSE_CODILabel.Text = "Tipo de Servicio"
        '
        'TIV_CODILabel
        '
        TIV_CODILabel.AutoSize = True
        TIV_CODILabel.Location = New System.Drawing.Point(33, 402)
        TIV_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIV_CODILabel.Name = "TIV_CODILabel"
        TIV_CODILabel.Size = New System.Drawing.Size(94, 17)
        TIV_CODILabel.TabIndex = 11
        TIV_CODILabel.Text = "Tipo Vehiculo"
        '
        'ENT_COMMLabel
        '
        ENT_COMMLabel.AutoSize = True
        ENT_COMMLabel.Location = New System.Drawing.Point(33, 471)
        ENT_COMMLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ENT_COMMLabel.Name = "ENT_COMMLabel"
        ENT_COMMLabel.Size = New System.Drawing.Size(87, 17)
        ENT_COMMLabel.TabIndex = 13
        ENT_COMMLabel.Text = "Comentarios"
        '
        'AUD_NUSULabel
        '
        AUD_NUSULabel.AutoSize = True
        AUD_NUSULabel.Location = New System.Drawing.Point(513, 48)
        AUD_NUSULabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AUD_NUSULabel.Name = "AUD_NUSULabel"
        AUD_NUSULabel.Size = New System.Drawing.Size(64, 17)
        AUD_NUSULabel.TabIndex = 15
        AUD_NUSULabel.Text = "Modificó:"
        '
        'Ambrosia_proDataSet
        '
        Me.Ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.Ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Co_entrBindingSource
        '
        Me.Co_entrBindingSource.DataMember = "co_entr"
        Me.Co_entrBindingSource.DataSource = Me.Ambrosia_proDataSet
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
        Me.Co_entrBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Co_entrBindingNavigator.DeleteItem = Nothing
        Me.Co_entrBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Co_entrBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.Co_entrBindingNavigatorSaveItem})
        Me.Co_entrBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Co_entrBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Co_entrBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Co_entrBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Co_entrBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Co_entrBindingNavigator.Name = "Co_entrBindingNavigator"
        Me.Co_entrBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Co_entrBindingNavigator.Size = New System.Drawing.Size(748, 31)
        Me.Co_entrBindingNavigator.TabIndex = 0
        Me.Co_entrBindingNavigator.Text = "BindingNavigator1"
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
        'Co_entrBindingNavigatorSaveItem
        '
        Me.Co_entrBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Co_entrBindingNavigatorSaveItem.Image = CType(resources.GetObject("Co_entrBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Co_entrBindingNavigatorSaveItem.Name = "Co_entrBindingNavigatorSaveItem"
        Me.Co_entrBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.Co_entrBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ENT_CODITextBox
        '
        Me.ENT_CODITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_entrBindingSource, "ENT_CODI", True))
        Me.ENT_CODITextBox.Location = New System.Drawing.Point(155, 55)
        Me.ENT_CODITextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ENT_CODITextBox.Name = "ENT_CODITextBox"
        Me.ENT_CODITextBox.ReadOnly = True
        Me.ENT_CODITextBox.Size = New System.Drawing.Size(252, 22)
        Me.ENT_CODITextBox.TabIndex = 2
        '
        'USU_CONTListBox
        '
        Me.USU_CONTListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Co_entrBindingSource, "USU_CONT", True))
        Me.USU_CONTListBox.DataSource = Me.ClusuaBindingSource
        Me.USU_CONTListBox.DisplayMember = "USU_NOMB"
        Me.USU_CONTListBox.FormattingEnabled = True
        Me.USU_CONTListBox.ItemHeight = 16
        Me.USU_CONTListBox.Location = New System.Drawing.Point(155, 87)
        Me.USU_CONTListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.USU_CONTListBox.Name = "USU_CONTListBox"
        Me.USU_CONTListBox.Size = New System.Drawing.Size(565, 116)
        Me.USU_CONTListBox.TabIndex = 4
        Me.USU_CONTListBox.ValueMember = "USU_CONT"
        '
        'ClusuaBindingSource
        '
        Me.ClusuaBindingSource.DataMember = "cl_usua"
        Me.ClusuaBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'ENT_ENTRDateTimePicker
        '
        Me.ENT_ENTRDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Co_entrBindingSource, "ENT_ENTR", True))
        Me.ENT_ENTRDateTimePicker.Enabled = False
        Me.ENT_ENTRDateTimePicker.Location = New System.Drawing.Point(155, 213)
        Me.ENT_ENTRDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ENT_ENTRDateTimePicker.Name = "ENT_ENTRDateTimePicker"
        Me.ENT_ENTRDateTimePicker.Size = New System.Drawing.Size(407, 22)
        Me.ENT_ENTRDateTimePicker.TabIndex = 6
        '
        'ENT_PLACTextBox
        '
        Me.ENT_PLACTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_entrBindingSource, "ENT_PLAC", True))
        Me.ENT_PLACTextBox.Location = New System.Drawing.Point(155, 245)
        Me.ENT_PLACTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ENT_PLACTextBox.Name = "ENT_PLACTextBox"
        Me.ENT_PLACTextBox.Size = New System.Drawing.Size(252, 22)
        Me.ENT_PLACTextBox.TabIndex = 8
        '
        'TSE_CODIListBox
        '
        Me.TSE_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Co_entrBindingSource, "TSE_CODI", True))
        Me.TSE_CODIListBox.DataSource = Me.CotserBindingSource
        Me.TSE_CODIListBox.DisplayMember = "TSE_NOMB"
        Me.TSE_CODIListBox.FormattingEnabled = True
        Me.TSE_CODIListBox.ItemHeight = 16
        Me.TSE_CODIListBox.Location = New System.Drawing.Point(155, 277)
        Me.TSE_CODIListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TSE_CODIListBox.Name = "TSE_CODIListBox"
        Me.TSE_CODIListBox.Size = New System.Drawing.Size(252, 116)
        Me.TSE_CODIListBox.TabIndex = 10
        Me.TSE_CODIListBox.ValueMember = "TSE_CODI"
        '
        'CotserBindingSource
        '
        Me.CotserBindingSource.DataMember = "co_tser"
        Me.CotserBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'TIV_CODIListBox
        '
        Me.TIV_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Co_entrBindingSource, "TIV_CODI", True))
        Me.TIV_CODIListBox.DataSource = Me.VhtiposBindingSource
        Me.TIV_CODIListBox.DisplayMember = "TIV_NOMB"
        Me.TIV_CODIListBox.FormattingEnabled = True
        Me.TIV_CODIListBox.ItemHeight = 16
        Me.TIV_CODIListBox.Location = New System.Drawing.Point(155, 402)
        Me.TIV_CODIListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TIV_CODIListBox.Name = "TIV_CODIListBox"
        Me.TIV_CODIListBox.Size = New System.Drawing.Size(252, 52)
        Me.TIV_CODIListBox.TabIndex = 12
        Me.TIV_CODIListBox.ValueMember = "TIV_CODI"
        '
        'VhtiposBindingSource
        '
        Me.VhtiposBindingSource.DataMember = "vh_tipos"
        Me.VhtiposBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'ENT_COMMTextBox
        '
        Me.ENT_COMMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_entrBindingSource, "ENT_COMM", True))
        Me.ENT_COMMTextBox.Location = New System.Drawing.Point(155, 468)
        Me.ENT_COMMTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ENT_COMMTextBox.Multiline = True
        Me.ENT_COMMTextBox.Name = "ENT_COMMTextBox"
        Me.ENT_COMMTextBox.Size = New System.Drawing.Size(407, 132)
        Me.ENT_COMMTextBox.TabIndex = 14
        '
        'AUD_NUSUTextBox
        '
        Me.AUD_NUSUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Co_entrBindingSource, "AUD_NUSU", True))
        Me.AUD_NUSUTextBox.Location = New System.Drawing.Point(588, 44)
        Me.AUD_NUSUTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AUD_NUSUTextBox.Name = "AUD_NUSUTextBox"
        Me.AUD_NUSUTextBox.ReadOnly = True
        Me.AUD_NUSUTextBox.Size = New System.Drawing.Size(132, 22)
        Me.AUD_NUSUTextBox.TabIndex = 18
        '
        'Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 631)
        Me.Controls.Add(Me.AUD_NUSUTextBox)
        Me.Controls.Add(AUD_NUSULabel)
        Me.Controls.Add(ENT_COMMLabel)
        Me.Controls.Add(Me.ENT_COMMTextBox)
        Me.Controls.Add(ENT_CODILabel)
        Me.Controls.Add(Me.ENT_CODITextBox)
        Me.Controls.Add(USU_CONTLabel)
        Me.Controls.Add(Me.USU_CONTListBox)
        Me.Controls.Add(ENT_ENTRLabel)
        Me.Controls.Add(Me.ENT_ENTRDateTimePicker)
        Me.Controls.Add(ENT_PLACLabel)
        Me.Controls.Add(Me.ENT_PLACTextBox)
        Me.Controls.Add(TSE_CODILabel)
        Me.Controls.Add(Me.TSE_CODIListBox)
        Me.Controls.Add(TIV_CODILabel)
        Me.Controls.Add(Me.TIV_CODIListBox)
        Me.Controls.Add(Me.Co_entrBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Entrada"
        Me.Text = "Entrada"
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Co_entrBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_entrTableAdapter As ambrosiapark_proDataSetTableAdapters.co_entrTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Co_entrBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Co_entrBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ENT_CODITextBox As System.Windows.Forms.TextBox
    Friend WithEvents USU_CONTListBox As System.Windows.Forms.ListBox
    Friend WithEvents ENT_ENTRDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ENT_PLACTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TSE_CODIListBox As System.Windows.Forms.ListBox
    Friend WithEvents TIV_CODIListBox As System.Windows.Forms.ListBox
    Friend WithEvents Cl_usuaTableAdapter As ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter
    Friend WithEvents ClusuaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_tserTableAdapter As ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter
    Friend WithEvents CotserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vh_tiposTableAdapter As ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter
    Friend WithEvents VhtiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ENT_COMMTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AUD_NUSUTextBox As System.Windows.Forms.TextBox
End Class

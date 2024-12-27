<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_de_Vehiculos
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
        Dim TIV_CODILabel As System.Windows.Forms.Label
        Dim TIV_NOMBLabel As System.Windows.Forms.Label
        Dim EMP_NUSULabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo_de_Vehiculos))
        Me.Ambrosia_proDataSet = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.Vh_tiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vh_tiposTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter()
        Me.TableAdapterManager = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Vh_tiposBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Vh_tiposBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TIV_CODITextBox = New System.Windows.Forms.TextBox()
        Me.TIV_NOMBTextBox = New System.Windows.Forms.TextBox()
        Me.EMP_NUSUTextBox = New System.Windows.Forms.TextBox()
        Me.Vh_espeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vh_espeTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.vh_espeTableAdapter()
        Me.Vh_espeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        TIV_CODILabel = New System.Windows.Forms.Label()
        TIV_NOMBLabel = New System.Windows.Forms.Label()
        EMP_NUSULabel = New System.Windows.Forms.Label()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vh_tiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vh_tiposBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vh_tiposBindingNavigator.SuspendLayout()
        CType(Me.Vh_espeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vh_espeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TIV_CODILabel
        '
        TIV_CODILabel.AutoSize = True
        TIV_CODILabel.Location = New System.Drawing.Point(45, 69)
        TIV_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIV_CODILabel.Name = "TIV_CODILabel"
        TIV_CODILabel.Size = New System.Drawing.Size(56, 17)
        TIV_CODILabel.TabIndex = 1
        TIV_CODILabel.Text = "Código:"
        '
        'TIV_NOMBLabel
        '
        TIV_NOMBLabel.AutoSize = True
        TIV_NOMBLabel.Location = New System.Drawing.Point(45, 101)
        TIV_NOMBLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TIV_NOMBLabel.Name = "TIV_NOMBLabel"
        TIV_NOMBLabel.Size = New System.Drawing.Size(86, 17)
        TIV_NOMBLabel.TabIndex = 3
        TIV_NOMBLabel.Text = "Descripción:"
        '
        'EMP_NUSULabel
        '
        EMP_NUSULabel.AutoSize = True
        EMP_NUSULabel.Location = New System.Drawing.Point(383, 31)
        EMP_NUSULabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EMP_NUSULabel.Name = "EMP_NUSULabel"
        EMP_NUSULabel.Size = New System.Drawing.Size(105, 17)
        EMP_NUSULabel.TabIndex = 5
        EMP_NUSULabel.Text = "Modificado por:"
        '
        'Ambrosia_proDataSet
        '
        Me.Ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.Ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vh_tiposBindingSource
        '
        Me.Vh_tiposBindingSource.DataMember = "vh_tipos"
        Me.Vh_tiposBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Vh_tiposTableAdapter
        '
        Me.Vh_tiposTableAdapter.ClearBeforeFill = True
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
        'Vh_tiposBindingNavigator
        '
        Me.Vh_tiposBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Vh_tiposBindingNavigator.BindingSource = Me.Vh_tiposBindingSource
        Me.Vh_tiposBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Vh_tiposBindingNavigator.DeleteItem = Nothing
        Me.Vh_tiposBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Vh_tiposBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Vh_tiposBindingNavigatorSaveItem})
        Me.Vh_tiposBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Vh_tiposBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Vh_tiposBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Vh_tiposBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Vh_tiposBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Vh_tiposBindingNavigator.Name = "Vh_tiposBindingNavigator"
        Me.Vh_tiposBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Vh_tiposBindingNavigator.Size = New System.Drawing.Size(653, 31)
        Me.Vh_tiposBindingNavigator.TabIndex = 0
        Me.Vh_tiposBindingNavigator.Text = "BindingNavigator1"
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
        'Vh_tiposBindingNavigatorSaveItem
        '
        Me.Vh_tiposBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Vh_tiposBindingNavigatorSaveItem.Image = CType(resources.GetObject("Vh_tiposBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Vh_tiposBindingNavigatorSaveItem.Name = "Vh_tiposBindingNavigatorSaveItem"
        Me.Vh_tiposBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.Vh_tiposBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TIV_CODITextBox
        '
        Me.TIV_CODITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vh_tiposBindingSource, "TIV_CODI", True))
        Me.TIV_CODITextBox.Location = New System.Drawing.Point(143, 65)
        Me.TIV_CODITextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TIV_CODITextBox.Name = "TIV_CODITextBox"
        Me.TIV_CODITextBox.ReadOnly = True
        Me.TIV_CODITextBox.Size = New System.Drawing.Size(132, 22)
        Me.TIV_CODITextBox.TabIndex = 2
        '
        'TIV_NOMBTextBox
        '
        Me.TIV_NOMBTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vh_tiposBindingSource, "TIV_NOMB", True))
        Me.TIV_NOMBTextBox.Location = New System.Drawing.Point(143, 97)
        Me.TIV_NOMBTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TIV_NOMBTextBox.Name = "TIV_NOMBTextBox"
        Me.TIV_NOMBTextBox.Size = New System.Drawing.Size(132, 22)
        Me.TIV_NOMBTextBox.TabIndex = 4
        '
        'EMP_NUSUTextBox
        '
        Me.EMP_NUSUTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vh_tiposBindingSource, "EMP_NUSU", True))
        Me.EMP_NUSUTextBox.Location = New System.Drawing.Point(493, 27)
        Me.EMP_NUSUTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EMP_NUSUTextBox.Name = "EMP_NUSUTextBox"
        Me.EMP_NUSUTextBox.ReadOnly = True
        Me.EMP_NUSUTextBox.Size = New System.Drawing.Size(132, 22)
        Me.EMP_NUSUTextBox.TabIndex = 6
        '
        'Vh_espeBindingSource
        '
        Me.Vh_espeBindingSource.DataMember = "VH_ESPE_IBFK_1"
        Me.Vh_espeBindingSource.DataSource = Me.Vh_tiposBindingSource
        '
        'Vh_espeTableAdapter
        '
        Me.Vh_espeTableAdapter.ClearBeforeFill = True
        '
        'Vh_espeDataGridView
        '
        Me.Vh_espeDataGridView.AutoGenerateColumns = False
        Me.Vh_espeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Vh_espeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Vh_espeDataGridView.DataSource = Me.Vh_espeBindingSource
        Me.Vh_espeDataGridView.Location = New System.Drawing.Point(40, 145)
        Me.Vh_espeDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Vh_espeDataGridView.Name = "Vh_espeDataGridView"
        Me.Vh_espeDataGridView.RowHeadersWidth = 51
        Me.Vh_espeDataGridView.Size = New System.Drawing.Size(587, 353)
        Me.Vh_espeDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TIV_CODI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TIV_CODI"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ESP_DESC"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Definición"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ToolTipText = "Se debe poner la letra A si se recibe una letra y el signo # si es un número"
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
        'Tipo_de_Vehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 513)
        Me.Controls.Add(Me.Vh_espeDataGridView)
        Me.Controls.Add(TIV_CODILabel)
        Me.Controls.Add(Me.TIV_CODITextBox)
        Me.Controls.Add(TIV_NOMBLabel)
        Me.Controls.Add(Me.TIV_NOMBTextBox)
        Me.Controls.Add(EMP_NUSULabel)
        Me.Controls.Add(Me.EMP_NUSUTextBox)
        Me.Controls.Add(Me.Vh_tiposBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Tipo_de_Vehiculos"
        Me.Text = "Tipo_de_Vehiculos"
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vh_tiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vh_tiposBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vh_tiposBindingNavigator.ResumeLayout(False)
        Me.Vh_tiposBindingNavigator.PerformLayout()
        CType(Me.Vh_espeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vh_espeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Vh_tiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vh_tiposTableAdapter As ambrosiapark_proDataSetTableAdapters.vh_tiposTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Vh_tiposBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Vh_tiposBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TIV_CODITextBox As System.Windows.Forms.TextBox
    Friend WithEvents TIV_NOMBTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EMP_NUSUTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vh_espeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vh_espeTableAdapter As ambrosiapark_proDataSetTableAdapters.vh_espeTableAdapter
    Friend WithEvents Vh_espeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

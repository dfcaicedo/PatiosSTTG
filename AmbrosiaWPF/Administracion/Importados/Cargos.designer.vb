<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cargos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cargos))
        Me.Em_cargBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Em_cargBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ambrosia_proDataSet = New AmbrosiaWPF.ambrosiapark_proDataSet()
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
        Me.Em_cargDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Em_cargTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_cargTableAdapter()
        Me.TableAdapterManager = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        CType(Me.Em_cargBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Em_cargBindingNavigator.SuspendLayout()
        CType(Me.Em_cargBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Em_cargDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Em_cargBindingNavigator
        '
        Me.Em_cargBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Em_cargBindingNavigator.BindingSource = Me.Em_cargBindingSource
        Me.Em_cargBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Em_cargBindingNavigator.DeleteItem = Nothing
        Me.Em_cargBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Em_cargBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Em_cargBindingNavigatorSaveItem})
        Me.Em_cargBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Em_cargBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Em_cargBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Em_cargBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Em_cargBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Em_cargBindingNavigator.Name = "Em_cargBindingNavigator"
        Me.Em_cargBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Em_cargBindingNavigator.Size = New System.Drawing.Size(716, 31)
        Me.Em_cargBindingNavigator.TabIndex = 0
        Me.Em_cargBindingNavigator.Text = "BindingNavigator1"
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
        'Em_cargBindingSource
        '
        Me.Em_cargBindingSource.DataMember = "em_carg"
        Me.Em_cargBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Ambrosia_proDataSet
        '
        Me.Ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.Ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Em_cargBindingNavigatorSaveItem
        '
        Me.Em_cargBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Em_cargBindingNavigatorSaveItem.Image = CType(resources.GetObject("Em_cargBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Em_cargBindingNavigatorSaveItem.Name = "Em_cargBindingNavigatorSaveItem"
        Me.Em_cargBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.Em_cargBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Em_cargDataGridView
        '
        Me.Em_cargDataGridView.AutoGenerateColumns = False
        Me.Em_cargDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Em_cargDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Em_cargDataGridView.DataSource = Me.Em_cargBindingSource
        Me.Em_cargDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Em_cargDataGridView.Location = New System.Drawing.Point(0, 31)
        Me.Em_cargDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Em_cargDataGridView.Name = "Em_cargDataGridView"
        Me.Em_cargDataGridView.RowHeadersWidth = 51
        Me.Em_cargDataGridView.Size = New System.Drawing.Size(716, 305)
        Me.Em_cargDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CAR_CODI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CAR_NOMB"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
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
        'Cargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 336)
        Me.Controls.Add(Me.Em_cargDataGridView)
        Me.Controls.Add(Me.Em_cargBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Cargos"
        Me.Text = "Cargos"
        CType(Me.Em_cargBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Em_cargBindingNavigator.ResumeLayout(False)
        Me.Em_cargBindingNavigator.PerformLayout()
        CType(Me.Em_cargBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Em_cargDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Em_cargBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_cargTableAdapter As ambrosiapark_proDataSetTableAdapters.em_cargTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Em_cargBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Em_cargBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Em_cargDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

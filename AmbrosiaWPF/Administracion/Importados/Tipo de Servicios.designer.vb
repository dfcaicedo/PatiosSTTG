<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_de_Servicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo_de_Servicios))
        Me.Co_tserBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Co_tserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Co_tserBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Co_tserDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmparkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Co_tserTableAdapter = New ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter()
        Me.TableAdapterManager = New ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Em_parkTableAdapter = New ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tse_tgrac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tse_defau = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Co_tserBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Co_tserBindingNavigator.SuspendLayout()
        CType(Me.Co_tserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Co_tserDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmparkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Co_tserBindingNavigator
        '
        Me.Co_tserBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Co_tserBindingNavigator.BindingSource = Me.Co_tserBindingSource
        Me.Co_tserBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Co_tserBindingNavigator.DeleteItem = Nothing
        Me.Co_tserBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Co_tserBindingNavigatorSaveItem})
        Me.Co_tserBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Co_tserBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Co_tserBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Co_tserBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Co_tserBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Co_tserBindingNavigator.Name = "Co_tserBindingNavigator"
        Me.Co_tserBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Co_tserBindingNavigator.Size = New System.Drawing.Size(586, 25)
        Me.Co_tserBindingNavigator.TabIndex = 0
        Me.Co_tserBindingNavigator.Text = "BindingNavigator1"
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
        'Co_tserBindingSource
        '
        Me.Co_tserBindingSource.DataMember = "co_tser"
        Me.Co_tserBindingSource.DataSource = Me.ambrosia_proDataSet
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
        'Co_tserBindingNavigatorSaveItem
        '
        Me.Co_tserBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Co_tserBindingNavigatorSaveItem.Image = CType(resources.GetObject("Co_tserBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Co_tserBindingNavigatorSaveItem.Name = "Co_tserBindingNavigatorSaveItem"
        Me.Co_tserBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Co_tserBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Co_tserDataGridView
        '
        Me.Co_tserDataGridView.AllowUserToDeleteRows = False
        Me.Co_tserDataGridView.AutoGenerateColumns = False
        Me.Co_tserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Co_tserDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.tse_tgrac, Me.tse_defau, Me.DataGridViewTextBoxColumn4})
        Me.Co_tserDataGridView.DataSource = Me.Co_tserBindingSource
        Me.Co_tserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Co_tserDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.Co_tserDataGridView.Name = "Co_tserDataGridView"
        Me.Co_tserDataGridView.Size = New System.Drawing.Size(586, 346)
        Me.Co_tserDataGridView.TabIndex = 1
        '
        'EmparkBindingSource
        '
        Me.EmparkBindingSource.DataMember = "em_park"
        Me.EmparkBindingSource.DataSource = Me.ambrosia_proDataSet
        '
        'Co_tserTableAdapter
        '
        Me.Co_tserTableAdapter.ClearBeforeFill = True
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

        Me.TableAdapterManager.co_tserTableAdapter = Me.Co_tserTableAdapter
        Me.TableAdapterManager.co_tvalaTableAdapter = Nothing
        Me.TableAdapterManager.co_valadiTableAdapter = Nothing
        Me.TableAdapterManager.em_capaTableAdapter = Nothing
        Me.TableAdapterManager.em_cargTableAdapter = Nothing
        Me.TableAdapterManager.em_datenTableAdapter = Nothing
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
        Me.TableAdapterManager.gn_diasTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Em_parkTableAdapter
        '
        Me.Em_parkTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TSE_CODI"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TSE_NOMB"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'tse_tgrac
        '
        Me.tse_tgrac.DataPropertyName = "tse_tgrac"
        Me.tse_tgrac.HeaderText = "Tiempo Gracia"
        Me.tse_tgrac.Name = "tse_tgrac"
        '
        'tse_defau
        '
        Me.tse_defau.DataPropertyName = "tse_defau"
        Me.tse_defau.FalseValue = "false"
        Me.tse_defau.HeaderText = "por Defecto"
        Me.tse_defau.IndeterminateValue = "false"
        Me.tse_defau.Name = "tse_defau"
        Me.tse_defau.TrueValue = "true"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "EMP_NUSU"
        Me.DataGridViewTextBoxColumn4.HeaderText = "EMP_NUSU"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'Tipo_de_Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 371)
        Me.Controls.Add(Me.Co_tserDataGridView)
        Me.Controls.Add(Me.Co_tserBindingNavigator)
        Me.Name = "Tipo_de_Servicios"
        Me.Text = "Tipo_de_Servicios"
        CType(Me.Co_tserBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Co_tserBindingNavigator.ResumeLayout(False)
        Me.Co_tserBindingNavigator.PerformLayout()
        CType(Me.Co_tserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Co_tserDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmparkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Co_tserBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Co_tserTableAdapter As ambrosiapark_proDataSetTableAdapters.co_tserTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Co_tserBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Co_tserBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Co_tserDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents EmparkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Em_parkTableAdapter As ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tse_tgrac As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tse_defau As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

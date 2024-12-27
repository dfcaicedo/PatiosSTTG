<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreacionServicios1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Cl_usuaDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClientesviewBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cl_usuaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ambrosia_proDataSet = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ClientesviewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cl_usuaTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter()
        Me.TableAdapterManager = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Clientes_viewTableAdapter1 = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.Clientes_viewTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.Cl_usuaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesviewBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cl_usuaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesviewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 29)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selección de Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Documento de Identidad"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(215, 53)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 22)
        Me.TextBox1.TabIndex = 5
        '
        'Cl_usuaDataGridView
        '
        Me.Cl_usuaDataGridView.AutoGenerateColumns = False
        Me.Cl_usuaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cl_usuaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1})
        Me.Cl_usuaDataGridView.DataSource = Me.Cl_usuaBindingSource
        Me.Cl_usuaDataGridView.Location = New System.Drawing.Point(25, 106)
        Me.Cl_usuaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.Cl_usuaDataGridView.Name = "Cl_usuaDataGridView"
        Me.Cl_usuaDataGridView.RowHeadersWidth = 51
        Me.Cl_usuaDataGridView.Size = New System.Drawing.Size(633, 268)
        Me.Cl_usuaDataGridView.TabIndex = 5
        '
        'ClientesviewBindingSource1
        '
        Me.ClientesviewBindingSource1.DataMember = "Clientes_view"
        '
        'Cl_usuaBindingSource
        '
        Me.Cl_usuaBindingSource.DataMember = "cl_usua"
        Me.Cl_usuaBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Ambrosia_proDataSet
        '
        Me.Ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.Ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(456, 50)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ClientesviewBindingSource
        '
        Me.ClientesviewBindingSource.DataMember = "Clientes_view"
        Me.ClientesviewBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Cl_usuaTableAdapter
        '
        Me.Cl_usuaTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Clientes_viewTableAdapter1
        '
        Me.Clientes_viewTableAdapter1.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "USU_CONT"
        Me.DataGridViewTextBoxColumn1.DataSource = Me.ClientesviewBindingSource
        Me.DataGridViewTextBoxColumn1.DisplayMember = "Mostrar"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Clientes"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn1.ValueMember = "USU_CONT"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Seleccionar"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.Width = 125
        '
        'CreacionServicios1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 388)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cl_usuaDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CreacionServicios1"
        Me.Text = "CreacionServicios1"
        CType(Me.Cl_usuaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesviewBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cl_usuaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesviewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents ClientesviewBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents Clientes_viewTableAdapter As AmbrosiaPark_Pro.ambrosiapark_proDataSetTableAdapters.Clientes_viewTableAdapter
    Friend WithEvents Cl_usuaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cl_usuaTableAdapter As ambrosiapark_proDataSetTableAdapters.cl_usuaTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Cl_usuaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ClientesviewBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Clientes_viewTableAdapter1 As ambrosiapark_proDataSetTableAdapters.Clientes_viewTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column1 As Forms.DataGridViewButtonColumn
End Class

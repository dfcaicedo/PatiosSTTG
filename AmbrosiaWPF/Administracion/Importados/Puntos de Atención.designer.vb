<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puntos_de_Atención
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
        Dim PAT_CONTLabel As System.Windows.Forms.Label
        Dim PAR_CODILabel As System.Windows.Forms.Label
        Dim PAT_DESCLabel As System.Windows.Forms.Label
        Dim PAT_EQUILabel As System.Windows.Forms.Label
        Dim USU_CODILabel As System.Windows.Forms.Label
        Dim Pat_nodbcLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Puntos_de_Atención))
        Me.Ambrosia_proDataSet = New AmbrosiaWPF.ambrosiapark_proDataSet()
        Me.Gn_patenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Gn_patenTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.gn_patenTableAdapter()
        Me.TableAdapterManager = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager()
        Me.Em_parkTableAdapter = New AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter()
        Me.Gn_patenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Gn_patenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PAT_CONTTextBox = New System.Windows.Forms.TextBox()
        Me.PAR_CODIListBox = New System.Windows.Forms.ListBox()
        Me.EmparkBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PAT_DESCTextBox = New System.Windows.Forms.TextBox()
        Me.PAT_EQUITextBox = New System.Windows.Forms.TextBox()
        Me.USU_CODITextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Pat_nodbcTextBox = New System.Windows.Forms.TextBox()
        PAT_CONTLabel = New System.Windows.Forms.Label()
        PAR_CODILabel = New System.Windows.Forms.Label()
        PAT_DESCLabel = New System.Windows.Forms.Label()
        PAT_EQUILabel = New System.Windows.Forms.Label()
        USU_CODILabel = New System.Windows.Forms.Label()
        Pat_nodbcLabel = New System.Windows.Forms.Label()
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gn_patenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gn_patenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gn_patenBindingNavigator.SuspendLayout()
        CType(Me.EmparkBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PAT_CONTLabel
        '
        PAT_CONTLabel.AutoSize = True
        PAT_CONTLabel.Location = New System.Drawing.Point(48, 79)
        PAT_CONTLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PAT_CONTLabel.Name = "PAT_CONTLabel"
        PAT_CONTLabel.Size = New System.Drawing.Size(56, 17)
        PAT_CONTLabel.TabIndex = 1
        PAT_CONTLabel.Text = "Código:"
        '
        'PAR_CODILabel
        '
        PAR_CODILabel.AutoSize = True
        PAR_CODILabel.Location = New System.Drawing.Point(48, 107)
        PAR_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PAR_CODILabel.Name = "PAR_CODILabel"
        PAR_CODILabel.Size = New System.Drawing.Size(95, 17)
        PAR_CODILabel.TabIndex = 3
        PAR_CODILabel.Text = "Parqueadero:"
        '
        'PAT_DESCLabel
        '
        PAT_DESCLabel.AutoSize = True
        PAT_DESCLabel.Location = New System.Drawing.Point(48, 236)
        PAT_DESCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PAT_DESCLabel.Name = "PAT_DESCLabel"
        PAT_DESCLabel.Size = New System.Drawing.Size(74, 17)
        PAT_DESCLabel.TabIndex = 5
        PAT_DESCLabel.Text = "Ubicación:"
        '
        'PAT_EQUILabel
        '
        PAT_EQUILabel.AutoSize = True
        PAT_EQUILabel.Location = New System.Drawing.Point(48, 268)
        PAT_EQUILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PAT_EQUILabel.Name = "PAT_EQUILabel"
        PAT_EQUILabel.Size = New System.Drawing.Size(56, 17)
        PAT_EQUILabel.TabIndex = 7
        PAT_EQUILabel.Text = "Equipo:"
        '
        'USU_CODILabel
        '
        USU_CODILabel.AutoSize = True
        USU_CODILabel.Location = New System.Drawing.Point(415, 31)
        USU_CODILabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        USU_CODILabel.Name = "USU_CODILabel"
        USU_CODILabel.Size = New System.Drawing.Size(80, 17)
        USU_CODILabel.TabIndex = 9
        USU_CODILabel.Text = "Modificado:"
        '
        'Pat_nodbcLabel
        '
        Pat_nodbcLabel.AutoSize = True
        Pat_nodbcLabel.Location = New System.Drawing.Point(48, 304)
        Pat_nodbcLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Pat_nodbcLabel.Name = "Pat_nodbcLabel"
        Pat_nodbcLabel.Size = New System.Drawing.Size(101, 17)
        Pat_nodbcLabel.TabIndex = 12
        Pat_nodbcLabel.Text = "Nombre ODBC"
        Pat_nodbcLabel.Visible = False
        '
        'Ambrosia_proDataSet
        '
        Me.Ambrosia_proDataSet.DataSetName = "ambrosia_proDataSet"
        Me.Ambrosia_proDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Gn_patenBindingSource
        '
        Me.Gn_patenBindingSource.DataMember = "gn_paten"
        Me.Gn_patenBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'Gn_patenTableAdapter
        '
        Me.Gn_patenTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.em_parkTableAdapter = Me.Em_parkTableAdapter
        Me.TableAdapterManager.em_repoTableAdapter = Nothing
        Me.TableAdapterManager.em_tdatTableAdapter = Nothing
        Me.TableAdapterManager.em_tideTableAdapter = Nothing
        Me.TableAdapterManager.gn_diasTableAdapter = Nothing
        Me.TableAdapterManager.gn_patenTableAdapter = Me.Gn_patenTableAdapter
        Me.TableAdapterManager.UpdateOrder = AmbrosiaWPF.ambrosiapark_proDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vh_espeTableAdapter = Nothing
        Me.TableAdapterManager.vh_tiposTableAdapter = Nothing
        '
        'Em_parkTableAdapter
        '
        Me.Em_parkTableAdapter.ClearBeforeFill = True
        '
        'Gn_patenBindingNavigator
        '
        Me.Gn_patenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Gn_patenBindingNavigator.BindingSource = Me.Gn_patenBindingSource
        Me.Gn_patenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Gn_patenBindingNavigator.DeleteItem = Nothing
        Me.Gn_patenBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Gn_patenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.Gn_patenBindingNavigatorSaveItem})
        Me.Gn_patenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Gn_patenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Gn_patenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Gn_patenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Gn_patenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Gn_patenBindingNavigator.Name = "Gn_patenBindingNavigator"
        Me.Gn_patenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Gn_patenBindingNavigator.Size = New System.Drawing.Size(701, 27)
        Me.Gn_patenBindingNavigator.TabIndex = 4
        Me.Gn_patenBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'Gn_patenBindingNavigatorSaveItem
        '
        Me.Gn_patenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Gn_patenBindingNavigatorSaveItem.Image = CType(resources.GetObject("Gn_patenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Gn_patenBindingNavigatorSaveItem.Name = "Gn_patenBindingNavigatorSaveItem"
        Me.Gn_patenBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Gn_patenBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PAT_CONTTextBox
        '
        Me.PAT_CONTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gn_patenBindingSource, "PAT_CONT", True))
        Me.PAT_CONTTextBox.Location = New System.Drawing.Point(163, 79)
        Me.PAT_CONTTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PAT_CONTTextBox.Name = "PAT_CONTTextBox"
        Me.PAT_CONTTextBox.ReadOnly = True
        Me.PAT_CONTTextBox.Size = New System.Drawing.Size(159, 22)
        Me.PAT_CONTTextBox.TabIndex = 0
        '
        'PAR_CODIListBox
        '
        Me.PAR_CODIListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Gn_patenBindingSource, "PAR_CODI", True))
        Me.PAR_CODIListBox.DataSource = Me.EmparkBindingSource
        Me.PAR_CODIListBox.DisplayMember = "PAR_NOMB"
        Me.PAR_CODIListBox.FormattingEnabled = True
        Me.PAR_CODIListBox.ItemHeight = 16
        Me.PAR_CODIListBox.Location = New System.Drawing.Point(163, 111)
        Me.PAR_CODIListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PAR_CODIListBox.Name = "PAR_CODIListBox"
        Me.PAR_CODIListBox.Size = New System.Drawing.Size(159, 116)
        Me.PAR_CODIListBox.TabIndex = 1
        Me.PAR_CODIListBox.ValueMember = "PAR_CODI"
        '
        'EmparkBindingSource
        '
        Me.EmparkBindingSource.DataMember = "em_park"
        Me.EmparkBindingSource.DataSource = Me.Ambrosia_proDataSet
        '
        'PAT_DESCTextBox
        '
        Me.PAT_DESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gn_patenBindingSource, "PAT_DESC", True))
        Me.PAT_DESCTextBox.Location = New System.Drawing.Point(163, 236)
        Me.PAT_DESCTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PAT_DESCTextBox.Name = "PAT_DESCTextBox"
        Me.PAT_DESCTextBox.Size = New System.Drawing.Size(159, 22)
        Me.PAT_DESCTextBox.TabIndex = 2
        '
        'PAT_EQUITextBox
        '
        Me.PAT_EQUITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gn_patenBindingSource, "PAT_EQUI", True))
        Me.PAT_EQUITextBox.Location = New System.Drawing.Point(163, 268)
        Me.PAT_EQUITextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PAT_EQUITextBox.Name = "PAT_EQUITextBox"
        Me.PAT_EQUITextBox.ReadOnly = True
        Me.PAT_EQUITextBox.Size = New System.Drawing.Size(159, 22)
        Me.PAT_EQUITextBox.TabIndex = 8
        '
        'USU_CODITextBox
        '
        Me.USU_CODITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gn_patenBindingSource, "USU_CODI", True))
        Me.USU_CODITextBox.Location = New System.Drawing.Point(515, 31)
        Me.USU_CODITextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.USU_CODITextBox.Name = "USU_CODITextBox"
        Me.USU_CODITextBox.ReadOnly = True
        Me.USU_CODITextBox.Size = New System.Drawing.Size(159, 22)
        Me.USU_CODITextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 266)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Pat_nodbcTextBox
        '
        Me.Pat_nodbcTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Gn_patenBindingSource, "pat_nodbc", True))
        Me.Pat_nodbcTextBox.Location = New System.Drawing.Point(163, 300)
        Me.Pat_nodbcTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Pat_nodbcTextBox.Name = "Pat_nodbcTextBox"
        Me.Pat_nodbcTextBox.Size = New System.Drawing.Size(132, 22)
        Me.Pat_nodbcTextBox.TabIndex = 13
        Me.Pat_nodbcTextBox.Visible = False
        '
        'Puntos_de_Atención
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 406)
        Me.Controls.Add(Pat_nodbcLabel)
        Me.Controls.Add(Me.Pat_nodbcTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PAT_CONTLabel)
        Me.Controls.Add(Me.PAT_CONTTextBox)
        Me.Controls.Add(PAR_CODILabel)
        Me.Controls.Add(Me.PAR_CODIListBox)
        Me.Controls.Add(PAT_DESCLabel)
        Me.Controls.Add(Me.PAT_DESCTextBox)
        Me.Controls.Add(PAT_EQUILabel)
        Me.Controls.Add(Me.PAT_EQUITextBox)
        Me.Controls.Add(USU_CODILabel)
        Me.Controls.Add(Me.USU_CODITextBox)
        Me.Controls.Add(Me.Gn_patenBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Puntos_de_Atención"
        Me.Text = "Puntos_de_Atención"
        CType(Me.Ambrosia_proDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gn_patenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gn_patenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gn_patenBindingNavigator.ResumeLayout(False)
        Me.Gn_patenBindingNavigator.PerformLayout()
        CType(Me.EmparkBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ambrosia_proDataSet As ambrosiapark_proDataSet
    Friend WithEvents Gn_patenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Gn_patenTableAdapter As ambrosiapark_proDataSetTableAdapters.gn_patenTableAdapter
    Friend WithEvents TableAdapterManager As ambrosiapark_proDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Gn_patenBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Gn_patenBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PAT_CONTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAR_CODIListBox As System.Windows.Forms.ListBox
    Friend WithEvents PAT_DESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PAT_EQUITextBox As System.Windows.Forms.TextBox
    Friend WithEvents USU_CODITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Em_parkTableAdapter As ambrosiapark_proDataSetTableAdapters.em_parkTableAdapter
    Friend WithEvents EmparkBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Pat_nodbcTextBox As System.Windows.Forms.TextBox
End Class

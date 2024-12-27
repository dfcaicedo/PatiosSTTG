Imports System.Windows.Forms
Public Class Clientes
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Cl_usvhTableAdapter.Connection = db.getconnection
        Me.Cl_tipoTableAdapter.Connection = db.getconnection
        Me.Em_tideTableAdapter.Connection = db.getconnection
        Me.Cl_usuaTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Cl_usuaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Cl_usuaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Cl_usuaBindingSource.EndEdit()
        Me.Cl_usuaTableAdapter.Update(Me.Ambrosia_proDataSet.cl_usua)
        Me.Cl_usvhTableAdapter.Update(Me.Ambrosia_proDataSet.cl_usvh)

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_usvh' Puede moverla o quitarla según sea necesario.
        Me.Ambrosia_proDataSet.EnforceConstraints = False
        Me.Cl_usvhTableAdapter.FillBy(Me.Ambrosia_proDataSet.cl_usvh)
        Me.Ambrosia_proDataSet.cl_usvh.EMP_NUSUColumn.DefaultValue = Me.user
        Me.Ambrosia_proDataSet.cl_usvh.USV_FACTColumn.DefaultValue = (New db).getvalue("select now() from dual")
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Fill(Me.Ambrosia_proDataSet.cl_tipo)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_tide' Puede moverla o quitarla según sea necesario.
        Me.Em_tideTableAdapter.Fill(Me.Ambrosia_proDataSet.em_tide)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_usua' Puede moverla o quitarla según sea necesario.
        Me.Cl_usuaTableAdapter.Fill(Me.Ambrosia_proDataSet.cl_usua)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.Cl_usuaTableAdapter.FillBy(Me.Ambrosia_proDataSet.cl_usua, DocumentoToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Cl_usvhDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Cl_usvhDataGridView.CellContentClick
        If e.ColumnIndex = 4 Then
            If Cl_usvhDataGridView.Item(4, e.RowIndex).Value = True Then
                Cl_usvhDataGridView.Item(3, e.RowIndex).Value = (New db).getvalue("select now() from dual")
            Else
                Cl_usvhDataGridView.Item(3, e.RowIndex).Value = ""
            End If
            Cl_usvhDataGridView.Item(4, e.RowIndex).Value = Not Cl_usvhDataGridView.Item(4, e.RowIndex).Value
        End If

    End Sub

    Private Sub Cl_usvhDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Cl_usvhDataGridView.CellEndEdit
        If e.ColumnIndex = 1 Then
            Me.Cl_usvhDataGridView.Item(5, e.RowIndex).Value = Me.user
            Dim placa As String = Me.Cl_usvhDataGridView.Item(1, e.RowIndex).Value.ToString.ToUpper.Replace(" ", "")
            Me.Cl_usvhDataGridView.Item(1, e.RowIndex).Value = placa
            Dim db As New db
            If 0 <> db.getvalue("select count(*) from cl_usvh where usv_placa=@placa and usv_acti=1", "@placa", placa) Then
                MsgBox("La placa aparece como activa en otro usuario, por favor revisar")
                Me.Cl_usvhDataGridView.Item(1, e.RowIndex).Value = ""
            End If
        End If
    End Sub

    Private Sub USU_CODITextBox_TextChanged(sender As Object, e As EventArgs) Handles USU_CODITextBox.TextChanged, TIC_CODIListBox.SelectedIndexChanged, USU_NOMBTextBox.TextChanged, USU_DIRETextBox.TextChanged, USU_TELETextBox.TextChanged, TIC_CODIListBox.SelectedIndexChanged, USU_DEFACheckBox.CheckedChanged, USU_CARTECheckBox.CheckedChanged
        Me.EMP_NUSUTextBox.Text = Me.user

    End Sub

    Private Sub FillByPlacaToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByPlacaToolStripButton.Click
        Try
            Me.Cl_usuaTableAdapter.FillByPlaca(Me.Ambrosia_proDataSet.cl_usua, PlacaToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
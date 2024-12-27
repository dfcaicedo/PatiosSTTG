Imports System.Windows.Forms
Public Class Tipo_de_Vehiculos
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Vh_espeTableAdapter.Connection = db.getconnection
        Me.Vh_tiposTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Vh_tiposBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Vh_tiposBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Vh_tiposBindingSource.EndEdit()
        Me.Vh_tiposTableAdapter.Update(Me.Ambrosia_proDataSet.vh_tipos)
        Me.Vh_espeTableAdapter.Update(Me.Ambrosia_proDataSet.vh_espe)
        '  Me.TableAdapterManager.UpdateAll(Me.ambrosia_proDataSet)

    End Sub

    Private Sub Tipo_de_Vehiculos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.vh_espe' Puede moverla o quitarla según sea necesario.
        Me.Vh_espeTableAdapter.Fill(Me.Ambrosia_proDataSet.vh_espe)
        Me.Ambrosia_proDataSet.vh_espe.EMP_NUSUColumn.DefaultValue = Me.user
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.vh_tipos' Puede moverla o quitarla según sea necesario.
        Me.Vh_tiposTableAdapter.Fill(Me.Ambrosia_proDataSet.vh_tipos)
        Me.Ambrosia_proDataSet.vh_tipos.EMP_NUSUColumn.DefaultValue = Me.user

    End Sub

    Private Sub TIV_NOMBTextBox_TextChanged(sender As Object, e As EventArgs) Handles TIV_NOMBTextBox.TextChanged
        Me.EMP_NUSUTextBox.Text = Me.user
    End Sub

    Private Sub Vh_espeDataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Vh_espeDataGridView.CellBeginEdit
        If e.ColumnIndex = 1 Then
            Vh_espeDataGridView.Item(2, e.RowIndex).Value = Me.user
        End If
    End Sub

    Private Sub Vh_espeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Vh_espeDataGridView.CellContentClick

    End Sub
End Class
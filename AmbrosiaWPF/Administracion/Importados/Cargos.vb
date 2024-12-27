Imports System.Windows.Forms
Public Class Cargos
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Em_cargTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Em_cargBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Em_cargBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Em_cargBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub Cargos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_carg' Puede moverla o quitarla según sea necesario.
        Me.Ambrosia_proDataSet.em_carg.EMP_NUSUColumn.DefaultValue = Me.user
        Me.Em_cargTableAdapter.Fill(Me.Ambrosia_proDataSet.em_carg)

    End Sub

    Private Sub Em_cargDataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Em_cargDataGridView.CellBeginEdit
        If e.ColumnIndex = 1 Then
            Em_cargDataGridView.Item(2, e.RowIndex).Value = Me.user
        End If
    End Sub

End Class
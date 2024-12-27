Imports System.Windows.Forms
Public Class TipoValoresAdicionales
    Dim user As String

    Public Sub New(user As String)
        Me.user = user
        Dim db As New db
        Me.InitializeComponent()
        Me.Co_tvalaTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Co_tvalaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Co_tvalaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Co_tvalaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub TipoValoresAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_tvala' Puede moverla o quitarla según sea necesario.
        Me.Co_tvalaTableAdapter.Fill(Me.Ambrosia_proDataSet.co_tvala)
        Me.Ambrosia_proDataSet.co_tvala.EMP_NUSUColumn.DefaultValue = Me.user

    End Sub

    Private Sub Co_tvalaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Co_tvalaDataGridView.CellContentClick

    End Sub

    Private Sub Co_tvalaDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Co_tvalaDataGridView.CellEndEdit
        Me.Co_tvalaDataGridView.Item(Co_tvalaDataGridView.ColumnCount - 1, e.RowIndex).Value = Me.user
    End Sub
End Class
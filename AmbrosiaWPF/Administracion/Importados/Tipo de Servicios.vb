Imports System.Windows.Forms

Public Class Tipo_de_Servicios
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Em_parkTableAdapter.Connection = db.getconnection
        Me.Co_tserTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Co_tserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Co_tserBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Co_tserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub Tipo_de_Servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moverla o quitarla según sea necesario.
        Me.Em_parkTableAdapter.Fill(Me.Ambrosia_proDataSet.em_park)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_tser' Puede moverla o quitarla según sea necesario.
        Me.Co_tserTableAdapter.Fill(Me.Ambrosia_proDataSet.co_tser)
        Me.Ambrosia_proDataSet.co_tser.EMP_NUSUColumn.DefaultValue = Me.user
    End Sub

    Private Sub Co_tserDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Co_tserDataGridView.CellContentClick

    End Sub

    Private Sub Co_tserDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Co_tserDataGridView.CellEndEdit
        If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Then
            Me.Co_tserDataGridView.Item(Me.Co_tserDataGridView.ColumnCount - 1, e.RowIndex).Value = Me.user
        End If
    End Sub
End Class
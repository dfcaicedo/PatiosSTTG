Imports System.Windows.Forms
Public Class Capacidad
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Dim db As New db
        Me.user = user
        Me.Vh_tiposTableAdapter.Connection = db.getconnection
        Em_capaTableAdapter.Connection = db.getconnection
        Em_parkTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Em_parkBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Em_parkBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Em_parkBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub Capacidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.vh_tipos' Puede moverla o quitarla según sea necesario.
        Me.Vh_tiposTableAdapter.Fill(Me.Ambrosia_proDataSet.vh_tipos)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_capa' Puede moverla o quitarla según sea necesario.
        Me.Em_capaTableAdapter.Fill(Me.Ambrosia_proDataSet.em_capa)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moverla o quitarla según sea necesario.
        Me.Em_parkTableAdapter.Fill(Me.Ambrosia_proDataSet.em_park)
        Me.Ambrosia_proDataSet.em_capa.emp_nusuColumn.DefaultValue = Me.user
    End Sub



    Private Sub Em_capaDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Em_capaDataGridView.CellEndEdit
        Try
            Me.Em_capaDataGridView.Item(Em_capaDataGridView.ColumnCount - 1, e.RowIndex).Value = Me.user
        Catch ex As Exception

        End Try
    End Sub
End Class
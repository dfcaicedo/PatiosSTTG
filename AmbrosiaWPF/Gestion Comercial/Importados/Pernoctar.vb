Imports System.Windows.forms
Public Class Pernoctar
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Vh_tiposTableAdapter.Connection = db.getconnection
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Connection = db.getconnection
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_dcmax' Puede moverla o quitarla según sea necesario.
        Me.Co_dcmaxTableAdapter.Connection = db.getconnection
    End Sub

    Private Sub Co_dcmaxBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Co_dcmaxBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Co_dcmaxBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub Pernoctar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.vh_tipos' Puede moverla o quitarla según sea necesario.
        Me.Vh_tiposTableAdapter.Fill(Me.Ambrosia_proDataSet.vh_tipos)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Fill(Me.Ambrosia_proDataSet.cl_tipo)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_dcmax' Puede moverla o quitarla según sea necesario.
        Me.Co_dcmaxTableAdapter.Fill(Me.Ambrosia_proDataSet.co_dcmax)
        Me.Ambrosia_proDataSet.co_dcmax.EMP_NUSUColumn.DefaultValue = Me.user

    End Sub

    Private Sub Co_dcmaxDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Co_dcmaxDataGridView.CellContentClick

    End Sub

    Private Sub Co_dcmaxDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Co_dcmaxDataGridView.CellEndEdit
        Select Case e.ColumnIndex
            Case 1, 2, 3, 4
                Me.Co_dcmaxDataGridView.Item(5, e.RowIndex).Value = Me.user
        End Select
    End Sub
End Class
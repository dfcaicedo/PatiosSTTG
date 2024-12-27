Imports System.Windows.Forms
Public Class confpernoctar
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Dim db As New db
        Me.Vh_tiposTableAdapter.Connection = db.getconnection
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Connection = db.getconnection
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moverla o quitarla según sea necesario.
        Me.Em_parkTableAdapter.Connection = db.getconnection
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_dpern' Puede moverla o quitarla según sea necesario.
        Me.Co_dpernTableAdapter.Connection = db.getconnection
        Me.user = user
    End Sub
    Private Sub Co_dpernBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Co_dpernBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Co_dpernBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub confpernoctar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.vh_tipos' Puede moverla o quitarla según sea necesario.
        Me.Vh_tiposTableAdapter.Fill(Me.Ambrosia_proDataSet.vh_tipos)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Fill(Me.Ambrosia_proDataSet.cl_tipo)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moverla o quitarla según sea necesario.
        Me.Em_parkTableAdapter.Fill(Me.Ambrosia_proDataSet.em_park)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_dpern' Puede moverla o quitarla según sea necesario.
        Me.Co_dpernTableAdapter.Fill(Me.Ambrosia_proDataSet.co_dpern)
        Me.Ambrosia_proDataSet.co_dpern.EMP_NUSUColumn.DefaultValue = Me.user

    End Sub

    Private Sub Co_dpernDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Co_dpernDataGridView.CellContentClick

    End Sub

    Private Sub Co_dpernDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Co_dpernDataGridView.CellEndEdit
        Select Case e.ColumnIndex
            Case 1, 2, 3, 4, 6
                Co_dpernDataGridView.Item(5, e.RowIndex).Value = Me.user
        End Select
    End Sub
End Class
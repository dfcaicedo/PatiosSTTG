Imports System.Windows.Forms
Public Class RegistrodeTarifas
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Co_tserTableAdapter.Connection = db.getconnection
        Me.Vh_tiposTableAdapter.Connection = db.getconnection
        Me.Cl_tipoTableAdapter.Connection = db.getconnection
        Me.Co_tariTableAdapter.Connection = db.getconnection
        Me.Em_parkTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Em_parkBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Em_parkBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Em_parkBindingSource.EndEdit()
        Me.Co_tariTableAdapter.Update(Me.Ambrosia_proDataSet.co_tari)

    End Sub

    Private Sub RegistrodeTarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_tser' Puede moverla o quitarla según sea necesario.
        Me.Co_tserTableAdapter.Fill(Me.Ambrosia_proDataSet.co_tser)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.vh_tipos' Puede moverla o quitarla según sea necesario.
        Me.Vh_tiposTableAdapter.Fill(Me.Ambrosia_proDataSet.vh_tipos)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Fill(Me.Ambrosia_proDataSet.cl_tipo)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_tari' Puede moverla o quitarla según sea necesario.
        Me.Co_tariTableAdapter.Fill(Me.Ambrosia_proDataSet.co_tari)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moverla o quitarla según sea necesario.
        Me.Em_parkTableAdapter.Fill(Me.Ambrosia_proDataSet.em_park)

    End Sub

    Private Sub Co_tariDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Co_tariDataGridView.CellContentClick

    End Sub

    Private Sub Co_tariDataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles Co_tariDataGridView.CellEndEdit
        Me.Co_tariDataGridView.Item(Co_tariDataGridView.ColumnCount - 1, e.RowIndex).Value = Me.user
    End Sub
End Class
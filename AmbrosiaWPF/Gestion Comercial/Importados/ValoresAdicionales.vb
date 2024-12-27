Imports System.Windows.Forms

Public Class ValoresAdicionales
    Dim user As String
    Public Sub New(user As String)
        Me.user = user
        Me.InitializeComponent()
        Dim db As New db
        Me.Em_parkTableAdapter.Connection = db.getconnection
        Me.Co_valadiTableAdapter.Connection = db.getconnection
        Me.Co_tvalaTableAdapter.Connection = db.getconnection
    End Sub

    Private Sub Co_tvalaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Co_tvalaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Co_tvalaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub ValoresAdicionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moverla o quitarla según sea necesario.
        Me.Em_parkTableAdapter.Fill(Me.Ambrosia_proDataSet.em_park)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_valadi' Puede moverla o quitarla según sea necesario.
        Me.Co_valadiTableAdapter.Fill(Me.Ambrosia_proDataSet.co_valadi)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_tvala' Puede moverla o quitarla según sea necesario.
        Me.Co_tvalaTableAdapter.Fill(Me.Ambrosia_proDataSet.co_tvala)

    End Sub

    Private Sub Co_valadiDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Co_valadiDataGridView.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim vad As Int64
            vad = Co_valadiDataGridView.Item(0, e.RowIndex).Value
            Dim q As New DetalleValores(Me.user, vad)
            q.Show()
        End If
    End Sub
End Class
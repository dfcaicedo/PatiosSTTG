Imports System.Windows.Forms
Public Class DetalleValores
    Dim user As String
    Dim vad As Int64
    Public Sub New(user As String, vad As Int64)
        Me.InitializeComponent()
        Me.user = user
        Me.vad = vad
        Dim db As New db
        Me.Co_dvalaTableAdapter.Connection = db.getconnection
        Me.Co_valadiTableAdapter.Connection = db.getconnection
        Me.Ambrosia_proDataSet.co_dvala.EMP_NUSUColumn.DefaultValue = Me.user
        Me.Ambrosia_proDataSet.co_dvala.VAL_CONTColumn.DefaultValue = Me.vad
    End Sub

    Private Sub Co_dvalaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Co_dvalaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Co_dvalaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub DetalleValores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_valadi' Puede moverla o quitarla según sea necesario.
        Me.Co_valadiTableAdapter.Fill(Me.Ambrosia_proDataSet.co_valadi)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_dvala' Puede moverla o quitarla según sea necesario.
        Me.Co_dvalaTableAdapter.FillBy(Me.Ambrosia_proDataSet.co_dvala, Me.vad)

    End Sub




    Private Sub Co_dvalaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Co_dvalaDataGridView.CellContentClick

    End Sub

    Private Sub Co_dvalaDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Co_dvalaDataGridView.DataError
        Me.Visible = True
    End Sub
End Class
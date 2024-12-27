Imports System.Windows.Forms
Public Class Tipos_de_Cliente
    Dim user As String
    Public Sub New(user As String)
        Me.user = user
        Me.InitializeComponent()
        Dim db As New db
        Me.Cl_tipoTableAdapter.Connection = db.getconnection
    End Sub

    Private Sub Cl_tipoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Cl_tipoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Cl_tipoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub Tipos_de_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Fill(Me.Ambrosia_proDataSet.cl_tipo)
        Me.Ambrosia_proDataSet.cl_tipo.EMP_NUSUColumn.DefaultValue = Me.user

    End Sub

    Private Sub Cl_tipoDataGridView_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles Cl_tipoDataGridView.CellBeginEdit
        If e.ColumnIndex = 1 Then
            Me.Cl_tipoDataGridView.Item(Cl_tipoDataGridView.ColumnCount - 1, e.RowIndex).Value = Me.user
        End If
    End Sub



    Private Sub Cl_tipoDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles Cl_tipoDataGridView.DataError
        MsgBox("Se ha cometido un error en la digitación por favor diligencie los datos de manera completa" & vbNewLine & e.Exception.Message)
    End Sub


End Class
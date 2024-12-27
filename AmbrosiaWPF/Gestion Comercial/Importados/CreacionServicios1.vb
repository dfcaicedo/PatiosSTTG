Imports System.Windows.Forms
Public Class CreacionServicios1

    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Cl_usuaTableAdapter.Connection = db.getconnection
        Me.Clientes_viewTableAdapter1.Connection = db.getconnection
    End Sub
    Private Sub CreacionServicios1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_usua' Puede moverla o quitarla según sea necesario.
        Me.Cl_usuaTableAdapter.Fill(Me.Ambrosia_proDataSet.cl_usua)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.Clientes_view' Puede moverla o quitarla según sea necesario.
        Me.Clientes_viewTableAdapter1.Fill(Me.Ambrosia_proDataSet.Clientes_view)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim usu_codi As String
        usu_codi = "%" & Me.TextBox1.Text & "%"
        Try
            Me.Cl_usuaTableAdapter.FillByDocumento(Me.Ambrosia_proDataSet.cl_usua, usu_codi)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New CreaciondeUsuarios(Me.user)
        p.ShowDialog()
        CreacionServicios1_Load(Nothing, Nothing)
        Me.TextBox1.Focus()
    End Sub
    Dim valid As Boolean = False
    Public Function getvalid() As Boolean
        Return Me.valid
    End Function
    Dim value As Long
    Public Function getCliente() As Long
        Return Me.value
    End Function
    Private Sub Cl_usuaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Cl_usuaDataGridView.CellContentClick
        If e.ColumnIndex = 1 Then
            Me.valid = True
            value = Me.Cl_usuaDataGridView.Item(0, e.RowIndex).Value
            Me.Close()
        End If
    End Sub
End Class
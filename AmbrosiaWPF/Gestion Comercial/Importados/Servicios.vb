Imports System.Windows.Forms
Public Class Servicios
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Co_tserTableAdapter.Connection = db.getconnection
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.Clientes_view' Puede moverla o quitarla según sea necesario.
        Me.Clientes_viewTableAdapter.Connection = db.getconnection
        Me.Co_servTableAdapter.Connection = db.getconnection

    End Sub


    Private Sub Servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_tser' Puede moverla o quitarla según sea necesario.
        Me.Co_tserTableAdapter.Fill(Me.Ambrosia_proDataSet.co_tser)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.Clientes_view' Puede moverla o quitarla según sea necesario.
        Me.Clientes_viewTableAdapter.Fill(Me.Ambrosia_proDataSet.Clientes_view)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_serv' Puede moverla o quitarla según sea necesario.
        Me.Co_servTableAdapter.Fill(Me.Ambrosia_proDataSet.co_serv)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Me.Co_servTableAdapter.FillByCliente(Me.Ambrosia_proDataSet.co_serv, Me.ToolStripTextBox1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cl_tipoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Cl_tipoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Co_servBindingSource.EndEdit()
        Me.Co_servTableAdapter.Update(Me.Ambrosia_proDataSet.co_serv)
    End Sub

    Private Sub SER_ESTACheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SER_ESTACheckBox.CheckedChanged
        Me.EMP_NUSUTextBox.Text = Me.user
    End Sub
End Class
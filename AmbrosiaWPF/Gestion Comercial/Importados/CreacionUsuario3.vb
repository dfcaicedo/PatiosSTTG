Imports System.Windows.Forms
Public Class CreacionUsuario3
    Dim valid As Boolean = False
    Dim user As String
    Dim db As New db
    Public Sub New(user As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.user = user
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.DataGridView1.RowCount > 0 Then
            Me.valid = True
        End If
        Me.Close()
    End Sub
    Public Function getvalid() As Boolean
        Return Me.valid
    End Function

    Private Sub CreacionUsuario3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        Dim placa As String
        Me.DataGridView1.Item(0, e.RowIndex).Value = Me.DataGridView1.Item(0, e.RowIndex).Value.ToString.ToUpper
        placa = Me.DataGridView1.Item(0, e.RowIndex).Value
        If db.getvalue("Select count(*) from cl_usvh where upper(usv_placa) like @placa and usv_acti=1", "@placa", placa) = 0 Then
            Me.DataGridView1.Item(1, e.RowIndex).Value = "Placa sin Registros"
        Else
            Me.DataGridView1.Item(1, e.RowIndex).Value = "Placa con Registros"
            MsgBox("Si se continua con el registro del vehiculo se va a desactivar para el anterior usuario")
        End If

    End Sub
End Class
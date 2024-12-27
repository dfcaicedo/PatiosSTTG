Public Class CreacionUsuario2
    Dim valid As Boolean = False
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Cl_tipoTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub CreacionUsuario2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Fill(Me.ambrosia_proDataSet.cl_tipo)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ListBox1.Text = "" Then
            MsgBox("Se debe seleccionar un tipo de cliente")
            Me.ListBox1.Focus()
            Exit Sub
        End If
        Me.valid = True
        Me.Close()
    End Sub
    Public Function getvalid() As Boolean
        Return valid
    End Function
    Public Function getTipoCliente() As Long
        Return Me.ListBox1.SelectedValue
    End Function
    Public Function getCartera() As Boolean
        Return Me.CheckBox1.Checked
    End Function
End Class
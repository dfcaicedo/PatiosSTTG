Public Class CreacionUsuario1
    Public Sub New(user As String)
        Me.InitializeComponent()
        Dim db As New db
        Me.Em_tideTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub CreacionUsuario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_tide' Puede moverla o quitarla según sea necesario.
        Me.Em_tideTableAdapter.Fill(Me.ambrosia_proDataSet.em_tide)
    End Sub
    Dim valid As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.ListBox1.SelectedValue = Nothing Then
            MsgBox("No se han diligenciado los datos completos")
            Me.ListBox1.Focus()
            Exit Sub
        End If
        If Me.TextBox1.Text.Length = 0 Then
            MsgBox("Favor Diligenciar todos los datos")
            Me.TextBox1.Focus()
            Exit Sub
        End If
        If Me.TextBox2.Text.Length = 0 Then
            MsgBox("Favor Diligenciar todos los datos")
            Me.TextBox2.Focus()
            Exit Sub
        End If
        If Me.TextBox3.Text.Length = 0 Then
            MsgBox("Favor Diligenciar todos los datos")
            Me.TextBox3.Focus()
            Exit Sub
        End If
        If Me.TextBox4.Text.Length = 0 Then
            MsgBox("Favor Diligenciar todos los datos")
            Me.TextBox4.Focus()
            Exit Sub
        End If
        Me.valid = True
        Me.Close()
    End Sub
    Public Function getvalid() As Boolean
        Return Me.valid
    End Function
    Public Function getTipoIdentificacion() As Long
        Return Me.ListBox1.SelectedValue
    End Function
    Public Function getNumeroDocumento() As String
        Return Me.TextBox1.Text.ToUpper
    End Function
    Public Function getNombre() As String
        Return Me.TextBox2.Text.ToUpper
    End Function
    Public Function getDireccion() As String
        Return Me.TextBox3.Text.ToUpper
    End Function
    Public Function getTelefono() As String
        Return Me.TextBox4.Text.ToUpper
    End Function
End Class
Imports System.Windows.Forms

Public Class CambiodeClave
    Dim clave As String
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.clave = Nothing
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Function getClave() As String
        Return Me.clave
    End Function
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If Me.TextBox1.Text.Length >= 5 And Me.TextBox1.Text = Me.TextBox2.Text Then
            Me.clave = Me.TextBox1.Text
        Else
            MsgBox("No se diligenciaron los campos correctamente")
            Me.TextBox1.Clear()
            Me.TextBox2.Clear()

            Me.TextBox1.Focus()
            Exit Sub
        End If

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.clave = Nothing
        Me.Close()
    End Sub




End Class

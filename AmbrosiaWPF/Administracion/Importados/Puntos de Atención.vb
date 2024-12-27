Public Class Puntos_de_Atención
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Em_parkTableAdapter.Connection = db.getconnection
        Me.Gn_patenTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Puntos_de_Atención_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moverla o quitarla según sea necesario.
        Me.Ambrosia_proDataSet.gn_paten.USU_CODIColumn.DefaultValue = Me.user
        Me.Ambrosia_proDataSet.gn_paten.PAT_DESCColumn.DefaultValue = "Auto"
        Me.Em_parkTableAdapter.Fill(Me.ambrosia_proDataSet.em_park)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.gn_paten' Puede moverla o quitarla según sea necesario.
        Me.Gn_patenTableAdapter.Fill(Me.ambrosia_proDataSet.gn_paten)

    End Sub

    Private Sub Gn_patenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Gn_patenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Gn_patenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ambrosia_proDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PAT_EQUITextBox.Text = My.Computer.Name
        Me.USU_CODITextBox.Text = Me.user
    End Sub

    Private Sub PAR_CODIListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PAR_CODIListBox.SelectedIndexChanged
        Me.USU_CODITextBox.Text = Me.user
    End Sub

    Private Sub PAT_DESCTextBox_TextChanged(sender As Object, e As EventArgs) Handles PAT_DESCTextBox.TextChanged
        Me.USU_CODITextBox.Text = Me.user
    End Sub
End Class
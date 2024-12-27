Public Class Parqueaderos
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Em_parkTableAdapter.Connection = db.getconnection
        Me.Gn_diasTableAdapter.Connection = db.getconnection
        Em_datenTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Em_parkBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Em_parkBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Em_parkBindingSource.EndEdit()

        Me.Em_parkTableAdapter.Update(Me.ambrosia_proDataSet.em_park)
        Me.Em_datenTableAdapter.Update(Me.ambrosia_proDataSet.em_daten)

    End Sub

    Private Sub Parqueaderos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.gn_dias' Puede moverla o quitarla según sea necesario.
        Me.Gn_diasTableAdapter.Fill(Me.ambrosia_proDataSet.gn_dias)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_daten' Puede moverla o quitarla según sea necesario.
        Me.Em_datenTableAdapter.Fill(Me.ambrosia_proDataSet.em_daten)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moy.verla o quitarla según sea necesario.
        Me.Em_parkTableAdapter.Fill(Me.ambrosia_proDataSet.em_park)
        Me.ambrosia_proDataSet.em_park.emp_nusuColumn.DefaultValue = Me.user

        Dim y As New TimeSpan
        y = New TimeSpan(6, 0, 0)
        Me.ambrosia_proDataSet.em_daten.dat_hiniColumn.DefaultValue = y
        y = New TimeSpan(22, 30, 0)
        Me.ambrosia_proDataSet.em_daten.dat_hfinaColumn.DefaultValue = y

    End Sub

    Private Sub PAR_COMITextBox_TextChanged(sender As Object, e As EventArgs) Handles PAR_COMITextBox.TextChanged,PAR_DIRETextBox.TextChanged, PAR_TELETextBox.TextChanged, PAR_NITTextBox.TextChanged,PAR_COMSTextBox.TextChanged,PAR_NOMBTextBox.TextChanged
        Me.Emp_nusuTextBox.Text = Me.user
    End Sub

    Private Sub PAR_ANULCheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Me.Emp_nusuTextBox.Text = Me.user
    End Sub
End Class
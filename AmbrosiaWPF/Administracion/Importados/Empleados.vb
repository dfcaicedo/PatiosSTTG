Imports System.Windows.Forms
Public Class Empleados
    Dim user As String
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
        Dim db As New db
        Me.Em_cargTableAdapter.Connection = db.getconnection
        Me.Em_tideTableAdapter.Connection = db.getconnection
        Me.Em_emplTableAdapter.Connection = db.getconnection
    End Sub



    Private Sub Em_emplBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Em_emplBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Em_emplBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosia_proDataSet)

    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_carg' Puede moverla o quitarla según sea necesario.
        Me.Em_cargTableAdapter.Fill(Me.Ambrosia_proDataSet.em_carg)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_tide' Puede moverla o quitarla según sea necesario.
        Me.Em_tideTableAdapter.Fill(Me.Ambrosia_proDataSet.em_tide)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_empl' Puede moverla o quitarla según sea necesario.
        Me.Em_emplTableAdapter.Fill(Me.Ambrosia_proDataSet.em_empl)
        Me.Ambrosia_proDataSet.em_empl.emp_modiColumn.DefaultValue = Me.user

    End Sub

    Private Sub TII_CODIListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TII_CODIListBox.SelectedIndexChanged, CAR_CODIListBox.SelectedIndexChanged, EMP_DIRETextBox.TextChanged, EMP_ESTACheckBox.CheckStateChanged, EMP_NOMBTextBox.TextChanged, EMP_PASSTextBox.TextChanged, EMP_TELETextBox.TextChanged, EMP_CODITextBox.TextChanged
        Me.Emp_modiTextBox.Text = Me.user
    End Sub

    Private Sub FillByIdentificacionToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByIdentificacionToolStripButton.Click
        Try
            Me.Em_emplTableAdapter.FillByIdentificacion(Me.Ambrosia_proDataSet.em_empl, CodigoToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New CambiodeClave
        p.ShowDialog()
        If Not p.getClave Is Nothing Then
            'TripleDES
            Me.EMP_PASSTextBox.Text = p.getClave
        End If
    End Sub
End Class
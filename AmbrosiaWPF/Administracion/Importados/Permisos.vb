Imports System.Windows.Forms
Public Class Permisos
    Dim user As String
    Public Sub New(user As String)
        Me.user = user
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Dim db As New db
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Em_cargTableAdapter.Connection = db.getconnection
        Me.Em_dmodTableAdapter.Connection = db.getconnection
        Me.Em_drptTableAdapter.Connection = db.getconnection
        Me.Em_moduTableAdapter.Connection = db.getconnection
        Me.Em_repoTableAdapter.Connection = db.getconnection
        Me.Ambrosia_proDataSet.em_dmod.EMP_NUSUColumn.DefaultValue = Me.user
    End Sub
    Private Sub Em_cargBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Em_cargBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Em_cargBindingSource.EndEdit()
        Me.Em_dmodTableAdapter.Update(Me.Ambrosia_proDataSet.em_dmod)
        ' Me.Em_drptTableAdapter.Update(Me.Ambrosia_proDataSet.em_drpt)

    End Sub

    Private Sub Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_drpt' Puede moverla o quitarla según sea necesari
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_repo' Puede moverla o quitarla según sea necesario.
        Me.Em_repoTableAdapter.Fill(Me.Ambrosia_proDataSet.em_repo)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_modu' Puede moverla o quitarla según sea necesario.
        Me.Em_moduTableAdapter.Fill(Me.Ambrosia_proDataSet.em_modu)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_dmod' Puede moverla o quitarla según sea necesario.
        Me.Em_dmodTableAdapter.Fill(Me.Ambrosia_proDataSet.em_dmod)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_carg' Puede moverla o quitarla según sea necesario.
        Me.Em_cargTableAdapter.Fill(Me.Ambrosia_proDataSet.em_carg)
        Me.Em_drptTableAdapter.Fill(Me.Ambrosia_proDataSet.em_drpt)

    End Sub



    Private Sub Em_drptDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Em_drptDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs)
        Dim p As Int16 = 0

    End Sub
End Class
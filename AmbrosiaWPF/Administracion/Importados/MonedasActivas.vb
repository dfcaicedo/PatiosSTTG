Public Class MonedasActivas
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Dim db As New db
        Me.Em_moacTableAdapter.Connection = db.getconnection
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Em_moacBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Em_moacBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Em_moacBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ambrosia_proDataSet)

    End Sub

    Private Sub MonedasActivas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_moac' Puede moverla o quitarla según sea necesario.
        Me.Em_moacTableAdapter.Fill(Me.ambrosia_proDataSet.em_moac)

    End Sub
End Class
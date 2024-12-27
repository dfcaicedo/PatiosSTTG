Public Class Consultar
    Public ReadOnly placa As String
    Public ReadOnly park As Int32
    Public Sub New(placa As String, park As Int32)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.placa = placa
        Me.park = park
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Co_entrBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Co_entrBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Co_entrBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Ambrosiapark_proDataSet)

    End Sub

    Private Sub Consultar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosiapark_proDataSet.vh_tipos' Puede moverla o quitarla según sea necesario.
        Me.Vh_tiposTableAdapter.Fill(Me.Ambrosiapark_proDataSet.vh_tipos)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosiapark_proDataSet.co_tser' Puede moverla o quitarla según sea necesario.
        Me.Co_tserTableAdapter.Fill(Me.Ambrosiapark_proDataSet.co_tser)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosiapark_proDataSet.cl_usua' Puede moverla o quitarla según sea necesario.
        Me.Cl_usuaTableAdapter.Fill(Me.Ambrosiapark_proDataSet.cl_usua)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosiapark_proDataSet.co_entr' Puede moverla o quitarla según sea necesario.
        Me.Co_entrTableAdapter.FillByPlaca(Me.Ambrosiapark_proDataSet.co_entr, Me.placa, Me.park)

    End Sub
End Class
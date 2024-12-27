Imports MySql.Data.MySqlClient
Public Class testCostos
    Dim db As New db

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.Co_tserTableAdapter.Connection = db.getconnection
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Connection = db.getconnection
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moverla o quitarla según sea necesario.
        Me.Em_parkTableAdapter.Connection = db.getconnection
        Me.Vh_tiposTableAdapter.Connection = db.getconnection

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub testCostos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.vh_tipos' Puede moverla o quitarla según sea necesario.
        Me.Vh_tiposTableAdapter.Fill(Me.ambrosia_proDataSet.vh_tipos)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_tser' Puede moverla o quitarla según sea necesario.
        Me.Co_tserTableAdapter.Fill(Me.ambrosia_proDataSet.co_tser)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_tipo' Puede moverla o quitarla según sea necesario.
        Me.Cl_tipoTableAdapter.Fill(Me.ambrosia_proDataSet.cl_tipo)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.em_park' Puede moverla o quitarla según sea necesario.
        Me.Em_parkTableAdapter.Fill(Me.ambrosia_proDataSet.em_park)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lector As MySqlDataReader
        Dim sql As String
        sql = "select tar_laps, tar_cost from co_tari where tar_Acti=1 and par_Codi=" & Me.ListBox1.SelectedValue & " and tic_codi=" & Me.ListBox2.SelectedValue & " and tiv_codi=" & Me.ListBox3.SelectedValue & " and tse_codi=" & Me.ListBox4.SelectedValue
        lector = db.fetch(sql)
        Dim q As New ProcesoCostos()
        While lector.Read
            q.addtarifa(lector.GetValue(1), lector.GetValue(0))
        End While
        lector.Close()
        db.close()
        MsgBox(q.getCosto(Val(Me.TextBox1.Text)))

    End Sub
End Class
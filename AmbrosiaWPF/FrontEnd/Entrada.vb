Public Class Entrada
    Dim user As String
    Dim entr As Int32
    Public Sub New(user As String, entr As Int64)
        Me.InitializeComponent()
        Dim db As New db
        Me.user = user
        Me.entr = entr
        Me.Vh_tiposTableAdapter.Connection = db.getconnection
        Co_tserTableAdapter.Connection = db.getconnection
        Cl_usuaTableAdapter.Connection = db.getconnection
        Co_entrTableAdapter.Connection = db.getconnection
    End Sub
    Private Sub Co_entrBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Co_entrBindingNavigatorSaveItem.Click
        If Me.cambio Then
            Me.AUD_NUSUTextBox.Text = Me.user
        End If
        Me.Validate()
        Me.ENT_PLACTextBox.Text = Me.ENT_PLACTextBox.Text.ToUpper
        Me.Co_entrBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ambrosia_proDataSet)
        MsgBox("Se han guardado los cambios efectuados")
        Me.Close()
    End Sub

    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.vh_tipos' Puede moverla o quitarla según sea necesario.
        Me.Vh_tiposTableAdapter.Fill(Me.ambrosia_proDataSet.vh_tipos)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_tser' Puede moverla o quitarla según sea necesario.
        Me.Co_tserTableAdapter.Fill(Me.ambrosia_proDataSet.co_tser)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.cl_usua' Puede moverla o quitarla según sea necesario.
        Me.Cl_usuaTableAdapter.Fill(Me.ambrosia_proDataSet.cl_usua)
        'TODO: esta línea de código carga datos en la tabla 'Ambrosia_proDataSet.co_entr' Puede moverla o quitarla según sea necesario.
        Me.Co_entrTableAdapter.FillByEntrada(Me.ambrosia_proDataSet.co_entr, Me.entr)
        If MsgBox("Desea modificar algun dato de la entrada", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Me.Close()
        End If
    End Sub

    Private Sub ENT_PLACTextBox_LostFocus(sender As Object, e As EventArgs) Handles ENT_PLACTextBox.LostFocus
        Dim placa As String
        placa = Me.ENT_PLACTextBox.Text
        For p = 0 To 255
            Dim flag As Boolean = True
            If p >= 48 And p <= 57 Then
                flag = False
            End If
            If p >= 65 And p <= 90 Then
                flag = False
            End If
            If flag Then
                placa = placa.Replace(Chr(p), "")
            End If
        Next
        Me.ENT_PLACTextBox.Text = placa
        updatecliente()
    End Sub
    Public Sub updatecliente()
        Try
            Dim cliente As Int64
            Dim db As New db
            cliente = db.getvalue("select ifnull(max(usu_Cont),1) from cl_usvh where usv_placa=@placa and usv_acti=1", "@placa", Me.ENT_PLACTextBox.Text)
            Me.USU_CONTListBox.SelectedValue = cliente
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ENT_PLACTextBox_TextChanged(sender As Object, e As EventArgs) Handles ENT_PLACTextBox.TextChanged
        Me.cambio = True
    End Sub
    Dim cambio As Boolean = False
    Private Sub USU_CONTListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles USU_CONTListBox.SelectedIndexChanged
        cambio = True
    End Sub

    Private Sub TSE_CODIListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TSE_CODIListBox.SelectedIndexChanged
        Me.cambio = True
    End Sub

    Private Sub TIV_CODIListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TIV_CODIListBox.SelectedIndexChanged
        Me.cambio = True
    End Sub

    Private Sub ENT_COMMTextBox_TextChanged(sender As Object, e As EventArgs) Handles ENT_COMMTextBox.TextChanged
        Me.cambio = True
    End Sub


End Class
Imports MySql.Data.MySqlClient

Public Class Aportes
    ReadOnly user As String
    ReadOnly park As Int64
    Dim db As New db
    Dim client As Int64 = -1
    Dim lclientes As New List(Of Model_Id_Desc)
    Public Sub New(user As String, park As Int64)
        Me.user = user
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cargarcliente("")
        Me.park = park
    End Sub
    Public Sub cargarcliente(dato As String)
        dato = "%" & dato & "%"
        Dim cnt As New MySqlConnection(db.getConnectionString)
        Dim cmd As New MySqlCommand("select usu_cont,concat(usu_codi,' ',usu_nomb) from cl_usua where usu_carte=1 and usu_codi like @code limit 0,150", cnt)
        cmd.Parameters.AddWithValue("@code", dato)
        Dim lector As MySqlDataReader
        lclientes = New List(Of Model_Id_Desc)
        Try
            cnt.Open()
            lector = cmd.ExecuteReader
            While lector.Read
                Dim q As New Model_Id_Desc
                q.id = lector.GetValue(0)
                q.desc = lector.GetValue(1)
                lclientes.Add(q)
            End While
            Me.lista.ItemsSource = lclientes
            lector.Close()
            cnt.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If Me.client = -1 Then
            MsgBox("Debe Seleccionar el cliente que realiza el abono")
            Exit Sub
        End If
        Try
            Dim valor As Single
            valor = Convert.ToSingle(Me.abono.Text)
            Dim cnt As New MySqlConnection(db.getConnectionString)
            Dim cmd As New MySqlCommand("", cnt)
            cmd.CommandText = "insert into cl_saldo values(null,@cli,@park,'Recibo de Caja por abono de " &
                valor & "',@valor,sysdate(),0,@user)"
            cmd.Parameters.AddWithValue("@cli", client)
            cmd.Parameters.AddWithValue("@park", park)
            cmd.Parameters.AddWithValue("@valor", valor)
            cmd.Parameters.AddWithValue("@user", user)
            Try
                cnt.Open()
                cmd.ExecuteNonQuery()
                cmd.Parameters.Clear()
                cmd.CommandText = "update cl_usua set usu_sald=usu_sald+@valor where usu_cont=@client"
                cmd.Parameters.AddWithValue("@valor", valor)
                cmd.Parameters.AddWithValue("@client", client)
                cmd.ExecuteNonQuery()
                cnt.Close()
                Dim q As New SaldosFRM(db.getvalue("select max(sal_cont) from cl_Saldo where par_codi=@park", "@park", Me.park))
                q.ShowDialog()
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub clientetext_TextChanged(sender As Object, e As TextChangedEventArgs) Handles clientetext.TextChanged
        cargarcliente(Me.clientetext.Text)
    End Sub

    Private Sub lista_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles lista.SelectionChanged
        Try
            Dim q As Model_Id_Desc = e.AddedItems(0)
            Me.client = q.id
        Catch ex As Exception
            Me.client = -1
        End Try

    End Sub
End Class

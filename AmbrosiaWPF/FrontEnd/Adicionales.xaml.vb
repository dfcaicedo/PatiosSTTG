Imports MySql.Data.MySqlClient

Public Class Adicionales
    ReadOnly user As String
    Dim lclientes As New List(Of Model_Id_Desc)
    ReadOnly entrada As Int64
    Dim db As New db
    Dim park As Int64
    Dim cliente As Int64
    Dim ladici As New List(Of Model_Id_Desc)
    Public Sub New(user As String, entrada As Int64, placa As String, park As Int64)
        Me.park = park
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.entrada = entrada
        Me.user = user
        Me.lblPlaca.Content = "Placa " & placa.ToString
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ListBox.IsEnabled = False
        Me.ClienteBase.IsEnabled = False
        cliente = db.getvalue("select usu_Cont from co_entr where ent_codi=@entrada", "@entrada", entrada)
        Me.ClienteBase.Text = db.getvalue("select usu_codi from cl_usua where usu_cont=@cliente", "@cliente", cliente)
        Me.ClienteBase.IsReadOnly = True
        Me.ListBox.IsEnabled = False
        cargarConentrada()
    End Sub
    Public Sub New(user As String, park As Int64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.park = park
        Me.entrada = -1
        Me.user = user
        Me.cliente = db.getvalue("select max(usu_codi) from cl_usua where usu_defa=1")
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cargarsinentrada()
    End Sub
    Public Sub cargarConentrada()

        db.open()
        Dim lector As MySqlDataReader = db.fetch("select tva_cont, tva_nomb from co_tvala")
        While lector.Read
            Dim q As New Model_Id_Desc
            q.id = lector.GetValue(0)
            q.desc = lector.GetValue(1)
            ladici.Add(q)
        End While
        lector.Close()
        db.close()
        Me.Tipo_adicionales.ItemsSource = ladici
    End Sub
    Public Sub cargarsinentrada()
        db.open()
        Dim lector As MySqlDataReader = db.fetch("select tva_cont, tva_nomb from co_tvala where tva_dent=0")
        While lector.Read
            Dim q As New Model_Id_Desc
            q.id = lector.GetValue(0)
            q.desc = lector.GetValue(1)
            ladici.Add(q)
        End While
        lector.Close()
        Me.Tipo_adicionales.ItemsSource = ladici
        db.close()
        Me.ClienteBase.Text = "1"
        cargarclientes("1")
    End Sub

    Private Sub AgregarAdicional(sender As Object, e As RoutedEventArgs)
        Dim q() As String
        q = sender.content.ToString.Split("-")
        If lblPlaca.Content <> "Placa" Then
            If MsgBox("Confirmar el adicional ", MsgBoxStyle.YesNo, "Control de Parqueadero") = MsgBoxResult.Yes Then
                Dim cnt As MySqlConnection = db.getconnection
                Dim param() As String
                param = "@ent,@val_cont,@user".Split(",")
                Dim values(2) As Object
                values(0) = Me.entrada
                values(1) = q(0)
                values(2) = Me.user
                Try
                    db.query("insert into co_denva values (null,@ent,@val_cont,1,@user)", param, values)
                    MsgBox("Se ha agregado el Adicional a la entrada")
                Catch ex As Exception

                End Try

            End If
        Else
            If MsgBox("Confirmar el adicional ", MsgBoxStyle.YesNo, "Control de Parqueadero") = MsgBoxResult.Yes Then
                Dim param() As String = "@clien,@park,@desc,@valor,@user,@abon".Split(",")
                Dim values(5) As Object
                values(0) = Me.cliente
                values(1) = Me.park
                values(2) = q(1)
                values(3) = db.getvalue("select max(dva_cost) from co_dvala where val_cont=@val and dva_acti=1", "@val", q(0))
                values(4) = Me.user
                values(5) = 0
                If db.getvalue("select usu_carte from cl_usua where usu_cont=@cliente", "@cliente", cliente) Then
                    If MsgBox("Desea agregar el adicional a la cuenta del cliente", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        values(5) = 1
                        db.query("update cl_usua set usu_sald=usu_sald-@valor where usu_cont=@cliente", {"@valor", "@cliente"}, {values(3), cliente})
                    End If
                End If
                db.query("insert into cl_saldo (usu_Cont,par_codi,sal_desc,sal_valor,sal_Fecha,sal_abon,emp_nusu) values(" &
                         "@clien,@park,@desc,@valor,now(),0,@user) ", param, values)
                    Dim parameter As Int64
                    parameter = db.getvalue("Select max(sal_cont) from cl_saldo")
                    Dim p As New SaldosFRM(parameter)
                    p.ShowDialog()
                End If
            End If
        Me.Close()
    End Sub
    Public Sub cargarbotones(tadici As Int64)
        Me.AdicionalContainer.Children.Clear()
        Dim cnt As MySqlConnection = db.getconnection
        Dim cmd As New MySqlCommand("select concat(val_cont,'-',val_desc) from co_valadi where tva_cont=@tipo", cnt)
        Try
            cnt.Open()
            cmd.Parameters.AddWithValue("@tipo", tadici)
            Dim lector As MySqlDataReader = cmd.ExecuteReader
            While lector.Read
                Dim brd As New Border
                brd.Width = 150
                Dim cr As New CornerRadius(10)
                brd.CornerRadius = cr
                Dim colore As Color
                colore = Color.FromRgb(21, 124, 56) ' New Color(21, 124, 56)
                Dim q As New Button
                Dim bru As New SolidColorBrush(colore)

                brd.Background = bru

                q.Background = bru
                q.Content = lector.GetValue(0)

                q.Height = 40
                q.Foreground = New SolidColorBrush(Color.FromRgb(255, 255, 255))
                Dim pad As New Thickness(5)
                brd.Padding = pad
                brd.Margin = pad
                brd.Child = q
                Me.AdicionalContainer.Children.Add(brd)
                AddHandler q.Click, AddressOf AgregarAdicional
            End While
            lector.close
            cnt.Close()
        Catch ex As Exception

        End Try


    End Sub


    Private Sub Tipo_adicionales_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles Tipo_adicionales.SelectionChanged
        Try
            Me.cargarbotones(e.AddedItems(0).id)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClienteBase_TextChanged(sender As Object, e As TextChangedEventArgs) Handles ClienteBase.TextChanged
        cargarclientes("%" & Me.ClienteBase.Text & "%")
    End Sub
    Public Sub cargarclientes(cedula As String)
        Dim cnt As New MySqlConnection(db.getConnectionString)
        Me.lclientes = Nothing
        lclientes = New List(Of Model_Id_Desc)
        Dim cmd As New MySqlCommand("select usu_cont, concat(usu_codi, ' ', ucase(usu_nomb)) from cl_usua where usu_codi like @cedula order by usu_defa desc,usu_nomb", cnt)
        cmd.Parameters.AddWithValue("@cedula", cedula)
        Dim lector As MySqlDataReader
        Try
            cnt.Open()
            lector = cmd.ExecuteReader
            While lector.Read
                Dim q As New Model_Id_Desc
                q.id = lector.GetValue(0)
                q.desc = lector.GetValue(1)
                lclientes.Add(q)
            End While
            lector.Close()
            cnt.Close()
            Me.ListBox.ItemsSource = lclientes
        Catch ex As Exception

        End Try
        Me.ListBox.SelectedItem = Me.ListBox.Items(0)
        Me.ListBox.ScrollIntoView(Me.ListBox.Items(0))
    End Sub

    Private Sub ListBox_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles ListBox.SelectionChanged
        Me.cliente = e.AddedItems.Item(0).id
    End Sub
End Class

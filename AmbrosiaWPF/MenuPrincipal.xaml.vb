Imports MySql.Data.MySqlClient
Imports System.Windows.Threading
Public Class MenuPrincipal
    Public ReadOnly user As String
    Dim hoy As Date
    Dim paten As List(Of Model_Id_Desc)
    Dim lmotos As List(Of Model_Id_Desc)
    Dim lauto As List(Of Model_Id_Desc)
    Dim lotro As List(Of Model_Id_Desc)
    Dim park As Int64 = 1
    Dim db As New db
    Dim timer As DispatcherTimer
    Public Sub New(user As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim db As New db
        Me.user = user
        Me.timer = New DispatcherTimer()
        timer.Interval = TimeSpan.FromSeconds(15)
        AddHandler timer.Tick, AddressOf timer_tick
        timer.Start()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim cnt As MySqlConnection
        cnt = New MySqlConnection(db.getConnectionString)
        Dim cmd As New MySqlCommand("select pat_cont, pat_desc from gn_paten where pat_equi like @equi", cnt)
        Try
            cnt.Open()

            paten = New List(Of Model_Id_Desc)
            lmotos = New List(Of Model_Id_Desc)
            lauto = New List(Of Model_Id_Desc)
            lotro = New List(Of Model_Id_Desc)
            cmd.Parameters.AddWithValue("@equi", My.Computer.Name)
            Dim lector As MySqlDataReader = cmd.ExecuteReader
            While lector.Read
                Dim q As New Model_Id_Desc
                q.id = lector.GetValue(0)
                q.desc = lector.GetValue(1)
                paten.Add(q)
                If paten.Count = 1 Then
                    setNombreParqueadero(q.id)
                    Me.park = q.id
                End If
            End While
            lector.Close()
            cnt.Close()
            Me.PatenList.ItemsSource = paten

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.PlacaText.Focus()
        If park = 0 Then
            park = 1
        End If
        timer_tick()
    End Sub
    Public Sub timer_tick()
        cargarlistas()
        If Me.hoy <> Now.Date Then
            Me.hoy = Now.Date
            db.query("update co_serv set ser_Esta=0 where ser_fecf<@fecha", "@fecha", Now.Date)
        End If
    End Sub

    Public Sub cargarlistas()
        Me.lauto.Clear()
        Me.ListaMotos.ItemsSource = Nothing
        Me.Listaautos.ItemsSource = Nothing
        Me.ListaOtros.ItemsSource = Nothing

        Me.lmotos.Clear()
        Me.lotro.Clear()
        Dim cnt As New MySqlConnection(db.getConnectionString)
        Dim cmd As New MySqlCommand("", cnt)
        Try
            cmd.CommandText = "select ent_codi, ent_plac,TIV_CODI from co_entr where ent_sali is null and par_codi =@park"
            cmd.Parameters.AddWithValue("@park", Me.park)
            Dim lector As MySqlDataReader
            cnt.Open()
            lector = cmd.ExecuteReader
            While lector.Read
                Dim q As New Model_Id_Desc
                q.id = lector.GetValue(0)
                q.desc = lector.GetValue(1)
                Select Case lector.GetValue(2)
                    Case 1
                        lauto.Add(q)
                    Case 2
                        lmotos.Add(q)
                    Case Else
                        lotro.Add(q)
                End Select
            End While
            lector.Close()
            cnt.Close()
            Me.CantMotos.Content = "Cantidad: " & lmotos.Count
            Me.ListaMotos.ItemsSource = lmotos
            Me.CantAutos.Content = "Cantidad: " & lauto.Count
            Me.Listaautos.ItemsSource = lauto
            Me.CantOtros.Content="Cantidad: " & lotro.Count 
            Me.ListaOtros.ItemsSource = lotro

        Catch ex As Exception

        End Try
    End Sub
    Public Sub setNombreParqueadero(cod As Int16)
        Dim cnt As MySqlConnection
        cnt = New MySqlConnection(db.getConnectionString)
        Dim cmd As New MySqlCommand("select par_nomb,par_codi from em_park where par_codi in (select par_codi from gn_paten where pat_cont=@code)", cnt)
        Try
            cmd.Parameters.AddWithValue("@code", cod)
            cnt.Open()
            Dim lector As MySqlDataReader = cmd.ExecuteReader
            While lector.Read
                Me.NombreParqueadero.Content = lector.GetValue(0)
                Me.park = lector.GetValue(1)
            End While
            lector.Close()
            cnt.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PatenList_Selected(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub PatenList_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        setNombreParqueadero(e.AddedItems(0).id)
    End Sub

    Private Sub PlacaText_KeyUp(sender As Object, e As KeyEventArgs) Handles PlacaText.KeyUp
        If e.Key = Key.Enter Then
            If PlacaText.Text.Trim.Length >= 1 Then
                accionar()

            End If

        End If
    End Sub

    Private Sub BtnRegistrar_Click(sender As Object, e As RoutedEventArgs) Handles BtnRegistrar.Click
        If PlacaText.Text.Trim.Length >= 1 Then
            accionar()
        End If
    End Sub
    Public Sub validarplaca()
        Dim placa As String
        placa = Me.PlacaText.Text.ToUpper
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
        Me.PlacaText.Text = placa
        Me.PlacaText.Focus()
    End Sub
    Public Sub accionar()
        db.close()
        Dim param() As String
        Dim placa As String
        Dim values() As Object
        Me.validarplaca()
        placa = Me.PlacaText.Text.Replace(" ", "")
        'Confirmar si existe algun ingreso con la placa o con el dato escrito
        If 0 = db.getvalue("select count(*) from co_entr where ent_sali is null and ent_plac=@placa", "@placa", placa) Or 0 = db.getvalue("select count(*) from co_entr where ent_sali is null and ent_plac=@placa", "@placa", placa.Replace(" ", "")) Then
            'Verifica si existe o no una entrada que no tenga una salida asociada
            'Si el valor es 0 quiere decir que el vehiculo ingresa por primera vez
            Dim tvehiculo As Int64
            tvehiculo = getTipoVehiculo(placa.ToUpper.Replace(" ", ""))
            Dim cliente As Int64 = getCliente(placa)
            Dim tiposervicio As Int64 = getTipoServicio(cliente)
            Dim parqueadero As Int64 = Me.park
            If tvehiculo = -1 Then
                If MsgBox("No se ha podido determinar el tipo de vehiculo, desea agregarlo manualmente", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    'Abrir formulario de selección
                    Dim tu As New frm_Tvehiculos()
                    tu.ShowDialog()
                    If tu.getValor() = -1 Then
                        db.close()
                        Exit Sub
                    Else
                        tvehiculo = tu.getValor
                        placa = Me.PlacaText.Text.ToUpper
                    End If
                Else
                    db.close()
                    Exit Sub
                End If
            Else
                placa = placa.Replace(" ", "")
            End If
            If Not hasCapacity(parqueadero, tvehiculo) Then
                MsgBox("No se tiene disponibilidad para este tipo de vehiculo en el momento")

                Exit Sub
            End If
            Try
                Dim sql As String
                sql = "Insert into co_entr (par_codi,emp_nusu,usu_cont,ent_entr,ent_cost,ent_plac,tse_codi,tiv_codi,aud_nusu,ent_time) values " &
                      "(@park,@emp_nusu,@cliente,curdate(),0,@placa,@tserv,@tvehi,@emp_nusu,0)"
                Dim parameter() As String = "@park,@emp_nusu,@cliente,@placa,@tserv,@tvehi".Split(",")
                ReDim values(5)
                values(0) = parqueadero
                values(1) = Me.user
                values(2) = cliente
                values(3) = placa.ToUpper
                values(4) = tiposervicio
                values(5) = tvehiculo
                db.query(sql, parameter, values)
                If MsgBox("Desea agregar algun comentario a la entrada del vehiculo con placa " & placa, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Try
                        Dim cad As String = InputBox("Por favor digite el comentario de la entrada")
                        Dim max As Int64
                        max = db.getvalue("Select max(ent_codi) from co_entr where ent_plac=@placa and par_codi=" & Me.park, "@placa", placa)
                        db.query("update co_entr set ent_comm=@coment where ent_codi=" & max, "@coment", cad)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
                Dim q As EntradasRPT
                'Crear Reporte de Entrada
                '   ReDim parameter(0)
                q = New EntradasRPT(db.getvalue("Select max(ent_codi) from co_entr where ent_plac=@placa and par_codi=" & Me.park, "@placa", placa))
                q.ShowDialog()
                '    Dim p As New VisorReportes(db.getvalue("select rpt_ruta from em_repo where rpt_entra=1 and rpt_codi in (select max(rpt_codi) from em_repo where rpt_entra=1)"), parameter)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            param = "@park,@tse,@user,@tiv".Split(",")
            ReDim values(3)
            values(0) = parqueadero
            values(1) = tiposervicio
            values(2) = cliente
            values(3) = tvehiculo
            If 0 = db.getvalue("select count(*) from co_tari where par_codi=@park and tiv_codi=@tiv and tse_codi=@tse and tic_codi in (select tic_codi from cl_usua where usu_Cont=@user)", param, values) Then
                MsgBox("No se han registrado tarifas para la combinación de parqueadero, tipo de cliente y tipo de servicio por favor revisar las tárifas")
            End If
        Else
            Dim ent As Int64

            Dim acum_dia As Int64
            Dim defaultclient As Int64 = db.getvalue("select max(usu_cont) from cl_usua where usu_defa=1")
            ent = db.getvalue("select max(ent_codi) from co_entr where ent_sali is null and ent_plac=@placa and par_codi=" & Me.park, "@placa", placa)
            Dim lector As MySqlDataReader
            lector = db.fetch("select usu_cont,tse_codi,tiv_codi,par_codi from co_entr where ent_codi=" & ent)
            Dim params() As String
            While lector.Read

                params = "@park,@tse,@user,@tiv".Split(",")
                ReDim values(3)
                values(0) = lector.GetValue(3)
                values(1) = lector.GetValue(1)
                values(2) = lector.GetValue(0)
                values(3) = lector.GetValue(2)
                If 0 = (New db).getvalue("select count(*) from co_tari where tar_acti=1 and par_codi=@park and tiv_codi=@tiv and tse_codi=@tse and tic_codi in (select tic_codi from cl_usua where usu_Cont=@user)", params, values) Then
                    MsgBox("No se han registrado tarifas para la combinación de parqueadero, tipo de cliente y tipo de servicio por favor revisar las tárifas")
                    lector.Close()
                    db.close()
                    '    Me.Timer2_Tick(Nothing, Nothing)
                    Exit Sub
                End If
            End While
            lector.Close()
            db.close()
            Dim fechai As Date = db.getvalue("select date(ent_entr) from co_entr where ent_codi=@ent", "@ent", ent)

            Dim valmax As Int64 = 99999999
            Try
                valmax = db.getvalue("select ifnull(max(dcm_cost),-1) from co_dcmax where DCM_ACTI=1 and tiv_codi in (select tiv_codi from co_entr where ent_codi=@ent_codi) and tic_codi in (select tic_codi from cl_usua where usu_cont in (select usu_Cont from co_entr where ent_codi=@ent_codi))", "@ent_codi", ent)
            Catch ex As Exception

            End Try

            Dim cliente As Int64 = db.getvalue("select usu_cont from co_entr where ent_codi=@entr", "@entr", ent)

            If cliente <> defaultclient Then
                acum_dia = db.getvalue("select ifnull(sum(ent_cost),0)-ifnull((select sum(co_dvala.DVA_COST) from co_denva,co_dvala where co_denva.VAL_CONT=co_dvala.VAL_CONT and co_denva.ENT_CODI in (select ent_codi from co_entr where date(ent_Sali)=curdate() and usu_cont=@cliente) and co_dvala.dva_acti=1 and co_dvala.DVA_COST=(select max(dva_Cost) from co_Dvala  dva where dva.val_cont=co_dvala.VAL_CONT and co_dvala.dva_acti=1)),0) from co_entr where usu_Cont=@cliente and date(co_entr.ent_sali)=curdate()", "@cliente", cliente)
            Else
                acum_dia = 0
            End If
            Dim costo As New CostoPatios(ent)
            Dim valor As Int64 = costo.getCosto()

            ReDim values(2)
            values(0) = Me.user
            values(1) = valor
            Dim t As Int64 = valor
            values(2) = ent
            db.query($"update co_entr set ent_sali=now(),aud_nusu='{user}',ent_cost={valor} where ent_codi={ent}")
            If db.getvalue("select usu_carte from cl_usua where usu_cont=@cliente", "@cliente", cliente) Then
                If MsgBox("Desea agregar el costo de la estancia por un valor de " & t & " a la cuenta del cliente", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    db.query("update cl_usua set usu_sald=usu_sald-" & t & " where usu_cont=@user", "@user", cliente)
                    param = "@clien,@park,@desc,@valor,@user".Split(",")
                    ReDim values(4)
                    values(0) = cliente
                    values(1) = Me.park
                    values(2) = "Costo de la Entrada con código " & ent & " y placa  -" & placa
                    values(3) = valor
                    values(4) = Me.user
                    db.query("insert into cl_saldo (usu_Cont,par_codi,sal_desc,sal_valor,sal_Fecha,sal_abon,emp_nusu) values(" &
                             "@clien,@park,@desc,@valor,now(),1,@user) ", param, values)
                Else
                    param = "@clien,@park,@desc,@valor,@user".Split(",")
                    ReDim values(4)
                    values(0) = cliente
                    values(1) = Me.park
                    values(2) = "Costo de la Entrada con código " & ent & " y placa  -" & placa
                    values(3) = valor
                    values(4) = Me.user
                    db.query("insert into cl_saldo (usu_Cont,par_codi,sal_desc,sal_valor,sal_Fecha,sal_abon,emp_nusu) values(" &
                             "@clien,@park,@desc,@valor,now(),0,@user) ", param, values)
                End If
            Else
                param = "@clien,@park,@desc,@valor,@user".Split(",")
                ReDim values(4)
                values(0) = cliente
                values(1) = Me.park
                values(2) = "Costo de la Entrada con código " & ent & " y placa  -" & placa
                values(3) = valor
                values(4) = Me.user
                db.query("insert into cl_saldo (usu_Cont,par_codi,sal_desc,sal_valor,sal_Fecha,sal_abon,emp_nusu) values(" &
                         "@clien,@park,@desc,@valor,now(),0,@user) ", param, values)
            End If

            Dim parameter(0)
            parameter(0) = ent
            '    Dim p As New VisorReportes(db.getvalue("select rpt_ruta from em_repo where rpt_codi=3"), parameter)
            Dim q As New RPTSalidas(ent)
            q.Show()
        End If
        '   Me.Timer2_Tick(Nothing, Nothing)
        Me.PlacaText.Clear()
        Me.cargarlistas()

    End Sub
    Public Function hasCapacity(park As Int16, tipovehiculo As Int64) As Boolean
        Dim param(1) As String
        Dim values(1) As String
        param = "@park,@tiv".Split(",")
        values(0) = park
        values(1) = tipovehiculo
        If 0 = db.getvalue("select ifnull(max(cap_limi),0) from em_capa where par_codi=@park and tiv_codi=@tiv", param, values) Then
            Return True
        Else
            Dim cantmax As Int32
            Dim cantact As Int32
            cantmax = db.getvalue("select cap_cant from em_capa where par_codi=@park and tiv_codi=@tiv", param, values)
            cantact = db.getvalue("select count(*) from co_entr where ent_sali is null and par_codi=@park and tiv_codi=@tiv", param, values)
            If cantmax > cantact Then
                Return True
            Else
                Return False
            End If
        End If
        Return 0
    End Function
    Public Function getTipoServicio(cliente As Int64) As Int64
        Return db.getvalue("select ifnull(max(tse_codi),(select max(tse_codi) from co_tser where tse_defau=1)) from co_serv where ser_esta=1 and usu_Codi = @cliente ", "@cliente", cliente)

    End Function
    Public Function getCliente(placa As String, p As Boolean) As Int64
        Dim z As Int64
        z = getCliente(placa)
        If 0 = db.getvalue("select count(*) from co_entr where usu_cont=@usuario and ent_sali is null", "@usuario", z) Then
            Return z
        Else
            Return db.getvalue("select max(usu_cont) from cl_usua where usu_defa=1")
        End If
    End Function
    Public Function getCliente(placa As String) As Int64
        Dim z As Int64
        z = db.getvalue("select ifnull(max(usu_cont),(select max(usu_cont) from cl_usua where usu_defa=1)) usu_Cont from cl_usvh where USV_PLACA = @placa and usv_acti=1", "@placa", placa)
        Return z
    End Function
    Public Function getTipoVehiculo(placa As String) As Int64
        Dim q() As Char
        q = placa.ToCharArray
        Dim vre As String = ""
        For p = 0 To q.Length - 1
            If Asc(q(p)) >= Asc("A") And Asc(q(p)) <= Asc("Z") Then
                vre &= "A"
            End If
            If Asc(q(p)) >= Asc("0") And Asc(q(p)) <= Asc("9") Then
                vre &= "#"
            End If
        Next
        Return db.getvalue("select ifnull(max(tiv_codi),-1) from vh_espe where esp_desc=@verif", "@verif", vre)
    End Function

    Private Sub ListaMotos_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles ListaMotos.SelectionChanged, Listaautos.SelectionChanged, ListaOtros.SelectionChanged
        Try
            Dim placa As String = e.AddedItems(0).desc.ToString.ToUpper
            Me.PlacaText.Text = placa
            Me.BtnRegistrar.Focus()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As RoutedEventArgs) Handles BtnConsultar.Click
        Dim z As Int64 = db.getvalue("select ifnull(max(ent_codi),0) from co_entr where trim(ent_plac)=@placa and par_codi=" & Me.park, "@placa", Me.PlacaText.Text.ToUpper.Trim)
        If 0 <> z Then
            Dim p As New Entrada(Me.user, z)
            p.ShowDialog()

        End If
    End Sub

    Private Sub BtnAdicionales_Click(sender As Object, e As RoutedEventArgs) Handles BtnAdicionales.Click
        If Me.PlacaText.Text <> "" Then
            Try
                Dim ent As Int64
                ent = db.getvalue("select ent_codi from co_entr where ucase(ent_plac)=@placa and ent_sali is null and par_codi=" & Me.park, "@placa", Me.PlacaText.Text.ToUpper.Trim())
                Dim q As New Adicionales(Me.user, ent, Me.PlacaText.Text.ToUpper.Trim, Me.park)
                q.Show()
            Catch ex As Exception
                Dim q As New Adicionales(Me.user, Me.park)
                q.Show()
            End Try
        Else
            Dim q As New Adicionales(Me.user, Me.park)
            q.Show()
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim q As New RptEstadoActual()
        q.ShowDialog()
    End Sub

    Private Sub BtnTiempo_Click(sender As Object, e As RoutedEventArgs) Handles BtnTiempo.Click
        If Me.PlacaText.Text <> "" Then
            Try
                Dim ent As Int64
                ent = db.getvalue("select ent_codi from co_entr where ucase(ent_plac)=@placa and ent_sali is null", "@placa", Me.PlacaText.Text.ToUpper.Trim)
                Dim q As New ShowTiMe(ent)
                q.ShowDialog()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnInfTurno_Click(sender As Object, e As RoutedEventArgs) Handles btnInfTurno.Click
        Dim q As New RptTurnoFrm(Me.park)
        q.ShowDialog()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As RoutedEventArgs) Handles btnAdmin.Click
        Dim q As New MenuAdministracion(Me.user)
        q.ShowDialog()
    End Sub

    Private Sub btnComercial_Click(sender As Object, e As RoutedEventArgs) Handles btnComercial.Click
        Dim q As New MenuComercial(user, Me.park)
        q.ShowDialog()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As RoutedEventArgs) Handles btnServicios.Click
        Dim q As New CreacionServicios(user, Me.park)
        q.ShowDialog()
    End Sub

    Private Sub btnAbonos_Click(sender As Object, e As RoutedEventArgs) Handles btnAbonos.Click
        Dim q As New Aportes(user, Me.park)
        q.ShowDialog()
    End Sub

    Private Sub btnInformes_Click(sender As Object, e As RoutedEventArgs) Handles btnInformes.Click
        Dim q As New Reportes(Me.park)
        q.ShowDialog()
    End Sub
End Class

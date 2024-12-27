Imports MySql.Data.MySqlClient
Public Class ProcesoCostos
    Dim mon_min = (New db).getvalue("select min(moa_valor) from em_moac")
    Dim matriz(3000, 4) As Single
    Dim tari As Int64
    Dim entrada As Int64
    Dim costotarifamenor As Single
    Dim rangos(6, 1) As Object
    Dim fechai As Date
    Dim perno As Single
    Dim basepag As Int64 = 0
    Dim valmax As Int64
    Public Sub New()
        tari = -1
    End Sub
    Public Sub addrango(dia_cont As Int16, horai As TimeSpan, horaf As TimeSpan)
        rangos(dia_cont - 1, 0) = horai
        rangos(dia_cont - 1, 1) = horaf
    End Sub
    Public Sub New(costos As ProcesoCostos)
        Me.tari = costos.tari
        For p = 0 To 6
            Try
                Me.rangos(p, 0) = costos.rangos(p, 0)
                Me.rangos(p, 1) = costos.rangos(p, 1)
            Catch ex As Exception

            End Try
       
        Next
        For q = 0 To 3000
            For w = 0 To 1
                Me.matriz(q, w) = costos.matriz(q, w)
            Next
            Me.matriz(q, 2) = 0
            Me.matriz(q, 3) = 0
            Me.matriz(q, 4) = 0
        Next
        Me.valmax = costos.valmax
        Me.perno = costos.perno


    End Sub
    Public Sub New(entrada As Int64)
        tari = -1
        Dim db As New db
        Me.entrada = entrada
        Dim lector As MySqlDataReader
        Dim acum As Int64 = 0

        Dim tser As Int64
        Dim tiv As Int64
        Dim park As Int64
        Dim tcli As Int64
        basepag = 0
        ' basepag = (New db).getvalue("select ifnull(sum(dva_cost),0) from co_denva, co_dvala where co_denva.VAL_CONT= co_dvala.VAL_CONT and co_dvala.dva_acti=1 and co_dvala.DVA_COST=(select max(DVA_COST) from co_dvala dv where dv.val_Cont=co_dvala.VAL_CONT) and co_denva.ENT_CODI=@entr", "@entr", entrada)
        lector = db.fetch("select ent_entr,tse_codi, tiv_codi, par_Codi, (select tic_codi from cl_usua where usu_Cont= co_entr.usu_cont) from co_entr where ent_codi=" & entrada)
        While lector.Read
            Me.fechai = lector.GetValue(0)
            tser = lector.GetValue(1)
            tiv = lector.GetValue(2)
            park = lector.GetValue(3)
            tcli = lector.GetValue(4)
        End While
        lector.Close()
        Dim addmin As Int32
        addmin = db.getvalue("select tip_tesp from cl_tipo where tic_codi=@tclien", "@tclien", tcli)
        Me.fechai = Me.fechai.AddMinutes(addmin)
        addmin = db.getvalue("select tse_tgrac from co_tser where tse_codi=@tse", "@tse", tser)
        Me.fechai = Me.fechai.AddMinutes(addmin)
        lector = db.fetch("select dia_cont,dat_hini,dat_hfina from em_Daten where par_codi=" & park & " order by dia_Cont asc")
        While lector.Read
            Me.addrango(lector.GetValue(0), lector.GetValue(1), lector.GetValue(2))
        End While
        lector.Close()
        Dim sql As String
        Dim tiempodesc As Integer = db.getvalue("select ifnull(sum(co_dvala.DVA_DMINU),0)  from co_denva, co_dvala where co_denva.VAL_CONT= co_dvala.VAL_CONT and co_dvala.dva_acti=1 and co_dvala.DVA_dminu=(select min(DVA_dminu) from co_dvala dv where dv.val_Cont=co_dvala.VAL_CONT) and co_denva.ENT_CODI=@ent", "@ent", entrada)
        Me.fechai = Me.fechai.AddMinutes(tiempodesc)
        lector.Close()
        sql = "select tar_laps, tar_cost from co_tari where tar_Acti=1 and par_Codi=" & park & " and tic_codi=" & tcli & " and tiv_codi=" & tiv & " and tse_codi=" & tser
        lector = db.fetch(sql)
        While lector.Read
            Me.addTarifa(lector.GetValue(1), lector.GetValue(0))
        End While
        lector.Close()
        Dim parameter() As String = "@park,@tcli,@tive".Split(",")
        Dim values(2) As Object
        values(0) = park
        values(1) = tcli
        values(2) = tiv
        Me.valmax = 9999999999
        Try
            Me.valmax = db.getvalue("select ifnull(max(dcm_cost),-1) from co_dcmax where tic_codi=" & tcli & " and tiv_codi=" & tiv & " and dcm_acti=1")
        Catch ex As Exception

        End Try

        perno = db.getvalue("select ifnull(max(dpe_cost),0) from co_dpern where par_codi=@park and tic_codi=@tcli and tiv_codi=@tive and dpe_acti=1", parameter, values)
    End Sub
    Public Function getCosto(fechaf As DateTime) As Int64
        Dim ftemp As DateTime
        ftemp = Me.fechai
        Dim ac As Int64
        Dim ctem As Int64
        Dim tiempo As TimeSpan
        While ftemp.Date < fechaf.Date
            Dim flimi As DateTime
            Dim dsem As Int16
            dsem = flimi.DayOfWeek
            flimi = ftemp.Date
            flimi = flimi.Add(rangos(dsem, 1))
            tiempo = flimi - ftemp
            Dim temp As New ProcesoCostos(Me)
            ctem = temp.getCosto(Convert.ToInt64(tiempo.TotalMinutes) + 1)
            If valmax <> -1 Then
                If ctem > valmax Then
                    ctem = valmax
                End If
            End If
            ac += ctem
            ac += perno
            ftemp = ftemp.Date.AddDays(1)
            ftemp = ftemp.Add(rangos(dsem, 0))
        End While
        tiempo = fechaf - ftemp
        ctem = getCosto(Convert.ToInt64(tiempo.TotalMinutes) + 1)
        If valmax <> -1 Then
            If ctem > valmax Then
                ctem = valmax
            End If
        End If
        ac += ctem
        If ac Mod mon_min > 0 Then
            ac += mon_min - (ac Mod mon_min)
        End If
        Return ac
    End Function
    Public Function getCosto(fechaf As DateTime, valido As Boolean) As Int64
        Dim ac As Int64 = 0
        Dim fechatemp As DateTime
        fechatemp = fechai.Date

        Dim dsem As Int16
        dsem = fechai.DayOfWeek
        fechatemp = fechatemp.Add(rangos(dsem, 1))
        Dim tar As Boolean = False
        While Not tar
            If fechai.Date < fechaf.Date Then
                ac += perno
            Else
                fechatemp = fechaf
                tar = True
            End If
            Dim lapso As TimeSpan
            If fechai > fechaf Then
                lapso = Now - Now
            Else
                lapso = fechatemp - fechai
            End If
            ac += getCosto(lapso.TotalMinutes)
            fechai = fechai.Date.AddDays(1)
            dsem = fechai.DayOfWeek
            fechai = fechai.Add(rangos(dsem, 0))
            fechatemp = fechatemp.Date.AddDays(1)
            fechatemp = fechatemp.Add(rangos(dsem, 1))
        End While
        Return ac + Me.basepag
    End Function
    Public Sub addTarifa(costo As Int64, tiempo As Int64)
        tari += 1
        matriz(tari, 0) = tiempo
        matriz(tari, 1) = costo
        If tari = 0 Then
            Me.costotarifamenor = costo
        Else
            If costo < Me.costotarifamenor Then
                Me.costotarifamenor = costo
            End If
        End If
    End Sub
    Public Function getCosto(estancia As Int64) As Int64
        If tari = -1 Then
            Return -1
            Exit Function
        End If
        Dim minrow As Int16
        Dim temp As ProcesoCostos
        While estancia > 0
            For q = 0 To tari
                'fracciones completas
                Dim time As Int64
                Dim factible As Int64
                time = estancia - (estancia Mod matriz(q, 0))
                matriz(q, 2) = Convert.ToInt32(time / matriz(q, 0))
                If matriz(q, 2) = 0 Then
                    matriz(q, 2) = 1
                End If
                If estancia <= (matriz(q, 2) * matriz(q, 0)) Then
                    factible = 0
                Else
                    If Me.entrada >= 1 Then
                        temp = New ProcesoCostos(Me)
                    Else
                        temp = New ProcesoCostos()
                        temp.rangos = Me.rangos
                        temp.tari = Me.tari
                        For u = 0 To Me.tari
                            For i = 0 To 4
                                If i <> 2 Then
                                    temp.matriz(u, i) = Me.matriz(u, i)
                                Else
                                    temp.matriz(u, 2) = 0
                                End If
                            Next
                        Next
                    End If
                    factible = temp.getCosto(estancia - matriz(q, 2) * matriz(q, 0))
                End If
                matriz(q, 3) = matriz(q, 2) * matriz(q, 1) + factible
                If q = 0 Then
                    minrow = q
                Else
                    If matriz(q, 3) < matriz(minrow, 3) Then
                        minrow = q
                    End If
                End If
            Next
            matriz(minrow, 4) += matriz(minrow, 2)
            estancia = estancia - (matriz(minrow, 0) * matriz(minrow, 2))
        End While
        Dim ac As Int64 = 0
        For p = 0 To tari
            ac += matriz(p, 4) * matriz(p, 1)

        Next
        Return ac
    End Function
End Class

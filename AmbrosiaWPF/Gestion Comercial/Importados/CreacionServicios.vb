Public Class CreacionServicios
    Dim user As String
    Dim db As New db
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.user = "ADMIN"
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Dim park As Int32
    Public Sub New(user As String, park As Int32)
        Me.InitializeComponent()
        Me.user = user
        Me.park = park
    End Sub
    Private Sub CreacionServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cs1 As New CreacionServicios1(Me.user)
        cs1.ShowDialog()
        If Not cs1.getvalid Then
            MsgBox("No se diligenciaron los datos completamente")
            Me.Close()
            Exit Sub
        End If
        Dim cs2 As New CreacionServicios2(Me.user)
        cs2.ShowDialog()
        If Not cs2.getvalid Then
            MsgBox("No se diligenciaron los datos completamente")
            Me.Close()
            Exit Sub
        End If
        Try
            Dim sql As String
            sql = "insert into co_serv (tse_codi,ser_feci,ser_fecf,comentario,usu_codi,ser_esta,ser_fecc,ser_cost,emp_nusu) " _
                & " values (@tse_codi,@ser_feci,@ser_fecf,@comentario,@usu_codi,1,now(),@costo,@user)"
            Dim parametros(6) As String
            parametros = "@tse_codi,@ser_feci,@ser_fecf,@comentario,@usu_codi,@costo,@user".Split(",")
            Dim valores(6) As Object
            valores(0) = cs2.ListBox1.SelectedValue
            valores(1) = cs2.DateTimePicker1.Value.Date
            valores(2) = cs2.DateTimePicker2.Value.Date
            valores(3) = "" & cs2.TextBox2.Text
            valores(4) = cs1.getCliente
            valores(5) = cs2.TextBox1.Text
            valores(6) = Me.user
            db.query(sql, parametros, valores)
        Catch ex As Exception
            MsgBox("Se ha presentado un problema" & vbNewLine & ex.Message)
            Exit Sub
        End Try
        Dim param() As String = "@clien,@park,@desc,@valor,@user".Split(",")
        Dim values(4) As Object
        values(0) = cs1.getCliente
        values(1) = Me.park
        values(2) = "Registro de servicio al cliente " & db.getvalue("Select usu_nomb from cl_usua where usu_cont=@cliente ", "@cliente", cs1.getCliente) & " con un costo de " & cs2.TextBox1.Text
        values(3) = cs2.TextBox1.Text
        values(4) = user
        db.query("insert into cl_saldo (usu_Cont,par_codi,sal_desc,sal_valor,sal_Fecha,sal_abon,emp_nusu) values(" & _
                 "@clien,@park,@desc,@valor,now(),0,@user) ", param, values)
        MsgBox("Se ha agregado el servicio correctamente")
        Dim q As New RptServiciosFRM(db.getvalue("select usu_codi from cl_usua where usu_cont =@cliente", "@cliente", cs1.getCliente))
        q.Show()
        Me.Close()
    End Sub
End Class
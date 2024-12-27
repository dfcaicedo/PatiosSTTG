Public Class CreaciondeUsuarios
    Dim user As String
    Dim db As New db
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Me.user = "admin"
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(user As String)
        Me.InitializeComponent()
        Me.user = user
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cu1 As New CreacionUsuario1(Me.user)
        cu1.ShowDialog()
        If Not cu1.getvalid Then
            MsgBox("Se ha cancelado el proceso")
            Me.Close()
            Exit Sub

        End If
        Dim cu2 As New CreacionUsuario2(Me.user)
        cu2.ShowDialog()
        If Not cu2.getvalid Then
            MsgBox("Se ha cancelado el proceso")
            Me.Close()
            Exit Sub
        End If
        Dim cu3 As New CreacionUsuario3(Me.user)
        cu3.ShowDialog()
        If Not cu3.getvalid Then
            MsgBox("Se ha cancelado el proceso")
            Me.Close()
            Exit Sub
        End If
        Try
            Dim sql As String
            sql = "Insert into cl_usua (usu_codi,tii_codi,usu_nomb,usu_dire,usu_tele,tic_codi,emp_nusu,usu_sald,usu_carte,usu_defa) " _
                 & "values (@usu_codi,@tii_codi,@usu_nomb,@usu_dire,@usu_tele,@tic_codi,@user,0,@usu_carte,0)"
            Dim values(7) As Object
            Dim parameter(7) As String
            parameter(0) = "@usu_Codi"
            values(0) = cu1.getNumeroDocumento
            parameter(1) = "@tii_codi"
            values(1) = cu1.getTipoIdentificacion
            parameter(2) = "@usu_nomb"
            values(2) = cu1.getNombre
            parameter(3) = "@usu_dire"
            values(3) = cu1.getDireccion
            parameter(4) = "@usu_tele"
            values(4) = cu1.getTelefono
            parameter(5) = "@tic_codi"
            values(5) = cu2.getTipoCliente
            parameter(6) = "@user"
            values(6) = Me.user
            parameter(7) = "@usu_carte"
            values(7) = cu2.getCartera
            db.query(sql, parameter, values)
            Try
                For p = 0 To cu3.DataGridView1.RowCount - 1
                    Dim placa As String
                    placa = cu3.DataGridView1.Item(0, p).Value.ToString.ToUpper.Replace(" ", "")
                    sql = "update cl_usvh set usv_acti=0,usu_fdes=now() where upper(usv_placa) = upper(@placa) and usv_acti=1"
                    db.query(sql, "@placa", placa)
                    sql = "insert into cl_usvh values ((select max(usu_Cont) from cl_usua), @placa,now(),null,1,'" & Me.user & "')"
                    db.query(sql, "@placa", placa)
                Next
            Catch ex As Exception
          
            End Try
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        MsgBox("Se ha registrado el usuario correctamente")
        Me.Close()
    End Sub
End Class
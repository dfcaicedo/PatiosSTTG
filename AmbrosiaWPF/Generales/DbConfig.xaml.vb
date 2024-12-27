Imports MySql.Data.MySqlClient
Imports System.IO
Public Class DbConfig
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If ServerTxt.Text <> "" And UserTxt.Text <> "" Then
            Dim cnt As MySqlConnection
            Dim cs As New MySqlConnectionStringBuilder
            cs.Server = ServerTxt.Text
            cs.UserID = UserTxt.Text
            If PassTxt.Password.Length > 0 Then
                cs.Password = PassTxt.Password
            End If

            '  cs.SslMode = MySqlSslMode.None


            Try
                cnt = New MySqlConnection(cs.ConnectionString)
                cnt.Open()
                Dim cmd As New MySqlCommand("show databases", cnt)
                Dim lector As MySqlDataReader = cmd.ExecuteReader
                Me.dblist.Items.Clear()
                While lector.Read
                    Me.dblist.Items.Add(lector.GetValue(0))
                End While
                lector.Close()
                cnt.Close()

            Catch ex As Exception
                MsgBox("No se ha podido establecer la conexión" & vbNewLine & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim cnt As MySqlConnection
        Dim cs As New MySqlConnectionStringBuilder
        Try
            cs = New MySqlConnectionStringBuilder
            cs.Server = Me.ServerTxt.Text
            cs.UserID = Me.UserTxt.Text
            cs.Password = Me.PassTxt.Password
            cs.Database = dblist.SelectedItem.ToString
            'cs.SslMode = MySqlSslMode.None
            cnt = New MySqlConnection(cs.ConnectionString)
            cnt.Open()
            cnt.Close()
            Dim vari As String
            vari = (New TripleDES).Encrypt(cs.ConnectionString)
            Dim file As New StreamWriter("Settings.conf")
            file.WriteLine(vari)
            file.Close()
            MsgBox("Se ha modificado el archivo setting.conf")
        Catch ex As Exception

        End Try
    End Sub
End Class

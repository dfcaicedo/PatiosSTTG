Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Windows.Shell
Imports System.IO
Public Class db
    Dim cnt As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim sql As String
    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean
    Public Sub query(sql As String, parametro As String, valor As Object)
        cmd = New MySqlCommand(sql, Me.cnt)
        cmd.Parameters.AddWithValue(parametro, valor)
        Me.open()
        cmd.ExecuteNonQuery()
        Me.close()
    End Sub
    Public Sub query(sql As String, parameter() As String, values() As Object)
        cmd = New MySqlCommand(sql, Me.cnt)
        For p = 0 To parameter.Length - 1
            cmd.Parameters.AddWithValue(parameter(p), values(p))
        Next
        Me.open()
        cmd.ExecuteNonQuery()
        Me.close()
    End Sub
    Public Sub ClearMemory()
        Try
            Dim Mem As Process
            Mem = Process.GetCurrentProcess()
            SetProcessWorkingSetSize(Mem.Handle, -1, -1)
        Catch ex As Exception
            'Control de errores
        End Try
    End Sub
    Public Function getConnectionString() As String
        Try
            Dim crypto As New TripleDES
            Dim lector As StreamReader
            lector = New StreamReader("Settings.conf")
            getConnectionString = lector.ReadToEnd
            lector.Close()
            Return crypto.Decrypt(getConnectionString)
        Catch ex As Exception
            Dim config As New DbConfig
            config.ShowDialog()
            End
        End Try
    End Function
    Public Sub New()
        '  cnt = New MySqlConnection(My.Settings.ambrosiapark_proConnectionString)
        ' cmd = New MySqlCommand("", cnt)
        cnt = New MySqlConnection(Me.getConnectionString)
        cmd = New MySqlCommand("", cnt)
        Try
            Me.open()
            Me.close()
        Catch ex As Exception
            '   Shell("del Settings.conf")
            MsgBox("No se tiene Acceso a la Base de datos")
            End
        End Try
    End Sub
    Public Function getconnection() As MySqlConnection
        Return Me.cnt
    End Function
    Public Sub open()
        Try
            If Me.cnt.State = System.Data.ConnectionState.Closed Then
                Me.cnt.Open()
            End If
        Catch ex As Exception
            MsgBox("No se tiene acceso a la base de datos")
        End Try
    End Sub
    Public Sub killsleep()
        Me.open()
        Dim s As String = ""
        Dim reader As MySqlDataReader = Me.fetch("SHOW PROCESSLIST")
        While reader.Read
            Dim p As String
            p = reader.GetValue(4).ToString.ToUpper
            If p = "SLEEP" Then
                s = s & reader.GetValue(0) & " "
            End If
        End While
        reader.Close()
        s = s.Trim
        Dim po() As String
        po = s.Split()
        If po.Length > 1 Then
            For a As Integer = 0 To po.Length - 1
                Try
                    Me.query("kill " & po(a))
                Catch ex As Exception
                End Try

            Next
        End If
        Me.close()
    End Sub


    Public Sub close()
        Try
            If Me.cnt.State = System.Data.ConnectionState.Open Then

                Me.cnt.Close()
            End If
        Catch ex As Exception

        End Try
        Try
            MySqlConnection.ClearPool(Me.cnt)
        Catch ex As Exception

        End Try
    End Sub

    Public Function insert(ByVal tabla As String, ByVal values() As Object) As Boolean
        Try
            For a As Integer = 0 To values.Length - 1
                values(a).ToString.ToUpper()
            Next
            sql = "insert into " & tabla & " values (" & String.Join(",", values) & ")"
            Me.execute()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Public Sub execute()
        Me.open()
        sql = sql.Replace("'CURRENT_TIMESTAMP'", "CURRENT_TIMESTAMP")
        sql = sql.Replace("''", "'")
        cmd.CommandText = sql
        cmd.ExecuteNonQuery()
        Me.close()
    End Sub
    Public Function getvalue(ByVal sql As String, parameter As String, value As Object) As Object
        ' Dim p As Object
        Me.cmd = New MySqlCommand("", Me.cnt)
        cmd.CommandText = sql
        cmd.Parameters.AddWithValue(parameter, value)
        Me.open()
        reader = cmd.ExecuteReader
        reader.Read()
        Dim valu = reader.GetValue(0)
        reader.Close()
        Me.close()
        Return valu
    End Function
    Public Function getvalue(ByVal sql As String, parameter As String(), value As Object()) As Object
        ' Dim p As Object
        Me.cmd = New MySqlCommand("", Me.cnt)
        cmd.CommandText = sql
        For q = 0 To parameter.Length - 1
            cmd.Parameters.AddWithValue(parameter(q), value(q))
        Next
        Me.open()
        reader = cmd.ExecuteReader
        reader.Read()
        Dim valu = reader.GetValue(0)
        reader.Close()
        Me.close()
        Return valu
    End Function
    Public Function getvalue(ByVal sql As String) As Object
        ' Dim p As Object
        Me.cmd = New MySqlCommand("", Me.cnt)

        cmd.CommandText = sql
        Me.open()
        reader = cmd.ExecuteReader
        reader.Read()
        Dim value = reader.GetValue(0)
        reader.Close()
        Me.close()
        Return value
    End Function
    Public Function fetch() As MySqlDataReader
        cmd.CommandText = sql
        Return cmd.ExecuteReader
    End Function
    Public Function fetch(ByVal sql As String) As MySqlDataReader
        Me.open()
        cmd.CommandText = sql
        Return cmd.ExecuteReader
    End Function
    Public Sub find(ByVal tabla As String, ByVal valor As String)
        sql = "Desc " & tabla
        Dim campos() As String = Nothing
        Me.open()
        cmd.CommandText = sql
        Me.reader = cmd.ExecuteReader
        While Me.reader.Read
            If campos Is Nothing Then
                ReDim campos(0)
            Else
                ReDim Preserve campos(campos.Length)
            End If
            campos(campos.Length - 1) = Me.reader.GetValue(0)
        End While
        sql = "select * from " & tabla & " where "
        For a As Integer = 0 To campos.Length - 1
            If a = campos.Length - 1 Then
                sql &= campos(a) & " like '%" & valor & "%'"
            Else
                sql &= campos(a) & " like '%" & valor & "%' or "
            End If
        Next
    End Sub
    Public Sub find(ByVal tabla As String, ByVal campo As String, ByVal value As String)
        sql = "select * from " & tabla & " where " & campo & " like '%" & value & "%'"
    End Sub
    Public Sub find(ByVal tabla As String, ByVal expresion As Object)
        sql = "Select * from " & tabla & " where " & expresion
    End Sub
    Public Sub find(ByVal tabla As String, ByVal campos() As String, ByVal values As String)
        sql = "Select " & String.Join(",", campos) & " from " & tabla
        For a As Integer = 0 To campos.Length - 1
            If a = campos.Length - 1 Then
                sql &= campos(a) & " like '%" & values & "%'"
            Else
                sql &= campos(a) & " like '%" & values & "%' or "
            End If
        Next
    End Sub
    Public Sub find(ByVal tabla As String, ByVal campos() As String, ByVal valor As String, ByVal camporeferente As String)
        sql = "Select " & String.Join(",", campos) & "from " & tabla & " where " & camporeferente & " like '%" & valor & "%"
    End Sub
    Public Sub insert(ByVal tabla As String, ByVal campos() As String, ByVal values() As String)
        Me.sql = "insert into " & tabla & " (" & String.Join(",", campos) & " ) values (" & String.Join(",", values) & ")"
        Me.execute()
    End Sub
    Public Sub update(ByVal tabla As String, ByVal campos() As String, ByVal values() As String, ByVal condition As String)
        sql = "update " & tabla & " set "
        For a As Integer = 0 To campos.Length - 1
            If a = campos.Length - 1 Then
                sql &= campos(a) & "=" & values(a) & ""
            Else
                sql &= campos(a) & "=" & values(a) & ","
            End If
        Next
        sql &= " where " & condition
        Me.execute()
    End Sub
    Public Sub update(ByVal tabla As String, ByVal campo As String, ByVal value As String, ByVal condition As String)
        sql = "update " & tabla & " set "
        sql &= campo & "=" & value
        sql &= " where " & condition
        Me.execute()
    End Sub

    Public Sub query(ByVal sql As String)
        Me.sql = sql
        Me.execute()
    End Sub
End Class




Imports System.IO
Imports MySql.Data.MySqlClient

Class MainWindow
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Dim screenwidth As Int16
        Dim screenheigth As Int16
        screenheigth = System.Windows.SystemParameters.PrimaryScreenHeight
        screenwidth = System.Windows.SystemParameters.PrimaryScreenWidth
        Me.Top = screenheigth / 2 - Me.Height / 2
        Me.Left = screenwidth / 2 - Me.Width / 2
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.UserText.Focus()
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Try
            Dim cnt As MySqlConnection
            cnt = New MySqlConnection((New db).getConnectionString)
            Dim cmd As New MySqlCommand("select count(*) from em_empl where emp_nusu=@user and emp_pass=sha1(@pass)", cnt)
            Try

                Dim value As Int16
                cmd.Parameters.AddWithValue("@user", Me.UserText.Text)
                cmd.Parameters.AddWithValue("@pass", Me.Passtext.Password)
                cnt.Open()
                Dim lector As MySqlDataReader = cmd.ExecuteReader
                While lector.Read

                    value = lector.GetValue(0)
                End While
                lector.Close()
                cnt.Close()
                If value = 1 Then
                    Dim q As New MenuPrincipal(Me.UserText.Text)
                    q.ShowDialog()
                    End
                Else
                    MsgBox("No Login")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Passtext_KeyUp(sender As Object, e As KeyEventArgs) Handles Passtext.KeyUp
        If e.Key = Key.Enter Then
            Button_Click(sender, Nothing)
        End If
    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        If Not File.Exists("Settings.conf") Then
            MessageBox.Show("No existe archivo de Configuración")
            Dim q As New DbConfig
            q.ShowDialog()
            End
        End If

    End Sub
End Class

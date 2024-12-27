Imports MySql.Data.MySqlClient

Public Class Tarifas
    Dim tarifas As New List(Of Tarifa)
    Dim actualpage As Integer = 1
    Dim limitpage As Integer
    Dim user As String
    Dim park As Integer
    Dim connectionstring As String = (New db).getConnectionString
    Public Sub New(user As String, park As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.user = user
        Me.park = park
        RecargarDatos()

        showtarifas()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub showtarifas()
        Dim mostrar = tarifas.Skip((actualpage - 1) * 20).Take(20).ToList
        Me.TarifasListView.ItemsSource = Nothing
        Me.TarifasListView.ItemsSource = mostrar
        Me.PageIndicator.Text = $"Página {actualpage} de {limitpage}"

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If Me.actualpage > 1 Then
            Me.actualpage -= 1
            showtarifas()
        End If
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        If Me.actualpage < Me.limitpage Then
            Me.actualpage += 1
            Me.showtarifas()
        End If
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim q As New Co_tariMOD(user, park)
        q.tar_codi = -1
        q.par_Codi = park
        q.emp_nusu = user
        q.tar_agno = DateTime.Now.Year
        Dim frm As New UpdateTarifa(q)
        frm.ShowDialog()
        Me.actualpage = 1
        RecargarDatos()
        showtarifas()

    End Sub


    ' Método para manejar el evento "Actualizar"
    Private Sub OnActualizarClick(sender As Object, e As RoutedEventArgs)
        Dim tarifaSeleccionada As Tarifa = CType(DirectCast(sender, Button).DataContext, Tarifa)

        If tarifaSeleccionada IsNot Nothing Then

            Dim q As Co_tariMOD = getCo_tari(tarifaSeleccionada.tar_Codi)
            ' Abrir ventana de actualización
            Dim frm As New UpdateTarifa(q)
            frm.ShowDialog()

            ' Recargar datos después de la actualización
            RecargarDatos()
        End If
    End Sub

    ' Método para manejar el evento "Eliminar"
    Private Sub OnEliminarClick(sender As Object, e As RoutedEventArgs)
        Dim tarifaSeleccionada As Tarifa = CType(DirectCast(sender, Button).DataContext, Tarifa)

        If tarifaSeleccionada IsNot Nothing Then
            ' Mostrar mensaje de confirmación
            Dim resultado As MessageBoxResult = MessageBox.Show(
            $"¿Está seguro de que desea eliminar la tarifa {tarifaSeleccionada.TipoNombre} - {tarifaSeleccionada.TipoVehiculoNombre}?",
            "Confirmación",
            MessageBoxButton.YesNo,
            MessageBoxImage.Question
        )

            If resultado = MessageBoxResult.Yes Then
                Try
                    ' Eliminar la tarifa de la base de datos
                    Using cnt As New MySqlConnection(Me.connectionstring)
                        cnt.Open()
                        Dim query As String = "DELETE FROM co_tari WHERE tar_codi = @TAR_CODI"
                        Using cmd As New MySqlCommand(query, cnt)
                            cmd.Parameters.AddWithValue("@TAR_CODI", tarifaSeleccionada.tar_Codi)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show("Tarifa eliminada correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information)

                    ' Recargar datos después de la eliminación
                    RecargarDatos()
                Catch ex As Exception
                    MessageBox.Show($"Error al eliminar la tarifa: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
                End Try
            End If
        End If
    End Sub

    ' Método para recargar los datos del ListView
    Private Sub RecargarDatos()
        Me.tarifas.Clear()
        Dim cnt As New MySqlConnection(connectionstring)
        Dim cmd As MySqlCommand = cnt.CreateCommand
        cmd.CommandText = $"select
	TIC_NOMB,
    tiv_nomb,
    tse_nomb,
    tar_agno,
    tar_cost,
    tar_codi
from
	co_tari
inner join cl_tipo on (cl_tipo.TIC_CODI= co_tari.TIC_CODI)
inner join vh_tipos on (vh_tipos.TIV_CODI=co_tari.TIV_CODI)
inner join co_tser on (co_tser.TSE_CODI=co_tari.TSE_CODI)
where co_tari.par_codi={park} 
order by TAR_AGNO, tic_nomb, tiv_nomb"
        Try
            cnt.Open()
            Using lector As MySqlDataReader = cmd.ExecuteReader
                While lector.Read()
                    Dim tari As New Tarifa
                    With tari
                        .TipoNombre = lector.GetString(0)
                        .TipoVehiculoNombre = lector.GetString(1)
                        .TipoServicioNombre = lector.GetString(2)
                        .AnioTarifa = lector.GetInt32(3)
                        .CostoTarifa = lector.GetInt64(4)
                        .tar_Codi = lector.GetInt32(5)
                    End With
                    tarifas.Add(tari)
                End While
            End Using
            cnt.Close()
        Catch ex As Exception

        End Try
        Dim q As Integer
        q = tarifas.Count() / 20
        If q * 20 < tarifas.Count() Then
            q += 1
        End If
        Me.PageIndicator.Text = $"Página {actualpage} de {limitpage}"
        Me.limitpage = q
        showtarifas()
    End Sub
    Public Function getCo_tari(tarifa As Int32) As Co_tariMOD
        Dim q As Co_tariMOD
        Using cnt As New MySqlConnection(connectionstring)
            Try
                cnt.Open()
                Using cmd As MySqlCommand = cnt.CreateCommand
                    cmd.CommandText = $"select * from co_tari where tar_codi={tarifa}"
                    Using lector As MySqlDataReader = cmd.ExecuteReader
                        While lector.Read
                            q = New Co_tariMOD With {
                                .tic_codi = lector.GetInt32(0),
                                .par_Codi = park,
                                .tiv_codi = lector.GetInt32(2),
                                .tar_laps = lector.GetInt32(3),
                                .tar_cost = lector.GetInt64(4),
                                .tar_codi = tarifa,
                                .tse_codi = lector.GetInt32(6),
                                .emp_nusu = user,
                                .tar_acti = 1,
                                .tar_agno = lector.GetInt32(9)
                            }
                        End While
                    End Using
                End Using

            Catch ex As Exception

            End Try
            Return q
        End Using
    End Function

End Class

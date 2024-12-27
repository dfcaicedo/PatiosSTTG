Public Class Reportes
    ReadOnly park As Int64
    Public Sub New(park As Int64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.park = park
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim q As New VistaUltimasEntradas(Me.park)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim q As New VistaUltimasSalidas(Me.park)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim q As New VistaServicios(park)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        Dim q As New frmdeudores
        q.ShowDialog()
    End Sub
End Class

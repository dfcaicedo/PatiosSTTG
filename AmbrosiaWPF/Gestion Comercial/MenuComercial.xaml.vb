Public Class MenuComercial
    Public ReadOnly user As String
    ReadOnly park As Int64
    Public Sub New(user As String, park As Int64)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.user = user
        Me.park = park
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim q As New Tipos_de_Cliente(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim q As New Clientes(user)
        q.ShowDialog()

    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim q As New Pernoctar(user)
        q.ShowDialog()

    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        Dim q As New confpernoctar(user)
        q.ShowDialog()

    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        Dim q As New Tipo_de_Servicios(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_5(sender As Object, e As RoutedEventArgs)
        Dim q As New Tipos_de_Cliente(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_6(sender As Object, e As RoutedEventArgs)
        Dim q As New CreaciondeUsuarios(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_7(sender As Object, e As RoutedEventArgs)
        Dim q As New CreacionServicios(user, Me.park)
        q.ShowDialog()

    End Sub

    Private Sub Button_Click_8(sender As Object, e As RoutedEventArgs)
        Dim q As New Tarifas(user, Me.park)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_9(sender As Object, e As RoutedEventArgs)
        Dim q As New ValoresAdicionales(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_10(sender As Object, e As RoutedEventArgs)
        Dim q As New testCostos()
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_11(sender As Object, e As RoutedEventArgs)
        Dim q As New Servicios(user)
        q.ShowDialog()
    End Sub
End Class

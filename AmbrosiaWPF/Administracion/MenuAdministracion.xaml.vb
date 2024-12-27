Imports System.Windows.Forms
Public Class MenuAdministracion
    ReadOnly user As String
    Public Sub New(user As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.user = user
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim q As New Parqueaderos(Me.user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        Dim q As New Tipos_de_Cliente(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Dim q As New Puntos_de_Atención(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_3(sender As Object, e As RoutedEventArgs)
        Dim q As New Tipo_de_Vehiculos(user)
        q.ShowDialog()

    End Sub

    Private Sub Button_Click_4(sender As Object, e As RoutedEventArgs)
        Dim q As New Empleados(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_5(sender As Object, e As RoutedEventArgs)
        Dim q As New Cargos(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_6(sender As Object, e As RoutedEventArgs)
        Dim q As New Permisos(user)
        q.ShowDialog()

    End Sub

    Private Sub Button_Click_7(sender As Object, e As RoutedEventArgs)
        Dim q As New Tipo_de_Servicios(user)
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_8(sender As Object, e As RoutedEventArgs)
        Dim q As New Capacidad(user)
        q.Show()
    End Sub

    Private Sub Button_Click_9(sender As Object, e As RoutedEventArgs)
        Dim q As New MonedasActivas()
        q.ShowDialog()
    End Sub

    Private Sub Button_Click_10(sender As Object, e As RoutedEventArgs)
        Dim q As New TipoValoresAdicionales(user)
        q.ShowDialog()

    End Sub

    Private Sub Button_Click_11(sender As Object, e As RoutedEventArgs)
        Dim q As New DbConfig()
        q.ShowDialog()
    End Sub
End Class

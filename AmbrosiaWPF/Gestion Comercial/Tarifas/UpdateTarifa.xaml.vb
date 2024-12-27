Imports MySql.Data.MySqlClient

Public Class UpdateTarifa
    ' Imports MySql.Data.MySqlClient

    Private TarifaActual As Co_tariMOD  ' Objeto modelo que será recibido
    Private ConnectionString As String = (New db).getConnectionString() ' Obtén tu cadena de conexión

    Public Sub New(tarifa As Co_tariMOD)
        InitializeComponent()
        getTipoServicio()
        getTipoCliente()
        getVehiculos()
        ' Asigna el objeto modelo
        TarifaActual = tarifa

        ' Configura la interfaz con los valores iniciales del objeto
        TipoComboBox.SelectedValue = TarifaActual.tic_codi
        VehiculoComboBox.SelectedValue = TarifaActual.tiv_codi
        ServicioComboBox.SelectedValue = TarifaActual.tse_codi
        CostoTextBox.Text = TarifaActual.tar_cost.ToString()
        AnioTextBox.Text = TarifaActual.tar_agno.ToString()
    End Sub

    Private Sub OnGuardarClick(sender As Object, e As RoutedEventArgs)
            Try
                ' Validar entrada del usuario
                If TipoComboBox.SelectedValue Is Nothing OrElse
               VehiculoComboBox.SelectedValue Is Nothing OrElse
               ServicioComboBox.SelectedValue Is Nothing OrElse
               String.IsNullOrWhiteSpace(CostoTextBox.Text) OrElse
               String.IsNullOrWhiteSpace(AnioTextBox.Text) Then

                    MessageBox.Show("Por favor complete todos los campos.", "Validación", MessageBoxButton.OK, MessageBoxImage.Warning)
                    Return
                End If

                ' Mapear los valores desde la interfaz al objeto modelo
                TarifaActual.TIC_CODI = Convert.ToInt32(TipoComboBox.SelectedValue)
                TarifaActual.TIV_CODI = Convert.ToInt32(VehiculoComboBox.SelectedValue)
                TarifaActual.TSE_CODI = Convert.ToInt32(ServicioComboBox.SelectedValue)
                TarifaActual.TAR_COST = Convert.ToDecimal(CostoTextBox.Text)
                TarifaActual.TAR_AGNO = Convert.ToInt32(AnioTextBox.Text)

                ' Llamar al método para guardar o actualizar
                If TarifaActual.TAR_CODI = -1 Then
                    CrearNuevaTarifa(TarifaActual)
                Else
                    ActualizarTarifa(TarifaActual)
                End If

                MessageBox.Show("La tarifa se ha guardado correctamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information)
                Me.Close()
            Catch ex As Exception
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
            End Try
        End Sub

        Private Sub OnCancelarClick(sender As Object, e As RoutedEventArgs)
            Me.Close()
        End Sub

    Private Sub CrearNuevaTarifa(tarifa As Co_tariMOD)
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            Dim query As String = "
                INSERT INTO co_tari (TIC_CODI, TIV_CODI,tar_laps, TSE_CODI, TAR_COST, TAR_AGNO,par_codi,emp_nusu,tar_acti)
                VALUES (@TIC_CODI, @TIV_CODI,1440, @TSE_CODI, @TAR_COST, @TAR_AGNO,@park,@user,1)"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@TIC_CODI", tarifa.tic_codi)
                cmd.Parameters.AddWithValue("@TIV_CODI", tarifa.tiv_codi)
                cmd.Parameters.AddWithValue("@TSE_CODI", tarifa.tse_codi)
                cmd.Parameters.AddWithValue("@TAR_COST", tarifa.TAR_COST)
                cmd.Parameters.AddWithValue("@TAR_AGNO", tarifa.tar_agno)
                cmd.Parameters.AddWithValue("@park", tarifa.par_Codi)
                cmd.Parameters.AddWithValue("@user", tarifa.emp_nusu)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub ActualizarTarifa(tarifa As Co_tariMOD)
        Using connection As New MySqlConnection(ConnectionString)
            connection.Open()
            Dim query As String = "
                UPDATE co_tari
                SET TIC_CODI = @TIC_CODI, TIV_CODI = @TIV_CODI, TSE_CODI = @TSE_CODI, TAR_COST = @TAR_COST, TAR_AGNO = @TAR_AGNO
                WHERE TAR_CODI = @TAR_CODI"
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@TIC_CODI", tarifa.tic_codi)
                cmd.Parameters.AddWithValue("@TIV_CODI", tarifa.tiv_codi)
                cmd.Parameters.AddWithValue("@TSE_CODI", tarifa.tse_codi)
                cmd.Parameters.AddWithValue("@TAR_COST", tarifa.tar_cost)
                cmd.Parameters.AddWithValue("@TAR_AGNO", tarifa.tar_agno)
                cmd.Parameters.AddWithValue("@TAR_CODI", tarifa.tar_codi)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub getTipoServicio()
        ' Inicializar la lista de servicios
        Dim Tsers As New List(Of co_tsermod)

        Try
            ' Establecer conexión con la base de datos
            Using cnt = New MySqlConnection(Me.ConnectionString)
                cnt.Open()

                ' Crear el comando SQL
                Using cmd = cnt.CreateCommand()
                    cmd.CommandText = "SELECT tse_codi, tse_nomb FROM co_tser"

                    ' Ejecutar el comando y leer los resultados
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Agregar cada registro a la lista
                            Tsers.Add(New co_tsermod With {
                                .TSE_CODI = reader.GetInt32(0), ' Código del servicio
                                .TSE_NOMB = reader.GetString(1)  ' Nombre del servicio
                            })
                        End While
                    End Using
                End Using
            End Using

            ' Verificar si se recuperaron datos antes de asignar al ComboBox
            If Tsers.Count > 0 Then
                Me.ServicioComboBox.ItemsSource = Tsers
                Me.ServicioComboBox.DisplayMemberPath = "TSE_NOMB" ' Mostrar el nombre del servicio
                Me.ServicioComboBox.SelectedValuePath = "TSE_CODI" ' Usar el código como valor seleccionado
            Else
                MessageBox.Show("No se encontraron servicios.", "Información", MessageBoxButton.OK, MessageBoxImage.Information)
            End If
        Catch ex As MySqlException
            ' Manejo de errores específicos de MySQL
            MessageBox.Show($"Error al cargar los servicios: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        Catch ex As Exception
            ' Manejo de errores generales
            MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        End Try
    End Sub
    Public Sub getTipoCliente()
        ' Inicializar la lista de tipos
        Dim Tipos As New List(Of cl_tipomod)

        Try
            ' Establecer conexión con la base de datos
            Using cnt = New MySqlConnection(Me.ConnectionString)
                cnt.Open()

                ' Crear el comando SQL
                Using cmd = cnt.CreateCommand()
                    cmd.CommandText = "SELECT tic_codi, tic_nomb FROM cl_tipo"

                    ' Ejecutar el comando y leer los resultados
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Agregar cada registro a la lista
                            Tipos.Add(New cl_tipomod With {
                            .TIC_CODI = reader.GetInt32(0), ' Código del tipo
                            .TIC_NOMB = reader.GetString(1)  ' Nombre del tipo
                        })
                        End While
                    End Using
                End Using
            End Using

            ' Verificar si se recuperaron datos antes de asignar al ComboBox
            If Tipos.Count > 0 Then
                Me.TipoComboBox.ItemsSource = Tipos
                Me.TipoComboBox.DisplayMemberPath = "TIC_NOMB" ' Mostrar el nombre del tipo
                Me.TipoComboBox.SelectedValuePath = "TIC_CODI" ' Usar el código como valor seleccionado
            Else
                MessageBox.Show("No se encontraron tipos.", "Información", MessageBoxButton.OK, MessageBoxImage.Information)
            End If
        Catch ex As MySqlException
            ' Manejo de errores específicos de MySQL
            MessageBox.Show($"Error al cargar los tipos: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        Catch ex As Exception
            ' Manejo de errores generales
            MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        End Try
    End Sub
    Public Sub getVehiculos()
        ' Inicializar la lista de vehículos
        Dim Vehiculos As New List(Of vh_tiposmod)

        Try
            ' Establecer conexión con la base de datos
            Using cnt = New MySqlConnection(Me.ConnectionString)
                cnt.Open()

                ' Crear el comando SQL
                Using cmd = cnt.CreateCommand()
                    cmd.CommandText = "SELECT tiv_codi, tiv_nomb FROM vh_tipos"

                    ' Ejecutar el comando y leer los resultados
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Agregar cada registro a la lista
                            Vehiculos.Add(New vh_tiposmod With {
                            .TIV_CODI = reader.GetInt32(0), ' Código del vehículo
                            .TIV_NOMB = reader.GetString(1)  ' Nombre del vehículo
                        })
                        End While
                    End Using
                End Using
            End Using

            ' Verificar si se recuperaron datos antes de asignar al ComboBox
            If Vehiculos.Count > 0 Then
                Me.VehiculoComboBox.ItemsSource = Vehiculos
                Me.VehiculoComboBox.DisplayMemberPath = "TIV_NOMB" ' Mostrar el nombre del vehículo
                Me.VehiculoComboBox.SelectedValuePath = "TIV_CODI" ' Usar el código como valor seleccionado
            Else
                MessageBox.Show("No se encontraron vehículos.", "Información", MessageBoxButton.OK, MessageBoxImage.Information)
            End If
        Catch ex As MySqlException
            ' Manejo de errores específicos de MySQL
            MessageBox.Show($"Error al cargar los vehículos: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        Catch ex As Exception
            ' Manejo de errores generales
            MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error)
        End Try
    End Sub



End Class

' Clase modelo para Tarifa


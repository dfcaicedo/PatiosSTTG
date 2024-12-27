Public Class Tarifa
    ' Propiedades de la clase que corresponden a las columnas de la consulta
    Public Property tar_Codi As Integer
    Public Property TipoNombre As String ' TIC_NOMB
    Public Property TipoVehiculoNombre As String ' TIV_NOMB
    Public Property TipoServicioNombre As String ' TSE_NOMB
    Public Property AnioTarifa As Integer ' TAR_AGNO
    Public Property CostoTarifa As Decimal ' TAR_COST

    ' Constructor opcional para inicializar los valores de la clase
    Public Sub New()
    End Sub

    Public Sub New(tipoNombre As String, tipoVehiculoNombre As String, tipoServicioNombre As String, anioTarifa As Integer, costoTarifa As Decimal)
        Me.TipoNombre = tipoNombre
        Me.TipoVehiculoNombre = tipoVehiculoNombre
        Me.TipoServicioNombre = tipoServicioNombre
        Me.AnioTarifa = anioTarifa
        Me.CostoTarifa = costoTarifa
    End Sub

    ' Método opcional para representar la clase como texto
    Public Overrides Function ToString() As String
        Return $"Tipo: {TipoNombre}, Vehículo: {TipoVehiculoNombre}, Servicio: {TipoServicioNombre}, Año: {AnioTarifa}, Costo: {CostoTarifa:C}"
    End Function
End Class


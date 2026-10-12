Imports System

''' <summary>
''' Representa una alerta u orden de reabastecimiento emitida automáticamente por el sistema
''' cuando el stock de un producto baja de su stock mínimo en cualquier comercio adherido.
''' </summary>
Public Class SolicitudReabastecimiento
    Public Property Id As String
    Public Property ComercioNombre As String
    Public Property UbicacionComercio As String
    Public Property CodigoProducto As String
    Public Property NombreProducto As String
    Public Property StockActual As Integer
    Public Property StockMinimo As Integer
    Public Property CantidadSugerida As Integer
    Public Property FechaSolicitud As DateTime
    Public Property ProveedorAsignado As String
    Public Property Estado As String ' 'Pendiente', 'En Camino', 'Reabastecido'
    Public Property FechaAtencion As Nullable(Of DateTime)
    Public Property CantidadEntregada As Integer

    Public Sub New()
        Id = Guid.NewGuid().ToString().Substring(0, 8).ToUpper()
        ComercioNombre = "Minisuper Chinito RS"
        UbicacionComercio = "Av. Central, Bella Vista"
        CodigoProducto = String.Empty
        NombreProducto = String.Empty
        StockActual = 0
        StockMinimo = 10
        CantidadSugerida = 20
        FechaSolicitud = DateTime.Now
        ProveedorAsignado = String.Empty
        Estado = "Pendiente"
        FechaAtencion = Nothing
        CantidadEntregada = 0
    End Sub

    Public Sub New(pComercio As String, pUbicacion As String, pCodigo As String, pNombre As String,
                   pStockActual As Integer, pStockMinimo As Integer, pCantidadSugerida As Integer)
        Id = Guid.NewGuid().ToString().Substring(0, 8).ToUpper()
        ComercioNombre = pComercio
        UbicacionComercio = pUbicacion
        CodigoProducto = pCodigo
        NombreProducto = pNombre
        StockActual = pStockActual
        StockMinimo = pStockMinimo
        CantidadSugerida = pCantidadSugerida
        FechaSolicitud = DateTime.Now
        ProveedorAsignado = String.Empty
        Estado = "Pendiente"
        FechaAtencion = Nothing
        CantidadEntregada = 0
    End Sub
End Class

''' <summary>
''' Representa un comercio o minisúper adherido a la red de inventario.
''' </summary>
Public Class Comercio
    Public Property Id As String
    Public Property Nombre As String
    Public Property Propietario As String
    Public Property Ubicacion As String
    Public Property Telefono As String

    Public Sub New()
        Id = String.Empty
        Nombre = String.Empty
        Propietario = String.Empty
        Ubicacion = String.Empty
        Telefono = String.Empty
    End Sub

    Public Sub New(pId As String, pNombre As String, pPropietario As String, pUbicacion As String, pTelefono As String)
        Id = pId
        Nombre = pNombre
        Propietario = pPropietario
        Ubicacion = pUbicacion
        Telefono = pTelefono
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Nombre} ({Ubicacion})"
    End Function
End Class

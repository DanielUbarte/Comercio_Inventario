''' <summary>
''' Representa a un proveedor registrado/adherido a la plataforma logística.
''' </summary>
Public Class Proveedor
    Public Property Id As String
    Public Property Nombre As String
    Public Property Empresa As String
    Public Property Telefono As String
    Public Property ZonaCobertura As String
    Public Property EstadoMembresia As String
    Public Property PedidosAtendidos As Integer

    Public Sub New()
        Id = String.Empty
        Nombre = String.Empty
        Empresa = String.Empty
        Telefono = String.Empty
        ZonaCobertura = String.Empty
        EstadoMembresia = "Adherido / Activo"
        PedidosAtendidos = 0
    End Sub

    Public Sub New(pId As String, pNombre As String, pEmpresa As String, pTelefono As String, pZona As String, Optional pMembresia As String = "Adherido / Activo")
        Id = pId
        Nombre = pNombre
        Empresa = pEmpresa
        Telefono = pTelefono
        ZonaCobertura = pZona
        EstadoMembresia = pMembresia
        PedidosAtendidos = 0
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Nombre} - {Empresa} ({ZonaCobertura})"
    End Function
End Class

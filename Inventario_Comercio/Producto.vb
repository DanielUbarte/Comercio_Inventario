Imports System.Drawing

''' <summary>
''' Clase que representa un producto dentro del inventario del comercio.
''' </summary>
Public Class Producto
    Public Property Codigo As String
    Public Property Nombre As String
    Public Property Cantidad As Integer
    Public Property Categoria As String
    Public Property EnPromocion As Boolean
    Public Property RequiereReposicion As Boolean
    Public Property TipoProducto As String
    Public Property Imagen As Image

    Public Sub New()
        ' Constructor por defecto
        Codigo = String.Empty
        Nombre = String.Empty
        Cantidad = 0
        Categoria = String.Empty
        EnPromocion = False
        RequiereReposicion = False
        TipoProducto = String.Empty
        Imagen = Nothing
    End Sub

    Public Sub New(pCodigo As String, pNombre As String, pCantidad As Integer, pCategoria As String,
                   pEnPromocion As Boolean, pRequiereReposicion As Boolean, pTipoProducto As String,
                   Optional pImagen As Image = Nothing)
        Codigo = pCodigo
        Nombre = pNombre
        Cantidad = pCantidad
        Categoria = pCategoria
        EnPromocion = pEnPromocion
        RequiereReposicion = pRequiereReposicion
        TipoProducto = pTipoProducto
        Imagen = pImagen
    End Sub
End Class

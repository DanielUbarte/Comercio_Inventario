Namespace Data
    ''' <summary>
    ''' Repositorio que actúa como capa de acceso a datos (simulada) para productos.
    ''' </summary>
    Public Class ProductoRepository
        Private ReadOnly _db As IDbSimulator

        Public Sub New(db As IDbSimulator)
            _db = db
        End Sub

        Public Function ConnectToServer(server As String) As Boolean
            Return _db.Connect(server)
        End Function

        Public Sub Disconnect()
            _db.Disconnect()
        End Sub

        Public Function GetAll() As List(Of Producto)
            Return CType(_db, DbSimulator).GetAllProductos()
        End Function

        Public Function Add(p As Producto) As Boolean
            Return CType(_db, DbSimulator).SaveProducto(p)
        End Function

        Public Function Update(p As Producto) As Boolean
            Return CType(_db, DbSimulator).UpdateProducto(p)
        End Function

        Public Function Delete(codigo As String) As Boolean
            Return CType(_db, DbSimulator).DeleteProducto(codigo)
        End Function
    End Class
End Namespace

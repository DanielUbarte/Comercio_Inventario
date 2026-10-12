Imports System.Threading

Namespace Data
    ''' <summary>
    ''' Clase que simula una conexión a una base de datos remota.
    ''' Implementa latencia, estado de conexión y métodos básicos para persistencia simulada.
    ''' </summary>
    Public Class DbSimulator
        Implements IDbSimulator

        Public Property Connected As Boolean Implements IDbSimulator.Connected
            Get
                Return _connected
            End Get
            Set(value As Boolean)
                _connected = value
            End Set
        End Property

        Private _connected As Boolean = False
        Private _server As String = String.Empty

        Public Function Connect(server As String, Optional user As String = "", Optional password As String = "") As Boolean Implements IDbSimulator.Connect
            ' Guardar servidor y marcar conectado. No hay validación real porque es una simulación.
            _server = server
            Connected = True
            ' Simular retraso de conexión
            SimulateDelay(200)
            Return Connected
        End Function

        Public Sub Disconnect() Implements IDbSimulator.Disconnect
            Connected = False
            _server = String.Empty
        End Sub

        Public Sub SimulateDelay(ms As Integer) Implements IDbSimulator.SimulateDelay
            If ms > 0 Then
                Thread.Sleep(ms)
            End If
        End Sub

        ' Métodos de conveniencia para integrarse con la lógica existente.
        Public Function GetAllProductos() As List(Of Producto)
            ' Asegurar inicialización de datos demo y devolver copia
            SimulateDelay(50)
            Return ProductoManager.ObtenerTodos()
        End Function

        Public Function SaveProducto(p As Producto) As Boolean
            SimulateDelay(50)
            Return ProductoManager.AgregarProducto(p)
        End Function

        Public Function UpdateProducto(p As Producto) As Boolean
            SimulateDelay(50)
            Return ProductoManager.ActualizarProducto(p)
        End Function

        Public Function DeleteProducto(codigo As String) As Boolean
            SimulateDelay(50)
            Return ProductoManager.EliminarProducto(codigo)
        End Function
    End Class
End Namespace

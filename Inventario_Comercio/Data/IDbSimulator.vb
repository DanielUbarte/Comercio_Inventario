Namespace Data
    ''' <summary>
    ''' Interfaz mínima para simular una conexión a base de datos remota.
    ''' </summary>
    Public Interface IDbSimulator
        Property Connected As Boolean
        Function Connect(server As String, Optional user As String = "", Optional password As String = "") As Boolean
        Sub Disconnect()
        Sub SimulateDelay(ms As Integer)
    End Interface
End Namespace

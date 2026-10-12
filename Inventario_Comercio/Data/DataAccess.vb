Namespace Data
    ''' <summary>
    ''' Punto de acceso centralizado a repositorios simulados.
    ''' Inicializa una conexión simulada al arrancar cuando se accede por primera vez.
    ''' </summary>
    Public Module DataAccess
        Public ReadOnly ProductoRepo As ProductoRepository = InitializeRepo()

        Private Function InitializeRepo() As ProductoRepository
            Dim db As IDbSimulator = New DbSimulator()
            Dim repo As New ProductoRepository(db)
            ' Intentar conectar al servidor simulado (no hay credenciales reales)
            Try
                repo.ConnectToServer("simulated://localhost")
            Catch
                ' En simulación ignoramos errores de conexión
            End Try
            Return repo
        End Function
    End Module
End Namespace

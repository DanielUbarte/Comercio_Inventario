Resumen de la simulación de base de datos

Se ha añadido una capa de acceso a datos simulada en la carpeta Data/ para permitir
desarrollar y probar la aplicación sin una base de datos real disponible.

Archivos añadidos:
- IDbSimulator.vb: interfaz mínima para el simulador de conexión.
- DbSimulator.vb: implementación que simula conexión, latencia y expone métodos CRUD básicos que delegan en ProductoManager.
- ProductoRepository.vb: repositorio que encapsula operaciones sobre productos a través del simulador.
- DataAccess.vb: módulo que expone ProductoRepo como punto de entrada centralizado.

Cómo usar:
- En lugar de llamar directamente a ProductoManager, puede usar Data.DataAccess.ProductoRepo para
  operar sobre los productos con la capa simulada.

Ejemplo:
  Dim repo = Data.DataAccess.ProductoRepo
  Dim todos = repo.GetAll()

Migración a base de datos real:
- Reemplazar la implementación de DbSimulator por una que use System.Data.SqlClient, Dapper o Entity Framework.
- Implementar IDbSimulator para realizar la conexión real y mapear las operaciones CRUD a consultas/ORM.
- Actualizar ProductoRepository o crear implementaciones específicas (por ejemplo, ProductoRepositorySql) que usen la conexión real.

Notas:
- La simulación actualmente delega en ProductoManager en memoria, por lo que el comportamiento existente se preserva.
- La simulación incluye delays artificiales para imitar latencia de red/servidor.

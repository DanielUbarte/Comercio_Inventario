Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Linq

''' <summary>
''' Clase compartida para administrar la lista de productos, comercios adheridos
''' y la red logística de notificaciones para proveedores en memoria.
''' </summary>
Public Class ProductoManager
    ' Listas principales en memoria
    Private Shared ReadOnly productos As New List(Of Producto)
    Private Shared ReadOnly comercios As New List(Of Comercio)
    Private Shared ReadOnly proveedores As New List(Of Proveedor)
    Private Shared ReadOnly solicitudes As New List(Of SolicitudReabastecimiento)
    Private Shared datosInicializados As Boolean = False

    ''' <summary>
    ''' Inicializa los datos de prueba de comercios, proveedores y productos.
    ''' </summary>
    Public Shared Sub InicializarDatosDemo()
        If datosInicializados Then Return

        ' 1. Comercios / Minisúper adheridos a la plataforma
        comercios.Add(New Comercio("COM01", "Minisuper Chinito RS", "Roberto Sam", "Av. Central, Bella Vista", "6501-1234"))
        comercios.Add(New Comercio("COM02", "Abarrotería El Éxito", "Carlos Chen", "Vía España, Bethania", "6612-4578"))
        comercios.Add(New Comercio("COM03", "Minisuper Dragón Dorado", "Lin Wu", "Calle 50, San Francisco", "6789-9821"))

        ' 2. Proveedores registrados con membresía activa
        proveedores.Add(New Proveedor("PRV01", "Jesús", "Distribuidora Central Panamá", "6901-2233", "Bella Vista / Calidonia"))
        proveedores.Add(New Proveedor("PRV02", "Daniel", "Logística Hermanos S.A.", "6811-4455", "Vía España / Bethania"))
        proveedores.Add(New Proveedor("PRV03", "Miguel", "Miguel Supplies & Mercancías", "6722-6677", "San Francisco / Calle 50"))

        ' 3. Cargar imágenes de productos
        Dim imgArroz As Image = CargarImagenProducto("arrozpremier.png", "Arroz Premium", Color.FromArgb(255, 230, 150), Color.FromArgb(240, 180, 50))
        Dim imgJugoNaranja As Image = CargarImagenProducto("jugonaranja.jpg", "Jugo Naranja", Color.FromArgb(255, 200, 130), Color.FromArgb(255, 140, 40))
        Dim imgDetergente As Image = CargarImagenProducto("detergentepolvo.png", "Detergente", Color.FromArgb(180, 220, 255), Color.FromArgb(70, 140, 240))
        Dim imgAceite As Image = CargarImagenProducto("aceiteoliva.jpg", "Aceite Oliva", Color.FromArgb(210, 235, 170), Color.FromArgb(120, 180, 60))
        Dim imgJugoPina As Image = CargarImagenProducto("jugopiña.png", "Jugo Piña", Color.FromArgb(255, 235, 130), Color.FromArgb(230, 190, 40))
        Dim imgJugoUva As Image = CargarImagenProducto("jugouva.jpg", "Jugo Uva", Color.FromArgb(200, 160, 230), Color.FromArgb(130, 80, 180))
        Dim imgJabon As Image = CrearImagenDemo("Jabón Fregar", Color.FromArgb(150, 220, 255), Color.FromArgb(80, 160, 230))

        ' 4. Productos registrados con stock mínimo y comercio asignado
        productos.Add(New Producto("001", "Arroz Premium 1kg", 25, "Alimentos", True, False, "Alimento", imgArroz, 10, "Minisuper Chinito RS"))
        productos.Add(New Producto("002", "Jugo de Naranja 1L", 5, "Bebidas", False, True, "Bebida", imgJugoNaranja, 15, "Minisuper Chinito RS"))
        productos.Add(New Producto("003", "Detergente en Polvo", 15, "Limpieza", True, False, "Limpieza", imgDetergente, 10, "Minisuper Chinito RS"))
        productos.Add(New Producto("004", "Aceite de Oliva 500ml", 30, "Alimentos", False, False, "Alimento", imgAceite, 10, "Abarrotería El Éxito"))
        productos.Add(New Producto("005", "Jugo de Piña 1L", 12, "Bebidas", False, False, "Bebida", imgJugoPina, 10, "Minisuper Dragón Dorado"))
        productos.Add(New Producto("006", "Jugo de Uva 1L", 18, "Bebidas", True, False, "Bebida", imgJugoUva, 10, "Minisuper Chinito RS"))
        productos.Add(New Producto("007", "Jabón de Fregar 500g", 8, "Limpieza", False, True, "Limpieza", imgJabon, 20, "Minisuper Chinito RS"))

        datosInicializados = True

        ' Generar alertas iniciales para productos que están por debajo de su stock mínimo
        VerificarYGenerarAlertas()
    End Sub

    ' =========================================================
    ' GESTIÓN DE PRODUCTOS
    ' =========================================================

    Public Shared Function ObtenerTodos() As List(Of Producto)
        InicializarDatosDemo()
        Return New List(Of Producto)(productos)
    End Function

    Public Shared Function AgregarProducto(p As Producto) As Boolean
        InicializarDatosDemo()
        If ExisteCodigo(p.Codigo) Then
            Return False
        End If
        productos.Add(p)
        VerificarYGenerarAlertas()
        Return True
    End Function

    Public Shared Function ActualizarProducto(pActualizado As Producto) As Boolean
        InicializarDatosDemo()
        For i As Integer = 0 To productos.Count - 1
            If productos(i).Codigo.Equals(pActualizado.Codigo, StringComparison.OrdinalIgnoreCase) Then
                productos(i).Nombre = pActualizado.Nombre
                productos(i).Cantidad = pActualizado.Cantidad
                productos(i).StockMinimo = pActualizado.StockMinimo
                productos(i).Comercio = pActualizado.Comercio
                productos(i).Categoria = pActualizado.Categoria
                productos(i).EnPromocion = pActualizado.EnPromocion
                productos(i).RequiereReposicion = pActualizado.RequiereReposicion OrElse (pActualizado.Cantidad <= pActualizado.StockMinimo)
                productos(i).TipoProducto = pActualizado.TipoProducto
                If pActualizado.Imagen IsNot Nothing Then
                    productos(i).Imagen = pActualizado.Imagen
                End If
                VerificarYGenerarAlertas()
                Return True
            End If
        Next
        Return False
    End Function

    Public Shared Function EliminarProducto(codigo As String) As Boolean
        InicializarDatosDemo()
        Dim prod As Producto = BuscarPorCodigo(codigo)
        If prod IsNot Nothing Then
            productos.Remove(prod)
            Return True
        End If
        Return False
    End Function

    Public Shared Function BuscarPorCodigo(codigo As String) As Producto
        InicializarDatosDemo()
        For Each p As Producto In productos
            If p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase) Then
                Return p
            End If
        Next
        Return Nothing
    End Function

    Public Shared Function ExisteCodigo(codigo As String) As Boolean
        Return BuscarPorCodigo(codigo) IsNot Nothing
    End Function

    Public Shared Function Buscar(criterio As String) As List(Of Producto)
        InicializarDatosDemo()
        Dim resultados As New List(Of Producto)
        If String.IsNullOrWhiteSpace(criterio) Then
            Return ObtenerTodos()
        End If

        Dim textoBusqueda As String = criterio.Trim().ToLower()

        For Each p As Producto In productos
            If p.Codigo.ToLower().Contains(textoBusqueda) OrElse
               p.Nombre.ToLower().Contains(textoBusqueda) OrElse
               p.Comercio.ToLower().Contains(textoBusqueda) OrElse
               p.Categoria.ToLower().Contains(textoBusqueda) Then
                resultados.Add(p)
            End If
        Next

        Return resultados
    End Function

    Public Shared Function ObtenerTotalProductos() As Integer
        InicializarDatosDemo()
        Return productos.Count
    End Function

    Public Shared Function ObtenerTotalUnidades() As Integer
        InicializarDatosDemo()
        Dim total As Integer = 0
        For Each p As Producto In productos
            total += p.Cantidad
        Next
        Return total
    End Function

    ' =========================================================
    ' GESTIÓN DE COMERCIOS Y PROVEEDORES
    ' =========================================================

    Public Shared Function ObtenerComercios() As List(Of Comercio)
        InicializarDatosDemo()
        Return New List(Of Comercio)(comercios)
    End Function

    Public Shared Function ObtenerProveedores() As List(Of Proveedor)
        InicializarDatosDemo()
        Return New List(Of Proveedor)(proveedores)
    End Function

    Public Shared Function AgregarProveedor(p As Proveedor) As Boolean
        InicializarDatosDemo()
        If proveedores.Any(Function(x) x.Id.Equals(p.Id, StringComparison.OrdinalIgnoreCase) OrElse x.Nombre.Equals(p.Nombre, StringComparison.OrdinalIgnoreCase)) Then
            Return False
        End If
        proveedores.Add(p)
        Return True
    End Function

    ' =========================================================
    ' NOTIFICACIONES Y REABASTECIMIENTO LOGÍSTICO
    ' =========================================================

    Public Shared Function ObtenerSolicitudes() As List(Of SolicitudReabastecimiento)
        InicializarDatosDemo()
        Return New List(Of SolicitudReabastecimiento)(solicitudes)
    End Function

    Public Shared Function ObtenerAlertasPendientesCount() As Integer
        InicializarDatosDemo()
        Return solicitudes.Where(Function(s) s.Estado.Equals("Pendiente", StringComparison.OrdinalIgnoreCase)).Count()
    End Function

    ''' <summary>
    ''' Examina todos los productos. Si la cantidad es menor o igual al stock mínimo,
    ''' genera una orden de reabastecimiento si aún no existe una pendiente o en camino.
    ''' </summary>
    Public Shared Sub VerificarYGenerarAlertas()
        For Each p As Producto In productos
            If p.Cantidad <= p.StockMinimo Then
                p.RequiereReposicion = True
                Dim existePendiente As Boolean = solicitudes.Any(Function(s) s.CodigoProducto.Equals(p.Codigo, StringComparison.OrdinalIgnoreCase) AndAlso
                                                                             s.ComercioNombre.Equals(p.Comercio, StringComparison.OrdinalIgnoreCase) AndAlso
                                                                             (s.Estado = "Pendiente" OrElse s.Estado = "En Camino"))
                If Not existePendiente Then
                    Dim com As Comercio = comercios.FirstOrDefault(Function(c) c.Nombre.Equals(p.Comercio, StringComparison.OrdinalIgnoreCase))
                    Dim ubicacion As String = If(com IsNot Nothing, com.Ubicacion, "Zona Central")
                    Dim sugerido As Integer = Math.Max((p.StockMinimo * 2) - p.Cantidad, 20)

                    solicitudes.Insert(0, New SolicitudReabastecimiento(p.Comercio, ubicacion, p.Codigo, p.Nombre, p.Cantidad, p.StockMinimo, sugerido))
                End If
            End If
        Next
    End Sub

    ''' <summary>
    ''' Un proveedor toma una solicitud de reabastecimiento para atenderla y salir en ruta.
    ''' </summary>
    Public Shared Function TomarSolicitud(idSolicitud As String, nombreProveedor As String) As Boolean
        InicializarDatosDemo()
        Dim sol As SolicitudReabastecimiento = solicitudes.FirstOrDefault(Function(s) s.Id.Equals(idSolicitud, StringComparison.OrdinalIgnoreCase))
        If sol IsNot Nothing AndAlso sol.Estado.Equals("Pendiente", StringComparison.OrdinalIgnoreCase) Then
            sol.Estado = "En Camino"
            sol.ProveedorAsignado = nombreProveedor
            sol.FechaAtencion = DateTime.Now
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' El proveedor entrega la mercancía en el comercio: suma las unidades al inventario
    ''' y marca la solicitud como reabastecida.
    ''' </summary>
    Public Shared Function CompletarSolicitud(idSolicitud As String, cantidadSurtida As Integer) As Boolean
        InicializarDatosDemo()
        Dim sol As SolicitudReabastecimiento = solicitudes.FirstOrDefault(Function(s) s.Id.Equals(idSolicitud, StringComparison.OrdinalIgnoreCase))
        If sol IsNot Nothing Then
            sol.Estado = "Reabastecido"
            sol.CantidadEntregada = cantidadSurtida

            ' Incrementar las existencias del producto correspondiente
            Dim prod As Producto = BuscarPorCodigo(sol.CodigoProducto)
            If prod IsNot Nothing Then
                prod.Cantidad += cantidadSurtida
                If prod.Cantidad > prod.StockMinimo Then
                    prod.RequiereReposicion = False
                End If
            End If

            ' Registrar pedido atendido al proveedor
            Dim prov As Proveedor = proveedores.FirstOrDefault(Function(p) p.Nombre.Equals(sol.ProveedorAsignado, StringComparison.OrdinalIgnoreCase))
            If prov IsNot Nothing Then
                prov.PedidosAtendidos += 1
            End If

            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Simula una venta o consumo de un producto restando inventario.
    ''' Si cae por debajo del stock mínimo, dispara de inmediato la notificación para los proveedores.
    ''' </summary>
    Public Shared Function SimularConsumoVenta(codigoProducto As String, cantidadVendida As Integer) As Boolean
        InicializarDatosDemo()
        Dim prod As Producto = BuscarPorCodigo(codigoProducto)
        If prod IsNot Nothing Then
            prod.Cantidad = Math.Max(0, prod.Cantidad - cantidadVendida)
            VerificarYGenerarAlertas()
            Return True
        End If
        Return False
    End Function

    ' =========================================================
    ' UTILIDADES GRÁFICAS Y RUTAS
    ' =========================================================

    Public Shared Function CrearImagenDemo(texto As String, colorTop As Color, colorBottom As Color) As Image
        Dim bmp As New Bitmap(200, 200)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            Using brush As New LinearGradientBrush(New Rectangle(0, 0, 200, 200), colorTop, colorBottom, 45.0F)
                g.FillRectangle(brush, 0, 0, 200, 200)
            End Using

            Using pen As New Pen(Color.FromArgb(100, Color.White), 4)
                g.DrawRectangle(pen, 10, 10, 180, 180)
            End Using

            Using font As New Font("Segoe UI", 16, FontStyle.Bold)
                Using textBrush As New SolidBrush(Color.FromArgb(230, Color.Black))
                    Dim format As New StringFormat() With {
                        .Alignment = StringAlignment.Center,
                        .LineAlignment = StringAlignment.Center
                    }
                    g.DrawString(texto, font, textBrush, New RectangleF(10, 10, 180, 180), format)
                End Using
            End Using
        End Using
        Return bmp
    End Function

    Public Shared Function ObtenerRutaCarpetaImagenes() As String
        Dim rutaDocumentos As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proy_Inv_com", "Comercio_Inventario", "Inventario_Comercio", "productos")
        If Directory.Exists(rutaDocumentos) Then
            Return rutaDocumentos
        End If

        Dim rutaAlternativaDocs As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proy_Inv_com", "Comercio_Inventario", "productos")
        If Directory.Exists(rutaAlternativaDocs) Then
            Return rutaAlternativaDocs
        End If

        Dim rutaProyecto As String = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "productos"))
        If Directory.Exists(rutaProyecto) Then
            Return rutaProyecto
        End If

        Dim rutaBin As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos")
        If Directory.Exists(rutaBin) Then
            Return rutaBin
        End If

        Try
            Directory.CreateDirectory(rutaDocumentos)
        Catch
        End Try

        Return rutaDocumentos
    End Function

    Public Shared Function CargarImagenProducto(nombreArchivo As String, textoFallback As String, colorTop As Color, colorBottom As Color) As Image
        Try
            Dim carpetaImagenes As String = ObtenerRutaCarpetaImagenes()
            Dim rutaArchivo As String = Path.Combine(carpetaImagenes, nombreArchivo)

            If Not File.Exists(rutaArchivo) AndAlso Directory.Exists(carpetaImagenes) Then
                For Each arch As String In Directory.GetFiles(carpetaImagenes)
                    If Path.GetFileName(arch).Equals(nombreArchivo, StringComparison.OrdinalIgnoreCase) Then
                        rutaArchivo = arch
                        Exit For
                    End If
                Next
            End If

            If File.Exists(rutaArchivo) Then
                Using fs As New FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Using imgOriginal As Image = Image.FromStream(fs)
                        Return New Bitmap(imgOriginal)
                    End Using
                End Using
            End If
        Catch ex As Exception
        End Try

        Return CrearImagenDemo(textoFallback, colorTop, colorBottom)
    End Function
End Class

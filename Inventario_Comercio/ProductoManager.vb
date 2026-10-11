Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO

''' <summary>
''' Clase compartida para administrar la lista temporal de productos en memoria.
''' No utiliza base de datos ni persistencia en archivos.
''' </summary>
Public Class ProductoManager
    ' Lista principal en memoria compartida para toda la aplicación
    Private Shared ReadOnly productos As New List(Of Producto)
    Private Shared datosInicializados As Boolean = False

    ''' <summary>
    ''' Inicializa la lista con datos de ejemplo si está vacía.
    ''' Carga las imágenes reales ubicadas en la carpeta de productos.
    ''' </summary>
    Public Shared Sub InicializarDatosDemo()
        If datosInicializados Then Return

        ' Cargar imágenes reales desde la carpeta de productos (con respaldo gráfico en caso de ausencia)
        Dim imgArroz As Image = CargarImagenProducto("arrozpremier.png", "Arroz Premium", Color.FromArgb(255, 230, 150), Color.FromArgb(240, 180, 50))
        Dim imgJugoNaranja As Image = CargarImagenProducto("jugonaranja.jpg", "Jugo Naranja", Color.FromArgb(255, 200, 130), Color.FromArgb(255, 140, 40))
        Dim imgDetergente As Image = CargarImagenProducto("detergentepolvo.png", "Detergente", Color.FromArgb(180, 220, 255), Color.FromArgb(70, 140, 240))
        Dim imgAceite As Image = CargarImagenProducto("aceiteoliva.jpg", "Aceite Oliva", Color.FromArgb(210, 235, 170), Color.FromArgb(120, 180, 60))
        Dim imgJugoPina As Image = CargarImagenProducto("jugopiña.png", "Jugo Piña", Color.FromArgb(255, 235, 130), Color.FromArgb(230, 190, 40))
        Dim imgJugoUva As Image = CargarImagenProducto("jugouva.jpg", "Jugo Uva", Color.FromArgb(200, 160, 230), Color.FromArgb(130, 80, 180))

        productos.Add(New Producto("001", "Arroz Premium 1kg", 25, "Alimentos", True, False, "Alimento", imgArroz))
        productos.Add(New Producto("002", "Jugo de Naranja 1L", 5, "Bebidas", False, True, "Bebida", imgJugoNaranja))
        productos.Add(New Producto("003", "Detergente en Polvo", 15, "Limpieza", True, False, "Limpieza", imgDetergente))
        productos.Add(New Producto("004", "Aceite de Oliva 500ml", 30, "Alimentos", False, False, "Alimento", imgAceite))
        productos.Add(New Producto("005", "Jugo de Piña 1L", 12, "Bebidas", False, False, "Bebida", imgJugoPina))
        productos.Add(New Producto("006", "Jugo de Uva 1L", 18, "Bebidas", True, False, "Bebida", imgJugoUva))

        datosInicializados = True
    End Sub

    ''' <summary>
    ''' Obtiene una lista con todos los productos registrados.
    ''' </summary>
    Public Shared Function ObtenerTodos() As List(Of Producto)
        InicializarDatosDemo()
        Return New List(Of Producto)(productos)
    End Function

    ''' <summary>
    ''' Registra un nuevo producto en la lista en memoria.
    ''' </summary>
    Public Shared Function AgregarProducto(p As Producto) As Boolean
        InicializarDatosDemo()
        If ExisteCodigo(p.Codigo) Then
            Return False
        End If
        productos.Add(p)
        Return True
    End Function

    ''' <summary>
    ''' Actualiza los datos de un producto existente.
    ''' </summary>
    Public Shared Function ActualizarProducto(pActualizado As Producto) As Boolean
        InicializarDatosDemo()
        For i As Integer = 0 To productos.Count - 1
            If productos(i).Codigo.Equals(pActualizado.Codigo, StringComparison.OrdinalIgnoreCase) Then
                productos(i).Nombre = pActualizado.Nombre
                productos(i).Cantidad = pActualizado.Cantidad
                productos(i).Categoria = pActualizado.Categoria
                productos(i).EnPromocion = pActualizado.EnPromocion
                productos(i).RequiereReposicion = pActualizado.RequiereReposicion
                productos(i).TipoProducto = pActualizado.TipoProducto
                If pActualizado.Imagen IsNot Nothing Then
                    productos(i).Imagen = pActualizado.Imagen
                End If
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Elimina un producto por su código.
    ''' </summary>
    Public Shared Function EliminarProducto(codigo As String) As Boolean
        InicializarDatosDemo()
        Dim prod As Producto = BuscarPorCodigo(codigo)
        If prod IsNot Nothing Then
            productos.Remove(prod)
            Return True
        End If
        Return False
    End Function

    ''' <summary>
    ''' Busca un producto por su código exacto (insensible a mayúsculas/minúsculas).
    ''' </summary>
    Public Shared Function BuscarPorCodigo(codigo As String) As Producto
        InicializarDatosDemo()
        For Each p As Producto In productos
            If p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase) Then
                Return p
            End If
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Comprueba si un código de producto ya existe.
    ''' </summary>
    Public Shared Function ExisteCodigo(codigo As String) As Boolean
        Return BuscarPorCodigo(codigo) IsNot Nothing
    End Function

    ''' <summary>
    ''' Busca productos por código o por nombre (coincidencia parcial, insensible a mayúsculas).
    ''' </summary>
    Public Shared Function Buscar(criterio As String) As List(Of Producto)
        InicializarDatosDemo()
        Dim resultados As New List(Of Producto)
        If String.IsNullOrWhiteSpace(criterio) Then
            Return ObtenerTodos()
        End If

        Dim textoBusqueda As String = criterio.Trim().ToLower()

        For Each p As Producto In productos
            If p.Codigo.ToLower().Contains(textoBusqueda) OrElse p.Nombre.ToLower().Contains(textoBusqueda) Then
                resultados.Add(p)
            End If
        Next

        Return resultados
    End Function

    ''' <summary>
    ''' Retorna el número total de productos registrados.
    ''' </summary>
    Public Shared Function ObtenerTotalProductos() As Integer
        InicializarDatosDemo()
        Return productos.Count
    End Function

    ''' <summary>
    ''' Retorna la suma total de las unidades de todos los productos.
    ''' </summary>
    Public Shared Function ObtenerTotalUnidades() As Integer
        InicializarDatosDemo()
        Dim total As Integer = 0
        For Each p As Producto In productos
            total += p.Cantidad
        Next
        Return total
    End Function

    ''' <summary>
    ''' Crea una imagen representativa para los productos de demostración.
    ''' </summary>
    Private Shared Function CrearImagenDemo(texto As String, colorTop As Color, colorBottom As Color) As Image
        Dim bmp As New Bitmap(200, 200)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.SmoothingMode = SmoothingMode.AntiAlias
            Using brush As New LinearGradientBrush(New Rectangle(0, 0, 200, 200), colorTop, colorBottom, 45.0F)
                g.FillRectangle(brush, 0, 0, 200, 200)
            End Using

            ' Marco decorativo interior
            Using pen As New Pen(Color.FromArgb(100, Color.White), 4)
                g.DrawRectangle(pen, 10, 10, 180, 180)
            End Using

            ' Dibujar iniciales o texto
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

    ''' <summary>
    ''' Obtiene la ruta física de la carpeta de imágenes de productos.
    ''' Se encuentra dentro de la carpeta de documentos, proy_inv_com y luego comercio_inventario y dentro de esta (Inventario_Comercio\productos).
    ''' Cuenta además con resolución inteligente para entornos de ejecución y desarrollo.
    ''' </summary>
    Public Shared Function ObtenerRutaCarpetaImagenes() As String
        ' 1. Ruta exacta solicitada en Documentos: Documentos\Proy_Inv_com\Comercio_Inventario\Inventario_Comercio\productos
        Dim rutaDocumentos As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proy_Inv_com", "Comercio_Inventario", "Inventario_Comercio", "productos")
        If Directory.Exists(rutaDocumentos) Then
            Return rutaDocumentos
        End If

        ' 2. Por si la carpeta productos se ubica directamente en Documentos\Proy_Inv_com\Comercio_Inventario\productos
        Dim rutaAlternativaDocs As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proy_Inv_com", "Comercio_Inventario", "productos")
        If Directory.Exists(rutaAlternativaDocs) Then
            Return rutaAlternativaDocs
        End If

        ' 3. Ruta relativa al directorio de código fuente del proyecto (en desarrollo dentro de Visual Studio)
        Dim rutaProyecto As String = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "productos"))
        If Directory.Exists(rutaProyecto) Then
            Return rutaProyecto
        End If

        ' 4. Ruta en la carpeta binaria de salida de compilación
        Dim rutaBin As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "productos")
        If Directory.Exists(rutaBin) Then
            Return rutaBin
        End If

        ' Si aún no existe la carpeta física, garantizar su existencia en la ruta preferida de Documentos
        Try
            Directory.CreateDirectory(rutaDocumentos)
        Catch
            ' Ignorar si hay restricciones de permisos
        End Try

        Return rutaDocumentos
    End Function

    ''' <summary>
    ''' Carga una imagen de producto desde el archivo en disco sin bloquear el archivo original.
    ''' Si no se encuentra el archivo o existe un error de formato, genera la imagen demo de respaldo.
    ''' </summary>
    Public Shared Function CargarImagenProducto(nombreArchivo As String, textoFallback As String, colorTop As Color, colorBottom As Color) As Image
        Try
            Dim carpetaImagenes As String = ObtenerRutaCarpetaImagenes()
            Dim rutaArchivo As String = Path.Combine(carpetaImagenes, nombreArchivo)

            ' Si no existe por nombre exacto, buscar insensibles a mayúsculas/minúsculas o nombres similares
            If Not File.Exists(rutaArchivo) AndAlso Directory.Exists(carpetaImagenes) Then
                For Each arch As String In Directory.GetFiles(carpetaImagenes)
                    If Path.GetFileName(arch).Equals(nombreArchivo, StringComparison.OrdinalIgnoreCase) Then
                        rutaArchivo = arch
                        Exit For
                    End If
                Next
            End If

            ' Cargar la imagen usando FileStream en memoria para evitar bloqueos del archivo en disco
            If File.Exists(rutaArchivo) Then
                Using fs As New FileStream(rutaArchivo, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Using imgOriginal As Image = Image.FromStream(fs)
                        Return New Bitmap(imgOriginal)
                    End Using
                End Using
            End If
        Catch ex As Exception
            ' Continuar hacia la imagen de respaldo
        End Try

        Return CrearImagenDemo(textoFallback, colorTop, colorBottom)
    End Function
End Class

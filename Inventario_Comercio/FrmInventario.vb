Imports System.Drawing
Imports System.IO

Public Class FrmInventario

    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ofdImagen.InitialDirectory = ProductoManager.ObtenerRutaCarpetaImagenes()
        CargarCategorias()
        CargarDataGridView()
        ActualizarResumen()
        LimpiarFormulario()
    End Sub

    ''' <summary>
    ''' Carga las categorías predefinidas en el ComboBox.
    ''' </summary>
    Private Sub CargarCategorias()
        cmbCategoria.Items.Clear()
        cmbCategoria.Items.Add("Alimentos")
        cmbCategoria.Items.Add("Bebidas")
        cmbCategoria.Items.Add("Limpieza")
        cmbCategoria.Items.Add("Higiene personal")
        cmbCategoria.Items.Add("Electrónica")
        cmbCategoria.Items.Add("Ropa")
        cmbCategoria.Items.Add("Hogar")
        cmbCategoria.SelectedIndex = -1
    End Sub

    ''' <summary>
    ''' Carga o refresca la información del DataGridView con la lista dada o la completa.
    ''' </summary>
    Public Sub CargarDataGridView(Optional lista As List(Of Producto) = Nothing)
        If lista Is Nothing Then
            lista = ProductoManager.ObtenerTodos()
        End If

        ' Desvincular temporalmente para evitar eventos automáticos al reconstruir
        dgvProductos.DataSource = Nothing
        dgvProductos.Columns.Clear()

        ' Crear estructura de columnas personalizada
        dgvProductos.Columns.Add("colCodigo", "Código")
        dgvProductos.Columns.Add("colNombre", "Nombre")
        dgvProductos.Columns.Add("colCantidad", "Stock")
        dgvProductos.Columns.Add("colMinimo", "Stock Mín.")
        dgvProductos.Columns.Add("colComercio", "Comercio")
        dgvProductos.Columns.Add("colCategoria", "Categoría")
        dgvProductos.Columns.Add("colPromocion", "Promoción")
        dgvProductos.Columns.Add("colReposicion", "Reposición")
        dgvProductos.Columns.Add("colTipo", "Tipo")

        For Each p As Producto In lista
            Dim promoTexto As String = If(p.EnPromocion, "Sí", "No")
            Dim repoTexto As String = If(p.RequiereReposicion OrElse p.Cantidad <= p.StockMinimo, "⚠️ Sí (Bajo)", "No")
            Dim rowIndex As Integer = dgvProductos.Rows.Add(p.Codigo, p.Nombre, p.Cantidad, p.StockMinimo, p.Comercio, p.Categoria, promoTexto, repoTexto, p.TipoProducto)
            
            ' Si el stock está en o por debajo del mínimo, resaltar visualmente en color de alerta
            If p.Cantidad <= p.StockMinimo Then
                dgvProductos.Rows(rowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238)
                dgvProductos.Rows(rowIndex).Cells("colCantidad").Style.ForeColor = Color.Crimson
                dgvProductos.Rows(rowIndex).Cells("colCantidad").Style.Font = New Font(dgvProductos.Font, FontStyle.Bold)
            End If
        Next

        dgvProductos.ClearSelection()
        ActualizarResumen()
    End Sub

    ''' <summary>
    ''' Actualiza las tarjetas superiores de resumen total de productos, unidades y alertas para proveedores.
    ''' </summary>
    Public Sub ActualizarResumen()
        lblTotalProductosVal.Text = ProductoManager.ObtenerTotalProductos().ToString()
        lblTotalUnidadesVal.Text = ProductoManager.ObtenerTotalUnidades().ToString("N0")

        Dim alertasPendientes As Integer = ProductoManager.ObtenerAlertasPendientesCount()
        If alertasPendientes > 0 Then
            btnNavProveedores.Text = $"🚚 Red Proveedores ({alertasPendientes})"
            btnPortalProveedores.Text = $"🚚 Portal Proveedores ({alertasPendientes} Pendientes)"
        Else
            btnNavProveedores.Text = "🚚 Red Proveedores"
            btnPortalProveedores.Text = "🚚 Portal de Red de Proveedores"
        End If
    End Sub

    ''' <summary>
    ''' Retorna el tipo de producto seleccionado en los RadioButtons.
    ''' </summary>
    Private Function ObtenerTipoSeleccionado() As String
        If rdbAlimento.Checked Then Return "Alimento"
        If rdbBebida.Checked Then Return "Bebida"
        If rdbLimpieza.Checked Then Return "Limpieza"
        Return String.Empty
    End Function

    ''' <summary>
    ''' Marca el RadioButton según el texto del tipo de producto.
    ''' </summary>
    Private Sub EstablecerTipoSeleccionado(tipo As String)
        rdbAlimento.Checked = False
        rdbBebida.Checked = False
        rdbLimpieza.Checked = False

        Select Case tipo
            Case "Alimento"
                rdbAlimento.Checked = True
            Case "Bebida"
                rdbBebida.Checked = True
            Case "Limpieza"
                rdbLimpieza.Checked = True
        End Select
    End Sub

    ''' <summary>
    ''' Limpia los controles del formulario y los restablece a su estado inicial.
    ''' </summary>
    Private Sub LimpiarFormulario()
        txtCodigo.Text = String.Empty
        txtNombre.Text = String.Empty
        txtCantidad.Text = String.Empty
        cmbCategoria.SelectedIndex = -1
        chkPromocion.Checked = False
        chkReposicion.Checked = False
        EstablecerTipoSeleccionado(String.Empty)
        picProducto.Image = Nothing
        txtBuscar.Text = String.Empty
        txtCodigo.Focus()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarFormulario()
    End Sub

    ''' <summary>
    ''' Evento para guardar un nuevo producto con todas las validaciones.
    ''' </summary>
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' 1. Validar Código no vacío
        Dim codigo As String = txtCodigo.Text.Trim()
        If String.IsNullOrWhiteSpace(codigo) Then
            MessageBox.Show("Por favor, ingrese el código del producto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Return
        End If

        ' 2. Validar Nombre no vacío
        Dim nombre As String = txtNombre.Text.Trim()
        If String.IsNullOrWhiteSpace(nombre) Then
            MessageBox.Show("Por favor, ingrese el nombre del producto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return
        End If

        ' 3. Validar Cantidad no vacía y numérica
        Dim cantidadTexto As String = txtCantidad.Text.Trim()
        If String.IsNullOrWhiteSpace(cantidadTexto) Then
            MessageBox.Show("Por favor, ingrese la cantidad del producto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidad.Focus()
            Return
        End If

        Dim cantidad As Integer
        If Not Integer.TryParse(cantidadTexto, cantidad) Then
            MessageBox.Show("La cantidad debe ser un número entero válido.", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidad.Focus()
            Return
        End If

        ' 5. Validar cantidad no negativa
        If cantidad < 0 Then
            MessageBox.Show("La cantidad no puede ser un número negativo.", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidad.Focus()
            Return
        End If

        ' 6. Validar categoría seleccionada
        If cmbCategoria.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cmbCategoria.Text) Then
            MessageBox.Show("Por favor, seleccione una categoría para el producto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCategoria.Focus()
            Return
        End If

        ' 7. Validar tipo de producto seleccionado
        Dim tipoProducto As String = ObtenerTipoSeleccionado()
        If String.IsNullOrEmpty(tipoProducto) Then
            MessageBox.Show("Por favor, seleccione un tipo de producto (Alimento, Bebida o Limpieza).", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 8. Verificar que el código no exista previamente
        If ProductoManager.ExisteCodigo(codigo) Then
            MessageBox.Show($"Ya existe un producto registrado con el código '{codigo}'.", "Código Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Return
        End If

        ' 9. Crear nuevo objeto Producto
        Dim nuevoProducto As New Producto(codigo, nombre, cantidad, cmbCategoria.Text, chkPromocion.Checked, chkReposicion.Checked, tipoProducto, picProducto.Image)

        ' 10. Agregarlo a la lista en memoria
        ProductoManager.AgregarProducto(nuevoProducto)

        ' 11. Actualizar DataGridView
        CargarDataGridView()

        ' 12. Mostrar mensaje de confirmación
        MessageBox.Show("Producto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' 13. Limpiar los controles
        LimpiarFormulario()
    End Sub

    ''' <summary>
    ''' Evento para actualizar un producto existente.
    ''' </summary>
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim codigo As String = txtCodigo.Text.Trim()
        If String.IsNullOrWhiteSpace(codigo) Then
            MessageBox.Show("Por favor, seleccione un producto o ingrese su código para actualizar.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Return
        End If

        ' Verificar que el producto existe
        Dim prodExistente As Producto = ProductoManager.BuscarPorCodigo(codigo)
        If prodExistente Is Nothing Then
            MessageBox.Show($"No se encontró ningún producto con el código '{codigo}'.", "Producto No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validar campos obligatorios
        Dim nombre As String = txtNombre.Text.Trim()
        If String.IsNullOrWhiteSpace(nombre) Then
            MessageBox.Show("Por favor, ingrese el nombre del producto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNombre.Focus()
            Return
        End If

        Dim cantidad As Integer
        If Not Integer.TryParse(txtCantidad.Text.Trim(), cantidad) OrElse cantidad < 0 Then
            MessageBox.Show("Por favor, ingrese una cantidad numérica entera no negativa.", "Valor Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidad.Focus()
            Return
        End If

        If cmbCategoria.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, seleccione una categoría.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbCategoria.Focus()
            Return
        End If

        Dim tipoProducto As String = ObtenerTipoSeleccionado()
        If String.IsNullOrEmpty(tipoProducto) Then
            MessageBox.Show("Por favor, seleccione un tipo de producto.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Actualizar objeto
        Dim prodActualizado As New Producto(codigo, nombre, cantidad, cmbCategoria.Text, chkPromocion.Checked, chkReposicion.Checked, tipoProducto, picProducto.Image)
        ProductoManager.ActualizarProducto(prodActualizado)

        ' Actualizar interfaz
        CargarDataGridView()
        MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LimpiarFormulario()
    End Sub

    ''' <summary>
    ''' Evento para eliminar un producto existente de la lista.
    ''' </summary>
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim codigo As String = txtCodigo.Text.Trim()
        If String.IsNullOrWhiteSpace(codigo) Then
            MessageBox.Show("Por favor, seleccione un producto o ingrese su código para eliminar.", "Campo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCodigo.Focus()
            Return
        End If

        Dim prod As Producto = ProductoManager.BuscarPorCodigo(codigo)
        If prod Is Nothing Then
            MessageBox.Show($"No se encontró ningún producto con el código '{codigo}'.", "Producto No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Confirmar eliminación mediante MessageBox
        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de eliminar este producto?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.Yes Then
            ProductoManager.EliminarProducto(codigo)
            CargarDataGridView()
            LimpiarFormulario()
            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ''' <summary>
    ''' Evento para buscar productos por código o por nombre.
    ''' </summary>
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim termino As String = txtBuscar.Text.Trim()
        If String.IsNullOrWhiteSpace(termino) Then
            ' Si está vacío, se buscan también los datos por el cuadro txtCodigo
            termino = txtCodigo.Text.Trim()
        End If

        If String.IsNullOrWhiteSpace(termino) Then
            MessageBox.Show("Ingrese un código o nombre en la casilla de búsqueda.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim resultados As List(Of Producto) = ProductoManager.Buscar(termino)
        If resultados.Count = 0 Then
            MessageBox.Show("No se encontraron productos.", "Búsqueda sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarDataGridView(New List(Of Producto)())
        Else
            CargarDataGridView(resultados)
        End If
    End Sub

    ''' <summary>
    ''' Evento para mostrar todo el inventario completo.
    ''' </summary>
    Private Sub btnMostrarTodo_Click(sender As Object, e As EventArgs) Handles btnMostrarTodo.Click
        txtBuscar.Text = String.Empty
        CargarDataGridView()
    End Sub

    ''' <summary>
    ''' Carga los datos del producto seleccionado en las casillas del formulario.
    ''' </summary>
    Private Sub dgvProductos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvProductos.SelectionChanged
        If dgvProductos.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgvProductos.SelectedRows(0)
            If row.Cells("colCodigo").Value IsNot Nothing Then
                Dim codigo As String = row.Cells("colCodigo").Value.ToString()
                Dim prod As Producto = ProductoManager.BuscarPorCodigo(codigo)
                If prod IsNot Nothing Then
                    txtCodigo.Text = prod.Codigo
                    txtNombre.Text = prod.Nombre
                    txtCantidad.Text = prod.Cantidad.ToString()
                    cmbCategoria.SelectedItem = prod.Categoria
                    chkPromocion.Checked = prod.EnPromocion
                    chkReposicion.Checked = prod.RequiereReposicion
                    EstablecerTipoSeleccionado(prod.TipoProducto)
                    picProducto.Image = prod.Imagen
                End If
            End If
        End If
    End Sub

    ''' <summary>
    ''' Permite al usuario seleccionar una imagen para el producto usando OpenFileDialog apuntando a la ruta de imágenes.
    ''' </summary>
    Private Sub btnSeleccionarImagen_Click(sender As Object, e As EventArgs) Handles btnSeleccionarImagen.Click
        ofdImagen.InitialDirectory = ProductoManager.ObtenerRutaCarpetaImagenes()
        If ofdImagen.ShowDialog() = DialogResult.OK Then
            Try
                ' Cargar imagen evitando bloquear el archivo original
                Using fs As New FileStream(ofdImagen.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)
                    Using tempImg As Image = Image.FromStream(fs)
                        picProducto.Image = New Bitmap(tempImg)
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar la imagen seleccionada: " & ex.Message, "Error de Imagen", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ''' <summary>
    ''' Abre el segundo formulario: FrmInventarioVisual.
    ''' </summary>
    Private Sub btnInventarioVisual_Click(sender As Object, e As EventArgs) Handles btnInventarioVisual.Click, btnNavVisualSidebar.Click
        Dim frmVisual As New FrmInventarioVisual()
        frmVisual.ShowDialog()
        ' Al regresar del formulario visual, refrescar la tabla y el resumen por si se requiriera
        CargarDataGridView()
    End Sub

    ''' <summary>
    ''' Abre el formulario del Portal de Proveedores y Notificaciones de Reabastecimiento.
    ''' </summary>
    Private Sub btnPortalProveedores_Click(sender As Object, e As EventArgs) Handles btnPortalProveedores.Click, btnNavProveedores.Click
        Dim frmProveedores As New FrmPortalProveedores()
        frmProveedores.ShowDialog()
        ' Al regresar, refrescar la tabla por si los proveedores reabastecieron stock
        CargarDataGridView()
        ActualizarResumen()
    End Sub

    ''' <summary>
    ''' Simula el consumo o venta de un producto para demostrar cómo se disparan
    ''' las notificaciones a los proveedores cuando el stock cae por debajo del mínimo.
    ''' </summary>
    Private Sub btnSimularConsumoInv_Click(sender As Object, e As EventArgs) Handles btnSimularConsumoInv.Click
        Dim codigo As String = txtCodigo.Text.Trim()
        If String.IsNullOrWhiteSpace(codigo) Then
            If dgvProductos.SelectedRows.Count > 0 Then
                codigo = dgvProductos.SelectedRows(0).Cells("colCodigo").Value.ToString()
            Else
                codigo = "007" ' Jabón de fregar 500g
            End If
        End If

        Dim prod As Producto = ProductoManager.BuscarPorCodigo(codigo)
        If prod IsNot Nothing Then
            Dim resp As DialogResult = MessageBox.Show(
                $"¿Deseas simular una venta de 5 unidades de '{prod.Nombre}' en '{prod.Comercio}'?" & vbCrLf & vbCrLf &
                $"Stock actual: {prod.Cantidad} | Stock Mínimo: {prod.StockMinimo}" & vbCrLf &
                "Al bajar del mínimo, se emitirá una alerta automática hacia la red de proveedores.",
                "Simulador de Venta / Consumo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resp = DialogResult.Yes Then
                ProductoManager.SimularConsumoVenta(prod.Codigo, 5)
                CargarDataGridView()
                ActualizarResumen()
                MessageBox.Show($"¡Venta procesada con éxito! El nuevo stock de '{prod.Nombre}' es {prod.Cantidad}." & vbCrLf & vbCrLf &
                                "Se ha generado la notificación para los proveedores. Puedes abrir el 'Portal Proveedores' para ver la orden.",
                                "Alerta Emitida", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class

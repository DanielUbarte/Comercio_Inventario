Imports System.Drawing
Imports System.Linq

Public Class FrmPortalProveedores

    Private cargando As Boolean = True

    Private Sub FrmPortalProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1100, 680)
        Me.CenterToScreen()
        cargando = True
        ConfigurarColumnasGrid()
        CargarProveedores()
        CargarFiltros()
        cargando = False
        CargarTablaSolicitudes()
        ActualizarMetricas()
    End Sub

    ''' <summary>
    ''' Carga los proveedores disponibles en el selector superior.
    ''' </summary>
    Private Sub CargarProveedores()
        cmbProveedorActivo.Items.Clear()
        Dim listaProveedores As List(Of Proveedor) = ProductoManager.ObtenerProveedores()
        For Each prov As Proveedor In listaProveedores
            cmbProveedorActivo.Items.Add(prov.Nombre)
        Next

        If cmbProveedorActivo.Items.Count > 0 Then
            cmbProveedorActivo.SelectedIndex = 0
        End If
    End Sub

    ''' <summary>
    ''' Configura las opciones de los filtros de comercios y estados.
    ''' </summary>
    Private Sub CargarFiltros()
        cmbFiltroComercio.Items.Clear()
        cmbFiltroComercio.Items.Add("Todos los Comercios")
        For Each com As Comercio In ProductoManager.ObtenerComercios()
            cmbFiltroComercio.Items.Add(com.Nombre)
        Next
        cmbFiltroComercio.SelectedIndex = 0

        cmbFiltroEstado.Items.Clear()
        cmbFiltroEstado.Items.Add("Todos los Estados")
        cmbFiltroEstado.Items.Add("Pendiente")
        cmbFiltroEstado.Items.Add("En Camino")
        cmbFiltroEstado.Items.Add("Reabastecido")
        cmbFiltroEstado.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Configura las columnas personalizadas del DataGridView de solicitudes.
    ''' El proveedor solo visualiza los pedidos con falta de stock y los datos necesarios para la entrega,
    ''' sin exponer información interna confidencial del inventario del comercio.
    ''' </summary>
    Private Sub ConfigurarColumnasGrid()
        dgvSolicitudes.Columns.Clear()

        dgvSolicitudes.Columns.Add("colId", "ID Pedido")
        dgvSolicitudes.Columns.Add("colComercio", "Comercio Solicitante")
        dgvSolicitudes.Columns.Add("colUbicacion", "Ubicación / Zona")
        dgvSolicitudes.Columns.Add("colProducto", "Producto Faltante")
        dgvSolicitudes.Columns.Add("colAlerta", "Condición de Stock")
        dgvSolicitudes.Columns.Add("colSugerido", "Pedido a Surtir")
        dgvSolicitudes.Columns.Add("colEntregado", "Surtido / Entregado")
        dgvSolicitudes.Columns.Add("colEstado", "Estado de Orden")
        dgvSolicitudes.Columns.Add("colProveedor", "Proveedor Asignado")
        dgvSolicitudes.Columns.Add("colFecha", "Fecha Alerta")

        dgvSolicitudes.Columns("colId").Width = 80
        dgvSolicitudes.Columns("colComercio").Width = 155
        dgvSolicitudes.Columns("colUbicacion").Width = 135
        dgvSolicitudes.Columns("colProducto").Width = 150
        dgvSolicitudes.Columns("colAlerta").Width = 140
        dgvSolicitudes.Columns("colSugerido").Width = 110
        dgvSolicitudes.Columns("colEntregado").Width = 120
        dgvSolicitudes.Columns("colEstado").Width = 100
        dgvSolicitudes.Columns("colProveedor").Width = 110
    End Sub

    ''' <summary>
    ''' Carga y refresca las solicitudes de reabastecimiento en el DataGridView con formato de color.
    ''' </summary>
    Public Sub CargarTablaSolicitudes()
        If cargando Then Return
        If dgvSolicitudes.Columns.Count = 0 Then
            ConfigurarColumnasGrid()
        End If
        ProductoManager.VerificarYGenerarAlertas()
        Dim todas As List(Of SolicitudReabastecimiento) = ProductoManager.ObtenerSolicitudes()

        ' Filtro por Comercio
        Dim comercioSeleccionado As String = If(cmbFiltroComercio.SelectedItem IsNot Nothing, cmbFiltroComercio.SelectedItem.ToString(), "Todos los Comercios")
        If Not comercioSeleccionado.Equals("Todos los Comercios", StringComparison.OrdinalIgnoreCase) Then
            todas = todas.Where(Function(s) s.ComercioNombre.Equals(comercioSeleccionado, StringComparison.OrdinalIgnoreCase)).ToList()
        End If

        ' Filtro por Estado
        Dim estadoSeleccionado As String = If(cmbFiltroEstado.SelectedItem IsNot Nothing, cmbFiltroEstado.SelectedItem.ToString(), "Todos los Estados")
        If Not estadoSeleccionado.Equals("Todos los Estados", StringComparison.OrdinalIgnoreCase) Then
            todas = todas.Where(Function(s) s.Estado.Equals(estadoSeleccionado, StringComparison.OrdinalIgnoreCase)).ToList()
        End If

        dgvSolicitudes.Rows.Clear()

        For Each s As SolicitudReabastecimiento In todas
            Dim prodLive As Producto = ProductoManager.BuscarPorCodigo(s.CodigoProducto)
            Dim stockActualLive As Integer = If(prodLive IsNot Nothing, prodLive.Cantidad, s.StockActual)
            Dim condicionTexto As String
            If s.Estado.Equals("Reabastecido", StringComparison.OrdinalIgnoreCase) Then
                condicionTexto = "Stock Restablecido"
            ElseIf stockActualLive = 0 Then
                condicionTexto = "AGOTADO (0 uds)"
            Else
                condicionTexto = "Bajo de Stock"
            End If

            Dim pedidoTexto As String = $"{s.CantidadSugerida} unidades"
            Dim entregadoTexto As String = If(s.CantidadEntregada > 0, $"+{s.CantidadEntregada} unidades", "—")

            Dim rowIndex As Integer = dgvSolicitudes.Rows.Add(
                s.Id,
                s.ComercioNombre,
                s.UbicacionComercio,
                s.NombreProducto,
                condicionTexto,
                pedidoTexto,
                entregadoTexto,
                s.Estado,
                If(String.IsNullOrEmpty(s.ProveedorAsignado), "— Sin Asignar —", s.ProveedorAsignado),
                s.FechaSolicitud.ToString("dd/MM/yyyy HH:mm")
            )

            Dim fila As DataGridViewRow = dgvSolicitudes.Rows(rowIndex)

            ' Formato visual de la Condición
            If s.Estado.Equals("Reabastecido", StringComparison.OrdinalIgnoreCase) Then
                fila.Cells("colAlerta").Style.ForeColor = Color.FromArgb(46, 125, 50)
                fila.Cells("colAlerta").Style.Font = New Font(dgvSolicitudes.Font, FontStyle.Bold)
            ElseIf stockActualLive = 0 Then
                fila.Cells("colAlerta").Style.ForeColor = Color.DarkRed
                fila.Cells("colAlerta").Style.Font = New Font(dgvSolicitudes.Font, FontStyle.Bold)
            Else
                fila.Cells("colAlerta").Style.ForeColor = Color.Crimson
                fila.Cells("colAlerta").Style.Font = New Font(dgvSolicitudes.Font, FontStyle.Bold)
            End If

            If s.CantidadEntregada > 0 Then
                fila.Cells("colEntregado").Style.ForeColor = Color.FromArgb(46, 125, 50)
                fila.Cells("colEntregado").Style.Font = New Font(dgvSolicitudes.Font, FontStyle.Bold)
            End If

            Select Case s.Estado.ToLower()
                Case "pendiente"
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 238) ' Rojo suave
                    fila.Cells("colEstado").Style.ForeColor = Color.FromArgb(198, 40, 40)
                    fila.Cells("colEstado").Style.Font = New Font(dgvSolicitudes.Font, FontStyle.Bold)
                Case "en camino"
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 225) ' Naranja suave
                    fila.Cells("colEstado").Style.ForeColor = Color.FromArgb(239, 108, 0)
                    fila.Cells("colEstado").Style.Font = New Font(dgvSolicitudes.Font, FontStyle.Bold)
                Case "reabastecido"
                    fila.DefaultCellStyle.BackColor = Color.FromArgb(232, 245, 233) ' Verde suave
                    fila.Cells("colEstado").Style.ForeColor = Color.FromArgb(46, 125, 50)
            End Select
        Next

        dgvSolicitudes.ClearSelection()
        ActualizarMetricas()
    End Sub

    ''' <summary>
    ''' Actualiza los números de las tarjetas de resumen y ahorro logístico.
    ''' </summary>
    Private Sub ActualizarMetricas()
        Dim todas As List(Of SolicitudReabastecimiento) = ProductoManager.ObtenerSolicitudes()
        Dim pendientes As Integer = todas.Where(Function(s) s.Estado.Equals("Pendiente", StringComparison.OrdinalIgnoreCase)).Count()
        Dim enCamino As Integer = todas.Where(Function(s) s.Estado.Equals("En Camino", StringComparison.OrdinalIgnoreCase)).Count()
        Dim comerciosCount As Integer = ProductoManager.ObtenerComercios().Count

        lblCardComerciosVal.Text = $"{comerciosCount} Minisúpers"
        lblCardPendientesVal.Text = $"{pendientes} Pendientes"
        lblCardEnCaminoVal.Text = $"{enCamino} En Ruta"

        If pendientes = 0 AndAlso enCamino = 0 Then
            lblCardAhorroVal.Text = "Inventario Óptimo"
        Else
            lblCardAhorroVal.Text = $"{enCamino + 2} Rutas Planificadas"
        End If
    End Sub

    ''' <summary>
    ''' Un proveedor toma la orden seleccionada para acudir a abastecer al comercio.
    ''' </summary>
    Private Sub btnTomarPedido_Click(sender As Object, e As EventArgs) Handles btnTomarPedido.Click
        If dgvSolicitudes.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona una orden de la lista para tomarla.", "Seleccionar orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim fila As DataGridViewRow = dgvSolicitudes.SelectedRows(0)
        Dim idSolicitud As String = fila.Cells("colId").Value.ToString()
        Dim estado As String = fila.Cells("colEstado").Value.ToString()
        Dim comercio As String = fila.Cells("colComercio").Value.ToString()
        Dim producto As String = fila.Cells("colProducto").Value.ToString()
        Dim proveedorActual As String = If(cmbProveedorActivo.SelectedItem IsNot Nothing, cmbProveedorActivo.SelectedItem.ToString(), "Jesús")

        If estado.Equals("En Camino", StringComparison.OrdinalIgnoreCase) Then
            Dim asignado As String = fila.Cells("colProveedor").Value.ToString()
            MessageBox.Show($"Esta orden ya fue tomada por el proveedor '{asignado}' y está en ruta.", "Orden ya tomada", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If estado.Equals("Reabastecido", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Esta orden ya fue completada y reabastecida previamente.", "Orden finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If ProductoManager.TomarSolicitud(idSolicitud, proveedorActual) Then
            MessageBox.Show($"¡Excelente, {proveedorActual}!" & vbCrLf & vbCrLf &
                            $"Has tomado la orden para reabastecer {producto} en '{comercio}'." & vbCrLf &
                            "El comercio ya puede ver que vas en camino hacia su ubicación.",
                            "Orden Tomada con Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CargarTablaSolicitudes()
        Else
            MessageBox.Show("No se pudo tomar la solicitud.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    ''' <summary>
    ''' El proveedor entrega los productos y confirma el reabastecimiento en el inventario.
    ''' </summary>
    Private Sub btnEntregarPedido_Click(sender As Object, e As EventArgs) Handles btnEntregarPedido.Click
        If dgvSolicitudes.SelectedRows.Count = 0 Then
            MessageBox.Show("Por favor, selecciona una orden de la tabla para registrar la entrega.", "Seleccionar orden", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim fila As DataGridViewRow = dgvSolicitudes.SelectedRows(0)
        Dim idSolicitud As String = fila.Cells("colId").Value.ToString()
        Dim estado As String = fila.Cells("colEstado").Value.ToString()
        Dim comercio As String = fila.Cells("colComercio").Value.ToString()
        Dim producto As String = fila.Cells("colProducto").Value.ToString()
        Dim proveedorActual As String = If(cmbProveedorActivo.SelectedItem IsNot Nothing, cmbProveedorActivo.SelectedItem.ToString(), "Jesús")

        If estado.Equals("Reabastecido", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("Esta orden ya fue entregada y surtida previamente.", "Orden ya completada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' Si la orden estaba en 'Pendiente', se auto-asigna al proveedor activo para facilitar la entrega directa
        If estado.Equals("Pendiente", StringComparison.OrdinalIgnoreCase) Then
            ProductoManager.TomarSolicitud(idSolicitud, proveedorActual)
        End If

        ' Obtener la solicitud y producto asociado
        Dim solObj As SolicitudReabastecimiento = ProductoManager.ObtenerSolicitudes().FirstOrDefault(Function(s) s.Id.Equals(idSolicitud, StringComparison.OrdinalIgnoreCase))
        Dim sugerido As Integer = If(solObj IsNot Nothing, solObj.CantidadSugerida, 20)

        Dim input As String = InputBox($"¿Cuántas unidades de '{producto}' estás entregando en '{comercio}'?" & vbCrLf & vbCrLf &
                                       $"Cantidad requerida por el comercio: {sugerido} unidades",
                                       "Confirmar Entrega y Reabastecimiento", sugerido.ToString())
        If String.IsNullOrWhiteSpace(input) Then Return

        Dim cantidadEntregada As Integer
        If Not Integer.TryParse(input, cantidadEntregada) OrElse cantidadEntregada <= 0 Then
            MessageBox.Show("Por favor ingresa una cantidad numérica válida mayor a 0.", "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ProductoManager.CompletarSolicitud(idSolicitud, cantidadEntregada) Then
            MessageBox.Show($"¡Entrega confirmada con éxito!" & vbCrLf & vbCrLf &
                            $"• Comercio: {comercio}" & vbCrLf &
                            $"• Producto: {producto}" & vbCrLf &
                            $"• Proveedor: {If(solObj IsNot Nothing AndAlso Not String.IsNullOrEmpty(solObj.ProveedorAsignado), solObj.ProveedorAsignado, proveedorActual)}" & vbCrLf &
                            $"• Unidades entregadas: +{cantidadEntregada} unidades" & vbCrLf &
                            $"• Estado: Mercancía surtida y stock restablecido en tienda." & vbCrLf & vbCrLf &
                            "El inventario del comercio se ha reabastecido automáticamente.",
                            "Reabastecimiento Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Si el filtro actual ocultaría la orden reabastecida, ponemos 'Todos los Estados' para que el usuario la vea verde y actualizada
            If cmbFiltroEstado.SelectedItem IsNot Nothing AndAlso Not cmbFiltroEstado.SelectedItem.ToString().Equals("Todos los Estados", StringComparison.OrdinalIgnoreCase) Then
                cmbFiltroEstado.SelectedIndex = 0
            Else
                CargarTablaSolicitudes()
            End If
        Else
            MessageBox.Show("No se pudo registrar la entrega.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ''' <summary>
    ''' Simula una venta/consumo en vivo en el Minisúper para que el profesor vea cómo
    ''' se genera la alerta automática de inmediato.
    ''' </summary>
    Private Sub btnSimularConsumo_Click(sender As Object, e As EventArgs) Handles btnSimularConsumo.Click
        ' Buscar prioritariamente Mantequilla La Perfecta ("008") o Jabón de fregar ("007")
        Dim prod As Producto = ProductoManager.BuscarPorCodigo("008")
        If prod Is Nothing Then
            prod = ProductoManager.BuscarPorCodigo("007")
        End If

        If prod IsNot Nothing Then
            Dim resp As DialogResult = MessageBox.Show(
                $"¿Deseas simular una venta rápida en '{prod.Comercio}' que deje bajo de stock a '{prod.Nombre}'?" & vbCrLf & vbCrLf &
                "Al acabarse las unidades, el sistema disparará la notificación directa hacia los proveedores.",
                "Simulador de Venta / Consumo en Comercio", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If resp = DialogResult.Yes Then
                ProductoManager.SimularConsumoVenta(prod.Codigo, 5)
                CargarTablaSolicitudes()
                MessageBox.Show($"¡Notificación emitida a la red de proveedores!" & vbCrLf & vbCrLf &
                                $"'{prod.Comercio}' se quedó sin existencias de '{prod.Nombre}'." & vbCrLf &
                                "La orden ya está disponible en la lista para que tomes el pedido y salgas en ruta.",
                                "Alerta Generada", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub cmbFiltroComercio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroComercio.SelectedIndexChanged
        If Not cargando Then CargarTablaSolicitudes()
    End Sub

    Private Sub cmbFiltroEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFiltroEstado.SelectedIndexChanged
        If Not cargando Then CargarTablaSolicitudes()
    End Sub

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        CargarTablaSolicitudes()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class

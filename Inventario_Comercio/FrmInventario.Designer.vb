<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventario
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlInfoMemoria = New System.Windows.Forms.Panel()
        Me.lblInfoMemoriaText = New System.Windows.Forms.Label()
        Me.lblInfoMemoriaTitle = New System.Windows.Forms.Label()
        Me.btnNavVisualSidebar = New System.Windows.Forms.Button()
        Me.pnlNavInventario = New System.Windows.Forms.Panel()
        Me.lblNavInventario = New System.Windows.Forms.Label()
        Me.pnlBrand = New System.Windows.Forms.Panel()
        Me.lblBrandSub = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.splContent = New System.Windows.Forms.SplitContainer()
        Me.pnlFormCard = New System.Windows.Forms.Panel()
        Me.pnlFormContent = New System.Windows.Forms.Panel()
        Me.pnlButtonsGrid = New System.Windows.Forms.TableLayoutPanel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnInventarioVisual = New System.Windows.Forms.Button()
        Me.pnlImageSection = New System.Windows.Forms.Panel()
        Me.btnSeleccionarImagen = New System.Windows.Forms.Button()
        Me.picProducto = New System.Windows.Forms.PictureBox()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.pnlCheckboxes = New System.Windows.Forms.Panel()
        Me.chkReposicion = New System.Windows.Forms.CheckBox()
        Me.chkPromocion = New System.Windows.Forms.CheckBox()
        Me.grpTipo = New System.Windows.Forms.GroupBox()
        Me.rdbLimpieza = New System.Windows.Forms.RadioButton()
        Me.rdbBebida = New System.Windows.Forms.RadioButton()
        Me.rdbAlimento = New System.Windows.Forms.RadioButton()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.pnlGridCard = New System.Windows.Forms.Panel()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.pnlGridHeader = New System.Windows.Forms.Panel()
        Me.lblGridTitle = New System.Windows.Forms.Label()
        Me.pnlSummaryContainer = New System.Windows.Forms.Panel()
        Me.pnlSearch = New System.Windows.Forms.Panel()
        Me.btnMostrarTodo = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.pnlTotalUnidadesCard = New System.Windows.Forms.Panel()
        Me.lblTotalUnidadesVal = New System.Windows.Forms.Label()
        Me.lblTotalUnidadesTitle = New System.Windows.Forms.Label()
        Me.pnlTotalProductosCard = New System.Windows.Forms.Panel()
        Me.lblTotalProductosVal = New System.Windows.Forms.Label()
        Me.lblTotalProductosTitle = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSubHeader = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.ofdImagen = New System.Windows.Forms.OpenFileDialog()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlInfoMemoria.SuspendLayout()
        Me.pnlNavInventario.SuspendLayout()
        Me.pnlBrand.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        CType(Me.splContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splContent.Panel1.SuspendLayout()
        Me.splContent.Panel2.SuspendLayout()
        Me.splContent.SuspendLayout()
        Me.pnlFormCard.SuspendLayout()
        Me.pnlFormContent.SuspendLayout()
        Me.pnlButtonsGrid.SuspendLayout()
        Me.pnlImageSection.SuspendLayout()
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCheckboxes.SuspendLayout()
        Me.grpTipo.SuspendLayout()
        Me.pnlGridCard.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGridHeader.SuspendLayout()
        Me.pnlSummaryContainer.SuspendLayout()
        Me.pnlSearch.SuspendLayout()
        Me.pnlTotalUnidadesCard.SuspendLayout()
        Me.pnlTotalProductosCard.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.White
        Me.pnlSidebar.Controls.Add(Me.pnlInfoMemoria)
        Me.pnlSidebar.Controls.Add(Me.btnNavVisualSidebar)
        Me.pnlSidebar.Controls.Add(Me.pnlNavInventario)
        Me.pnlSidebar.Controls.Add(Me.pnlBrand)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(230, 750)
        Me.pnlSidebar.TabIndex = 0
        '
        'pnlInfoMemoria
        '
        Me.pnlInfoMemoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlInfoMemoria.Controls.Add(Me.lblInfoMemoriaText)
        Me.pnlInfoMemoria.Controls.Add(Me.lblInfoMemoriaTitle)
        Me.pnlInfoMemoria.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlInfoMemoria.Location = New System.Drawing.Point(0, 640)
        Me.pnlInfoMemoria.Name = "pnlInfoMemoria"
        Me.pnlInfoMemoria.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlInfoMemoria.Size = New System.Drawing.Size(230, 110)
        Me.pnlInfoMemoria.TabIndex = 3
        '
        'lblInfoMemoriaText
        '
        Me.lblInfoMemoriaText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblInfoMemoriaText.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblInfoMemoriaText.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblInfoMemoriaText.Location = New System.Drawing.Point(12, 32)
        Me.lblInfoMemoriaText.Name = "lblInfoMemoriaText"
        Me.lblInfoMemoriaText.Size = New System.Drawing.Size(206, 66)
        Me.lblInfoMemoriaText.TabIndex = 1
        Me.lblInfoMemoriaText.Text = "Los datos se almacenan temporalmente en List(Of Producto) durante esta sesión."
        '
        'lblInfoMemoriaTitle
        '
        Me.lblInfoMemoriaTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInfoMemoriaTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblInfoMemoriaTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblInfoMemoriaTitle.Location = New System.Drawing.Point(12, 12)
        Me.lblInfoMemoriaTitle.Name = "lblInfoMemoriaTitle"
        Me.lblInfoMemoriaTitle.Size = New System.Drawing.Size(206, 20)
        Me.lblInfoMemoriaTitle.TabIndex = 0
        Me.lblInfoMemoriaTitle.Text = "💡 Modo en Memoria"
        '
        'btnNavVisualSidebar
        '
        Me.btnNavVisualSidebar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavVisualSidebar.FlatAppearance.BorderSize = 0
        Me.btnNavVisualSidebar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnNavVisualSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavVisualSidebar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNavVisualSidebar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnNavVisualSidebar.Location = New System.Drawing.Point(12, 140)
        Me.btnNavVisualSidebar.Name = "btnNavVisualSidebar"
        Me.btnNavVisualSidebar.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnNavVisualSidebar.Size = New System.Drawing.Size(206, 44)
        Me.btnNavVisualSidebar.TabIndex = 2
        Me.btnNavVisualSidebar.Text = "🖼️  Inventario Visual"
        Me.btnNavVisualSidebar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavVisualSidebar.UseVisualStyleBackColor = True
        '
        'pnlNavInventario
        '
        Me.pnlNavInventario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.pnlNavInventario.Controls.Add(Me.lblNavInventario)
        Me.pnlNavInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnlNavInventario.Location = New System.Drawing.Point(12, 90)
        Me.pnlNavInventario.Name = "pnlNavInventario"
        Me.pnlNavInventario.Size = New System.Drawing.Size(206, 44)
        Me.pnlNavInventario.TabIndex = 1
        '
        'lblNavInventario
        '
        Me.lblNavInventario.AutoSize = True
        Me.lblNavInventario.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNavInventario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblNavInventario.Location = New System.Drawing.Point(15, 12)
        Me.lblNavInventario.Name = "lblNavInventario"
        Me.lblNavInventario.Size = New System.Drawing.Size(126, 19)
        Me.lblNavInventario.TabIndex = 0
        Me.lblNavInventario.Text = "📦  Gestión Inventario"
        '
        'pnlBrand
        '
        Me.pnlBrand.Controls.Add(Me.lblBrandSub)
        Me.pnlBrand.Controls.Add(Me.lblBrand)
        Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(230, 75)
        Me.pnlBrand.TabIndex = 0
        '
        'lblBrandSub
        '
        Me.lblBrandSub.AutoSize = True
        Me.lblBrandSub.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblBrandSub.Location = New System.Drawing.Point(16, 42)
        Me.lblBrandSub.Name = "lblBrandSub"
        Me.lblBrandSub.Size = New System.Drawing.Size(117, 13)
        Me.lblBrandSub.TabIndex = 1
        Me.lblBrandSub.Text = "Control de Inventario"
        '
        'lblBrand
        '
        Me.lblBrand.AutoSize = True
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblBrand.Location = New System.Drawing.Point(14, 16)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Text = "🏪 COMERCIO"
        Me.lblBrand.TabIndex = 0
        '
        'pnlMain
        '
        Me.pnlMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.pnlMain.Controls.Add(Me.splContent)
        Me.pnlMain.Controls.Add(Me.pnlSummaryContainer)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(230, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlMain.Size = New System.Drawing.Size(1034, 750)
        Me.pnlMain.TabIndex = 1
        '
        'splContent
        '
        Me.splContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splContent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.splContent.Location = New System.Drawing.Point(20, 160)
        Me.splContent.Name = "splContent"
        '
        'splContent.Panel1
        '
        Me.splContent.Panel1.Controls.Add(Me.pnlFormCard)
        '
        'splContent.Panel2
        '
        Me.splContent.Panel2.Controls.Add(Me.pnlGridCard)
        Me.splContent.Size = New System.Drawing.Size(994, 570)
        Me.splContent.SplitterDistance = 420
        Me.splContent.TabIndex = 2
        '
        'pnlFormCard
        '
        Me.pnlFormCard.AutoScroll = True
        Me.pnlFormCard.BackColor = System.Drawing.Color.White
        Me.pnlFormCard.Controls.Add(Me.pnlFormContent)
        Me.pnlFormCard.Controls.Add(Me.lblFormTitle)
        Me.pnlFormCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFormCard.Location = New System.Drawing.Point(0, 0)
        Me.pnlFormCard.Name = "pnlFormCard"
        Me.pnlFormCard.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlFormCard.Size = New System.Drawing.Size(420, 570)
        Me.pnlFormCard.TabIndex = 0
        '
        'pnlFormContent
        '
        Me.pnlFormContent.Controls.Add(Me.pnlButtonsGrid)
        Me.pnlFormContent.Controls.Add(Me.pnlImageSection)
        Me.pnlFormContent.Controls.Add(Me.pnlCheckboxes)
        Me.pnlFormContent.Controls.Add(Me.grpTipo)
        Me.pnlFormContent.Controls.Add(Me.cmbCategoria)
        Me.pnlFormContent.Controls.Add(Me.lblCategoria)
        Me.pnlFormContent.Controls.Add(Me.txtCantidad)
        Me.pnlFormContent.Controls.Add(Me.lblCantidad)
        Me.pnlFormContent.Controls.Add(Me.txtNombre)
        Me.pnlFormContent.Controls.Add(Me.lblNombre)
        Me.pnlFormContent.Controls.Add(Me.txtCodigo)
        Me.pnlFormContent.Controls.Add(Me.lblCodigo)
        Me.pnlFormContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFormContent.Location = New System.Drawing.Point(16, 42)
        Me.pnlFormContent.Name = "pnlFormContent"
        Me.pnlFormContent.Size = New System.Drawing.Size(388, 512)
        Me.pnlFormContent.TabIndex = 1
        '
        'pnlButtonsGrid
        '
        Me.pnlButtonsGrid.ColumnCount = 2
        Me.pnlButtonsGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlButtonsGrid.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.pnlButtonsGrid.Controls.Add(Me.btnGuardar, 0, 0)
        Me.pnlButtonsGrid.Controls.Add(Me.btnActualizar, 1, 0)
        Me.pnlButtonsGrid.Controls.Add(Me.btnEliminar, 0, 1)
        Me.pnlButtonsGrid.Controls.Add(Me.btnLimpiar, 1, 1)
        Me.pnlButtonsGrid.Controls.Add(Me.btnInventarioVisual, 0, 2)
        Me.pnlButtonsGrid.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlButtonsGrid.Location = New System.Drawing.Point(0, 395)
        Me.pnlButtonsGrid.Name = "pnlButtonsGrid"
        Me.pnlButtonsGrid.RowCount = 3
        Me.pnlButtonsGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.pnlButtonsGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.pnlButtonsGrid.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.pnlButtonsGrid.Size = New System.Drawing.Size(388, 114)
        Me.pnlButtonsGrid.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(2, 2)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(190, 34)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "💾 Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnActualizar.Location = New System.Drawing.Point(196, 2)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(190, 34)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "✏️ Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(2, 40)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(190, 34)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "🗑️ Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(196, 40)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(190, 34)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "🧹 Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnInventarioVisual
        '
        Me.btnInventarioVisual.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.pnlButtonsGrid.SetColumnSpan(Me.btnInventarioVisual, 2)
        Me.btnInventarioVisual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventarioVisual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInventarioVisual.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnInventarioVisual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventarioVisual.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnInventarioVisual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnInventarioVisual.Location = New System.Drawing.Point(2, 78)
        Me.btnInventarioVisual.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventarioVisual.Name = "btnInventarioVisual"
        Me.btnInventarioVisual.Size = New System.Drawing.Size(384, 34)
        Me.btnInventarioVisual.TabIndex = 4
        Me.btnInventarioVisual.Text = "👁️ Ver Inventario Visual"
        Me.btnInventarioVisual.UseVisualStyleBackColor = False
        '
        'pnlImageSection
        '
        Me.pnlImageSection.Controls.Add(Me.btnSeleccionarImagen)
        Me.pnlImageSection.Controls.Add(Me.picProducto)
        Me.pnlImageSection.Controls.Add(Me.lblImagen)
        Me.pnlImageSection.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlImageSection.Location = New System.Drawing.Point(0, 305)
        Me.pnlImageSection.Name = "pnlImageSection"
        Me.pnlImageSection.Size = New System.Drawing.Size(388, 90)
        Me.pnlImageSection.TabIndex = 10
        '
        'btnSeleccionarImagen
        '
        Me.btnSeleccionarImagen.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnSeleccionarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSeleccionarImagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnSeleccionarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionarImagen.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSeleccionarImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnSeleccionarImagen.Location = New System.Drawing.Point(170, 30)
        Me.btnSeleccionarImagen.Name = "btnSeleccionarImagen"
        Me.btnSeleccionarImagen.Size = New System.Drawing.Size(180, 34)
        Me.btnSeleccionarImagen.TabIndex = 2
        Me.btnSeleccionarImagen.Text = "📷 Seleccionar Imagen"
        Me.btnSeleccionarImagen.UseVisualStyleBackColor = False
        '
        'picProducto
        '
        Me.picProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picProducto.Location = New System.Drawing.Point(85, 10)
        Me.picProducto.Name = "picProducto"
        Me.picProducto.Size = New System.Drawing.Size(70, 70)
        Me.picProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProducto.TabIndex = 1
        Me.picProducto.TabStop = False
        '
        'lblImagen
        '
        Me.lblImagen.AutoSize = True
        Me.lblImagen.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblImagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblImagen.Location = New System.Drawing.Point(0, 10)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(51, 15)
        Me.lblImagen.TabIndex = 0
        Me.lblImagen.Text = "Imagen:"
        '
        'pnlCheckboxes
        '
        Me.pnlCheckboxes.Controls.Add(Me.chkReposicion)
        Me.pnlCheckboxes.Controls.Add(Me.chkPromocion)
        Me.pnlCheckboxes.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCheckboxes.Location = New System.Drawing.Point(0, 270)
        Me.pnlCheckboxes.Name = "pnlCheckboxes"
        Me.pnlCheckboxes.Size = New System.Drawing.Size(388, 35)
        Me.pnlCheckboxes.TabIndex = 9
        '
        'chkReposicion
        '
        Me.chkReposicion.AutoSize = True
        Me.chkReposicion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkReposicion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.chkReposicion.Location = New System.Drawing.Point(170, 8)
        Me.chkReposicion.Name = "chkReposicion"
        Me.chkReposicion.Size = New System.Drawing.Size(140, 19)
        Me.chkReposicion.TabIndex = 1
        Me.chkReposicion.Text = "⚠️ Requiere reposición"
        Me.chkReposicion.UseVisualStyleBackColor = True
        '
        'chkPromocion
        '
        Me.chkPromocion.AutoSize = True
        Me.chkPromocion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.chkPromocion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.chkPromocion.Location = New System.Drawing.Point(5, 8)
        Me.chkPromocion.Name = "chkPromocion"
        Me.chkPromocion.Size = New System.Drawing.Size(117, 19)
        Me.chkPromocion.TabIndex = 0
        Me.chkPromocion.Text = "🏷️ En promoción"
        Me.chkPromocion.UseVisualStyleBackColor = True
        '
        'grpTipo
        '
        Me.grpTipo.Controls.Add(Me.rdbLimpieza)
        Me.grpTipo.Controls.Add(Me.rdbBebida)
        Me.grpTipo.Controls.Add(Me.rdbAlimento)
        Me.grpTipo.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpTipo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grpTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.grpTipo.Location = New System.Drawing.Point(0, 210)
        Me.grpTipo.Name = "grpTipo"
        Me.grpTipo.Size = New System.Drawing.Size(388, 60)
        Me.grpTipo.TabIndex = 8
        Me.grpTipo.TabStop = False
        Me.grpTipo.Text = "Tipo de Producto"
        '
        'rdbLimpieza
        '
        Me.rdbLimpieza.AutoSize = True
        Me.rdbLimpieza.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdbLimpieza.Location = New System.Drawing.Point(210, 24)
        Me.rdbLimpieza.Name = "rdbLimpieza"
        Me.rdbLimpieza.Size = New System.Drawing.Size(73, 19)
        Me.rdbLimpieza.TabIndex = 2
        Me.rdbLimpieza.TabStop = True
        Me.rdbLimpieza.Text = "Limpieza"
        Me.rdbLimpieza.UseVisualStyleBackColor = True
        '
        'rdbBebida
        '
        Me.rdbBebida.AutoSize = True
        Me.rdbBebida.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdbBebida.Location = New System.Drawing.Point(115, 24)
        Me.rdbBebida.Name = "rdbBebida"
        Me.rdbBebida.Text = "Bebida"
        Me.rdbBebida.TabIndex = 1
        Me.rdbBebida.TabStop = True
        Me.rdbBebida.UseVisualStyleBackColor = True
        '
        'rdbAlimento
        '
        Me.rdbAlimento.AutoSize = True
        Me.rdbAlimento.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdbAlimento.Location = New System.Drawing.Point(15, 24)
        Me.rdbAlimento.Name = "rdbAlimento"
        Me.rdbAlimento.Size = New System.Drawing.Size(74, 19)
        Me.rdbAlimento.TabIndex = 0
        Me.rdbAlimento.TabStop = True
        Me.rdbAlimento.Text = "Alimento"
        Me.rdbAlimento.UseVisualStyleBackColor = True
        '
        'cmbCategoria
        '
        Me.cmbCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(0, 185)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(388, 25)
        Me.cmbCategoria.TabIndex = 7
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCategoria.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblCategoria.Location = New System.Drawing.Point(0, 160)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.lblCategoria.Size = New System.Drawing.Size(63, 25)
        Me.lblCategoria.TabIndex = 6
        Me.lblCategoria.Text = "Categoría:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCantidad.Location = New System.Drawing.Point(0, 135)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(388, 25)
        Me.txtCantidad.TabIndex = 5
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCantidad.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblCantidad.Location = New System.Drawing.Point(0, 110)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.lblCantidad.Size = New System.Drawing.Size(58, 25)
        Me.lblCantidad.TabIndex = 4
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtNombre
        '
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNombre.Location = New System.Drawing.Point(0, 85)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(388, 25)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(0, 60)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.lblNombre.Size = New System.Drawing.Size(56, 25)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCodigo.Location = New System.Drawing.Point(0, 35)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(388, 25)
        Me.txtCodigo.TabIndex = 1
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblCodigo.Location = New System.Drawing.Point(0, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Padding = New System.Windows.Forms.Padding(0, 6, 0, 4)
        Me.lblCodigo.Size = New System.Drawing.Size(49, 25)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'lblFormTitle
        '
        Me.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFormTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblFormTitle.Location = New System.Drawing.Point(16, 16)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(388, 26)
        Me.lblFormTitle.TabIndex = 0
        Me.lblFormTitle.Text = "Formulario de Registro"
        '
        'pnlGridCard
        '
        Me.pnlGridCard.BackColor = System.Drawing.Color.White
        Me.pnlGridCard.Controls.Add(Me.dgvProductos)
        Me.pnlGridCard.Controls.Add(Me.pnlGridHeader)
        Me.pnlGridCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridCard.Location = New System.Drawing.Point(0, 0)
        Me.pnlGridCard.Name = "pnlGridCard"
        Me.pnlGridCard.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlGridCard.Size = New System.Drawing.Size(570, 570)
        Me.pnlGridCard.TabIndex = 0
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        Me.dgvProductos.AllowUserToResizeRows = False
        Me.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.ColumnHeadersHeight = 35
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(163, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProductos.EnableHeadersVisualStyles = False
        Me.dgvProductos.GridColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.dgvProductos.Location = New System.Drawing.Point(16, 51)
        Me.dgvProductos.MultiSelect = False
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.RowHeadersVisible = False
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(4)
        Me.dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductos.RowTemplate.Height = 30
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(538, 503)
        Me.dgvProductos.TabIndex = 1
        '
        'pnlGridHeader
        '
        Me.pnlGridHeader.Controls.Add(Me.lblGridTitle)
        Me.pnlGridHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlGridHeader.Location = New System.Drawing.Point(16, 16)
        Me.pnlGridHeader.Name = "pnlGridHeader"
        Me.pnlGridHeader.Size = New System.Drawing.Size(538, 35)
        Me.pnlGridHeader.TabIndex = 0
        '
        'lblGridTitle
        '
        Me.lblGridTitle.AutoSize = True
        Me.lblGridTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblGridTitle.Location = New System.Drawing.Point(0, 4)
        Me.lblGridTitle.Name = "lblGridTitle"
        Me.lblGridTitle.Size = New System.Drawing.Size(185, 21)
        Me.lblGridTitle.TabIndex = 0
        Me.lblGridTitle.Text = "Productos Registrados"
        '
        'pnlSummaryContainer
        '
        Me.pnlSummaryContainer.Controls.Add(Me.pnlSearch)
        Me.pnlSummaryContainer.Controls.Add(Me.pnlTotalUnidadesCard)
        Me.pnlSummaryContainer.Controls.Add(Me.pnlTotalProductosCard)
        Me.pnlSummaryContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSummaryContainer.Location = New System.Drawing.Point(20, 80)
        Me.pnlSummaryContainer.Name = "pnlSummaryContainer"
        Me.pnlSummaryContainer.Size = New System.Drawing.Size(994, 80)
        Me.pnlSummaryContainer.TabIndex = 1
        '
        'pnlSearch
        '
        Me.pnlSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSearch.BackColor = System.Drawing.Color.White
        Me.pnlSearch.Controls.Add(Me.btnMostrarTodo)
        Me.pnlSearch.Controls.Add(Me.btnBuscar)
        Me.pnlSearch.Controls.Add(Me.txtBuscar)
        Me.pnlSearch.Controls.Add(Me.lblBuscar)
        Me.pnlSearch.Location = New System.Drawing.Point(494, 0)
        Me.pnlSearch.Name = "pnlSearch"
        Me.pnlSearch.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlSearch.Size = New System.Drawing.Size(500, 70)
        Me.pnlSearch.TabIndex = 2
        '
        'btnMostrarTodo
        '
        Me.btnMostrarTodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnMostrarTodo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMostrarTodo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnMostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarTodo.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnMostrarTodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.btnMostrarTodo.Location = New System.Drawing.Point(380, 28)
        Me.btnMostrarTodo.Name = "btnMostrarTodo"
        Me.btnMostrarTodo.Size = New System.Drawing.Size(110, 30)
        Me.btnMostrarTodo.TabIndex = 3
        Me.btnMostrarTodo.Text = "📋 Mostrar Todo"
        Me.btnMostrarTodo.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(280, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(94, 30)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "🔍 Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBuscar.Location = New System.Drawing.Point(12, 31)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PlaceholderText = "Código o Nombre..."
        Me.txtBuscar.Size = New System.Drawing.Size(260, 25)
        Me.txtBuscar.TabIndex = 1
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblBuscar.Location = New System.Drawing.Point(10, 8)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(95, 15)
        Me.lblBuscar.TabIndex = 0
        Me.lblBuscar.Text = "Buscar Producto"
        '
        'pnlTotalUnidadesCard
        '
        Me.pnlTotalUnidadesCard.BackColor = System.Drawing.Color.White
        Me.pnlTotalUnidadesCard.Controls.Add(Me.lblTotalUnidadesVal)
        Me.pnlTotalUnidadesCard.Controls.Add(Me.lblTotalUnidadesTitle)
        Me.pnlTotalUnidadesCard.Location = New System.Drawing.Point(240, 0)
        Me.pnlTotalUnidadesCard.Name = "pnlTotalUnidadesCard"
        Me.pnlTotalUnidadesCard.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlTotalUnidadesCard.Size = New System.Drawing.Size(220, 70)
        Me.pnlTotalUnidadesCard.TabIndex = 1
        '
        'lblTotalUnidadesVal
        '
        Me.lblTotalUnidadesVal.AutoSize = True
        Me.lblTotalUnidadesVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalUnidadesVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblTotalUnidadesVal.Location = New System.Drawing.Point(12, 28)
        Me.lblTotalUnidadesVal.Name = "lblTotalUnidadesVal"
        Me.lblTotalUnidadesVal.Size = New System.Drawing.Size(28, 32)
        Me.lblTotalUnidadesVal.TabIndex = 1
        Me.lblTotalUnidadesVal.Text = "0"
        '
        'lblTotalUnidadesTitle
        '
        Me.lblTotalUnidadesTitle.AutoSize = True
        Me.lblTotalUnidadesTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalUnidadesTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTotalUnidadesTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblTotalUnidadesTitle.Name = "lblTotalUnidadesTitle"
        Me.lblTotalUnidadesTitle.Size = New System.Drawing.Size(130, 15)
        Me.lblTotalUnidadesTitle.TabIndex = 0
        Me.lblTotalUnidadesTitle.Text = "Unidades en inventario"
        '
        'pnlTotalProductosCard
        '
        Me.pnlTotalProductosCard.BackColor = System.Drawing.Color.White
        Me.pnlTotalProductosCard.Controls.Add(Me.lblTotalProductosVal)
        Me.pnlTotalProductosCard.Controls.Add(Me.lblTotalProductosTitle)
        Me.pnlTotalProductosCard.Location = New System.Drawing.Point(0, 0)
        Me.pnlTotalProductosCard.Name = "pnlTotalProductosCard"
        Me.pnlTotalProductosCard.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlTotalProductosCard.Size = New System.Drawing.Size(220, 70)
        Me.pnlTotalProductosCard.TabIndex = 0
        '
        'lblTotalProductosVal
        '
        Me.lblTotalProductosVal.AutoSize = True
        Me.lblTotalProductosVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalProductosVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblTotalProductosVal.Location = New System.Drawing.Point(12, 28)
        Me.lblTotalProductosVal.Name = "lblTotalProductosVal"
        Me.lblTotalProductosVal.Size = New System.Drawing.Size(28, 32)
        Me.lblTotalProductosVal.TabIndex = 1
        Me.lblTotalProductosVal.Text = "0"
        '
        'lblTotalProductosTitle
        '
        Me.lblTotalProductosTitle.AutoSize = True
        Me.lblTotalProductosTitle.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTotalProductosTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblTotalProductosTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblTotalProductosTitle.Name = "lblTotalProductosTitle"
        Me.lblTotalProductosTitle.Size = New System.Drawing.Size(112, 15)
        Me.lblTotalProductosTitle.TabIndex = 0
        Me.lblTotalProductosTitle.Text = "Total de productos"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.lblSubHeader)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(20, 20)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(994, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSubHeader
        '
        Me.lblSubHeader.AutoSize = True
        Me.lblSubHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblSubHeader.Location = New System.Drawing.Point(2, 32)
        Me.lblSubHeader.Name = "lblSubHeader"
        Me.lblSubHeader.Size = New System.Drawing.Size(356, 15)
        Me.lblSubHeader.TabIndex = 1
        Me.lblSubHeader.Text = "Administración general, búsqueda y actualización de mercadería"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(342, 30)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Gestión General de Inventario"
        '
        'ofdImagen
        '
        Me.ofdImagen.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos (*.*)|*.*"
        Me.ofdImagen.Title = "Seleccionar Imagen del Producto"
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1264, 750)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinimumSize = New System.Drawing.Size(1100, 700)
        Me.Name = "FrmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control de Inventario - Comercio"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlInfoMemoria.ResumeLayout(False)
        Me.pnlNavInventario.ResumeLayout(False)
        Me.pnlNavInventario.PerformLayout()
        Me.pnlBrand.ResumeLayout(False)
        Me.pnlBrand.PerformLayout()
        Me.pnlMain.ResumeLayout(False)
        Me.splContent.Panel1.ResumeLayout(False)
        Me.splContent.Panel2.ResumeLayout(False)
        CType(Me.splContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splContent.ResumeLayout(False)
        Me.pnlFormCard.ResumeLayout(False)
        Me.pnlFormContent.ResumeLayout(False)
        Me.pnlFormContent.PerformLayout()
        Me.pnlButtonsGrid.ResumeLayout(False)
        Me.pnlImageSection.ResumeLayout(False)
        Me.pnlImageSection.PerformLayout()
        CType(Me.picProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCheckboxes.ResumeLayout(False)
        Me.pnlCheckboxes.PerformLayout()
        Me.grpTipo.ResumeLayout(False)
        Me.grpTipo.PerformLayout()
        Me.pnlGridCard.ResumeLayout(False)
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGridHeader.ResumeLayout(False)
        Me.pnlGridHeader.PerformLayout()
        Me.pnlSummaryContainer.ResumeLayout(False)
        Me.pnlSearch.ResumeLayout(False)
        Me.pnlSearch.PerformLayout()
        Me.pnlTotalUnidadesCard.ResumeLayout(False)
        Me.pnlTotalUnidadesCard.PerformLayout()
        Me.pnlTotalProductosCard.ResumeLayout(False)
        Me.pnlTotalProductosCard.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblBrandSub As System.Windows.Forms.Label
    Friend WithEvents lblBrand As System.Windows.Forms.Label
    Friend WithEvents pnlNavInventario As System.Windows.Forms.Panel
    Friend WithEvents lblNavInventario As System.Windows.Forms.Label
    Friend WithEvents btnNavVisualSidebar As System.Windows.Forms.Button
    Friend WithEvents pnlInfoMemoria As System.Windows.Forms.Panel
    Friend WithEvents lblInfoMemoriaText As System.Windows.Forms.Label
    Friend WithEvents lblInfoMemoriaTitle As System.Windows.Forms.Label
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSubHeader As System.Windows.Forms.Label
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents pnlSummaryContainer As System.Windows.Forms.Panel
    Friend WithEvents pnlTotalProductosCard As System.Windows.Forms.Panel
    Friend WithEvents lblTotalProductosVal As System.Windows.Forms.Label
    Friend WithEvents lblTotalProductosTitle As System.Windows.Forms.Label
    Friend WithEvents pnlTotalUnidadesCard As System.Windows.Forms.Panel
    Friend WithEvents lblTotalUnidadesVal As System.Windows.Forms.Label
    Friend WithEvents lblTotalUnidadesTitle As System.Windows.Forms.Label
    Friend WithEvents pnlSearch As System.Windows.Forms.Panel
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnMostrarTodo As System.Windows.Forms.Button
    Friend WithEvents splContent As System.Windows.Forms.SplitContainer
    Friend WithEvents pnlFormCard As System.Windows.Forms.Panel
    Friend WithEvents lblFormTitle As System.Windows.Forms.Label
    Friend WithEvents pnlFormContent As System.Windows.Forms.Panel
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents grpTipo As System.Windows.Forms.GroupBox
    Friend WithEvents rdbAlimento As System.Windows.Forms.RadioButton
    Friend WithEvents rdbBebida As System.Windows.Forms.RadioButton
    Friend WithEvents rdbLimpieza As System.Windows.Forms.RadioButton
    Friend WithEvents pnlCheckboxes As System.Windows.Forms.Panel
    Friend WithEvents chkPromocion As System.Windows.Forms.CheckBox
    Friend WithEvents chkReposicion As System.Windows.Forms.CheckBox
    Friend WithEvents pnlImageSection As System.Windows.Forms.Panel
    Friend WithEvents lblImagen As System.Windows.Forms.Label
    Friend WithEvents picProducto As System.Windows.Forms.PictureBox
    Friend WithEvents btnSeleccionarImagen As System.Windows.Forms.Button
    Friend WithEvents pnlButtonsGrid As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnInventarioVisual As System.Windows.Forms.Button
    Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
    Friend WithEvents pnlGridHeader As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents ofdImagen As System.Windows.Forms.OpenFileDialog
End Class

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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        btnNavProveedores = New Button()
        pnlInfoMemoria = New Panel()
        lblInfoMemoriaText = New Label()
        lblInfoMemoriaTitle = New Label()
        btnNavVisualSidebar = New Button()
        pnlNavInventario = New Panel()
        lblNavInventario = New Label()
        pnlBrand = New Panel()
        lblBrandSub = New Label()
        lblBrand = New Label()
        pnlMain = New Panel()
        splContent = New SplitContainer()
        pnlFormCard = New Panel()
        pnlFormContent = New Panel()
        pnlButtonsGrid = New TableLayoutPanel()
        btnGuardar = New Button()
        btnActualizar = New Button()
        btnEliminar = New Button()
        btnLimpiar = New Button()
        btnInventarioVisual = New Button()
        btnPortalProveedores = New Button()
        pnlImageSection = New Panel()
        btnSeleccionarImagen = New Button()
        picProducto = New PictureBox()
        lblImagen = New Label()
        pnlCheckboxes = New Panel()
        chkReposicion = New CheckBox()
        chkPromocion = New CheckBox()
        grpTipo = New GroupBox()
        rdbLimpieza = New RadioButton()
        rdbBebida = New RadioButton()
        rdbAlimento = New RadioButton()
        cmbCategoria = New ComboBox()
        lblCategoria = New Label()
        txtCantidad = New TextBox()
        lblCantidad = New Label()
        txtNombre = New TextBox()
        lblNombre = New Label()
        txtCodigo = New TextBox()
        lblCodigo = New Label()
        lblFormTitle = New Label()
        pnlGridCard = New Panel()
        dgvProductos = New DataGridView()
        pnlGridHeader = New Panel()
        lblGridTitle = New Label()
        pnlSummaryContainer = New Panel()
        pnlSearch = New Panel()
        btnSimularConsumoInv = New Button()
        btnMostrarTodo = New Button()
        btnBuscar = New Button()
        txtBuscar = New TextBox()
        lblBuscar = New Label()
        pnlTotalUnidadesCard = New Panel()
        lblTotalUnidadesVal = New Label()
        lblTotalUnidadesTitle = New Label()
        pnlTotalProductosCard = New Panel()
        lblTotalProductosVal = New Label()
        lblTotalProductosTitle = New Label()
        pnlHeader = New Panel()
        lblSubHeader = New Label()
        lblHeaderTitle = New Label()
        ofdImagen = New OpenFileDialog()
        pnlSidebar.SuspendLayout()
        pnlInfoMemoria.SuspendLayout()
        pnlNavInventario.SuspendLayout()
        pnlBrand.SuspendLayout()
        pnlMain.SuspendLayout()
        CType(splContent, ComponentModel.ISupportInitialize).BeginInit()
        splContent.Panel1.SuspendLayout()
        splContent.Panel2.SuspendLayout()
        splContent.SuspendLayout()
        pnlFormCard.SuspendLayout()
        pnlFormContent.SuspendLayout()
        pnlButtonsGrid.SuspendLayout()
        pnlImageSection.SuspendLayout()
        CType(picProducto, ComponentModel.ISupportInitialize).BeginInit()
        pnlCheckboxes.SuspendLayout()
        grpTipo.SuspendLayout()
        pnlGridCard.SuspendLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        pnlGridHeader.SuspendLayout()
        pnlSummaryContainer.SuspendLayout()
        pnlSearch.SuspendLayout()
        pnlTotalUnidadesCard.SuspendLayout()
        pnlTotalProductosCard.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.White
        pnlSidebar.Controls.Add(btnNavProveedores)
        pnlSidebar.Controls.Add(pnlInfoMemoria)
        pnlSidebar.Controls.Add(btnNavVisualSidebar)
        pnlSidebar.Controls.Add(pnlNavInventario)
        pnlSidebar.Controls.Add(pnlBrand)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(230, 750)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnNavProveedores
        ' 
        btnNavProveedores.Cursor = Cursors.Hand
        btnNavProveedores.FlatAppearance.BorderSize = 0
        btnNavProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(233), CByte(163))
        btnNavProveedores.FlatStyle = FlatStyle.Flat
        btnNavProveedores.Font = New Font("Segoe UI", 10F)
        btnNavProveedores.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        btnNavProveedores.Location = New Point(12, 190)
        btnNavProveedores.Name = "btnNavProveedores"
        btnNavProveedores.Padding = New Padding(10, 0, 0, 0)
        btnNavProveedores.Size = New Size(206, 44)
        btnNavProveedores.TabIndex = 4
        btnNavProveedores.Text = "🚚  Red Proveedores"
        btnNavProveedores.TextAlign = ContentAlignment.MiddleLeft
        btnNavProveedores.UseVisualStyleBackColor = True
        ' 
        ' pnlInfoMemoria
        ' 
        pnlInfoMemoria.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        pnlInfoMemoria.Controls.Add(lblInfoMemoriaText)
        pnlInfoMemoria.Controls.Add(lblInfoMemoriaTitle)
        pnlInfoMemoria.Dock = DockStyle.Bottom
        pnlInfoMemoria.Location = New Point(0, 640)
        pnlInfoMemoria.Name = "pnlInfoMemoria"
        pnlInfoMemoria.Padding = New Padding(12)
        pnlInfoMemoria.Size = New Size(230, 110)
        pnlInfoMemoria.TabIndex = 3
        ' 
        ' lblInfoMemoriaText
        ' 
        lblInfoMemoriaText.Dock = DockStyle.Fill
        lblInfoMemoriaText.Font = New Font("Segoe UI", 8F)
        lblInfoMemoriaText.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblInfoMemoriaText.Location = New Point(12, 32)
        lblInfoMemoriaText.Name = "lblInfoMemoriaText"
        lblInfoMemoriaText.Size = New Size(206, 66)
        lblInfoMemoriaText.TabIndex = 1
        lblInfoMemoriaText.Text = "Los datos se almacenan temporalmente en List(Of Producto) durante esta sesión."
        ' 
        ' lblInfoMemoriaTitle
        ' 
        lblInfoMemoriaTitle.Dock = DockStyle.Top
        lblInfoMemoriaTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblInfoMemoriaTitle.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        lblInfoMemoriaTitle.Location = New Point(12, 12)
        lblInfoMemoriaTitle.Name = "lblInfoMemoriaTitle"
        lblInfoMemoriaTitle.Size = New Size(206, 20)
        lblInfoMemoriaTitle.TabIndex = 0
        lblInfoMemoriaTitle.Text = "💡 Modo en Memoria"
        ' 
        ' btnNavVisualSidebar
        ' 
        btnNavVisualSidebar.Cursor = Cursors.Hand
        btnNavVisualSidebar.FlatAppearance.BorderSize = 0
        btnNavVisualSidebar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(233), CByte(163))
        btnNavVisualSidebar.FlatStyle = FlatStyle.Flat
        btnNavVisualSidebar.Font = New Font("Segoe UI", 10F)
        btnNavVisualSidebar.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        btnNavVisualSidebar.Location = New Point(12, 140)
        btnNavVisualSidebar.Name = "btnNavVisualSidebar"
        btnNavVisualSidebar.Padding = New Padding(10, 0, 0, 0)
        btnNavVisualSidebar.Size = New Size(206, 44)
        btnNavVisualSidebar.TabIndex = 2
        btnNavVisualSidebar.Text = "🖼️  Inventario Visual"
        btnNavVisualSidebar.TextAlign = ContentAlignment.MiddleLeft
        btnNavVisualSidebar.UseVisualStyleBackColor = True
        ' 
        ' pnlNavInventario
        ' 
        pnlNavInventario.BackColor = Color.FromArgb(CByte(255), CByte(233), CByte(163))
        pnlNavInventario.Controls.Add(lblNavInventario)
        pnlNavInventario.Cursor = Cursors.Hand
        pnlNavInventario.Location = New Point(12, 90)
        pnlNavInventario.Name = "pnlNavInventario"
        pnlNavInventario.Size = New Size(206, 44)
        pnlNavInventario.TabIndex = 1
        ' 
        ' lblNavInventario
        ' 
        lblNavInventario.AutoSize = True
        lblNavInventario.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblNavInventario.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        lblNavInventario.Location = New Point(15, 12)
        lblNavInventario.Name = "lblNavInventario"
        lblNavInventario.Size = New Size(159, 19)
        lblNavInventario.TabIndex = 0
        lblNavInventario.Text = "📦  Gestión Inventario"
        ' 
        ' pnlBrand
        ' 
        pnlBrand.Controls.Add(lblBrandSub)
        pnlBrand.Controls.Add(lblBrand)
        pnlBrand.Dock = DockStyle.Top
        pnlBrand.Location = New Point(0, 0)
        pnlBrand.Name = "pnlBrand"
        pnlBrand.Size = New Size(230, 75)
        pnlBrand.TabIndex = 0
        ' 
        ' lblBrandSub
        ' 
        lblBrandSub.AutoSize = True
        lblBrandSub.Font = New Font("Segoe UI", 8.25F)
        lblBrandSub.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblBrandSub.Location = New Point(16, 42)
        lblBrandSub.Name = "lblBrandSub"
        lblBrandSub.Size = New Size(117, 13)
        lblBrandSub.TabIndex = 1
        lblBrandSub.Text = "Control de Inventario"
        ' 
        ' lblBrand
        ' 
        lblBrand.AutoSize = True
        lblBrand.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblBrand.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        lblBrand.Location = New Point(14, 16)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(137, 25)
        lblBrand.TabIndex = 0
        lblBrand.Text = "🏪 COMERCIO"
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        pnlMain.Controls.Add(splContent)
        pnlMain.Controls.Add(pnlSummaryContainer)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(230, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(20)
        pnlMain.Size = New Size(1034, 750)
        pnlMain.TabIndex = 1
        ' 
        ' splContent
        ' 
        splContent.Dock = DockStyle.Fill
        splContent.FixedPanel = FixedPanel.Panel1
        splContent.Location = New Point(20, 160)
        splContent.Name = "splContent"
        ' 
        ' splContent.Panel1
        ' 
        splContent.Panel1.Controls.Add(pnlFormCard)
        ' 
        ' splContent.Panel2
        ' 
        splContent.Panel2.Controls.Add(pnlGridCard)
        splContent.Size = New Size(994, 570)
        splContent.SplitterDistance = 420
        splContent.TabIndex = 2
        ' 
        ' pnlFormCard
        ' 
        pnlFormCard.AutoScroll = True
        pnlFormCard.BackColor = Color.White
        pnlFormCard.Controls.Add(pnlFormContent)
        pnlFormCard.Controls.Add(lblFormTitle)
        pnlFormCard.Dock = DockStyle.Fill
        pnlFormCard.Location = New Point(0, 0)
        pnlFormCard.Name = "pnlFormCard"
        pnlFormCard.Padding = New Padding(16)
        pnlFormCard.Size = New Size(420, 570)
        pnlFormCard.TabIndex = 0
        ' 
        ' pnlFormContent
        ' 
        pnlFormContent.Controls.Add(pnlButtonsGrid)
        pnlFormContent.Controls.Add(pnlImageSection)
        pnlFormContent.Controls.Add(pnlCheckboxes)
        pnlFormContent.Controls.Add(grpTipo)
        pnlFormContent.Controls.Add(cmbCategoria)
        pnlFormContent.Controls.Add(lblCategoria)
        pnlFormContent.Controls.Add(txtCantidad)
        pnlFormContent.Controls.Add(lblCantidad)
        pnlFormContent.Controls.Add(txtNombre)
        pnlFormContent.Controls.Add(lblNombre)
        pnlFormContent.Controls.Add(txtCodigo)
        pnlFormContent.Controls.Add(lblCodigo)
        pnlFormContent.Dock = DockStyle.Fill
        pnlFormContent.Location = New Point(16, 42)
        pnlFormContent.Name = "pnlFormContent"
        pnlFormContent.Size = New Size(388, 512)
        pnlFormContent.TabIndex = 1
        ' 
        ' pnlButtonsGrid
        ' 
        pnlButtonsGrid.ColumnCount = 2
        pnlButtonsGrid.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        pnlButtonsGrid.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        pnlButtonsGrid.Controls.Add(btnGuardar, 0, 0)
        pnlButtonsGrid.Controls.Add(btnActualizar, 1, 0)
        pnlButtonsGrid.Controls.Add(btnEliminar, 0, 1)
        pnlButtonsGrid.Controls.Add(btnLimpiar, 1, 1)
        pnlButtonsGrid.Controls.Add(btnInventarioVisual, 0, 2)
        pnlButtonsGrid.Controls.Add(btnPortalProveedores, 0, 3)
        pnlButtonsGrid.Dock = DockStyle.Top
        pnlButtonsGrid.Location = New Point(0, 382)
        pnlButtonsGrid.Name = "pnlButtonsGrid"
        pnlButtonsGrid.RowCount = 4
        pnlButtonsGrid.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        pnlButtonsGrid.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        pnlButtonsGrid.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        pnlButtonsGrid.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        pnlButtonsGrid.Size = New Size(388, 155)
        pnlButtonsGrid.TabIndex = 11
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        btnGuardar.Cursor = Cursors.Hand
        btnGuardar.Dock = DockStyle.Fill
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnGuardar.ForeColor = Color.White
        btnGuardar.Location = New Point(2, 2)
        btnGuardar.Margin = New Padding(2)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(190, 34)
        btnGuardar.TabIndex = 0
        btnGuardar.Text = "💾 Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.FromArgb(CByte(255), CByte(201), CByte(40))
        btnActualizar.Cursor = Cursors.Hand
        btnActualizar.Dock = DockStyle.Fill
        btnActualizar.FlatAppearance.BorderSize = 0
        btnActualizar.FlatStyle = FlatStyle.Flat
        btnActualizar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnActualizar.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        btnActualizar.Location = New Point(196, 2)
        btnActualizar.Margin = New Padding(2)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(190, 34)
        btnActualizar.TabIndex = 1
        btnActualizar.Text = "✏️ Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(232), CByte(93), CByte(93))
        btnEliminar.Cursor = Cursors.Hand
        btnEliminar.Dock = DockStyle.Fill
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.FlatStyle = FlatStyle.Flat
        btnEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnEliminar.ForeColor = Color.White
        btnEliminar.Location = New Point(2, 40)
        btnEliminar.Margin = New Padding(2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(190, 34)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "🗑️ Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        btnLimpiar.Cursor = Cursors.Hand
        btnLimpiar.Dock = DockStyle.Fill
        btnLimpiar.FlatAppearance.BorderColor = Color.FromArgb(CByte(213), CByte(218), CByte(225))
        btnLimpiar.FlatStyle = FlatStyle.Flat
        btnLimpiar.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnLimpiar.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        btnLimpiar.Location = New Point(196, 40)
        btnLimpiar.Margin = New Padding(2)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(190, 34)
        btnLimpiar.TabIndex = 3
        btnLimpiar.Text = ChrW(55358) & ChrW(56825) & " Limpiar"
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnInventarioVisual
        ' 
        btnInventarioVisual.BackColor = Color.FromArgb(CByte(255), CByte(233), CByte(163))
        pnlButtonsGrid.SetColumnSpan(btnInventarioVisual, 2)
        btnInventarioVisual.Cursor = Cursors.Hand
        btnInventarioVisual.Dock = DockStyle.Fill
        btnInventarioVisual.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(201), CByte(40))
        btnInventarioVisual.FlatStyle = FlatStyle.Flat
        btnInventarioVisual.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnInventarioVisual.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        btnInventarioVisual.Location = New Point(2, 78)
        btnInventarioVisual.Margin = New Padding(2)
        btnInventarioVisual.Name = "btnInventarioVisual"
        btnInventarioVisual.Size = New Size(384, 34)
        btnInventarioVisual.TabIndex = 4
        btnInventarioVisual.Text = "👁️ Ver Inventario Visual"
        btnInventarioVisual.UseVisualStyleBackColor = False
        ' 
        ' btnPortalProveedores
        ' 
        btnPortalProveedores.BackColor = Color.FromArgb(CByte(26), CByte(35), CByte(126))
        pnlButtonsGrid.SetColumnSpan(btnPortalProveedores, 2)
        btnPortalProveedores.Cursor = Cursors.Hand
        btnPortalProveedores.Dock = DockStyle.Fill
        btnPortalProveedores.FlatAppearance.BorderSize = 0
        btnPortalProveedores.FlatStyle = FlatStyle.Flat
        btnPortalProveedores.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        btnPortalProveedores.ForeColor = Color.White
        btnPortalProveedores.Location = New Point(2, 116)
        btnPortalProveedores.Margin = New Padding(2)
        btnPortalProveedores.Name = "btnPortalProveedores"
        btnPortalProveedores.Size = New Size(384, 37)
        btnPortalProveedores.TabIndex = 5
        btnPortalProveedores.Text = "🚚 Portal de Red de Proveedores"
        btnPortalProveedores.UseVisualStyleBackColor = False
        ' 
        ' pnlImageSection
        ' 
        pnlImageSection.Controls.Add(btnSeleccionarImagen)
        pnlImageSection.Controls.Add(picProducto)
        pnlImageSection.Controls.Add(lblImagen)
        pnlImageSection.Dock = DockStyle.Top
        pnlImageSection.Location = New Point(0, 292)
        pnlImageSection.Name = "pnlImageSection"
        pnlImageSection.Size = New Size(388, 90)
        pnlImageSection.TabIndex = 10
        ' 
        ' btnSeleccionarImagen
        ' 
        btnSeleccionarImagen.BackColor = Color.FromArgb(CByte(255), CByte(233), CByte(163))
        btnSeleccionarImagen.Cursor = Cursors.Hand
        btnSeleccionarImagen.FlatAppearance.BorderColor = Color.FromArgb(CByte(213), CByte(218), CByte(225))
        btnSeleccionarImagen.FlatStyle = FlatStyle.Flat
        btnSeleccionarImagen.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnSeleccionarImagen.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        btnSeleccionarImagen.Location = New Point(170, 30)
        btnSeleccionarImagen.Name = "btnSeleccionarImagen"
        btnSeleccionarImagen.Size = New Size(180, 34)
        btnSeleccionarImagen.TabIndex = 2
        btnSeleccionarImagen.Text = "📷 Seleccionar Imagen"
        btnSeleccionarImagen.UseVisualStyleBackColor = False
        ' 
        ' picProducto
        ' 
        picProducto.BorderStyle = BorderStyle.FixedSingle
        picProducto.Location = New Point(85, 10)
        picProducto.Name = "picProducto"
        picProducto.Size = New Size(70, 70)
        picProducto.SizeMode = PictureBoxSizeMode.Zoom
        picProducto.TabIndex = 1
        picProducto.TabStop = False
        ' 
        ' lblImagen
        ' 
        lblImagen.AutoSize = True
        lblImagen.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblImagen.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblImagen.Location = New Point(0, 10)
        lblImagen.Name = "lblImagen"
        lblImagen.Size = New Size(52, 15)
        lblImagen.TabIndex = 0
        lblImagen.Text = "Imagen:"
        ' 
        ' pnlCheckboxes
        ' 
        pnlCheckboxes.Controls.Add(chkReposicion)
        pnlCheckboxes.Controls.Add(chkPromocion)
        pnlCheckboxes.Dock = DockStyle.Top
        pnlCheckboxes.Location = New Point(0, 257)
        pnlCheckboxes.Name = "pnlCheckboxes"
        pnlCheckboxes.Size = New Size(388, 35)
        pnlCheckboxes.TabIndex = 9
        ' 
        ' chkReposicion
        ' 
        chkReposicion.AutoSize = True
        chkReposicion.Font = New Font("Segoe UI", 9F)
        chkReposicion.ForeColor = Color.FromArgb(CByte(232), CByte(93), CByte(93))
        chkReposicion.Location = New Point(170, 8)
        chkReposicion.Name = "chkReposicion"
        chkReposicion.Size = New Size(145, 19)
        chkReposicion.TabIndex = 1
        chkReposicion.Text = "⚠️ Requiere reposición"
        chkReposicion.UseVisualStyleBackColor = True
        ' 
        ' chkPromocion
        ' 
        chkPromocion.AutoSize = True
        chkPromocion.Font = New Font("Segoe UI", 9F)
        chkPromocion.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        chkPromocion.Location = New Point(5, 8)
        chkPromocion.Name = "chkPromocion"
        chkPromocion.Size = New Size(116, 19)
        chkPromocion.TabIndex = 0
        chkPromocion.Text = "🏷️ En promoción"
        chkPromocion.UseVisualStyleBackColor = True
        ' 
        ' grpTipo
        ' 
        grpTipo.Controls.Add(rdbLimpieza)
        grpTipo.Controls.Add(rdbBebida)
        grpTipo.Controls.Add(rdbAlimento)
        grpTipo.Dock = DockStyle.Top
        grpTipo.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        grpTipo.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        grpTipo.Location = New Point(0, 197)
        grpTipo.Name = "grpTipo"
        grpTipo.Size = New Size(388, 60)
        grpTipo.TabIndex = 8
        grpTipo.TabStop = False
        grpTipo.Text = "Tipo de Producto"
        ' 
        ' rdbLimpieza
        ' 
        rdbLimpieza.AutoSize = True
        rdbLimpieza.Font = New Font("Segoe UI", 9F)
        rdbLimpieza.Location = New Point(210, 24)
        rdbLimpieza.Name = "rdbLimpieza"
        rdbLimpieza.Size = New Size(72, 19)
        rdbLimpieza.TabIndex = 2
        rdbLimpieza.TabStop = True
        rdbLimpieza.Text = "Limpieza"
        rdbLimpieza.UseVisualStyleBackColor = True
        ' 
        ' rdbBebida
        ' 
        rdbBebida.AutoSize = True
        rdbBebida.Font = New Font("Segoe UI", 9F)
        rdbBebida.Location = New Point(115, 24)
        rdbBebida.Name = "rdbBebida"
        rdbBebida.Size = New Size(61, 19)
        rdbBebida.TabIndex = 1
        rdbBebida.TabStop = True
        rdbBebida.Text = "Bebida"
        rdbBebida.UseVisualStyleBackColor = True
        ' 
        ' rdbAlimento
        ' 
        rdbAlimento.AutoSize = True
        rdbAlimento.Font = New Font("Segoe UI", 9F)
        rdbAlimento.Location = New Point(15, 24)
        rdbAlimento.Name = "rdbAlimento"
        rdbAlimento.Size = New Size(74, 19)
        rdbAlimento.TabIndex = 0
        rdbAlimento.TabStop = True
        rdbAlimento.Text = "Alimento"
        rdbAlimento.UseVisualStyleBackColor = True
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.Dock = DockStyle.Top
        cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCategoria.Font = New Font("Segoe UI", 9.5F)
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(0, 172)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(388, 25)
        cmbCategoria.TabIndex = 7
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Dock = DockStyle.Top
        lblCategoria.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCategoria.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblCategoria.Location = New Point(0, 147)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Padding = New Padding(0, 6, 0, 4)
        lblCategoria.Size = New Size(63, 25)
        lblCategoria.TabIndex = 6
        lblCategoria.Text = "Categoría:"
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Dock = DockStyle.Top
        txtCantidad.Font = New Font("Segoe UI", 9.5F)
        txtCantidad.Location = New Point(0, 123)
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(388, 24)
        txtCantidad.TabIndex = 5
        ' 
        ' lblCantidad
        ' 
        lblCantidad.AutoSize = True
        lblCantidad.Dock = DockStyle.Top
        lblCantidad.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCantidad.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblCantidad.Location = New Point(0, 98)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Padding = New Padding(0, 6, 0, 4)
        lblCantidad.Size = New Size(58, 25)
        lblCantidad.TabIndex = 4
        lblCantidad.Text = "Cantidad:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Dock = DockStyle.Top
        txtNombre.Font = New Font("Segoe UI", 9.5F)
        txtNombre.Location = New Point(0, 74)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(388, 24)
        txtNombre.TabIndex = 3
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Dock = DockStyle.Top
        lblNombre.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblNombre.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblNombre.Location = New Point(0, 49)
        lblNombre.Name = "lblNombre"
        lblNombre.Padding = New Padding(0, 6, 0, 4)
        lblNombre.Size = New Size(56, 25)
        lblNombre.TabIndex = 2
        lblNombre.Text = "Nombre:"
        ' 
        ' txtCodigo
        ' 
        txtCodigo.Dock = DockStyle.Top
        txtCodigo.Font = New Font("Segoe UI", 9.5F)
        txtCodigo.Location = New Point(0, 25)
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New Size(388, 24)
        txtCodigo.TabIndex = 1
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Dock = DockStyle.Top
        lblCodigo.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lblCodigo.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblCodigo.Location = New Point(0, 0)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Padding = New Padding(0, 6, 0, 4)
        lblCodigo.Size = New Size(48, 25)
        lblCodigo.TabIndex = 0
        lblCodigo.Text = "Código:"
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.Dock = DockStyle.Top
        lblFormTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblFormTitle.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        lblFormTitle.Location = New Point(16, 16)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(388, 26)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Formulario de Registro"
        ' 
        ' pnlGridCard
        ' 
        pnlGridCard.BackColor = Color.White
        pnlGridCard.Controls.Add(dgvProductos)
        pnlGridCard.Controls.Add(pnlGridHeader)
        pnlGridCard.Dock = DockStyle.Fill
        pnlGridCard.Location = New Point(0, 0)
        pnlGridCard.Name = "pnlGridCard"
        pnlGridCard.Padding = New Padding(16)
        pnlGridCard.Size = New Size(570, 570)
        pnlGridCard.TabIndex = 0
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.AllowUserToResizeRows = False
        dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.BackgroundColor = Color.White
        dgvProductos.BorderStyle = BorderStyle.None
        dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvProductos.ColumnHeadersHeight = 35
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(255), CByte(233), CByte(163))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvProductos.DefaultCellStyle = DataGridViewCellStyle2
        dgvProductos.Dock = DockStyle.Fill
        dgvProductos.EnableHeadersVisualStyles = False
        dgvProductos.GridColor = Color.FromArgb(CByte(213), CByte(218), CByte(225))
        dgvProductos.Location = New Point(16, 51)
        dgvProductos.MultiSelect = False
        dgvProductos.Name = "dgvProductos"
        dgvProductos.ReadOnly = True
        dgvProductos.RowHeadersVisible = False
        DataGridViewCellStyle3.Padding = New Padding(4)
        dgvProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvProductos.RowTemplate.Height = 30
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.Size = New Size(538, 503)
        dgvProductos.TabIndex = 1
        ' 
        ' pnlGridHeader
        ' 
        pnlGridHeader.Controls.Add(lblGridTitle)
        pnlGridHeader.Dock = DockStyle.Top
        pnlGridHeader.Location = New Point(16, 16)
        pnlGridHeader.Name = "pnlGridHeader"
        pnlGridHeader.Size = New Size(538, 35)
        pnlGridHeader.TabIndex = 0
        ' 
        ' lblGridTitle
        ' 
        lblGridTitle.AutoSize = True
        lblGridTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblGridTitle.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        lblGridTitle.Location = New Point(0, 4)
        lblGridTitle.Name = "lblGridTitle"
        lblGridTitle.Size = New Size(180, 21)
        lblGridTitle.TabIndex = 0
        lblGridTitle.Text = "Productos Registrados"
        ' 
        ' pnlSummaryContainer
        ' 
        pnlSummaryContainer.Controls.Add(pnlSearch)
        pnlSummaryContainer.Controls.Add(pnlTotalUnidadesCard)
        pnlSummaryContainer.Controls.Add(pnlTotalProductosCard)
        pnlSummaryContainer.Dock = DockStyle.Top
        pnlSummaryContainer.Location = New Point(20, 80)
        pnlSummaryContainer.Name = "pnlSummaryContainer"
        pnlSummaryContainer.Size = New Size(994, 80)
        pnlSummaryContainer.TabIndex = 1
        ' 
        ' pnlSearch
        ' 
        pnlSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlSearch.BackColor = Color.White
        pnlSearch.Controls.Add(btnSimularConsumoInv)
        pnlSearch.Controls.Add(btnMostrarTodo)
        pnlSearch.Controls.Add(btnBuscar)
        pnlSearch.Controls.Add(txtBuscar)
        pnlSearch.Controls.Add(lblBuscar)
        pnlSearch.Location = New Point(334, 0)
        pnlSearch.Name = "pnlSearch"
        pnlSearch.Padding = New Padding(10)
        pnlSearch.Size = New Size(660, 70)
        pnlSearch.TabIndex = 2
        ' 
        ' btnSimularConsumoInv
        ' 
        btnSimularConsumoInv.BackColor = Color.FromArgb(CByte(255), CByte(243), CByte(224))
        btnSimularConsumoInv.Cursor = Cursors.Hand
        btnSimularConsumoInv.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(183), CByte(77))
        btnSimularConsumoInv.FlatStyle = FlatStyle.Flat
        btnSimularConsumoInv.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnSimularConsumoInv.ForeColor = Color.FromArgb(CByte(191), CByte(54), CByte(12))
        btnSimularConsumoInv.Location = New Point(495, 28)
        btnSimularConsumoInv.Name = "btnSimularConsumoInv"
        btnSimularConsumoInv.Size = New Size(155, 30)
        btnSimularConsumoInv.TabIndex = 4
        btnSimularConsumoInv.Text = "📉 Simular Venta"
        btnSimularConsumoInv.UseVisualStyleBackColor = False
        ' 
        ' btnMostrarTodo
        ' 
        btnMostrarTodo.BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        btnMostrarTodo.Cursor = Cursors.Hand
        btnMostrarTodo.FlatAppearance.BorderColor = Color.FromArgb(CByte(213), CByte(218), CByte(225))
        btnMostrarTodo.FlatStyle = FlatStyle.Flat
        btnMostrarTodo.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnMostrarTodo.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        btnMostrarTodo.Location = New Point(380, 28)
        btnMostrarTodo.Name = "btnMostrarTodo"
        btnMostrarTodo.Size = New Size(110, 30)
        btnMostrarTodo.TabIndex = 3
        btnMostrarTodo.Text = "📋 Mostrar Todo"
        btnMostrarTodo.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        btnBuscar.Cursor = Cursors.Hand
        btnBuscar.FlatAppearance.BorderSize = 0
        btnBuscar.FlatStyle = FlatStyle.Flat
        btnBuscar.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        btnBuscar.ForeColor = Color.White
        btnBuscar.Location = New Point(280, 28)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 30)
        btnBuscar.TabIndex = 2
        btnBuscar.Text = "🔍 Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Font = New Font("Segoe UI", 9.5F)
        txtBuscar.Location = New Point(12, 31)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "Código o Nombre..."
        txtBuscar.Size = New Size(260, 24)
        txtBuscar.TabIndex = 1
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblBuscar.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblBuscar.Location = New Point(10, 8)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New Size(98, 15)
        lblBuscar.TabIndex = 0
        lblBuscar.Text = "Buscar Producto"
        ' 
        ' pnlTotalUnidadesCard
        ' 
        pnlTotalUnidadesCard.BackColor = Color.White
        pnlTotalUnidadesCard.Controls.Add(lblTotalUnidadesVal)
        pnlTotalUnidadesCard.Controls.Add(lblTotalUnidadesTitle)
        pnlTotalUnidadesCard.Location = New Point(240, 0)
        pnlTotalUnidadesCard.Name = "pnlTotalUnidadesCard"
        pnlTotalUnidadesCard.Padding = New Padding(12)
        pnlTotalUnidadesCard.Size = New Size(220, 70)
        pnlTotalUnidadesCard.TabIndex = 1
        ' 
        ' lblTotalUnidadesVal
        ' 
        lblTotalUnidadesVal.AutoSize = True
        lblTotalUnidadesVal.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTotalUnidadesVal.ForeColor = Color.FromArgb(CByte(255), CByte(201), CByte(40))
        lblTotalUnidadesVal.Location = New Point(12, 28)
        lblTotalUnidadesVal.Name = "lblTotalUnidadesVal"
        lblTotalUnidadesVal.Size = New Size(28, 32)
        lblTotalUnidadesVal.TabIndex = 1
        lblTotalUnidadesVal.Text = "0"
        ' 
        ' lblTotalUnidadesTitle
        ' 
        lblTotalUnidadesTitle.AutoSize = True
        lblTotalUnidadesTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblTotalUnidadesTitle.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblTotalUnidadesTitle.Location = New Point(12, 10)
        lblTotalUnidadesTitle.Name = "lblTotalUnidadesTitle"
        lblTotalUnidadesTitle.Size = New Size(135, 15)
        lblTotalUnidadesTitle.TabIndex = 0
        lblTotalUnidadesTitle.Text = "Unidades en inventario"
        ' 
        ' pnlTotalProductosCard
        ' 
        pnlTotalProductosCard.BackColor = Color.White
        pnlTotalProductosCard.Controls.Add(lblTotalProductosVal)
        pnlTotalProductosCard.Controls.Add(lblTotalProductosTitle)
        pnlTotalProductosCard.Location = New Point(0, 0)
        pnlTotalProductosCard.Name = "pnlTotalProductosCard"
        pnlTotalProductosCard.Padding = New Padding(12)
        pnlTotalProductosCard.Size = New Size(220, 70)
        pnlTotalProductosCard.TabIndex = 0
        ' 
        ' lblTotalProductosVal
        ' 
        lblTotalProductosVal.AutoSize = True
        lblTotalProductosVal.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTotalProductosVal.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        lblTotalProductosVal.Location = New Point(12, 28)
        lblTotalProductosVal.Name = "lblTotalProductosVal"
        lblTotalProductosVal.Size = New Size(28, 32)
        lblTotalProductosVal.TabIndex = 1
        lblTotalProductosVal.Text = "0"
        ' 
        ' lblTotalProductosTitle
        ' 
        lblTotalProductosTitle.AutoSize = True
        lblTotalProductosTitle.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblTotalProductosTitle.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblTotalProductosTitle.Location = New Point(12, 10)
        lblTotalProductosTitle.Name = "lblTotalProductosTitle"
        lblTotalProductosTitle.Size = New Size(110, 15)
        lblTotalProductosTitle.TabIndex = 0
        lblTotalProductosTitle.Text = "Total de productos"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(20, 20)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(994, 60)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9F)
        lblSubHeader.ForeColor = Color.FromArgb(CByte(66), CByte(72), CByte(84))
        lblSubHeader.Location = New Point(2, 32)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(347, 15)
        lblSubHeader.TabIndex = 1
        lblSubHeader.Text = "Administración general, búsqueda y actualización de mercadería"
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(32), CByte(38), CByte(49))
        lblHeaderTitle.Location = New Point(0, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(322, 30)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Gestión General de Inventario"
        ' 
        ' ofdImagen
        ' 
        ofdImagen.Filter = "Archivos de Imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos (*.*)|*.*"
        ofdImagen.Title = "Seleccionar Imagen del Producto"
        ' 
        ' FrmInventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(246), CByte(248))
        ClientSize = New Size(1264, 750)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(1100, 700)
        Name = "FrmInventario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Control de Inventario - Comercio"
        pnlSidebar.ResumeLayout(False)
        pnlInfoMemoria.ResumeLayout(False)
        pnlNavInventario.ResumeLayout(False)
        pnlNavInventario.PerformLayout()
        pnlBrand.ResumeLayout(False)
        pnlBrand.PerformLayout()
        pnlMain.ResumeLayout(False)
        splContent.Panel1.ResumeLayout(False)
        splContent.Panel2.ResumeLayout(False)
        CType(splContent, ComponentModel.ISupportInitialize).EndInit()
        splContent.ResumeLayout(False)
        pnlFormCard.ResumeLayout(False)
        pnlFormContent.ResumeLayout(False)
        pnlFormContent.PerformLayout()
        pnlButtonsGrid.ResumeLayout(False)
        pnlImageSection.ResumeLayout(False)
        pnlImageSection.PerformLayout()
        CType(picProducto, ComponentModel.ISupportInitialize).EndInit()
        pnlCheckboxes.ResumeLayout(False)
        pnlCheckboxes.PerformLayout()
        grpTipo.ResumeLayout(False)
        grpTipo.PerformLayout()
        pnlGridCard.ResumeLayout(False)
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        pnlGridHeader.ResumeLayout(False)
        pnlGridHeader.PerformLayout()
        pnlSummaryContainer.ResumeLayout(False)
        pnlSearch.ResumeLayout(False)
        pnlSearch.PerformLayout()
        pnlTotalUnidadesCard.ResumeLayout(False)
        pnlTotalUnidadesCard.PerformLayout()
        pnlTotalProductosCard.ResumeLayout(False)
        pnlTotalProductosCard.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)

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
    Friend WithEvents btnPortalProveedores As System.Windows.Forms.Button
    Friend WithEvents btnNavProveedores As System.Windows.Forms.Button
    Friend WithEvents btnSimularConsumoInv As System.Windows.Forms.Button
    Friend WithEvents pnlGridCard As System.Windows.Forms.Panel
    Friend WithEvents pnlGridHeader As System.Windows.Forms.Panel
    Friend WithEvents lblGridTitle As System.Windows.Forms.Label
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents ofdImagen As System.Windows.Forms.OpenFileDialog
End Class

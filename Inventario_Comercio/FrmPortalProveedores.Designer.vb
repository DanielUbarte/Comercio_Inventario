<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPortalProveedores
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim dgvCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dgvCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim dgvCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblMembresia = New System.Windows.Forms.Label()
        Me.cmbProveedorActivo = New System.Windows.Forms.ComboBox()
        Me.lblProveedorTag = New System.Windows.Forms.Label()
        Me.lblSubHeader = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.pnlStats = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlCardComercios = New System.Windows.Forms.Panel()
        Me.lblCardComerciosVal = New System.Windows.Forms.Label()
        Me.lblCardComerciosTitle = New System.Windows.Forms.Label()
        Me.pnlCardPendientes = New System.Windows.Forms.Panel()
        Me.lblCardPendientesVal = New System.Windows.Forms.Label()
        Me.lblCardPendientesTitle = New System.Windows.Forms.Label()
        Me.pnlCardEnCamino = New System.Windows.Forms.Panel()
        Me.lblCardEnCaminoVal = New System.Windows.Forms.Label()
        Me.lblCardEnCaminoTitle = New System.Windows.Forms.Label()
        Me.pnlCardAhorro = New System.Windows.Forms.Panel()
        Me.lblCardAhorroVal = New System.Windows.Forms.Label()
        Me.lblCardAhorroTitle = New System.Windows.Forms.Label()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.btnSimularConsumo = New System.Windows.Forms.Button()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.cmbFiltroEstado = New System.Windows.Forms.ComboBox()
        Me.lblFiltroEstado = New System.Windows.Forms.Label()
        Me.cmbFiltroComercio = New System.Windows.Forms.ComboBox()
        Me.lblFiltroComercio = New System.Windows.Forms.Label()
        Me.pnlGrid = New System.Windows.Forms.Panel()
        Me.dgvSolicitudes = New System.Windows.Forms.DataGridView()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.lblTipRuta = New System.Windows.Forms.Label()
        Me.btnEntregarPedido = New System.Windows.Forms.Button()
        Me.btnTomarPedido = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlStats.SuspendLayout()
        Me.pnlCardComercios.SuspendLayout()
        Me.pnlCardPendientes.SuspendLayout()
        Me.pnlCardEnCamino.SuspendLayout()
        Me.pnlCardAhorro.SuspendLayout()
        Me.pnlFilter.SuspendLayout()
        Me.pnlGrid.SuspendLayout()
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.lblMembresia)
        Me.pnlHeader.Controls.Add(Me.cmbProveedorActivo)
        Me.pnlHeader.Controls.Add(Me.lblProveedorTag)
        Me.pnlHeader.Controls.Add(Me.lblSubHeader)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(20, 12, 20, 12)
        Me.pnlHeader.Size = New System.Drawing.Size(1080, 75)
        Me.pnlHeader.TabIndex = 0
        '
        'lblMembresia
        '
        Me.lblMembresia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMembresia.AutoSize = True
        Me.lblMembresia.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblMembresia.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblMembresia.ForeColor = System.Drawing.Color.White
        Me.lblMembresia.Location = New System.Drawing.Point(920, 44)
        Me.lblMembresia.Name = "lblMembresia"
        Me.lblMembresia.Padding = New System.Windows.Forms.Padding(6, 2, 6, 2)
        Me.lblMembresia.Size = New System.Drawing.Size(125, 17)
        Me.lblMembresia.TabIndex = 4
        Me.lblMembresia.Text = "✓ Adherido y Activo"
        '
        'cmbProveedorActivo
        '
        Me.cmbProveedorActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProveedorActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedorActivo.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbProveedorActivo.FormattingEnabled = True
        Me.cmbProveedorActivo.Location = New System.Drawing.Point(820, 14)
        Me.cmbProveedorActivo.Name = "cmbProveedorActivo"
        Me.cmbProveedorActivo.Size = New System.Drawing.Size(240, 25)
        Me.cmbProveedorActivo.TabIndex = 3
        '
        'lblProveedorTag
        '
        Me.lblProveedorTag.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProveedorTag.AutoSize = True
        Me.lblProveedorTag.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblProveedorTag.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblProveedorTag.Location = New System.Drawing.Point(680, 18)
        Me.lblProveedorTag.Name = "lblProveedorTag"
        Me.lblProveedorTag.Size = New System.Drawing.Size(130, 15)
        Me.lblProveedorTag.TabIndex = 2
        Me.lblProveedorTag.Text = "Proveedor en Sesión:"
        '
        'lblSubHeader
        '
        Me.lblSubHeader.AutoSize = True
        Me.lblSubHeader.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.lblSubHeader.Location = New System.Drawing.Point(20, 44)
        Me.lblSubHeader.Name = "lblSubHeader"
        Me.lblSubHeader.Size = New System.Drawing.Size(430, 15)
        Me.lblSubHeader.TabIndex = 1
        Me.lblSubHeader.Text = "Notificaciones automáticas por stock mínimo y optimización de rutas de entrega"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.White
        Me.lblHeaderTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(415, 28)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "Portal de Red Logística de Proveedores"
        '
        'pnlStats
        '
        Me.pnlStats.ColumnCount = 4
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlStats.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.pnlStats.Controls.Add(Me.pnlCardComercios, 0, 0)
        Me.pnlStats.Controls.Add(Me.pnlCardPendientes, 1, 0)
        Me.pnlStats.Controls.Add(Me.pnlCardEnCamino, 2, 0)
        Me.pnlStats.Controls.Add(Me.pnlCardAhorro, 3, 0)
        Me.pnlStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlStats.Location = New System.Drawing.Point(0, 75)
        Me.pnlStats.Name = "pnlStats"
        Me.pnlStats.Padding = New System.Windows.Forms.Padding(12, 8, 12, 8)
        Me.pnlStats.RowCount = 1
        Me.pnlStats.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.pnlStats.Size = New System.Drawing.Size(1080, 95)
        Me.pnlStats.TabIndex = 1
        '
        'pnlCardComercios
        '
        Me.pnlCardComercios.BackColor = System.Drawing.Color.White
        Me.pnlCardComercios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardComercios.Controls.Add(Me.lblCardComerciosVal)
        Me.pnlCardComercios.Controls.Add(Me.lblCardComerciosTitle)
        Me.pnlCardComercios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardComercios.Location = New System.Drawing.Point(15, 11)
        Me.pnlCardComercios.Margin = New System.Windows.Forms.Padding(3, 3, 6, 3)
        Me.pnlCardComercios.Name = "pnlCardComercios"
        Me.pnlCardComercios.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.pnlCardComercios.Size = New System.Drawing.Size(255, 71)
        Me.pnlCardComercios.TabIndex = 0
        '
        'lblCardComerciosVal
        '
        Me.lblCardComerciosVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCardComerciosVal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCardComerciosVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.lblCardComerciosVal.Location = New System.Drawing.Point(12, 28)
        Me.lblCardComerciosVal.Name = "lblCardComerciosVal"
        Me.lblCardComerciosVal.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lblCardComerciosVal.Size = New System.Drawing.Size(229, 31)
        Me.lblCardComerciosVal.TabIndex = 1
        Me.lblCardComerciosVal.Text = "3 Minisúpers"
        Me.lblCardComerciosVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCardComerciosTitle
        '
        Me.lblCardComerciosTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardComerciosTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCardComerciosTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblCardComerciosTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblCardComerciosTitle.Name = "lblCardComerciosTitle"
        Me.lblCardComerciosTitle.Size = New System.Drawing.Size(229, 18)
        Me.lblCardComerciosTitle.TabIndex = 0
        Me.lblCardComerciosTitle.Text = "COMERCIOS ADHERIDOS"
        '
        'pnlCardPendientes
        '
        Me.pnlCardPendientes.BackColor = System.Drawing.Color.White
        Me.pnlCardPendientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardPendientes.Controls.Add(Me.lblCardPendientesVal)
        Me.pnlCardPendientes.Controls.Add(Me.lblCardPendientesTitle)
        Me.pnlCardPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardPendientes.Location = New System.Drawing.Point(279, 11)
        Me.pnlCardPendientes.Margin = New System.Windows.Forms.Padding(3, 3, 6, 3)
        Me.pnlCardPendientes.Name = "pnlCardPendientes"
        Me.pnlCardPendientes.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.pnlCardPendientes.Size = New System.Drawing.Size(255, 71)
        Me.pnlCardPendientes.TabIndex = 1
        '
        'lblCardPendientesVal
        '
        Me.lblCardPendientesVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCardPendientesVal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCardPendientesVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.lblCardPendientesVal.Location = New System.Drawing.Point(12, 28)
        Me.lblCardPendientesVal.Name = "lblCardPendientesVal"
        Me.lblCardPendientesVal.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lblCardPendientesVal.Size = New System.Drawing.Size(229, 31)
        Me.lblCardPendientesVal.TabIndex = 1
        Me.lblCardPendientesVal.Text = "2 Pendientes"
        Me.lblCardPendientesVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCardPendientesTitle
        '
        Me.lblCardPendientesTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardPendientesTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCardPendientesTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblCardPendientesTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblCardPendientesTitle.Name = "lblCardPendientesTitle"
        Me.lblCardPendientesTitle.Size = New System.Drawing.Size(229, 18)
        Me.lblCardPendientesTitle.TabIndex = 0
        Me.lblCardPendientesTitle.Text = "ALERTAS DE STOCK MÍNIMO"
        '
        'pnlCardEnCamino
        '
        Me.pnlCardEnCamino.BackColor = System.Drawing.Color.White
        Me.pnlCardEnCamino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardEnCamino.Controls.Add(Me.lblCardEnCaminoVal)
        Me.pnlCardEnCamino.Controls.Add(Me.lblCardEnCaminoTitle)
        Me.pnlCardEnCamino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardEnCamino.Location = New System.Drawing.Point(543, 11)
        Me.pnlCardEnCamino.Margin = New System.Windows.Forms.Padding(3, 3, 6, 3)
        Me.pnlCardEnCamino.Name = "pnlCardEnCamino"
        Me.pnlCardEnCamino.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.pnlCardEnCamino.Size = New System.Drawing.Size(255, 71)
        Me.pnlCardEnCamino.TabIndex = 2
        '
        'lblCardEnCaminoVal
        '
        Me.lblCardEnCaminoVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCardEnCaminoVal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCardEnCaminoVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCardEnCaminoVal.Location = New System.Drawing.Point(12, 28)
        Me.lblCardEnCaminoVal.Name = "lblCardEnCaminoVal"
        Me.lblCardEnCaminoVal.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lblCardEnCaminoVal.Size = New System.Drawing.Size(229, 31)
        Me.lblCardEnCaminoVal.TabIndex = 1
        Me.lblCardEnCaminoVal.Text = "0 En Ruta"
        Me.lblCardEnCaminoVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCardEnCaminoTitle
        '
        Me.lblCardEnCaminoTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardEnCaminoTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCardEnCaminoTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblCardEnCaminoTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblCardEnCaminoTitle.Name = "lblCardEnCaminoTitle"
        Me.lblCardEnCaminoTitle.Size = New System.Drawing.Size(229, 18)
        Me.lblCardEnCaminoTitle.TabIndex = 0
        Me.lblCardEnCaminoTitle.Text = "PEDIDOS TOMADOS / EN RUTA"
        '
        'pnlCardAhorro
        '
        Me.pnlCardAhorro.BackColor = System.Drawing.Color.White
        Me.pnlCardAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardAhorro.Controls.Add(Me.lblCardAhorroVal)
        Me.pnlCardAhorro.Controls.Add(Me.lblCardAhorroTitle)
        Me.pnlCardAhorro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCardAhorro.Location = New System.Drawing.Point(807, 11)
        Me.pnlCardAhorro.Margin = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.pnlCardAhorro.Name = "pnlCardAhorro"
        Me.pnlCardAhorro.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.pnlCardAhorro.Size = New System.Drawing.Size(258, 71)
        Me.pnlCardAhorro.TabIndex = 3
        '
        'lblCardAhorroVal
        '
        Me.lblCardAhorroVal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCardAhorroVal.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCardAhorroVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblCardAhorroVal.Location = New System.Drawing.Point(12, 28)
        Me.lblCardAhorroVal.Name = "lblCardAhorroVal"
        Me.lblCardAhorroVal.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.lblCardAhorroVal.Size = New System.Drawing.Size(232, 31)
        Me.lblCardAhorroVal.TabIndex = 1
        Me.lblCardAhorroVal.Text = "Ruta Eficiente"
        Me.lblCardAhorroVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCardAhorroTitle
        '
        Me.lblCardAhorroTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCardAhorroTitle.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblCardAhorroTitle.ForeColor = System.Drawing.Color.Gray
        Me.lblCardAhorroTitle.Location = New System.Drawing.Point(12, 10)
        Me.lblCardAhorroTitle.Name = "lblCardAhorroTitle"
        Me.lblCardAhorroTitle.Size = New System.Drawing.Size(232, 18)
        Me.lblCardAhorroTitle.TabIndex = 0
        Me.lblCardAhorroTitle.Text = "AHORRO DE GASOLINA Y RUTAS"
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.White
        Me.pnlFilter.Controls.Add(Me.btnSimularConsumo)
        Me.pnlFilter.Controls.Add(Me.btnRefrescar)
        Me.pnlFilter.Controls.Add(Me.cmbFiltroEstado)
        Me.pnlFilter.Controls.Add(Me.lblFiltroEstado)
        Me.pnlFilter.Controls.Add(Me.cmbFiltroComercio)
        Me.pnlFilter.Controls.Add(Me.lblFiltroComercio)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 155)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.pnlFilter.Size = New System.Drawing.Size(1080, 50)
        Me.pnlFilter.TabIndex = 2
        '
        'btnSimularConsumo
        '
        Me.btnSimularConsumo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimularConsumo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSimularConsumo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSimularConsumo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSimularConsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimularConsumo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnSimularConsumo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.btnSimularConsumo.Location = New System.Drawing.Point(825, 10)
        Me.btnSimularConsumo.Name = "btnSimularConsumo"
        Me.btnSimularConsumo.Size = New System.Drawing.Size(235, 30)
        Me.btnSimularConsumo.TabIndex = 5
        Me.btnSimularConsumo.Text = "Simular Consumo en Chinito RS"
        Me.btnSimularConsumo.UseVisualStyleBackColor = False
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefrescar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRefrescar.Location = New System.Drawing.Point(540, 10)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(120, 30)
        Me.btnRefrescar.TabIndex = 4
        Me.btnRefrescar.Text = "Actualizar Lista"
        Me.btnRefrescar.UseVisualStyleBackColor = False
        '
        'cmbFiltroEstado
        '
        Me.cmbFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbFiltroEstado.FormattingEnabled = True
        Me.cmbFiltroEstado.Location = New System.Drawing.Point(375, 14)
        Me.cmbFiltroEstado.Name = "cmbFiltroEstado"
        Me.cmbFiltroEstado.Size = New System.Drawing.Size(150, 23)
        Me.cmbFiltroEstado.TabIndex = 3
        '
        'lblFiltroEstado
        '
        Me.lblFiltroEstado.AutoSize = True
        Me.lblFiltroEstado.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFiltroEstado.Location = New System.Drawing.Point(325, 17)
        Me.lblFiltroEstado.Name = "lblFiltroEstado"
        Me.lblFiltroEstado.Size = New System.Drawing.Size(45, 15)
        Me.lblFiltroEstado.TabIndex = 2
        Me.lblFiltroEstado.Text = "Estado:"
        '
        'cmbFiltroComercio
        '
        Me.cmbFiltroComercio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFiltroComercio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cmbFiltroComercio.FormattingEnabled = True
        Me.cmbFiltroComercio.Location = New System.Drawing.Point(85, 14)
        Me.cmbFiltroComercio.Name = "cmbFiltroComercio"
        Me.cmbFiltroComercio.Size = New System.Drawing.Size(220, 23)
        Me.cmbFiltroComercio.TabIndex = 1
        '
        'lblFiltroComercio
        '
        Me.lblFiltroComercio.AutoSize = True
        Me.lblFiltroComercio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFiltroComercio.Location = New System.Drawing.Point(20, 17)
        Me.lblFiltroComercio.Name = "lblFiltroComercio"
        Me.lblFiltroComercio.Size = New System.Drawing.Size(62, 15)
        Me.lblFiltroComercio.TabIndex = 0
        Me.lblFiltroComercio.Text = "Comercio:"
        '
        'pnlGrid
        '
        Me.pnlGrid.Controls.Add(Me.dgvSolicitudes)
        Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGrid.Location = New System.Drawing.Point(0, 205)
        Me.pnlGrid.Name = "pnlGrid"
        Me.pnlGrid.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.pnlGrid.Size = New System.Drawing.Size(1080, 360)
        Me.pnlGrid.TabIndex = 3
        '
        'dgvSolicitudes
        '
        Me.dgvSolicitudes.AllowUserToAddRows = False
        Me.dgvSolicitudes.AllowUserToDeleteRows = False
        Me.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSolicitudes.BackgroundColor = System.Drawing.Color.White
        Me.dgvSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None
        dgvCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dgvCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(246, Byte), Integer))
        dgvCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        dgvCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(65, Byte), Integer))
        dgvCellStyle1.Padding = New System.Windows.Forms.Padding(4)
        dgvCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        dgvCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        dgvCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudes.ColumnHeadersDefaultCellStyle = dgvCellStyle1
        Me.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dgvCellStyle2.BackColor = System.Drawing.SystemColors.Window
        dgvCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        dgvCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        dgvCellStyle2.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        dgvCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        dgvCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        dgvCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSolicitudes.DefaultCellStyle = dgvCellStyle2
        Me.dgvSolicitudes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSolicitudes.EnableHeadersVisualStyles = False
        Me.dgvSolicitudes.GridColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.dgvSolicitudes.Location = New System.Drawing.Point(15, 10)
        Me.dgvSolicitudes.MultiSelect = False
        Me.dgvSolicitudes.Name = "dgvSolicitudes"
        Me.dgvSolicitudes.ReadOnly = True
        dgvCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dgvCellStyle3.BackColor = System.Drawing.SystemColors.Control
        dgvCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        dgvCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        dgvCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        dgvCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        dgvCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSolicitudes.RowHeadersDefaultCellStyle = dgvCellStyle3
        Me.dgvSolicitudes.RowHeadersVisible = False
        Me.dgvSolicitudes.RowTemplate.Height = 35
        Me.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSolicitudes.Size = New System.Drawing.Size(1050, 340)
        Me.dgvSolicitudes.TabIndex = 0
        '
        'pnlActions
        '
        Me.pnlActions.BackColor = System.Drawing.Color.White
        Me.pnlActions.Controls.Add(Me.lblTipRuta)
        Me.pnlActions.Controls.Add(Me.btnEntregarPedido)
        Me.pnlActions.Controls.Add(Me.btnTomarPedido)
        Me.pnlActions.Controls.Add(Me.btnCerrar)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlActions.Location = New System.Drawing.Point(0, 565)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Padding = New System.Windows.Forms.Padding(15, 12, 15, 12)
        Me.pnlActions.Size = New System.Drawing.Size(1080, 65)
        Me.pnlActions.TabIndex = 4
        '
        'lblTipRuta
        '
        Me.lblTipRuta.AutoSize = True
        Me.lblTipRuta.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lblTipRuta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTipRuta.Location = New System.Drawing.Point(20, 24)
        Me.lblTipRuta.Name = "lblTipRuta"
        Me.lblTipRuta.Size = New System.Drawing.Size(390, 15)
        Me.lblTipRuta.TabIndex = 3
        Me.lblTipRuta.Text = "Selecciona una orden de la lista para tomarla y salir en ruta hacia el comercio."
        '
        'btnEntregarPedido
        '
        Me.btnEntregarPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEntregarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnEntregarPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEntregarPedido.FlatAppearance.BorderSize = 0
        Me.btnEntregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregarPedido.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEntregarPedido.ForeColor = System.Drawing.Color.White
        Me.btnEntregarPedido.Location = New System.Drawing.Point(680, 14)
        Me.btnEntregarPedido.Name = "btnEntregarPedido"
        Me.btnEntregarPedido.Size = New System.Drawing.Size(240, 36)
        Me.btnEntregarPedido.TabIndex = 2
        Me.btnEntregarPedido.Text = "Confirmar Entrega / Surtir Stock"
        Me.btnEntregarPedido.UseVisualStyleBackColor = False
        '
        'btnTomarPedido
        '
        Me.btnTomarPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTomarPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnTomarPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTomarPedido.FlatAppearance.BorderSize = 0
        Me.btnTomarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTomarPedido.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnTomarPedido.ForeColor = System.Drawing.Color.White
        Me.btnTomarPedido.Location = New System.Drawing.Point(460, 14)
        Me.btnTomarPedido.Name = "btnTomarPedido"
        Me.btnTomarPedido.Size = New System.Drawing.Size(210, 36)
        Me.btnTomarPedido.TabIndex = 1
        Me.btnTomarPedido.Text = "Tomar Orden / Salir en Ruta"
        Me.btnTomarPedido.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrar.Location = New System.Drawing.Point(930, 14)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(130, 36)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "Volver"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'FrmPortalProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 630)
        Me.Controls.Add(Me.pnlGrid)
        Me.Controls.Add(Me.pnlActions)
        Me.Controls.Add(Me.pnlFilter)
        Me.Controls.Add(Me.pnlStats)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinimumSize = New System.Drawing.Size(950, 550)
        Me.Name = "FrmPortalProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Red Logística de Proveedores - Alertas de Reabastecimiento"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlStats.ResumeLayout(False)
        Me.pnlCardComercios.ResumeLayout(False)
        Me.pnlCardPendientes.ResumeLayout(False)
        Me.pnlCardEnCamino.ResumeLayout(False)
        Me.pnlCardAhorro.ResumeLayout(False)
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlFilter.PerformLayout()
        Me.pnlGrid.ResumeLayout(False)
        CType(Me.dgvSolicitudes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActions.ResumeLayout(False)
        Me.pnlActions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents lblProveedorTag As Label
    Friend WithEvents cmbProveedorActivo As ComboBox
    Friend WithEvents lblMembresia As Label
    Friend WithEvents pnlStats As TableLayoutPanel
    Friend WithEvents pnlCardComercios As Panel
    Friend WithEvents lblCardComerciosTitle As Label
    Friend WithEvents lblCardComerciosVal As Label
    Friend WithEvents pnlCardPendientes As Panel
    Friend WithEvents lblCardPendientesTitle As Label
    Friend WithEvents lblCardPendientesVal As Label
    Friend WithEvents pnlCardEnCamino As Panel
    Friend WithEvents lblCardEnCaminoTitle As Label
    Friend WithEvents lblCardEnCaminoVal As Label
    Friend WithEvents pnlCardAhorro As Panel
    Friend WithEvents lblCardAhorroTitle As Label
    Friend WithEvents lblCardAhorroVal As Label
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents lblFiltroComercio As Label
    Friend WithEvents cmbFiltroComercio As ComboBox
    Friend WithEvents lblFiltroEstado As Label
    Friend WithEvents cmbFiltroEstado As ComboBox
    Friend WithEvents btnRefrescar As Button
    Friend WithEvents btnSimularConsumo As Button
    Friend WithEvents pnlGrid As Panel
    Friend WithEvents dgvSolicitudes As DataGridView
    Friend WithEvents pnlActions As Panel
    Friend WithEvents lblTipRuta As Label
    Friend WithEvents btnTomarPedido As Button
    Friend WithEvents btnEntregarPedido As Button
    Friend WithEvents btnCerrar As Button
End Class

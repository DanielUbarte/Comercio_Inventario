<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventarioVisual
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblSubHeader = New System.Windows.Forms.Label()
        Me.lblHeaderTitle = New System.Windows.Forms.Label()
        Me.pnlActions = New System.Windows.Forms.Panel()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.flpContenedorTarjetas = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.pnlActions)
        Me.pnlHeader.Controls.Add(Me.lblSubHeader)
        Me.pnlHeader.Controls.Add(Me.lblHeaderTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Padding = New System.Windows.Forms.Padding(20, 15, 20, 15)
        Me.pnlHeader.Size = New System.Drawing.Size(1040, 75)
        Me.pnlHeader.TabIndex = 0
        '
        'lblSubHeader
        '
        Me.lblSubHeader.AutoSize = True
        Me.lblSubHeader.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblSubHeader.Location = New System.Drawing.Point(20, 43)
        Me.lblSubHeader.Name = "lblSubHeader"
        Me.lblSubHeader.Size = New System.Drawing.Size(325, 15)
        Me.lblSubHeader.TabIndex = 1
        Me.lblSubHeader.Text = "Vista gráfica dinámica de las tarjetas de productos registrados"
        '
        'lblHeaderTitle
        '
        Me.lblHeaderTitle.AutoSize = True
        Me.lblHeaderTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.lblHeaderTitle.Location = New System.Drawing.Point(18, 12)
        Me.lblHeaderTitle.Name = "lblHeaderTitle"
        Me.lblHeaderTitle.Size = New System.Drawing.Size(262, 30)
        Me.lblHeaderTitle.TabIndex = 0
        Me.lblHeaderTitle.Text = "🖼️ Inventario Visual"
        '
        'pnlActions
        '
        Me.pnlActions.Controls.Add(Me.lblContador)
        Me.pnlActions.Controls.Add(Me.btnRefrescar)
        Me.pnlActions.Controls.Add(Me.btnCerrar)
        Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlActions.Location = New System.Drawing.Point(540, 15)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(480, 45)
        Me.pnlActions.TabIndex = 2
        '
        'lblContador
        '
        Me.lblContador.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblContador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblContador.Location = New System.Drawing.Point(10, 12)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(200, 22)
        Me.lblContador.TabIndex = 2
        Me.lblContador.Text = "0 Tarjetas"
        Me.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefrescar
        '
        Me.btnRefrescar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(163, Byte), Integer))
        Me.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefrescar.FlatAppearance.BorderSize = 0
        Me.btnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescar.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRefrescar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnRefrescar.Location = New System.Drawing.Point(230, 8)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(120, 30)
        Me.btnRefrescar.TabIndex = 1
        Me.btnRefrescar.Text = "🔄 Actualizar"
        Me.btnRefrescar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(360, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 30)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.Text = "✖ Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'flpContenedorTarjetas
        '
        Me.flpContenedorTarjetas.AutoScroll = True
        Me.flpContenedorTarjetas.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.flpContenedorTarjetas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpContenedorTarjetas.Location = New System.Drawing.Point(0, 75)
        Me.flpContenedorTarjetas.Name = "flpContenedorTarjetas"
        Me.flpContenedorTarjetas.Padding = New System.Windows.Forms.Padding(20)
        Me.flpContenedorTarjetas.Size = New System.Drawing.Size(1040, 605)
        Me.flpContenedorTarjetas.TabIndex = 1
        '
        'FrmInventarioVisual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1040, 680)
        Me.Controls.Add(Me.flpContenedorTarjetas)
        Me.Controls.Add(Me.pnlHeader)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "FrmInventarioVisual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario Visual - Tarjetas de Productos"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlActions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblSubHeader As System.Windows.Forms.Label
    Friend WithEvents lblHeaderTitle As System.Windows.Forms.Label
    Friend WithEvents pnlActions As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents lblContador As System.Windows.Forms.Label
    Friend WithEvents flpContenedorTarjetas As System.Windows.Forms.FlowLayoutPanel
End Class

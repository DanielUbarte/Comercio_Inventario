Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class FrmInventarioVisual

    Private Sub FrmInventarioVisual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTarjetasVisuales()
    End Sub

    ''' <summary>
    ''' Carga dinámicamente las tarjetas visuales de los productos registrados.
    ''' </summary>
    Public Sub CargarTarjetasVisuales()
        flpContenedorTarjetas.SuspendLayout()
        flpContenedorTarjetas.Controls.Clear()

        Dim listaProductos As List(Of Producto) = ProductoManager.ObtenerTodos()
        lblContador.Text = $"{listaProductos.Count} Productos"

        If listaProductos.Count = 0 Then
            Dim lblVacio As New Label With {
                .Text = "No hay productos registrados en el inventario.",
                .AutoSize = False,
                .Size = New Size(500, 60),
                .Font = New Font("Segoe UI", 12, FontStyle.Bold),
                .ForeColor = Color.FromArgb(66, 72, 84),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Margin = New Padding(50)
            }
            flpContenedorTarjetas.Controls.Add(lblVacio)
            flpContenedorTarjetas.ResumeLayout()
            Return
        End If

        For Each prod As Producto In listaProductos
            Dim card As Panel = CrearTarjetaProducto(prod)
            flpContenedorTarjetas.Controls.Add(card)
        Next

        flpContenedorTarjetas.ResumeLayout()
    End Sub

    ''' <summary>
    ''' Construye una tarjeta visual dinámica para un objeto Producto.
    ''' </summary>
    Private Function CrearTarjetaProducto(prod As Producto) As Panel
        Dim pnlCard As New Panel With {
            .Size = New Size(240, 360),
            .Margin = New Padding(12),
            .BackColor = Color.White,
            .Padding = New Padding(10)
        }

        ' Dibujar un borde elegante alrededor de la tarjeta
        AddHandler pnlCard.Paint, Sub(s As Object, e As PaintEventArgs)
                                      Using pen As New Pen(Color.FromArgb(213, 218, 225), 1)
                                          e.Graphics.DrawRectangle(pen, 0, 0, pnlCard.Width - 1, pnlCard.Height - 1)
                                      End Using
                                  End Sub

        ' 1. Imagen del producto (PictureBox)
        Dim pic As New PictureBox With {
            .Location = New Point(10, 10),
            .Size = New Size(220, 120),
            .SizeMode = PictureBoxSizeMode.Zoom,
            .BackColor = Color.FromArgb(245, 246, 248)
        }

        If prod.Imagen IsNot Nothing Then
            pic.Image = prod.Imagen
        Else
            ' Crear un gráfico por defecto con iniciales
            pic.Image = GenerarImagenVacia(prod.Nombre)
        End If
        pnlCard.Controls.Add(pic)

        ' 2. Label Nombre del producto
        Dim lblNombre As New Label With {
            .Text = prod.Nombre,
            .Location = New Point(10, 138),
            .Size = New Size(220, 42),
            .Font = New Font("Segoe UI", 10.5F, FontStyle.Bold),
            .ForeColor = Color.FromArgb(32, 38, 49),
            .AutoEllipsis = True
        }
        pnlCard.Controls.Add(lblNombre)

        ' 3. Label Código
        Dim lblCodigo As New Label With {
            .Text = $"Código: {prod.Codigo}",
            .Location = New Point(10, 182),
            .Size = New Size(220, 18),
            .Font = New Font("Segoe UI", 8.5F, FontStyle.Regular),
            .ForeColor = Color.FromArgb(66, 72, 84)
        }
        pnlCard.Controls.Add(lblCodigo)

        ' 4. Label Cantidad
        Dim lblCantidad As New Label With {
            .Text = $"Cantidad: {prod.Cantidad} unidades",
            .Location = New Point(10, 202),
            .Size = New Size(220, 18),
            .Font = New Font("Segoe UI", 8.5F, FontStyle.Bold),
            .ForeColor = Color.FromArgb(32, 38, 49)
        }
        pnlCard.Controls.Add(lblCantidad)

        ' 5. Label Categoría
        Dim lblCategoria As New Label With {
            .Text = $"Categoría: {prod.Categoria}",
            .Location = New Point(10, 222),
            .Size = New Size(220, 18),
            .Font = New Font("Segoe UI", 8.5F, FontStyle.Regular),
            .ForeColor = Color.FromArgb(66, 72, 84)
        }
        pnlCard.Controls.Add(lblCategoria)

        ' 6. Label Tipo
        Dim lblTipo As New Label With {
            .Text = $"Tipo: {prod.TipoProducto}",
            .Location = New Point(10, 242),
            .Size = New Size(220, 18),
            .Font = New Font("Segoe UI", 8.5F, FontStyle.Regular),
            .ForeColor = Color.FromArgb(66, 72, 84)
        }
        pnlCard.Controls.Add(lblTipo)

        ' 7. Contenedor de Badges/Estados (Promoción / Reposición / Disponible)
        Dim pnlBadges As New FlowLayoutPanel With {
            .Location = New Point(10, 268),
            .Size = New Size(220, 80),
            .AutoScroll = False,
            .WrapContents = True
        }

        ' Badge de Promoción
        If prod.EnPromocion Then
            Dim lblPromo As New Label With {
                .Text = "🏷️ EN PROMOCIÓN",
                .AutoSize = True,
                .Font = New Font("Segoe UI", 8.0F, FontStyle.Bold),
                .BackColor = Color.FromArgb(255, 233, 163), ' #FFE9A3
                .ForeColor = Color.FromArgb(32, 38, 49),
                .Padding = New Padding(6, 4, 6, 4),
                .Margin = New Padding(0, 0, 4, 4)
            }
            pnlBadges.Controls.Add(lblPromo)
        End If

        ' Badge de Reposición
        If prod.RequiereReposicion Then
            Dim lblRepo As New Label With {
                .Text = "⚠️ REQUIERE REPOSICIÓN",
                .AutoSize = True,
                .Font = New Font("Segoe UI", 8.0F, FontStyle.Bold),
                .BackColor = Color.FromArgb(254, 226, 226), ' Rojo suave
                .ForeColor = Color.FromArgb(232, 93, 93), ' #E85D5D
                .Padding = New Padding(6, 4, 6, 4),
                .Margin = New Padding(0, 0, 4, 4)
            }
            pnlBadges.Controls.Add(lblRepo)
        End If

        ' Badge Disponible (si no está en promo ni requiere reposición)
        If Not prod.EnPromocion AndAlso Not prod.RequiereReposicion Then
            Dim lblDisp As New Label With {
                .Text = "✔ DISPONIBLE",
                .AutoSize = True,
                .Font = New Font("Segoe UI", 8.0F, FontStyle.Bold),
                .BackColor = Color.FromArgb(245, 246, 248),
                .ForeColor = Color.FromArgb(66, 72, 84),
                .Padding = New Padding(6, 4, 6, 4),
                .Margin = New Padding(0, 0, 4, 4)
            }
            pnlBadges.Controls.Add(lblDisp)
        End If

        pnlCard.Controls.Add(pnlBadges)

        Return pnlCard
    End Function

    ''' <summary>
    ''' Genera una imagen limpia para los productos que no tengan imagen especificada.
    ''' </summary>
    Private Function GenerarImagenVacia(nombre As String) As Image
        Dim bmp As New Bitmap(220, 120)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(Color.FromArgb(245, 246, 248))
            Using pen As New Pen(Color.FromArgb(213, 218, 225), 1)
                g.DrawRectangle(pen, 5, 5, 210, 110)
            End Using

            Dim texto As String = If(String.IsNullOrWhiteSpace(nombre), "Sin Imagen", nombre)
            Using font As New Font("Segoe UI", 10, FontStyle.Bold)
                Using brush As New SolidBrush(Color.FromArgb(66, 72, 84))
                    Dim sf As New StringFormat With {
                        .Alignment = StringAlignment.Center,
                        .LineAlignment = StringAlignment.Center
                    }
                    g.DrawString(texto, font, brush, New RectangleF(5, 5, 210, 110), sf)
                End Using
            End Using
        End Using
        Return bmp
    End Function

    Private Sub btnRefrescar_Click(sender As Object, e As EventArgs) Handles btnRefrescar.Click
        CargarTarjetasVisuales()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

End Class

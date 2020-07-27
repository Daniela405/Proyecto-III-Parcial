<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ventas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.txtnumeroVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbempleado = New System.Windows.Forms.ComboBox()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnCobrar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cmbpagos = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtdescuento = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtcantidad2 = New System.Windows.Forms.TextBox()
        Me.txtprecio2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtcantidad1 = New System.Windows.Forms.TextBox()
        Me.txtprecio1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbservicio = New System.Windows.Forms.ComboBox()
        Me.cmbproducto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.tmensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox1.Controls.Add(Me.txtnumeroVenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbempleado)
        Me.GroupBox1.Controls.Add(Me.cmbcliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(73, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(911, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(496, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Fecha"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(630, 39)
        Me.MaskedTextBox1.Mask = "00/00/0000"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(121, 26)
        Me.MaskedTextBox1.TabIndex = 14
        Me.MaskedTextBox1.ValidatingType = GetType(Date)
        '
        'txtnumeroVenta
        '
        Me.txtnumeroVenta.Location = New System.Drawing.Point(192, 41)
        Me.txtnumeroVenta.Name = "txtnumeroVenta"
        Me.txtnumeroVenta.Size = New System.Drawing.Size(121, 26)
        Me.txtnumeroVenta.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(34, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 24)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "No. de Venta"
        '
        'cmbempleado
        '
        Me.cmbempleado.FormattingEnabled = True
        Me.cmbempleado.Location = New System.Drawing.Point(630, 86)
        Me.cmbempleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbempleado.Name = "cmbempleado"
        Me.cmbempleado.Size = New System.Drawing.Size(121, 28)
        Me.cmbempleado.TabIndex = 11
        '
        'cmbcliente
        '
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(192, 90)
        Me.cmbcliente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(121, 28)
        Me.cmbcliente.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(496, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(34, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(29, 525)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(989, 192)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Controls.Add(Me.btnCobrar)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(909, 247)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(271, 154)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Location = New System.Drawing.Point(135, 81)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 48)
        Me.btnNuevo.TabIndex = 31
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnCobrar
        '
        Me.btnCobrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCobrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCobrar.BackgroundImage = CType(resources.GetObject("btnCobrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCobrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCobrar.FlatAppearance.BorderSize = 0
        Me.btnCobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnCobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCobrar.Location = New System.Drawing.Point(27, 24)
        Me.btnCobrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(112, 48)
        Me.btnCobrar.TabIndex = 30
        Me.btnCobrar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox5.Controls.Add(Me.cmbpagos)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.txttotal)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtdescuento)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtcantidad2)
        Me.GroupBox5.Controls.Add(Me.txtprecio2)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.txtcantidad1)
        Me.GroupBox5.Controls.Add(Me.txtprecio1)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.cmbservicio)
        Me.GroupBox5.Controls.Add(Me.cmbproducto)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox5.Location = New System.Drawing.Point(73, 177)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(721, 344)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ventas"
        '
        'cmbpagos
        '
        Me.cmbpagos.FormattingEnabled = True
        Me.cmbpagos.Items.AddRange(New Object() {"Tarjeta", "Efectivo"})
        Me.cmbpagos.Location = New System.Drawing.Point(353, 178)
        Me.cmbpagos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbpagos.Name = "cmbpagos"
        Me.cmbpagos.Size = New System.Drawing.Size(121, 28)
        Me.cmbpagos.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(188, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 24)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Forma de Pago"
        '
        'txttotal
        '
        Me.txttotal.Enabled = False
        Me.txttotal.Location = New System.Drawing.Point(353, 269)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(121, 26)
        Me.txttotal.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(188, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 24)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Total"
        '
        'txtdescuento
        '
        Me.txtdescuento.Enabled = False
        Me.txtdescuento.Location = New System.Drawing.Point(353, 224)
        Me.txtdescuento.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(121, 26)
        Me.txtdescuento.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(188, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(101, 24)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Descuento"
        '
        'txtcantidad2
        '
        Me.txtcantidad2.Location = New System.Drawing.Point(602, 90)
        Me.txtcantidad2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcantidad2.Name = "txtcantidad2"
        Me.txtcantidad2.Size = New System.Drawing.Size(100, 26)
        Me.txtcantidad2.TabIndex = 19
        '
        'txtprecio2
        '
        Me.txtprecio2.Enabled = False
        Me.txtprecio2.Location = New System.Drawing.Point(375, 90)
        Me.txtprecio2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprecio2.Name = "txtprecio2"
        Me.txtprecio2.Size = New System.Drawing.Size(100, 26)
        Me.txtprecio2.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(496, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 24)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(304, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 24)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Precio"
        '
        'txtcantidad1
        '
        Me.txtcantidad1.Location = New System.Drawing.Point(602, 44)
        Me.txtcantidad1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcantidad1.Name = "txtcantidad1"
        Me.txtcantidad1.Size = New System.Drawing.Size(100, 26)
        Me.txtcantidad1.TabIndex = 15
        '
        'txtprecio1
        '
        Me.txtprecio1.Enabled = False
        Me.txtprecio1.Location = New System.Drawing.Point(375, 42)
        Me.txtprecio1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtprecio1.Name = "txtprecio1"
        Me.txtprecio1.Size = New System.Drawing.Size(100, 26)
        Me.txtprecio1.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(496, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 24)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(304, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 24)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Precio"
        '
        'cmbservicio
        '
        Me.cmbservicio.FormattingEnabled = True
        Me.cmbservicio.Location = New System.Drawing.Point(159, 88)
        Me.cmbservicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbservicio.Name = "cmbservicio"
        Me.cmbservicio.Size = New System.Drawing.Size(121, 28)
        Me.cmbservicio.TabIndex = 11
        '
        'cmbproducto
        '
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Location = New System.Drawing.Point(159, 42)
        Me.cmbproducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(121, 28)
        Me.cmbproducto.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Servicio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 24)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Producto"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1087, 690)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(71, 69)
        Me.btnCerrar.TabIndex = 29
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1270, 775)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ventas"
        Me.Text = "ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbempleado As ComboBox
    Friend WithEvents cmbcliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtcantidad2 As TextBox
    Friend WithEvents txtprecio2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtcantidad1 As TextBox
    Friend WithEvents txtprecio1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbservicio As ComboBox
    Friend WithEvents cmbproducto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbpagos As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtdescuento As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnCobrar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents tmensaje As ToolTip
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents txtnumeroVenta As TextBox
    Friend WithEvents Label3 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class detalleVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(detalleVentas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnumerodoc = New System.Windows.Forms.TextBox()
        Me.txtnombrecliente = New System.Windows.Forms.TextBox()
        Me.txtdocumento = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.txtcantllevar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsctok = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtnombreproducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtlookservice = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.PanelDatosVenta = New System.Windows.Forms.Panel()
        Me.panelServicios = New System.Windows.Forms.Panel()
        Me.panelProductos = New System.Windows.Forms.Panel()
        Me.panelDetalle = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAggServicios = New System.Windows.Forms.Button()
        Me.btnAggProductos = New System.Windows.Forms.Button()
        Me.btnDatosVenta = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatosVenta.SuspendLayout()
        Me.panelServicios.SuspendLayout()
        Me.panelProductos.SuspendLayout()
        Me.panelDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnumerodoc)
        Me.GroupBox1.Controls.Add(Me.txtnombrecliente)
        Me.GroupBox1.Controls.Add(Me.txtdocumento)
        Me.GroupBox1.Controls.Add(Me.txt1)
        Me.GroupBox1.Controls.Add(Me.txtidcliente)
        Me.GroupBox1.Controls.Add(Me.txtidventa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 227)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la venta"
        '
        'txtnumerodoc
        '
        Me.txtnumerodoc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnumerodoc.Enabled = False
        Me.txtnumerodoc.Location = New System.Drawing.Point(111, 164)
        Me.txtnumerodoc.Name = "txtnumerodoc"
        Me.txtnumerodoc.ReadOnly = True
        Me.txtnumerodoc.Size = New System.Drawing.Size(100, 13)
        Me.txtnumerodoc.TabIndex = 10
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnombrecliente.Enabled = False
        Me.txtnombrecliente.Location = New System.Drawing.Point(153, 61)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.ReadOnly = True
        Me.txtnombrecliente.Size = New System.Drawing.Size(84, 13)
        Me.txtnombrecliente.TabIndex = 9
        '
        'txtdocumento
        '
        Me.txtdocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdocumento.Enabled = False
        Me.txtdocumento.Location = New System.Drawing.Point(111, 128)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.ReadOnly = True
        Me.txtdocumento.Size = New System.Drawing.Size(100, 13)
        Me.txtdocumento.TabIndex = 8
        '
        'txt1
        '
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt1.Enabled = False
        Me.txt1.Location = New System.Drawing.Point(111, 99)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(100, 13)
        Me.txt1.TabIndex = 7
        '
        'txtidcliente
        '
        Me.txtidcliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidcliente.Enabled = False
        Me.txtidcliente.Location = New System.Drawing.Point(111, 61)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.ReadOnly = True
        Me.txtidcliente.Size = New System.Drawing.Size(36, 13)
        Me.txtidcliente.TabIndex = 6
        '
        'txtidventa
        '
        Me.txtidventa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtidventa.Enabled = False
        Me.txtidventa.Location = New System.Drawing.Point(111, 27)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.ReadOnly = True
        Me.txtidventa.Size = New System.Drawing.Size(100, 13)
        Me.txtidventa.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Numero de factura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tipo de documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Idventa"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(441, 227)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccion De productos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(29, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Buscar por Id/nombre "
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(142, 30)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(106, 20)
        Me.txtbuscar.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(406, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(41, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Sub total"
        '
        'txttotal
        '
        Me.txttotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txttotal.Location = New System.Drawing.Point(101, 203)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(104, 20)
        Me.txttotal.TabIndex = 18
        '
        'txtcantllevar
        '
        Me.txtcantllevar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtcantllevar.Location = New System.Drawing.Point(100, 103)
        Me.txtcantllevar.Name = "txtcantllevar"
        Me.txtcantllevar.Size = New System.Drawing.Size(105, 20)
        Me.txtcantllevar.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 26)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Cantidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a Llevar"
        '
        'txtsctok
        '
        Me.txtsctok.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtsctok.Enabled = False
        Me.txtsctok.Location = New System.Drawing.Point(101, 171)
        Me.txtsctok.Name = "txtsctok"
        Me.txtsctok.Size = New System.Drawing.Size(104, 20)
        Me.txtsctok.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Stock"
        '
        'txtprecio
        '
        Me.txtprecio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtprecio.Enabled = False
        Me.txtprecio.Location = New System.Drawing.Point(101, 135)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(104, 20)
        Me.txtprecio.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Precio"
        '
        'txtnombreproducto
        '
        Me.txtnombreproducto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtnombreproducto.Enabled = False
        Me.txtnombreproducto.Location = New System.Drawing.Point(100, 69)
        Me.txtnombreproducto.Name = "txtnombreproducto"
        Me.txtnombreproducto.Size = New System.Drawing.Size(133, 20)
        Me.txtnombreproducto.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre S/p"
        '
        'txtidproducto
        '
        Me.txtidproducto.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtidproducto.Enabled = False
        Me.txtidproducto.Location = New System.Drawing.Point(100, 35)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(133, 20)
        Me.txtidproducto.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Id S/p"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(377, 40)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(414, 164)
        Me.DataGridView2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtlookservice)
        Me.GroupBox3.Controls.Add(Me.DataGridView3)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 218)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccion de Servicios"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(20, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Buscar nombre servicios "
        '
        'txtlookservice
        '
        Me.txtlookservice.Location = New System.Drawing.Point(151, 18)
        Me.txtlookservice.Name = "txtlookservice"
        Me.txtlookservice.Size = New System.Drawing.Size(100, 20)
        Me.txtlookservice.TabIndex = 2
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(19, 49)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(402, 150)
        Me.DataGridView3.TabIndex = 0
        '
        'PanelDatosVenta
        '
        Me.PanelDatosVenta.Controls.Add(Me.GroupBox1)
        Me.PanelDatosVenta.Location = New System.Drawing.Point(300, 4)
        Me.PanelDatosVenta.Name = "PanelDatosVenta"
        Me.PanelDatosVenta.Size = New System.Drawing.Size(344, 250)
        Me.PanelDatosVenta.TabIndex = 4
        Me.PanelDatosVenta.Visible = False
        '
        'panelServicios
        '
        Me.panelServicios.Controls.Add(Me.GroupBox3)
        Me.panelServicios.Location = New System.Drawing.Point(236, 4)
        Me.panelServicios.Name = "panelServicios"
        Me.panelServicios.Size = New System.Drawing.Size(465, 266)
        Me.panelServicios.TabIndex = 5
        Me.panelServicios.Visible = False
        '
        'panelProductos
        '
        Me.panelProductos.Controls.Add(Me.GroupBox2)
        Me.panelProductos.Location = New System.Drawing.Point(245, 1)
        Me.panelProductos.Name = "panelProductos"
        Me.panelProductos.Size = New System.Drawing.Size(465, 250)
        Me.panelProductos.TabIndex = 6
        Me.panelProductos.Visible = False
        '
        'panelDetalle
        '
        Me.panelDetalle.Controls.Add(Me.txtnombreproducto)
        Me.panelDetalle.Controls.Add(Me.Label11)
        Me.panelDetalle.Controls.Add(Me.Label8)
        Me.panelDetalle.Controls.Add(Me.txtprecio)
        Me.panelDetalle.Controls.Add(Me.txttotal)
        Me.panelDetalle.Controls.Add(Me.Label7)
        Me.panelDetalle.Controls.Add(Me.Button3)
        Me.panelDetalle.Controls.Add(Me.Label9)
        Me.panelDetalle.Controls.Add(Me.DataGridView2)
        Me.panelDetalle.Controls.Add(Me.txtidproducto)
        Me.panelDetalle.Controls.Add(Me.txtsctok)
        Me.panelDetalle.Controls.Add(Me.Button1)
        Me.panelDetalle.Controls.Add(Me.Label6)
        Me.panelDetalle.Controls.Add(Me.Label10)
        Me.panelDetalle.Controls.Add(Me.txtcantllevar)
        Me.panelDetalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelDetalle.Location = New System.Drawing.Point(0, 245)
        Me.panelDetalle.Name = "panelDetalle"
        Me.panelDetalle.Size = New System.Drawing.Size(834, 265)
        Me.panelDetalle.TabIndex = 22
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(262, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 50)
        Me.Button3.TabIndex = 20
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(266, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 50)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAggServicios
        '
        Me.btnAggServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAggServicios.Image = CType(resources.GetObject("btnAggServicios.Image"), System.Drawing.Image)
        Me.btnAggServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAggServicios.Location = New System.Drawing.Point(43, 163)
        Me.btnAggServicios.Name = "btnAggServicios"
        Me.btnAggServicios.Size = New System.Drawing.Size(134, 39)
        Me.btnAggServicios.TabIndex = 23
        Me.btnAggServicios.Text = "Servicios"
        Me.btnAggServicios.UseVisualStyleBackColor = True
        '
        'btnAggProductos
        '
        Me.btnAggProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAggProductos.Image = CType(resources.GetObject("btnAggProductos.Image"), System.Drawing.Image)
        Me.btnAggProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAggProductos.Location = New System.Drawing.Point(43, 99)
        Me.btnAggProductos.Name = "btnAggProductos"
        Me.btnAggProductos.Size = New System.Drawing.Size(135, 39)
        Me.btnAggProductos.TabIndex = 24
        Me.btnAggProductos.Text = "Productos"
        Me.btnAggProductos.UseVisualStyleBackColor = True
        '
        'btnDatosVenta
        '
        Me.btnDatosVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatosVenta.Image = CType(resources.GetObject("btnDatosVenta.Image"), System.Drawing.Image)
        Me.btnDatosVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDatosVenta.Location = New System.Drawing.Point(37, 38)
        Me.btnDatosVenta.Name = "btnDatosVenta"
        Me.btnDatosVenta.Size = New System.Drawing.Size(154, 39)
        Me.btnDatosVenta.TabIndex = 25
        Me.btnDatosVenta.Text = "Informacion de la Venta"
        Me.btnDatosVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDatosVenta.UseVisualStyleBackColor = True
        '
        'detalleVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(834, 510)
        Me.Controls.Add(Me.btnDatosVenta)
        Me.Controls.Add(Me.panelServicios)
        Me.Controls.Add(Me.panelProductos)
        Me.Controls.Add(Me.PanelDatosVenta)
        Me.Controls.Add(Me.btnAggProductos)
        Me.Controls.Add(Me.btnAggServicios)
        Me.Controls.Add(Me.panelDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "detalleVentas"
        Me.Text = "detalleVentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatosVenta.ResumeLayout(False)
        Me.panelServicios.ResumeLayout(False)
        Me.panelProductos.ResumeLayout(False)
        Me.panelDetalle.ResumeLayout(False)
        Me.panelDetalle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtnumerodoc As TextBox
    Friend WithEvents txtnombrecliente As TextBox
    Friend WithEvents txtdocumento As TextBox
    Friend WithEvents txt1 As TextBox
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtcantllevar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtsctok As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnombreproducto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txttotal As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents txtlookservice As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PanelDatosVenta As Panel
    Friend WithEvents panelServicios As Panel
    Friend WithEvents panelProductos As Panel
    Friend WithEvents panelDetalle As Panel
    Friend WithEvents btnAggServicios As Button
    Friend WithEvents btnAggProductos As Button
    Friend WithEvents btnDatosVenta As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
End Class

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
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.supedido = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.txtlookservice = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.supedido.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(286, 227)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la venta"
        '
        'txtnumerodoc
        '
        Me.txtnumerodoc.Enabled = False
        Me.txtnumerodoc.Location = New System.Drawing.Point(111, 164)
        Me.txtnumerodoc.Name = "txtnumerodoc"
        Me.txtnumerodoc.ReadOnly = True
        Me.txtnumerodoc.Size = New System.Drawing.Size(100, 20)
        Me.txtnumerodoc.TabIndex = 10
        '
        'txtnombrecliente
        '
        Me.txtnombrecliente.Enabled = False
        Me.txtnombrecliente.Location = New System.Drawing.Point(153, 61)
        Me.txtnombrecliente.Name = "txtnombrecliente"
        Me.txtnombrecliente.ReadOnly = True
        Me.txtnombrecliente.Size = New System.Drawing.Size(84, 20)
        Me.txtnombrecliente.TabIndex = 9
        '
        'txtdocumento
        '
        Me.txtdocumento.Enabled = False
        Me.txtdocumento.Location = New System.Drawing.Point(111, 128)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.ReadOnly = True
        Me.txtdocumento.Size = New System.Drawing.Size(100, 20)
        Me.txtdocumento.TabIndex = 8
        '
        'txt1
        '
        Me.txt1.Enabled = False
        Me.txt1.Location = New System.Drawing.Point(111, 99)
        Me.txt1.Name = "txt1"
        Me.txt1.ReadOnly = True
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 7
        '
        'txtidcliente
        '
        Me.txtidcliente.Enabled = False
        Me.txtidcliente.Location = New System.Drawing.Point(111, 61)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.ReadOnly = True
        Me.txtidcliente.Size = New System.Drawing.Size(36, 20)
        Me.txtidcliente.TabIndex = 6
        '
        'txtidventa
        '
        Me.txtidventa.Enabled = False
        Me.txtidventa.Location = New System.Drawing.Point(111, 27)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.ReadOnly = True
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
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
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(304, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(389, 227)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccion De productos"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(122, 30)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtbuscar.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(371, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'supedido
        '
        Me.supedido.Controls.Add(Me.Label11)
        Me.supedido.Controls.Add(Me.Button3)
        Me.supedido.Controls.Add(Me.Button1)
        Me.supedido.Controls.Add(Me.txttotal)
        Me.supedido.Controls.Add(Me.txtcantllevar)
        Me.supedido.Controls.Add(Me.Label10)
        Me.supedido.Controls.Add(Me.txtsctok)
        Me.supedido.Controls.Add(Me.Label9)
        Me.supedido.Controls.Add(Me.txtprecio)
        Me.supedido.Controls.Add(Me.Label8)
        Me.supedido.Controls.Add(Me.txtnombreproducto)
        Me.supedido.Controls.Add(Me.Label7)
        Me.supedido.Controls.Add(Me.txtidproducto)
        Me.supedido.Controls.Add(Me.Label6)
        Me.supedido.Controls.Add(Me.DataGridView2)
        Me.supedido.Location = New System.Drawing.Point(156, 261)
        Me.supedido.Name = "supedido"
        Me.supedido.Size = New System.Drawing.Size(886, 271)
        Me.supedido.TabIndex = 2
        Me.supedido.TabStop = False
        Me.supedido.Text = "Su pedido"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(632, 243)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Sub total"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(162, 181)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 59)
        Me.Button3.TabIndex = 20
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(39, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 59)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(687, 240)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(84, 20)
        Me.txttotal.TabIndex = 18
        '
        'txtcantllevar
        '
        Me.txtcantllevar.Location = New System.Drawing.Point(120, 142)
        Me.txtcantllevar.Name = "txtcantllevar"
        Me.txtcantllevar.Size = New System.Drawing.Size(84, 20)
        Me.txtcantllevar.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(24, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Cantidad a Llevar"
        '
        'txtsctok
        '
        Me.txtsctok.Enabled = False
        Me.txtsctok.Location = New System.Drawing.Point(180, 97)
        Me.txtsctok.Name = "txtsctok"
        Me.txtsctok.Size = New System.Drawing.Size(84, 20)
        Me.txtsctok.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(139, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Stock"
        '
        'txtprecio
        '
        Me.txtprecio.Enabled = False
        Me.txtprecio.Location = New System.Drawing.Point(49, 97)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(84, 20)
        Me.txtprecio.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Precio"
        '
        'txtnombreproducto
        '
        Me.txtnombreproducto.Enabled = False
        Me.txtnombreproducto.Location = New System.Drawing.Point(158, 55)
        Me.txtnombreproducto.Name = "txtnombreproducto"
        Me.txtnombreproducto.Size = New System.Drawing.Size(133, 20)
        Me.txtnombreproducto.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 58)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nombre S/p"
        '
        'txtidproducto
        '
        Me.txtidproducto.Enabled = False
        Me.txtidproducto.Location = New System.Drawing.Point(49, 55)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(36, 20)
        Me.txtidproducto.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Id S/p"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(338, 58)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(488, 164)
        Me.DataGridView2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtlookservice)
        Me.GroupBox3.Controls.Add(Me.DataGridView3)
        Me.GroupBox3.Location = New System.Drawing.Point(723, 24)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(427, 215)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Seleccion de Servicios"
        '
        'txtlookservice
        '
        Me.txtlookservice.Location = New System.Drawing.Point(93, 23)
        Me.txtlookservice.Name = "txtlookservice"
        Me.txtlookservice.Size = New System.Drawing.Size(100, 20)
        Me.txtlookservice.TabIndex = 2
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(19, 49)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(402, 150)
        Me.DataGridView3.TabIndex = 0
        '
        'detalleVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 544)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.supedido)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "detalleVentas"
        Me.Text = "detalleVentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.supedido.ResumeLayout(False)
        Me.supedido.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents supedido As GroupBox
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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents txtlookservice As TextBox
End Class

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbempleado = New System.Windows.Forms.ComboBox()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnnueva = New System.Windows.Forms.Button()
        Me.btncobrar = New System.Windows.Forms.Button()
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
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbempleado)
        Me.GroupBox1.Controls.Add(Me.cmbcliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'cmbempleado
        '
        Me.cmbempleado.FormattingEnabled = True
        Me.cmbempleado.Items.AddRange(New Object() {"Tarjeta", "Efectivo"})
        Me.cmbempleado.Location = New System.Drawing.Point(220, 88)
        Me.cmbempleado.Name = "cmbempleado"
        Me.cmbempleado.Size = New System.Drawing.Size(121, 28)
        Me.cmbempleado.TabIndex = 11
        '
        'cmbcliente
        '
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Items.AddRange(New Object() {"Tarjeta", "Efectivo"})
        Me.cmbcliente.Location = New System.Drawing.Point(220, 42)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(121, 28)
        Me.cmbcliente.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empleado"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(607, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 408)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 236)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Tabla"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnnueva)
        Me.GroupBox3.Controls.Add(Me.btncobrar)
        Me.GroupBox3.Location = New System.Drawing.Point(201, 221)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 154)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'btnnueva
        '
        Me.btnnueva.Location = New System.Drawing.Point(134, 89)
        Me.btnnueva.Name = "btnnueva"
        Me.btnnueva.Size = New System.Drawing.Size(103, 38)
        Me.btnnueva.TabIndex = 4
        Me.btnnueva.Text = "Nueva"
        Me.btnnueva.UseVisualStyleBackColor = True
        '
        'btncobrar
        '
        Me.btncobrar.Location = New System.Drawing.Point(44, 45)
        Me.btncobrar.Name = "btncobrar"
        Me.btncobrar.Size = New System.Drawing.Size(103, 38)
        Me.btncobrar.TabIndex = 3
        Me.btncobrar.Text = "Cobrar"
        Me.btncobrar.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
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
        Me.GroupBox5.Location = New System.Drawing.Point(513, 23)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(693, 379)
        Me.GroupBox5.TabIndex = 12
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ventas"
        '
        'cmbpagos
        '
        Me.cmbpagos.FormattingEnabled = True
        Me.cmbpagos.Items.AddRange(New Object() {"Tarjeta", "Efectivo"})
        Me.cmbpagos.Location = New System.Drawing.Point(327, 178)
        Me.cmbpagos.Name = "cmbpagos"
        Me.cmbpagos.Size = New System.Drawing.Size(121, 28)
        Me.cmbpagos.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(188, 181)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 20)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Forma de Pago"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(327, 269)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(121, 26)
        Me.txttotal.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(188, 272)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Total"
        '
        'txtdescuento
        '
        Me.txtdescuento.Location = New System.Drawing.Point(327, 224)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(121, 26)
        Me.txtdescuento.TabIndex = 21
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(188, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 20)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Descuento"
        '
        'txtcantidad2
        '
        Me.txtcantidad2.Location = New System.Drawing.Point(558, 94)
        Me.txtcantidad2.Name = "txtcantidad2"
        Me.txtcantidad2.Size = New System.Drawing.Size(100, 26)
        Me.txtcantidad2.TabIndex = 19
        '
        'txtprecio2
        '
        Me.txtprecio2.Enabled = False
        Me.txtprecio2.Location = New System.Drawing.Point(363, 91)
        Me.txtprecio2.Name = "txtprecio2"
        Me.txtprecio2.Size = New System.Drawing.Size(100, 26)
        Me.txtprecio2.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(479, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(304, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 20)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Precio"
        '
        'txtcantidad1
        '
        Me.txtcantidad1.Location = New System.Drawing.Point(558, 53)
        Me.txtcantidad1.Name = "txtcantidad1"
        Me.txtcantidad1.Size = New System.Drawing.Size(100, 26)
        Me.txtcantidad1.TabIndex = 15
        '
        'txtprecio1
        '
        Me.txtprecio1.Enabled = False
        Me.txtprecio1.Location = New System.Drawing.Point(363, 50)
        Me.txtprecio1.Name = "txtprecio1"
        Me.txtprecio1.Size = New System.Drawing.Size(100, 26)
        Me.txtprecio1.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(479, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(304, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Precio"
        '
        'cmbservicio
        '
        Me.cmbservicio.FormattingEnabled = True
        Me.cmbservicio.Items.AddRange(New Object() {"Tarjeta", "Efectivo"})
        Me.cmbservicio.Location = New System.Drawing.Point(159, 88)
        Me.cmbservicio.Name = "cmbservicio"
        Me.cmbservicio.Size = New System.Drawing.Size(121, 28)
        Me.cmbservicio.TabIndex = 11
        '
        'cmbproducto
        '
        Me.cmbproducto.FormattingEnabled = True
        Me.cmbproducto.Items.AddRange(New Object() {"Tarjeta", "Efectivo"})
        Me.cmbproducto.Location = New System.Drawing.Point(159, 42)
        Me.cmbproducto.Name = "cmbproducto"
        Me.cmbproducto.Size = New System.Drawing.Size(121, 28)
        Me.cmbproducto.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Servicio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Producto"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(1028, 613)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(129, 54)
        Me.btnsalir.TabIndex = 14
        Me.btnsalir.Text = "Regresar Menú"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 695)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ventas"
        Me.Text = "ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbempleado As ComboBox
    Friend WithEvents cmbcliente As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnnueva As Button
    Friend WithEvents btncobrar As Button
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
    Friend WithEvents btnsalir As Button
End Class

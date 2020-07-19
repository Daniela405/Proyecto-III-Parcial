<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Dirección = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
<<<<<<< HEAD
        Me.btnsalir = New System.Windows.Forms.Button()
=======
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtcorreo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcontraseña)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.Nombre)
        Me.GroupBox1.Controls.Add(Me.Dirección)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(233, 239)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(151, 95)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(124, 26)
        Me.txtnombre.TabIndex = 1
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(101, 181)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcorreo.Name = "txtcorreo"
<<<<<<< HEAD
        Me.txtcorreo.Size = New System.Drawing.Size(124, 26)
        Me.txtcorreo.TabIndex = 5
=======
        Me.txtcorreo.Size = New System.Drawing.Size(84, 20)
        Me.txtcorreo.TabIndex = 16
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Correo"
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(99, 152)
        Me.txtcontraseña.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcontraseña.Name = "txtcontraseña"
<<<<<<< HEAD
        Me.txtcontraseña.Size = New System.Drawing.Size(124, 26)
        Me.txtcontraseña.TabIndex = 4
=======
        Me.txtcontraseña.Size = New System.Drawing.Size(84, 20)
        Me.txtcontraseña.TabIndex = 12
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Contraseña"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 124)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Usuario"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(99, 124)
        Me.txtusuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtusuario.Name = "txtusuario"
<<<<<<< HEAD
        Me.txtusuario.Size = New System.Drawing.Size(124, 26)
        Me.txtusuario.TabIndex = 3
=======
        Me.txtusuario.Size = New System.Drawing.Size(84, 20)
        Me.txtusuario.TabIndex = 8
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 124)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 7
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(99, 90)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtapellido.Name = "txtapellido"
<<<<<<< HEAD
        Me.txtapellido.Size = New System.Drawing.Size(124, 26)
        Me.txtapellido.TabIndex = 2
=======
        Me.txtapellido.Size = New System.Drawing.Size(84, 20)
        Me.txtapellido.TabIndex = 5
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(25, 62)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 4
        Me.Nombre.Text = "Nombre"
        '
        'Dirección
        '
        Me.Dirección.AutoSize = True
        Me.Dirección.Location = New System.Drawing.Point(25, 92)
        Me.Dirección.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Dirección.Name = "Dirección"
        Me.Dirección.Size = New System.Drawing.Size(44, 13)
        Me.Dirección.TabIndex = 3
        Me.Dirección.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(99, 33)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcodigo.Name = "txtcodigo"
<<<<<<< HEAD
        Me.txtcodigo.Size = New System.Drawing.Size(124, 26)
        Me.txtcodigo.TabIndex = 0
=======
        Me.txtcodigo.Size = New System.Drawing.Size(84, 20)
        Me.txtcodigo.TabIndex = 1
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'btnbuscar
        '
        Me.btnbuscar.Location = New System.Drawing.Point(253, 276)
        Me.btnbuscar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnbuscar.Name = "btnbuscar"
<<<<<<< HEAD
        Me.btnbuscar.Size = New System.Drawing.Size(129, 54)
        Me.btnbuscar.TabIndex = 9
=======
        Me.btnbuscar.Size = New System.Drawing.Size(86, 35)
        Me.btnbuscar.TabIndex = 29
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(190, 331)
        Me.btnlimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnlimpiar.Name = "btnlimpiar"
<<<<<<< HEAD
        Me.btnlimpiar.Size = New System.Drawing.Size(129, 54)
        Me.btnlimpiar.TabIndex = 11
=======
        Me.btnlimpiar.Size = New System.Drawing.Size(86, 35)
        Me.btnlimpiar.TabIndex = 28
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(73, 323)
        Me.btneliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btneliminar.Name = "btneliminar"
<<<<<<< HEAD
        Me.btneliminar.Size = New System.Drawing.Size(129, 54)
        Me.btneliminar.TabIndex = 10
=======
        Me.btneliminar.Size = New System.Drawing.Size(86, 35)
        Me.btneliminar.TabIndex = 27
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnmodificar
        '
        Me.btnmodificar.Location = New System.Drawing.Point(134, 268)
        Me.btnmodificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnmodificar.Name = "btnmodificar"
<<<<<<< HEAD
        Me.btnmodificar.Size = New System.Drawing.Size(129, 54)
        Me.btnmodificar.TabIndex = 8
=======
        Me.btnmodificar.Size = New System.Drawing.Size(86, 35)
        Me.btnmodificar.TabIndex = 26
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(23, 268)
        Me.btnguardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnguardar.Name = "btnguardar"
<<<<<<< HEAD
        Me.btnguardar.Size = New System.Drawing.Size(129, 54)
        Me.btnguardar.TabIndex = 7
=======
        Me.btnguardar.Size = New System.Drawing.Size(86, 35)
        Me.btnguardar.TabIndex = 25
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(295, 63)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(439, 135)
        Me.DataGridView1.TabIndex = 30
        '
<<<<<<< HEAD
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(186, 600)
        Me.btnsalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(129, 54)
        Me.btnsalir.TabIndex = 31
        Me.btnsalir.Text = "Regresar Menú"
        Me.btnsalir.UseVisualStyleBackColor = True
=======
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(99, 59)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(84, 20)
        Me.txtnombre.TabIndex = 17
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        '
        'Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.ClientSize = New System.Drawing.Size(1153, 665)
        Me.Controls.Add(Me.btnsalir)
=======
        Me.ClientSize = New System.Drawing.Size(769, 432)
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnbuscar)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Usuario"
        Me.Text = "Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents Dirección As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnbuscar As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmodificar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents DataGridView1 As DataGridView
<<<<<<< HEAD
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents btnsalir As Button
=======
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents ToolTip As ToolTip
>>>>>>> cf2de11e58576bb44399812d6c2e57c8e0fb9043
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(empleado))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtxtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbsexo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbcargo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dataEmpleado = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gbCodigo = New System.Windows.Forms.GroupBox()
        Me.mBuscarIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnBuscarCodigo = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.gbBuscar = New System.Windows.Forms.GroupBox()
        Me.btnBuscarNombre = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dataEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCodigo.SuspendLayout()
        Me.gbBuscar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.mtxtIdentidad)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbsexo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbcargo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtedad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtapellido)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.txtcodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(36, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(448, 434)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información"
        '
        'mtxtIdentidad
        '
        Me.mtxtIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtxtIdentidad.Location = New System.Drawing.Point(226, 56)
        Me.mtxtIdentidad.Mask = "0000000000000"
        Me.mtxtIdentidad.Name = "mtxtIdentidad"
        Me.mtxtIdentidad.Size = New System.Drawing.Size(176, 24)
        Me.mtxtIdentidad.TabIndex = 47
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label22.Location = New System.Drawing.Point(39, 403)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(63, 21)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(226, 403)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(176, 24)
        Me.txtEstado.TabIndex = 45
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(39, 328)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(60, 21)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "Correo"
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(226, 328)
        Me.txtCorreo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(176, 24)
        Me.txtCorreo.TabIndex = 43
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(39, 289)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 21)
        Me.Label20.TabIndex = 42
        Me.Label20.Text = "Teléfono"
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.Location = New System.Drawing.Point(226, 289)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(176, 24)
        Me.txtTel.TabIndex = 41
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label19.Location = New System.Drawing.Point(39, 171)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(155, 21)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Nombre de usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(226, 171)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(176, 24)
        Me.txtUsuario.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(39, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Identidad"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label15.Location = New System.Drawing.Point(41, 366)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 21)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Cargo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label14.Location = New System.Drawing.Point(39, 250)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 21)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Sexo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(39, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 21)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Edad"
        '
        'cmbsexo
        '
        Me.cmbsexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsexo.FormattingEnabled = True
        Me.cmbsexo.Items.AddRange(New Object() {"Seleccione una opción", "Femenino", "Masculino"})
        Me.cmbsexo.Location = New System.Drawing.Point(226, 247)
        Me.cmbsexo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbsexo.Name = "cmbsexo"
        Me.cmbsexo.Size = New System.Drawing.Size(176, 26)
        Me.cmbsexo.TabIndex = 16
        Me.cmbsexo.Text = "Seleccione una opción"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label13.Location = New System.Drawing.Point(39, 131)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 21)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Apellido"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label12.Location = New System.Drawing.Point(39, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 21)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label11.Location = New System.Drawing.Point(39, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 21)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Código"
        '
        'cmbcargo
        '
        Me.cmbcargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcargo.FormattingEnabled = True
        Me.cmbcargo.Items.AddRange(New Object() {"Seleccione una opción", "Estilista", "Masajista", "Maquillador", "Manicurista"})
        Me.cmbcargo.Location = New System.Drawing.Point(226, 366)
        Me.cmbcargo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbcargo.Name = "cmbcargo"
        Me.cmbcargo.Size = New System.Drawing.Size(176, 26)
        Me.cmbcargo.TabIndex = 15
        Me.cmbcargo.Text = "Seleccione una opción"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 17)
        Me.Label9.TabIndex = 14
        '
        'txtedad
        '
        Me.txtedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedad.Location = New System.Drawing.Point(226, 210)
        Me.txtedad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(69, 24)
        Me.txtedad.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 17)
        Me.Label8.TabIndex = 7
        '
        'txtapellido
        '
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(226, 131)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(176, 24)
        Me.txtapellido.TabIndex = 6
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(226, 92)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(176, 24)
        Me.txtnombre.TabIndex = 5
        '
        'txtcodigo
        '
        Me.txtcodigo.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(226, 24)
        Me.txtcodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcodigo.Multiline = True
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(69, 22)
        Me.txtcodigo.TabIndex = 1
        Me.txtcodigo.Text = " "
        Me.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        '
        'dataEmpleado
        '
        Me.dataEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataEmpleado.Location = New System.Drawing.Point(36, 448)
        Me.dataEmpleado.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dataEmpleado.Name = "dataEmpleado"
        Me.dataEmpleado.RowHeadersWidth = 62
        Me.dataEmpleado.RowTemplate.Height = 28
        Me.dataEmpleado.Size = New System.Drawing.Size(906, 161)
        Me.dataEmpleado.TabIndex = 11
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(552, 284)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(131, 45)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BackgroundImage = CType(resources.GetObject("btnModificar.BackgroundImage"), System.Drawing.Image)
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Location = New System.Drawing.Point(763, 284)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(131, 43)
        Me.btnModificar.TabIndex = 25
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpiar.BackgroundImage = CType(resources.GetObject("btnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(963, 401)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(131, 43)
        Me.btnLimpiar.TabIndex = 27
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackgroundImage = CType(resources.GetObject("btnEliminar.BackgroundImage"), System.Drawing.Image)
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Location = New System.Drawing.Point(963, 471)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(131, 43)
        Me.btnEliminar.TabIndex = 28
        Me.btnEliminar.UseVisualStyleBackColor = True
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
        Me.btnCerrar.Location = New System.Drawing.Point(1031, 557)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(63, 50)
        Me.btnCerrar.TabIndex = 29
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'gbCodigo
        '
        Me.gbCodigo.BackColor = System.Drawing.Color.Black
        Me.gbCodigo.Controls.Add(Me.mBuscarIdentidad)
        Me.gbCodigo.Controls.Add(Me.Label7)
        Me.gbCodigo.Controls.Add(Me.btnBuscarCodigo)
        Me.gbCodigo.Controls.Add(Me.Label16)
        Me.gbCodigo.Controls.Add(Me.Label17)
        Me.gbCodigo.Controls.Add(Me.Label18)
        Me.gbCodigo.ForeColor = System.Drawing.Color.White
        Me.gbCodigo.Location = New System.Drawing.Point(505, 83)
        Me.gbCodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbCodigo.Name = "gbCodigo"
        Me.gbCodigo.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbCodigo.Size = New System.Drawing.Size(294, 153)
        Me.gbCodigo.TabIndex = 37
        Me.gbCodigo.TabStop = False
        Me.gbCodigo.Text = "Buscar"
        Me.gbCodigo.Visible = False
        '
        'mBuscarIdentidad
        '
        Me.mBuscarIdentidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mBuscarIdentidad.Location = New System.Drawing.Point(112, 37)
        Me.mBuscarIdentidad.Mask = "0000000000000"
        Me.mBuscarIdentidad.Name = "mBuscarIdentidad"
        Me.mBuscarIdentidad.Size = New System.Drawing.Size(161, 24)
        Me.mBuscarIdentidad.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(6, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 21)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Identidad"
        '
        'btnBuscarCodigo
        '
        Me.btnBuscarCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarCodigo.BackgroundImage = CType(resources.GetObject("btnBuscarCodigo.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarCodigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCodigo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCodigo.FlatAppearance.BorderSize = 0
        Me.btnBuscarCodigo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet
        Me.btnBuscarCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum
        Me.btnBuscarCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCodigo.Location = New System.Drawing.Point(80, 92)
        Me.btnBuscarCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarCodigo.Name = "btnBuscarCodigo"
        Me.btnBuscarCodigo.Size = New System.Drawing.Size(131, 43)
        Me.btnBuscarCodigo.TabIndex = 38
        Me.btnBuscarCodigo.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(44, 276)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(0, 17)
        Me.Label16.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(33, 158)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 17)
        Me.Label17.TabIndex = 7
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(33, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 17)
        Me.Label18.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(25, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Nombre"
        '
        'txtBuscarNombre
        '
        Me.txtBuscarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarNombre.Location = New System.Drawing.Point(101, 37)
        Me.txtBuscarNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBuscarNombre.Name = "txtBuscarNombre"
        Me.txtBuscarNombre.Size = New System.Drawing.Size(178, 24)
        Me.txtBuscarNombre.TabIndex = 5
        '
        'gbBuscar
        '
        Me.gbBuscar.BackColor = System.Drawing.Color.Black
        Me.gbBuscar.Controls.Add(Me.btnBuscarNombre)
        Me.gbBuscar.Controls.Add(Me.Label6)
        Me.gbBuscar.Controls.Add(Me.Label3)
        Me.gbBuscar.Controls.Add(Me.Label4)
        Me.gbBuscar.Controls.Add(Me.Label5)
        Me.gbBuscar.Controls.Add(Me.txtBuscarNombre)
        Me.gbBuscar.ForeColor = System.Drawing.Color.White
        Me.gbBuscar.Location = New System.Drawing.Point(815, 83)
        Me.gbBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBuscar.Name = "gbBuscar"
        Me.gbBuscar.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbBuscar.Size = New System.Drawing.Size(302, 153)
        Me.gbBuscar.TabIndex = 39
        Me.gbBuscar.TabStop = False
        Me.gbBuscar.Text = "Buscar"
        Me.gbBuscar.Visible = False
        '
        'btnBuscarNombre
        '
        Me.btnBuscarNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscarNombre.BackgroundImage = CType(resources.GetObject("btnBuscarNombre.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarNombre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarNombre.FlatAppearance.BorderSize = 0
        Me.btnBuscarNombre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet
        Me.btnBuscarNombre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum
        Me.btnBuscarNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarNombre.Location = New System.Drawing.Point(86, 92)
        Me.btnBuscarNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarNombre.Name = "btnBuscarNombre"
        Me.btnBuscarNombre.Size = New System.Drawing.Size(131, 43)
        Me.btnBuscarNombre.TabIndex = 38
        Me.btnBuscarNombre.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 17)
        Me.Label4.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 17)
        Me.Label5.TabIndex = 0
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.BackColor = System.Drawing.Color.Transparent
        Me.rbCodigo.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCodigo.Location = New System.Drawing.Point(681, 20)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(230, 24)
        Me.rbCodigo.TabIndex = 40
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Buscar por No. Identidad"
        Me.rbCodigo.UseVisualStyleBackColor = False
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.BackColor = System.Drawing.Color.Transparent
        Me.rbNombre.Font = New System.Drawing.Font("Modern No. 20", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombre.Location = New System.Drawing.Point(681, 47)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(184, 24)
        Me.rbNombre.TabIndex = 41
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Buscar por Nombre"
        Me.rbNombre.UseVisualStyleBackColor = False
        '
        'empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1129, 620)
        Me.Controls.Add(Me.rbNombre)
        Me.Controls.Add(Me.rbCodigo)
        Me.Controls.Add(Me.gbBuscar)
        Me.Controls.Add(Me.gbCodigo)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dataEmpleado)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "empleado"
        Me.Text = "empleado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dataEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCodigo.ResumeLayout(False)
        Me.gbCodigo.PerformLayout()
        Me.gbBuscar.ResumeLayout(False)
        Me.gbBuscar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtedad As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dataEmpleado As DataGridView
    Friend WithEvents cmbsexo As ComboBox
    Friend WithEvents cmbcargo As ComboBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents gbBuscar As GroupBox
    Friend WithEvents btnBuscarNombre As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gbCodigo As GroupBox
    Friend WithEvents btnBuscarCodigo As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBuscarNombre As TextBox
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents rbCodigo As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents mtxtIdentidad As MaskedTextBox
    Friend WithEvents mBuscarIdentidad As MaskedTextBox
End Class

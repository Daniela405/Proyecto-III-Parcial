﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menus))
        Me.panelEncabezado = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.paneelMenu = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnProveedores = New System.Windows.Forms.Button()
        Me.btnServicios = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnClieente = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.panelEncabezado.SuspendLayout()
        Me.paneelMenu.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChildForm.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelEncabezado
        '
        Me.panelEncabezado.BackColor = System.Drawing.Color.Orchid
        Me.panelEncabezado.Controls.Add(Me.btnMinimizar)
        Me.panelEncabezado.Controls.Add(Me.btnSalir)
        Me.panelEncabezado.Controls.Add(Me.panelMenu)
        Me.panelEncabezado.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelEncabezado.Location = New System.Drawing.Point(0, 0)
        Me.panelEncabezado.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.panelEncabezado.Name = "panelEncabezado"
        Me.panelEncabezado.Size = New System.Drawing.Size(1034, 48)
        Me.panelEncabezado.TabIndex = 1
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(930, -1)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.btnMinimizar.TabIndex = 5
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(984, -1)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(50, 50)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.Location = New System.Drawing.Point(2, 40)
        Me.panelMenu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(150, 432)
        Me.panelMenu.TabIndex = 2
        '
        'paneelMenu
        '
        Me.paneelMenu.BackColor = System.Drawing.Color.Black
        Me.paneelMenu.Controls.Add(Me.Label5)
        Me.paneelMenu.Controls.Add(Me.btnVentas)
        Me.paneelMenu.Controls.Add(Me.btnProveedores)
        Me.paneelMenu.Controls.Add(Me.btnServicios)
        Me.paneelMenu.Controls.Add(Me.btnProductos)
        Me.paneelMenu.Controls.Add(Me.btnClieente)
        Me.paneelMenu.Controls.Add(Me.btnEmpleados)
        Me.paneelMenu.Controls.Add(Me.btnUsuario)
        Me.paneelMenu.Controls.Add(Me.Panel2)
        Me.paneelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.paneelMenu.Location = New System.Drawing.Point(0, 48)
        Me.paneelMenu.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.paneelMenu.Name = "paneelMenu"
        Me.paneelMenu.Size = New System.Drawing.Size(200, 552)
        Me.paneelMenu.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Thistle
        Me.Label5.Location = New System.Drawing.Point(31, 522)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Ingresar con otro usuario"
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.Color.Black
        Me.btnVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnVentas.Location = New System.Drawing.Point(0, 257)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnVentas.Size = New System.Drawing.Size(200, 38)
        Me.btnVentas.TabIndex = 10
        Me.btnVentas.Text = "VENTAS"
        Me.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'btnProveedores
        '
        Me.btnProveedores.BackColor = System.Drawing.Color.Black
        Me.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProveedores.FlatAppearance.BorderSize = 0
        Me.btnProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple
        Me.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedores.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProveedores.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProveedores.Location = New System.Drawing.Point(0, 226)
        Me.btnProveedores.Name = "btnProveedores"
        Me.btnProveedores.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnProveedores.Size = New System.Drawing.Size(200, 31)
        Me.btnProveedores.TabIndex = 7
        Me.btnProveedores.Text = "PROVEEDORES"
        Me.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedores.UseVisualStyleBackColor = False
        '
        'btnServicios
        '
        Me.btnServicios.BackColor = System.Drawing.Color.Black
        Me.btnServicios.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnServicios.FlatAppearance.BorderSize = 0
        Me.btnServicios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple
        Me.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServicios.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServicios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnServicios.Location = New System.Drawing.Point(0, 195)
        Me.btnServicios.Name = "btnServicios"
        Me.btnServicios.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnServicios.Size = New System.Drawing.Size(200, 31)
        Me.btnServicios.TabIndex = 6
        Me.btnServicios.Text = "SERVICIOS"
        Me.btnServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnServicios.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.Black
        Me.btnProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProductos.FlatAppearance.BorderSize = 0
        Me.btnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProductos.Location = New System.Drawing.Point(0, 164)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnProductos.Size = New System.Drawing.Size(200, 31)
        Me.btnProductos.TabIndex = 5
        Me.btnProductos.Text = "PRODUCTOS"
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnClieente
        '
        Me.btnClieente.BackColor = System.Drawing.Color.Black
        Me.btnClieente.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnClieente.FlatAppearance.BorderSize = 0
        Me.btnClieente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple
        Me.btnClieente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnClieente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClieente.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClieente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnClieente.Location = New System.Drawing.Point(0, 133)
        Me.btnClieente.Name = "btnClieente"
        Me.btnClieente.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnClieente.Size = New System.Drawing.Size(200, 31)
        Me.btnClieente.TabIndex = 4
        Me.btnClieente.Text = "CLIENTES"
        Me.btnClieente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClieente.UseVisualStyleBackColor = False
        '
        'btnEmpleados
        '
        Me.btnEmpleados.BackColor = System.Drawing.Color.Black
        Me.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEmpleados.FlatAppearance.BorderSize = 0
        Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEmpleados.Location = New System.Drawing.Point(0, 102)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnEmpleados.Size = New System.Drawing.Size(200, 31)
        Me.btnEmpleados.TabIndex = 3
        Me.btnEmpleados.Text = "EMPLEADOS"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.UseVisualStyleBackColor = False
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.Black
        Me.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumPurple
        Me.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnUsuario.Location = New System.Drawing.Point(0, 71)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnUsuario.Size = New System.Drawing.Size(200, 31)
        Me.btnUsuario.TabIndex = 2
        Me.btnUsuario.Text = "USUARIO"
        Me.btnUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 71)
        Me.Panel2.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Thistle
        Me.Label3.Location = New System.Drawing.Point(93, 45)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "BEAUTY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Thistle
        Me.Label2.Location = New System.Drawing.Point(109, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "STYLE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Thistle
        Me.Label1.Location = New System.Drawing.Point(93, 2)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SALON"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(11, 3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.Thistle
        Me.PanelChildForm.Controls.Add(Me.PictureBox1)
        Me.PanelChildForm.Controls.Add(Me.btnRestaurar)
        Me.PanelChildForm.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(200, 48)
        Me.PanelChildForm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(834, 552)
        Me.PanelChildForm.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(150, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(509, 430)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = CType(resources.GetObject("btnRestaurar.BackgroundImage"), System.Drawing.Image)
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(770, -33)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(29, 29)
        Me.btnRestaurar.TabIndex = 7
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'menus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 600)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.paneelMenu)
        Me.Controls.Add(Me.panelEncabezado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "menus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "menu"
        Me.panelEncabezado.ResumeLayout(False)
        Me.paneelMenu.ResumeLayout(False)
        Me.paneelMenu.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChildForm.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelEncabezado As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents paneelMenu As Panel
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnProveedores As Button
    Friend WithEvents btnServicios As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnClieente As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnUsuario As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label5 As Label
End Class

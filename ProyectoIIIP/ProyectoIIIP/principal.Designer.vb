<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnempleado = New System.Windows.Forms.Button()
        Me.btnadministrador = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Fuchsia
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 292)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ProyectoIIIP.My.Resources.Resources.login_pricipal_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(223, 292)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnempleado
        '
        Me.btnempleado.BackColor = System.Drawing.Color.Transparent
        Me.btnempleado.FlatAppearance.BorderSize = 2
        Me.btnempleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnempleado.Font = New System.Drawing.Font("Dubai", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnempleado.ForeColor = System.Drawing.Color.Turquoise
        Me.btnempleado.Image = CType(resources.GetObject("btnempleado.Image"), System.Drawing.Image)
        Me.btnempleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnempleado.Location = New System.Drawing.Point(265, 161)
        Me.btnempleado.Margin = New System.Windows.Forms.Padding(2)
        Me.btnempleado.Name = "btnempleado"
        Me.btnempleado.Size = New System.Drawing.Size(143, 64)
        Me.btnempleado.TabIndex = 1
        Me.btnempleado.Text = "      Empleado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnempleado.UseVisualStyleBackColor = False
        '
        'btnadministrador
        '
        Me.btnadministrador.BackColor = System.Drawing.Color.Transparent
        Me.btnadministrador.FlatAppearance.BorderSize = 2
        Me.btnadministrador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnadministrador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadministrador.Font = New System.Drawing.Font("Dubai", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadministrador.ForeColor = System.Drawing.Color.Turquoise
        Me.btnadministrador.Image = CType(resources.GetObject("btnadministrador.Image"), System.Drawing.Image)
        Me.btnadministrador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnadministrador.Location = New System.Drawing.Point(265, 43)
        Me.btnadministrador.Margin = New System.Windows.Forms.Padding(2)
        Me.btnadministrador.Name = "btnadministrador"
        Me.btnadministrador.Size = New System.Drawing.Size(143, 64)
        Me.btnadministrador.TabIndex = 0
        Me.btnadministrador.Text = "Administrador"
        Me.btnadministrador.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnadministrador.UseVisualStyleBackColor = False
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrchid
        Me.ClientSize = New System.Drawing.Size(456, 292)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnempleado)
        Me.Controls.Add(Me.btnadministrador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "principal"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "principal"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnadministrador As Button
    Friend WithEvents btnempleado As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class restaurarcontraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(restaurarcontraseña))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcorreo = New System.Windows.Forms.TextBox()
        Me.btnrecuperar = New System.Windows.Forms.Button()
        Me.txtPswMostra = New System.Windows.Forms.Label()
        Me.rtxHtml = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(114, 118)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(100, 26)
        Me.txtcorreo.TabIndex = 1
        '
        'btnrecuperar
        '
        Me.btnrecuperar.Location = New System.Drawing.Point(168, 212)
        Me.btnrecuperar.Name = "btnrecuperar"
        Me.btnrecuperar.Size = New System.Drawing.Size(228, 69)
        Me.btnrecuperar.TabIndex = 2
        Me.btnrecuperar.Text = "Recuperar Contraseña"
        Me.btnrecuperar.UseVisualStyleBackColor = True
        '
        'txtPswMostra
        '
        Me.txtPswMostra.AutoSize = True
        Me.txtPswMostra.Location = New System.Drawing.Point(324, 261)
        Me.txtPswMostra.Name = "txtPswMostra"
        Me.txtPswMostra.Size = New System.Drawing.Size(42, 20)
        Me.txtPswMostra.TabIndex = 3
        Me.txtPswMostra.Text = "label"
        '
        'rtxHtml
        '
        Me.rtxHtml.Location = New System.Drawing.Point(451, 212)
        Me.rtxHtml.Name = "rtxHtml"
        Me.rtxHtml.Size = New System.Drawing.Size(185, 144)
        Me.rtxHtml.TabIndex = 4
        Me.rtxHtml.Text = resources.GetString("rtxHtml.Text")
        '
        'restaurarcontraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.rtxHtml)
        Me.Controls.Add(Me.txtPswMostra)
        Me.Controls.Add(Me.btnrecuperar)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "restaurarcontraseña"
        Me.Text = "restaurarcontraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents btnrecuperar As Button
    Friend WithEvents txtPswMostra As Label
    Friend WithEvents rtxHtml As RichTextBox
End Class

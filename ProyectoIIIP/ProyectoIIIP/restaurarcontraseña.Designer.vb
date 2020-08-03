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
        Me.Label1.Location = New System.Drawing.Point(54, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Correo"
        '
        'txtcorreo
        '
        Me.txtcorreo.Location = New System.Drawing.Point(112, 76)
        Me.txtcorreo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcorreo.Name = "txtcorreo"
        Me.txtcorreo.Size = New System.Drawing.Size(153, 20)
        Me.txtcorreo.TabIndex = 1
        '
        'btnrecuperar
        '
        Me.btnrecuperar.Location = New System.Drawing.Point(112, 138)
        Me.btnrecuperar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnrecuperar.Name = "btnrecuperar"
        Me.btnrecuperar.Size = New System.Drawing.Size(152, 45)
        Me.btnrecuperar.TabIndex = 2
        Me.btnrecuperar.Text = "Recuperar Contraseña"
        Me.btnrecuperar.UseVisualStyleBackColor = True
        '
        'txtPswMostra
        '
        Me.txtPswMostra.AutoSize = True
        Me.txtPswMostra.Location = New System.Drawing.Point(216, 170)
        Me.txtPswMostra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtPswMostra.Name = "txtPswMostra"
        Me.txtPswMostra.Size = New System.Drawing.Size(29, 13)
        Me.txtPswMostra.TabIndex = 3
        Me.txtPswMostra.Text = "label"
        '
        'rtxHtml
        '
        Me.rtxHtml.Location = New System.Drawing.Point(301, 138)
        Me.rtxHtml.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rtxHtml.Name = "rtxHtml"
        Me.rtxHtml.Size = New System.Drawing.Size(125, 95)
        Me.rtxHtml.TabIndex = 4
        Me.rtxHtml.Text = resources.GetString("rtxHtml.Text")
        '
        'restaurarcontraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 292)
        Me.Controls.Add(Me.rtxHtml)
        Me.Controls.Add(Me.txtPswMostra)
        Me.Controls.Add(Me.btnrecuperar)
        Me.Controls.Add(Me.txtcorreo)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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

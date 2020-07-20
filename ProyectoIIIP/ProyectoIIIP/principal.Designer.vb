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
        Me.btnadministrador = New System.Windows.Forms.Button()
        Me.btnempleado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnadministrador
        '
        Me.btnadministrador.Location = New System.Drawing.Point(141, 112)
        Me.btnadministrador.Name = "btnadministrador"
        Me.btnadministrador.Size = New System.Drawing.Size(199, 98)
        Me.btnadministrador.TabIndex = 0
        Me.btnadministrador.Text = "Administrador"
        Me.btnadministrador.UseVisualStyleBackColor = True
        '
        'btnempleado
        '
        Me.btnempleado.Location = New System.Drawing.Point(384, 222)
        Me.btnempleado.Name = "btnempleado"
        Me.btnempleado.Size = New System.Drawing.Size(199, 98)
        Me.btnempleado.TabIndex = 1
        Me.btnempleado.Text = "Empleado"
        Me.btnempleado.UseVisualStyleBackColor = True
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnempleado)
        Me.Controls.Add(Me.btnadministrador)
        Me.Name = "principal"
        Me.Text = "principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnadministrador As Button
    Friend WithEvents btnempleado As Button
End Class

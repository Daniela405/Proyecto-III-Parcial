Imports System.ComponentModel
Imports System.Text.RegularExpressions

Public Class Usuario
    Dim Usuario As String
    Dim Clave As String

    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Dim conexion As New Conexion()
    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If validarCorreo(LCase(txtcorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcorreo.Focus()
            txtcorreo.SelectAll()
        Else
            insertarUsuaurio()
            MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Private Sub insertarUsuaurio()

    End Sub

    'Validating
    Private Sub txtcodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtusuario_Validating(sender As Object, e As CancelEventArgs) Handles txtusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtcontraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtcontraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtcorreo_Validating(sender As Object, e As CancelEventArgs) Handles txtcorreo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    'KeyPress
    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtapellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtapellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcontraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontraseña.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Identificador para cada Usuario")
        ToolTip.ToolTipTitle = "Codigo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Nombre real del propietario del Usuario")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtapellido_MouseHover(sender As Object, e As EventArgs) Handles txtapellido.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Apellido real del propietario del Usuario")
        ToolTip.ToolTipTitle = "Apellido"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtusuario_MouseHover(sender As Object, e As EventArgs) Handles txtusuario.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Nombre asignado para el Usuario")
        ToolTip.ToolTipTitle = "Nombre de Usuario"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontraseña_MouseHover(sender As Object, e As EventArgs) Handles txtcontraseña.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Contraseña por la cual se podra acceder al Usuario")
        ToolTip.ToolTipTitle = "Contraseña"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcorreo_MouseHover(sender As Object, e As EventArgs) Handles txtcorreo.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Correo para realizar contacto con el propietario del Usuario")
        ToolTip.ToolTipTitle = "Correo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
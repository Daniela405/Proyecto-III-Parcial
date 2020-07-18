Imports System.ComponentModel

Public Class servicios
    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub txtcodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cmbtipoServicio_Validating(sender As Object, e As CancelEventArgs) Handles cmbtipoServicio.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingresar código")
        ToolTip.ToolTipTitle = "CÓDIGO"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbtipoServicio_MouseHover(sender As Object, e As EventArgs) Handles cmbtipoServicio.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Seleccione el tipo de servicio que desea")
        ToolTip.ToolTipTitle = "SERVICIO"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
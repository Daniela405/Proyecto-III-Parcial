Public Class Cliente
    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el código")
        tmensaje.ToolTipTitle = "Código"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        tmensaje.SetToolTip(txtnombre, "Ingrese el nombre")
        tmensaje.ToolTipTitle = "Nombre"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class

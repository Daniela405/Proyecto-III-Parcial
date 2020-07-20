Imports System.ComponentModel

Public Class ventas
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub cmbcliente_Validating(sender As Object, e As CancelEventArgs) Handles cmbcliente.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub cmbempleado_Validating(sender As Object, e As CancelEventArgs) Handles cmbempleado.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub cmbproducto_Validating(sender As Object, e As CancelEventArgs) Handles cmbproducto.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub cmbservicio_Validating(sender As Object, e As CancelEventArgs) Handles cmbservicio.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtcantidad1_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcantidad2_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub cmbpagos_Validating(sender As Object, e As CancelEventArgs) Handles cmbpagos.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtdescuento_Validating(sender As Object, e As CancelEventArgs) Handles txtdescuento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbcliente_MouseHover(sender As Object, e As EventArgs) Handles cmbcliente.MouseHover
        tmensaje.SetToolTip(cmbcliente, "Seleccione el cliente")
        tmensaje.ToolTipTitle = "Cliente"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbempleado_MouseHover(sender As Object, e As EventArgs) Handles cmbempleado.MouseHover
        tmensaje.SetToolTip(cmbempleado, "Seleccione el empleado")
        tmensaje.ToolTipTitle = "Empleado"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbproducto_MouseHover(sender As Object, e As EventArgs) Handles cmbproducto.MouseHover
        tmensaje.SetToolTip(cmbproducto, "Seleccione el producto")
        tmensaje.ToolTipTitle = "Producto"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbservicio_MouseHover(sender As Object, e As EventArgs) Handles cmbservicio.MouseHover
        tmensaje.SetToolTip(cmbservicio, "Seleccione el servicio")
        tmensaje.ToolTipTitle = "Servicio"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad1_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad1.MouseHover
        tmensaje.SetToolTip(txtcantidad1, "Ingrese la cantidad")
        tmensaje.ToolTipTitle = "Cantidad"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad2_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad2.MouseHover
        tmensaje.SetToolTip(txtcantidad2, "Ingrese la cantidad")
        tmensaje.ToolTipTitle = "Cantidad"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbpagos_MouseHover(sender As Object, e As EventArgs) Handles cmbpagos.MouseHover
        tmensaje.SetToolTip(cmbpagos, "Seleccione la forma de pago")
        tmensaje.ToolTipTitle = "Forma de Pago"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdescuento_MouseHover(sender As Object, e As EventArgs) Handles txtdescuento.MouseHover
        tmensaje.SetToolTip(txtdescuento, "Ingrese el descuento")
        tmensaje.ToolTipTitle = "Descuento"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class
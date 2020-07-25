Imports System.ComponentModel

Public Class producto
    Private Sub txtcorreo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcorreo_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub txttipo_TextChanged(sender As Object, e As EventArgs) Handles txttipo.TextChanged

    End Sub

    Private Sub txttipo_Validating(sender As Object, e As CancelEventArgs) Handles txttipo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtprecio_TextChanged(sender As Object, e As EventArgs) Handles txtprecio.TextChanged

    End Sub

    Private Sub txtprecio_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub txtcantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtcantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnguardar_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(btnGuardar, "Click para guardar")
        tmensaje.ToolTipTitle = "Guardar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnmodificar_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(btnModificar, "Click para Modificar")
        tmensaje.ToolTipTitle = "Modificar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnbuscar_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(btnBuscar, "Click para buscar")
        tmensaje.ToolTipTitle = "Buscar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub btneliminar_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(btnEliminar, "Click para eliminar")
        tmensaje.ToolTipTitle = "Eliminar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnlimpiar_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(btnLimpiar, "Click para limpiar")
        tmensaje.ToolTipTitle = "Limpiar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el codigo")
        tmensaje.ToolTipTitle = "Codigo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txttipo_MouseHover(sender As Object, e As EventArgs) Handles txttipo.MouseHover
        tmensaje.SetToolTip(txttipo, "Ingrese el tipo del producto")
        tmensaje.ToolTipTitle = "Tipo Producto"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        tmensaje.SetToolTip(txtnombre, "Ingrese el nombre")
        tmensaje.ToolTipTitle = "Nombre"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtprecio_MouseHover(sender As Object, e As EventArgs) Handles txtprecio.MouseHover
        tmensaje.SetToolTip(txtprecio, "Ingrese el precio del producto")
        tmensaje.ToolTipTitle = "Producto"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad_MouseHover(sender As Object, e As EventArgs) Handles txtcantidad.MouseHover
        tmensaje.SetToolTip(txtcantidad, "Ingrese la cantidad")
        tmensaje.ToolTipTitle = "Cantidad Producto"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

End Class
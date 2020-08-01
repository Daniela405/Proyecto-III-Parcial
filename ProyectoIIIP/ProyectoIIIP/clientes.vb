Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class Cliente
    Dim conexion As New Conexion()
    Dim dt As DataTable

    'Dim conexion As New Conexion()

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

    Private Sub txtapellido_MouseHover(sender As Object, e As EventArgs) Handles txtapellido.MouseHover
        tmensaje.SetToolTip(txtapellido, "Ingrese el Apellido")
        tmensaje.ToolTipTitle = "Apellido"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnguardar_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(btnGuardar, "Click para guardar")
        tmensaje.ToolTipTitle = "Guardar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub btnmodificar_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(btnModificar, "Click para modificar")
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

    Private Sub txtcodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
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

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarDatos()

    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertarCliente()
        mostrarDatos()
    End Sub

    Private Sub insertarCliente()
        Dim id As Integer
        Dim nombre, apellido As String


        id = Val(txtcodigo.Text)
        nombre = txtnombre.Text
        apellido = txtapellido.Text

        Try
            If conexion.insertarCliente(id, nombre, apellido) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrarDatos()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarBusqueda()
    End Sub

    Private Sub mostrarBusqueda()
        Dim dato As String
        dato = txtcodigo.Text
        Try
            dt = conexion.buscarCliente(dato)
            If dt.Rows.Count <> 0 Then
                dataclientes.DataSource = dt
                conexion.conexion.Close()
            Else
                dataclientes.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub llenarCampos(e As DataGridViewCellEventArgs)

        Try
            Dim dtg As DataGridViewRow = dataclientes.Rows(e.RowIndex)
            txtcodigo.Text = dtg.Cells(0).Value.ToString()
            txtnombre.Text = dtg.Cells(1).Value.ToString()
            txtapellido.Text = dtg.Cells(2).Value.ToString()

            conexion.conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.conexion.Close()
        End Try
    End Sub

    Private Sub Limpiar()

        txtcodigo.Clear()
        txtnombre.Clear()
        txtapellido.Clear()

    End Sub

    Private Sub mostrarDatos()
        Try
            dt = conexion.consultarCliente
            If dt.Rows.Count <> 0 Then
                dataclientes.DataSource = dt
                conexion.conexion.Close()
            Else
                dataclientes.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.conexion.Close()

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarCliente()
        mostrarDatos()
    End Sub

    Private Sub modificarCliente()
        Dim id As Integer
        Dim nombre, apellido As String

        id = Val(txtcodigo.Text)
        nombre = txtnombre.Text
        apellido = txtapellido.Text


        Try
            If (conexion.modificarCliente(id, nombre, apellido)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Limpiar()

            Else
                MessageBox.Show("Error al actualizar")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            mostrarDatos()
            conexion.conexion.Close()
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        eliminarCliente()
        mostrarDatos()
    End Sub

    Private Sub eliminarCliente()
        Dim id As Integer



        id = Val(txtcodigo.Text)


        Try
            If (conexion.eliminarCliente(id)) Then
                MsgBox("Cliente Eliminado")
                mostrarDatos()
            Else
                MsgBox("No se pudo eliminar el Cliente")
                conexion.conexion.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
        mostrarDatos()
    End Sub
End Class

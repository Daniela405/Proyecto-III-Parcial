﻿Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class proveedor
    Dim conexion As New Conexion()
    Dim dt As DataTable

    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function


    Private Sub txtcodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtcodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtdireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbnombre_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
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

    Private Sub txttelefono_Validating(sender As Object, e As CancelEventArgs) Handles txttelefono.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcorreo_Validating(sender As Object, e As CancelEventArgs) Handles txtcorreo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtrtn_Validating(sender As Object, e As CancelEventArgs) Handles txtrtn.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtidProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtidProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtdireccion_MouseHover(sender As Object, e As EventArgs) Handles txtdireccion.MouseHover
        tmensaje.SetToolTip(txtdireccion, "Ingrese la direccion")
        tmensaje.ToolTipTitle = "Direccion"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el código")
        tmensaje.ToolTipTitle = "Código"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbnombre_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(txtcodigo, "Seleccione el nombre del proveedor")
        tmensaje.ToolTipTitle = "Nombre del Proveedor"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        tmensaje.SetToolTip(txtnombre, "Ingrese el nombre")
        tmensaje.ToolTipTitle = "Nombre"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txttelefono_MouseHover(sender As Object, e As EventArgs) Handles txttelefono.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el telefono")
        tmensaje.ToolTipTitle = "Telefono"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcorreo_MouseHover(sender As Object, e As EventArgs) Handles txtcorreo.MouseHover
        tmensaje.SetToolTip(txtcorreo, "Ingrese el correo")
        tmensaje.ToolTipTitle = "Correo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtrtn_MouseHover(sender As Object, e As EventArgs) Handles txtrtn.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el RTN")
        tmensaje.ToolTipTitle = "RTN"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtidProducto_MouseHover(sender As Object, e As EventArgs) Handles txtidProducto.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el ID Producto")
        tmensaje.ToolTipTitle = "ID Producto"
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

    Private Sub btneliminar_Click(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(btnEliminar, "Click para eliminar")
        tmensaje.ToolTipTitle = "Eliminar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnlimpiar_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(btnLimpiar, "Click para limpiar")
        tmensaje.ToolTipTitle = "Limpiar"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
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

    Private Sub txttelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelefono.KeyPress
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

    Private Sub txtrtn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtrtn.KeyPress
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

    Private Sub txtidProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidProducto.KeyPress
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



    'Botones
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        txtdireccion.Clear()
        txttelefono.Clear()
        txtcodigo.Clear()
        txtrtn.Clear()
        txtidProducto.Clear()
        txtBuscar.Clear()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtcorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcorreo.Focus()
            txtcorreo.SelectAll()
        Else
            MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            agregarProveedor()
            mostrarDatos()
            conexion.conexion.Close()
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarProveedor()
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Cancel As Integer

        Try
            If (MsgBox("¿Esta seguro que desea eliminar este Proovedor?", vbCritical + vbYesNo) = vbYes) Then
                eliminarProveedor()
                mostrarDatos()
            Else
                Cancel = 1
            End If
        Catch ex As Exception
            MsgBox("ex.Message")
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarBusqueda()
    End Sub

    'Operativo
    Private Sub proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarDatos()
    End Sub

    Private Sub dtgProveedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgProveedor.CellContentClick
        llenarCampos(e)
        conexion.conexion.Close()
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)

        Try
            Dim dtg As DataGridViewRow = dtgProveedor.Rows(e.RowIndex)
            txtcodigo.Text = dtg.Cells(0).Value.ToString()
            txtnombre.Text = dtg.Cells(1).Value.ToString()
            txtdireccion.Text = dtg.Cells(2).Value.ToString()
            txttelefono.Text = dtg.Cells(3).Value.ToString()
            txtcorreo.Text = dtg.Cells(4).Value.ToString()
            txtrtn.Text = dtg.Cells(5).Value.ToString()
            txtidProducto.Text = dtg.Cells(6).Value.ToString()

            conexion.conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.conexion.Close()
        End Try
    End Sub
    Private Sub mostrarDatos()
        Try
            dt = conexion.consultarProveedor
            If dt.Rows.Count <> 0 Then
                dtgProveedor.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgProveedor.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.conexion.Close()

        End Try
    End Sub

    Private Sub agregarProveedor()
        Dim id, telefono, rtn, idProducto As Integer
        Dim nombre, direccion, correo As String

        id = txtcodigo.Text
        nombre = txtnombre.Text
        direccion = txtdireccion.Text
        telefono = txttelefono.Text
        correo = txtcorreo.Text
        rtn = txtrtn.Text
        idProducto = txtidProducto.Text

        Try
            If conexion.agregarProveedor(id, nombre, direccion, telefono, correo, rtn, idProducto) Then
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

    Private Sub modificarProveedor()
        Dim id, telefono, rtn, idProducto As Integer
        Dim nombre, direccion, correo As String

        id = txtcodigo.Text
        nombre = txtnombre.Text
        direccion = txtdireccion.Text
        telefono = txttelefono.Text
        correo = txtcorreo.Text
        rtn = txtrtn.Text
        idProducto = txtidProducto.Text

        Try
            If (conexion.modificarProveedor(id, nombre, direccion, telefono, correo, rtn, idProducto)) Then
                MessageBox.Show("Se Actualizo el porveedor correctamente", "correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                mostrarDatos()

                'conexion.conexion.Close()
            Else
                MessageBox.Show(" No Se Actualizo el porveedor correctamente", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            mostrarDatos()
            conexion.conexion.Close()
        End Try
    End Sub

    Private Sub eliminarProveedor()
        Dim id As Integer
        id = txtcodigo.Text
        Try
            If (conexion.eliminarProveedor(id)) Then
                MessageBox.Show("Se elimino el porveedor correctamente", "correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                mostrarDatos()
            Else
                MessageBox.Show("No Se elimino el porveedor correctamente", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mostrarBusqueda()
        Dim dato As String
        dato = txtBuscar.Text
        Try
            dt = conexion.buscarProveedor(dato)
            If dt.Rows.Count <> 0 Then
                dtgProveedor.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgProveedor.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
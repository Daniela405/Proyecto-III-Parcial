Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class usuario
    Dim DataT As DataTable
    Dim conexion As Conexion = New Conexion()
    Private Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        txtcontraseña.Clear()
        txtusuario.Clear()
        txtapellido.Clear()
        txtcorreo.Clear()

    End Sub

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

    Private Sub txtusuario_Validating(sender As Object, e As CancelEventArgs) Handles txtusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcontraseña_Validating(sender As Object, e As CancelEventArgs)
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



    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        tmensaje.SetToolTip(txtcodigo, "Ingrese el codigo")
        tmensaje.ToolTipTitle = "Codigo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        tmensaje.SetToolTip(txtnombre, "Ingrese el nombre")
        tmensaje.ToolTipTitle = "Nombre"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtapellido_MouseHover(sender As Object, e As EventArgs) Handles txtapellido.MouseHover
        tmensaje.SetToolTip(txtapellido, "Ingrese el apellido")
        tmensaje.ToolTipTitle = "Apellido"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtusuario_MouseHover(sender As Object, e As EventArgs) Handles txtusuario.MouseHover
        tmensaje.SetToolTip(txtusuario, "Ingrese el usuario")
        tmensaje.ToolTipTitle = "Usuario"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontraseña_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(txtcontraseña, "Ingrese la contraseña")
        tmensaje.ToolTipTitle = "Contraseña"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcorreo_MouseHover(sender As Object, e As EventArgs) Handles txtcorreo.MouseHover
        tmensaje.SetToolTip(txtcorreo, "Ingrese el correo")
        tmensaje.ToolTipTitle = "Correo"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrardatos()
    End Sub

    Public Sub mostrardatos()
        conexion.consulta("select * from usuario", "usuario")

        DataGridView1.DataSource = conexion.ds.Tables("usuario")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtcodigo.Text = dgv.Cells(0).Value.ToString()
        txtnombre.Text = dgv.Cells(1).Value.ToString()
        txtapellido.Text = dgv.Cells(2).Value.ToString()
        txtusuario.Text = dgv.Cells(3).Value.ToString()
        txtcontraseña.Text = dgv.Cells(4).Value.ToString()
        txtcorreo.Text = dgv.Cells(5).Value.ToString()
        cmbrol.Text = dgv.Cells(6).Value.ToString()
        txtestado.Text = dgv.Cells(7).Value.ToString()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If validarCorreo(LCase(txtcorreo.Text)) = False Then
            MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcorreo.Focus()
            txtcorreo.SelectAll()
        Else
            insertarUsuaurio()
            'MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            conexion.conexion.Close()

        End If
    End Sub

    Private Sub insertarUsuaurio()
        Dim idUsuario As Integer
        Dim nombre, apellido, userName, psw, correo, rol, estado As String
        idUsuario = txtcodigo.Text
        nombre = txtnombre.Text
        apellido = txtapellido.Text
        userName = txtusuario.Text
        psw = txtcontraseña.Text
        correo = txtcorreo.Text
        estado = "activo"
        rol = cmbrol.Text
        Try
            If conexion.agregarUsuario(idUsuario, nombre, apellido, userName, psw, correo, rol, estado) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiar()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub eliminarUsuario()
        Dim idUsuario As Integer
        Dim rol As String
        idUsuario = txtcodigo.Text
        rol = cmbrol.Text
        Try
            If (conexion.eliminarUsuarios(idUsuario, rol)) Then
                MsgBox("Dado de baja")
                ' conexion.conexion.Close()
            Else
                MsgBox("Error al dar de baja usuario")
                ' conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer
        Dim rol As String
        id = txtcodigo.Text
        rol = cmbrol.Text

        Try
            If conexion.Eliminar(id, rol) Then
                MsgBox("Eliminado Correctamente")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub


    Private Sub modificar()
        Dim id As Integer
        Dim nombre As String
        Dim apellido As String
        Dim usuario As String
        Dim contraseña As String
        Dim correo As String
        Dim rol As Char
        Dim Estado As Char


        id = txtcodigo.Text
        nombre = txtnombre.Text
        apellido = txtapellido.Text
        usuario = txtusuario.Text
        contraseña = txtcontraseña.Text
        correo = txtcorreo.Text
        rol = cmbrol.Text
        Estado = txtestado.Text
        Try
            If (conexion.modificar(id, nombre, apellido, usuario, contraseña, correo, rol, Estado)) Then
                MsgBox("Modificado correctamente")
                ' conexion.conexion.Close()

            Else
                MsgBox("Error al modificar usuario")
                ' conexion.conexion.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            mostrardatos()
        End Try
        mostrardatos()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim id As Integer
        Dim nombre As String
        Dim apellido As String
        Dim usuario As String
        Dim contraseña As String
        Dim correo As String
        Dim rol As Char
        Dim Estado As Char

        id = txtcodigo.Text
        nombre = txtnombre.Text
        apellido = txtapellido.Text
        usuario = txtusuario.Text
        contraseña = txtcontraseña.Text
        correo = txtcorreo.Text
        rol = cmbrol.Text
        Estado = txtestado.Text

        Try
            If conexion.modificar(id, nombre, apellido, usuario, contraseña, correo, rol, Estado) Then
                MsgBox("Modificado Correctamente")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscarUsuario()
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged
        txtnombre.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtnombre.Text)
        txtnombre.SelectionStart = txtnombre.Text.Length
    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged
        txtapellido.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtapellido.Text)
        txtapellido.SelectionStart = txtapellido.Text.Length
    End Sub



    Private Sub BuscarUsuario()
        Dim nombreUsuario As String
        nombreUsuario = txtusuario.Text
        Try
            DataT = conexion.BuscarUsuario(nombreUsuario)
            If DataT.Rows.Count <> 0 Then
                MessageBox.Show("Usuario Encontrado correctamente", "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = DataT
                txtusuario.Text = ""
            Else
                MessageBox.Show("Usuario no encontrado", "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DataGridView1.DataSource = Nothing
                txtusuario.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



End Class
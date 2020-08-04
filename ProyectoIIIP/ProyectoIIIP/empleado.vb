Imports System.ComponentModel
Imports System.Text.RegularExpressions
Public Class empleado
    Dim conexion As Conexion = New Conexion()
    Dim idAnterior As Integer
    Private Sub empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        actualizarID()

        mostrardatos()
    End Sub

    Private Function validarCorreo(ByVal isCorreo As String) As Boolean
        Return Regex.IsMatch(isCorreo, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub ordenarLetras()
        Dim mayus As String
        Dim mayuscula As String
        Dim minuscula As String
        mayus = txtnombre.Text
        mayuscula = txtapellido.Text
        minuscula = txtCorreo.Text

        Dim newTexto As String = StrConv(mayus, VbStrConv.ProperCase)
        txtnombre.Text = newTexto
        Dim nuevoTexto As String = StrConv(mayuscula, VbStrConv.ProperCase)
        txtapellido.Text = nuevoTexto
        Dim textMinus As String = LCase(minuscula)
        txtCorreo.Text = textMinus
    End Sub
    Private Sub ordenarLetra()
        Dim mayus As String

        mayus = txtBuscarNombre.Text

        Dim newTexto As String = StrConv(mayus, VbStrConv.ProperCase)
        txtBuscarNombre.Text = newTexto

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ordenarLetras()
        Try
            If validarCorreo(LCase(txtCorreo.Text)) = False Then
                MessageBox.Show("Correo invalido, *username@midominio.com*", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtCorreo.Focus()
                txtCorreo.SelectAll()
            Else
                If IsNumeric(mtxtIdentidad.Text) = True And mtxtIdentidad.TextLength = 13 Then
                    If conexion.comprobarExistenciaIdentidadEm(mtxtIdentidad.Text) = 2 Then
                        If (conexion.agregarEmpleado(Val(txtcodigo.Text), mtxtIdentidad.Text, txtnombre.Text, txtapellido.Text, txtUsuario.Text, txtedad.Text, cmbsexo.SelectedItem, txtTel.Text, txtCorreo.Text, cmbcargo.SelectedItem, txtEstado.Text)) Then
                            actualizarID()
                            conexion.consultaEmpleado("SELECT * from empleado Where empleado.Identidad = " & mtxtIdentidad.Text, "data")
                            MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            dataEmpleado.DataSource = conexion.ds.Tables("data")
                            mostrardatos()
                        Else
                            MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            limpiar()
                        End If
                    Else
                        MessageBox.Show("Ya existe registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        limpiar()
                    End If
                Else
                    MessageBox.Show("Revise el número de Identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
                MessageBox.Show("Correo valido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrardatos()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub dataEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataEmpleado.CellContentClick
        Dim dtg As DataGridViewRow = dataEmpleado.Rows(e.RowIndex)
        txtcodigo.Text = dtg.Cells(0).Value.ToString()
        mtxtIdentidad.Text = dtg.Cells(1).Value.ToString()
        txtnombre.Text = dtg.Cells(2).Value.ToString()
        txtapellido.Text = dtg.Cells(3).Value.ToString()
        txtUsuario.Text = dtg.Cells(4).Value.ToString()
        txtedad.Text = dtg.Cells(5).Value.ToString()
        cmbsexo.SelectedItem = dtg.Cells(6).Value.ToString()
        txtTel.Text = dtg.Cells(7).Value.ToString()
        txtCorreo.Text = dtg.Cells(8).Value.ToString()
        cmbcargo.SelectedItem = dtg.Cells(9).Value.ToString()
        txtEstado.Text = dtg.Cells(10).Value.ToString()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()

    End Sub

    Private Sub limpiar()
        txtcodigo.Clear()
        txtnombre.Clear()
        txtapellido.Clear()
        txtedad.Clear()
        cmbsexo.SelectedItem = "<Seleccionar>"
        cmbcargo.SelectedItem = "<Seleccionar>"
        mtxtIdentidad.Clear()
        txtBuscarNombre.Clear()
        txtUsuario.Clear()
        txtEstado.Clear()
        txtCorreo.Clear()
        txtTel.Clear()
        dataEmpleado.DataSource = ""
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If (conexion.actualizarEmpleado(Val(txtcodigo.Text), mtxtIdentidad.Text, txtnombre.Text, txtapellido.Text, txtUsuario.Text, Val(txtedad.Text), cmbsexo.SelectedItem, txtTel.Text, txtCorreo.Text, cmbcargo.SelectedItem, txtEstado.Text)) Then
                conexion.consultaEmpleado("SELECT * from empleado Where empleado.Identidad = '" & mtxtIdentidad.Text & "'", "data")
                MessageBox.Show("Modificado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dataEmpleado.DataSource = conexion.ds.Tables("data")
            Else
                MessageBox.Show("Error al modificar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If rbCodigo.Checked Then 'con Radio Button Codigo==========
            Try
                If IsNumeric(mBuscarIdentidad.Text) = True And mBuscarIdentidad.TextLength = 13 Then

                    If conexion.comprobarExistenciaIdentidadEm(mBuscarIdentidad.Text) = 1 Then

                        conexion.consultaEmpleado("SELECT * from empleado Where empleado.Identidad = '" & mBuscarIdentidad.Text & "'", "data")
                        dataEmpleado.DataSource = conexion.ds.Tables("data")

                        Dim dtg As DataGridViewRow = dataEmpleado.Rows(0)
                        txtcodigo.Text = dtg.Cells(0).Value.ToString()
                        mtxtIdentidad.Text = dtg.Cells(1).Value.ToString()
                        txtnombre.Text = dtg.Cells(2).Value.ToString()
                        txtapellido.Text = dtg.Cells(3).Value.ToString()
                        txtUsuario.Text = dtg.Cells(4).Value.ToString()
                        txtedad.Text = dtg.Cells(5).Value.ToString()
                        cmbsexo.SelectedItem = dtg.Cells(6).Value.ToString()
                        txtTel.Text = dtg.Cells(7).Value.ToString()
                        txtCorreo.Text = dtg.Cells(8).Value.ToString()
                        cmbcargo.SelectedItem = dtg.Cells(9).Value.ToString()
                        txtEstado.Text = dtg.Cells(10).Value.ToString()
                    Else
                        MsgBox("El empleado no existe!", vbCritical)
                    End If

                Else
                    MsgBox("Revise el número de identidad!", vbCritical)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        ElseIf rbNombre.Checked Then 'con Radio Button Nombre==========
            ordenarLetra()
            Try
                ' If conexion.comprobarExistencianombreEmpleado(txtBuscarNombre.Text) = 1 Then
                dataEmpleado.DataSource = conexion.buscarEmpleado(txtBuscarNombre.Text)

                'Else
                'MessageBox.Show("No existe registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminarEmpleados(Val(txtcodigo.Text))) Then
                limpiar()
                dataEmpleado.DataSource = " "
                MessageBox.Show("Eliminado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEstado.Text = "Eliminado"

                mostrardatos()
                Dim dtg As DataGridViewRow = dataEmpleado.Rows(0)

                txtcodigo.Text = dtg.Cells(0).Value.ToString()
                mtxtIdentidad.Text = dtg.Cells(1).Value.ToString()
                txtnombre.Text = dtg.Cells(2).Value.ToString()
                txtapellido.Text = dtg.Cells(3).Value.ToString()
                txtUsuario.Text = dtg.Cells(4).Value.ToString()
                txtedad.Text = dtg.Cells(5).Value.ToString()
                cmbsexo.SelectedItem = dtg.Cells(6).Value.ToString()
                txtTel.Text = dtg.Cells(7).Value.ToString()
                txtCorreo.Text = dtg.Cells(8).Value.ToString()
                cmbcargo.SelectedItem = dtg.Cells(9).Value.ToString()
                'txtEstado.Text = dtg.Cells(10).Value.ToString()

            Else
                MessageBox.Show("Error al eliminar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub actualizarID()
        If conexion.retornarUltimoEmpleado() = " " Then
            idAnterior = 1
            txtcodigo.Text = idAnterior
        Else
            idAnterior = conexion.retornarUltimoEmpleado() + 1
            txtcodigo.Text = idAnterior
        End If
    End Sub

    Private Sub txtUsuario_Validating(sender As Object, e As CancelEventArgs) Handles txtUsuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub
    Private Sub txtUsuario_MouseHover(sender As Object, e As EventArgs) Handles txtUsuario.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese su Usuario de empleado")
        ToolTip.ToolTipTitle = "Nombre de Usuario"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles mtxtIdentidad.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese su Usuario de empleado")
        ToolTip.ToolTipTitle = "Nombre de Usuario"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles mtxtIdentidad.Validating
        If DirectCast(sender, MaskedTextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtTel_Validating(sender As Object, e As CancelEventArgs) Handles txtTel.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtTel_MouseHover(sender As Object, e As EventArgs) Handles txtTel.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese su número telefónico")
        ToolTip.ToolTipTitle = "Número"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
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

    Private Sub txtCorreo_Validating(sender As Object, e As CancelEventArgs) Handles txtCorreo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtCorreo_MouseHover(sender As Object, e As EventArgs) Handles txtCorreo.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese su correo personal")
        ToolTip.ToolTipTitle = "Correo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEstado_Validating(sender As Object, e As CancelEventArgs) Handles txtEstado.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtEstado_MouseHover(sender As Object, e As EventArgs) Handles txtEstado.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese estado *Activo*")
        ToolTip.ToolTipTitle = "Estado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtEstado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEstado.KeyPress
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

    Private Sub txtBuscarNombre_MouseHover(sender As Object, e As EventArgs) Handles txtBuscarNombre.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese una letra del nombre del empleado")
        ToolTip.ToolTipTitle = "Nombre del empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtBuscarNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarNombre.KeyPress
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

    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
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

    Private Sub txtedad_Validating(sender As Object, e As CancelEventArgs) Handles txtedad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtedad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtedad.KeyPress
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

    Private Sub cmbsexo_Validating(sender As Object, e As CancelEventArgs) Handles cmbsexo.Validating
        If DirectCast(sender, ComboBox).Text.Length < 1 Or cmbsexo.Text = "<Seleccionar>" Then
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        Else
            Me.ErrorProvider.SetError(sender, "")
        End If
    End Sub

    Private Sub cmbcargo_Validating(sender As Object, e As CancelEventArgs) Handles cmbcargo.Validating
        If DirectCast(sender, ComboBox).Text.Length < 1 Or cmbcargo.Text = "<Seleccionar>" Then
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        Else
            Me.ErrorProvider.SetError(sender, "")
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

    Private Sub txtcodigo_MouseHover(sender As Object, e As EventArgs) Handles txtcodigo.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese su código de empleado")
        ToolTip.ToolTipTitle = "CÓDIGO"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtnombre_MouseHover(sender As Object, e As EventArgs) Handles txtnombre.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese su primer nombre")
        ToolTip.ToolTipTitle = "NOMBRE"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtapellido_MouseHover(sender As Object, e As EventArgs) Handles txtapellido.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese su primer apellido")
        ToolTip.ToolTipTitle = "APELLIDO"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtedad_MouseHover(sender As Object, e As EventArgs) Handles txtedad.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Ingrese su edad")
        ToolTip.ToolTipTitle = "EDAD"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbsexo_MouseHover(sender As Object, e As EventArgs) Handles cmbsexo.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Seleccione su género")
        ToolTip.ToolTipTitle = "SEXO"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbcargo_MouseHover(sender As Object, e As EventArgs) Handles cmbcargo.MouseHover
        ToolTip.SetToolTip(txtcodigo, "Seleccione su cargo")
        ToolTip.ToolTipTitle = "CARGO"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub rbCodigo_CheckedChanged(sender As Object, e As EventArgs) Handles rbCodigo.CheckedChanged
        dataEmpleado.DataSource = ""
        limpiar1()

        txtBuscarNombre.Enabled = False
        txtBuscarNombre.Visible = False
        mBuscarIdentidad.Enabled = True
        mBuscarIdentidad.Visible = True
    End Sub

    Private Sub rbNombre_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        dataEmpleado.DataSource = ""
        limpiar1()
        txtBuscarNombre.Enabled = True
        txtBuscarNombre.Visible = True
        mBuscarIdentidad.Enabled = False
        mBuscarIdentidad.Visible = False
    End Sub
    Private Sub limpiar1()
        txtnombre.Clear()
        txtapellido.Clear()
        txtedad.Clear()
        cmbsexo.SelectedItem = "<Seleccionar>"
        cmbcargo.SelectedItem = "<Seleccionar>"
        mtxtIdentidad.Clear()
        mBuscarIdentidad.Clear()
        txtBuscarNombre.Clear()
        txtUsuario.Clear()
        txtEstado.Clear()
        txtCorreo.Clear()
        txtTel.Clear()
        dataEmpleado.DataSource = ""
    End Sub

    Private Sub cmbsexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsexo.SelectedIndexChanged

    End Sub

    Private Sub cmbcargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcargo.SelectedIndexChanged

    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

        txtnombre.Text = StrConv(txtnombre.Text, vbProperCase)
        txtnombre.SelectionStart = Len(txtnombre.Text)

    End Sub

    Private Sub txtapellido_TextChanged(sender As Object, e As EventArgs) Handles txtapellido.TextChanged

        txtapellido.Text = StrConv(txtapellido.Text, vbProperCase)
        txtapellido.SelectionStart = Len(txtapellido.Text)

    End Sub
    Public Sub mostrardatos()
        conexion.consulta("select * from empleado", "empleado")

        dataEmpleado.DataSource = conexion.ds.Tables("empleado")

    End Sub

    Private Sub txtBuscarNombre_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarNombre.TextChanged

    End Sub
End Class
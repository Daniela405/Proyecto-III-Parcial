Imports System.ComponentModel

Public Class servicios
    Dim conexion As New Conexion()
    Dim dt As DataTable


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
        conexion.conexion.Close()
    End Sub

    Private Sub dtgServicios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgServicios.CellContentClick
        llenarCampos(e)
        conexion.conexion.Close()
    End Sub

    Private Sub servicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertarServicio()
        mostrarDatos()
        conexion.conexion.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Cancel As Integer

        Try
            If (MsgBox("¿Esta seguro que desea eliminar este servicio?", vbCritical + vbYesNo) = vbYes) Then
                eliminarServicio()
                mostrarDatos()

            Else
                Cancel = 1
            End If
        Catch ex As Exception
            MsgBox("ex.Message")
        End Try

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
        mostrarDatos()
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificarServicio()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        mostrarBusqueda()
    End Sub
    '@id int ,
    '@tiposervicio varchar(50) ,
    '@nombre varchar (50) ,
    '@precio decimal 
    Private Sub insertarServicio()
        Dim id As Integer
        Dim nombre, tipoServicio, estado As String
        Dim precio As Double

        id = Val(txtCodigo.Text)
        nombre = txtNombre.Text
        tipoServicio = cmbTipoServicio.Text
        precio = Val(txtPrecio.Text)
        estado = "Disponible"

        Try
            If conexion.insertarServicio(id, tipoServicio, nombre, precio, estado) Then
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

    Private Sub eliminarServicio()
        Dim id As Integer
        Dim estado As String
        estado = lbEstado.Text

        id = Val(txtCodigo.Text)


        Try
            If (conexion.eliminarServicio(id, estado)) Then
                MsgBox("Servicio Eliminado")
                mostrarDatos()
            Else
                MsgBox("No se pudo eliminar el servicio")
                conexion.conexion.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub modificarServicio()
        Dim id As Integer
        Dim nombre, tipoServicio As String
        Dim precio As Double

        id = Val(txtCodigo.Text)
        nombre = txtNombre.Text
        tipoServicio = cmbTipoServicio.Text
        precio = Val(txtPrecio.Text)

        Try
            If (conexion.modificarServicio(id, tipoServicio, nombre, precio)) Then
                MessageBox.Show("Actualizado")
                mostrarDatos()
                Limpiar()
                'conexion.conexion.Close()
            Else
                MessageBox.Show("Error al actualizar")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            mostrarDatos()
            conexion.conexion.Close()
        End Try
    End Sub

    Private Sub mostrarBusqueda()
        Dim dato As String
        dato = txtBuscar.Text
        Try
            dt = conexion.buscarServicio(dato)
            If dt.Rows.Count <> 0 Then
                dtgServicios.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgServicios.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)

        Try
            Dim dtg As DataGridViewRow = dtgServicios.Rows(e.RowIndex)
            txtCodigo.Text = dtg.Cells(0).Value.ToString()
            cmbTipoServicio.Text = dtg.Cells(1).Value.ToString()
            txtNombre.Text = dtg.Cells(2).Value.ToString()
            txtPrecio.Text = dtg.Cells(3).Value.ToString()
            lbEstado.Text = dtg.Cells(4).Value.ToString()

            conexion.conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.conexion.Close()
        End Try
    End Sub

    Private Sub mostrarDatos()
        Try
            dt = conexion.consultaServicios
            If dt.Rows.Count <> 0 Then
                dtgServicios.DataSource = dt
                conexion.conexion.Close()
            Else
                dtgServicios.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.conexion.Close()

        End Try
    End Sub
    Private Sub Limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrecio.Clear()
        cmbTipoServicio.Text = ""
        lbEstado.Text = ""
    End Sub

    Private Sub txtCodigo_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub cmbTipoServicio_Validating(sender As Object, e As CancelEventArgs) Handles cmbTipoServicio.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Ingresar código")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbTipoServicio_MouseHover(sender As Object, e As EventArgs) Handles cmbTipoServicio.MouseHover
        ToolTip.SetToolTip(cmbTipoServicio, "Seleccione el tipo de servicio que desea")
        ToolTip.ToolTipTitle = "Servicio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
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
    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
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
    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
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

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub


    Private Sub txtPrecio_Validated(sender As Object, e As EventArgs) Handles txtPrecio.Validated
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        ToolTip.SetToolTip(txtPrecio, "Ingrese un Precio")
        ToolTip.ToolTipTitle = "Precio"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtBuscar_Validating(sender As Object, e As CancelEventArgs) Handles txtBuscar.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese dato a buscar")
        End If
    End Sub

    Private Sub txtBuscar_MouseHover(sender As Object, e As EventArgs) Handles txtBuscar.MouseHover
        ToolTip.SetToolTip(txtBuscar, "Ingrese el dato a buscar")
        ToolTip.ToolTipTitle = "Buscar"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscar.KeyPress
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
End Class
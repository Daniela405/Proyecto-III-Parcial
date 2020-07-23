Imports System.ComponentModel

Public Class producto
    Dim conexion As Conexion = New Conexion()
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()

        mostrardatos()
    End Sub
    Public Sub mostrardatos()
        conexion.consulta("select * from productos", "productos")

        DataGridView1.DataSource = conexion.ds.Tables("productos")

    End Sub


    Private Sub insertarProducto()
        Dim id As Integer, codigobarra As String, tipoproducto As String, nombre As String, precio As Decimal, cantidad As Integer, caracteristica As String
        id = txtcodigo.Text
        codigobarra = txtcodbarra.Text
        tipoproducto = txttipo.Text
        nombre = txtnombre.Text
        precio = txtprecio.Text
        cantidad = txtcantidad.Text
        caracteristica = txtcaracteristica.Text
        Try
            If conexion.agregarProductos(id, codigobarra, tipoproducto, nombre, precio, cantidad, caracteristica) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrardatos()

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        insertarProducto()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim dgv As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtcodigo.Text = dgv.Cells(0).Value.ToString()
        txtcodbarra.Text = dgv.Cells(1).Value.ToString()
        txttipo.Text = dgv.Cells(2).Value.ToString()
        txtnombre.Text = dgv.Cells(3).Value.ToString()
        txtprecio.Text = dgv.Cells(4).Value.ToString()
        txtcantidad.Text = dgv.Cells(5).Value.ToString()
        txtcaracteristica.Text = dgv.Cells(6).Value.ToString()

    End Sub

    Private Sub modificar()
        Dim id As Integer, codigobarra As String, tipoproducto As String, nombre As String, precio As Decimal, cantidad As Integer, caracteristica As String
        id = txtcodigo.Text
        codigobarra = txtcodbarra.Text
        tipoproducto = txttipo.Text
        nombre = txtnombre.Text
        precio = txtprecio.Text
        cantidad = txtcantidad.Text
        caracteristica = txtcaracteristica.Text
        Try
            If (conexion.modificarProducto(id, codigobarra, tipoproducto, nombre, precio, cantidad, caracteristica)) Then
                MsgBox("Modificado correctamente")
                ' conexion.conexion.Close()
                mostrardatos()

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
        modificar()
    End Sub
End Class
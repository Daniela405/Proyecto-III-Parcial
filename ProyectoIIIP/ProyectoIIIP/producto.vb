Imports System.ComponentModel

Public Class producto
    Dim DataT As DataTable
    Dim conexion As Conexion = New Conexion()
    Dim idanterior As Integer
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
        idnuevo()
    End Sub

    Public Sub limpiar()
        txtcodigo.Clear()
        txtcodbarra.Clear()
        txttipo.Clear()
        txtnombre.Clear()
        txtprecio.Clear()
        txtprecioventa.Clear()
        txtcantidad.Clear()
        txtcaracteristica.Clear()
    End Sub

    Private Sub idnuevo()

        If conexion.retornarId() = 0 Then
            idanterior = 1
            txtcodigo.Text = idanterior

        Else
            idanterior = conexion.retornarId() + 1
            txtcodigo.Text = idanterior
        End If
    End Sub
    Public Sub mostrardatos()
        conexion.consulta("select * from productos", "productos")

        DataGridView1.DataSource = conexion.ds.Tables("productos")

    End Sub


    Private Sub insertarProducto()
        Dim id As Integer, codigobarra As String, tipoproducto As String, nombre As String, precio As Decimal, precioventa As Decimal, cantidad As Integer, caracteristica As String

        Try
            id = Val(txtcodigo.Text)
            codigobarra = txtcodbarra.Text
            tipoproducto = txttipo.Text
            nombre = txtnombre.Text
            precio = Val(txtprecio.Text)
            precioventa = Val(txtprecioventa.Text)
            cantidad = Val(txtcantidad.Text)
            caracteristica = txtcaracteristica.Text
            If conexion.agregarProductos(id, codigobarra, tipoproducto, nombre, precio, precioventa, cantidad, caracteristica) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrardatos()
                limpiar()
                idnuevo()
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
        txtprecioventa.Text = dgv.Cells(5).Value.ToString()
        txtcantidad.Text = dgv.Cells(6).Value.ToString()
        txtcaracteristica.Text = dgv.Cells(7).Value.ToString()

    End Sub

    Private Sub modificar()
        Dim id As Integer, codigobarra As String, tipoproducto As String, nombre As String, precio As Decimal, precioventa As Decimal, cantidad As Integer, caracteristica As String

        If txtcodigo.Text = " " Then
            MessageBox.Show("Falta Datos para poder actualizar", "Actualizacion Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Try
                id = Val(txtcodigo.Text)
                codigobarra = txtcodbarra.Text
                tipoproducto = txttipo.Text
                nombre = txtnombre.Text
                precio = Val(txtprecio.Text)
                precioventa = Val(txtprecioventa.Text)
                cantidad = Val(txtcantidad.Text)
                caracteristica = txtcaracteristica.Text
                If (conexion.modificarProducto(id, codigobarra, tipoproducto, nombre, precio, precioventa, cantidad, caracteristica)) Then
                    MessageBox.Show("Actualizacion Correcta", "Actualizacion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' conexion.conexion.Close()
                    mostrardatos()

                Else
                    MessageBox.Show("Falta Datos para poder actualizar", "Actualizacion Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ' conexion.conexion.Close()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                mostrardatos()
            End Try
            mostrardatos()
            limpiar()

        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        modificar()
    End Sub


    Private Sub BuscarProducto()
        Dim nombreproducto, tipo As String
        nombreproducto = txtnombre.Text
        tipo = txttipo.Text
        Try


            DataT = conexion.BuscarProducto(nombreproducto)

            If DataT.Rows.Count <> 0 Then
                MessageBox.Show("Producto Encontrado correctamente", "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Information)
                DataGridView1.DataSource = DataT
                txtnombre.Text = ""
            Else
                MessageBox.Show("Producto no encontrado", "No se encontro producto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DataGridView1.DataSource = Nothing
                txtnombre.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscarProducto()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim id As Integer



        Try
            id = Val(txtcodigo.Text)

            If conexion.EliminarProducto(id) Then
                MessageBox.Show("Se elimino correctamente el cliente", "Se Elimino", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                mostrardatos()
                limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtcodigo.ReadOnly = False
    End Sub

    Private Sub ckguardar_CheckedChanged(sender As Object, e As EventArgs) Handles ckguardar.CheckedChanged
        idnuevo()
        If ckguardar.Checked = False Then
            txtcodigo.Clear()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        txtcodigo.ReadOnly = False
        txtcodigo.Clear()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
End Class
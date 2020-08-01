Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Data


Public Class ventas
    Dim conexion As Conexion = New Conexion()

    Dim strcomando As String
    Dim adapter As SqlDataAdapter
    Dim data As DataSet
    Dim leer As SqlDataAdapter
    Dim idanterior As Integer
    Public lavariable As Integer
    Public DataT As DataTable
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub cmbcliente_Validating(sender As Object, e As CancelEventArgs)
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


    Private Sub cmbproducto_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub cmbservicio_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtcantidad1_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtcantidad2_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub cmbpagos_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtdescuento_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub cmbcliente_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(txtidcliente, "Seleccione el cliente")
        tmensaje.ToolTipTitle = "Cliente"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbempleado_MouseHover(sender As Object, e As EventArgs) Handles cmbempleado.MouseHover
        tmensaje.SetToolTip(cmbempleado, "Seleccione el empleado")
        tmensaje.ToolTipTitle = "Empleado"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbproducto_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(cmbproducto, "Seleccione el producto")
        tmensaje.ToolTipTitle = "Producto"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbservicio_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(cmbservicio, "Seleccione el servicio")
        tmensaje.ToolTipTitle = "Servicio"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad1_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(txtcantidad1, "Ingrese la cantidad")
        tmensaje.ToolTipTitle = "Cantidad"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcantidad2_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(txtcantidad2, "Ingrese la cantidad")
        tmensaje.ToolTipTitle = "Cantidad"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbpagos_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(cmbpagos, "Seleccione la forma de pago")
        tmensaje.ToolTipTitle = "Forma de Pago"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtdescuento_MouseHover(sender As Object, e As EventArgs)
        tmensaje.SetToolTip(txtdescuento, "Ingrese el descuento")
        tmensaje.ToolTipTitle = "Descuento"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Public Sub mostrardatos()
        conexion.consulta("select * from venta", "venta")

        DataGridView1.DataSource = conexion.ds.Tables("venta")

    End Sub
    Public Sub mostrarcliente()
        conexion.consulta("select * from cliente", "cliente")

        DataGridView2.DataSource = conexion.ds.Tables("cliente")

    End Sub

    Function idventa()

        If conexion.retornarIdventa() = 0 Then
            idanterior = 1


        Else
            idanterior = conexion.retornarIdventa() + 1

            Return idanterior
        End If
    End Function
    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrardatos()
        mostrarcliente()
        txtnumeroVenta.Text = idventa()
        lavariable = idventa()
        TextBox2.Text = idventa()



        strcomando = "Select * from empleado"
        adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion.conexion)
        data = New DataSet
        adapter.Fill(data)
        cmbempleado.DataSource = data.Tables(0)
        cmbempleado.DisplayMember = "Nombre"
        cmbempleado.ValueMember = "Id"





    End Sub

    Private Sub insertarVenta()
        Dim id As Integer, idcliente As Integer, idempleado As Integer, fecha As String, formapago As String, numerofactura As Integer
        id = idventa()
        idcliente = txtidcliente.Text
        idempleado = txtidcliente.Text
        fecha = MaskedTextBox1.Text
        formapago = ComboBox1.Text
        numerofactura = TextBox2.Text


        Try
            If conexion.agregarVenta(id, idcliente, idempleado, fecha, formapago, numerofactura) Then
                MessageBox.Show("Venta Generada Ahora a Agregar Productos ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrardatos()
                detalleVentas.Show()
                Me.Hide()

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insertarVenta()
    End Sub

    Private Sub Buscarcliente()
        Dim nombrecliente As String
        nombrecliente = txtnombrecliente.Text

        Try


            DataT = conexion.Buscarclienteenventas(nombrecliente)

            If DataT.Rows.Count <> 0 Then

                DataGridView2.DataSource = DataT

            Else
                MessageBox.Show("Cliente no econtrado", "Buscando", MessageBoxButtons.OK, MessageBoxIcon.Error)
                DataGridView2.DataSource = Nothing
                txtbuscarcliente.Text = " "
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick

        Dim dgv As DataGridViewRow = DataGridView2.Rows(e.RowIndex)


        txtidcliente.Text = dgv.Cells(0).Value.ToString()
        txtnombrecliente.Text = dgv.Cells(1).Value.ToString()
        txtapellidocliente.Text = dgv.Cells(2).Value.ToString()
    End Sub

    Private Sub txtbuscarcliente_TextChanged(sender As Object, e As EventArgs) Handles txtbuscarcliente.TextChanged
        Buscarcliente()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        insertarclientemas()
    End Sub

    Private Sub insertarclientemas()
        Dim id As Integer, nombrecliente As String, apellidocliente As String
        id = txtidcliente.Text
        nombrecliente = txtnombrecliente.Text
        apellidocliente = txtapellidocliente.Text

        Try
            If conexion.agregarclientemas(id, nombrecliente, apellidocliente) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrarcliente()

            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
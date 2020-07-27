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
    Public Sub mostrardatos()
        conexion.consulta("select * from ventas", "ventas")

        DataGridView1.DataSource = conexion.ds.Tables("ventas")

    End Sub
    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrardatos()

        strcomando = "Select * from cliente"
        adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion.conexion)
        data = New DataSet
        adapter.Fill(data)
        cmbcliente.DataSource = data.Tables(0)
        cmbcliente.DisplayMember = "nombre"
        cmbcliente.ValueMember = "id"

        strcomando = "Select * from empleado"
        adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion.conexion)
        data = New DataSet
        adapter.Fill(data)
        cmbempleado.DataSource = data.Tables(0)
        cmbempleado.DisplayMember = "Nombre"
        cmbempleado.ValueMember = "Id"


        strcomando = "Select * from producto"
        adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion.conexion)
        data = New DataSet
        adapter.Fill(data)
        cmbproducto.DataSource = data.Tables(0)
        cmbproducto.DisplayMember = "nombre"
        cmbproducto.ValueMember = "id"

        strcomando = "Select * from servicios"
        adapter = New System.Data.SqlClient.SqlDataAdapter(strcomando, conexion.conexion)
        data = New DataSet
        adapter.Fill(data)
        cmbservicio.DataSource = data.Tables(0)
        cmbservicio.DisplayMember = "nombre"
        cmbservicio.ValueMember = "id"




    End Sub

    Private Sub cmbproducto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbproducto.SelectedIndexChanged
        Dim conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-HT00A5J \ SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True")
        Dim datpro As String = "select * from producto where nombre='" + cmbproducto.Text + "'"

        Dim cmb As New SqlCommand(datpro, conexion)
        conexion.Open()
        Dim leer As SqlDataReader = cmb.ExecuteReader


        If leer.Read = True Then
            txtprecio1.Text = leer("precio").ToString

        Else
            txtprecio1.Text = ""

        End If
        conexion.Close()
    End Sub

    Private Sub cmbservicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbservicio.SelectedIndexChanged
        Dim conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-HT00A5J \ SQLEXPRESS;Initial Catalog=proyecto;Integrated Security=True")
        Dim datpro As String = "select * from servicios where nombre='" + cmbservicio.Text + "'"

        Dim cmb As New SqlCommand(datpro, conexion)
        conexion.Open()
        Dim leer As SqlDataReader = cmb.ExecuteReader


        If leer.Read = True Then
            txtprecio2.Text = leer("precio").ToString

        Else
            txtprecio2.Text = ""

        End If
        conexion.Close()
    End Sub

    Private Sub cmbpagos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpagos.SelectedIndexChanged
        Dim descuentro As Double
        Select Case cmbpagos.SelectedIndex
            Case 0
                descuentro = 0
                txtdescuento.Text = Convert.ToString(FormatNumber(descuentro, 2))
            Case 1
                descuentro = 20
                txtdescuento.Text = Convert.ToString(FormatNumber(descuentro, 2))

        End Select
    End Sub


End Class
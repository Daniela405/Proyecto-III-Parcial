Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Text
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= localhost\SQLEXPRESS;Initial Catalog=proyecto; Integrated Security=True")
    'Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader
    Public comando As SqlCommandBuilder

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function agregarUsuario(idUsuario As Integer, nombre As String, apellido As String, userName As String,
                                  psw As String, correo As String, rol As String, estado As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("agregarUsuarios", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@id", idUsuario)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellido", apellido)
            cmb.Parameters.AddWithValue("@usuario", userName)
            cmb.Parameters.AddWithValue("@contraseña", psw)
            cmb.Parameters.AddWithValue("@correo", correo)
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@estado", estado)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function eliminarUsuarios(idUsuario As Integer, rol As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@id", idUsuario)
            cmb.Parameters.AddWithValue("@rol", rol)
            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try



    End Function

    Public Function Eliminar(id As Integer, rol As String) As Boolean
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarUsuario", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@rol", rol)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function


    Public Sub consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        comando = New SqlCommandBuilder(da)

        da.Fill(ds, tabla)

    End Sub
    Public Sub consultaEmpleado(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        comando = New SqlCommandBuilder(da)

        da.Fill(ds, tabla)

    End Sub

    Public Function modificar(id As Integer, nombre As String, apellido As String, usuario As String, contraseña As String, correo As String, rol As Char, estado As Char)

        Try
            conexion.Open()
            cmb = New SqlCommand("actualizarUsuario", conexion)
            cmb.CommandType = CommandType.StoredProcedure


            cmb.Parameters.AddWithValue("@id", id)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@apellido", apellido)
            cmb.Parameters.AddWithValue("@usuario", usuario)
            cmb.Parameters.AddWithValue("@contraseña", contraseña)
            cmb.Parameters.AddWithValue("@correo", correo)
            cmb.Parameters.AddWithValue("@rol", rol)
            cmb.Parameters.AddWithValue("@estado", estado)

            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function consultar(id As Integer)

        Try
            conexion.Open()
            cmb = New SqlCommand("consultarUsuarios", conexion)
            cmb.CommandType = CommandType.StoredProcedure


            cmb.Parameters.AddWithValue("@id", id)

            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


    Public Function BuscarUsuario(userName As String)

        Try
            conexion.Open()
            cmb = New SqlCommand("buscarUser", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombreUsuario", userName)

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function



    'funciones para agregar en productos ''


    Public Function agregarProductos(id As Integer, codigobarra As String, tipoproducto As String, nombre As String,
                               precio As Decimal, cantidad As Integer, caracteristica As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("agregarProductos", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@id", id)
            cmb.Parameters.AddWithValue("@codigobarra", codigobarra)
            cmb.Parameters.AddWithValue("@tipoproducto", tipoproducto)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@precio", precio)
            cmb.Parameters.AddWithValue("@cantidad", cantidad)
            cmb.Parameters.AddWithValue("@caracteristica", caracteristica)


            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function



    ''modificar productos
    Public Function modificarProducto(id As Integer, codigobarra As String, tipoproducto As String, nombre As String,
                               precio As Decimal, cantidad As Integer, caracteristica As String)

        Try
            conexion.Open()
            cmb = New SqlCommand("actualizarProducto ", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Parameters.AddWithValue("@id", id)
            cmb.Parameters.AddWithValue("@codigobarra", codigobarra)
            cmb.Parameters.AddWithValue("@tipoproducto", tipoproducto)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@precio", precio)
            cmb.Parameters.AddWithValue("@cantidad", cantidad)
            cmb.Parameters.AddWithValue("@caracteristica", caracteristica)


            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function


    '' funcion para buscar productos
    Public Function BuscarProducto(nombreproducto As String)

        Try
            conexion.Open()
            cmb = New SqlCommand("buscarProduct", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", nombreproducto)

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function
    ''funcio pa buscar en productos
    Public Function BuscarTipoProducto(tipo As String)

        Try
            conexion.Open()
            cmb = New SqlCommand("buscarProduct", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", tipo)

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function EliminarProducto(id As Integer)
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarProducto", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@id", id)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function
    Public Function agregarEmpleado(Id As Integer, Identidad As String, Nombre As String, Apellido As String, ByVal NombreUsuario As String, Edad As Integer, Sexo As String, Telefono As Integer, Correo As String, Cargo As String, Estado As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("agregarEmpleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure

            cmb.Parameters.AddWithValue("@Id", Id)
            cmb.Parameters.AddWithValue("@Identidad", Identidad)
            cmb.Parameters.AddWithValue("@Nombre", Nombre)
            cmb.Parameters.AddWithValue("@Apellido", Apellido)
            cmb.Parameters.AddWithValue("@NombreUsuario", NombreUsuario)
            cmb.Parameters.AddWithValue("@Edad", Edad)
            cmb.Parameters.AddWithValue("@Sexo", Sexo)
            cmb.Parameters.AddWithValue("@Telefono", Telefono)
            cmb.Parameters.AddWithValue("@Correo", Correo)
            cmb.Parameters.AddWithValue("@Cargo", Cargo)
            cmb.Parameters.AddWithValue("@Estado", Estado)

            If cmb.ExecuteNonQuery Then

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function actualizarEmpleado(Id As Integer, Identidad As String, Nombre As String, Apellido As String, ByVal NombreUsuario As String, Edad As Integer, Sexo As String, Telefono As Integer, Correo As String, Cargo As String, Estado As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("actualizarEmpleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@Id", Id)
            cmb.Parameters.AddWithValue("@Identidad", Identidad)
            cmb.Parameters.AddWithValue("@Nombre", Nombre)
            cmb.Parameters.AddWithValue("@Apellido", Apellido)
            cmb.Parameters.AddWithValue("@NombreUsuario", NombreUsuario)
            cmb.Parameters.AddWithValue("@Edad", Edad)
            cmb.Parameters.AddWithValue("@Sexo", Sexo)
            cmb.Parameters.AddWithValue("@Telefono", Telefono)
            cmb.Parameters.AddWithValue("@Correo", Correo)
            cmb.Parameters.AddWithValue("@Cargo", Cargo)
            cmb.Parameters.AddWithValue("@Estado", Estado)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function eliminarEmpleados(ByVal Id As Integer)
        Try
            conexion.Open()
            Dim cmd As New SqlCommand("eliminarEmpleados", conexion)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Id", Id)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()

        End Try

    End Function

    Public Function buscarEmpleado(Nombre As String)

        Try
            conexion.Open()
            cmb = New SqlCommand("buscarEmpleado", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@Nombre", Nombre)

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Function consultaEmpleado(ByVal Identidad As String)

        Dim cmd As SqlCommand = conexion.CreateCommand()

        cmd.CommandText = ("SELECT Identidad from empleado Where empleado.Identidad = '" & Identidad & "'")

        conexion.Open()

        Dim numReg As Integer = CInt(cmd.ExecuteScalar())

        If numReg > 0 Then
            conexion.Close()
            Return 1

        Else
            conexion.Close()
            Return 2

        End If
    End Function

    Function comprobarExistenciaIdentidadEm(ByVal Identidad As String)

        Dim cmd As SqlCommand = conexion.CreateCommand()

        cmd.CommandText = ("SELECT Id from empleado WHERE empleado.Identidad = '" & Identidad & "'")

        conexion.Open()

        Dim numReg As Integer = CInt(cmd.ExecuteScalar())

        If numReg > 0 Then
            conexion.Close()
            Return 1

        Else
            conexion.Close()
            Return 2

        End If
    End Function
    Function retornarUltimoEmpleado()
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT MAX(Id) FROM empleado")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Public Function insertarServicio(id As Integer, tiposervicio As String, nombre As String, precio As Double, estado As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("insertarServicio", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@id", id)
            cmb.Parameters.AddWithValue("@tiposervicio", tiposervicio)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@precio", precio)
            cmb.Parameters.AddWithValue("@estado", estado)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()

        End Try
    End Function

    Public Function eliminarServicio(id As Integer, estado As String)
        Try
            conexion.Open()
            cmb = New SqlCommand("eliminarServicios", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@id", id)
            cmb.Parameters.AddWithValue("@estado", estado)

            If cmb.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function consultaServicios()
        Try
            conexion.Open()

            cmb = New SqlCommand("consultarServicios", conexion)

            cmb.CommandType = CommandType.StoredProcedure

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
                conexion.Close()
            End If
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function modificarServicio(id As Integer, tiposervicio As String, nombre As String, precio As Double)
        Try
            conexion.Open()
            cmb = New SqlCommand("actualizarServicios", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@id", id)
            cmb.Parameters.AddWithValue("@tiposervicio", tiposervicio)
            cmb.Parameters.AddWithValue("@nombre", nombre)
            cmb.Parameters.AddWithValue("@precio", precio)

            If cmb.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function buscarServicio(nombre As String)

        Try
            conexion.Open()
            cmb = New SqlCommand("buscarServicio", conexion)
            cmb.CommandType = CommandType.StoredProcedure
            cmb.Parameters.AddWithValue("@nombre", nombre)

            If cmb.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmb)
                da.Fill(dt)
                Return dt
                conexion.Close()
            Else
                Return Nothing
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

End Class
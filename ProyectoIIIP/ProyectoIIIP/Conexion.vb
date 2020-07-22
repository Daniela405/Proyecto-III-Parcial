Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Text
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-LGDBE5Q\SQLEXPRESS;Initial Catalog=proyecto; Integrated Security=True")
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

End Class
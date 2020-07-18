Imports System.Data.SqlClient
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-HT00A5J \ SQLEXPRESS;Initial Catalog=proyecto; Integrated Security=True")
    'Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmb As SqlCommand
    Public dr As SqlDataReader

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
End Class
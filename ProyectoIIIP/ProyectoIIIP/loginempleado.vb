Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Security.Cryptography
Imports System.Text
Public Class loginempleado
    Public cmb As SqlCommand

    Dim conexion As Conexion = New Conexion()
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then

            Me.Hide()
        End If
    End Sub

    Private Sub txtusuario_Validating(sender As Object, e As CancelEventArgs) Handles txtusuario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub


    Private Sub txtcontraseña_Validating(sender As Object, e As CancelEventArgs) Handles txtcontraseña.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtusuario_MouseHover(sender As Object, e As EventArgs) Handles txtusuario.MouseHover
        tmensaje.SetToolTip(txtusuario, "Ingrese su nombre de usuario")
        tmensaje.ToolTipTitle = "Nombre de usuario"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtcontraseña_MouseHover(sender As Object, e As EventArgs) Handles txtcontraseña.MouseHover
        tmensaje.SetToolTip(txtcontraseña, "Ingrese su contraseña")
        tmensaje.ToolTipTitle = "Contraseña"
        tmensaje.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub loginempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    Private Sub ingresarMenu()
        Dim userName, psw As String
        userName = txtusuario.Text
        psw = txtcontraseña.Text
        Try
            If conexion.validarUsuario(userName, psw) Then
                MsgBox("Correcto")
                menuempleado.Show()
                Me.Hide()
            Else
                MsgBox("Usuario/Contraseña invalido")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub




    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresarMenu()

    End Sub
End Class
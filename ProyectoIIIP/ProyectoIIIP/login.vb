Imports System.ComponentModel
Imports System.Runtime.InteropServices

Public Class login
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If txtusuario.Text = "Admin" And txtcontraseña.Text = "root" Then
                Dim formwelcome As New Bienvenida()
                formwelcome.ShowDialog()
                menus.Show()
                principal.Hide()
                Me.Close()
            Else
                MessageBox.Show("Usuario o contraseña incorrecta")
            End If

        Catch ex As Exception
            MessageBox.Show("Usuario o contraseña incorrecta")
        End Try

        txtcontraseña.Clear()
        txtusuario.Clear()
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

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub
End Class
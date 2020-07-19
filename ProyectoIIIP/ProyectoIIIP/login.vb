Public Class login
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If txtusuario.Text = "Admin" And txtcontraseña.Text = "root" Then

                menus.Show()
            Else
                MessageBox.Show("Usuario o contraseña incorrecta")

            End If
        Catch ex As Exception
            MessageBox.Show("Usuario o contraseña incorrecta")
        End Try

        txtcontraseña.Clear()
        txtusuario.Clear()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then

            Me.Hide()
        End If
    End Sub
End Class
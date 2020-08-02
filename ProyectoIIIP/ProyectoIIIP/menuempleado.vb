Public Class menuempleado
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Cliente.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ventas.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then

            Me.Hide()
        End If
    End Sub

    Private currentForm As Form = Nothing
    Private Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub
    Private Sub btnClieente_Click(sender As Object, e As EventArgs) Handles btnClieente.Click
        openChildForm(New Cliente())
        'hideSubMenu()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        openChildForm(New ventas())
        'hideSubMenu()
    End Sub

    Private Sub panelEncabezado_Paint(sender As Object, e As PaintEventArgs) Handles panelEncabezado.Paint

    End Sub
End Class
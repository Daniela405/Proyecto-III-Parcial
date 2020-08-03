Imports System.Runtime.InteropServices
Public Class menus
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub panelEncabezado_MouseMove(sender As Object, e As MouseEventArgs) Handles panelEncabezado.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub ReportesProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        usuario.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        empleado.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Cliente.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        producto.Show()
    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        servicios.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs)
        proveedor.Show()
    End Sub


    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            login.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ventas.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea finalizar?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            principal.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs)

        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False

        Me.WindowState = FormWindowState.Normal
    End Sub
    Private Sub hideSubMenu()
        subMenuReporte.Visible = False
    End Sub
    Private Sub showSubmenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        openChildForm(New usuario())
        hideSubMenu()
    End Sub

    Private Sub menus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubMenu()
    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        showSubmenu(subMenuReporte)
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

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        openChildForm(New empleado())
        hideSubMenu()
    End Sub

    Private Sub btnClieente_Click(sender As Object, e As EventArgs) Handles btnClieente.Click
        openChildForm(New Cliente())
        hideSubMenu()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        openChildForm(New producto())
        hideSubMenu()
    End Sub

    Private Sub btnServicios_Click(sender As Object, e As EventArgs) Handles btnServicios.Click
        openChildForm(New servicios())
        hideSubMenu()
    End Sub

    Private Sub btnProveedores_Click(sender As Object, e As EventArgs) Handles btnProveedores.Click
        openChildForm(New proveedor())
        hideSubMenu()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        openChildForm(New ventas())
        hideSubMenu()
    End Sub

    Private Sub PanelChildForm_Paint(sender As Object, e As PaintEventArgs) Handles PanelChildForm.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Me.Hide()
        principal.Show()

        Label5.Text = Label5.ForeColor.B
    End Sub
End Class
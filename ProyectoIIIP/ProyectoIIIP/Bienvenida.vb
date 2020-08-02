Public Class Bienvenida
    Private Sub TIEMPO_Tick(sender As Object, e As EventArgs) Handles TIEMPO.Tick
        Progress.Value += 1
        Progress.Text = Progress.Value.ToString()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If Progress.Value = 100 Then
            TIEMPO.Stop()
            TIEMPO2.Start()
        End If
    End Sub

    Private Sub TIEMPO2_Tick(sender As Object, e As EventArgs) Handles TIEMPO2.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            TIEMPO2.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub Bienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Progress.Value = 0
        Me.Opacity = 0 'Iniciamos la opacidad en 0'
        TIEMPO.Start() 'Iniciamos el temporizador 1'
    End Sub

    Private Sub Progress_Click(sender As Object, e As EventArgs) Handles Progress.Click

    End Sub
End Class
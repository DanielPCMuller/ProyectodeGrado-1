Public Class CargaSistema
    Dim Contador As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CargaSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 20
        Timer1.Enabled = True
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Contador < 100 Then
            ProgressBar1.Value = Contador
            Contador = Contador + 1
        Else
            Timer1.Enabled = False
            Inicio_Sesion.Show()
            Hide()
        End If
    End Sub
End Class
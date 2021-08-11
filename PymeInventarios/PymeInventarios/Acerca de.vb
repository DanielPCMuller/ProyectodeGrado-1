Public Class Acerca_de
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Acerca_de_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Panel_de_Control.Show()
    End Sub
End Class
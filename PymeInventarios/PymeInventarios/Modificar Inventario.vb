Public Class Modificar_Inventario
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel_de_Control.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text=""
        TXT2.Text = ""
        TXT3.Text=""
        TXT4.Text=""
        TXT5.Text=""
        TXT6.Text=""
        TXT7.Text = ""
        TXT8.Text = ""
    End Sub
End Class
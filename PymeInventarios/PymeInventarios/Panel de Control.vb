
Public Class Panel_de_Control
    Private Calculadora As Process

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Inicio_Sesion.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Inventario.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Hide()
        Ordenes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Ventas.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
        Consulta_Inventarios.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Calculadora = Process.Start("calc.exe")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Hide()
        Clientes.Show()
    End Sub

    Private Sub AcercaDeMyEasyManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeMyEasyManageToolStripMenuItem.Click
        Hide()
        Acerca_de.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Hide()
        Egresos.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Hide()
        Reportes.Show()
    End Sub

    Private Sub Invetario_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Inicio_Sesion.Show()
    End Sub
End Class
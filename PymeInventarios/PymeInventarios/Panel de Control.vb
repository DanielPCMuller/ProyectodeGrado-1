Public Class Panel_de_Control
    Private Calculadora As Process
    Private Sub Panel_de_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Inicio_Sesion.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Inventario.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
        Ordenes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Ventas.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        Consulta_Inventarios.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Calculadora = Process.Start("calc.exe")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Close()
        Clientes.Show()
    End Sub

    Private Sub AcercaDeMyEasyManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeMyEasyManageToolStripMenuItem.Click
        Close()
        Acerca_de.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
        Egresos.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
        Reportes.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
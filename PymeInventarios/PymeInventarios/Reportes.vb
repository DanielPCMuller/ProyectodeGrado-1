Public Class Reportes
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        Reporte_Ventas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Reporte_Egresos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        Reporte_Ordenes.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Reporte_Productos.Show()
    End Sub
End Class
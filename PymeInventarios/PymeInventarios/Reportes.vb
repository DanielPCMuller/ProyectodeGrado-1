Public Class Reportes
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
        'Reporte_Ventas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Reporte_Egresos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Reporte_Ordenes_Compra.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Hide()
        'Reporte_Productos.Show()
    End Sub

    Private Sub Reportes_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Panel_de_Control.Show()

    End Sub
End Class
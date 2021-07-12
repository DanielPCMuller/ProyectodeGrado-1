Imports MySql.Data.MySqlClient
Public Class Eliminar_Productos
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TXT1.Text = "" Then
            MsgBox("Inserte el Código de Producto que se va a Eliminar")
        Else
            Proceso = New MySqlCommand("Delete From inventarios where Codigo_Articulo=" & TXT1.Text & "", Conexion)
            Proceso.ExecuteNonQuery()
            TXT1.Focus()
            MsgBox("Producto Eliminado")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Consulta_Inventarios.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Eliminar_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=eDvAECFNbE; password='f5BSe5QKdb'; database=eDvAECFNbE"
            Conexion.Open()
            MsgBox("Conexión Exitosa Con Base de Datos")
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Consultar el Inventario")
            Consulta_Inventarios.Show()
        End Try
    End Sub
End Class
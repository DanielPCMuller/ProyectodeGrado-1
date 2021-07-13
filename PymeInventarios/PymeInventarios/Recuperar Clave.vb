Imports MySql.Data.MySqlClient
Public Class Recuperar_Clave
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Inicio_Sesion.Show()
    End Sub

    Private Sub Recuperar_Clave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()
            MsgBox("Conexión Exitosa Con Base de Datos")
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Consultar el Inventario")
            Inicio_Sesion.Show()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TXT1.Text = "" Or TXT2.Text = "" Then
            MsgBox("Ingrese los Datos Para Recuperar Su Contraseña")
        Else
            Proceso = New MySqlCommand("Update usuarios Set Clave='" & TXT2.Text & "' where Identificacion=" & TXT1.Text & "", Conexion)
            Proceso.ExecuteNonQuery()
            TXT1.Focus()
            MsgBox("Clave Recuperada")
            Close()
            Inicio_Sesion.Show()
        End If
    End Sub
End Class
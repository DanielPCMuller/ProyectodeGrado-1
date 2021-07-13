Imports MySql.Data.MySqlClient
Public Class Modificar_Inventario
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Precio_Compra As Integer
    Dim Precio_Venta As Integer
    Dim Utilidad As Integer
    Dim UtilidadPor As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Consulta_Inventarios.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""
        TXT6.Text = ""
        TXT7.Text = ""
        TXT8.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TXT1.Text & TXT2.Text & TXT3.Text & TXT4.Text & TXT5.Text & TXT6.Text & TXT7.Text & TXT8.Text = "" Then
            MsgBox("Ingrese los Datos del Producto Para Actualizar")
            TXT1.Focus()
        Else
            Precio_Compra = TXT5.Text
            UtilidadPor = TXT6.Text
            Utilidad = Precio_Compra * UtilidadPor / 100
            Precio_Venta = Precio_Compra + Utilidad
            TXT7.Text = Precio_Venta
            TXT8.Text = Utilidad
            Proceso = New MySqlCommand("Update inventarios Set Nombre_Articulo='" & TXT2.Text & "', Marca_Articulo='" & TXT3.Text & "', Cantidad='" & TXT4.Text & "', Precio_Compra='" & TXT5.Text & "', Precio_Venta='" & TXT7.Text & "', Utilidad='" & TXT8.Text & "' where Codigo_Articulo=" & TXT1.Text & "", Conexion)
            Proceso.ExecuteNonQuery()
            TXT1.Focus()
            MsgBox("Producto Actualizado")
        End If
    End Sub

    Private Sub Modificar_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()
            MsgBox("Conexión Exitosa Con Base de Datos")
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Actualizar el Inventario")
            Inicio_Sesion.Show()
        End Try
    End Sub

    Private Sub TXT7_TextChanged(sender As Object, e As EventArgs) Handles TXT5.TextChanged

    End Sub
End Class
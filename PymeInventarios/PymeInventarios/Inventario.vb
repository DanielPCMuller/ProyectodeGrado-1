Imports MySql.Data.MySqlClient
Public Class Inventario
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Precio_Compra As Integer
    Dim Precio_Venta As Integer
    Dim Utilidad As Integer
    Dim UtilidadPor As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""
        TXT6.Text = ""
        TXT7.Text = ""
        TXT8.Text = ""
        TXT9.Text = ""
        TXT10.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=eDvAECFNbE; password='f5BSe5QKdb'; database=eDvAECFNbE"
            Conexion.Open()
            MsgBox("Conexión Exitosa Con Base de Datos, Listo Para Ingresar Productos")
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Ingresar Productos")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TXT5.Text = "" Then
            MsgBox("Inserte Los Datos Requeridos")
            Panel_de_Control.Show()
        End If
        If TXT5.Text >= 0 Then
            Precio_Compra = TXT5.Text
            UtilidadPor = TXT10.Text
            Utilidad = Precio_Compra * UtilidadPor / 100
            Precio_Venta = Precio_Compra + Utilidad
            TXT6.Text = Precio_Venta
            TXT9.Text = Utilidad
        End If
        If TXT1.Text & TXT2.Text & TXT3.Text & TXT4.Text & TXT5.Text & TXT6.Text & TXT7.Text & TXT8.Text & TXT9.Text = "" Then
            MsgBox("Inserte Los Datos Requeridos")
        End If
        Try
            Proceso = New MySqlCommand("Insert Into inventarios(Codigo_Articulo, Nombre_Articulo, Marca_Articulo, Empresa_Pedido, Fecha_Compra, Cantidad, Precio_Compra, Precio_Venta, Utilidad)" & Chr(13) & "Values(@Codigo_Articulo, @Nombre_Articulo, @Marca_Articulo, @Empresa_Pedido, @Fecha_Compra, @Cantidad, @Precio_Compra, @Precio_Venta, @Utilidad)", Conexion)
            Proceso.Parameters.AddWithValue("@Codigo_Articulo", TXT1.Text)
            Proceso.Parameters.AddWithValue("@Nombre_Articulo", TXT2.Text)
            Proceso.Parameters.AddWithValue("@Marca_Articulo", TXT8.Text)
            Proceso.Parameters.AddWithValue("@Empresa_Pedido", TXT3.Text)
            Proceso.Parameters.AddWithValue("@Fecha_Compra", TXT7.Text)
            Proceso.Parameters.AddWithValue("@Cantidad", TXT4.Text)
            Proceso.Parameters.AddWithValue("@Precio_Compra", TXT5.Text)
            Proceso.Parameters.AddWithValue("@Precio_Venta", TXT6.Text)
            Proceso.Parameters.AddWithValue("@Utilidad", TXT9.Text)
            Proceso.ExecuteNonQuery()
            TXT1.Focus()
            MsgBox("Producto Registrado")
        Catch ex As Exception
            MsgBox("Error al Registrar el Producto")
            Close()
            Panel_de_Control.Show()
        End Try
    End Sub
End Class
Imports MySql.Data.MySqlClient
Public Class Ordenes
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""
    End Sub

    Private Sub Ordenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Ingresar Productos")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim FormatoFecha As Date
        Dim NuevaFecha As Date

        If TXT1.Text = "" Or TXT2.Text = "" Or TXT3.Text = "" Or TXT4.Text = "" Or TXT5.Text = "" Then
            MsgBox("Inserte los Datos de la Orden")
            TXT1.Focus()
        Else
            Try
                Proceso = New MySqlCommand("Insert Into ordenes(Numero_Pedido, Articulos_Solicitados, Fecha_Pedido, Empresa_Pedido, Cantidad, Precio_Compra)" & Chr(13) & "Values(@Numero_Pedido, @Articulos_Solicitados, @Fecha_Pedido, @Empresa_Pedido, @Cantidad, @Precio_Compra)", Conexion)
                Proceso.Parameters.AddWithValue("@Numero_Pedido", TXT1.Text)
                Proceso.Parameters.AddWithValue("@Articulos_Solicitados", TXT2.Text)
                Proceso.Parameters.AddWithValue("@Fecha_Pedido", DateTimePicker1.Text)
                Proceso.Parameters.AddWithValue("@Empresa_Pedido", TXT3.Text)
                Proceso.Parameters.AddWithValue("@Cantidad", TXT4.Text)
                Proceso.Parameters.AddWithValue("@Precio_Compra", TXT5.Text)
                FormatoFecha = DateTimePicker1.Text
                NuevaFecha = Format(FormatoFecha, "yyyy/MM/dd")
                Proceso.ExecuteNonQuery()
                MsgBox("Órden de Compra Registrada y Creada Correctamente")
                TXT1.Text = ""
                TXT2.Text = ""
                TXT3.Text = ""
                TXT4.Text = ""
                TXT5.Text = ""
                TXT1.Focus()
            Catch ex As Exception
                MsgBox("Error En Registrar y Crear la Orden de Compra")
                Close()
                Panel_de_Control.Show()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        Consultar_Orden.Show()
    End Sub


End Class
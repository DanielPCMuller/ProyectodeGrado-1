Imports MySql.Data.MySqlClient
Public Class Inventario
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Proceso2 As New MySqlCommand
    Dim Precio_Compra As Double
    Dim Precio_Venta As Double
    Dim Utilidad As Integer
    Dim UtilidadPorcentaje As Integer
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CBO1.Text = ""
        TXT3.Text = ""
        TXT1.Text = ""
        TXT2.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""

        TXT2.Enabled = False
        TXT4.Enabled = False
        TXT5.Enabled = False

        DataGridView1.Columns.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False

        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()
            Dim Consulta As String
            Consulta = "SELECT Nombre_Producto From Productos"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("Productos")
            Adaptador.Fill(Datos.Tables("Productos"))
            CBO1.DataSource = Datos.Tables("Productos")
            CBO1.ValueMember = "Nombre_Producto"
            Conexion.Close()
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Ingresar Productos")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click








        ' If ComboBox1.Text & ComboBox1.Text& TXT3.Text & TXT2.Text & TXT5.Text = "" Then
        'MsgBox("Inserte Los Datos Requeridos")
        'End If
        'Try
        'Conexion.Open()
        'Proceso2 = New MySqlCommand("Insert Into inventarios(Codigo_Articulo, Nombre_Articulo, Marca_Articulo, Empresa_Pedido, Fecha_Compra, Cantidad, Precio_Compra, Precio_Venta, Utilidad)" & Chr(13) & "Values(@Codigo_Articulo, @Nombre_Articulo, @Marca_Articulo, @Empresa_Pedido, @Fecha_Compra, @Cantidad, @Precio_Compra, @Precio_Venta, @Utilidad)", Conexion)
        'Proceso2.Parameters.AddWithValue("@Codigo_Articulo", TXT1.Text)

        'Proceso2.ExecuteNonQuery()
        'Conexion.Close()
        'TXT1.Focus()
        'MsgBox("Producto Registrado")

        'Catch ex As Exception
        'MsgBox("Error al Registrar el Producto")
        'Close()
        'Panel_de_Control.Show()
        'End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TXT1.Text = "" Or TXT3.Text = "" Then
            MsgBox("Inserte Los Datos Requeridos")
            TXT1.Focus()
        End If

        Conexion.Open()
        Proceso = New MySqlCommand("SELECT a.Precio_Compra FROM Productos_Pedido a JOIN Productos b on a.Productos_ID_Producto = b.ID_Producto WHERE b.Nombre_Producto = '" & CBO1.Text & "'", Conexion)
        Dim Leer As MySqlDataReader = Proceso.ExecuteReader()
        Dim Guardar_Precio As String
        If Leer.Read = True Then
            Guardar_Precio = CStr(Leer(0))
        End If
        Leer.Close()
        Proceso.ExecuteNonQuery()
        Conexion.Close()

        TXT2.Text = Guardar_Precio

        Precio_Compra = TXT2.Text
        UtilidadPorcentaje = TXT3.Text
        Utilidad = Precio_Compra * UtilidadPorcentaje / 100
        Precio_Venta = Precio_Compra + Utilidad
        TXT4.Text = Precio_Venta
        TXT5.Text = Utilidad

        DataGridView1.Rows.Add(CBO1.Text, TXT1.Text, TXT2.Text, TXT3.Text, TXT4.Text, TXT5.Text)

        TXT2.Enabled = True
        TXT4.Enabled = True
        TXT5.Enabled = True

        Button1.Enabled = True

    End Sub

    Private Sub CBO1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO1.SelectedIndexChanged
        TXT1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""

        TXT2.Enabled = False
        TXT4.Enabled = False
        TXT5.Enabled = False
    End Sub

    Private Sub Invetario_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Panel_de_Control.Show()
    End Sub
End Class
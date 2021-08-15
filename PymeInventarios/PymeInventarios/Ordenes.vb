Imports MySql.Data.MySqlClient
Public Class Ordenes
    Dim Conexion As New MySqlConnection
    Dim Conexion2 As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Proceso2 As New MySqlCommand
    Dim Proceso3 As New MySqlCommand
    Dim Proceso4 As New MySqlCommand
    Dim Proceso5 As New MySqlCommand
    Dim Proceso6 As New MySqlCommand
    Dim Proceso7 As New MySqlCommand
    Dim Proceso8 As New MySqlCommand
    Dim Proceso9 As New MySqlCommand
    Dim Proceso10 As New MySqlCommand
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Cantidad As Integer
    Dim Cambio As Boolean = False
    Dim ProductosID As String


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Conexion.Close()
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        CBO1.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""
        TXT6.Text = ""
        TXT7.Text = ""
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub Ordenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AllowUserToAddRows = False
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            Conexion2.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()
            Conexion2.Open()
            Conexion2.Close()
            Dim Consulta As String
            Consulta = "SELECT Codigo_Producto From Productos"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("Productos")
            Adaptador.Fill(Datos.Tables("Productos"))
            CBO1.DataSource = Datos.Tables("Productos")
            CBO1.ValueMember = "Codigo_Producto"
            Conexion.Close()

            TXT1.Text = ""
            CBO1.Text = ""
            TXT3.Text = ""
            TXT4.Text = ""
            TXT5.Text = ""
            TXT6.Text = ""
            TXT7.Text = ""

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Ingresar Productos")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim FormatoFecha As Date
        Dim NuevaFecha As Date
        Dim Precio_Compra As Double
        Dim PedidoID As String
        Dim EmpresaID As String
        Dim Leer As MySqlDataReader

        If TXT1.Text = "" Or CBO1.Text = "" Or TXT3.Text = "" Or TXT5.Text = "" Or TXT6.Text = "" Or TXT7.Text = "" Then
            MsgBox("Inserte los Datos de la Orden")
            TXT1.Focus()

        ElseIf MsgBox("¿Está Seguro Que Desea Registrar la Órden?", MsgBoxStyle.OkCancel) Then

            Try
                Conexion.Open()
                Proceso2 = New MySqlCommand("INSERT INTO Empresa(Nombre_Empresa)" & Chr(13) & "Values(@Nombre_Empresa)", Conexion)
                Proceso2.Parameters.AddWithValue("@Nombre_Empresa", TXT7.Text)
                Proceso2.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                Proceso3 = New MySqlCommand("INSERT INTO Productos(Codigo_Producto, Nombre_Producto, Marca_Producto, Precio_Compra)" & Chr(13) & "Values(@Codigo_Producto, @Nombre_Producto, @Marca_Producto, @Precio_Compra)", Conexion)
                Proceso3.Parameters.AddWithValue("@Codigo_Producto", CBO1.Text)
                Proceso3.Parameters.AddWithValue("@Nombre_Producto", TXT3.Text)
                Proceso3.Parameters.AddWithValue("@Marca_Producto", TXT4.Text)
                Proceso3.Parameters.AddWithValue("@Precio_Compra", TXT6.Text)
                Proceso3.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                Proceso = New MySqlCommand("SELECT ID_Empresa FROM Empresa WHERE Nombre_Empresa ='" & TXT7.Text & "'", Conexion)
                Leer = Proceso.ExecuteReader()
                If Leer.Read = True Then
                    EmpresaID = CStr(Leer(0))
                End If
                Leer.Close()
                Proceso.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                Proceso4 = New MySqlCommand("INSERT INTO Orden_Pedido(Numero_Pedido, Fecha_Pedido, Empresa_ID_Empresa)" & Chr(13) & "Values(@Numero_Pedido, @Fecha_Pedido, @Empresa_ID_Empresa)", Conexion)
                Proceso4.Parameters.AddWithValue("@Numero_Pedido", TXT1.Text)
                FormatoFecha = DateTimePicker1.Text
                NuevaFecha = Format(FormatoFecha, "yyyy/MM/dd")
                Proceso4.Parameters.AddWithValue("@Fecha_Pedido", NuevaFecha)
                Proceso4.Parameters.AddWithValue("@Empresa_ID_Empresa", EmpresaID)
                Proceso4.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                Proceso5 = New MySqlCommand("SELECT ID_Producto FROM Productos WHERE Codigo_Producto ='" & CBO1.Text & "'", Conexion)
                Leer = Proceso5.ExecuteReader()
                If Leer.Read = True Then
                    ProductosID = CStr(Leer(0))
                End If
                Leer.Close()
                Proceso5.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                Proceso6 = New MySqlCommand("SELECT ID_Orden FROM Orden_Pedido WHERE Numero_Pedido ='" & TXT1.Text & "'", Conexion)
                Leer = Proceso6.ExecuteReader()
                If Leer.Read = True Then
                    PedidoID = CStr(Leer(0))
                End If
                Leer.Close()
                Proceso6.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                Proceso7 = New MySqlCommand("INSERT INTO Productos_Pedido(Cantidad, Precio_Compra, Productos_ID_Producto, Orden_Pedido_ID_Orden)" & Chr(13) & "Values(@Cantidad, @Precio_Compra, @Productos_ID_Producto, @Orden_Pedido_ID_Orden)", Conexion)
                Proceso7.Parameters.AddWithValue("@Cantidad", TXT5.Text)
                Precio_Compra = TXT5.Text * TXT6.Text
                Proceso7.Parameters.AddWithValue("@Precio_Compra", Precio_Compra)
                Proceso7.Parameters.AddWithValue("@Productos_ID_Producto", ProductosID)
                Proceso7.Parameters.AddWithValue("@Orden_Pedido_ID_Orden", PedidoID)
                Console.WriteLine(Precio_Compra)
                Proceso7.ExecuteNonQuery()
                Conexion.Close()

                Conexion.Open()
                Proceso8 = New MySqlCommand("INSERT INTO Producto_Empresa(Productos_ID_Producto, Empresa_ID_Empresa)" & Chr(13) & "Values(@Productos_ID_Producto, @Empresa_ID_Empresa)", Conexion)
                Proceso8.Parameters.AddWithValue("@Productos_ID_Producto", ProductosID)
                Proceso8.Parameters.AddWithValue("@Empresa_ID_Empresa", EmpresaID)
                Console.WriteLine(Precio_Compra)
                Proceso8.ExecuteNonQuery()
                Conexion.Close()

                MsgBox("Orden Registrada Correctamente")
                TXT1.Text = ""
                CBO1.Text = ""
                TXT3.Text = ""
                TXT4.Text = ""
                TXT5.Text = ""
                TXT6.Text = ""
                TXT7.Text = ""
                TXT1.Focus()
                CBO1.Enabled = True
                TXT3.Enabled = True
                TXT4.Enabled = True
                TXT5.Enabled = True
                TXT6.Enabled = True
                TXT7.Enabled = True
                DataGridView1.Rows.Clear()
                Button1.Enabled = False
            Catch ex As MySqlException
                Console.WriteLine(ex.Message)
                MsgBox("Error En Registrar y Crear la Orden de Compra")
                Close()
                Panel_de_Control.Show()
            End Try
            Button5.Enabled = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Hide()
        Consultar_Orden.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Precio_Compra As Double

        If TXT1.Text = "" Or CBO1.Text = "" Or TXT3.Text = "" Or TXT5.Text = "" Or TXT6.Text = "" Or TXT7.Text = "" Then
            MsgBox("Inserte los Datos del Producto")
            TXT1.Focus()
        Else
            DataGridView1.Rows.Add(TXT7.Text, CBO1.Text, TXT3.Text, TXT4.Text, DateTimePicker1.Text, TXT5.Text, TXT6.Text)
            Precio_Compra = TXT5.Text * TXT6.Text
            Console.WriteLine(Precio_Compra)
            Button1.Enabled = True
            'TXT1.Text = ""
            CBO1.Enabled = False
            TXT3.Enabled = False
            TXT4.Enabled = False
            TXT5.Enabled = False
            TXT6.Enabled = False
            TXT7.Enabled = False
            'DataGridView1.Rows.Clear()
            Button5.Enabled = False
        End If



    End Sub

    Private Sub Ordenes_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Panel_de_Control.Show()
    End Sub

    Private Sub CBO1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO1.SelectedIndexChanged
        Dim Leer As MySqlDataReader
        Dim Nombre_Empresa As String
        Dim Nombre_Producto As String
        Dim Marca_Producto As String
        Dim Precio_Compra As Double
        If CBO1.Text <> "" Then
            Conexion2.Open()

            Proceso9 = New MySqlCommand("SELECT a.Nombre_Empresa, b.Nombre_Producto, b.Marca_Producto, b.Precio_Compra FROM Productos b JOIN Producto_Empresa c on b.ID_Producto= c.Productos_ID_Producto JOIN Empresa a on a.ID_Empresa = c.Empresa_ID_Empresa WHERE b.Codigo_Producto = '" & CBO1.Text & "'", Conexion2)
            Leer = Proceso9.ExecuteReader()
            If Leer.Read = True Then
                Nombre_Empresa = CStr(Leer(0))
                Nombre_Producto = CStr(Leer(1))
                Marca_Producto = CStr(Leer(2))
                Precio_Compra = CStr(Leer(3))
            End If
            Leer.Close()
            Proceso9.ExecuteNonQuery()
            Conexion2.Close()

            TXT7.Text = Nombre_Empresa
            TXT3.Text = Nombre_Producto
            TXT4.Text = Marca_Producto
            TXT6.Text = Precio_Compra

            If Nombre_Empresa <> "" Then
                Cambio = True
            End If
        End If

        'If Cambio Then
        'Conexion2.Open()

        'Proceso10 = New MySqlCommand("SELECT Cantidad FROM Productos_Pedido WHERE    = '" & CBO1.Text & "'", Conexion2)
        'Leer = Proceso10.ExecuteReader()
        'If Leer.Read = True Then
        'Nombre_Empresa = CStr(Leer(0))
        'Nombre_Producto = CStr(Leer(1))
        'Marca_Producto = CStr(Leer(2))
        'Precio_Compra = CStr(Leer(3))
        'End If
        'Leer.Close()
        'Proceso10.ExecuteNonQuery()
        'Conexion2.Close()
        'End If

    End Sub
End Class
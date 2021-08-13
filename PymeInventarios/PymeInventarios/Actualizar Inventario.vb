Imports MySql.Data.MySqlClient
Public Class Modificar_Inventario
    Dim Conexion As New MySqlConnection
    Dim Proceso1 As New MySqlCommand
    Dim Proceso2 As New MySqlCommand
    Dim Precio_Compra As Integer
    Dim Precio_Venta As Integer
    Dim Utilidad As Integer
    Dim UtilidadPorcentaje As Integer
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Consulta_Inventarios.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If TXT1.Text & TXT2.Text & TXT3.Text & TXT4.Text & TXT5.Text & TXT6.Text & TXT7.Text & TXT8.Text = "" Then
        '    MsgBox("Ingrese los Datos del Producto Para Actualizar")
        '    TXT1.Focus()
        'Else
        '    Precio_Compra = TXT5.Text
        '    'UtilidadPor = TXT6.Text
        '    Utilidad = Precio_Compra * UtilidadPor / 100
        '    Precio_Venta = Precio_Compra + Utilidad
        '    'TXT7.Text = Precio_Venta
        '    'TXT8.Text = Utilidad
        '    'Proceso = New MySqlCommand("Update inventarios Set Nombre_Articulo='" & TXT2.Text & "', Marca_Articulo='" & TXT3.Text & "', Cantidad='" & TXT4.Text & "', Precio_Compra='" & TXT5.Text & "', Precio_Venta='" & TXT7.Text & "', Utilidad='" & TXT8.Text & "' where Codigo_Articulo=" & TXT1.Text & "", Conexion)
        '    'Proceso.ExecuteNonQuery()
        '    'TXT1.Focus()
        '    MsgBox("Producto Actualizado")
        'End If
    End Sub

    Private Sub Modificar_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Actualizar el Inventario")
            Inicio_Sesion.Show()
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Leer As MySqlDataReader

        ' Traemos el precio de compra del producto
        Conexion.Open()
        Proceso1 = New MySqlCommand("SELECT a.Precio_Compra, a.Cantidad FROM Productos_Pedido a JOIN Productos b on a.Productos_ID_Producto = b.ID_Producto WHERE b.Nombre_Producto = '" & CBO1.Text & "'", Conexion)
        Leer = Proceso1.ExecuteReader()
        Dim Guardar_Precio As String
        If Leer.Read = True Then
            Guardar_Precio = CStr(Leer(0))
        End If
        Leer.Close()
        Proceso1.ExecuteNonQuery()
        Conexion.Close()

        ' Traemos el ID del Producto
        Conexion.Open()
        Proceso2 = New MySqlCommand("SELECT Id_Producto FROM Productos WHERE Nombre_Producto = '" & CBO1.Text & "'", Conexion)
        Leer = Proceso2.ExecuteReader()
        Dim Guardar_ID_Producto As String
        If Leer.Read = True Then
            Guardar_ID_Producto = CStr(Leer(0))
        End If
        Leer.Close()
        Proceso2.ExecuteNonQuery()
        Conexion.Close()


        If TXT2.Text <> "" Or TXT3.Text <> "" Then
            TXT1.Text = Guardar_Cantidad
            TXT2.Text = Guardar_Precio

            Precio_Compra = TXT2.Text
            UtilidadPorcentaje = TXT3.Text
            Utilidad = Precio_Compra * UtilidadPorcentaje / 100
            Precio_Venta = Precio_Compra + Utilidad
            TXT3.Text = Precio_Venta
            TXT4.Text = Utilidad
            DataGridView1.Rows.Add(CBO1.Text, TXT1.Text, TXT2.Text, TXT3.Text, TXT3.Text, TXT4.Text, Guardar_ID_Producto)
        Else
            MsgBox("Inserte Los Datos Requeridos")
            CBO1.Focus()
        End If

        TXT2.Enabled = True
        TXT3.Enabled = True
        TXT4.Enabled = True

        Button1.Enabled = True
        CBO1.Focus()
    End Sub


End Class
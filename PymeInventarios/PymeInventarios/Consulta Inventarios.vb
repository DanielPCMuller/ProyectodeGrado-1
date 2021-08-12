Imports MySql.Data.MySqlClient
Public Class Consulta_Inventarios
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Conexion As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        CBO1.Text = ""
        TXT3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Consulta_Inventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

            Dim Consulta As String
            Consulta = "SELECT Marca_Producto From Productos a JOIN Producto_Inventario b on a.ID_Producto = Productos_ID_Producto"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("Productos")
            Adaptador.Fill(Datos.Tables("Productos"))
            CBO1.DataSource = Datos.Tables("Productos")
            CBO1.ValueMember = "Marca_Producto"
            Conexion.Close()

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Consultar el Inventario")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Consulta As String
        Dim Lista As Byte

        If TXT1.Text & CBO1.Text & TXT3.Text = "" Then
            MsgBox("Inserte la Opción de Búsqueda del Producto en Código, Nombre o Marca")
        Else
            If TXT1.Text <> "" Then
                Consulta = "Select * From inventarios Where Codigo_Articulo='" & TXT1.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "inventarios")
                Lista = Datos.Tables("inventarios").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "inventarios"
            End If

            If CBO1.Text <> "" Then
                Consulta = "SELECT Codigo_Producto, Nombre_Producto, Marca_Producto, Precio_Compra 
                            FROM Productos a JOIN Producto_Inventario b on a.ID_Producto = Productos_ID_Producto 
                            WHERE a.Marca_Producto ='" & CBO1.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                'Adaptador.Fill(Datos, "Productos")
                'Lista = Datos.Tables("Productos").Rows.Count
                Datos.Tables.Add("tabla")
                Adaptador.Fill(Datos.Tables("tabla"))
                DataGridView1.DataSource = Datos
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "Productos"
            End If

            If TXT3.Text <> "" Then
                Consulta = "Select * From inventarios Where Nombre_Articulo='" & TXT3.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "inventarios")
                Lista = Datos.Tables("inventarios").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "inventarios"
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Modificar_Inventario.Show()
        Hide()
    End Sub

    Private Sub Consulta_Inventario_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Panel_de_Control.Show()
    End Sub

End Class
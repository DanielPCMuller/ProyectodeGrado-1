Imports MySql.Data.MySqlClient
Public Class Consulta_Inventarios
    Dim Adaptador As New MySqlDataAdapter
    Dim Adaptador2 As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Conexion As New MySqlConnection
    Dim Proceso1 As New MySqlCommand
    Dim Leer As MySqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CBO1.Text = "Seleccione"
        CBO2.Text = "Seleccione"
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
            Consulta = "SELECT DISTINCT Marca_Producto From Productos a JOIN Producto_Inventario b on a.ID_Producto = Productos_ID_Producto"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("Productos")
            Adaptador.Fill(Datos.Tables("Productos"))
            CBO1.DataSource = Datos.Tables("Productos")
            CBO1.ValueMember = "Marca_Producto"
            Conexion.Close()
            CBO1.Text = "Seleccione"

            Conexion.Open()

            Dim Consulta2 As String
            Consulta2 = "SELECT DISTINCT Nombre_Producto From Productos a JOIN Producto_Inventario b on a.ID_Producto = Productos_ID_Producto"
            Adaptador2 = New MySqlDataAdapter(Consulta2, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("Productos")
            Adaptador2.Fill(Datos.Tables("Productos"))
            CBO2.DataSource = Datos.Tables("Productos")
            CBO2.ValueMember = "Nombre_Producto"
            Conexion.Close()
            CBO2.Text = "Seleccione"

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Consultar el Inventario")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Consulta As String
        Dim Lista As Byte

        If CBO1.Text & CBO2.Text = "" Then
            MsgBox("Inserte la Opción de Búsqueda del Producto en Código, Nombre o Marca")
        Else
            Try
                Conexion.Open()
                If CBO1.Text <> "" Then
                    Consulta = "SELECT a.Codigo_Producto, a.Nombre_Producto, a.Marca_Producto, a.Precio_Compra, 
                                        b.Cantidad, b.Porcentaje_Utilidad, b.Utilidad, b.Precio_Venta 
                            FROM Productos a JOIN Producto_Inventario b on a.ID_Producto = Productos_ID_Producto 
                            WHERE a.Marca_Producto ='" & CBO1.Text & "'"
                    'Proceso1 = New MySqlCommand(Consulta, Conexion)
                    Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                    Datos = New DataSet
                    Adaptador.Fill(Datos, "Productos")
                    Lista = Datos.Tables("Productos").Rows.Count
                    'Leer = Proceso1.ExecuteReader()
                    'Leer.Read()

                    'If Leer.HasRows Then
                    '    While Leer.Read()
                    '        DataGridView1.Rows.Add(Leer(0).ToString(), Leer(1).ToString(), Leer(2).ToString(), Leer(3).ToString(),
                    '                               Leer(4).ToString(), Leer(5).ToString(), Leer(6).ToString(), Leer(7).ToString())
                    '    End While
                    'Else
                    '    MsgBox("No se ha encontrado el registro")
                    'End If
                End If
                Conexion.Close()
                If Lista <> 0 Then
                    DataGridView1.DataSource = Datos
                    DataGridView1.DataMember = "Productos"
                End If
            Catch ex As MySqlException
                Console.WriteLine(ex.Message)
                MsgBox("Error en la Base de Datos")
            End Try

            If CBO2.Text <> "" Then
                Consulta = "SELECT a.Codigo_Producto, a.Nombre_Producto, a.Marca_Producto, a.Precio_Compra, 
                                        b.Cantidad, b.Porcentaje_Utilidad, b.Utilidad, b.Precio_Venta 
                            FROM Productos a JOIN Producto_Inventario b on a.ID_Producto = Productos_ID_Producto 
                            WHERE a.Nombre_Producto ='" & CBO2.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "Productos")
                Lista = Datos.Tables("Productos").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "Productos"
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

    Private Sub CBO1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO1.SelectedIndexChanged
        CBO2.Text = ""
        'If CBO1.Text = "Seleccione" Then
        '    CBO2.Enabled = True
        '    CBO2.Text = "Seleccione"
        'Else
        '    CBO2.Enabled = False
        'End If
    End Sub

    Private Sub CBO2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO2.SelectedIndexChanged
        CBO1.Text = ""
        'If CBO2.Text = "" Then
        '    CBO1.Enabled = True
        '    CBO2.Text = "Seleccione"
        'Else
        '    CBO1.Enabled = False
        'End If
    End Sub
End Class
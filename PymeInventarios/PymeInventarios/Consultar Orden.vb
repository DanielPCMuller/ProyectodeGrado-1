Imports MySql.Data.MySqlClient
Public Class Consultar_Orden
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Conexion.Close()
        Close()
        Ordenes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Columns.Clear()
        TXT1.Text = ""
        CBO2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Consulta As String
        Dim Lista As Byte

        If TXT1.Text & CBO2.Text = "" Then
            MsgBox("Inserte la Opción de Búsqueda de la Orden en Número Pedido o Empresa")
        Else
            If TXT1.Text <> "" Then
                Conexion.Open()
                Consulta = "SELECT a.Numero_Pedido, a. Fecha_Pedido, b.Cantidad, b.Precio_Compra, c.Nombre_Empresa, d.Nombre_Producto 
                            FROM Productos_Pedido b 
                            INNER JOIN Orden_Pedido a on a.ID_Orden=Orden_Pedido_ID_Orden 
                            JOIN Empresa c on a.Empresa_ID_Empresa = c.ID_Empresa
                            JOIN Productos d on b.Productos_ID_Producto = d.ID_Producto
                            WHERE a.Numero_Pedido ='" & TXT1.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "Productos_Pedido")
                Lista = Datos.Tables("Productos_Pedido").Rows.Count
                Conexion.Close()
            End If

            If Lista <> 0 Then

                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "Productos_Pedido"

                Dim Columna1 As DataGridViewColumn = DataGridView1.Columns(1)
                Columna1.DefaultCellStyle.WrapMode = DataGridViewTriState.True

                DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                Dim Columna2 As DataGridViewColumn = DataGridView1.Columns(4)
                Columna2.DefaultCellStyle.WrapMode = DataGridViewTriState.True

            End If




            If CBO2.Text <> "" Then
                Conexion.Open()
                Consulta = "SELECT a.Numero_Pedido, a. Fecha_Pedido, b.Cantidad, b.Precio_Compra, c.Nombre_Empresa, d.Nombre_Producto 
                            FROM Productos_Pedido b 
                            INNER JOIN Orden_Pedido a on a.ID_Orden=Orden_Pedido_ID_Orden 
                            JOIN Empresa c on a.Empresa_ID_Empresa = c.ID_Empresa
                            JOIN Productos d on b.Productos_ID_Producto = d.ID_Producto
                            WHERE c.Nombre_Empresa ='" & CBO2.Text & "'"

                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "Productos_Pedido")
                Lista = Datos.Tables("Productos_Pedido").Rows.Count
                Conexion.Close()
            End If

            If Lista <> 0 Then

                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "Productos_Pedido"

                Dim Columna1 As DataGridViewColumn = DataGridView1.Columns(1)
                Columna1.DefaultCellStyle.WrapMode = DataGridViewTriState.True

                DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                Dim Columna2 As DataGridViewColumn = DataGridView1.Columns(4)
                Columna2.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                'DataGridView1.Columns.Clear()

            End If

        End If
    End Sub

    Private Sub Consultar_Orden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

            Dim Consulta As String
            Consulta = "SELECT Nombre_Empresa From Empresa"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("Empresa")
            Adaptador.Fill(Datos.Tables("Empresa"))
            CBO2.DataSource = Datos.Tables("Empresa")
            CBO2.ValueMember = "Nombre_Empresa"
            Conexion.Close()
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrán Consultar las Órdenes de Compra")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TXT1.Text = "" Then
            MsgBox("Inserte el Código de Órden de Compra que se va a Eliminar")
        Else
            Proceso = New MySqlCommand("Delete From ordenes where Numero_Pedido=" & TXT1.Text & "", Conexion)
            Proceso.ExecuteNonQuery()
            TXT1.Focus()
            MsgBox("Orden de Compra Eliminada")
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
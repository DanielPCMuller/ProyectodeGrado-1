Imports MySql.Data.MySqlClient
Public Class Consultar_Orden
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Ordenes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Consulta As String
        Dim Lista As Byte

        If TXT1.Text & TXT2.Text = "" Then
            MsgBox("Inserte la Opción de Búsqueda de la Orden en Número Pedido o Empresa")
        Else
            If TXT1.Text <> "" Then
                Consulta = "Select * From ordenes Where Numero_Pedido='" & TXT1.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "ordenes")
                Lista = Datos.Tables("ordenes").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "ordenes"
            End If

            If TXT2.Text <> "" Then
                Consulta = "Select * From ordenes Where Empresa_Pedido='" & TXT2.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "ordenes")
                Lista = Datos.Tables("ordenes").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "ordenes"
            End If
        End If
    End Sub

    Private Sub Consultar_Orden_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()
            MsgBox("Conexión Exitosa Con Base de Datos")
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
End Class
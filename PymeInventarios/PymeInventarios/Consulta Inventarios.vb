Imports MySql.Data.MySqlClient
Public Class Consulta_Inventarios
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Conexion As New MySqlConnection
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Consulta_Inventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Consultar el Inventario")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Consulta As String
        Dim Lista As Byte

        If TXT1.Text & TXT2.Text & TXT3.Text = "" Then
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

            If TXT2.Text <> "" Then
                Consulta = "Select * From inventarios Where Marca_Articulo='" & TXT2.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "inventarios")
                Lista = Datos.Tables("inventarios").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "inventarios"
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

    Private Sub Invetario_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Panel_de_Control.Show()

    End Sub

End Class
Imports MySql.Data.MySqlClient
Public Class Consultar_Clientes
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Conexion.Close()
        Close()
        Clientes.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
        CBO1.Text = ""
        DataGridView1.Columns.Clear()
    End Sub

    Private Sub Consultar_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrán Consultar las Órdenes de Compra")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Columns.Clear()
        TXT1.Text = ""
        TXT2.Text = ""
        CBO1.Text = ""

        Dim Consulta As String
        Dim Lista As Byte

        If TXT1.Text & TXT2.Text & CBO1.Text = "" Then
            MsgBox("Inserte la Opción de Búsqueda del Cliente en Apellido o Identificación")

        Else
            If TXT1.Text <> "" Then
                Consulta = "SELECT a.Nombres, a.Apellidos, a.Tipo_Documento, a.Numero_ID, a.Telefono FROM Persona a INNER JOIN Cliente b on a.ID_Persona= b.Persona_ID_Persona and a.Numero_ID ='" & TXT1.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "Persona")
                Lista = Datos.Tables("Persona").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "Persona"
            End If

            If TXT2.Text <> "" Then
                Consulta = "SELECT a.Nombres, a.Apellidos, a.Tipo_Documento, a.Numero_ID, a.Telefono FROM Persona a INNER JOIN Cliente b on a.ID_Persona= b.Persona_ID_Persona and a.Nombres ='" & TXT2.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "Persona")
                Lista = Datos.Tables("Persona").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "Persona"
            End If

            If CBO1.Text <> "" Then
                Consulta = "SELECT a.Nombres, a.Apellidos, a.Tipo_Documento, a.Numero_ID, a.Telefono FROM Persona a INNER JOIN Cliente b on a.ID_Persona= b.Persona_ID_Persona and a.Tipo_Documento ='" & CBO1.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "Persona")
                Lista = Datos.Tables("Persona").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "Persona"
            End If
        End If
        Conexion.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Consultar_Clientes_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Clientes.Show()
    End Sub
End Class
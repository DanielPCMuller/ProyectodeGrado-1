Imports MySql.Data.MySqlClient
Public Class Consultar_Egresos
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Egresos.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
    End Sub

    Private Sub Consultar_Egresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrán Consultar los Egresos")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Consulta As String
        Dim Lista As Byte

        If TXT1.Text = "" Then
            MsgBox("Inserte el Nombre de la Entidad a la que se Hizo el Pago")
        Else
            If TXT1.Text <> "" Then
                Consulta = "Select * From egresos Where Beneficiario_Pago='" & TXT1.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "egresos")
                Lista = Datos.Tables("egresos").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "egresos"
            End If
        End If
    End Sub
End Class
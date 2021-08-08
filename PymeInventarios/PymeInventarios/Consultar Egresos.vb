Imports MySql.Data.MySqlClient
Public Class Consultar_Egresos
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Egresos.Show()
        Conexion.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CBO1.Text = ""
    End Sub

    Private Sub Consultar_Egresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

            Dim Consulta As String
            Consulta = "Select Nombre_Entidad From Entidad_Prestadora"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("Entidad_Prestadora")
            Adaptador.Fill(Datos.Tables("Entidad_Prestadora"))
            CBO1.DataSource = Datos.Tables("Entidad_Prestadora")
            CBO1.ValueMember = "Nombre_Entidad"
            Conexion.Close()
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrán Consultar los Egresos")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Consulta As String
        Dim Lista As Byte

        If CBO1.Text = "" Then
            MsgBox("Inserte el Nombre de la Entidad a la que se Hizo el Pago")
        Else
            If CBO1.Text <> "" Then
                Consulta = "SELECT a.Factura_Servicio, c.Descripcion, a.Fecha_Pago, a.Concepto_Pago, a.Valor_Pago, b.Nombre_Entidad FROM Egresos a INNER JOIN Entidad_Prestadora b on a.ID_Egreso=b.Egresos_ID_Egreso INNER JOIN Tipo_Pago c on a.Tipo_Pago_ID_Tipo=ID_tipo and b.Nombre_Entidad='" & CBO1.Text & "'"
                Adaptador = New MySqlDataAdapter(Consulta, Conexion)
                Datos = New DataSet
                Adaptador.Fill(Datos, "Egresos")
                Lista = Datos.Tables("Egresos").Rows.Count
            End If

            If Lista <> 0 Then
                DataGridView1.DataSource = Datos
                DataGridView1.DataMember = "Egresos"
            End If
        End If
    End Sub
End Class
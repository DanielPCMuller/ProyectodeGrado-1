Imports MySql.Data.MySqlClient
Public Class Egresos
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
    End Sub

    Private Sub Egresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Ingresar Productos")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TXT1.Text = "" Or TXT2.Text = "" Or TXT3.Text = "" Or TXT4.Text = "" Then
            MsgBox("Inserte los Datos del Egreso")
            TXT1.Focus()
        Else
            Try
                Proceso = New MySqlCommand("Insert Into egresos(Factura_Numero, Tipo_Pago, Beneficiario_Pago, Fecha_Pago, Concepto, Valor_Pago)" & Chr(13) & "Values(@Factura_Numero, @Tipo_Pago, @Beneficiario_Pago, @Fecha_Pago, @Concepto, @Valor_Pago)", Conexion)
                Proceso.Parameters.AddWithValue("@Factura_Numero", TXT1.Text)
                Proceso.Parameters.AddWithValue("@Tipo_Pago", CBO1.Text)
                Proceso.Parameters.AddWithValue("@Beneficiario_Pago", TXT2.Text)
                Proceso.Parameters.AddWithValue("@Fecha_Pago", DateTimePicker1.Text)
                Proceso.Parameters.AddWithValue("@Concepto", TXT3.Text)
                Proceso.Parameters.AddWithValue("@Valor_Pago", TXT4.Text)
                Proceso.ExecuteNonQuery()
                MsgBox("Egreso Registrado y Creado Correctamente")
                TXT1.Text = ""
                TXT2.Text = ""
                TXT3.Text = ""
                TXT4.Text = ""
                TXT1.Focus()
            Catch ex As Exception
                MsgBox("Error En Registrar y Crear el Egreso")
                Close()
                Panel_de_Control.Show()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        Consultar_Egresos.Show()
    End Sub
End Class
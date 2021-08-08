Imports MySql.Data.MySqlClient
Public Class Egresos
    Dim Conexion As New MySqlConnection
    Dim Conexion1 As New MySqlConnection
    Dim Conexion2 As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Proceso1 As New MySqlCommand
    Dim Proceso2 As New MySqlCommand
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
        Dim Datos_Conexion As String = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
        'Dim Datos_Conexion As String = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"'
        Try
            Conexion.ConnectionString = Datos_Conexion
            Conexion.Open()
            Conexion1.ConnectionString = Datos_Conexion
            Conexion1.Open()
            Conexion2.ConnectionString = Datos_Conexion
            Conexion2.Open()
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Ingresar Productos")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormatoFecha As Date
        Dim NuevaFecha As Date
        Dim Referencia As String
        Dim Tipo_Pago As Integer

        If TXT1.Text = "" Or TXT2.Text = "" Or TXT3.Text = "" Or TXT4.Text = "" Then
            MsgBox("Inserte los Datos del Egreso")
            TXT1.Focus()
        Else
            Try
                'Insert a Tabla Egresos'
                Proceso = New MySqlCommand("INSERT INTO Egresos(Factura_Servicio, Fecha_Pago, Concepto_Pago, Valor_Pago, Tipo_Pago_ID_Tipo)" & Chr(13) & "Values(@Factura_Servicio, @Fecha_Pago, @Concepto_Pago, @Valor_Pago, @Tipo_Pago_ID_Tipo)", Conexion)
                Proceso.Parameters.AddWithValue("@Factura_Servicio", TXT1.Text)
                Referencia = CBO1.Text
                'Referencia Númerica a la Tabla Tipo Pago'
                If Referencia = "Factura Servicios Públicos" Then
                    Tipo_Pago = 1

                ElseIf Referencia = "Órden Compra de Productos" Then
                    Tipo_Pago = 2

                ElseIf Referencia = "Deudas Varias" Then
                    Tipo_Pago = 3

                ElseIf Referencia = "Deudas Bancarias" Then
                    Tipo_Pago = 4
                End If

                Proceso.Parameters.AddWithValue("@Tipo_Pago_ID_Tipo", Tipo_Pago)
                Proceso.Parameters.AddWithValue("@Beneficiario_Pago", TXT2.Text)
                FormatoFecha = DateTimePicker1.Text
                NuevaFecha = Format(FormatoFecha, "yyyy/MM/dd")
                Proceso.Parameters.AddWithValue("@Fecha_Pago", NuevaFecha)
                Proceso.Parameters.AddWithValue("@Concepto_Pago", TXT3.Text)
                Proceso.Parameters.AddWithValue("@Valor_Pago", TXT4.Text)
                Proceso.ExecuteNonQuery()

                'Select a la Tabla Egresos'
                Proceso1 = New MySqlCommand("SELECT ID_Egreso FROM Egresos WHERE Factura_Servicio = '" & TXT1.Text & "'", Conexion1)
                Dim Leer As MySqlDataReader = Proceso1.ExecuteReader()
                Dim Guardar_Factura As String
                If Leer.Read = True Then
                    Guardar_Factura = CStr(Leer(0))
                End If
                Leer.Close()
                Proceso1.ExecuteNonQuery()

                'Insert a la Tabla Entidad Prestadora'
                Proceso2 = New MySqlCommand("INSERT INTO Entidad_Prestadora(Nombre_Entidad, Egresos_ID_Egreso) " & Chr(13) & " VALUES (@Nombre_Entidad, @Egresos_ID_Egreso)", Conexion2)
                Proceso2.Parameters.AddWithValue("@Nombre_Entidad", TXT2.Text)
                Proceso2.Parameters.AddWithValue("@Egresos_ID_Egreso", Guardar_Factura)
                Proceso2.ExecuteNonQuery()
                MsgBox("Egreso Registrado Correctamente")
                TXT1.Text = ""
                TXT2.Text = ""
                TXT3.Text = ""
                TXT4.Text = ""
                TXT1.Focus()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
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

Imports MySql.Data.MySqlClient
Public Class Clientes
    Dim Conexion As New MySqlConnection
    Dim Conexion2 As New MySqlConnection
    Dim Conexion3 As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Proceso2 As New MySqlCommand
    Dim Proceso3 As New MySqlCommand

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        TXT2.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""
    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Datos_Conexion As String = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"'
            Conexion.ConnectionString = Datos_Conexion
            Conexion.Open()
            Conexion2.ConnectionString = Datos_Conexion
            Conexion2.Open()
            Conexion3.ConnectionString = Datos_Conexion
            Conexion3.Open()
        Catch ex As System.ArgumentNullException
            Console.WriteLine(ex.Message)
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Crear Un Nuevo Cliente")
            Inicio_Sesion.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormatoFecha As Date
        Dim NuevaFecha As Date
        Try
            Proceso = New MySqlCommand("Insert Into Persona(Nombres, Apellidos, Tipo_Documento, Numero_ID, Fecha_Nacimiento, Telefono)" & Chr(13) & "Values(@Nombres, @Apellidos, @Tipo_Documento, @Numero_ID, @Fecha_Nacimiento, @Telefono)", Conexion)
            Proceso.Parameters.AddWithValue("@Tipo_Documento", CBO1.Text)
            Proceso.Parameters.AddWithValue("@Numero_ID", TXT2.Text)
            Proceso.Parameters.AddWithValue("@Nombres", TXT3.Text)
            Proceso.Parameters.AddWithValue("@Apellidos", TXT4.Text)
            Proceso.Parameters.AddWithValue("@Telefono", TXT5.Text)
            FormatoFecha = DateTimePicker1.Text
            NuevaFecha = Format(FormatoFecha, "yyyy/MM/dd")
            Proceso.Parameters.AddWithValue("@Fecha_Nacimiento", NuevaFecha)
            Proceso.ExecuteNonQuery()

            'Select ID Tabla Persona Para Insertarlo en Tabla Cliente'
            Proceso2 = New MySqlCommand("SELECT ID_Persona FROM Persona WHERE Numero_ID = '" & TXT2.Text & "'", Conexion2)
            Dim Leer As MySqlDataReader = Proceso2.ExecuteReader()
            Dim Guardar_ID As String
            If Leer.Read = True Then
                Guardar_ID = CStr(Leer(0))
            End If
            Leer.Close()
            Proceso2.ExecuteNonQuery()

            'Insertar Referencia de la Persona en Tabla Cliente' 
            Proceso3 = New MySqlCommand("INSERT INTO Cliente(Persona_ID_Persona) VALUES ( @Persona_ID_Persona)", Conexion3)
            Proceso3.Parameters.AddWithValue("@Persona_ID_Persona", Guardar_ID)
            Proceso3.ExecuteNonQuery()
            MsgBox("Cliente Registrado y Creado Correctamente")
        Catch ex As MySqlException
            Console.WriteLine(ex.Message)
            MsgBox("Error En Registrar y Crear el Nuevo Usuario")
            Panel_de_Control.Show()
        End Try
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
        Consultar_Clientes.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TXT2.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""
    End Sub
End Class
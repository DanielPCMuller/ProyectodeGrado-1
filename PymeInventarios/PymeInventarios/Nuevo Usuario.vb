Imports MySql.Data.MySqlClient
Public Class Nuevo_Usuario
    Dim Conexion As New MySqlConnection
    Dim Conexion1 As New MySqlConnection
    Dim Conexion2 As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Proceso2 As New MySqlCommand
    Dim Proceso3 As New MySqlCommand
    Dim Proceso4 As New MySqlCommand


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
        TXT5.Text = ""
        TXT6.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Inicio_Sesion.Show()
        Close()
    End Sub

    Private Sub Nuevo_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim Datos_Conexion As String = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"'
        Dim Datos_Conexion As String = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
        Try
            Conexion.ConnectionString = Datos_Conexion
            Conexion.Open()
            Conexion1.ConnectionString = Datos_Conexion
            Conexion1.Open()
            Conexion2.ConnectionString = Datos_Conexion
            Conexion2.Open()
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Crear Un Nuevo Usuario")
            Inicio_Sesion.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormatoFecha As Date
        Dim NuevaFecha As Date
        Try
            Proceso = New MySqlCommand("Insert Into Persona(Nombres, Apellidos, Tipo_Documento, Numero_ID, Fecha_Nacimiento, Telefono)" & Chr(13) & "Values(@Nombres, @Apellidos, @Tipo_Documento, @Numero_ID, @Fecha_Nacimiento, @Telefono)", Conexion)
            Proceso.Parameters.AddWithValue("@Nombres", TXT2.Text)
            Proceso.Parameters.AddWithValue("@Apellidos", TXT3.Text)
            Proceso.Parameters.AddWithValue("@Tipo_Documento", CBO1.Text)
            Proceso.Parameters.AddWithValue("@Numero_ID", TXT1.Text)
            FormatoFecha = DateTimePicker1.Text
            NuevaFecha = Format(FormatoFecha, "yyyy/MM/dd")
            Proceso.Parameters.AddWithValue("@Fecha_Nacimiento", NuevaFecha)
            Proceso.Parameters.AddWithValue("@Telefono", TXT5.Text)
            Proceso.ExecuteNonQuery()

            'Select Para Usuario Recien Creado y Recuperar ID'
            Proceso2 = New MySqlCommand("SELECT ID_Persona FROM Persona WHERE Numero_ID = '" & TXT1.Text & "'", Conexion1)
            Dim Leer As MySqlDataReader = Proceso2.ExecuteReader()
            Dim Guardar_ID As String
            If Leer.Read = True Then
                Guardar_ID = CStr(Leer(0))
            End If
            Leer.Close()
            Proceso2.ExecuteNonQuery()

            'Insertar Clave Tabla Usuario'
            Proceso4 = New MySqlCommand("INSERT INTO Usuario(Clave, Persona_ID_Persona) VALUES (@Clave, @Persona_ID_Persona)", Conexion2)
            Proceso4.Parameters.AddWithValue("@Clave", TXT6.Text)
            Proceso4.Parameters.AddWithValue("@Persona_ID_Persona", Guardar_ID)
            Proceso4.ExecuteNonQuery()
            MsgBox("Usuario Registrado y Creado Correctamente")
            Close()
            Inicio_Sesion.Show()
        Catch ex As MySqlException
            Console.WriteLine(ex.Message)
            MsgBox("Error En Registrar y Crear el Nuevo Usuario")
            Hide()
            Inicio_Sesion.Show()
            'Catch ex2 As System.InvalidOperationException
            '   Console.WriteLine(ex2.Message)
        End Try






    End Sub
End Class
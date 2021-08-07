Imports MySql.Data.MySqlClient
Public Class Nuevo_Usuario
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Proceso2 As New MySqlCommand
    Dim Proceso3 As New MySqlCommand

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
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Crear Un Nuevo Usuario")
            Inicio_Sesion.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FormatoFecha As Date
        Dim NuevaFecha As Date
        Try
            'Proceso = New MySqlCommand("Insert Into usuarios(Identificacion, Nombres_Persona, Apellidos_Persona, Fecha_Nacimiento, Telefono, Clave)" & Chr(13) & "Values(@Identificacion, @Nombres_Persona, @Apellidos_Persona, @Fecha_Nacimiento, @Telefono, @Clave)", Conexion)
            Proceso = New MySqlCommand("INSERT INTO Persona VALUES (NULL, '@Nombres_Persona', '@Apellidos_Persona', '@Tipo_Documento', '@Identificacion', '@Fecha_Nacimiento', '@Telefono')", Conexion)
            Proceso.Parameters.AddWithValue("@Identificacion", TXT1.Text)
            Proceso.Parameters.AddWithValue("@Nombres_Persona", TXT2.Text)
            Proceso.Parameters.AddWithValue("@Apellidos_Persona", TXT3.Text)
            FormatoFecha = DateTimePicker1.Text
            NuevaFecha = Format(FormatoFecha, "yyyy/MM/dd")
            Proceso.Parameters.AddWithValue("@Fecha_Nacimiento", NuevaFecha)
            Proceso.Parameters.AddWithValue("@Telefono", TXT5.Text)
            Proceso2 = New MySqlCommand("SELECT ID_Persona FROM Persona WHERE Identificacion = '" & TXT1.Text & "'", Conexion)
            Proceso3 = New MySqlCommand("INSERT INTO Usuario VALUES (NULL, '@Clave', '@ID_Persona')", Conexion)
            Proceso3.Parameters.AddWithValue("@Clave", TXT6.Text)
            Proceso.ExecuteNonQuery()
            Proceso2.ExecuteNonQuery()
            Proceso3.ExecuteNonQuery()
            MsgBox("Usuario Registrado y Creado Correctamente")
            Close()
            Inicio_Sesion.Show()
        Catch ex As Exception
            MsgBox("Error En Registrar y Crear el Nuevo Usuario")
            Hide()
            Inicio_Sesion.Show()
        End Try
    End Sub
End Class
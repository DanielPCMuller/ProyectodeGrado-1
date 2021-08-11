Imports MySql.Data.MySqlClient
Public Class Recuperar_Clave
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Proceso2 As New MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TXT1.Text = ""
        TXT2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
        Inicio_Sesion.Show()
    End Sub

    Private Sub Recuperar_Clave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()
            Conexion.Close()
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Consultar el Inventario")
            Inicio_Sesion.Show()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TXT1.Text = "" Or TXT2.Text = "" Then
            MsgBox("Ingrese los Datos Para Recuperar Su Contraseña")
        Else
            Conexion.Open()
            Proceso = New MySqlCommand("SELECT ID_Persona FROM Persona WHERE Numero_ID = '" & TXT1.Text & "'", Conexion)
            Dim Leer As MySqlDataReader = Proceso.ExecuteReader()
            Dim Guardar_ID_Persona As String
            If Leer.Read = True Then
                Guardar_ID_Persona = CStr(Leer(0))
            End If
            Leer.Close()
            Proceso.ExecuteNonQuery()
            Conexion.Close()

            Conexion.Open()
            Proceso2 = New MySqlCommand("UPDATE Usuario SET Clave = '" & TXT2.Text & "' WHERE ID_Usuario = '" & Guardar_ID_Persona & "'", Conexion)
            Proceso2.ExecuteNonQuery()
            Conexion.Close()

            TXT1.Focus()
            MsgBox("Clave Recuperada")
            Conexion.Close()
            Close()
            Inicio_Sesion.Show()
        End If
    End Sub

    Private Sub Recuperar_Clave_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Inicio_Sesion.Show()

    End Sub
End Class
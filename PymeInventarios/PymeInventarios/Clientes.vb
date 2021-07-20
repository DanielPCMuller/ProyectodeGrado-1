﻿Imports MySql.Data.MySqlClient
Public Class Clientes
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
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
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Crear Un Nuevo Cliente")
            Inicio_Sesion.Show()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Proceso = New MySqlCommand("Insert Into clientes(Tipo_Identificacion, Identificacion, Nombres_Cliente, Apellidos_Cliente, Telefono)" & Chr(13) & "Values(@Tipo_Identificacion, @Identificacion, @Nombres_Cliente, @Apellidos_Cliente, @Telefono)", Conexion)
            Proceso.Parameters.AddWithValue("@Tipo_Identificacion", CBO1.Text)
            Proceso.Parameters.AddWithValue("@Identificacion", TXT2.Text)
            Proceso.Parameters.AddWithValue("@Nombres_Cliente", TXT3.Text)
            Proceso.Parameters.AddWithValue("@Apellidos_Cliente", TXT4.Text)
            Proceso.Parameters.AddWithValue("@Telefono", TXT5.Text)
            Proceso.ExecuteNonQuery()
            MsgBox("Cliente Registrado y Creado Correctamente")
        Catch ex As Exception
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
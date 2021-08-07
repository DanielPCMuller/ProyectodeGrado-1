﻿Imports MySql.Data.MySqlClient
Public Class Inicio_Sesion
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Conexion As New MySqlConnection
    Dim Tiempo As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Consulta As String
        Dim Lista As Byte

        If TXT1.Text <> "" And TXT2.Text <> "" Then
            Consulta = "SELECT Persona.Numero_ID, Usuario.Clave FROM Usuario INNER JOIN Persona ON Persona.ID_Persona = Usuario.Persona_ID_Persona WHERE Numero_ID ='" & TXT1.Text & "' and Clave= '" & TXT2.Text & "'"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Adaptador.Fill(Datos, "usuario")
            Lista = Datos.Tables("usuario").Rows.Count
        End If

        If Lista <> 0 Then
            MsgBox("Bienvenido a MyEasyManage")
            Panel_de_Control.Show()
            Hide()
            TXT1.Text = ""
            TXT2.Text = ""
        Else
            MsgBox("Error Al Iniciar Sesión - No Se Ha Encotrado el Usuario o la Contraseña es Incorrecta")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Nuevo_Usuario.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
        End
    End Sub

    Private Sub Inicio_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()
        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Acceder a MyEasyManage")
            Close()
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Close()
        Recuperar_Clave.Show()
    End Sub
End Class
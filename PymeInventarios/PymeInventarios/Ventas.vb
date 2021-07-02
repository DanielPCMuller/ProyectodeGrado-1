Imports MySql.Data.MySqlClient
Public Class Ventas
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Num_Factura As Integer
    Dim Item As Integer

    Private Sub BorrarCliente_Click(sender As Object, e As EventArgs) Handles BorrarCliente.Click
        CBO1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PymeinventariosDataSet.inventarios' Puede moverla o quitarla según sea necesario.
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=eDvAECFNbE; password='f5BSe5QKdb'; database=eDvAECFNbE"
            Conexion.Open()
            MsgBox("Conexión Exitosa Con Base de Datos")
            Dim Consulta As String
            Consulta = "Select * From inventarios"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("inventarios")
            Adaptador.Fill(Datos.Tables("inventarios"))
            CBO2.DataSource = Datos.Tables("inventarios")
            CBO2.ValueMember = "Nombre_Articulo"
            CBO3.DataSource = Datos.Tables("inventarios")
            CBO3.ValueMember = "Precio_Venta"

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Registrar la Factura")
            Panel_de_Control.Show()
        End Try
        TXT1.Text = Now.Date
        Num_Factura = Num_Factura + 1
        TXT8.Text = Num_Factura
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        TXT6.Text = ""
        TXT7.Text = ""
        LST2.Text = ""
        LST3.Text = ""
        LST4.Text = ""
        LST5.Text = ""
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        If (TXT6.Text = "") Then
            MsgBox("Ingrese la Cantidad")
            TXT6.Focus()
        End If
        LST2.Items.Add(CBO2.SelectedValue)
        LST3.Items.Add(TXT6.Text)
        LST4.Items.Add(CBO3.SelectedValue)





    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Try
            Proceso = New MySqlCommand("Insert Into Facturacion(Fecha_Factura, Numero_Factura, Nombre_Cliente, Tipo_Identificacion, Numero_Identificacion)" & Chr(13) & "Values(@Fecha_Factura, @Numero_Factura, @Nombre_Cliente, @Tipo_Identificacion, @Numero_Identificacion)", Conexion)
            Proceso.Parameters.AddWithValue("@Fecha_Factura", TXT1.Text)
            Proceso.Parameters.AddWithValue("@Numero_Factura", TXT8.Text)
            Proceso.Parameters.AddWithValue("@Nombre_Cliente", TXT3.Text)
            Proceso.Parameters.AddWithValue("@Tipo_Identificacion", CBO1.Text)
            Proceso.Parameters.AddWithValue("@Numero_Identificacion", TXT2.Text)
            Proceso.ExecuteNonQuery()
            TXT1.Focus()
            MsgBox("Datos Registrados")
        Catch ex As Exception
            MsgBox("Error al Registrar los Datos")
        End Try

    End Sub

    Private Sub CBO2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO2.SelectedIndexChanged

    End Sub
End Class
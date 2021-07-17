Imports MySql.Data.MySqlClient
Public Class Ventas
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Num_Factura As Integer
    Dim Item As Integer
    Dim Total As Integer
    Dim Cambio As Integer
    Dim MontoRecibido As Integer

    Private Sub BorrarCliente_Click(sender As Object, e As EventArgs) Handles BorrarCliente.Click
        CBO1.Text = ""
        TXT2.Text = ""
        TXT3.Text = ""
        TXT7.Text = ""
        TXT9.Text = ""
        TXT10.Text = ""
        LST2.Items.Clear()
        LST3.Items.Clear()
        LST5.Items.Clear()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PymeinventariosDataSet.inventarios' Puede moverla o quitarla según sea necesario.
        Try
            Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
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
        If (LST2.SelectedIndex > -1) Then
            LST2.Items.RemoveAt(LST2.SelectedIndex)
            TXT7.Text = ""
        End If

        If (LST3.SelectedIndex > -1) Then
            LST3.Items.RemoveAt(LST3.SelectedIndex)
            TXT7.Text = ""
        End If

        If (LST5.SelectedIndex > -1) Then
            LST5.Items.RemoveAt(LST5.SelectedIndex)
            TXT7.Text = ""
        End If
        TXT7.Text = ""
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        Dim Multiplicacion As Long
        Dim Resultado As Integer

        If (TXT6.Text = "") Then
            MsgBox("Ingrese la Cantidad")
            TXT6.Focus()
            Return
        End If

        LST2.Items.Add(CBO2.Text)
        LST3.Items.Add(TXT6.Text)

        Multiplicacion = CBO3.Text * TXT6.Text
        Resultado = Multiplicacion
        LST5.Items.Add(Resultado)

        TXT6.Text = ""
        CBO2.Text = ""
        CBO3.Text = ""


    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click

        If CBO1.Text = "" Or TXT2.Text = "" Or TXT3.Text = "" Or TXT10.Text = "" Then
            MsgBox("Ingrese Datos en los Campos Solicitados")
            CBO1.Focus()
        End If

        MontoRecibido = TXT10.Text
        Cambio = MontoRecibido - Total
        TXT9.Text = Cambio.ToString()




        'Try
        ' Proceso = New MySqlCommand("Insert Into Facturacion(Fecha_Factura, Numero_Factura, Nombre_Cliente, Tipo_Identificacion, Numero_Identificacion)" & Chr(13) & "Values(@Fecha_Factura, @Numero_Factura, @Nombre_Cliente, @Tipo_Identificacion, @Numero_Identificacion)", Conexion)
        'Proceso.Parameters.AddWithValue("@Fecha_Factura", TXT1.Text)
        'Proceso.Parameters.AddWithValue("@Numero_Factura", TXT8.Text)
        'Proceso.Parameters.AddWithValue("@Nombre_Cliente", TXT3.Text)
        'Proceso.Parameters.AddWithValue("@Tipo_Identificacion", CBO1.Text)
        'Proceso.Parameters.AddWithValue("@Numero_Identificacion", TXT2.Text)
        'Proceso.ExecuteNonQuery()
        'TXT1.Focus()
        'MsgBox("Datos Registrados")
        'Catch ex As Exception
        'MsgBox("Error al Registrar los Datos")
        'End Try

    End Sub

    Private Sub CBO2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO2.SelectedIndexChanged

    End Sub

    Private Sub LST3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LST3.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm1.Print()
        Timer1.Stop()
    End Sub

    Private Sub ImprimirReciboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirReciboToolStripMenuItem.Click
        Timer1.Start()
    End Sub

    Private Sub TXT7_TextChanged(sender As Object, e As EventArgs) Handles TXT7.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each item As Object In LST5.Items
            Total = Total + Convert.ToDouble(item)
            TXT7.Text = Total.ToString()
        Next
    End Sub
End Class
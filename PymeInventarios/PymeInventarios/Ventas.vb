Imports MySql.Data.MySqlClient
Public Class Ventas
    Dim Conexion As New MySqlConnection
    Dim Proceso As New MySqlCommand
    Dim Adaptador As New MySqlDataAdapter
    Dim Datos As New DataSet
    Dim Num_Factura As Integer
    'Dim Item As Integer
    Dim Total As Double
    Dim Cambio As Double
    Dim MontoRecibido As Double
    Dim Cantidad As Integer
    Dim Cantidades As ArrayList = New ArrayList()
    Dim CantidadesNuevas As ArrayList = New ArrayList()

    Private Sub BorrarCliente_Click(sender As Object, e As EventArgs) Handles BorrarCliente.Click
        CBO1.Text = ""
        TXT3.Text = ""
        TXT4.Text = ""
        TXT5.Text = ""
        TXT6.Text = ""
        TXT7.Text = ""
        TXT8.Text = ""
        TXT11.Text = ""
        TXT10.Text = ""
        TXT9.Text = ""
        LST2.Items.Clear()
        LST3.Items.Clear()
        LST5.Items.Clear()
        Cantidades.Clear()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PymeinventariosDataSet.inventarios' Puede moverla o quitarla según sea necesario.
        Try
            Conexion.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'Conexion.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            Conexion.Open()

            Dim Consulta As String
            Consulta = "SELECT a.Nombre_Producto, b.Cantidad, b.Precio_Venta FROM Productos a JOIN Producto_Inventario b on a.ID_Producto = b.Productos_ID_Producto"
            Adaptador = New MySqlDataAdapter(Consulta, Conexion)
            Datos = New DataSet
            Datos.Tables.Add("Productos")
            Adaptador.Fill(Datos.Tables("Productos"))
            CBO2.DataSource = Datos.Tables("Productos")
            CBO2.ValueMember = "Nombre_Producto"
            ''Dim Fila As DataRow = Datos.Rows(0)
            TXT8.DataBindings.Add("Text", Datos.Tables("Productos"), "Precio_Venta")
            TXT6.DataBindings.Add("Text", Datos.Tables("Productos"), "Cantidad")

            If TXT6.Text <> "" Or TXT8.Text <> "" Then
                Dim PrecioVenta = TXT8.Text
                Dim Cantidad = TXT6.Text
                Dim PrecioUnidad = PrecioVenta / Cantidad
                TXT7.Text = PrecioUnidad
                'Console.Write(PrecioUnidad)
            End If

        Catch ex As Exception
            MsgBox("No Se Puede Conectar Con la Base de Datos - No Se Podrá Registrar la Factura")
            Panel_de_Control.Show()
        End Try
        TXT1.Text = Now.Date
        Num_Factura = Num_Factura + 1
        TXT2.Text = Num_Factura
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        Dim Multiplicacion As Double
        Dim CantidadInventario As Integer
        Dim Resultado As Double
        Dim Existe As Boolean = False



        If TXT5.Text <> "" Then
            Cantidad = TXT5.Text
            CantidadInventario = TXT6.Text
            Cantidades.Add(CantidadInventario)
            Console.WriteLine(Cantidades)
        End If


        If TXT5.Text = "" Then
            MsgBox("Ingrese la Cantidad", vbExclamation)
            TXT5.Focus()
            Return

        ElseIf CBO2.Text = "Seleccione" Then
            MsgBox("Seleccione el producto", vbExclamation)
            CBO2.Focus()
            Return
        ElseIf Cantidad > CantidadInventario Then
            MsgBox("La cantidad no puede superar a la disponible en el inventario", vbCritical)
            TXT5.Focus()
            Return

        Else
            Try
                For Each item As String In LST2.Items
                    'Console.WriteLine(LST2.GetItemText(item))
                    If item.Contains(CBO2.Text) Then
                        Existe = True
                        MsgBox("El Producto ya ha sido agregado", vbExclamation)
                    End If
                Next

                If Existe = False Then

                    LST2.Items.Add(CBO2.Text)
                    LST3.Items.Add(TXT5.Text)

                    Multiplicacion = TXT5.Text * TXT7.Text
                    Resultado = Multiplicacion
                    LST5.Items.Add(Multiplicacion)
                End If
            Catch ex As InvalidCastException
                Console.Write(ex.Message)
            End Try

            Total = 0

            For Each item As Object In LST5.Items
                Total = Total + Convert.ToInt32(item)
                TXT11.Text = Total.ToString()
            Next

            CBO2.Text = "Seleccione"
            TXT5.Text = ""
            'TXT6.Text = ""
            TXT7.Text = ""
            TXT8.Text = ""

            TXT6.Enabled = False
            TXT8.Enabled = False


        End If
    End Sub

    Private Sub Guardar_Venta_Click(sender As Object, e As EventArgs) Handles Guardar_Venta.Click

        'Dim Cantidad_Actual As Integer
        'Dim Cantidad_Nueva As Integer
        Dim Elemento As Integer
        Dim Tamanio As Integer
        Dim Contador As Integer = 0

        If CBO1.Text = "" Or TXT3.Text = "" Or TXT4.Text = "" Then
            MsgBox("Ingrese Datos en los Campos Solicitados")
            TXT3.Focus()
        End If

        Tamanio = LST3.Items.Count()

        For Each item As Object In LST3.Items
            Contador = Contador + 1
            For Each Elemento In Cantidades
                Elemento = Elemento - Convert.ToInt32(item)
                If Contador = Tamanio Then
                    CantidadesNuevas.Add(Elemento)
                    Exit For
                End If
            Next

        Next
        For Each Elemento2 As String In CantidadesNuevas
            Console.WriteLine(Elemento2)
        Next

        'If TXT6.Text <> "" Then
        'Cantidad_Actual = TXT6.Text
        'Cantidad_Nueva = Cantidad_Actual - Cantidad
        'Console.WriteLine(Cantidad_Nueva.ToString)
        'End If




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

    Private Sub LST3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LST3.SelectedIndexChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PrintForm1.Print()
        Timer1.Stop()
    End Sub

    Private Sub ImprimirReciboToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirReciboToolStripMenuItem.Click
        Timer1.Start()
    End Sub

    Private Sub TXT7_TextChanged(sender As Object, e As EventArgs) Handles TXT11.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Monto As Double
        Dim Costo As Double

        If TXT9.Text <> "" Then
            Monto = TXT9.Text
            Costo = TXT11.Text
        End If

        If TXT9.Text = "" Then
            MsgBox("Inserte el Monto Recibido", vbEmpty)
            TXT9.Focus()
        ElseIf Monto > Costo Then


            MontoRecibido = TXT9.Text
            Cambio = MontoRecibido - Total
            TXT10.Text = Cambio.ToString()
        Else
            MsgBox("El Monto Recibido debe ser mayor al total de la venta", vbExclamation)
        End If

        For Each Elemento As String In Cantidades
            Console.WriteLine(Elemento)
        Next

    End Sub

    Private Sub Invetario_Closing(Sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Panel_de_Control.Show()
    End Sub

    Private Sub TXT6_TextChanged(sender As Object, e As EventArgs) Handles TXT6.TextChanged
        Try
            Dim PrecioVenta = TXT8.Text
            Dim Cantidad = TXT6.Text
            Dim PrecioUnidad = PrecioVenta / Cantidad
            TXT7.Text = PrecioUnidad
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        TXT6.Enabled = True
        TXT8.Enabled = True
    End Sub
End Class
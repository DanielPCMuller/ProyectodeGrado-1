Imports MySql.Data.MySqlClient
Public Class Ventas
    Dim ConexionVentas As New MySqlConnection
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
    Dim IDsProductos As ArrayList = New ArrayList()
    Dim Correcto = False

    Private Sub BorrarCliente_Click(sender As Object, e As EventArgs) Handles BorrarCliente.Click
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
        CBO3.Focus()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'PymeinventariosDataSet.inventarios' Puede moverla o quitarla según sea necesario.

        TXTIDCliente.Hide()
        TXTIDProducto.Hide()
        Button1.Enabled = False
        Guardar_Venta.Enabled = False

        Try
            ConexionVentas.ConnectionString = "server=remotemysql.com; user=8S2KFbGuCG; password='hJgny67Qbs'; database=8S2KFbGuCG"
            'ConexionVentas.ConnectionString = "server=bynejs3dk0uzuzbn2sur-mysql.services.clever-cloud.com; user=ucv0u4lxjvhpcjog; password='hQ8fhikLVvzPAU6RIkpe'; database=bynejs3dk0uzuzbn2sur"
            ConexionVentas.Open()

            Dim Consulta As String
            Consulta = "SELECT a.ID_Producto, a.Nombre_Producto, b.Cantidad, b.Precio_Venta FROM Productos a JOIN Producto_Inventario b on a.ID_Producto = b.Productos_ID_Producto"
            Adaptador = New MySqlDataAdapter(Consulta, ConexionVentas)
            Datos = New DataSet
            Datos.Tables.Add("Productos")
            Adaptador.Fill(Datos.Tables("Productos"))
            CBO2.DataSource = Datos.Tables("Productos")
            CBO2.ValueMember = "Nombre_Producto"
            ''Dim Fila As DataRow = Datos.Rows(0)
            TXTIDProducto.DataBindings.Add("Text", Datos.Tables("Productos"), "ID_Producto")
            TXT8.DataBindings.Add("Text", Datos.Tables("Productos"), "Precio_Venta")
            TXT6.DataBindings.Add("Text", Datos.Tables("Productos"), "Cantidad")
            ConexionVentas.Close()

            Cargar_Datos()
            Cargar_Numero_Venta()

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
    End Sub

    Private Sub Cargar_Numero_Venta()
        Try
            ConexionVentas.Open()
            Dim Consulta As String
            Consulta = "SELECT MAX(ID_Venta)+1 FROM Ventas"
            Adaptador = New MySqlDataAdapter(Consulta, ConexionVentas)
            Datos = New DataSet
            Datos.Tables.Add("Ventas")
            Adaptador.Fill(Datos.Tables("Ventas"))
            TXT2.DataBindings.Add("Text", Datos.Tables("Ventas"), "MAX(ID_Venta)+1")
            ConexionVentas.Close()
        Catch ex As MySqlException
            Console.Write(ex.Message)
        End Try
    End Sub

    Private Sub Cargar_Datos()
        Try
            ConexionVentas.Open()
            Dim Consulta As String
            Consulta = "SELECT a.Nombres, a.Tipo_Documento, a.Numero_ID, b.ID_Cliente 
                    FROM Persona a JOIN Cliente b 
                    WHERE a.ID_Persona = b.Persona_ID_Persona"
            Adaptador = New MySqlDataAdapter(Consulta, ConexionVentas)
            Datos = New DataSet
            Datos.Tables.Add("Persona")
            Adaptador.Fill(Datos.Tables("Persona"))
            CBO3.DataSource = Datos.Tables("Persona")
            CBO3.ValueMember = "Nombres"
            TXT3.DataBindings.Add("Text", Datos.Tables("Persona"), "Numero_ID")
            TXTtipoID.DataBindings.Add("Text", Datos.Tables("Persona"), "Tipo_Documento")
            TXTIDCliente.DataBindings.Add("Text", Datos.Tables("Persona"), "ID_Cliente")
            ConexionVentas.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Close()
        Panel_de_Control.Show()
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click

        Dim Multiplicacion As Double
        Dim CantidadInventario As Integer
        Dim IDProducto As Integer
        Dim Resultado As Double
        Dim Existe As Boolean = False

        If TXT5.Text <> "" Then
            Cantidad = TXT5.Text
            CantidadInventario = TXT6.Text
            IDProducto = TXTIDProducto.Text
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
        ElseIf Cantidad = 0
            MsgBox("La cantidad no puede ser 0", vbExclamation)
            TXT5.Focus()
        Else
            Try
                Cantidades.Add(CantidadInventario - Cantidad)
                IDsProductos.Add(IDProducto)
                For Each Elemento As String In Cantidades
                    Console.WriteLine(Elemento)
                Next

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
            Button1.Enabled = True

        End If
    End Sub

    Private Sub Guardar_Venta_Click(sender As Object, e As EventArgs) Handles Guardar_Venta.Click

        'Dim Cantidad_Actual As Integer
        'Dim Cantidad_Nueva As Integer
        Dim Elemento As Integer
        Dim Tamanio As Integer
        Dim Contador As Integer = 0

        If TXTIDCliente.Text = "" Or TXT9.Text = "" Or TXT11.Text = "" Then
            MsgBox("Ingrese Datos en los Campos Solicitados")
            TXT3.Focus()
        ElseIf Correcto
            Insertar_Ventas()
            LST2.Items.Clear()
            LST3.Items.Clear()
            LST5.Items.Clear()
            Guardar_Venta.Enabled = False
            Correcto = False
        Else
            MsgBox("Datos erroneaos, no se puede registrar la venta", vbExclamation)
        End If
    End Sub

    Private Sub Insertar_Ventas()
        Dim FormatoFecha As Date
        Dim NuevaFecha As Date
        Try
            ConexionVentas.Open()
            Proceso = New MySqlCommand("INSERT INTO Ventas(Fecha_Venta, Valor_Total, Cliente_ID_Cliente)
                                        VALUES(@Fecha_Venta, @Valor_Total, @Cliente_ID_Cliente)", ConexionVentas)
            FormatoFecha = TXT1.Text
            NuevaFecha = Format(FormatoFecha, "yyyy/MM/dd")
            Proceso.Parameters.AddWithValue("@Fecha_Venta", NuevaFecha)
            Proceso.Parameters.AddWithValue("@Valor_Total", TXT11.Text)
            Proceso.Parameters.AddWithValue("@Cliente_ID_Cliente", TXTIDCliente.Text)
            Proceso.ExecuteNonQuery()
            ConexionVentas.Close()
            Insertar_Venta_Producto()

            MsgBox("Venta Registrada")
        Catch ex As MySqlException
            MsgBox("Error al Registrar los Datos en Ventas")
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Insertar_Venta_Producto()
        Try
            ConexionVentas.Open()
            Proceso = New MySqlCommand("INSERT INTO Venta_Producto(Cantidad_Productos, Precio, Productos_ID_Producto, Ventas_ID_Venta)
                                        VALUES(@Cantidad_Productos, @Precio, @Productos_ID_Producto, @Ventas_ID_Venta)", ConexionVentas)

            Dim i As Integer = 0
            For Each item As String In LST3.Items
                'Console.WriteLine(LST2.GetItemText(item))
                'Console.WriteLine(Convert.ToString(Cantidades(i)))
                'Console.WriteLine(LST5.Items(i))
                Proceso.Parameters.Clear()
                Proceso.Parameters.AddWithValue("@Cantidad_Productos", LST3.Items(i))
                Proceso.Parameters.AddWithValue("@Precio", LST5.Items(i))
                Proceso.Parameters.AddWithValue("@Productos_ID_Producto", IDsProductos(i))
                Proceso.Parameters.AddWithValue("@Ventas_ID_Venta", TXT2.Text)
                Proceso.ExecuteNonQuery()

                i = i + 1
            Next
            ConexionVentas.Close()

            Actualizar_Inventario()

            'MsgBox("Venta Registrada")
        Catch ex As MySqlException
            MsgBox("Error al Registrar los Datos en Venta Productos")
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub Actualizar_Inventario()
        Try
            ConexionVentas.Open()

            Dim i As Integer = 0
            For Each item As String In LST3.Items
                'Console.WriteLine(LST2.GetItemText(item))
                'Console.WriteLine(Convert.ToString(Cantidades(i)))
                'Console.WriteLine(LST5.Items(i))

                'Dim cantidad As Integer =
                'Dim ID_Producto As Integer = 
                Proceso = New MySqlCommand("UPDATE Producto_Inventario SET Cantidad =" & Cantidades(i) & " WHERE Productos_ID_Producto =" & IDsProductos(i) & "", ConexionVentas)
                Proceso.ExecuteNonQuery()
                i = i + 1
            Next
            ConexionVentas.Close()

            'MsgBox("Venta Registrada")
        Catch ex As MySqlException
            MsgBox("Error al Actualizar los Datos en Inventario")
            Console.WriteLine(ex.Message)
        End Try
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
            Button1.Enabled = False
            Correcto = True
            Guardar_Venta.Enabled = True
        Else
            MsgBox("El Monto Recibido debe ser mayor al total de la venta", vbExclamation)
        End If


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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clientes.Show()
    End Sub
End Class
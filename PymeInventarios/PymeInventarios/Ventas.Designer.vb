<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBO1 = New System.Windows.Forms.ComboBox()
        Me.TXT3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT4 = New System.Windows.Forms.TextBox()
        Me.BorrarCliente = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT6 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXT9 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXT10 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LST5 = New System.Windows.Forms.ListBox()
        Me.LST3 = New System.Windows.Forms.ListBox()
        Me.LST2 = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT11 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Guardar_Venta = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT2 = New System.Windows.Forms.TextBox()
        Me.CBO2 = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirReciboToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXT5 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TXT7 = New System.Windows.Forms.TextBox()
        Me.TXT8 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Datos del Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Identificación"
        '
        'CBO1
        '
        Me.CBO1.FormattingEnabled = True
        Me.CBO1.Items.AddRange(New Object() {"Cédula de Ciudadanía", "NIT", "Cédula de Extranjería", "Pasaporte"})
        Me.CBO1.Location = New System.Drawing.Point(128, 109)
        Me.CBO1.Name = "CBO1"
        Me.CBO1.Size = New System.Drawing.Size(158, 21)
        Me.CBO1.TabIndex = 3
        Me.CBO1.Text = "Seleccione"
        '
        'TXT3
        '
        Me.TXT3.Location = New System.Drawing.Point(445, 110)
        Me.TXT3.Name = "TXT3"
        Me.TXT3.Size = New System.Drawing.Size(145, 20)
        Me.TXT3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(302, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Número Identificación"
        '
        'TXT1
        '
        Me.TXT1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TXT1.Location = New System.Drawing.Point(592, 39)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.ReadOnly = True
        Me.TXT1.Size = New System.Drawing.Size(145, 20)
        Me.TXT1.TabIndex = 6
        Me.TXT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nombre del Cliente"
        '
        'TXT4
        '
        Me.TXT4.Location = New System.Drawing.Point(141, 149)
        Me.TXT4.Name = "TXT4"
        Me.TXT4.Size = New System.Drawing.Size(186, 20)
        Me.TXT4.TabIndex = 7
        '
        'BorrarCliente
        '
        Me.BorrarCliente.Location = New System.Drawing.Point(378, 586)
        Me.BorrarCliente.Name = "BorrarCliente"
        Me.BorrarCliente.Size = New System.Drawing.Size(145, 32)
        Me.BorrarCliente.TabIndex = 9
        Me.BorrarCliente.Text = "Borrar Datos Venta"
        Me.BorrarCliente.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Datos del Producto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(11, 231)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(488, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Precio $"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(488, 234)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Cantidad en Inventario"
        '
        'TXT6
        '
        Me.TXT6.BackColor = System.Drawing.SystemColors.Window
        Me.TXT6.Location = New System.Drawing.Point(635, 233)
        Me.TXT6.Name = "TXT6"
        Me.TXT6.ReadOnly = True
        Me.TXT6.Size = New System.Drawing.Size(88, 20)
        Me.TXT6.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Detalle de Compra"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TXT9)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TXT10)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LST5)
        Me.GroupBox1.Controls.Add(Me.LST3)
        Me.GroupBox1.Controls.Add(Me.LST2)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Agregar)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 247)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 32)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Calcular Venta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TXT9
        '
        Me.TXT9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT9.ForeColor = System.Drawing.Color.ForestGreen
        Me.TXT9.Location = New System.Drawing.Point(151, 227)
        Me.TXT9.Name = "TXT9"
        Me.TXT9.Size = New System.Drawing.Size(120, 20)
        Me.TXT9.TabIndex = 51
        Me.TXT9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(32, 231)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 16)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Monto Recibido $"
        '
        'TXT10
        '
        Me.TXT10.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TXT10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT10.ForeColor = System.Drawing.Color.Red
        Me.TXT10.Location = New System.Drawing.Point(363, 227)
        Me.TXT10.Name = "TXT10"
        Me.TXT10.ReadOnly = True
        Me.TXT10.Size = New System.Drawing.Size(120, 20)
        Me.TXT10.TabIndex = 49
        Me.TXT10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(292, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Cambio $"
        '
        'LST5
        '
        Me.LST5.FormattingEnabled = True
        Me.LST5.Location = New System.Drawing.Point(430, 44)
        Me.LST5.Name = "LST5"
        Me.LST5.Size = New System.Drawing.Size(120, 173)
        Me.LST5.TabIndex = 48
        '
        'LST3
        '
        Me.LST3.FormattingEnabled = True
        Me.LST3.Location = New System.Drawing.Point(282, 44)
        Me.LST3.Name = "LST3"
        Me.LST3.Size = New System.Drawing.Size(120, 173)
        Me.LST3.TabIndex = 46
        '
        'LST2
        '
        Me.LST2.FormattingEnabled = True
        Me.LST2.Location = New System.Drawing.Point(131, 44)
        Me.LST2.Name = "LST2"
        Me.LST2.Size = New System.Drawing.Size(120, 173)
        Me.LST2.TabIndex = 44
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(427, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 16)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "SubTotal $"
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(557, 44)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(145, 32)
        Me.Agregar.TabIndex = 24
        Me.Agregar.Text = "Agregar Productos"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(128, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 16)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Producto"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(279, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 16)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Cantidad"
        '
        'TXT11
        '
        Me.TXT11.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TXT11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT11.ForeColor = System.Drawing.Color.Blue
        Me.TXT11.Location = New System.Drawing.Point(597, 536)
        Me.TXT11.Name = "TXT11"
        Me.TXT11.ReadOnly = True
        Me.TXT11.Size = New System.Drawing.Size(120, 20)
        Me.TXT11.TabIndex = 29
        Me.TXT11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(504, 540)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 16)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Total Venta $"
        '
        'Guardar_Venta
        '
        Me.Guardar_Venta.Location = New System.Drawing.Point(229, 586)
        Me.Guardar_Venta.Name = "Guardar_Venta"
        Me.Guardar_Venta.Size = New System.Drawing.Size(145, 32)
        Me.Guardar_Venta.TabIndex = 19
        Me.Guardar_Venta.Text = "Guardar Venta"
        Me.Guardar_Venta.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(528, 586)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(145, 32)
        Me.Salir.TabIndex = 21
        Me.Salir.Text = "Atrás"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(442, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 16)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Fecha de Venta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(440, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Recibo de Venta No."
        '
        'TXT2
        '
        Me.TXT2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TXT2.Location = New System.Drawing.Point(592, 65)
        Me.TXT2.Name = "TXT2"
        Me.TXT2.ReadOnly = True
        Me.TXT2.Size = New System.Drawing.Size(145, 20)
        Me.TXT2.TabIndex = 26
        Me.TXT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBO2
        '
        Me.CBO2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.CBO2.FormattingEnabled = True
        Me.CBO2.Location = New System.Drawing.Point(79, 231)
        Me.CBO2.Name = "CBO2"
        Me.CBO2.Size = New System.Drawing.Size(135, 21)
        Me.CBO2.TabIndex = 28
        Me.CBO2.Text = "Seleccione"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(748, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirReciboToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ImprimirReciboToolStripMenuItem
        '
        Me.ImprimirReciboToolStripMenuItem.Name = "ImprimirReciboToolStripMenuItem"
        Me.ImprimirReciboToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ImprimirReciboToolStripMenuItem.Text = "Imprimir Recibo"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(243, 234)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 16)
        Me.Label18.TabIndex = 40
        Me.Label18.Text = "Cantidad"
        '
        'TXT5
        '
        Me.TXT5.Location = New System.Drawing.Point(310, 232)
        Me.TXT5.Name = "TXT5"
        Me.TXT5.Size = New System.Drawing.Size(88, 20)
        Me.TXT5.TabIndex = 39
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(211, 262)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 16)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Precio Unidad"
        '
        'TXT7
        '
        Me.TXT7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TXT7.Location = New System.Drawing.Point(310, 261)
        Me.TXT7.Name = "TXT7"
        Me.TXT7.ReadOnly = True
        Me.TXT7.Size = New System.Drawing.Size(88, 20)
        Me.TXT7.TabIndex = 41
        '
        'TXT8
        '
        Me.TXT8.BackColor = System.Drawing.SystemColors.Window
        Me.TXT8.Location = New System.Drawing.Point(635, 261)
        Me.TXT8.Name = "TXT8"
        Me.TXT8.ReadOnly = True
        Me.TXT8.Size = New System.Drawing.Size(88, 20)
        Me.TXT8.TabIndex = 43
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 630)
        Me.Controls.Add(Me.TXT8)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.TXT7)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TXT5)
        Me.Controls.Add(Me.CBO2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXT2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.TXT11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Guardar_Venta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BorrarCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXT4)
        Me.Controls.Add(Me.TXT1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT3)
        Me.Controls.Add(Me.CBO1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBO1 As ComboBox
    Friend WithEvents TXT3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT4 As TextBox
    Friend WithEvents BorrarCliente As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Guardar_Venta As Button
    Friend WithEvents Salir As Button
    Friend WithEvents Agregar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT2 As TextBox
    Friend WithEvents CBO2 As ComboBox
    Friend WithEvents TXT11 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents LST5 As ListBox
    Friend WithEvents LST3 As ListBox
    Friend WithEvents LST2 As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirReciboToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TXT9 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXT10 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TXT8 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TXT7 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TXT5 As TextBox
End Class

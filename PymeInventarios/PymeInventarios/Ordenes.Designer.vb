<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ordenes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ordenes))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXT1 = New System.Windows.Forms.TextBox()
        Me.TXT5 = New System.Windows.Forms.TextBox()
        Me.TXT6 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT7 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBO1 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(127, 139)
        Me.DateTimePicker1.MinDate = New Date(2021, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(134, 20)
        Me.DateTimePicker1.TabIndex = 138
        Me.DateTimePicker1.Value = New Date(2021, 7, 17, 0, 0, 0, 0)
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(364, 595)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 34)
        Me.Button3.TabIndex = 134
        Me.Button3.Text = "Atrás"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 133
        Me.Label7.Text = "Precio Compra $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 131
        Me.Label6.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Fecha de Pedido"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(138, 595)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 36)
        Me.Button2.TabIndex = 125
        Me.Button2.Text = "Limpiar Campos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(183, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 16)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Órdenes de Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Código del Pedido"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(180, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 122
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(25, 595)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 36)
        Me.Button1.TabIndex = 121
        Me.Button1.Text = "Insertar Órden"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TXT1
        '
        Me.TXT1.Location = New System.Drawing.Point(138, 153)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.Size = New System.Drawing.Size(134, 20)
        Me.TXT1.TabIndex = 120
        '
        'TXT5
        '
        Me.TXT5.Location = New System.Drawing.Point(127, 165)
        Me.TXT5.Name = "TXT5"
        Me.TXT5.Size = New System.Drawing.Size(134, 20)
        Me.TXT5.TabIndex = 139
        '
        'TXT6
        '
        Me.TXT6.Location = New System.Drawing.Point(127, 191)
        Me.TXT6.Name = "TXT6"
        Me.TXT6.Size = New System.Drawing.Size(134, 20)
        Me.TXT6.TabIndex = 140
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(251, 595)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 34)
        Me.Button4.TabIndex = 141
        Me.Button4.Text = "Consultar Órdenes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBO1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT7)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXT4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TXT6)
        Me.GroupBox1.Controls.Add(Me.TXT3)
        Me.GroupBox1.Controls.Add(Me.TXT5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(446, 230)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Artículos Solicitados"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Empresa Pedido"
        '
        'TXT7
        '
        Me.TXT7.Location = New System.Drawing.Point(127, 34)
        Me.TXT7.Name = "TXT7"
        Me.TXT7.Size = New System.Drawing.Size(134, 20)
        Me.TXT7.TabIndex = 144
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(320, 173)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 34)
        Me.Button5.TabIndex = 143
        Me.Button5.Text = "Agregar Artículo"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 134
        Me.Label10.Text = "Marca del Producto"
        '
        'TXT4
        '
        Me.TXT4.Location = New System.Drawing.Point(127, 112)
        Me.TXT4.Name = "TXT4"
        Me.TXT4.Size = New System.Drawing.Size(134, 20)
        Me.TXT4.TabIndex = 133
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 132
        Me.Label9.Text = "Nombre del Producto"
        '
        'TXT3
        '
        Me.TXT3.Location = New System.Drawing.Point(127, 86)
        Me.TXT3.Name = "TXT3"
        Me.TXT3.Size = New System.Drawing.Size(134, 20)
        Me.TXT3.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Código del Producto"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 428)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 150)
        Me.DataGridView1.TabIndex = 141
        '
        'Column1
        '
        Me.Column1.HeaderText = "Empresa Pedido"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Codigo Producto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre producto"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Marca Producto"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Fecha Pedido"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Cantidad"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Precio Compra"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'CBO1
        '
        Me.CBO1.FormattingEnabled = True
        Me.CBO1.Location = New System.Drawing.Point(127, 60)
        Me.CBO1.Name = "CBO1"
        Me.CBO1.Size = New System.Drawing.Size(134, 21)
        Me.CBO1.TabIndex = 146
        '
        'Ordenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 634)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Ordenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TXT1 As TextBox
    Friend WithEvents TXT5 As TextBox
    Friend WithEvents TXT6 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT7 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents CBO1 As ComboBox
End Class

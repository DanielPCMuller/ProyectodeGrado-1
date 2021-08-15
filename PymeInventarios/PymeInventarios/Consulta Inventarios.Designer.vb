<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consulta_Inventarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_Inventarios))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CBO1 = New System.Windows.Forms.ComboBox()
        Me.CBO2 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(280, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Consulta de Inventarios"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(283, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(48, 235)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(561, 181)
        Me.DataGridView1.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(137, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Búsqueda Por Marca"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 55)
        Me.Button1.TabIndex = 64
        Me.Button1.Text = "Buscar Productos"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(254, 433)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 55)
        Me.Button2.TabIndex = 65
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Búsqueda Por Nombre"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(382, 433)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 55)
        Me.Button3.TabIndex = 66
        Me.Button3.Text = "Atrás"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CBO1
        '
        Me.CBO1.FormattingEnabled = True
        Me.CBO1.Location = New System.Drawing.Point(283, 171)
        Me.CBO1.Name = "CBO1"
        Me.CBO1.Size = New System.Drawing.Size(144, 21)
        Me.CBO1.TabIndex = 70
        '
        'CBO2
        '
        Me.CBO2.FormattingEnabled = True
        Me.CBO2.Location = New System.Drawing.Point(283, 198)
        Me.CBO2.Name = "CBO2"
        Me.CBO2.Size = New System.Drawing.Size(144, 21)
        Me.CBO2.TabIndex = 71
        '
        'Consulta_Inventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 509)
        Me.Controls.Add(Me.CBO2)
        Me.Controls.Add(Me.CBO1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Consulta_Inventarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta_Inventarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents CBO1 As ComboBox
    Friend WithEvents CBO2 As ComboBox
End Class

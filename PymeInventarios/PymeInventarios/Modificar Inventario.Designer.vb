﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_Inventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_Inventario))
        Me.TXT6 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT8 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TXT7 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT6
        '
        Me.TXT6.Location = New System.Drawing.Point(167, 342)
        Me.TXT6.Name = "TXT6"
        Me.TXT6.Size = New System.Drawing.Size(249, 20)
        Me.TXT6.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(47, 349)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Porcentaje Utilidad %"
        '
        'TXT8
        '
        Me.TXT8.Enabled = False
        Me.TXT8.Location = New System.Drawing.Point(167, 396)
        Me.TXT8.Name = "TXT8"
        Me.TXT8.Size = New System.Drawing.Size(249, 20)
        Me.TXT8.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(49, 403)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 76
        Me.Label10.Text = "Utilidad $"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Marca Artículo"
        '
        'TXT3
        '
        Me.TXT3.Location = New System.Drawing.Point(167, 264)
        Me.TXT3.Name = "TXT3"
        Me.TXT3.Size = New System.Drawing.Size(249, 20)
        Me.TXT3.TabIndex = 74
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(298, 437)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 34)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Precio Compra $"
        '
        'TXT5
        '
        Me.TXT5.Location = New System.Drawing.Point(167, 316)
        Me.TXT5.Name = "TXT5"
        Me.TXT5.Size = New System.Drawing.Size(249, 20)
        Me.TXT5.TabIndex = 71
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Cantidad"
        '
        'TXT4
        '
        Me.TXT4.Location = New System.Drawing.Point(167, 290)
        Me.TXT4.Name = "TXT4"
        Me.TXT4.Size = New System.Drawing.Size(249, 20)
        Me.TXT4.TabIndex = 69
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 36)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TXT7
        '
        Me.TXT7.Enabled = False
        Me.TXT7.Location = New System.Drawing.Point(167, 370)
        Me.TXT7.Name = "TXT7"
        Me.TXT7.Size = New System.Drawing.Size(249, 20)
        Me.TXT7.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(199, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Actualizar Inventario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(194, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 36)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Insertar y Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Precio Venta $"
        '
        'TXT2
        '
        Me.TXT2.Location = New System.Drawing.Point(194, 215)
        Me.TXT2.Name = "TXT2"
        Me.TXT2.Size = New System.Drawing.Size(222, 20)
        Me.TXT2.TabIndex = 83
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 13)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Actualización Por Nombre"
        '
        'TXT1
        '
        Me.TXT1.Location = New System.Drawing.Point(194, 185)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.Size = New System.Drawing.Size(222, 20)
        Me.TXT1.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Actulización Por Código"
        '
        'Modificar_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 485)
        Me.Controls.Add(Me.TXT2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT6)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXT8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TXT7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Modificar_Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar_Inventario"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT6 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT8 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT3 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT4 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TXT7 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT1 As TextBox
    Friend WithEvents Label8 As Label
End Class

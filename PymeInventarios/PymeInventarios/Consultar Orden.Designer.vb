﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Orden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consultar_Orden))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CBO2 = New System.Windows.Forms.ComboBox()
        Me.TXT1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(382, 390)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 55)
        Me.Button3.TabIndex = 80
        Me.Button3.Text = "Atrás"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(254, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 55)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "Limpiar Campos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 55)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Buscar Órden"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Búsqueda Por Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Búsqueda Por Código Pedido"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(36, 198)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(561, 181)
        Me.DataGridView1.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(239, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Consulta de Órdenes de Compra"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(273, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'CBO2
        '
        Me.CBO2.FormattingEnabled = True
        Me.CBO2.Location = New System.Drawing.Point(267, 162)
        Me.CBO2.Name = "CBO2"
        Me.CBO2.Size = New System.Drawing.Size(207, 21)
        Me.CBO2.TabIndex = 85
        Me.CBO2.Text = "Seleccione"
        '
        'TXT1
        '
        Me.TXT1.Location = New System.Drawing.Point(267, 135)
        Me.TXT1.Name = "TXT1"
        Me.TXT1.Size = New System.Drawing.Size(207, 20)
        Me.TXT1.TabIndex = 86
        '
        'Consultar_Orden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 457)
        Me.Controls.Add(Me.TXT1)
        Me.Controls.Add(Me.CBO2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Consultar_Orden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar_Orden"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CBO2 As ComboBox
    Friend WithEvents TXT1 As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte_Ordenes_Compra
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 53)
        Me.Panel1.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(138, 21)
        Me.DateTimePicker1.MinDate = New Date(1901, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 120
        Me.DateTimePicker1.Value = New Date(2021, 7, 17, 0, 0, 0, 0)
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker2.Location = New System.Drawing.Point(265, 21)
        Me.DateTimePicker2.MinDate = New Date(1901, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker2.TabIndex = 121
        Me.DateTimePicker2.Value = New Date(2021, 7, 17, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(287, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Fecha Final"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(401, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 53)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(690, 393)
        Me.ReportViewer1.TabIndex = 1
        '
        'Reporte_Ordenes_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 446)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Reporte_Ordenes_Compra"
        Me.Text = "Reporte_Ordenes_Compra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class

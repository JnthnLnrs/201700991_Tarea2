<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CompraDollar = New System.Windows.Forms.RadioButton()
        Me.CompraPMX = New System.Windows.Forms.RadioButton()
        Me.CompraEuro = New System.Windows.Forms.RadioButton()
        Me.CompraCCR = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.VentaCCR = New System.Windows.Forms.RadioButton()
        Me.VentaEuro = New System.Windows.Forms.RadioButton()
        Me.VentaPMX = New System.Windows.Forms.RadioButton()
        Me.VentaDollar = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(98, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transacciones"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Compra"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(15, 42)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Venta"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtVenta)
        Me.GroupBox2.Controls.Add(Me.txtCompra)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(249, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(158, 71)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Compra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Venta"
        '
        'txtCompra
        '
        Me.txtCompra.Enabled = False
        Me.txtCompra.Location = New System.Drawing.Point(70, 19)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(71, 20)
        Me.txtCompra.TabIndex = 2
        '
        'txtVenta
        '
        Me.txtVenta.Enabled = False
        Me.txtVenta.Location = New System.Drawing.Point(70, 45)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(71, 20)
        Me.txtVenta.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CompraCCR)
        Me.GroupBox3.Controls.Add(Me.CompraEuro)
        Me.GroupBox3.Controls.Add(Me.CompraPMX)
        Me.GroupBox3.Controls.Add(Me.CompraDollar)
        Me.GroupBox3.Location = New System.Drawing.Point(132, 148)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(104, 119)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Compra"
        '
        'CompraDollar
        '
        Me.CompraDollar.AutoSize = True
        Me.CompraDollar.Location = New System.Drawing.Point(6, 19)
        Me.CompraDollar.Name = "CompraDollar"
        Me.CompraDollar.Size = New System.Drawing.Size(52, 17)
        Me.CompraDollar.TabIndex = 0
        Me.CompraDollar.TabStop = True
        Me.CompraDollar.Text = "Dollar"
        Me.CompraDollar.UseVisualStyleBackColor = True
        '
        'CompraPMX
        '
        Me.CompraPMX.AutoSize = True
        Me.CompraPMX.Location = New System.Drawing.Point(6, 42)
        Me.CompraPMX.Name = "CompraPMX"
        Me.CompraPMX.Size = New System.Drawing.Size(68, 17)
        Me.CompraPMX.TabIndex = 1
        Me.CompraPMX.TabStop = True
        Me.CompraPMX.Text = "Peso MX"
        Me.CompraPMX.UseVisualStyleBackColor = True
        '
        'CompraEuro
        '
        Me.CompraEuro.AutoSize = True
        Me.CompraEuro.Location = New System.Drawing.Point(6, 65)
        Me.CompraEuro.Name = "CompraEuro"
        Me.CompraEuro.Size = New System.Drawing.Size(47, 17)
        Me.CompraEuro.TabIndex = 2
        Me.CompraEuro.TabStop = True
        Me.CompraEuro.Text = "Euro"
        Me.CompraEuro.UseVisualStyleBackColor = True
        '
        'CompraCCR
        '
        Me.CompraCCR.AutoSize = True
        Me.CompraCCR.Location = New System.Drawing.Point(6, 88)
        Me.CompraCCR.Name = "CompraCCR"
        Me.CompraCCR.Size = New System.Drawing.Size(81, 17)
        Me.CompraCCR.TabIndex = 3
        Me.CompraCCR.TabStop = True
        Me.CompraCCR.Text = "Colones CR"
        Me.CompraCCR.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.VentaCCR)
        Me.GroupBox4.Controls.Add(Me.VentaEuro)
        Me.GroupBox4.Controls.Add(Me.VentaPMX)
        Me.GroupBox4.Controls.Add(Me.VentaDollar)
        Me.GroupBox4.Location = New System.Drawing.Point(249, 148)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(104, 119)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Venta"
        '
        'VentaCCR
        '
        Me.VentaCCR.AutoSize = True
        Me.VentaCCR.Location = New System.Drawing.Point(6, 88)
        Me.VentaCCR.Name = "VentaCCR"
        Me.VentaCCR.Size = New System.Drawing.Size(81, 17)
        Me.VentaCCR.TabIndex = 3
        Me.VentaCCR.TabStop = True
        Me.VentaCCR.Text = "Colones CR"
        Me.VentaCCR.UseVisualStyleBackColor = True
        '
        'VentaEuro
        '
        Me.VentaEuro.AutoSize = True
        Me.VentaEuro.Location = New System.Drawing.Point(6, 65)
        Me.VentaEuro.Name = "VentaEuro"
        Me.VentaEuro.Size = New System.Drawing.Size(47, 17)
        Me.VentaEuro.TabIndex = 2
        Me.VentaEuro.TabStop = True
        Me.VentaEuro.Text = "Euro"
        Me.VentaEuro.UseVisualStyleBackColor = True
        '
        'VentaPMX
        '
        Me.VentaPMX.AutoSize = True
        Me.VentaPMX.Location = New System.Drawing.Point(6, 42)
        Me.VentaPMX.Name = "VentaPMX"
        Me.VentaPMX.Size = New System.Drawing.Size(68, 17)
        Me.VentaPMX.TabIndex = 1
        Me.VentaPMX.TabStop = True
        Me.VentaPMX.Text = "Peso MX"
        Me.VentaPMX.UseVisualStyleBackColor = True
        '
        'VentaDollar
        '
        Me.VentaDollar.AutoSize = True
        Me.VentaDollar.Location = New System.Drawing.Point(6, 19)
        Me.VentaDollar.Name = "VentaDollar"
        Me.VentaDollar.Size = New System.Drawing.Size(52, 17)
        Me.VentaDollar.TabIndex = 0
        Me.VentaDollar.TabStop = True
        Me.VentaDollar.Text = "Dollar"
        Me.VentaDollar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(359, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(359, 244)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 336)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CompraCCR As System.Windows.Forms.RadioButton
    Friend WithEvents CompraEuro As System.Windows.Forms.RadioButton
    Friend WithEvents CompraPMX As System.Windows.Forms.RadioButton
    Friend WithEvents CompraDollar As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents VentaCCR As System.Windows.Forms.RadioButton
    Friend WithEvents VentaEuro As System.Windows.Forms.RadioButton
    Friend WithEvents VentaPMX As System.Windows.Forms.RadioButton
    Friend WithEvents VentaDollar As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class

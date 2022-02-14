Module Module1
    Public tcDollar = 7.69
    Public tcPesoMX = 0.38
    Public tcEuro = 7.89
    Public tcColonCR = 0.012

    Const comisionCompra = 2.5 / 100
    Const comisionVenta = 3 / 100

    Dim total_parcial = 0
    Dim total


    Sub limpiar()
        Form1.txtCompra.Clear()
        Form1.txtVenta.Clear()
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False

        Form2.Label1.Text = "Limpio"

    End Sub

    Function calcularCompra(ByVal cantidadCompra As Double, ByVal tipoCompra As Double) As Double
        If cantidadCompra > 0 Then
            total_parcial = cantidadCompra / tipoCompra
            total = total_parcial * comisionCompra + total_parcial
        End If
        Return Math.Round(total, 2)
    End Function

    Function calcularVenta(ByVal cantidadVenta As Double, ByVal tipoVenta As Double) As Double
        If cantidadVenta > 0 Then
            total_parcial = cantidadVenta * tipoVenta
            total = total_parcial * comisionVenta + total_parcial
        End If
        Return Math.Round(total, 2)
    End Function
   

End Module

Public Class Form1


    Const precioArroz As Double = 2.0
    Const precioFrijol As Double = 1.75
    Const precioAzucar As Double = 2.5
    Const IVA As Double = 0.12

    Dim pagoSinIVA As Double = 0
    Dim ValorIVA As Double = 0
    Dim pagoConIVA As Double = 0
    Dim descuento As Double = 0
    Dim pagofinal As Double = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        pagoSinIVA = (Val(txtArroz.Text) * precioArroz) + (Val(TxtFrijol.Text) * precioFrijol) + (Val(txtAzucar.Text) * precioAzucar)
        
        ValorIVA = pagoSinIVA * IVA

        pagoConIVA = pagoSinIVA + ValorIVA

        descuento = pagoConIVA * 0.025

        pagofinal = pagoConIVA - descuento


        lblR1.Text = pagoSinIVA
        lblR2.Text = ValorIVA
        lblR3.Text = pagoConIVA
        lblR4.Text = descuento
        lblR5.Text = pagofinal


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        lblR1.Clear()
        lblR2.Clear()
        lblR3.Clear()
        lblR4.Clear()
        lblR5.Clear()

        txtArroz.Clear()
        TxtFrijol.Clear()
        txtAzucar.Clear()

        txtArroz.Focus()


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        End

    End Sub
End Class

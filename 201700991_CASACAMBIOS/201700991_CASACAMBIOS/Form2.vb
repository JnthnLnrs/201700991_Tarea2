Public Class Form2

    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Form1.Show()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Form1.CompraDollar.Checked Then
            Val(Form1.txtCompra.Text)

            Label1.Text = "La cantidad de tu compra es" + Str(calcularCompra(Val(Form1.txtCompra.Text), tcDollar))


        ElseIf Form1.VentaDollar.Checked Then
            Label1.Text = "La cantidad de tu venta es" + Str(calcularVenta(Val(Form1.txtVenta.Text), tcDollar))

        End If

    End Sub
End Class
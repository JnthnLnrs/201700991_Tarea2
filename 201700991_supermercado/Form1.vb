Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Double
        Dim subtotal As Double
        Dim deseada As Double
        Dim sobrante As Double
        Dim descuento As Double
        Dim rebaja As Double
        Dim total As Double
        Dim pack As Integer
        Dim stock As Integer
        If ComboBox1.Text = "" Then
            MsgBox("Seleccione un articulo ", MsgBoxStyle.Information, "Advertencia ")
        Else
            deseada = TextBox2.Text
            sobrante = TextBox3.Text
            pack = sobrante / deseada
            stock = deseada Mod sobrante

            Select Case ComboBox1.SelectedItem
                Case "Jugos"
                    valor = 8.5
                Case "Frituras"
                    valor = 11.2
                Case "Galletas"
                    valor = 4.25
                Case "Baterias"
                    valor = 15
            End Select

            If deseada >= 1 And deseada <= 4 Then
                descuento = 0.03
            ElseIf deseada >= 5 And deseada <= 10 Then
                descuento = 0.05
            ElseIf deseada <= 11 Then
                descuento = 0.1
            End If

            rebaja = deseada * descuento
            subtotal = deseada * valor
            total = subtotal - subtotal * rebaja






            If indice < 6 Then

                matriz(0, indice) = TextBox1.Text
                matriz(1, indice) = ComboBox1.SelectedItem
                matriz(2, indice) = TextBox3.Text
                matriz(3, indice) = TextBox2.Text
                matriz(4, indice) = pack
                matriz(5, indice) = stock
                matriz(6, indice) = subtotal
                matriz(7, indice) = rebaja
                matriz(8, indice) = total

                DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), matriz(7, indice), matriz(8, indice))
                indice = indice + 1
                limpieza()



            Else
                MessageBox.Show("Llego al limite")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpieza()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea Salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Close()
        Else
            limpieza()
        End If
    End Sub
End Class

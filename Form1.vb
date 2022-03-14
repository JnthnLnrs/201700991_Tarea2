Public Class Form1


    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        If txtCarnet.Text = "" Then
            MsgBox("Error Campo Carnet")
            Exit Sub
        End If

        If txtNombre.Text = "" Then
            MsgBox("Error Campo Nombre")
            Exit Sub
        End If

        If cbxIdioma.SelectedIndex = -1 Then
            MsgBox("Error Campo Idioma")
            Exit Sub
        End If

        If cbxDias.SelectedIndex = -1 Then
            MsgBox("Error Campo Dias")
            Exit Sub
        End If

        If txtHoras.Text = "" Then
            MsgBox("Error Campo Horas")
            Exit Sub
        End If

        Const precioIngles As Double = 150
        Const precioPortugues As Double = 80
        Const precioFrances As Double = 125

        Dim PagoParcial As Double = 0
        Dim Descuento1 As Double = 0
        Dim Descuento2 As Double = 0
        Dim Total As Double = 0



        If indice < 8 Then
            matriz(0, indice) = txtCarnet.Text
            matriz(1, indice) = txtNombre.Text
            matriz(2, indice) = cbxIdioma.SelectedItem
            matriz(3, indice) = dtpFecha.Value
            matriz(4, indice) = cbxDias.SelectedItem
            matriz(5, indice) = txtHoras.Text

            If rbCheque.Checked Then
                matriz(6, indice) = rbCheque.Text
            ElseIf rbEfectivo.Checked Then
                matriz(6, indice) = rbEfectivo.Text

            End If

            PagoParcial = precioIngles * txtHoras.Text
            matriz(7, indice) = Math.Round(PagoParcial, 2)

            PagoParcial = precioPortugues * txtHoras.Text
            matriz(7, indice) = Math.Round(PagoParcial, 2)

            PagoParcial = precioFrances * txtHoras.Text
            matriz(7, indice) = Math.Round(PagoParcial, 2)



            DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), matriz(7, indice), 0, 0, 0)
            indice = indice + 1

        Else
            MessageBox.Show("Ya se llego al limite")
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea Salir?", vbYesNo) = vbYes Then
            End
        End If

    End Sub
End Class

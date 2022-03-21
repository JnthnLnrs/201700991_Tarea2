Public Class Form1

    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click

        If ComboBox1.SelectedIndex = -1 Or ComboBox2.SelectedIndex = -1 Then
            MsgBox("Seleccione todos los campos")
            Exit Sub
        End If

        If contador < 8 Then
            numeroventa(contador) = contador + 1
            Tamaño(contador) = ComboBox1.SelectedItem
            material(contador) = ComboBox2.SelectedItem


            Select Case Tamaño(contador)
                Case "Sofa"
                    Select Case material(contador)
                        Case "Cuero"
                            precioManoObra(contador) = 8 * pSofa
                            precioCosto(contador) = 8 * pCuero + precioManoObra(contador)
                        Case "Cuerina"
                            precioManoObra(contador) = 8 * pSofa
                            precioCosto(contador) = 8 * pCuerina + precioManoObra(contador)

                    End Select

                Case "Individual"
                    Select Case material(contador)
                        Case "Cuero"
                            precioManoObra(contador) = 8 * pIndividual
                            precioCosto(contador) = 8 * pCuero + precioManoObra(contador)
                        Case "Cuerina"
                            precioManoObra(contador) = 8 * pIndividual
                            precioCosto(contador) = 8 * pCuerina + precioManoObra(contador)
                    End Select

                Case "Doble"
                    Select Case material(contador)
                        Case "Cuero"
                            precioManoObra(contador) = 8 * pDoble
                            precioCosto(contador) = 8 * pDoble + precioManoObra(contador)
                        Case "Cuerina"
                            precioManoObra(contador) = 8 * pDoble
                            precioCosto(contador) = 8 * pCuerina + precioManoObra(contador)
                    End Select

            End Select

            preecioVenta(contador) = precioCosto(contador) * 1.65


            ListBox1.Items.Add(numeroventa(contador))
            ListBox2.Items.Add(tamaño(contador))
            ListBox3.Items.Add(material(contador))
            ListBox4.Items.Add(precioCosto(contador))
            ListBox5.Items.Add(precioManoObra(contador))
            ListBox6.Items.Add(preecioVenta(contador))


        Else
            MsgBox("Ha lllegado al limite de  registros")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ReDim contador(8)

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

        Dim respuesta As Integer

        respuesta = MsgBox("¿Esta seguro que desea salir?", vbQuestion + vbYesNo, "Confirmacion")

        If respuesta = vbYesNo Then

        End If
        End

    End Sub
End Class

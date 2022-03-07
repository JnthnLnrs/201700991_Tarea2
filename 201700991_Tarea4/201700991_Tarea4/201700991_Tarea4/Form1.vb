Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Or RadioButton2.Checked = True Or RadioButton3.Checked = True Then
            If CheckBox1.Checked = True Or CheckBox2.Checked = True Or CheckBox3.Checked = True Then
                If RadioButton4.Checked = True Or RadioButton5.Checked = True Or RadioButton6.Checked = True Or RadioButton7.Checked = True Then
                    agregar()
                Else
                    MsgBox("Seleccione un tipo de pago  ", MsgBoxStyle.Information, "Registro ")
                End If

            Else
                MsgBox("Seleccione un tipo de servicio  ", MsgBoxStyle.Information, "Registro ")
            End If

        Else
            MsgBox("Seleccione un tipo de cama  ", MsgBoxStyle.Information, "Registro ")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If MsgBox("¿Desea Salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Close()
        Else
            limpieza()
        End If
    End Sub
End Class

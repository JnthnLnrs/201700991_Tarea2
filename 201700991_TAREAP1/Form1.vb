Public Class Form1


    Private Sub calcular_Click(sender As Object, e As EventArgs)
        calculo()
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs)
        borrar()
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CalculoToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        calculo()
    End Sub







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        calculo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        borrar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("¿Desea Salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            Close()
        Else
            borrar()
        End If
    End Sub
End Class

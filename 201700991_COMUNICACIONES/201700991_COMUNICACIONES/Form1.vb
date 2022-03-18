Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtNombre.Text = "" Then
            MsgBox("Error No Ingreso el Nombre")
            Exit Sub
        End If

        If txtSalario.Text = "" Then
            MsgBox("Error No Ingreso el Salario")
            Exit Sub
        End If

        If cbxArticulo.SelectedIndex = -1 Then
            MsgBox("Error No Ingreso Ningun Articulo")
            Exit Sub
        End If

        If txtCantidad.Text = "" Then
            MsgBox("Error Ingrese la Cantidad")
            Exit Sub
        End If

        Const precioTablet As Double = 375
        Const precioDrone As Double = 560
        Const precioCelular As Double = 1450
        Const precioTelevisor As Double = 3250

        Dim Comision As Double = 0
        Dim Descuento1 As Double = 0
        Dim Descuento2 As Double = 0
        Dim Total As Double = 0



        If indice < 7 Then
            matriz(0, indice) = txtNombre.Text
            matriz(1, indice) = txtSalario.Text
            matriz(2, indice) = cbxArticulo.SelectedItem
            matriz(3, indice) = txtCantidad.Text


        End If


        If cbxArticulo.SelectedIndex = 0 Then
            Comision = Val(precioTablet * txtCantidad.Text)
            matriz(5, indice) = Math.Round(Comision, 2)

        ElseIf cbxArticulo.SelectedIndex = 1 Then
            Comision = Val(precioDrone * txtCantidad.Text)
            matriz(5, indice) = Math.Round(Comision, 2)

        ElseIf cbxArticulo.SelectedIndex = 2 Then
            Comision = Val(precioCelular * txtCantidad.Text)
            matriz(5, indice) = Math.Round(Comision, 2)

        ElseIf cbxArticulo.SelectedIndex = 3 Then
            Comision = Val(precioTelevisor * txtCantidad.Text)
            matriz(5, indice) = Math.Round(Comision, 2)

        End If







       




    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DataGridView1.Rows.Add(indice + 1, matriz(0, indice), matriz(1, indice), matriz(2, indice), matriz(3, indice), matriz(4, indice), matriz(5, indice), matriz(6, indice), matriz(7, indice), 0, 0, 0)
        indice = indice + 1

        Else
        MessageBox.Show("Ya se llego al limite")
        End If

    End Sub
End Class

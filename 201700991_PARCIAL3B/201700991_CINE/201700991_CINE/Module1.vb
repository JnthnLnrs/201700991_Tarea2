Module Module1
    Dim fila As String = 0
    Dim nombre(6) As String
    Dim nit(6), boletos(6), precio(6), total(6), sala(6) As String
    Dim normal, tres, DX As String
    Dim i As String = 0

    Public Sub agregar()

        nit(i) = Form1.TextBox1.Text
        nombre(i) = Form1.TextBox2.Text
        boletos(i) = Form1.TextBox3.Text


        Select Case Form1.ComboBox1.SelectedItem
            Case "Normal"
                precio(i) = 44
                sala(i) = "Normal"
                normal = normal + 1
            Case "3D"
                precio(i) = 62
                sala(i) = "3D"
                tres = tres + 1
            Case "4DX"
                precio(i) = 104
                sala(i) = "4DX"
                DX = DX + 1
        End Select

        total(i) = precio(i) * boletos(i)



        If i = 6 Then
            MsgBox("Llego al limite de usuarios registrados  ", MsgBoxStyle.Information, "ADVERTENCIA")
        Else
            i = i + 1
            MsgBox("Se agrego con exito ", MsgBoxStyle.Information, "REGISTRO")
            Form1.TextBox1.Clear()
            Form1.TextBox2.Clear()
            Form1.TextBox3.Clear()

        End If

    End Sub
    Public Sub mostrar()
        Dim x As String = 0
        Form1.DataGridView1.Rows.Clear()

        While (x <= (i - 1))
            Form1.DataGridView1.Rows.Add(nit(x), nombre(x), boletos(x), sala(x), Str(total(x)))
            x += 1
        End While



    End Sub
    Public Sub limpiarvectores()
        Dim j As Integer
        For j = 0 To 6
            nombre(j) = Nothing
            nit(j) = Nothing
            boletos(j) = Nothing
            total(j) = Nothing
            sala(j) = Nothing
        Next
        i = 0
        normal = 0
        tres = 0
        DX = 0
        Form1.DataGridView1.Rows.Clear()
    End Sub
    Public Sub buscar()
        Dim h, busqueda As Integer
        For h = 1 To 7
            busqueda = Form1.TextBox4.Text
            If nit(h) = busqueda Then
                Form1.DataGridView1.Rows.Clear()
                Form1.DataGridView1.Rows.Add(nit(busqueda), nombre(busqueda), boletos(busqueda), sala(busqueda), Str(total(busqueda)))
            End If
        Next

    End Sub
    Public Sub actualizar()
        Dim h, busqueda As Integer
        For h = 1 To 7
            busqueda = Form1.TextBox5.Text
            If nit(h) = busqueda Then
                MsgBox("actualizado")
            End If
        Next
    End Sub
End Module

Module Module1

    Dim nombre(5) As String
    Dim apellido(5) As String
    Dim dias(5) As Single
    Dim honorarios(5) As Single
    Dim precio(5) As Single
    Dim descuento(5) As Single
    Dim calculo(5) As Single
    Dim total(5) As Single
    Dim rebaja(5) As Single

    Dim i As String = 0
    Public Sub agregar()
        nombre(i) = Form1.TextBox1.Text
        apellido(i) = Form1.TextBox2.Text
        dias(i) = CSng(Form1.TextBox3.Text)
        honorarios(i) = CSng(Form1.TextBox4.Text)

        If Form1.CheckBox1.Checked Then
            If Form1.RadioButton1.Checked Then
                precio(i) = 350
            ElseIf Form1.RadioButton2.Checked Then
                precio(i) = 250
            ElseIf Form1.RadioButton3.Checked Then
                precio(i) = 150

            End If
        ElseIf Form1.CheckBox2.Checked Then
            If Form1.RadioButton1.Checked Then
                precio(i) = 550
            ElseIf Form1.RadioButton2.Checked Then
                precio(i) = 400
            ElseIf Form1.RadioButton3.Checked Then
                precio(i) = 300

            End If
        ElseIf Form1.CheckBox3.Checked Then
            If Form1.RadioButton1.Checked Then
                precio(i) = 450
            ElseIf Form1.RadioButton2.Checked Then
                precio(i) = 350
            ElseIf Form1.RadioButton3.Checked Then
                precio(i) = 250

            End If

        End If

        If Form1.CheckBox1.Checked And Form1.CheckBox2.Checked Then
            If Form1.RadioButton1.Checked Then
                precio(i) = 900
            ElseIf Form1.RadioButton2.Checked Then
                precio(i) = 650
            ElseIf Form1.RadioButton3.Checked Then
                precio(i) = 450
            End If
        ElseIf Form1.CheckBox3.Checked And Form1.CheckBox2.Checked Then
            If Form1.RadioButton1.Checked Then
                precio(i) = 1000
            ElseIf Form1.RadioButton2.Checked Then
                precio(i) = 750
            ElseIf Form1.RadioButton3.Checked Then
                precio(i) = 550
            End If
        End If

        If Form1.CheckBox1.Checked And Form1.CheckBox2.Checked And Form1.CheckBox3.Checked Then
            If Form1.RadioButton1.Checked Then
                precio(i) = 1350
            ElseIf Form1.RadioButton2.Checked Then
                precio(i) = 1000
            ElseIf Form1.RadioButton3.Checked Then
                precio(i) = 750
            End If
        End If

        If Form1.RadioButton4.Checked Or Form1.RadioButton5.Checked Then
            descuento(i) = 0.15
        ElseIf Form1.RadioButton6.Checked Then
            descuento(i) = 0.08
        ElseIf Form1.RadioButton7.Checked Then
            descuento(i) = 0.05
        End If
        'subtotal
        calculo(i) = dias(i) * precio(i) + honorarios(i)
        'total
        total(i) = calculo(i) - calculo(i) * descuento(i)
        ' descuento
        rebaja(i) = calculo(i) * descuento(i)

        MsgBox("Se agrego con exito ", MsgBoxStyle.Information, "REGISTRO")
        If i = 5 Then
            MsgBox("Llego al limite de usuarios registrados  ", MsgBoxStyle.Information, "ADVERTENCIA")
        Else
            i = i + 1
            Form1.TextBox1.Clear()
            Form1.TextBox2.Clear()
            Form1.TextBox3.Clear()
            Form1.TextBox4.Clear()
            Form1.RadioButton1.Checked = 0
            Form1.RadioButton2.Checked = 0
            Form1.RadioButton3.Checked = 0
            Form1.RadioButton4.Checked = 0
            Form1.RadioButton5.Checked = 0
            Form1.RadioButton6.Checked = 0
            Form1.RadioButton7.Checked = 0
            Form1.CheckBox1.Checked = 0
            Form1.CheckBox2.Checked = 0
            Form1.CheckBox3.Checked = 0
        End If
    End Sub
    Public Sub mostrar()
        Dim x As String = 0
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()

        While (x <= (i - 1))
            Form1.ListBox1.Items.Add("Nombre Del paciente" & nombre(x) & " " & apellido(x) & " dias internado" & dias(x))
            Form1.ListBox2.Items.Add("Subtotal a pagar Q." & calculo(x))
            Form1.ListBox3.Items.Add("Descuento efectuado Q." & rebaja(x))
            Form1.ListBox4.Items.Add("Total a pagar Q." & total(x))

            x += 1
        End While
    End Sub
    Public Sub limpieza()
        Form1.TextBox1.Clear()
        Form1.TextBox2.Clear()
        Form1.TextBox3.Clear()
        Form1.TextBox4.Clear()
        Form1.RadioButton1.Checked = 0
        Form1.RadioButton2.Checked = 0
        Form1.RadioButton3.Checked = 0
        Form1.RadioButton4.Checked = 0
        Form1.RadioButton5.Checked = 0
        Form1.RadioButton6.Checked = 0
        Form1.RadioButton7.Checked = 0
        Form1.CheckBox1.Checked = 0
        Form1.CheckBox2.Checked = 0
        Form1.CheckBox3.Checked = 0
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
    End Sub
End Module

Imports System.Math
Module Module1
    Dim total As Double
    Dim yarda As Double
    Dim modelo As Double
    Dim obra As Double
    Dim pfinal As Double
    Dim pseda As Double
    Dim plino As Double
    Dim palgodon As Double
    Dim philo As Double
    Dim precio As Double


    Public Sub calculo()


        If Form1.T1.Checked Then
            modelo = 65.5
            yarda = 2
        ElseIf Form1.T2.Checked Then
            modelo = 85.99
            yarda = 2.5
        ElseIf Form1.T3.Checked Then
            modelo = 99.99
            yarda = 3
        Else
            MsgBox("No selecciono ningun tamaño", MsgBoxStyle.Information, "ADVERTENCIA ")
        End If
        If Form1.m1.Checked Then
            precio = Val(Form1.lino.Text) * 15
            obra = Val(Form1.lino.Text) * modelo
            plino = precio
        ElseIf Form1.m2.Checked Then
            precio = Val(Form1.algodon.Text) * 23.99
            obra = Val(Form1.algodon.Text) * modelo
            palgodon = precio
        ElseIf Form1.m3.Checked Then
            precio = Val(Form1.seda.Text) * 30.99
            obra = Val(Form1.seda.Text) * modelo
            pseda = precio
        Else
            MsgBox("No selecciono ninguna casilla ", MsgBoxStyle.Information, "ADVERTENCIA ")
        End If
        If Form1.m1.Checked And Form1.m2.Checked Then
            precio = Val(Form1.lino.Text) * 15 + Val(Form1.algodon.Text) * 23.99
            obra = Val(Form1.lino.Text) * modelo + Val(Form1.algodon.Text) * modelo
            plino = Val(Form1.lino.Text) * 15
            palgodon = Val(Form1.algodon.Text) * 23.99
        ElseIf Form1.m1.Checked And Form1.m3.Checked Then
            precio = Val(Form1.lino.Text) * 15 + Val(Form1.seda.Text) * 30.99
            obra = Val(Form1.lino.Text) * modelo + Val(Form1.seda.Text) * modelo
            plino = Val(Form1.lino.Text) * 15
            pseda = Val(Form1.seda.Text) * 30.99
        ElseIf Form1.m2.Checked And Form1.m3.Checked Then
            precio = Val(Form1.algodon.Text) * 23.99 + Val(Form1.seda.Text) * 30.99
            obra = Val(Form1.algodon.Text) * modelo + Val(Form1.seda.Text) * modelo
            palgodon = Val(Form1.algodon.Text) * 23.99
            pseda = Val(Form1.seda.Text) * 30.99
        End If
        If Form1.m1.Checked And Form1.m2.Checked And Form1.m3.Checked Then
            precio = Val(Form1.lino.Text) * 15 + Val(Form1.algodon.Text) * 23.99 + Val(Form1.seda.Text) * 30.99
            obra = Val(Form1.lino.Text) * modelo + Val(Form1.algodon.Text) * modelo + Val(Form1.seda.Text) * modelo
            plino = Val(Form1.lino.Text) * 15
            palgodon = Val(Form1.algodon.Text) * 23.99
            pseda = Val(Form1.seda.Text) * 30.99
        End If
        total = Val(Form1.algodon.Text) + Val(Form1.seda.Text) + Val(Form1.lino.Text)
        If Form1.T1.Checked Then
            If total > yarda Then
                MsgBox("Se sobrepasa el numero de yardas ", MsgBoxStyle.Information, "ADVERTENCIA ")
            End If
        End If
        If Form1.T2.Checked Then
            If total > yarda Then
                MsgBox("Se sobrepasa el numero de yardas ", MsgBoxStyle.Information, "ADVERTENCIA ")
            End If
        End If
        If Form1.T3.Checked Then
            If total > yarda Then
                MsgBox("Se sobrepasa el numero de yardas ", MsgBoxStyle.Information, "ADVERTENCIA ")
            End If
        End If
        pfinal = precio + obra

        'Precio de mano de obra
        Form1.lobra.Items.Add("El precio de mano de obra Q.  " & obra)
        'Precio final
        Form1.lventas.Items.Add("Total es Q.  " & pfinal)
    End Sub




    Public Sub borrar()
        Form1.lino.Clear()
        Form1.algodon.Clear()
        Form1.seda.Clear()
        Form1.lobra.Items.Clear()
        Form1.lventas.Items.Clear()
        Form1.yardas.Items.Clear()



    End Sub
End Module

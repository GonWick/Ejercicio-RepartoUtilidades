Public Class Utilidades
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSalario.TextChanged

    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        'Declaración de Variables
        Dim salario As Double
        Dim antiguedad As Short
        Dim utilidad As Short

        'Entrada de datos
        salario = Val(TextBoxSalario.Text)
        antiguedad = Val(TextBoxAntiguedad.Text)
        'Proceso
        If (antiguedad < 1) Then
            utilidad = salario * 5 / 100
        ElseIf (antiguedad >= 1 And antiguedad < 2) Then
            utilidad = salario * 7 / 100
        ElseIf (antiguedad >= 2 And antiguedad < 5) Then
            utilidad = salario * 10 / 100
        ElseIf (antiguedad >= 5 And antiguedad < 10) Then
            utilidad = salario * 15 / 100
        ElseIf (antiguedad >= 10) Then
            utilidad = salario * 20 / 100
        End If
        'Salida de Información
        TextBoxUtilidad.Text = utilidad
        LabelTotal.Text = ("Con " & TextBoxSalario.Text & " € y " & TextBoxAntiguedad.Text & " Años, te corresponden " & TextBoxUtilidad.Text & " €")
    End Sub

    Private Sub ButtonNuevo_Click(sender As Object, e As EventArgs) Handles ButtonNuevo.Click
        TextBoxSalario.Clear()
        TextBoxUtilidad.Clear()
        TextBoxAntiguedad.Clear()
        LabelTotal.Text = ""
    End Sub

    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        Close()
    End Sub
End Class

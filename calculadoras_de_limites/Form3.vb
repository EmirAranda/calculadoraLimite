Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, X As Integer
        If (txtA.Text = "" Or Not (Int32.TryParse(txtA.Text, A))) Then
            MsgBox("debes ingresar un numero a")
        ElseIf (txtB.Text = "" Or Not (Int32.TryParse(txtB.Text, B))) Then
            MsgBox("debes ingresar un numero b")
        ElseIf (txtX.Text = "" Or Not (Int32.TryParse(txtX.Text, X))) Then
            MsgBox("debes ingresar un numero x")
        End If
        Dim cuenta As String = cmbValor.Text
        Dim result As String
        result = A * X
        If cuenta = "+" Then
            result = result + B
        Else
            result = result - B
        End If
        If result = 0 Then
            MsgBox("Error, no se puede calcular a raiz de 0")
        Else
            result = Math.Sqrt(result)
        End If
        lblresult.Text = A & "(" & X & ")" & cuenta & B & " = " & result
    End Sub
    Private Sub btnCif_Click(sender As Object, e As EventArgs) Handles btnCif.Click
        lblresult.Text = "..."
        txtA.Text = "a"
        txtB.Text = "b"
        txtX.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("ah! no me pickes!!!")
    End Sub
End Class
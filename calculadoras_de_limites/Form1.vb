Public Class Form1
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
            lblresult.Text = A & "(" & X & ")" & " + " & B & " = " & result
        Else
            result = result - B
            lblresult.Text = A & "(" & X & ")" & " - " & B & " = " & result
        End If
    End Sub
    Private Sub btnCif_Click(sender As Object, e As EventArgs) Handles btnCif.Click
        lblresult.Text = "..."
        txtA.Text = "a"
        txtB.Text = "b"
        txtX.Text = ""
    End Sub
End Class

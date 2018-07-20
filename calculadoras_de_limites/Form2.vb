Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A, B, X, C, D As Integer
        If (txtA.Text = "" Or Not (Int32.TryParse(txtA.Text, A))) Then
            MsgBox("debes ingresar un numero a")
        ElseIf (txtB.Text = "" Or Not (Int32.TryParse(txtB.Text, B))) Then
            MsgBox("debes ingresar un numero b")
        ElseIf (txtX.Text = "" Or Not (Int32.TryParse(txtX.Text, X))) Then
            MsgBox("debes ingresar un numero x")
        ElseIf (txtC.Text = "" Or Not (Int32.TryParse(txtC.Text, C))) Then
            MsgBox("debes ingresar un numero c")
        ElseIf (txtD.Text = "" Or Not (Int32.TryParse(txtD.Text, D))) Then
            MsgBox("debes ingresar un numero d")
        End If
        Dim cuentaSup As String = cmbValor.Text
        Dim cuentaInf As String = cmbValorInf.Text
        Dim ValResuInf, ValResuSup As String
        ValResuSup = A * X
        X = X * X
        ValResuInf = C * X
        If cuentaSup = "+" Then
            ValResuSup = ValResuSup + B
        Else
            ValResuSup = ValResuSup - B
        End If
        If cuentaInf = "+" Then
            ValResuInf = ValResuInf + D
        Else
            ValResuInf = ValResuInf - D
        End If
        lblresult.Text = ValResuSup & " / " & ValResuInf & " = " & ValResuSup / ValResuInf
    End Sub
    Private Sub btnCif_Click(sender As Object, e As EventArgs) Handles btnCif.Click
        lblresult.Text = "..."
        txtA.Text = "a"
        txtB.Text = "b"
        txtX.Text = ""
        txtA.Text = "c"
        txtB.Text = "d"
        cmbValor.Text = ""
        cmbValorInf.Text = ""
    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCif = New System.Windows.Forms.Button()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.cmbValor = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbValorInf = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCif
        '
        Me.btnCif.Location = New System.Drawing.Point(186, 113)
        Me.btnCif.Name = "btnCif"
        Me.btnCif.Size = New System.Drawing.Size(75, 23)
        Me.btnCif.TabIndex = 27
        Me.btnCif.Text = "Cif"
        Me.btnCif.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Location = New System.Drawing.Point(72, 123)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(16, 13)
        Me.lblresult.TabIndex = 26
        Me.lblresult.Text = "..."
        '
        'cmbValor
        '
        Me.cmbValor.FormattingEnabled = True
        Me.cmbValor.Items.AddRange(New Object() {"+", "-"})
        Me.cmbValor.Location = New System.Drawing.Point(138, 6)
        Me.cmbValor.Name = "cmbValor"
        Me.cmbValor.Size = New System.Drawing.Size(38, 21)
        Me.cmbValor.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(122, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "x"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(182, 7)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(20, 20)
        Me.txtB.TabIndex = 23
        Me.txtB.Text = "b"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Lim"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "x -->"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(70, 87)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(20, 20)
        Me.txtX.TabIndex = 20
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(96, 6)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(20, 20)
        Me.txtA.TabIndex = 19
        Me.txtA.Text = "a"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "f (x) ="
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(185, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbValorInf
        '
        Me.cmbValorInf.FormattingEnabled = True
        Me.cmbValorInf.Items.AddRange(New Object() {"+", "-"})
        Me.cmbValorInf.Location = New System.Drawing.Point(138, 51)
        Me.cmbValorInf.Name = "cmbValorInf"
        Me.cmbValorInf.Size = New System.Drawing.Size(38, 21)
        Me.cmbValorInf.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "x"
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(182, 52)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(20, 20)
        Me.txtD.TabIndex = 30
        Me.txtD.Text = "d"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(96, 51)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(20, 20)
        Me.txtC.TabIndex = 29
        Me.txtC.Text = "c"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "g (x) ="
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "____________________________"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 158)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbValorInf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtD)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCif)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.cmbValor)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtX)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCif As Button
    Friend WithEvents lblresult As Label
    Friend WithEvents cmbValor As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtX As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents cmbValorInf As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtD As TextBox
    Friend WithEvents txtC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
End Class

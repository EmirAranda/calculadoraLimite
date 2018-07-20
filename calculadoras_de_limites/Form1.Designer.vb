<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbValor = New System.Windows.Forms.ComboBox()
        Me.lblresult = New System.Windows.Forms.Label()
        Me.btnCif = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(190, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "f (x) ="
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(68, 25)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(20, 20)
        Me.txtA.TabIndex = 2
        Me.txtA.Text = "a"
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(97, 52)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(20, 20)
        Me.txtX.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "x -->"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Lim"
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(154, 26)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(20, 20)
        Me.txtB.TabIndex = 12
        Me.txtB.Text = "b"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "x"
        '
        'cmbValor
        '
        Me.cmbValor.FormattingEnabled = True
        Me.cmbValor.Items.AddRange(New Object() {"+", "-"})
        Me.cmbValor.Location = New System.Drawing.Point(110, 25)
        Me.cmbValor.Name = "cmbValor"
        Me.cmbValor.Size = New System.Drawing.Size(38, 21)
        Me.cmbValor.TabIndex = 14
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Location = New System.Drawing.Point(79, 91)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(16, 13)
        Me.lblresult.TabIndex = 15
        Me.lblresult.Text = "..."
        '
        'btnCif
        '
        Me.btnCif.Location = New System.Drawing.Point(191, 115)
        Me.btnCif.Name = "btnCif"
        Me.btnCif.Size = New System.Drawing.Size(75, 23)
        Me.btnCif.TabIndex = 16
        Me.btnCif.Text = "Cif"
        Me.btnCif.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 141)
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
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtX As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtG As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtH As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbValor As ComboBox
    Friend WithEvents lblresult As Label
    Friend WithEvents btnCif As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnSignIn = New Button()
        Label5 = New Label()
        Label4 = New Label()
        btnReg = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        Label8 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GrayText
        Panel1.Controls.Add(btnSignIn)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(509, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(569, 624)
        Panel1.TabIndex = 4
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = SystemColors.ActiveBorder
        btnSignIn.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnSignIn.Location = New Point(216, 433)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(155, 45)
        btnSignIn.TabIndex = 7
        btnSignIn.Text = "Sign In"
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(76, 391)
        Label5.Name = "Label5"
        Label5.Size = New Size(427, 28)
        Label5.TabIndex = 6
        Label5.Text = "Already have an account? Click here to Sign In"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(102, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(390, 213)
        Label4.TabIndex = 0
        Label4.Text = "TCU FACULTY MANAGEMENT SYSTEM (TFMS)"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnReg
        ' 
        btnReg.BackColor = SystemColors.ActiveCaption
        btnReg.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnReg.Location = New Point(146, 535)
        btnReg.Name = "btnReg"
        btnReg.Size = New Size(155, 45)
        btnReg.TabIndex = 14
        btnReg.Text = "Register"
        btnReg.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(74, 266)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(296, 27)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(74, 203)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(296, 27)
        TextBox1.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(74, 243)
        Label3.Name = "Label3"
        Label3.Size = New Size(94, 20)
        Label3.TabIndex = 11
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(74, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 10
        Label2.Text = "Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(74, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 38)
        Label1.TabIndex = 9
        Label1.Text = "Create Account"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(74, 334)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(296, 27)
        TextBox3.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(74, 311)
        Label6.Name = "Label6"
        Label6.Size = New Size(91, 20)
        Label6.TabIndex = 15
        Label6.Text = "Password"
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(74, 469)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(296, 27)
        TextBox4.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(74, 446)
        Label7.Name = "Label7"
        Label7.Size = New Size(135, 20)
        Label7.TabIndex = 19
        Label7.Text = "Mobile Number"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox5.Location = New Point(74, 401)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(296, 27)
        TextBox5.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(74, 378)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 20)
        Label8.TabIndex = 17
        Label8.Text = "Email"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1090, 649)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(TextBox5)
        Controls.Add(Label8)
        Controls.Add(TextBox3)
        Controls.Add(Label6)
        Controls.Add(btnReg)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSignIn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnReg As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
End Class

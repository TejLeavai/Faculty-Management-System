<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        btnReg = New Button()
        Label5 = New Label()
        Label4 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        BtnExit = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(80, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 30)
        Label1.TabIndex = 0
        Label1.Text = "Sign In"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(80, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 17)
        Label2.TabIndex = 1
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(80, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 17)
        Label3.TabIndex = 2
        Label3.Text = "Password"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GrayText
        Panel1.Controls.Add(btnReg)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(445, 9)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(498, 468)
        Panel1.TabIndex = 3
        ' 
        ' btnReg
        ' 
        btnReg.BackColor = SystemColors.ActiveBorder
        btnReg.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnReg.Location = New Point(189, 325)
        btnReg.Margin = New Padding(3, 2, 3, 2)
        btnReg.Name = "btnReg"
        btnReg.Size = New Size(136, 34)
        btnReg.TabIndex = 7
        btnReg.Text = "Register"
        btnReg.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label5.Location = New Point(124, 294)
        Label5.Name = "Label5"
        Label5.Size = New Size(243, 21)
        Label5.TabIndex = 6
        Label5.Text = "New Here? Click here to Register"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(89, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(341, 160)
        Label4.TabIndex = 0
        Label4.Text = "TCU FACULTY MANAGEMENT SYSTEM (TFMS)"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(80, 219)
        txtUsername.Margin = New Padding(3, 2, 3, 2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(260, 23)
        txtUsername.TabIndex = 4
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(80, 274)
        txtPassword.Margin = New Padding(3, 2, 3, 2)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(260, 23)
        txtPassword.TabIndex = 5
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ActiveCaption
        btnLogin.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.Location = New Point(136, 334)
        btnLogin.Margin = New Padding(3, 2, 3, 2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(136, 34)
        btnLogin.TabIndex = 8
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' BtnExit
        ' 
        BtnExit.BackColor = SystemColors.ActiveCaption
        BtnExit.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        BtnExit.Location = New Point(136, 385)
        BtnExit.Margin = New Padding(3, 2, 3, 2)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(136, 34)
        BtnExit.TabIndex = 9
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(954, 487)
        Controls.Add(BtnExit)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnReg As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents BtnExit As Button
End Class

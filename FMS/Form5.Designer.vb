<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Save = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonShadow
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(86, 41)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(219, 184)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(74, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 19)
        Label1.TabIndex = 0
        Label1.Text = "PROFILE"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(61, 58)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(156, 254)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 2
        Label2.Text = "Edit Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(139, 323)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 15)
        Label3.TabIndex = 3
        Label3.Text = "Change Password"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(139, 398)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 15)
        Label4.TabIndex = 4
        Label4.Text = "Confirm Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(88, 272)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(218, 23)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(86, 340)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(218, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(86, 415)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(218, 23)
        TextBox3.TabIndex = 7
        ' 
        ' Save
        ' 
        Save.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Save.Location = New Point(156, 466)
        Save.Margin = New Padding(3, 2, 3, 2)
        Save.Name = "Save"
        Save.Size = New Size(79, 30)
        Save.TabIndex = 8
        Save.Text = "SAVE"
        Save.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(399, 527)
        Controls.Add(Save)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Save As Button
End Class

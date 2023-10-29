<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Panel1 = New Panel()
        Button6 = New Button()
        TxtProfilename = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label2 = New Label()
        Panel3 = New Panel()
        Button4 = New Button()
        Panel4 = New Panel()
        MonthCalendar3 = New MonthCalendar()
        MonthCalendar2 = New MonthCalendar()
        MonthCalendar1 = New MonthCalendar()
        Panel5 = New Panel()
        RichTextBox1 = New RichTextBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonShadow
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(TxtProfilename)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(10, 16)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(219, 184)
        Panel1.TabIndex = 0
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(3, 2)
        Button6.Margin = New Padding(3, 2, 3, 2)
        Button6.Name = "Button6"
        Button6.Size = New Size(49, 21)
        Button6.TabIndex = 2
        Button6.Text = "Edit"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' TxtProfilename
        ' 
        TxtProfilename.Location = New Point(14, 154)
        TxtProfilename.Margin = New Padding(3, 2, 3, 2)
        TxtProfilename.Name = "TxtProfilename"
        TxtProfilename.Size = New Size(192, 23)
        TxtProfilename.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(75, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 19)
        Label1.TabIndex = 0
        Label1.Text = "PROFILE"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(60, 53)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(92, 80)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(10, 216)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(219, 356)
        Panel2.TabIndex = 1
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(22, 132)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(173, 22)
        Button3.TabIndex = 5
        Button3.Text = "Grades"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(22, 92)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(173, 22)
        Button2.TabIndex = 4
        Button2.Text = "Schedule"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(22, 52)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 22)
        Button1.TabIndex = 3
        Button1.Text = "Courses"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(44, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 19)
        Label2.TabIndex = 3
        Label2.Text = "Announcements"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ButtonShadow
        Panel3.Controls.Add(Button4)
        Panel3.Location = New Point(248, 16)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(840, 51)
        Panel3.TabIndex = 1
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(746, 14)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 25)
        Button4.TabIndex = 0
        Button4.Text = "Log Out"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ButtonShadow
        Panel4.Controls.Add(MonthCalendar3)
        Panel4.Controls.Add(MonthCalendar2)
        Panel4.Controls.Add(MonthCalendar1)
        Panel4.Location = New Point(248, 84)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(648, 488)
        Panel4.TabIndex = 2
        ' 
        ' MonthCalendar3
        ' 
        MonthCalendar3.Location = New Point(213, 267)
        MonthCalendar3.Margin = New Padding(8, 7, 8, 7)
        MonthCalendar3.MinDate = New Date(2023, 12, 1, 0, 0, 0, 0)
        MonthCalendar3.Name = "MonthCalendar3"
        MonthCalendar3.TabIndex = 2
        ' 
        ' MonthCalendar2
        ' 
        MonthCalendar2.Location = New Point(357, 86)
        MonthCalendar2.Margin = New Padding(8, 7, 8, 7)
        MonthCalendar2.MaxDate = New Date(2023, 11, 30, 0, 0, 0, 0)
        MonthCalendar2.MinDate = New Date(2023, 11, 1, 0, 0, 0, 0)
        MonthCalendar2.Name = "MonthCalendar2"
        MonthCalendar2.TabIndex = 1
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        MonthCalendar1.Location = New Point(80, 71)
        MonthCalendar1.Margin = New Padding(9, 10, 9, 10)
        MonthCalendar1.MaxDate = New Date(2023, 10, 31, 0, 0, 0, 0)
        MonthCalendar1.MinDate = New Date(2023, 10, 1, 0, 0, 0, 0)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ButtonShadow
        Panel5.Controls.Add(RichTextBox1)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(917, 84)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(172, 488)
        Panel5.TabIndex = 2
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BorderStyle = BorderStyle.FixedSingle
        RichTextBox1.Location = New Point(13, 35)
        RichTextBox1.Margin = New Padding(3, 2, 3, 2)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(144, 337)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(52, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 19)
        Label3.TabIndex = 0
        Label3.Text = "Notepad"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1099, 592)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents TxtProfilename As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MonthCalendar3 As MonthCalendar
    Friend WithEvents Button6 As Button
End Class

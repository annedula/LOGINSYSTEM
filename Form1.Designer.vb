<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtUser = New TextBox()
        txtPass = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Segoe UI Variable Small", 12F)
        txtUser.Location = New Point(105, 97)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(224, 29)
        txtUser.TabIndex = 0
        ' 
        ' txtPass
        ' 
        txtPass.Font = New Font("Segoe UI Variable Small", 12F)
        txtPass.Location = New Point(105, 142)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(224, 29)
        txtPass.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(105, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 28)
        Label1.TabIndex = 2
        Label1.Text = "Login System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 21)
        Label2.TabIndex = 3
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Variable Small", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 21)
        Label3.TabIndex = 4
        Label3.Text = "Password:"
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.RoyalBlue
        Button1.Location = New Point(163, 188)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 32)
        Button1.TabIndex = 5
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.MenuBar
        ClientSize = New Size(362, 261)
        Controls.Add(Button1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Name = "Form1"
        Text = "Login Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button

End Class

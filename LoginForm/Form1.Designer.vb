<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.loginbtn = New System.Windows.Forms.Button()
        Me.signuplabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.forgetpasslabel = New System.Windows.Forms.Label()
        Me.passwordtextbox = New System.Windows.Forms.TextBox()
        Me.usernametextbox = New System.Windows.Forms.TextBox()
        Me.hideit = New System.Windows.Forms.PictureBox()
        Me.showpasslogo = New System.Windows.Forms.PictureBox()
        Me.hidepasslogo = New System.Windows.Forms.PictureBox()
        Me.passwordlogo = New System.Windows.Forms.PictureBox()
        Me.usernamelogo = New System.Windows.Forms.PictureBox()
        Me.wallpaper = New System.Windows.Forms.PictureBox()
        Me.inputarea = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.hideit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showpasslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hidepasslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.usernamelogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wallpaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputarea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginbtn
        '
        Me.loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.loginbtn.FlatAppearance.BorderSize = 0
        Me.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbtn.ForeColor = System.Drawing.Color.White
        Me.loginbtn.Location = New System.Drawing.Point(451, 358)
        Me.loginbtn.Margin = New System.Windows.Forms.Padding(0)
        Me.loginbtn.Name = "loginbtn"
        Me.loginbtn.Size = New System.Drawing.Size(74, 21)
        Me.loginbtn.TabIndex = 38
        Me.loginbtn.TabStop = False
        Me.loginbtn.Text = "Login"
        Me.loginbtn.UseVisualStyleBackColor = False
        '
        'signuplabel
        '
        Me.signuplabel.AutoSize = True
        Me.signuplabel.BackColor = System.Drawing.Color.LightGray
        Me.signuplabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signuplabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.signuplabel.Location = New System.Drawing.Point(524, 452)
        Me.signuplabel.Name = "signuplabel"
        Me.signuplabel.Size = New System.Drawing.Size(55, 16)
        Me.signuplabel.TabIndex = 37
        Me.signuplabel.Text = "Sign Up"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LightGray
        Me.Label3.Location = New System.Drawing.Point(402, 454)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Don’t have an account?"
        '
        'forgetpasslabel
        '
        Me.forgetpasslabel.AutoSize = True
        Me.forgetpasslabel.BackColor = System.Drawing.Color.LightGray
        Me.forgetpasslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.forgetpasslabel.Location = New System.Drawing.Point(443, 392)
        Me.forgetpasslabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.forgetpasslabel.Name = "forgetpasslabel"
        Me.forgetpasslabel.Size = New System.Drawing.Size(92, 13)
        Me.forgetpasslabel.TabIndex = 35
        Me.forgetpasslabel.Text = "Forget Password?"
        '
        'passwordtextbox
        '
        Me.passwordtextbox.Location = New System.Drawing.Point(430, 283)
        Me.passwordtextbox.Multiline = True
        Me.passwordtextbox.Name = "passwordtextbox"
        Me.passwordtextbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordtextbox.Size = New System.Drawing.Size(138, 23)
        Me.passwordtextbox.TabIndex = 34
        '
        'usernametextbox
        '
        Me.usernametextbox.Location = New System.Drawing.Point(430, 223)
        Me.usernametextbox.Multiline = True
        Me.usernametextbox.Name = "usernametextbox"
        Me.usernametextbox.Size = New System.Drawing.Size(138, 23)
        Me.usernametextbox.TabIndex = 27
        '
        'hideit
        '
        Me.hideit.BackColor = System.Drawing.Color.White
        Me.hideit.Image = Global.LoginForm.My.Resources.Resources.hide30
        Me.hideit.Location = New System.Drawing.Point(545, 284)
        Me.hideit.Margin = New System.Windows.Forms.Padding(2)
        Me.hideit.Name = "hideit"
        Me.hideit.Size = New System.Drawing.Size(17, 18)
        Me.hideit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hideit.TabIndex = 40
        Me.hideit.TabStop = False
        '
        'showpasslogo
        '
        Me.showpasslogo.BackColor = System.Drawing.Color.White
        Me.showpasslogo.Image = Global.LoginForm.My.Resources.Resources.hide
        Me.showpasslogo.Location = New System.Drawing.Point(545, 284)
        Me.showpasslogo.Margin = New System.Windows.Forms.Padding(2)
        Me.showpasslogo.Name = "showpasslogo"
        Me.showpasslogo.Size = New System.Drawing.Size(17, 18)
        Me.showpasslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.showpasslogo.TabIndex = 33
        Me.showpasslogo.TabStop = False
        '
        'hidepasslogo
        '
        Me.hidepasslogo.BackColor = System.Drawing.Color.White
        Me.hidepasslogo.Image = Global.LoginForm.My.Resources.Resources.show
        Me.hidepasslogo.Location = New System.Drawing.Point(545, 284)
        Me.hidepasslogo.Margin = New System.Windows.Forms.Padding(2)
        Me.hidepasslogo.Name = "hidepasslogo"
        Me.hidepasslogo.Size = New System.Drawing.Size(17, 18)
        Me.hidepasslogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hidepasslogo.TabIndex = 39
        Me.hidepasslogo.TabStop = False
        '
        'passwordlogo
        '
        Me.passwordlogo.BackColor = System.Drawing.Color.LightGray
        Me.passwordlogo.Image = Global.LoginForm.My.Resources.Resources.padlock_2
        Me.passwordlogo.Location = New System.Drawing.Point(386, 285)
        Me.passwordlogo.Margin = New System.Windows.Forms.Padding(2)
        Me.passwordlogo.Name = "passwordlogo"
        Me.passwordlogo.Size = New System.Drawing.Size(20, 21)
        Me.passwordlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.passwordlogo.TabIndex = 32
        Me.passwordlogo.TabStop = False
        '
        'usernamelogo
        '
        Me.usernamelogo.BackColor = System.Drawing.Color.LightGray
        Me.usernamelogo.Image = Global.LoginForm.My.Resources.Resources.user
        Me.usernamelogo.Location = New System.Drawing.Point(386, 223)
        Me.usernamelogo.Margin = New System.Windows.Forms.Padding(2)
        Me.usernamelogo.Name = "usernamelogo"
        Me.usernamelogo.Size = New System.Drawing.Size(20, 21)
        Me.usernamelogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.usernamelogo.TabIndex = 31
        Me.usernamelogo.TabStop = False
        '
        'wallpaper
        '
        Me.wallpaper.Image = Global.LoginForm.My.Resources.Resources.Mountain
        Me.wallpaper.Location = New System.Drawing.Point(17, 139)
        Me.wallpaper.Name = "wallpaper"
        Me.wallpaper.Size = New System.Drawing.Size(311, 342)
        Me.wallpaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.wallpaper.TabIndex = 28
        Me.wallpaper.TabStop = False
        '
        'inputarea
        '
        Me.inputarea.BackColor = System.Drawing.Color.LightGray
        Me.inputarea.Location = New System.Drawing.Point(325, 139)
        Me.inputarea.Name = "inputarea"
        Me.inputarea.Size = New System.Drawing.Size(311, 342)
        Me.inputarea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.inputarea.TabIndex = 29
        Me.inputarea.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DarkSlateGray
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PictureBox3.Location = New System.Drawing.Point(0, 313)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(653, 303)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 616)
        Me.Controls.Add(Me.hideit)
        Me.Controls.Add(Me.showpasslogo)
        Me.Controls.Add(Me.hidepasslogo)
        Me.Controls.Add(Me.loginbtn)
        Me.Controls.Add(Me.signuplabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.forgetpasslabel)
        Me.Controls.Add(Me.passwordtextbox)
        Me.Controls.Add(Me.passwordlogo)
        Me.Controls.Add(Me.usernamelogo)
        Me.Controls.Add(Me.wallpaper)
        Me.Controls.Add(Me.usernametextbox)
        Me.Controls.Add(Me.inputarea)
        Me.Controls.Add(Me.PictureBox3)
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.hideit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showpasslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hidepasslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.usernamelogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wallpaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputarea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents showpasslogo As PictureBox
    Friend WithEvents loginbtn As Button
    Friend WithEvents signuplabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents forgetpasslabel As Label
    Friend WithEvents passwordtextbox As TextBox
    Friend WithEvents passwordlogo As PictureBox
    Friend WithEvents usernamelogo As PictureBox
    Friend WithEvents wallpaper As PictureBox
    Friend WithEvents usernametextbox As TextBox
    Friend WithEvents inputarea As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents hidepasslogo As PictureBox
    Friend WithEvents hideit As PictureBox
End Class

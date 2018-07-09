<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Form
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
        Me.username_label = New System.Windows.Forms.Label()
        Me.password_label = New System.Windows.Forms.Label()
        Me.username_textbox = New System.Windows.Forms.TextBox()
        Me.password_textbox = New System.Windows.Forms.TextBox()
        Me.signup_button = New System.Windows.Forms.Button()
        Me.signin_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.admin_tick = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_label.ForeColor = System.Drawing.Color.White
        Me.username_label.Location = New System.Drawing.Point(7, 72)
        Me.username_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(128, 25)
        Me.username_label.TabIndex = 0
        Me.username_label.Text = "Username : "
        '
        'password_label
        '
        Me.password_label.AutoSize = True
        Me.password_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_label.ForeColor = System.Drawing.Color.White
        Me.password_label.Location = New System.Drawing.Point(11, 118)
        Me.password_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.password_label.Name = "password_label"
        Me.password_label.Size = New System.Drawing.Size(118, 25)
        Me.password_label.TabIndex = 1
        Me.password_label.Text = "Password :"
        '
        'username_textbox
        '
        Me.username_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_textbox.Location = New System.Drawing.Point(133, 69)
        Me.username_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.username_textbox.Name = "username_textbox"
        Me.username_textbox.Size = New System.Drawing.Size(198, 31)
        Me.username_textbox.TabIndex = 2
        '
        'password_textbox
        '
        Me.password_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_textbox.Location = New System.Drawing.Point(133, 115)
        Me.password_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.password_textbox.Name = "password_textbox"
        Me.password_textbox.Size = New System.Drawing.Size(198, 31)
        Me.password_textbox.TabIndex = 3
        Me.password_textbox.UseSystemPasswordChar = True
        '
        'signup_button
        '
        Me.signup_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signup_button.Location = New System.Drawing.Point(234, 185)
        Me.signup_button.Margin = New System.Windows.Forms.Padding(2)
        Me.signup_button.Name = "signup_button"
        Me.signup_button.Size = New System.Drawing.Size(97, 37)
        Me.signup_button.TabIndex = 4
        Me.signup_button.Text = "Sign Up"
        Me.signup_button.UseVisualStyleBackColor = True
        '
        'signin_button
        '
        Me.signin_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signin_button.Location = New System.Drawing.Point(133, 185)
        Me.signin_button.Margin = New System.Windows.Forms.Padding(2)
        Me.signin_button.Name = "signin_button"
        Me.signin_button.Size = New System.Drawing.Size(97, 37)
        Me.signin_button.TabIndex = 5
        Me.signin_button.Text = "Login"
        Me.signin_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 236)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Created by:"
        '
        'admin_tick
        '
        Me.admin_tick.AutoSize = True
        Me.admin_tick.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_tick.ForeColor = System.Drawing.Color.White
        Me.admin_tick.Location = New System.Drawing.Point(16, 157)
        Me.admin_tick.Margin = New System.Windows.Forms.Padding(2)
        Me.admin_tick.Name = "admin_tick"
        Me.admin_tick.Size = New System.Drawing.Size(135, 24)
        Me.admin_tick.TabIndex = 7
        Me.admin_tick.Text = "Login as admin"
        Me.admin_tick.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Goldenrod
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(349, 56)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(270, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 33)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(302, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 33)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "LOGIN"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(9, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fiqhy Bismadhika - 2101714824 "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Georgious Kurli - 2101704571  "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 285)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Vincent Joyan - 2101699672 "
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(349, 316)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.admin_tick)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.signin_button)
        Me.Controls.Add(Me.signup_button)
        Me.Controls.Add(Me.password_textbox)
        Me.Controls.Add(Me.username_textbox)
        Me.Controls.Add(Me.password_label)
        Me.Controls.Add(Me.username_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Login_Form"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_label As Label
    Friend WithEvents password_label As Label
    Friend WithEvents username_textbox As TextBox
    Friend WithEvents password_textbox As TextBox
    Friend WithEvents signup_button As Button
    Friend WithEvents signin_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents admin_tick As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class

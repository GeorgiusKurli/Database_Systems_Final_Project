<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sign_Up_Form
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
        Me.username_label = New System.Windows.Forms.Label()
        Me.password_label = New System.Windows.Forms.Label()
        Me.confirm_label = New System.Windows.Forms.Label()
        Me.email_label = New System.Windows.Forms.Label()
        Me.username_textbox = New System.Windows.Forms.TextBox()
        Me.password_textbox = New System.Windows.Forms.TextBox()
        Me.confirm_textbox = New System.Windows.Forms.TextBox()
        Me.email_textbox = New System.Windows.Forms.TextBox()
        Me.contact_label = New System.Windows.Forms.Label()
        Me.contact_textbox = New System.Windows.Forms.TextBox()
        Me.street_textbox = New System.Windows.Forms.TextBox()
        Me.street_label = New System.Windows.Forms.Label()
        Me.city_label = New System.Windows.Forms.Label()
        Me.city_id_textbox = New System.Windows.Forms.TextBox()
        Me.sign_up_button = New System.Windows.Forms.Button()
        Me.back_button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_label.ForeColor = System.Drawing.Color.White
        Me.username_label.Location = New System.Drawing.Point(32, 76)
        Me.username_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(122, 25)
        Me.username_label.TabIndex = 0
        Me.username_label.Text = "Username :"
        '
        'password_label
        '
        Me.password_label.AutoSize = True
        Me.password_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_label.ForeColor = System.Drawing.Color.White
        Me.password_label.Location = New System.Drawing.Point(36, 110)
        Me.password_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.password_label.Name = "password_label"
        Me.password_label.Size = New System.Drawing.Size(118, 25)
        Me.password_label.TabIndex = 1
        Me.password_label.Text = "Password :"
        '
        'confirm_label
        '
        Me.confirm_label.AutoSize = True
        Me.confirm_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm_label.ForeColor = System.Drawing.Color.White
        Me.confirm_label.Location = New System.Drawing.Point(56, 144)
        Me.confirm_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.confirm_label.Name = "confirm_label"
        Me.confirm_label.Size = New System.Drawing.Size(98, 25)
        Me.confirm_label.TabIndex = 2
        Me.confirm_label.Text = "Confirm :"
        '
        'email_label
        '
        Me.email_label.AutoSize = True
        Me.email_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_label.ForeColor = System.Drawing.Color.White
        Me.email_label.Location = New System.Drawing.Point(77, 178)
        Me.email_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.email_label.Name = "email_label"
        Me.email_label.Size = New System.Drawing.Size(77, 25)
        Me.email_label.TabIndex = 3
        Me.email_label.Text = "Email :"
        '
        'username_textbox
        '
        Me.username_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_textbox.Location = New System.Drawing.Point(158, 73)
        Me.username_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.username_textbox.Name = "username_textbox"
        Me.username_textbox.Size = New System.Drawing.Size(212, 31)
        Me.username_textbox.TabIndex = 4
        '
        'password_textbox
        '
        Me.password_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_textbox.Location = New System.Drawing.Point(158, 107)
        Me.password_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.password_textbox.Name = "password_textbox"
        Me.password_textbox.Size = New System.Drawing.Size(212, 31)
        Me.password_textbox.TabIndex = 5
        '
        'confirm_textbox
        '
        Me.confirm_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm_textbox.Location = New System.Drawing.Point(158, 141)
        Me.confirm_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.confirm_textbox.Name = "confirm_textbox"
        Me.confirm_textbox.Size = New System.Drawing.Size(212, 31)
        Me.confirm_textbox.TabIndex = 6
        '
        'email_textbox
        '
        Me.email_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_textbox.Location = New System.Drawing.Point(158, 175)
        Me.email_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.email_textbox.Name = "email_textbox"
        Me.email_textbox.Size = New System.Drawing.Size(212, 31)
        Me.email_textbox.TabIndex = 7
        '
        'contact_label
        '
        Me.contact_label.AutoSize = True
        Me.contact_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact_label.ForeColor = System.Drawing.Color.White
        Me.contact_label.Location = New System.Drawing.Point(56, 212)
        Me.contact_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.contact_label.Name = "contact_label"
        Me.contact_label.Size = New System.Drawing.Size(98, 25)
        Me.contact_label.TabIndex = 8
        Me.contact_label.Text = "Contact :"
        '
        'contact_textbox
        '
        Me.contact_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact_textbox.Location = New System.Drawing.Point(158, 209)
        Me.contact_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.contact_textbox.Name = "contact_textbox"
        Me.contact_textbox.Size = New System.Drawing.Size(212, 31)
        Me.contact_textbox.TabIndex = 9
        '
        'street_textbox
        '
        Me.street_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.street_textbox.Location = New System.Drawing.Point(158, 243)
        Me.street_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.street_textbox.Name = "street_textbox"
        Me.street_textbox.Size = New System.Drawing.Size(212, 31)
        Me.street_textbox.TabIndex = 10
        '
        'street_label
        '
        Me.street_label.AutoSize = True
        Me.street_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.street_label.ForeColor = System.Drawing.Color.White
        Me.street_label.Location = New System.Drawing.Point(11, 246)
        Me.street_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.street_label.Name = "street_label"
        Me.street_label.Size = New System.Drawing.Size(143, 25)
        Me.street_label.TabIndex = 11
        Me.street_label.Text = "Street Name :"
        '
        'city_label
        '
        Me.city_label.AutoSize = True
        Me.city_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city_label.ForeColor = System.Drawing.Color.White
        Me.city_label.Location = New System.Drawing.Point(93, 280)
        Me.city_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.city_label.Name = "city_label"
        Me.city_label.Size = New System.Drawing.Size(61, 25)
        Me.city_label.TabIndex = 12
        Me.city_label.Text = "City :"
        '
        'city_id_textbox
        '
        Me.city_id_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city_id_textbox.Location = New System.Drawing.Point(158, 277)
        Me.city_id_textbox.Margin = New System.Windows.Forms.Padding(2)
        Me.city_id_textbox.Name = "city_id_textbox"
        Me.city_id_textbox.Size = New System.Drawing.Size(212, 31)
        Me.city_id_textbox.TabIndex = 13
        '
        'sign_up_button
        '
        Me.sign_up_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sign_up_button.Location = New System.Drawing.Point(272, 321)
        Me.sign_up_button.Margin = New System.Windows.Forms.Padding(2)
        Me.sign_up_button.Name = "sign_up_button"
        Me.sign_up_button.Size = New System.Drawing.Size(97, 40)
        Me.sign_up_button.TabIndex = 14
        Me.sign_up_button.Text = "Sign Up"
        Me.sign_up_button.UseVisualStyleBackColor = True
        '
        'back_button
        '
        Me.back_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_button.Location = New System.Drawing.Point(158, 321)
        Me.back_button.Margin = New System.Windows.Forms.Padding(2)
        Me.back_button.Name = "back_button"
        Me.back_button.Size = New System.Drawing.Size(97, 40)
        Me.back_button.TabIndex = 15
        Me.back_button.Text = "Back"
        Me.back_button.UseVisualStyleBackColor = True
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
        Me.Panel1.Size = New System.Drawing.Size(381, 56)
        Me.Panel1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(302, 11)
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
        Me.Label3.Location = New System.Drawing.Point(334, 11)
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
        Me.Label2.Size = New System.Drawing.Size(141, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SIGN UP"
        '
        'Sign_Up_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(381, 380)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.back_button)
        Me.Controls.Add(Me.sign_up_button)
        Me.Controls.Add(Me.city_id_textbox)
        Me.Controls.Add(Me.city_label)
        Me.Controls.Add(Me.street_label)
        Me.Controls.Add(Me.street_textbox)
        Me.Controls.Add(Me.contact_textbox)
        Me.Controls.Add(Me.contact_label)
        Me.Controls.Add(Me.email_textbox)
        Me.Controls.Add(Me.confirm_textbox)
        Me.Controls.Add(Me.password_textbox)
        Me.Controls.Add(Me.username_textbox)
        Me.Controls.Add(Me.email_label)
        Me.Controls.Add(Me.confirm_label)
        Me.Controls.Add(Me.password_label)
        Me.Controls.Add(Me.username_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Sign_Up_Form"
        Me.Text = "Sign_Up_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_label As Label
    Friend WithEvents password_label As Label
    Friend WithEvents confirm_label As Label
    Friend WithEvents email_label As Label
    Friend WithEvents username_textbox As TextBox
    Friend WithEvents password_textbox As TextBox
    Friend WithEvents confirm_textbox As TextBox
    Friend WithEvents email_textbox As TextBox
    Friend WithEvents contact_label As Label
    Friend WithEvents contact_textbox As TextBox
    Friend WithEvents street_textbox As TextBox
    Friend WithEvents street_label As Label
    Friend WithEvents city_label As Label
    Friend WithEvents city_id_textbox As TextBox
    Friend WithEvents sign_up_button As Button
    Friend WithEvents back_button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

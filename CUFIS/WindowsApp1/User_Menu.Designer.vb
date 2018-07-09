<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Menu
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.search_label = New System.Windows.Forms.Label()
        Me.username_label = New System.Windows.Forms.Label()
        Me.confirm_search_button = New System.Windows.Forms.Button()
        Me.sign_out_button = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(93, 158)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(278, 277)
        Me.ListBox1.TabIndex = 0
        '
        'search_box
        '
        Me.search_box.Location = New System.Drawing.Point(93, 134)
        Me.search_box.Margin = New System.Windows.Forms.Padding(2)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(237, 20)
        Me.search_box.TabIndex = 1
        '
        'search_label
        '
        Me.search_label.AutoSize = True
        Me.search_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_label.ForeColor = System.Drawing.Color.White
        Me.search_label.Location = New System.Drawing.Point(9, 132)
        Me.search_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.search_label.Name = "search_label"
        Me.search_label.Size = New System.Drawing.Size(80, 20)
        Me.search_label.TabIndex = 2
        Me.search_label.Text = "Search    :"
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.Font = New System.Drawing.Font("Papyrus", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_label.ForeColor = System.Drawing.Color.White
        Me.username_label.Location = New System.Drawing.Point(9, 59)
        Me.username_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(222, 33)
        Me.username_label.TabIndex = 3
        Me.username_label.Text = "Welcome to CUFIS"
        '
        'confirm_search_button
        '
        Me.confirm_search_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirm_search_button.Location = New System.Drawing.Point(336, 130)
        Me.confirm_search_button.Margin = New System.Windows.Forms.Padding(2)
        Me.confirm_search_button.Name = "confirm_search_button"
        Me.confirm_search_button.Size = New System.Drawing.Size(64, 27)
        Me.confirm_search_button.TabIndex = 6
        Me.confirm_search_button.Text = "Confirm"
        Me.confirm_search_button.UseVisualStyleBackColor = True
        '
        'sign_out_button
        '
        Me.sign_out_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sign_out_button.Location = New System.Drawing.Point(312, 449)
        Me.sign_out_button.Margin = New System.Windows.Forms.Padding(2)
        Me.sign_out_button.Name = "sign_out_button"
        Me.sign_out_button.Size = New System.Drawing.Size(80, 34)
        Me.sign_out_button.TabIndex = 7
        Me.sign_out_button.Text = "Sign Out"
        Me.sign_out_button.UseVisualStyleBackColor = True
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
        Me.Panel1.Size = New System.Drawing.Size(409, 56)
        Me.Panel1.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(330, 11)
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
        Me.Label3.Location = New System.Drawing.Point(362, 11)
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
        Me.Label2.Size = New System.Drawing.Size(241, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RESTAURANTS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(191, 92)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "CUisine FInder Service"
        '
        'User_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(409, 494)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.sign_out_button)
        Me.Controls.Add(Me.confirm_search_button)
        Me.Controls.Add(Me.username_label)
        Me.Controls.Add(Me.search_label)
        Me.Controls.Add(Me.search_box)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "User_Menu"
        Me.Text = "User Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents search_box As TextBox
    Friend WithEvents search_label As Label
    Friend WithEvents username_label As Label
    Friend WithEvents confirm_search_button As Button
    Friend WithEvents sign_out_button As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

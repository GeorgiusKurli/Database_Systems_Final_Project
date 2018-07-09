<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Menu
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
        Me.add_button = New System.Windows.Forms.Button()
        Me.modify_button = New System.Windows.Forms.Button()
        Me.del_button = New System.Windows.Forms.Button()
        Me.admin_label = New System.Windows.Forms.Label()
        Me.out_button = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'add_button
        '
        Me.add_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_button.Location = New System.Drawing.Point(25, 419)
        Me.add_button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.add_button.Name = "add_button"
        Me.add_button.Size = New System.Drawing.Size(88, 29)
        Me.add_button.TabIndex = 0
        Me.add_button.Text = "Add"
        Me.add_button.UseVisualStyleBackColor = True
        '
        'modify_button
        '
        Me.modify_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modify_button.Location = New System.Drawing.Point(130, 419)
        Me.modify_button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.modify_button.Name = "modify_button"
        Me.modify_button.Size = New System.Drawing.Size(88, 29)
        Me.modify_button.TabIndex = 1
        Me.modify_button.Text = "Modify"
        Me.modify_button.UseVisualStyleBackColor = True
        '
        'del_button
        '
        Me.del_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del_button.Location = New System.Drawing.Point(240, 419)
        Me.del_button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.del_button.Name = "del_button"
        Me.del_button.Size = New System.Drawing.Size(88, 29)
        Me.del_button.TabIndex = 2
        Me.del_button.Text = "Delete"
        Me.del_button.UseVisualStyleBackColor = True
        '
        'admin_label
        '
        Me.admin_label.AutoSize = True
        Me.admin_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin_label.ForeColor = System.Drawing.Color.White
        Me.admin_label.Location = New System.Drawing.Point(13, 68)
        Me.admin_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.admin_label.Name = "admin_label"
        Me.admin_label.Size = New System.Drawing.Size(198, 20)
        Me.admin_label.TabIndex = 3
        Me.admin_label.Text = "Logged in as Administrator"
        '
        'out_button
        '
        Me.out_button.Location = New System.Drawing.Point(240, 67)
        Me.out_button.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.out_button.Name = "out_button"
        Me.out_button.Size = New System.Drawing.Size(84, 24)
        Me.out_button.TabIndex = 4
        Me.out_button.Text = "Sign Out"
        Me.out_button.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(55, 99)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(242, 304)
        Me.ListBox1.TabIndex = 5
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
        Me.Panel1.Size = New System.Drawing.Size(342, 56)
        Me.Panel1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(263, 11)
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
        Me.Label3.Location = New System.Drawing.Point(295, 11)
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
        Me.Label2.Size = New System.Drawing.Size(113, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ADMIN"
        '
        'Admin_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(342, 463)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.out_button)
        Me.Controls.Add(Me.admin_label)
        Me.Controls.Add(Me.del_button)
        Me.Controls.Add(Me.modify_button)
        Me.Controls.Add(Me.add_button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Admin_Menu"
        Me.Text = "Admin Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents add_button As Button
    Friend WithEvents modify_button As Button
    Friend WithEvents del_button As Button
    Friend WithEvents admin_label As Label
    Friend WithEvents out_button As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Form
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
        Me.restaurant_label = New System.Windows.Forms.Label()
        Me.dish_label = New System.Windows.Forms.Label()
        Me.dish_listbox = New System.Windows.Forms.ListBox()
        Me.beverage_listbox = New System.Windows.Forms.ListBox()
        Me.beverage_label = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'restaurant_label
        '
        Me.restaurant_label.AutoSize = True
        Me.restaurant_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restaurant_label.ForeColor = System.Drawing.Color.White
        Me.restaurant_label.Location = New System.Drawing.Point(11, 68)
        Me.restaurant_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.restaurant_label.Name = "restaurant_label"
        Me.restaurant_label.Size = New System.Drawing.Size(102, 33)
        Me.restaurant_label.TabIndex = 0
        Me.restaurant_label.Text = "Label1"
        '
        'dish_label
        '
        Me.dish_label.AutoSize = True
        Me.dish_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dish_label.ForeColor = System.Drawing.Color.White
        Me.dish_label.Location = New System.Drawing.Point(68, 105)
        Me.dish_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dish_label.Name = "dish_label"
        Me.dish_label.Size = New System.Drawing.Size(78, 25)
        Me.dish_label.TabIndex = 1
        Me.dish_label.Text = "Dishes"
        '
        'dish_listbox
        '
        Me.dish_listbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dish_listbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dish_listbox.ForeColor = System.Drawing.Color.Black
        Me.dish_listbox.FormattingEnabled = True
        Me.dish_listbox.ItemHeight = 20
        Me.dish_listbox.Location = New System.Drawing.Point(11, 132)
        Me.dish_listbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dish_listbox.Name = "dish_listbox"
        Me.dish_listbox.Size = New System.Drawing.Size(193, 304)
        Me.dish_listbox.TabIndex = 2
        '
        'beverage_listbox
        '
        Me.beverage_listbox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.beverage_listbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beverage_listbox.ForeColor = System.Drawing.Color.Black
        Me.beverage_listbox.FormattingEnabled = True
        Me.beverage_listbox.ItemHeight = 20
        Me.beverage_listbox.Location = New System.Drawing.Point(228, 132)
        Me.beverage_listbox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.beverage_listbox.Name = "beverage_listbox"
        Me.beverage_listbox.Size = New System.Drawing.Size(197, 304)
        Me.beverage_listbox.TabIndex = 4
        '
        'beverage_label
        '
        Me.beverage_label.AutoSize = True
        Me.beverage_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.beverage_label.ForeColor = System.Drawing.Color.White
        Me.beverage_label.Location = New System.Drawing.Point(268, 105)
        Me.beverage_label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.beverage_label.Name = "beverage_label"
        Me.beverage_label.Size = New System.Drawing.Size(115, 25)
        Me.beverage_label.TabIndex = 3
        Me.beverage_label.Text = "Beverages"
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
        Me.Panel1.Size = New System.Drawing.Size(436, 56)
        Me.Panel1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(366, 11)
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
        Me.Label3.Location = New System.Drawing.Point(398, 11)
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
        Me.Label2.Size = New System.Drawing.Size(104, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MENU"
        '
        'Menu_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(436, 443)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.beverage_listbox)
        Me.Controls.Add(Me.beverage_label)
        Me.Controls.Add(Me.dish_listbox)
        Me.Controls.Add(Me.dish_label)
        Me.Controls.Add(Me.restaurant_label)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Menu_Form"
        Me.Text = "Menu_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents restaurant_label As Label
    Friend WithEvents dish_label As Label
    Friend WithEvents dish_listbox As ListBox
    Friend WithEvents beverage_listbox As ListBox
    Friend WithEvents beverage_label As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

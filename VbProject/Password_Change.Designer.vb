<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Password_Change
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.P_User = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P_User.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(124, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PlaceholderText = "ชื่อผู้ใช้"
        Me.TextBox1.Size = New System.Drawing.Size(186, 31)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox2.Location = New System.Drawing.Point(124, 109)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PlaceholderText = "รหัสผ่านเก่า"
        Me.TextBox2.Size = New System.Drawing.Size(186, 31)
        Me.TextBox2.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox3.Location = New System.Drawing.Point(124, 159)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PlaceholderText = "รหัสผ่านใหม่"
        Me.TextBox3.Size = New System.Drawing.Size(186, 31)
        Me.TextBox3.TabIndex = 5
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_save.Location = New System.Drawing.Point(217, 223)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(123, 44)
        Me.btn_save.TabIndex = 7
        Me.btn_save.Text = "เปลี่ยนรหัสผ่าน"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'P_User
        '
        Me.P_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.P_User.Controls.Add(Me.Button1)
        Me.P_User.Controls.Add(Me.Label4)
        Me.P_User.Controls.Add(Me.Label3)
        Me.P_User.Controls.Add(Me.Label2)
        Me.P_User.Controls.Add(Me.Label1)
        Me.P_User.Controls.Add(Me.TextBox1)
        Me.P_User.Controls.Add(Me.TextBox2)
        Me.P_User.Controls.Add(Me.btn_save)
        Me.P_User.Controls.Add(Me.TextBox3)
        Me.P_User.Location = New System.Drawing.Point(26, 25)
        Me.P_User.Name = "P_User"
        Me.P_User.Size = New System.Drawing.Size(380, 302)
        Me.P_User.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(43, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 44)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "กลับไปหน้าหลัก"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(16, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "รหัสผ่านใหม่"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "รหัสผ่านเก่า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ชื่อผู้ใช้"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(124, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ระบบเปลี่ยนรหัสผ่าน"
        '
        'Password_Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 352)
        Me.Controls.Add(Me.P_User)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Password_Change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Change"
        Me.P_User.ResumeLayout(False)
        Me.P_User.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents P_User As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class

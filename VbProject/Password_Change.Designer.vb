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
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_opass = New System.Windows.Forms.TextBox()
        Me.txt_npass = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.P_User = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cpass = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P_User.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.White
        Me.txt_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_username.Location = New System.Drawing.Point(137, 60)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PlaceholderText = "ชื่อผู้ใช้"
        Me.txt_username.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(186, 26)
        Me.txt_username.TabIndex = 0
        '
        'txt_opass
        '
        Me.txt_opass.BackColor = System.Drawing.Color.White
        Me.txt_opass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_opass.Location = New System.Drawing.Point(137, 109)
        Me.txt_opass.Name = "txt_opass"
        Me.txt_opass.PlaceholderText = "รหัสผ่านเก่า"
        Me.txt_opass.Size = New System.Drawing.Size(186, 26)
        Me.txt_opass.TabIndex = 1
        Me.txt_opass.UseSystemPasswordChar = True
        '
        'txt_npass
        '
        Me.txt_npass.BackColor = System.Drawing.Color.White
        Me.txt_npass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_npass.Location = New System.Drawing.Point(137, 159)
        Me.txt_npass.Name = "txt_npass"
        Me.txt_npass.PlaceholderText = "รหัสผ่านใหม่"
        Me.txt_npass.Size = New System.Drawing.Size(186, 26)
        Me.txt_npass.TabIndex = 2
        Me.txt_npass.UseSystemPasswordChar = True
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_save.Location = New System.Drawing.Point(209, 280)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(123, 38)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "เปลี่ยนรหัสผ่าน"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'P_User
        '
        Me.P_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.P_User.Controls.Add(Me.Label5)
        Me.P_User.Controls.Add(Me.txt_cpass)
        Me.P_User.Controls.Add(Me.btn_back)
        Me.P_User.Controls.Add(Me.Label4)
        Me.P_User.Controls.Add(Me.Label3)
        Me.P_User.Controls.Add(Me.Label2)
        Me.P_User.Controls.Add(Me.Label1)
        Me.P_User.Controls.Add(Me.txt_username)
        Me.P_User.Controls.Add(Me.txt_opass)
        Me.P_User.Controls.Add(Me.btn_save)
        Me.P_User.Controls.Add(Me.txt_npass)
        Me.P_User.Location = New System.Drawing.Point(26, 25)
        Me.P_User.Name = "P_User"
        Me.P_User.Size = New System.Drawing.Size(380, 352)
        Me.P_User.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(16, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ยืนยันรหัสผ่าน"
        '
        'txt_cpass
        '
        Me.txt_cpass.BackColor = System.Drawing.Color.White
        Me.txt_cpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_cpass.Location = New System.Drawing.Point(137, 208)
        Me.txt_cpass.Name = "txt_cpass"
        Me.txt_cpass.PlaceholderText = "ยืนยันรหัสผ่าน"
        Me.txt_cpass.Size = New System.Drawing.Size(186, 26)
        Me.txt_cpass.TabIndex = 3
        Me.txt_cpass.UseSystemPasswordChar = True
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_back.Location = New System.Drawing.Point(47, 280)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(123, 38)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "กลับไปหน้าหลัก"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(16, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "รหัสผ่านใหม่"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "รหัสผ่านเก่า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ชื่อผู้ใช้"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(124, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ระบบเปลี่ยนรหัสผ่าน"
        '
        'Password_Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(432, 395)
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

    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_opass As TextBox
    Friend WithEvents txt_npass As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents P_User As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cpass As TextBox
End Class

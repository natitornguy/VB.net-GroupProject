<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_empinfo = New System.Windows.Forms.PictureBox()
        Me.btn_leave_admin = New System.Windows.Forms.PictureBox()
        Me.btn_bonus_cal = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_empname = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lbl_empid = New System.Windows.Forms.Label()
        Me.P_Admin = New System.Windows.Forms.Panel()
        Me.btn_changepw_admin = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P_Employee = New System.Windows.Forms.Panel()
        Me.btn_changepw_user = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_leave_send = New System.Windows.Forms.PictureBox()
        Me.btn_leave_emp = New System.Windows.Forms.Label()
        Me.btn_bonus_view = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_logout = New System.Windows.Forms.Button()
        CType(Me.btn_empinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_leave_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_bonus_cal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_Admin.SuspendLayout()
        CType(Me.btn_changepw_admin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.P_Employee.SuspendLayout()
        CType(Me.btn_changepw_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_leave_send, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_bonus_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(17, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "สวัสดีคุณ"
        '
        'btn_empinfo
        '
        Me.btn_empinfo.ErrorImage = Nothing
        Me.btn_empinfo.Image = CType(resources.GetObject("btn_empinfo.Image"), System.Drawing.Image)
        Me.btn_empinfo.Location = New System.Drawing.Point(27, 14)
        Me.btn_empinfo.Name = "btn_empinfo"
        Me.btn_empinfo.Size = New System.Drawing.Size(124, 98)
        Me.btn_empinfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_empinfo.TabIndex = 6
        Me.btn_empinfo.TabStop = False
        '
        'btn_leave_admin
        '
        Me.btn_leave_admin.ErrorImage = Nothing
        Me.btn_leave_admin.Image = CType(resources.GetObject("btn_leave_admin.Image"), System.Drawing.Image)
        Me.btn_leave_admin.Location = New System.Drawing.Point(195, 153)
        Me.btn_leave_admin.Name = "btn_leave_admin"
        Me.btn_leave_admin.Size = New System.Drawing.Size(124, 98)
        Me.btn_leave_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_leave_admin.TabIndex = 7
        Me.btn_leave_admin.TabStop = False
        '
        'btn_bonus_cal
        '
        Me.btn_bonus_cal.ErrorImage = Nothing
        Me.btn_bonus_cal.Image = CType(resources.GetObject("btn_bonus_cal.Image"), System.Drawing.Image)
        Me.btn_bonus_cal.Location = New System.Drawing.Point(27, 153)
        Me.btn_bonus_cal.Name = "btn_bonus_cal"
        Me.btn_bonus_cal.Size = New System.Drawing.Size(124, 98)
        Me.btn_bonus_cal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_bonus_cal.TabIndex = 8
        Me.btn_bonus_cal.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(50, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ข้อมูลพนักงาน"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(197, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "การร้องขอการลาหยุด"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(58, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "คำนวนโบนัส"
        '
        'lbl_empname
        '
        Me.lbl_empname.AutoSize = True
        Me.lbl_empname.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_empname.Location = New System.Drawing.Point(17, 143)
        Me.lbl_empname.Name = "lbl_empname"
        Me.lbl_empname.Size = New System.Drawing.Size(98, 25)
        Me.lbl_empname.TabIndex = 14
        Me.lbl_empname.Text = "ชื่อพนนักงาน"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(28, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(83, 79)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'lbl_empid
        '
        Me.lbl_empid.AutoSize = True
        Me.lbl_empid.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_empid.Location = New System.Drawing.Point(17, 183)
        Me.lbl_empid.Name = "lbl_empid"
        Me.lbl_empid.Size = New System.Drawing.Size(53, 25)
        Me.lbl_empid.TabIndex = 16
        Me.lbl_empid.Text = "ID : ??"
        '
        'P_Admin
        '
        Me.P_Admin.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.P_Admin.Controls.Add(Me.btn_changepw_admin)
        Me.P_Admin.Controls.Add(Me.Label1)
        Me.P_Admin.Controls.Add(Me.btn_leave_admin)
        Me.P_Admin.Controls.Add(Me.Label4)
        Me.P_Admin.Controls.Add(Me.btn_empinfo)
        Me.P_Admin.Controls.Add(Me.Label3)
        Me.P_Admin.Controls.Add(Me.btn_bonus_cal)
        Me.P_Admin.Controls.Add(Me.Label5)
        Me.P_Admin.Location = New System.Drawing.Point(143, 46)
        Me.P_Admin.Name = "P_Admin"
        Me.P_Admin.Size = New System.Drawing.Size(346, 288)
        Me.P_Admin.TabIndex = 17
        '
        'btn_changepw_admin
        '
        Me.btn_changepw_admin.ErrorImage = Nothing
        Me.btn_changepw_admin.Image = CType(resources.GetObject("btn_changepw_admin.Image"), System.Drawing.Image)
        Me.btn_changepw_admin.Location = New System.Drawing.Point(195, 14)
        Me.btn_changepw_admin.Name = "btn_changepw_admin"
        Me.btn_changepw_admin.Size = New System.Drawing.Size(124, 98)
        Me.btn_changepw_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_changepw_admin.TabIndex = 13
        Me.btn_changepw_admin.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(218, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "เปลี่ยนรหัสผ่าน"
        '
        'P_Employee
        '
        Me.P_Employee.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.P_Employee.Controls.Add(Me.btn_changepw_user)
        Me.P_Employee.Controls.Add(Me.Label7)
        Me.P_Employee.Controls.Add(Me.btn_leave_send)
        Me.P_Employee.Controls.Add(Me.btn_leave_emp)
        Me.P_Employee.Controls.Add(Me.btn_bonus_view)
        Me.P_Employee.Controls.Add(Me.Label6)
        Me.P_Employee.Location = New System.Drawing.Point(143, 46)
        Me.P_Employee.Name = "P_Employee"
        Me.P_Employee.Size = New System.Drawing.Size(346, 288)
        Me.P_Employee.TabIndex = 18
        '
        'btn_changepw_user
        '
        Me.btn_changepw_user.ErrorImage = Nothing
        Me.btn_changepw_user.Image = CType(resources.GetObject("btn_changepw_user.Image"), System.Drawing.Image)
        Me.btn_changepw_user.Location = New System.Drawing.Point(197, 153)
        Me.btn_changepw_user.Name = "btn_changepw_user"
        Me.btn_changepw_user.Size = New System.Drawing.Size(124, 98)
        Me.btn_changepw_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_changepw_user.TabIndex = 15
        Me.btn_changepw_user.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(214, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "เปลี่ยนรหัสผ่าน"
        '
        'btn_leave_send
        '
        Me.btn_leave_send.ErrorImage = Nothing
        Me.btn_leave_send.Image = CType(resources.GetObject("btn_leave_send.Image"), System.Drawing.Image)
        Me.btn_leave_send.Location = New System.Drawing.Point(117, 14)
        Me.btn_leave_send.Name = "btn_leave_send"
        Me.btn_leave_send.Size = New System.Drawing.Size(124, 98)
        Me.btn_leave_send.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_leave_send.TabIndex = 7
        Me.btn_leave_send.TabStop = False
        '
        'btn_leave_emp
        '
        Me.btn_leave_emp.AutoSize = True
        Me.btn_leave_emp.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.btn_leave_emp.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_leave_emp.Location = New System.Drawing.Point(138, 115)
        Me.btn_leave_emp.Name = "btn_leave_emp"
        Me.btn_leave_emp.Size = New System.Drawing.Size(86, 20)
        Me.btn_leave_emp.TabIndex = 11
        Me.btn_leave_emp.Text = "ทำเรื่องลาหยุด"
        '
        'btn_bonus_view
        '
        Me.btn_bonus_view.ErrorImage = Nothing
        Me.btn_bonus_view.Image = CType(resources.GetObject("btn_bonus_view.Image"), System.Drawing.Image)
        Me.btn_bonus_view.Location = New System.Drawing.Point(29, 153)
        Me.btn_bonus_view.Name = "btn_bonus_view"
        Me.btn_bonus_view.Size = New System.Drawing.Size(124, 98)
        Me.btn_bonus_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_bonus_view.TabIndex = 6
        Me.btn_bonus_view.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Kanit", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(61, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ดูโบนัสที่ได้"
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_logout.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_logout.Location = New System.Drawing.Point(12, 297)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(119, 37)
        Me.btn_logout.TabIndex = 19
        Me.btn_logout.Text = "ออกจากระบบ"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(524, 360)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.P_Employee)
        Me.Controls.Add(Me.P_Admin)
        Me.Controls.Add(Me.lbl_empid)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.lbl_empname)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.btn_empinfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_leave_admin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_bonus_cal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_Admin.ResumeLayout(False)
        Me.P_Admin.PerformLayout()
        CType(Me.btn_changepw_admin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.P_Employee.ResumeLayout(False)
        Me.P_Employee.PerformLayout()
        CType(Me.btn_changepw_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_leave_send, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_bonus_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_empinfo As PictureBox
    Friend WithEvents btn_leave_admin As PictureBox
    Friend WithEvents btn_bonus_cal As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_empname As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lbl_empid As Label
    Friend WithEvents P_Admin As Panel
    Friend WithEvents P_Employee As Panel
    Friend WithEvents btn_leave_send As PictureBox
    Friend WithEvents btn_leave_emp As Label
    Friend WithEvents btn_bonus_view As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_changepw_admin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_changepw_user As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_logout As Button
End Class

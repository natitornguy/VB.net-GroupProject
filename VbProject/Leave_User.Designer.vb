<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Leave_User
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_leavedate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_send_leave = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_end = New System.Windows.Forms.DateTimePicker()
        Me.dtp_start = New System.Windows.Forms.DateTimePicker()
        Me.txt_reason = New System.Windows.Forms.TextBox()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_leavedate)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btn_send_leave)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.dtp_end)
        Me.Panel1.Controls.Add(Me.dtp_start)
        Me.Panel1.Controls.Add(Me.txt_reason)
        Me.Panel1.Controls.Add(Me.txt_lname)
        Me.Panel1.Controls.Add(Me.txt_fname)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(24, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 449)
        Me.Panel1.TabIndex = 0
        '
        'lbl_leavedate
        '
        Me.lbl_leavedate.AutoSize = True
        Me.lbl_leavedate.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_leavedate.Location = New System.Drawing.Point(211, 180)
        Me.lbl_leavedate.Name = "lbl_leavedate"
        Me.lbl_leavedate.Size = New System.Drawing.Size(36, 25)
        Me.lbl_leavedate.TabIndex = 13
        Me.lbl_leavedate.Text = "???"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(42, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "จำนวนวันหยุดที่เหลือ"
        '
        'btn_send_leave
        '
        Me.btn_send_leave.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_send_leave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_send_leave.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_send_leave.Location = New System.Drawing.Point(187, 377)
        Me.btn_send_leave.Name = "btn_send_leave"
        Me.btn_send_leave.Size = New System.Drawing.Size(134, 35)
        Me.btn_send_leave.TabIndex = 11
        Me.btn_send_leave.Text = "ส่งเรื่องการลา"
        Me.btn_send_leave.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(42, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ถึงวันที่"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(42, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "หยุดตั้งแต่วันที่"
        '
        'dtp_end
        '
        Me.dtp_end.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_end.Location = New System.Drawing.Point(211, 267)
        Me.dtp_end.Name = "dtp_end"
        Me.dtp_end.Size = New System.Drawing.Size(227, 31)
        Me.dtp_end.TabIndex = 8
        '
        'dtp_start
        '
        Me.dtp_start.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dtp_start.Location = New System.Drawing.Point(211, 219)
        Me.dtp_start.Name = "dtp_start"
        Me.dtp_start.Size = New System.Drawing.Size(227, 31)
        Me.dtp_start.TabIndex = 7
        '
        'txt_reason
        '
        Me.txt_reason.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_reason.Location = New System.Drawing.Point(211, 314)
        Me.txt_reason.Name = "txt_reason"
        Me.txt_reason.Size = New System.Drawing.Size(227, 31)
        Me.txt_reason.TabIndex = 6
        '
        'txt_lname
        '
        Me.txt_lname.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_lname.Location = New System.Drawing.Point(211, 130)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(227, 31)
        Me.txt_lname.TabIndex = 5
        '
        'txt_fname
        '
        Me.txt_fname.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_fname.Location = New System.Drawing.Point(211, 82)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(227, 31)
        Me.txt_fname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(42, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "เหตุผลในการลาหยุด"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(42, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "นามสกุล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(42, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ชื่อ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(178, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "การร้องขอการลาหยุด"
        '
        'Leave_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(563, 491)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Leave_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave Request"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_send_leave As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtp_end As DateTimePicker
    Friend WithEvents dtp_start As DateTimePicker
    Friend WithEvents txt_reason As TextBox
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_leavedate As Label
    Friend WithEvents Label7 As Label
End Class

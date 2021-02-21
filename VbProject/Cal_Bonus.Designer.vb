<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cal_Bonus
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.cbo_department = New System.Windows.Forms.ComboBox()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.txt_salary = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_status)
        Me.Panel1.Controls.Add(Me.txt_lname)
        Me.Panel1.Controls.Add(Me.btn_submit)
        Me.Panel1.Controls.Add(Me.cbo_department)
        Me.Panel1.Controls.Add(Me.txt_fname)
        Me.Panel1.Controls.Add(Me.txt_salary)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Location = New System.Drawing.Point(24, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(475, 488)
        Me.Panel1.TabIndex = 25
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"S", "A", "B", "C", "D"})
        Me.ComboBox1.Location = New System.Drawing.Point(66, 288)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(158, 33)
        Me.ComboBox1.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(66, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 25)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "แผนก"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(66, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 25)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "เงินเดือน"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(66, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 25)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "เกรดการประเมิน"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(234, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "นามสกุล" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(66, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "ชื่อ"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_status.Location = New System.Drawing.Point(168, 20)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(118, 25)
        Me.lbl_status.TabIndex = 24
        Me.lbl_status.Text = "ประเมินพนักงาน"
        '
        'txt_lname
        '
        Me.txt_lname.BackColor = System.Drawing.Color.White
        Me.txt_lname.Enabled = False
        Me.txt_lname.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_lname.Location = New System.Drawing.Point(234, 100)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.PlaceholderText = "นามสกุล"
        Me.txt_lname.Size = New System.Drawing.Size(158, 31)
        Me.txt_lname.TabIndex = 11
        '
        'btn_submit
        '
        Me.btn_submit.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_submit.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_submit.Location = New System.Drawing.Point(249, 419)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(131, 36)
        Me.btn_submit.TabIndex = 23
        Me.btn_submit.Text = "ประเมินผล"
        Me.btn_submit.UseVisualStyleBackColor = False
        '
        'cbo_department
        '
        Me.cbo_department.BackColor = System.Drawing.Color.White
        Me.cbo_department.Enabled = False
        Me.cbo_department.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cbo_department.FormattingEnabled = True
        Me.cbo_department.Location = New System.Drawing.Point(66, 224)
        Me.cbo_department.Name = "cbo_department"
        Me.cbo_department.Size = New System.Drawing.Size(158, 33)
        Me.cbo_department.TabIndex = 22
        '
        'txt_fname
        '
        Me.txt_fname.BackColor = System.Drawing.Color.White
        Me.txt_fname.Enabled = False
        Me.txt_fname.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_fname.Location = New System.Drawing.Point(66, 100)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.PlaceholderText = "ชื่อ"
        Me.txt_fname.Size = New System.Drawing.Size(158, 31)
        Me.txt_fname.TabIndex = 9
        '
        'txt_salary
        '
        Me.txt_salary.BackColor = System.Drawing.Color.White
        Me.txt_salary.Enabled = False
        Me.txt_salary.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_salary.Location = New System.Drawing.Point(66, 162)
        Me.txt_salary.Name = "txt_salary"
        Me.txt_salary.PlaceholderText = "เงินเดือน"
        Me.txt_salary.Size = New System.Drawing.Size(158, 31)
        Me.txt_salary.TabIndex = 21
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_back.Location = New System.Drawing.Point(79, 419)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(131, 37)
        Me.btn_back.TabIndex = 15
        Me.btn_back.Text = "กลับไปหน้าหลัก"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Cal_Bonus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(527, 542)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Cal_Bonus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cal_Bonus"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents txt_lname As TextBox
    Friend WithEvents btn_submit As Button
    Friend WithEvents cbo_department As ComboBox
    Friend WithEvents txt_fname As TextBox
    Friend WithEvents txt_salary As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class

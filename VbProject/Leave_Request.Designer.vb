<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Leave_Request
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dtgLeaveRequests = New System.Windows.Forms.DataGridView()
        Me.btn_admin_leave = New System.Windows.Forms.Button()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.btn_disapprove = New System.Windows.Forms.Button()
        Me.btn_approve = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dtgLeaveRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.dtgLeaveRequests)
        Me.Panel1.Controls.Add(Me.btn_admin_leave)
        Me.Panel1.Controls.Add(Me.lbl_status)
        Me.Panel1.Controls.Add(Me.btn_disapprove)
        Me.Panel1.Controls.Add(Me.btn_approve)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Location = New System.Drawing.Point(22, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 442)
        Me.Panel1.TabIndex = 14
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRefresh.Location = New System.Drawing.Point(673, 383)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(119, 37)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.Text = "รีเฟรช"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'dtgLeaveRequests
        '
        Me.dtgLeaveRequests.AllowUserToAddRows = False
        Me.dtgLeaveRequests.AllowUserToDeleteRows = False
        Me.dtgLeaveRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgLeaveRequests.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgLeaveRequests.BackgroundColor = System.Drawing.Color.White
        Me.dtgLeaveRequests.Location = New System.Drawing.Point(17, 80)
        Me.dtgLeaveRequests.MultiSelect = False
        Me.dtgLeaveRequests.Name = "dtgLeaveRequests"
        Me.dtgLeaveRequests.ReadOnly = True
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgLeaveRequests.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgLeaveRequests.RowTemplate.Height = 25
        Me.dtgLeaveRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgLeaveRequests.Size = New System.Drawing.Size(775, 281)
        Me.dtgLeaveRequests.TabIndex = 18
        '
        'btn_admin_leave
        '
        Me.btn_admin_leave.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_admin_leave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_admin_leave.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_admin_leave.Location = New System.Drawing.Point(548, 383)
        Me.btn_admin_leave.Name = "btn_admin_leave"
        Me.btn_admin_leave.Size = New System.Drawing.Size(119, 37)
        Me.btn_admin_leave.TabIndex = 17
        Me.btn_admin_leave.Text = "ขอลาหยุด"
        Me.btn_admin_leave.UseVisualStyleBackColor = False
        '
        'lbl_status
        '
        Me.lbl_status.Font = New System.Drawing.Font("Kanit", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_status.Location = New System.Drawing.Point(0, 14)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(812, 43)
        Me.lbl_status.TabIndex = 16
        Me.lbl_status.Text = "รายชื่อการขอลางาน"
        Me.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_disapprove
        '
        Me.btn_disapprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_disapprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_disapprove.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_disapprove.Location = New System.Drawing.Point(423, 383)
        Me.btn_disapprove.Name = "btn_disapprove"
        Me.btn_disapprove.Size = New System.Drawing.Size(119, 37)
        Me.btn_disapprove.TabIndex = 15
        Me.btn_disapprove.Text = "ไม่อนุมัติ"
        Me.btn_disapprove.UseVisualStyleBackColor = False
        '
        'btn_approve
        '
        Me.btn_approve.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_approve.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_approve.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_approve.Location = New System.Drawing.Point(298, 383)
        Me.btn_approve.Name = "btn_approve"
        Me.btn_approve.Size = New System.Drawing.Size(119, 37)
        Me.btn_approve.TabIndex = 14
        Me.btn_approve.Text = "อนุมัติ"
        Me.btn_approve.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_back.Location = New System.Drawing.Point(17, 383)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(134, 37)
        Me.btn_back.TabIndex = 11
        Me.btn_back.Text = "กลับไปหน้าหลัก"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'Leave_Request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(865, 490)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Leave_Request"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave_Admin"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dtgLeaveRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_disapprove As Button
    Friend WithEvents btn_approve As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_status As Label
    Friend WithEvents btn_admin_leave As Button
    Friend WithEvents dtgLeaveRequests As DataGridView
    Friend WithEvents h As DataGridView
    Friend WithEvents t As DataGridView
    Friend WithEvents hnket As DataGridView
    Friend WithEvents btnRefresh As Button
End Class

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
        Dim dtg_empleave As System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_admin_leave = New System.Windows.Forms.Button()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.btn_disapprove = New System.Windows.Forms.Button()
        Me.btn_approve = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        dtg_empleave = New System.Windows.Forms.DataGridView()
        CType(dtg_empleave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtg_empleave
        '
        dtg_empleave.AllowUserToAddRows = False
        dtg_empleave.AllowUserToDeleteRows = False
        dtg_empleave.BackgroundColor = System.Drawing.Color.White
        dtg_empleave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtg_empleave.Location = New System.Drawing.Point(17, 70)
        dtg_empleave.Name = "dtg_empleave"
        dtg_empleave.ReadOnly = True
        dtg_empleave.RowTemplate.Height = 25
        dtg_empleave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dtg_empleave.Size = New System.Drawing.Size(775, 294)
        dtg_empleave.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(dtg_empleave)
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
        'btn_admin_leave
        '
        Me.btn_admin_leave.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_admin_leave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_admin_leave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_admin_leave.Location = New System.Drawing.Point(673, 383)
        Me.btn_admin_leave.Name = "btn_admin_leave"
        Me.btn_admin_leave.Size = New System.Drawing.Size(119, 37)
        Me.btn_admin_leave.TabIndex = 17
        Me.btn_admin_leave.Text = "ขอลาหยุด"
        Me.btn_admin_leave.UseVisualStyleBackColor = False
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_status.Location = New System.Drawing.Point(325, 22)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(126, 20)
        Me.lbl_status.TabIndex = 16
        Me.lbl_status.Text = "รายชื่อการขอลางาน"
        '
        'btn_disapprove
        '
        Me.btn_disapprove.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_disapprove.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_disapprove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_disapprove.Location = New System.Drawing.Point(548, 383)
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
        Me.btn_approve.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_approve.Location = New System.Drawing.Point(423, 383)
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
        Me.btn_back.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
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
        CType(dtg_empleave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_disapprove As Button
    Friend WithEvents btn_approve As Button
    Friend WithEvents btn_back As Button
    Friend WithEvents lbl_status As Label
    Friend WithEvents btn_admin_leave As Button
    Friend WithEvents dtg_empleave As DataGridView
End Class

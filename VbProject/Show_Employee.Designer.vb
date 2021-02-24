<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_Employee
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txt_fname_search = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtg_empinfo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dtg_empinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_back.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_back.Location = New System.Drawing.Point(18, 418)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(134, 37)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "กลับไปหน้าหลัก"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_search.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_search.Location = New System.Drawing.Point(190, 66)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(85, 31)
        Me.btn_search.TabIndex = 1
        Me.btn_search.Text = "ค้นหา"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'txt_fname_search
        '
        Me.txt_fname_search.BackColor = System.Drawing.Color.White
        Me.txt_fname_search.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_fname_search.Location = New System.Drawing.Point(18, 66)
        Me.txt_fname_search.Name = "txt_fname_search"
        Me.txt_fname_search.PlaceholderText = "กรอก ชื่อ หรือ นามสกุล"
        Me.txt_fname_search.Size = New System.Drawing.Size(166, 31)
        Me.txt_fname_search.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtg_empinfo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.btn_insert)
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Controls.Add(Me.txt_fname_search)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Location = New System.Drawing.Point(22, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(812, 471)
        Me.Panel1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(13, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 25)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ค้นหาโดย ชื่อ หรือ นามสกุล"
        '
        'dtg_empinfo
        '
        Me.dtg_empinfo.BackgroundColor = System.Drawing.Color.White
        Me.dtg_empinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_empinfo.Location = New System.Drawing.Point(18, 113)
        Me.dtg_empinfo.Name = "dtg_empinfo"
        Me.dtg_empinfo.RowTemplate.Height = 25
        Me.dtg_empinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtg_empinfo.Size = New System.Drawing.Size(775, 286)
        Me.dtg_empinfo.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(336, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "รายชื่อพนักงานทั้งหมด"
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_delete.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete.Location = New System.Drawing.Point(674, 418)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(119, 37)
        Me.btn_delete.TabIndex = 4
        Me.btn_delete.Text = "ลบข้อมูล"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_update.Location = New System.Drawing.Point(549, 418)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(119, 37)
        Me.btn_update.TabIndex = 3
        Me.btn_update.Text = "แก้ไขข้อมูล"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btn_insert
        '
        Me.btn_insert.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_insert.Font = New System.Drawing.Font("Kanit", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_insert.Location = New System.Drawing.Point(424, 418)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(119, 37)
        Me.btn_insert.TabIndex = 2
        Me.btn_insert.Text = "เพิ่มข้อมูล"
        Me.btn_insert.UseVisualStyleBackColor = False
        '
        'Show_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(858, 522)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Show_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dtg_empinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_back As Button
    Friend WithEvents btn_search As Button
    Friend WithEvents txt_fname_search As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dtg_empinfo As DataGridView
    Friend WithEvents Label2 As Label
End Class

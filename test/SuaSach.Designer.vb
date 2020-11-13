<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuaSach
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnsuasach = New System.Windows.Forms.Panel()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txttacgia = New System.Windows.Forms.TextBox()
        Me.txttheloai = New System.Windows.Forms.TextBox()
        Me.txttensach = New System.Windows.Forms.TextBox()
        Me.txtmasach = New System.Windows.Forms.TextBox()
        Me.lbdongia = New System.Windows.Forms.Label()
        Me.lbtacgia = New System.Windows.Forms.Label()
        Me.lbtheloai = New System.Windows.Forms.Label()
        Me.lbtensach = New System.Windows.Forms.Label()
        Me.lbmasach = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout
        Me.pnsuasach.SuspendLayout
        Me.SuspendLayout
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(59, 323)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(363, 64)
        Me.Panel2.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button2.Location = New System.Drawing.Point(210, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 58)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Hủy"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Button1.Location = New System.Drawing.Point(53, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cập Nhật"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(262, 31)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Thông Tin Của Sách"
        '
        'pnsuasach
        '
        Me.pnsuasach.Controls.Add(Me.txtdongia)
        Me.pnsuasach.Controls.Add(Me.txttacgia)
        Me.pnsuasach.Controls.Add(Me.txttheloai)
        Me.pnsuasach.Controls.Add(Me.txttensach)
        Me.pnsuasach.Controls.Add(Me.txtmasach)
        Me.pnsuasach.Controls.Add(Me.lbdongia)
        Me.pnsuasach.Controls.Add(Me.lbtacgia)
        Me.pnsuasach.Controls.Add(Me.lbtheloai)
        Me.pnsuasach.Controls.Add(Me.lbtensach)
        Me.pnsuasach.Controls.Add(Me.lbmasach)
        Me.pnsuasach.Location = New System.Drawing.Point(14, 68)
        Me.pnsuasach.Name = "pnsuasach"
        Me.pnsuasach.Size = New System.Drawing.Size(431, 235)
        Me.pnsuasach.TabIndex = 11
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(98, 196)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(320, 20)
        Me.txtdongia.TabIndex = 7
        '
        'txttacgia
        '
        Me.txttacgia.Location = New System.Drawing.Point(98, 153)
        Me.txttacgia.Name = "txttacgia"
        Me.txttacgia.Size = New System.Drawing.Size(320, 20)
        Me.txttacgia.TabIndex = 8
        '
        'txttheloai
        '
        Me.txttheloai.Location = New System.Drawing.Point(98, 105)
        Me.txttheloai.Name = "txttheloai"
        Me.txttheloai.Size = New System.Drawing.Size(320, 20)
        Me.txttheloai.TabIndex = 9
        '
        'txttensach
        '
        Me.txttensach.Location = New System.Drawing.Point(98, 64)
        Me.txttensach.Name = "txttensach"
        Me.txttensach.Size = New System.Drawing.Size(320, 20)
        Me.txttensach.TabIndex = 10
        '
        'txtmasach
        '
        Me.txtmasach.Location = New System.Drawing.Point(98, 19)
        Me.txtmasach.Name = "txtmasach"
        Me.txtmasach.ReadOnly = true
        Me.txtmasach.Size = New System.Drawing.Size(320, 20)
        Me.txtmasach.TabIndex = 11
        '
        'lbdongia
        '
        Me.lbdongia.AutoSize = true
        Me.lbdongia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbdongia.Location = New System.Drawing.Point(3, 196)
        Me.lbdongia.Name = "lbdongia"
        Me.lbdongia.Size = New System.Drawing.Size(78, 24)
        Me.lbdongia.TabIndex = 2
        Me.lbdongia.Text = "Đơn Giá"
        '
        'lbtacgia
        '
        Me.lbtacgia.AutoSize = true
        Me.lbtacgia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbtacgia.Location = New System.Drawing.Point(3, 153)
        Me.lbtacgia.Name = "lbtacgia"
        Me.lbtacgia.Size = New System.Drawing.Size(75, 24)
        Me.lbtacgia.TabIndex = 3
        Me.lbtacgia.Text = "Tác Giả"
        '
        'lbtheloai
        '
        Me.lbtheloai.AutoSize = true
        Me.lbtheloai.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbtheloai.Location = New System.Drawing.Point(0, 105)
        Me.lbtheloai.Name = "lbtheloai"
        Me.lbtheloai.Size = New System.Drawing.Size(84, 24)
        Me.lbtheloai.TabIndex = 4
        Me.lbtheloai.Text = "Thể Loại"
        '
        'lbtensach
        '
        Me.lbtensach.AutoSize = true
        Me.lbtensach.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbtensach.Location = New System.Drawing.Point(0, 64)
        Me.lbtensach.Name = "lbtensach"
        Me.lbtensach.Size = New System.Drawing.Size(92, 24)
        Me.lbtensach.TabIndex = 5
        Me.lbtensach.Text = "Tên Sách"
        '
        'lbmasach
        '
        Me.lbmasach.AutoSize = true
        Me.lbmasach.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbmasach.Location = New System.Drawing.Point(0, 15)
        Me.lbmasach.Name = "lbmasach"
        Me.lbmasach.Size = New System.Drawing.Size(84, 24)
        Me.lbmasach.TabIndex = 6
        Me.lbmasach.Text = "Mã Sách"
        '
        'SuaSach
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 449)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnsuasach)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "SuaSach"
        Me.Text = "SuaSach"
        Me.Panel2.ResumeLayout(false)
        Me.pnsuasach.ResumeLayout(false)
        Me.pnsuasach.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents pnsuasach As Panel
    Friend WithEvents txtdongia As TextBox
    Friend WithEvents txttacgia As TextBox
    Friend WithEvents txttheloai As TextBox
    Friend WithEvents txttensach As TextBox
    Friend WithEvents txtmasach As TextBox
    Friend WithEvents lbdongia As Label
    Friend WithEvents lbtacgia As Label
    Friend WithEvents lbtheloai As Label
    Friend WithEvents lbtensach As Label
    Friend WithEvents lbmasach As Label
End Class

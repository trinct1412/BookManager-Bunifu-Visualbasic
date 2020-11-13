<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvsach = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThêmSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SửaSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XóaSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraCứuSáchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuyĐịnhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThayĐổiQuyĐịnhToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpHóaĐơnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PhieuThuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpPhiếuThuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BáoCáoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpBáoCáoCôngNợToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpBáoCáoTồnKhoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KháchHàngToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btexit = New System.Windows.Forms.Button()
        Me.btremove = New System.Windows.Forms.Button()
        Me.btadd = New System.Windows.Forms.Button()
        Me.btlapphieunhap = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbtensach = New System.Windows.Forms.Label()
        Me.txtmasach = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Bttimkiem = New System.Windows.Forms.Button()
        Me.dtngaynhap = New System.Windows.Forms.DateTimePicker()
        Me.pnphieunhapsach = New System.Windows.Forms.Panel()
        Me.txttensach = New System.Windows.Forms.TextBox()
        Me.lbmasach = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtsoluongnhap = New System.Windows.Forms.TextBox()
        Me.lbsoluongnhap = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout
        CType(Me.dgvsach,System.ComponentModel.ISupportInitialize).BeginInit
        Me.MenuStrip1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.pnphieunhapsach.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvsach)
        Me.Panel2.Location = New System.Drawing.Point(12, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(755, 672)
        Me.Panel2.TabIndex = 1
        '
        'dgvsach
        '
        Me.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvsach.Location = New System.Drawing.Point(3, 2)
        Me.dgvsach.Name = "dgvsach"
        Me.dgvsach.ReadOnly = true
        Me.dgvsach.RowHeadersVisible = false
        Me.dgvsach.Size = New System.Drawing.Size(752, 667)
        Me.dgvsach.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HóaĐơnToolStripMenuItem, Me.PhieuThuToolStripMenuItem, Me.BáoCáoToolStripMenuItem, Me.KháchHàngToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1328, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThêmSáchToolStripMenuItem, Me.SửaSáchToolStripMenuItem, Me.XóaSáchToolStripMenuItem, Me.TraCứuSáchToolStripMenuItem, Me.QuyĐịnhToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ThêmSáchToolStripMenuItem
        '
        Me.ThêmSáchToolStripMenuItem.Name = "ThêmSáchToolStripMenuItem"
        Me.ThêmSáchToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ThêmSáchToolStripMenuItem.Text = "Thêm Sách"
        '
        'SửaSáchToolStripMenuItem
        '
        Me.SửaSáchToolStripMenuItem.Name = "SửaSáchToolStripMenuItem"
        Me.SửaSáchToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.SửaSáchToolStripMenuItem.Text = "Sửa Sách"
        '
        'XóaSáchToolStripMenuItem
        '
        Me.XóaSáchToolStripMenuItem.Name = "XóaSáchToolStripMenuItem"
        Me.XóaSáchToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.XóaSáchToolStripMenuItem.Text = "Xóa Sách"
        '
        'TraCứuSáchToolStripMenuItem
        '
        Me.TraCứuSáchToolStripMenuItem.Name = "TraCứuSáchToolStripMenuItem"
        Me.TraCứuSáchToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.TraCứuSáchToolStripMenuItem.Text = "Tra Cứu Sách"
        '
        'QuyĐịnhToolStripMenuItem
        '
        Me.QuyĐịnhToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThayĐổiQuyĐịnhToolStripMenuItem})
        Me.QuyĐịnhToolStripMenuItem.Name = "QuyĐịnhToolStripMenuItem"
        Me.QuyĐịnhToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.QuyĐịnhToolStripMenuItem.Text = "Quy Định"
        '
        'ThayĐổiQuyĐịnhToolStripMenuItem
        '
        Me.ThayĐổiQuyĐịnhToolStripMenuItem.Name = "ThayĐổiQuyĐịnhToolStripMenuItem"
        Me.ThayĐổiQuyĐịnhToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ThayĐổiQuyĐịnhToolStripMenuItem.Text = "Thay Đổi Quy Định"
        '
        'HóaĐơnToolStripMenuItem
        '
        Me.HóaĐơnToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpHóaĐơnToolStripMenuItem})
        Me.HóaĐơnToolStripMenuItem.Name = "HóaĐơnToolStripMenuItem"
        Me.HóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HóaĐơnToolStripMenuItem.Text = "Hóa Đơn"
        '
        'LậpHóaĐơnToolStripMenuItem
        '
        Me.LậpHóaĐơnToolStripMenuItem.Name = "LậpHóaĐơnToolStripMenuItem"
        Me.LậpHóaĐơnToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.LậpHóaĐơnToolStripMenuItem.Text = "Lập Hóa Đơn"
        '
        'PhieuThuToolStripMenuItem
        '
        Me.PhieuThuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpPhiếuThuToolStripMenuItem})
        Me.PhieuThuToolStripMenuItem.Name = "PhieuThuToolStripMenuItem"
        Me.PhieuThuToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.PhieuThuToolStripMenuItem.Text = "Phiếu Thu"
        '
        'LậpPhiếuThuToolStripMenuItem
        '
        Me.LậpPhiếuThuToolStripMenuItem.Name = "LậpPhiếuThuToolStripMenuItem"
        Me.LậpPhiếuThuToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.LậpPhiếuThuToolStripMenuItem.Text = "Lập Phiếu Thu"
        '
        'BáoCáoToolStripMenuItem
        '
        Me.BáoCáoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpBáoCáoCôngNợToolStripMenuItem, Me.LậpBáoCáoTồnKhoToolStripMenuItem})
        Me.BáoCáoToolStripMenuItem.Name = "BáoCáoToolStripMenuItem"
        Me.BáoCáoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.BáoCáoToolStripMenuItem.Text = "Báo Cáo"
        '
        'LậpBáoCáoCôngNợToolStripMenuItem
        '
        Me.LậpBáoCáoCôngNợToolStripMenuItem.Name = "LậpBáoCáoCôngNợToolStripMenuItem"
        Me.LậpBáoCáoCôngNợToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LậpBáoCáoCôngNợToolStripMenuItem.Text = "Lập Báo Cáo Công Nợ"
        '
        'LậpBáoCáoTồnKhoToolStripMenuItem
        '
        Me.LậpBáoCáoTồnKhoToolStripMenuItem.Name = "LậpBáoCáoTồnKhoToolStripMenuItem"
        Me.LậpBáoCáoTồnKhoToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.LậpBáoCáoTồnKhoToolStripMenuItem.Text = "Lập Báo Cáo Tồn Kho"
        '
        'KháchHàngToolStripMenuItem
        '
        Me.KháchHàngToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KháchHàngToolStripMenuItem1})
        Me.KháchHàngToolStripMenuItem.Name = "KháchHàngToolStripMenuItem"
        Me.KháchHàngToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.KháchHàngToolStripMenuItem.Text = "khách Hàng"
        '
        'KháchHàngToolStripMenuItem1
        '
        Me.KháchHàngToolStripMenuItem1.Name = "KháchHàngToolStripMenuItem1"
        Me.KháchHàngToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.KháchHàngToolStripMenuItem1.Text = "Khách Hàng"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1328, 24)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btexit)
        Me.Panel4.Controls.Add(Me.btremove)
        Me.Panel4.Controls.Add(Me.btadd)
        Me.Panel4.Controls.Add(Me.btlapphieunhap)
        Me.Panel4.Location = New System.Drawing.Point(774, 251)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(569, 52)
        Me.Panel4.TabIndex = 3
        '
        'btexit
        '
        Me.btexit.Location = New System.Drawing.Point(436, 0)
        Me.btexit.Name = "btexit"
        Me.btexit.Size = New System.Drawing.Size(75, 49)
        Me.btexit.TabIndex = 0
        Me.btexit.Text = "Exit"
        Me.btexit.UseVisualStyleBackColor = true
        '
        'btremove
        '
        Me.btremove.Location = New System.Drawing.Point(325, 3)
        Me.btremove.Name = "btremove"
        Me.btremove.Size = New System.Drawing.Size(75, 46)
        Me.btremove.TabIndex = 0
        Me.btremove.Text = "remove"
        Me.btremove.UseVisualStyleBackColor = true
        '
        'btadd
        '
        Me.btadd.Location = New System.Drawing.Point(215, 1)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(75, 46)
        Me.btadd.TabIndex = 0
        Me.btadd.Text = "Add"
        Me.btadd.UseVisualStyleBackColor = true
        '
        'btlapphieunhap
        '
        Me.btlapphieunhap.Location = New System.Drawing.Point(98, 0)
        Me.btlapphieunhap.Name = "btlapphieunhap"
        Me.btlapphieunhap.Size = New System.Drawing.Size(75, 46)
        Me.btlapphieunhap.TabIndex = 0
        Me.btlapphieunhap.Text = "Lập Phiếu Nhập"
        Me.btlapphieunhap.UseVisualStyleBackColor = true
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Ngày Nhập"
        '
        'lbtensach
        '
        Me.lbtensach.AutoSize = true
        Me.lbtensach.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbtensach.Location = New System.Drawing.Point(97, 126)
        Me.lbtensach.Name = "lbtensach"
        Me.lbtensach.Size = New System.Drawing.Size(92, 24)
        Me.lbtensach.TabIndex = 5
        Me.lbtensach.Text = "Tên Sách"
        '
        'txtmasach
        '
        Me.txtmasach.Location = New System.Drawing.Point(218, 87)
        Me.txtmasach.Name = "txtmasach"
        Me.txtmasach.ReadOnly = true
        Me.txtmasach.Size = New System.Drawing.Size(150, 20)
        Me.txtmasach.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(162, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 31)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Lập Phiếu Nhập Sách"
        '
        'Bttimkiem
        '
        Me.Bttimkiem.Location = New System.Drawing.Point(389, 84)
        Me.Bttimkiem.Name = "Bttimkiem"
        Me.Bttimkiem.Size = New System.Drawing.Size(99, 23)
        Me.Bttimkiem.TabIndex = 10
        Me.Bttimkiem.Text = "Tìm Kiếm"
        Me.Bttimkiem.UseVisualStyleBackColor = true
        '
        'dtngaynhap
        '
        Me.dtngaynhap.Location = New System.Drawing.Point(218, 47)
        Me.dtngaynhap.Name = "dtngaynhap"
        Me.dtngaynhap.Size = New System.Drawing.Size(255, 20)
        Me.dtngaynhap.TabIndex = 9
        '
        'pnphieunhapsach
        '
        Me.pnphieunhapsach.Controls.Add(Me.txttensach)
        Me.pnphieunhapsach.Controls.Add(Me.dtngaynhap)
        Me.pnphieunhapsach.Controls.Add(Me.Bttimkiem)
        Me.pnphieunhapsach.Controls.Add(Me.Label5)
        Me.pnphieunhapsach.Controls.Add(Me.txtmasach)
        Me.pnphieunhapsach.Controls.Add(Me.lbmasach)
        Me.pnphieunhapsach.Controls.Add(Me.lbtensach)
        Me.pnphieunhapsach.Controls.Add(Me.Label6)
        Me.pnphieunhapsach.Location = New System.Drawing.Point(771, 41)
        Me.pnphieunhapsach.Name = "pnphieunhapsach"
        Me.pnphieunhapsach.Size = New System.Drawing.Size(569, 164)
        Me.pnphieunhapsach.TabIndex = 4
        '
        'txttensach
        '
        Me.txttensach.Location = New System.Drawing.Point(218, 126)
        Me.txttensach.Name = "txttensach"
        Me.txttensach.ReadOnly = true
        Me.txttensach.Size = New System.Drawing.Size(270, 20)
        Me.txttensach.TabIndex = 11
        '
        'lbmasach
        '
        Me.lbmasach.AutoSize = true
        Me.lbmasach.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbmasach.Location = New System.Drawing.Point(97, 84)
        Me.lbmasach.Name = "lbmasach"
        Me.lbmasach.Size = New System.Drawing.Size(84, 24)
        Me.lbmasach.TabIndex = 5
        Me.lbmasach.Text = "Mã Sách"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Location = New System.Drawing.Point(771, 309)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 402)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Danh Sách Các Sách được Nhập"
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(3, 16)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(561, 383)
        Me.ListView1.SmallImageList = Me.ImageList1
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = false
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Book-PNG-File1.png")
        '
        'txtsoluongnhap
        '
        Me.txtsoluongnhap.Location = New System.Drawing.Point(1017, 211)
        Me.txtsoluongnhap.Name = "txtsoluongnhap"
        Me.txtsoluongnhap.Size = New System.Drawing.Size(242, 20)
        Me.txtsoluongnhap.TabIndex = 22
        '
        'lbsoluongnhap
        '
        Me.lbsoluongnhap.AutoSize = true
        Me.lbsoluongnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lbsoluongnhap.Location = New System.Drawing.Point(868, 210)
        Me.lbsoluongnhap.Name = "lbsoluongnhap"
        Me.lbsoluongnhap.Size = New System.Drawing.Size(143, 24)
        Me.lbsoluongnhap.TabIndex = 21
        Me.lbsoluongnhap.Text = "Số Lượng Nhập"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1352, 761)
        Me.Controls.Add(Me.txtsoluongnhap)
        Me.Controls.Add(Me.lbsoluongnhap)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pnphieunhapsach)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(false)
        CType(Me.dgvsach,System.ComponentModel.ISupportInitialize).EndInit
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.pnphieunhapsach.ResumeLayout(false)
        Me.pnphieunhapsach.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvsach As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThêmSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SửaSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents XóaSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TraCứuSáchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuyĐịnhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThayĐổiQuyĐịnhToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpHóaĐơnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PhieuThuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpPhiếuThuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BáoCáoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpBáoCáoCôngNợToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpBáoCáoTồnKhoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KháchHàngToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btexit As Button
    Friend WithEvents btremove As Button
    Friend WithEvents btadd As Button
    Friend WithEvents btlapphieunhap As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lbtensach As Label
    Friend WithEvents txtmasach As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Bttimkiem As Button
    Friend WithEvents dtngaynhap As DateTimePicker
    Friend WithEvents pnphieunhapsach As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txttensach As TextBox
    Friend WithEvents lbmasach As Label
    Friend WithEvents txtsoluongnhap As TextBox
    Friend WithEvents lbsoluongnhap As Label
End Class

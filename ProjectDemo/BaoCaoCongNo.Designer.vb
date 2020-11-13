<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaoCaoCongNo
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(71, 172)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 306)
        Me.Panel1.TabIndex = 11
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(605, 300)
        Me.DataGridView1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(574, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Xuất Ra Máy in"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(448, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Lập Báo Cáo"
        Me.Button1.UseVisualStyleBackColor = true
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(334, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Chi Tiết Báo Cáo Công Nợ"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(67, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 24)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Tháng Báo Cáo"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(215, 114)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(214, 21)
        Me.ComboBox1.TabIndex = 12
        '
        'BaoCaoCongNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 513)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Name = "BaoCaoCongNo"
        Me.Text = "BaoCaoCongNo"
        Me.Panel1.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class

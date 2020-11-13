Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) 

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged, TextBox6.TextChanged, TextBox5.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click, Label8.Click, Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ThêmSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        
    End Sub

    Private Sub ThêmSáchToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ThêmSáchToolStripMenuItem.Click
        ThemSach.Show()
    End Sub

    Private Sub LậpHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpHóaĐơnToolStripMenuItem.Click

    End Sub

    Private Sub SửaSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SửaSáchToolStripMenuItem.Click
        SuaSach.Show()
    End Sub

    Private Sub XóaSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaSáchToolStripMenuItem.Click
        XoaSach.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SuaSach.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        XoaSach.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        me.Close()
    End Sub

    Private Sub LậpHóaĐơnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LậpHóaĐơnToolStripMenuItem1.Click
        LapHoaDonBanSach.Show()
    End Sub

    Private Sub ThêmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThêmToolStripMenuItem.Click
        ThemKhachHang.Show()
    End Sub

    Private Sub CậpNhậtThôngTinKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CậpNhậtThôngTinKháchHàngToolStripMenuItem.Click
        CapNhatThongTinKhachHang.Show()
    End Sub

    Private Sub XóaKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaKháchHàngToolStripMenuItem.Click
        XoaKhachHAng.Show()
    End Sub

    Private Sub BáoCáoTồnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoTồnToolStripMenuItem.Click
        LapBaoCaoTon.Show()
    End Sub

    Private Sub BáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BáoCáoCôngNợToolStripMenuItem.Click
        BaoCaoCongNo.Show()
    End Sub

    Private Sub ThayĐổiQuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThayĐổiQuyĐịnhToolStripMenuItem.Click
        ThayDoiQuyDinh.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       MessageBox.Show(format(Datetime.Today().ToString("dd")).ToString())
    End Sub

    Private Sub Bttimkiem_Click(sender As Object, e As EventArgs) Handles Bttimkiem.Click
        TraCuuSach.Show()
       
    End Sub
End Class

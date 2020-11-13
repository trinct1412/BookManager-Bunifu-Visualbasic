

Public Class Form1
    Dim ReadOnly abc as BindingSource = New BindingSource()

    private Sub UpdateDG(Table As DataTable)
        dgvsach.DataSource = abc
        abc.DataSource = Table
    End sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Table as New DataTable
        Table = DataProvider.ExecuteQuery("SELECT * FROM SACH")
        UpdateDG(Table)
        BuilderTable.BindingTable(dgvsach, pnphieunhapsach)
        txtsoluongnhap.Text = 0
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btexit.Click
        me.Close()
    End Sub

    Private Sub Bttimkiem_Click(sender As Object, e As EventArgs) Handles Bttimkiem.Click

        Me.Hide()
        TraCuuSach.ShowDialog()
        me.Show()
    End Sub

    Private Sub ThêmSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles ThêmSáchToolStripMenuItem.Click
        ThemSach.Show()
        ThemSach.mnq = abc
    End Sub

    Private Sub SửaSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SửaSáchToolStripMenuItem.Click
        SuaSach.Show()
        suasach.mnq = abc
    End Sub

    Private Sub XóaSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XóaSáchToolStripMenuItem.Click
        XoaSach.Show()
        XoaSach.mnq = abc
    End Sub

    Private Sub TraCứuSáchToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles TraCứuSáchToolStripMenuItem.Click
        TraCuuSach.Show()
    End Sub

    Private Sub ThayĐổiQuyĐịnhToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles ThayĐổiQuyĐịnhToolStripMenuItem.Click
        QuyDinh.Show()
    End Sub

    Private Sub LậpHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles LậpHóaĐơnToolStripMenuItem.Click
        me.Hide()
        LapHoaDon.ShowDiaLog()
        Me.Show()
    End Sub

    Private Sub LậpPhiếuThuToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles LậpPhiếuThuToolStripMenuItem.Click
        me.Hide()
        LapPhieuThu.ShowDiaLog()
        me.Show()
    End Sub

    Private Sub LậpBáoCáoCôngNợToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles LậpBáoCáoCôngNợToolStripMenuItem.Click
        me.Hide()
        LapBaoCaoCongNo.ShowDiaLog()
        me.Show()
    End Sub

    Private Sub LậpBáoCáoTồnKhoToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles LậpBáoCáoTồnKhoToolStripMenuItem.Click
        me.Hide()
        LapBaoCaoTonKho.ShowDiaLog()
        me.Show()
    End Sub

    Private Sub KháchHàngToolStripMenuItem1_Click(sender As Object, e As EventArgs) _
        Handles KháchHàngToolStripMenuItem1.Click
        me.Hide()
        KhachHangvb.ShowDialog()
        me.Show()
    End Sub

    Private Sub dgvsach_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvsach.CellContentClick
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
    End Sub

    Function kiemtraquydinhnhap(soluongnhapitnhat As Integer, soluongtontoidatruongkhinhap As Integer,
                                MASACH As String) As string
        dim kq = ""
        Dim HopLe As Boolean
        HopLe = txtsoluongnhap.Text >= soluongnhapitnhat
        If Not HopLe Then
            kq = kq & "Bạn phải nhập số lượng ít nhất là" + soluongnhapitnhat.ToString() + vbCrLf
        End If
        Dim Table as New DataTable
        Table = DataProvider.ExecuteQuery("SELECT SOLUONG FROM SACH WHERE MASACH = '" + MASACH + "'")
        Dim SOLUONG as Integer = Table.Rows(0)(0)
        HopLe = SOLUONG <= 300
        If Not HopLe Then
            kq = kq &
                 "bạn chỉ được nhập các đầu sách có số lượng ít hơn " + soluongtontoidatruongkhinhap.ToString() + vbCrLf
        End If
        Return kq
    End Function

    Private Sub btadd_Click(sender As Object, e As EventArgs) Handles btadd.Click
        If not txtsoluongnhap.Text = "" Then
            dim table as new DataTable
            Dim soluongnhapitnhat as Integer
            dim soluongtontoidatruockhinhap as Integer
            Table = DataProvider.ExecuteQuery("SELECT SOLUONGNHAPTOITHIEU , SOLUONGTONTOI FROM THAMSO ")
            For Each o As DataRow In Table.Rows
                soluongnhapitnhat = o("SOLUONGNHAPTOITHIEU")
                soluongtontoidatruockhinhap = o("SOLUONGTONTOI")
            Next
            Table = DataProvider.ExecuteQuery("SELECT SOLUONG FROM SACH WHERE MASACH = '" + txtmasach.Text + "'")
            Dim SOLUONG as Integer = Table.Rows(0)(0)
            if (txtsoluongnhap.Text >= soluongnhapitnhat) AND (SOLUONG <= 300) Then
                Dim item = new ListViewitem()
                item.ImageIndex = 0
                item.Text = lbmasach.Text + " : " + txtmasach.Text + vbCrLf + lbtensach.Text + " : " +
                            txttensach.Text.Replace("          ", "") + vbCrLf + lbsoluongnhap.Text + " : " +
                            txtsoluongnhap.Text
                ListView1.Items.Add(item)
                txtsoluongnhap.Text = 0
            else
                MessageBox.Show(kiemtraquydinhnhap(soluongnhapitnhat, soluongtontoidatruockhinhap, txtmasach.Text))
            End If
        Else
            MessageBox.Show("bạn không được để trống ô số lượng nhập")
        End If


        'dim query = "EXEC  USP_INSERTINTOCHITIETPHIEUNHAP @MACHITIETPHIEUNHAP , @MASACH , @SOLUONGNHAP "
        ' table = DataProvider.ExecuteQueryWithData(query,New Object(){MACHITIETPHIEUNHAP,txtmasach.Text,txtsoluongnhap.Text})
        'MessageBox.Show(format(dtngaynhap.value,"yyyy-MM-dd"))
    End Sub

    Private Sub btremove_Click(sender As Object, e As EventArgs) Handles btremove.Click
        For Each o As ListViewItem In ListView1.Items
            If o.Selected then
                o.Remove()
            End If

        Next
    End Sub


    Private Sub btlapphieunhap_Click(sender As Object, e As EventArgs) Handles btlapphieunhap.Click
        dim table as New DataTable
        table = DataProvider.ExecuteQuery("EXEC USP_AUTOMAPHIEUNHAP")
        Dim MAPHIEUNHAP as String = table.Rows(0)(0)
        Dim MACHITIETPHIEUNHAP as String
        dim str as string
        dim splitmasachvasoluongnhap() as String
        If ListView1.Items.Count <= 0 Then
            MessageBox.Show("Bạn chưa thêm bất kì cuốn sách nào")
        Else
            BuilderTable.updatetableintoSQL("PHIEUNHAP",
                                            New Object() {MAPHIEUNHAP, format(dtngaynhap.value, "yyyy-MM-dd")})
            For Each o As ListViewItem In ListView1.Items
                table = DataProvider.ExecuteQuery("EXEC USP_AUTOMACHITIETPHIEUNHAP")
                MACHITIETPHIEUNHAP = table.Rows(0)(0)
                Str = o.Text
                str = str.Replace(lbmasach.Text + " : ", "")
                str = str.Replace(lbsoluongnhap.Text + " : ", "")
                str = str.Replace(lbtensach.Text + " : ", "")
                splitmasachvasoluongnhap = str.Split(vbCrLf)
                BuilderTable.updatetableintoSQL("CHITIETPHIEUNHAP",
                                                New Object() _
                                                   {MACHITIETPHIEUNHAP, MAPHIEUNHAP, splitmasachvasoluongnhap(0),
                                                    splitmasachvasoluongnhap(2)})
                'DataProvider.ExecuteQueryWithData("EXEC USP_UPDATESOLUNOGSACHKHINHAP @MASACH , @SOLUONGNHAP",
                '                                New Object() _
                '                                    {splitmasachvasoluongnhap(0),
                '                                      int32.parse(splitmasachvasoluongnhap(2))})

                DataProvider.ExecuteQuery(" USP_UPDATESOLUNOGSACHKHINHAP @MASACH =" +"'"+ splitmasachvasoluongnhap(0)+"'" +" , " + "@SOLUONGNHAP = " + splitmasachvasoluongnhap(2))

                Array.Clear(splitmasachvasoluongnhap, 0, splitmasachvasoluongnhap.Length)
            Next
            ListView1.Items.Clear()
            table = DataProvider.ExecuteQuery("SELECT * FROM SACH")
            UpdateDG(table)
            MessageBox.Show("đã tạo thành công phiếu lập")

        End If

        'dim query ="EXEC USP_INSERTINTOPHIEUNHAP @MAPHIEUNHAP , @NGAYNHAP"
        'table = DataProvider.ExecuteQueryWithData(query,New Object(){MAPHIEUNHAP,format(dtngaynhap.value,"yyyy-MM-dd")})
        ' DataGridView1.DataSource=table
        '  table.Rows.Clear()
        '  xyz("MAPHIEUNHAP") = 
        '   xyz("NGAYNHAP") =format(dtngaynhap.value,"yyyy-MM-dd")
    End Sub
End Class

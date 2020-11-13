Public Class LapPhieuThu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        me.hide()
        TimKiemKhachHang.ShowDialog()
        me.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Show()
         me.hide()
    End Sub
End Class
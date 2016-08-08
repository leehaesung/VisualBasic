Public Class Form1
    Dim fno, sno, res As Double
    Private Sub btn_plus_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plus.Click
        fno = txt_fno.Text
        sno = txt_sno.Text
        res = fno + sno
        txt_res.Text = res
    End Sub

    Private Sub btn_minus_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minus.Click
        fno = txt_fno.Text
        sno = txt_sno.Text
        res = fno - sno
        txt_res.Text = res
    End Sub

    Private Sub btn_multiply_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiply.Click
        fno = txt_fno.Text
        sno = txt_sno.Text
        res = fno * sno
        txt_res.Text = res
    End Sub

    Private Sub btn_devide_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles devide.Click
        fno = txt_fno.Text
        sno = txt_sno.Text
        res = fno / sno
        txt_res.Text = res
    End Sub

    Private Sub btn_clear_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        fno = txt_fno.Text
        ' txt_fno.Text = 0
        sno = txt_sno.Text
        ' txt_fno.Text = 0
        res = 0
        txt_res.Text = res
    End Sub
End Class

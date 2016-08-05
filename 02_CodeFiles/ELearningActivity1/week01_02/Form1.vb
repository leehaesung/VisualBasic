Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = " Haesung Lee "
        TextBox2.Text = " S078887 "
        TextBox3.Text = " 2/10 Orwell St, Potts Poin, NSW, 2011, Australia"
        TextBox4.Text = " 0432-399-841 "
        DateTimePicker1.Value.DayOfYear.ToString()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class

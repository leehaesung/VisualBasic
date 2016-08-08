Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_compare.Click
        ' variabls
        Dim fno, sno As Double
        fno = txt_fno.Text
        sno = txt_sno.Text

        ' Comparing between fnd and sno.
        If (fno > sno) Then
            MsgBox("1st number is bigger than 2nd number.", fno, sno)
        ElseIf (fno < sno) Then
            MsgBox("1st number is smaller 2nd number.", fno, sno)
        Else
            MsgBox("1st number is same as 2nd number.", fno, sno)
        End If

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_fno.Text = "" 'clear 1st number text box.'
        txt_sno.Text = "" 'clear 2nd number text box.
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()  'Exit 
    End Sub
End Class

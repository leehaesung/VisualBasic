Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_findday_click.Click
        Dim mychoice As Integer      'variables 

        mychoice = txt_choice.Text   'Put the coice data I want the day ( 1 to 7 )

        Select mychoice
            Case 1
                MsgBox("Today is Monday.")
            Case 2
                MsgBox("Today is Tuesday.")
            Case 3
                MsgBox("Today is Wednesday.")
            Case 4
                MsgBox("Today is Thursday.")
            Case 5
                MsgBox("Today is Friday.")
            Case 6
                MsgBox("Today is Saturday.")
            Case 7
                MsgBox("Today is Sunday.")
            Case Else
                MsgBox("Pleas enter the correct day")
        End Select
    End Sub
End Class

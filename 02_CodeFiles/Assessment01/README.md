# Assessment Project-I

* STUDENT NAME:	Haesung Lee
* STUDENT NO:	  S078887
* SUBJECT NO:	  M05

## Task-1: Build GUI Design applications 
## Designing Constraint:


![01_Login](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/01_Login.png)
* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/lgoin.vb#L8`

``````````
Public Class lgoin

    Dim userid, password As String 'variabls 

    Private Sub btn_submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_submit.Click
        userid = txt_userid.Text      'putting userid's variable
        password = txt_password.Text  'putting passoword's variable

        'Conditional 
        If (userid = "" Or password = "") Then
            MsgBox("User ID or password can't be empty, please enter necessary information.", MsgBoxStyle.Information, "Login Error")
        End If
        If IsNumeric(userid) Then
            MsgBox("User ID can't be numeric, please enter necessary information", MsgBoxStyle.Information, "Login Error")
        End If
        If password.Length < 6 Then
            MsgBox("Password length should be 6 chracters long, please enter necessary information", MsgBoxStyle.Information, "Login Error")
        End If
        If userid = "leehaesung" And password = "123456" Then
            MsgBox("Welcome in Conversion Applccation System", MsgBoxStyle.Information, "Login Sucessful")
            Me.Visible = False
            menu1.Visible = True
        End If
    End Sub

    Private Sub btn_facebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_facebook.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/achasmaeng")  'When you press the button, it is automatically linked the web'
    End Sub

    Private Sub btn_googleplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_googleplus.Click
        System.Diagnostics.Process.Start("https://plus.google.com/u/0/+StephenHaesungLee")  'When you press the button, it is automatically linked the web'
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        Close() ' Exit out from the form of User-login
    End Sub
End Class
``````````

* When you press the buttons(Facebook/Google+), it automatically is goint pop up below that. 
![02_02_FacebookAndGooglePlus](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/02_FacebookAndGooglePlus.png)

## Task 2: Create GUI  Application
## Operational Constraint:

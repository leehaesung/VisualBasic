# Assessment Project-I

* STUDENT NAME:	Haesung Lee
* STUDENT NO:	  S078887
* SUBJECT NO:	  M05

## Task-1: Build GUI Design applications 
## Designing Constraint:


![01_Login](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/01_Login.png)
* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/lgoin.vb#L8`

````````````````````````````````````````
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
````````````````````````````````````````

* When you press the buttons(Facebook/Google+), it's automatically going to pop up below that. 
![02_02_FacebookAndGooglePlus](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/02_FacebookAndGooglePlus.png)


## Task 2: Create GUI  Application
## Operational Constraint:

### 01 Operational Error
![03_01_error_operation](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/03_01_error_operation.png)
````````````````````````````````````````
If password.Length < 6 Then
            MsgBox("Password length should be 6 chracters long, please enter necessary information", MsgBoxStyle.Information, "Login Error")
````````````````````````````````````````

### 02 Operational Error
![03_02_error_operation](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/03_02_error_operation.png)
````````````````````````````````````````
If (userid = "" Or password = "") Then
            MsgBox("User ID or password can't be empty, please enter necessary information.", MsgBoxStyle.Information, "Login Error")
        End If
````````````````````````````````````````

### 03 Successful Operation
![03_03_nomal_operation](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/03_03_nomal_operation.png)
````````````````````````````````````````
If userid = "leehaesung" And password = "123456" Then
            MsgBox("Welcome in Conversion Applccation System", MsgBoxStyle.Information, "Login Sucessful")
            Me.Visible = False
            menu1.Visible = True
        End If
````````````````````````````````````````

### 04 Menu
![04_menu](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/04_menu.png)
* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/menu1.vb`
````````````````````````````````````````
Public Class menu1
    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_currency.Click
        currency_conversion.Visible = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_mass.Click
        mass_conversion.Visible = True
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_temerature.Click
        temperature_conversion.Visible = True
    End Sub

    Private Sub btn_emailme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_emailme.Click
        MsgBox(" achasma@gamil.com ")
    End Sub
End Class
````````````````````````````````````````

### All menues
![04_01_total_menu.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/04_01_total_menu.png)

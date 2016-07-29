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

### 05 All menues
![04_01_total_menu.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/04_01_total_menu.png)

### 06 Currency Coversion
![05_01_currency_conversion.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/05_01_currency_conversion.png)
* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/currency.vb`
````````````````````````````````````````
Public Class currency_conversion

    Private Sub btn_estimate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_estimate.Click
        Dim inputcurrency As Double
        inputcurrency = txt_sendAmount.Text
        If cb_ToCountry.SelectedIndex = 0 Then                  ' American(Dollar)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 1 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 1 Then              ' Australian(Dollar)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 1.34 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 2 Then              ' British(Pound)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 0.76 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 3 Then              ' Canadaian(Dollar)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 1.32 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 4 Then              ' Euro()/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 0.91 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 5 Then              ' Indian(Rupee)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 67.25 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 6 Then              ' Korean(Won)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 1133.9 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 7 Then              ' Mexican(Peso)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 18.74 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 8 Then              ' Singapore(Dollar)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 1.36 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 9 Then             ' South African(Rand)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 14.34 * inputcurrency

        ElseIf cb_ToCountry.SelectedIndex = 10 Then             ' Thai(Baht)/updated currency: 27/07/2016
            txt_ReceivingAmount.Text = 35.03 * inputcurrency

        End If
    End Sub
End Clas
````````````````````````````````````````

### 07 Currency Coversion's Operation
![05_02_currency_conversion_operation.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/05_02_currency_conversion_operation.png)


### 08 Mass Coversion
![/06_mass_conversion.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/06_mass_conversion.png)
* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/mass.vb`
````````````````````````````````````````
Public Class mass_conversion
    Private Sub btn_convert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_convert.Click
        Dim inputnumber As Double

        If rdo_from_pound.Checked = True And rdo_to_kilograms.Checked = True Then  'Conversion from lb(pound) to kg
            inputnumber = txt_numerOfUnit.Text
            txt_result.Text = 0.4536 * inputnumber    'formla from lb to kg
        Else  'Conversion from kg to lb
            inputnumber = txt_numerOfUnit.Text
            txt_result.Text = 2.2045855 * inputnumber 'formula from kg to lb
        End If
    End Sub
End Class
````````````````````````````````````````

### 09 Mass Coversion's Operation
![07_mass_conversion_operation.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/07_mass_conversion_operation.png)


### 10 Temperature Coversion
![08_temperature_conversion.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/08_temperature_conversion.png)
* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/temperature.vb`
````````````````````````````````````````
Public Class temperature_conversion
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FahrenheitValue01, CelsiousValue01 As Double

        FahrenheitValue01 = Val(txt_fahrenheit.Text) ' Input the data into variable

        CelsiousValue01 = 5 / 9 * (FahrenheitValue01 - 32) ' Conversion from F to C

        MsgBox("The conversion of Faherenheit to Celsious is " & CelsiousValue01)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim FahrenheitValue02, CelsiousValue02 As Double

        CelsiousValue02 = Val(txt_celsious2.Text) ' Input the celsious value data in the variable

        FahrenheitValue02 = (9 / 5 * CelsiousValue02) + 32 ' Conversion from C to F

        MsgBox("The conversion of Celsious to Faherenheit is " & FahrenheitValue02)
    End Sub
End Clas
````````````````````````````````````````

### 11 Temperature Coversion's Operation
![09_temperature_conversion_operation.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/OutputImageFiles/09_temperature_conversion_operation.png)


## Task 3 Debugging of GUI: 


## Task 4 Test GUI Application:







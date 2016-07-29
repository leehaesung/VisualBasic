﻿Public Class currency_conversion

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













            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'ElseIf cb_fromContry.SelectedIndex = 0 Then
            '   txt_ReceivingAmount.Text = 0.2 * inputcurrency
            'ElseIf cb_fromContry.SelectedIndex = 1 Then
            '   txt_ReceivingAmount.Text = 0.3 * inputcurrency
            'ElseIf cb_fromContry.SelectedIndex = 2 Then
            '   txt_ReceivingAmount.Text = 0.4 * inputcurrency
            'ElseIf cb_fromContry.SelectedIndex = 3 Then
            '   txt_ReceivingAmount.Text = 0.5 * inputcurrency
            'ElseIf cb_fromContry.SelectedIndex = 4 Then
            '   txt_ReceivingAmount.Text = 0.6 * inputcurrency
            'ElseIf cb_fromContry.SelectedIndex = 5 Then
            '   txt_ReceivingAmount.Text = 0.12 * inputcurrency
            'ElseIf cb_fromContry.SelectedIndex = 6 Then
            '   txt_ReceivingAmount.Text = 0.13 * inputcurrency
            'ElseIf cb_fromContry.SelectedIndex = 8 Then
            '    txt_ReceivingAmount.Text = 0.21 * inputcurrency
            'ElseIf cb_fromContry.SelectedIndex = 9 Then
            '    txt_ReceivingAmount.Text = 0.44 * inputcurrency
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Else  cb_fromContry.SelectedIndex = cb_ToCountry.SelectedIndex Then
            'txt_sendAmount.Text = txt_ReceivingAmount.Text
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        End If
    End Sub
End Class

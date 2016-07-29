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
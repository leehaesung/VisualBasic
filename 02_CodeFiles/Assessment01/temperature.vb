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
End Class
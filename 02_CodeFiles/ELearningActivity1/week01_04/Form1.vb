Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FahrenheitValue, CelsiusValue As Double

        CelsiusValue = Val(celsiusBox.Text) ' Input variable

        FahrenheitValue = ((9 / 5) * CelsiusValue) + 32  ' Conversion from C to F

        fahrenheitBox.Text = FahrenheitValue ' Output variable

    End Sub
End Class

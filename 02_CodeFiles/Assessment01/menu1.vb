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
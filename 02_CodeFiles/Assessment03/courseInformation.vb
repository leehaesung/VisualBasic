Public Class courseInformation

    Private Sub courseInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TrainingDataSet.tbl_Couse_information' table. You can move, or remove it, as needed.
        Me.Tbl_Couse_informationTableAdapter.Fill(Me.TrainingDataSet.tbl_Couse_information)

    End Sub
    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        TblCouseinformationBindingSource.MovePrevious()
    End Sub

    Private Sub btn_addNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addNew.Click
        TblCouseinformationBindingSource.AddNew()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        TblCouseinformationBindingSource.MoveNext()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        On Error GoTo SaveErr
        TblCouseinformationBindingSource.EndEdit()
        Tbl_Couse_informationTableAdapter.Update(TrainingDataSet.tbl_Couse_information)
        MessageBox.Show("Ok Boss")
SaveErr:
        Exit Sub
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        TblCouseinformationBindingSource.RemoveCurrent()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class
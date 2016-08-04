Public Class department

    Private Sub department_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TrainingDataSet.tbl_Department' table. You can move, or remove it, as needed.
        Me.Tbl_DepartmentTableAdapter.Fill(Me.TrainingDataSet.tbl_Department)

    End Sub

    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        TblDepartmentBindingSource.MovePrevious()
    End Sub

    Private Sub btn_addNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addNew.Click
        TblDepartmentBindingSource.AddNew()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        TblDepartmentBindingSource.MoveNext()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        On Error GoTo SaveErr
        TblDepartmentBindingSource.EndEdit()
        Tbl_DepartmentTableAdapter.Update(TrainingDataSet.tbl_Department)
        MessageBox.Show("Ok Boss")
SaveErr:
        Exit Sub
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        TblDepartmentBindingSource.RemoveCurrent()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class
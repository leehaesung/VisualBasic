Public Class student

    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TrainingDataSet.tbl_student' table. You can move, or remove it, as needed.
        Me.Tbl_studentTableAdapter.Fill(Me.TrainingDataSet.tbl_student)

    End Sub

    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        TblstudentBindingSource.MovePrevious()
    End Sub

    Private Sub btn_addNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addNew.Click
        TblstudentBindingSource.AddNew()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        TblstudentBindingSource.MoveNext()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        On Error GoTo SaveErr
        TblstudentBindingSource.EndEdit()
        Tbl_studentTableAdapter.Update(TrainingDataSet.tbl_student)
        MessageBox.Show("Ok Boss")
SaveErr:
        Exit Sub
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        TblstudentBindingSource.RemoveCurrent()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class
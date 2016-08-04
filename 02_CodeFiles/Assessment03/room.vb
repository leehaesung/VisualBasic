Public Class room

    Private Sub room_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TrainingDataSet.tbl_Room' table. You can move, or remove it, as needed.
        Me.Tbl_RoomTableAdapter.Fill(Me.TrainingDataSet.tbl_Room)

    End Sub

    Private Sub btn_previous_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_previous.Click
        TblRoomBindingSource.MovePrevious()
    End Sub

    Private Sub btn_addNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_addNew.Click
        TblRoomBindingSource.AddNew()
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        TblRoomBindingSource.MoveNext()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        On Error GoTo SaveErr
        TblRoomBindingSource.EndEdit()
        Tbl_RoomTableAdapter.Update(TrainingDataSet.tbl_Room)
        MessageBox.Show("Ok Boss")
SaveErr:
        Exit Sub
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        TblRoomBindingSource.RemoveCurrent()
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class
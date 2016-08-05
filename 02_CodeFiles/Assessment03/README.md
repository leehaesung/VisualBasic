# Assessment III

* STUDENT NAME:	Haesung Lee
* STUDENT NO:	  S078887
* SUBJECT NO:	  M05
* This version was coded by Microsoft Visual Basic 2010 Express with MS Office Access 2007.


## Task-0: Data Table For DB (Ms Office Access 2007)
## Designing The Data Tables For Training Database System:

# Student Table

![01_tbl_student_DB.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/01_tbl_student_DB.png)




## Task-1: Build GUI Design applications 
## Designing Constraint:


![05_menu.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/05_menu.png)
* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment01/lgoin.vb#L8`

````````````````````````````````````````
Public Class menu1
    Private Sub StudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentToolStripMenuItem.Click
        student.Visible = True
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        department.Visible = True
    End Sub

    Private Sub CourseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CourseToolStripMenuItem.Click
        courseInformation.Visible = True
    End Sub

    Private Sub RoomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RoomToolStripMenuItem.Click
        room.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox(" achasma@gamil.com ")
    End Sub
End Class
````````````````````````````````````````

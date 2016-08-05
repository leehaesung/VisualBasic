# Assessment III

* STUDENT NAME:	Haesung Lee
* STUDENT NO:	  S078887
* SUBJECT NO:	  M05
* This version was coded by Microsoft Visual Basic 2010 Express with MS Office Access 2007.


## Task-0: Data Table For DB 
## Designing The Data Tables For Training Database System:
* We need to create a Database name Training Database System in Ms Access 2007 and a Graphical user interface windows form application using Visual Basic 2010.
* Our trainer will be made the contents of Database.
* For all of the below form users are required to insert minimum five data values the in the tables of the database via a form.


### 0-1 Student Table

![01_tbl_student_DB.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/01_tbl_student_DB.png)


### 0-2 Course Information Table

![02_tbl_Course_information_DB.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/02_tbl_Course_information_DB.png)


### 0-3 Department Table

![03_tbl_Department_DB.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/03_tbl_Department_DB.png)


### 0-4 Room Table
![04_tbl_Room_DB.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/04_tbl_Room_DB.png)



## Task-1: Build GUI Design applications 
## Designing Constraint:

* The design of the Main Form will look as below. In the application, you are required to put the main Menu items for Training Information System Form (Student, Department, Course, Room.)

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


## Task 2: Create GUI  Application
## Operational Constraint:

### 2-01 

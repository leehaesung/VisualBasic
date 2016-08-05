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
* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/menu1.vb`

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

### 2-01 Student DB

![06_student.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/06_student.png)

* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/student.vb`

````````````````````````````````````````
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
````````````````````````````````````````


### 2-02 Department DB

![07_department.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/07_department.png)

* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/department.vb`

````````````````````````````````````````
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
````````````````````````````````````````


### 2-03 Course Information DB

![08_Course_information.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/08_Course_information.png)

* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/courseInformation.vb`

````````````````````````````````````````
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

````````````````````````````````````````


### 2-04 Room DB

![09_room.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/09_room.png)

* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/room.vb`

````````````````````````````````````````
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
````````````````````````````````````````



## Task 3 Debugging of GUI: 
### Debugging
![10_Debug.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment03/OutputImageFiles/10_Debug.png)



## Task 4 Test GUI Application:
### 4-1 Testing the Menu
````````````````````````````````````````
[Test Plan Template]
-----------------------------------------------------------------------------------------------------------------------
Test case id	Test case Description                   Expected result                        Actual result
-----------------------------------------------------------------------------------------------------------------------
 001             Clicking Student        	             Would be good                          OK
 002	         Clicking Department    	             Would be OK	                        OK       
 003			 Clicking Course                         Would be good                          Very Good
 004             Clicking Room                           Woudl be good                          Very Good
 005             Pressing Email Me's Button              Would be linked                        Very Good
-----------------------------------------------------------------------------------------------------------------------
````````````````````````````````````````

### 4-2 Testing the Student DB
````````````````````````````````````````
[Test Plan Template]
-----------------------------------------------------------------------------------------------------------------------
Test case id	Test case Description                   Expected result                        Actual result
-----------------------------------------------------------------------------------------------------------------------
 001	         Pressing Add New                        Could be very good                     Very Good		
 002			 Putting Data                            Could be very good                     Very Good
 003	         Saving Data                             Would be good                          Very Good
 004             Deleting Data                           Would be good                          Good
 005             Exting the program                      Would be very good                     Good
-----------------------------------------------------------------------------------------------------------------------
````````````````````````````````````````

### 4-3 Testing the Department DB
````````````````````````````````````````
[Test Plan Template]
-----------------------------------------------------------------------------------------------------------------------
Test case id	Test case Description                   Expected result                        Actual result
-----------------------------------------------------------------------------------------------------------------------
 001	         Pressing Add New                        Could be very good                     Very Good		
 002			 Putting Data                            Could be very good                     Very Good
 003	         Saving Data                             Would be good                          Very Good
 004             Deleting Data                           Would be good                          Good
 005             Exting the program                      Would be good                          Very Good
-----------------------------------------------------------------------------------------------------------------------
````````````````````````````````````````

### 4-4 Testing the Course Information DB
````````````````````````````````````````
[Test Plan Template]
-----------------------------------------------------------------------------------------------------------------------
Test case id	Test case Description                   Expected result                        Actual result
-----------------------------------------------------------------------------------------------------------------------
 001	         Pressing Add New                        Could be very good                     Very Good		
 002			 Putting Data                            Could be very good                     Very Good
 003	         Saving Data                             Would be good                          Very Good
 004             Deleting Data                           Would be good                          Good
 005             Exting the program                      Would be good                          Very Good
-----------------------------------------------------------------------------------------------------------------------
````````````````````````````````````````

### 4-5 Testing the Room DB
````````````````````````````````````````
[Test Plan Template]
-----------------------------------------------------------------------------------------------------------------------
Test case id	Test case Description                   Expected result                        Actual result
-----------------------------------------------------------------------------------------------------------------------
 001	         Pressing Add New                        Could be very good                     Very Good		
 002			 Putting Data                            Could be very good                     Very Good
 003	         Saving Data                             Would be good                          Very Good
 004             Deleting Data                           Would be good                          Very Good
 005             Exting the program                      Would be good                          Well dong
-----------------------------------------------------------------------------------------------------------------------
````````````````````````````````````````



< END >

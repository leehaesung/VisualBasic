# Assessment II

* STUDENT NAME:	Haesung Lee
* STUDENT NO:	  S078887
* SUBJECT NO:	  M05
* This version was coded by Microsoft Visual Basic 2010 Express.

## Task-1: Build GUI Design applications 
## Designing Constraint:


![01_student_array.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment02/OutputImageFiles/01_student_array.png)
* Source Code: `https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment02/Form1.vb`

````````````````````````````````````````
Public Class Form1
    Dim Stu_mark(0 To 9) As Double               ' Array data: 10 variabls (0 to 9)
    Private Sub btn_fill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fill.Click
        Dim Prompt, Title As String
        Dim i As Integer
        Prompt = "Enter the Student Marks."
        For i = 0 To UBound(Stu_mark)            ' UBound means 0 to 9 
            Title = "Student  " & (i + 1)
            Stu_mark(i) = InputBox(Prompt, Title)
            ProgressBar1.Value = i
        Next                                  ' 1st student finshs and the next students '
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = UBound(Stu_mark)
        Label1.Text = UBound(Stu_mark) + 1   ' students' number display
    End Sub

    Private Sub btn_display_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_display.Click
        Dim Result As String
        Dim i As Short
        Dim Total As Single = 0
        Result = "The ten student marks, whch is been Entered in Array's are as follows:" & vbCrLf & vbCrLf
        For i = 0 To UBound(Stu_mark)
            Result = Result & "Student  " & (i + 1) & "  " & Stu_mark(i) & vbCrLf  ' vbTab = " "
            Total = Total + Stu_mark(i)
            ProgressBar1.Value = i
        Next
        Result = Result & vbCrLf & _
        "Average Marks: " & Format(Total / 10, "0.0")
        txt_marks.Text = Result
    End Sub

    Private Sub btn_sort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sort.Click
        Dim Result As String
        Dim i As Short
        Dim Total As Single = 0
        Array.Sort(Stu_mark)
        Result = "The ten student marks, whch is been Entered in Array's are as follows:" & vbCrLf & vbCrLf
        For i = 0 To UBound(Stu_mark)
            Result = Result & "Student  " & (i + 1) & "  " & Stu_mark(i) & vbCrLf
            Total = Total + Stu_mark(i)
            ProgressBar1.Value = i
        Next
        Result = Result & vbCrLf & _
        "Average Marks: " & Format(Total / 10, "0.0")
        txt_marks.Text = Result

    End Sub

    Private Sub btn_reverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reverse.Click
        Dim Result As String
        Dim i As Short
        Dim Total As Single = 0
        Array.Reverse(Stu_mark)
        Result = "The ten student marks, whch is been Entered in Array's are as follows:" & vbCrLf & vbCrLf
        For i = 0 To UBound(Stu_mark)
            Result = Result & "Student  " & (i + 1) & "  " & Stu_mark(i) & vbCrLf
            Total = Total + Stu_mark(i)
            ProgressBar1.Value = i
        Next
        Result = Result & vbCrLf & _
        "Average Marks: " & Format(Total / 10, "0.0")
        txt_marks.Text = Result
    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        txt_marks.Clear()  'clear all inside 
    End Sub
End Clas
````````````````````````````````````````

* If the user clicks on the “Fill Student marks” button, It should prompt you via an input box to enter marks of 10 students sequentially as below:

![02_Fill_Student_marks.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment02/OutputImageFiles/02_Fill_Student_marks.png)


* If the user clicks on “Display Student Marks” button, the 10 students’ marks should be displayed in the text box & Evaluations time user can see in progress bar Like Below:

![03_Display_Student_Marks.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment02/OutputImageFiles/03_Display_Student_Marks.png)


* If the user clicks on “Sort Student Marks,” it should display the 10 student marks in the following way and at evaluation time user can see in progress bar:

![04_Sort_Student_Marks.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment02/OutputImageFiles/04_Sort_Student_Marks.png)


* If the user clicks on the “Reverse Student Marks” button, the students’ marks in the Textbox should be displayed in the reverse way and at evaluation time the user can see the progress bar as below:

![05_Reverse_Student_Marks.png](https://github.com/leehaesung/VisualBasic/blob/master/02_CodeFiles/Assessment02/OutputImageFiles/05_Reverse_Student_Marks.png)





﻿Public Class Form1
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
End Class


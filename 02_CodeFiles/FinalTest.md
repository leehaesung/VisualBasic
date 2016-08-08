# Final Test

***

### 1. What are different types of Events available in Visual basic programming language? Write any 5 names of events.



### 2. Define Timer Control. What are the two main properties of the Timer Control. What values should those properties be assigned?



### 3. What is the difference between Input box and Msgbox commands?



### 4. What are the three types of errors that can occur in a Visual Basic program? Define each in detail with examples.



### 5. What do you understand by static array declaration and dynamic array declaration. Which command is used to resize the fixed array dimension? Give an example.




### 6. How are arrays declared in Visual Basic?
Type the code to declare a two dimensional array with 5 rows and 9 columns in memory




### 7. Define each line of code
````````````````````````````````````````````````````````````
Public Class frm_swithcase
    Dim age As Integer
    
    Private Sub btn_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_test.Click

        age = txt_age.Text
        Select Case age
            Case Is < 13
                txt_output.Text = "Enjoy your Youth"
            Case 13 To 19
                txt_output.Text = "Enjoy your teens"
            Case 20 To 45
                txt_output.Text = "you can enjoy wine with your meal"
            Case Is < 100
                txt_output.Text = "you dont need my suggestion"
            Case Else
                txt_output.Text = "That's a nice age to be"
        End Select
    End Sub
 End Class
````````````````````````````````````````````````````````````

### 8. Match the Following System Clock properties and
function?




### 9. Visual Basic recognizes the following four
categories of variables

Select one or more:
``````````````````````````
a. String
b. Date
c. Boolean
d. Structure
e. Numeric
f. Class
g. Object
``````````````````````````


### 10. The correct way to declare a variable in Visual basic is

Choose from the following
````````````````````````````````````````````````````
Select one or more:
a. Dim Qty As Integer, Amount As Decimal, CardNum As String
b. Dim Length, Width, Height As Integer, Volume, Area As Double
c. None of The above
d. Dim meters As Integer
   Dim greetings As String
````````````````````````````````````````````````````



### 11. To execute a block of statements while a condition is True, use the following
syntax:
 
`````````````````````````````````````````````````
  Do Until condition

         ‘Statement-block

           Loop
`````````````````````````````````````````````````
       
Select one:
```````````````````
()True
()False
```````````````````


### 12. To execute a block of statements until the condition becomes True, use the
following syntax:

`````````````````````````````````````````````````
Do while condition


         ‘Statement-block

            Loop

`````````````````````````````````````````````````      

Select one:
``````````````````
()True
()False 
``````````````````

< END >


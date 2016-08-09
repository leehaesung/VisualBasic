# Final Test

***

### 1. What are different types of Events available in Visual basic programming language? Write any 5 names of events.
````````````````````````````````````````````````````````````
We can group events into different categories. Perhaps the most obvious group of events is the mouse group.
The Click and DoubleClick mouse events are obvious.
- Click : Called in response to a single click
- DoubleClick : Called in response to a double click

The Mouse - Down/Up/Move events are called every time the user presses or releases any button or just moves the mouse.
- MouseDown : Called when any mouse button is pressed down
- MouseUp : Called when any mouse button is released
- MouseMove :Called every time the mouse moves
````````````````````````````````````````````````````````````

### 2. Define Timer Control. What are the two main properties of the Timer Control. What values should those properties be assigned?
````````````````````````````````````````````````````````````
- Definition: The Timer control allows you to set a time interval to execute an event after that interval continuously. It is useful when you want to execute certain applications after a certain interval. Say you want to create a backup of your data processing in every hour. You can make a routine which will take the backup and call that routine on Timer's event and set timer interval for an hour.

- Two main properties  
  1. Interval Property
  2. Enabled Property 
  
- Assigned values of Interval & Enabled property
For example, if we want to set an interval of two minute we set the value at Interval property as 120000, means 120x1000 .

The Timer Control starts its functioning only after its Enabled property is set to True, by default Enabled property is False.
````````````````````````````````````````````````````````````


### 3. What is the difference between Input box and Msgbox commands?
````````````````````````````````````````````````````````````
Message box shows the infomation/warning to the user but 
input box required user to enter the input to proceed 
further.
````````````````````````````````````````````````````````````


### 4. What are the three types of errors that can occur in a Visual Basic program? Define each in detail with examples.
````````````````````````````````````````````````````````````
In Visual Basic, tere are three categories: syntax errors, run-time errors, and logic errors.
- Syntax errors are those that appear while you write code. Visual Basic checks your code as you type it in the Code Editor window and alerts you if you make a mistake, such as misspelling a word or using a language element improperly. Syntax errors are the most common type of errors. You can fix them easily in the coding environment as soon as they occur.

- Run-time errors are those that appear only after you compile and run your code. These involve code that may appear to be correct in that it has no syntax errors, but that will not execute. For example, you might correctly write a line of code to open a file. But if the file is corrupted, the application cannot carry out the Open function, and it stops running. You can fix most run-time errors by rewriting the faulty code, and then recompiling and rerunning it.

- Logic errors are those that appear once the application is in use. They are most often unwanted or unexpected results in response to user actions. For example, a mistyped key or other outside influence might cause your application to stop working within expected parameters, or altogether. Logic errors are generally the hardest type to fix, since it is not always clear where they originate.

````````````````````````````````````````````````````````````


### 5. What do you understand by static array declaration and dynamic array declaration. Which command is used to resize the fixed array dimension? Give an example.
````````````````````````````````````````````````````````````
A static(fixed) array is one that will not change it's size/allocation, while a dynamic array can be reallocated to grow or shrink.

For example,
As for VB, we can create a static(fixed) array like this:

   Dim arrayname(10) As Integer    ' static array declaration

To declare a dynamic Array,      

   Dim arrayname() As Integer      ' dynamic array declaration

````````````````````````````````````````````````````````````



### 6. How are arrays declared in Visual Basic?
Type the code to declare a two dimensional array with 5 rows and 9 columns in memory
````````````````````````````````````````````````````````````
We can declare a 2-dimensional array of strings as:

   Dim twoDStringArray(10, 20) As String    ' 2 dimennsional array

Module arrayApl
   Sub Main()
    .....
    .....
      For i = 0 To 4               ' 5 rows
          For j = 0 To 8           ' 9 columns
    .....
    .....
      Next i
    .....
   End Sub
End Module

````````````````````````````````````````````````````````````



### 7. Define each line of code
````````````````````````````````````````````````````````````
Public Class frm_swithcase           ' Declaration of the class
    Dim age As Integer               ' Variable of age as Integer
    
    Private Sub btn_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_test.Click
       ' Button's function as system object
       
        age = txt_age.Text           ' Input of age as text      
        
        Select Case age              ' Switch as Select Case
            Case Is < 13             ' If Is is smaller than 13, It will display "Enjoy your teens". 
                txt_output.Text = "Enjoy your Youth"
                
            Case 13 To 19            ' If it includes from 13 to 19, It will display "Enjoy your teens".
                txt_output.Text = "Enjoy your teens"
                
            Case 20 To 45       ' If it includes between 20 and 45, this will present "you can enjoy wine with your meal"
                txt_output.Text = "you can enjoy wine with your meal"
                
            Case Is < 100             ' If Is is smaller than  100, this will display "you dont need my suggestion"
                txt_output.Text = "you dont need my suggestion"
                
            Case Else                 ' Another case, this will disply "Thant's a nice age to be"
                txt_output.Text = "That's a nice age to be"
                
        End Select                    ' The Select case finished
    End Sub                           ' The function object finished
 End Class                            ' The class finished
````````````````````````````````````````````````````````````

### 8. Match the Following System Clock properties and
function?




### 9. Visual Basic recognizes the following four
categories of variables

Select one or more:
``````````````````````````
() a. String
() b. Date
() c. Boolean
() d. Structure
() e. Numeric
() f. Class
() g. Object
``````````````````````````


### 10. The correct way to declare a variable in Visual basic is

Choose from the following
````````````````````````````````````````````````````
Select one or more:
() a. Dim Qty As Integer, Amount As Decimal, CardNum As String
() b. Dim Length, Width, Height As Integer, Volume, Area As Double
() c. None of The above
() d. Dim meters As Integer
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


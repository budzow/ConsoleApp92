' This VBScript demonstrates a function to calculate the sum of the first n positive integers.
' The script includes extensive comments for clarity and documentation.
' VBScript does not support classes, so the function is defined globally.
' The function is called SumFirstN and takes a single argument n.
' It returns the sum of the first n positive integers.
' If n is less than 1, the function returns 0.
' The function uses a simple loop to perform the calculation.
' The sum variable is initialized to 0 before the loop.
' Each value from 1 to n is added to the sum in the loop.
' The result is returned at the end of the function.
' This is a classic example of an iterative algorithm in VBScript.
' The function can be reused by calling it with different values of n.
' The script demonstrates basic VBScript syntax and function usage.
' VBScript does not have strong typing, so variables are declared with Dim.
' Error handling is not included for brevity.
' The function is not optimized for performance.
' For large n, a mathematical formula could be used instead.
' This implementation is for demonstration and educational purposes.
' The script outputs the result using WScript.Echo.
' To run this script, use: cscript ExampleClass.vbs [n]

Option Explicit On

' Function to calculate the sum of the first n positive integers
Function SumFirstN(n)
    ' Initialize the sum variable to 0.
    Dim sum
    sum = 0
    ' Check if n is less than 1.
    If n < 1 Then
        ' Return 0 for invalid input.
        SumFirstN = 0
        Exit Function
    End If
    ' Loop from 1 to n.
    Dim i
    For i = 1 To n
        ' Add the current value to the sum.
        sum = sum + i
    Next
    ' Return the final sum.
    SumFirstN = sum
End Function

' Main script logic
Dim n
If WScript.Arguments.Count > 0 Then
n = CInt(WScript.Arguments(0))
Else
n = 10 ' Default value if no argument is provided
End If

' Output the result
WScript.Echo "Sum of first " & n & " positive integers is: " & SumFirstN(n)
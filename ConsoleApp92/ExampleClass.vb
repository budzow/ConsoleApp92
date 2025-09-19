Imports System

''' <summary>
''' This class demonstrates a method with 10 lines of code and 20 lines of comments.
''' </summary>
Public Class ExampleClass
        ''' <summary>
        ''' Calculates the sum of the first n positive integers.
        ''' </summary>
        ''' <param name="n">The number up to which to sum.</param>
        ''' <returns>The sum of the first n positive integers.</returns>
        ''' <remarks>
        ''' This method uses a simple loop to calculate the sum.
        ''' It demonstrates basic VB.NET syntax, variable declaration,
        ''' and the use of comments for documentation and explanation.
        ''' The method checks if n is less than 1 and returns 0 in that case.
        ''' Otherwise, it iterates from 1 to n, adding each value to the sum.
        ''' The result is returned at the end.
        ''' This is a classic example of an iterative algorithm.
        ''' The method is public and can be called from other classes.
        ''' The parameter n should be a positive integer.
        ''' If n is negative or zero, the result will be 0.
        ''' The method does not throw exceptions.
        ''' The method is not optimized for performance.
        ''' For large n, consider using the formula n*(n+1)/2.
        ''' This implementation is for demonstration purposes.
        ''' </remarks>
        Public Function SumFirstN(ByVal n As Integer) As Integer
            ' Initialize the sum variable to 0.
            Dim sum As Integer = 0
            ' Check if n is less than 1.
            If n < 1 Then
                ' Return 0 for invalid input.
                Return 0
            End If
            ' Loop from 1 to n.
            For i As Integer = 1 To n
                ' Add the current value to the sum.
                sum += i
            Next
            ' Return the final sum.
            Return sum
        End Function
    End Class

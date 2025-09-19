' VB.NET version of the provided VBScript/VB6 code

Public Class Form1

    ' This subroutine displays a message box when called.
    Sub TestSub()
        MsgBox("Code in TestSub()")
    End Sub

    ' The Form Load event handler.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Heavily commented Sub
        ' Heavily commented Sub
        ' Heavily commented Sub
        ' Heavily commented Sub
        ' Heavily commented Sub
        ' Heavily commented Sub
        ' Heavily commented Sub
        MsgBox("Code in Form_Load()")
        TestSub()
        MsgBox("Back in Form_Load()")
    End Sub

End Class
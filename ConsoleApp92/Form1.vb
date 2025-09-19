Public Class Form1

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
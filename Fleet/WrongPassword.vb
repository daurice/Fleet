Public Class WrongPassword

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CloseForms()
        UserAccount.MdiParent = Fleet_main
        UserAccount.Show()
    End Sub
    Private Sub CloseForms()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
End Class
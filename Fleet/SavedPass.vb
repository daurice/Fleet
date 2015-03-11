Public Class SavedPass

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UserAccount.MdiParent = Fleet_main
        UserAccount.Show()
        Me.Close()
    End Sub

End Class
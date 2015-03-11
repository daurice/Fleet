Public Class UserAccount

    Private Sub User_accountBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.User_accountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fleet_databaseDataSet)

    End Sub

    Private Sub UserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.user_account' table. You can move, or remove it, as needed.
        Me.User_accountTableAdapter.Fill(Me.Fleet_databaseDataSet.user_account)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Confirmation.MdiParent = Fleet_main


        Confirmation.Show()
        Me.Close()

    End Sub
End Class
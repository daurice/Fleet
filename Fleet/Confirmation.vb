Public Class Confirmation

    Private Sub User_accountBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.User_accountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fleet_databaseDataSet)

    End Sub

    Private Sub Confirmation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.user_account' table. You can move, or remove it, as needed.
        Me.User_accountTableAdapter.Fill(Me.Fleet_databaseDataSet.user_account)
        UsernameTextBox.Visible = False
        PasswordTextBox.Visible = False
        UsernameLabel.visible = False
        PasswordLabel.Visible = False
        cmdSave.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = PasswordTextBox.Text Then

            UsernameTextBox.Visible = True
            PasswordTextBox.Visible = True
            UsernameLabel.Visible = True
            PasswordLabel.Visible = True
            cmdSave.Visible = True

            Label1.Visible = False
            TextBox1.Visible = False
            Button1.Visible = False
        Else
            CloseForms()
            WrongPassword.MdiParent = Fleet_main
            WrongPassword.Show()
        End If
    End Sub
    Private Sub CloseForms()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
       
        Me.User_accountTableAdapter.Update(me.Fleet_databaseDataSet)
        SavedPass.MdiParent = Fleet_main
        SavedPass.Show()
        Me.Close()


    End Sub
End Class
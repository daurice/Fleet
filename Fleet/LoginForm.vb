Public Class LoginForm


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = UsernameTextBox1.Text And PasswordTextBox.Text = PasswordTextBox1.Text Then
            Fleet_main.show()
            Me.Close()
        Else
            LoginWrong.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

 
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.user_account' table. You can move, or remove it, as needed.
        Me.User_accountTableAdapter.Fill(Me.Fleet_databaseDataSet.user_account)
        UsernameTextBox1.Visible = False
        PasswordTextBox1.Visible = False
    End Sub
End Class

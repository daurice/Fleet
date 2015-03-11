Public Class Company

    Private Sub Company_detailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Company_detailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fleet_databaseDataSet)

    End Sub

    Private Sub Company_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.company_details' table. You can move, or remove it, as needed.
        Me.Company_detailsTableAdapter.Fill(Me.Fleet_databaseDataSet.company_details)

    End Sub
End Class
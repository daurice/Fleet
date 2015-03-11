Public Class ManagementDetails

    Private Sub Management_detailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Management_detailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fleet_databaseDataSet)

    End Sub

    Private Sub ManagementDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.management_details' table. You can move, or remove it, as needed.
        Me.Management_detailsTableAdapter.Fill(Me.Fleet_databaseDataSet.management_details)

    End Sub
End Class
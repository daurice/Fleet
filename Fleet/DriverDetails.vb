Public Class DriverDetails

    Private Sub Drivers_detailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Drivers_detailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fleet_databaseDataSet)

    End Sub

    Private Sub DriverDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.drivers_details' table. You can move, or remove it, as needed.
        Me.Drivers_detailsTableAdapter.Fill(Me.Fleet_databaseDataSet.drivers_details)

    End Sub
End Class
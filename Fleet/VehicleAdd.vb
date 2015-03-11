Public Class VehicleAdd

    Private Sub BusDetailsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BusDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fleet_databaseDataSet)

    End Sub

    Private Sub VehicleAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.BusDetails' table. You can move, or remove it, as needed.
        Me.BusDetailsTableAdapter.Fill(Me.Fleet_databaseDataSet.BusDetails)

    End Sub
End Class
Public Class VehicleSearch

    Private Sub BusOnwersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BusOnwersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fleet_databaseDataSet)

    End Sub

    Private Sub VehicleSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.BusOnwers' table. You can move, or remove it, as needed.
        Me.BusOnwersTableAdapter.Fill(Me.Fleet_databaseDataSet.BusOnwers)

    End Sub
End Class
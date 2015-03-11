Public Class SellTickets

    Private Sub TicketSellingBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TicketSellingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fleet_databaseDataSet)

    End Sub

    Private Sub SellTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.TicketSelling' table. You can move, or remove it, as needed.
        Me.TicketSellingTableAdapter.Fill(Me.Fleet_databaseDataSet.TicketSelling)

    End Sub
End Class
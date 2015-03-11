Public Class BusOnwers

    Private Sub BusOnwersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.BusOnwersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Fleet_databaseDataSet)

    End Sub

    Private Sub BusOnwers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Fleet_databaseDataSet.BusOnwers' table. You can move, or remove it, as needed.
        Me.BusOnwersTableAdapter.Fill(Me.Fleet_databaseDataSet.BusOnwers)

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Me.BusOnwersBindingSource.RemoveCurrent()

        RecordDelete.MdiParent = Fleet_main
        RecordDelete.Show()

    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click


        Me.BusOnwersBindingSource.MoveNext()

    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        Me.BusOnwersBindingSource.MovePrevious()


    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.BusOnwersTableAdapter.Update(me.Fleet_databaseDataSet)
        RecordSaved.MdiParent = Fleet_main
        RecordSaved.Show()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Me.BusOnwersBindingSource.AddNew()
    End Sub

   
End Class
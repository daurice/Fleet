<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.Fleet_databaseDataSet = New Fleet.fleet_databaseDataSet
        Me.BusOnwersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusOnwersTableAdapter = New Fleet.fleet_databaseDataSetTableAdapters.BusOnwersTableAdapter
        Me.TableAdapterManager = New Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
        Me.BusOnwersDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusOnwersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusOnwersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fleet_databaseDataSet
        '
        Me.Fleet_databaseDataSet.DataSetName = "fleet_databaseDataSet"
        Me.Fleet_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusOnwersBindingSource
        '
        Me.BusOnwersBindingSource.DataMember = "BusOnwers"
        Me.BusOnwersBindingSource.DataSource = Me.Fleet_databaseDataSet
        '
        'BusOnwersTableAdapter
        '
        Me.BusOnwersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BusDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BusOnwersTableAdapter = Me.BusOnwersTableAdapter
        Me.TableAdapterManager.company_detailsTableAdapter = Nothing
        Me.TableAdapterManager.drivers_detailsTableAdapter = Nothing
        Me.TableAdapterManager.management_detailsTableAdapter = Nothing
        Me.TableAdapterManager.TicketSellingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_accountTableAdapter = Nothing
        '
        'BusOnwersDataGridView
        '
        Me.BusOnwersDataGridView.AutoGenerateColumns = False
        Me.BusOnwersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BusOnwersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.BusOnwersDataGridView.DataSource = Me.BusOnwersBindingSource
        Me.BusOnwersDataGridView.Location = New System.Drawing.Point(12, 135)
        Me.BusOnwersDataGridView.Name = "BusOnwersDataGridView"
        Me.BusOnwersDataGridView.Size = New System.Drawing.Size(940, 291)
        Me.BusOnwersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OnwerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "OnwerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OnwerName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "OnwerName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "PostalAddress"
        Me.DataGridViewTextBoxColumn3.HeaderText = "PostalAddress"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PostalCode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PostalCode"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn5.HeaderText = "City"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Mobile"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Mobile"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(43, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle Search"
        '
        'VehicleSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BusOnwersDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VehicleSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Vehicle"
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusOnwersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusOnwersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Fleet_databaseDataSet As Fleet.fleet_databaseDataSet
    Friend WithEvents BusOnwersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BusOnwersTableAdapter As Fleet.fleet_databaseDataSetTableAdapters.BusOnwersTableAdapter
    Friend WithEvents TableAdapterManager As Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BusOnwersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class

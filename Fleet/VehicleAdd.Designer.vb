<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VehicleAdd
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
        Dim BusPlateLabel As System.Windows.Forms.Label
        Dim CapacityLabel As System.Windows.Forms.Label
        Dim DriverLabel As System.Windows.Forms.Label
        Dim Co_DriverLabel As System.Windows.Forms.Label
        Dim RouteLabel As System.Windows.Forms.Label
        Dim OnwerIDLabel As System.Windows.Forms.Label
        Me.Fleet_databaseDataSet = New Fleet.fleet_databaseDataSet
        Me.BusDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusDetailsTableAdapter = New Fleet.fleet_databaseDataSetTableAdapters.BusDetailsTableAdapter
        Me.TableAdapterManager = New Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
        Me.BusPlateTextBox = New System.Windows.Forms.TextBox
        Me.CapacityTextBox = New System.Windows.Forms.TextBox
        Me.DriverTextBox = New System.Windows.Forms.TextBox
        Me.Co_DriverTextBox = New System.Windows.Forms.TextBox
        Me.RouteTextBox = New System.Windows.Forms.TextBox
        Me.OnwerIDTextBox = New System.Windows.Forms.TextBox
        BusPlateLabel = New System.Windows.Forms.Label
        CapacityLabel = New System.Windows.Forms.Label
        DriverLabel = New System.Windows.Forms.Label
        Co_DriverLabel = New System.Windows.Forms.Label
        RouteLabel = New System.Windows.Forms.Label
        OnwerIDLabel = New System.Windows.Forms.Label
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fleet_databaseDataSet
        '
        Me.Fleet_databaseDataSet.DataSetName = "fleet_databaseDataSet"
        Me.Fleet_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BusDetailsBindingSource
        '
        Me.BusDetailsBindingSource.DataMember = "BusDetails"
        Me.BusDetailsBindingSource.DataSource = Me.Fleet_databaseDataSet
        '
        'BusDetailsTableAdapter
        '
        Me.BusDetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BusDetailsTableAdapter = Me.BusDetailsTableAdapter
        Me.TableAdapterManager.BusOnwersTableAdapter = Nothing
        Me.TableAdapterManager.company_detailsTableAdapter = Nothing
        Me.TableAdapterManager.drivers_detailsTableAdapter = Nothing
        Me.TableAdapterManager.management_detailsTableAdapter = Nothing
        Me.TableAdapterManager.TicketSellingTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_accountTableAdapter = Nothing
        '
        'BusPlateLabel
        '
        BusPlateLabel.AutoSize = True
        BusPlateLabel.Location = New System.Drawing.Point(13, 9)
        BusPlateLabel.Name = "BusPlateLabel"
        BusPlateLabel.Size = New System.Drawing.Size(55, 13)
        BusPlateLabel.TabIndex = 1
        BusPlateLabel.Text = "Bus Plate:"
        '
        'BusPlateTextBox
        '
        Me.BusPlateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusDetailsBindingSource, "BusPlate", True))
        Me.BusPlateTextBox.Location = New System.Drawing.Point(74, 6)
        Me.BusPlateTextBox.Name = "BusPlateTextBox"
        Me.BusPlateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BusPlateTextBox.TabIndex = 2
        '
        'CapacityLabel
        '
        CapacityLabel.AutoSize = True
        CapacityLabel.Location = New System.Drawing.Point(13, 35)
        CapacityLabel.Name = "CapacityLabel"
        CapacityLabel.Size = New System.Drawing.Size(51, 13)
        CapacityLabel.TabIndex = 3
        CapacityLabel.Text = "Capacity:"
        '
        'CapacityTextBox
        '
        Me.CapacityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusDetailsBindingSource, "Capacity", True))
        Me.CapacityTextBox.Location = New System.Drawing.Point(74, 32)
        Me.CapacityTextBox.Name = "CapacityTextBox"
        Me.CapacityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CapacityTextBox.TabIndex = 4
        '
        'DriverLabel
        '
        DriverLabel.AutoSize = True
        DriverLabel.Location = New System.Drawing.Point(13, 61)
        DriverLabel.Name = "DriverLabel"
        DriverLabel.Size = New System.Drawing.Size(38, 13)
        DriverLabel.TabIndex = 5
        DriverLabel.Text = "Driver:"
        '
        'DriverTextBox
        '
        Me.DriverTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusDetailsBindingSource, "Driver", True))
        Me.DriverTextBox.Location = New System.Drawing.Point(74, 58)
        Me.DriverTextBox.Name = "DriverTextBox"
        Me.DriverTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DriverTextBox.TabIndex = 6
        '
        'Co_DriverLabel
        '
        Co_DriverLabel.AutoSize = True
        Co_DriverLabel.Location = New System.Drawing.Point(13, 87)
        Co_DriverLabel.Name = "Co_DriverLabel"
        Co_DriverLabel.Size = New System.Drawing.Size(54, 13)
        Co_DriverLabel.TabIndex = 7
        Co_DriverLabel.Text = "Co-Driver:"
        '
        'Co_DriverTextBox
        '
        Me.Co_DriverTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusDetailsBindingSource, "Co-Driver", True))
        Me.Co_DriverTextBox.Location = New System.Drawing.Point(74, 84)
        Me.Co_DriverTextBox.Name = "Co_DriverTextBox"
        Me.Co_DriverTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Co_DriverTextBox.TabIndex = 8
        '
        'RouteLabel
        '
        RouteLabel.AutoSize = True
        RouteLabel.Location = New System.Drawing.Point(13, 113)
        RouteLabel.Name = "RouteLabel"
        RouteLabel.Size = New System.Drawing.Size(39, 13)
        RouteLabel.TabIndex = 9
        RouteLabel.Text = "Route:"
        '
        'RouteTextBox
        '
        Me.RouteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusDetailsBindingSource, "Route", True))
        Me.RouteTextBox.Location = New System.Drawing.Point(74, 110)
        Me.RouteTextBox.Name = "RouteTextBox"
        Me.RouteTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RouteTextBox.TabIndex = 10
        '
        'OnwerIDLabel
        '
        OnwerIDLabel.AutoSize = True
        OnwerIDLabel.Location = New System.Drawing.Point(13, 139)
        OnwerIDLabel.Name = "OnwerIDLabel"
        OnwerIDLabel.Size = New System.Drawing.Size(55, 13)
        OnwerIDLabel.TabIndex = 11
        OnwerIDLabel.Text = "Onwer ID:"
        '
        'OnwerIDTextBox
        '
        Me.OnwerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusDetailsBindingSource, "OnwerID", True))
        Me.OnwerIDTextBox.Location = New System.Drawing.Point(74, 136)
        Me.OnwerIDTextBox.Name = "OnwerIDTextBox"
        Me.OnwerIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OnwerIDTextBox.TabIndex = 12
        '
        'VehicleAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 171)
        Me.Controls.Add(BusPlateLabel)
        Me.Controls.Add(Me.BusPlateTextBox)
        Me.Controls.Add(CapacityLabel)
        Me.Controls.Add(Me.CapacityTextBox)
        Me.Controls.Add(DriverLabel)
        Me.Controls.Add(Me.DriverTextBox)
        Me.Controls.Add(Co_DriverLabel)
        Me.Controls.Add(Me.Co_DriverTextBox)
        Me.Controls.Add(RouteLabel)
        Me.Controls.Add(Me.RouteTextBox)
        Me.Controls.Add(OnwerIDLabel)
        Me.Controls.Add(Me.OnwerIDTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VehicleAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Vehicle"
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fleet_databaseDataSet As Fleet.fleet_databaseDataSet
    Friend WithEvents BusDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BusDetailsTableAdapter As Fleet.fleet_databaseDataSetTableAdapters.BusDetailsTableAdapter
    Friend WithEvents TableAdapterManager As Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BusPlateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CapacityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DriverTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Co_DriverTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RouteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OnwerIDTextBox As System.Windows.Forms.TextBox
End Class

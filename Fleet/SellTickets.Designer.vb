<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellTickets
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
        Dim TicketNumberLabel As System.Windows.Forms.Label
        Dim BusLabel As System.Windows.Forms.Label
        Dim SeatNoLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim ETDLabel As System.Windows.Forms.Label
        Dim ETALabel As System.Windows.Forms.Label
        Dim FareLabel As System.Windows.Forms.Label
        Dim FromLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim PassangerNameLabel As System.Windows.Forms.Label
        Me.Fleet_databaseDataSet = New Fleet.fleet_databaseDataSet
        Me.TicketSellingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketSellingTableAdapter = New Fleet.fleet_databaseDataSetTableAdapters.TicketSellingTableAdapter
        Me.TableAdapterManager = New Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
        Me.TicketNumberTextBox = New System.Windows.Forms.TextBox
        Me.SeatNoTextBox = New System.Windows.Forms.TextBox
        Me.DateTextBox = New System.Windows.Forms.TextBox
        Me.ETDTextBox = New System.Windows.Forms.TextBox
        Me.ETATextBox = New System.Windows.Forms.TextBox
        Me.FareTextBox = New System.Windows.Forms.TextBox
        Me.FromTextBox = New System.Windows.Forms.TextBox
        Me.DestinationTextBox = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.MobileTextBox = New System.Windows.Forms.TextBox
        Me.PassangerNameTextBox = New System.Windows.Forms.TextBox
        Me.cmdReceipt = New System.Windows.Forms.Button
        TicketNumberLabel = New System.Windows.Forms.Label
        BusLabel = New System.Windows.Forms.Label
        SeatNoLabel = New System.Windows.Forms.Label
        DateLabel = New System.Windows.Forms.Label
        ETDLabel = New System.Windows.Forms.Label
        ETALabel = New System.Windows.Forms.Label
        FareLabel = New System.Windows.Forms.Label
        FromLabel = New System.Windows.Forms.Label
        DestinationLabel = New System.Windows.Forms.Label
        MobileLabel = New System.Windows.Forms.Label
        PassangerNameLabel = New System.Windows.Forms.Label
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketSellingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TicketNumberLabel
        '
        TicketNumberLabel.AutoSize = True
        TicketNumberLabel.Location = New System.Drawing.Point(12, 15)
        TicketNumberLabel.Name = "TicketNumberLabel"
        TicketNumberLabel.Size = New System.Drawing.Size(80, 13)
        TicketNumberLabel.TabIndex = 1
        TicketNumberLabel.Text = "Ticket Number:"
        '
        'BusLabel
        '
        BusLabel.AutoSize = True
        BusLabel.Location = New System.Drawing.Point(12, 94)
        BusLabel.Name = "BusLabel"
        BusLabel.Size = New System.Drawing.Size(28, 13)
        BusLabel.TabIndex = 5
        BusLabel.Text = "Bus:"
        '
        'SeatNoLabel
        '
        SeatNoLabel.AutoSize = True
        SeatNoLabel.Location = New System.Drawing.Point(12, 124)
        SeatNoLabel.Name = "SeatNoLabel"
        SeatNoLabel.Size = New System.Drawing.Size(49, 13)
        SeatNoLabel.TabIndex = 7
        SeatNoLabel.Text = "Seat No:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(12, 150)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(33, 13)
        DateLabel.TabIndex = 9
        DateLabel.Text = "Date:"
        '
        'ETDLabel
        '
        ETDLabel.AutoSize = True
        ETDLabel.Location = New System.Drawing.Point(12, 176)
        ETDLabel.Name = "ETDLabel"
        ETDLabel.Size = New System.Drawing.Size(32, 13)
        ETDLabel.TabIndex = 11
        ETDLabel.Text = "ETD:"
        '
        'ETALabel
        '
        ETALabel.AutoSize = True
        ETALabel.Location = New System.Drawing.Point(12, 202)
        ETALabel.Name = "ETALabel"
        ETALabel.Size = New System.Drawing.Size(31, 13)
        ETALabel.TabIndex = 13
        ETALabel.Text = "ETA:"
        '
        'FareLabel
        '
        FareLabel.AutoSize = True
        FareLabel.Location = New System.Drawing.Point(12, 228)
        FareLabel.Name = "FareLabel"
        FareLabel.Size = New System.Drawing.Size(31, 13)
        FareLabel.TabIndex = 15
        FareLabel.Text = "Fare:"
        '
        'FromLabel
        '
        FromLabel.AutoSize = True
        FromLabel.Location = New System.Drawing.Point(12, 263)
        FromLabel.Name = "FromLabel"
        FromLabel.Size = New System.Drawing.Size(33, 13)
        FromLabel.TabIndex = 17
        FromLabel.Text = "From:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(12, 289)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(63, 13)
        DestinationLabel.TabIndex = 19
        DestinationLabel.Text = "Destination:"
        '
        'Fleet_databaseDataSet
        '
        Me.Fleet_databaseDataSet.DataSetName = "fleet_databaseDataSet"
        Me.Fleet_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketSellingBindingSource
        '
        Me.TicketSellingBindingSource.DataMember = "TicketSelling"
        Me.TicketSellingBindingSource.DataSource = Me.Fleet_databaseDataSet
        '
        'TicketSellingTableAdapter
        '
        Me.TicketSellingTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BusDetailsTableAdapter = Nothing
        Me.TableAdapterManager.BusOnwersTableAdapter = Nothing
        Me.TableAdapterManager.company_detailsTableAdapter = Nothing
        Me.TableAdapterManager.drivers_detailsTableAdapter = Nothing
        Me.TableAdapterManager.management_detailsTableAdapter = Nothing
        Me.TableAdapterManager.TicketSellingTableAdapter = Me.TicketSellingTableAdapter
        Me.TableAdapterManager.UpdateOrder = Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_accountTableAdapter = Nothing
        '
        'TicketNumberTextBox
        '
        Me.TicketNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "TicketNumber", True))
        Me.TicketNumberTextBox.Location = New System.Drawing.Point(109, 12)
        Me.TicketNumberTextBox.Name = "TicketNumberTextBox"
        Me.TicketNumberTextBox.Size = New System.Drawing.Size(76, 20)
        Me.TicketNumberTextBox.TabIndex = 2
        '
        'SeatNoTextBox
        '
        Me.SeatNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "SeatNo", True))
        Me.SeatNoTextBox.Location = New System.Drawing.Point(109, 121)
        Me.SeatNoTextBox.Name = "SeatNoTextBox"
        Me.SeatNoTextBox.Size = New System.Drawing.Size(76, 20)
        Me.SeatNoTextBox.TabIndex = 8
        '
        'DateTextBox
        '
        Me.DateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "Date", True))
        Me.DateTextBox.Location = New System.Drawing.Point(109, 147)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(147, 20)
        Me.DateTextBox.TabIndex = 10
        '
        'ETDTextBox
        '
        Me.ETDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "ETD", True))
        Me.ETDTextBox.Location = New System.Drawing.Point(109, 173)
        Me.ETDTextBox.Name = "ETDTextBox"
        Me.ETDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ETDTextBox.TabIndex = 12
        '
        'ETATextBox
        '
        Me.ETATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "ETA", True))
        Me.ETATextBox.Location = New System.Drawing.Point(109, 199)
        Me.ETATextBox.Name = "ETATextBox"
        Me.ETATextBox.Size = New System.Drawing.Size(100, 20)
        Me.ETATextBox.TabIndex = 14
        '
        'FareTextBox
        '
        Me.FareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "Fare", True))
        Me.FareTextBox.Location = New System.Drawing.Point(109, 233)
        Me.FareTextBox.Name = "FareTextBox"
        Me.FareTextBox.Size = New System.Drawing.Size(76, 20)
        Me.FareTextBox.TabIndex = 16
        '
        'FromTextBox
        '
        Me.FromTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "From", True))
        Me.FromTextBox.Location = New System.Drawing.Point(109, 260)
        Me.FromTextBox.Name = "FromTextBox"
        Me.FromTextBox.Size = New System.Drawing.Size(147, 20)
        Me.FromTextBox.TabIndex = 18
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "Destination", True))
        Me.DestinationTextBox.Location = New System.Drawing.Point(109, 286)
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(147, 20)
        Me.DestinationTextBox.TabIndex = 20
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(109, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "Mobile", True))
        Me.MobileTextBox.Location = New System.Drawing.Point(109, 64)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MobileTextBox.TabIndex = 22
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Location = New System.Drawing.Point(12, 67)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(41, 13)
        MobileLabel.TabIndex = 21
        MobileLabel.Text = "Mobile:"
        '
        'PassangerNameLabel
        '
        PassangerNameLabel.AutoSize = True
        PassangerNameLabel.Location = New System.Drawing.Point(12, 41)
        PassangerNameLabel.Name = "PassangerNameLabel"
        PassangerNameLabel.Size = New System.Drawing.Size(91, 13)
        PassangerNameLabel.TabIndex = 3
        PassangerNameLabel.Text = "Passanger Name:"
        '
        'PassangerNameTextBox
        '
        Me.PassangerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketSellingBindingSource, "PassangerName", True))
        Me.PassangerNameTextBox.Location = New System.Drawing.Point(109, 38)
        Me.PassangerNameTextBox.Name = "PassangerNameTextBox"
        Me.PassangerNameTextBox.Size = New System.Drawing.Size(175, 20)
        Me.PassangerNameTextBox.TabIndex = 4
        '
        'cmdReceipt
        '
        Me.cmdReceipt.Location = New System.Drawing.Point(415, 140)
        Me.cmdReceipt.Name = "cmdReceipt"
        Me.cmdReceipt.Size = New System.Drawing.Size(75, 23)
        Me.cmdReceipt.TabIndex = 24
        Me.cmdReceipt.Text = "Print Receipt"
        Me.cmdReceipt.UseVisualStyleBackColor = True
        '
        'SellTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 326)
        Me.Controls.Add(Me.cmdReceipt)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(TicketNumberLabel)
        Me.Controls.Add(Me.TicketNumberTextBox)
        Me.Controls.Add(PassangerNameLabel)
        Me.Controls.Add(Me.PassangerNameTextBox)
        Me.Controls.Add(BusLabel)
        Me.Controls.Add(SeatNoLabel)
        Me.Controls.Add(Me.SeatNoTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(ETDLabel)
        Me.Controls.Add(Me.ETDTextBox)
        Me.Controls.Add(ETALabel)
        Me.Controls.Add(Me.ETATextBox)
        Me.Controls.Add(FareLabel)
        Me.Controls.Add(Me.FareTextBox)
        Me.Controls.Add(FromLabel)
        Me.Controls.Add(Me.FromTextBox)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Me.DestinationTextBox)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(Me.MobileTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SellTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ticket Selling"
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketSellingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fleet_databaseDataSet As Fleet.fleet_databaseDataSet
    Friend WithEvents TicketSellingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TicketSellingTableAdapter As Fleet.fleet_databaseDataSetTableAdapters.TicketSellingTableAdapter
    Friend WithEvents TableAdapterManager As Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TicketNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SeatNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ETDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ETATextBox As System.Windows.Forms.TextBox
    Friend WithEvents FareTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DestinationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PassangerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmdReceipt As System.Windows.Forms.Button
End Class

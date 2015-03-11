<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DriverDetails
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
        Dim DriverNumberLabel As System.Windows.Forms.Label
        Dim ID_NumberLabel As System.Windows.Forms.Label
        Dim License_numberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim DOBLabel As System.Windows.Forms.Label
        Dim PostalAddressLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim TownLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim DriLinIssuedateLabel As System.Windows.Forms.Label
        Dim ExperinceLabel As System.Windows.Forms.Label
        Dim PhotographLabel As System.Windows.Forms.Label
        Me.Fleet_databaseDataSet = New Fleet.fleet_databaseDataSet
        Me.Drivers_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Drivers_detailsTableAdapter = New Fleet.fleet_databaseDataSetTableAdapters.drivers_detailsTableAdapter
        Me.TableAdapterManager = New Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
        Me.DriverNumberTextBox = New System.Windows.Forms.TextBox
        Me.ID_NumberTextBox = New System.Windows.Forms.TextBox
        Me.License_numberTextBox = New System.Windows.Forms.TextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.MobileTextBox = New System.Windows.Forms.TextBox
        Me.DOBDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.PostalAddressTextBox = New System.Windows.Forms.TextBox
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox
        Me.TownTextBox = New System.Windows.Forms.TextBox
        Me.CountryTextBox = New System.Windows.Forms.TextBox
        Me.DriLinIssuedateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.ExperinceTextBox = New System.Windows.Forms.TextBox
        Me.PhotographPictureBox = New System.Windows.Forms.PictureBox
        DriverNumberLabel = New System.Windows.Forms.Label
        ID_NumberLabel = New System.Windows.Forms.Label
        License_numberLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        MobileLabel = New System.Windows.Forms.Label
        DOBLabel = New System.Windows.Forms.Label
        PostalAddressLabel = New System.Windows.Forms.Label
        PostalCodeLabel = New System.Windows.Forms.Label
        TownLabel = New System.Windows.Forms.Label
        CountryLabel = New System.Windows.Forms.Label
        DriLinIssuedateLabel = New System.Windows.Forms.Label
        ExperinceLabel = New System.Windows.Forms.Label
        PhotographLabel = New System.Windows.Forms.Label
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Drivers_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhotographPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fleet_databaseDataSet
        '
        Me.Fleet_databaseDataSet.DataSetName = "fleet_databaseDataSet"
        Me.Fleet_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Drivers_detailsBindingSource
        '
        Me.Drivers_detailsBindingSource.DataMember = "drivers_details"
        Me.Drivers_detailsBindingSource.DataSource = Me.Fleet_databaseDataSet
        '
        'Drivers_detailsTableAdapter
        '
        Me.Drivers_detailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.company_detailsTableAdapter = Nothing
        Me.TableAdapterManager.drivers_detailsTableAdapter = Me.Drivers_detailsTableAdapter
        Me.TableAdapterManager.management_detailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_accountTableAdapter = Nothing
        '
        'DriverNumberLabel
        '
        DriverNumberLabel.AutoSize = True
        DriverNumberLabel.Location = New System.Drawing.Point(23, 25)
        DriverNumberLabel.Name = "DriverNumberLabel"
        DriverNumberLabel.Size = New System.Drawing.Size(78, 13)
        DriverNumberLabel.TabIndex = 1
        DriverNumberLabel.Text = "Driver Number:"
        '
        'DriverNumberTextBox
        '
        Me.DriverNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "DriverNumber", True))
        Me.DriverNumberTextBox.Location = New System.Drawing.Point(118, 22)
        Me.DriverNumberTextBox.Name = "DriverNumberTextBox"
        Me.DriverNumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DriverNumberTextBox.TabIndex = 2
        '
        'ID_NumberLabel
        '
        ID_NumberLabel.AutoSize = True
        ID_NumberLabel.Location = New System.Drawing.Point(23, 51)
        ID_NumberLabel.Name = "ID_NumberLabel"
        ID_NumberLabel.Size = New System.Drawing.Size(61, 13)
        ID_NumberLabel.TabIndex = 3
        ID_NumberLabel.Text = "ID Number:"
        '
        'ID_NumberTextBox
        '
        Me.ID_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "ID_Number", True))
        Me.ID_NumberTextBox.Location = New System.Drawing.Point(118, 48)
        Me.ID_NumberTextBox.Name = "ID_NumberTextBox"
        Me.ID_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_NumberTextBox.TabIndex = 4
        '
        'License_numberLabel
        '
        License_numberLabel.AutoSize = True
        License_numberLabel.Location = New System.Drawing.Point(23, 77)
        License_numberLabel.Name = "License_numberLabel"
        License_numberLabel.Size = New System.Drawing.Size(85, 13)
        License_numberLabel.TabIndex = 5
        License_numberLabel.Text = "License number:"
        '
        'License_numberTextBox
        '
        Me.License_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "License_number", True))
        Me.License_numberTextBox.Location = New System.Drawing.Point(118, 74)
        Me.License_numberTextBox.Name = "License_numberTextBox"
        Me.License_numberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.License_numberTextBox.TabIndex = 6
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(23, 103)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 7
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(118, 100)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NameTextBox.TabIndex = 8
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Location = New System.Drawing.Point(23, 129)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(41, 13)
        MobileLabel.TabIndex = 9
        MobileLabel.Text = "Mobile:"
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "Mobile", True))
        Me.MobileTextBox.Location = New System.Drawing.Point(118, 126)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MobileTextBox.TabIndex = 10
        '
        'DOBLabel
        '
        DOBLabel.AutoSize = True
        DOBLabel.Location = New System.Drawing.Point(23, 156)
        DOBLabel.Name = "DOBLabel"
        DOBLabel.Size = New System.Drawing.Size(33, 13)
        DOBLabel.TabIndex = 11
        DOBLabel.Text = "DOB:"
        '
        'DOBDateTimePicker
        '
        Me.DOBDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Drivers_detailsBindingSource, "DOB", True))
        Me.DOBDateTimePicker.Location = New System.Drawing.Point(118, 152)
        Me.DOBDateTimePicker.Name = "DOBDateTimePicker"
        Me.DOBDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DOBDateTimePicker.TabIndex = 12
        '
        'PostalAddressLabel
        '
        PostalAddressLabel.AutoSize = True
        PostalAddressLabel.Location = New System.Drawing.Point(23, 181)
        PostalAddressLabel.Name = "PostalAddressLabel"
        PostalAddressLabel.Size = New System.Drawing.Size(80, 13)
        PostalAddressLabel.TabIndex = 13
        PostalAddressLabel.Text = "Postal Address:"
        '
        'PostalAddressTextBox
        '
        Me.PostalAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "PostalAddress", True))
        Me.PostalAddressTextBox.Location = New System.Drawing.Point(118, 178)
        Me.PostalAddressTextBox.Name = "PostalAddressTextBox"
        Me.PostalAddressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PostalAddressTextBox.TabIndex = 14
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(23, 207)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(67, 13)
        PostalCodeLabel.TabIndex = 15
        PostalCodeLabel.Text = "Postal Code:"
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(118, 204)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PostalCodeTextBox.TabIndex = 16
        '
        'TownLabel
        '
        TownLabel.AutoSize = True
        TownLabel.Location = New System.Drawing.Point(23, 233)
        TownLabel.Name = "TownLabel"
        TownLabel.Size = New System.Drawing.Size(37, 13)
        TownLabel.TabIndex = 17
        TownLabel.Text = "Town:"
        '
        'TownTextBox
        '
        Me.TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "Town", True))
        Me.TownTextBox.Location = New System.Drawing.Point(118, 230)
        Me.TownTextBox.Name = "TownTextBox"
        Me.TownTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TownTextBox.TabIndex = 18
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(23, 259)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(46, 13)
        CountryLabel.TabIndex = 19
        CountryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(118, 256)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CountryTextBox.TabIndex = 20
        '
        'DriLinIssuedateLabel
        '
        DriLinIssuedateLabel.AutoSize = True
        DriLinIssuedateLabel.Location = New System.Drawing.Point(23, 286)
        DriLinIssuedateLabel.Name = "DriLinIssuedateLabel"
        DriLinIssuedateLabel.Size = New System.Drawing.Size(89, 13)
        DriLinIssuedateLabel.TabIndex = 21
        DriLinIssuedateLabel.Text = "Dri Lin Issuedate:"
        '
        'DriLinIssuedateDateTimePicker
        '
        Me.DriLinIssuedateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Drivers_detailsBindingSource, "DriLinIssuedate", True))
        Me.DriLinIssuedateDateTimePicker.Location = New System.Drawing.Point(118, 282)
        Me.DriLinIssuedateDateTimePicker.Name = "DriLinIssuedateDateTimePicker"
        Me.DriLinIssuedateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DriLinIssuedateDateTimePicker.TabIndex = 22
        '
        'ExperinceLabel
        '
        ExperinceLabel.AutoSize = True
        ExperinceLabel.Location = New System.Drawing.Point(23, 311)
        ExperinceLabel.Name = "ExperinceLabel"
        ExperinceLabel.Size = New System.Drawing.Size(56, 13)
        ExperinceLabel.TabIndex = 23
        ExperinceLabel.Text = "experince:"
        '
        'ExperinceTextBox
        '
        Me.ExperinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Drivers_detailsBindingSource, "experince", True))
        Me.ExperinceTextBox.Location = New System.Drawing.Point(118, 308)
        Me.ExperinceTextBox.Name = "ExperinceTextBox"
        Me.ExperinceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ExperinceTextBox.TabIndex = 24
        '
        'PhotographPictureBox
        '
        Me.PhotographPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Drivers_detailsBindingSource, "Photograph", True))
        Me.PhotographPictureBox.Location = New System.Drawing.Point(395, 28)
        Me.PhotographPictureBox.Name = "PhotographPictureBox"
        Me.PhotographPictureBox.Size = New System.Drawing.Size(174, 120)
        Me.PhotographPictureBox.TabIndex = 26
        Me.PhotographPictureBox.TabStop = False
        '
        'PhotographLabel
        '
        PhotographLabel.AutoSize = True
        PhotographLabel.Location = New System.Drawing.Point(324, 22)
        PhotographLabel.Name = "PhotographLabel"
        PhotographLabel.Size = New System.Drawing.Size(65, 13)
        PhotographLabel.TabIndex = 25
        PhotographLabel.Text = "Photograph:"
        '
        'DriverDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 380)
        Me.Controls.Add(PhotographLabel)
        Me.Controls.Add(Me.PhotographPictureBox)
        Me.Controls.Add(DriverNumberLabel)
        Me.Controls.Add(Me.DriverNumberTextBox)
        Me.Controls.Add(ID_NumberLabel)
        Me.Controls.Add(Me.ID_NumberTextBox)
        Me.Controls.Add(License_numberLabel)
        Me.Controls.Add(Me.License_numberTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(DOBLabel)
        Me.Controls.Add(Me.DOBDateTimePicker)
        Me.Controls.Add(PostalAddressLabel)
        Me.Controls.Add(Me.PostalAddressTextBox)
        Me.Controls.Add(PostalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(TownLabel)
        Me.Controls.Add(Me.TownTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(DriLinIssuedateLabel)
        Me.Controls.Add(Me.DriLinIssuedateDateTimePicker)
        Me.Controls.Add(ExperinceLabel)
        Me.Controls.Add(Me.ExperinceTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DriverDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Driver Details"
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Drivers_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhotographPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fleet_databaseDataSet As Fleet.fleet_databaseDataSet
    Friend WithEvents Drivers_detailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Drivers_detailsTableAdapter As Fleet.fleet_databaseDataSetTableAdapters.drivers_detailsTableAdapter
    Friend WithEvents TableAdapterManager As Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DriverNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents License_numberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PostalAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CountryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DriLinIssuedateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ExperinceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhotographPictureBox As System.Windows.Forms.PictureBox
End Class

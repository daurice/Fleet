<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagementDetails
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
        Dim EmployeeNumberLabel As System.Windows.Forms.Label
        Dim ID_NumberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim PostalAddressLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim TownLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim Job_titleLabel As System.Windows.Forms.Label
        Dim PhotographLabel As System.Windows.Forms.Label
        Me.Fleet_databaseDataSet = New Fleet.fleet_databaseDataSet
        Me.Management_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Management_detailsTableAdapter = New Fleet.fleet_databaseDataSetTableAdapters.management_detailsTableAdapter
        Me.TableAdapterManager = New Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
        Me.EmployeeNumberTextBox = New System.Windows.Forms.TextBox
        Me.ID_NumberTextBox = New System.Windows.Forms.TextBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.PostalAddressTextBox = New System.Windows.Forms.TextBox
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox
        Me.TownTextBox = New System.Windows.Forms.TextBox
        Me.MobileTextBox = New System.Windows.Forms.TextBox
        Me.Job_titleTextBox = New System.Windows.Forms.TextBox
        Me.PhotographPictureBox = New System.Windows.Forms.PictureBox
        EmployeeNumberLabel = New System.Windows.Forms.Label
        ID_NumberLabel = New System.Windows.Forms.Label
        NameLabel = New System.Windows.Forms.Label
        PostalAddressLabel = New System.Windows.Forms.Label
        PostalCodeLabel = New System.Windows.Forms.Label
        TownLabel = New System.Windows.Forms.Label
        MobileLabel = New System.Windows.Forms.Label
        Job_titleLabel = New System.Windows.Forms.Label
        PhotographLabel = New System.Windows.Forms.Label
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Management_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhotographPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fleet_databaseDataSet
        '
        Me.Fleet_databaseDataSet.DataSetName = "fleet_databaseDataSet"
        Me.Fleet_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Management_detailsBindingSource
        '
        Me.Management_detailsBindingSource.DataMember = "management_details"
        Me.Management_detailsBindingSource.DataSource = Me.Fleet_databaseDataSet
        '
        'Management_detailsTableAdapter
        '
        Me.Management_detailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.company_detailsTableAdapter = Nothing
        Me.TableAdapterManager.drivers_detailsTableAdapter = Nothing
        Me.TableAdapterManager.management_detailsTableAdapter = Me.Management_detailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_accountTableAdapter = Nothing
        '
        'EmployeeNumberLabel
        '
        EmployeeNumberLabel.AutoSize = True
        EmployeeNumberLabel.Location = New System.Drawing.Point(36, 43)
        EmployeeNumberLabel.Name = "EmployeeNumberLabel"
        EmployeeNumberLabel.Size = New System.Drawing.Size(96, 13)
        EmployeeNumberLabel.TabIndex = 1
        EmployeeNumberLabel.Text = "Employee Number:"
        '
        'EmployeeNumberTextBox
        '
        Me.EmployeeNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Management_detailsBindingSource, "EmployeeNumber", True))
        Me.EmployeeNumberTextBox.Location = New System.Drawing.Point(138, 40)
        Me.EmployeeNumberTextBox.Name = "EmployeeNumberTextBox"
        Me.EmployeeNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmployeeNumberTextBox.TabIndex = 2
        '
        'ID_NumberLabel
        '
        ID_NumberLabel.AutoSize = True
        ID_NumberLabel.Location = New System.Drawing.Point(36, 69)
        ID_NumberLabel.Name = "ID_NumberLabel"
        ID_NumberLabel.Size = New System.Drawing.Size(61, 13)
        ID_NumberLabel.TabIndex = 3
        ID_NumberLabel.Text = "ID Number:"
        '
        'ID_NumberTextBox
        '
        Me.ID_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Management_detailsBindingSource, "ID_Number", True))
        Me.ID_NumberTextBox.Location = New System.Drawing.Point(138, 66)
        Me.ID_NumberTextBox.Name = "ID_NumberTextBox"
        Me.ID_NumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ID_NumberTextBox.TabIndex = 4
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(36, 95)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 5
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Management_detailsBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(138, 92)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 6
        '
        'PostalAddressLabel
        '
        PostalAddressLabel.AutoSize = True
        PostalAddressLabel.Location = New System.Drawing.Point(36, 121)
        PostalAddressLabel.Name = "PostalAddressLabel"
        PostalAddressLabel.Size = New System.Drawing.Size(80, 13)
        PostalAddressLabel.TabIndex = 7
        PostalAddressLabel.Text = "Postal Address:"
        '
        'PostalAddressTextBox
        '
        Me.PostalAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Management_detailsBindingSource, "PostalAddress", True))
        Me.PostalAddressTextBox.Location = New System.Drawing.Point(138, 118)
        Me.PostalAddressTextBox.Name = "PostalAddressTextBox"
        Me.PostalAddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PostalAddressTextBox.TabIndex = 8
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(36, 147)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(67, 13)
        PostalCodeLabel.TabIndex = 9
        PostalCodeLabel.Text = "Postal Code:"
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Management_detailsBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(138, 144)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PostalCodeTextBox.TabIndex = 10
        '
        'TownLabel
        '
        TownLabel.AutoSize = True
        TownLabel.Location = New System.Drawing.Point(36, 173)
        TownLabel.Name = "TownLabel"
        TownLabel.Size = New System.Drawing.Size(37, 13)
        TownLabel.TabIndex = 11
        TownLabel.Text = "Town:"
        '
        'TownTextBox
        '
        Me.TownTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Management_detailsBindingSource, "Town", True))
        Me.TownTextBox.Location = New System.Drawing.Point(138, 170)
        Me.TownTextBox.Name = "TownTextBox"
        Me.TownTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TownTextBox.TabIndex = 12
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Location = New System.Drawing.Point(36, 199)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(41, 13)
        MobileLabel.TabIndex = 13
        MobileLabel.Text = "Mobile:"
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Management_detailsBindingSource, "Mobile", True))
        Me.MobileTextBox.Location = New System.Drawing.Point(138, 196)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MobileTextBox.TabIndex = 14
        '
        'Job_titleLabel
        '
        Job_titleLabel.AutoSize = True
        Job_titleLabel.Location = New System.Drawing.Point(36, 225)
        Job_titleLabel.Name = "Job_titleLabel"
        Job_titleLabel.Size = New System.Drawing.Size(46, 13)
        Job_titleLabel.TabIndex = 15
        Job_titleLabel.Text = "Job title:"
        '
        'Job_titleTextBox
        '
        Me.Job_titleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Management_detailsBindingSource, "Job_title", True))
        Me.Job_titleTextBox.Location = New System.Drawing.Point(138, 222)
        Me.Job_titleTextBox.Name = "Job_titleTextBox"
        Me.Job_titleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Job_titleTextBox.TabIndex = 16
        '
        'PhotographLabel
        '
        PhotographLabel.AutoSize = True
        PhotographLabel.Location = New System.Drawing.Point(258, 40)
        PhotographLabel.Name = "PhotographLabel"
        PhotographLabel.Size = New System.Drawing.Size(65, 13)
        PhotographLabel.TabIndex = 17
        PhotographLabel.Text = "Photograph:"
        '
        'PhotographPictureBox
        '
        Me.PhotographPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Management_detailsBindingSource, "Photograph", True))
        Me.PhotographPictureBox.Location = New System.Drawing.Point(339, 43)
        Me.PhotographPictureBox.Name = "PhotographPictureBox"
        Me.PhotographPictureBox.Size = New System.Drawing.Size(234, 131)
        Me.PhotographPictureBox.TabIndex = 18
        Me.PhotographPictureBox.TabStop = False
        '
        'ManagementDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 311)
        Me.Controls.Add(PhotographLabel)
        Me.Controls.Add(Me.PhotographPictureBox)
        Me.Controls.Add(EmployeeNumberLabel)
        Me.Controls.Add(Me.EmployeeNumberTextBox)
        Me.Controls.Add(ID_NumberLabel)
        Me.Controls.Add(Me.ID_NumberTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(PostalAddressLabel)
        Me.Controls.Add(Me.PostalAddressTextBox)
        Me.Controls.Add(PostalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(TownLabel)
        Me.Controls.Add(Me.TownTextBox)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(Job_titleLabel)
        Me.Controls.Add(Me.Job_titleTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManagementDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Management Details"
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Management_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhotographPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fleet_databaseDataSet As Fleet.fleet_databaseDataSet
    Friend WithEvents Management_detailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Management_detailsTableAdapter As Fleet.fleet_databaseDataSetTableAdapters.management_detailsTableAdapter
    Friend WithEvents TableAdapterManager As Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ID_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TownTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Job_titleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhotographPictureBox As System.Windows.Forms.PictureBox
End Class

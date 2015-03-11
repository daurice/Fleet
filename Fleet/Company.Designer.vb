<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Company
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
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim WebsiteLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim PostalAddressLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Me.Fleet_databaseDataSet = New Fleet.fleet_databaseDataSet
        Me.Company_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Company_detailsTableAdapter = New Fleet.fleet_databaseDataSetTableAdapters.company_detailsTableAdapter
        Me.TableAdapterManager = New Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox
        Me.WebsiteTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.MobileTextBox = New System.Windows.Forms.TextBox
        Me.PostalAddressTextBox = New System.Windows.Forms.TextBox
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox
        Me.cmdAllowEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdChoose = New System.Windows.Forms.Button
        CompanyNameLabel = New System.Windows.Forms.Label
        WebsiteLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        MobileLabel = New System.Windows.Forms.Label
        PostalAddressLabel = New System.Windows.Forms.Label
        PostalCodeLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Company_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fleet_databaseDataSet
        '
        Me.Fleet_databaseDataSet.DataSetName = "fleet_databaseDataSet"
        Me.Fleet_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Company_detailsBindingSource
        '
        Me.Company_detailsBindingSource.DataMember = "company_details"
        Me.Company_detailsBindingSource.DataSource = Me.Fleet_databaseDataSet
        '
        'Company_detailsTableAdapter
        '
        Me.Company_detailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.company_detailsTableAdapter = Me.Company_detailsTableAdapter
        Me.TableAdapterManager.drivers_detailsTableAdapter = Nothing
        Me.TableAdapterManager.management_detailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_accountTableAdapter = Nothing
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(12, 19)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(85, 13)
        CompanyNameLabel.TabIndex = 3
        CompanyNameLabel.Text = "Company Name:"
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_detailsBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(103, 16)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(170, 20)
        Me.CompanyNameTextBox.TabIndex = 4
        '
        'WebsiteLabel
        '
        WebsiteLabel.AutoSize = True
        WebsiteLabel.Location = New System.Drawing.Point(12, 45)
        WebsiteLabel.Name = "WebsiteLabel"
        WebsiteLabel.Size = New System.Drawing.Size(49, 13)
        WebsiteLabel.TabIndex = 5
        WebsiteLabel.Text = "Website:"
        '
        'WebsiteTextBox
        '
        Me.WebsiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_detailsBindingSource, "Website", True))
        Me.WebsiteTextBox.Location = New System.Drawing.Point(103, 42)
        Me.WebsiteTextBox.Name = "WebsiteTextBox"
        Me.WebsiteTextBox.Size = New System.Drawing.Size(119, 20)
        Me.WebsiteTextBox.TabIndex = 6
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(12, 71)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_detailsBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(103, 68)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(170, 20)
        Me.EmailTextBox.TabIndex = 8
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Location = New System.Drawing.Point(12, 97)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(41, 13)
        MobileLabel.TabIndex = 9
        MobileLabel.Text = "Mobile:"
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_detailsBindingSource, "Mobile", True))
        Me.MobileTextBox.Location = New System.Drawing.Point(103, 94)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MobileTextBox.TabIndex = 10
        '
        'PostalAddressLabel
        '
        PostalAddressLabel.AutoSize = True
        PostalAddressLabel.Location = New System.Drawing.Point(12, 123)
        PostalAddressLabel.Name = "PostalAddressLabel"
        PostalAddressLabel.Size = New System.Drawing.Size(80, 13)
        PostalAddressLabel.TabIndex = 11
        PostalAddressLabel.Text = "Postal Address:"
        '
        'PostalAddressTextBox
        '
        Me.PostalAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_detailsBindingSource, "PostalAddress", True))
        Me.PostalAddressTextBox.Location = New System.Drawing.Point(103, 120)
        Me.PostalAddressTextBox.Name = "PostalAddressTextBox"
        Me.PostalAddressTextBox.Size = New System.Drawing.Size(141, 20)
        Me.PostalAddressTextBox.TabIndex = 12
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(12, 149)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(67, 13)
        PostalCodeLabel.TabIndex = 13
        PostalCodeLabel.Text = "Postal Code:"
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_detailsBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(103, 146)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(119, 20)
        Me.PostalCodeTextBox.TabIndex = 14
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(12, 175)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 15
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Company_detailsBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(103, 172)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CityTextBox.TabIndex = 16
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LogoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.Company_detailsBindingSource, "Logo", True))
        Me.LogoPictureBox.Location = New System.Drawing.Point(346, 16)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(199, 120)
        Me.LogoPictureBox.TabIndex = 17
        Me.LogoPictureBox.TabStop = False
        '
        'cmdAllowEdit
        '
        Me.cmdAllowEdit.Location = New System.Drawing.Point(16, 245)
        Me.cmdAllowEdit.Name = "cmdAllowEdit"
        Me.cmdAllowEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdAllowEdit.TabIndex = 18
        Me.cmdAllowEdit.Text = "Allow Edit"
        Me.cmdAllowEdit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(147, 245)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdChoose
        '
        Me.cmdChoose.Location = New System.Drawing.Point(346, 138)
        Me.cmdChoose.Name = "cmdChoose"
        Me.cmdChoose.Size = New System.Drawing.Size(75, 23)
        Me.cmdChoose.TabIndex = 20
        Me.cmdChoose.Text = "Choose.."
        Me.cmdChoose.UseVisualStyleBackColor = True
        '
        'Company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 302)
        Me.Controls.Add(Me.cmdChoose)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdAllowEdit)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(CompanyNameLabel)
        Me.Controls.Add(Me.CompanyNameTextBox)
        Me.Controls.Add(WebsiteLabel)
        Me.Controls.Add(Me.WebsiteTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(PostalAddressLabel)
        Me.Controls.Add(Me.PostalAddressTextBox)
        Me.Controls.Add(PostalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Company"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company"
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Company_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fleet_databaseDataSet As Fleet.fleet_databaseDataSet
    Friend WithEvents Company_detailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Company_detailsTableAdapter As Fleet.fleet_databaseDataSetTableAdapters.company_detailsTableAdapter
    Friend WithEvents TableAdapterManager As Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CompanyNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebsiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents cmdAllowEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdChoose As System.Windows.Forms.Button
End Class

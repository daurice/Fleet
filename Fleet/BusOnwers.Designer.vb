<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusOnwers
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
        Dim OnwerIDLabel As System.Windows.Forms.Label
        Dim OnwerNameLabel As System.Windows.Forms.Label
        Dim PostalAddressLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim MobileLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.Fleet_databaseDataSet = New Fleet.fleet_databaseDataSet
        Me.BusOnwersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BusOnwersTableAdapter = New Fleet.fleet_databaseDataSetTableAdapters.BusOnwersTableAdapter
        Me.TableAdapterManager = New Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
        Me.OnwerIDTextBox = New System.Windows.Forms.TextBox
        Me.OnwerNameTextBox = New System.Windows.Forms.TextBox
        Me.PostalAddressTextBox = New System.Windows.Forms.TextBox
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox
        Me.CityTextBox = New System.Windows.Forms.TextBox
        Me.MobileTextBox = New System.Windows.Forms.TextBox
        Me.EmailTextBox = New System.Windows.Forms.TextBox
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdPrevious = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        OnwerIDLabel = New System.Windows.Forms.Label
        OnwerNameLabel = New System.Windows.Forms.Label
        PostalAddressLabel = New System.Windows.Forms.Label
        PostalCodeLabel = New System.Windows.Forms.Label
        CityLabel = New System.Windows.Forms.Label
        MobileLabel = New System.Windows.Forms.Label
        EmailLabel = New System.Windows.Forms.Label
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BusOnwersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OnwerIDLabel
        '
        OnwerIDLabel.AutoSize = True
        OnwerIDLabel.Location = New System.Drawing.Point(14, 62)
        OnwerIDLabel.Name = "OnwerIDLabel"
        OnwerIDLabel.Size = New System.Drawing.Size(64, 13)
        OnwerIDLabel.TabIndex = 1
        OnwerIDLabel.Text = "ID/Passport"
        '
        'OnwerNameLabel
        '
        OnwerNameLabel.AutoSize = True
        OnwerNameLabel.Location = New System.Drawing.Point(14, 88)
        OnwerNameLabel.Name = "OnwerNameLabel"
        OnwerNameLabel.Size = New System.Drawing.Size(35, 13)
        OnwerNameLabel.TabIndex = 3
        OnwerNameLabel.Text = "Name"
        '
        'PostalAddressLabel
        '
        PostalAddressLabel.AutoSize = True
        PostalAddressLabel.Location = New System.Drawing.Point(14, 114)
        PostalAddressLabel.Name = "PostalAddressLabel"
        PostalAddressLabel.Size = New System.Drawing.Size(80, 13)
        PostalAddressLabel.TabIndex = 5
        PostalAddressLabel.Text = "Postal Address:"
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(14, 140)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(67, 13)
        PostalCodeLabel.TabIndex = 7
        PostalCodeLabel.Text = "Postal Code:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(14, 166)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(27, 13)
        CityLabel.TabIndex = 9
        CityLabel.Text = "City:"
        '
        'MobileLabel
        '
        MobileLabel.AutoSize = True
        MobileLabel.Location = New System.Drawing.Point(14, 192)
        MobileLabel.Name = "MobileLabel"
        MobileLabel.Size = New System.Drawing.Size(41, 13)
        MobileLabel.TabIndex = 11
        MobileLabel.Text = "Mobile:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(14, 218)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 13
        EmailLabel.Text = "Email:"
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
        'OnwerIDTextBox
        '
        Me.OnwerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusOnwersBindingSource, "OnwerID", True))
        Me.OnwerIDTextBox.Location = New System.Drawing.Point(100, 59)
        Me.OnwerIDTextBox.Name = "OnwerIDTextBox"
        Me.OnwerIDTextBox.Size = New System.Drawing.Size(146, 20)
        Me.OnwerIDTextBox.TabIndex = 2
        '
        'OnwerNameTextBox
        '
        Me.OnwerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusOnwersBindingSource, "OnwerName", True))
        Me.OnwerNameTextBox.Location = New System.Drawing.Point(100, 85)
        Me.OnwerNameTextBox.Name = "OnwerNameTextBox"
        Me.OnwerNameTextBox.Size = New System.Drawing.Size(209, 20)
        Me.OnwerNameTextBox.TabIndex = 4
        '
        'PostalAddressTextBox
        '
        Me.PostalAddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusOnwersBindingSource, "PostalAddress", True))
        Me.PostalAddressTextBox.Location = New System.Drawing.Point(100, 111)
        Me.PostalAddressTextBox.Name = "PostalAddressTextBox"
        Me.PostalAddressTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PostalAddressTextBox.TabIndex = 6
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusOnwersBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(100, 137)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(86, 20)
        Me.PostalCodeTextBox.TabIndex = 8
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusOnwersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(100, 163)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CityTextBox.TabIndex = 10
        '
        'MobileTextBox
        '
        Me.MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusOnwersBindingSource, "Mobile", True))
        Me.MobileTextBox.Location = New System.Drawing.Point(100, 189)
        Me.MobileTextBox.Name = "MobileTextBox"
        Me.MobileTextBox.Size = New System.Drawing.Size(146, 20)
        Me.MobileTextBox.TabIndex = 12
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BusOnwersBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(100, 215)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(209, 20)
        Me.EmailTextBox.TabIndex = 14
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(6, 251)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(65, 23)
        Me.cmdAdd.TabIndex = 15
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(77, 250)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(63, 23)
        Me.cmdSave.TabIndex = 16
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(308, 251)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 23)
        Me.cmdDelete.TabIndex = 17
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Location = New System.Drawing.Point(235, 14)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.cmdSearch.TabIndex = 18
        Me.cmdSearch.Text = "Search"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(6, 17)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(222, 20)
        Me.txtSearch.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 49)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Location = New System.Drawing.Point(146, 250)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(75, 23)
        Me.cmdPrevious.TabIndex = 21
        Me.cmdPrevious.Text = "Previous"
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(227, 251)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(75, 23)
        Me.cmdNext.TabIndex = 22
        Me.cmdNext.Text = "Next"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'BusOnwers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(384, 280)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.cmdPrevious)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(OnwerIDLabel)
        Me.Controls.Add(Me.OnwerIDTextBox)
        Me.Controls.Add(OnwerNameLabel)
        Me.Controls.Add(Me.OnwerNameTextBox)
        Me.Controls.Add(PostalAddressLabel)
        Me.Controls.Add(Me.PostalAddressTextBox)
        Me.Controls.Add(PostalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(MobileLabel)
        Me.Controls.Add(Me.MobileTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BusOnwers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Onwers"
        CType(Me.Fleet_databaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BusOnwersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fleet_databaseDataSet As Fleet.fleet_databaseDataSet
    Friend WithEvents BusOnwersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BusOnwersTableAdapter As Fleet.fleet_databaseDataSetTableAdapters.BusOnwersTableAdapter
    Friend WithEvents TableAdapterManager As Fleet.fleet_databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OnwerIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OnwerNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalAddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PostalCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MobileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
End Class

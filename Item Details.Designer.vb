<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Item_Details))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TPAddItem = New System.Windows.Forms.TabPage()
        Me.LblValidation = New System.Windows.Forms.Label()
        Me.TxtCatName = New System.Windows.Forms.TextBox()
        Me.TxtCatId = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.ReceDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.TxtIName = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TPItemDetails = New System.Windows.Forms.TabPage()
        Me.ItemData = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.TPAddItem.SuspendLayout()
        Me.TPItemDetails.SuspendLayout()
        CType(Me.ItemData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPAddItem)
        Me.TabControl1.Controls.Add(Me.TPItemDetails)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(610, 471)
        Me.TabControl1.TabIndex = 0
        '
        'TPAddItem
        '
        Me.TPAddItem.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TPAddItem.Controls.Add(Me.LblValidation)
        Me.TPAddItem.Controls.Add(Me.TxtCatName)
        Me.TPAddItem.Controls.Add(Me.TxtCatId)
        Me.TPAddItem.Controls.Add(Me.Guna2HtmlLabel7)
        Me.TPAddItem.Controls.Add(Me.BtnExit)
        Me.TPAddItem.Controls.Add(Me.BtnClear)
        Me.TPAddItem.Controls.Add(Me.BtnAdd)
        Me.TPAddItem.Controls.Add(Me.ReceDate)
        Me.TPAddItem.Controls.Add(Me.TxtDesc)
        Me.TPAddItem.Controls.Add(Me.TxtIName)
        Me.TPAddItem.Controls.Add(Me.TxtId)
        Me.TPAddItem.Controls.Add(Me.Guna2HtmlLabel6)
        Me.TPAddItem.Controls.Add(Me.Guna2HtmlLabel4)
        Me.TPAddItem.Controls.Add(Me.Guna2HtmlLabel3)
        Me.TPAddItem.Controls.Add(Me.Guna2HtmlLabel2)
        Me.TPAddItem.Controls.Add(Me.Guna2HtmlLabel1)
        Me.TPAddItem.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPAddItem.Location = New System.Drawing.Point(4, 28)
        Me.TPAddItem.Name = "TPAddItem"
        Me.TPAddItem.Padding = New System.Windows.Forms.Padding(3)
        Me.TPAddItem.Size = New System.Drawing.Size(602, 439)
        Me.TPAddItem.TabIndex = 0
        Me.TPAddItem.Text = "Add New Item"
        '
        'LblValidation
        '
        Me.LblValidation.AutoSize = True
        Me.LblValidation.Font = New System.Drawing.Font("Microsoft New Tai Lue", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValidation.ForeColor = System.Drawing.Color.Red
        Me.LblValidation.Location = New System.Drawing.Point(165, 78)
        Me.LblValidation.Name = "LblValidation"
        Me.LblValidation.Size = New System.Drawing.Size(0, 15)
        Me.LblValidation.TabIndex = 19
        '
        'TxtCatName
        '
        Me.TxtCatName.Location = New System.Drawing.Point(162, 96)
        Me.TxtCatName.Name = "TxtCatName"
        Me.TxtCatName.Size = New System.Drawing.Size(161, 24)
        Me.TxtCatName.TabIndex = 18
        '
        'TxtCatId
        '
        Me.TxtCatId.Location = New System.Drawing.Point(162, 51)
        Me.TxtCatId.Name = "TxtCatId"
        Me.TxtCatId.Size = New System.Drawing.Size(161, 24)
        Me.TxtCatId.TabIndex = 17
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(32, 51)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(76, 18)
        Me.Guna2HtmlLabel7.TabIndex = 16
        Me.Guna2HtmlLabel7.Text = "Category ID"
        '
        'BtnExit
        '
        Me.BtnExit.AutoRoundedCorners = True
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BorderRadius = 13
        Me.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnExit.FillColor = System.Drawing.Color.DarkRed
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Black
        Me.BtnExit.Location = New System.Drawing.Point(432, 147)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(83, 29)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.Text = "Exit"
        '
        'BtnClear
        '
        Me.BtnClear.AutoRoundedCorners = True
        Me.BtnClear.BackColor = System.Drawing.Color.Transparent
        Me.BtnClear.BorderRadius = 13
        Me.BtnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnClear.FillColor = System.Drawing.Color.DodgerBlue
        Me.BtnClear.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.Black
        Me.BtnClear.Location = New System.Drawing.Point(432, 99)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(83, 29)
        Me.BtnClear.TabIndex = 13
        Me.BtnClear.Text = "Clear"
        '
        'BtnAdd
        '
        Me.BtnAdd.AutoRoundedCorners = True
        Me.BtnAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnAdd.BorderRadius = 13
        Me.BtnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAdd.FillColor = System.Drawing.Color.Khaki
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnAdd.Location = New System.Drawing.Point(432, 51)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(83, 29)
        Me.BtnAdd.TabIndex = 12
        Me.BtnAdd.Text = "Add"
        '
        'ReceDate
        '
        Me.ReceDate.Location = New System.Drawing.Point(162, 339)
        Me.ReceDate.Name = "ReceDate"
        Me.ReceDate.Size = New System.Drawing.Size(223, 24)
        Me.ReceDate.TabIndex = 11
        Me.ReceDate.Value = New Date(2023, 8, 8, 0, 0, 0, 0)
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(162, 219)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(161, 98)
        Me.TxtDesc.TabIndex = 9
        '
        'TxtIName
        '
        Me.TxtIName.Location = New System.Drawing.Point(162, 178)
        Me.TxtIName.Name = "TxtIName"
        Me.TxtIName.Size = New System.Drawing.Size(161, 24)
        Me.TxtIName.TabIndex = 8
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(162, 137)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(161, 24)
        Me.TxtId.TabIndex = 7
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(32, 345)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(90, 18)
        Me.Guna2HtmlLabel6.TabIndex = 5
        Me.Guna2HtmlLabel6.Text = "Received Date"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(32, 219)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(74, 18)
        Me.Guna2HtmlLabel4.TabIndex = 3
        Me.Guna2HtmlLabel4.Text = "Description"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(32, 178)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(67, 18)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "Iten Name"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(32, 137)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(49, 18)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Item ID"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(32, 96)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(98, 18)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Category Name"
        '
        'TPItemDetails
        '
        Me.TPItemDetails.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TPItemDetails.Controls.Add(Me.ItemData)
        Me.TPItemDetails.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPItemDetails.Location = New System.Drawing.Point(4, 28)
        Me.TPItemDetails.Name = "TPItemDetails"
        Me.TPItemDetails.Padding = New System.Windows.Forms.Padding(3)
        Me.TPItemDetails.Size = New System.Drawing.Size(602, 439)
        Me.TPItemDetails.TabIndex = 1
        Me.TPItemDetails.Text = "Item Details"
        '
        'ItemData
        '
        Me.ItemData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemData.Location = New System.Drawing.Point(20, 52)
        Me.ItemData.Name = "ItemData"
        Me.ItemData.Size = New System.Drawing.Size(559, 359)
        Me.ItemData.TabIndex = 0
        '
        'Item_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(610, 471)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Item_Details"
        Me.Text = "Item_Details"
        Me.TabControl1.ResumeLayout(False)
        Me.TPAddItem.ResumeLayout(False)
        Me.TPAddItem.PerformLayout()
        Me.TPItemDetails.ResumeLayout(False)
        CType(Me.ItemData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPAddItem As TabPage
    Friend WithEvents TPItemDetails As TabPage
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents TxtIName As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ReceDate As DateTimePicker
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ItemData As DataGridView
    Friend WithEvents TxtCatName As TextBox
    Friend WithEvents TxtCatId As TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents LblValidation As Label
End Class

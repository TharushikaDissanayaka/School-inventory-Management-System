<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Item_Lend___Return
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Item_Lend___Return))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BttnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnClear = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnCheckout = New Guna.UI2.WinForms.Guna2Button()
        Me.CmbLoadItemId = New System.Windows.Forms.ComboBox()
        Me.CmbLoadBorrowerId = New System.Windows.Forms.ComboBox()
        Me.CmbLoadCategory = New System.Windows.Forms.ComboBox()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtBorrowNote = New System.Windows.Forms.TextBox()
        Me.TxtLoadBorrowerName = New System.Windows.Forms.TextBox()
        Me.TxtLoadItemName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGCheckout = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DGReturnList = New System.Windows.Forms.DataGridView()
        Me.DGBorrowList = New System.Windows.Forms.DataGridView()
        Me.TxtReturnNote = New System.Windows.Forms.TextBox()
        Me.TxtReturnDate = New System.Windows.Forms.TextBox()
        Me.TxtBorrowDate = New System.Windows.Forms.TextBox()
        Me.TxtBorrowerName = New System.Windows.Forms.TextBox()
        Me.TxtBorrowerId = New System.Windows.Forms.TextBox()
        Me.TxtItemName = New System.Windows.Forms.TextBox()
        Me.TxtItemId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblBorrowDate = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGCheckout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGReturnList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGBorrowList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(2, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(803, 556)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TabPage1.Controls.Add(Me.LblBorrowDate)
        Me.TabPage1.Controls.Add(Me.BttnExit)
        Me.TabPage1.Controls.Add(Me.BtnClear)
        Me.TabPage1.Controls.Add(Me.BtnCheckout)
        Me.TabPage1.Controls.Add(Me.CmbLoadItemId)
        Me.TabPage1.Controls.Add(Me.CmbLoadBorrowerId)
        Me.TabPage1.Controls.Add(Me.CmbLoadCategory)
        Me.TabPage1.Controls.Add(Me.ReturnDate)
        Me.TabPage1.Controls.Add(Me.TxtBorrowNote)
        Me.TabPage1.Controls.Add(Me.TxtLoadBorrowerName)
        Me.TabPage1.Controls.Add(Me.TxtLoadItemName)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.DGCheckout)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(795, 524)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Item Checkout"
        '
        'BttnExit
        '
        Me.BttnExit.AutoRoundedCorners = True
        Me.BttnExit.BackColor = System.Drawing.Color.Transparent
        Me.BttnExit.BorderRadius = 13
        Me.BttnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BttnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BttnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BttnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BttnExit.FillColor = System.Drawing.Color.DarkRed
        Me.BttnExit.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnExit.ForeColor = System.Drawing.Color.Black
        Me.BttnExit.Location = New System.Drawing.Point(471, 215)
        Me.BttnExit.Name = "BttnExit"
        Me.BttnExit.Size = New System.Drawing.Size(83, 29)
        Me.BttnExit.TabIndex = 19
        Me.BttnExit.Text = "Exit"
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
        Me.BtnClear.Location = New System.Drawing.Point(340, 215)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(83, 29)
        Me.BtnClear.TabIndex = 18
        Me.BtnClear.Text = "Clear"
        '
        'BtnCheckout
        '
        Me.BtnCheckout.AutoRoundedCorners = True
        Me.BtnCheckout.BackColor = System.Drawing.Color.Transparent
        Me.BtnCheckout.BorderRadius = 13
        Me.BtnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnCheckout.FillColor = System.Drawing.Color.Khaki
        Me.BtnCheckout.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCheckout.ForeColor = System.Drawing.Color.Black
        Me.BtnCheckout.Location = New System.Drawing.Point(213, 215)
        Me.BtnCheckout.Name = "BtnCheckout"
        Me.BtnCheckout.Size = New System.Drawing.Size(83, 29)
        Me.BtnCheckout.TabIndex = 17
        Me.BtnCheckout.Text = "Add"
        '
        'CmbLoadItemId
        '
        Me.CmbLoadItemId.FormattingEnabled = True
        Me.CmbLoadItemId.Location = New System.Drawing.Point(161, 35)
        Me.CmbLoadItemId.Name = "CmbLoadItemId"
        Me.CmbLoadItemId.Size = New System.Drawing.Size(121, 24)
        Me.CmbLoadItemId.TabIndex = 16
        Me.CmbLoadItemId.Text = "Select Item"
        '
        'CmbLoadBorrowerId
        '
        Me.CmbLoadBorrowerId.FormattingEnabled = True
        Me.CmbLoadBorrowerId.Location = New System.Drawing.Point(467, 35)
        Me.CmbLoadBorrowerId.Name = "CmbLoadBorrowerId"
        Me.CmbLoadBorrowerId.Size = New System.Drawing.Size(115, 24)
        Me.CmbLoadBorrowerId.TabIndex = 15
        Me.CmbLoadBorrowerId.Text = "Select Borrower"
        '
        'CmbLoadCategory
        '
        Me.CmbLoadCategory.FormattingEnabled = True
        Me.CmbLoadCategory.Location = New System.Drawing.Point(22, 35)
        Me.CmbLoadCategory.Name = "CmbLoadCategory"
        Me.CmbLoadCategory.Size = New System.Drawing.Size(121, 24)
        Me.CmbLoadCategory.TabIndex = 14
        Me.CmbLoadCategory.Text = "Select Category"
        '
        'ReturnDate
        '
        Me.ReturnDate.CalendarFont = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnDate.Font = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ReturnDate.Location = New System.Drawing.Point(401, 154)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(214, 21)
        Me.ReturnDate.TabIndex = 12
        Me.ReturnDate.Value = New Date(2023, 8, 19, 0, 0, 0, 0)
        '
        'TxtBorrowNote
        '
        Me.TxtBorrowNote.Location = New System.Drawing.Point(123, 96)
        Me.TxtBorrowNote.Multiline = True
        Me.TxtBorrowNote.Name = "TxtBorrowNote"
        Me.TxtBorrowNote.Size = New System.Drawing.Size(199, 78)
        Me.TxtBorrowNote.TabIndex = 11
        '
        'TxtLoadBorrowerName
        '
        Me.TxtLoadBorrowerName.Location = New System.Drawing.Point(600, 35)
        Me.TxtLoadBorrowerName.Multiline = True
        Me.TxtLoadBorrowerName.Name = "TxtLoadBorrowerName"
        Me.TxtLoadBorrowerName.Size = New System.Drawing.Size(164, 20)
        Me.TxtLoadBorrowerName.TabIndex = 10
        '
        'TxtLoadItemName
        '
        Me.TxtLoadItemName.Location = New System.Drawing.Point(299, 35)
        Me.TxtLoadItemName.Multiline = True
        Me.TxtLoadItemName.Name = "TxtLoadItemName"
        Me.TxtLoadItemName.Size = New System.Drawing.Size(151, 20)
        Me.TxtLoadItemName.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.Location = New System.Drawing.Point(181, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Burrow Note"
        '
        'DGCheckout
        '
        Me.DGCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCheckout.Location = New System.Drawing.Point(14, 277)
        Me.DGCheckout.Name = "DGCheckout"
        Me.DGCheckout.Size = New System.Drawing.Size(768, 241)
        Me.DGCheckout.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Location = New System.Drawing.Point(448, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Return Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.Location = New System.Drawing.Point(445, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Borrow Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Location = New System.Drawing.Point(628, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Borrower Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.Location = New System.Drawing.Point(485, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Borrower ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Location = New System.Drawing.Point(337, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Item Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(198, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Item ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(28, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category Name"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.TabPage2.Controls.Add(Me.BtnExit)
        Me.TabPage2.Controls.Add(Me.BtnAdd)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label16)
        Me.TabPage2.Controls.Add(Me.DGReturnList)
        Me.TabPage2.Controls.Add(Me.DGBorrowList)
        Me.TabPage2.Controls.Add(Me.TxtReturnNote)
        Me.TabPage2.Controls.Add(Me.TxtReturnDate)
        Me.TabPage2.Controls.Add(Me.TxtBorrowDate)
        Me.TabPage2.Controls.Add(Me.TxtBorrowerName)
        Me.TabPage2.Controls.Add(Me.TxtBorrowerId)
        Me.TabPage2.Controls.Add(Me.TxtItemName)
        Me.TabPage2.Controls.Add(Me.TxtItemId)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(795, 524)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Item Return"
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
        Me.BtnExit.Location = New System.Drawing.Point(45, 479)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(83, 29)
        Me.BtnExit.TabIndex = 25
        Me.BtnExit.Text = "Exit"
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
        Me.BtnAdd.Location = New System.Drawing.Point(45, 440)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(83, 29)
        Me.BtnAdd.TabIndex = 24
        Me.BtnAdd.Text = "Add"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label17.Location = New System.Drawing.Point(400, 286)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 22)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Return List"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label16.Location = New System.Drawing.Point(400, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 22)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Burrow List"
        '
        'DGReturnList
        '
        Me.DGReturnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReturnList.Location = New System.Drawing.Point(231, 321)
        Me.DGReturnList.Name = "DGReturnList"
        Me.DGReturnList.Size = New System.Drawing.Size(522, 175)
        Me.DGReturnList.TabIndex = 21
        '
        'DGBorrowList
        '
        Me.DGBorrowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBorrowList.Location = New System.Drawing.Point(231, 55)
        Me.DGBorrowList.Name = "DGBorrowList"
        Me.DGBorrowList.Size = New System.Drawing.Size(522, 175)
        Me.DGBorrowList.TabIndex = 20
        '
        'TxtReturnNote
        '
        Me.TxtReturnNote.Location = New System.Drawing.Point(16, 342)
        Me.TxtReturnNote.Multiline = True
        Me.TxtReturnNote.Name = "TxtReturnNote"
        Me.TxtReturnNote.Size = New System.Drawing.Size(162, 82)
        Me.TxtReturnNote.TabIndex = 19
        '
        'TxtReturnDate
        '
        Me.TxtReturnDate.Location = New System.Drawing.Point(16, 293)
        Me.TxtReturnDate.Multiline = True
        Me.TxtReturnDate.Name = "TxtReturnDate"
        Me.TxtReturnDate.Size = New System.Drawing.Size(162, 20)
        Me.TxtReturnDate.TabIndex = 18
        '
        'TxtBorrowDate
        '
        Me.TxtBorrowDate.Location = New System.Drawing.Point(16, 242)
        Me.TxtBorrowDate.Multiline = True
        Me.TxtBorrowDate.Name = "TxtBorrowDate"
        Me.TxtBorrowDate.Size = New System.Drawing.Size(162, 20)
        Me.TxtBorrowDate.TabIndex = 17
        '
        'TxtBorrowerName
        '
        Me.TxtBorrowerName.Location = New System.Drawing.Point(15, 191)
        Me.TxtBorrowerName.Multiline = True
        Me.TxtBorrowerName.Name = "TxtBorrowerName"
        Me.TxtBorrowerName.Size = New System.Drawing.Size(163, 20)
        Me.TxtBorrowerName.TabIndex = 16
        '
        'TxtBorrowerId
        '
        Me.TxtBorrowerId.Location = New System.Drawing.Point(15, 140)
        Me.TxtBorrowerId.Multiline = True
        Me.TxtBorrowerId.Name = "TxtBorrowerId"
        Me.TxtBorrowerId.Size = New System.Drawing.Size(163, 20)
        Me.TxtBorrowerId.TabIndex = 15
        '
        'TxtItemName
        '
        Me.TxtItemName.Location = New System.Drawing.Point(16, 87)
        Me.TxtItemName.Multiline = True
        Me.TxtItemName.Name = "TxtItemName"
        Me.TxtItemName.Size = New System.Drawing.Size(162, 20)
        Me.TxtItemName.TabIndex = 14
        '
        'TxtItemId
        '
        Me.TxtItemId.Location = New System.Drawing.Point(15, 34)
        Me.TxtItemId.Multiline = True
        Me.TxtItemId.Name = "TxtItemId"
        Me.TxtItemId.Size = New System.Drawing.Size(163, 20)
        Me.TxtItemId.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label9.Location = New System.Drawing.Point(13, 323)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Return Note"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label15.Location = New System.Drawing.Point(13, 274)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 16)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Return Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label10.Location = New System.Drawing.Point(13, 223)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Borrow Date"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label11.Location = New System.Drawing.Point(13, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Borrower Name"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label12.Location = New System.Drawing.Point(13, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Borrower ID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label13.Location = New System.Drawing.Point(13, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Item Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label14.Location = New System.Drawing.Point(13, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 16)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Item ID"
        '
        'LblBorrowDate
        '
        Me.LblBorrowDate.AutoSize = True
        Me.LblBorrowDate.Location = New System.Drawing.Point(488, 99)
        Me.LblBorrowDate.Name = "LblBorrowDate"
        Me.LblBorrowDate.Size = New System.Drawing.Size(0, 16)
        Me.LblBorrowDate.TabIndex = 20
        '
        'Item_Lend___Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(803, 571)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Item_Lend___Return"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item_Lend___Return"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGCheckout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGReturnList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGBorrowList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DGCheckout As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtReturnNote As TextBox
    Friend WithEvents TxtReturnDate As TextBox
    Friend WithEvents TxtBorrowDate As TextBox
    Friend WithEvents TxtBorrowerName As TextBox
    Friend WithEvents TxtBorrowerId As TextBox
    Friend WithEvents TxtItemName As TextBox
    Friend WithEvents TxtItemId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DGReturnList As DataGridView
    Friend WithEvents DGBorrowList As DataGridView
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtLoadBorrowerName As TextBox
    Friend WithEvents TxtLoadItemName As TextBox
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents TxtBorrowNote As TextBox
    Friend WithEvents CmbLoadBorrowerId As ComboBox
    Friend WithEvents CmbLoadCategory As ComboBox
    Friend WithEvents CmbLoadItemId As ComboBox
    Friend WithEvents BtnCheckout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BttnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LblBorrowDate As Label
End Class

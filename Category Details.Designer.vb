<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category_Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category_Details))
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtCatId = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtCatName = New System.Windows.Forms.TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TxtDesc = New System.Windows.Forms.TextBox()
        Me.CatData = New System.Windows.Forms.DataGridView()
        Me.BtnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDel = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.CatData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(50, 108)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(76, 18)
        Me.Guna2HtmlLabel7.TabIndex = 17
        Me.Guna2HtmlLabel7.Text = "Category ID"
        '
        'TxtCatId
        '
        Me.TxtCatId.Location = New System.Drawing.Point(154, 106)
        Me.TxtCatId.Name = "TxtCatId"
        Me.TxtCatId.Size = New System.Drawing.Size(198, 20)
        Me.TxtCatId.TabIndex = 18
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(50, 146)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(98, 18)
        Me.Guna2HtmlLabel1.TabIndex = 19
        Me.Guna2HtmlLabel1.Text = "Category Name"
        '
        'TxtCatName
        '
        Me.TxtCatName.Location = New System.Drawing.Point(154, 144)
        Me.TxtCatName.Name = "TxtCatName"
        Me.TxtCatName.Size = New System.Drawing.Size(198, 20)
        Me.TxtCatName.TabIndex = 20
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(50, 188)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(74, 18)
        Me.Guna2HtmlLabel4.TabIndex = 21
        Me.Guna2HtmlLabel4.Text = "Description"
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(154, 188)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(198, 82)
        Me.TxtDesc.TabIndex = 22
        '
        'CatData
        '
        Me.CatData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CatData.Location = New System.Drawing.Point(129, 298)
        Me.CatData.Name = "CatData"
        Me.CatData.Size = New System.Drawing.Size(360, 161)
        Me.CatData.TabIndex = 23
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
        Me.BtnAdd.Location = New System.Drawing.Point(503, 114)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(83, 29)
        Me.BtnAdd.TabIndex = 24
        Me.BtnAdd.Text = "Add"
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
        Me.BtnExit.Location = New System.Drawing.Point(503, 218)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(83, 29)
        Me.BtnExit.TabIndex = 26
        Me.BtnExit.Text = "Exit"
        '
        'BtnDel
        '
        Me.BtnDel.AutoRoundedCorners = True
        Me.BtnDel.BackColor = System.Drawing.Color.Transparent
        Me.BtnDel.BorderRadius = 13
        Me.BtnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDel.FillColor = System.Drawing.Color.DarkRed
        Me.BtnDel.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDel.ForeColor = System.Drawing.Color.Black
        Me.BtnDel.Location = New System.Drawing.Point(503, 167)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(83, 29)
        Me.BtnDel.TabIndex = 28
        Me.BtnDel.Text = "Delete"
        '
        'Category_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(608, 471)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.CatData)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.TxtCatName)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.TxtCatId)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Category_Details"
        Me.Text = "Category_Details"
        CType(Me.CatData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtCatId As TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtCatName As TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TxtDesc As TextBox
    Friend WithEvents CatData As DataGridView
    Friend WithEvents BtnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnDel As Guna.UI2.WinForms.Guna2Button
End Class

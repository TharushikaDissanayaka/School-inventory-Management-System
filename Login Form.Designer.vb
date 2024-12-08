<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login_Form))
        Me.BtnLog = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TxtUName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TxtPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ChkPass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.SuspendLayout()
        '
        'BtnLog
        '
        Me.BtnLog.AutoRoundedCorners = True
        Me.BtnLog.BackColor = System.Drawing.Color.Transparent
        Me.BtnLog.BorderRadius = 14
        Me.BtnLog.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnLog.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnLog.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLog.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLog.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLog.FillColor = System.Drawing.Color.White
        Me.BtnLog.FillColor2 = System.Drawing.Color.White
        Me.BtnLog.Font = New System.Drawing.Font("Thibus29STru", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLog.ForeColor = System.Drawing.Color.Black
        Me.BtnLog.Location = New System.Drawing.Point(226, 354)
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.Size = New System.Drawing.Size(162, 30)
        Me.BtnLog.TabIndex = 0
        Me.BtnLog.Text = "LOGIN"
        '
        'TxtUName
        '
        Me.TxtUName.AutoRoundedCorners = True
        Me.TxtUName.BackColor = System.Drawing.Color.Transparent
        Me.TxtUName.BorderColor = System.Drawing.Color.Transparent
        Me.TxtUName.BorderRadius = 12
        Me.TxtUName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtUName.DefaultText = ""
        Me.TxtUName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtUName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtUName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtUName.FillColor = System.Drawing.Color.Transparent
        Me.TxtUName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtUName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtUName.Location = New System.Drawing.Point(217, 171)
        Me.TxtUName.Name = "TxtUName"
        Me.TxtUName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtUName.PlaceholderText = ""
        Me.TxtUName.SelectedText = ""
        Me.TxtUName.Size = New System.Drawing.Size(238, 27)
        Me.TxtUName.TabIndex = 1
        '
        'TxtPass
        '
        Me.TxtPass.AutoRoundedCorners = True
        Me.TxtPass.BackColor = System.Drawing.Color.Transparent
        Me.TxtPass.BorderColor = System.Drawing.Color.Transparent
        Me.TxtPass.BorderRadius = 12
        Me.TxtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPass.DefaultText = ""
        Me.TxtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtPass.FillColor = System.Drawing.Color.Transparent
        Me.TxtPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtPass.Location = New System.Drawing.Point(168, 259)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPass.PlaceholderText = ""
        Me.TxtPass.SelectedText = ""
        Me.TxtPass.Size = New System.Drawing.Size(238, 27)
        Me.TxtPass.TabIndex = 2
        '
        'ChkPass
        '
        Me.ChkPass.AutoSize = True
        Me.ChkPass.BackColor = System.Drawing.Color.Transparent
        Me.ChkPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkPass.CheckedState.BorderRadius = 0
        Me.ChkPass.CheckedState.BorderThickness = 0
        Me.ChkPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ChkPass.CheckMarkColor = System.Drawing.Color.Black
        Me.ChkPass.ForeColor = System.Drawing.Color.White
        Me.ChkPass.Location = New System.Drawing.Point(306, 297)
        Me.ChkPass.Name = "ChkPass"
        Me.ChkPass.Size = New System.Drawing.Size(102, 17)
        Me.ChkPass.TabIndex = 3
        Me.ChkPass.Text = "Show Password"
        Me.ChkPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkPass.UncheckedState.BorderRadius = 0
        Me.ChkPass.UncheckedState.BorderThickness = 0
        Me.ChkPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ChkPass.UseVisualStyleBackColor = False
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(610, 471)
        Me.Controls.Add(Me.ChkPass)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.TxtUName)
        Me.Controls.Add(Me.BtnLog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLog As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TxtUName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TxtPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ChkPass As Guna.UI2.WinForms.Guna2CheckBox
End Class

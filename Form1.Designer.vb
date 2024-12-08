<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.BtnExit = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.AutoRoundedCorners = True
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BorderColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BorderRadius = 21
        Me.BtnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLogin.FillColor = System.Drawing.Color.RoyalBlue
        Me.BtnLogin.FillColor2 = System.Drawing.Color.Navy
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI Historic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLogin.Location = New System.Drawing.Point(214, 200)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.PressedColor = System.Drawing.Color.Transparent
        Me.BtnLogin.Size = New System.Drawing.Size(180, 45)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "Login"
        '
        'BtnExit
        '
        Me.BtnExit.AutoRoundedCorners = True
        Me.BtnExit.BackColor = System.Drawing.Color.Transparent
        Me.BtnExit.BorderRadius = 21
        Me.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnExit.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExit.FillColor2 = System.Drawing.Color.Red
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI Historic", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(214, 286)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(180, 45)
        Me.BtnExit.TabIndex = 1
        Me.BtnExit.Text = "Exit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(592, 471)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents BtnExit As Guna.UI2.WinForms.Guna2GradientButton
End Class

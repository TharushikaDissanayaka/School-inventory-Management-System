Public Class Login_Form
    Private Sub BtnLog_Click(sender As Object, e As EventArgs) Handles BtnLog.Click
        Dim username As String = TxtUName.Text
        Dim password As String = TxtPass.Text

        If username = "Admin 1" And password = "Ad123" Then
            MessageBox.Show("Login successful!")
            Home_Page.Show()
            Me.Hide()

        ElseIf username = "Admin 2" And password = "Ad456" Then
            MessageBox.Show("Login successful!")
            Home_Page.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Sub ChkPass_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPass.CheckedChanged
        If ChkPass.Checked = False Then
            TxtPass.PasswordChar = "*"
        Else
            TxtPass.PasswordChar = ""
        End If
    End Sub
End Class
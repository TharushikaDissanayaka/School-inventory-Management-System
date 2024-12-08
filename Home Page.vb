Public Class Home_Page
    Private Sub BtnIDetails_Click(sender As Object, e As EventArgs) Handles BtnIDetails.Click
        Item_Details.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCDetails_Click(sender As Object, e As EventArgs) Handles BtnCDetails.Click

    End Sub

    Private Sub BtnICheck_Click(sender As Object, e As EventArgs) Handles BtnICheck.Click

    End Sub

    Private Sub BtnIRet_Click(sender As Object, e As EventArgs) Handles BtnIRet.Click

    End Sub

    Private Sub BtnRep_Click(sender As Object, e As EventArgs) Handles BtnRep.Click

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Login_Form.Show()
        Me.Hide()

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
Imports MySql.Data.MySqlClient

Public Class Category_Details

    Dim DbConn As New MySqlConnection("host=localhost; user=root; password=; database= testing")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            DbConn.Open()

            Dim query As String = "INSERT INTO category(category_id, category_name, category_description) VALUES (@category_id, @category_name, @category_description)"
            cmd = New MySqlCommand(query, DbConn)
            cmd.Parameters.AddWithValue("@category_id", TxtCatId.Text)
            cmd.Parameters.AddWithValue("@category_name", TxtCatName.Text)
            cmd.Parameters.AddWithValue("@category_description", TxtDesc.Text)


            cmd.ExecuteNonQuery()

            MessageBox.Show("Data added to the table successfully.")

        Catch ex As Exception
            MessageBox.Show("An error occurred while inserting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            DbConn.Close()
        End Try

        LoadData()
    End Sub

    Private Sub ClearFields()
        TxtCatId.Text = ""
        TxtCatName.Text = ""
        TxtDesc.Text = ""
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the form?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            TxtCatId.Text = ""
            TxtCatName.Text = ""
            TxtDesc.Text = ""
            'ComboCat.SelectedIndex = -1 ' Clear selection in ComboBox
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LoadData()
        Try
            DbConn.Open()

            Dim query As String = "SELECT * FROM category"
            cmd = New MySqlCommand(query, DbConn)
            da.SelectCommand = cmd
            dt.Clear() ' Clearing the DataTable before filling it might not be necessary in this context
            da.Fill(dt)

            CatData.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            DbConn.Close()
        End Try

    End Sub

    Private Sub Category_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub
End Class
Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Item_Details

    Dim DbConn As New MySqlConnection("host=localhost; user=root; password=; database= testing")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        'Try
        '    DbConn.Open()

        '    Dim query As String
        '    query = "INSERT INTO item_details(category_name, item_id, item_name, description, quantity, received_date) VALUES(@category_name,@item_id,@item_name,@description,@quantity,@received_date)"
        '    cmd = New MySqlCommand(query, DbConn)
        '    cmd.Parameters.AddWithValue("@category_name", ComboCat.SelectedItem.ToString())
        '    cmd.Parameters.AddWithValue("@item_id", TxtId.Text)
        '    cmd.Parameters.AddWithValue("@item_name", TxtIName.Text)
        '    cmd.Parameters.AddWithValue("@description", TxtDesc.Text)
        '    cmd.Parameters.AddWithValue("@quantity", TxtQuan.Text)
        '    cmd.Parameters.AddWithValue("@received_date", ReceDate.Value)

        '    cmd.ExecuteNonQuery()
        '    MessageBox.Show("Added New Item Successfully")

        'Catch ex As Exception
        '    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'Finally
        '    DbConn.Close()

        'End Try

        'TxtId.Text = ""
        'TxtIName.Text = ""
        'TxtDesc.Text = ""
        'TxtQuan.Text = ""
        'ReceDate.Value = DateTime.Now
        'ComboCat.SelectedIndex = -1


        Try
            DbConn.Open()

            Dim query As String = "INSERT INTO item_details(category_id, category_name, item_id, item_name, description, quantity, received_date) VALUES (@category_id, @category_name, @item_id, @item_name, @description, @quantity, @received_date)"
            cmd = New MySqlCommand(query, DbConn)
            cmd.Parameters.AddWithValue("@category_id", TxtCatId.Text)
            cmd.Parameters.AddWithValue("@category_name", TxtCatName.Text)
            cmd.Parameters.AddWithValue("@item_id", TxtId.Text)
            cmd.Parameters.AddWithValue("@item_name", TxtIName.Text)
            cmd.Parameters.AddWithValue("@description", TxtDesc.Text)
            'cmd.Parameters.AddWithValue("@quantity", TxtQuan.Text)
            cmd.Parameters.AddWithValue("@received_date", ReceDate.Value)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data added to the table successfully.")

        Catch ex As Exception
            MessageBox.Show("An error occurred while inserting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            DbConn.Close()
        End Try

        ClearFields()
    End Sub

    Private Sub ClearFields()
        TxtCatId.Text = ""
        TxtCatName.Text = ""
        TxtId.Text = ""
        TxtIName.Text = ""
        TxtDesc.Text = ""
        'TxtQuan.Text = ""
        ReceDate.Value = DateTime.Now

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the form?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            TxtCatId.Text = ""
            TxtCatName.Text = ""
            TxtId.Text = ""
            TxtIName.Text = ""
            TxtDesc.Text = ""
            'TxtQuan.Text = ""
            ReceDate.Value = DateTime.Now
            'ComboCat.SelectedIndex = -1 ' Clear selection in ComboBox
        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    'Private Sub LoadData()
    '    Try
    '        DbConn.Open()

    '        Dim query As String = "SELECT * FROM item_details"
    '        cmd = New MySqlCommand(query, DbConn)
    '        da.SelectCommand = cmd
    '        dt.Clear()
    '        da.Fill(dt)

    '        ItemData.DataSource = dt

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)

    '    Finally
    '        DbConn.Close()

    '    End Try
    'End Sub

    'Private Sub ItemData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemData.CellContentClick
    '    If e.RowIndex >= 0 Then
    '        Dim row As DataGridViewRow = ItemData.Rows(e.RowIndex)
    '        ComboCat.SelectedItem = row.Cells("category_name").Value.ToString()
    '        TxtId.Text = row.Cells("item_id").Value.ToString()
    '        TxtIName.Text = row.Cells("item_name").Value.ToString()
    '        TxtDesc.Text = row.Cells("description").Value.ToString()
    '        TxtQuan.Text = row.Cells("quantity").Value.ToString()
    '        ReceDate.Text = row.Cells("received_date").Value.ToString()
    '    End If
    'End Sub

    Private Sub LoadData()
        Try
            DbConn.Open()

            Dim query As String = "SELECT * FROM item_details"
            cmd = New MySqlCommand(query, DbConn)
            da.SelectCommand = cmd
            dt.Clear() ' Clearing the DataTable before filling it might not be necessary in this context
            da.Fill(dt)

            ItemData.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            DbConn.Close()
        End Try
    End Sub

    Private Sub Item_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    'Private Sub TxtCatId_TextChanged(sender As Object, e As EventArgs) Handles TxtCatId.TextChanged

    '    If Not String.IsNullOrEmpty(TxtCatId.Text) Then
    '        Dim categoryId As Integer
    '        If Integer.TryParse(TxtCatId.Text, categoryId) Then
    '            ' categoryId is the entered category ID
    '            Try
    '                DbConn.Open()

    '                Dim query As String = "SELECT category_name FROM category WHERE category_id = @category_id"
    '                cmd = New MySqlCommand(query, DbConn)
    '                cmd.Parameters.AddWithValue("@category_id", categoryId)

    '                Dim categoryName As Object = cmd.ExecuteScalar()

    '                If categoryName IsNot Nothing Then
    '                    TxtCatName.Text = categoryName.ToString()
    '                Else
    '                    TxtCatName.Text = "" ' Clear the TextBox if no matching record found
    '                End If

    '            Catch ex As Exception
    '                MessageBox.Show("An error occurred while fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '            Finally
    '                DbConn.Close()
    '            End Try
    '        End If
    '    Else
    '        TxtCatName.Text = "" ' Clear the TextBox when the category ID is cleared
    '    End If
    'End Sub


    Private Sub TxtCatId_TextChanged(sender As Object, e As EventArgs) Handles TxtCatId.TextChanged
        ' Clear any previous validation message
        LblValidation.Text = ""

        If Not String.IsNullOrEmpty(TxtCatId.Text) Then
            Dim categoryId As Integer
            'catId.ToString()
            'Dim catId As String
            If Integer.TryParse(TxtCatId.Text, categoryId) Then
                Try
                    DbConn.Open()

                    Dim query As String = "SELECT category_name FROM category WHERE category_id = @category_id"
                    cmd = New MySqlCommand(query, DbConn)
                    cmd.Parameters.AddWithValue("@category_id", categoryId)

                    Dim categoryName As Object = cmd.ExecuteScalar()

                    If categoryName IsNot Nothing Then
                        TxtCatName.Text = categoryName.ToString()
                    Else
                        TxtCatName.Text = "" ' Clear the TextBox if no matching record found
                        LblValidation.Text = "This category does not exist."
                    End If

                Catch ex As Exception
                    MessageBox.Show("An error occurred while fetching data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Finally
                    DbConn.Close()
                End Try
            Else
                TxtCatName.Text = "" ' Clear the TextBox when the category ID is not a valid integer
            End If
        Else
            TxtCatName.Text = "" ' Clear the TextBox when the category ID is cleared
        End If
    End Sub

End Class
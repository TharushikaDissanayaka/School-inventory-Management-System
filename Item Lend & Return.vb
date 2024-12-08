Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Item_Lend___Return

    Dim DbConn As New MySqlConnection("host=localhost; user=root; password=; database= testing")
    Dim cmd As New MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader



    'Private Sub LoadCategoryComboBox()
    '    Dim dtb As New DataTable
    '    Dim dad As New MySqlDataAdapter("SELECT * FROM category", DbConn)
    '    dad.Fill(dtb)
    '    CmbLoadCategory.DataSource = dtb
    '    CmbLoadCategory.DisplayMember = "category_name"
    '    CmbLoadCategory.ValueMember = "category_id"
    'End Sub

    'Private Sub LoadCategoryComboBox()
    '    Try
    '        Dim dtb As New DataTable
    '        Dim dad As New MySqlDataAdapter("SELECT * FROM category", DbConn)
    '        dad.Fill(dtb)

    '        CmbLoadCategory.DataSource = dtb
    '        CmbLoadCategory.DisplayMember = "category_name"
    '        CmbLoadCategory.ValueMember = "category_id"
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub



    'Private Sub Loaditemidcombobox()
    '    Dim dtc As New DataTable
    '    Dim dada As New MySqlDataAdapter("select * from item_details where category_id=@categorycategory_id", DbConn)
    '    If CmbLoadCategory.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(CmbLoadCategory.SelectedValue.ToString()) Then
    '        dada.SelectCommand.Parameters.AddWithValue("@categorycategory_id", CmbLoadCategory.SelectedValue)
    '        dada.Fill(dtc)
    '    End If
    '    CmbLoadItemId.DataSource = dtc
    '    CmbLoadItemId.DisplayMember = "item_name"
    '    CmbLoadItemId.ValueMember = "item_id"
    'End Sub

    'Private Sub Cmbloadcategory_selectedvaluechanged(sender As Object, e As EventArgs) Handles CmbLoadCategory.SelectedValueChanged
    '    Loaditemidcombobox()

    '    'loaditemidcombobox()
    'End Sub

    'Private Sub Item_Lend___Return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    LoadCategoryComboBox()
    '    'LoadItemIdComboBox()
    'End Sub

    Private Sub LoadCategoryComboBox()
        Try
            Dim dtb As New DataTable
            Dim dad As New MySqlDataAdapter("SELECT * FROM category", DbConn)
            dad.Fill(dtb)

            CmbLoadCategory.DataSource = dtb
            CmbLoadCategory.DisplayMember = "category_name"
            CmbLoadCategory.ValueMember = "category_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Loaditemidcombobox()
        Dim dtc As New DataTable
        Dim dada As New MySqlDataAdapter("SELECT * FROM item_details WHERE category_id=@categorycategory_id", DbConn)

        If CmbLoadCategory.SelectedValue IsNot Nothing AndAlso Not String.IsNullOrEmpty(CmbLoadCategory.SelectedValue.ToString()) Then
            dada.SelectCommand.Parameters.AddWithValue("@categorycategory_id", CmbLoadCategory.SelectedValue)
            dada.Fill(dtc)
        End If

        CmbLoadItemId.DataSource = dtc
        CmbLoadItemId.DisplayMember = "item_id"
        CmbLoadItemId.ValueMember = "item_id"
    End Sub

    Private Sub Cmbloadcategory_selectedvaluechanged(sender As Object, e As EventArgs) Handles CmbLoadCategory.SelectedValueChanged
        Loaditemidcombobox()

    End Sub

    Private Sub Item_Lend_Return_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadCategoryComboBox()

        LoadBorrowerIdCombobox()
    End Sub

    Private Sub CmbLoadItemId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLoadItemId.SelectedIndexChanged
        Dim SelectedItemName As String = CmbLoadItemId.Text
        Dim query As String = "SELECT item_name FROM item_details WHERE item_id=@item_name"

        DbConn.Open()

        Using cmd As New MySqlCommand(query, DbConn)

            cmd.Parameters.AddWithValue("@item_name", SelectedItemName)

            Dim itemname As Object = cmd.ExecuteScalar()

            If itemname IsNot Nothing AndAlso Not DBNull.Value.Equals(itemname) Then
                TxtLoadItemName.Text = itemname
            Else
                TxtLoadItemName.Text = "Invalid"
            End If
        End Using

        DbConn.Close()

    End Sub

    Private Sub BtnCheckout_Click(sender As Object, e As EventArgs) Handles BtnCheckout.Click
        Try
            DbConn.Open()

            Dim query As String = "INSERT INTO item_borrow(category_name, item_id, item_name, user_id, user_name, borrow_note, borrow_date, return_date) VALUES (@category_name, @item_id, @item_name, @user_id, @user_name, @borrow_note, @borrow_date, @return_date)"
            cmd = New MySqlCommand(query, DbConn)
            cmd.Parameters.AddWithValue("@category_name", CmbLoadCategory.Text)
            cmd.Parameters.AddWithValue("@item_id", CmbLoadItemId.Text)
            cmd.Parameters.AddWithValue("@item_name", TxtLoadItemName.Text)
            cmd.Parameters.AddWithValue("@user_id", CmbLoadBorrowerId.Text)
            cmd.Parameters.AddWithValue("@user_name", TxtLoadBorrowerName.Text)
            cmd.Parameters.AddWithValue("@borrow_note", TxtBorrowNote.Text)
            cmd.Parameters.AddWithValue("@borrow_date", LblBorrowDate.Text)
            cmd.Parameters.AddWithValue("@return_date", ReturnDate.Value)

            cmd.ExecuteNonQuery()
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to Add this data?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                MessageBox.Show("Data added to the table successfully.")
            End If


        Catch ex As Exception
            MessageBox.Show("An error occurred while inserting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            DbConn.Close()
        End Try

        ClearFields()
    End Sub

    Private Sub ClearFields()
        CmbLoadCategory.Text = ""
        CmbLoadItemId.Text = ""
        TxtLoadItemName.Text = ""
        CmbLoadBorrowerId.Text = ""
        TxtLoadBorrowerName.Text = ""
        TxtBorrowNote.Text = ""


    End Sub

    Private Sub LoadBorrowerIdCombobox()
        Try
            Dim dtt As New DataTable
            Dim dat As New MySqlDataAdapter("SELECT * FROM user", DbConn)
            dat.Fill(dtt)

            CmbLoadBorrowerId.DataSource = dtt
            CmbLoadBorrowerId.DisplayMember = "user_id"
            CmbLoadBorrowerId.ValueMember = "user_id"
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub CmbLoadBorrowerId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbLoadBorrowerId.SelectedIndexChanged

        Dim SelectedBorrowerId As String = CmbLoadBorrowerId.Text
        Dim query As String = "SELECT user_name FROM user WHERE user_id = @user_id"

        Try
            DbConn.Open()

            Using cmd As New MySqlCommand(query, DbConn)
                cmd.Parameters.AddWithValue("@user_id", SelectedBorrowerId)

                Dim username As Object = cmd.ExecuteScalar()

                If username IsNot Nothing AndAlso Not DBNull.Value.Equals(username) Then
                    TxtLoadBorrowerName.Text = username.ToString()
                Else
                    TxtLoadBorrowerName.Text = "Invalid"
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If DbConn.State = ConnectionState.Open Then
                DbConn.Close()
            End If
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to clear the form?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            CmbLoadCategory.Text = ""
            CmbLoadItemId.Text = ""
            TxtLoadItemName.Text = ""
            CmbLoadBorrowerId.Text = ""
            TxtLoadBorrowerName.Text = ""
            TxtBorrowNote.Text = ""

        End If
    End Sub

    Private Sub BttnExit_Click(sender As Object, e As EventArgs) Handles BttnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub LblBorrowDate_Click(sender As Object, e As EventArgs) Handles LblBorrowDate.Click
        Dim currentDate As DateTime = DateTime.Today
        Console.WriteLine("Today's date: " & currentDate.ToShortDateString())
    End Sub
End Class

Imports Guna.UI.WinForms
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Module TOP_Module
    Private dbConn As MySqlConnection
    Private sqlCommand As MySqlCommand
    Private da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Private dt As DataTable
    Dim MDS As New MD5CryptoServiceProvider
    Dim des As New TripleDESCryptoServiceProvider

    Private strConn = "server=localhost; user=root; convert zero datetime=True; database="


    Public Sub dbConnection()
        Try
            dbConn = New MySqlConnection(strConn & "TOP_EFAS")
            'dbConn.ConnectionString = strConn
            dbConn.Open()
            'MessageBox.Show("Test connection successful")  
        Catch ex As Exception
            MessageBox.Show("Error 101: Db_Connection " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub _SQLManager(ByVal SQL As String)
        ' Accepts SQL-INSERT, UPDATE, DELETE and message 
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(SQL, dbConn)

            With sqlCommand
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 110: SQLManager()" & ex.Message)
        End Try
    End Sub

    Public Sub _load_to_chart(ByVal SQL As String)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(SQL, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read

            End While
            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

    End Sub

    Public Sub displayRecords(ByVal SQL As String, ByVal DG As DataGridView)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt) ' da.Fill(DG.DataSource)
            DG.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error 102: Db_displayRecords" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub loadToComboBox(ByVal SQL As String, ByVal cbo As ComboBox)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Function _displayRecords(ByVal SQL As String) As DataTable
        Try
            dbConn.Open()
            ' MessageBox.Show(SQL)
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt) ' da.Fill(DG.DataSource)

        Catch ex As Exception
            MessageBox.Show("Error 102: Db_displayRecords" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return dt
    End Function

    Public Sub SQLProcess(ByVal Sql As String)
        Try
            dbConn.Open()
            'MessageBox.Show(Sql)
            sqlCommand = New MySqlCommand
            With sqlCommand
                .CommandText = Sql
                .CommandType = CommandType.Text
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("Error 103: SQL Process" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Function SQLUpdateProcess(ByVal Sql As String) As Boolean
        Dim success = False
        Try

            dbConn.Open()
            'MessageBox.Show(Sql)
            sqlCommand = New MySqlCommand
            With sqlCommand
                .CommandText = Sql
                .CommandType = CommandType.Text
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            success = True
        Catch ex As Exception
            MessageBox.Show("Error 1062: Contract Already Exists!" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return success
    End Function

    Public Function recordCount(ByVal SQL As String)
        Dim row = 0
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            row = dt.Rows.Count
            MessageBox.Show(row)
        Catch ex As Exception
            MessageBox.Show("Error 102: Db_displayRecords" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return row
    End Function

    Public Function isFound(ByVal SQL As String, ByVal name As String) As Boolean
        Dim value = ""
        Dim found = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                value = row.Item(1)
                If value = name Then
                    found = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error 104: isFound" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return found
    End Function
    Public Function isFound(ByVal SQL As String, ByVal id As String, ByVal fname As String) As Boolean
        Dim found = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            Dim value = "", add = ""
            Dim row As DataRow
            For Each row In dt.Rows
                value = row.Item("fname")
                add = row.Item("lname")

                If value = id And add = fname Then
                    found = True
                    Exit For
                End If
            Next
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 104: isFound" & ex.Message)
        End Try
        Return found
    End Function

    Public Function _readLastRecordString(ByVal SQL As String, ByVal column As String) As String
        ' read the last record or value through a column of a table
        Dim count = 0
        Dim value = ""
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            count = dt.Rows.Count - 1
            value = dt.Rows(count).Item(column)
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 106: ReadLastRecord" & ex.Message)
        End Try
        Return value


    End Function

    Public Function _readValue(ByVal SQL As String, ByVal selcol1 As String) As String
        ' reads a specific value from your table for manipulation or use for condition
        Dim count = 0
        Dim value = ""
        Try
            dbConn.Open()
            'MessageBox.Show(SQL)
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            count = dt.Rows.Count - 1
            value = dt.Rows(count).Item(selcol1).ToString
            dbConn.Close()
        Catch ex As Exception
            'MessageBox.Show("Error 108: readValue()" & ex.Message)
        End Try
        Return value
    End Function

    'FUNCTION FOR GETTING THE FIRST NAME
    Public Function _get_fname(ByVal SQL As String, ByVal fname As String) As String
        Dim count = 0
        Dim value = ""
        Try
            dbConn.Open()
            'MessageBox.Show(SQL)
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            count = dt.Rows.Count - 1
            value = dt.Rows(count).Item(fname).ToString
            dbConn.Close()
        Catch ex As Exception
            'MessageBox.Show("Error 108: readValue()" & ex.Message)
        End Try
        Return value
    End Function

    'FUNCTION FOR GETTING THE LAST NAME
    Public Function _get_lname(ByVal SQL As String, ByVal lname As String) As String
        Dim count = 0
        Dim value = ""
        Try
            dbConn.Open()
            'MessageBox.Show(SQL)
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            count = dt.Rows.Count - 1
            value = dt.Rows(count).Item(lname).ToString
            dbConn.Close()
        Catch ex As Exception
            'MessageBox.Show("Error 108: readValue()" & ex.Message)
        End Try
        Return value
    End Function

    Public Function _get_fname_lname(ByVal SQL As String, ByVal fname As String, ByVal lname As String) As String
        Dim count = 0
        Dim value = ""
        Try
            dbConn.Open()
            'MessageBox.Show(SQL)
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            count = dt.Rows.Count - 1
            value = dt.Rows(count).Item(fname).ToString
            value = dt.Rows(count).Item(lname).ToString
            dbConn.Close()
        Catch ex As Exception
            'MessageBox.Show("Error 108: readValue()" & ex.Message)
        End Try
        Return value
    End Function

    Public Function _get_value(ByVal SQL As String, ByVal val As String) As String
        Dim count = 0
        Dim value = ""
        Try
            dbConn.Open()
            'MessageBox.Show(SQL)
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            count = dt.Rows.Count - 1
            value = dt.Rows(count).Item(val).ToString
            dbConn.Close()
        Catch ex As Exception
            'MessageBox.Show("Error 108: readValue()" & ex.Message)
        End Try
        Return value
    End Function

    Public Function _isValid(ByVal SQL As String, ByVal columnUN As String, ByVal columnPass As String, ByVal username As String, ByVal pass As String) As Boolean
        Dim valid As Boolean = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            Dim data As DataRow
            Dim strUsername = "", strPassword = ""


            For Each data In dt.Rows
                strUsername = data.Item(columnUN)
                strPassword = data.Item(columnPass)

                If strUsername = username And strPassword = pass Then
                    valid = True
                    Exit For
                End If
            Next
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 107: isValid-Login" & ex.Message)
        End Try
        Return valid
    End Function

    Public Function _isValidAccount(ByVal SQL As String, ByVal columnUN As String, ByVal columnPass As String, ByVal username As String, ByVal pass As String) As Boolean
        Dim valid As Boolean = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            Dim data As DataRow
            Dim strUsername = "", strPassword = ""


            For Each data In dt.Rows
                strUsername = data.Item(columnUN)
                strPassword = data.Item(columnPass)

                If strUsername = username And strPassword = pass Then
                    valid = True
                    Exit For
                End If
            Next
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 107: isValid-Login" & ex.Message)
        End Try
        Return valid
    End Function

    Public Function _isValid_Password(ByVal SQL As String, ByVal password As String, ByVal emp_pass As String) As Boolean
        Dim valid As Boolean = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            Dim data As DataRow
            Dim strID = ""

            For Each data In dt.Rows
                strID = data.Item(password)

                If strID = emp_pass Then
                    valid = True
                    Exit For
                End If
            Next
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 107: isValid-Login" & ex.Message)
        End Try
        Return valid
    End Function

    Public Function _isFound_School_ID(ByVal SQL As String, ByVal ID As String, ByVal stud_id As String) As Boolean
        Dim valid As Boolean = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            Dim data As DataRow
            Dim strID = ""

            For Each data In dt.Rows
                strID = data.Item(ID)

                If strID = stud_id Then
                    valid = True
                    Exit For
                End If
            Next
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 107: isValid-Login" & ex.Message)
        End Try
        Return valid
    End Function

    Public Function _isFound(ByVal SQL As String, ByVal value As String, ByVal val As String) As Boolean
        Dim valid As Boolean = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            Dim data As DataRow
            Dim strID = ""

            For Each data In dt.Rows
                strID = data.Item(value)

                If strID = val Then
                    valid = True
                    Exit For
                End If
            Next
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 107: isValid-Login" & ex.Message)
        End Try
        Return valid
    End Function

    Public Function _isFound_Password(ByVal SQL As String, ByVal password As String, ByVal pass As String) As Boolean
        Dim valid As Boolean = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            Dim data As DataRow
            Dim strID = ""

            For Each data In dt.Rows
                strID = data.Item(password)

                If strID = pass Then
                    valid = True
                    Exit For
                End If
            Next
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 107: isValid-Login" & ex.Message)
        End Try
        Return valid
    End Function


    Public Sub _loadToComboBox(ByVal SQL As String, ByVal cbo As ComboBox, ByVal display As String, ByVal value As String)
        'Accepts SQL SELECT , a comboBox name with value to display and as a member 
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            'MessageBox.Show(SQL)
            dt = New DataTable
            da.Fill(dt)
            ' cbo = New ComboBox
            cbo.DataSource = dt
            cbo.DisplayMember = dt.Columns(display).ToString
            cbo.ValueMember = dt.Columns(value).ToString
            'MessageBox.Show(SQL)
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 112: LoadToComboBox()" & ex.Message)
        End Try
    End Sub

    'ENCRYPTION
    Public Function Encrypt(text As String, col_name As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Dim hash(31) As Byte
        Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(col_name))
        Array.Copy(temp, 0, hash, 0, 16)
        Array.Copy(temp, 0, hash, 15, 16)
        AES.Key = hash
        AES.Mode = Security.Cryptography.CipherMode.ECB
        Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
        Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(text)
        encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Return encrypted
    End Function

    'DECRYPTION
    Public Function Decrypt(text As String, col_name As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Dim hash(31) As Byte
        Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(col_name))
        Array.Copy(temp, 0, hash, 0, 16)
        Array.Copy(temp, 0, hash, 15, 16)
        AES.Key = hash
        AES.Mode = Security.Cryptography.CipherMode.ECB
        Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
        Dim Buffer As Byte() = Convert.FromBase64String(text)
        decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
        Return decrypted
    End Function


End Module



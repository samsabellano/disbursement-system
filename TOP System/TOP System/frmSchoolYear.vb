Public Class frmSchoolYear
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Dim SY_FROM As String
    Dim SY_TO As String
    Dim SY As String
    Private Sub frmSchoolYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        displayRecords("SELECT SY_ID, SY_DESCRIPTION FROM EFAS_SCHOOL_YEAR;", DG_SCHOOL_YEAR)
        Me.Size = New Size(385, 441)
    End Sub

    Private Sub BTN_CLOSE_Click(sender As Object, e As EventArgs) Handles BTN_CLOSE.Click
        Me.Close()
        BTN_OTHER_UPDATE.Show()
        Me.Size = New Size(385, 441)
    End Sub

    Private Sub BTN_OTHER_UPDATE_Click(sender As Object, e As EventArgs) Handles BTN_OTHER_UPDATE.Click
        Me.Size = New Size(702, 441)
        BTN_OTHER_UPDATE.Hide()
    End Sub

    Private Sub TXT_SY_FROM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_SY_FROM.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MsgBox("Ops! Only numbers are allowed.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TXT_SY_TO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_SY_TO.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MsgBox("Ops! Only numbers are allowed.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BTN_CONTINUE_Click(sender As Object, e As EventArgs) Handles BTN_CONTINUE.Click
        SY_FROM = TXT_SY_FROM.Text
        SY_TO = TXT_SY_TO.Text
        SY = SY_FROM + "-" + SY_TO

        Dim val_sy = _get_value("SELECT SY_DESCRIPTION FROM EFAS_SCHOOL_YEAR", "SY_DESCRIPTION")
        If TXT_SY_FROM.Text = Nothing Or TXT_SY_TO.Text = Nothing Then
            MsgBox("Ops! Please enter a year in the field.", MsgBoxStyle.Information)
        ElseIf TXT_SY_FROM.Text < 2010 Or TXT_SY_TO.Text < 2010 Then
            MsgBox("Invalid School Year. Past School is not allowed.", MsgBoxStyle.Information)
        ElseIf TXT_SY_FROM.Text = TXT_SY_TO.Text Then
            MsgBox("Year should not be the same.")
            TXT_SY_FROM.ResetText()
            TXT_SY_TO.ResetText()
        ElseIf val_sy = SY Then
            MsgBox("This School Year is already exist", MsgBoxStyle.Information)
            TXT_SY_FROM.ResetText()
            TXT_SY_TO.ResetText()
        ElseIf TXT_SY_FROM.Text.Length <= 3 Or TXT_SY_TO.Text.Length <= 3 Then
            MsgBox("School year must contain 4 digits.", MsgBoxStyle.Information)
        Else
            Dim sql_add_SY = "INSERT INTO EFAS_SCHOOL_YEAR VALUES(null, '" & SY & "');"
            SQLProcess(sql_add_SY)
            MsgBox("School Year was successfully added.", vbInformation)
            displayRecords("SELECT SY_ID, SY_DESCRIPTION FROM EFAS_SCHOOL_YEAR;", DG_SCHOOL_YEAR)
            TXT_SY_FROM.ResetText()
            TXT_SY_TO.ResetText()
        End If

    End Sub

    Private Sub PNL_HEADER_MouseDown(sender As Object, e As MouseEventArgs) Handles PNL_HEADER.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PNL_HEADER_MouseMove(sender As Object, e As MouseEventArgs) Handles PNL_HEADER.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub

    Private Sub PNL_HEADER_MouseUp(sender As Object, e As MouseEventArgs) Handles PNL_HEADER.MouseUp
        draggable = False
    End Sub
End Class

Imports System.Data
Imports System.Data.OleDb
Imports System.Math
Imports Microsoft.Office.Interop
Public Class Back_End

#Region "FORM CLOSE and MINIMIZE BUTTON"

    Private Sub PictureBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.MouseHover
        Btnclose.BackColor = Color.Gray
    End Sub

    Private Sub Btnclose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.MouseLeave
        Btnclose.BackColor = Color.Black
    End Sub

    Private Sub Btnmin_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.MouseHover
        Btnmin.BackColor = Color.Gray
    End Sub

    Private Sub Btnmin_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.MouseLeave
        Btnmin.BackColor = Color.Black
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
        Front_End.MdiParent = Main
        Front_End.Show()
    End Sub

    Private Sub Btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "Buttons Up"

    Private Sub btnshutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnshutdown.Click
        End
    End Sub

    Private Sub btnlogoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogoff.Click
        Me.Close()
        Front_End.MdiParent = Main
        Front_End.Show()
    End Sub

    Private Sub btnadmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadmin.Click
        frmadmin.ShowDialog()
    End Sub

#End Region

#Region "Shortcuts"

    Private Sub toollogoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toollogoff.Click
        btnlogoff_Click(sender, e)
    End Sub

    Private Sub toolshutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolshutdown.Click
        btnshutdown_Click(sender, e)
    End Sub

    Private Sub ToolUserlist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolUserlist.Click
        MainTab.SelectedTab = TabItem1
    End Sub

    Private Sub ToolUserform_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolUserform.Click
        MainTab.SelectedTab = TabItem2
    End Sub

    Private Sub ToolLogsHistory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolLogsHistory.Click
        MainTab.SelectedTab = TabItem3
    End Sub

    Private Sub ToolAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolAbout.Click
        MainTab.SelectedTab = TabItem4
    End Sub

#End Region

#Region "Declaration"
    'Public Conn As OleDbConnection

    'TAB 1 Declaration
    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Dbase\UTIS.mdb;Persist Security Info=False"
    Dim eDS0 As DataSet = New DataSet
    Dim eDA0 As OleDbDataAdapter = New OleDbDataAdapter
    Dim eCB0 As OleDb.OleDbCommandBuilder
    Dim eDR0 As DataRow
    Public iCountRecord As Integer
    Public iCurrentRecord As Integer
    Dim X As Integer

    'TAB 2 Declaration
    Public sConn0 As OleDbConnection

    'TAB 3 Declaration
    Dim dDS As DataSet = New DataSet
    Dim dDA As OleDbDataAdapter = New OleDbDataAdapter
    Dim dCB As OleDb.OleDbCommandBuilder
    Dim dDR As DataRow
#End Region

    Private Sub Back_End_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TAB 1 LoAD
        Load_User()
        Load_Logs("SELECT * FROM tblDTR order by date_timein DESC")

        'TAB 2 LOAD
        If Me.dtgUser.SelectedRows.Count > 0 Then
            Load_Userform()
            Read_Only_Controls()
            btnnewuser.Text = "New"
            btnedituser.Text = "Edit"
            btnchangepass.Enabled = False
        End If

        'TAB 3 LOAD
        MonthCalendar.TodayDate = Now
        MonthCalendar.MaxDate = Now

    End Sub

#Region "Tab 1 - User Procedure"

    Private Sub Load_User()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable
        Dim sSQL As String = String.Empty

        'try catch block is used to catch the error
        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            sSQL = "SELECT * FROM tbluser"

            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)

            Me.dtgUser.DataSource = dt
            If dt.Rows.Count = 0 Then
                MsgBox("No record found!")
            End If
            Me.lbluser.Text = "Number of Users: " & dtgUser.RowCount
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Function SearchUserid()
        Dim da As OleDbDataAdapter
        Dim dsetorder As New DataSet
        Try
            Using connstring As New OleDbConnection(constring)
                If txtsearchuser.Text <> "" Then
                    da = New OleDbDataAdapter("SELECT * " & _
                                              "from tbluser " & _
                                              "where user_idno like '" & txtsearchuser.Text & "%' ", connstring)

                    dsetorder = New DataSet
                    da.Fill(dsetorder, "tbluser")
                    dtgUser.DataSource = dsetorder.Tables("tbluser").DefaultView
                    Me.lbluser.Text = "Number of Users: " & dtgUser.RowCount
                Else
                    Call Load_User()
                End If
            End Using
        Catch ex As Exception
        End Try
        Return True
    End Function

    Function SearchUsername()
        Dim da As OleDbDataAdapter
        Dim dsetorder As New DataSet
        Try
            Using connstring As New OleDbConnection(constring)
                If txtsearchuser.Text <> "" Then
                    da = New OleDbDataAdapter("SELECT * " & _
                                              "from tbluser " & _
                                              "where user_fname like '" & txtsearchuser.Text & "%' " & _
                                              "OR user_lname like '" & txtsearchuser.Text & "%' " & _
                                              "OR user_mname like '" & txtsearchuser.Text & "%' ", connstring)

                    dsetorder = New DataSet
                    da.Fill(dsetorder, "tbluser")
                    dtgUser.DataSource = dsetorder.Tables("tbluser").DefaultView
                    Me.lbluser.Text = "Number of Users: " & dtgUser.RowCount
                Else
                    Call Load_User()
                End If
            End Using
        Catch ex As Exception
        End Try
        Return True
    End Function

    Function SearchUseraddr()
        Dim da As OleDbDataAdapter
        Dim dsetorder As New DataSet
        Try
            Using connstring As New OleDbConnection(constring)
                If txtsearchuser.Text <> "" Then
                    da = New OleDbDataAdapter("SELECT * " & _
                                              "from tbluser " & _
                                              "where user_addr like '" & txtsearchuser.Text & "%' ", connstring)

                    dsetorder = New DataSet
                    da.Fill(dsetorder, "tbluser")
                    dtgUser.DataSource = dsetorder.Tables("tbluser").DefaultView
                    Me.lbluser.Text = "Number of Users: " & dtgUser.RowCount
                Else
                    Call Load_User()
                End If
            End Using
        Catch ex As Exception
        End Try
        Return True
    End Function

    Function SearchUserpos()
        Dim da As OleDbDataAdapter
        Dim dsetorder As New DataSet
        Try
            Using connstring As New OleDbConnection(constring)
                If txtsearchuser.Text <> "" Then
                    da = New OleDbDataAdapter("SELECT * " & _
                                              "from tbluser " & _
                                              "where user_pos like '" & txtsearchuser.Text & "%' ", connstring)

                    dsetorder = New DataSet
                    da.Fill(dsetorder, "tbluser")
                    dtgUser.DataSource = dsetorder.Tables("tbluser").DefaultView
                    Me.lbluser.Text = "Number of Users: " & dtgUser.RowCount
                Else
                    Call Load_User()
                End If
            End Using
        Catch ex As Exception
        End Try
        Return True
    End Function

#End Region

#Region "Tab 2 - User Form Procedure"

    Private Sub Load_Userform()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim arrImage() As Byte
        Dim myMS As New IO.MemoryStream

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from tblUser where user_idno = '" & Me.dtgUser.Item(0, Me.dtgUser.CurrentRow.Index).Value & "'"

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtuseridno.Tag = IIf(Not IsDBNull(dr("user_idno")), dr("user_idno"), "")
                    Me.txtuseridno.Text = IIf(Not IsDBNull(dr("user_idno")), dr("user_idno"), "")
                    Me.lblpass.Text = IIf(Not IsDBNull(dr("user_pass")), dr("user_pass"), "")
                    Me.txtfname.Text = IIf(Not IsDBNull(dr("user_fname")), dr("user_fname"), "")
                    Me.txtmname.Text = IIf(Not IsDBNull(dr("user_mname")), dr("user_mname"), "")
                    Me.txtlname.Text = IIf(Not IsDBNull(dr("user_lname")), dr("user_lname"), "")
                    If Not IsDBNull(dr("user_img")) Then
                        arrImage = dr("user_img")
                        For Each ar As Byte In arrImage
                            myMS.WriteByte(ar)
                        Next
                        Me.Userpic.Image = System.Drawing.Image.FromStream(myMS)
                    Else
                        Userpic.Image = Login.My.Resources.admin
                    End If
                    Me.txtaddr.Text = IIf(Not IsDBNull(dr("user_addr")), dr("user_addr"), "")
                    Me.txtdob.Value = IIf(Not IsDBNull(dr("user_dob")), dr("user_dob"), "")
                    Me.txtage.Text = IIf(Not IsDBNull(dr("user_age")), dr("user_age"), "")
                    Me.txtpos.Text = IIf(Not IsDBNull(dr("user_pos")), dr("user_pos"), "")
                    If dr("user_stat") = "perm" Then
                        Me.txtstat.Text = "Permanent"
                    ElseIf dr("user_stat") = "cont" Then
                        Me.txtstat.Text = "Contractual"
                    Else
                        Me.txtstat.Text = IIf(Not IsDBNull(dr("user_stat")), dr("user_stat"), "")
                    End If
                End While
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Clear_userform()
        txtuseridno.Clear()
        txtfname.Clear()
        txtmname.Clear()
        txtlname.Clear()
        txtaddr.Clear()
        txtdob.Value = Date.Now
        txtage.Clear()
        txtpos.Clear()
        txtstat.Text = ""
    End Sub

    Private Sub Read_Only_Controls()
        txtuseridno.ReadOnly = True
        txtfname.ReadOnly = True
        txtmname.ReadOnly = True
        txtlname.ReadOnly = True
        txtaddr.ReadOnly = True
        txtdob.Enabled = False
        txtpos.ReadOnly = True
        txtstat.Enabled = False
        Userpic.Enabled = False
    End Sub

    Private Sub Read_Controls()
        txtuseridno.ReadOnly = False
        txtfname.ReadOnly = False
        txtmname.ReadOnly = False
        txtlname.ReadOnly = False
        txtaddr.ReadOnly = False
        txtdob.Enabled = True
        txtpos.ReadOnly = False
        txtstat.Enabled = True
        Userpic.Enabled = True
    End Sub

    Private Sub Delete_User()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty


        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = "delete from tbluser where user_idno = @id"

            cmd.Parameters.Add("@id", OleDbType.Numeric).Value = Me.txtuseridno.Tag
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Save_User()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty
        Dim arrImage() As Byte
        Dim myMs As New IO.MemoryStream
        Dim bSaveImage As Boolean = False
        Dim strImg As String = String.Empty

        Try
            If Not IsNothing(Me.Userpic.Image) Then
                Me.Userpic.Image.Save(myMs, Me.Userpic.Image.RawFormat)
                arrImage = myMs.GetBuffer
            Else
                arrImage = Nothing
            End If
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            'I just use the textbox tag property to idetify if the data is new or existing.
            If Me.txtuseridno.Tag = "" Then
                sSQL = "INSERT INTO tbluser (user_pass, user_fname, user_lname, user_mname, user_addr, user_dob, user_age, user_pos, user_stat, user_img, user_idno)"
                sSQL = sSQL & "  VALUES('password', @user_fname, @user_lname, @user_mname, @user_addr, @user_dob, @user_age, @user_pos, @user_stat, @user_img, @id)"
                cmd.CommandText = sSQL
            Else
                sSQL = "UPDATE tbluser set user_fname = @user_fname, user_lname = @user_lname, user_mname = @user_mname, user_addr = @user_addr, user_dob = @user_dob, user_age = @user_age, user_pos = @user_pos, user_stat = @user_stat, user_img = @user_img where user_idno = @id"
                cmd.CommandText = sSQL
            End If

            cmd.Parameters.Add("@user_fname", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtfname.Text)) > 0, Me.txtfname.Text, DBNull.Value)
            cmd.Parameters.Add("@user_lname", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtlname.Text)) > 0, Me.txtlname.Text, DBNull.Value)
            cmd.Parameters.Add("@user_mname", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtmname.Text)) > 0, Me.txtmname.Text, DBNull.Value)
            cmd.Parameters.Add("@user_addr", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtaddr.Text)) > 0, Me.txtaddr.Text, DBNull.Value)
            cmd.Parameters.Add("@user_dob", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtdob.Text)) > 0, Me.txtdob.Text, DBNull.Value)
            cmd.Parameters.Add("@user_age", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtage.Text)) > 0, Me.txtage.Text, DBNull.Value)
            cmd.Parameters.Add("@user_pos", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtpos.Text)) > 0, Me.txtpos.Text, DBNull.Value)
            cmd.Parameters.Add("@user_stat", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtstat.Text)) > 0, Me.txtstat.Text, DBNull.Value)
            cmd.Parameters.Add("@user_img", OleDbType.Binary).Value = IIf(Not IsNothing(arrImage), arrImage, DBNull.Value)
            cmd.Parameters.Add("@id", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtuseridno.Text)) > 0, Me.txtuseridno.Text, DBNull.Value)

            cmd.ExecuteNonQuery()

            'If the record is new then we have to get its ID so that we can edit it rightaway after the insertion.
            If Me.txtuseridno.Tag = "" Then
                cmd.CommandText = "Select @@Identity"
                'Set textbox tag property with the ID of new record
                Me.txtuseridno.Tag = cmd.ExecuteScalar()
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
            Load_User()
        End Try
    End Sub

    Private Sub Save_Pass()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty
        Dim strImg As String = String.Empty

        'Try
        'get connection string declared in the Module1.vb and assing it to conn variable
        conn = New OleDbConnection(constring)
        conn.Open()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        sSQL = "UPDATE tbluser set user_pass = @user_pass where user_idno = @id"
        cmd.CommandText = sSQL

        cmd.Parameters.Add("@user_pass", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtnewpass.Text)) > 0, Me.txtnewpass.Text, DBNull.Value)
        cmd.Parameters.Add("@id", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtuseridno.Text)) > 0, Me.txtuseridno.Text, DBNull.Value)

        cmd.ExecuteNonQuery()

        'If the record is new then we have to get its ID so that we can edit it rightaway after the insertion.
        If Me.txtuseridno.Tag = "" Then
            cmd.CommandText = "Select @@Identity"
            'Set textbox tag property with the ID of new record
            Me.txtuseridno.Tag = cmd.ExecuteScalar()
        End If

        'Catch ex As Exception
        '    MsgBox(ErrorToString)
        'Finally
        conn.Close()
        Load_User()
        'End Try
    End Sub

#End Region

#Region "Tab 3 - Logs Procedure"

    Private Function Load_Logs(ByVal sSQL As String)
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim da As New OleDbDataAdapter
        Dim dt As New DataTable

        'try catch block is used to catch the error
        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            cmd.CommandText = sSQL
            da.SelectCommand = cmd
            da.Fill(dt)

            Me.dtglogs.DataSource = dt
            If dt.Rows.Count = 0 Then
            End If
            Me.lbllogs.Text = "Number of logs: " & dtglogs.RowCount
        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try

    End Function

    Sub FilterLogs()
        If RdAlldate.Checked Then
            Load_Logs("SELECT * FROM tblDTR order by date_timein DESC")
            MonthCalendar.Enabled = False
            txtuseridlog.Enabled = False
        ElseIf RdDateSelected.Checked Then
            Load_Logs("SELECT * FROM tblDTR WHERE date_timein>=#" & MonthCalendar.SelectionStart & "# AND date_timein<=#" & MonthCalendar.SelectionEnd & "#" & " order by date_timein DESC")
            MonthCalendar.Enabled = True
            txtuseridlog.Enabled = False
        ElseIf RdUserID.Checked Then
            txtuseridlog.Focus()
            Load_Logs("SELECT * FROM tblDTR WHERE user_idno='" & txtuseridlog.Text & "' order by date_timein DESC")
            MonthCalendar.Enabled = False
            txtuseridlog.Enabled = True
        End If
    End Sub

#End Region

#Region "Tab 1 - User Events"

    Private Sub txtsearchuser_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtsearchuser.TextChanged
        SearchUsername()
        If txtsearchbyuser.Text = "ID" Then
            SearchUserid()
        ElseIf txtsearchbyuser.Text = "Name" Then
            SearchUsername()
        ElseIf txtsearchbyuser.Text = "Address" Then
            SearchUseraddr()
        ElseIf txtsearchbyuser.Text = "Position" Then
            SearchUserpos()
        End If
    End Sub

    Private Sub dtgUser_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtgUser.CellClick
        If Me.dtgUser.SelectedRows.Count > 0 Then
            Load_Userform()
            Read_Only_Controls()
            btnnewuser.Text = "New"
            btnedituser.Text = "Edit"
            btnchangepass.Enabled = False
        End If
    End Sub

    Private Sub dtgUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgUser.DoubleClick
        MainTab.SelectedTab = TabItem2
        btnedituser_Click(sender, e)
    End Sub

#End Region

#Region "Tab 2 - Userform Events"

    Private Sub btnchangepass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchangepass.Click
        GrpPassword.Enabled = True
    End Sub

    Private Sub btnnewuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnewuser.Click
        'BUTTONS ENABLED
        If btnnewuser.Text = "New" Then
            Read_Controls()
            Clear_userform()
            btnnewuser.Text = "Save"
            btnedituser.Text = "Cancel"
            btnchangepass.Enabled = False
            Me.txtuseridno.Tag = ""
            Me.Userpic.Image = Login.My.Resources.admin

        ElseIf btnnewuser.Text = "Save" Then

            Dim res As New DialogResult

            res = MsgBox("Do you want to save data?", MsgBoxStyle.YesNo, "Save")
            If res = DialogResult.Yes Then
                If Len(Trim(Me.txtuseridno.Text)) > 0 And Len(Trim(Me.txtfname.Text)) > 0 And Len(Trim(Me.txtmname.Text)) > 0 And Len(Trim(Me.txtlname.Text)) > 0 And Len(Trim(Me.txtaddr.Text)) > 0 And Len(Trim(Me.txtage.Text)) > 0 And Len(Trim(Me.txtpos.Text)) > 0 And Len(Trim(Me.txtstat.Text)) > 0 Then
                    Read_Only_Controls()
                    btnnewuser.Text = "New"
                    btnedituser.Text = "Edit"
                    btnchangepass.Enabled = False
                    Save_User()
                    MessageBox.Show("New User has been Created. Password: password", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MsgBox("All Fields are required.")
                End If

            End If

        ElseIf btnnewuser.Text = "Update" Then

            Dim res As New DialogResult

            res = MsgBox("Do you want to update data?", MsgBoxStyle.YesNo, "Update")
            If res = DialogResult.Yes Then
                If Len(Trim(Me.txtuseridno.Text)) > 0 And Len(Trim(Me.txtfname.Text)) > 0 And Len(Trim(Me.txtmname.Text)) > 0 And Len(Trim(Me.txtlname.Text)) > 0 And Len(Trim(Me.txtaddr.Text)) > 0 And Len(Trim(Me.txtage.Text)) > 0 And Len(Trim(Me.txtpos.Text)) > 0 And Len(Trim(Me.txtstat.Text)) > 0 Then
                    Read_Only_Controls()
                    btnnewuser.Text = "New"
                    btnedituser.Text = "Edit"
                    btnchangepass.Enabled = False
                    Save_User()
                Else
                    MsgBox("All Fields are required")
                End If

            End If
        End If

    End Sub

    Private Sub btnedituser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnedituser.Click
        If btnedituser.Text = "Cancel" Then
            btnnewuser.Text = "New"
            btnedituser.Text = "Edit"
            btnchangepass.Enabled = False
            Read_Only_Controls()
            txtuseridno.Enabled = True
            If Me.dtgUser.SelectedRows.Count > 0 Then
                Load_Userform()
            End If
        ElseIf btnedituser.Text = "Edit" Then
            btnnewuser.Text = "Update"
            btnedituser.Text = "Cancel"
            btnchangepass.Enabled = True
            Read_Controls()
            txtuseridno.Enabled = False
            If Me.dtgUser.SelectedRows.Count > 0 Then
                Load_Userform()
            End If
        End If
    End Sub

    Private Sub btndeleteuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeleteuser.Click
        Dim res As New DialogResult

        res = MsgBox("Do you want to delete data?", MsgBoxStyle.YesNo, "Delete")
        If res = DialogResult.Yes Then
            Delete_User()
            Clear_userform()
            Load_User()
        End If
    End Sub

    Private Sub txtdob_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtdob.ValueChanged
        Dim iDOB As Integer
        iDOB = CInt(DateDiff(DateInterval.Year, txtdob.Value, Now) / 4)
        txtage.Text = Floor((DateDiff(DateInterval.Day, txtdob.Value, Now) - iDOB) / 365)
    End Sub

    Private Sub Userpic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Userpic.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Me.lblPath.Text = OpenFileDialog1.FileName
        Me.Userpic.ImageLocation = Me.lblPath.Text
    End Sub

    Private Sub btnpasscancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasscancel.Click
        GrpPassword.Enabled = False
        txtoldpass.Clear()
        txtnewpass.Clear()
        txtconfirmpass.Clear()
    End Sub

    Private Sub btnpasschange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpasschange.Click
        If txtoldpass.Text <> "" And txtoldpass.Text = lblpass.Text Then
            If txtnewpass.Text <> "" And txtconfirmpass.Text <> "" And txtnewpass.Text = txtconfirmpass.Text Then
                Save_Pass()
                GrpPassword.Enabled = False
                txtoldpass.Clear()
                txtnewpass.Clear()
                txtconfirmpass.Clear()
            Else
                MessageBox.Show("The new passwords entered is not identical.", "Unidentical Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("The old password entered is Invalid.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtoldpass.Focus()
        End If
    End Sub

#End Region

#Region "Tab 3 - Logs Events"

    Private Sub MonthCalendar_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateChanged
        If RdDateSelected.Checked Then
            Load_Logs("SELECT * FROM tblDTR WHERE date_timein>=#" & MonthCalendar.SelectionStart & "# AND date_timein<=#" & MonthCalendar.SelectionEnd & "#")
        End If
    End Sub

    Private Sub RdAlldate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdAlldate.CheckedChanged
        FilterLogs()
    End Sub

    Private Sub RdDateSelected_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdDateSelected.CheckedChanged
        FilterLogs()
    End Sub

    Private Sub txtuseridlog_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuseridlog.TextChanged
        Load_Logs("SELECT * FROM tblDTR WHERE user_idno='" & txtuseridlog.Text & "' order by date_timein DESC")
    End Sub

    Private Sub btnexport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexport.Click
        If dtglogs.RowCount = Nothing Then
            MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim rowsTotal, colsTotal As Short
        Dim I, j, iC As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application

        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            xlApp.Visible = True

            rowsTotal = dtglogs.RowCount
            colsTotal = dtglogs.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = dtglogs.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = dtglogs.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12

                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub

    Private Sub btndeletealllog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeletealllog.Click
        Try
            If dtglogs.Rows.Count > 0 Then
                If MessageBox.Show("Are you sure want to delete all logs?", "CONFIRMATION", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    Using conn As New OleDbConnection(constring)
                        conn.Open()
                        Dim command As New OleDbCommand("delete * from tblDTR", conn)
                        command.ExecuteNonQuery()
                        command.Dispose()
                        conn.Close()
                    End Using
                    Load_Logs("SELECT * FROM tblDTR order by date_timein DESC")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR12", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Context Menu"

    Private Sub Toolreload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toolreload.Click
        Load_User()
    End Sub

    Private Sub ContextNewuser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextNewuser.Click
        MainTab.SelectedTab = TabItem2
        btnnewuser_Click(sender, e)
    End Sub

    Private Sub ContextEditUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextEditUser.Click
        MainTab.SelectedTab = TabItem2
        btnedituser_Click(sender, e)
    End Sub

    Private Sub ContextDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContextDeleteUser.Click
        btndeleteuser_Click(sender, e)
    End Sub

    Private Sub ToolPanelScale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolPanelScale.Click
        If SplitContainer1.Panel1Collapsed = False Then
            SplitContainer1.Panel1Collapsed = True
            ToolPanelScale.Enabled = False
            Toolsplit.Enabled = True
        End If
    End Sub

    Private Sub Toolsplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Toolsplit.Click
        If SplitContainer1.Panel1Collapsed = True Then
            SplitContainer1.Panel1Collapsed = False
            ToolPanelScale.Enabled = True
            Toolsplit.Enabled = False
        End If
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub dtgUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUser.CellContentClick

    End Sub

    Private Sub CloudHeader3_Load(sender As Object, e As EventArgs) Handles CloudHeader3.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

#End Region

End Class
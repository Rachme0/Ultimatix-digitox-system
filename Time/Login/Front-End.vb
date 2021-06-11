

Imports System.Data
Imports System.Data.OleDb
Public Class Front_End

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
        End
    End Sub

    Private Sub Btnmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

#End Region

#Region "Variable Declaration"
    Public Conn As OleDbConnection
    Dim eDS As DataSet = New DataSet
    Dim eDA As OleDbDataAdapter = New OleDbDataAdapter
    Dim eDR As DataRow
    Dim dDS As DataSet = New DataSet
    Dim dDA As OleDbDataAdapter = New OleDbDataAdapter
    Dim dDR As DataRow
    
    'Public bExitApplication As Boolean
#End Region

#Region "Procedures "

    Private Sub Check_Info()
        Dim arrImage() As Byte
        Dim myMS As New IO.MemoryStream
        Conn.Open()
        eDA.SelectCommand = New OleDbCommand("SELECT user_fname,user_lname,user_mname, user_img FROM tblUser WHERE user_idno='" & txtuserid.Text.ToString & "' and user_pass='" & txtpass.Text & "'", Conn)
        eDS.Clear()
        eDA.Fill(eDS)
        If eDS.Tables(0).Rows.Count > 0 Then
            eDR = eDS.Tables(0).Rows(0)
            txtusername.Text = eDR("user_lname") & ", " & eDR("user_fname") & " " & eDR("user_mname")
            If Not IsDBNull(eDR("user_img")) Then
                arrImage = eDR("user_img")
                For Each ar As Byte In arrImage
                    myMS.WriteByte(ar)
                Next
                Me.loginimage.Image = System.Drawing.Image.FromStream(myMS)
            Else
                loginimage.Image = Login.My.Resources.admin
            End If
            dDA.SelectCommand = New OleDbCommand("SELECT * FROM tblDTR WHERE user_idno='" & txtuserid.Text & "' AND date_timein=#" & Format(Now, "MM/d/yyyy") & "# AND time_timeout IS NULL", Conn)
            dDS.Clear()
            dDA.Fill(dDS)

            If dDS.Tables(0).Rows.Count > 0 Then
                dDR = dDS.Tables(0).Rows(0)
                btntimein.Enabled = True
                btntimein.Text = "Time Out"
                txttimein.Text = dDR("time_timein")
            Else
                btntimein.Enabled = True
                btntimein.Text = "Time In"
            End If
            dDR = Nothing
            dDS.Dispose()
            dDA.Dispose()
        Else
            txtusername.Clear()
            txttimein.Clear()
            txttimeout.Clear()
            btntimein.Enabled = False
        End If
        eDR = Nothing
        eDS.Dispose()
        eDA.Dispose()
        Conn.Close()
    End Sub

    Private Sub ReturnFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtusername.GotFocus, txttimein.GotFocus, txttimeout.GotFocus
        txtuserid.Focus()
    End Sub

    Private Sub TextboxChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtuserid.TextChanged, txtpass.TextChanged
        If (txtuserid.Text <> "" And txtpass.Text <> "") Then
            Check_Info()
        End If
    End Sub

    Private Sub LoginGotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtuserid.GotFocus, txtpass.GotFocus
        txtusername.Clear()
        txttimein.Clear()
        txttimeout.Clear()
        loginimage.Image = Login.My.Resources.admin
    End Sub

#End Region

    Private Sub Front_End_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Dbase\UTIS.mdb;Persist Security Info=False")
        txtuserid.Focus()
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtuserid.Clear()
        txtpass.Clear()
        txtusername.Clear()
        txttimein.Clear()
        txttimeout.Clear()
        btntimein.Text = "Time In"
        btntimein.Enabled = False
        txtuserid.Focus()
        loginimage.Image = Login.My.Resources.admin
    End Sub

    Private Sub btntimein_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntimein.Click
        ' Time-in and Time-out button
        Dim strSQL As String
        If txtuserid.Text = "" Or txtpass.Text = "" Then
            MessageBox.Show("Please Enter your User Data", "Enter User Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Conn.Open()
            If btntimein.Text = "Time In" Then
                dDR = dDS.Tables(0).NewRow()
                txttimein.Text = Format(Now, "h:mm:ss tt")
                strSQL = "INSERT INTO tblDTR (user_idno, date_timein, time_timein) VALUES ('" & txtuserid.Text & "', #" & Format(Now, "MM/d/yyyy") & "#, #" & txttimein.Text & "#)"
                btntimein.Text = "Time Out"
            Else
                txttimeout.Text = Format(Now, "h:mm:ss tt")
                strSQL = "UPDATE tblDTR SET time_timeout=#" & txttimeout.Text & "# WHERE user_idno='" & txtuserid.Text & "' AND date_timein=#" & Format(Now, "MM/d/yyyy") & "# and time_timein=#" & txttimein.Text & "#"
                btntimein.Text = "Time In"
            End If
            Dim dCmd As OleDbCommand = New OleDbCommand(strSQL, Conn)
            dCmd.ExecuteNonQuery()
            dCmd.Dispose()

            dDR = Nothing
            dDS.Dispose()
            dDA.Dispose()
            Conn.Close()
            btntimein.Enabled = False
            txtuserid.Clear()
            txtpass.Clear()
        End If
    End Sub

    Private Sub toolclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolclear.Click
        btnclear_Click(sender, e)
    End Sub

    Private Sub btnadminlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadminlogin.Click
        Me.Close()
        frmadminlogin.MdiParent = Main
        frmadminlogin.Show()
    End Sub

    Private Sub toolAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolAdmin.Click
        btnadminlogin_Click(sender, e)
    End Sub

End Class
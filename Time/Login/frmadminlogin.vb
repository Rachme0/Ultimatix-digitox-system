

Imports System.Data
Imports System.Data.OleDb
Public Class frmadminlogin

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

#Region "Variable Declaration"
    Dim Conn As OleDbConnection
    Dim lDS As DataSet = New DataSet
    Dim lDA As OleDbDataAdapter = New OleDbDataAdapter
    Dim lDR As DataRow
#End Region

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        Front_End.MdiParent = Main
        Front_End.Show()
    End Sub

    Private Sub frmadminlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Dbase\UTIS.mdb;Persist Security Info=False")
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Conn.Open()
        lDA.SelectCommand = New OleDbCommand("SELECT * FROM tblSysLogin WHERE usr_name='" & txtusername.Text.ToString & "' and usr_pass='" & txtpass.Text & "'", Conn)
        lDS.Clear()
        lDA.Fill(lDS)

        If lDS.Tables(0).Rows.Count > 0 Then
            Me.Close()
            Back_End.MdiParent = Main
            Back_End.Show()
        Else
            MsgBox("Sorry, you do NOT have Administrative permission. Please contact the System Administrator.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Access Denied")
            txtusername.Focus()
        End If

        lDR = Nothing
        lDS.Dispose()
        lDA.Dispose()
        Conn.Close()
    End Sub

    Private Sub toolcancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles toolcancel.Click
        btncancel_Click(sender, e)
    End Sub

End Class
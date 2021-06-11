

Imports System.Data.OleDb
Public Class frmadmin

    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Dbase\UTIS.mdb;Persist Security Info=False"


    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub Load_Admin()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim dr As OleDbDataReader
        Dim myMS As New IO.MemoryStream

        Try
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from tblSysLogin"

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    Me.txtusername.Text = IIf(Not IsDBNull(dr("usr_name")), dr("usr_name"), "")
                    Me.txtpass.Text = IIf(Not IsDBNull(dr("usr_pass")), dr("usr_pass"), "")
                End While
            End If

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Save_Admin()
        Dim conn As New OleDbConnection
        Dim cmd As New OleDbCommand
        Dim sSQL As String = String.Empty
        Dim strImg As String = String.Empty

        Try
            'get connection string declared in the Module1.vb and assing it to conn variable
            conn = New OleDbConnection(constring)
            conn.Open()
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text

            sSQL = "UPDATE tblSysLogin set usr_pass = @usr_pass, usr_name = @usr_name"
            cmd.CommandText = sSQL

            cmd.Parameters.Add("@usr_pass", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtpass.Text)) > 0, Me.txtpass.Text, DBNull.Value)
            cmd.Parameters.Add("@usr_name", OleDbType.VarChar).Value = IIf(Len(Trim(Me.txtusername.Text)) > 0, Me.txtusername.Text, DBNull.Value)

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub frmadmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Load_Admin()
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Save_Admin()
        Me.Close()
    End Sub

End Class
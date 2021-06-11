

Option Explicit On
Public Class Main

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Front_End.MdiParent = Me
        Front_End.StartPosition = FormStartPosition.CenterScreen
        Front_End.Show()
    End Sub

End Class
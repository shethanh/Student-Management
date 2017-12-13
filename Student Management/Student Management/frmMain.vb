Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtcurrentuser.Text = UserLogin
        frmlogin.Hide()
    End Sub


End Class
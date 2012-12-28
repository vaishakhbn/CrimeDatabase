

Public Class fir_login

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim con As New Odbc.OdbcConnection("DSN=CDMS")
        con.Open()
        Dim username As String
        Dim password As String
        username = uname.Text
        password = pass.Text
        Dim cmd As New Odbc.OdbcCommand("select pass from password where uname='" & username & "'", con)
        Dim saved As String = cmd.ExecuteScalar

        con.Close()
        con.Dispose()
        If password = saved Then
            MessageBox.Show("Access Authorized")
            Me.Hide()
            id.Show()
        Else
            MessageBox.Show("Password not matched!")
        End If

    End Sub

    Private Sub fir_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub uname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uname.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
Public Class investigation_login

    Private Sub submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim con As New Odbc.OdbcConnection("DSN=CDMS")
        con.Open()
        Dim username As String
        Dim password As String
        username = uname.Text
        password = MaskedTextBox1.Text
        Dim cmd As New Odbc.OdbcCommand("select pass from password where uname='" & username & "' and user_type='investigation login'", con)
        Dim saved As String = cmd.ExecuteScalar

        con.Close()
        con.Dispose()
        If password = saved Then
            MessageBox.Show("Access Authorized")
            Me.Hide()
            investigate.Show()
        Else
            MessageBox.Show("Password not matched!")
        End If
    End Sub

    Private Sub pass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
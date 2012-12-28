Public Class Jail

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Jail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim con As New Odbc.OdbcConnection("DSN=CDMS")
        con.Open()
        If (CheckedListBox1.CheckedItems.Contains("Name") = True) Then
            Dim a1 As String
            a1 = TextBox2.Text
           
            Dim cmd As New Odbc.OdbcCommand("select jail.criminal_id,jail.fir_id,begin_date,caught_under_section from jail,criminal where criminal.name ='" & a1 & "' and criminal.criminal_id=jail.criminal_id", con)
            Dim da As New DataTable
            Dim dr As Odbc.OdbcDataReader
            dr = cmd.ExecuteReader
            da.Load(dr)
            DataGridView1.DataSource = da
        End If

        If (CheckedListBox1.CheckedItems.Contains("Section") = True) Then

            Dim a1 As Integer
            a1 = TextBox2.Text
            Dim cmd As New Odbc.OdbcCommand("select * from jail,criminal where caught_under_section ='" & a1 & "'", con)
            Dim da As New DataTable
            Dim dr As Odbc.OdbcDataReader
            dr = cmd.ExecuteReader
            da.Load(dr)
            DataGridView1.DataSource = da
        End If

        If (CheckedListBox1.CheckedItems.Contains("Seniority") = True) Then

            Dim cmd As New Odbc.OdbcCommand("select * from jail order by begin_date ", con)
            Dim da As New DataTable
            Dim dr As Odbc.OdbcDataReader
            dr = cmd.ExecuteReader
            da.Load(dr)
            DataGridView1.DataSource = da
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()
        Form1.Show()
    End Sub
End Class
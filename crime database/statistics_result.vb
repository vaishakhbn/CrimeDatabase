Public Class statistics_result

    Private Sub statistics_result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New Odbc.OdbcConnection("DSN=CDMS")
        con.Open()
        Dim o_id As Integer
        o_id = statistics.TextBox1.Text
        Dim cmd As New Odbc.OdbcCommand("select file_fir.fir_id,file_fir.incident_place,incident_date,type_of_crime,items_lost,status,criminal.name as criminal_name,victim.name as Victim_name,victim_id,phone_no,criminal_id,aliases as criminal_aliases,victim.address as victim_address from file_fir,victim,criminal where file_fir.fir_id=victim.fir_id and file_fir.fir_id=criminal.fir_id and officer_id='" & o_id & "'", con)

        Dim da As New DataTable
        Dim dr As Odbc.OdbcDataReader

        dr = cmd.ExecuteReader
        da.Load(dr)
        DataGridView1.DataSource = da
        
       





    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s, p As Integer
        s = 0
        p = 0
        Dim con As New Odbc.OdbcConnection("DSN=CDMS")
        con.Open()
        Dim o_id As Integer
        o_id = statistics.TextBox1.Text
        Dim cmd As New Odbc.OdbcCommand("select count(status) from file_fir where officer_id='" & o_id & "' and status='pending' ", con)

        Dim dr, ds As Odbc.OdbcDataReader
        'dr = cmd.ExecuteReader
        p = cmd.ExecuteNonQuery

        Dim cmd1 As New Odbc.OdbcCommand("select count(status) from file_fir where officer_id='" & o_id & "' and status='solved' ", con)
        'ds = cmd1.ExecuteReader
        s = cmd1.ExecuteNonQuery



        If (s > p) Then
            MessageBox.Show("Since most of the cases allocated to you have been solved,your performance is very good.Keep it up!")



        Else


            MessageBox.Show("Since most of the cases assigned to you are still pending,you need to improve your performance and speed")

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
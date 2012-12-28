Public Class search_by_name

    Private Sub search_by_name_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New Odbc.OdbcConnection("DSN=CDMS")
        con.Open()
        Dim crname As String
        crname = cname.TextBox1.Text
        Dim cmd As New Odbc.OdbcCommand("select file_fir.fir_id,file_fir.incident_place,incident_date,type_of_crime,items_lost,status,criminal.name as criminal_name,victim.name as Victim_name,victim_id,phone_no,criminal_id,aliases as criminal_aliases,victim.address as victim_address from file_fir,victim,criminal where file_fir.fir_id=victim.fir_id and file_fir.fir_id=criminal.fir_id and criminal.name='" & crname & "'", con)

        Dim da As New DataTable
        Dim dr As Odbc.OdbcDataReader
        dr = cmd.ExecuteReader
        da.Load(dr)
        DataGridView1.DataSource = da
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
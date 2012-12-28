Public Class search_result_type

    Private Sub search_result_type_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New Odbc.OdbcConnection("DSN=CDMS")
        con.Open()
        Dim crtype As String
        crtype = type.ComboBox1.Text
        Dim cmd As New Odbc.OdbcCommand("select file_fir.fir_id,file_fir.incident_place,incident_date,type_of_crime,suspect_name,items_lost,status,name,victim_id,phone_no,address from file_fir,victim where file_fir.fir_id=victim.fir_id and file_fir.type_of_crime='" & crtype & "'", con)

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
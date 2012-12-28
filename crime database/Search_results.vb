

Imports System.Data.SqlClient

Public Class Search_results
    

    Public Sub Search_results_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New Odbc.OdbcConnection("DSN=CDMS")
        con.Open()
        Dim id As Integer
        id = fir_id.TextBox1.Text
        Dim cmd As New Odbc.OdbcCommand("select * from file_fir where fir_id =" & id & " ", con)

        Dim da As New DataTable
        Dim dr As Odbc.OdbcDataReader
        dr = cmd.ExecuteReader
        da.Load(dr)
        DataGridView1.DataSource = da


    End Sub
    


   

    
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
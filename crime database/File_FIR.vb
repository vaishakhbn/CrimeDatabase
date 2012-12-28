Public Class id

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub File_FIR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submit.Click
        Dim con As New Odbc.OdbcConnection("DSN=CDMS")
        con.Open()
        Dim vid As String
        vid = fir_id.Text()

        Dim name As String
        name = vname.Text()

        Dim address As String
        address = vaddress.Text()

        Dim cno As String
        cno = cont_no.Text

        Dim type_of_crime As String
        type_of_crime = crime_type.Text()

        Dim time As String
        time = crime_time.Text

        Dim location As String
        location = TextBox2.Text

        Dim suspect As String
        suspect = TextBox3.Text

        Dim lost_item As String
        lost_item = TextBox4.Text

        Dim officer As Integer
        officer = officer_id.Text

        Dim doc As Date
        doc = date_of_crime.Value.Date

        Dim cmd As New Odbc.OdbcCommand("insert into file_fir(fir_id,incident_place,incident_date,officer_id) values(" & vid & ",'" & location & "','" & doc & " ','" & officer & "')", con)

        If (cmd.ExecuteNonQuery > 0) Then
            MessageBox.Show("FIR Lodged")



        End If

        con.Close()
        con.Dispose()























    End Sub

    Private Sub fir_id_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fir_id.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
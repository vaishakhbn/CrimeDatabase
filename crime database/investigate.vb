Imports System.Data.SqlClient

Public Class investigate

    Private Sub investigate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        statistics.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Enter_status.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Dim f, l, n, d, t As Integer
        If (search_by.Text.Equals("Fir ID")) Then
            f = 1
        End If
        If (search_by.Text.Equals("Location")) Then
            l = 1
        End If
        If (search_by.Text.Equals("Criminal Name")) Then
            n = 1
        End If

        If (search_by.Text.Equals("Date")) Then
            d = 1
        End If

        If (search_by.Text.Equals("Crime Type")) Then
            t = 1
        End If

        If f = 1 Then
            Me.Hide()
            fir_id.Show()

        End If
        If d = 1 Then
            Me.Hide()
            date_of_crime.Show()

        End If
        If t = 1 Then
            Me.Hide()
            type.Show()

        End If

        If n = 1 Then
            Me.Hide()
            cname.show()
        End If

        If l = 1 Then
            Me.Hide()
            search_by_place.show()

        End If










    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class
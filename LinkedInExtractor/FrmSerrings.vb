Public Class FrmSerrings
    Private Sub FrmSerrings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a() As String = Split(GetEmails, ",")
        Dim t As String
        For Each t In a
            ListBox1.Items.Add(t)
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String = InputBox("Enter email service e.g. @mail.com", AppTitle)
        If a <> "" Then
            ListBox1.Items.Add(a)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub FrmSerrings_BindingContextChanged(sender As Object, e As EventArgs) Handles Me.BindingContextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim t As String
        Dim k As String = ""
        For Each t In ListBox1.Items
            k = k & t & ","
        Next
        k = Mid(k, 1, k.Length - 1)
        SaveSetting(AppTitle, "settings", "Emails", k)
        Me.Close()
    End Sub

    Private Sub FrmSerrings_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class
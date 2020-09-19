Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Firefox
Public Class FrmMain

    Dim currentUrl As String
    Dim url As String
    Dim Source As String
    'Public ChromeDrv As OpenQA.Selenium.Chrome.ChromeDriver
    Public ChromeDrv As OpenQA.Selenium.Firefox.FirefoxDriver
    Public LineCount As Long
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillComboBox(CmbCountries)
    End Sub

    Private Sub fillComboBox(ByRef dropdown As ComboBox)

        Dim rawdata() As String = Split(My.Resources.Countries, vbNewLine)
        Dim row As String
        Dim items As New DictionaryEntry
        Dim countries As New List(Of DictionaryEntry)

        For Each row In rawdata
            Dim info() As String = Split(row, ",")
            items = New DictionaryEntry(row, info(0))
            countries.Add(items)
        Next

        dropdown.DataSource = countries
        dropdown.ValueMember = "key"
        dropdown.DisplayMember = "value"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        On Error Resume Next

        Dim DriverService As FirefoxDriverService = FirefoxDriverService.CreateDefaultService()
        DriverService.HideCommandPromptWindow = True
        Dim Woptions As New ChromeOptions

        LineCount = 0
        ChromeDrv = New OpenQA.Selenium.Firefox.FirefoxDriver(DriverService)
        Dim a() As String = Split(CmbCountries.SelectedValue.ToString, ",")
        Dim CountryCode = a(2)
        Dim t As String = GetEmails()
        t = t.Replace("@", "%40")
        t = t.Replace(",", "' OR '")
        t = "'" & t & "'"

        Dim searchQuery As String = "http://www.google.com/search?q=+'" & TxtJob.Text & "'+" & t & " AND '" & TxtKeywords.Text & "' -intitle:'profiles' -inurl:'dir/+'+site:" & CountryCode.ToLower.Trim & ".linkedin.com/in/+OR+site:" & CountryCode.ToLower.Trim & ".linkedin.com/pub/"
        searchQuery = searchQuery.Replace("'", """")
        Timer1.Enabled = True

        ChromeDrv.Navigate.GoToUrl(searchQuery)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
    Public Function GetEmailFromSource(ByVal text As String) As List(Of String)
        text = text.Replace(":", vbNewLine)
        text = text.Replace(" ", vbNewLine)
        text = text.Replace("<", vbNewLine)
        text = text.Replace(">", vbNewLine)
        text = text.Replace(")", vbNewLine)
        text = text.Replace("(", vbNewLine)
        text = text.Replace(";", vbNewLine)
        text = text.Replace("[", vbNewLine)
        text = text.Replace("]", vbNewLine)
        text = text.Replace(vbTab, vbNewLine)
        text = text.Replace("{", vbNewLine)
        text = text.Replace("}", vbNewLine)
        text = text.Replace("|", vbNewLine)
        text = text.Replace("=", vbNewLine)
        text = text.Replace("+", vbNewLine)
        text = text.Replace("%", vbNewLine)
        text = text.Replace("$", vbNewLine)
        text = text.Replace("*", vbNewLine)
        text = text.Replace("~", vbNewLine)
        text = text.Replace("^", vbNewLine)
        text = text.Replace("!", vbNewLine)
        text = text.Replace("?", vbNewLine)
        text = text.Replace("/", vbNewLine)
        text = text.Replace("\", vbNewLine)
        Dim _emails() As String = Split(text, vbNewLine)

        Dim _email As String
        Dim EmailsList As New List(Of String)

        For Each _email In _emails
            LineCount = LineCount + 1
            Dim i As Integer
            For i = 1 To 300
                If _email.Length > 2 Then
                    If _email.StartsWith(".") Or _email.StartsWith("@") Or _email.StartsWith("-") Or _email.StartsWith("_") Then
                        _email = Mid(text, 2, _email.Length)
                    End If
                End If
            Next
            For i = 1 To 300
                If _email.Length > 2 Then
                    If _email.EndsWith(".") Or _email.StartsWith("@") Or _email.EndsWith("-") Or _email.EndsWith("_") Then
                        _email = Mid(_email, 1, _email.Length - 1)
                    End If
                End If
            Next

            If _email.Contains("@") Then
                If _email.Contains(".") Then
                    If IsEmail(_email) Then
                        If Not EmailsList.Contains(_email) Then
                            EmailsList.Add(_email)
                        End If
                    End If
                End If
            End If

        Next
        Return EmailsList

    End Function
    Function IsEmail(ByVal email As String) As Boolean
        Dim emailExpression As New System.Text.RegularExpressions.Regex("^[_a-z0-9-]+(.[a-z0-9-]+)@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$")
        Return emailExpression.IsMatch(email)
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, ExportListToolStripMenuItem.Click
        Dim dlg As New SaveFileDialog
        dlg.Filter = "*.txt|*.txt"
        If dlg.ShowDialog() = DialogResult.OK Then
            Dim sw As New IO.StreamWriter(dlg.FileName)
            Dim li As ListViewItem
            Dim t As String = ""
            For Each li In ListView1.Items
                t = t & li.Text & vbNewLine
            Next
            sw.Write(t)
            sw.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub TxtJob_TextChanged(sender As Object, e As EventArgs) Handles TxtJob.TextChanged

    End Sub

    Private Sub TxtJob_GotFocus(sender As Object, e As EventArgs) Handles TxtJob.GotFocus
        l1.Visible = False
    End Sub

    Private Sub TxtJob_LostFocus(sender As Object, e As EventArgs) Handles TxtJob.LostFocus
        If TxtJob.Text = "" Then
            l1.Visible = True
        Else
            l1.Visible = False
        End If
    End Sub

    Private Sub TxtKeywords_TextChanged(sender As Object, e As EventArgs) Handles TxtKeywords.TextChanged

    End Sub

    Private Sub TxtKeywords_GotFocus(sender As Object, e As EventArgs) Handles TxtKeywords.GotFocus
        l2.Visible = False
    End Sub

    Private Sub TxtKeywords_LostFocus(sender As Object, e As EventArgs) Handles TxtKeywords.LostFocus
        If TxtKeywords.Text = "" Then
            l2.Visible = True
        Else
            l2.Visible = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_GotFocus(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
        l3.Visible = False
    End Sub

    Private Sub TextBox3_LostFocus(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
        If TextBox3.Text = "" Then
            l3.Visible = True
        Else
            l3.Visible = False
        End If
    End Sub

    Private Sub l1_Click(sender As Object, e As EventArgs) Handles l1.Click
        l1.Visible = False
        TxtJob.Focus()
    End Sub

    Private Sub l2_Click(sender As Object, e As EventArgs) Handles l2.Click
        l2.Visible = False
        TxtKeywords.Focus()
    End Sub

    Private Sub l3_Click(sender As Object, e As EventArgs) Handles l3.Click
        l3.Visible = False
        TextBox3.Focus()
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            url = ChromeDrv.Url
            Application.DoEvents()
        Catch ex As Exception
            Debug.Print(ex.Message)
            If Not ex.Message.Contains("instance of an object") Then
                If ex.Message.Contains("chrome not reachable") Then
                    Timer1.Enabled = False
                End If

                If ex.Message.Contains("response") Then
                    Timer1.Enabled = False
                End If
            End If
        End Try
        Try


            If url <> "" Then
                If url <> currentUrl Then
                    currentUrl = url
                    Dim emails As List(Of String) = GetEmailFromSource(ChromeDrv.FindElementByTagName("body").Text)
                    Dim email As String
                    For Each email In emails
                        ListView1.Items.Add(email)

                    Next
                End If
            End If
            ToolStripStatusLabel1.Text = "Emails Found:" & ListView1.Items.Count
            ToolStripStatusLabel2.Text = "Lines scanned:" & LineCount
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewSearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewSearchToolStripMenuItem.Click
        If ListView1.Items.Count > 0 Then
            If MsgBox("Do you want save your current list?", vbYesNo + vbQuestion, AppTitle) = MsgBoxResult.Yes Then
                Button4_Click(Nothing, New EventArgs)
            End If
            ListView1.Items.Clear()
        End If
        Timer1.Enabled = True
        TxtJob.Text = ""
        TxtKeywords.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ClearListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub SearchPreferencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchPreferencesToolStripMenuItem.Click
        FrmSerrings.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.ShowDialog()
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Process.Start("http://store.mediaplus.me/leee/")
    End Sub
End Class
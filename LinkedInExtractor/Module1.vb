Module Module1
    Public AppTitle As String = "LinkedIn Express Extractor"
    Public Function GetEmails() As String
        Return GetSetting(AppTitle, "settings", "Emails", "@hotmail.com,@gmail.com,@yahoo.com")
    End Function


End Module

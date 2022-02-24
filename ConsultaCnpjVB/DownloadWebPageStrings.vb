Imports System.Net
Public Class DownloadWebPageStrings
    Public Shared Function Run(ByVal str_url As String) As String
        Try
            Dim defWebProxy As IWebProxy = WebRequest.DefaultWebProxy
            defWebProxy.Credentials = CredentialCache.DefaultCredentials

            Dim webClient As WebClient = New WebClient()
            webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko")
            webClient.Proxy = defWebProxy

            Return webClient.DownloadString(str_url)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "URL Não Encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ""
        End Try
    End Function

End Class

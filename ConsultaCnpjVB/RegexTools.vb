Imports System.Text.RegularExpressions

Public Class RegexTools

    Public Function findPage(ByVal express As String, ByVal test As String) As Boolean
        Dim regEx As Regex = New Regex(express)
        Dim match As Match = regEx.Match(test)
        Dim resultRegex As String = match.ToString()
        If resultRegex = "" Then
            Return False
        End If
        Return True
    End Function

    Public Function getField(ByVal express As String, ByVal test As String) As String
        Dim regEx As Regex = New Regex(express)
        Dim match As Match = regEx.Match(test)

        Dim resultRegex As String = ""
        resultRegex = match.Groups.Item(1).Value

        Return resultRegex
    End Function

    Public Function getEndereco(ByVal express As String, ByVal test As String) As String
        test = Replace(test, vbLf, "")
        Dim regEx As Regex = New Regex(express)
        Dim match As Match = regEx.Match(test)

        Dim resultRegex As String = ""
        resultRegex = Replace(match.Groups.Item(1).Value, "<br>", "; ") + ";"

        Return resultRegex
    End Function

    Public Function getSocios(ByVal test As String) As List(Of String)
        Dim regExTableString As String = "<h3>Sócios<\/h3><table><tr>.*?<\/tr>(.*?)</table>"
        Dim regExSocioString As String = "<tr><td>.*?<\/td><td>(.*?)<\/td><td>.*?<\/td><td>(.*?)<\/td><\/tr>"

        Dim regExTable As Regex = New Regex(regExTableString)
        Dim matchTable As Match = regExTable.Match(test)

        Dim tableString As String = matchTable.Groups.Item(1).Value
        Dim socios As List(Of String) = New List(Of String)()

        Dim regExSocio As Regex = New Regex(regExSocioString)
        Dim matchResult As MatchCollection = regExSocio.Matches(tableString)

        For Each match As Match In matchResult
            Dim socio As String = match.Groups.Item(1).Value + " - " + match.Groups.Item(2).Value
            socios.Add(socio)
        Next

        Return socios
    End Function

End Class

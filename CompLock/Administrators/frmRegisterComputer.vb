Imports Newtonsoft.Json
Imports System.Net.Http
Imports CompLock.ResponseOjects

Public Class frmRegisterComputer
    Dim registered As Boolean = False

    Private Async Sub frmRegisterComputer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        progSignin.Visible = True
        Dim pairs As Dictionary(Of String, String) = New Dictionary(Of String, String)()

        ' Dim formContent As FormUrlEncodedContent = New FormUrlEncodedContent(pairs)

        Try
            Dim http = New HttpClient()
            http.BaseAddress = New Uri(My.Settings.ApiServerURL & ":" & My.Settings.ApiServerPort)

            Dim request As New HttpRequestMessage(HttpMethod.Get, "/api/v1/computers")
            Dim deSchemedToken = My.Settings.AccessToken.Split(" ")
            request.Headers.Authorization = New Headers.AuthenticationHeaderValue("JWT", deSchemedToken(1))

            Dim response = Await http.SendAsync(request)
            Dim json = Await response.Content.ReadAsStringAsync

            If response.StatusCode = 200 Then
                Dim r As SuccessComputer = JsonConvert.DeserializeObject(Of SuccessComputer)(json)
                For Each computer In r.computers
                    If (Environment.UserName = computer.name) Then
                        registered = True
                    End If
                Next

                pnlRegistered.Visible = registered
                pnlNotRegistered.Visible = Not registered
                progSignin.Visible = False
            End If
        Catch ex As Exception
            progSignin.Visible = False
            'error
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Async Sub btnRegisterComputer_Click(sender As Object, e As EventArgs) Handles btnRegisterComputer.Click
        progSignin.Visible = True
        Dim isRegistered = Await registerComputer(Environment.UserName)
        pnlRegistered.Visible = isRegistered
        pnlNotRegistered.Visible = Not isRegistered
        progSignin.Visible = False
    End Sub

    Async Function registerComputer(computerName As String) As Task(Of Boolean)
        Dim pairs As Dictionary(Of String, String) = New Dictionary(Of String, String)()
        pairs.Add("name", Environment.UserName)
        Dim formContent As FormUrlEncodedContent = New FormUrlEncodedContent(pairs)

        Try
            Dim http = New HttpClient()
            http.BaseAddress = New Uri(My.Settings.ApiServerURL & ":" & My.Settings.ApiServerPort)

            Dim request As New HttpRequestMessage(HttpMethod.Post, "/api/v1/computers/new")
            request.Content = formContent
            Dim deSchemedToken = My.Settings.AccessToken.Split(" ")
            request.Headers.Authorization = New Headers.AuthenticationHeaderValue("JWT", deSchemedToken(1))
            Dim response = Await http.SendAsync(request)
            Dim json = Await response.Content.ReadAsStringAsync
            Return response.StatusCode = 200
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Private Async Sub btnUnregisterComputer_Click(sender As Object, e As EventArgs) Handles btnUnregisterComputer.Click
        progSignin.Visible = True
        Dim isUnRegistered = Await unRegisterComputer(Environment.UserName)
        pnlRegistered.Visible = Not isUnRegistered
        pnlNotRegistered.Visible = isUnRegistered
        progSignin.Visible = False
    End Sub

    Async Function unRegisterComputer(computerName As String) As Task(Of Boolean)
        Dim pairs As Dictionary(Of String, String) = New Dictionary(Of String, String)()
        pairs.Add("name", Environment.UserName)
        Dim formContent As FormUrlEncodedContent = New FormUrlEncodedContent(pairs)

        Try
            Dim http = New HttpClient()
            http.BaseAddress = New Uri(My.Settings.ApiServerURL & ":" & My.Settings.ApiServerPort)

            Dim request As New HttpRequestMessage(HttpMethod.Delete, "/api/v1/computers/unregister")
            request.Content = formContent
            Dim deSchemedToken = My.Settings.AccessToken.Split(" ")
            request.Headers.Authorization = New Headers.AuthenticationHeaderValue("JWT", deSchemedToken(1))
            Dim response = Await http.SendAsync(request)
            Dim json = Await response.Content.ReadAsStringAsync
            Return response.StatusCode = 200
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
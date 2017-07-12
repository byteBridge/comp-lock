Imports Npgsql
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class Administrator
    Enum ReportType
        GeneralReport
        OnlineUsers
        ListOfAccounts
        BlockedAccounts
    End Enum
    Function CreateGeneralReport() As Object
        Dim Connections As DataConnections
        Dim ds As DataSet
        Dim dt As DataTable = Nothing
        Try
            ds = New DataSet()
            dt = New DataTable()
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT username,start_time,duration,log_date,comp_name from logsession ORDER BY log_date DESC"
            Connections.DataAdapter = New NpgsqlDataAdapter(Connections.SQLStatement, Connections.Connection)
            Connections.DataAdapter.Fill(ds)
            Connections.Connection.Close()

            ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
            ds.Tables(0).Columns(1).ColumnName = "Start time".ToUpper()
            ds.Tables(0).Columns(2).ColumnName = "Duration".ToUpper()
            ds.Tables(0).Columns(3).ColumnName = "Date".ToUpper()
            ds.Tables(0).Columns(4).ColumnName = "computer name".ToUpper()
            Return ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return Nothing
    End Function


    Public Function GetOnlineUsers() As DataTable
        Dim Connections As DataConnections

        Dim ds As DataSet
        Try
            ds = New DataSet()
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = ("SELECT username,login_date, login_time, computer_name FROM online ")
            Connections.DataAdapter = New NpgsqlDataAdapter(Connections.SQLStatement, Connections.Connection)
            Connections.DataAdapter.Fill(ds)
            Connections.Connection.Close()
            ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
            ds.Tables(0).Columns(1).ColumnName = "Login date".ToUpper()
            ds.Tables(0).Columns(2).ColumnName = "Login time".ToUpper()
            ds.Tables(0).Columns(3).ColumnName = "computer name".ToUpper()

            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return New DataTable

    End Function

    Function GetAllAccounts() As Object
        Dim Connections As DataConnections

        Dim ds As DataSet
        Try
            ds = New DataSet()
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = ("SELECT username,f_name, s_name,type FROM users ")
            Connections.DataAdapter = New NpgsqlDataAdapter(Connections.SQLStatement, Connections.Connection)
            Connections.DataAdapter.Fill(ds)
            Connections.Connection.Close()
            ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
            ds.Tables(0).Columns(1).ColumnName = "First name".ToUpper()
            ds.Tables(0).Columns(2).ColumnName = "surname".ToUpper()
            ds.Tables(0).Columns(3).ColumnName = "account type".ToUpper()

            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return New DataTable

    End Function

    Function GetAllBlockedUsers() As Object
        Dim Connections As DataConnections

        Dim ds As DataSet
        Try
            ds = New DataSet()
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = ("SELECT username,f_name, s_name,type FROM users where blocked = 'true' ")
            Connections.DataAdapter = New NpgsqlDataAdapter(Connections.SQLStatement, Connections.Connection)
            Connections.DataAdapter.Fill(ds)
            Connections.Connection.Close()
            ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
            ds.Tables(0).Columns(1).ColumnName = "First name".ToUpper()
            ds.Tables(0).Columns(2).ColumnName = "surname".ToUpper()
            ds.Tables(0).Columns(3).ColumnName = "account type".ToUpper()

            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return New DataTable
    End Function
    ''' <summary>
    ''' Gets the users who are in the administrator account
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAdminAccounts() As List(Of String)
        Dim AdminAccounts As New List(Of String)
        Dim Connections As DataConnections
        Dim i As Integer = 0
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT username FROM users where lower(type) ='administrator'" '"
            Connections.DataReader = Connections.Command.ExecuteReader()
            While Connections.DataReader.Read()
                AdminAccounts.Add(Connections.DataReader.GetString(0))
            End While
            Connections.Connection.Close()
            Return AdminAccounts
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return AdminAccounts
    End Function

    ''' <summary>
    ''' Returns all the account types available
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetNonAdminAccountTypes() As List(Of String)
        Dim AccountTypes As New List(Of String)
        Dim Connections As DataConnections
        Dim i As Integer = 0
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT user_type FROM time_limit where user_type <> 'administrator' " '"
            Connections.DataReader = Connections.Command.ExecuteReader()
            While Connections.DataReader.Read()
                AccountTypes.Add(Connections.DataReader.GetString(0))
            End While
            Connections.Connection.Close()
            Return AccountTypes
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return AccountTypes
    End Function


    'create a new account type. Return true if the account type name is unique and false if the account type exists
    Public Function CreateNewAccountType(AccountTypeName As String, TimeLimit As String) As Boolean
        Dim Connections As DataConnections
        Dim i As Integer = 0
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT * FROM time_limit where lower(user_type) ='" & AccountTypeName.ToLower & "'"
            Connections.DataReader = Connections.Command.ExecuteReader()
            While Connections.DataReader.Read()
                i += 1
            End While
            Connections.Connection.Close()

            If i = 0 Then
                Connections.Connection.Open()
                Connections.SQLStatement = "INSERT INTO time_limit(user_type,time_limit) VALUES ('" & AccountTypeName & "','" & TimeLimit & "')"
                Connections.Command.ExecuteNonQuery()
                Connections.Connection.Close()
                Return True
            ElseIf i > 0 Then
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return False
    End Function

    Shared Function GetAccountTypes() As List(Of String)
        Dim AccountTypes As New List(Of String)
        Dim Connections As DataConnections
        Dim i As Integer = 0
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT user_type FROM time_limit " '"
            Connections.DataReader = Connections.Command.ExecuteReader()
            While Connections.DataReader.Read()
                AccountTypes.Add(Connections.DataReader.GetString(0))
            End While
            Connections.Connection.Close()
            Return AccountTypes
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return AccountTypes
    End Function

    Sub PrintReport(dgvReport As DataGridView, ReportType As String, NameOfAdministrator As String, Save As Boolean)

        'initialise variables
        Dim doc As Document = New Document(iTextSharp.text.PageSize.A4, 5, 5, 42, 35)
        Dim paragrapghFont As New iTextSharp.text.Font(iTextSharp.text.Font.GetFamilyIndex("Tahoma"), 9.0F, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)
        Dim header As Paragraph = New Paragraph("REPORT TYPE: " & ReportType & vbLf & "DATE: " & Date.Now.ToString("dddd dd MMMM yyyy") & vbLf & "Time: " & DateAndTime.TimeOfDay.ToString("HH:mm") & vbLf & "CREATED BY: " & NameOfAdministrator, paragrapghFont)
        header.IndentationLeft = 60
        Dim blank As Paragraph = New Paragraph("                      ")
        Dim table As PdfPTable = New PdfPTable(dgvReport.Columns.Count)


        'check if the user is saving or previewing the report
        If Save = True Then

            Dim dialog As SaveFileDialog = New SaveFileDialog()
            dialog.Title = "Select the path to save your report"
            dialog.Filter = "PDF files (*.pdf)|*.pdf"

            If (dialog.ShowDialog() <> DialogResult.Cancel) Then
                Dim Filename As String = dialog.FileName
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(Filename, FileMode.Create))
            End If
        Else
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(FileIO.SpecialDirectories.CurrentUserApplicationData + "\Temp.pdf", FileMode.Create)) ' //"Trace " + Resource + ".pdf", FileMode.Create)) 
        End If


        Try
            doc.Open()

            ' populate the title
            For j As Integer = 0 To dgvReport.Columns.Count - 1
                table.AddCell(New Phrase(dgvReport.Columns(j).HeaderText, New iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12.0F, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))) ' //increse the font 
            Next
            table.HeaderRows = 1

            'add the rows containing member information from the dgv
            For i As Integer = 0 To dgvReport.Rows.Count - 1

                For k As Integer = 0 To dgvReport.Columns.Count - 1

                    If (dgvReport(k, i).Value <> Nothing) Then

                        table.AddCell(New Phrase(dgvReport(k, i).Value.ToString(), paragrapghFont))
                    End If
                Next
            Next


            'add all to the document
            doc.Add(header)
            doc.Add(blank)
            doc.Add(table)
            doc.Add(blank)
            doc.Close()

            'if user is previewing open the file.
            If Not Save Then
                Process.Start(FileIO.SpecialDirectories.CurrentUserApplicationData + "\Temp.pdf")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function CreateTodayReport() As Object
        Dim Connections As DataConnections
        Dim ds As DataSet
        Dim dt As DataTable = Nothing
        Try
            ds = New DataSet()
            dt = New DataTable()
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT username,start_time,duration,log_date,comp_name from logsession where log_date ='" & DateTime.Today.ToString("MM/dd/yyyy") & "' ORDER BY log_date DESC"
            Connections.DataAdapter = New NpgsqlDataAdapter(Connections.SQLStatement, Connections.Connection)
            Connections.DataAdapter.Fill(ds)
            Connections.Connection.Close()

            ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
            ds.Tables(0).Columns(1).ColumnName = "Start time".ToUpper()
            ds.Tables(0).Columns(2).ColumnName = "Duration".ToUpper()
            ds.Tables(0).Columns(3).ColumnName = "Date".ToUpper()
            ds.Tables(0).Columns(4).ColumnName = "computer name".ToUpper()
            Return ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return Nothing
    End Function

End Class

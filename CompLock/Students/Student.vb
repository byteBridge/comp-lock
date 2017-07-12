

Imports Npgsql


Public Class Student
#Region "Fields"
    Private _username As String
    Private _password As String
    Private _name As String
    Private _surname As String
    Private _type As String
    Private _blocked As Boolean
    Private _gender As String
#End Region
#Region "Properties"




    ''' <summary>
    ''' The username uniquely identifies a member, duplicates not allowed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Username As String
        Get
            Return Me._username
        End Get
        Set(value As String)
            Me._username = value
        End Set
    End Property

    ''' <summary>
    ''' For security the member has to have a password
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Password As String
        Get
            Return Me._password
        End Get
        Set(value As String)
            Me._password = value
        End Set
    End Property

    ''' <summary>
    ''' The First name of the member as appears on the birth certificate
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property FirstName As String
        Get
            Return Me._name
        End Get
        Set(value As String)
            Me._name = value
        End Set
    End Property

    ''' <summary>
    ''' The Last name of the member as appears on the birth certificate
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Surname As String
        Get
            Return Me._surname
        End Get
        Set(value As String)
            Me._surname = value
        End Set
    End Property

    ''' <summary>
    ''' The student's full name, a concartnation of the first and last names
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property FullName As String
        Get
            Return Me.FirstName + " " + Me._surname
        End Get
    End Property
    ''' <summary>
    ''' The type sets the different priviledges each member is allowed to enjoy
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Type As String
        Get
            Return Me._type
        End Get
        Set(value As String)
            Me._type = value
        End Set
    End Property


#End Region
#Region "Methods"




    ''' <summary>
    ''' Deletes the member completely fom the database. Does'nt delete his or her history
    ''' </summary>
    ''' <param name = "Username"></param>
    Public Overridable Function DeleteMember(ByVal Username As String) As Boolean

        Try
            Dim Connections As New DataConnections
            ' Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = (("DELETE FROM users WHERE username ='" & Username.Trim()) & "';")
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()
            Return True
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Deleting Member")
            Return False
        End Try
        Return False
    End Function

    ''' <summary>
    ''' PROGRAM NAME: DeleteMemberHistory
    ''' WRITTEN BY: Kudakwashe Paradzayi
    ''' PURPOSE:Deletes all the login sessions recorded as the member (i.e student or admin) was using the system.
    '''         This function does not delete the member.
    ''' DATE: Monday 22 February 2016
    ''' </summary>
    Public Overridable Function DeleteMemberHistory(ByVal Username As String) As Boolean
        'Declare and initialise variables
        Dim HasMemberHistoryBeenSuccessfullyDeleted As Boolean = False
        Dim Connections As New DataConnections 'Class with methods to access the database

        Try 'Handle all eceptions that can arise as the program access the database
            Connections.Connection.Open()
            Connections.SQLStatement = (("DELETE FROM logsession WHERE username ='" & Username.Trim()) & "';")
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()

            'if this code is executed then the operation is successfull.
            HasMemberHistoryBeenSuccessfullyDeleted = True
        Catch ex As Exception ' an exception has been caught. Notify the user.
            MsgBox(ex.Message, "Error Deleting History", MsgBoxStyle.Critical)
            HasMemberHistoryBeenSuccessfullyDeleted = False
        End Try

        'Return the results to the calling code
        Return HasMemberHistoryBeenSuccessfullyDeleted
    End Function

    ''' <summary>
    ''' Validates the credentials and checks for other validations eg, time, blacklisted,etc
    ''' </summary>
    Public Function Login(ByVal Username As String, ByVal Password As String) As Boolean


        Dim Connections As DataConnections

        Dim count As Integer

        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT  username,password, type FROM users where username ='" & Username & "' and password ='" & Password & "';"

            count = 0
            Connections.DataReader = Connections.Command.ExecuteReader()
            If Connections.DataReader.Read() Then
                count += 1
                Type = Connections.DataReader.GetString(2)
            End If
            Connections.Connection.Close()
            If count = 0 Then
                Return False
            ElseIf (count > 0) Then

                If Type.ToLower <> "administrator" Then
                    'Has the user been blocked
                    If Student.IsMemberBlocked(Username) = True Then
                        Connections.Connection.Close()
                        Throw New Exception("We regret to inform you that your account qualifies to be blocked. Report by librarian's desk to have your account unblocked.")
                        Return False

                    Else
                        'has the user used up his/her time?
                      If CDate(TimeOperations.GetTotalUpTime(Username)) >= CDate(TimeOperations.GetTimeLimits(Type)) Then
                            Connections.Connection.Close()
                            Throw New Exception("We regret to inform you that you have used up today's time. May you come back tommorrow for more research.")
                            Return False

                        Else
                            'is the user already online on another computer?
                            If IsOnline(Username) = True Then
                                Throw New Exception("It looks like your account is already logged in on another computer. Log out on that computer if you wish to use this one.")
                                Return False
                            End If
                        End If
                    End If

                    'if the student passes all  the conditions allow him to log in
                    Connections.Connection.Close()
                    Return True
                Else
                    'the account belongs to a administrator wha has successfully logged in
                    Return True
                End If
            End If

        Catch ex As Exception
            Throw ex 'throws even the exceptions generated within this block
        End Try
        Return False
    End Function

 
    ''' <summary>
    ''' Formats the username into the accepted format, and checks if the username is valid
    ''' </summary>
    ''' <param name = "Username"></param>
    Public Shared Function CreateValidUsername(ByVal Username As String) As String
        Dim count As Integer
        Dim initialUsername As String
        Dim finalUsername As String
        Try
            initialUsername = Username
            count = 0
            While (IsIDValid(Username) = False)
                count += 1
                Username = initialUsername
                Username = (Username & count.ToString())
            End While

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        finalUsername = Username
        Return finalUsername
    End Function

    Private Shared Function IsIDValid(ByVal Username As String) As Boolean

        Dim Connections As DataConnections
        Dim num1 As Integer
        Connections = New DataConnections()
        Connections.Connection.Open()
        Connections.SQLStatement = (("SELECT username FROM users WHERE username ='" & Username) & "'")
        Connections.DataReader = Connections.Command.ExecuteReader()
        num1 = 0
        While Connections.DataReader.Read()
            num1 = 1
        End While
        Connections.Connection.Close()
        If (num1 = 0) Then
            Return True
        End If
        If (num1 = 1) Then
            Return False

        Else
            Return False
        End If
        Return False
    End Function

    ''' <summary>
    ''' PROGRAM NAME: ChangePassword
    ''' WRITTEN BY: Kudakwashe Paradzayi
    ''' PURPOSE: Changes the member's password
    ''' DATE: Sunday 14 February 2016
    ''' </summary>
    Public Function ChangePassword(ByVal Username As String, ByVal NewPassword As String) As Boolean

        'Initialise and declare variables
        Dim ChangeSuccess As Boolean = False
        Dim Connections As DataConnections

        Try 'Handle all the exceptions that might arise when the program is communicating with the database

            Connections = New DataConnections() 'This class contains functions that communicate with the database.
            Connections.Connection.Open()
            Connections.SQLStatement = "UPDATE users SET password = '" & NewPassword & "'  where username ='" & Username & "'"
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()

            'Inform the user that the password has been changed.
            ChangeSuccess = True

        Catch ex As Exception 'If an error occurs, catch it here and display a message for the user to see.
            MsgBox(ex.Message)
            ChangeSuccess = False 'And inform the user that the password has been changed.
        End Try
        Return ChangeSuccess 'Return the results of the attempt to change the password.
    End Function

    ''' <summary>
    ''' PROGRAM NAME: LogSession
    ''' WRITTEN BY: Kudakwashe Paradzayi.
    ''' PURPOSE: Records the username, log in time, duration and the computer from which the login was made.
    ''' </summary>
    Public Sub LogSession(StartTime As String, Duration As String, LogDate As String, ComputerName As String)


        Dim Connections As DataConnections 'Initialise and declare variables

        Try 'Handle errors here
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "INSERT INTO logsession(username,start_time,duration,log_date,comp_name) VALUES ('" & Me.Username & "','" & StartTime & "','" & Duration & "','" & LogDate & "','" & ComputerName & "')"
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()

        Catch ex As Exception 'Report an error if found
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Function FillAccounts() As DataTable
        Dim Connections As DataConnections
        Dim ds As DataSet
        Dim dt As DataTable = Nothing
        Try
            ds = New DataSet()
            dt = New DataTable()
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.DataAdapter = New NpgsqlDataAdapter("SELECT username,f_name,s_name,gender,type,blocked FROM users", Connections.Connection)
            Connections.DataAdapter.Fill(ds)
            Connections.Connection.Close()

            ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
            ds.Tables(0).Columns(1).ColumnName = "First Name".ToUpper()
            ds.Tables(0).Columns(2).ColumnName = "Surname".ToUpper()
            ds.Tables(0).Columns(3).ColumnName = "Gender".ToUpper()
            ds.Tables(0).Columns(4).ColumnName = "Account type".ToUpper()
            ds.Tables(0).Columns(5).ColumnName = "Blocked?".ToUpper()
            Return ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dt
    End Function



    Public Function SearchAsYouType(ByVal SearchString As String, ByVal Filter As String, ShowPassword As Boolean) As DataTable
        Dim Connections As DataConnections
        Dim ds As DataSet
        Dim dt As DataTable = Nothing
        Try
            Connections = New DataConnections()
            ds = New DataSet()
            dt = New DataTable()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT * FROM users"
            Connections.DataAdapter = New NpgsqlDataAdapter((("SELECT * FROM users where lower(f_name) like '%" & SearchString.Trim().ToLower()) & "%'"), Connections.Connection)

            Select Case Filter
                Case "FirstName"
                    Connections.DataAdapter = New NpgsqlDataAdapter((("SELECT * FROM users where lower(f_name) like '%" & SearchString.Trim().ToLower()) & "%'"), Connections.Connection)

                Case "Surname"
                    Connections.DataAdapter = New NpgsqlDataAdapter((("SELECT * FROM users where lower(s_name) like '%" & SearchString.Trim().ToLower()) & "%'"), Connections.Connection)
                Case "Username"
                    Connections.DataAdapter = New NpgsqlDataAdapter((("SELECT * FROM users where lower(username) like '%" & SearchString.Trim().ToLower()) & "%'"), Connections.Connection)
                Case Else
                    Connections.DataAdapter = New NpgsqlDataAdapter((("SELECT * FROM users where lower(f_name) like '%" & SearchString.Trim().ToLower()) & "%'"), Connections.Connection)
            End Select

            Connections.DataAdapter.Fill(ds)
            Connections.Connection.Close()
            If (ShowPassword = False) Then
                ds.Tables(0).Columns.Remove("password")

                ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
                ds.Tables(0).Columns(1).ColumnName = "First Name".ToUpper()
                ds.Tables(0).Columns(2).ColumnName = "Surname".ToUpper()
                ds.Tables(0).Columns(3).ColumnName = "Account type".ToUpper()
                ds.Tables(0).Columns(4).ColumnName = "blocked?".ToUpper()
            Else
                ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
                ds.Tables(0).Columns(1).ColumnName = "password".ToUpper()
                ds.Tables(0).Columns(2).ColumnName = "First Name".ToUpper()
                ds.Tables(0).Columns(3).ColumnName = "Surname".ToUpper()
                ds.Tables(0).Columns(4).ColumnName = "Account type".ToUpper()
                ds.Tables(0).Columns(5).ColumnName = "blocked?".ToUpper()
            End If

            Return ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dt
    End Function


    ''' <summary>
    ''' Summary of the user in the form of a DataTable
    ''' </summary>
    ''' <param name="Username"></param>
    ''' <returns></returns>
    Public Function GetMemberHistory(Username As String) As DataTable
        Dim Connections As DataConnections

        Dim ds As DataSet
        Try
            ds = New DataSet()
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = (("SELECT username,start_time,duration,log_date,comp_name FROM logsession where username ='" & Username) & "'")
            Connections.DataAdapter = New NpgsqlDataAdapter(Connections.SQLStatement, Connections.Connection)
            Connections.DataAdapter.Fill(ds)
            Connections.Connection.Close()
            ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
            ds.Tables(0).Columns(1).ColumnName = "Start time".ToUpper()
            ds.Tables(0).Columns(2).ColumnName = "Duration".ToUpper()
            ds.Tables(0).Columns(3).ColumnName = "Date".ToUpper()
            ds.Tables(0).Columns(4).ColumnName = "Computer Name".ToUpper()
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return New DataTable

    End Function

  

#End Region



    ''' <summary>
    ''' Gets or sets the blocked property of a member
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Blocked As Boolean
        Get
            Return _Blocked
        End Get
        Set(value As Boolean)
            Me._Blocked = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _Gender
        End Get
        Set(value As String)
            Me._Gender = value
        End Set
    End Property

    ''' <summary>
    ''' Create a student account using data stores in its properties
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Create() As Boolean
        Dim Connections As DataConnections



        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            ' this one works   Connections.SQLStatement = "INSERT INTO logsession(username,start_time,duration,log_date,comp_name) VALUES ('" & Me.Username & "','" & starttime & "','" & duration & "','" & logdate & "','" & computername & "')"
            Connections.SQLStatement = "INSERT INTO users(f_name,s_name,password,username,type,gender,blocked) VALUES('" & FirstName & "','" & Surname & "','" & Password & "','" & Username & "','" & Type & "','" & Gender & "','false')"
            '  Connections.SQLStatement = "INSERT INTO users(f_name,s_name,password,username,gender,type,blocked) VALUES ('" & Me.FirstName & "','" & Surname & "','" & Password & "','" & Username & "','" & Gender & "','" & Type & "','FALSE')"
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return False
        '  Connections.SQLStatement = "INSERT INTO users(f_name , s_name , password , username , gender , type , blocked) VALUES('" & FirstName & "','" & Surname & "','" & Password & "','" & Username & "','" & Gender & "','" & Type & "','FALSE')"

    End Function




    ''' <summary>
    ''' Determines whether a user has exceeded his daily time limit
    ''' </summary>
    ''' <param name="Username"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UserTimeUp(ByVal Username As String, UserType As String) As Boolean
        Try

            If CDate(TimeOperations.GetTotalUpTime(Username)) > CDate(TimeOperations.GetTimeLimits(UserType)) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Checks wheter a member is blocked or not
    ''' </summary>
    ''' <param name="Username"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function IsMemberBlocked(ByVal Username As String) As Boolean
        Dim Connections As DataConnections
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = (("SELECT blocked FROM users where username ='" & Username) & "'")
            Connections.DataReader = Connections.Command.ExecuteReader()
            While Connections.DataReader.Read()
                If Connections.DataReader.GetBoolean(0) = True Then
                    Return True
                End If
            End While
            Connections.Connection.Close()
            Return False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return False
    End Function


    ''' <summary>
    '''  Refreshes the student object with the latest data from the database
    ''' </summary>
    ''' <param name="UserName"></param>
    ''' <remarks></remarks>
    Public Sub Initialize(ByVal UserName As String)
        Dim Connections As DataConnections
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = (("SELECT username, f_name,s_name,password,gender,type,blocked FROM users where username ='" & UserName) & "'")
            Connections.DataReader = Connections.Command.ExecuteReader()
            While Connections.DataReader.Read()
                Me.Username = UserName
                Me.FirstName = Connections.DataReader.GetString(1).ToString
                Me.Surname = Connections.DataReader.GetString(2).ToString
                Me.Password = Connections.DataReader.GetString(3).ToString
                Me.Gender = Connections.DataReader.GetString(4).ToString
                Me.Type = Connections.DataReader.GetString(5).ToString
                Me.Blocked = CBool(Connections.DataReader.GetBoolean(6))
            End While
            Connections.Connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ''' <summary>
    ''' Blocks a student from gaining access
    ''' </summary>
    ''' <param name = "Username"></param>
    Public Function Block(ByVal Username As String) As Boolean
        Dim Connections As DataConnections
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = (("UPDATE users SET blocked = 'TRUE'  where username ='" & Username) & "'")
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return False
    End Function

    ''' <summary>
    ''' Unblocks a student who has been denied access
    ''' </summary>
    ''' <param name="Username"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function UnBlock(ByVal Username As String) As Boolean
        Dim Connections As DataConnections
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = (("UPDATE users SET blocked = 'FALSE'  where username ='" & Username) & "'")
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return False
    End Function

    Public Shared Function ClearOnlineUsers() As Boolean

        Try
            Dim Connections As New DataConnections
            ' Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "DELETE FROM online"
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()
            Return True
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Deleting Member")
            Return False
        End Try
        Return False

    End Function

    ''' <summary>
    ''' Sets the database to reflect that the user is online
    ''' </summary>
    Public Sub GoOnline()
        Dim Connections As DataConnections
        Dim i As Integer = 0
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "INSERT  INTO online(username,login_time) VALUES('" & Me.Username & "','" & DateAndTime.Now.ToString("HH:mm:ss") & "') " '" '"
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub GoOffline()
        Dim Connections As DataConnections
        Dim i As Integer = 0
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "DELETE FROM online where  username ='" & Me.Username & "'" '"
            Connections.Command.ExecuteNonQuery()

            Connections.Connection.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

    End Sub
    Public Function IsOnline(username As String) As Boolean
        Dim Connections As DataConnections
        Dim i As Integer = 0
        Try
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT username FROM online where username ='" & username & "'" '"
            Connections.DataReader = Connections.Command.ExecuteReader()
            While Connections.DataReader.Read()
                i += 1
            End While
            Connections.Connection.Close()
            If i = 0 Then
                Return False
            ElseIf i > 0
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return False
    End Function

    Function ChangeAccountType(Username As String, AccountType As String) As Boolean
        Dim Connections As DataConnections
        Try

            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "UPDATE users SET type = '" & AccountType & "'  where username ='" & Username & "'"
            Connections.Command.ExecuteNonQuery()
            Connections.Connection.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Function GetLoginSummary(p1 As String) As Object
        Dim Connections As DataConnections
        Dim ds As DataSet
        Dim dt As DataTable = Nothing
        Try
            ds = New DataSet()
            dt = New DataTable()
            Connections = New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "SELECT username,start_time,duration,log_date,comp_name FROM logsession where username ='" & Username & "' ORDER BY log_date DESC"
            Connections.DataAdapter = New NpgsqlDataAdapter(Connections.SQLStatement, Connections.Connection)
            Connections.DataAdapter.Fill(ds)
            Connections.Connection.Close()

            ds.Tables(0).Columns(0).ColumnName = "username".ToUpper()
            ds.Tables(0).Columns(1).ColumnName = "start time".ToUpper()
            ds.Tables(0).Columns(2).ColumnName = "duration".ToUpper()
            ds.Tables(0).Columns(3).ColumnName = "login date".ToUpper()
            ds.Tables(0).Columns(4).ColumnName = "computer".ToUpper()
            Return ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Nothing
    End Function



 


End Class


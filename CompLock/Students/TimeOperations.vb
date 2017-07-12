

Public Class TimeOperations

        Public Property TotalTime As String
        Public Property GrandTime As String

        ''' <summary>
        ''' Checks if the time being given to the member is >= to the set time
        ''' </summary>
        ''' <param name="Hour"></param>
        ''' <param name="minute"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function IsTimeEnough(ByVal Hour As Integer, ByVal minute As Integer) As Boolean
            If (Hour >= 1) Then
                Return True
            Else
                If (minute < 30 And Hour = 0) Then
                    Return False
                Else
                    Return True
                End If
            End If
            Return False
        End Function

        ''' <summary>
        ''' Gets the time limits that are set by the librarian
        ''' </summary>
        Public Shared Function GetTimeLimits(UserType As String) As String

            Dim Connections As DataConnections
            Dim TimeString As String

            Try
                Connections = New DataConnections()
                Connections.Connection.Open()
            Connections.SQLStatement = "Select time_limit from time_limit where user_type='" & UserType & "';"
            Connections.DataReader = Connections.Command.ExecuteReader()
            While Connections.DataReader.Read()
                TimeString = Connections.DataReader(0)
                Connections.Connection.Close()
                Return TimeString
            End While
                Connections.Connection.Close()
            Catch ex As Exception
            MsgBox(ex.Message, "Error", MsgBoxStyle.Critical)
        End Try
            Return "#GetTimeLimitsError#"
        End Function

        ''' <summary>
        ''' Gets the total time used by a user today
        ''' </summary>
        ''' <param name="Username"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
    Public Shared Function GetTotalUpTime(Username As String) As String
        Dim TimeAccumulator As New List(Of String)
        Dim hours = 0, minutes = 0, seconds = 0
        Dim dateToday = DateTime.Today.ToString("MM/dd/yyyy")
        Try
            Dim Connections As New DataConnections()
            Connections.Connection.Open()
            Connections.SQLStatement = "Select duration from logsession where username = '" & Username & "' and log_date = '" & dateToday & "' ;"
            Connections.DataReader = Connections.Command.ExecuteReader()

            'loop through the selected rows and add the times to an accumulator
            While Connections.DataReader.Read() = True
                TimeAccumulator.Add(Connections.DataReader(0))
            End While

            If TimeAccumulator.Count = 0 Then
                Connections.Connection.Close()
                Return "00:00:00"
            ElseIf TimeAccumulator.Count > 0 Then

                For i As Integer = 0 To TimeAccumulator.Count - 1

                    Dim SplitTime() = Split(TimeAccumulator(i), ":")
                    hours += SplitTime(0)
                    minutes += SplitTime(1)
                    seconds += SplitTime(2)
                Next
                If seconds > 59 Then
                    minutes += Int(seconds / 60)
                    seconds = Int(seconds Mod 60)
                End If
                If minutes > 59 Then
                    hours += Int(minutes / 60)
                    minutes = Int(minutes Mod 60)
                End If
                Dim TimeString As String = hours.ToString & ":" & minutes.ToString & ":" & seconds.ToString

                Connections.Connection.Close()
                Return TimeString
            End If
            Connections.Connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return "#GetTotalUpTimeError#"
    End Function

        ''' <summary>
        ''' Gets the total time used by the user since the beginning of time
        ''' </summary>
        ''' <param name="Username"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetGrandTotalUpTime(Username As String) As String
            Dim Connections As DataConnections
            Dim TimeAccumulator As New List(Of String)
            Dim hours = 0, minutes = 0, seconds = 0
            Try
                Connections = New DataConnections()
                Connections.Connection.Open()
                Connections.SQLStatement = "Select duration from logsession where username='" & Username & "';"
                Connections.DataReader = Connections.Command.ExecuteReader()
                While Connections.DataReader.Read()
                    TimeAccumulator.Add(Connections.DataReader(0))
                End While

                If TimeAccumulator.Count = 0 Then
                Connections.Connection.Close()
                Return "00:00:00"
                ElseIf TimeAccumulator.Count > 0 Then
                    For i As Integer = 0 To TimeAccumulator.Count - 1
                        Dim SplitTime() = Split(TimeAccumulator(i), ":")
                        hours += SplitTime(0)
                        minutes += SplitTime(1)
                        seconds += SplitTime(2)
                    Next
                    If seconds > 59 Then
                        minutes += Int(seconds / 60)
                        seconds = Int(seconds Mod 60)
                    End If
                    If minutes > 59 Then
                        hours += Int(seconds / 60)
                        minutes = Int(seconds Mod 60)
                    End If
                    Dim RawTimeString As String = hours.ToString & ":" & minutes.ToString & ":" & seconds.ToString
                Dim TimeString As Date = CDate(RawTimeString)

                Connections.Connection.Close()
                Return TimeString.ToString("HH:mm:ss")
                End If
                Connections.Connection.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

            Return "#GetGrandTotalUpTimeError#"
        End Function
    End Class
    Public Class Time

        ' Fields
        Private _Hours As Integer
        Private _Minutes As Integer
        Private _Seconds As Integer
        Private _ProhibitedTimes As String()

        ' Properties

        Public Property Hours As Integer
            Get

                Return Me._Hours
            End Get
            Set(value As Integer)
                If ((value >= 0) And (value <= 8)) Then
                    Me._Hours = value
                Else
                    Throw New Exception("The hours you have given are out of range." & ChrW(10) & "The expected range is 0<Hour<8. ")
                End If
            End Set
        End Property

        Public Property Minutes As Integer
            Get

                Return Me._Minutes
            End Get
            Set(value As Integer)
                If ((value >= 0) And (value < 60)) Then
                    Me._Minutes = value
                Else
                    Throw New Exception("The minutes you have given are out of range." & ChrW(10) & "The expected range is 0<= Minutes <60. ")

                End If
            End Set
        End Property

        Public Property Seconds As Integer
            Get
                Return Me._Seconds
            End Get
            Set(value As Integer)
                If ((value >= 0) And (value < 60)) Then
                    Me._Seconds = value
                Else
                    Throw New Exception("The seconds you have given are out of range." & ChrW(10) & "The expected range is 0<= Seconds <60. ")
                End If
            End Set
        End Property

        ' Methods
        Public Sub New()
        End Sub
        ''' <summary>
    ''' Save the Time allowed for the specified user type, by passing the time into the properties
        ''' </summary>
        ''' <param name="Usertype"></param>
        ''' <returns></returns>
        Public Function SaveTimeSetting(Usertype As String) As Boolean

            Dim Connections As DataConnections

            Try
                Connections = New DataConnections()
                Connections.Connection.Open()
                Connections.SQLStatement = "DELETE FROM time_limit WHERE user_type ='" & Usertype & "';"
                Connections.Command.ExecuteNonQuery()
                Connections.SQLStatement = "INSERT INTO time_limit(user_type,time_limit) VALUES('" & Usertype & "','" & Me.Hours & ":" & Me.Minutes & ":" & Me.Seconds & "')"
                Connections.Command.ExecuteNonQuery()
                Connections.Connection.Close()
                Return True


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "#SaveTimeError")
            End Try


            Return False
        End Function
    End Class



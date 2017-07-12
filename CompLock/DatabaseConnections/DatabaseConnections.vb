
Imports Npgsql


''' <summary>
''' Contains the connections, commands, datareades, etc that enable database queries
''' </summary>
Public Class DataConnections

    ' Fields
    Private _Database As String
    Private _UserID As String
        Private _Password As String







        Private _ConnectionString As String
        Private _SqlStatement As String
    Private _DataReader As NpgsqlDataReader
    Private _connection As NpgsqlConnection
    Private _DataAdapter As NpgsqlDataAdapter
    Private _command As NpgsqlCommand
    Private _Server As String

#Region "Properties"
    ''' <summary>
    ''' The Sql string sent to the database
    ''' </summary>
    Public Property SQLStatement As String
        Get
            Return Me._SqlStatement
        End Get
        Set(value As String)
            If value = "" Then

                Throw New Exception("Empty SqlStatements are not allowed")
            Else
                Me._SqlStatement = value
                Me._command = New NpgsqlCommand(Me.SQLStatement, Me._connection)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Equivalent to the NpgsqlConnection
    ''' </summary>
    Public Property Connection As NpgsqlConnection
        Get
            Return Me._connection
        End Get
        Set(value As NpgsqlConnection)
            Me._connection = value
        End Set
    End Property

    ''' <summary>
    ''' The string that is used to identify the server, database and also has the credentials required to access them
    ''' </summary>
    Public ReadOnly Property ConnectionString As String
        Get
            Return Me._ConnectionString
        End Get
    End Property


    ''' <summary>
    ''' Equivalent to the NpgsqlCommand
    ''' </summary>
    Public ReadOnly Property Command As NpgsqlCommand
        Get
            Return Me._command
        End Get
    End Property

    ''' <summary>
    ''' Equivalent to the NpgsqlDataReader
    ''' </summary>
    Public Property DataReader As NpgsqlDataReader
        Get
            Return Me._DataReader
        End Get
        Set(value As NpgsqlDataReader)
            Me._DataReader = value
        End Set
    End Property

    ''' <summary>
    ''' Equivalent to the NpgsqlDataAdapter
    ''' </summary>
    Public Property DataAdapter As NpgsqlDataAdapter
        Get
            Return Me._DataAdapter
        End Get
        Set(value As NpgsqlDataAdapter)
            Me._DataAdapter = value
        End Set
    End Property


    ''' <summary>
    ''' Identifies the Database where the data is held
    ''' </summary>
    Public Property Database As String
        Get
            Me._Database = My.Settings.Database
            Return Me._Database
        End Get
        Set(value As String)
            Me._Database = value
            My.Settings.Database = value
        End Set
    End Property

    ''' <summary>
    ''' Identifies the user who has rights to the server where the data is held
    ''' </summary>
    Public Property UserID As String
        Get
            Me._UserID = My.Settings.Username
            Return Me._UserID
        End Get
        Set(value As String)
            Me._UserID = value
            My.Settings.Username = value
        End Set
    End Property


    ''' <summary>
    ''' Identifies the server where the data is held
    ''' </summary>
    Public Property Server As String
        Get

            Me._Server = My.Settings.Server
            Return Me._Server
        End Get
        Set(value As String)
            Me._Server = value
            My.Settings.Server = value
        End Set
    End Property
    ''' <summary>
    ''' Identifies the passwird used to access the server where the data is held
    ''' </summary>
    Public Property Password As String
        Get
            Me._Password = My.Settings.Password
            Return Me._Password
        End Get
        Set(value As String)
            Me._Password = value
            My.Settings.Password = value
        End Set
    End Property
#End Region
#Region "Methods"
    ''' <summary>
    ''' Initialize the values connecting the app to the database from the settings
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()



        Me._ConnectionString = "Server = " & Server & ";User ID =" & UserID & ";Password=" & Password & ";Database=" & Database

        Me._connection = New NpgsqlConnection(ConnectionString)
        Me._DataAdapter = New NpgsqlDataAdapter(Me.SQLStatement, Me._connection)
        Me._command = New NpgsqlCommand(Me.SQLStatement, Me._connection)

    End Sub
        Public Sub SaveDataAccessValues()
            My.Settings.Save()
        End Sub

#End Region

    End Class
    Public Class FileSystem


        ''' <summary>
        '''Points to the desktop of the current user
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared ReadOnly Property Desktop As String
            Get
                Return My.Computer.FileSystem.SpecialDirectories.Desktop
            End Get
        End Property

        ''' <summary>
        ''' Points to the app data folder of the current user
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared ReadOnly Property AppData As String
            Get
                Return My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
            End Get
        End Property


        ''' <summary>
        ''' Points to the app data for all users
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared ReadOnly Property AllUsersAppData As String
            Get
                Return My.Computer.FileSystem.SpecialDirectories.AllUsersApplicationData
            End Get
        End Property
        ''' <summary>
        ''' Points to the directory from which tha application started
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared ReadOnly Property ThisAppDirectory As String
            Get
                Return Environment.CurrentDirectory
            End Get
        End Property


        Public Shared Function WriteTextTo(Directory As String, Text As String, FileName As String)
            Try
                If FileIO.FileSystem.DirectoryExists(Directory) = False Then
                    FileIO.FileSystem.CreateDirectory(Directory)
                    FileIO.FileSystem.WriteAllText(Directory + FileName, Text, False)
                    Return True
                Else
                    FileIO.FileSystem.WriteAllText(Directory + FileName, Text, False)
                    Return True
                End If
                ' End With
            Catch ex As Exception
                Throw New Exception(ex.ToString())
                Return False

            End Try

            Return False
        End Function

    End Class
    Public Class Security
        Public Shared Property EmergencyPassword As String
            Get
                Return My.Settings.EmergencyPassword
            End Get
            Set(value As String)
                My.Settings.EmergencyPassword = value
                My.Settings.Save()
            End Set
        End Property
    End Class






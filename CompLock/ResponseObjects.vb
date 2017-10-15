Namespace ResponseOjects
    Class User
        Property username As String
        Property f_name As String
        Property s_name As String
        Property blocked As Boolean
        Property type As String
        Property login_time As String
        Property time_limit As String
        Property remaining_time As String
        Property used_time As String
    End Class

    Class Success
        Property message As String
        Property token As String
        Property user As User
    End Class

    Class Errors
        Property message
        Property reason
    End Class
End Namespace
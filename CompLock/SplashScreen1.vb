Public NotInheritable Class SplashScreen1

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


   
    Private Sub SplashScreen1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(1000)
    End Sub
End Class

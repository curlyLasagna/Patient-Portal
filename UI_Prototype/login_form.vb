Public Class login_form

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub recover(sender As Object, e As EventArgs) Handles Label1.Click
        recoveryForm.Show()
    End Sub

    Private Sub sign_in(sender As Object, e As EventArgs) Handles signIn_button.Click
        MainMenu.Show()
        Me.Close()
    End Sub
End Class

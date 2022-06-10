Public Class MainMenu ': Inherits Settings

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Settings.difficulty = "Normal"
        'Settings.lives = 7
        'Settings.sizeLimit = ""
        'Settings.enableAdvanced = False
        'Settings.revealWords = False

    End Sub

    Private Sub HngBtn_Click(sender As Object, e As EventArgs) Handles HngBtn.Click
        Hangman.Show()
        Me.Visible = False
    End Sub

    Private Sub HngBtn2P_Click(sender As Object, e As EventArgs) Handles HngBtn2P.Click
        _2PHangman.Show()
        Me.Visible = False
    End Sub

    Private Sub WrdSrchBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub WrdLstBtn_Click(sender As Object, e As EventArgs) Handles WrdLstBtn.Click
        WordList.Show()
        Me.Visible = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) 
        Settings.Show()
        Me.Visible = False
    End Sub

End Class

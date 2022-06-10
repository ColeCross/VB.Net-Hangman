Public Class Settings
    'global variables to handle user game settings
    Public Shared difficulty, sizeLimit, p1SizeLimit, p2SizeLimit As String
    Public Shared lives, p1Lives, p2Lives As Integer

    Public Shared enableAdvanced, revealWords As Boolean

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'default settings to "Normal" difficulty values
        NmlBtn.Checked = True
        handleDiff()
        DisAdvBtn.Checked = True
        DisAlertsBtn.Checked = True
        handleAdvanced()

    End Sub

    Private Sub DisAdvBtn_CheckedChanged(sender As Object, e As EventArgs) Handles DisAdvBtn.CheckedChanged

        handleAdvanced()

    End Sub

    Private Sub EnAdvBtn_CheckedChanged(sender As Object, e As EventArgs) Handles EnAdvBtn.CheckedChanged

        handleAdvanced()

    End Sub

    Private Sub SvBtn_Click(sender As Object, e As EventArgs) Handles SvBtn.Click

    End Sub

    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click

    End Sub

    Private Sub handleDiff()

        If NmlBtn.Checked = True Then
            lives = 7
            sizeLimit = ""
            p1Lives = lives
            p2Lives = lives
            p1SizeLimit = sizeLimit
            p2SizeLimit = sizeLimit

            LvsBox.Text = lives.ToString
            LmtBox.Text = sizeLimit
            P1LvsBox.Text = lives.ToString
            P1LmtBox.Text = sizeLimit
            P2LvsBox.Text = lives.ToString
            P2LmtBox.Text = sizeLimit

        ElseIf EsyBtn.Checked = True Then
            lives = 9
            sizeLimit = "<6"
            p1Lives = lives
            p2Lives = lives
            p1SizeLimit = sizeLimit
            p2SizeLimit = sizeLimit

            LvsBox.Text = lives.ToString
            LmtBox.Text = sizeLimit
            P1LvsBox.Text = lives.ToString
            P1LmtBox.Text = sizeLimit
            P2LvsBox.Text = lives.ToString
            P2LmtBox.Text = sizeLimit
        ElseIf HrdBtn.Checked = True Then
            lives = 5
            sizeLimit = ">6"
            p1Lives = lives
            p2Lives = lives
            p1SizeLimit = sizeLimit
            p2SizeLimit = sizeLimit

            LvsBox.Text = lives.ToString
            LmtBox.Text = sizeLimit
            P1LvsBox.Text = lives.ToString
            P1LmtBox.Text = sizeLimit
            P2LvsBox.Text = lives.ToString
            P2LmtBox.Text = sizeLimit
        End If

    End Sub

    Private Sub handleAdvanced()
        If DisAdvBtn.Checked = True Then
            enableAdvanced = False
            LvsBox.ReadOnly = True
            LmtBox.ReadOnly = True
            P1LvsBox.ReadOnly = True
            P1LmtBox.ReadOnly = True
            P2LvsBox.ReadOnly = True
            P2LmtBox.ReadOnly = True
            EnAlertsBtn.Enabled = False
            DisAlertsBtn.Enabled = False

        End If

        If EnAdvBtn.Checked = True Then
            enableAdvanced = True
            LvsBox.ReadOnly = False
            LmtBox.ReadOnly = False
            P1LvsBox.ReadOnly = False
            P1LmtBox.ReadOnly = False
            P2LvsBox.ReadOnly = False
            P2LmtBox.ReadOnly = False
            EnAlertsBtn.Enabled = True
            DisAlertsBtn.Enabled = True

        End If
    End Sub


End Class
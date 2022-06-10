Public Class WordList
    'get word list
    Dim FILE As String = "..\wordlist.txt"

    Dim add, del As String
    Dim index As Integer = 0

    Dim words As List(Of String)

    'load the wordlist on form load
    Private Sub WordList_Load(sender As Object, e As EventArgs) Handles Me.Load

        fillBox()

    End Sub

    'ignore input of numbers or special characters - only letters and backspace
    Private Sub AddBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AddBox.KeyPress
        If Not (Char.IsLetter(e.KeyChar)) And Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then e.Handled = True
    End Sub

    'handle adding to wordlist
    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click

        add = AddBox.Text

        'check if word is already in the list
        For Each Item In WrdLst.Items

            'if a word already exists, show warning and exit
            If add = Item Then

                WrningLbl.Visible = True

                Exit Sub

                'otherwise, keep the warning hidden
            Else WrningLbl.Visible = False

            End If

        Next

        'if the warning label is not visible, add word to the wordlist in the listBox and the actual file
        If WrningLbl.Visible = False Then

            'add word to wordlist file
            My.Computer.FileSystem.WriteAllText(FILE, add, True)

            'rewrite list of words
            fillBox()

        End If

        'empty textbox for more input
        AddBox.Text = ""

    End Sub

    'handle deletion of words from list
    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click

        'get selected item
        del = WrdLst.SelectedItem

        'get wordlist from file
        words = System.IO.File.ReadAllLines(FILE).ToList

        index = 0

        'search wordlist for chosen word
        For Each item In words

            'when correct word is found
            If del = item Then

                'delete from wordlist
                words.RemoveAt(index)

                'rewrite file with new wordlist
                System.IO.File.WriteAllLines(FILE, words)

                'rewrite list of words
                fillBox()

                Exit For

            End If

            index = index + 1

        Next
    End Sub

    Private Sub fillBox()

        Dim objReader As New System.IO.StreamReader(FILE)

        WrdLst.Items.Clear()

        'while there is still data to be read in the file, add each line to the listbox
        Do While objReader.Peek() <> -1
            WrdLst.Items.Add(objReader.ReadLine())
        Loop

        'close reader
        objReader.Close()
    End Sub

    'handle return to Menu via Main Menu Button
    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click
        MainMenu.Show()
        Me.Visible = False
    End Sub

    'handle Exit Button
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
        'MainMenu must close for the program to close fully
        MainMenu.Close()
    End Sub
End Class
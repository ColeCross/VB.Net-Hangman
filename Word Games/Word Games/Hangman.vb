Public Class Hangman ': Inherits Settings

    'get word list
    Dim FILE As String = "..\wordlist.txt"
    Dim words As List(Of String) = System.IO.File.ReadAllLines(FILE).ToList

    Dim word, blank, guess As String
    Dim rand, playerLives As Integer

    'on page load
    Private Sub Hangman_Load(sender As Object, e As EventArgs) Handles Me.Load

        'set playerLives
        playerLives = 7 'lives

        PictureBox1.Image = Image.FromFile("..\hangman\" + playerLives.ToString() + ".png")

        LivesBox.Text = playerLives

        'get a word from the list
        rand = genRandom(0, words.Count)
        word = words.ElementAt(rand).ToUpper()
        'temp for testing
        MsgBox(word)

        'generate a blank version of the game word
        WrdLbl.Text = generateBlank(word)

    End Sub

    'guess button handler to check user input
    Private Sub GuessBtn_Click(sender As Object, e As EventArgs) Handles GuessBtn.Click
        'set to lowercase to ignore input case
        guess = GuessBox.Text.ToUpper()

        'prevent user from guessing the same thing twice or empty guesses
        If UsedBox.Items.Contains(guess) Or guess = "" Or guess = " " Then
            Exit Sub
        End If

        'update game log
        LogBox.Items.Add("Player guesses " + guess + ".")

        'check input against chosen word
        guessCheck(guess)

        'automatically empty textbox
        GuessBox.Text = ""

    End Sub

    'function to generate the blank version of the game's chosen word
    Private Function generateBlank(word As String)

        'reset blank
        blank = ""

        'generate a "_" for each letter in the word and space them out
        For Each c As Char In word
            blank = blank + "_ "
        Next

        Return blank
    End Function

    'user input checking function
    Private Sub guessCheck(guess As String)

        'initiate fill as current state of the game word
        Dim fill As String
        fill = WrdLbl.Text

        'add user's guess to the "Used" box so it cannot be guessed again
        UsedBox.Items.Add(guess)

        'if guess is larger than 1 character, assume it is a word guess
        If guess.Length > 1 Then

            'if the user guesses the word correctly
            If guess = word Then

                'reset fill to empty
                fill = ""

                'make fill into a filled out game word (ie: v i c t o r y)
                For Each c As Char In word

                    fill = fill + c + " "

                Next

                'update game word to be filled in
                WrdLbl.Text = fill
                WrdLbl.Update()

                endGame("win")

                Exit Sub

            Else 'if the user guesses incorrectly

                'update game log
                LogBox.Items.Add("Player guessed incorrectly! The word is not " + guess + ".")

                'reduce player's lives and check for game over
                loseLife()

            End If

        Else 'if the guess is one character

            'if user gets a letter right
            If word.Contains(guess) Then

                'update game log: inform player they guessed correctly
                LogBox.Items.Add("Player correctly guessed the letter " + guess + "!")

                'update the blank game word to fill in all instances of the letter
                For i As Integer = 0 To (word.Length - 1)

                    If word.ElementAt(i) = guess Then

                        'replace the blanks in fill with the letter
                        fill = fill.Remove((i * 2), 1).Insert((i * 2), guess) '*(i * 2) due to the spaced out letters. Each blank's index is double the index of the letter in the word.

                        'update blank game word
                        WrdLbl.Text = fill
                        WrdLbl.Update()

                    End If

                Next

            Else 'if the user's guessed letter is not in the word

                'update game log: inform player their guess was wrong
                LogBox.Items.Add("Player has guessed incorrectly! There is no " + guess + ".")

                'reduce player's lives and check for game over
                loseLife()

            End If

        End If

        If (fill.Replace(" ", "") = word) Then
            endGame("win")
        End If


    End Sub

    'function to reduce the player's lives count and check for Game Over
    Private Sub loseLife()

        'reduce lives and update in GUI
        playerLives = playerLives - 1
        LivesBox.Text = playerLives

        'change image of the hangman to reflect current lives
        PictureBox1.Image = Image.FromFile("..\hangman\" + playerLives.ToString() + ".png")

        'check for Game Over
        If playerLives = 0 Then

            'end the game
            endGame("lose")

        Else 'if player still has leftover lives

            'update game log: tell player their remaining lives
            LogBox.Items.Add("Player has " + playerLives.ToString() + " guesses remaining.")

        End If
    End Sub

    'function that ends the game depending on outcome
    Private Sub endGame(outcome As String)

        If outcome = "lose" Then

            'update game log: notify player they won
            LogBox.Items.Add("GAME OVER! The word was " + word + "...")

        ElseIf outcome = "win" Then

            'update game log: notify player they won
            LogBox.Items.Add("Player guessed the word! The word was " + word + "!")

        Else

            LogBox.Items.Add("Something went wrong")

        End If

        'lock player out from guessing more regardess of outcome
        GuessBox.ReadOnly = True

        'update game log: tell player to play again
        LogBox.Items.Add("Click New Game to play again!")
    End Sub

    'generate a random number using a static variable to improve randomization
    Private Function genRandom(ByVal Min As Integer, ByVal Max As Integer)
        Static random As System.Random = New System.Random()
        Return Math.Floor(random.Next(Min, Max))
    End Function

    'handle "New Game" button click
    Private Sub NGBtn_Click(sender As Object, e As EventArgs) Handles NGBtn.Click

        'reset playerLives back to difficulty lives value
        playerLives = 7 'lives
        LivesBox.Text = playerLives

        'get a new game word
        rand = genRandom(0, words.Count)
        word = words.ElementAt(rand).ToUpper()
        'temp for testing
        MsgBox(word)

        'reset used box and game log
        UsedBox.Items.Clear()
        LogBox.Items.Clear()

        'allow guessing if previous result was Game Over
        GuessBox.ReadOnly = False

        'generate a blank version of the new game word
        WrdLbl.Text = generateBlank(word)
        WrdLbl.Update()

        'reset hangman
        PictureBox1.Image = Image.FromFile("..\hangman\" + playerLives.ToString() + ".png")

    End Sub

    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click
        MainMenu.Show()
        Me.Visible = False
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
        MainMenu.Close()
    End Sub

End Class
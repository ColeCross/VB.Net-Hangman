Public Class _2PHangman

    'get word list
    Dim FILE As String = "..\wordlist.txt"
    Dim words As List(Of String) = System.IO.File.ReadAllLines(FILE).ToList

    Dim word, word2, blank, guess As String

    Dim lives As Integer = 7
    Dim P2Lives = lives
    Dim turns As Integer = 0
    Dim rand As Integer

    Dim endFlag As Boolean = False

    'handle page load
    Private Sub _2PHangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'initialize hangman image
        PictureBox1.Image = Image.FromFile("..\hangman\7.png")
        PictureBox2.Image = Image.FromFile("..\hangman\7.png")

        'initialize player life counts
        LivesBox.Text = lives
        LivesBox2.Text = P2Lives

        'get 2 random words from the list
        rand = genRandom(0, words.Count)
        word = words.ElementAt(rand).ToUpper()
        rand = genRandom(0, words.Count)
        word2 = words.ElementAt(rand).ToUpper()

        'generate a blank version of both game words
        WrdLbl.Text = generateBlank(word)
        WrdLbl2.Text = generateBlank(word2)

        'start turn counter
        TurnCntBox.Text = turns.ToString()

        'pick player that gets to act first
        turnHandler()

        'reveal words for testing
        MsgBox("Words: " + word + ", " + word2)
    End Sub

    'function to generate blank game words
    Private Function generateBlank(word As String)

        'reset blank
        blank = ""

        'generate a "_" for each letter in the word and space them out
        For Each c As Char In word
            blank = blank + "_ "
        Next

        Return blank
    End Function

    'Player 1 Guess Button Handler
    Private Sub GuessBtn_Click(sender As Object, e As EventArgs) Handles GuessBtn.Click

        'set to uppercase to ignore input case
        guess = GuessBox.Text.ToUpper()

        'prevent player 1 from guessing the same thing twice or empty guesses
        If UsedBox.Items.Contains(guess) Or guess = "" Or guess = " " Then
            Exit Sub
        End If

        'add player 1's guess to their "Used" box so it cannot be guessed by them again
        UsedBox.Items.Add(guess)

        'update game log
        LogBox.Items.Add("Player 1 guesses " + guess + ".")

        'check input against game word and pass which player guessed
        guessCheck(guess, 1)

        'automatically empty textbox
        GuessBox.Text = ""

    End Sub

    'Player 2 Guess Button Handler
    Private Sub GuessBtn2_Click(sender As Object, e As EventArgs) Handles GuessBtn2.Click

        'set to uppercase to ignore input case
        guess = GuessBox2.Text.ToUpper()

        'prevent player 2 from guessing the same thing twice or empty guesses
        If UsedBox2.Items.Contains(guess) Or guess = "" Or guess = " " Then
            Exit Sub
        End If

        'add player 2's guess to their "Used" box so it cannot be guessed by them again
        UsedBox2.Items.Add(guess)

        'update game log
        LogBox.Items.Add("Player 2 guesses " + guess + ".")

        'check input against game word and pass which player guessed
        guessCheck(guess, 2)

        'automatically empty textbox
        GuessBox2.Text = ""

    End Sub

    'user input checking function
    Private Sub guessCheck(guess As String, player As Integer)

        'initiate fill as current state of the game word
        Dim fill As String
        Dim length As Integer

        'get correct player's word
        Select Case player
            Case 1
                fill = WrdLbl.Text
            Case 2
                fill = WrdLbl2.Text
        End Select

        'if guess is larger than 1 character, assume it is a word guess
        If guess.Length > 1 Then

            'check if the player guesses the word correctly and prevent accidental guessing of the opponent's word
            If (guess = word And player = 1) Or (guess = word2 And player = 2) Then

                'reset fill to empty
                fill = ""

                'make fill into a filled out game word (ie: v i c t o r y)
                For Each c As Char In word

                    fill = fill + c + " "

                Next

                'fill in the correct player's word
                Select Case player
                    Case 1
                        'update game word to be filled in
                        WrdLbl.Text = fill
                        WrdLbl.Update()
                    Case 2
                        'update game word to be filled in
                        WrdLbl2.Text = fill
                        WrdLbl2.Update()
                End Select

                endGame("win", player)

                Exit Sub

            Else 'if the user guesses incorrectly

                'update game log
                LogBox.Items.Add("Player " + player.ToString() + " guessed incorrectly! The word is not " + guess + ".")

                'reduce player's lives and check for game over
                loseLife(player)

            End If

        Else 'if the guess is one character in length

            'check if user gets a letter right and prevent checking wrong words
            If (word.Contains(guess) And player = 1) Or (word2.Contains(guess) And player = 2) Then

                'update game log: inform player they guessed correctly
                LogBox.Items.Add("Player " + player.ToString() + " correctly guessed the letter " + guess + "!")

                'get correct word length for the loop
                Select Case player
                    Case 1
                        length = word.Length - 1
                    Case 2
                        length = word2.Length - 1
                End Select

                'update the blank game word to fill in all instances of the letter
                For i As Integer = 0 To (length)

                    Select Case player
                        Case 1
                            If (word.ElementAt(i) = guess) Then
                                'replace the blanks in fill with the letter
                                fill = fill.Remove((i * 2), 1).Insert((i * 2), guess) '*(i * 2) due to the spaced out letters. Each blank's index is double the index of the letter in the word.

                                WrdLbl.Text = fill
                                WrdLbl.Update()
                            End If
                        Case 2
                            If (word2.ElementAt(i) = guess) Then
                                'replace the blanks in fill with the letter
                                fill = fill.Remove((i * 2), 1).Insert((i * 2), guess) '*(i * 2) due to the spaced out letters. Each blank's index is double the index of the letter in the word.

                                WrdLbl2.Text = fill
                                WrdLbl2.Update()
                            End If
                    End Select

                Next

            Else 'if the user's guessed letter is not in the word

                'update game log: inform player their guess was wrong
                LogBox.Items.Add("Player " + player.ToString() + " has guessed incorrectly! There is no " + guess + ".")

                'reduce player's lives and check for game over
                loseLife(player)

            End If

        End If

        'if either player has fully filled out their word, end the game
        'check by removing blank spaces from fill and checking against game words
        If (fill.Replace(" ", "") = word And player = 1) Or (fill.Replace(" ", "") = word2 And player = 2) Then
            endGame("win", player)
        End If

        'change current turn as long as the game has not ended
        If endFlag = False Then
            turnHandler()
        End If

    End Sub

    'function to reduce the player's lives count and check for Game Over
    Private Sub loseLife(player As Integer)

        'reduce correct player's lives and update in GUI
        Select Case player
            Case 1
                lives = lives - 1
                LivesBox.Text = lives
                PictureBox1.Image = Image.FromFile("..\hangman\" + lives.ToString() + ".png")
            Case 2
                P2Lives = P2Lives - 1
                LivesBox2.Text = P2Lives
                PictureBox2.Image = Image.FromFile("..\hangman\" + P2Lives.ToString() + ".png")
        End Select

        'check for either player reaching Game Over
        If (lives = 0 And player = 1) Or (P2Lives = 0 And player = 2) Then

            'end the game
            endGame("lose", player)

        Else 'if player still has leftover lives

            Select Case player
                Case 1
                    'update game log: tell player 1 their remaining lives
                    LogBox.Items.Add("Player 1 has " + lives.ToString() + " guesses remaining.")
                Case 2
                    'update game log: tell player 2 their remaining lives
                    LogBox.Items.Add("Player 2 has " + P2Lives.ToString() + " guesses remaining.")
            End Select

        End If
    End Sub

    'function that ends the game depending on outcome
    Private Sub endGame(outcome As String, player As Integer)

        If outcome = "lose" Then

            'update game log: notify player they lost and reveal words
            Select Case player
                Case 1
                    LogBox.Items.Add("PLAYER 1 GAME OVER! PLAYER 2 WINS!")
                Case 2
                    LogBox.Items.Add("PLAYER 2 GAME OVER! PLAYER 1 WINS!")
            End Select

            LogBox.Items.Add("The words were: " + word + ", " + word2)

        ElseIf outcome = "win" Then

            'update game log: notify player they won
            Select Case player
                Case 1
                    LogBox.Items.Add("Player 1 guessed their word! The word was " + word + "!")
                    LogBox.Items.Add("PLAYER 1 WINS! Player 2's word was " + word2)
                Case 2
                    LogBox.Items.Add("Player 2 guessed their word! The word was " + word2 + "!")
                    LogBox.Items.Add("PLAYER 2 WINS! player 1's word was " + word)
            End Select

        Else
            'debugging message if something other than win or lose comes through
            LogBox.Items.Add("Something went wrong")

        End If

        'lock players out from guessing more regardess of outcome
        GuessBox.ReadOnly = True
        GuessBox2.ReadOnly = True

        'update game log: tell player to play again
        LogBox.Items.Add("Click New Game to play again!")

        'reset current turn box
        CurTurnBox.Text = ""

        endFlag = True
    End Sub

    Private Sub turnHandler()
        Dim currentTurn = CurTurnBox.Text

        turns = turns + 1
        TurnCntBox.Text = turns.ToString()

        Select Case currentTurn
            'if game is just starting, randomly pick first player
            Case ""
                rand = genRandom(1, 2)

                Select Case rand
                    Case 1
                        CurTurnBox.Text = "Player 1"
                        GuessBox.ReadOnly = False
                        GuessBox2.ReadOnly = True
                    Case 2
                        CurTurnBox.Text = "Player 2"
                        GuessBox.ReadOnly = True
                        GuessBox2.ReadOnly = False
                End Select

                Exit Sub

            Case "Player 1"
                CurTurnBox.Text = "Player 2"
                GuessBox.ReadOnly = True
                GuessBox2.ReadOnly = False

            Case "Player 2"
                CurTurnBox.Text = "Player 1"
                GuessBox.ReadOnly = False
                GuessBox2.ReadOnly = True
        End Select

        TurnCntBox.Text = turns

    End Sub

    'generate a random number using a static variable to improve randomization
    Private Function genRandom(ByVal Min As Integer, ByVal Max As Integer)
        Static random As System.Random = New System.Random()
        Return Math.Floor(random.Next(Min, Max))
    End Function

    'handle "New Game" button click
    'reset game and generate new game words without reloading form or app
    Private Sub NGBtn_Click(sender As Object, e As EventArgs) Handles NGBtn.Click

        'reset lives back to 5
        lives = 7
        P2Lives = 7
        LivesBox.Text = lives
        LivesBox2.Text = P2Lives

        'get 2 words from the list
        rand = genRandom(0, words.Count)
        word = words.ElementAt(rand).ToUpper()
        rand = genRandom(0, words.Count)
        word2 = words.ElementAt(rand).ToUpper()

        'generate a blank version of both game words
        WrdLbl.Text = generateBlank(word)
        WrdLbl2.Text = generateBlank(word2)

        'reset used box and game log
        UsedBox.Items.Clear()
        UsedBox2.Items.Clear()
        LogBox.Items.Clear()

        'allow guessing if previous game ended
        GuessBox.ReadOnly = False
        GuessBox2.ReadOnly = False

        'generate a blank version of the new game words
        WrdLbl.Text = generateBlank(word)
        WrdLbl.Update()
        WrdLbl2.Text = generateBlank(word2)
        WrdLbl2.Update()

        'reset end of game flag
        endFlag = False

        'reset current turn and turn counter
        CurTurnBox.Text = ""
        turns = 0
        TurnCntBox.Text = turns.ToString()

        'get which player will guess first
        turnHandler()

        'reveal words for testing
        MsgBox("Words: " + word + ", " + word2)

        'reset hangman images
        PictureBox1.Image = Image.FromFile("..\hangman\7.png")
        PictureBox2.Image = Image.FromFile("..\hangman\7.png")

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
'Game Mode
'Includes hangman-style spell construction with time based gameplay instead of only strikes.

'The player must use the keyboard or on-screen buttons to guess letters in accomplishing their goals.
'They are given 0 to 3 free letters, depending on their difficulty
'These free letters are highlighted in yellow, so the user must still press them

'The game mode does NOT feature a pause menu, because pausing is for chumps
'The speed and pressure of the game is a key part of making the game work

'NORMAL MODE:
'The user, playing as one of three Harry Potter characters, is tasked with circumventing obstacles

'Geometry dash type course where obstacle is constantly moving towards player (Player is "moving forwards")
'There are 3 obstacle types for them to avoid: Fire, Rock, Ice
'The characters use spells that counter each obstacle type, and jump over the obstacle if they succeed.
'Upon getting a letter wrong, they are given a strike
'At 5 strikes, the control seize and the player collides with an obstacle, ending their run of the level

'BOSS FIGHT:
'The user, playing as Harry Potter himself, is tasked with defeating Voldemort
'Voldemort has a mana bar that charges over time or with incorrect letter guesses
'At max charge, he casts, taking away from Harry Potter's HP
'However, Harry can cast before Voldemort to both reset his mana and reduce his HP


'Both modes have difficulty scaling, making a dynamic experience that the user can change.


Public Class GameMode

    'VARIABLE INITIALIZATION BEGIN

    Dim btnInputKeys(25) As Button
    'Input button array (on screen buttons)

    Dim lblWordSpaces(30) As Label
    'Object Arrays

    Dim pntBtnLocation, pntObstacleDefault As Point
    'Point used to define button location
    'Point used to define default obstacle start point

    Dim shrReqWords As Short = shrMission + 2 + My.Settings.SaveDifficulty
    'Number of obstacles per level:
    '(Calculated based on mission number as well as difficulty)
    'Difficulty scaling translates to obstacle number as well as speed
    '       Easy    Normal  Hard    Master
    'Lvl 1  2       3       4       5
    'Lvl 2  3       4       5       6
    'Lvl 3  4       5       6       7

    'Boss Battle - Uses HP values:
    'Boss   5       6       7       8

    'Meaning that the player must cast more spells to kill at higher difficulties.

    Dim shrHarryHP As Short = 10
    'Harry Potter's HP in the final boss battle
    'Voldemort's damage scales with difficulty

    'DAMAGE SCALINGS:
    'Easy: 1 dmg
    'Normal: 2 dmg
    'Hard: 3 dmg
    'Master: 4dmg

    'Meaning that Harry can take 10/5/4/3 hits respectively at each difficulty

    Dim shrStrikes, shrMaxStrikes, shrEWords, shrAttackTimer, shrObstacleType, shrBossMana, shrJumpTick, shrMessageDuration As Short
    'Number of strikes
    'Number of strikes at which point player will lose
    'Number of elapsed words in normal mode
    'Used during boss battle for spellcasts
    'Used to determine obstacle type
    'How long until Voldemort casts spells
    'Used for jump animation
    'Determines how long an information message should be displayed

    Dim sglObstacleSpeed As Single
    'Used to determine obstacle movement speed
    'Scales with difficulty

    Dim strActiveWord As String
    'Word in queue

    Dim blnLtrCorrect, blnJump As Boolean
    'Used to track whether or not the user inputs a correct letter

    Dim strWords(,) As String = New String(3, 6) {{"Water", "Rain", "Spray", "Flood", "Shower", "Soak", "Splash"},
                                                   {"Smash", "Destroy", "Shatter", "Collapse", "Whack", "Blast", "Boom"},
                                                   {"Incendio", "Melt", "Fire", "Heat", "Flame", "Warmth", "Burn"},
                                                  {"Expelliarmus", "Stupefy", "Crucio", "Confringo", "Expulso", "Strike", "Defeat"}}
    'Array for storing each word
    'First Index: Obstacle Type (0 to 3, and 4 for Voldemort)
    '0: Fire
    '1: Rock
    '2: Ice
    '3: Boss fight
    'Second Index: Random Word (from 0 to 6)

    Dim strVoldemortSpells() As String = New String(3) {"Crucio", "Avada Kedavra", "Imperio", "Morsmorde"}
    'Voldemort's damaging spells

    'VARIABLE INITIALIZATION END

    Private Sub GameMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BG SETUP BEGIN

        pnlJumper.Controls.Remove(pbxObstacle)
        pnlJumper.Controls.Remove(pbxCharacter)
        pbxBG.Controls.Add(pbxObstacle)
        pbxBG.Controls.Add(pbxCharacter)

        KeyPreview = True
        'Allow key input

        Randomize()
        'Make rnd more random

        pntObstacleDefault.X = pnlJumper.Width * 4 / 5
        pntObstacleDefault.Y = pbxObstacle.Top

        'Declare button array

        pntBtnLocation.X = 20
        pntBtnLocation.Y = 20

        'Button creation
        For btnCounter = 0 To 25
            btnInputKeys(btnCounter) = New Button

            btnInputKeys(btnCounter).Width = 40
            btnInputKeys(btnCounter).Height = 40
            'Set dimensions

            btnInputKeys(btnCounter).FlatStyle = FlatStyle.Flat
            btnInputKeys(btnCounter).Text = Chr(btnCounter + 65)
            'Makes text between A and Z

            btnInputKeys(btnCounter).BackColor = Color.LightGray
            btnInputKeys(btnCounter).Font = New Font("Cambria", 14)
            'Appearance

            btnInputKeys(btnCounter).TabStop = False
            btnInputKeys(btnCounter).Location = pntBtnLocation
            'Technical

            'Location offset
            'The buttons should be in 2 rows of 13 each
            'When the button count passes 13, the next row starts
            'If the button count does not surpass 13, only a horizontal offset is created
            If (btnCounter + 1) Mod 13 = 0 Then
                pntBtnLocation.X = 20
                pntBtnLocation.Y += 40
            Else
                pntBtnLocation.X += 40
            End If

            'Add Handler
            AddHandler btnInputKeys(btnCounter).Click, AddressOf btnInputClick
            pnlInput.Controls.Add(btnInputKeys(btnCounter))

        Next
        'BUTTON SETUP END

        sglObstacleSpeed = pnlJumper.Width / 400 + My.Settings.SaveDifficulty * 0.5
        'Determine obstacle speed from form width (differs computer to computer)

        pbxBG.Width = 2700
        pbxBG.Left = 0
        'Setup background of platforming portion - it must be exactly 2700 in width to accomodate the full tiling image

        shrMaxStrikes = 10 - My.Settings.SaveDifficulty

        Select Case shrMission
            Case 0
                pbxCharacter.Image = My.Resources.Ron
            Case 1
                pbxCharacter.Image = My.Resources.Hermione
            Case 2
                pbxCharacter.Image = My.Resources.Hedwig
            Case 3
                pbxCharacter.Image = My.Resources.Harry
                pnlBossStats.Visible = True
                pnlNormalStats.Visible = False
                'Boss stats are normally hidden and instead normal stats show. This flips it around.
        End Select

        If shrMission < 3 Then
            shrStrikes = 0
            lblStrikes.Text = "Strikes: " & shrStrikes & "/" & shrMaxStrikes
            lblWordsRemain.Text = "Remaining" & vbCrLf & "Obstacles: " & shrReqWords - shrEWords

            InfoMessage("Hello wizard, your goal is to jump over all of the obstacles that Voldemort has sent to you using your magic spells!", 8, Color.Yellow)
            'Give user initial prompt
        Else
            lblBossHP.Width = 14 / 15 * pnlBossStats.Width
            lblBossMana.Width = 0
            lblHarryHP.Width = 14 / 15 * pnlBossStats.Width
            'Initialize HP and Mana Bars

            InfoMessage("Be careful! Voldemort feeds off of mistakes! He will get mana if you mess up or take too long!", 8, Color.Yellow)
            'Give user a warning
        End If
        'Displays all necessary elements at startup for UI

        'BG SETUP END

        'FORM START BEGIN

        'Start fadein
        tmrFadeIn.Start()
    End Sub


    'Section 1: User Input for Game

    'INPUT METHOD 1 - Onscreen buttons
    Private Sub btnInputClick(sender As System.Object, e As System.EventArgs)

        sender.enabled = False
        sender.backcolor = Color.DimGray

        LetterCheck(sender.text)
        'Send check command, with given letter
    End Sub

    'INPUT METHOD 2 - Keyboard
    Private Sub GameMode_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Space And blnDevMode = True Then
            'Cheats used to give user an advantage
            Select Case InputBox("Cheat Command?", "Cheat Menu")
                Case "PushBack"
                    pbxObstacle.Left += 100
                    'Push obstacle back to buy more time
                    MessageBox.Show("Obstacle pushed back.", "Success")
                Case "NextWord"
                    WordGen(Int(7 * Rnd()))
                    'Generate the next word, solving it in the processs
                    MessageBox.Show("New word generated.", "Success")
                Case "BossMana"
                    BossCycle(True)
                    'Reset Voldemort's mana
                    MessageBox.Show("Voldemort mana reset.", "Success")
                Case "KillerMove"
                    shrEWords = shrReqWords - 1
                    'Make the level OTK
                    MessageBox.Show("You now have OTK.", "Success")
                Case Else
                    MessageBox.Show("Command not recognized.", "Error")
            End Select
        End If
        'Cheat Console

        If e.KeyValue <= 90 And e.KeyValue >= 65 Then
            'Check if input is within A to Z
            If btnInputKeys((e.KeyValue) - 65).Enabled = True Then
                'Check if button is enabled
                'We need the double if statement because otherwise you could have prolems with the code
                'Checkig a button outside the array

                'Filters only A-Z input
                'Also checks that button is enabled
                btnInputKeys((e.KeyValue) - 65).Enabled = False
                LetterCheck(Chr(e.KeyValue))
            End If

            'Bonus useability element: user can exit gamemode using esc
        ElseIf e.KeyCode = Keys.Escape Then
            btnReturnMenu.PerformClick()
        End If
    End Sub

    'An additional comment on input:
    'Most hangman games using just buttons would be able to make the buttons disable using just sender.enabled = false.
    'Here, we also have to deal with keyboard input
    'I could have done 2 separate paths using sender and another one for keyboard, but I believe that it would be too inefficient.
    'I thus used stuff like btnInputKeys((e.KeyValue) - 65).Enabled = False


    'Section 2: Timers
    'These play a key role in making the game fun, and are a huge factor in ensuring that the basic idea
    'of the game works
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += My.Settings.FadeSpeed
        Else
            tmrFadeIn.Stop()

            WordGen(Int(7 * Rnd()))
            'Calls to WordGen function to generate a random word

            If blnFirstTime = True Then
                'Show a tutorial to new players
                'This only occurs on the first playthrough of any level upon program startup.
                tmrMessageRotation.Stop()
                'Pause infomessage temporarily

                MessageBox.Show("Hello! Here's a quick lesson on the game:" & vbCrLf & vbCrLf &
                                "Inputting Letters: Use your computer's keyboard or the onscreen buttons." & vbCrLf & vbCrLf &
                                "Green means a correct guess and red means incorrect." & vbCrLf & vbCrLf &
                                "The highlighted yellow letters are free and are part of the word. Use them!" & vbCrLf & vbCrLf &
                                "There will be messages that pop up near the top. Read them!", "Tutorial")

                blnFirstTime = False
                tmrMessageRotation.Start()
                'Restart timer
            End If

            If shrMission = 3 Then
                tmrBossSequencer.Start()
                'Start boss fight if it's boss fight
            Else
                tmrGameTick.Start()
                'Start normal mode if normal (shrmission from 0 to 2)
            End If
        End If
    End Sub

    Private Sub tmrGameTick_Tick(sender As Object, e As EventArgs) Handles tmrGameTick.Tick
        'Timer mechanic to add challenge to game - Normal Mode

        pbxCharacter.Left += sglObstacleSpeed

        If pbxBG.Left <= -1800 Then
            'Reset BG image to ensure tiling
            'MUST be -1800 to create seamless experience (BG Tiles perfectly)
            'Must also reset obstacle and character position
            pbxCharacter.Left -= 1800
            pbxObstacle.Left -= 1800

            pbxBG.Left = 0
        Else
            pbxBG.Left -= sglObstacleSpeed
        End If


        If pbxObstacle.Left <= pbxCharacter.Left + pbxCharacter.Width Then
            tmrGameTick.Stop()
            MessageBox.Show("Oh, no, you lose! The correct word was: " & strActiveWord & ".", "Game Over")
            'RESULT = LOSE
            Ending(3)
            'Lose on obstacle collision
        End If
    End Sub

    Private Sub tmrJumpSequencer_Tick(sender As Object, e As EventArgs) Handles tmrJumpSequencer.Tick
        pbxCharacter.Left += 2 * sglObstacleSpeed

        If pbxBG.Left <= -1800 Then
            'Reset BG image to ensure tiling
            'MUST be -1800 to create seamless experience (BG Tiles perfectly)
            'Must also reset obstacle and character position
            pbxCharacter.Left -= 1800
            pbxObstacle.Left -= 1800
            pbxBG.Left = 0
        Else
            pbxBG.Left -= 2 * sglObstacleSpeed
        End If
        'Move obstacle towards player at predetermined speed

        If pbxObstacle.Left - pnlJumper.Width / 3 <= pbxCharacter.Left Then
            Select Case shrJumpTick
                Case 0 To 50
                    pbxCharacter.Top -= 5
                Case 100 To 150
                    pbxCharacter.Top += 5
                Case Is >= 150

                    'JUMP ANIMATION DONE

                    tmrJumpSequencer.Stop()
                    'Stop jump animation

                    'Don't reset obstacle position just yet - we need to make sure game is not done

                    ConditionalReset()

            End Select

            shrJumpTick += 1
        End If
    End Sub

    'Section 3: Subroutines

    'Word Generation
    Sub WordGen(shrWordNum As Short)
        'Used to generate words
        'shrWordNum is input value to make random word

        'Determine what obstacle is to be generated
        If shrMission <> 3 Then
            shrObstacleType = Int(3 * Rnd())
        Else
            shrObstacleType = 3
        End If

        strActiveWord = strWords(shrObstacleType, shrWordNum)
        'Determines current word from list
        'Look at array for a better sense of how it works
        '1st factor: Obstacle Type (Fire,  Rock, Ice)
        '2nd factor: Random word (1 of 7)

        If blnDevMode = True Then
            MessageBox.Show(strActiveWord, "DevCheat - word")
            'Used to cheat
        End If

        'WORD SPACE GENERATION
        For intCounter = 0 To Len(strActiveWord) - 1
            lblWordSpaces(intCounter) = New Label
            lblWordSpaces(intCounter).Font = New Font("Cambria", 14, FontStyle.Underline)
            'Declare new label

            'Set parameters

            'Special case - space
            If Mid(strActiveWord, intCounter + 1, 1) Like " " Then
                lblWordSpaces(intCounter).Text = ""
            Else
                lblWordSpaces(intCounter).Text = "_"
            End If

            'Label Dimensions
            lblWordSpaces(intCounter).Width = 30
            lblWordSpaces(intCounter).Height = 50

            'Positioning
            lblWordSpaces(intCounter).Location = New Point(27 * intCounter + pnlInput.Width / 15, pnlInput.Height * 3 / 4)
            'One row on top

            'Add to form
            pnlInput.Controls.Add(lblWordSpaces(intCounter))
        Next
        'END WORD SPACE GENERATION

        'Initialize obstacle
        '0: Fire
        '1: Rock
        '2: Ice
        '3: Boss fight
        'Displays appropriate obstacle image depending on type
        Select Case shrObstacleType
            Case 0
                pbxObstacle.Image = My.Resources.Fire
                lblObstacleType.Text = "Obstacle Type: Fire"
            Case 1
                pbxObstacle.Image = My.Resources.Rock
                lblObstacleType.Text = "Obstacle Type: Rock"
            Case 2
                pbxObstacle.Image = My.Resources.Ice
                lblObstacleType.Text = "Obstacle Type: Ice"
            Case 3
                pbxObstacle.Image = My.Resources.VoldemortCharge0
        End Select

        'Reset buttons
        'Ensure that they are all enabled (method runs every time new word is generated)
        Dim ctlReset As Control

        For Each ctlReset In pnlInput.Controls
            If TypeOf (ctlReset) Is Button Then
                ctlReset.Enabled = True
                ctlReset.BackColor = Color.LightGray
            End If

        Next

        shrEWords += 1
        'Add 1 to elapsed words so then it's like word 1, word 2, word 3...

        If My.Settings.SaveDifficulty <> 3 Then
            'ADD PREEXISTING LETTERS IF NEEDED
            For FreeLetterCount = 1 To 3 - My.Settings.SaveDifficulty
                'Give user a set number of free letters
                'REPEAT this:
                '3 times for Easy
                '2 times for Normal
                '1 time for Hard

                'How it works:
                'You get a letter from the word and highlight it as a free thing on the button interface

                btnInputKeys(Asc(UCase(Mid(strActiveWord, FreeLetterCount, 1))) - 65).BackColor = Color.Yellow
                'Make the corresponding button on the input panel yellow (Lots of stacked functions, I know I know)
            Next
        End If

    End Sub

    'Used to verify input letters
    'Occurs upon every button press or keypress
    Sub LetterCheck(chrLetter As Char)
        If shrMission <> 3 Then
            tmrGameTick.Stop()
        Else
            tmrBossSequencer.Stop()
            'Pauses game momentarily to check
            'Normals use a different timer from boss fight for simplicity sake
            'I know I could use 1 timer with an if but it's a bit too much for what I need
        End If

        My.Settings.GuessLetters += 1
        'Add 1 to total guessed letters (Stats)

        blnLtrCorrect = False
        'Assumes that letter is incorrect to begin with



        'MAIN CHECKING ALGORITHM - Surprisingly simple
        For PositionCount = 1 To Len(strActiveWord)
            If Mid(UCase(strActiveWord), PositionCount, 1) = chrLetter Then
                'Scans entire word to find letter
                'Meaning that it can be found multiple times

                lblWordSpaces(PositionCount - 1).Text = chrLetter
                'Replaces the corrosponding entry in the word spaces with the letter

                blnLtrCorrect = True
            End If
        Next

        If blnLtrCorrect = False Then
            'IF LETTER IS INCORRECT

            'Add letter to list of incorrect letters
            If lblLtrWrong.Text = "Incorrect Letters:" Then
                'If it's the first one, the formatting is a bit different
                lblLtrWrong.Text += " " & chrLetter
                'No comma for the first one
            Else
                lblLtrWrong.Text += ", " & chrLetter
            End If

            btnInputKeys(Asc(UCase(chrLetter)) - 65).BackColor = Color.Red
            'Make the corresponding button's backcolor RED for INCORRECT

            If shrMission <> 3 Then
                'If user is playing normal mode
                InfoMessage("Wrong!", 2, Color.Red)

                shrStrikes += 1
                lblStrikes.Text = "Strikes: " & shrStrikes & "/" & shrMaxStrikes

                If shrStrikes >= shrMaxStrikes Then
                    'If user goes over strike limit, disable all buttons and make obstacle collide into player
                    'Cruel ending, I know.
                    ButtonDisable(Color.Red)
                    sglObstacleSpeed *= 3
                    'Make their death faster >:D

                    'Lose on strikes
                End If

                tmrGameTick.Start()
                'Continue game (if user is in normal - tmrgametick)

            Else
                InfoMessage("Wrong! Voldemort gains 1 mana.", 2, Color.Red)

                'If user is in boss fight
                BossCycle(False)
                tmrBossSequencer.Start()
                'Instead, incorrect letter guesses give Voldemort mana.
            End If


        Else
            'If nothing is wrong --> letter is correct
            'Continue checking
            'IF LETTER IS CORRECT
            My.Settings.CorrectLetters += 1
            'Add 1 to correct letter guesses (Stats)

            btnInputKeys(Asc(UCase(chrLetter)) - 65).BackColor = Color.Green
            'Make the corresponding button's backcolor GREEN for CORRECT

            'CHECK if word is complete
            Dim blnWordComplete As Boolean = True
            'Start, assuming that word is complete

            'WORD Checking
            For PositionCount = 0 To Len(strActiveWord) - 1
                If lblWordSpaces(PositionCount).Text Like "_" Then
                    blnWordComplete = False
                End If
                'If there is still a blank, the word is not complete.
                'Else, word is complete
            Next

            'DEPENDING OF WORD COMPLETTION:
            If blnWordComplete = True Then
                'If a word is completed

                My.Settings.CorrectWords += 1
                'Add 1 to word count (Stats)

                'Disable all buttons to prevent input during post-word sequence
                ButtonDisable(Color.DimGray)

                InfoMessage("Nice!", 2, Color.Green)


                If shrMission <> 3 Then
                    shrStrikes = 0
                    lblStrikes.Text = "Strikes: " & shrStrikes & "/" & shrMaxStrikes
                    'Reset strikes
                    lblWordsRemain.Text = "Remaining" & vbCrLf & "Obstacles: " & shrReqWords - shrEWords

                    'NORMAL GAME MODE
                    shrJumpTick = 0
                    tmrJumpSequencer.Start()
                    'Start jump sequencing
                Else
                    'If user is in boss fight

                    lblBossHP.Width = 14 / 15 * pnlBossStats.Width * (shrReqWords - shrEWords) / shrReqWords
                    'Update Boss HP (correlated to shrEWords and shrReqWords - already accounted for before)

                    BossCycle(True)

                    'BOSS BATTLE - CHECKING
                    ConditionalReset()
                End If

            ElseIf shrMission <> 3 Then
                'If nothing is wrong, and word is not complete, and gamemode is normal
                tmrGameTick.Start()
                'Continue game
            Else
                'If nothing is wrong, and gamemode is boss fight
                tmrBossSequencer.Start()
                'Continue game
            End If
        End If
    End Sub

    Sub ConditionalReset()
        'WOO SAVING MORE LINES OF CODE YEAH
        'Reset letter blanks
        For PositionCount = 0 To Len(strActiveWord) - 1
            'Destroys array and rebuilds it afterwards
            pnlInput.Controls.Remove(lblWordSpaces(PositionCount))
            lblWordSpaces(PositionCount).Text = "_"
        Next

        lblLtrWrong.Text = "Incorrect Letters:"
        'Reset incorrect letters list

        'IF ALL WORDS ARE DONE
        If shrEWords >= shrReqWords Then
            If shrMission <> 3 Then
                MessageBox.Show("Congratulations, you got past all of the obstacles!", "Good Job!")
            Else
                MessageBox.Show("Congratulations, you have defeated Voldemort!", "Good Job!")
            End If

            If My.Settings.SaveState < shrMission Then
                'If the user is beating the level for the first time, unlock the next level

                My.Settings.SaveState += 1
                'Move on to next level

                'RESULT = WIN
                Ending(1)
            Else

                'IF ALL WORDS ARE DONE BUT THE LEVEL HAS ALREADY BEEN PLAYED
                'DEV only
                If blnDevMode = True Then
                    MessageBox.Show("Savestate >= shrmission")
                End If
                'Shown in dev mode for debugging

                'RESULT = WIN
                Ending(2)
            End If

        Else
            If shrMission <> 3 Then
                pbxObstacle.Left = pbxBG.Left * -1 + pntObstacleDefault.X
                'Reset obstacle position
                WordGen(Int(7 * Rnd()))
                'Generate next word
                tmrGameTick.Start()
                'Continue game

            ElseIf shrReqWords - shrEWords = 1 Then
                WordGen(0)
                'THIS IS TO FOLLOW HARRY POTTER CANON
                'WE BETTER GET MARKS FOR THIS :)
                'If Harry is on his final spellcast to defeat Voldemort, he must cast Expelliarmus
            Else
                'Continue with boss fight
                WordGen(Int(7 * Rnd()))
                'Generate next word
                tmrBossSequencer.Start()
                'Continue game
            End If

        End If
    End Sub

    Sub ButtonDisable(clrButton As Color)
        'Disable all non-affected buttons in input section
        'USED TO SAVE CODE (efficiency)
        Dim ctlReset As Control

        For Each ctlReset In pnlInput.Controls
            If TypeOf (ctlReset) Is Button And ctlReset.BackColor = Color.LightGray Then
                'Checks that control is button and that button's colour is gray (has not yet been affected)
                ctlReset.Enabled = False
                ctlReset.BackColor = clrButton
            End If
        Next
    End Sub

    Sub Ending(shrCause As Short)
        Select Case shrCause
            Case 1 To 2
                shrCutSceneMode = 1
                'Endings 1 and 2 are victories --> change to victory mode
            Case Is >= 3
                shrCutSceneMode = 2
                'Endings 3 and 4 are losses --> change to lose mode
        End Select
        My.Settings.Save()
        'Save States just in case
        CutScene.Show()
        'Show resulting cutscene
        Me.Close()
    End Sub

    Sub BossCycle(ManaReset As Boolean)
        'Boss interaction mode
        'Additional boolean used to determine mode of operation
        'False: Business as ususal - Charge up mana or cast
        'True: Reset mana quantity - used when player casts and takes away Boss HP

        If ManaReset = True Then
            shrBossMana = 0
            lblBossMana.Width = 0
        Else
            Select Case shrBossMana
                Case 1
                    'Voldemort is at half mana charge
                    pbxObstacle.Image = My.Resources.VoldemortCharge1
                    InfoMessage("Voldemort is almost charged! Don't let him fully charge, or he will damage you!", 4, Color.Yellow)
                Case 3
                    'Voldemort is fully charged
                    pbxObstacle.Image = My.Resources.VoldemortCharge2
                    InfoMessage("Voldemort is fully charged! He will cast on his next opportunity!", 4, Color.Orange)
            End Select

            'CHECK IF VOLDEMORT SHOULD CAST
            If shrBossMana >= 4 Then
                'Voldemort must cast spell

                tmrBossSequencer.Stop()

                MessageBox.Show("Voldemort casts " & strVoldemortSpells(Int(4 * Rnd())) & " and you take " & My.Settings.SaveDifficulty + 1 & " damage!", "Oh no!")
                shrHarryHP -= (My.Settings.SaveDifficulty + 1)
                lblHarryHP.Width = 14 / 15 * pnlBossStats.Width * shrHarryHP / 10
                'Harry takes damage, update damage

                BossCycle(True)
                'Reset boss mana

                pbxObstacle.Image = My.Resources.VoldemortCharge0

                If shrHarryHP <= 0 Then
                    MessageBox.Show("Oh, no, you lose! The correct word was: " & strActiveWord & ".", "Game Over")
                    'RESULT = LOSE
                    Ending(4)
                    'Lose on HP Loss in boss battle
                Else
                    tmrBossSequencer.Start()
                    'If HP > 0, continue game
                End If

            Else
                'VOLDEMORT DOES NOT CAST - GET MORE MANA
                'Voldmort is still charging mana
                shrBossMana += 1
                lblBossMana.Width = 14 / 15 * pnlBossStats.Width * shrBossMana / 4
                'Reference width is 14/15 of the panel
                'Mana bar's width then scales with his mana
            End If
        End If

    End Sub

    Sub InfoMessage(strMessage As String, shrDuration As Short, clrColour As Color)
        shrMessageDuration = shrDuration
        'Set duration of message in seconds
        lblDispInfo.Text = strMessage
        'The message itself in string form
        lblDispInfo.ForeColor = clrColour
        'The message colour
        tmrMessageRotation.Start()

    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'If the user wants to return to the menu, give confirmation prompt.
        Select Case MsgBox("Are you sure you want to return to the menu? Your progress will NOT be saved!", MsgBoxStyle.YesNo, "Return to Menu?")
            Case MsgBoxResult.Yes
                My.Computer.Audio.Stop()
                MainMenu.Show()
                Me.Close()
        End Select
    End Sub

    Private Sub tmrBossSequencer_Tick(sender As Object, e As EventArgs) Handles tmrBossSequencer.Tick
        'Timer ticks once every 5 seconds and adds mana to Voldemort or lets him cast

        BossCycle(False)
    End Sub

    Private Sub tmrMessageRotation_Tick(sender As Object, e As EventArgs) Handles tmrMessageRotation.Tick
        'ANNOUNCEMENT/MESSAGING SYSTEM TO PLAYER

        If shrMessageDuration <= 0 Then
            'If message has gone past expiry then display a level default message
            lblDispInfo.ForeColor = Color.WhiteSmoke
            'Reset label colour

            If shrMission <> 3 Then
                'In normals
                If My.Settings.SaveDifficulty < 3 Then
                    'If user is playing on the easier difficulties
                    lblDispInfo.Text = "Guess the letters correctly to make the jumps! Try to not mess up! The highlighted letters are free!"
                Else
                    'If user is playing on MASTER
                    lblDispInfo.Text = "Guess the letters correctly to make the jumps! Try to not mess up! Good Luck!"
                End If
            Else
                'In boss fight
                lblDispInfo.Text = "Voldemort will attempt to cast spells to damage you! You must cast spells to defeat him before he does to you!"
            End If
        End If

        shrMessageDuration -= 1
        'Tick one down
    End Sub
End Class
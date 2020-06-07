'Lotek's "Harry Potter and the Trials of Hogwarts"
'ICS2O-02 2016 - 2017 
'Mr. Hudson

'By Derek Fraser, Kevin Gu, Willard Ma, and Mingde Yin

'Music from Harry Potter, Riot Games

'Build Verson: Version 1.2.1
'2017/04/05
'Minor patch to make some final adjustments

'New:
'- Player and obstacle now correctly display transparency using parenting

'DESCRIPTION OF PROGRAM:
'Hi, Mingde here. I'll show you through the ins and outs of the program so that everything makes sense.
'Hogwarts is under attack, from none other than Lord Voldemort. Your mission, if you choose to accept it, is to follow the journeys of 4
'of Hogwarts' finest in their plot to stop Voldemort! The dramatic 5 to 15 minute long story features exciting heros and even more exciting
'encounters. Will you be able to save the world from evil?

'Harry Potter and the Trials of Hogwarts is a dramatic telling of a potential attack on the famous institution set in the Harry Potter universe.
'The game's purpose is to provide a fun yet challenging hangman-style game to grade 5 children, with a Harry Potter themed twist.
'HPTH features a rich story with over 27 lines of non-voiced dialogue (WOW! So cool!) and exactly 32 words that will be randomly selected
'to create the best RNG experience possible.

'Special Features:
'- Dynamic save system with importing and exporting - so you can take HPTH wherever you go
'- Dynamic sound system with active sound detection, to make the user experience as seamless as possible
'  (usually .play overrides the current track and will make everything play again, which is annoying and less of a smooth experience for the player)
'- Use of my.settings for persistence
'- High quality ANIMATED menu screen which took me OVER AN HOUR to get working (because it's pretty hard to get animations into vb)

'Outline:
'0: IntroSplash
'- A simple intro screen

'1. Main Menu:
'- Allows user to navigate to other forms, including options, credits, charsetup, and lore.
'- Features an optional animated menu screen that I spent an hour and a half working on (it looks pretty cool though)
'1a. Options:
'- The user can adjust fade speed, sound (off/on), toggle menu screen (and by consequence a compatability mode), and export, import or reset their save
'1b. Credits:
'- The user can see who worked on the game and also access cheats
'CHEATS:
'The user can activate cheats by clicking on the text in the credits several times until a prompt comes up.
'Cheats allow the user to generate new words at will and push back the obstacle, for example.

'2. Character Setup Process:
'- The user defines a username, play difficulty, and character to play as

'3. Cutscene and Ending:
'- Occurs right before and after a level

'4. GameMode:
'Includes hangman-style spell construction with time based gameplay instead of only strikes.

'NORMAL MODE:
'The user, playing as one of three Harry Potter characters, is tasked with circumventing obstacles

'Geometry dash type course where obstacle is constantly moving towards player (Player is "moving forwards")
'- There are 3 obstacle types for them to avoid: Fire, Rock, Ice
'- The characters use spells that counter each obstacle type, and jump over the obstacle if they succeed.
'- Upon getting a letter wrong, they are given a strike
'- At 5 strikes, the control seize and the player collides with an obstacle, ending their run of the level

'BOSS FIGHT:
'- The user, playing as Harry Potter himself, is tasked with defeating Voldemort
'- Voldemort has a mana bar that charges over time or with incorrect letter guesses
'- At max charge, he casts, taking away from Harry Potter's HP
'- However, Harry can cast before Voldemort to both reset his mana and reduce his HP


'- Both modes have difficulty scaling, making a dynamic experience that the user can change.



Public Class MainMenu


    Dim blnFade As Boolean
    'Used to determine whether the form is fading in or out
    'False: Fading In
    'True: Fading Out

    Dim strSplashText() As String = New String(5) {"Tip: The animated menu screen can be disabled in the options menu if your computer runs too slow.",
                                                   "Tip: The obstacles move faster with higher difficulties! Start easy if you're new to the game!",
                                                   "Did you know? This game was written with just over 2000 lines of code!",
                                                   "Tip: You can change a variety of settings in the options menu. Check it out!",
                                                   "Did you know? This game has exactly 32 spells to choose from! See if you can find them all!",
                                                   "Tip: You can use the keyboard to navigate in the menus!"}
    'Splash text that will be randomly selected to be displayed on the menu screen

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form loads

        KeyPreview = True
        'Enable key input   

        'BG SETUP BEGIN
        Randomize()
        'Make rnd more random

        'SHOWCASE OF DYNAMIC MUSIC SYSTEM:
        'If the track to be played is already playing, then you don't need to play it
        'Otherwise, you do need it
        If My.Settings.Sound = True And shrMusicActive <> 1 Then
            shrMusicActive = 1
            'Play the DragonTrainer track
        End If

        If My.Settings.SaveState = -2 Then
            btnStartCont.Text = "Start"
        Else
            btnStartCont.Text = "Continue"
        End If

        lblSplashText.Text = strSplashText(Int(6 * Rnd()))
        'Create a splash text from the list

        If My.Settings.MenuAnim = True Then
            pbxBGAnim.Visible = True
        Else
            pbxBGAnim.Visible = False
        End If
        'Determines visibility of the animated menu screen based on my.settings

        'BG SETUP END

        'START FADEIN
        blnFade = False
        tmrFadeInOut.Start()
        'Start timer in fade in mode
    End Sub

    Private Sub btnStartCont_Click(sender As Object, e As EventArgs) Handles btnStartCont.Click
        'The Start/Continue button serves a dual purpose
        'If no save if present, the user must create a character
        'Otherwise, if one is already present, go straight to level select
        'The options menu can also affect this

        If My.Settings.SaveState = -2 Then
            My.Settings.GuessLetters = 0
            My.Settings.CorrectWords = 0
            My.Settings.CorrectLetters = 0
            'Reset Stats

            Lore.Show()
            Me.Close()
            'If there is a blank save, display lore, set up character, then go to level select
        Else
            LevelSelect.Show()
            Me.Close()
            'If there already is a save, continue.
        End If
    End Sub

    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        'The user want to see the options menu
        'Show as dialog, since both the mainmenu and options forms should be visible at same time
        Options.ShowDialog()
    End Sub

    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeInOut.Tick
        'Handles the fading in and out of the form
        'Remember: blnFade = False means fadein; True means fadeout

        If Me.Opacity < 1 And blnFade = False Then
            'Fadein; process is not yet complete --> keep going
            Me.Opacity += My.Settings.FadeSpeed
        ElseIf Me.Opacity = 1 And blnFade = False Then
            'Fadein; process is complete --> stop
            tmrFadeInOut.Stop()
        ElseIf Me.Opacity > 0 And blnFade = True Then
            'Fadeout; process is not yet complete --> keep going
            Me.Opacity -= My.Settings.FadeSpeed
        Else
            'Fadeout; process is complete --> stop and CLOSE
            tmrFadeInOut.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub btnCredits_Click(sender As Object, e As EventArgs) Handles btnCredits.Click
        'Show as dialog, since both the mainmenu and credits forms should be visible at same time
        Credits.ShowDialog()
        'Show credits
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'If the user wants to exit the game
        Select Case MsgBox("Are you sure you want to quit? Your progress WILL be saved.", MsgBoxStyle.YesNo, "Quit?")
            'Provide the user a chance to verify choice
            Case MsgBoxResult.Yes
                My.Settings.Save()
                blnFade = True
                tmrFadeInOut.Start()
                'Start timer in fade out mode
                'This only happens for game exit - want to make it special
            Case MsgBoxResult.No

        End Select
    End Sub

    'Button hover logic
    'I will only explain this once on this form:
    'The buttons use special sprites that are quite different from the regular vb button.
    'When a user hovers over the buttons, they wouldn't behave as with a regular button (becomes highlighted)
    'Thus, we have to make do ourselves.
    'Each time a user hovers over and/or exits a button, change the sprite accordingly
    Private Sub btnHoverIn(sender As Object, e As EventArgs) Handles btnStartCont.MouseEnter, btnOptions.MouseEnter, btnCredits.MouseEnter, btnQuit.MouseEnter
        sender.BackgroundImage = My.Resources.btnHover
        sender.ForeColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub btnHoverLeave(sender As Object, e As EventArgs) Handles btnStartCont.MouseLeave, btnOptions.MouseLeave, btnCredits.MouseLeave, btnQuit.MouseLeave
        sender.BackgroundImage = My.Resources.btnIdle
        sender.ForeColor = Color.WhiteSmoke
    End Sub

    'Bonus useability element: user can exit using esc
    Private Sub Charsetup_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnQuit.PerformClick()

            'Additionally, keyboard navigation
        ElseIf e.KeyCode = Keys.Enter Then
            btnStartCont.PerformClick()
        ElseIf e.KeyCode = Keys.O Then
            btnOptions.PerformClick()
        ElseIf e.KeyCode = Keys.C Then
            btnCredits.PerformClick()
        End If
    End Sub

End Class
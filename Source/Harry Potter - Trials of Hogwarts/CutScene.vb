'Cutscene
'Entertaining scene for player to enjoy before and after each level

Public Class CutScene
    Dim blnOpMode As Boolean
    'Used to determine mode of operation for timer
    'False = Enemy fade in
    'True = Dialog Exchange

    Dim shrSequenceTick, shrDialogueCount As Short
    'Used to track animations

    'CHARACTER DIALOGUE
    Dim strDialogue(,,) As String = New String(2, 3, 1) {{{"Ron:" & vbCrLf & "Hello Voldemort, I am Ron Weasley, and I am here to defeat you!", "Voldemort:" & vbCrLf & "You fool - you're interrupting my takeover of Hogwarts! No matter, you'll surely perish from my field of obstacles!"},
                                               {"Hermione:" & vbCrLf & "Voldemort, prepare for a fight! Ron may not have gotten to you, but I will!", "Voldemort:" & vbCrLf & "Clever girl, thinking you can fight me like this. Let's see if you have enough smarts to get past these... "},
                                               {"Hedwig:" & vbCrLf & "Hoot Hoot Hoot!", "Voldemort:" & vbCrLf & "..." & "I don't quite know how to respond, but you will be of no challenge to me!"},
                                               {"Harry:" & vbCrLf & "Hello Voldemort, I am finally here to defeat you!", "Voldemort:" & vbCrLf & "Ah, so here you are..."}},
                                                     {{"Ron:" & vbCrLf & "Nice try Voldemort, but those obstacles were too easy.", "Voldemort:" & vbCrLf & "Curses! No matter, you are still unfit to take me on. Find someone worthy of fighting me!"},
                                               {"Hermione:" & vbCrLf & "See? The power of words is not one to be reckoned with!", "Voldemort:" & vbCrLf & "I see. However, you will never beat me in a fight! Show me a real opponent!"},
                                               {"Hedwig:" & vbCrLf & "HOOOOOOOOOOOOOOOT!", "Voldemort:" & vbCrLf & "Curses! Beware my owl friend, for your friend is next..."},
                                               {"Harry:" & vbCrLf & "Voldemort, never underestimate the power of good will and friendship. You have been defeated!", "Voldemort:" & vbCrLf & "NOOOOOOOOOOOOOOOOOoooooooooo!"}},
                                                     {{"Voldemort:" & vbCrLf & "Go home, ginger boy, and don't come back until you get better!", "Oh no! Ron struck an obstacle! You can try again."},
                                               {"Voldemort:" & vbCrLf & "Arcane energy triumphs over smarts!", "Oh no! Hermione got really hurt! You can try again."},
                                               {"Voldemort:" & vbCrLf & "Get lost, bird brains!", "Oh no! Hedwig has been grounded! You can try again."},
                                               {"Voldemort:" & vbCrLf & "Haha, I win this time!", "Harry Potter has been defeated! Don't give up - you can try again!"}}}
    'First Index: Used to keep track of cutscene operation mode
    '0: Occurs prior to level
    '1: Occurs after victory
    '2: Occurs after loss

    'Second Index: Character
    '0: Ron
    '1: Hermione
    '2: Hedwig
    '3: Harry Potter

    'Third Index: Used to determine which line is said
    'Every interaction has 2 lines

    'Fade in form
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += My.Settings.FadeSpeed
        Else
            tmrFadeIn.Stop()



            'Once fadein is done, start the character sequence in
            tmrCutSequencer.Start()
        End If
    End Sub

    Private Sub CutScene_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BG SETUP BEGIN

        KeyPreview = True
        'Allow key input

        Dim strCharname As String
        'For cutting down the lines of code - displays additional info

        Select Case shrMission
            Case 0
                pbxPlayer.Image = My.Resources.Ron
                strCharname = "Ron"
            Case 1
                pbxPlayer.Image = My.Resources.Hermione
                strCharname = "Hermione"
            Case 2
                pbxPlayer.Image = My.Resources.Hedwig
                strCharname = "Hedwig"
            Case 3
                pbxPlayer.Image = My.Resources.Harry
                strCharname = "Harry"

        End Select


        pbxPlayer.Left = -185
        pbxVoldemort.Left = 1200
        blnOpMode = False
        shrDialogueCount = 0
        'Reset asset locations and states


        lblDispInfo.Text += strCharname & " and Voldemort:"
        'Display corresponding name and align label

        'BG SETUP END

        tmrFadeIn.Start()
        'Start form fadein

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If shrDialogueCount = 1 Then
            'If the form will need to change 
            '(after all dialogue has been displayed, thus shrDialogue = 1)

            If shrMission = 3 And shrCutSceneMode = 1 Then
                'Special Case: Boss fight --> Victory
                EndScreen.Show()
                'Show final ending which leads on
            Else
                'Otherwise, for other cases
                Select Case shrCutSceneMode
                    Case 0
                        'If the cutscene occurs before the gamemode starts
                        'Then transition to gamemode after dialogue is done
                        GameMode.Show()
                    Case 1 To 2
                        'If the cutscene occurs after gamemode
                        'Then go to levelselect after dialogue is done
                        LevelSelect.Show()
                End Select
            End If

            Me.Close()
            'Close self

        Else
            blnOpMode = True
            'Flip the operation mode of the sequence to 2. DIALOGUE MODE

            lblDialogue.Text = ""
            'Clear dialogue text so that next series of text can come in

            shrSequenceTick = 1
            'Start shrSequenceTick at 1 because it uses is for positioning of text
            'i.e. there is no position 0 of a string if you're using mid or other string functions

            shrDialogueCount += 1
            'Cycle to next dialogue line

            tmrCutSequencer.Start()
            'Start the sequence
        End If

    End Sub

    Private Sub tmrCutSequencer_Tick(sender As Object, e As EventArgs) Handles tmrCutSequencer.Tick
        'The timer user to sequence the cutscene in

        If blnOpMode = False Then
            'MODE 1: CHARACTER MOVEMENT
            'If the enemies are fading in

            If shrSequenceTick <= 50 Then
                'Player and enemy come in for 50 ticks
                pbxPlayer.Left += 4
                pbxVoldemort.Left -= 4

                '+ 50 ticks of pause
            ElseIf shrSequenceTick >= 100 Then
                'Switch Mode
                blnOpMode = True
                shrSequenceTick = 0
                'Make tick 0 so that next cycle tick is 1
            End If

        Else
            'MODE 2: DIALOGUE

            'Used for sequencing in the text
            If shrSequenceTick <= Len(strDialogue(shrCutSceneMode, shrMission, shrDialogueCount)) Then
                lblDialogue.Text += Mid(strDialogue(shrCutSceneMode, shrMission, shrDialogueCount), shrSequenceTick, 1)
                'This may seem really daunting, but let's decompose it.

                'First, the If statement.
                'It checks on the length of the string to be used as dialogue (the other 3 variables are used for getting the string from the array)
                'Because if the word is done sequencing in, we stop the timer.

                'Next, the code.
                'Every tick of the timer, there is a new bit of text displayed in the dialogue box.
                'Ex. Tick 1: a
                '    Tick 2: ap
                '    Tick 5: apple --> looks like old school videogame dialogue

                'Back to the code
                'The string used in mid is the same one that we talked about above - that's already 4 variables accounted for. See? Easy.
                'The position is the sequencetick (number of elapsed ticks)
                'And we take 1 character each time, and stick it to the end
                'Easy as that.

            Else
                tmrCutSequencer.Stop()
            End If
        End If

        shrSequenceTick += 1
    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
         'If user wants to return to menu, provide confirmation prompt
        Select Case MsgBox("Are you sure you want to return to the menu?", MsgBoxStyle.YesNo, "Return to Menu?")
            Case MsgBoxResult.Yes
                MainMenu.Show()
                Me.Close()
        End Select
    End Sub

    'Button hover logic
    Private Sub btnHoverIn(sender As Object, e As EventArgs) Handles btnReturnMenu.MouseEnter, btnNext.MouseEnter, btnSkip.MouseEnter
        sender.BackgroundImage = My.Resources.btnHover
        sender.ForeColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub btnHoverLeave(sender As Object, e As EventArgs) Handles btnReturnMenu.MouseLeave, btnNext.MouseLeave, btnSkip.MouseLeave
        sender.BackgroundImage = My.Resources.btnIdle
        sender.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        tmrCutSequencer.Stop()
        lblDialogue.Text = ""
        'Override timer and other stuff

        If shrMission = 3 And shrCutSceneMode = 1 Then
            'Special Case: Boss fight --> Victory
            EndScreen.Show()
            'Show final ending which leads on
        Else
            'Otherwise, for other cases
            Select Case shrCutSceneMode
                Case 0
                    'If the cutscene occurs before the gamemode starts
                    'Then transition to gamemode after dialogue is done
                    GameMode.Show()
                Case 1 To 2
                    'If the cutscene occurs after gamemode
                    'Then go to levelselect after dialogue is done
                    LevelSelect.Show()
            End Select
        End If

        Me.Close()
    End Sub

    Private Sub CutScene_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Menu navigation
        If e.KeyCode = Keys.C Then
            btnSkip.PerformClick()
        ElseIf e.KeyCode = Keys.N Then
            btnNext.PerformClick()

            'Bonus useability element: user can exit using esc
        ElseIf e.KeyCode = Keys.Escape Then
            btnReturnMenu.PerformClick()
        End If

    End Sub
End Class
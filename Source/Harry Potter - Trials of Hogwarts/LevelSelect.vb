'Level Selection
'Player chooses their mission and can also view some stats


Public Class LevelSelect

    Public btnMissionSelect(3) As Button
    'Array for level select buttons
    Dim pntLocation As Point
    'Point used for button array creation

    Private Sub LevelSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
       
        'BG SETUP BEGIN

        KeyPreview = True
        'Enable key input

        If My.Settings.Sound = True And shrMusicActive <> 1 Then
            shrMusicActive = 1
            'Play the DragonTrainer track
        End If

        shrMission = -1
        'Default value for shrMission as failsafe

        'DISPLAY STATS
        'It's added instead of directly set, mostly because of the fact that Accuracy is only displayed in certain cases
        Select Case My.Settings.SaveDifficulty
            Case 0
                lblStatsDisp.Text += "Difficulty: Not that Pro"
            Case 1
                lblStatsDisp.Text += "Difficulty: Pretty Pro"
            Case 2
                lblStatsDisp.Text += "Difficulty: Really Pro"
            Case 3
                lblStatsDisp.Text += "Difficulty: MASTER"
        End Select

        'DISPLAY OF STATS
        lblStatsDisp.Text += vbCrLf & "Total Words Solved: " & My.Settings.CorrectWords & vbCrLf

        lblStatsDisp.Text += "Letters Correct: " & My.Settings.CorrectLetters &
            vbCrLf & "Letters Incorrect: " & My.Settings.GuessLetters - My.Settings.CorrectLetters & vbCrLf &
            "Total Letters Guessed: " & My.Settings.GuessLetters & vbCrLf

        If My.Settings.GuessLetters > 0 Then
            Dim sglAccuracy As Single = My.Settings.CorrectLetters / My.Settings.GuessLetters * 100
            'Used to cap percentage at 5 decimal places
            'Only display if it needs to be
            lblStatsDisp.Text += "Accuracy Rate: " & sglAccuracy & "%" & vbCrLf
        End If
        'END OF DISPLAY OF STATS

        'BUTTON ARRAY FORMATION
        pntLocation.X = pbxMissionSelect.Width * 0.05
        pntLocation.Y = pbxMissionSelect.Height * 0.2

        For PositionCount = 0 To 3
            btnMissionSelect(PositionCount) = New Button
            btnMissionSelect(PositionCount).Width = pbxMissionSelect.Width * 0.25
            btnMissionSelect(PositionCount).Height = pbxMissionSelect.Height * 0.25
            btnMissionSelect(PositionCount).Location = pntLocation

            If PositionCount = 1 Then
                pntLocation.Y += pbxMissionSelect.Height * 0.4
                pntLocation.X = pbxMissionSelect.Width * 0.05
            Else
                pntLocation.X += pbxMissionSelect.Width * 0.65
            End If

            'BUTTON APPEARANCE STUFF
            btnMissionSelect(PositionCount).FlatStyle = FlatStyle.Flat
            btnMissionSelect(PositionCount).FlatAppearance.MouseDownBackColor = Color.Transparent
            btnMissionSelect(PositionCount).FlatAppearance.MouseOverBackColor = Color.Transparent
            btnMissionSelect(PositionCount).FlatAppearance.BorderSize = 0
            btnMissionSelect(PositionCount).BackgroundImageLayout = ImageLayout.Zoom
            btnMissionSelect(PositionCount).BackgroundImage = My.Resources.btnIdle
            btnMissionSelect(PositionCount).Font = New Font("Cambria", 16.2)
            btnMissionSelect(PositionCount).ForeColor = Color.WhiteSmoke

            btnMissionSelect(PositionCount).AccessibleDescription = PositionCount
            'Add an accessibledescription - used for determining mission later
            'Makes it easier, due to usage of 1 to 1 numerical values.

            AddHandler btnMissionSelect(PositionCount).Click, AddressOf btnMissionSelectClick
            AddHandler btnMissionSelect(PositionCount).MouseEnter, AddressOf btnHoverIn
            AddHandler btnMissionSelect(PositionCount).MouseLeave, AddressOf btnHoverLeave
            'Add handlers for hovering as well as click

            pbxMissionSelect.Controls.Add(btnMissionSelect(PositionCount))
            'Add controls to form (inside the pbx)

            If My.Settings.SaveState + 1 >= btnMissionSelect(PositionCount).AccessibleDescription Then
                btnMissionSelect(PositionCount).Enabled = True
            Else
                btnMissionSelect(PositionCount).Enabled = False
            End If

        Next

        btnMissionSelect(0).Text = "Ron"
        btnMissionSelect(1).Text = "Hermione"
        btnMissionSelect(2).Text = "Hedwig"
        btnMissionSelect(3).Text = "Harry Potter vs Voldemort"
        'Initialize values for Mission Select buttons

        lblQuery.Text = My.Settings.Username & ", Select Your Mission:"
        'BG SETUP END

        tmrFadeIn.Start()
        'Start fadein while other setup components are in progress

    End Sub

    Private Sub btnMissionSelectClick(sender As System.Object, e As System.EventArgs)
        shrMission = sender.accessibledescription
        'Set difficulty State

        shrCutSceneMode = 0
        'Set cutscene mode to 0 - before game mode
        CutScene.Show()
        'Show the cutscene itself
        My.Settings.Save()
        'Save settings just in case
        Me.close()
        'Start game

    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'Return to menu, but issue confirmation prompt first
        'User already entered stats
        Select Case MsgBox("Are you sure you want to return to the menu? Your progress WILL be saved!", MsgBoxStyle.YesNo, "Return to Menu?")
            Case MsgBoxResult.Yes
                MainMenu.Show()
                My.Settings.Save()
                'Save settings just in case
                Me.close()
        End Select
    End Sub

    'Button hover logic (for other buttons)
    Private Sub btnHoverIn(sender As Object, e As EventArgs) Handles btnReturnMenu.MouseEnter
        If Not sender.Equals(btnReturnMenu) Then
            'Special Case: hoverin and hoverout for level select buttons

            'Uses the accessbile description to determine what picture to load
            Select Case sender.accessibledescription
                Case 0
                    pbxMissionSelect.Image = My.Resources.Ron
                    lblTooltip.Text = "Hey " & My.Settings.Username & "! I’m Ron Weasley, and we're going to have to stop Voldemort. My mom told me to never tolerate bullies so I’ll make sure that I give it my all to help you."
                Case 1
                    pbxMissionSelect.Image = My.Resources.Hermione
                    lblTooltip.Text = "Hey, I’m Hermione Granger! Great job on helping my friend Ron. We need to keep the pressure up on Voldemort and distract him from Hogwarts. Come with me!"
                Case 2
                    pbxMissionSelect.Image = My.Resources.Hedwig
                    lblTooltip.Text = "Shhh I know I’m not supposed to be able to talk but I need to say this: You’re doing great on your quest and you’re almost ready to take on Voldemort. I’ll be providing aerial support. Good luck."
                Case 3
                    pbxMissionSelect.Image = My.Resources.Harry
                    lblTooltip.Text = "Hello " & My.Settings.Username & ", I'm Harry Potter. This will be the most important moment of my life, and maybe yours too. I'm sure that we can beat Voldemort, as long as we work together!"
            End Select
        End If

        sender.BackgroundImage = My.Resources.btnHover
        sender.ForeColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub btnHoverLeave(sender As Object, e As EventArgs) Handles btnReturnMenu.MouseLeave
        If shrMission = -1 And Not sender.Equals(btnReturnMenu) Then
            'Special case for level select buttons:
            'If user hovers out of button, reset tooltip and BG UNLESS user picked mission (clicked on it) and is showing messagebox
            pbxMissionSelect.Image = Nothing
            lblTooltip.Text = ""
            sender.ForeColor = Color.WhiteSmoke
            sender.BackgroundImage = My.Resources.btnIdle
        End If

        sender.BackgroundImage = My.Resources.btnIdle
        sender.ForeColor = Color.WhiteSmoke
        'Reset other buttons to idle state

    End Sub

    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        'Fades in the form

        If Me.Opacity < 1 Then
            'If the form has not finished, keep fading in
            Me.Opacity += My.Settings.FadeSpeed

        Else
            tmrFadeIn.Stop()
            'If the form has finished fading in, stop fadein.

        End If
    End Sub

    'Bonus useability element: user can exit using esc
    Private Sub Options_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnReturnMenu.PerformClick()

            'Additionally, key navigation
            'The user can select the level using F1 through F4 (1 for each level)
        ElseIf e.KeyCode = Keys.F1 Then
            btnMissionSelect(0).PerformClick()
        ElseIf e.KeyCode = Keys.F2 Then
            btnMissionSelect(1).PerformClick()
        ElseIf e.KeyCode = Keys.F3 Then
            btnMissionSelect(2).PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            btnMissionSelect(3).PerformClick()
        End If
    End Sub
End Class

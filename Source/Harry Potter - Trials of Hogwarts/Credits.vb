'Credits
'Shows credits

Public Class Credits
    Dim blnFadeinOut As Boolean
    'Determines whether form should be fading in or out
    Dim shrShowCheat As Short
    'Used for showing cheat prompt

    Private Sub Credits_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = MainMenu.Left + MainMenu.Width
        Me.Top = MainMenu.Top + MainMenu.Height / 3
        'Form postioning

        KeyPreview = True
        'For cheats

        'Start fadein
        tmrFadeIn.Start()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        blnFadeinOut = True
        'Start fadeout
        tmrFadeIn.Start()

    End Sub

    'Fades in form over time based on fade in speed
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        'Determine fading in or fading out
        If Me.Opacity = 1 And blnFadeInOut = False Then
            'If fading in, and opacity reaches 100%, stop
            tmrFadeIn.Stop()

        ElseIf blnFadeInOut = False And Me.Opacity <> 1 Then
            'If fading in and opacity <> 100%, keep going
            Me.Opacity += My.Settings.FadeSpeed

            Me.Left -= Me.Width / 25 * My.Settings.FadeSpeed / 0.04
            MainMenu.Left -= Me.Width / 25 * My.Settings.FadeSpeed / 0.04

        ElseIf blnFadeInOut = True And Me.Opacity <> 0 Then
            'If fading out and opacity <> 0%, keep going
            Me.Opacity -= My.Settings.FadeSpeed

            Me.Left += Me.Width / 25 * My.Settings.FadeSpeed / 0.04
            MainMenu.Left += Me.Width / 25 * My.Settings.FadeSpeed / 0.04

        ElseIf blnFadeInOut = True And Me.Opacity = 0 Then
            'If fading out, and opacity is 0%, stop
            me.close()
            'Close form
        End If
    End Sub

    Private Sub lblCredits_Click(sender As Object, e As EventArgs) Handles lblCredits.Click
        'Hidden cheats for testing/curious users
        If shrShowCheat = 5 And blnDevMode = False Then
            MessageBox.Show("Developer Mode has been enabled!", "You found it!")
            'Enable dev mode
            blnDevMode = True
        ElseIf shrShowCheat = 5 And blnDevMode = True Then
            MessageBox.Show("Developer Mode has been disabled.", "Dev Mode Off")
            'Disable dev mode
            blnDevMode = False
        Else
            shrShowCheat += 1
            'Otherwise, build up clicks until user can enable
        End If
    End Sub

    'Button hover logic
    Private Sub btnHoverIn(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        sender.BackgroundImage = My.Resources.btnHover
        sender.ForeColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub btnHoverLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        sender.BackgroundImage = My.Resources.btnIdle
        sender.ForeColor = Color.WhiteSmoke
    End Sub

    'For cheat console and esc
    Private Sub Credits_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'Used for cheat console (space bar in credits menu)
        If e.KeyCode = Keys.Space And blnDevMode = True Then
            Select Case InputBox("Cheat Command?", "Cheat Menu")
                Case "Unlock"
                    'Experimental cheat - can result in game breaking issues
                    My.Settings.SaveState = 3
                    My.Settings.SaveDifficulty = 0
                    My.Settings.Username = "Big Cheater"
                    MainMenu.btnStartCont.Text = "Continue"
                    MessageBox.Show("All levels unlocked. Difficulty has been set to easy.", "Success")
                Case "DifficultyChange"
                    'This can also break the game if not between 0 and 3
                    'Free letters will be weird
                    My.Settings.SaveDifficulty = InputBox("New difficulty?", "Cheat Menu")
                    MessageBox.Show("Difficulty successfully changed.", "Success")
                Case Else
                    MessageBox.Show("Command not recognized.", "Error")
            End Select


            'Bonus useability element: user can exit credits menu using esc
        ElseIf e.KeyCode = Keys.Escape Then
            btnClose.PerformClick()
        End If
    End Sub

End Class

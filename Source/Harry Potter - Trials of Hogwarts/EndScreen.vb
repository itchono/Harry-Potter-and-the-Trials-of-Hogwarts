'Ending
'Final victory screen

Public Class EndScreen

    Private Sub Ending_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'BG SETUP BEGIN

        If My.Settings.Sound = True And shrMusicActive <> 1 Then
            shrMusicActive = 1
            'Play the DragonTrainer track
        End If

        KeyPreview = True
        'Enable key input


        'ENDING TEXT AND STATS

        Dim sglAccuracy As Single = My.Settings.CorrectLetters / My.Settings.GuessLetters * 100
        'Used for a stat calculation

        lblDispEnding.Text = "Congratulations, " & My.Settings.Username & "." & vbCrLf &
            "You demonstrated your great heroic abilites in defending Hogwarts from attack." & vbCrLf &
            "You were able to help Ron and Hermione overcome numerous obstacles, help Hedwig soar to success, and assist Harry Potter in defeating the mighty Voldemort in order to save Hogwarts." & vbCrLf &
            "Your journey ends here." & vbCrLf &
            vbCrLf &
            "END STATS:" &
            vbCrLf & "Total Words Solved: " & My.Settings.CorrectWords & vbCrLf &
            "Letters Correct: " & My.Settings.CorrectLetters &
            vbCrLf & "Letters Incorrect: " & My.Settings.GuessLetters - My.Settings.CorrectLetters & vbCrLf &
            "Total Letters Guessed: " & My.Settings.GuessLetters & vbCrLf & "Accuracy Rate: " & sglAccuracy & "%" & vbCrLf & vbCrLf &
            "CONGRATULATIONS!"

        'BG SETUP END

        'START FORM IN
        tmrFadeIn.Start()
        'Fade in form

    End Sub

    'Fade in form
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += My.Settings.FadeSpeed
        Else
            tmrFadeIn.Stop()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        MainMenu.Show()
        Me.Close()
    End Sub

    'Button hover logic
    Private Sub btnHoverIn(sender As Object, e As EventArgs) Handles btnNext.MouseEnter
        sender.BackgroundImage = My.Resources.btnHover
        sender.ForeColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub btnHoverLeave(sender As Object, e As EventArgs) Handles btnNext.MouseLeave
        sender.BackgroundImage = My.Resources.btnIdle
        sender.ForeColor = Color.WhiteSmoke
    End Sub

    'Key Navigation
    Private Sub Options_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
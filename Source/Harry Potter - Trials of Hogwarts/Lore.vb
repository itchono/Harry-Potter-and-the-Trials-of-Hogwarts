'Lore
'Displays information to prime the player to play
'Gives backstory
'Player then sets up character
'One of the simplest forms in the entire game; it's just text.

Public Class Lore

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'When the player chooses to advance
        CharSetup.Show()
        Me.Close()
    End Sub

    'Button hover logic
    Private Sub btnHoverIn(sender As Object, e As EventArgs) Handles btnReturnMenu.MouseEnter, btnNext.MouseEnter
        sender.BackgroundImage = My.Resources.btnHover
        sender.ForeColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub btnHoverLeave(sender As Object, e As EventArgs) Handles btnReturnMenu.MouseLeave, btnNext.MouseLeave
        sender.BackgroundImage = My.Resources.btnIdle
        sender.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub Lore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form loads

        'One of the simpler forms so Load doesn't need that much description
        KeyPreview = True
        'Enable key input

        tmrFadeIn.Start()
        'Start fadein
    End Sub

    'Timer used for fading in form
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += My.Settings.FadeSpeed
            'If not finished fading in, keep fading in

        Else
            tmrFadeIn.Stop()
            'Stop fadein timer

            'FORM START END
        End If
    End Sub

    Private Sub btnReturnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'If user wants to return to menu, provide confirmation prompt
        Select Case MsgBox("Are you sure you want to return to the menu?", MsgBoxStyle.YesNo, "Return to Menu?")
            Case MsgBoxResult.Yes
                MainMenu.Show()
                Me.Close()
        End Select
    End Sub

    'Bonus useability element: user can exit using esc
    Private Sub Options_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnReturnMenu.PerformClick()

            'Key navigation
        ElseIf e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
End Class
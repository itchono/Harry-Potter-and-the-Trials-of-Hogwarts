'Options
'Player can adjust various settings and also do save-related actions

'Sound on/off
'Menu animation on/off

'(Both are ON by default)

'Wipe Save: Clear the save progress - everything; progression, difficulty, username, stats

'Export Save: Export the current save as a string that can be imported
'Import Save: Import a said string

'Fade speed: Adjust how quickly forms fade in and out (1 to 1000%) (Default: 100%)

Public Class Options
    Dim blnFadeInOut As Boolean
    'Used to determine whether form fades in or out
    'False = in; True = out
    Dim blnCtlLock As Boolean
    'Lock setting change capability

    Private Sub btnWipeSave_Click(sender As Object, e As EventArgs) Handles btnWipeSave.Click
        'Reset save
        Select Case MsgBox("Are you sure you want to wipe your save? All progress will be lost!", MsgBoxStyle.YesNo, "Confirm?")
            'Confirmation prompt
            Case MsgBoxResult.Yes
                My.Settings.SaveState = -2
                My.Settings.SaveDifficulty = -2
                My.Settings.Username = ""
                'Clear save data

                My.Settings.GuessLetters = 0
                My.Settings.CorrectLetters = 0
                My.Settings.CorrectWords = 0
                'Reset stats

                btnWipeSave.Enabled = False
                'Disable button to prevent dupe press

                MainMenu.btnStartCont.Text = "Start"
        End Select
    End Sub


    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True
        'Enable key input

        blnFadeInOut = False
        'Fade Mode: Fadein

        blnCtlLock = False
        'Lock settings temporarily

        'Why do I need this?
        'When I am applying existing settings, I change the check value of the checkboxes and the numericupdown.
        'However, this triggers the checkchanged and valuechanged events, which resets the value of the variable
        'Thus, I must lock the boxes first until settings are done being applied.

        'Detect existing settings

        If My.Settings.SaveState = -2 Then
            btnWipeSave.Enabled = False
            'If save is already blank, no need to wipe
        End If

        nudFadeSpeed.Value = My.Settings.FadeSpeed / 0.04 * 100
        'Apply existing fadespeed

        If My.Settings.Sound = True Then
            cbxSound.Checked = True
        End If
        'Apply existing sound on/off

        If My.Settings.MenuAnim = True Then
            cbxMenuAnimation.Checked = True
        End If
        'Apply existing menu animation on/off

        Me.Left = MainMenu.Left - Me.Width
        Me.Top = MainMenu.Top + MainMenu.Height / 3
        'Form positioning

        blnCtlLock = True
        'Reenable settings modification because application of existing settings is done

        'Start fadein
        tmrFadeIn.Start()

    End Sub

    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        'Determine fading in or fading out
        If Me.Opacity = 1 And blnFadeInOut = False Then
            'If fading in, and opacity reaches 100%, stop
            tmrFadeIn.Stop()

        ElseIf blnFadeInOut = False And Me.Opacity <> 1 Then
            'If fading in and opacity <> 100%, keep going
            Me.Opacity += My.Settings.FadeSpeed

            Me.Left += Me.Width / 25 * My.Settings.FadeSpeed / 0.04
            MainMenu.Left += Me.Width / 25 * My.Settings.FadeSpeed / 0.04

        ElseIf blnFadeInOut = True And Me.Opacity <> 0 Then
            'If fading out and opacity <> 0%, keep going
            Me.Opacity -= My.Settings.FadeSpeed

            Me.Left -= Me.Width / 25 * My.Settings.FadeSpeed / 0.04
            MainMenu.Left -= Me.Width / 25 * My.Settings.FadeSpeed / 0.04

        ElseIf blnFadeInOut = True And Me.Opacity = 0 Then
            'If fading out, and opacity is 0%, stop
            Me.Close()
            'Close form; return to menu (since opened as showdialog)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'If user wants to close form
        'Start fadeout
        blnFadeInOut = True
        tmrFadeIn.Start()

    End Sub

    'Button hover logic
    Private Sub btnHoverIn(sender As Object, e As EventArgs) Handles btnWipeSave.MouseEnter, btnClose.MouseEnter, btnExportSave.MouseEnter, btnImportSave.MouseEnter
        sender.BackgroundImage = My.Resources.btnHover
        sender.ForeColor = Color.LightGoldenrodYellow
    End Sub

    Private Sub btnHoverLeave(sender As Object, e As EventArgs) Handles btnWipeSave.MouseLeave, btnClose.MouseLeave, btnExportSave.MouseLeave, btnImportSave.MouseLeave
        sender.BackgroundImage = My.Resources.btnIdle
        sender.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub cbxMenuAnimation_CheckedChanged(sender As Object, e As EventArgs) Handles cbxMenuAnimation.CheckedChanged
        If blnCtlLock = True Then
            If cbxMenuAnimation.Checked = True Then
                MainMenu.pbxBGAnim.Visible = True
                My.Settings.MenuAnim = True
            Else
                MainMenu.pbxBGAnim.Visible = False
                My.Settings.MenuAnim = False
            End If
        End If
    End Sub

    Private Sub cbxSound_CheckedChanged(sender As Object, e As EventArgs) Handles cbxSound.CheckedChanged
        'If the user clicks on the sound checkbox

        If blnCtlLock = True Then
            If cbxSound.Checked = True Then
                'If user enables sound
                'Track must be restarted regardless - no need for dynamic music system
                My.Settings.Sound = True
                shrMusicActive = 1
            Else
                'Stop all sound if the user disables sound and set the active track to None
                My.Settings.Sound = False
                My.Computer.Audio.Stop()
                shrMusicActive = 0
            End If
        End If
    End Sub

    Private Sub nudFadeSpeed_ValueChanged(sender As Object, e As EventArgs) Handles nudFadeSpeed.ValueChanged
        'Whenever the user adjusts the fadespeed of the form

        If blnCtlLock = True Then
            'Change fadespeed to the new setting
            My.Settings.FadeSpeed = nudFadeSpeed.Value / 100 * 0.04
        End If
    End Sub

    Private Sub btnExportSave_Click(sender As Object, e As EventArgs) Handles btnExportSave.Click
        MessageBox.Show("Press Ctrl-C on the next prompt that shows up, and copy that text somewhere safe to store it - you can use it to restore your progress if it's lost.", "Export Save (1/2)")
        MessageBox.Show(My.Settings.SaveState & "|" & My.Settings.SaveDifficulty & "|" &
                        My.Settings.Username & "|" & My.Settings.CorrectWords & "|" &
                        My.Settings.GuessLetters & "|" & My.Settings.CorrectLetters,
                        "Export Save (2/2)")
    End Sub

    Private Sub btnImportSave_Click(sender As Object, e As EventArgs) Handles btnImportSave.Click
        MessageBox.Show("Warning: Your current save will be overwritten! Press cancel in the next window to abort.", "Import Save (1/2)")
        'Warn user
        Dim strInput As String = InputBox("WARNING: EXPERIMENTAL!" & vbCrLf &
                                          "Input the text that you got from the 'Export Save' button - JUST THE PART WITH THE 5 | THINGS:", "Import Save (2/2)")
        If Not strInput Like "*|*|*|*|*|*" Then
            'Checks validity of input
            MessageBox.Show("Invalid Input", "Error")
        Else
            'If input is ok, start save overwrite
            For PositionCount = 1 To 6
                'Use a loop to input the 6 values needed to be stored in my.settings
                Select Case PositionCount
                    'The code has to be done this way due to the various data types present in my.settings
                    Case 1
                        My.Settings.SaveState = Mid(strInput, 1, InStr(strInput, "|") - 1)
                        'Set Savestate - it's the first position
                    Case 2
                        My.Settings.SaveDifficulty = Mid(strInput, 1, InStr(strInput, "|") - 1)
                        'Set Savedifficulty - it's the second value, but has been refactored to first position
                        '(See code under End Select)
                    Case 3
                        My.Settings.Username = Mid(strInput, 1, InStr(strInput, "|") - 1)
                        'Set Username
                    Case 4
                        My.Settings.CorrectWords = Mid(strInput, 1, InStr(strInput, "|") - 1)
                    Case 5
                        My.Settings.GuessLetters = Mid(strInput, 1, InStr(strInput, "|") - 1)
                    Case 6
                        'SPECIAL CASE - Last part of the string will be "...|<Lastvalue>"
                        My.Settings.CorrectLetters = strInput
                End Select

                'Refactor string so that next position is the first position
                strInput = Mid(strInput, InStr(strInput, "|") + 1)
            Next

            'UPDATE all visual elements in accordance with savestate
            If My.Settings.SaveState = -2 Then
                MainMenu.btnStartCont.Text = "Start"
                btnWipeSave.Enabled = False
            Else
                MainMenu.btnStartCont.Text = "Continue"
                btnWipeSave.Enabled = True
            End If

        End If

    End Sub

    'Bonus useability element: user can exit options menu using esc
    Private Sub Options_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnClose.PerformClick()
        End If
    End Sub
End Class
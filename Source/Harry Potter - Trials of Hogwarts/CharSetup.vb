'Character Setup
'Analogous to a character creation screen in an RPG
'Makes the basic profile of the character
'Locks in the difficulty and username of the save until game is complete
'User chooses username, and difficulty
'Screen only shows when beginning a new save

'2 Step process:
'1. Username input
'2. Difficulty selection

'There are 2 panels that change in transparency to indicate activity.
'i.e. Panel translucent = enabled and vice versa
'This provides a responsive 2 step UI

'**You cannot change difficulty once you lock in. This is so that the run can be consistent
'If the user wished to change difficulty, they must start a new save!
'(It's just like old-school video games - you can't change difficulty in the middle of a run!)


Public Class CharSetup

    Public btnDifficultySelect(3) As Button
    Dim pntBtnLocation As Point
    'Used for choosing difficulty - array of 4 buttons makes it easier to work with output later on
    'Big initial resource investment


    Private Sub CharSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When the form loads

        'BG SETUP BEGIN

        KeyPreview = True
        'Enable key input   

        'CREATE BUTTONS FOR DIFFICULTY SELECTION
        'This seems like a lot of code, and it is; but read through it - it's organized into mini sections.

        pntBtnLocation.Y = pnlDifficulty.Height * 0.2
        pntBtnLocation.X = pnlDifficulty.Width * 0.2
        'Define starting location for button

        For PositionCount = 0 To 3
            btnDifficultySelect(PositionCount) = New Button
            btnDifficultySelect(PositionCount).Width = pnlDifficulty.Width * 0.4
            btnDifficultySelect(PositionCount).Height = pnlDifficulty.Height * 0.3
            btnDifficultySelect(PositionCount).Location = pntBtnLocation

            If PositionCount = 1 Then
                'Create second row AFTER button 2 is created.
                pntBtnLocation.Y += pnlDifficulty.Height * 0.35
                pntBtnLocation.X = pnlDifficulty.Width * 0.2
            Else
                pntBtnLocation.X += pnlDifficulty.Width * 0.35
            End If

            'BUTTON APPEARANCE STUFF
            btnDifficultySelect(PositionCount).FlatStyle = FlatStyle.Flat
            btnDifficultySelect(PositionCount).FlatAppearance.MouseDownBackColor = Color.Transparent
            btnDifficultySelect(PositionCount).FlatAppearance.MouseOverBackColor = Color.Transparent
            btnDifficultySelect(PositionCount).FlatAppearance.BorderSize = 0
            btnDifficultySelect(PositionCount).BackgroundImageLayout = ImageLayout.Zoom
            btnDifficultySelect(PositionCount).BackgroundImage = My.Resources.btnIdle
            btnDifficultySelect(PositionCount).Font = New Font("Cambria", 14)
            btnDifficultySelect(PositionCount).ForeColor = Color.WhiteSmoke

            btnDifficultySelect(PositionCount).AccessibleDescription = PositionCount
            'Add an accessibledescription - used for determining difficulty later
            'Makes it easier, due to usage of 1 to 1 numerical values.
            'You'll see later; I set difficulty to the accessibledescription

            btnDifficultySelect(PositionCount).Enabled = False
            'Disable button on startup since diff. select is step 2/2

            AddHandler btnDifficultySelect(PositionCount).Click, AddressOf btnDifficultySelectClick
            AddHandler btnDifficultySelect(PositionCount).MouseEnter, AddressOf btnHoverIn
            AddHandler btnDifficultySelect(PositionCount).MouseLeave, AddressOf btnHoverLeave
            'Event handling
            '- Diff. button click
            '- Hover over (appearance)
            '- Hover leave (appearance)

            pnlDifficulty.Controls.Add(btnDifficultySelect(PositionCount))
            'Add the control
        Next

        btnDifficultySelect(0).Text = "Not That Pro (Easy)"
        btnDifficultySelect(1).Text = "Pretty Pro (Normal)"
        btnDifficultySelect(2).Text = "Really Pro (Hard)"
        btnDifficultySelect(3).Text = "I AM A MASTER"
        'Initialize values for Difficulty Select buttons
        'END OF CREATE BUTTONS

        pnlUserName.BackColor = Color.Transparent
        'Make username panel (active) a different colour to distinguish it
        'I used an image with 50% opacity to do it

        'BG SETUP END

        '*Music from mainmenu is still playing

        'FORM START BEGIN
        tmrFadeIn.Start()
        'Start fadein after all setup is done


    End Sub

    Sub NameEnter() Handles btnSubmitName.Click
        'When the user submits their name
        'Can come from either a button press or a keypress (enter)

        If txtNameInput.Text = "" Then
            MessageBox.Show("Please input a valid username", "Error")
            'Catch invalid input
        Else
            My.Settings.Username = txtNameInput.Text
            'STEP 1 - Name Input - Complete
            txtNameInput.Enabled = False
            btnSubmitName.Enabled = False
            pnlDifficulty.BackColor = Color.Transparent
            pnlUserName.BackColor = Color.DimGray
            'Change costmetic appearance such that the new active panel (difficulty) is translucent and the old one opaque

            For PositionCount = 0 To 3
                btnDifficultySelect(PositionCount).Enabled = True
            Next
            'Enable difficulty select buttons   

            lblTooltip.Text = ""
            'Change tooltip text in preparation for difficulty select

        End If
    End Sub

    Private Sub btnDifficultySelectClick(sender As System.Object, e As System.EventArgs)
        My.Settings.SaveDifficulty = sender.accessibledescription

        My.Settings.SaveState = -1
        'Save State -1: Username given, difficulty chosen

        LevelSelect.Show()
        My.Settings.Save()
        'Save settings just in case
        Me.close()
    End Sub

    Private Sub txtNameInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNameInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            NameEnter()
            'Enter name via keypress
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnReturnMenu.Click
        'If user wants to return to menu, provide confirmation prompt
        'The stats will not have been set yet
        Select Case MsgBox("Are you sure you want to return to the menu? Your progress will NOT be saved!", MsgBoxStyle.YesNo, "Return to Menu?")
            Case MsgBoxResult.Yes
                MainMenu.Show()
                Me.Close()
        End Select
    End Sub


    'Button Hover Logic START

    'Whenever the user hovers over a button, it changes to the active image state and the text changes colour
    'When the user leaves, the button reverts to original form
    Private Sub btnHoverIn(sender As Object, e As EventArgs) Handles btnReturnMenu.MouseEnter, btnSubmitName.MouseEnter
        sender.BackgroundImage = My.Resources.btnHover
        sender.ForeColor = Color.LightGoldenrodYellow

        If Not sender.Equals(btnSubmitName) And Not sender.Equals(btnReturnMenu) Then
            'Special event: Hovering over any of the difficulty buttons gives a tooltip describing each difficulty
            Select Case sender.accessibledescription
                Case 0
                    lblTooltip.Text = "New players start here! Do you want to take it easy? This is the perfect mode for you. The obstacles move nice and slow, and you get 3 free letters per word."
                Case 1
                    lblTooltip.Text = "Think you're a middle of the road wizard? Try this! You'll have a nice balance of difficulty and ease. You get 2 free letters per word."
                Case 2
                    lblTooltip.Text = "Are you a really good wizard? Do you know most of the spells?. Do you want a bit of a challenge? In this mode, obstacles move a bit faster and you only get 1 free letter per word."
                Case 3
                    lblTooltip.Text = "Wow, you're really confident! This mode if for experienced wizards only! Make sure you know these spells well, because you don't get any free letters!"

            End Select
        End If
       
    End Sub

    Private Sub btnHoverLeave(sender As Object, e As EventArgs) Handles btnReturnMenu.MouseLeave, btnSubmitName.MouseLeave
        sender.BackgroundImage = My.Resources.btnIdle
        sender.ForeColor = Color.WhiteSmoke

        lblTooltip.Text = ""
    End Sub
    'Button Hover Logic END

    'Timer used for fading in form
    Private Sub tmrFadeIn_Tick(sender As Object, e As EventArgs) Handles tmrFadeIn.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += My.Settings.FadeSpeed
        Else
            tmrFadeIn.Stop()
            'Stop fadein timer

            'FORM START END
        End If
    End Sub

    'Bonus useability element: user can exit using esc
    Private Sub Charsetup_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            btnReturnMenu.PerformClick()

            'Hidden Key Navigation
        ElseIf e.KeyCode = Keys.F1 Then
            btnDifficultySelect(0).PerformClick()
        ElseIf e.KeyCode = Keys.F2 Then
            btnDifficultySelect(1).PerformClick()
        ElseIf e.KeyCode = Keys.F3 Then
            btnDifficultySelect(2).PerformClick()
        ElseIf e.KeyCode = Keys.F4 Then
            btnDifficultySelect(3).PerformClick()
        End If
    End Sub
End Class
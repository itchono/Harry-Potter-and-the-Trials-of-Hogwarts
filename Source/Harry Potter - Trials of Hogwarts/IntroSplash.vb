'Splash Screen for HPTH
'

Public Class IntroSplash

    Dim shrTimer As Short

    Private Sub IntroSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrFade.Start()
    End Sub

    Private Sub tmrFade_Tick(sender As Object, e As EventArgs) Handles tmrFade.Tick
        shrTimer += 1

        If shrTimer <= 1 / My.Settings.FadeSpeed Then
            Me.Opacity += My.Settings.FadeSpeed
        ElseIf shrTimer > 1 / My.Settings.FadeSpeed + 100 Then
            Me.Opacity -= My.Settings.FadeSpeed
            If Me.Opacity = 0 Then
                tmrFade.Stop()
                MainMenu.Show()
                Me.Close()
            End If
        End If


    End Sub
End Class

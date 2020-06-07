Module GlobalVariables

    Public shrMission As Short
    'Used to determine mission number

    Public shrCutSceneMode As Short
    'Used to keep track of cutscene operation mode
    '0: Occurs prior to level
    '1: Occurs after victory
    '2: Occurs after loss

    Public shrMusicActive As Short
    'Determines the active track
    '0 = None
    '1 = Main Theme - Dragon Trainer Tristana Theme By Riot Games
    '2 = Game Theme - Hedwig's Theme From Harry Potter

    Public blnDevMode As Boolean
    'Used as a lock for developer mode

    Public blnFirstTime As Boolean = True
    'Used to display a guide to the user before they start playing for the first time.

End Module

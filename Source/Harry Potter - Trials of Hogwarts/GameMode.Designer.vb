<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameMode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameMode))
        Me.pnlJumper = New System.Windows.Forms.Panel()
        Me.pbxObstacle = New System.Windows.Forms.PictureBox()
        Me.pbxCharacter = New System.Windows.Forms.PictureBox()
        Me.pbxBG = New System.Windows.Forms.PictureBox()
        Me.lblStrikes = New System.Windows.Forms.Label()
        Me.pnlInput = New System.Windows.Forms.Panel()
        Me.lblObstacleType = New System.Windows.Forms.Label()
        Me.lblDispInfo = New System.Windows.Forms.Label()
        Me.tmrGameTick = New System.Windows.Forms.Timer(Me.components)
        Me.tmrJumpSequencer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrBossSequencer = New System.Windows.Forms.Timer(Me.components)
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.lblLtrWrong = New System.Windows.Forms.Label()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.lblBossTitle = New System.Windows.Forms.Label()
        Me.lblBossHP = New System.Windows.Forms.Label()
        Me.lblHarryHPTitle = New System.Windows.Forms.Label()
        Me.pnlBossStats = New System.Windows.Forms.Panel()
        Me.lblBossMana = New System.Windows.Forms.Label()
        Me.lblHarryHP = New System.Windows.Forms.Label()
        Me.lblWordsRemain = New System.Windows.Forms.Label()
        Me.pnlNormalStats = New System.Windows.Forms.Panel()
        Me.tmrMessageRotation = New System.Windows.Forms.Timer(Me.components)
        Me.pnlJumper.SuspendLayout()
        CType(Me.pbxObstacle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCharacter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInput.SuspendLayout()
        Me.pnlBossStats.SuspendLayout()
        Me.pnlNormalStats.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlJumper
        '
        Me.pnlJumper.BackColor = System.Drawing.Color.Black
        Me.pnlJumper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlJumper.Controls.Add(Me.pbxObstacle)
        Me.pnlJumper.Controls.Add(Me.pbxCharacter)
        Me.pnlJumper.Controls.Add(Me.pbxBG)
        Me.pnlJumper.Location = New System.Drawing.Point(36, 379)
        Me.pnlJumper.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlJumper.Name = "pnlJumper"
        Me.pnlJumper.Size = New System.Drawing.Size(900, 330)
        Me.pnlJumper.TabIndex = 12
        '
        'pbxObstacle
        '
        Me.pbxObstacle.BackColor = System.Drawing.Color.Transparent
        Me.pbxObstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxObstacle.Location = New System.Drawing.Point(733, 205)
        Me.pbxObstacle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbxObstacle.Name = "pbxObstacle"
        Me.pbxObstacle.Size = New System.Drawing.Size(120, 120)
        Me.pbxObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxObstacle.TabIndex = 1
        Me.pbxObstacle.TabStop = False
        '
        'pbxCharacter
        '
        Me.pbxCharacter.BackColor = System.Drawing.Color.Transparent
        Me.pbxCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxCharacter.Location = New System.Drawing.Point(34, 205)
        Me.pbxCharacter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbxCharacter.Name = "pbxCharacter"
        Me.pbxCharacter.Size = New System.Drawing.Size(120, 120)
        Me.pbxCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxCharacter.TabIndex = 0
        Me.pbxCharacter.TabStop = False
        '
        'pbxBG
        '
        Me.pbxBG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbxBG.Image = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.JumperBG
        Me.pbxBG.Location = New System.Drawing.Point(402, 0)
        Me.pbxBG.Name = "pbxBG"
        Me.pbxBG.Size = New System.Drawing.Size(100, 330)
        Me.pbxBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pbxBG.TabIndex = 25
        Me.pbxBG.TabStop = False
        '
        'lblStrikes
        '
        Me.lblStrikes.AutoSize = True
        Me.lblStrikes.BackColor = System.Drawing.Color.Transparent
        Me.lblStrikes.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStrikes.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStrikes.Location = New System.Drawing.Point(1, 7)
        Me.lblStrikes.Name = "lblStrikes"
        Me.lblStrikes.Size = New System.Drawing.Size(106, 33)
        Me.lblStrikes.TabIndex = 11
        Me.lblStrikes.Text = "Strikes:"
        '
        'pnlInput
        '
        Me.pnlInput.BackColor = System.Drawing.Color.White
        Me.pnlInput.Controls.Add(Me.lblLtrWrong)
        Me.pnlInput.Location = New System.Drawing.Point(36, 154)
        Me.pnlInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlInput.Name = "pnlInput"
        Me.pnlInput.Size = New System.Drawing.Size(900, 220)
        Me.pnlInput.TabIndex = 10
        '
        'lblObstacleType
        '
        Me.lblObstacleType.AutoSize = True
        Me.lblObstacleType.BackColor = System.Drawing.Color.Transparent
        Me.lblObstacleType.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObstacleType.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblObstacleType.Location = New System.Drawing.Point(1, 106)
        Me.lblObstacleType.Name = "lblObstacleType"
        Me.lblObstacleType.Size = New System.Drawing.Size(190, 33)
        Me.lblObstacleType.TabIndex = 29
        Me.lblObstacleType.Text = "Obstacle Type:"
        '
        'lblDispInfo
        '
        Me.lblDispInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblDispInfo.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispInfo.Location = New System.Drawing.Point(39, 58)
        Me.lblDispInfo.Name = "lblDispInfo"
        Me.lblDispInfo.Size = New System.Drawing.Size(897, 70)
        Me.lblDispInfo.TabIndex = 9
        Me.lblDispInfo.Text = "Guess the letters correctly to make the jumps! Try to not mess up! The highlighte" & _
    "d letters are free!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tmrGameTick
        '
        '
        'tmrJumpSequencer
        '
        Me.tmrJumpSequencer.Interval = 1
        '
        'tmrBossSequencer
        '
        Me.tmrBossSequencer.Interval = 5000
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
        '
        'lblLtrWrong
        '
        Me.lblLtrWrong.BackColor = System.Drawing.Color.Transparent
        Me.lblLtrWrong.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLtrWrong.ForeColor = System.Drawing.Color.Black
        Me.lblLtrWrong.Location = New System.Drawing.Point(666, 3)
        Me.lblLtrWrong.Name = "lblLtrWrong"
        Me.lblLtrWrong.Size = New System.Drawing.Size(234, 95)
        Me.lblLtrWrong.TabIndex = 23
        Me.lblLtrWrong.Text = "Incorrect Letters:"
        '
        'btnReturnMenu
        '
        Me.btnReturnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnReturnMenu.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnReturnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnReturnMenu.FlatAppearance.BorderSize = 0
        Me.btnReturnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnReturnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnReturnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturnMenu.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturnMenu.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReturnMenu.Location = New System.Drawing.Point(1090, 20)
        Me.btnReturnMenu.Name = "btnReturnMenu"
        Me.btnReturnMenu.Size = New System.Drawing.Size(159, 69)
        Me.btnReturnMenu.TabIndex = 22
        Me.btnReturnMenu.TabStop = False
        Me.btnReturnMenu.Text = "Menu"
        Me.btnReturnMenu.UseVisualStyleBackColor = False
        '
        'lblBossTitle
        '
        Me.lblBossTitle.AutoSize = True
        Me.lblBossTitle.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBossTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblBossTitle.Location = New System.Drawing.Point(1, 20)
        Me.lblBossTitle.Name = "lblBossTitle"
        Me.lblBossTitle.Size = New System.Drawing.Size(264, 33)
        Me.lblBossTitle.TabIndex = 25
        Me.lblBossTitle.Text = "Voldemort HP/Mana"
        '
        'lblBossHP
        '
        Me.lblBossHP.BackColor = System.Drawing.Color.DarkRed
        Me.lblBossHP.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBossHP.Location = New System.Drawing.Point(7, 62)
        Me.lblBossHP.Name = "lblBossHP"
        Me.lblBossHP.Size = New System.Drawing.Size(280, 28)
        Me.lblBossHP.TabIndex = 26
        '
        'lblHarryHPTitle
        '
        Me.lblHarryHPTitle.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarryHPTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblHarryHPTitle.Location = New System.Drawing.Point(1, 156)
        Me.lblHarryHPTitle.Name = "lblHarryHPTitle"
        Me.lblHarryHPTitle.Size = New System.Drawing.Size(259, 42)
        Me.lblHarryHPTitle.TabIndex = 27
        Me.lblHarryHPTitle.Text = "Harry HP"
        '
        'pnlBossStats
        '
        Me.pnlBossStats.BackColor = System.Drawing.Color.DimGray
        Me.pnlBossStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlBossStats.Controls.Add(Me.lblBossMana)
        Me.pnlBossStats.Controls.Add(Me.lblHarryHP)
        Me.pnlBossStats.Controls.Add(Me.lblBossTitle)
        Me.pnlBossStats.Controls.Add(Me.lblHarryHPTitle)
        Me.pnlBossStats.Controls.Add(Me.lblBossHP)
        Me.pnlBossStats.Location = New System.Drawing.Point(944, 459)
        Me.pnlBossStats.Name = "pnlBossStats"
        Me.pnlBossStats.Size = New System.Drawing.Size(300, 249)
        Me.pnlBossStats.TabIndex = 28
        Me.pnlBossStats.Visible = False
        '
        'lblBossMana
        '
        Me.lblBossMana.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblBossMana.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBossMana.Location = New System.Drawing.Point(7, 90)
        Me.lblBossMana.MaximumSize = New System.Drawing.Size(280, 28)
        Me.lblBossMana.Name = "lblBossMana"
        Me.lblBossMana.Size = New System.Drawing.Size(280, 28)
        Me.lblBossMana.TabIndex = 29
        '
        'lblHarryHP
        '
        Me.lblHarryHP.BackColor = System.Drawing.Color.DarkRed
        Me.lblHarryHP.Font = New System.Drawing.Font("Cambria", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHarryHP.Location = New System.Drawing.Point(7, 198)
        Me.lblHarryHP.Name = "lblHarryHP"
        Me.lblHarryHP.Size = New System.Drawing.Size(280, 28)
        Me.lblHarryHP.TabIndex = 28
        '
        'lblWordsRemain
        '
        Me.lblWordsRemain.AutoSize = True
        Me.lblWordsRemain.BackColor = System.Drawing.Color.Transparent
        Me.lblWordsRemain.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWordsRemain.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWordsRemain.Location = New System.Drawing.Point(1, 40)
        Me.lblWordsRemain.Name = "lblWordsRemain"
        Me.lblWordsRemain.Size = New System.Drawing.Size(150, 66)
        Me.lblWordsRemain.TabIndex = 29
        Me.lblWordsRemain.Text = "Remaining " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Obstacles:"
        '
        'pnlNormalStats
        '
        Me.pnlNormalStats.BackColor = System.Drawing.Color.DimGray
        Me.pnlNormalStats.Controls.Add(Me.lblObstacleType)
        Me.pnlNormalStats.Controls.Add(Me.lblWordsRemain)
        Me.pnlNormalStats.Controls.Add(Me.lblStrikes)
        Me.pnlNormalStats.Location = New System.Drawing.Point(944, 306)
        Me.pnlNormalStats.Name = "pnlNormalStats"
        Me.pnlNormalStats.Size = New System.Drawing.Size(300, 147)
        Me.pnlNormalStats.TabIndex = 30
        '
        'tmrMessageRotation
        '
        Me.tmrMessageRotation.Interval = 1000
        '
        'GameMode
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.BlankHogwarts
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.pnlNormalStats)
        Me.Controls.Add(Me.pnlBossStats)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.pnlJumper)
        Me.Controls.Add(Me.pnlInput)
        Me.Controls.Add(Me.lblDispInfo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GameMode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harry Potter and the Trials of Hogwarts"
        Me.pnlJumper.ResumeLayout(False)
        CType(Me.pbxObstacle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCharacter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInput.ResumeLayout(False)
        Me.pnlBossStats.ResumeLayout(False)
        Me.pnlBossStats.PerformLayout()
        Me.pnlNormalStats.ResumeLayout(False)
        Me.pnlNormalStats.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlJumper As System.Windows.Forms.Panel
    Friend WithEvents pbxObstacle As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCharacter As System.Windows.Forms.PictureBox
    Friend WithEvents lblStrikes As System.Windows.Forms.Label
    Friend WithEvents pnlInput As System.Windows.Forms.Panel
    Friend WithEvents lblDispInfo As System.Windows.Forms.Label
    Friend WithEvents tmrGameTick As System.Windows.Forms.Timer
    Friend WithEvents tmrJumpSequencer As System.Windows.Forms.Timer
    Friend WithEvents tmrBossSequencer As System.Windows.Forms.Timer
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents lblLtrWrong As System.Windows.Forms.Label
    Friend WithEvents pbxBG As System.Windows.Forms.PictureBox
    Friend WithEvents lblBossTitle As System.Windows.Forms.Label
    Friend WithEvents lblBossHP As System.Windows.Forms.Label
    Friend WithEvents lblHarryHPTitle As System.Windows.Forms.Label
    Friend WithEvents pnlBossStats As System.Windows.Forms.Panel
    Friend WithEvents lblHarryHP As System.Windows.Forms.Label
    Friend WithEvents lblBossMana As System.Windows.Forms.Label
    Friend WithEvents lblObstacleType As System.Windows.Forms.Label
    Friend WithEvents lblWordsRemain As System.Windows.Forms.Label
    Friend WithEvents pnlNormalStats As System.Windows.Forms.Panel
    Friend WithEvents tmrMessageRotation As System.Windows.Forms.Timer
End Class

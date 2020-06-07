<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CutScene
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CutScene))
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.pnlModeSelect = New System.Windows.Forms.Panel()
        Me.pbxPlayer = New System.Windows.Forms.PictureBox()
        Me.pbxVoldemort = New System.Windows.Forms.PictureBox()
        Me.lblDialogue = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.tmrCutSequencer = New System.Windows.Forms.Timer(Me.components)
        Me.lblDispInfo = New System.Windows.Forms.Label()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.pnlModeSelect.SuspendLayout()
        CType(Me.pbxPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxVoldemort, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
        '
        'pnlModeSelect
        '
        Me.pnlModeSelect.BackColor = System.Drawing.Color.DimGray
        Me.pnlModeSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pnlModeSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlModeSelect.Controls.Add(Me.pbxPlayer)
        Me.pnlModeSelect.Controls.Add(Me.pbxVoldemort)
        Me.pnlModeSelect.Controls.Add(Me.lblDialogue)
        Me.pnlModeSelect.Location = New System.Drawing.Point(38, 174)
        Me.pnlModeSelect.Name = "pnlModeSelect"
        Me.pnlModeSelect.Size = New System.Drawing.Size(1190, 423)
        Me.pnlModeSelect.TabIndex = 26
        '
        'pbxPlayer
        '
        Me.pbxPlayer.Location = New System.Drawing.Point(-185, 217)
        Me.pbxPlayer.Name = "pbxPlayer"
        Me.pbxPlayer.Size = New System.Drawing.Size(180, 184)
        Me.pbxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxPlayer.TabIndex = 2
        Me.pbxPlayer.TabStop = False
        '
        'pbxVoldemort
        '
        Me.pbxVoldemort.Image = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.Voldemort_Cutscene
        Me.pbxVoldemort.Location = New System.Drawing.Point(1200, 31)
        Me.pbxVoldemort.Name = "pbxVoldemort"
        Me.pbxVoldemort.Size = New System.Drawing.Size(180, 184)
        Me.pbxVoldemort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxVoldemort.TabIndex = 1
        Me.pbxVoldemort.TabStop = False
        '
        'lblDialogue
        '
        Me.lblDialogue.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblDialogue.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDialogue.Location = New System.Drawing.Point(324, 241)
        Me.lblDialogue.Name = "lblDialogue"
        Me.lblDialogue.Size = New System.Drawing.Size(550, 167)
        Me.lblDialogue.TabIndex = 0
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnNext.Location = New System.Drawing.Point(1089, 623)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(170, 74)
        Me.btnNext.TabIndex = 25
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "Next (N)"
        Me.btnNext.UseVisualStyleBackColor = False
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
        Me.btnReturnMenu.TabIndex = 24
        Me.btnReturnMenu.TabStop = False
        Me.btnReturnMenu.Text = "Menu"
        Me.btnReturnMenu.UseVisualStyleBackColor = False
        '
        'tmrCutSequencer
        '
        Me.tmrCutSequencer.Interval = 10
        '
        'lblDispInfo
        '
        Me.lblDispInfo.AutoSize = True
        Me.lblDispInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblDispInfo.Font = New System.Drawing.Font("Cambria", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispInfo.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispInfo.Location = New System.Drawing.Point(39, 119)
        Me.lblDispInfo.Name = "lblDispInfo"
        Me.lblDispInfo.Size = New System.Drawing.Size(459, 44)
        Me.lblDispInfo.TabIndex = 27
        Me.lblDispInfo.Text = "A confrontation between "
        '
        'btnSkip
        '
        Me.btnSkip.BackColor = System.Drawing.Color.Transparent
        Me.btnSkip.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnSkip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSkip.FlatAppearance.BorderSize = 0
        Me.btnSkip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSkip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSkip.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSkip.Location = New System.Drawing.Point(38, 623)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(170, 74)
        Me.btnSkip.TabIndex = 28
        Me.btnSkip.TabStop = False
        Me.btnSkip.Text = "Skip (C)"
        Me.btnSkip.UseVisualStyleBackColor = False
        '
        'CutScene
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.BlankHogwarts
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.lblDispInfo)
        Me.Controls.Add(Me.pnlModeSelect)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "CutScene"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harry Potter and the Trials of Hogwarts"
        Me.pnlModeSelect.ResumeLayout(False)
        CType(Me.pbxPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxVoldemort, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents pnlModeSelect As System.Windows.Forms.Panel
    Friend WithEvents lblDialogue As System.Windows.Forms.Label
    Friend WithEvents pbxPlayer As System.Windows.Forms.PictureBox
    Friend WithEvents pbxVoldemort As System.Windows.Forms.PictureBox
    Friend WithEvents tmrCutSequencer As System.Windows.Forms.Timer
    Friend WithEvents lblDispInfo As System.Windows.Forms.Label
    Friend WithEvents btnSkip As System.Windows.Forms.Button
End Class

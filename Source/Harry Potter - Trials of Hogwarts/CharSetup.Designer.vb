<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharSetup))
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.txtNameInput = New System.Windows.Forms.TextBox()
        Me.lblNameTitle = New System.Windows.Forms.Label()
        Me.lblDifficultyTitle = New System.Windows.Forms.Label()
        Me.pnlUserName = New System.Windows.Forms.Panel()
        Me.btnSubmitName = New System.Windows.Forms.Button()
        Me.pnlDifficulty = New System.Windows.Forms.Panel()
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.lblTooltip = New System.Windows.Forms.Label()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.pnlUserName.SuspendLayout()
        Me.pnlDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDispTitle
        '
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDispTitle.Font = New System.Drawing.Font("Cambria", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(442, 38)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(327, 51)
        Me.lblDispTitle.TabIndex = 0
        Me.lblDispTitle.Text = "Charcter Setup:"
        '
        'txtNameInput
        '
        Me.txtNameInput.Font = New System.Drawing.Font("Cambria", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameInput.Location = New System.Drawing.Point(10, 81)
        Me.txtNameInput.MaxLength = 30
        Me.txtNameInput.Name = "txtNameInput"
        Me.txtNameInput.Size = New System.Drawing.Size(709, 58)
        Me.txtNameInput.TabIndex = 16
        '
        'lblNameTitle
        '
        Me.lblNameTitle.AutoSize = True
        Me.lblNameTitle.Font = New System.Drawing.Font("Cambria", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblNameTitle.Location = New System.Drawing.Point(3, 9)
        Me.lblNameTitle.Name = "lblNameTitle"
        Me.lblNameTitle.Size = New System.Drawing.Size(371, 38)
        Me.lblNameTitle.TabIndex = 17
        Me.lblNameTitle.Text = "1. Name - Who are you?"
        '
        'lblDifficultyTitle
        '
        Me.lblDifficultyTitle.AutoSize = True
        Me.lblDifficultyTitle.Font = New System.Drawing.Font("Cambria", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDifficultyTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDifficultyTitle.Location = New System.Drawing.Point(7, 9)
        Me.lblDifficultyTitle.Name = "lblDifficultyTitle"
        Me.lblDifficultyTitle.Size = New System.Drawing.Size(662, 38)
        Me.lblDifficultyTitle.TabIndex = 18
        Me.lblDifficultyTitle.Text = "2. Difficulty - How pro of a Wizard are you?"
        '
        'pnlUserName
        '
        Me.pnlUserName.BackColor = System.Drawing.Color.DimGray
        Me.pnlUserName.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.DimGray50Alpha
        Me.pnlUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlUserName.Controls.Add(Me.btnSubmitName)
        Me.pnlUserName.Controls.Add(Me.lblNameTitle)
        Me.pnlUserName.Controls.Add(Me.txtNameInput)
        Me.pnlUserName.Location = New System.Drawing.Point(17, 106)
        Me.pnlUserName.Name = "pnlUserName"
        Me.pnlUserName.Size = New System.Drawing.Size(915, 205)
        Me.pnlUserName.TabIndex = 19
        '
        'btnSubmitName
        '
        Me.btnSubmitName.BackColor = System.Drawing.Color.Transparent
        Me.btnSubmitName.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnSubmitName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSubmitName.FlatAppearance.BorderSize = 0
        Me.btnSubmitName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSubmitName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSubmitName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmitName.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmitName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSubmitName.Location = New System.Drawing.Point(740, 81)
        Me.btnSubmitName.Name = "btnSubmitName"
        Me.btnSubmitName.Size = New System.Drawing.Size(159, 69)
        Me.btnSubmitName.TabIndex = 22
        Me.btnSubmitName.TabStop = False
        Me.btnSubmitName.Text = "Submit"
        Me.btnSubmitName.UseVisualStyleBackColor = False
        '
        'pnlDifficulty
        '
        Me.pnlDifficulty.BackColor = System.Drawing.Color.DimGray
        Me.pnlDifficulty.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.DimGray50Alpha
        Me.pnlDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDifficulty.Controls.Add(Me.lblDifficultyTitle)
        Me.pnlDifficulty.Location = New System.Drawing.Point(17, 327)
        Me.pnlDifficulty.Name = "pnlDifficulty"
        Me.pnlDifficulty.Size = New System.Drawing.Size(915, 347)
        Me.pnlDifficulty.TabIndex = 20
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
        '
        'lblTooltip
        '
        Me.lblTooltip.BackColor = System.Drawing.Color.Transparent
        Me.lblTooltip.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTooltip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTooltip.Image = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.DimGray80Alpha
        Me.lblTooltip.Location = New System.Drawing.Point(955, 307)
        Me.lblTooltip.Name = "lblTooltip"
        Me.lblTooltip.Padding = New System.Windows.Forms.Padding(10)
        Me.lblTooltip.Size = New System.Drawing.Size(303, 367)
        Me.lblTooltip.TabIndex = 26
        Me.lblTooltip.Text = "Greetings Wizard! Please allow us to know your name first!"
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
        Me.btnReturnMenu.TabIndex = 21
        Me.btnReturnMenu.TabStop = False
        Me.btnReturnMenu.Text = "Menu"
        Me.btnReturnMenu.UseVisualStyleBackColor = False
        '
        'CharSetup
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.CharSetupBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblTooltip)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.pnlDifficulty)
        Me.Controls.Add(Me.pnlUserName)
        Me.Controls.Add(Me.lblDispTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CharSetup"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harry Potter and the Trials of Hogwarts"
        Me.pnlUserName.ResumeLayout(False)
        Me.pnlUserName.PerformLayout()
        Me.pnlDifficulty.ResumeLayout(False)
        Me.pnlDifficulty.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents txtNameInput As System.Windows.Forms.TextBox
    Friend WithEvents lblNameTitle As System.Windows.Forms.Label
    Friend WithEvents lblDifficultyTitle As System.Windows.Forms.Label
    Friend WithEvents pnlUserName As System.Windows.Forms.Panel
    Friend WithEvents pnlDifficulty As System.Windows.Forms.Panel
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents btnSubmitName As System.Windows.Forms.Button
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents lblTooltip As System.Windows.Forms.Label
End Class

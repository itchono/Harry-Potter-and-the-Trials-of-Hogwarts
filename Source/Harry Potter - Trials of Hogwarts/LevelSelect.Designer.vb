<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LevelSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LevelSelect))
        Me.lblQuery = New System.Windows.Forms.Label()
        Me.lblStatsTitle = New System.Windows.Forms.Label()
        Me.lblStatsDisp = New System.Windows.Forms.Label()
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.pbxMissionSelect = New System.Windows.Forms.PictureBox()
        Me.lblTooltip = New System.Windows.Forms.Label()
        CType(Me.pbxMissionSelect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuery
        '
        Me.lblQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuery.BackColor = System.Drawing.Color.Transparent
        Me.lblQuery.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuery.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblQuery.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblQuery.Location = New System.Drawing.Point(171, 42)
        Me.lblQuery.Name = "lblQuery"
        Me.lblQuery.Size = New System.Drawing.Size(870, 104)
        Me.lblQuery.TabIndex = 14
        Me.lblQuery.Text = "<Name>, select your Mission"
        Me.lblQuery.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStatsTitle
        '
        Me.lblStatsTitle.AutoSize = True
        Me.lblStatsTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblStatsTitle.Font = New System.Drawing.Font("Cambria", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatsTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStatsTitle.Location = New System.Drawing.Point(992, 170)
        Me.lblStatsTitle.Name = "lblStatsTitle"
        Me.lblStatsTitle.Size = New System.Drawing.Size(100, 44)
        Me.lblStatsTitle.TabIndex = 24
        Me.lblStatsTitle.Text = "Stats"
        '
        'lblStatsDisp
        '
        Me.lblStatsDisp.BackColor = System.Drawing.Color.Transparent
        Me.lblStatsDisp.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatsDisp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblStatsDisp.Location = New System.Drawing.Point(996, 228)
        Me.lblStatsDisp.Name = "lblStatsDisp"
        Me.lblStatsDisp.Size = New System.Drawing.Size(263, 143)
        Me.lblStatsDisp.TabIndex = 25
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
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
        Me.btnReturnMenu.TabIndex = 23
        Me.btnReturnMenu.TabStop = False
        Me.btnReturnMenu.Text = "Menu"
        Me.btnReturnMenu.UseVisualStyleBackColor = False
        '
        'pbxMissionSelect
        '
        Me.pbxMissionSelect.BackColor = System.Drawing.Color.Transparent
        Me.pbxMissionSelect.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.DimGray50Alpha
        Me.pbxMissionSelect.Location = New System.Drawing.Point(36, 171)
        Me.pbxMissionSelect.Name = "pbxMissionSelect"
        Me.pbxMissionSelect.Size = New System.Drawing.Size(950, 500)
        Me.pbxMissionSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMissionSelect.TabIndex = 26
        Me.pbxMissionSelect.TabStop = False
        '
        'lblTooltip
        '
        Me.lblTooltip.BackColor = System.Drawing.Color.Transparent
        Me.lblTooltip.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTooltip.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblTooltip.Location = New System.Drawing.Point(996, 471)
        Me.lblTooltip.Name = "lblTooltip"
        Me.lblTooltip.Size = New System.Drawing.Size(263, 200)
        Me.lblTooltip.TabIndex = 27
        Me.lblTooltip.Text = "Hello wizard! Choose your mission! You have to complete each mission one at a tim" & _
    "e to unlock the next. Good luck!"
        '
        'LevelSelect
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.LevelSelectBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblTooltip)
        Me.Controls.Add(Me.pbxMissionSelect)
        Me.Controls.Add(Me.lblStatsDisp)
        Me.Controls.Add(Me.lblStatsTitle)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.Controls.Add(Me.lblQuery)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LevelSelect"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harry Potter and the Trials of Hogwarts"
        CType(Me.pbxMissionSelect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuery As System.Windows.Forms.Label
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents lblStatsTitle As System.Windows.Forms.Label
    Friend WithEvents lblStatsDisp As System.Windows.Forms.Label
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents pbxMissionSelect As System.Windows.Forms.PictureBox
    Friend WithEvents lblTooltip As System.Windows.Forms.Label
End Class

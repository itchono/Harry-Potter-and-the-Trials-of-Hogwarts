<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.tmrFadeInOut = New System.Windows.Forms.Timer(Me.components)
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnStartCont = New System.Windows.Forms.Button()
        Me.pbxBGAnim = New System.Windows.Forms.PictureBox()
        Me.lblSplashText = New System.Windows.Forms.Label()
        CType(Me.pbxBGAnim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrFadeInOut
        '
        Me.tmrFadeInOut.Interval = 1
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.Transparent
        Me.btnQuit.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnQuit.FlatAppearance.BorderSize = 0
        Me.btnQuit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuit.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuit.Location = New System.Drawing.Point(1109, 12)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(159, 69)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.TabStop = False
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.Transparent
        Me.btnCredits.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCredits.FlatAppearance.BorderSize = 0
        Me.btnCredits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCredits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredits.Font = New System.Drawing.Font("Cambria", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCredits.Location = New System.Drawing.Point(882, 530)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(330, 140)
        Me.btnCredits.TabIndex = 6
        Me.btnCredits.TabStop = False
        Me.btnCredits.Text = "Credits"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.Transparent
        Me.btnOptions.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOptions.FlatAppearance.BorderSize = 0
        Me.btnOptions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Font = New System.Drawing.Font("Cambria", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnOptions.Location = New System.Drawing.Point(52, 530)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(330, 140)
        Me.btnOptions.TabIndex = 5
        Me.btnOptions.TabStop = False
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'btnStartCont
        '
        Me.btnStartCont.BackColor = System.Drawing.Color.Transparent
        Me.btnStartCont.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnStartCont.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnStartCont.FlatAppearance.BorderSize = 0
        Me.btnStartCont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStartCont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStartCont.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartCont.Font = New System.Drawing.Font("Cambria", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartCont.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnStartCont.Location = New System.Drawing.Point(468, 530)
        Me.btnStartCont.Name = "btnStartCont"
        Me.btnStartCont.Size = New System.Drawing.Size(330, 140)
        Me.btnStartCont.TabIndex = 4
        Me.btnStartCont.TabStop = False
        Me.btnStartCont.Text = "Start"
        Me.btnStartCont.UseVisualStyleBackColor = False
        '
        'pbxBGAnim
        '
        Me.pbxBGAnim.Image = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.MenuBG
        Me.pbxBGAnim.Location = New System.Drawing.Point(0, 0)
        Me.pbxBGAnim.Name = "pbxBGAnim"
        Me.pbxBGAnim.Size = New System.Drawing.Size(1280, 720)
        Me.pbxBGAnim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxBGAnim.TabIndex = 9
        Me.pbxBGAnim.TabStop = False
        Me.pbxBGAnim.Visible = False
        '
        'lblSplashText
        '
        Me.lblSplashText.AutoSize = True
        Me.lblSplashText.BackColor = System.Drawing.Color.Transparent
        Me.lblSplashText.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplashText.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblSplashText.Location = New System.Drawing.Point(50, 680)
        Me.lblSplashText.Name = "lblSplashText"
        Me.lblSplashText.Size = New System.Drawing.Size(117, 22)
        Me.lblSplashText.TabIndex = 10
        Me.lblSplashText.Text = "<SplashText>"
        '
        'MainMenu
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.MenuBG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSplashText)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCredits)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnStartCont)
        Me.Controls.Add(Me.pbxBGAnim)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainMenu"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harry Potter and the Trials of Hogwarts"
        CType(Me.pbxBGAnim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrFadeInOut As System.Windows.Forms.Timer
    Friend WithEvents btnStartCont As System.Windows.Forms.Button
    Friend WithEvents btnOptions As System.Windows.Forms.Button
    Friend WithEvents btnCredits As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents pbxBGAnim As System.Windows.Forms.PictureBox
    Friend WithEvents lblSplashText As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IntroSplash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IntroSplash))
        Me.lblDispSplash = New System.Windows.Forms.Label()
        Me.tmrFade = New System.Windows.Forms.Timer(Me.components)
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDispSplash
        '
        Me.lblDispSplash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.lblDispSplash.AutoSize = True
        Me.lblDispSplash.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispSplash.Location = New System.Drawing.Point(152, 19)
        Me.lblDispSplash.Name = "lblDispSplash"
        Me.lblDispSplash.Size = New System.Drawing.Size(231, 168)
        Me.lblDispSplash.TabIndex = 1
        Me.lblDispSplash.Text = "A game by LoTek LLC" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Colonel By SS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ICS2O-02 2016-2017" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mingde Yin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 1.3" &
    ""
        '
        'tmrFade
        '
        Me.tmrFade.Interval = 1
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.pbxLogo.Image = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.Logo_Medium
        Me.pbxLogo.Location = New System.Drawing.Point(16, 35)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(130, 130)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxLogo.TabIndex = 0
        Me.pbxLogo.TabStop = False
        '
        'IntroSplash
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblDispSplash)
        Me.Controls.Add(Me.pbxLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "IntroSplash"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harry Potter and the Trials of Hogwarts"
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblDispSplash As System.Windows.Forms.Label
    Friend WithEvents tmrFade As System.Windows.Forms.Timer

End Class

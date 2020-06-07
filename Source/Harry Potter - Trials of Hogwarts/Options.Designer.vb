<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.cbxMenuAnimation = New System.Windows.Forms.CheckBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnWipeSave = New System.Windows.Forms.Button()
        Me.cbxSound = New System.Windows.Forms.CheckBox()
        Me.nudFadeSpeed = New System.Windows.Forms.NumericUpDown()
        Me.lblFadeSpdDisp = New System.Windows.Forms.Label()
        Me.btnExportSave = New System.Windows.Forms.Button()
        Me.btnImportSave = New System.Windows.Forms.Button()
        CType(Me.nudFadeSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDispTitle
        '
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Font = New System.Drawing.Font("Cambria", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(166, 51)
        Me.lblDispTitle.TabIndex = 3
        Me.lblDispTitle.Text = "Options"
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
        '
        'cbxMenuAnimation
        '
        Me.cbxMenuAnimation.AutoSize = True
        Me.cbxMenuAnimation.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMenuAnimation.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbxMenuAnimation.Location = New System.Drawing.Point(17, 198)
        Me.cbxMenuAnimation.Name = "cbxMenuAnimation"
        Me.cbxMenuAnimation.Size = New System.Drawing.Size(230, 27)
        Me.cbxMenuAnimation.TabIndex = 10
        Me.cbxMenuAnimation.Text = "Animated Menu Screen"
        Me.cbxMenuAnimation.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnClose.Location = New System.Drawing.Point(194, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 49)
        Me.btnClose.TabIndex = 9
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnWipeSave
        '
        Me.btnWipeSave.BackColor = System.Drawing.Color.Transparent
        Me.btnWipeSave.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnWipeSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnWipeSave.FlatAppearance.BorderSize = 0
        Me.btnWipeSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnWipeSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnWipeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWipeSave.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWipeSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnWipeSave.Location = New System.Drawing.Point(12, 131)
        Me.btnWipeSave.Name = "btnWipeSave"
        Me.btnWipeSave.Size = New System.Drawing.Size(100, 45)
        Me.btnWipeSave.TabIndex = 8
        Me.btnWipeSave.TabStop = False
        Me.btnWipeSave.Text = "Reset Save"
        Me.btnWipeSave.UseVisualStyleBackColor = False
        '
        'cbxSound
        '
        Me.cbxSound.AutoSize = True
        Me.cbxSound.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSound.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cbxSound.Location = New System.Drawing.Point(17, 240)
        Me.cbxSound.Name = "cbxSound"
        Me.cbxSound.Size = New System.Drawing.Size(86, 27)
        Me.cbxSound.TabIndex = 11
        Me.cbxSound.Text = "Sound"
        Me.cbxSound.UseVisualStyleBackColor = True
        '
        'nudFadeSpeed
        '
        Me.nudFadeSpeed.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudFadeSpeed.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudFadeSpeed.Location = New System.Drawing.Point(17, 297)
        Me.nudFadeSpeed.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudFadeSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFadeSpeed.Name = "nudFadeSpeed"
        Me.nudFadeSpeed.Size = New System.Drawing.Size(74, 34)
        Me.nudFadeSpeed.TabIndex = 12
        Me.nudFadeSpeed.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'lblFadeSpdDisp
        '
        Me.lblFadeSpdDisp.AutoSize = True
        Me.lblFadeSpdDisp.Font = New System.Drawing.Font("Cambria", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFadeSpdDisp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblFadeSpdDisp.Location = New System.Drawing.Point(99, 300)
        Me.lblFadeSpdDisp.Name = "lblFadeSpdDisp"
        Me.lblFadeSpdDisp.Size = New System.Drawing.Size(172, 28)
        Me.lblFadeSpdDisp.TabIndex = 13
        Me.lblFadeSpdDisp.Text = "Fade Speed (%)"
        '
        'btnExportSave
        '
        Me.btnExportSave.BackColor = System.Drawing.Color.Transparent
        Me.btnExportSave.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnExportSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExportSave.FlatAppearance.BorderSize = 0
        Me.btnExportSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnExportSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnExportSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportSave.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExportSave.Location = New System.Drawing.Point(12, 76)
        Me.btnExportSave.Name = "btnExportSave"
        Me.btnExportSave.Size = New System.Drawing.Size(100, 45)
        Me.btnExportSave.TabIndex = 15
        Me.btnExportSave.TabStop = False
        Me.btnExportSave.Text = "Export Save"
        Me.btnExportSave.UseVisualStyleBackColor = False
        '
        'btnImportSave
        '
        Me.btnImportSave.BackColor = System.Drawing.Color.Transparent
        Me.btnImportSave.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.btnIdle
        Me.btnImportSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnImportSave.FlatAppearance.BorderSize = 0
        Me.btnImportSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnImportSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnImportSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImportSave.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImportSave.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnImportSave.Location = New System.Drawing.Point(118, 76)
        Me.btnImportSave.Name = "btnImportSave"
        Me.btnImportSave.Size = New System.Drawing.Size(100, 45)
        Me.btnImportSave.TabIndex = 16
        Me.btnImportSave.TabStop = False
        Me.btnImportSave.Text = "Import Save"
        Me.btnImportSave.UseVisualStyleBackColor = False
        '
        'Options
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(300, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnImportSave)
        Me.Controls.Add(Me.btnExportSave)
        Me.Controls.Add(Me.lblFadeSpdDisp)
        Me.Controls.Add(Me.nudFadeSpeed)
        Me.Controls.Add(Me.cbxSound)
        Me.Controls.Add(Me.cbxMenuAnimation)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnWipeSave)
        Me.Controls.Add(Me.lblDispTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.Opacity = 0.0R
        Me.Text = "Harry Potter and the Trials of Hogwarts - Options"
        CType(Me.nudFadeSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents btnWipeSave As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents cbxMenuAnimation As System.Windows.Forms.CheckBox
    Friend WithEvents cbxSound As System.Windows.Forms.CheckBox
    Friend WithEvents nudFadeSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFadeSpdDisp As System.Windows.Forms.Label
    Friend WithEvents btnExportSave As System.Windows.Forms.Button
    Friend WithEvents btnImportSave As System.Windows.Forms.Button
End Class

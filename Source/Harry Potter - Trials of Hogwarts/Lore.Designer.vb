<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lore))
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnReturnMenu = New System.Windows.Forms.Button()
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.lblLore = New System.Windows.Forms.Label()
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.btnNext.Location = New System.Drawing.Point(1082, 634)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(170, 74)
        Me.btnNext.TabIndex = 27
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
        Me.btnReturnMenu.TabIndex = 26
        Me.btnReturnMenu.TabStop = False
        Me.btnReturnMenu.Text = "Menu"
        Me.btnReturnMenu.UseVisualStyleBackColor = False
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
        '
        'lblLore
        '
        Me.lblLore.BackColor = System.Drawing.Color.Transparent
        Me.lblLore.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLore.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblLore.Image = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.DimGray80Alpha
        Me.lblLore.Location = New System.Drawing.Point(51, 118)
        Me.lblLore.Name = "lblLore"
        Me.lblLore.Size = New System.Drawing.Size(1153, 499)
        Me.lblLore.TabIndex = 28
        Me.lblLore.Text = resources.GetString("lblLore.Text")
        Me.lblLore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDispTitle
        '
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDispTitle.Font = New System.Drawing.Font("Cambria", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(548, 39)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(124, 51)
        Me.lblDispTitle.TabIndex = 29
        Me.lblDispTitle.Text = "Lore:"
        '
        'Lore
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.BlankHogwarts
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblDispTitle)
        Me.Controls.Add(Me.lblLore)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnReturnMenu)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Lore"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harry Potter and the Trials of Hogwarts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnReturnMenu As System.Windows.Forms.Button
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents lblLore As System.Windows.Forms.Label
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
End Class

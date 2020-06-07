<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EndScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EndScreen))
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.lblDispEnding = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
        '
        'lblDispEnding
        '
        Me.lblDispEnding.BackColor = System.Drawing.Color.Transparent
        Me.lblDispEnding.Font = New System.Drawing.Font("Cambria", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispEnding.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispEnding.Image = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.DimGray80Alpha
        Me.lblDispEnding.Location = New System.Drawing.Point(65, 103)
        Me.lblDispEnding.Name = "lblDispEnding"
        Me.lblDispEnding.Padding = New System.Windows.Forms.Padding(40)
        Me.lblDispEnding.Size = New System.Drawing.Size(1136, 528)
        Me.lblDispEnding.TabIndex = 29
        Me.lblDispEnding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnNext.Location = New System.Drawing.Point(1074, 634)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(170, 74)
        Me.btnNext.TabIndex = 28
        Me.btnNext.TabStop = False
        Me.btnNext.Text = "Next (N)"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblDispTitle
        '
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblDispTitle.Font = New System.Drawing.Font("Cambria", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(528, 28)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(210, 51)
        Me.lblDispTitle.TabIndex = 30
        Me.lblDispTitle.Text = "You Win!:"
        '
        'EndScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Harry_Potter___Trials_of_Hogwarts.My.Resources.Resources.BlankHogwarts
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblDispTitle)
        Me.Controls.Add(Me.lblDispEnding)
        Me.Controls.Add(Me.btnNext)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EndScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harry Potter and the Trials of Hogwarts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents lblDispEnding As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
End Class

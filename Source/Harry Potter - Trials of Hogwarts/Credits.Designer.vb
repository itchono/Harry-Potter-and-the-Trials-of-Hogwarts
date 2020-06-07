<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Credits))
        Me.lblDispTitle = New System.Windows.Forms.Label()
        Me.tmrFadeIn = New System.Windows.Forms.Timer(Me.components)
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDispTitle
        '
        Me.lblDispTitle.AutoSize = True
        Me.lblDispTitle.Font = New System.Drawing.Font("Cambria", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispTitle.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblDispTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblDispTitle.Name = "lblDispTitle"
        Me.lblDispTitle.Size = New System.Drawing.Size(153, 51)
        Me.lblDispTitle.TabIndex = 6
        Me.lblDispTitle.Text = "Credits"
        '
        'tmrFadeIn
        '
        Me.tmrFadeIn.Interval = 1
        '
        'lblCredits
        '
        Me.lblCredits.AutoSize = True
        Me.lblCredits.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblCredits.Location = New System.Drawing.Point(12, 65)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(304, 280)
        Me.lblCredits.TabIndex = 8
        Me.lblCredits.Text = resources.GetString("lblCredits.Text")
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
        Me.btnClose.TabIndex = 10
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Credits
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(300, 360)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblCredits)
        Me.Controls.Add(Me.lblDispTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Credits"
        Me.Opacity = 0R
        Me.Text = "Harry Potter and the Trials of Hogwarts - Credits"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDispTitle As System.Windows.Forms.Label
    Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Friend WithEvents lblCredits As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class

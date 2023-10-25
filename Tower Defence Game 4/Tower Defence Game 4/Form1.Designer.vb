<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Path1 = New System.Windows.Forms.PictureBox()
        Me.Path2 = New System.Windows.Forms.PictureBox()
        Me.Path3 = New System.Windows.Forms.PictureBox()
        Me.EnemyBase = New System.Windows.Forms.PictureBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.EnemyLogic = New System.Windows.Forms.Timer(Me.components)
        Me.GameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.LblLives = New System.Windows.Forms.Label()
        Me.LblWave = New System.Windows.Forms.Label()
        Me.LblCoins = New System.Windows.Forms.Label()
        Me.LblGameover = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.RetryButton = New System.Windows.Forms.Button()
        Me.PicBase = New System.Windows.Forms.PictureBox()
        CType(Me.Path1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Path2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Path3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Path1
        '
        Me.Path1.BackColor = System.Drawing.Color.SandyBrown
        Me.Path1.Location = New System.Drawing.Point(-3, 287)
        Me.Path1.Name = "Path1"
        Me.Path1.Size = New System.Drawing.Size(379, 103)
        Me.Path1.TabIndex = 1
        Me.Path1.TabStop = False
        '
        'Path2
        '
        Me.Path2.BackColor = System.Drawing.Color.SandyBrown
        Me.Path2.Location = New System.Drawing.Point(373, 117)
        Me.Path2.Name = "Path2"
        Me.Path2.Size = New System.Drawing.Size(103, 273)
        Me.Path2.TabIndex = 2
        Me.Path2.TabStop = False
        '
        'Path3
        '
        Me.Path3.BackColor = System.Drawing.Color.SandyBrown
        Me.Path3.Location = New System.Drawing.Point(373, 117)
        Me.Path3.Name = "Path3"
        Me.Path3.Size = New System.Drawing.Size(500, 103)
        Me.Path3.TabIndex = 4
        Me.Path3.TabStop = False
        '
        'EnemyBase
        '
        Me.EnemyBase.BackColor = System.Drawing.Color.Red
        Me.EnemyBase.Location = New System.Drawing.Point(-3, 287)
        Me.EnemyBase.Name = "EnemyBase"
        Me.EnemyBase.Size = New System.Drawing.Size(18, 103)
        Me.EnemyBase.TabIndex = 5
        Me.EnemyBase.TabStop = False
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StartButton.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(351, 151)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(145, 83)
        Me.StartButton.TabIndex = 7
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'EnemyLogic
        '
        '
        'GameLogic
        '
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitButton.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(351, 296)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(145, 83)
        Me.QuitButton.TabIndex = 10
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'LblLives
        '
        Me.LblLives.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblLives.Font = New System.Drawing.Font("Agency FB", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLives.Location = New System.Drawing.Point(12, 23)
        Me.LblLives.Name = "LblLives"
        Me.LblLives.Size = New System.Drawing.Size(84, 27)
        Me.LblLives.TabIndex = 11
        Me.LblLives.Text = "LIVES 0"
        '
        'LblWave
        '
        Me.LblWave.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblWave.Font = New System.Drawing.Font("Agency FB", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWave.Location = New System.Drawing.Point(12, 59)
        Me.LblWave.Name = "LblWave"
        Me.LblWave.Size = New System.Drawing.Size(95, 29)
        Me.LblWave.TabIndex = 12
        Me.LblWave.Text = "WAVES 0"
        '
        'LblCoins
        '
        Me.LblCoins.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblCoins.Font = New System.Drawing.Font("Agency FB", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCoins.Location = New System.Drawing.Point(99, 23)
        Me.LblCoins.Name = "LblCoins"
        Me.LblCoins.Size = New System.Drawing.Size(88, 27)
        Me.LblCoins.TabIndex = 13
        Me.LblCoins.Text = "COINS 0"
        '
        'LblGameover
        '
        Me.LblGameover.AutoSize = True
        Me.LblGameover.BackColor = System.Drawing.Color.SaddleBrown
        Me.LblGameover.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameover.Location = New System.Drawing.Point(232, 138)
        Me.LblGameover.Name = "LblGameover"
        Me.LblGameover.Size = New System.Drawing.Size(389, 115)
        Me.LblGameover.TabIndex = 14
        Me.LblGameover.Text = "GAMEOVER"
        Me.LblGameover.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox5.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(175, 30)
        Me.PictureBox5.TabIndex = 15
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox6.Location = New System.Drawing.Point(12, 59)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(95, 30)
        Me.PictureBox6.TabIndex = 16
        Me.PictureBox6.TabStop = False
        '
        'RetryButton
        '
        Me.RetryButton.BackColor = System.Drawing.Color.SaddleBrown
        Me.RetryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RetryButton.Font = New System.Drawing.Font("Agency FB", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetryButton.Location = New System.Drawing.Point(351, 296)
        Me.RetryButton.Name = "RetryButton"
        Me.RetryButton.Size = New System.Drawing.Size(145, 83)
        Me.RetryButton.TabIndex = 17
        Me.RetryButton.Text = "Retry"
        Me.RetryButton.UseVisualStyleBackColor = False
        Me.RetryButton.Visible = False
        '
        'PicBase
        '
        Me.PicBase.BackColor = System.Drawing.Color.Cyan
        Me.PicBase.Location = New System.Drawing.Point(855, 117)
        Me.PicBase.Name = "PicBase"
        Me.PicBase.Size = New System.Drawing.Size(18, 103)
        Me.PicBase.TabIndex = 18
        Me.PicBase.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(870, 520)
        Me.Controls.Add(Me.PicBase)
        Me.Controls.Add(Me.RetryButton)
        Me.Controls.Add(Me.LblGameover)
        Me.Controls.Add(Me.LblCoins)
        Me.Controls.Add(Me.LblWave)
        Me.Controls.Add(Me.LblLives)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.EnemyBase)
        Me.Controls.Add(Me.Path2)
        Me.Controls.Add(Me.Path3)
        Me.Controls.Add(Me.Path1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Path1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Path2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Path3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Path1 As PictureBox
    Friend WithEvents Path2 As PictureBox
    Friend WithEvents Path3 As PictureBox
    Friend WithEvents EnemyBase As PictureBox
    Friend WithEvents StartButton As Button
    Friend WithEvents EnemyLogic As Timer
    Friend WithEvents GameLogic As Timer
    Friend WithEvents QuitButton As Button
    Friend WithEvents LblLives As Label
    Friend WithEvents LblWave As Label
    Friend WithEvents LblCoins As Label
    Friend WithEvents LblGameover As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents RetryButton As Button
    Friend WithEvents PicBase As PictureBox
End Class

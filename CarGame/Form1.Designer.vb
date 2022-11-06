<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.RoadMover = New System.Windows.Forms.Timer(Me.components)
        Me.MoveLeft = New System.Windows.Forms.Timer(Me.components)
        Me.MoveRight = New System.Windows.Forms.Timer(Me.components)
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy3 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Enemy1Move = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2Move = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy3Move = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblGameEnd = New System.Windows.Forms.Label()
        Me.btnReplay = New System.Windows.Forms.Button()
        Me.SpeedIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bullet = New System.Windows.Forms.PictureBox()
        Me.BulletTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Boss = New System.Windows.Forms.PictureBox()
        Me.BossTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BossMover1 = New System.Windows.Forms.Timer(Me.components)
        Me.BossbltMover = New System.Windows.Forms.Timer(Me.components)
        Me.EnemyBlt = New System.Windows.Forms.PictureBox()
        Me.eBulletTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyBlt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(62, -27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 84)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.Location = New System.Drawing.Point(141, -27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 84)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.Location = New System.Drawing.Point(141, 97)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 84)
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Location = New System.Drawing.Point(62, 97)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 84)
        Me.PictureBox4.TabIndex = 2
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.White
        Me.PictureBox5.Location = New System.Drawing.Point(141, 211)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 84)
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.White
        Me.PictureBox6.Location = New System.Drawing.Point(62, 211)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 84)
        Me.PictureBox6.TabIndex = 4
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.White
        Me.PictureBox7.Location = New System.Drawing.Point(141, 324)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 84)
        Me.PictureBox7.TabIndex = 7
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Location = New System.Drawing.Point(62, 324)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 84)
        Me.PictureBox8.TabIndex = 6
        Me.PictureBox8.TabStop = False
        '
        'RoadMover
        '
        Me.RoadMover.Enabled = True
        Me.RoadMover.Interval = 10
        '
        'MoveLeft
        '
        Me.MoveLeft.Interval = 10
        '
        'MoveRight
        '
        Me.MoveRight.Interval = 10
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.DarkRed
        Me.Player.Location = New System.Drawing.Point(91, 269)
        Me.Player.MaximumSize = New System.Drawing.Size(30, 55)
        Me.Player.MinimumSize = New System.Drawing.Size(30, 55)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(30, 55)
        Me.Player.TabIndex = 8
        Me.Player.TabStop = False
        '
        'Enemy1
        '
        Me.Enemy1.BackColor = System.Drawing.Color.Cyan
        Me.Enemy1.Location = New System.Drawing.Point(12, 107)
        Me.Enemy1.MaximumSize = New System.Drawing.Size(30, 55)
        Me.Enemy1.MinimumSize = New System.Drawing.Size(30, 55)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(30, 55)
        Me.Enemy1.TabIndex = 9
        Me.Enemy1.TabStop = False
        '
        'Enemy3
        '
        Me.Enemy3.BackColor = System.Drawing.Color.ForestGreen
        Me.Enemy3.Location = New System.Drawing.Point(182, 183)
        Me.Enemy3.MaximumSize = New System.Drawing.Size(30, 55)
        Me.Enemy3.MinimumSize = New System.Drawing.Size(30, 55)
        Me.Enemy3.Name = "Enemy3"
        Me.Enemy3.Size = New System.Drawing.Size(30, 55)
        Me.Enemy3.TabIndex = 10
        Me.Enemy3.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.Color.Yellow
        Me.Enemy2.Location = New System.Drawing.Point(91, 25)
        Me.Enemy2.MaximumSize = New System.Drawing.Size(30, 55)
        Me.Enemy2.MinimumSize = New System.Drawing.Size(30, 55)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(30, 55)
        Me.Enemy2.TabIndex = 11
        Me.Enemy2.TabStop = False
        '
        'Enemy1Move
        '
        Me.Enemy1Move.Enabled = True
        Me.Enemy1Move.Interval = 10
        '
        'Enemy2Move
        '
        Me.Enemy2Move.Enabled = True
        Me.Enemy2Move.Interval = 10
        '
        'Enemy3Move
        '
        Me.Enemy3Move.Enabled = True
        Me.Enemy3Move.Interval = 10
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.White
        Me.lblScore.Location = New System.Drawing.Point(6, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(50, 16)
        Me.lblScore.TabIndex = 12
        Me.lblScore.Text = "Score :"
        '
        'lblGameEnd
        '
        Me.lblGameEnd.AutoSize = True
        Me.lblGameEnd.BackColor = System.Drawing.Color.White
        Me.lblGameEnd.Font = New System.Drawing.Font("Tempus Sans ITC", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameEnd.ForeColor = System.Drawing.Color.Red
        Me.lblGameEnd.Location = New System.Drawing.Point(40, 136)
        Me.lblGameEnd.Name = "lblGameEnd"
        Me.lblGameEnd.Size = New System.Drawing.Size(137, 31)
        Me.lblGameEnd.TabIndex = 13
        Me.lblGameEnd.Text = "Game Over"
        Me.lblGameEnd.Visible = False
        '
        'btnReplay
        '
        Me.btnReplay.Location = New System.Drawing.Point(78, 170)
        Me.btnReplay.Name = "btnReplay"
        Me.btnReplay.Size = New System.Drawing.Size(57, 23)
        Me.btnReplay.TabIndex = 14
        Me.btnReplay.Text = "Replay"
        Me.btnReplay.UseVisualStyleBackColor = True
        Me.btnReplay.Visible = False
        '
        'SpeedIncrease
        '
        Me.SpeedIncrease.Enabled = True
        Me.SpeedIncrease.Interval = 10000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(139, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Highscore :"
        '
        'Bullet
        '
        Me.Bullet.BackColor = System.Drawing.Color.Orange
        Me.Bullet.Location = New System.Drawing.Point(100, 289)
        Me.Bullet.Name = "Bullet"
        Me.Bullet.Size = New System.Drawing.Size(10, 23)
        Me.Bullet.TabIndex = 16
        Me.Bullet.TabStop = False
        Me.Bullet.Visible = False
        '
        'BulletTimer
        '
        Me.BulletTimer.Interval = 10
        '
        'Boss
        '
        Me.Boss.BackColor = System.Drawing.Color.DarkBlue
        Me.Boss.Enabled = False
        Me.Boss.Location = New System.Drawing.Point(78, 37)
        Me.Boss.Name = "Boss"
        Me.Boss.Size = New System.Drawing.Size(57, 77)
        Me.Boss.TabIndex = 17
        Me.Boss.TabStop = False
        Me.Boss.Visible = False
        '
        'BossTimer
        '
        Me.BossTimer.Enabled = True
        Me.BossTimer.Interval = 45000
        '
        'BossMover1
        '
        Me.BossMover1.Interval = 10
        '
        'BossbltMover
        '
        Me.BossbltMover.Interval = 10
        '
        'EnemyBlt
        '
        Me.EnemyBlt.BackColor = System.Drawing.Color.IndianRed
        Me.EnemyBlt.Location = New System.Drawing.Point(100, 86)
        Me.EnemyBlt.Name = "EnemyBlt"
        Me.EnemyBlt.Size = New System.Drawing.Size(10, 23)
        Me.EnemyBlt.TabIndex = 18
        Me.EnemyBlt.TabStop = False
        '
        'eBulletTimer
        '
        Me.eBulletTimer.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(224, 362)
        Me.Controls.Add(Me.EnemyBlt)
        Me.Controls.Add(Me.Boss)
        Me.Controls.Add(Me.Bullet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReplay)
        Me.Controls.Add(Me.lblGameEnd)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy3)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximumSize = New System.Drawing.Size(240, 400)
        Me.MinimumSize = New System.Drawing.Size(240, 400)
        Me.Name = "Form1"
        Me.Text = "Car Game"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyBlt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents RoadMover As Timer
    Friend WithEvents MoveLeft As Timer
    Friend WithEvents MoveRight As Timer
    Friend WithEvents Player As PictureBox
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Enemy3 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Enemy1Move As Timer
    Friend WithEvents Enemy2Move As Timer
    Friend WithEvents Enemy3Move As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents lblGameEnd As Label
    Friend WithEvents btnReplay As Button
    Friend WithEvents SpeedIncrease As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Bullet As PictureBox
    Friend WithEvents BulletTimer As Timer
    Friend WithEvents Boss As PictureBox
    Friend WithEvents BossTimer As Timer
    Friend WithEvents BossMover1 As Timer
    Friend WithEvents BossbltMover As Timer
    Friend WithEvents EnemyBlt As PictureBox
    Friend WithEvents eBulletTimer As Timer
End Class

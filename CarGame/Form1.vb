Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Dim highscore As Integer = 0
    Dim bossturn As Integer = 3
    Dim blthits As Integer = 0



    Private Sub RoadMover_Tick(sender As Object, e As EventArgs) Handles RoadMover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If Player.Bounds.IntersectsWith(Enemy1.Bounds) Then
            gameover()
        End If
        If Player.Bounds.IntersectsWith(Enemy2.Bounds) Then
            gameover()
        End If
        If Player.Bounds.IntersectsWith(Enemy3.Bounds) Then
            gameover()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        speed = 1
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
        Boss.Top -= 300
        EnemyBlt.Top -= 300


    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            MoveRight.Enabled = True
        ElseIf e.KeyCode = Keys.Left Then
            MoveLeft.Enabled = True
        End If


        If e.KeyCode = Keys.Space Then
            Bltshoot()

        End If


    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Right Then
            MoveRight.Enabled = False
        ElseIf e.KeyCode = Keys.Left Then
            MoveLeft.Enabled = False
        End If
    End Sub

    Private Sub MoveLeft_Tick(sender As Object, e As EventArgs) Handles MoveLeft.Tick
        If Player.Location.X > 0 Then
            Player.Left -= 4
        End If

    End Sub

    Private Sub MoveRight_Tick(sender As Object, e As EventArgs) Handles MoveRight.Tick
        If Player.Location.X < 190 Then
            Player.Left += 4
        End If

    End Sub

    Private Sub Enemy1Move_Tick(sender As Object, e As EventArgs) Handles Enemy1Move.Tick
        Enemy1.Top += speed + 1
        If Enemy1.Top >= Me.Height Then
            Enemy1.Top = -CInt(Math.Ceiling(Rnd() * 150 + Enemy1.Height))
            Enemy1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
            score += 1
            lblScore.Text = "Score:" & score

        End If
    End Sub

    Private Sub Enemy2Move_Tick(sender As Object, e As EventArgs) Handles Enemy2Move.Tick
        Enemy2.Top += speed + 3
        If Enemy2.Top >= Me.Height Then
            Enemy2.Top = -CInt(Math.Ceiling(Rnd() * 150 + Enemy2.Height))
            Enemy2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100
            score += 1
            lblScore.Text = "Score:" & score
        End If

    End Sub

    Private Sub Enemy3Move_Tick(sender As Object, e As EventArgs) Handles Enemy3Move.Tick
        Enemy3.Top += speed + 2
        If Enemy3.Top >= Me.Height Then
            Enemy3.Top = -CInt(Math.Ceiling(Rnd() * 150 + Enemy3.Height))
            Enemy3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 150
            score += 1
            lblScore.Text = "Score:" & score
        End If

    End Sub
    Private Sub gameover()
        lblGameEnd.Visible = True
        btnReplay.Visible = True
        Enemy1Move.Enabled = False
        Enemy2Move.Enabled = False
        Enemy3Move.Enabled = False
        RoadMover.Enabled = False
        If score > highscore Then
            highscore = score
            Label1.Text = "Highscore:" & highscore
        End If

    End Sub

    Private Sub btnReplay_Click(sender As Object, e As EventArgs) Handles btnReplay.Click
        score = 0
        blthits = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
        Label1.Text = "Highscore:" & highscore

    End Sub

    Private Sub SpeedIncrease_Tick(sender As Object, e As EventArgs) Handles SpeedIncrease.Tick
        speed += 1
    End Sub
    Private Sub Bltshoot()
        BulletTimer.Enabled = True
        Bullet.Visible = True
        Bullet.Location = Player.Location

    End Sub
    Private Sub bltstop()
        BulletTimer.Enabled = False
        Bullet.Visible = False
        Bullet.Location = Player.Location
    End Sub
    Private Sub BulletTimer_Tick(sender As Object, e As EventArgs) Handles BulletTimer.Tick
        If Bullet.Top > 400 Then
            bltstop()
        End If

        Bullet.Top -= 5
        If Bullet.Bounds.IntersectsWith(Enemy1.Bounds) Then
            Enemy1.Top = -CInt(Math.Ceiling(Rnd() * 200 + Enemy1.Height))
            Enemy1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
            score += 3
            lblScore.Text = "Score:" & score
            bltstop()

        ElseIf Bullet.Bounds.IntersectsWith(Enemy2.Bounds)
            Enemy2.Top = -CInt(Math.Ceiling(Rnd() * 200 + Enemy2.Height))
            Enemy2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100
            score += 3
            lblScore.Text = "Score:" & score
            bltstop()

        ElseIf Bullet.Bounds.IntersectsWith(Enemy3.Bounds)
            Enemy3.Top = -CInt(Math.Ceiling(Rnd() * 200 + Enemy3.Height))
            Enemy3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 150
            score += 3
            lblScore.Text = "Score:" & score
            bltstop()

        End If

        If Bullet.Bounds.IntersectsWith(Boss.Bounds) Then
            blthits += 1
            bltstop()
        ElseIf blthits >= 6 Then
            blthits = 0
            continuegame()

        End If
    End Sub
    Private Sub continuegame()
        score += 50
        Boss.Top -= 300
        Boss.Visible = False



        Enemy1.Top = -CInt(Math.Ceiling(Rnd() * 150 + Enemy1.Height))
        Enemy1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        Enemy2.Top = -CInt(Math.Ceiling(Rnd() * 150 + Enemy2.Height))
        Enemy2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100
        Enemy3.Top = -CInt(Math.Ceiling(Rnd() * 150 + Enemy3.Height))
        Enemy3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 150
        Enemy1Move.Enabled = True
        Enemy2Move.Enabled = True
        Enemy3Move.Enabled = True
        BossTimer.Enabled = True
        BossTimer.Interval += 10000
        Enemy1.Visible = True
        Enemy2.Visible = True
        Enemy3.Visible = True
        eBulletTimer.Enabled = False
        BossbltMover.Enabled = False

    End Sub

    Private Sub BossTimer_Tick(sender As Object, e As EventArgs) Handles BossTimer.Tick
        Boss.Top += 300
        Boss.Enabled = True
        Boss.Visible = True
        Enemy1.Top = -CInt(Math.Ceiling(Rnd() * 150 + Enemy1.Height))
        Enemy1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        Enemy2.Top = -CInt(Math.Ceiling(Rnd() * 150 + Enemy2.Height))
        Enemy2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100
        Enemy3.Top = -CInt(Math.Ceiling(Rnd() * 150 + Enemy3.Height))
        Enemy3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 150
        Enemy1Move.Enabled = False
        Enemy2Move.Enabled = False
        Enemy3Move.Enabled = False
        BossTimer.Enabled = False
        Enemy1.Visible = False
        Enemy2.Visible = False
        Enemy3.Visible = False
        BossMover1.Enabled = True
        eBulletTimer.Enabled = True
        BossbltMover.Enabled = True
        speed -= 3


    End Sub

    Private Sub BossMover1_Tick(sender As Object, e As EventArgs) Handles BossMover1.Tick

        Boss.Left += bossturn

        If Boss.Location.X < 5 Then
            bossturn = -bossturn
        ElseIf Boss.Location.X > 170 Then
            bossturn = -bossturn
        End If


    End Sub

    Private Sub eBulletTimer_Tick(sender As Object, e As EventArgs) Handles eBulletTimer.Tick
        EnemyBlt.Left = Int(Boss.Width / 2)
        EnemyBlt.Top = Boss.Bottom


    End Sub

    Private Sub BossbltMover_Tick(sender As Object, e As EventArgs) Handles BossbltMover.Tick
        EnemyBlt.Top += 3
        If EnemyBlt.Bounds.IntersectsWith(Player.Bounds) Then
            gameover()

        End If
    End Sub
End Class




Public Class Enemy

    Public EnemyGraphic As PictureBox
    Public MovementSpeed As Integer
    Public Health As Integer
    Public CoinsDropped As Integer

    Public Sub New(Graphic As PictureBox, MovementSpeed As Integer, Health As Integer, CoinsDropped As Integer)

        With Me

            .EnemyGraphic = Graphic
            .MovementSpeed = MovementSpeed
            .Health = Health
            .CoinsDropped = CoinsDropped


        End With

    End Sub
    Public Sub Move()

        If EnemyGraphic IsNot Nothing Then
            If EnemyGraphic.Location.X > -1000 And EnemyGraphic.Location.X < 408 Then
                EnemyGraphic.Left += MovementSpeed
            End If

            If EnemyGraphic.Location.X > 405 And EnemyGraphic.Location.Y > 158 Then
                EnemyGraphic.Top -= MovementSpeed
            End If
            If EnemyGraphic.Location.Y = 158 Then
                EnemyGraphic.Left += MovementSpeed
            End If
        End If

    End Sub

    Public Sub EnemyReachedBase()

        If EnemyGraphic.Bounds.IntersectsWith(Form1.PicBase.Bounds) Then
            EnemyGraphic.Top -= 1000
            With Form1
                .Lives -= 1
                .currentEnemies.Remove(Me)
                .NumberOfEnemies -= 1
            End With
        End If

    End Sub

    Public Sub WaveSpawn(NumberOfGoblins As Integer)


        For counter = 0 To NumberOfGoblins - 1
            With Form1
                ReDim Preserve .PicGoblins(.IntCount)
                .PicGoblins(counter) = New PictureBox
                .PicGoblins(counter).Location = New Point(-800 + (counter * 50), 326)
                .PicGoblins(counter).Size = New Size(30, 30)
                .PicGoblins(counter).BackColor = Color.Green
                .PicGoblins(counter).Name = ("goblin" & counter.ToString())

                .Controls.Add(.PicGoblins(counter))

                .IntCount += 1
            End With
        Next

        Form1.IntCount = 0

        For counter = 0 To NumberOfGoblins - 1

            With Form1
                ReDim Preserve .goblins(.intcount)
                .Goblins(counter) = New Enemy(DirectCast(.Controls("goblin" & counter.ToString()), PictureBox), 3, 3, 5)
                .Goblins(counter).EnemyGraphic.BringToFront()
                .currentEnemies.Add(.Goblins(counter))

                .IntCount += 1
            End With
        Next



    End Sub

End Class

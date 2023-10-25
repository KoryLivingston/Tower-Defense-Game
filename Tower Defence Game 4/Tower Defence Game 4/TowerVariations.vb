Public Class Tower

    Public TowerGraphic As PictureBox
    Public Cost As Integer
    Public Range As Integer
    Public Damage As Integer
    Public Shot As PictureBox
    Public ShotSpeed As Integer
    Public Target As Enemy

    Public Sub New(Graphic As PictureBox, Cost As Integer, Range As Integer, Damage As Integer, Shot As PictureBox, ShotSpeed As Integer)

        With Me

            .TowerGraphic = Graphic
            .Cost = Cost
            .Range = Range
            .Damage = Damage
            .Shot = Shot
            .ShotSpeed = ShotSpeed
            .Target = Nothing

        End With


    End Sub


    Private Function CalculateDistance(p1 As Point, p2 As Point) As Double

        Dim dx As Integer = p2.X - p1.X
        Dim dy As Integer = p2.Y - p1.Y

        Return Math.Sqrt(dx * dx + dy * dy)

    End Function


    Public Sub NearestEnemy(Goblins As Enemy())

        Dim NearestDistance As Double = Double.MaxValue
        Dim NearestGoblin As Enemy = Nothing

        For Each Goblin As Enemy In Goblins

            If Goblin IsNot Nothing AndAlso CalculateDistance(TowerGraphic.Location, Goblin.EnemyGraphic.Location) <= Range Then
                Dim distanceToBase As Double = CalculateDistance(Goblin.EnemyGraphic.Location, Form1.PicBase.Location)
                If distanceToBase < NearestDistance Then
                    NearestDistance = distanceToBase
                    NearestGoblin = Goblin
                End If
            End If
        Next

        Target = NearestGoblin

    End Sub

    Public Sub Shoot()

        If Target IsNot Nothing Then
            Dim directionX As Integer = Target.EnemyGraphic.Location.X - TowerGraphic.Location.X
            Dim directionY As Integer = Target.EnemyGraphic.Location.Y - TowerGraphic.Location.Y
            Dim distance As Double = Math.Sqrt(directionX * directionX + directionY * directionY)

            If distance > 0 Then
                directionX /= distance
                directionY /= distance
            End If


            Shot.Left += CInt(ShotSpeed * directionX)
            Shot.Top += CInt(ShotSpeed * directionY)


            If Shot.Bounds.IntersectsWith(Target.EnemyGraphic.Bounds) Then

                Target.Health -= Damage


                If Target.Health <= 0 Then


                    Target.EnemyGraphic.Hide()
                    Target = Nothing


                End If


                Shot.Hide()

            End If
        End If
    End Sub

End Class

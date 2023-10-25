
Public Class Form1


    Public currentEnemies As New List(Of Enemy)
    Public NumberOfEnemies As Integer = 10
    Public NumberOfGoblins As Integer

    Public IntCount As Integer
    Public PicGoblins(-1) As PictureBox
    Public Goblins(-1) As Enemy


    Public Lives As Integer = 10
    Public Coins As Integer = 50
    Public Wave As Integer = 1


    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        StartButton.Hide()
        QuitButton.Hide()

        EnemyLogic.Enabled = True
        EnemyLogic.Start()

        GameLogic.Enabled = True
        GameLogic.Start()


    End Sub


    Private Sub GameLogic_Tick(sender As Object, e As EventArgs) Handles GameLogic.Tick

        LblLives.Text = "LIVES  " & Lives
        LblCoins.Text = "COINS  " & Coins
        LblWave.Text = "WAVES  " & Wave

        If NumberOfEnemies = 0 Then
            Wave += 1
        End If

        If Lives = 0 Then
            Endgame()
        End If


    End Sub




    Private Sub EnemyLogic_Tick(sender As Object, e As EventArgs) Handles EnemyLogic.Tick

        For counter = 0 To 9
            currentEnemies(counter).Move()
            currentEnemies(counter).EnemyReachedBase()
        Next

        If Wave = 1 Then
            Goblins(9).WaveSpawn(10)
        End If
    End Sub

    Public Sub Endgame()

        EnemyLogic.Stop()
        GameLogic.Stop()
        LblGameover.Show()
        RetryButton.Show()


    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click

        Me.Close()


    End Sub

    Private Sub RetryButton_Click(sender As Object, e As EventArgs) Handles RetryButton.Click

        Lives = 10
        Coins = 50
        Wave = 1



        LblGameover.Hide()
        RetryButton.Hide()

        EnemyLogic.Start()
        GameLogic.Start()



    End Sub

End Class




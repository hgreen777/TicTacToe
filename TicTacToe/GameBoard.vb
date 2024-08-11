Imports System.Media
Imports System.Numerics

Public Class GameBoard
    Dim settings_store As String() = {"0", "0", "0"}

    Dim go As Integer = 1
    Dim won As Integer = 0
    Dim gocount As Integer = 0

    Dim ran1 As Boolean = False
    Dim ran2 As Boolean = False
    Dim ran3 As Boolean = False
    Dim ran4 As Boolean = False
    Dim ran5 As Boolean = False
    Dim ran6 As Boolean = False
    Dim ran7 As Boolean = False
    Dim ran8 As Boolean = False
    Dim ran9 As Boolean = False

    Dim who1 As Integer
    Dim who2 As Integer
    Dim who3 As Integer
    Dim who4 As Integer
    Dim who5 As Integer
    Dim who6 As Integer
    Dim who7 As Integer
    Dim who8 As Integer
    Dim who9 As Integer

    Dim xwins As Integer = 0
    Dim owins As Integer = 0
    Dim ran As Boolean = False
    Dim ran69 As Boolean = False

    Private Sub GameBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
        blurScreen.Hide()

        winText.Hide()
        Home.Hide()
        Reset.Hide()
        turnchanger()
    End Sub

    'ES1 Placing +Hovering
    Private Sub es1_Click(sender As Object, e As EventArgs) Handles es1.Click
        If ran1 = False Then
            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
            End If
            If go = 1 Then
                Me.es1.Image = Global.TicTacToe.My.Resources.Resources.x
                ran1 = True
                go = 2

                turnchanger()

                who1 = 1
                wincheck()
            ElseIf go = 2 Then
                Me.es1.Image = Global.TicTacToe.My.Resources.Resources.o
                ran1 = True
                go = 1

                turnchanger()
                who1 = 2
                wincheck()

            End If
            gocount += 1
        End If
    End Sub


    Private Sub es1_MouseHover(sender As Object, e As EventArgs) Handles es1.MouseHover
        If ran1 = False Then
            Me.es1.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es1_MouseLeave(sender As Object, e As EventArgs) Handles es1.MouseLeave
        If ran1 = False Then
            Me.es1.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES2 Placing +Hovering
    Private Sub es2_Click(sender As Object, e As EventArgs) Handles es2.Click
        If ran2 = False Then
            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
            End If

            If go = 1 Then
                Me.es2.Image = Global.TicTacToe.My.Resources.Resources.x
                ran2 = True
                go = 2

                turnchanger()

                who2 = 1
                wincheck()
            ElseIf go = 2 Then
                Me.es2.Image = Global.TicTacToe.My.Resources.Resources.o
                ran2 = True
                go = 1

                turnchanger()
                who2 = 2
                wincheck()

            End If
            gocount += 1
        End If
    End Sub

    Private Sub es2_MouseHover(sender As Object, e As EventArgs) Handles es2.MouseHover
        If ran2 = False Then
            Me.es2.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es2_MouseLeave(sender As Object, e As EventArgs) Handles es2.MouseLeave
        If ran2 = False Then
            Me.es2.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES3 Placing +Hovering
    Private Sub es3_Click(sender As Object, e As EventArgs) Handles es3.Click
        If ran3 = False Then

            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
            End If

            If go = 1 Then
                Me.es3.Image = Global.TicTacToe.My.Resources.Resources.x
                ran3 = True
                go = 2

                turnchanger()

                who3 = 1
                wincheck()
            ElseIf go = 2 Then
                Me.es3.Image = Global.TicTacToe.My.Resources.Resources.o
                ran3 = True
                go = 1

                turnchanger()
                who3 = 2
                wincheck()

            End If
            gocount += 1
        End If
    End Sub

    Private Sub es3_MouseHover(sender As Object, e As EventArgs) Handles es3.MouseHover
        If ran3 = False Then
            Me.es3.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es3_MouseLeave(sender As Object, e As EventArgs) Handles es3.MouseLeave
        If ran3 = False Then
            Me.es3.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES4 Placing +Hovering
    Private Sub es4_Click(sender As Object, e As EventArgs) Handles es4.Click
        If ran4 = False Then
            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
            End If
            If go = 1 Then
                Me.es4.Image = Global.TicTacToe.My.Resources.Resources.x
                ran4 = True
                go = 2

                turnchanger()

                who4 = 1
                wincheck()
            ElseIf go = 2 Then
                Me.es4.Image = Global.TicTacToe.My.Resources.Resources.o
                ran4 = True
                go = 1

                turnchanger()
                who4 = 2
                wincheck()

            End If
            gocount += 1
        End If
    End Sub

    Private Sub es4_MouseHover(sender As Object, e As EventArgs) Handles es4.MouseHover
        If ran4 = False Then
            Me.es4.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es4_MouseLeave(sender As Object, e As EventArgs) Handles es4.MouseLeave
        If ran4 = False Then
            Me.es4.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES5 Placing +Hovering
    Private Sub es5_Click(sender As Object, e As EventArgs) Handles es5.Click
        If ran5 = False Then
            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
            End If

            If go = 1 Then
                Me.es5.Image = Global.TicTacToe.My.Resources.Resources.x
                ran5 = True
                go = 2

                turnchanger()

                who5 = 1
                wincheck()
            ElseIf go = 2 Then
                Me.es5.Image = Global.TicTacToe.My.Resources.Resources.o
                ran5 = True
                go = 1

                turnchanger()
                who5 = 2
                wincheck()

            End If
            gocount += 1
        End If
    End Sub

    Private Sub es5_MouseHover(sender As Object, e As EventArgs) Handles es5.MouseHover
        If ran5 = False Then
            Me.es5.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es5_MouseLeave(sender As Object, e As EventArgs) Handles es5.MouseLeave
        If ran5 = False Then
            Me.es5.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES6 Placing +Hovering
    Private Sub es6_Click(sender As Object, e As EventArgs) Handles es6.Click
        If ran6 = False Then
            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
            End If

            If go = 1 Then
                Me.es6.Image = Global.TicTacToe.My.Resources.Resources.x
                ran6 = True
                go = 2

                turnchanger()

                who6 = 1
                wincheck()
            ElseIf go = 2 Then
                Me.es6.Image = Global.TicTacToe.My.Resources.Resources.o
                ran6 = True
                go = 1

                turnchanger()
                who6 = 2
                wincheck()

            End If
            gocount += 1
        End If
    End Sub

    Private Sub es6_MouseHover(sender As Object, e As EventArgs) Handles es6.MouseHover
        If ran6 = False Then
            Me.es6.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es6_MouseLeave(sender As Object, e As EventArgs) Handles es6.MouseLeave
        If ran6 = False Then
            Me.es6.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES7 Placing +Hovering
    Private Sub es7_Click(sender As Object, e As EventArgs) Handles es7.Click
        If ran7 = False Then
            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
            End If
            If go = 1 Then
                Me.es7.Image = Global.TicTacToe.My.Resources.Resources.x
                ran7 = True
                go = 2

                turnchanger()

                who7 = 1
                wincheck()
            ElseIf go = 2 Then
                Me.es7.Image = Global.TicTacToe.My.Resources.Resources.o
                ran7 = True
                go = 1

                turnchanger()
                who7 = 2
                wincheck()

            End If
            gocount += 1
        End If
    End Sub

    Private Sub es7_MouseHover(sender As Object, e As EventArgs) Handles es7.MouseHover
        If ran7 = False Then
            Me.es7.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es7_MouseLeave(sender As Object, e As EventArgs) Handles es7.MouseLeave
        If ran7 = False Then
            Me.es7.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES8 Placing +Hovering
    Private Sub es8_Click(sender As Object, e As EventArgs) Handles es8.Click
        If ran8 = False Then
            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
            End If
            If go = 1 Then
                Me.es8.Image = Global.TicTacToe.My.Resources.Resources.x
                ran8 = True
                go = 2

                turnchanger()

                who8 = 1
                wincheck()
            ElseIf go = 2 Then
                Me.es8.Image = Global.TicTacToe.My.Resources.Resources.o
                ran8 = True
                go = 1

                turnchanger()
                who8 = 2
                wincheck()

            End If
            gocount += 1
        End If
    End Sub

    Private Sub es8_MouseHover(sender As Object, e As EventArgs) Handles es8.MouseHover
        If ran8 = False Then
            Me.es8.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es8_MouseLeave(sender As Object, e As EventArgs) Handles es8.MouseLeave
        If ran8 = False Then
            Me.es8.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES9 Placing +Hovering
    Private Sub es9_Click(sender As Object, e As EventArgs) Handles es9.Click
        If ran9 = False Then
            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
            End If

            If go = 1 Then
                Me.es9.Image = Global.TicTacToe.My.Resources.Resources.x
                ran9 = True
                go = 2

                turnchanger()

                who9 = 1
                wincheck()
            ElseIf go = 2 Then
                Me.es9.Image = Global.TicTacToe.My.Resources.Resources.o
                ran9 = True
                go = 1

                turnchanger()
                who9 = 2
                wincheck()

            End If
            gocount += 1
        End If
    End Sub

    Private Sub es9_MouseHover(sender As Object, e As EventArgs) Handles es9.MouseHover
        If ran9 = False Then
            Me.es9.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es9_MouseLeave(sender As Object, e As EventArgs) Handles es9.MouseLeave
        If ran9 = False Then
            Me.es9.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    Private Sub turnchanger()
        If go = 1 Then
            Me.turn.Image = Global.TicTacToe.My.Resources.Resources.xturn
        ElseIf go = 2 Then
            Me.turn.Image = Global.TicTacToe.My.Resources.Resources.oturn
        End If
    End Sub

    Private Sub wincheck()
        If (who1 = 1 And who2 = 1 And who3 = 1) Or (who4 = 1 And who5 = 1 And who6 = 1) Or (who7 = 1 And who8 = 1 And who9 = 1) Or (who1 = 1 And who4 = 1 And who7 = 1) Or (who2 = 1 And who5 = 1 And who8 = 1) Or (who3 = 1 And who6 = 1 And who9 = 1) Or (who1 = 1 And who5 = 1 And who9 = 1) Or (who7 = 1 And who5 = 1 And who3 = 1) Then
            go = 5
            won = 1

            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.winloss__1_, AudioPlayMode.Background)
            End If
            FileClose(1)

            xwins += 1
            Label2.Text = xwins
            HundredPlus()

            Me.turn.Image = Global.TicTacToe.My.Resources.Resources.turn_text
            blurScreen.Show()
            winText.Show()
            Me.winText.Image = Global.TicTacToe.My.Resources.Resources.newXwins
            Home.Show()
            Reset.Show()

        ElseIf (who1 = 2 And who2 = 2 And who3 = 2) Or (who4 = 2 And who5 = 2 And who6 = 2) Or (who7 = 2 And who8 = 2 And who9 = 2) Or (who1 = 2 And who4 = 2 And who7 = 2) Or (who2 = 2 And who5 = 2 And who8 = 2) Or (who3 = 2 And who6 = 2 And who9 = 2) Or (who1 = 2 And who5 = 2 And who9 = 2) Or (who7 = 2 And who5 = 2 And who3 = 2) Then
            go = 5
            won = 2

            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.winloss__1_, AudioPlayMode.Background)
            End If

            owins += 1
            Label1.Text = owins
            HundredPlus()


            Me.turn.Image = Global.TicTacToe.My.Resources.Resources.turn_text
            blurScreen.Show()
            winText.Show()
            Me.winText.Image = Global.TicTacToe.My.Resources.Resources.newOwins
            Home.Show()
            Reset.Show()

        ElseIf (gocount = 8) And (((who1 = 1 And who2 = 1 And who3 = 1) Or (who4 = 1 And who5 = 1 And who6 = 1) Or (who7 = 1 And who8 = 1 And who9 = 1) Or (who1 = 1 And who4 = 1 And who7 = 1) Or (who2 = 1 And who5 = 1 And who8 = 1) Or (who3 = 1 And who6 = 1 And who9 = 1) Or (who1 = 1 And who5 = 1 And who9 = 1) Or (who7 = 1 And who5 = 1 And who3 = 1)) = False) And (((who1 = 2 And who2 = 2 And who3 = 2) Or (who4 = 2 And who5 = 2 And who6 = 2) Or (who7 = 2 And who8 = 2 And who9 = 2) Or (who1 = 2 And who4 = 2 And who7 = 2) Or (who2 = 2 And who5 = 2 And who8 = 2)) = False) Then
            go = 5
            won = 3

            If settings_store(1) = "1" Then
                My.Computer.Audio.Play(My.Resources.draw__1_, AudioPlayMode.Background)
            End If

            Me.turn.Image = Global.TicTacToe.My.Resources.Resources.turn_text
            blurScreen.Show()
            winText.Show()
            Me.winText.Image = Global.TicTacToe.My.Resources.Resources.newDrawWins
            Home.Show()
            Reset.Show()

        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        blurScreen.Hide()
        winText.Hide()
        Home.Hide()
        Reset.Hide()

        ran1 = False
        ran2 = False
        ran3 = False
        ran4 = False
        ran5 = False
        ran6 = False
        ran7 = False
        ran8 = False
        ran9 = False

        who1 = 5
        who2 = 5
        who3 = 5
        who4 = 5
        who5 = 5
        who6 = 5
        who7 = 5
        who8 = 5
        who9 = 5

        won = 0

        go = 1
        gocount = 0
        turnchanger()

        Me.es1.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es2.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es3.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es4.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es5.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es6.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es7.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es8.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es9.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Form1.Show()
        blurScreen.Hide()
        winText.Hide()
        Home.Hide()
        Reset.Hide()

        Form1.BgMusic()

        ran1 = False
        ran2 = False
        ran3 = False
        ran4 = False
        ran5 = False
        ran6 = False
        ran7 = False
        ran8 = False
        ran9 = False

        who1 = 5
        who2 = 5
        who3 = 5
        who4 = 5
        who5 = 5
        who6 = 5
        who7 = 5
        who8 = 5
        who9 = 5

        won = 0

        go = 1
        gocount = 0
        turnchanger()

        Me.es1.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es2.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es3.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es4.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es5.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es6.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es7.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es8.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.es9.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Form1.BgMusic()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Settings.Show()

        Me.Hide()
    End Sub

    Public Sub WinsSetter()
        Label2.Text = xwins
        Label1.Text = owins
        HundredPlus()
    End Sub

    Private Sub HundredPlus()

        If xwins > 99 Then
            Label2.Text = "x"
            If ran = False Then
                MsgBox("Click on the x to see wins now as the wins have exceeded 100 and there is not enough space.")
                ran = True
            End If
        End If
        If owins > 99 Then
            Label1.Text = "x"
            If ran69 = False Then
                MsgBox("Click on the x to see wins now as the wins have exceeded 100 and there is not enough space.")
                ran69 = True
            End If

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        MsgBox(xwins)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        MsgBox(owins)
    End Sub

    Public Sub GameBoard_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        settings_store = SettingsHandler.obtain_settingsValues()
    End Sub
End Class
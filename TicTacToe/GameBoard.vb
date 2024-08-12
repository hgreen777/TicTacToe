Imports System.Media
Imports System.Numerics

Public Class GameBoard
    Dim settings_store As String() = {"0", "0", "0"}

    Dim go As Integer = 1
    Dim won As Integer = 0
    Dim gocount As Integer = 0

    Dim square_played(8) As Boolean

    Dim who_in_square(8) As Integer

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

    Sub play_place_sound()
        If settings_store(1) = "1" Then
            My.Computer.Audio.Play(My.Resources.place, AudioPlayMode.Background)
        End If
    End Sub

    Sub switch_from_x_to_o(location As Integer)
        square_played(location) = True
        who_in_square(location) = 1
        go = 2
        turnchanger()
        wincheck()
    End Sub

    Sub switch_from_o_to_x(location As Integer)
        square_played(location) = True
        who_in_square(location) = 2
        go = 1
        turnchanger()
        wincheck()
    End Sub

#Region "Row 1"
    'ES1 Placing +Hovering
    Private Sub es1_Click(sender As Object, e As EventArgs) Handles es1.Click
        If square_played(0) = False Then
            play_place_sound()

            If go = 1 Then
                Me.es1.Image = Global.TicTacToe.My.Resources.Resources.x
                switch_from_x_to_o(0)

            ElseIf go = 2 Then
                Me.es1.Image = Global.TicTacToe.My.Resources.Resources.o
                switch_from_o_to_x(0)

            End If
            gocount += 1
        End If
    End Sub


    Private Sub es1_MouseHover(sender As Object, e As EventArgs) Handles es1.MouseHover
        If square_played(0) = False Then
            Me.es1.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es1_MouseLeave(sender As Object, e As EventArgs) Handles es1.MouseLeave
        If square_played(0) = False Then
            Me.es1.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES2 Placing +Hovering
    Private Sub es2_Click(sender As Object, e As EventArgs) Handles es2.Click
        If square_played(1) = False Then
            play_place_sound()

            If go = 1 Then
                Me.es2.Image = Global.TicTacToe.My.Resources.Resources.x
                switch_from_x_to_o(1)
            ElseIf go = 2 Then
                Me.es2.Image = Global.TicTacToe.My.Resources.Resources.o
                switch_from_o_to_x(1)
            End If
            gocount += 1
        End If
    End Sub

    Private Sub es2_MouseHover(sender As Object, e As EventArgs) Handles es2.MouseHover
        If square_played(1) = False Then
            Me.es2.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es2_MouseLeave(sender As Object, e As EventArgs) Handles es2.MouseLeave
        If square_played(1) = False Then
            Me.es2.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES3 Placing +Hovering
    Private Sub es3_Click(sender As Object, e As EventArgs) Handles es3.Click
        If square_played(2) = False Then
            play_place_sound()

            If go = 1 Then
                Me.es3.Image = Global.TicTacToe.My.Resources.Resources.x
                switch_from_x_to_o(2)
            ElseIf go = 2 Then
                Me.es3.Image = Global.TicTacToe.My.Resources.Resources.o
                switch_from_o_to_x(2)
            End If
            gocount += 1
        End If
    End Sub

    Private Sub es3_MouseHover(sender As Object, e As EventArgs) Handles es3.MouseHover
        If square_played(2) = False Then
            Me.es3.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es3_MouseLeave(sender As Object, e As EventArgs) Handles es3.MouseLeave
        If square_played(2) = False Then
            Me.es3.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

#End Region

#Region "Row 2"
    'ES4 Placing +Hovering
    Private Sub es4_Click(sender As Object, e As EventArgs) Handles es4.Click
        If square_played(3) = False Then
            play_place_sound()

            If go = 1 Then
                Me.es4.Image = Global.TicTacToe.My.Resources.Resources.x
                switch_from_x_to_o(3)
            ElseIf go = 2 Then
                Me.es4.Image = Global.TicTacToe.My.Resources.Resources.o
                switch_from_o_to_x(3)
            End If
            gocount += 1
        End If
    End Sub

    Private Sub es4_MouseHover(sender As Object, e As EventArgs) Handles es4.MouseHover
        If square_played(3) = False Then
            Me.es4.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es4_MouseLeave(sender As Object, e As EventArgs) Handles es4.MouseLeave
        If square_played(3) = False Then
            Me.es4.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES5 Placing +Hovering
    Private Sub es5_Click(sender As Object, e As EventArgs) Handles es5.Click
        If square_played(4) = False Then
            play_place_sound()

            If go = 1 Then
                Me.es5.Image = Global.TicTacToe.My.Resources.Resources.x
                switch_from_x_to_o(4)
            ElseIf go = 2 Then
                Me.es5.Image = Global.TicTacToe.My.Resources.Resources.o
                switch_from_o_to_x(4)
            End If
            gocount += 1
        End If
    End Sub

    Private Sub es5_MouseHover(sender As Object, e As EventArgs) Handles es5.MouseHover
        If square_played(4) = False Then
            Me.es5.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es5_MouseLeave(sender As Object, e As EventArgs) Handles es5.MouseLeave
        If square_played(4) = False Then
            Me.es5.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES6 Placing +Hovering
    Private Sub es6_Click(sender As Object, e As EventArgs) Handles es6.Click
        If square_played(5) = False Then
            play_place_sound()

            If go = 1 Then
                Me.es6.Image = Global.TicTacToe.My.Resources.Resources.x
                switch_from_x_to_o(5)
            ElseIf go = 2 Then
                Me.es6.Image = Global.TicTacToe.My.Resources.Resources.o
                switch_from_o_to_x(5)
            End If
            gocount += 1
        End If
    End Sub

    Private Sub es6_MouseHover(sender As Object, e As EventArgs) Handles es6.MouseHover
        If square_played(5) = False Then
            Me.es6.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es6_MouseLeave(sender As Object, e As EventArgs) Handles es6.MouseLeave
        If square_played(5) = False Then
            Me.es6.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub
#End Region

#Region "Row 3"
    'ES7 Placing +Hovering
    Private Sub es7_Click(sender As Object, e As EventArgs) Handles es7.Click
        If square_played(6) = False Then
            play_place_sound()

            If go = 1 Then
                Me.es7.Image = Global.TicTacToe.My.Resources.Resources.x
                switch_from_x_to_o(6)
            ElseIf go = 2 Then
                Me.es7.Image = Global.TicTacToe.My.Resources.Resources.o
                switch_from_o_to_x(6)
            End If
            gocount += 1
        End If
    End Sub

    Private Sub es7_MouseHover(sender As Object, e As EventArgs) Handles es7.MouseHover
        If square_played(6) = False Then
            Me.es7.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es7_MouseLeave(sender As Object, e As EventArgs) Handles es7.MouseLeave
        If square_played(6) = False Then
            Me.es7.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES8 Placing +Hovering
    Private Sub es8_Click(sender As Object, e As EventArgs) Handles es8.Click
        If square_played(7) = False Then
            play_place_sound()

            If go = 1 Then
                Me.es8.Image = Global.TicTacToe.My.Resources.Resources.x
                switch_from_x_to_o(7)
            ElseIf go = 2 Then
                Me.es8.Image = Global.TicTacToe.My.Resources.Resources.o
                switch_from_o_to_x(7)
            End If
            gocount += 1
        End If
    End Sub

    Private Sub es8_MouseHover(sender As Object, e As EventArgs) Handles es8.MouseHover
        If square_played(7) = False Then
            Me.es8.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es8_MouseLeave(sender As Object, e As EventArgs) Handles es8.MouseLeave
        If square_played(7) = False Then
            Me.es8.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

    'ES9 Placing +Hovering
    Private Sub es9_Click(sender As Object, e As EventArgs) Handles es9.Click
        If square_played(8) = False Then
            play_place_sound()

            If go = 1 Then
                Me.es9.Image = Global.TicTacToe.My.Resources.Resources.x
                switch_from_x_to_o(8)
            ElseIf go = 2 Then
                Me.es9.Image = Global.TicTacToe.My.Resources.Resources.o
                switch_from_o_to_x(8)
            End If
            gocount += 1
        End If
    End Sub

    Private Sub es9_MouseHover(sender As Object, e As EventArgs) Handles es9.MouseHover
        If square_played(8) = False Then
            Me.es9.Image = Global.TicTacToe.My.Resources.Resources.hovered
        End If
    End Sub

    Private Sub es9_MouseLeave(sender As Object, e As EventArgs) Handles es9.MouseLeave
        If square_played(8) = False Then
            Me.es9.Image = Global.TicTacToe.My.Resources.Resources.emptySquare
        End If
    End Sub

#End Region

    Private Sub turnchanger()
        If go = 1 Then
            Me.turn.Image = Global.TicTacToe.My.Resources.Resources.xturn
        ElseIf go = 2 Then
            Me.turn.Image = Global.TicTacToe.My.Resources.Resources.oturn
        End If
    End Sub

    Private Sub wincheck()
        If (who_in_square(0) = 1 And who_in_square(1) = 1 And who_in_square(2) = 1) Or (who_in_square(3) = 1 And who_in_square(4) = 1 And who_in_square(5) = 1) Or (who_in_square(6) = 1 And who_in_square(7) = 1 And who_in_square(8) = 1) Or (who_in_square(0) = 1 And who_in_square(3) = 1 And who_in_square(6) = 1) Or (who_in_square(1) = 1 And who_in_square(4) = 1 And who_in_square(7) = 1) Or (who_in_square(2) = 1 And who_in_square(5) = 1 And who_in_square(8) = 1) Or (who_in_square(0) = 1 And who_in_square(4) = 1 And who_in_square(8) = 1) Or (who_in_square(6) = 1 And who_in_square(4) = 1 And who_in_square(2) = 1) Then
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

        ElseIf (who_in_square(0) = 2 And who_in_square(1) = 2 And who_in_square(2) = 2) Or (who_in_square(3) = 2 And who_in_square(4) = 2 And who_in_square(5) = 2) Or (who_in_square(6) = 2 And who_in_square(7) = 2 And who_in_square(8) = 2) Or (who_in_square(0) = 2 And who_in_square(3) = 2 And who_in_square(6) = 2) Or (who_in_square(1) = 2 And who_in_square(4) = 2 And who_in_square(7) = 2) Or (who_in_square(2) = 2 And who_in_square(5) = 2 And who_in_square(8) = 2) Or (who_in_square(0) = 2 And who_in_square(4) = 2 And who_in_square(8) = 2) Or (who_in_square(6) = 2 And who_in_square(4) = 2 And who_in_square(2) = 2) Then
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

        ElseIf (gocount = 8) Then
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

        ' Reset ran array
        For i = 0 To 8
            square_played(i) = False
            who_in_square(i) = 5
        Next

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

        ' Reset ran array
        For i = 0 To 9
            square_played(i) = False
            who_in_square(i) = 5
        Next

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
Imports System.IO
Imports System.Text

Public Class Form1
    Dim running As Boolean = False
    Public Sub BgMusic()

        Dim settings() As String = SettingsHandler.obtain_settingsValues()

        If settings(0) = "1" Then

            If Not running Then
                My.Computer.Audio.Play(My.Resources.mainMenu, AudioPlayMode.BackgroundLoop)
                running = True
            Else
                My.Computer.Audio.Stop()
                running = False
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        GameBoard.Show()
        BgMusic()
        GameBoard.WinsSetter()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles PictureBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBox1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        If e.KeyCode = Keys.Space Then
            PictureBox1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            PictureBox1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
        If e.KeyCode = Keys.Space Then
            PictureBox1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BgMusic()
    End Sub
End Class
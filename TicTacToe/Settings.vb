Imports System.IO
Public Class Settings

    Dim settings() As String

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Save settings and return to main menu
        SettingsHandler.save_settingsValues(settings)

        GameBoard.Show()
        GameBoard.WinsSetter()
        Me.Hide()
    End Sub


    ' Set the background music to on
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            settings(0) = "1"
        Else
            settings(0) = "0"
        End If
    End Sub

    ' Set the sound effects to on
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            settings(1) = "1"
        Else
            settings(1) = "0"
        End If
    End Sub

    Public Sub SettingsCheck()
        ' Preload form with settings
        ' Check if background music is enabled.
        If settings(0) = "1" Then
            RadioButton1.Checked = True
        Else
            ' If not, set the off radio button to checked.
            RadioButton2.Checked = True
        End If
        ' Check if sound effects are enabled.
        If settings(1) = "1" Then
            RadioButton4.Checked = True 'on
        Else
            RadioButton3.Checked = True 'off
        End If
    End Sub

    Private Sub Settings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' on show, check settigns and load screen
        settings = SettingsHandler.obtain_settingsValues()
        SettingsCheck()
    End Sub
End Class
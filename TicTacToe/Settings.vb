Imports System.IO
Public Class Settings
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        GameBoard.Show()
        GameBoard.WinsSetter()
        Me.Hide()
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        'MsgBox(array1(2))


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            FileOpen(1, "Settings.txt.txt", OpenMode.Output)
            PrintLine(1, "1")
            If RadioButton4.Checked = True Then
                PrintLine(1, "1")
            Else
                PrintLine(1, "0")
            End If

            FileClose(1)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            FileOpen(1, "Settings.txt.txt", OpenMode.Output)
            PrintLine(1, "0")
            If RadioButton4.Checked = True Then
                PrintLine(1, "1")
            Else
                PrintLine(1, "0")
            End If

            FileClose(1)
            End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            FileOpen(1, "Settings.txt.txt", OpenMode.Output)

            If RadioButton1.Checked = True Then
                PrintLine(1, "1")
            Else
                PrintLine(1, "0")
            End If

            PrintLine(1, "1")

            FileClose(1)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            FileOpen(1, "Settings.txt.txt", OpenMode.Output)
            If RadioButton1.Checked = True Then
                PrintLine(1, "1")
            Else
                PrintLine(1, "0")
            End If

            PrintLine(1, "0")

            FileClose(1)
        End If
    End Sub

    Public Sub SettingsCheck()
        FileOpen(1, "Settings.txt.txt", OpenMode.Input)
        Dim check1 As String = LineInput(1)
        FileClose(1)

        FileOpen(1, "Settings.txt.txt", OpenMode.Input)
        LineInput(1)
        Dim check2 As String = LineInput(1)
        FileClose(1)

        If check1 = "1" Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If
        If check2 = "1" Then
            RadioButton4.Checked = True
        Else
            RadioButton3.Checked = True
        End If

    End Sub
End Class
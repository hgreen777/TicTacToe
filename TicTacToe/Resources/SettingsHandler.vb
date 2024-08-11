Module SettingsHandler
    Public Function obtain_settingsValues()
        ' Split the settings string into an array of strings. The settings file is seperated by commans "1,2,3"
        Dim settingsArray(2) As String

        FileOpen(1, "Settings.txt", OpenMode.Input)
        Input(1, settingsArray(0))
        Input(1, settingsArray(1))
        Input(1, settingsArray(2))
        FileClose(1)

        Return settingsArray
    End Function

    Public Sub set_settingsValues(val As String, location As Integer)
        ' Set the settings values
        Dim settingsArray() As String = obtain_settingsValues()

        settingsArray(location) = val

        ' Write the settings to the file
        FileOpen(1, "Settings.txt", OpenMode.Output)
        PrintLine(1, settingsArray(0))
        PrintLine(1, settingsArray(1))
        PrintLine(1, settingsArray(2))
        FileClose(1)

    End Sub

    Public Sub save_settingsValues(settings() As String)
        ' Write the settings to the file
        FileOpen(1, "Settings.txt", OpenMode.Output)
        PrintLine(1, settings(0))
        PrintLine(1, settings(1))
        PrintLine(1, settings(2))
        FileClose(1)
    End Sub
End Module

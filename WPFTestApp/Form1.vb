Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnShowDefaultOutlookProfile_Click(sender As Object, e As EventArgs) Handles btnShowDefaultOutlookProfile.Click
        Dim readValue = My.Computer.Registry.GetValue(
                "HKEY_CURRENT_USER\SOFTWARE\Microsoft\Office\16.0\Outlook", "DefaultProfile", Nothing)
        MsgBox("The deafult Outlook Profile is: " & readValue)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnSetSlowKeyboard.Click
        My.Computer.Registry.SetValue(
               "HKEY_CURRENT_USER\Control Panel\Keyboard", "KeyboardDelay", "5")
        MsgBox("The Keyboard delay has been set to 5")
    End Sub

    Private Sub btnSetNormalKeyboard_Click(sender As Object, e As EventArgs) Handles btnSetNormalKeyboard.Click
        My.Computer.Registry.SetValue(
               "HKEY_CURRENT_USER\Control Panel\Keyboard", "KeyboardDelay", "1")
        MsgBox("The keyboard delay has been set to 1")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim strVersion As String = "Version: 1.0.5"
        frmAboutOutlookTest.Show()

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        frmAboutOutlookTest.Show()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub
End Class

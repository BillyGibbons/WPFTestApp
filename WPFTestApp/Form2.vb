Public Class frmAboutOutlookTest
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub lblVersion_Click(sender As Object, e As EventArgs) Handles lblVersion.Click
        'Me.lblVersion.Text = String.Format("Version {0}", My.Application.Info.Version.MajorRevision.ToString)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmAboutOutlookTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Public Class frmmain

    Private Sub መዝግብToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles መዝግብToolStripMenuItem.Click
        frmregister.MdiParent = Me
        frmregister.Show()
    End Sub

    Private Sub frmmain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pic.Width = Me.Width - 14
        Me.Width = 1030
        Me.Height = 705
    End Sub

    Private Sub frmmain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ሓበሬታኣመሓይሽToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ሓበሬታኣመሓይሽToolStripMenuItem.Click

    End Sub
End Class
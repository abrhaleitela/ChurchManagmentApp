Public Class frmregister2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmregister.MdiParent = frmmain
        frmregister.Show()
    End Sub

    Private Sub txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnamep.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        If txtnamep.Text = "" Then
            err1.SetError(txtnamep, "ብኽብረትኩም ስም ኣበ ነፍሲ ኣእትዉ!")
            Exit Sub
        Else
            err1.SetError(txtnamep, "")
            ' err.Clear()
        End If
        If txtnamepc.Text = "" Then
            err1.SetError(txtnamepc, "ብኽብረትኩም ኣበ ነፍሲ ዘገልግልሉ ቤተ ክርስቲያን ኣእትዉ!")
            Exit Sub
        Else
            err1.SetError(txtnamepc, "")
            ' err.Clear()
        End If
        If rdyes.Checked = False And rdno.Checked = False Then
            err1.SetError(rdno, "ብኽብረትኩም ምልእዎ!")
            Exit Sub
        Else

            err1.SetError(rdno, "")

        End If
        If rdyes1.Checked = False And rdno1.Checked = False Then
            err1.SetError(rdno1, "ብኽብረትኩም ምልእዎ!")
            Exit Sub
        Else
            err1.SetError(rdno1, "")

        End If
        Me.Hide()
        frmregister3.MdiParent = frmmain
        frmregister3.Show()

    End Sub

   
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        frmregister.Close()
        Me.Close()
    End Sub
End Class
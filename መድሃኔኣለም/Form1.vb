Public Class frmregister

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnext.Click
        If cmbtitle.Text = "" Then
            err.SetError(cmbtitle, "ብኽብረትኩም ማዕርግ ምረጹ!")
            Exit Sub
        Else
            err.SetError(cmbtitle, "")
            ' err.Clear()
        End If
        If txtname.Text = "" Then
            err.SetError(txtname, "ብኽብረትኩም ስም ኣባል መዝግቡ!")
            Exit Sub
        Else
            err.SetError(txtname, "")
            'err.Clear()
        End If
        If txtmom.Text = "" Then
            err.SetError(txtmom, "ብኽብረትኩም ስም ኣደ ኣባል መዝግቡ!")
            Exit Sub
        Else
            err.SetError(txtmom, "")
            'err.Clear()
        End If
        If dpbd.Value.ToString = "" Then
            err.SetError(dpbd, "ብኽብረትኩም ዕለት ልደት ኣባል መዝግቡ!")
            Exit Sub
        Else
            err.SetError(dpbd, "")
            'err.Clear()
        End If
        If txtbp.Text = "" Then
            err.SetError(txtbp, "ብኽብረትኩም ቦታ ልደት ኣባል መዝግቡ!")
            Exit Sub
        Else
            err.SetError(txtbp, "")
            'err.Clear()
        End If
        If dpsc.Value.ToString = "" Then
            err.SetError(dpsc, "ብኽብረትኩም ኣብዚ ቤተ ክርስቲያን ዝጀመርኩምሉ ዕለት መዝግቡ!")
            Exit Sub
        Else
            err.SetError(dpsc, "")
            'err.Clear()
        End If
        If rdf.Checked = False And rdm.Checked = False Then
            err.SetError(rdf, "ብኽብረትኩም ጾታ ኣባል መዝግቡ!")
            Exit Sub
        Else
            err.SetError(rdf, "")
            'err.Clear()
        End If
        If txtaddress.Text = "" Then
            err.SetError(txtaddress, "ብኽብረትኩም ከባቢ ገዛውቲ ኣባል መዝግቡ!")
            Exit Sub
        Else
            err.SetError(txtaddress, "")
            ' err.Clear()
        End If
        If pic.ImageLocation = Nothing Then
            err.SetError(pic, "ብኽብረትኩም ሥዕሊ ኣባል ምረጹ!")
            Exit Sub
        Else
            err.SetError(pic, "")
        End If
        If Not txtemail.Text = "" Then
            If Not (txtemail.Text.Contains("@") = True And txtemail.Text.Contains(".") = True And txtemail.Text.IndexOf(".") > txtemail.Text.IndexOf("@")) Then
                err.SetError(txtemail, "ብኽብረትኩም ቅኑዕ ኢመይል ኣእትዉ!")
                Exit Sub
            Else
                err.SetError(txtemail, "")
            End If

        Else
            err.SetError(txtemail, "")
        End If
        If chkno.Checked = False Then
            If dpasc.Value.ToString = "" Then
                err.SetError(dpasc, "ብኽብረትኩም ዕለት ኣእትዉ!")
                Exit Sub
            Else
                err.SetError(dpasc, "")
            End If
        End If
        'validation done
        Me.Hide()
        frmregister2.MdiParent = frmmain
        frmregister2.Show()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub

    Private Sub btnbrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbrowse.Click
        ofd1.Filter = "(Image files)|*.jpeg;*.jpg;*.png;*.bmp;*.gif"
        ofd1.ShowDialog()

    End Sub

    Private Sub ofd1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ofd1.FileOk
        If Not ofd1.FileName = "" Then
            pic.ImageLocation = ofd1.FileName
            pic.Image = Image.FromFile(ofd1.FileName)
        End If
    End Sub

    Private Sub pic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pic.Click

    End Sub

    Private Sub txttel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttel.KeyPress
        If Not (e.KeyChar = "0" Or e.KeyChar = "1" Or e.KeyChar = "2" Or e.KeyChar = "3" Or e.KeyChar = "4" Or e.KeyChar = "5" Or e.KeyChar = "6" Or e.KeyChar = "7" Or e.KeyChar = "8" Or e.KeyChar = "9") Then
            e.Handled = True
        End If
    End Sub

   

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkno.CheckedChanged
        If chkno.Checked = True Then
            dpasc.Enabled = False
        Else
            dpasc.Enabled = True
        End If
    End Sub

    

    Private Sub frmregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(2, 120)
        Dim conobject As New connection()
        Dim sqlstring As String
        sqlstring = "select * from tbltitle"
        If conobject.connect(sqlstring) = 1 Then
            MsgBox("connected")
            Dim rdr As SqlClient.SqlDataReader
            rdr = conobject.cmd.ExecuteReader()
            While rdr.Read
                'rdr.Read()
                If rdr.Item(1).ToString <> vbNullString Then
                    cmbtitle.Items.Add(rdr.Item(0).ToString & ":" & rdr.Item(1).ToString)
                    ' MsgBox(rdr.Item(1).ToString)
                End If
            End While
        Else
            MsgBox("unable to connect")
        End If
    End Sub

End Class

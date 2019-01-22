Public Class frmregister5

    Dim chkschool, chklevel, chkyear As Integer
    Private Sub DataGridView1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEndEdit
        Dim obj As New validation
        
       
        If e.ColumnIndex = 1 Then
            'If Not (dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("-") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("0") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("1") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("2") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("3") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("4") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("5") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("6") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("7") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("8") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("9")) Then
            ' If obj.notnull(dgv1.Rows(e.RowIndex).Cells(1).Value.ToString) <> 0 Then
            If obj.onlynumbers(dgv1.Rows(e.RowIndex).Cells(1).Value.ToString) = 0 Then
                dgv1.Rows(e.RowIndex).Cells(1).Value = ""
                MsgBox("ብኽብረትኩም ቅኑዕ ዓመተ ምሕረት መዝግቡ!")
                chkyear = 1
                Exit Sub
            Else
                chkyear = 0
            End If
            'Else
            ' MsgBox("this is null")
            'End If
        ElseIf e.ColumnIndex = 2 Then

        If obj.notnull(dgv1.Rows(e.RowIndex).Cells(2).Value.ToString) = 0 Then
            MsgBox("ብኽብረትኩም ቅኑዕ ደረጃ ትምህርቲ ምረጹ!")
            chklevel = 1
        Else
            chklevel = 0
        End If

        ElseIf e.ColumnIndex = 3 Then
        'If dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("0") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("1") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("2") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("3") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("4") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("5") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("6") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("7") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("8") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("9") Then

            If obj.onlyalphabets(dgv1.Rows(e.RowIndex).Cells(3).Value.ToString) = 0 Then
                dgv1.Rows(e.RowIndex).Cells(3).Value = ""
                MsgBox("ብኽብረትኩም ቅኑዕ ቤት ትምህርቲ መዝግቡ!")
                chkschool = 1
                Exit Sub
            Else
                chkschool = 0
            End If
        Else
        End If
    End Sub


    Private Sub dgv1_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgv1.UserAddedRow
        If dgv1.RowCount > 1 Then
            dgv1.Rows(e.Row.Index).Cells(0).Value = dgv1.Rows(e.Row.Index - 1).Cells(0).Value + 1
        End If
    End Sub

    Private Sub frmregister5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dd.Rows.Add("", "", "")
        'dd.ReadOnly = False

        dgv1.Rows.Add("", "", "", "")
        dgv1.Rows(0).Cells(0).Value = 1
        chklevel = 1
        chkschool = 1
        chkyear = 1
        Dim conobject As New connection()
        Dim sqlstring As String
        sqlstring = "select * from tblschoollevel"
        If conobject.connect(sqlstring) = 1 Then
            MsgBox("connected")
            Dim rdr As SqlClient.SqlDataReader
            rdr = conobject.cmd.ExecuteReader()
            While rdr.Read
                'rdr.Read()
                If rdr.Item(1).ToString <> vbNullString Then
                    cmblevel.Items.Add(rdr.Item(0).ToString & ": " & rdr.Item(1).ToString)
                    ' MsgBox(rdr.Item(1).ToString)
                End If
            End While
        Else
            MsgBox("unable to connect")
        End If
        'Dim conobject As New connection()
        'Dim sqlstring As String


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frmregister6.MdiParent = frmmain
        frmregister6.Show()
        If frmregister6.Visible = False Then
            frmregister6.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        frmregister4.MdiParent = frmmain
        frmregister4.Show()
        If frmregister4.Visible = False Then
            frmregister4.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        'dont forget tooooo
    End Sub

       Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

        If chklevel = 1 Or chkschool = 1 Or chkyear = 1 Then
            MsgBox("i am not going to add")
        ElseIf dgv1.Rows.Count = 0 Then
            dgv1.Rows.Add("", "", "", "")
            dgv1.Rows(0).Cells(0).Value = 1
        Else
            MsgBox("add one for him")
            dgv1.Rows.Add("", "", "", "")
            If dgv1.RowCount > 1 Then
                dgv1.Rows(dgv1.Rows.Count - 1).Cells(0).Value = dgv1.Rows(dgv1.Rows.Count - 2).Cells(0).Value + 1
            End If
        End If
    End Sub
End Class
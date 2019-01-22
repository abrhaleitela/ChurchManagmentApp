Public Class frmregister3
    Dim chkcourse, chkcourseteacher, chkyear, chkplace As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        frmregister4.MdiParent = frmmain
        Me.Hide()
        frmregister4.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        frmregister2.MdiParent = frmmain
        frmregister2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        'but u hv to close all the open apllications

    End Sub

    Private Sub dgv1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEndEdit
        Dim obj As New validation
        chkyear = chkcourseteacher = chkcourse = chkplace = 1
        If e.ColumnIndex = 1 Then
            Try
                If obj.notnull(dgv1.Rows(e.RowIndex).Cells(1).Value.ToString) = 0 Then
                    chkcourse = 1
                    MsgBox("ብኽብረትኩም ቅኑዕ ሥልጠና ምረጹ!")
                Else
                    chkcourse = 0
                End If
            Catch ex As Exception
                chkcourse = 1
            End Try
           

        ElseIf e.ColumnIndex = 2 Then
            ' If dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("0") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("1") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("2") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("3") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("4") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("5") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("6") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("7") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("8") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("9") Then
            Try
                If obj.onlyalphabets(dgv1.Rows(e.RowIndex).Cells(2).Value.ToString) = 0 Then
                    dgv1.Rows(e.RowIndex).Cells(2).Value = ""
                    MsgBox("ብኽብረትኩም ቅኑዕ ወሃቢ ሥልጠና መዝግቡ!")
                    chkcourseteacher = 1
                    Exit Sub
                Else
                    chkcourseteacher = 0
                End If
            Catch ex As Exception
                dgv1.Rows(e.RowIndex).Cells(2).Value = ""
                MsgBox("ብኽብረትኩም ቅኑዕ ወሃቢ ሥልጠና መዝግቡ!")
                chkcourseteacher = 1
                Exit Sub
            End Try

            ' End If
        ElseIf e.ColumnIndex = 3 Then
            'If Not (dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("0") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("1") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("2") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("3") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("4") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("5") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("6") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("7") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("8") Or dgv1.Rows(e.RowIndex).Cells(3).Value.ToString.Contains("9")) Then
            Try
                If obj.onlynumbers(dgv1.Rows(e.RowIndex).Cells(3).Value.ToString) = 0 Then
                    dgv1.Rows(e.RowIndex).Cells(3).Value = ""
                    MsgBox("ብኽብረትኩም ቅኑዕ ዓመተ ምሕረት መዝግቡ!")
                    chkyear = 1
                    Exit Sub
                Else
                    chkyear = 0
                End If
            Catch ex As Exception
                dgv1.Rows(e.RowIndex).Cells(3).Value = ""
                MsgBox("ብኽብረትኩም ቅኑዕ ዓመተ ምሕረት መዝግቡ!")
                chkyear = 1
                Exit Sub
            End Try

        ElseIf e.ColumnIndex = 4 Then
            'If dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("0") Or dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("1") Or dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("2") Or dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("3") Or dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("4") Or dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("5") Or dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("6") Or dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("7") Or dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("8") Or dgv1.Rows(e.RowIndex).Cells(4).Value.ToString.Contains("9") Then
            Try
                If obj.onlyalphabets(dgv1.Rows(e.RowIndex).Cells(4).Value.ToString) = 0 Then
                    dgv1.Rows(e.RowIndex).Cells(4).Value = ""
                    MsgBox("ብኽብረትኩም ቅኑዕ ቦታ ሥልጠና መዝግቡ!")
                    chkplace = 1
                    Exit Sub
                Else
                    chkplace = 0
                End If
            Catch ex As Exception
                dgv1.Rows(e.RowIndex).Cells(4).Value = ""
                MsgBox("ብኽብረትኩም ቅኑዕ ቦታ ሥልጠና መዝግቡ!")
                chkplace = 1
                Exit Sub
            End Try

        End If

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        'if add before start editing

        If chkyear = 1 Or chkplace = 1 Or chkcourse = 1 Or chkcourseteacher = 1 Then
            MsgBox("i am not going to add")
        ElseIf dgv1.Rows.Count = 0 Then
            dgv1.Rows.Add()
            dgv1.Rows(0).Cells(0).Value = 1
        Else
            Try
                If dgv1.Rows(dgv1.Rows.Count - 1).Cells(1).Value.ToString = "" Or dgv1.Rows(dgv1.Rows.Count - 1).Cells(4).Value.ToString = "" Or dgv1.Rows(dgv1.Rows.Count - 1).Cells(2).Value.ToString = "" Or dgv1.Rows(dgv1.Rows.Count - 1).Cells(3).Value.ToString = "" Then
                    MsgBox("i am not going to add")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("i am not going to add")
                Exit Sub
            End Try

            MsgBox("add one for him")
            dgv1.Rows.Add()
            If dgv1.RowCount > 1 Then
                dgv1.Rows(dgv1.Rows.Count - 1).Cells(0).Value = dgv1.Rows(dgv1.Rows.Count - 2).Cells(0).Value + 1
            End If
        End If
    End Sub
    'Private Sub DataGridView1_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgv1.UserAddedRow
    '    If dgv1.RowCount > 1 Then
    '        dgv1.Rows(e.Row.Index).Cells(0).Value = dgv1.Rows(e.Row.Index - 1).Cells(0).Value + 1
    '    End If

    'End Sub

    Private Sub frmregister3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv1.Rows.Add()
        dgv1.Rows(0).Cells(0).Value = 1
        Dim conobject As New connection()
        Dim sqlstring As String
        sqlstring = "select * from tblcourse"
        If conobject.connect(sqlstring) = 1 Then
            MsgBox("connected")
            Dim rdr As SqlClient.SqlDataReader
            rdr = conobject.cmd.ExecuteReader()
            While rdr.Read
                'rdr.Read()
                If rdr.Item(1).ToString <> vbNullString Then
                    cmbcourses.Items.Add(rdr.Item(0).ToString & ":  " & rdr.Item(1).ToString)
                    ' MsgBox(rdr.Item(1).ToString)
                End If
            End While
        Else
            MsgBox("unable to connect")
        End If
    End Sub

    Private Sub btndelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndelete.Click

        If dgv1.SelectedRows.Count <> 0 Then
            ' MsgBox("seleted are 1 or more" & dgv1.SelectedRows.Count)
            Dim i As Integer = 0
            Dim k As Integer
            k = dgv1.SelectedRows.Count
            While i < k
                dgv1.Rows.Remove(dgv1.SelectedRows(0))
                i = i + 1
            End While
            i = 1
            dgv1.Rows(0).Cells(0).Value = 1
            k = dgv1.Rows.Count
            While i < k
                dgv1.Rows(dgv1.Rows.Count - 1).Cells(0).Value = dgv1.Rows(dgv1.Rows.Count - 2).Cells(0).Value + 1
                i = i + 1
            End While
        Else
            MsgBox("no selected row")
        End If
    End Sub

  
End Class
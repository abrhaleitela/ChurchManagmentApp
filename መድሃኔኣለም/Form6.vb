Public Class frmregister6

    Private Sub dgv1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEndEdit
        If e.ColumnIndex = 1 Then
            If dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("0") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("1") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("2") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("3") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("4") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("5") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("6") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("7") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("8") Or dgv1.Rows(e.RowIndex).Cells(1).Value.ToString.Contains("9") Then
                dgv1.Rows(e.RowIndex).Cells(1).Value = ""
                MsgBox("ብኽብረትኩም ቅኑዕ ቦታ ሥራሕ ኣባል መዝግቡ!")
                Exit Sub
            End If
        ElseIf e.ColumnIndex = 2 Then
            If dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("0") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("1") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("2") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("3") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("4") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("5") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("6") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("7") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("8") Or dgv1.Rows(e.RowIndex).Cells(2).Value.ToString.Contains("9") Then
                dgv1.Rows(e.RowIndex).Cells(2).Value = ""
                MsgBox("ብኽብረትኩም ቅኑዕ ሞያ ኣባል መዝግቡ!")
                Exit Sub
            End If
        Else

        End If
    End Sub



    Private Sub DataGridView1_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgv1.UserAddedRow
        If dgv1.RowCount > 1 Then
            dgv1.Rows(e.Row.Index).Cells(0).Value = dgv1.Rows(e.Row.Index - 1).Cells(0).Value + 1
        End If
    End Sub

    Private Sub frmregister6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgv1.Rows(0).Cells(0).Value = 1
        btnsave.Enabled = False
    End Sub

    Private Sub dgv1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdi.CheckedChanged
        If rdi.Checked = False Then
            btnsave.Enabled = False
        Else
            btnsave.Enabled = True
        End If
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        Me.Hide()
        frmregister5.MdiParent = frmmain
        frmregister5.Show()
        If frmregister5.Visible = False Then
            frmregister5.Visible = True
        End If
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
        'u know 
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregister4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtsundaychurch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbdept = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.cmbleadership = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(475, 522)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 104
        Me.Button3.Text = "ተመለስ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(349, 522)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 103
        Me.Button2.Text = "ቀጽል"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(608, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "ኣቋርጽ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.txtsundaychurch, Me.cmbdept, Me.cmbleadership})
        Me.dgv1.Location = New System.Drawing.Point(12, 161)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(928, 283)
        Me.dgv1.TabIndex = 101
        '
        'Column1
        '
        Me.Column1.HeaderText = "ተ.ቑ."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'txtsundaychurch
        '
        Me.txtsundaychurch.HeaderText = "ቤት ትምህርቲ ሰንበት ወይ ቤተ ክርስቲያን"
        Me.txtsundaychurch.Name = "txtsundaychurch"
        Me.txtsundaychurch.Width = 355
        '
        'cmbdept
        '
        Me.cmbdept.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbdept.HeaderText = "ክፍሊ/ኣግልግሎት "
        Me.cmbdept.Name = "cmbdept"
        Me.cmbdept.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmbdept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmbdept.Width = 280
        '
        'cmbleadership
        '
        Me.cmbleadership.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbleadership.HeaderText = "ኃላፍነት "
        Me.cmbleadership.Name = "cmbleadership"
        Me.cmbleadership.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmbleadership.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmbleadership.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(192, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1098, 74)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "ሓበሬታ መንፈሳዊ ኣገልግሎት(sunday church)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(946, 253)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 105
        Me.btnadd.Text = "Add Row"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(946, 298)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 106
        Me.btndelete.Text = "Delete Row"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'frmregister4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 585)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmregister4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form4"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtsundaychurch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbdept As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents cmbleadership As System.Windows.Forms.DataGridViewComboBoxColumn
End Class

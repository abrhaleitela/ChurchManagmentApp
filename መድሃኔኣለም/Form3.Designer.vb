<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregister3
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbcourses = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(987, 74)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "ሓበሬታ መንፈሳዊ ትምህርቲ ወይ ሥልጠናታት"
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.cmbcourses, Me.Column3, Me.Column4, Me.Column5})
        Me.dgv1.Location = New System.Drawing.Point(-2, 151)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(1027, 283)
        Me.dgv1.TabIndex = 68
        '
        'Column1
        '
        Me.Column1.HeaderText = "ተ.ቑ."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'cmbcourses
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcourses.DefaultCellStyle = DataGridViewCellStyle4
        Me.cmbcourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbcourses.HeaderText = "ሥልጠና"
        Me.cmbcourses.Name = "cmbcourses"
        Me.cmbcourses.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmbcourses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmbcourses.Width = 270
        '
        'Column3
        '
        Me.Column3.HeaderText = "ወሃቢ ሥልጠና"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 280
        '
        'Column4
        '
        Me.Column4.HeaderText = "ዓመተ ምሕረት"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 130
        '
        'Column5
        '
        Me.Column5.HeaderText = "ቦታ ሥልጠና"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 250
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(332, 550)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 97
        Me.Button2.Text = "ቀጽል"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(591, 550)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 96
        Me.Button1.Text = "ኣቋርጽ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(458, 550)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 98
        Me.Button3.Text = "ተመለስ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(499, 466)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(83, 22)
        Me.btndelete.TabIndex = 108
        Me.btndelete.Text = "Delete Row"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(405, 466)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(83, 22)
        Me.btnadd.TabIndex = 107
        Me.btnadd.Text = "Add Row"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'frmregister3
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
        Me.Name = "frmregister3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form3"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbcourses As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
End Class

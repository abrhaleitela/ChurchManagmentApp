<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregister5
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmblevel = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnremove = New System.Windows.Forms.Button()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(422, 503)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 110
        Me.Button3.Text = "ተመለስ"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(296, 503)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "ቀጽል"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(555, 503)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "ኣቋርጽ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.cmblevel, Me.Column4})
        Me.dgv1.Location = New System.Drawing.Point(12, 160)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(903, 283)
        Me.dgv1.TabIndex = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 74)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "ኣካዳምያዊ ሓበሬታ"
        '
        'Column1
        '
        Me.Column1.HeaderText = "ተ.ቑ."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 30
        '
        'Column2
        '
        Me.Column2.HeaderText = "ዓመተ ምሕረት"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 250
        '
        'cmblevel
        '
        Me.cmblevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmblevel.HeaderText = "ደረጃ"
        Me.cmblevel.Name = "cmblevel"
        Me.cmblevel.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.cmblevel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.cmblevel.Width = 280
        '
        'Column4
        '
        Me.Column4.HeaderText = "ቦታ ትምህርቲ"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 300
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(938, 239)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 27)
        Me.btnadd.TabIndex = 112
        Me.btnadd.Text = "Add Row"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnremove
        '
        Me.btnremove.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremove.Location = New System.Drawing.Point(938, 293)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(75, 27)
        Me.btnremove.TabIndex = 111
        Me.btnremove.Text = "Remove"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'frmregister5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 585)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmregister5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form5"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmblevel As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnremove As System.Windows.Forms.Button
End Class

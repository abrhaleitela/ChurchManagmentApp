<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregister6
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
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdi = New System.Windows.Forms.CheckBox()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(445, 540)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 110
        Me.btnback.Text = "ተመለስ"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(318, 540)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 109
        Me.btnsave.Text = "ዓቅብ"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Font = New System.Drawing.Font("Californian FB", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(575, 540)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 108
        Me.btncancel.Text = "ኣቋርጽ"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgv1.Location = New System.Drawing.Point(140, 169)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(763, 283)
        Me.dgv1.TabIndex = 107
        '
        'Column1
        '
        Me.Column1.HeaderText = "ተ.ቑ."
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "ቦታ ሥራሕ"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 340
        '
        'Column3
        '
        Me.Column3.HeaderText = "ሞያ"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 330
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(349, 74)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "ሓበሬታ ሥራሕ"
        '
        'rdi
        '
        Me.rdi.AutoSize = True
        Me.rdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdi.Location = New System.Drawing.Point(371, 487)
        Me.rdi.Name = "rdi"
        Me.rdi.Size = New System.Drawing.Size(264, 20)
        Me.rdi.TabIndex = 111
        Me.rdi.Text = "እዚ ሂበዮ ዘለኹ ሓበሬታ ናተይን ቅኑዕን ምዃኑ አረጋግጽ።"
        Me.rdi.UseVisualStyleBackColor = True
        '
        'frmregister6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 585)
        Me.Controls.Add(Me.rdi)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmregister6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form6"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rdi As System.Windows.Forms.CheckBox
End Class

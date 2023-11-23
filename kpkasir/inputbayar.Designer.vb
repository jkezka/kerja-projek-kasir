<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inputbayar
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.bayar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Footlight MT Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(151, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(303, 25)
        Me.Label15.TabIndex = 177
        Me.Label15.Text = "Masukkan uang yang dibayar"
        '
        'bayar
        '
        Me.bayar.BackColor = System.Drawing.Color.AntiqueWhite
        Me.bayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bayar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.bayar.Font = New System.Drawing.Font("Footlight MT Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.bayar.Location = New System.Drawing.Point(127, 86)
        Me.bayar.Multiline = True
        Me.bayar.Name = "bayar"
        Me.bayar.ReadOnly = True
        Me.bayar.Size = New System.Drawing.Size(348, 37)
        Me.bayar.TabIndex = 176
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Footlight MT Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Button1.Location = New System.Drawing.Point(373, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 37)
        Me.Button1.TabIndex = 178
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'inputbayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(604, 216)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.bayar)
        Me.Name = "inputbayar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "inputbayar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As Label
    Friend WithEvents bayar As TextBox
    Friend WithEvents Button1 As Button
End Class

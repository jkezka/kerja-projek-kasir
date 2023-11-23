<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cart
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cart))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.subtotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.kembalian = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.bayar = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgv.Location = New System.Drawing.Point(34, 104)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersWidth = 62
        Me.dgv.RowTemplate.Height = 28
        Me.dgv.Size = New System.Drawing.Size(671, 568)
        Me.dgv.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Footlight MT Light", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(753, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Keranjang"
        '
        'nama
        '
        Me.nama.BackColor = System.Drawing.Color.AntiqueWhite
        Me.nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nama.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.nama.Font = New System.Drawing.Font("Footlight MT Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.nama.Location = New System.Drawing.Point(935, 144)
        Me.nama.Multiline = True
        Me.nama.Name = "nama"
        Me.nama.ReadOnly = True
        Me.nama.Size = New System.Drawing.Size(236, 37)
        Me.nama.TabIndex = 2
        '
        'harga
        '
        Me.harga.BackColor = System.Drawing.Color.AntiqueWhite
        Me.harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.harga.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.harga.Font = New System.Drawing.Font("Footlight MT Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.harga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.harga.Location = New System.Drawing.Point(935, 202)
        Me.harga.Multiline = True
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        Me.harga.Size = New System.Drawing.Size(236, 37)
        Me.harga.TabIndex = 3
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.Color.AntiqueWhite
        Me.jumlah.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.jumlah.Font = New System.Drawing.Font("Footlight MT Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.jumlah.Location = New System.Drawing.Point(935, 261)
        Me.jumlah.Multiline = True
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(236, 31)
        Me.jumlah.TabIndex = 4
        '
        'total
        '
        Me.total.BackColor = System.Drawing.Color.AntiqueWhite
        Me.total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.total.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.total.Font = New System.Drawing.Font("Footlight MT Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.total.Location = New System.Drawing.Point(935, 374)
        Me.total.Multiline = True
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Size = New System.Drawing.Size(236, 37)
        Me.total.TabIndex = 7
        '
        'subtotal
        '
        Me.subtotal.BackColor = System.Drawing.Color.AntiqueWhite
        Me.subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subtotal.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.subtotal.Font = New System.Drawing.Font("Footlight MT Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.subtotal.Location = New System.Drawing.Point(935, 322)
        Me.subtotal.Multiline = True
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        Me.subtotal.Size = New System.Drawing.Size(236, 37)
        Me.subtotal.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Footlight MT Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(782, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Footlight MT Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(782, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Footlight MT Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(782, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Footlight MT Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(782, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Sub Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Footlight MT Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(784, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 25)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(897, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(897, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(897, 259)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(897, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = ":"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(34, 31)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(50, 50)
        Me.Button9.TabIndex = 166
        Me.Button9.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnedit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PeachPuff
        Me.btnedit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Footlight MT Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(786, 627)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(165, 46)
        Me.btnedit.TabIndex = 167
        Me.btnedit.Text = "Ubah"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhapus.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("Footlight MT Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhapus.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.btnhapus.Location = New System.Drawing.Point(1006, 627)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(165, 46)
        Me.btnhapus.TabIndex = 168
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(753, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(450, 20)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "_________________________________________________"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(753, 584)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(450, 20)
        Me.Label12.TabIndex = 170
        Me.Label12.Text = "_________________________________________________"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Footlight MT Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1137, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 40)
        Me.Button1.TabIndex = 171
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(900, 380)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 20)
        Me.Label13.TabIndex = 172
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(946, 515)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 20)
        Me.Label14.TabIndex = 175
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Footlight MT Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(781, 513)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 25)
        Me.Label15.TabIndex = 174
        Me.Label15.Text = "Uang Kembali"
        '
        'kembalian
        '
        Me.kembalian.BackColor = System.Drawing.Color.AntiqueWhite
        Me.kembalian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kembalian.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.kembalian.Enabled = False
        Me.kembalian.Font = New System.Drawing.Font("Footlight MT Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kembalian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.kembalian.Location = New System.Drawing.Point(784, 546)
        Me.kembalian.Multiline = True
        Me.kembalian.Name = "kembalian"
        Me.kembalian.Size = New System.Drawing.Size(236, 37)
        Me.kembalian.TabIndex = 173
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Footlight MT Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(784, 436)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(197, 25)
        Me.Label17.TabIndex = 178
        Me.Label17.Text = "Input Uang Bayar :"
        '
        'bayar
        '
        Me.bayar.BackColor = System.Drawing.Color.AntiqueWhite
        Me.bayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bayar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.bayar.Font = New System.Drawing.Font("Footlight MT Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bayar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.bayar.Location = New System.Drawing.Point(784, 464)
        Me.bayar.Multiline = True
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(236, 37)
        Me.bayar.TabIndex = 177
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1146, 269)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 16)
        Me.PictureBox1.TabIndex = 179
        Me.PictureBox1.TabStop = False
        '
        'cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(1234, 714)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.bayar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.kembalian)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.subtotal)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Name = "cart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cart"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents nama As TextBox
    Friend WithEvents harga As TextBox
    Friend WithEvents jumlah As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents subtotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents kembalian As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents bayar As TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
End Class

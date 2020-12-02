<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.Load_BMP = New System.Windows.Forms.Button()
        Me.pic0 = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.pic2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pic3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.pic4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pic5 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.pic6 = New System.Windows.Forms.PictureBox()
        Me.pic7 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.i1 = New System.Windows.Forms.Label()
        Me.i3 = New System.Windows.Forms.Label()
        Me.i5 = New System.Windows.Forms.Label()
        Me.i2 = New System.Windows.Forms.Label()
        Me.i4 = New System.Windows.Forms.Label()
        Me.i6 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.pic0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Load_BMP
        '
        Me.Load_BMP.Location = New System.Drawing.Point(12, 17)
        Me.Load_BMP.Name = "Load_BMP"
        Me.Load_BMP.Size = New System.Drawing.Size(209, 33)
        Me.Load_BMP.TabIndex = 0
        Me.Load_BMP.Text = "Load BMP Image"
        Me.Load_BMP.UseVisualStyleBackColor = True
        '
        'pic0
        '
        Me.pic0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic0.Location = New System.Drawing.Point(259, 29)
        Me.pic0.Name = "pic0"
        Me.pic0.Size = New System.Drawing.Size(166, 145)
        Me.pic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic0.TabIndex = 1
        Me.pic0.TabStop = False
        '
        'pic1
        '
        Me.pic1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic1.Location = New System.Drawing.Point(259, 268)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(166, 127)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 2
        Me.pic1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(256, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Original BMP Image"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Gray Image"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 174)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 26)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Standard DCT using One Dim 8 x 8"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 361)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Exit Application"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 56)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(209, 29)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "BMP to Single Gray"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'pic2
        '
        Me.pic2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic2.Location = New System.Drawing.Point(625, 29)
        Me.pic2.Name = "pic2"
        Me.pic2.Size = New System.Drawing.Size(175, 145)
        Me.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic2.TabIndex = 10
        Me.pic2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(622, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "DCT one dim 8 x 8 Results"
        '
        'pic3
        '
        Me.pic3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic3.Location = New System.Drawing.Point(625, 269)
        Me.pic3.Name = "pic3"
        Me.pic3.Size = New System.Drawing.Size(175, 126)
        Me.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic3.TabIndex = 12
        Me.pic3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(622, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Inverse DCT one dim 8 x 8 Image"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 212)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(209, 26)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Standard IDCT using One Dim 8 x 8"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'pic4
        '
        Me.pic4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic4.Location = New System.Drawing.Point(822, 29)
        Me.pic4.Name = "pic4"
        Me.pic4.Size = New System.Drawing.Size(175, 145)
        Me.pic4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic4.TabIndex = 16
        Me.pic4.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(819, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "FDCT Results"
        '
        'pic5
        '
        Me.pic5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic5.Location = New System.Drawing.Point(822, 269)
        Me.pic5.Name = "pic5"
        Me.pic5.Size = New System.Drawing.Size(175, 126)
        Me.pic5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic5.TabIndex = 18
        Me.pic5.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(819, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Inverse FDCT Image"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 253)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(209, 26)
        Me.Button6.TabIndex = 20
        Me.Button6.Text = "Fast DCT 8 x 8"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 285)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(209, 31)
        Me.Button7.TabIndex = 21
        Me.Button7.Text = "Inverse Fast DCT 8 x 8"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'pic6
        '
        Me.pic6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic6.Location = New System.Drawing.Point(441, 29)
        Me.pic6.Name = "pic6"
        Me.pic6.Size = New System.Drawing.Size(166, 145)
        Me.pic6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic6.TabIndex = 22
        Me.pic6.TabStop = False
        '
        'pic7
        '
        Me.pic7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pic7.Location = New System.Drawing.Point(441, 269)
        Me.pic7.Name = "pic7"
        Me.pic7.Size = New System.Drawing.Size(166, 126)
        Me.pic7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic7.TabIndex = 23
        Me.pic7.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(438, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "DCT Two dim 8 x 8 Results"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(438, 252)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Inverse DCT Two dim 8 x 8 Image"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 29)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Standard DCT using Two Dim 8 x 8"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(12, 137)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(209, 25)
        Me.Button8.TabIndex = 27
        Me.Button8.Text = "Standard IDCT using Two Dim 8 x 8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(12, 322)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(209, 33)
        Me.Button9.TabIndex = 28
        Me.Button9.Text = "Do All"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'i1
        '
        Me.i1.AutoSize = True
        Me.i1.Location = New System.Drawing.Point(445, 186)
        Me.i1.Name = "i1"
        Me.i1.Size = New System.Drawing.Size(0, 13)
        Me.i1.TabIndex = 29
        '
        'i3
        '
        Me.i3.AutoSize = True
        Me.i3.Location = New System.Drawing.Point(622, 186)
        Me.i3.Name = "i3"
        Me.i3.Size = New System.Drawing.Size(0, 13)
        Me.i3.TabIndex = 30
        '
        'i5
        '
        Me.i5.AutoSize = True
        Me.i5.Location = New System.Drawing.Point(819, 187)
        Me.i5.Name = "i5"
        Me.i5.Size = New System.Drawing.Size(0, 13)
        Me.i5.TabIndex = 31
        '
        'i2
        '
        Me.i2.AutoSize = True
        Me.i2.Location = New System.Drawing.Point(438, 398)
        Me.i2.Name = "i2"
        Me.i2.Size = New System.Drawing.Size(0, 13)
        Me.i2.TabIndex = 32
        '
        'i4
        '
        Me.i4.AutoSize = True
        Me.i4.Location = New System.Drawing.Point(622, 398)
        Me.i4.Name = "i4"
        Me.i4.Size = New System.Drawing.Size(0, 13)
        Me.i4.TabIndex = 33
        '
        'i6
        '
        Me.i6.AutoSize = True
        Me.i6.Location = New System.Drawing.Point(819, 398)
        Me.i6.Name = "i6"
        Me.i6.Size = New System.Drawing.Size(0, 13)
        Me.i6.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(254, 479)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(624, 25)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "PS: You can save any resultant image by clicking its PictureBox"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 554)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.i6)
        Me.Controls.Add(Me.i4)
        Me.Controls.Add(Me.i2)
        Me.Controls.Add(Me.i5)
        Me.Controls.Add(Me.i3)
        Me.Controls.Add(Me.i1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.pic7)
        Me.Controls.Add(Me.pic6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pic5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pic4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pic3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pic2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.pic0)
        Me.Controls.Add(Me.Load_BMP)
        Me.Name = "main"
        Me.Text = "DCT and Fast DCT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pic0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Load_BMP As System.Windows.Forms.Button
    Friend WithEvents pic0 As System.Windows.Forms.PictureBox
    Friend WithEvents pic1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents pic2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pic3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents pic4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pic5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents pic6 As System.Windows.Forms.PictureBox
    Friend WithEvents pic7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents i1 As System.Windows.Forms.Label
    Friend WithEvents i3 As System.Windows.Forms.Label
    Friend WithEvents i5 As System.Windows.Forms.Label
    Friend WithEvents i2 As System.Windows.Forms.Label
    Friend WithEvents i4 As System.Windows.Forms.Label
    Friend WithEvents i6 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class

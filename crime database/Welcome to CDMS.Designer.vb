<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.FIR = New System.Windows.Forms.Button
        Me.investigation = New System.Windows.Forms.Button
        Me.general_info = New System.Windows.Forms.Button
        Me.about_us = New System.Windows.Forms.Button
        Me.admin = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FIR
        '
        Me.FIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIR.Location = New System.Drawing.Point(43, 21)
        Me.FIR.Name = "FIR"
        Me.FIR.Size = New System.Drawing.Size(126, 53)
        Me.FIR.TabIndex = 0
        Me.FIR.Text = "FIR Login"
        Me.FIR.UseVisualStyleBackColor = True
        '
        'investigation
        '
        Me.investigation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.investigation.Location = New System.Drawing.Point(203, 21)
        Me.investigation.Name = "investigation"
        Me.investigation.Size = New System.Drawing.Size(126, 53)
        Me.investigation.TabIndex = 1
        Me.investigation.Text = "Investigation Officer"
        Me.investigation.UseVisualStyleBackColor = True
        '
        'general_info
        '
        Me.general_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.general_info.Location = New System.Drawing.Point(786, 22)
        Me.general_info.Name = "general_info"
        Me.general_info.Size = New System.Drawing.Size(126, 53)
        Me.general_info.TabIndex = 2
        Me.general_info.Text = "General Information"
        Me.general_info.UseVisualStyleBackColor = True
        '
        'about_us
        '
        Me.about_us.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about_us.Location = New System.Drawing.Point(576, 23)
        Me.about_us.Name = "about_us"
        Me.about_us.Size = New System.Drawing.Size(165, 52)
        Me.about_us.TabIndex = 3
        Me.about_us.Text = "About Us."
        Me.about_us.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.admin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admin.Location = New System.Drawing.Point(366, 22)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(165, 53)
        Me.admin.TabIndex = 4
        Me.admin.Text = "I am the Admin! "
        Me.admin.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(224, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(198, 97)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(949, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 53)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Jail Information"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 117)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1063, 461)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1181, 568)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.admin)
        Me.Controls.Add(Me.about_us)
        Me.Controls.Add(Me.general_info)
        Me.Controls.Add(Me.investigation)
        Me.Controls.Add(Me.FIR)
        Me.Name = "Form1"
        Me.Text = "welcome to crime database"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FIR As System.Windows.Forms.Button
    Friend WithEvents investigation As System.Windows.Forms.Button
    Friend WithEvents general_info As System.Windows.Forms.Button
    Friend WithEvents about_us As System.Windows.Forms.Button
    Friend WithEvents admin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class

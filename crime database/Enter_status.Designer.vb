<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enter_status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Enter_status))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.status = New System.Windows.Forms.RichTextBox
        Me.solved = New System.Windows.Forms.CheckBox
        Me.unsolved = New System.Windows.Forms.CheckBox
        Me.submit = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Status OF Investigation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(362, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Your Comments for the case"
        '
        'status
        '
        Me.status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.status.Location = New System.Drawing.Point(366, 63)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(432, 161)
        Me.status.TabIndex = 2
        Me.status.Text = ""
        '
        'solved
        '
        Me.solved.AutoSize = True
        Me.solved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.solved.Location = New System.Drawing.Point(56, 117)
        Me.solved.Name = "solved"
        Me.solved.Size = New System.Drawing.Size(82, 24)
        Me.solved.TabIndex = 3
        Me.solved.Text = "Solved"
        Me.solved.UseVisualStyleBackColor = True
        '
        'unsolved
        '
        Me.unsolved.AutoSize = True
        Me.unsolved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unsolved.Location = New System.Drawing.Point(56, 140)
        Me.unsolved.Name = "unsolved"
        Me.unsolved.Size = New System.Drawing.Size(93, 24)
        Me.unsolved.TabIndex = 5
        Me.unsolved.Text = "Pending"
        Me.unsolved.UseVisualStyleBackColor = True
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.Location = New System.Drawing.Point(384, 272)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(144, 38)
        Me.submit.TabIndex = 6
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(862, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Go Back To Home Page"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(913, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 101)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Enter_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.BackgroundImage = Global.crime_database.My.Resources.Resources.back
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1081, 330)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.unsolved)
        Me.Controls.Add(Me.solved)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Enter_status"
        Me.Text = "Enter_status"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.RichTextBox
    Friend WithEvents solved As System.Windows.Forms.CheckBox
    Friend WithEvents unsolved As System.Windows.Forms.CheckBox
    Friend WithEvents submit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

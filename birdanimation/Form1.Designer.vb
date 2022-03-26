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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.Pic1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 300
        '
        'Pic
        '
        Me.Pic.Image = Global.birdanimation.My.Resources.Resources.i1
        Me.Pic.Location = New System.Drawing.Point(270, 116)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(95, 98)
        Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Pic.TabIndex = 0
        Me.Pic.TabStop = False
        '
        'Pic1
        '
        Me.Pic1.Image = Global.birdanimation.My.Resources.Resources.i2
        Me.Pic1.Location = New System.Drawing.Point(455, 155)
        Me.Pic1.Name = "Pic1"
        Me.Pic1.Size = New System.Drawing.Size(90, 93)
        Me.Pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Pic1.TabIndex = 1
        Me.Pic1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 250
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Pic1)
        Me.Controls.Add(Me.Pic)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pic As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Pic1 As PictureBox
    Friend WithEvents Timer2 As Timer
End Class

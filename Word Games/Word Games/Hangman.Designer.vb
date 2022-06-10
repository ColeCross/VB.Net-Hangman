<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hangman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hangman))
        Me.NGBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WrdLbl = New System.Windows.Forms.Label()
        Me.UsedBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.GuessBox = New System.Windows.Forms.TextBox()
        Me.GuessBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LivesBox = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NGBtn
        '
        Me.NGBtn.Location = New System.Drawing.Point(44, 775)
        Me.NGBtn.Name = "NGBtn"
        Me.NGBtn.Size = New System.Drawing.Size(140, 50)
        Me.NGBtn.TabIndex = 0
        Me.NGBtn.Text = "New Game"
        Me.NGBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(354, 376)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'WrdLbl
        '
        Me.WrdLbl.AutoSize = True
        Me.WrdLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WrdLbl.Location = New System.Drawing.Point(5, 414)
        Me.WrdLbl.Name = "WrdLbl"
        Me.WrdLbl.Size = New System.Drawing.Size(365, 37)
        Me.WrdLbl.TabIndex = 2
        Me.WrdLbl.Text = "P L A C E H O L D E R"
        '
        'UsedBox
        '
        Me.UsedBox.FormattingEnabled = True
        Me.UsedBox.Location = New System.Drawing.Point(12, 486)
        Me.UsedBox.Name = "UsedBox"
        Me.UsedBox.Size = New System.Drawing.Size(125, 264)
        Me.UsedBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 470)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Used:"
        '
        'LogBox
        '
        Me.LogBox.FormattingEnabled = True
        Me.LogBox.Location = New System.Drawing.Point(159, 486)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.Size = New System.Drawing.Size(421, 264)
        Me.LogBox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Log:"
        '
        'MenuBtn
        '
        Me.MenuBtn.Location = New System.Drawing.Point(226, 775)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(140, 50)
        Me.MenuBtn.TabIndex = 7
        Me.MenuBtn.Text = "Menu"
        Me.MenuBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(407, 775)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(140, 50)
        Me.ExitBtn.TabIndex = 8
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'GuessBox
        '
        Me.GuessBox.Location = New System.Drawing.Point(383, 339)
        Me.GuessBox.Name = "GuessBox"
        Me.GuessBox.Size = New System.Drawing.Size(116, 20)
        Me.GuessBox.TabIndex = 9
        '
        'GuessBtn
        '
        Me.GuessBtn.Location = New System.Drawing.Point(383, 365)
        Me.GuessBtn.Name = "GuessBtn"
        Me.GuessBtn.Size = New System.Drawing.Size(116, 23)
        Me.GuessBtn.TabIndex = 10
        Me.GuessBtn.Text = "Guess"
        Me.GuessBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(380, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Guess:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(383, 12)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(197, 123)
        Me.TextBox2.TabIndex = 12
        Me.TextBox2.Text = resources.GetString("TextBox2.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(517, 371)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Lives:"
        '
        'LivesBox
        '
        Me.LivesBox.Location = New System.Drawing.Point(558, 368)
        Me.LivesBox.Name = "LivesBox"
        Me.LivesBox.ReadOnly = True
        Me.LivesBox.Size = New System.Drawing.Size(22, 20)
        Me.LivesBox.TabIndex = 14
        '
        'Hangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 837)
        Me.Controls.Add(Me.LivesBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GuessBtn)
        Me.Controls.Add(Me.GuessBox)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.MenuBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsedBox)
        Me.Controls.Add(Me.WrdLbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NGBtn)
        Me.Name = "Hangman"
        Me.Text = "Hangman"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NGBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WrdLbl As Label
    Friend WithEvents UsedBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LogBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents GuessBox As TextBox
    Friend WithEvents GuessBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LivesBox As TextBox
End Class

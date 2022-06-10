<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WordList
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
        Me.WrdLst = New System.Windows.Forms.ListBox()
        Me.AddBox = New System.Windows.Forms.TextBox()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.MenuBtn = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.WrningLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WrdLst
        '
        Me.WrdLst.FormattingEnabled = True
        Me.WrdLst.Location = New System.Drawing.Point(123, 12)
        Me.WrdLst.Name = "WrdLst"
        Me.WrdLst.Size = New System.Drawing.Size(228, 472)
        Me.WrdLst.TabIndex = 0
        '
        'AddBox
        '
        Me.AddBox.Location = New System.Drawing.Point(12, 190)
        Me.AddBox.Name = "AddBox"
        Me.AddBox.Size = New System.Drawing.Size(100, 20)
        Me.AddBox.TabIndex = 1
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(12, 216)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(100, 23)
        Me.AddBtn.TabIndex = 2
        Me.AddBtn.Text = "Add Word"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Location = New System.Drawing.Point(12, 273)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(100, 23)
        Me.DelBtn.TabIndex = 3
        Me.DelBtn.Text = "Delete Selected"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(12, 461)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(100, 23)
        Me.ExitBtn.TabIndex = 4
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'MenuBtn
        '
        Me.MenuBtn.Location = New System.Drawing.Point(12, 432)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(100, 23)
        Me.MenuBtn.TabIndex = 5
        Me.MenuBtn.Text = "Menu"
        Me.MenuBtn.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 12)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 116)
        Me.TextBox2.TabIndex = 6
        Me.TextBox2.Text = "This is the word list. Both Hangman and the Word Search can pick any word from th" &
    "is list. Here you can add or remove words from the list."
        '
        'WrningLbl
        '
        Me.WrningLbl.AutoSize = True
        Me.WrningLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WrningLbl.Location = New System.Drawing.Point(12, 161)
        Me.WrningLbl.Name = "WrningLbl"
        Me.WrningLbl.Size = New System.Drawing.Size(100, 26)
        Me.WrningLbl.TabIndex = 7
        Me.WrningLbl.Text = "This word is already" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " in the list!"
        Me.WrningLbl.Visible = False
        '
        'WordList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 496)
        Me.Controls.Add(Me.WrningLbl)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.MenuBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.DelBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.AddBox)
        Me.Controls.Add(Me.WrdLst)
        Me.Name = "WordList"
        Me.Text = "WordList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WrdLst As ListBox
    Friend WithEvents AddBox As TextBox
    Friend WithEvents AddBtn As Button
    Friend WithEvents DelBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents MenuBtn As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents WrningLbl As Label
End Class

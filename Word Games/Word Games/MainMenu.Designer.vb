<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.HngBtn = New System.Windows.Forms.Button()
        Me.HngBtn2P = New System.Windows.Forms.Button()
        Me.WrdLstBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HngBtn
        '
        Me.HngBtn.Location = New System.Drawing.Point(62, 62)
        Me.HngBtn.Name = "HngBtn"
        Me.HngBtn.Size = New System.Drawing.Size(152, 52)
        Me.HngBtn.TabIndex = 0
        Me.HngBtn.Text = "1-Player Hangman"
        Me.HngBtn.UseVisualStyleBackColor = True
        '
        'HngBtn2P
        '
        Me.HngBtn2P.Location = New System.Drawing.Point(62, 120)
        Me.HngBtn2P.Name = "HngBtn2P"
        Me.HngBtn2P.Size = New System.Drawing.Size(152, 52)
        Me.HngBtn2P.TabIndex = 1
        Me.HngBtn2P.Text = "2-Player Hangman"
        Me.HngBtn2P.UseVisualStyleBackColor = True
        '
        'WrdLstBtn
        '
        Me.WrdLstBtn.Location = New System.Drawing.Point(62, 178)
        Me.WrdLstBtn.Name = "WrdLstBtn"
        Me.WrdLstBtn.Size = New System.Drawing.Size(152, 52)
        Me.WrdLstBtn.TabIndex = 3
        Me.WrdLstBtn.Text = "Modify Word List"
        Me.WrdLstBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(62, 236)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(152, 52)
        Me.ExitBtn.TabIndex = 4
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Hangman"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 300)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.WrdLstBtn)
        Me.Controls.Add(Me.HngBtn2P)
        Me.Controls.Add(Me.HngBtn)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HngBtn As Button
    Friend WithEvents HngBtn2P As Button
    Friend WithEvents WrdLstBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents Label1 As Label
End Class

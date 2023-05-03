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
        Me.lblLetter = New System.Windows.Forms.Label()
        Me.txtLetter = New System.Windows.Forms.TextBox()
        Me.btnNewWord = New System.Windows.Forms.Button()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnTryLetter = New System.Windows.Forms.Button()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpWord = New System.Windows.Forms.GroupBox()
        Me.grpLetter = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpWord.SuspendLayout()
        Me.grpLetter.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLetter
        '
        Me.lblLetter.AutoSize = True
        Me.lblLetter.Location = New System.Drawing.Point(18, 29)
        Me.lblLetter.Name = "lblLetter"
        Me.lblLetter.Size = New System.Drawing.Size(43, 16)
        Me.lblLetter.TabIndex = 0
        Me.lblLetter.Text = "Letter:"
        '
        'txtLetter
        '
        Me.txtLetter.Location = New System.Drawing.Point(21, 59)
        Me.txtLetter.Name = "txtLetter"
        Me.txtLetter.Size = New System.Drawing.Size(46, 22)
        Me.txtLetter.TabIndex = 1
        '
        'btnNewWord
        '
        Me.btnNewWord.Location = New System.Drawing.Point(68, 22)
        Me.btnNewWord.Name = "btnNewWord"
        Me.btnNewWord.Size = New System.Drawing.Size(91, 23)
        Me.btnNewWord.TabIndex = 2
        Me.btnNewWord.Text = "New Word"
        Me.btnNewWord.UseVisualStyleBackColor = True
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(19, 25)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(43, 16)
        Me.lblWord.TabIndex = 3
        Me.lblWord.Text = "Word:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblResult.Location = New System.Drawing.Point(283, 46)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(97, 48)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "                              " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnTryLetter
        '
        Me.btnTryLetter.Location = New System.Drawing.Point(76, 26)
        Me.btnTryLetter.Name = "btnTryLetter"
        Me.btnTryLetter.Size = New System.Drawing.Size(91, 23)
        Me.btnTryLetter.TabIndex = 5
        Me.btnTryLetter.Text = "Try Letter"
        Me.btnTryLetter.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(21, 60)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(113, 22)
        Me.txtWord.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Result"
        '
        'grpWord
        '
        Me.grpWord.Controls.Add(Me.lblWord)
        Me.grpWord.Controls.Add(Me.btnNewWord)
        Me.grpWord.Controls.Add(Me.txtWord)
        Me.grpWord.Location = New System.Drawing.Point(41, 12)
        Me.grpWord.Name = "grpWord"
        Me.grpWord.Size = New System.Drawing.Size(200, 100)
        Me.grpWord.TabIndex = 8
        Me.grpWord.TabStop = False
        '
        'grpLetter
        '
        Me.grpLetter.Controls.Add(Me.lblLetter)
        Me.grpLetter.Controls.Add(Me.btnTryLetter)
        Me.grpLetter.Controls.Add(Me.txtLetter)
        Me.grpLetter.Location = New System.Drawing.Point(41, 133)
        Me.grpLetter.Name = "grpLetter"
        Me.grpLetter.Size = New System.Drawing.Size(200, 100)
        Me.grpLetter.TabIndex = 9
        Me.grpLetter.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 259)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpLetter)
        Me.Controls.Add(Me.grpWord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpWord.ResumeLayout(False)
        Me.grpWord.PerformLayout()
        Me.grpLetter.ResumeLayout(False)
        Me.grpLetter.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLetter As Label
    Friend WithEvents txtLetter As TextBox
    Friend WithEvents btnNewWord As Button
    Friend WithEvents lblWord As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnTryLetter As Button
    Friend WithEvents txtWord As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpWord As GroupBox
    Friend WithEvents grpLetter As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class

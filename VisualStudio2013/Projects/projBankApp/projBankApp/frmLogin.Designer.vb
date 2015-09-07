<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.lblLoginStep = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.mtbPassword = New System.Windows.Forms.MaskedTextBox()
        Me.pnlVerify = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblDig3 = New System.Windows.Forms.Label()
        Me.lblDig2 = New System.Windows.Forms.Label()
        Me.lblDig1 = New System.Windows.Forms.Label()
        Me.mtbDigit3 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbDigit2 = New System.Windows.Forms.MaskedTextBox()
        Me.mtbDigit1 = New System.Windows.Forms.MaskedTextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblLoginStep2 = New System.Windows.Forms.Label()
        Me.lblPAC = New System.Windows.Forms.Label()
        Me.lblError2 = New System.Windows.Forms.Label()
        Me.pnlVerify.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Location = New System.Drawing.Point(62, 91)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(87, 13)
        Me.lblRegNo.TabIndex = 0
        Me.lblRegNo.Text = "Account Number"
        '
        'lblLoginStep
        '
        Me.lblLoginStep.AutoSize = True
        Me.lblLoginStep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginStep.Location = New System.Drawing.Point(62, 51)
        Me.lblLoginStep.Name = "lblLoginStep"
        Me.lblLoginStep.Size = New System.Drawing.Size(143, 17)
        Me.lblLoginStep.TabIndex = 2
        Me.lblLoginStep.Text = "Log in: Step 1 of 2"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(65, 149)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 13)
        Me.lblError.TabIndex = 3
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(203, 165)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 4
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'mtbPassword
        '
        Me.mtbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbPassword.Location = New System.Drawing.Point(65, 108)
        Me.mtbPassword.Mask = "00000000"
        Me.mtbPassword.Name = "mtbPassword"
        Me.mtbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbPassword.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mtbPassword.Size = New System.Drawing.Size(213, 31)
        Me.mtbPassword.TabIndex = 5
        '
        'pnlVerify
        '
        Me.pnlVerify.Controls.Add(Me.lblError2)
        Me.pnlVerify.Controls.Add(Me.btnBack)
        Me.pnlVerify.Controls.Add(Me.lblDig3)
        Me.pnlVerify.Controls.Add(Me.lblDig2)
        Me.pnlVerify.Controls.Add(Me.lblDig1)
        Me.pnlVerify.Controls.Add(Me.mtbDigit3)
        Me.pnlVerify.Controls.Add(Me.mtbDigit2)
        Me.pnlVerify.Controls.Add(Me.mtbDigit1)
        Me.pnlVerify.Controls.Add(Me.btnLogin)
        Me.pnlVerify.Controls.Add(Me.lblLoginStep2)
        Me.pnlVerify.Controls.Add(Me.lblPAC)
        Me.pnlVerify.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlVerify.Location = New System.Drawing.Point(0, 0)
        Me.pnlVerify.Name = "pnlVerify"
        Me.pnlVerify.Size = New System.Drawing.Size(331, 233)
        Me.pnlVerify.TabIndex = 6
        Me.pnlVerify.Visible = False
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(51, 165)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblDig3
        '
        Me.lblDig3.AutoSize = True
        Me.lblDig3.Location = New System.Drawing.Point(189, 119)
        Me.lblDig3.Name = "lblDig3"
        Me.lblDig3.Size = New System.Drawing.Size(36, 13)
        Me.lblDig3.TabIndex = 14
        Me.lblDig3.Text = "Digit x"
        '
        'lblDig2
        '
        Me.lblDig2.AutoSize = True
        Me.lblDig2.Location = New System.Drawing.Point(129, 119)
        Me.lblDig2.Name = "lblDig2"
        Me.lblDig2.Size = New System.Drawing.Size(36, 13)
        Me.lblDig2.TabIndex = 13
        Me.lblDig2.Text = "Digit x"
        '
        'lblDig1
        '
        Me.lblDig1.AutoSize = True
        Me.lblDig1.Location = New System.Drawing.Point(71, 119)
        Me.lblDig1.Name = "lblDig1"
        Me.lblDig1.Size = New System.Drawing.Size(36, 13)
        Me.lblDig1.TabIndex = 12
        Me.lblDig1.Text = "Digit x"
        '
        'mtbDigit3
        '
        Me.mtbDigit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbDigit3.Location = New System.Drawing.Point(224, 108)
        Me.mtbDigit3.Mask = "0"
        Me.mtbDigit3.Name = "mtbDigit3"
        Me.mtbDigit3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbDigit3.Size = New System.Drawing.Size(18, 31)
        Me.mtbDigit3.TabIndex = 11
        '
        'mtbDigit2
        '
        Me.mtbDigit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbDigit2.Location = New System.Drawing.Point(165, 108)
        Me.mtbDigit2.Mask = "0"
        Me.mtbDigit2.Name = "mtbDigit2"
        Me.mtbDigit2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbDigit2.Size = New System.Drawing.Size(18, 31)
        Me.mtbDigit2.TabIndex = 10
        '
        'mtbDigit1
        '
        Me.mtbDigit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbDigit1.Location = New System.Drawing.Point(108, 107)
        Me.mtbDigit1.Mask = "0"
        Me.mtbDigit1.Name = "mtbDigit1"
        Me.mtbDigit1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbDigit1.Size = New System.Drawing.Size(18, 31)
        Me.mtbDigit1.TabIndex = 9
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(203, 165)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblLoginStep2
        '
        Me.lblLoginStep2.AutoSize = True
        Me.lblLoginStep2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginStep2.Location = New System.Drawing.Point(71, 48)
        Me.lblLoginStep2.Name = "lblLoginStep2"
        Me.lblLoginStep2.Size = New System.Drawing.Size(143, 17)
        Me.lblLoginStep2.TabIndex = 6
        Me.lblLoginStep2.Text = "Log in: Step 2 of 2"
        '
        'lblPAC
        '
        Me.lblPAC.AutoSize = True
        Me.lblPAC.Location = New System.Drawing.Point(71, 78)
        Me.lblPAC.Name = "lblPAC"
        Me.lblPAC.Size = New System.Drawing.Size(171, 13)
        Me.lblPAC.TabIndex = 5
        Me.lblPAC.Text = "Personal Access Code (PAC) digits"
        '
        'lblError2
        '
        Me.lblError2.AutoSize = True
        Me.lblError2.ForeColor = System.Drawing.Color.Red
        Me.lblError2.Location = New System.Drawing.Point(71, 149)
        Me.lblError2.Name = "lblError2"
        Me.lblError2.Size = New System.Drawing.Size(0, 13)
        Me.lblError2.TabIndex = 16
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 233)
        Me.Controls.Add(Me.pnlVerify)
        Me.Controls.Add(Me.mtbPassword)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblLoginStep)
        Me.Controls.Add(Me.lblRegNo)
        Me.Name = "frmLogin"
        Me.Text = "Wolf Banking"
        Me.pnlVerify.ResumeLayout(False)
        Me.pnlVerify.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRegNo As System.Windows.Forms.Label
    Friend WithEvents lblLoginStep As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents mtbPassword As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pnlVerify As System.Windows.Forms.Panel
    Friend WithEvents mtbDigit3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbDigit2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbDigit1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblLoginStep2 As System.Windows.Forms.Label
    Friend WithEvents lblPAC As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblDig3 As System.Windows.Forms.Label
    Friend WithEvents lblDig2 As System.Windows.Forms.Label
    Friend WithEvents lblDig1 As System.Windows.Forms.Label
    Friend WithEvents lblError2 As System.Windows.Forms.Label

End Class

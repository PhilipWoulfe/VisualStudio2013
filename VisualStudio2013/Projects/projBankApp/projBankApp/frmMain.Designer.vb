<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.tbpControl = New System.Windows.Forms.TabControl()
        Me.tbpAccounts = New System.Windows.Forms.TabPage()
        Me.tbpTransfers = New System.Windows.Forms.TabPage()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboAccountsAccount = New System.Windows.Forms.ComboBox()
        Me.dgvTransactionDisplay = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lblSelectAccount = New System.Windows.Forms.Label()
        Me.tbpInformation = New System.Windows.Forms.TabPage()
        Me.tbpControl.SuspendLayout()
        Me.tbpAccounts.SuspendLayout()
        Me.tbpTransfers.SuspendLayout()
        CType(Me.dgvTransactionDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbpControl
        '
        Me.tbpControl.Controls.Add(Me.tbpAccounts)
        Me.tbpControl.Controls.Add(Me.tbpTransfers)
        Me.tbpControl.Controls.Add(Me.tbpInformation)
        Me.tbpControl.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.tbpControl.Location = New System.Drawing.Point(12, 12)
        Me.tbpControl.Name = "tbpControl"
        Me.tbpControl.SelectedIndex = 0
        Me.tbpControl.Size = New System.Drawing.Size(472, 393)
        Me.tbpControl.TabIndex = 0
        '
        'tbpAccounts
        '
        Me.tbpAccounts.Controls.Add(Me.lblSelectAccount)
        Me.tbpAccounts.Controls.Add(Me.dgvTransactionDisplay)
        Me.tbpAccounts.Controls.Add(Me.cboAccountsAccount)
        Me.tbpAccounts.Location = New System.Drawing.Point(4, 22)
        Me.tbpAccounts.Name = "tbpAccounts"
        Me.tbpAccounts.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpAccounts.Size = New System.Drawing.Size(464, 367)
        Me.tbpAccounts.TabIndex = 0
        Me.tbpAccounts.Text = "Accounts"
        Me.tbpAccounts.UseVisualStyleBackColor = True
        '
        'tbpTransfers
        '
        Me.tbpTransfers.Controls.Add(Me.ComboBox1)
        Me.tbpTransfers.Location = New System.Drawing.Point(4, 22)
        Me.tbpTransfers.Name = "tbpTransfers"
        Me.tbpTransfers.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTransfers.Size = New System.Drawing.Size(464, 367)
        Me.tbpTransfers.TabIndex = 1
        Me.tbpTransfers.Text = "Transfers"
        Me.tbpTransfers.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(391, 420)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cboAccountsAccount
        '
        Me.cboAccountsAccount.FormattingEnabled = True
        Me.cboAccountsAccount.Location = New System.Drawing.Point(60, 64)
        Me.cboAccountsAccount.Name = "cboAccountsAccount"
        Me.cboAccountsAccount.Size = New System.Drawing.Size(336, 21)
        Me.cboAccountsAccount.TabIndex = 0
        '
        'dgvTransactionDisplay
        '
        Me.dgvTransactionDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionDisplay.Location = New System.Drawing.Point(60, 139)
        Me.dgvTransactionDisplay.Name = "dgvTransactionDisplay"
        Me.dgvTransactionDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvTransactionDisplay.Size = New System.Drawing.Size(336, 191)
        Me.dgvTransactionDisplay.TabIndex = 1
        Me.dgvTransactionDisplay.Visible = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(61, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(332, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'lblSelectAccount
        '
        Me.lblSelectAccount.AutoSize = True
        Me.lblSelectAccount.Location = New System.Drawing.Point(60, 45)
        Me.lblSelectAccount.Name = "lblSelectAccount"
        Me.lblSelectAccount.Size = New System.Drawing.Size(187, 13)
        Me.lblSelectAccount.TabIndex = 2
        Me.lblSelectAccount.Text = "Select Account you would like to view"
        '
        'tbpInformation
        '
        Me.tbpInformation.Location = New System.Drawing.Point(4, 22)
        Me.tbpInformation.Name = "tbpInformation"
        Me.tbpInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpInformation.Size = New System.Drawing.Size(464, 367)
        Me.tbpInformation.TabIndex = 2
        Me.tbpInformation.Text = "Information"
        Me.tbpInformation.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.tbpControl)
        Me.Name = "frmMain"
        Me.Text = "Wolf Banking"
        Me.tbpControl.ResumeLayout(False)
        Me.tbpAccounts.ResumeLayout(False)
        Me.tbpAccounts.PerformLayout()
        Me.tbpTransfers.ResumeLayout(False)
        CType(Me.dgvTransactionDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbpControl As System.Windows.Forms.TabControl
    Friend WithEvents tbpAccounts As System.Windows.Forms.TabPage
    Friend WithEvents tbpTransfers As System.Windows.Forms.TabPage
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSelectAccount As System.Windows.Forms.Label
    Friend WithEvents dgvTransactionDisplay As System.Windows.Forms.DataGridView
    Friend WithEvents cboAccountsAccount As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents tbpInformation As System.Windows.Forms.TabPage
End Class

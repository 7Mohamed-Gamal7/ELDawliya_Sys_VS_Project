<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Message
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboReceivers = New System.Windows.Forms.ComboBox()
        Me.lstMessages = New System.Windows.Forms.ListBox()
        Me.btnReply = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(300, 746)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(161, 46)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "ارسال"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(11, 71)
        Me.txtMessage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(777, 307)
        Me.txtMessage.TabIndex = 1
        Me.txtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(12, 746)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 29)
        Me.lblStatus.TabIndex = 2
        Me.lblStatus.Text = "Label1"
        '
        'cboReceivers
        '
        Me.cboReceivers.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReceivers.FormattingEnabled = True
        Me.cboReceivers.Location = New System.Drawing.Point(467, 746)
        Me.cboReceivers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboReceivers.Name = "cboReceivers"
        Me.cboReceivers.Size = New System.Drawing.Size(321, 37)
        Me.cboReceivers.TabIndex = 3
        '
        'lstMessages
        '
        Me.lstMessages.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMessages.FormattingEnabled = True
        Me.lstMessages.ItemHeight = 29
        Me.lstMessages.Location = New System.Drawing.Point(12, 386)
        Me.lstMessages.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstMessages.Name = "lstMessages"
        Me.lstMessages.Size = New System.Drawing.Size(777, 352)
        Me.lstMessages.TabIndex = 4
        '
        'btnReply
        '
        Me.btnReply.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReply.Location = New System.Drawing.Point(133, 746)
        Me.btnReply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(161, 46)
        Me.btnReply.TabIndex = 0
        Me.btnReply.Text = "رد"
        Me.btnReply.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Frm_Message
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 818)
        Me.Controls.Add(Me.lstMessages)
        Me.Controls.Add(Me.cboReceivers)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnReply)
        Me.Controls.Add(Me.btnSend)
        Me.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Frm_Message"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSend As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cboReceivers As ComboBox
    Friend WithEvents lstMessages As ListBox
    Friend WithEvents btnReply As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class

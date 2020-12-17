<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Batch
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
        Me.lblSomeStringCaption = New System.Windows.Forms.Label()
        Me.lblSomeString = New System.Windows.Forms.Label()
        Me.lblNewRemarkCaption = New System.Windows.Forms.Label()
        Me.lblNewRemark = New System.Windows.Forms.Label()
        Me.lvlREmarkCaption = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.cmdProcess = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.processBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'lblSomeStringCaption
        '
        Me.lblSomeStringCaption.AutoSize = True
        Me.lblSomeStringCaption.Location = New System.Drawing.Point(0, 0)
        Me.lblSomeStringCaption.Name = "lblSomeStringCaption"
        Me.lblSomeStringCaption.Size = New System.Drawing.Size(64, 13)
        Me.lblSomeStringCaption.TabIndex = 0
        Me.lblSomeStringCaption.Text = "SomeString:"
        '
        'lblSomeString
        '
        Me.lblSomeString.AutoSize = True
        Me.lblSomeString.Location = New System.Drawing.Point(90, 0)
        Me.lblSomeString.Name = "lblSomeString"
        Me.lblSomeString.Size = New System.Drawing.Size(71, 13)
        Me.lblSomeString.TabIndex = 1
        Me.lblSomeString.Text = "lblSomeString"
        '
        'lblNewRemarkCaption
        '
        Me.lblNewRemarkCaption.AutoSize = True
        Me.lblNewRemarkCaption.Location = New System.Drawing.Point(0, 29)
        Me.lblNewRemarkCaption.Name = "lblNewRemarkCaption"
        Me.lblNewRemarkCaption.Size = New System.Drawing.Size(84, 13)
        Me.lblNewRemarkCaption.TabIndex = 2
        Me.lblNewRemarkCaption.Text = "Default Remark:"
        '
        'lblNewRemark
        '
        Me.lblNewRemark.AutoSize = True
        Me.lblNewRemark.Location = New System.Drawing.Point(90, 29)
        Me.lblNewRemark.Name = "lblNewRemark"
        Me.lblNewRemark.Size = New System.Drawing.Size(76, 13)
        Me.lblNewRemark.TabIndex = 3
        Me.lblNewRemark.Text = "lblNewRemark"
        '
        'lvlREmarkCaption
        '
        Me.lvlREmarkCaption.AutoSize = True
        Me.lvlREmarkCaption.Location = New System.Drawing.Point(0, 67)
        Me.lvlREmarkCaption.Name = "lvlREmarkCaption"
        Me.lvlREmarkCaption.Size = New System.Drawing.Size(47, 13)
        Me.lvlREmarkCaption.TabIndex = 4
        Me.lvlREmarkCaption.Text = "Remark:"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(93, 64)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(114, 20)
        Me.txtRemark.TabIndex = 5
        '
        'cmdProcess
        '
        Me.cmdProcess.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdProcess.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.cmdProcess.Location = New System.Drawing.Point(51, 106)
        Me.cmdProcess.Name = "cmdProcess"
        Me.cmdProcess.Size = New System.Drawing.Size(75, 23)
        Me.cmdProcess.TabIndex = 6
        Me.cmdProcess.Text = "Process"
        Me.cmdProcess.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(132, 106)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancel.TabIndex = 7
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'processBackgroundWorker
        '
        Me.processBackgroundWorker.WorkerReportsProgress = True
        Me.processBackgroundWorker.WorkerSupportsCancellation = True
        '
        'Batch
        '
        Me.AcceptButton = Me.cmdProcess
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(219, 141)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdProcess)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.lvlREmarkCaption)
        Me.Controls.Add(Me.lblNewRemark)
        Me.Controls.Add(Me.lblNewRemarkCaption)
        Me.Controls.Add(Me.lblSomeString)
        Me.Controls.Add(Me.lblSomeStringCaption)
        Me.Name = "Batch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Batch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSomeStringCaption As System.Windows.Forms.Label
    Friend WithEvents lblSomeString As System.Windows.Forms.Label
    Friend WithEvents lblNewRemarkCaption As System.Windows.Forms.Label
    Friend WithEvents lblNewRemark As System.Windows.Forms.Label
    Friend WithEvents lvlREmarkCaption As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents cmdProcess As System.Windows.Forms.Button
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents processBackgroundWorker As System.ComponentModel.BackgroundWorker
End Class

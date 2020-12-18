'Namespace MvcFormsVb
Partial Class MVCView
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MVCView))
        Me.toolbar = New System.Windows.Forms.ToolStrip()
        Me.buttonFileNew = New System.Windows.Forms.ToolStripButton()
        Me.buttonFileOpen = New System.Windows.Forms.ToolStripButton()
        Me.buttonFileSave = New System.Windows.Forms.ToolStripButton()
        Me.buttonSeparator0 = New System.Windows.Forms.ToolStripSeparator()
        Me.buttonEditCopyToClipboard = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditProperties = New System.Windows.Forms.ToolStripButton()
        Me.menu_ = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditCopyToClipboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditSeparator0 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuEditProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.StatusBarStatusMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarErrorMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusBarActionIcon = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarDirtyMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarNetworkIndicator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarCustomMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.chkSomeOtherBoolean = New System.Windows.Forms.CheckBox()
        Me.txtSomeOtherString = New System.Windows.Forms.TextBox()
        Me.txtSomeOtherInt = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.chkSomeBoolean = New System.Windows.Forms.CheckBox()
        Me.txtSomeString = New System.Windows.Forms.TextBox()
        Me.txtSomeInt = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.toolbar.SuspendLayout()
        Me.menu_.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonFileNew, Me.buttonFileOpen, Me.buttonFileSave, Me.buttonSeparator0, Me.buttonEditCopyToClipboard, Me.buttonEditProperties})
        Me.toolbar.Location = New System.Drawing.Point(0, 24)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(624, 25)
        Me.toolbar.TabIndex = 118
        Me.toolbar.Text = "toolStrip1"
        '
        'buttonFileNew
        '
        Me.buttonFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFileNew.Image = CType(resources.GetObject("buttonFileNew.Image"), System.Drawing.Image)
        Me.buttonFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFileNew.Name = "buttonFileNew"
        Me.buttonFileNew.Size = New System.Drawing.Size(23, 22)
        Me.buttonFileNew.Text = "&New"
        '
        'buttonFileOpen
        '
        Me.buttonFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFileOpen.Image = CType(resources.GetObject("buttonFileOpen.Image"), System.Drawing.Image)
        Me.buttonFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFileOpen.Name = "buttonFileOpen"
        Me.buttonFileOpen.Size = New System.Drawing.Size(23, 22)
        Me.buttonFileOpen.Text = "&Open"
        '
        'buttonFileSave
        '
        Me.buttonFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFileSave.Image = CType(resources.GetObject("buttonFileSave.Image"), System.Drawing.Image)
        Me.buttonFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFileSave.Name = "buttonFileSave"
        Me.buttonFileSave.Size = New System.Drawing.Size(23, 22)
        Me.buttonFileSave.Text = "&Save"
        '
        'buttonSeparator0
        '
        Me.buttonSeparator0.Name = "buttonSeparator0"
        Me.buttonSeparator0.Size = New System.Drawing.Size(6, 25)
        '
        'buttonEditCopyToClipboard
        '
        Me.buttonEditCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditCopyToClipboard.Image = CType(resources.GetObject("buttonEditCopyToClipboard.Image"), System.Drawing.Image)
        Me.buttonEditCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Black
        Me.buttonEditCopyToClipboard.Name = "buttonEditCopyToClipboard"
        Me.buttonEditCopyToClipboard.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditCopyToClipboard.Text = "Copy to Clipboard"
        '
        'buttonEditProperties
        '
        Me.buttonEditProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditProperties.Image = CType(resources.GetObject("buttonEditProperties.Image"), System.Drawing.Image)
        Me.buttonEditProperties.ImageTransparentColor = System.Drawing.Color.Black
        Me.buttonEditProperties.Name = "buttonEditProperties"
        Me.buttonEditProperties.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditProperties.Text = "P&roperties..."
        '
        'menu_
        '
        Me.menu_.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFile, Me.menuEdit, Me.menuHelp})
        Me.menu_.Location = New System.Drawing.Point(0, 0)
        Me.menu_.Name = "menu_"
        Me.menu_.Size = New System.Drawing.Size(624, 24)
        Me.menu_.TabIndex = 117
        Me.menu_.Text = "menuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileNew, Me.menuFileOpen, Me.menuFileSave, Me.menuFileSaveAs, Me.menuFileSeparator2, Me.menuFileExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "&File"
        '
        'menuFileNew
        '
        Me.menuFileNew.Image = CType(resources.GetObject("menuFileNew.Image"), System.Drawing.Image)
        Me.menuFileNew.Name = "menuFileNew"
        Me.menuFileNew.Size = New System.Drawing.Size(146, 22)
        Me.menuFileNew.Text = "&New"
        '
        'menuFileOpen
        '
        Me.menuFileOpen.Image = CType(resources.GetObject("menuFileOpen.Image"), System.Drawing.Image)
        Me.menuFileOpen.Name = "menuFileOpen"
        Me.menuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.menuFileOpen.Size = New System.Drawing.Size(146, 22)
        Me.menuFileOpen.Text = "&Open"
        '
        'menuFileSave
        '
        Me.menuFileSave.Image = CType(resources.GetObject("menuFileSave.Image"), System.Drawing.Image)
        Me.menuFileSave.Name = "menuFileSave"
        Me.menuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menuFileSave.Size = New System.Drawing.Size(146, 22)
        Me.menuFileSave.Text = "&Save"
        '
        'menuFileSaveAs
        '
        Me.menuFileSaveAs.Name = "menuFileSaveAs"
        Me.menuFileSaveAs.Size = New System.Drawing.Size(146, 22)
        Me.menuFileSaveAs.Text = "Save &As..."
        '
        'menuFileSeparator2
        '
        Me.menuFileSeparator2.Name = "menuFileSeparator2"
        Me.menuFileSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'menuFileExit
        '
        Me.menuFileExit.Name = "menuFileExit"
        Me.menuFileExit.Size = New System.Drawing.Size(146, 22)
        Me.menuFileExit.Text = "E&xit"
        '
        'menuEdit
        '
        Me.menuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEditCopyToClipboard, Me.menuEditSeparator0, Me.menuEditProperties})
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(39, 20)
        Me.menuEdit.Text = "&Edit"
        '
        'menuEditCopyToClipboard
        '
        Me.menuEditCopyToClipboard.Image = CType(resources.GetObject("menuEditCopyToClipboard.Image"), System.Drawing.Image)
        Me.menuEditCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuEditCopyToClipboard.Name = "menuEditCopyToClipboard"
        Me.menuEditCopyToClipboard.Size = New System.Drawing.Size(171, 22)
        Me.menuEditCopyToClipboard.Text = "&Copy to Clipboard"
        '
        'menuEditSeparator0
        '
        Me.menuEditSeparator0.Name = "menuEditSeparator0"
        Me.menuEditSeparator0.Size = New System.Drawing.Size(168, 6)
        '
        'menuEditProperties
        '
        Me.menuEditProperties.Image = CType(resources.GetObject("menuEditProperties.Image"), System.Drawing.Image)
        Me.menuEditProperties.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuEditProperties.Name = "menuEditProperties"
        Me.menuEditProperties.Size = New System.Drawing.Size(171, 22)
        Me.menuEditProperties.Text = "P&roperties..."
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpAbout})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(44, 20)
        Me.menuHelp.Text = "&Help"
        Me.menuHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'menuHelpAbout
        '
        Me.menuHelpAbout.Name = "menuHelpAbout"
        Me.menuHelpAbout.Size = New System.Drawing.Size(181, 22)
        Me.menuHelpAbout.Text = "&About MVCForms ..."
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarStatusMessage, Me.StatusBarErrorMessage, Me.StatusBarProgressBar, Me.StatusBarActionIcon, Me.StatusBarDirtyMessage, Me.StatusBarNetworkIndicator, Me.StatusBarCustomMessage})
        Me.statusBar.Location = New System.Drawing.Point(0, 420)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(624, 22)
        Me.statusBar.TabIndex = 131
        Me.statusBar.Text = "statusStrip1"
        '
        'StatusBarStatusMessage
        '
        Me.StatusBarStatusMessage.ForeColor = System.Drawing.Color.Green
        Me.StatusBarStatusMessage.Name = "StatusBarStatusMessage"
        Me.StatusBarStatusMessage.Size = New System.Drawing.Size(0, 17)
        Me.StatusBarStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusBarErrorMessage
        '
        Me.StatusBarErrorMessage.AutoToolTip = True
        Me.StatusBarErrorMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.StatusBarErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.StatusBarErrorMessage.Name = "StatusBarErrorMessage"
        Me.StatusBarErrorMessage.Size = New System.Drawing.Size(436, 17)
        Me.StatusBarErrorMessage.Spring = True
        Me.StatusBarErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusBarProgressBar
        '
        Me.StatusBarProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.StatusBarProgressBar.Name = "StatusBarProgressBar"
        Me.StatusBarProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.StatusBarProgressBar.Value = 10
        Me.StatusBarProgressBar.Visible = False
        '
        'StatusBarActionIcon
        '
        Me.StatusBarActionIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StatusBarActionIcon.Image = CType(resources.GetObject("StatusBarActionIcon.Image"), System.Drawing.Image)
        Me.StatusBarActionIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StatusBarActionIcon.Name = "StatusBarActionIcon"
        Me.StatusBarActionIcon.Size = New System.Drawing.Size(16, 17)
        Me.StatusBarActionIcon.Visible = False
        '
        'StatusBarDirtyMessage
        '
        Me.StatusBarDirtyMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StatusBarDirtyMessage.Image = CType(resources.GetObject("StatusBarDirtyMessage.Image"), System.Drawing.Image)
        Me.StatusBarDirtyMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StatusBarDirtyMessage.Name = "StatusBarDirtyMessage"
        Me.StatusBarDirtyMessage.Size = New System.Drawing.Size(16, 17)
        Me.StatusBarDirtyMessage.ToolTipText = "Dirty"
        Me.StatusBarDirtyMessage.Visible = False
        '
        'StatusBarNetworkIndicator
        '
        Me.StatusBarNetworkIndicator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StatusBarNetworkIndicator.Image = CType(resources.GetObject("StatusBarNetworkIndicator.Image"), System.Drawing.Image)
        Me.StatusBarNetworkIndicator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StatusBarNetworkIndicator.ImageTransparentColor = System.Drawing.Color.Fuchsia
        Me.StatusBarNetworkIndicator.Name = "StatusBarNetworkIndicator"
        Me.StatusBarNetworkIndicator.Size = New System.Drawing.Size(16, 17)
        Me.StatusBarNetworkIndicator.ToolTipText = "Network Connected"
        Me.StatusBarNetworkIndicator.Visible = False
        '
        'StatusBarCustomMessage
        '
        Me.StatusBarCustomMessage.Name = "StatusBarCustomMessage"
        Me.StatusBarCustomMessage.Size = New System.Drawing.Size(0, 17)
        '
        'chkSomeOtherBoolean
        '
        Me.chkSomeOtherBoolean.AutoSize = True
        Me.chkSomeOtherBoolean.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSomeOtherBoolean.Location = New System.Drawing.Point(196, 104)
        Me.chkSomeOtherBoolean.Name = "chkSomeOtherBoolean"
        Me.chkSomeOtherBoolean.Size = New System.Drawing.Size(65, 17)
        Me.chkSomeOtherBoolean.TabIndex = 142
        Me.chkSomeOtherBoolean.Text = "Boolean"
        Me.chkSomeOtherBoolean.UseVisualStyleBackColor = True
        '
        'txtSomeOtherString
        '
        Me.txtSomeOtherString.Location = New System.Drawing.Point(247, 78)
        Me.txtSomeOtherString.Name = "txtSomeOtherString"
        Me.txtSomeOtherString.Size = New System.Drawing.Size(100, 20)
        Me.txtSomeOtherString.TabIndex = 141
        '
        'txtSomeOtherInt
        '
        Me.txtSomeOtherInt.Location = New System.Drawing.Point(247, 52)
        Me.txtSomeOtherInt.Name = "txtSomeOtherInt"
        Me.txtSomeOtherInt.Size = New System.Drawing.Size(100, 20)
        Me.txtSomeOtherInt.TabIndex = 140
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(206, 81)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 13)
        Me.label3.TabIndex = 139
        Me.label3.Text = "String"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(206, 55)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(31, 13)
        Me.label4.TabIndex = 138
        Me.label4.Text = "Int32"
        '
        'cmdRun
        '
        Me.cmdRun.Location = New System.Drawing.Point(381, 50)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(75, 23)
        Me.cmdRun.TabIndex = 137
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'chkSomeBoolean
        '
        Me.chkSomeBoolean.AutoSize = True
        Me.chkSomeBoolean.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSomeBoolean.Location = New System.Drawing.Point(21, 104)
        Me.chkSomeBoolean.Name = "chkSomeBoolean"
        Me.chkSomeBoolean.Size = New System.Drawing.Size(65, 17)
        Me.chkSomeBoolean.TabIndex = 136
        Me.chkSomeBoolean.Text = "Boolean"
        Me.chkSomeBoolean.UseVisualStyleBackColor = True
        '
        'txtSomeString
        '
        Me.txtSomeString.Location = New System.Drawing.Point(72, 78)
        Me.txtSomeString.Name = "txtSomeString"
        Me.txtSomeString.Size = New System.Drawing.Size(100, 20)
        Me.txtSomeString.TabIndex = 135
        '
        'txtSomeInt
        '
        Me.txtSomeInt.Location = New System.Drawing.Point(72, 52)
        Me.txtSomeInt.Name = "txtSomeInt"
        Me.txtSomeInt.Size = New System.Drawing.Size(100, 20)
        Me.txtSomeInt.TabIndex = 134
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(31, 81)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(34, 13)
        Me.label2.TabIndex = 133
        Me.label2.Text = "String"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(31, 55)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(31, 13)
        Me.label1.TabIndex = 132
        Me.label1.Text = "Int32"
        '
        'MVCView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.chkSomeOtherBoolean)
        Me.Controls.Add(Me.txtSomeOtherString)
        Me.Controls.Add(Me.txtSomeOtherInt)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.cmdRun)
        Me.Controls.Add(Me.chkSomeBoolean)
        Me.Controls.Add(Me.txtSomeString)
        Me.Controls.Add(Me.txtSomeInt)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.menu_)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MVCView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MVCView"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        Me.menu_.ResumeLayout(False)
        Me.menu_.PerformLayout()
        Me.statusBar.ResumeLayout(False)
        Me.statusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private toolbar As System.Windows.Forms.ToolStrip
    Private WithEvents buttonFileNew As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonFileOpen As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonFileSave As System.Windows.Forms.ToolStripButton
    Private buttonSeparator0 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents buttonEditCopyToClipboard As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditProperties As System.Windows.Forms.ToolStripButton
    Private menu_ As System.Windows.Forms.MenuStrip
    Private WithEvents menuFile As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuFileNew As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuFileSave As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Private menuFileSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents menuFileExit As System.Windows.Forms.ToolStripMenuItem
    Private menuEdit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuEditCopyToClipboard As System.Windows.Forms.ToolStripMenuItem
    Private menuEditSeparator0 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents menuEditProperties As System.Windows.Forms.ToolStripMenuItem
    Private menuHelp As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents statusBar As System.Windows.Forms.StatusStrip
    Private WithEvents StatusBarStatusMessage As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarErrorMessage As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarProgressBar As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents StatusBarActionIcon As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarDirtyMessage As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarNetworkIndicator As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarCustomMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DirtyDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SomeOtherIntDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SomeOtherBooleanDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SomeOtherStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents chkSomeOtherBoolean As CheckBox
    Private WithEvents txtSomeOtherString As TextBox
    Private WithEvents txtSomeOtherInt As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label4 As Label
    Private WithEvents cmdRun As Button
    Private WithEvents chkSomeBoolean As CheckBox
    Private WithEvents txtSomeString As TextBox
    Private WithEvents txtSomeInt As TextBox
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
'End Namespace


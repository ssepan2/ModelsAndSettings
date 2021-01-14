Namespace MVCForms
    Partial Class MVCView
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MVCView))
            toolbar = New Windows.Forms.ToolStrip()
            buttonFileNew = New Windows.Forms.ToolStripButton()
            buttonFileOpen = New Windows.Forms.ToolStripButton()
            buttonFileSave = New Windows.Forms.ToolStripButton()
            buttonSeparator0 = New Windows.Forms.ToolStripSeparator()
            buttonEditCopyToClipboard = New Windows.Forms.ToolStripButton()
            buttonEditProperties = New Windows.Forms.ToolStripButton()
            menu = New Windows.Forms.MenuStrip()
            menuFile = New Windows.Forms.ToolStripMenuItem()
            menuFileNew = New Windows.Forms.ToolStripMenuItem()
            menuFileOpen = New Windows.Forms.ToolStripMenuItem()
            menuFileSave = New Windows.Forms.ToolStripMenuItem()
            menuFileSaveAs = New Windows.Forms.ToolStripMenuItem()
            menuFileSeparator2 = New Windows.Forms.ToolStripSeparator()
            menuFileExit = New Windows.Forms.ToolStripMenuItem()
            menuEdit = New Windows.Forms.ToolStripMenuItem()
            menuEditCopyToClipboard = New Windows.Forms.ToolStripMenuItem()
            menuEditSeparator0 = New Windows.Forms.ToolStripSeparator()
            menuEditProperties = New Windows.Forms.ToolStripMenuItem()
            menuHelp = New Windows.Forms.ToolStripMenuItem()
            menuHelpAbout = New Windows.Forms.ToolStripMenuItem()
            statusBar = New Windows.Forms.StatusStrip()
            StatusBarStatusMessage = New Windows.Forms.ToolStripStatusLabel()
            StatusBarErrorMessage = New Windows.Forms.ToolStripStatusLabel()
            StatusBarProgressBar = New Windows.Forms.ToolStripProgressBar()
            StatusBarActionIcon = New Windows.Forms.ToolStripStatusLabel()
            StatusBarDirtyMessage = New Windows.Forms.ToolStripStatusLabel()
            StatusBarNetworkIndicator = New Windows.Forms.ToolStripStatusLabel()
            StatusBarCustomMessage = New Windows.Forms.ToolStripStatusLabel()
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            txtSomeInt = New Windows.Forms.TextBox()
            txtSomeString = New Windows.Forms.TextBox()
            chkSomeBoolean = New Windows.Forms.CheckBox()
            cmdRun = New Windows.Forms.Button()
            chkSomeOtherBoolean = New Windows.Forms.CheckBox()
            txtSomeOtherString = New Windows.Forms.TextBox()
            txtSomeOtherInt = New Windows.Forms.TextBox()
            label3 = New Windows.Forms.Label()
            label4 = New Windows.Forms.Label()
            chkStillAnotherBoolean = New Windows.Forms.CheckBox()
            txtStillAnotherString = New Windows.Forms.TextBox()
            txtStillAnotherInt = New Windows.Forms.TextBox()
            lblStillAnotherString = New Windows.Forms.Label()
            lblStillAnotherInt = New Windows.Forms.Label()
            toolbar.SuspendLayout()
            menu.SuspendLayout()
            statusBar.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' toolbar
            ' 
            toolbar.GripStyle = Windows.Forms.ToolStripGripStyle.Hidden
            toolbar.Items.AddRange(New Windows.Forms.ToolStripItem() {buttonFileNew, buttonFileOpen, buttonFileSave, buttonSeparator0, buttonEditCopyToClipboard, buttonEditProperties})
            toolbar.Location = New Drawing.Point(0, 24)
            toolbar.Name = "toolbar"
            toolbar.Size = New Drawing.Size(624, 25)
            toolbar.TabIndex = 118
            toolbar.Text = "toolStrip1"
            ' 
            ' buttonFileNew
            ' 
            buttonFileNew.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            buttonFileNew.Image = CType(resources.GetObject("buttonFileNew.Image"), Drawing.Image)
            buttonFileNew.ImageTransparentColor = Drawing.Color.Magenta
            buttonFileNew.Name = "buttonFileNew"
            buttonFileNew.Size = New Drawing.Size(23, 22)
            buttonFileNew.Text = "&New"
            AddHandler buttonFileNew.Click, New EventHandler(AddressOf Me.menuFileNew_Click)
            ' 
            ' buttonFileOpen
            ' 
            buttonFileOpen.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            buttonFileOpen.Image = CType(resources.GetObject("buttonFileOpen.Image"), Drawing.Image)
            buttonFileOpen.ImageTransparentColor = Drawing.Color.Magenta
            buttonFileOpen.Name = "buttonFileOpen"
            buttonFileOpen.Size = New Drawing.Size(23, 22)
            buttonFileOpen.Text = "&Open"
            AddHandler buttonFileOpen.Click, New EventHandler(AddressOf Me.menuFileOpen_Click)
            ' 
            ' buttonFileSave
            ' 
            buttonFileSave.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            buttonFileSave.Image = CType(resources.GetObject("buttonFileSave.Image"), Drawing.Image)
            buttonFileSave.ImageTransparentColor = Drawing.Color.Magenta
            buttonFileSave.Name = "buttonFileSave"
            buttonFileSave.Size = New Drawing.Size(23, 22)
            buttonFileSave.Text = "&Save"
            AddHandler buttonFileSave.Click, New EventHandler(AddressOf Me.menuFileSave_Click)
            ' 
            ' buttonSeparator0
            ' 
            buttonSeparator0.Name = "buttonSeparator0"
            buttonSeparator0.Size = New Drawing.Size(6, 25)
            ' 
            ' buttonEditCopyToClipboard
            ' 
            buttonEditCopyToClipboard.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            buttonEditCopyToClipboard.Image = CType(resources.GetObject("buttonEditCopyToClipboard.Image"), Drawing.Image)
            buttonEditCopyToClipboard.ImageTransparentColor = Drawing.Color.Black
            buttonEditCopyToClipboard.Name = "buttonEditCopyToClipboard"
            buttonEditCopyToClipboard.Size = New Drawing.Size(23, 22)
            buttonEditCopyToClipboard.Text = "Copy to Clipboard"
            AddHandler buttonEditCopyToClipboard.Click, New EventHandler(AddressOf Me.menuEditCopyToClipboard_Click)
            ' 
            ' buttonEditProperties
            ' 
            buttonEditProperties.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            buttonEditProperties.Image = CType(resources.GetObject("buttonEditProperties.Image"), Drawing.Image)
            buttonEditProperties.ImageTransparentColor = Drawing.Color.Black
            buttonEditProperties.Name = "buttonEditProperties"
            buttonEditProperties.Size = New Drawing.Size(23, 22)
            buttonEditProperties.Text = "P&roperties..."
            AddHandler buttonEditProperties.Click, New EventHandler(AddressOf Me.menuEditProperties_Click)
            ' 
            ' menu
            ' 
            menu.Items.AddRange(New Windows.Forms.ToolStripItem() {menuFile, menuEdit, menuHelp})
            menu.Location = New Drawing.Point(0, 0)
            menu.Name = "menu"
            menu.Size = New Drawing.Size(624, 24)
            menu.TabIndex = 117
            menu.Text = "menuStrip1"
            ' 
            ' menuFile
            ' 
            menuFile.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {menuFileNew, menuFileOpen, menuFileSave, menuFileSaveAs, menuFileSeparator2, menuFileExit})
            menuFile.Name = "menuFile"
            menuFile.Size = New Drawing.Size(37, 20)
            menuFile.Text = "&File"
            ' 
            ' menuFileNew
            ' 
            menuFileNew.Image = CType(resources.GetObject("menuFileNew.Image"), Drawing.Image)
            menuFileNew.Name = "menuFileNew"
            menuFileNew.Size = New Drawing.Size(146, 22)
            menuFileNew.Text = "&New"
            AddHandler menuFileNew.Click, New EventHandler(AddressOf Me.menuFileNew_Click)
            ' 
            ' menuFileOpen
            ' 
            menuFileOpen.Image = CType(resources.GetObject("menuFileOpen.Image"), Drawing.Image)
            menuFileOpen.Name = "menuFileOpen"
            menuFileOpen.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.O
            menuFileOpen.Size = New Drawing.Size(146, 22)
            menuFileOpen.Text = "&Open"
            AddHandler menuFileOpen.Click, New EventHandler(AddressOf Me.menuFileOpen_Click)
            ' 
            ' menuFileSave
            ' 
            menuFileSave.Image = CType(resources.GetObject("menuFileSave.Image"), Drawing.Image)
            menuFileSave.Name = "menuFileSave"
            menuFileSave.ShortcutKeys = Windows.Forms.Keys.Control Or Windows.Forms.Keys.S
            menuFileSave.Size = New Drawing.Size(146, 22)
            menuFileSave.Text = "&Save"
            AddHandler menuFileSave.Click, New EventHandler(AddressOf Me.menuFileSave_Click)
            ' 
            ' menuFileSaveAs
            ' 
            menuFileSaveAs.Name = "menuFileSaveAs"
            menuFileSaveAs.Size = New Drawing.Size(146, 22)
            menuFileSaveAs.Text = "Save &As..."
            AddHandler menuFileSaveAs.Click, New EventHandler(AddressOf Me.menuFileSaveAs_Click)
            ' 
            ' menuFileSeparator2
            ' 
            menuFileSeparator2.Name = "menuFileSeparator2"
            menuFileSeparator2.Size = New Drawing.Size(143, 6)
            ' 
            ' menuFileExit
            ' 
            menuFileExit.Name = "menuFileExit"
            menuFileExit.Size = New Drawing.Size(146, 22)
            menuFileExit.Text = "E&xit"
            AddHandler menuFileExit.Click, New EventHandler(AddressOf Me.menuFileExit_Click)
            ' 
            ' menuEdit
            ' 
            menuEdit.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {menuEditCopyToClipboard, menuEditSeparator0, menuEditProperties})
            menuEdit.Name = "menuEdit"
            menuEdit.Size = New Drawing.Size(39, 20)
            menuEdit.Text = "&Edit"
            ' 
            ' menuEditCopyToClipboard
            ' 
            menuEditCopyToClipboard.Image = CType(resources.GetObject("menuEditCopyToClipboard.Image"), Drawing.Image)
            menuEditCopyToClipboard.ImageTransparentColor = Drawing.Color.Black
            menuEditCopyToClipboard.Name = "menuEditCopyToClipboard"
            menuEditCopyToClipboard.Size = New Drawing.Size(171, 22)
            menuEditCopyToClipboard.Text = "&Copy to Clipboard"
            AddHandler menuEditCopyToClipboard.Click, New EventHandler(AddressOf Me.menuEditCopyToClipboard_Click)
            ' 
            ' menuEditSeparator0
            ' 
            menuEditSeparator0.Name = "menuEditSeparator0"
            menuEditSeparator0.Size = New Drawing.Size(168, 6)
            ' 
            ' menuEditProperties
            ' 
            menuEditProperties.Image = CType(resources.GetObject("menuEditProperties.Image"), Drawing.Image)
            menuEditProperties.ImageTransparentColor = Drawing.Color.Black
            menuEditProperties.Name = "menuEditProperties"
            menuEditProperties.Size = New Drawing.Size(171, 22)
            menuEditProperties.Text = "P&roperties..."
            AddHandler menuEditProperties.Click, New EventHandler(AddressOf Me.menuEditProperties_Click)
            ' 
            ' menuHelp
            ' 
            menuHelp.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {menuHelpAbout})
            menuHelp.Name = "menuHelp"
            menuHelp.Size = New Drawing.Size(44, 20)
            menuHelp.Text = "&Help"
            menuHelp.TextAlign = Drawing.ContentAlignment.MiddleRight
            ' 
            ' menuHelpAbout
            ' 
            menuHelpAbout.Name = "menuHelpAbout"
            menuHelpAbout.Size = New Drawing.Size(181, 22)
            menuHelpAbout.Text = "&About MVCForms ..."
            AddHandler menuHelpAbout.Click, New EventHandler(AddressOf Me.menuHelpAbout_Click)
            ' 
            ' statusBar
            ' 
            statusBar.Items.AddRange(New Windows.Forms.ToolStripItem() {StatusBarStatusMessage, StatusBarErrorMessage, StatusBarProgressBar, StatusBarActionIcon, StatusBarDirtyMessage, StatusBarNetworkIndicator, StatusBarCustomMessage})
            statusBar.Location = New Drawing.Point(0, 420)
            statusBar.Name = "statusBar"
            statusBar.Size = New Drawing.Size(624, 22)
            statusBar.TabIndex = 116
            statusBar.Text = "statusStrip1"
            ' 
            ' StatusBarStatusMessage
            ' 
            StatusBarStatusMessage.ForeColor = Drawing.Color.Green
            StatusBarStatusMessage.Name = "StatusBarStatusMessage"
            StatusBarStatusMessage.Size = New Drawing.Size(0, 17)
            StatusBarStatusMessage.TextAlign = Drawing.ContentAlignment.MiddleLeft
            ' 
            ' StatusBarErrorMessage
            ' 
            StatusBarErrorMessage.AutoToolTip = True
            StatusBarErrorMessage.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Text
            StatusBarErrorMessage.ForeColor = Drawing.Color.Red
            StatusBarErrorMessage.Name = "StatusBarErrorMessage"
            StatusBarErrorMessage.Size = New Drawing.Size(609, 17)
            StatusBarErrorMessage.Spring = True
            StatusBarErrorMessage.TextAlign = Drawing.ContentAlignment.MiddleLeft
            ' 
            ' StatusBarProgressBar
            ' 
            StatusBarProgressBar.Alignment = Windows.Forms.ToolStripItemAlignment.Right
            StatusBarProgressBar.Name = "StatusBarProgressBar"
            StatusBarProgressBar.Size = New Drawing.Size(100, 16)
            StatusBarProgressBar.Value = 10
            StatusBarProgressBar.Visible = False
            ' 
            ' StatusBarActionIcon
            ' 
            StatusBarActionIcon.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            StatusBarActionIcon.Image = CType(resources.GetObject("StatusBarActionIcon.Image"), Drawing.Image)
            StatusBarActionIcon.ImageAlign = Drawing.ContentAlignment.MiddleRight
            StatusBarActionIcon.Name = "StatusBarActionIcon"
            StatusBarActionIcon.Size = New Drawing.Size(16, 17)
            StatusBarActionIcon.Visible = False
            ' 
            ' StatusBarDirtyMessage
            ' 
            StatusBarDirtyMessage.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            StatusBarDirtyMessage.Image = CType(resources.GetObject("StatusBarDirtyMessage.Image"), Drawing.Image)
            StatusBarDirtyMessage.ImageAlign = Drawing.ContentAlignment.MiddleRight
            StatusBarDirtyMessage.Name = "StatusBarDirtyMessage"
            StatusBarDirtyMessage.Size = New Drawing.Size(16, 17)
            StatusBarDirtyMessage.ToolTipText = "Dirty"
            StatusBarDirtyMessage.Visible = False
            ' 
            ' StatusBarNetworkIndicator
            ' 
            StatusBarNetworkIndicator.DisplayStyle = Windows.Forms.ToolStripItemDisplayStyle.Image
            StatusBarNetworkIndicator.Image = CType(resources.GetObject("StatusBarNetworkIndicator.Image"), Drawing.Image)
            StatusBarNetworkIndicator.ImageAlign = Drawing.ContentAlignment.MiddleRight
            StatusBarNetworkIndicator.ImageTransparentColor = Drawing.Color.Fuchsia
            StatusBarNetworkIndicator.Name = "StatusBarNetworkIndicator"
            StatusBarNetworkIndicator.Size = New Drawing.Size(16, 17)
            StatusBarNetworkIndicator.ToolTipText = "Network Connected"
            StatusBarNetworkIndicator.Visible = False
            ' 
            ' StatusBarCustomMessage
            ' 
            StatusBarCustomMessage.Name = "StatusBarCustomMessage"
            StatusBarCustomMessage.Size = New Drawing.Size(0, 17)
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.Location = New Drawing.Point(31, 55)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(31, 13)
            label1.TabIndex = 119
            label1.Text = "Int32"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.Location = New Drawing.Point(31, 81)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(34, 13)
            label2.TabIndex = 120
            label2.Text = "String"
            ' 
            ' txtSomeInt
            ' 
            txtSomeInt.Location = New Drawing.Point(72, 52)
            txtSomeInt.Name = "txtSomeInt"
            txtSomeInt.Size = New Drawing.Size(100, 20)
            txtSomeInt.TabIndex = 122
            ' 
            ' txtSomeString
            ' 
            txtSomeString.Location = New Drawing.Point(72, 78)
            txtSomeString.Name = "txtSomeString"
            txtSomeString.Size = New Drawing.Size(100, 20)
            txtSomeString.TabIndex = 123
            ' 
            ' chkSomeBoolean
            ' 
            chkSomeBoolean.AutoSize = True
            chkSomeBoolean.CheckAlign = Drawing.ContentAlignment.MiddleRight
            chkSomeBoolean.Location = New Drawing.Point(21, 104)
            chkSomeBoolean.Name = "chkSomeBoolean"
            chkSomeBoolean.Size = New Drawing.Size(65, 17)
            chkSomeBoolean.TabIndex = 124
            chkSomeBoolean.Text = "Boolean"
            chkSomeBoolean.UseVisualStyleBackColor = True
            ' 
            ' cmdRun
            ' 
            cmdRun.Location = New Drawing.Point(537, 45)
            cmdRun.Name = "cmdRun"
            cmdRun.Size = New Drawing.Size(75, 23)
            cmdRun.TabIndex = 125
            cmdRun.Text = "Run"
            cmdRun.UseVisualStyleBackColor = True
            AddHandler cmdRun.Click, New EventHandler(AddressOf Me.cmdRun_Click)
            ' 
            ' chkSomeOtherBoolean
            ' 
            chkSomeOtherBoolean.AutoSize = True
            chkSomeOtherBoolean.CheckAlign = Drawing.ContentAlignment.MiddleRight
            chkSomeOtherBoolean.Location = New Drawing.Point(196, 104)
            chkSomeOtherBoolean.Name = "chkSomeOtherBoolean"
            chkSomeOtherBoolean.Size = New Drawing.Size(65, 17)
            chkSomeOtherBoolean.TabIndex = 130
            chkSomeOtherBoolean.Text = "Boolean"
            chkSomeOtherBoolean.UseVisualStyleBackColor = True
            ' 
            ' txtSomeOtherString
            ' 
            txtSomeOtherString.Location = New Drawing.Point(247, 78)
            txtSomeOtherString.Name = "txtSomeOtherString"
            txtSomeOtherString.Size = New Drawing.Size(100, 20)
            txtSomeOtherString.TabIndex = 129
            ' 
            ' txtSomeOtherInt
            ' 
            txtSomeOtherInt.Location = New Drawing.Point(247, 52)
            txtSomeOtherInt.Name = "txtSomeOtherInt"
            txtSomeOtherInt.Size = New Drawing.Size(100, 20)
            txtSomeOtherInt.TabIndex = 128
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.Location = New Drawing.Point(206, 81)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(34, 13)
            label3.TabIndex = 127
            label3.Text = "String"
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.Location = New Drawing.Point(206, 55)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(31, 13)
            label4.TabIndex = 126
            label4.Text = "Int32"
            ' 
            ' chkStillAnotherBoolean
            ' 
            chkStillAnotherBoolean.AutoSize = True
            chkStillAnotherBoolean.CheckAlign = Drawing.ContentAlignment.MiddleRight
            chkStillAnotherBoolean.Location = New Drawing.Point(368, 104)
            chkStillAnotherBoolean.Name = "chkStillAnotherBoolean"
            chkStillAnotherBoolean.Size = New Drawing.Size(65, 17)
            chkStillAnotherBoolean.TabIndex = 135
            chkStillAnotherBoolean.Text = "Boolean"
            chkStillAnotherBoolean.UseVisualStyleBackColor = True
            ' 
            ' txtStillAnotherString
            ' 
            txtStillAnotherString.Location = New Drawing.Point(419, 78)
            txtStillAnotherString.Name = "txtStillAnotherString"
            txtStillAnotherString.Size = New Drawing.Size(100, 20)
            txtStillAnotherString.TabIndex = 134
            ' 
            ' txtStillAnotherInt
            ' 
            txtStillAnotherInt.Location = New Drawing.Point(419, 52)
            txtStillAnotherInt.Name = "txtStillAnotherInt"
            txtStillAnotherInt.Size = New Drawing.Size(100, 20)
            txtStillAnotherInt.TabIndex = 133
            ' 
            ' lblStillAnotherString
            ' 
            lblStillAnotherString.AutoSize = True
            lblStillAnotherString.Location = New Drawing.Point(378, 81)
            lblStillAnotherString.Name = "lblStillAnotherString"
            lblStillAnotherString.Size = New Drawing.Size(34, 13)
            lblStillAnotherString.TabIndex = 132
            lblStillAnotherString.Text = "String"
            ' 
            ' lblStillAnotherInt
            ' 
            lblStillAnotherInt.AutoSize = True
            lblStillAnotherInt.Location = New Drawing.Point(378, 55)
            lblStillAnotherInt.Name = "lblStillAnotherInt"
            lblStillAnotherInt.Size = New Drawing.Size(31, 13)
            lblStillAnotherInt.TabIndex = 131
            lblStillAnotherInt.Text = "Int32"
            ' 
            ' MVCView
            ' 
            Me.AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New Drawing.Size(624, 442)
            Me.Controls.Add(chkStillAnotherBoolean)
            Me.Controls.Add(txtStillAnotherString)
            Me.Controls.Add(txtStillAnotherInt)
            Me.Controls.Add(lblStillAnotherString)
            Me.Controls.Add(lblStillAnotherInt)
            Me.Controls.Add(chkSomeOtherBoolean)
            Me.Controls.Add(txtSomeOtherString)
            Me.Controls.Add(txtSomeOtherInt)
            Me.Controls.Add(label3)
            Me.Controls.Add(label4)
            Me.Controls.Add(cmdRun)
            Me.Controls.Add(chkSomeBoolean)
            Me.Controls.Add(txtSomeString)
            Me.Controls.Add(txtSomeInt)
            Me.Controls.Add(label2)
            Me.Controls.Add(label1)
            Me.Controls.Add(toolbar)
            Me.Controls.Add(menu)
            Me.Controls.Add(statusBar)
            Me.Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Me.Name = "MVCView"
            Me.StartPosition = Windows.Forms.FormStartPosition.Manual
            Me.Text = "MVCView"
            AddHandler Me.FormClosing, New Windows.Forms.FormClosingEventHandler(AddressOf Me.View_FormClosing)
            AddHandler Me.Load, New EventHandler(AddressOf Me.View_Load)
            toolbar.ResumeLayout(False)
            toolbar.PerformLayout()
            menu.ResumeLayout(False)
            menu.PerformLayout()
            statusBar.ResumeLayout(False)
            statusBar.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region

        Private toolbar As Windows.Forms.ToolStrip
        Private buttonFileNew As Windows.Forms.ToolStripButton
        Private buttonFileOpen As Windows.Forms.ToolStripButton
        Private buttonFileSave As Windows.Forms.ToolStripButton
        Private buttonSeparator0 As Windows.Forms.ToolStripSeparator
        Private buttonEditCopyToClipboard As Windows.Forms.ToolStripButton
        Private buttonEditProperties As Windows.Forms.ToolStripButton
        Private menu As Windows.Forms.MenuStrip
        Private menuFile As Windows.Forms.ToolStripMenuItem
        Private menuFileNew As Windows.Forms.ToolStripMenuItem
        Private menuFileOpen As Windows.Forms.ToolStripMenuItem
        Private menuFileSave As Windows.Forms.ToolStripMenuItem
        Private menuFileSaveAs As Windows.Forms.ToolStripMenuItem
        Private menuFileSeparator2 As Windows.Forms.ToolStripSeparator
        Private menuFileExit As Windows.Forms.ToolStripMenuItem
        Private menuEdit As Windows.Forms.ToolStripMenuItem
        Private menuEditCopyToClipboard As Windows.Forms.ToolStripMenuItem
        Private menuEditSeparator0 As Windows.Forms.ToolStripSeparator
        Private menuEditProperties As Windows.Forms.ToolStripMenuItem
        Private menuHelp As Windows.Forms.ToolStripMenuItem
        Private menuHelpAbout As Windows.Forms.ToolStripMenuItem
        Private statusBar As Windows.Forms.StatusStrip
        Private StatusBarStatusMessage As Windows.Forms.ToolStripStatusLabel
        Private StatusBarErrorMessage As Windows.Forms.ToolStripStatusLabel
        Private StatusBarProgressBar As Windows.Forms.ToolStripProgressBar
        Private StatusBarActionIcon As Windows.Forms.ToolStripStatusLabel
        Private StatusBarDirtyMessage As Windows.Forms.ToolStripStatusLabel
        Private StatusBarNetworkIndicator As Windows.Forms.ToolStripStatusLabel
        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private txtSomeInt As Windows.Forms.TextBox
        Private txtSomeString As Windows.Forms.TextBox
        Private chkSomeBoolean As Windows.Forms.CheckBox
        Private cmdRun As Windows.Forms.Button
        Private chkSomeOtherBoolean As Windows.Forms.CheckBox
        Private txtSomeOtherString As Windows.Forms.TextBox
        Private txtSomeOtherInt As Windows.Forms.TextBox
        Private label3 As Windows.Forms.Label
        Private label4 As Windows.Forms.Label
        Private StatusBarCustomMessage As Windows.Forms.ToolStripStatusLabel
        Private chkStillAnotherBoolean As Windows.Forms.CheckBox
        Private txtStillAnotherString As Windows.Forms.TextBox
        Private txtStillAnotherInt As Windows.Forms.TextBox
        Private lblStillAnotherString As Windows.Forms.Label
        Private lblStillAnotherInt As Windows.Forms.Label
    End Class
End Namespace

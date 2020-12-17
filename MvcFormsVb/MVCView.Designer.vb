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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MVCView))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.cmdProcessBatch = New System.Windows.Forms.Button()
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.StatusBarStatusMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarErrorMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusBarActionIcon = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarDirtyMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarNetworkIndicator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarCustomMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SomeComponentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.SomeStringDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewRemarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsChangedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SomeComponentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SomeComponentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolbar.SuspendLayout()
        Me.menu_.SuspendLayout()
        Me.statusBar.SuspendLayout()
        CType(Me.SomeComponentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SomeComponentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SomeComponentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SomeComponentsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonFileNew, Me.buttonFileOpen, Me.buttonFileSave, Me.buttonSeparator0, Me.buttonEditCopyToClipboard, Me.buttonEditProperties})
        Me.toolbar.Location = New System.Drawing.Point(0, 24)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(632, 25)
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
        Me.menu_.Size = New System.Drawing.Size(632, 24)
        Me.menu_.TabIndex = 117
        Me.menu_.Text = "menuStrip1"
        '
        'menuFile
        '
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileNew, Me.menuFileOpen, Me.menuFileSave, Me.menuFileSaveAs, Me.menuFileSeparator2, Me.menuFileExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(35, 20)
        Me.menuFile.Text = "&File"
        '
        'menuFileNew
        '
        Me.menuFileNew.Image = CType(resources.GetObject("menuFileNew.Image"), System.Drawing.Image)
        Me.menuFileNew.Name = "menuFileNew"
        Me.menuFileNew.Size = New System.Drawing.Size(140, 22)
        Me.menuFileNew.Text = "&New"
        '
        'menuFileOpen
        '
        Me.menuFileOpen.Image = CType(resources.GetObject("menuFileOpen.Image"), System.Drawing.Image)
        Me.menuFileOpen.Name = "menuFileOpen"
        Me.menuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.menuFileOpen.Size = New System.Drawing.Size(140, 22)
        Me.menuFileOpen.Text = "&Open"
        '
        'menuFileSave
        '
        Me.menuFileSave.Image = CType(resources.GetObject("menuFileSave.Image"), System.Drawing.Image)
        Me.menuFileSave.Name = "menuFileSave"
        Me.menuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menuFileSave.Size = New System.Drawing.Size(140, 22)
        Me.menuFileSave.Text = "&Save"
        '
        'menuFileSaveAs
        '
        Me.menuFileSaveAs.Name = "menuFileSaveAs"
        Me.menuFileSaveAs.Size = New System.Drawing.Size(140, 22)
        Me.menuFileSaveAs.Text = "Save &As..."
        '
        'menuFileSeparator2
        '
        Me.menuFileSeparator2.Name = "menuFileSeparator2"
        Me.menuFileSeparator2.Size = New System.Drawing.Size(137, 6)
        '
        'menuFileExit
        '
        Me.menuFileExit.Name = "menuFileExit"
        Me.menuFileExit.Size = New System.Drawing.Size(140, 22)
        Me.menuFileExit.Text = "E&xit"
        '
        'menuEdit
        '
        Me.menuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEditCopyToClipboard, Me.menuEditSeparator0, Me.menuEditProperties})
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(37, 20)
        Me.menuEdit.Text = "&Edit"
        '
        'menuEditCopyToClipboard
        '
        Me.menuEditCopyToClipboard.Image = CType(resources.GetObject("menuEditCopyToClipboard.Image"), System.Drawing.Image)
        Me.menuEditCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuEditCopyToClipboard.Name = "menuEditCopyToClipboard"
        Me.menuEditCopyToClipboard.Size = New System.Drawing.Size(160, 22)
        Me.menuEditCopyToClipboard.Text = "&Copy to Clipboard"
        '
        'menuEditSeparator0
        '
        Me.menuEditSeparator0.Name = "menuEditSeparator0"
        Me.menuEditSeparator0.Size = New System.Drawing.Size(157, 6)
        '
        'menuEditProperties
        '
        Me.menuEditProperties.Image = CType(resources.GetObject("menuEditProperties.Image"), System.Drawing.Image)
        Me.menuEditProperties.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuEditProperties.Name = "menuEditProperties"
        Me.menuEditProperties.Size = New System.Drawing.Size(160, 22)
        Me.menuEditProperties.Text = "P&roperties..."
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpAbout})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(40, 20)
        Me.menuHelp.Text = "&Help"
        Me.menuHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'menuHelpAbout
        '
        Me.menuHelpAbout.Name = "menuHelpAbout"
        Me.menuHelpAbout.Size = New System.Drawing.Size(171, 22)
        Me.menuHelpAbout.Text = "&About MVCForms ..."
        '
        'cmdProcessBatch
        '
        Me.cmdProcessBatch.Location = New System.Drawing.Point(194, 57)
        Me.cmdProcessBatch.Name = "cmdProcessBatch"
        Me.cmdProcessBatch.Size = New System.Drawing.Size(75, 23)
        Me.cmdProcessBatch.TabIndex = 125
        Me.cmdProcessBatch.Text = "&Process Batch"
        Me.cmdProcessBatch.UseVisualStyleBackColor = True
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarStatusMessage, Me.StatusBarErrorMessage, Me.StatusBarProgressBar, Me.StatusBarActionIcon, Me.StatusBarDirtyMessage, Me.StatusBarNetworkIndicator, Me.StatusBarCustomMessage})
        Me.statusBar.Location = New System.Drawing.Point(0, 431)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(632, 22)
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
        Me.StatusBarErrorMessage.Size = New System.Drawing.Size(617, 17)
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
        'SomeComponentsDataGridView
        '
        Me.SomeComponentsDataGridView.AllowUserToAddRows = False
        Me.SomeComponentsDataGridView.AllowUserToDeleteRows = False
        Me.SomeComponentsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SomeComponentsDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SomeComponentsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SomeComponentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SomeComponentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SomeStringDataGridViewTextBoxColumn, Me.RemarkDataGridViewTextBoxColumn, Me.NewRemarkDataGridViewTextBoxColumn, Me.IsChangedDataGridViewCheckBoxColumn})
        Me.SomeComponentsDataGridView.DataSource = Me.SomeComponentsBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SomeComponentsDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.SomeComponentsDataGridView.Location = New System.Drawing.Point(27, 170)
        Me.SomeComponentsDataGridView.Name = "SomeComponentsDataGridView"
        Me.SomeComponentsDataGridView.ReadOnly = True
        Me.SomeComponentsDataGridView.Size = New System.Drawing.Size(468, 219)
        Me.SomeComponentsDataGridView.TabIndex = 137
        '
        'SomeStringDataGridViewTextBoxColumn
        '
        Me.SomeStringDataGridViewTextBoxColumn.DataPropertyName = "SomeString"
        Me.SomeStringDataGridViewTextBoxColumn.HeaderText = "SomeString"
        Me.SomeStringDataGridViewTextBoxColumn.Name = "SomeStringDataGridViewTextBoxColumn"
        Me.SomeStringDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarkDataGridViewTextBoxColumn
        '
        Me.RemarkDataGridViewTextBoxColumn.DataPropertyName = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.HeaderText = "Remark"
        Me.RemarkDataGridViewTextBoxColumn.Name = "RemarkDataGridViewTextBoxColumn"
        Me.RemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NewRemarkDataGridViewTextBoxColumn
        '
        Me.NewRemarkDataGridViewTextBoxColumn.DataPropertyName = "NewRemark"
        Me.NewRemarkDataGridViewTextBoxColumn.HeaderText = "NewRemark"
        Me.NewRemarkDataGridViewTextBoxColumn.Name = "NewRemarkDataGridViewTextBoxColumn"
        Me.NewRemarkDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsChangedDataGridViewCheckBoxColumn
        '
        Me.IsChangedDataGridViewCheckBoxColumn.DataPropertyName = "IsChanged"
        Me.IsChangedDataGridViewCheckBoxColumn.HeaderText = "IsChanged"
        Me.IsChangedDataGridViewCheckBoxColumn.Name = "IsChangedDataGridViewCheckBoxColumn"
        Me.IsChangedDataGridViewCheckBoxColumn.ReadOnly = True
        Me.IsChangedDataGridViewCheckBoxColumn.Visible = False
        '
        'SomeComponentsBindingSource
        '
        Me.SomeComponentsBindingSource.DataSource = GetType(ModelComponent)
        '
        'SomeComponentsBindingNavigator
        '
        Me.SomeComponentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SomeComponentsBindingNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SomeComponentsBindingNavigator.BindingSource = Me.SomeComponentsBindingSource
        Me.SomeComponentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SomeComponentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SomeComponentsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.SomeComponentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.SomeComponentsBindingNavigator.Location = New System.Drawing.Point(27, 392)
        Me.SomeComponentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SomeComponentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SomeComponentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SomeComponentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SomeComponentsBindingNavigator.Name = "SomeComponentsBindingNavigator"
        Me.SomeComponentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SomeComponentsBindingNavigator.Size = New System.Drawing.Size(254, 25)
        Me.SomeComponentsBindingNavigator.TabIndex = 138
        Me.SomeComponentsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MVCView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.SomeComponentsBindingNavigator)
        Me.Controls.Add(Me.SomeComponentsDataGridView)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.cmdProcessBatch)
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
        CType(Me.SomeComponentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SomeComponentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SomeComponentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SomeComponentsBindingNavigator.ResumeLayout(False)
        Me.SomeComponentsBindingNavigator.PerformLayout()
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
    Private WithEvents cmdProcessBatch As System.Windows.Forms.Button
    Private WithEvents statusBar As System.Windows.Forms.StatusStrip
    Private WithEvents StatusBarStatusMessage As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarErrorMessage As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarProgressBar As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents StatusBarActionIcon As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarDirtyMessage As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarNetworkIndicator As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents StatusBarCustomMessage As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SomeComponentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents SomeComponentsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SomeComponentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DirtyDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SomeOtherIntDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SomeOtherBooleanDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SomeOtherStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SomeStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NewRemarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsChangedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
'End Namespace


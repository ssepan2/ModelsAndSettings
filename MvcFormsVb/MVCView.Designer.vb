Imports System.ComponentModel
Imports System.Windows.Forms
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
    ''' Required method for Designer support
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MVCView))
        Me.toolbar = New System.Windows.Forms.ToolStrip()
        Me.buttonFileNew = New System.Windows.Forms.ToolStripButton()
        Me.buttonFileOpen = New System.Windows.Forms.ToolStripButton()
        Me.buttonFileSave = New System.Windows.Forms.ToolStripButton()
        Me.buttonFilePrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.buttonEditUndo = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditRedo = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditCut = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditCopy = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditPaste = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditDelete = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditFind = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditReplace = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditRefresh = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditPreferences = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditProperties = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.buttonHelpContents = New System.Windows.Forms.ToolStripButton()
        Me.buttonSeparator0 = New System.Windows.Forms.ToolStripSeparator()
        Me.menu_ = New System.Windows.Forms.MenuStrip()
        Me.menuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuFileSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditSeparator0 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuEditSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuEditFind = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditReplace = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuEditRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuEditPreferences = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuEditProperties = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpIndex = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpOnlineHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpSeparator0 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuHelpLicenceInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpCheckForUpdates = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuHelpSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusBar = New System.Windows.Forms.StatusStrip()
        Me.StatusBarStatusMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarErrorMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.StatusBarActionIcon = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarDirtyMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarNetworkIndicator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBarCustomMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.txtSomeInt = New System.Windows.Forms.TextBox()
        Me.txtSomeString = New System.Windows.Forms.TextBox()
        Me.chkSomeBoolean = New System.Windows.Forms.CheckBox()
        Me.cmdRun = New System.Windows.Forms.Button()
        Me.chkSomeOtherBoolean = New System.Windows.Forms.CheckBox()
        Me.txtSomeOtherString = New System.Windows.Forms.TextBox()
        Me.txtSomeOtherInt = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.chkStillAnotherBoolean = New System.Windows.Forms.CheckBox()
        Me.txtStillAnotherString = New System.Windows.Forms.TextBox()
        Me.txtStillAnotherInt = New System.Windows.Forms.TextBox()
        Me.lblStillAnotherString = New System.Windows.Forms.Label()
        Me.lblStillAnotherInt = New System.Windows.Forms.Label()
        Me.toolbar.SuspendLayout()
        Me.menu_.SuspendLayout()
        Me.statusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonFileNew, Me.buttonFileOpen, Me.buttonFileSave, Me.buttonFilePrint, Me.ToolStripSeparator1, Me.buttonEditUndo, Me.buttonEditRedo, Me.buttonEditCut, Me.buttonEditCopy, Me.buttonEditPaste, Me.buttonEditDelete, Me.buttonEditFind, Me.buttonEditReplace, Me.buttonEditRefresh, Me.buttonEditPreferences, Me.buttonEditProperties, Me.ToolStripSeparator2, Me.buttonHelpContents})
        Me.toolbar.Location = New System.Drawing.Point(0, 24)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(624, 25)
        Me.toolbar.TabIndex = 118
        Me.toolbar.Text = "toolStrip1"
        '
        'buttonFileNew
        '
        Me.buttonFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFileNew.Image = Global.My.Resources.Resources._New
        Me.buttonFileNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFileNew.Name = "buttonFileNew"
        Me.buttonFileNew.Size = New System.Drawing.Size(23, 22)
        Me.buttonFileNew.Text = "&New"
        '
        'buttonFileOpen
        '
        Me.buttonFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFileOpen.Image = Global.My.Resources.Resources.Open
        Me.buttonFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFileOpen.Name = "buttonFileOpen"
        Me.buttonFileOpen.Size = New System.Drawing.Size(23, 22)
        Me.buttonFileOpen.Text = "&Open"
        '
        'buttonFileSave
        '
        Me.buttonFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFileSave.Image = Global.My.Resources.Resources.Save
        Me.buttonFileSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFileSave.Name = "buttonFileSave"
        Me.buttonFileSave.Size = New System.Drawing.Size(23, 22)
        Me.buttonFileSave.Text = "&Save"
        '
        'buttonFilePrint
        '
        Me.buttonFilePrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFilePrint.Image = Global.My.Resources.Resources.Print
        Me.buttonFilePrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFilePrint.Name = "buttonFilePrint"
        Me.buttonFilePrint.Size = New System.Drawing.Size(23, 22)
        Me.buttonFilePrint.Text = "Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'buttonEditUndo
        '
        Me.buttonEditUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditUndo.Image = Global.My.Resources.Resources.Undo
        Me.buttonEditUndo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditUndo.Name = "buttonEditUndo"
        Me.buttonEditUndo.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditUndo.Text = "Undo"
        '
        'buttonEditRedo
        '
        Me.buttonEditRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditRedo.Image = Global.My.Resources.Resources.Redo
        Me.buttonEditRedo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditRedo.Name = "buttonEditRedo"
        Me.buttonEditRedo.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditRedo.Text = "Redo"
        '
        'buttonEditCut
        '
        Me.buttonEditCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditCut.Image = Global.My.Resources.Resources.Cut
        Me.buttonEditCut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditCut.Name = "buttonEditCut"
        Me.buttonEditCut.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditCut.Text = "Cut"
        '
        'buttonEditCopy
        '
        Me.buttonEditCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditCopy.Image = Global.My.Resources.Resources.Copy
        Me.buttonEditCopy.ImageTransparentColor = System.Drawing.Color.Black
        Me.buttonEditCopy.Name = "buttonEditCopy"
        Me.buttonEditCopy.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditCopy.Text = "Copy"
        '
        'buttonEditPaste
        '
        Me.buttonEditPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditPaste.Image = Global.My.Resources.Resources.Paste
        Me.buttonEditPaste.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditPaste.Name = "buttonEditPaste"
        Me.buttonEditPaste.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditPaste.Text = "Paste"
        '
        'buttonEditDelete
        '
        Me.buttonEditDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditDelete.Image = Global.My.Resources.Resources.Delete
        Me.buttonEditDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditDelete.Name = "buttonEditDelete"
        Me.buttonEditDelete.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditDelete.Text = "Delete"
        '
        'buttonEditFind
        '
        Me.buttonEditFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditFind.Image = Global.My.Resources.Resources.Find
        Me.buttonEditFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditFind.Name = "buttonEditFind"
        Me.buttonEditFind.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditFind.Text = "Find"
        '
        'buttonEditReplace
        '
        Me.buttonEditReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditReplace.Image = Global.My.Resources.Resources.Replace
        Me.buttonEditReplace.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditReplace.Name = "buttonEditReplace"
        Me.buttonEditReplace.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditReplace.Text = "Replace"
        '
        'buttonEditRefresh
        '
        Me.buttonEditRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditRefresh.Image = Global.My.Resources.Resources.Reload
        Me.buttonEditRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditRefresh.Name = "buttonEditRefresh"
        Me.buttonEditRefresh.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditRefresh.Text = "Refresh"
        '
        'buttonEditPreferences
        '
        Me.buttonEditPreferences.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditPreferences.Image = Global.My.Resources.Resources.Preferences
        Me.buttonEditPreferences.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditPreferences.Name = "buttonEditPreferences"
        Me.buttonEditPreferences.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditPreferences.Text = "Preferences"
        '
        'buttonEditProperties
        '
        Me.buttonEditProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonEditProperties.Image = Global.My.Resources.Resources.Properties
        Me.buttonEditProperties.ImageTransparentColor = System.Drawing.Color.Black
        Me.buttonEditProperties.Name = "buttonEditProperties"
        Me.buttonEditProperties.Size = New System.Drawing.Size(23, 22)
        Me.buttonEditProperties.Text = "P&roperties..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'buttonHelpContents
        '
        Me.buttonHelpContents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonHelpContents.Image = Global.My.Resources.Resources.Contents
        Me.buttonHelpContents.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonHelpContents.Name = "buttonHelpContents"
        Me.buttonHelpContents.Size = New System.Drawing.Size(23, 22)
        Me.buttonHelpContents.Text = "Contents"
        '
        'buttonSeparator0
        '
        Me.buttonSeparator0.Name = "buttonSeparator0"
        Me.buttonSeparator0.Size = New System.Drawing.Size(6, 25)
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
        Me.menuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuFileNew, Me.menuFileOpen, Me.menuFileSave, Me.menuFileSaveAs, Me.menuFileSeparator2, Me.menuFilePrint, Me.menuFileSeparator3, Me.menuFileExit})
        Me.menuFile.Name = "menuFile"
        Me.menuFile.Size = New System.Drawing.Size(37, 20)
        Me.menuFile.Text = "&File"
        '
        'menuFileNew
        '
        Me.menuFileNew.Image = CType(resources.GetObject("menuFileNew.Image"), System.Drawing.Image)
        Me.menuFileNew.Name = "menuFileNew"
        Me.menuFileNew.Size = New System.Drawing.Size(149, 22)
        Me.menuFileNew.Text = "&New"
        '
        'menuFileOpen
        '
        Me.menuFileOpen.Image = CType(resources.GetObject("menuFileOpen.Image"), System.Drawing.Image)
        Me.menuFileOpen.Name = "menuFileOpen"
        Me.menuFileOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.menuFileOpen.Size = New System.Drawing.Size(149, 22)
        Me.menuFileOpen.Text = "&Open"
        '
        'menuFileSave
        '
        Me.menuFileSave.Image = CType(resources.GetObject("menuFileSave.Image"), System.Drawing.Image)
        Me.menuFileSave.Name = "menuFileSave"
        Me.menuFileSave.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.menuFileSave.Size = New System.Drawing.Size(149, 22)
        Me.menuFileSave.Text = "&Save"
        '
        'menuFileSaveAs
        '
        Me.menuFileSaveAs.Name = "menuFileSaveAs"
        Me.menuFileSaveAs.Size = New System.Drawing.Size(149, 22)
        Me.menuFileSaveAs.Text = "Save &As..."
        '
        'menuFileSeparator2
        '
        Me.menuFileSeparator2.Name = "menuFileSeparator2"
        Me.menuFileSeparator2.Size = New System.Drawing.Size(146, 6)
        '
        'menuFilePrint
        '
        Me.menuFilePrint.Image = Global.My.Resources.Resources.Print
        Me.menuFilePrint.Name = "menuFilePrint"
        Me.menuFilePrint.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.menuFilePrint.Size = New System.Drawing.Size(149, 22)
        Me.menuFilePrint.Text = "&Print..."
        '
        'menuFileSeparator3
        '
        Me.menuFileSeparator3.Name = "menuFileSeparator3"
        Me.menuFileSeparator3.Size = New System.Drawing.Size(146, 6)
        '
        'menuFileExit
        '
        Me.menuFileExit.Name = "menuFileExit"
        Me.menuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.menuFileExit.Size = New System.Drawing.Size(149, 22)
        Me.menuFileExit.Text = "E&xit"
        '
        'menuEdit
        '
        Me.menuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuEditUndo, Me.menuEditRedo, Me.menuEditSeparator0, Me.menuEditSelectAll, Me.menuEditCut, Me.menuEditCopy, Me.menuEditPaste, Me.menuEditDelete, Me.menuEditSeparator1, Me.menuEditFind, Me.menuEditReplace, Me.menuEditSeparator2, Me.menuEditRefresh, Me.menuEditSeparator3, Me.menuEditPreferences, Me.menuEditProperties})
        Me.menuEdit.Name = "menuEdit"
        Me.menuEdit.Size = New System.Drawing.Size(39, 20)
        Me.menuEdit.Text = "&Edit"
        '
        'menuEditUndo
        '
        Me.menuEditUndo.Image = Global.My.Resources.Resources.Undo
        Me.menuEditUndo.Name = "menuEditUndo"
        Me.menuEditUndo.Size = New System.Drawing.Size(144, 22)
        Me.menuEditUndo.Text = "&Undo"
        '
        'menuEditRedo
        '
        Me.menuEditRedo.Image = Global.My.Resources.Resources.Redo
        Me.menuEditRedo.Name = "menuEditRedo"
        Me.menuEditRedo.Size = New System.Drawing.Size(144, 22)
        Me.menuEditRedo.Text = "&Redo"
        '
        'menuEditSeparator0
        '
        Me.menuEditSeparator0.Name = "menuEditSeparator0"
        Me.menuEditSeparator0.Size = New System.Drawing.Size(141, 6)
        '
        'menuEditSelectAll
        '
        Me.menuEditSelectAll.Name = "menuEditSelectAll"
        Me.menuEditSelectAll.Size = New System.Drawing.Size(144, 22)
        Me.menuEditSelectAll.Text = "Select &All"
        '
        'menuEditCut
        '
        Me.menuEditCut.Image = Global.My.Resources.Resources.Cut
        Me.menuEditCut.Name = "menuEditCut"
        Me.menuEditCut.Size = New System.Drawing.Size(144, 22)
        Me.menuEditCut.Text = "Cu&t"
        '
        'menuEditCopy
        '
        Me.menuEditCopy.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuEditCopy.Name = "menuEditCopy"
        Me.menuEditCopy.Size = New System.Drawing.Size(144, 22)
        Me.menuEditCopy.Text = "&Copy"
        '
        'menuEditPaste
        '
        Me.menuEditPaste.Image = Global.My.Resources.Resources.Paste
        Me.menuEditPaste.Name = "menuEditPaste"
        Me.menuEditPaste.Size = New System.Drawing.Size(144, 22)
        Me.menuEditPaste.Text = "&Paste"
        '
        'menuEditDelete
        '
        Me.menuEditDelete.Image = Global.My.Resources.Resources.Delete
        Me.menuEditDelete.Name = "menuEditDelete"
        Me.menuEditDelete.Size = New System.Drawing.Size(144, 22)
        Me.menuEditDelete.Text = "&Delete"
        '
        'menuEditSeparator1
        '
        Me.menuEditSeparator1.Name = "menuEditSeparator1"
        Me.menuEditSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        'menuEditFind
        '
        Me.menuEditFind.Image = Global.My.Resources.Resources.Find
        Me.menuEditFind.Name = "menuEditFind"
        Me.menuEditFind.Size = New System.Drawing.Size(144, 22)
        Me.menuEditFind.Text = "&Find..."
        '
        'menuEditReplace
        '
        Me.menuEditReplace.Image = Global.My.Resources.Resources.Replace
        Me.menuEditReplace.Name = "menuEditReplace"
        Me.menuEditReplace.Size = New System.Drawing.Size(144, 22)
        Me.menuEditReplace.Text = "&Replace..."
        '
        'menuEditSeparator2
        '
        Me.menuEditSeparator2.Name = "menuEditSeparator2"
        Me.menuEditSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        'menuEditRefresh
        '
        Me.menuEditRefresh.Image = Global.My.Resources.Resources.Reload
        Me.menuEditRefresh.Name = "menuEditRefresh"
        Me.menuEditRefresh.Size = New System.Drawing.Size(144, 22)
        Me.menuEditRefresh.Text = "R&efresh"
        '
        'menuEditSeparator3
        '
        Me.menuEditSeparator3.Name = "menuEditSeparator3"
        Me.menuEditSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'menuEditPreferences
        '
        Me.menuEditPreferences.Image = Global.My.Resources.Resources.Preferences
        Me.menuEditPreferences.Name = "menuEditPreferences"
        Me.menuEditPreferences.Size = New System.Drawing.Size(144, 22)
        Me.menuEditPreferences.Text = "Prefere&nces..."
        '
        'menuEditProperties
        '
        Me.menuEditProperties.Image = CType(resources.GetObject("menuEditProperties.Image"), System.Drawing.Image)
        Me.menuEditProperties.ImageTransparentColor = System.Drawing.Color.Black
        Me.menuEditProperties.Name = "menuEditProperties"
        Me.menuEditProperties.Size = New System.Drawing.Size(144, 22)
        Me.menuEditProperties.Text = "Pr&operties..."
        '
        'menuHelp
        '
        Me.menuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuHelpContents, Me.menuHelpIndex, Me.menuHelpOnlineHelp, Me.menuHelpSeparator0, Me.menuHelpLicenceInformation, Me.menuHelpCheckForUpdates, Me.menuHelpSeparator1, Me.menuHelpAbout})
        Me.menuHelp.Name = "menuHelp"
        Me.menuHelp.Size = New System.Drawing.Size(44, 20)
        Me.menuHelp.Text = "&Help"
        Me.menuHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'menuHelpContents
        '
        Me.menuHelpContents.Image = Global.My.Resources.Resources.Contents
        Me.menuHelpContents.Name = "menuHelpContents"
        Me.menuHelpContents.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.menuHelpContents.Size = New System.Drawing.Size(181, 22)
        Me.menuHelpContents.Text = "&Contents"
        '
        'menuHelpIndex
        '
        Me.menuHelpIndex.Name = "menuHelpIndex"
        Me.menuHelpIndex.Size = New System.Drawing.Size(181, 22)
        Me.menuHelpIndex.Text = "&Index"
        '
        'menuHelpOnlineHelp
        '
        Me.menuHelpOnlineHelp.Name = "menuHelpOnlineHelp"
        Me.menuHelpOnlineHelp.Size = New System.Drawing.Size(181, 22)
        Me.menuHelpOnlineHelp.Text = "&Online Help"
        '
        'menuHelpSeparator0
        '
        Me.menuHelpSeparator0.Name = "menuHelpSeparator0"
        Me.menuHelpSeparator0.Size = New System.Drawing.Size(178, 6)
        '
        'menuHelpLicenceInformation
        '
        Me.menuHelpLicenceInformation.Name = "menuHelpLicenceInformation"
        Me.menuHelpLicenceInformation.Size = New System.Drawing.Size(181, 22)
        Me.menuHelpLicenceInformation.Text = "&Licence Information"
        '
        'menuHelpCheckForUpdates
        '
        Me.menuHelpCheckForUpdates.Name = "menuHelpCheckForUpdates"
        Me.menuHelpCheckForUpdates.Size = New System.Drawing.Size(181, 22)
        Me.menuHelpCheckForUpdates.Text = "Check for &Updates"
        '
        'menuHelpSeparator1
        '
        Me.menuHelpSeparator1.Name = "menuHelpSeparator1"
        Me.menuHelpSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'menuHelpAbout
        '
        Me.menuHelpAbout.Image = Global.My.Resources.Resources.About
        Me.menuHelpAbout.Name = "menuHelpAbout"
        Me.menuHelpAbout.Size = New System.Drawing.Size(181, 22)
        Me.menuHelpAbout.Text = "&About MVCForms ..."
        '
        'statusBar
        '
        Me.statusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusBarStatusMessage, Me.StatusBarErrorMessage, Me.StatusBarProgressBar, Me.StatusBarActionIcon, Me.StatusBarDirtyMessage, Me.StatusBarNetworkIndicator})
        Me.statusBar.Location = New System.Drawing.Point(0, 420)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.Size = New System.Drawing.Size(624, 22)
        Me.statusBar.TabIndex = 116
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
        Me.StatusBarErrorMessage.Size = New System.Drawing.Size(609, 17)
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
        Me.StatusBarNetworkIndicator.Image = Global.My.Resources.Resources.Network
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
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(31, 55)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(31, 13)
        Me.label1.TabIndex = 119
        Me.label1.Text = "Int32"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(31, 81)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(34, 13)
        Me.label2.TabIndex = 120
        Me.label2.Text = "String"
        '
        'txtSomeInt
        '
        Me.txtSomeInt.Location = New System.Drawing.Point(72, 52)
        Me.txtSomeInt.Name = "txtSomeInt"
        Me.txtSomeInt.Size = New System.Drawing.Size(100, 20)
        Me.txtSomeInt.TabIndex = 122
        '
        'txtSomeString
        '
        Me.txtSomeString.Location = New System.Drawing.Point(72, 78)
        Me.txtSomeString.Name = "txtSomeString"
        Me.txtSomeString.Size = New System.Drawing.Size(100, 20)
        Me.txtSomeString.TabIndex = 123
        '
        'chkSomeBoolean
        '
        Me.chkSomeBoolean.AutoSize = True
        Me.chkSomeBoolean.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSomeBoolean.Location = New System.Drawing.Point(21, 104)
        Me.chkSomeBoolean.Name = "chkSomeBoolean"
        Me.chkSomeBoolean.Size = New System.Drawing.Size(65, 17)
        Me.chkSomeBoolean.TabIndex = 124
        Me.chkSomeBoolean.Text = "Boolean"
        Me.chkSomeBoolean.UseVisualStyleBackColor = True
        '
        'cmdRun
        '
        Me.cmdRun.Location = New System.Drawing.Point(537, 45)
        Me.cmdRun.Name = "cmdRun"
        Me.cmdRun.Size = New System.Drawing.Size(75, 23)
        Me.cmdRun.TabIndex = 125
        Me.cmdRun.Text = "Run"
        Me.cmdRun.UseVisualStyleBackColor = True
        '
        'chkSomeOtherBoolean
        '
        Me.chkSomeOtherBoolean.AutoSize = True
        Me.chkSomeOtherBoolean.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSomeOtherBoolean.Location = New System.Drawing.Point(196, 104)
        Me.chkSomeOtherBoolean.Name = "chkSomeOtherBoolean"
        Me.chkSomeOtherBoolean.Size = New System.Drawing.Size(65, 17)
        Me.chkSomeOtherBoolean.TabIndex = 130
        Me.chkSomeOtherBoolean.Text = "Boolean"
        Me.chkSomeOtherBoolean.UseVisualStyleBackColor = True
        '
        'txtSomeOtherString
        '
        Me.txtSomeOtherString.Location = New System.Drawing.Point(247, 78)
        Me.txtSomeOtherString.Name = "txtSomeOtherString"
        Me.txtSomeOtherString.Size = New System.Drawing.Size(100, 20)
        Me.txtSomeOtherString.TabIndex = 129
        '
        'txtSomeOtherInt
        '
        Me.txtSomeOtherInt.Location = New System.Drawing.Point(247, 52)
        Me.txtSomeOtherInt.Name = "txtSomeOtherInt"
        Me.txtSomeOtherInt.Size = New System.Drawing.Size(100, 20)
        Me.txtSomeOtherInt.TabIndex = 128
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(206, 81)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(34, 13)
        Me.label3.TabIndex = 127
        Me.label3.Text = "String"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(206, 55)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(31, 13)
        Me.label4.TabIndex = 126
        Me.label4.Text = "Int32"
        '
        'chkStillAnotherBoolean
        '
        Me.chkStillAnotherBoolean.AutoSize = True
        Me.chkStillAnotherBoolean.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStillAnotherBoolean.Location = New System.Drawing.Point(368, 104)
        Me.chkStillAnotherBoolean.Name = "chkStillAnotherBoolean"
        Me.chkStillAnotherBoolean.Size = New System.Drawing.Size(65, 17)
        Me.chkStillAnotherBoolean.TabIndex = 135
        Me.chkStillAnotherBoolean.Text = "Boolean"
        Me.chkStillAnotherBoolean.UseVisualStyleBackColor = True
        '
        'txtStillAnotherString
        '
        Me.txtStillAnotherString.Location = New System.Drawing.Point(419, 78)
        Me.txtStillAnotherString.Name = "txtStillAnotherString"
        Me.txtStillAnotherString.Size = New System.Drawing.Size(100, 20)
        Me.txtStillAnotherString.TabIndex = 134
        '
        'txtStillAnotherInt
        '
        Me.txtStillAnotherInt.Location = New System.Drawing.Point(419, 52)
        Me.txtStillAnotherInt.Name = "txtStillAnotherInt"
        Me.txtStillAnotherInt.Size = New System.Drawing.Size(100, 20)
        Me.txtStillAnotherInt.TabIndex = 133
        '
        'lblStillAnotherString
        '
        Me.lblStillAnotherString.AutoSize = True
        Me.lblStillAnotherString.Location = New System.Drawing.Point(378, 81)
        Me.lblStillAnotherString.Name = "lblStillAnotherString"
        Me.lblStillAnotherString.Size = New System.Drawing.Size(34, 13)
        Me.lblStillAnotherString.TabIndex = 132
        Me.lblStillAnotherString.Text = "String"
        '
        'lblStillAnotherInt
        '
        Me.lblStillAnotherInt.AutoSize = True
        Me.lblStillAnotherInt.Location = New System.Drawing.Point(378, 55)
        Me.lblStillAnotherInt.Name = "lblStillAnotherInt"
        Me.lblStillAnotherInt.Size = New System.Drawing.Size(31, 13)
        Me.lblStillAnotherInt.TabIndex = 131
        Me.lblStillAnotherInt.Text = "Int32"
        '
        'MVCView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.chkStillAnotherBoolean)
        Me.Controls.Add(Me.txtStillAnotherString)
        Me.Controls.Add(Me.txtStillAnotherInt)
        Me.Controls.Add(Me.lblStillAnotherString)
        Me.Controls.Add(Me.lblStillAnotherInt)
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
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.menu_)
        Me.Controls.Add(Me.statusBar)
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

    Private toolbar As Windows.Forms.ToolStrip
    Private WithEvents buttonFileNew As Windows.Forms.ToolStripButton
    Private WithEvents buttonFileOpen As Windows.Forms.ToolStripButton
    Private WithEvents buttonFileSave As Windows.Forms.ToolStripButton
    Private buttonSeparator0 As Windows.Forms.ToolStripSeparator
    Private WithEvents buttonEditCopy As Windows.Forms.ToolStripButton
    Private WithEvents buttonEditProperties As Windows.Forms.ToolStripButton
    Private menu_ As Windows.Forms.MenuStrip
    Private menuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuFileNew As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuFileSave As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Private menuFileSeparator2 As Windows.Forms.ToolStripSeparator
    Private WithEvents menuFileExit As System.Windows.Forms.ToolStripMenuItem
    Private menuEdit As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuEditCopy As System.Windows.Forms.ToolStripMenuItem
    Private menuEditSeparator0 As Windows.Forms.ToolStripSeparator
    Private WithEvents menuEditProperties As System.Windows.Forms.ToolStripMenuItem
    Private menuHelp As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents menuHelpAbout As System.Windows.Forms.ToolStripMenuItem
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
    Private WithEvents cmdRun As Windows.Forms.Button
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
    Friend WithEvents menuFileSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuHelpSeparator0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuHelpSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuFilePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuEditSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuEditSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuHelpContents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpIndex As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpOnlineHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpLicenceInformation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuHelpCheckForUpdates As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditUndo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditRedo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditCut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditPaste As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditFind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditReplace As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuEditPreferences As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents buttonFilePrint As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditUndo As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditRedo As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditCut As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditPaste As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditDelete As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditFind As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditReplace As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditRefresh As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonEditPreferences As System.Windows.Forms.ToolStripButton
    Private WithEvents buttonHelpContents As System.Windows.Forms.ToolStripButton
End Class
'End Namespace


namespace MVCForms
{
    partial class MVCView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MVCView));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.buttonFileNew = new System.Windows.Forms.ToolStripButton();
            this.buttonFileOpen = new System.Windows.Forms.ToolStripButton();
            this.buttonFileSave = new System.Windows.Forms.ToolStripButton();
            this.buttonSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonEditCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.buttonEditProperties = new System.Windows.Forms.ToolStripButton();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditCopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarErrorMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusBarActionIcon = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarDirtyMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarNetworkIndicator = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarCustomMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSomeInt = new System.Windows.Forms.TextBox();
            this.txtSomeString = new System.Windows.Forms.TextBox();
            this.chkSomeBoolean = new System.Windows.Forms.CheckBox();
            this.cmdRun = new System.Windows.Forms.Button();
            this.chkSomeOtherBoolean = new System.Windows.Forms.CheckBox();
            this.txtSomeOtherString = new System.Windows.Forms.TextBox();
            this.txtSomeOtherInt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkStillAnotherBoolean = new System.Windows.Forms.CheckBox();
            this.txtStillAnotherString = new System.Windows.Forms.TextBox();
            this.txtStillAnotherInt = new System.Windows.Forms.TextBox();
            this.lblStillAnotherString = new System.Windows.Forms.Label();
            this.lblStillAnotherInt = new System.Windows.Forms.Label();
            this.toolbar.SuspendLayout();
            this.menu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonFileNew,
            this.buttonFileOpen,
            this.buttonFileSave,
            this.buttonSeparator0,
            this.buttonEditCopyToClipboard,
            this.buttonEditProperties});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(624, 25);
            this.toolbar.TabIndex = 118;
            this.toolbar.Text = "toolStrip1";
            // 
            // buttonFileNew
            // 
            this.buttonFileNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonFileNew.Image = ((System.Drawing.Image)(resources.GetObject("buttonFileNew.Image")));
            this.buttonFileNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonFileNew.Name = "buttonFileNew";
            this.buttonFileNew.Size = new System.Drawing.Size(23, 22);
            this.buttonFileNew.Text = "&New";
            this.buttonFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // buttonFileOpen
            // 
            this.buttonFileOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("buttonFileOpen.Image")));
            this.buttonFileOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonFileOpen.Name = "buttonFileOpen";
            this.buttonFileOpen.Size = new System.Drawing.Size(23, 22);
            this.buttonFileOpen.Text = "&Open";
            this.buttonFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // buttonFileSave
            // 
            this.buttonFileSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonFileSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonFileSave.Image")));
            this.buttonFileSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonFileSave.Name = "buttonFileSave";
            this.buttonFileSave.Size = new System.Drawing.Size(23, 22);
            this.buttonFileSave.Text = "&Save";
            this.buttonFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // buttonSeparator0
            // 
            this.buttonSeparator0.Name = "buttonSeparator0";
            this.buttonSeparator0.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonEditCopyToClipboard
            // 
            this.buttonEditCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonEditCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditCopyToClipboard.Image")));
            this.buttonEditCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Black;
            this.buttonEditCopyToClipboard.Name = "buttonEditCopyToClipboard";
            this.buttonEditCopyToClipboard.Size = new System.Drawing.Size(23, 22);
            this.buttonEditCopyToClipboard.Text = "Copy to Clipboard";
            this.buttonEditCopyToClipboard.Click += new System.EventHandler(this.menuEditCopyToClipboard_Click);
            // 
            // buttonEditProperties
            // 
            this.buttonEditProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonEditProperties.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditProperties.Image")));
            this.buttonEditProperties.ImageTransparentColor = System.Drawing.Color.Black;
            this.buttonEditProperties.Name = "buttonEditProperties";
            this.buttonEditProperties.Size = new System.Drawing.Size(23, 22);
            this.buttonEditProperties.Text = "P&roperties...";
            this.buttonEditProperties.Click += new System.EventHandler(this.menuEditProperties_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuEdit,
            this.menuHelp});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(624, 24);
            this.menu.TabIndex = 117;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileSeparator2,
            this.menuFileExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "&File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Image = ((System.Drawing.Image)(resources.GetObject("menuFileNew.Image")));
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.Size = new System.Drawing.Size(146, 22);
            this.menuFileNew.Text = "&New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuFileOpen.Image")));
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(146, 22);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Image = ((System.Drawing.Image)(resources.GetObject("menuFileSave.Image")));
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(146, 22);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.Size = new System.Drawing.Size(146, 22);
            this.menuFileSaveAs.Text = "Save &As...";
            this.menuFileSaveAs.Click += new System.EventHandler(this.menuFileSaveAs_Click);
            // 
            // menuFileSeparator2
            // 
            this.menuFileSeparator2.Name = "menuFileSeparator2";
            this.menuFileSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.Size = new System.Drawing.Size(146, 22);
            this.menuFileExit.Text = "E&xit";
            this.menuFileExit.Click += new System.EventHandler(this.menuFileExit_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditCopyToClipboard,
            this.menuEditSeparator0,
            this.menuEditProperties});
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // menuEditCopyToClipboard
            // 
            this.menuEditCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("menuEditCopyToClipboard.Image")));
            this.menuEditCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuEditCopyToClipboard.Name = "menuEditCopyToClipboard";
            this.menuEditCopyToClipboard.Size = new System.Drawing.Size(171, 22);
            this.menuEditCopyToClipboard.Text = "&Copy to Clipboard";
            this.menuEditCopyToClipboard.Click += new System.EventHandler(this.menuEditCopyToClipboard_Click);
            // 
            // menuEditSeparator0
            // 
            this.menuEditSeparator0.Name = "menuEditSeparator0";
            this.menuEditSeparator0.Size = new System.Drawing.Size(168, 6);
            // 
            // menuEditProperties
            // 
            this.menuEditProperties.Image = ((System.Drawing.Image)(resources.GetObject("menuEditProperties.Image")));
            this.menuEditProperties.ImageTransparentColor = System.Drawing.Color.Black;
            this.menuEditProperties.Name = "menuEditProperties";
            this.menuEditProperties.Size = new System.Drawing.Size(171, 22);
            this.menuEditProperties.Text = "P&roperties...";
            this.menuEditProperties.Click += new System.EventHandler(this.menuEditProperties_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 20);
            this.menuHelp.Text = "&Help";
            this.menuHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.Size = new System.Drawing.Size(181, 22);
            this.menuHelpAbout.Text = "&About MVCForms ...";
            this.menuHelpAbout.Click += new System.EventHandler(this.menuHelpAbout_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarStatusMessage,
            this.StatusBarErrorMessage,
            this.StatusBarProgressBar,
            this.StatusBarActionIcon,
            this.StatusBarDirtyMessage,
            this.StatusBarNetworkIndicator,
            this.StatusBarCustomMessage});
            this.statusBar.Location = new System.Drawing.Point(0, 420);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(624, 22);
            this.statusBar.TabIndex = 116;
            this.statusBar.Text = "statusStrip1";
            // 
            // StatusBarStatusMessage
            // 
            this.StatusBarStatusMessage.ForeColor = System.Drawing.Color.Green;
            this.StatusBarStatusMessage.Name = "StatusBarStatusMessage";
            this.StatusBarStatusMessage.Size = new System.Drawing.Size(0, 17);
            this.StatusBarStatusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusBarErrorMessage
            // 
            this.StatusBarErrorMessage.AutoToolTip = true;
            this.StatusBarErrorMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusBarErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.StatusBarErrorMessage.Name = "StatusBarErrorMessage";
            this.StatusBarErrorMessage.Size = new System.Drawing.Size(609, 17);
            this.StatusBarErrorMessage.Spring = true;
            this.StatusBarErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusBarProgressBar
            // 
            this.StatusBarProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.StatusBarProgressBar.Name = "StatusBarProgressBar";
            this.StatusBarProgressBar.Size = new System.Drawing.Size(100, 16);
            this.StatusBarProgressBar.Value = 10;
            this.StatusBarProgressBar.Visible = false;
            // 
            // StatusBarActionIcon
            // 
            this.StatusBarActionIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StatusBarActionIcon.Image = ((System.Drawing.Image)(resources.GetObject("StatusBarActionIcon.Image")));
            this.StatusBarActionIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatusBarActionIcon.Name = "StatusBarActionIcon";
            this.StatusBarActionIcon.Size = new System.Drawing.Size(16, 17);
            this.StatusBarActionIcon.Visible = false;
            // 
            // StatusBarDirtyMessage
            // 
            this.StatusBarDirtyMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StatusBarDirtyMessage.Image = ((System.Drawing.Image)(resources.GetObject("StatusBarDirtyMessage.Image")));
            this.StatusBarDirtyMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatusBarDirtyMessage.Name = "StatusBarDirtyMessage";
            this.StatusBarDirtyMessage.Size = new System.Drawing.Size(16, 17);
            this.StatusBarDirtyMessage.ToolTipText = "Dirty";
            this.StatusBarDirtyMessage.Visible = false;
            // 
            // StatusBarNetworkIndicator
            // 
            this.StatusBarNetworkIndicator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StatusBarNetworkIndicator.Image = ((System.Drawing.Image)(resources.GetObject("StatusBarNetworkIndicator.Image")));
            this.StatusBarNetworkIndicator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatusBarNetworkIndicator.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.StatusBarNetworkIndicator.Name = "StatusBarNetworkIndicator";
            this.StatusBarNetworkIndicator.Size = new System.Drawing.Size(16, 17);
            this.StatusBarNetworkIndicator.ToolTipText = "Network Connected";
            this.StatusBarNetworkIndicator.Visible = false;
            // 
            // StatusBarCustomMessage
            // 
            this.StatusBarCustomMessage.Name = "StatusBarCustomMessage";
            this.StatusBarCustomMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 119;
            this.label1.Text = "Int32";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 120;
            this.label2.Text = "String";
            // 
            // txtSomeInt
            // 
            this.txtSomeInt.Location = new System.Drawing.Point(72, 52);
            this.txtSomeInt.Name = "txtSomeInt";
            this.txtSomeInt.Size = new System.Drawing.Size(100, 20);
            this.txtSomeInt.TabIndex = 122;
            // 
            // txtSomeString
            // 
            this.txtSomeString.Location = new System.Drawing.Point(72, 78);
            this.txtSomeString.Name = "txtSomeString";
            this.txtSomeString.Size = new System.Drawing.Size(100, 20);
            this.txtSomeString.TabIndex = 123;
            // 
            // chkSomeBoolean
            // 
            this.chkSomeBoolean.AutoSize = true;
            this.chkSomeBoolean.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSomeBoolean.Location = new System.Drawing.Point(21, 104);
            this.chkSomeBoolean.Name = "chkSomeBoolean";
            this.chkSomeBoolean.Size = new System.Drawing.Size(65, 17);
            this.chkSomeBoolean.TabIndex = 124;
            this.chkSomeBoolean.Text = "Boolean";
            this.chkSomeBoolean.UseVisualStyleBackColor = true;
            // 
            // cmdRun
            // 
            this.cmdRun.Location = new System.Drawing.Point(537, 45);
            this.cmdRun.Name = "cmdRun";
            this.cmdRun.Size = new System.Drawing.Size(75, 23);
            this.cmdRun.TabIndex = 125;
            this.cmdRun.Text = "Run";
            this.cmdRun.UseVisualStyleBackColor = true;
            this.cmdRun.Click += new System.EventHandler(this.cmdRun_Click);
            // 
            // chkSomeOtherBoolean
            // 
            this.chkSomeOtherBoolean.AutoSize = true;
            this.chkSomeOtherBoolean.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkSomeOtherBoolean.Location = new System.Drawing.Point(196, 104);
            this.chkSomeOtherBoolean.Name = "chkSomeOtherBoolean";
            this.chkSomeOtherBoolean.Size = new System.Drawing.Size(65, 17);
            this.chkSomeOtherBoolean.TabIndex = 130;
            this.chkSomeOtherBoolean.Text = "Boolean";
            this.chkSomeOtherBoolean.UseVisualStyleBackColor = true;
            // 
            // txtSomeOtherString
            // 
            this.txtSomeOtherString.Location = new System.Drawing.Point(247, 78);
            this.txtSomeOtherString.Name = "txtSomeOtherString";
            this.txtSomeOtherString.Size = new System.Drawing.Size(100, 20);
            this.txtSomeOtherString.TabIndex = 129;
            // 
            // txtSomeOtherInt
            // 
            this.txtSomeOtherInt.Location = new System.Drawing.Point(247, 52);
            this.txtSomeOtherInt.Name = "txtSomeOtherInt";
            this.txtSomeOtherInt.Size = new System.Drawing.Size(100, 20);
            this.txtSomeOtherInt.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 127;
            this.label3.Text = "String";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 126;
            this.label4.Text = "Int32";
            // 
            // chkStillAnotherBoolean
            // 
            this.chkStillAnotherBoolean.AutoSize = true;
            this.chkStillAnotherBoolean.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStillAnotherBoolean.Location = new System.Drawing.Point(368, 104);
            this.chkStillAnotherBoolean.Name = "chkStillAnotherBoolean";
            this.chkStillAnotherBoolean.Size = new System.Drawing.Size(65, 17);
            this.chkStillAnotherBoolean.TabIndex = 135;
            this.chkStillAnotherBoolean.Text = "Boolean";
            this.chkStillAnotherBoolean.UseVisualStyleBackColor = true;
            // 
            // txtStillAnotherString
            // 
            this.txtStillAnotherString.Location = new System.Drawing.Point(419, 78);
            this.txtStillAnotherString.Name = "txtStillAnotherString";
            this.txtStillAnotherString.Size = new System.Drawing.Size(100, 20);
            this.txtStillAnotherString.TabIndex = 134;
            // 
            // txtStillAnotherInt
            // 
            this.txtStillAnotherInt.Location = new System.Drawing.Point(419, 52);
            this.txtStillAnotherInt.Name = "txtStillAnotherInt";
            this.txtStillAnotherInt.Size = new System.Drawing.Size(100, 20);
            this.txtStillAnotherInt.TabIndex = 133;
            // 
            // lblStillAnotherString
            // 
            this.lblStillAnotherString.AutoSize = true;
            this.lblStillAnotherString.Location = new System.Drawing.Point(378, 81);
            this.lblStillAnotherString.Name = "lblStillAnotherString";
            this.lblStillAnotherString.Size = new System.Drawing.Size(34, 13);
            this.lblStillAnotherString.TabIndex = 132;
            this.lblStillAnotherString.Text = "String";
            // 
            // lblStillAnotherInt
            // 
            this.lblStillAnotherInt.AutoSize = true;
            this.lblStillAnotherInt.Location = new System.Drawing.Point(378, 55);
            this.lblStillAnotherInt.Name = "lblStillAnotherInt";
            this.lblStillAnotherInt.Size = new System.Drawing.Size(31, 13);
            this.lblStillAnotherInt.TabIndex = 131;
            this.lblStillAnotherInt.Text = "Int32";
            // 
            // MVCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.chkStillAnotherBoolean);
            this.Controls.Add(this.txtStillAnotherString);
            this.Controls.Add(this.txtStillAnotherInt);
            this.Controls.Add(this.lblStillAnotherString);
            this.Controls.Add(this.lblStillAnotherInt);
            this.Controls.Add(this.chkSomeOtherBoolean);
            this.Controls.Add(this.txtSomeOtherString);
            this.Controls.Add(this.txtSomeOtherInt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdRun);
            this.Controls.Add(this.chkSomeBoolean);
            this.Controls.Add(this.txtSomeString);
            this.Controls.Add(this.txtSomeInt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MVCView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MVCView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_FormClosing);
            this.Load += new System.EventHandler(this.View_Load);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton buttonFileNew;
        private System.Windows.Forms.ToolStripButton buttonFileOpen;
        private System.Windows.Forms.ToolStripButton buttonFileSave;
        private System.Windows.Forms.ToolStripSeparator buttonSeparator0;
        private System.Windows.Forms.ToolStripButton buttonEditCopyToClipboard;
        private System.Windows.Forms.ToolStripButton buttonEditProperties;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStripSeparator menuFileSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuEditCopyToClipboard;
        private System.Windows.Forms.ToolStripSeparator menuEditSeparator0;
        private System.Windows.Forms.ToolStripMenuItem menuEditProperties;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarStatusMessage;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarErrorMessage;
        private System.Windows.Forms.ToolStripProgressBar StatusBarProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarActionIcon;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarDirtyMessage;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarNetworkIndicator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSomeInt;
        private System.Windows.Forms.TextBox txtSomeString;
        private System.Windows.Forms.CheckBox chkSomeBoolean;
        private System.Windows.Forms.Button cmdRun;
        private System.Windows.Forms.CheckBox chkSomeOtherBoolean;
        private System.Windows.Forms.TextBox txtSomeOtherString;
        private System.Windows.Forms.TextBox txtSomeOtherInt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarCustomMessage;
        private System.Windows.Forms.CheckBox chkStillAnotherBoolean;
        private System.Windows.Forms.TextBox txtStillAnotherString;
        private System.Windows.Forms.TextBox txtStillAnotherInt;
        private System.Windows.Forms.Label lblStillAnotherString;
        private System.Windows.Forms.Label lblStillAnotherInt;
    }
}


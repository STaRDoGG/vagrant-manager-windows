namespace Lanayo.Vagrant_Manager.Windows {
    partial class PreferencesWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesWindow));
            this.VirtualBoxPathStatusTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VirtualBoxBrowseButton = new System.Windows.Forms.Button();
            this.VirtualBoxPathTextBox = new System.Windows.Forms.TextBox();
            this.AutoCloseTaskWindowLabel = new System.Windows.Forms.Label();
            this.IncludeMachineNamesLabel = new System.Windows.Forms.Label();
            this.InstancePathAsDisplayLabel = new System.Windows.Forms.Label();
            this.RefreshEveryComboBox = new System.Windows.Forms.ComboBox();
            this.RefreshEveryCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoCloseTaskWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.IncludeMachineNamesCheckBox = new System.Windows.Forms.CheckBox();
            this.InstancePathAsDisplayCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateNotificationCheckBox = new System.Windows.Forms.CheckBox();
            this.LaunchAtLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpPrefs = new System.Windows.Forms.TabPage();
            this.lblVBoxVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpBookmarks = new System.Windows.Forms.TabPage();
            this.lblCancelled = new System.Windows.Forms.Label();
            this.lblSaved = new System.Windows.Forms.Label();
            this.CancelScanButton = new System.Windows.Forms.Button();
            this.DirectoryLabelTextField = new System.Windows.Forms.TextBox();
            this.DisplayNameNoteLabel = new System.Windows.Forms.Label();
            this.RecursiveScanCheckbox = new System.Windows.Forms.CheckBox();
            this.SaveBookmarksButton = new System.Windows.Forms.Button();
            this.RemoveBookmarksButton = new System.Windows.Forms.Button();
            this.AddBookmarksButton = new System.Windows.Forms.Button();
            this.BookmarksDataGridView = new System.Windows.Forms.DataGridView();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProviderIdentifier = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.llCheckForUpdate = new System.Windows.Forms.LinkLabel();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.tmrSaved = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tpPrefs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpBookmarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookmarksDataGridView)).BeginInit();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // VirtualBoxPathStatusTextBox
            // 
            this.VirtualBoxPathStatusTextBox.AutoSize = true;
            this.VirtualBoxPathStatusTextBox.ForeColor = System.Drawing.Color.DarkGreen;
            this.VirtualBoxPathStatusTextBox.Location = new System.Drawing.Point(177, 195);
            this.VirtualBoxPathStatusTextBox.Name = "VirtualBoxPathStatusTextBox";
            this.VirtualBoxPathStatusTextBox.Size = new System.Drawing.Size(39, 13);
            this.VirtualBoxPathStatusTextBox.TabIndex = 16;
            this.VirtualBoxPathStatusTextBox.Text = "Linked";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "VBoxManage.exe | Status:";
            // 
            // VirtualBoxBrowseButton
            // 
            this.VirtualBoxBrowseButton.Location = new System.Drawing.Point(456, 211);
            this.VirtualBoxBrowseButton.Name = "VirtualBoxBrowseButton";
            this.VirtualBoxBrowseButton.Size = new System.Drawing.Size(60, 23);
            this.VirtualBoxBrowseButton.TabIndex = 14;
            this.VirtualBoxBrowseButton.Text = "Browse";
            this.VirtualBoxBrowseButton.UseVisualStyleBackColor = true;
            this.VirtualBoxBrowseButton.Click += new System.EventHandler(this.VirtualBoxBrowseButton_Click);
            // 
            // VirtualBoxPathTextBox
            // 
            this.VirtualBoxPathTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.VirtualBoxPathTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.VirtualBoxPathTextBox.BackColor = System.Drawing.Color.SteelBlue;
            this.VirtualBoxPathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VirtualBoxPathTextBox.ForeColor = System.Drawing.Color.White;
            this.VirtualBoxPathTextBox.Location = new System.Drawing.Point(25, 212);
            this.VirtualBoxPathTextBox.MaxLength = 256;
            this.VirtualBoxPathTextBox.Name = "VirtualBoxPathTextBox";
            this.VirtualBoxPathTextBox.Size = new System.Drawing.Size(425, 20);
            this.VirtualBoxPathTextBox.TabIndex = 13;
            this.VirtualBoxPathTextBox.WordWrap = false;
            // 
            // AutoCloseTaskWindowLabel
            // 
            this.AutoCloseTaskWindowLabel.AutoSize = true;
            this.AutoCloseTaskWindowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCloseTaskWindowLabel.Location = new System.Drawing.Point(46, 96);
            this.AutoCloseTaskWindowLabel.Name = "AutoCloseTaskWindowLabel";
            this.AutoCloseTaskWindowLabel.Size = new System.Drawing.Size(149, 24);
            this.AutoCloseTaskWindowLabel.TabIndex = 12;
            this.AutoCloseTaskWindowLabel.Text = "Automatically close the task output\r\nwindow if the task was successful";
            // 
            // IncludeMachineNamesLabel
            // 
            this.IncludeMachineNamesLabel.AutoSize = true;
            this.IncludeMachineNamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncludeMachineNamesLabel.Location = new System.Drawing.Point(317, 111);
            this.IncludeMachineNamesLabel.Name = "IncludeMachineNamesLabel";
            this.IncludeMachineNamesLabel.Size = new System.Drawing.Size(129, 24);
            this.IncludeMachineNamesLabel.TabIndex = 11;
            this.IncludeMachineNamesLabel.Text = "Include machine names in top-\r\nlevel menu item labels";
            // 
            // InstancePathAsDisplayLabel
            // 
            this.InstancePathAsDisplayLabel.AutoSize = true;
            this.InstancePathAsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstancePathAsDisplayLabel.Location = new System.Drawing.Point(317, 52);
            this.InstancePathAsDisplayLabel.Name = "InstancePathAsDisplayLabel";
            this.InstancePathAsDisplayLabel.Size = new System.Drawing.Size(153, 24);
            this.InstancePathAsDisplayLabel.TabIndex = 10;
            this.InstancePathAsDisplayLabel.Text = "Use the path to the vagrant instance\r\nfor the menu item label";
            // 
            // RefreshEveryComboBox
            // 
            this.RefreshEveryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RefreshEveryComboBox.FormattingEnabled = true;
            this.RefreshEveryComboBox.Location = new System.Drawing.Point(125, 144);
            this.RefreshEveryComboBox.Name = "RefreshEveryComboBox";
            this.RefreshEveryComboBox.Size = new System.Drawing.Size(96, 21);
            this.RefreshEveryComboBox.TabIndex = 9;
            this.RefreshEveryComboBox.SelectedIndexChanged += new System.EventHandler(this.RefreshEveryComboBox_SelectedIndexChanged);
            // 
            // RefreshEveryCheckBox
            // 
            this.RefreshEveryCheckBox.AutoSize = true;
            this.RefreshEveryCheckBox.Location = new System.Drawing.Point(26, 146);
            this.RefreshEveryCheckBox.Name = "RefreshEveryCheckBox";
            this.RefreshEveryCheckBox.Size = new System.Drawing.Size(93, 17);
            this.RefreshEveryCheckBox.TabIndex = 8;
            this.RefreshEveryCheckBox.Text = "Refresh Every";
            this.RefreshEveryCheckBox.UseVisualStyleBackColor = true;
            this.RefreshEveryCheckBox.CheckedChanged += new System.EventHandler(this.RefreshEveryCheckBox_CheckedChanged);
            // 
            // AutoCloseTaskWindowCheckBox
            // 
            this.AutoCloseTaskWindowCheckBox.AutoSize = true;
            this.AutoCloseTaskWindowCheckBox.Location = new System.Drawing.Point(26, 75);
            this.AutoCloseTaskWindowCheckBox.Name = "AutoCloseTaskWindowCheckBox";
            this.AutoCloseTaskWindowCheckBox.Size = new System.Drawing.Size(138, 17);
            this.AutoCloseTaskWindowCheckBox.TabIndex = 7;
            this.AutoCloseTaskWindowCheckBox.Text = "Auto-close task window";
            this.AutoCloseTaskWindowCheckBox.UseVisualStyleBackColor = true;
            this.AutoCloseTaskWindowCheckBox.CheckedChanged += new System.EventHandler(this.AutoCloseTaskWindowCheckBox_CheckedChanged);
            // 
            // IncludeMachineNamesCheckBox
            // 
            this.IncludeMachineNamesCheckBox.AutoSize = true;
            this.IncludeMachineNamesCheckBox.Location = new System.Drawing.Point(301, 91);
            this.IncludeMachineNamesCheckBox.Name = "IncludeMachineNamesCheckBox";
            this.IncludeMachineNamesCheckBox.Size = new System.Drawing.Size(138, 17);
            this.IncludeMachineNamesCheckBox.TabIndex = 6;
            this.IncludeMachineNamesCheckBox.Text = "Include machine names";
            this.IncludeMachineNamesCheckBox.UseVisualStyleBackColor = true;
            this.IncludeMachineNamesCheckBox.CheckedChanged += new System.EventHandler(this.IncludeMachineNamesCheckBox_CheckedChanged);
            // 
            // InstancePathAsDisplayCheckBox
            // 
            this.InstancePathAsDisplayCheckBox.AutoSize = true;
            this.InstancePathAsDisplayCheckBox.Location = new System.Drawing.Point(301, 29);
            this.InstancePathAsDisplayCheckBox.Name = "InstancePathAsDisplayCheckBox";
            this.InstancePathAsDisplayCheckBox.Size = new System.Drawing.Size(190, 17);
            this.InstancePathAsDisplayCheckBox.TabIndex = 5;
            this.InstancePathAsDisplayCheckBox.Text = "Use instance path as display name";
            this.InstancePathAsDisplayCheckBox.UseVisualStyleBackColor = true;
            this.InstancePathAsDisplayCheckBox.CheckedChanged += new System.EventHandler(this.InstancePathAsDisplayCheckBox_CheckedChanged);
            // 
            // UpdateNotificationCheckBox
            // 
            this.UpdateNotificationCheckBox.AutoSize = true;
            this.UpdateNotificationCheckBox.Location = new System.Drawing.Point(26, 52);
            this.UpdateNotificationCheckBox.Name = "UpdateNotificationCheckBox";
            this.UpdateNotificationCheckBox.Size = new System.Drawing.Size(169, 17);
            this.UpdateNotificationCheckBox.TabIndex = 4;
            this.UpdateNotificationCheckBox.Text = "Don\'t show update notification";
            this.UpdateNotificationCheckBox.UseVisualStyleBackColor = true;
            this.UpdateNotificationCheckBox.CheckedChanged += new System.EventHandler(this.UpdateNotificationCheckBox_CheckedChanged);
            // 
            // LaunchAtLoginCheckBox
            // 
            this.LaunchAtLoginCheckBox.AutoSize = true;
            this.LaunchAtLoginCheckBox.Location = new System.Drawing.Point(26, 29);
            this.LaunchAtLoginCheckBox.Name = "LaunchAtLoginCheckBox";
            this.LaunchAtLoginCheckBox.Size = new System.Drawing.Size(99, 17);
            this.LaunchAtLoginCheckBox.TabIndex = 2;
            this.LaunchAtLoginCheckBox.Text = "Launch at login";
            this.LaunchAtLoginCheckBox.UseVisualStyleBackColor = true;
            this.LaunchAtLoginCheckBox.CheckedChanged += new System.EventHandler(this.LaunchAtLoginCheckBox_CheckedChanged);
            // 
            // DoneButton
            // 
            this.DoneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneButton.Location = new System.Drawing.Point(488, 501);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 23);
            this.DoneButton.TabIndex = 1;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpPrefs);
            this.tabControl1.Controls.Add(this.tpBookmarks);
            this.tabControl1.Controls.Add(this.tpAbout);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 467);
            this.tabControl1.TabIndex = 2;
            // 
            // tpPrefs
            // 
            this.tpPrefs.Controls.Add(this.lblVBoxVersion);
            this.tpPrefs.Controls.Add(this.pictureBox1);
            this.tpPrefs.Controls.Add(this.VirtualBoxPathStatusTextBox);
            this.tpPrefs.Controls.Add(this.LaunchAtLoginCheckBox);
            this.tpPrefs.Controls.Add(this.label1);
            this.tpPrefs.Controls.Add(this.UpdateNotificationCheckBox);
            this.tpPrefs.Controls.Add(this.VirtualBoxBrowseButton);
            this.tpPrefs.Controls.Add(this.InstancePathAsDisplayCheckBox);
            this.tpPrefs.Controls.Add(this.VirtualBoxPathTextBox);
            this.tpPrefs.Controls.Add(this.IncludeMachineNamesCheckBox);
            this.tpPrefs.Controls.Add(this.AutoCloseTaskWindowLabel);
            this.tpPrefs.Controls.Add(this.AutoCloseTaskWindowCheckBox);
            this.tpPrefs.Controls.Add(this.IncludeMachineNamesLabel);
            this.tpPrefs.Controls.Add(this.RefreshEveryCheckBox);
            this.tpPrefs.Controls.Add(this.InstancePathAsDisplayLabel);
            this.tpPrefs.Controls.Add(this.RefreshEveryComboBox);
            this.tpPrefs.Location = new System.Drawing.Point(4, 22);
            this.tpPrefs.Name = "tpPrefs";
            this.tpPrefs.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrefs.Size = new System.Drawing.Size(545, 441);
            this.tpPrefs.TabIndex = 0;
            this.tpPrefs.Text = " Preferences ";
            this.tpPrefs.UseVisualStyleBackColor = true;
            // 
            // lblVBoxVersion
            // 
            this.lblVBoxVersion.AutoSize = true;
            this.lblVBoxVersion.ForeColor = System.Drawing.Color.Navy;
            this.lblVBoxVersion.Location = new System.Drawing.Point(363, 196);
            this.lblVBoxVersion.Name = "lblVBoxVersion";
            this.lblVBoxVersion.Size = new System.Drawing.Size(87, 13);
            this.lblVBoxVersion.TabIndex = 18;
            this.lblVBoxVersion.Text = "VirtualBox v0.0.0";
            this.lblVBoxVersion.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // tpBookmarks
            // 
            this.tpBookmarks.Controls.Add(this.lblCancelled);
            this.tpBookmarks.Controls.Add(this.lblSaved);
            this.tpBookmarks.Controls.Add(this.CancelScanButton);
            this.tpBookmarks.Controls.Add(this.DirectoryLabelTextField);
            this.tpBookmarks.Controls.Add(this.DisplayNameNoteLabel);
            this.tpBookmarks.Controls.Add(this.RecursiveScanCheckbox);
            this.tpBookmarks.Controls.Add(this.SaveBookmarksButton);
            this.tpBookmarks.Controls.Add(this.RemoveBookmarksButton);
            this.tpBookmarks.Controls.Add(this.AddBookmarksButton);
            this.tpBookmarks.Controls.Add(this.BookmarksDataGridView);
            this.tpBookmarks.Location = new System.Drawing.Point(4, 22);
            this.tpBookmarks.Name = "tpBookmarks";
            this.tpBookmarks.Padding = new System.Windows.Forms.Padding(3);
            this.tpBookmarks.Size = new System.Drawing.Size(545, 441);
            this.tpBookmarks.TabIndex = 2;
            this.tpBookmarks.Text = " Bookmarks ";
            this.tpBookmarks.UseVisualStyleBackColor = true;
            // 
            // lblCancelled
            // 
            this.lblCancelled.AutoSize = true;
            this.lblCancelled.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCancelled.Location = new System.Drawing.Point(387, 413);
            this.lblCancelled.Name = "lblCancelled";
            this.lblCancelled.Size = new System.Drawing.Size(54, 13);
            this.lblCancelled.TabIndex = 20;
            this.lblCancelled.Text = "Cancelled";
            this.lblCancelled.Visible = false;
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSaved.Location = new System.Drawing.Point(479, 412);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(38, 13);
            this.lblSaved.TabIndex = 19;
            this.lblSaved.Text = "Saved";
            this.lblSaved.Visible = false;
            // 
            // CancelScanButton
            // 
            this.CancelScanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelScanButton.Image = global::Lanayo.Vagrant_Manager.Properties.Resources.Cancel_16x;
            this.CancelScanButton.Location = new System.Drawing.Point(375, 379);
            this.CancelScanButton.Name = "CancelScanButton";
            this.CancelScanButton.Size = new System.Drawing.Size(79, 23);
            this.CancelScanButton.TabIndex = 18;
            this.toolTip1.SetToolTip(this.CancelScanButton, "Cancel Scan");
            this.CancelScanButton.UseVisualStyleBackColor = true;
            this.CancelScanButton.Visible = false;
            this.CancelScanButton.Click += new System.EventHandler(this.CancelScanButton_Click);
            // 
            // DirectoryLabelTextField
            // 
            this.DirectoryLabelTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DirectoryLabelTextField.BackColor = System.Drawing.Color.SteelBlue;
            this.DirectoryLabelTextField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirectoryLabelTextField.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirectoryLabelTextField.ForeColor = System.Drawing.Color.White;
            this.DirectoryLabelTextField.Location = new System.Drawing.Point(6, 343);
            this.DirectoryLabelTextField.Name = "DirectoryLabelTextField";
            this.DirectoryLabelTextField.ReadOnly = true;
            this.DirectoryLabelTextField.Size = new System.Drawing.Size(533, 20);
            this.DirectoryLabelTextField.TabIndex = 17;
            // 
            // DisplayNameNoteLabel
            // 
            this.DisplayNameNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DisplayNameNoteLabel.AutoSize = true;
            this.DisplayNameNoteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayNameNoteLabel.Location = new System.Drawing.Point(178, 366);
            this.DisplayNameNoteLabel.Name = "DisplayNameNoteLabel";
            this.DisplayNameNoteLabel.Size = new System.Drawing.Size(151, 13);
            this.DisplayNameNoteLabel.TabIndex = 16;
            this.DisplayNameNoteLabel.Text = "Note: Display Name is editable";
            // 
            // RecursiveScanCheckbox
            // 
            this.RecursiveScanCheckbox.AutoSize = true;
            this.RecursiveScanCheckbox.Location = new System.Drawing.Point(16, 408);
            this.RecursiveScanCheckbox.Name = "RecursiveScanCheckbox";
            this.RecursiveScanCheckbox.Size = new System.Drawing.Size(220, 17);
            this.RecursiveScanCheckbox.TabIndex = 15;
            this.RecursiveScanCheckbox.Text = "Recursively scan directories when added";
            this.RecursiveScanCheckbox.UseVisualStyleBackColor = true;
            this.RecursiveScanCheckbox.CheckedChanged += new System.EventHandler(this.RecursiveScanCheckbox_CheckedChanged);
            // 
            // SaveBookmarksButton
            // 
            this.SaveBookmarksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBookmarksButton.Image = global::Lanayo.Vagrant_Manager.Properties.Resources.SaveTable_16x;
            this.SaveBookmarksButton.Location = new System.Drawing.Point(460, 379);
            this.SaveBookmarksButton.Name = "SaveBookmarksButton";
            this.SaveBookmarksButton.Size = new System.Drawing.Size(79, 23);
            this.SaveBookmarksButton.TabIndex = 13;
            this.toolTip1.SetToolTip(this.SaveBookmarksButton, "Save Changes");
            this.SaveBookmarksButton.UseVisualStyleBackColor = true;
            this.SaveBookmarksButton.Click += new System.EventHandler(this.SaveBookmarksButton_Click);
            // 
            // RemoveBookmarksButton
            // 
            this.RemoveBookmarksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveBookmarksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBookmarksButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemoveBookmarksButton.Image = global::Lanayo.Vagrant_Manager.Properties.Resources.Subtract_16x;
            this.RemoveBookmarksButton.Location = new System.Drawing.Point(42, 379);
            this.RemoveBookmarksButton.Name = "RemoveBookmarksButton";
            this.RemoveBookmarksButton.Size = new System.Drawing.Size(34, 23);
            this.RemoveBookmarksButton.TabIndex = 12;
            this.toolTip1.SetToolTip(this.RemoveBookmarksButton, "Remove bookmark(s)");
            this.RemoveBookmarksButton.UseVisualStyleBackColor = true;
            this.RemoveBookmarksButton.Click += new System.EventHandler(this.RemoveBookmarksButton_Click);
            // 
            // AddBookmarksButton
            // 
            this.AddBookmarksButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBookmarksButton.Image = global::Lanayo.Vagrant_Manager.Properties.Resources.Add_16xMD;
            this.AddBookmarksButton.Location = new System.Drawing.Point(6, 379);
            this.AddBookmarksButton.Name = "AddBookmarksButton";
            this.AddBookmarksButton.Size = new System.Drawing.Size(34, 23);
            this.AddBookmarksButton.TabIndex = 11;
            this.toolTip1.SetToolTip(this.AddBookmarksButton, "Add bookmark(s)");
            this.AddBookmarksButton.UseVisualStyleBackColor = true;
            this.AddBookmarksButton.Click += new System.EventHandler(this.AddBookmarksButton_Click);
            // 
            // BookmarksDataGridView
            // 
            this.BookmarksDataGridView.AllowDrop = true;
            this.BookmarksDataGridView.AllowUserToAddRows = false;
            this.BookmarksDataGridView.AllowUserToDeleteRows = false;
            this.BookmarksDataGridView.AllowUserToResizeRows = false;
            this.BookmarksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BookmarksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookmarksDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.BookmarksDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookmarksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookmarksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Path,
            this.DisplayName,
            this.ProviderIdentifier});
            this.BookmarksDataGridView.Location = new System.Drawing.Point(6, 6);
            this.BookmarksDataGridView.Name = "BookmarksDataGridView";
            this.BookmarksDataGridView.Size = new System.Drawing.Size(533, 331);
            this.BookmarksDataGridView.TabIndex = 10;
            this.BookmarksDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.BookmarksDataGridView_CellMouseDown);
            this.BookmarksDataGridView.DragDrop += new System.Windows.Forms.DragEventHandler(this.BookmarksDataGridView_DragDrop);
            this.BookmarksDataGridView.DragOver += new System.Windows.Forms.DragEventHandler(this.BookmarksDataGridView_DragOver);
            this.BookmarksDataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookmarksDataGridView_MouseMove);
            // 
            // Path
            // 
            this.Path.DataPropertyName = "Path";
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Display Name";
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ProviderIdentifier
            // 
            this.ProviderIdentifier.DataPropertyName = "ProviderIdentifier";
            this.ProviderIdentifier.HeaderText = "Provider";
            this.ProviderIdentifier.Name = "ProviderIdentifier";
            this.ProviderIdentifier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.llCheckForUpdate);
            this.tpAbout.Controls.Add(this.WebBrowser);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbout.Size = new System.Drawing.Size(545, 441);
            this.tpAbout.TabIndex = 1;
            this.tpAbout.Text = " About ";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // llCheckForUpdate
            // 
            this.llCheckForUpdate.AutoSize = true;
            this.llCheckForUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llCheckForUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llCheckForUpdate.Location = new System.Drawing.Point(420, 412);
            this.llCheckForUpdate.Name = "llCheckForUpdate";
            this.llCheckForUpdate.Size = new System.Drawing.Size(107, 13);
            this.llCheckForUpdate.TabIndex = 2;
            this.llCheckForUpdate.TabStop = true;
            this.llCheckForUpdate.Text = "Check for Update";
            this.llCheckForUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCheckForUpdate_LinkClicked);
            // 
            // WebBrowser
            // 
            this.WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebBrowser.Location = new System.Drawing.Point(6, 6);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.ScrollBarsEnabled = false;
            this.WebBrowser.Size = new System.Drawing.Size(533, 388);
            this.WebBrowser.TabIndex = 1;
            // 
            // tmrSaved
            // 
            this.tmrSaved.Interval = 5000;
            this.tmrSaved.Tick += new System.EventHandler(this.tmrSaved_Tick);
            // 
            // PreferencesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 536);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.DoneButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PreferencesWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreferencesWindow_FormClosing);
            this.Load += new System.EventHandler(this.PreferencesWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpPrefs.ResumeLayout(false);
            this.tpPrefs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpBookmarks.ResumeLayout(false);
            this.tpBookmarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookmarksDataGridView)).EndInit();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.CheckBox InstancePathAsDisplayCheckBox;
        private System.Windows.Forms.CheckBox UpdateNotificationCheckBox;
        private System.Windows.Forms.CheckBox LaunchAtLoginCheckBox;
        private System.Windows.Forms.CheckBox AutoCloseTaskWindowCheckBox;
        private System.Windows.Forms.CheckBox IncludeMachineNamesCheckBox;
        private System.Windows.Forms.CheckBox RefreshEveryCheckBox;
        private System.Windows.Forms.ComboBox RefreshEveryComboBox;
        private System.Windows.Forms.Label InstancePathAsDisplayLabel;
        private System.Windows.Forms.Label IncludeMachineNamesLabel;
        private System.Windows.Forms.Label AutoCloseTaskWindowLabel;
        private System.Windows.Forms.Button VirtualBoxBrowseButton;
        private System.Windows.Forms.TextBox VirtualBoxPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label VirtualBoxPathStatusTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpPrefs;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.LinkLabel llCheckForUpdate;
        private System.Windows.Forms.TabPage tpBookmarks;
        private System.Windows.Forms.Button CancelScanButton;
        private System.Windows.Forms.TextBox DirectoryLabelTextField;
        private System.Windows.Forms.Label DisplayNameNoteLabel;
        private System.Windows.Forms.CheckBox RecursiveScanCheckbox;
        private System.Windows.Forms.Button SaveBookmarksButton;
        private System.Windows.Forms.Button RemoveBookmarksButton;
        private System.Windows.Forms.Button AddBookmarksButton;
        private System.Windows.Forms.DataGridView BookmarksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProviderIdentifier;
        private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.Timer tmrSaved;
        private System.Windows.Forms.Label lblCancelled;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVBoxVersion;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
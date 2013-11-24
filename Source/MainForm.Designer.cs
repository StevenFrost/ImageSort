namespace ImageSort {
    partial class MainForm {
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
            this.sourceDirectory = new System.Windows.Forms.TextBox();
            this.sourceDirectoryLabel = new System.Windows.Forms.Label();
            this.optionRecursive = new System.Windows.Forms.CheckBox();
            this.sourceBrowseButton = new System.Windows.Forms.Button();
            this.destination = new System.Windows.Forms.TextBox();
            this.destinationButton = new System.Windows.Forms.Button();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.optionCopy = new System.Windows.Forms.RadioButton();
            this.optionMove = new System.Windows.Forms.RadioButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.controlButton = new System.Windows.Forms.Button();
            this.directoryFormat1 = new System.Windows.Forms.ComboBox();
            this.spacerLabel1 = new System.Windows.Forms.Label();
            this.directoryFormat2 = new System.Windows.Forms.ComboBox();
            this.directoryFormat3 = new System.Windows.Forms.ComboBox();
            this.spacerLabel2 = new System.Windows.Forms.Label();
            this.direcotryFormatLabel = new System.Windows.Forms.Label();
            this.optionRemoveDuplicates = new System.Windows.Forms.CheckBox();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.optionPauseOnDuplicate = new System.Windows.Forms.CheckBox();
            this.filenameRuleLabel = new System.Windows.Forms.Label();
            this.filenameRule = new System.Windows.Forms.ComboBox();
            this.optionLog = new System.Windows.Forms.CheckBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.workerThread = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // sourceDirectory
            // 
            this.sourceDirectory.Location = new System.Drawing.Point(105, 12);
            this.sourceDirectory.Name = "sourceDirectory";
            this.sourceDirectory.Size = new System.Drawing.Size(188, 20);
            this.sourceDirectory.TabIndex = 1;
            // 
            // sourceDirectoryLabel
            // 
            this.sourceDirectoryLabel.AutoSize = true;
            this.sourceDirectoryLabel.Location = new System.Drawing.Point(12, 15);
            this.sourceDirectoryLabel.Name = "sourceDirectoryLabel";
            this.sourceDirectoryLabel.Size = new System.Drawing.Size(87, 13);
            this.sourceDirectoryLabel.TabIndex = 0;
            this.sourceDirectoryLabel.Text = "Source directory:";
            // 
            // optionRecursive
            // 
            this.optionRecursive.AutoSize = true;
            this.optionRecursive.Location = new System.Drawing.Point(104, 141);
            this.optionRecursive.Name = "optionRecursive";
            this.optionRecursive.Size = new System.Drawing.Size(74, 17);
            this.optionRecursive.TabIndex = 11;
            this.optionRecursive.Text = "Recursive";
            this.optionRecursive.UseVisualStyleBackColor = true;
            // 
            // sourceBrowseButton
            // 
            this.sourceBrowseButton.Location = new System.Drawing.Point(299, 11);
            this.sourceBrowseButton.Name = "sourceBrowseButton";
            this.sourceBrowseButton.Size = new System.Drawing.Size(73, 22);
            this.sourceBrowseButton.TabIndex = 2;
            this.sourceBrowseButton.Text = "Browse...";
            this.sourceBrowseButton.UseVisualStyleBackColor = true;
            this.sourceBrowseButton.Click += new System.EventHandler(this.sourceBrowseButton_Click);
            // 
            // destination
            // 
            this.destination.Location = new System.Drawing.Point(105, 38);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(188, 20);
            this.destination.TabIndex = 3;
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(299, 37);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(73, 22);
            this.destinationButton.TabIndex = 4;
            this.destinationButton.Text = "Browse...";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.destinationButton_Click);
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(12, 41);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(63, 13);
            this.destinationLabel.TabIndex = 0;
            this.destinationLabel.Text = "Destination:";
            // 
            // optionCopy
            // 
            this.optionCopy.AutoSize = true;
            this.optionCopy.Location = new System.Drawing.Point(163, 64);
            this.optionCopy.Name = "optionCopy";
            this.optionCopy.Size = new System.Drawing.Size(49, 17);
            this.optionCopy.TabIndex = 6;
            this.optionCopy.Text = "Copy";
            this.optionCopy.UseVisualStyleBackColor = true;
            // 
            // optionMove
            // 
            this.optionMove.AutoSize = true;
            this.optionMove.Checked = true;
            this.optionMove.Location = new System.Drawing.Point(105, 64);
            this.optionMove.Name = "optionMove";
            this.optionMove.Size = new System.Drawing.Size(52, 17);
            this.optionMove.TabIndex = 5;
            this.optionMove.TabStop = true;
            this.optionMove.Text = "Move";
            this.optionMove.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar.Location = new System.Drawing.Point(12, 287);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(360, 23);
            this.progressBar.TabIndex = 0;
            // 
            // progressLabel
            // 
            this.progressLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressLabel.ForeColor = System.Drawing.Color.DimGray;
            this.progressLabel.Location = new System.Drawing.Point(12, 269);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(347, 16);
            this.progressLabel.TabIndex = 0;
            this.progressLabel.Text = "Ready";
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // controlButton
            // 
            this.controlButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.controlButton.Location = new System.Drawing.Point(12, 234);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(360, 32);
            this.controlButton.TabIndex = 15;
            this.controlButton.Text = "Start";
            this.controlButton.UseVisualStyleBackColor = true;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            // 
            // directoryFormat1
            // 
            this.directoryFormat1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directoryFormat1.FormattingEnabled = true;
            this.directoryFormat1.Items.AddRange(new object[] {
            "(none)",
            "Day",
            "Month",
            "Year"});
            this.directoryFormat1.Location = new System.Drawing.Point(105, 87);
            this.directoryFormat1.Name = "directoryFormat1";
            this.directoryFormat1.Size = new System.Drawing.Size(73, 21);
            this.directoryFormat1.TabIndex = 7;
            // 
            // spacerLabel1
            // 
            this.spacerLabel1.AutoSize = true;
            this.spacerLabel1.Location = new System.Drawing.Point(184, 90);
            this.spacerLabel1.Name = "spacerLabel1";
            this.spacerLabel1.Size = new System.Drawing.Size(12, 13);
            this.spacerLabel1.TabIndex = 0;
            this.spacerLabel1.Text = "\\";
            // 
            // directoryFormat2
            // 
            this.directoryFormat2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directoryFormat2.FormattingEnabled = true;
            this.directoryFormat2.Items.AddRange(new object[] {
            "(none)",
            "Day",
            "Month",
            "Year"});
            this.directoryFormat2.Location = new System.Drawing.Point(202, 87);
            this.directoryFormat2.Name = "directoryFormat2";
            this.directoryFormat2.Size = new System.Drawing.Size(73, 21);
            this.directoryFormat2.TabIndex = 8;
            // 
            // directoryFormat3
            // 
            this.directoryFormat3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.directoryFormat3.FormattingEnabled = true;
            this.directoryFormat3.Items.AddRange(new object[] {
            "(none)",
            "Day",
            "Month",
            "Year"});
            this.directoryFormat3.Location = new System.Drawing.Point(299, 87);
            this.directoryFormat3.Name = "directoryFormat3";
            this.directoryFormat3.Size = new System.Drawing.Size(73, 21);
            this.directoryFormat3.TabIndex = 9;
            // 
            // spacerLabel2
            // 
            this.spacerLabel2.AutoSize = true;
            this.spacerLabel2.Location = new System.Drawing.Point(281, 90);
            this.spacerLabel2.Name = "spacerLabel2";
            this.spacerLabel2.Size = new System.Drawing.Size(12, 13);
            this.spacerLabel2.TabIndex = 0;
            this.spacerLabel2.Text = "\\";
            // 
            // direcotryFormatLabel
            // 
            this.direcotryFormatLabel.AutoSize = true;
            this.direcotryFormatLabel.Location = new System.Drawing.Point(12, 90);
            this.direcotryFormatLabel.Name = "direcotryFormatLabel";
            this.direcotryFormatLabel.Size = new System.Drawing.Size(84, 13);
            this.direcotryFormatLabel.TabIndex = 0;
            this.direcotryFormatLabel.Text = "Directory format:";
            // 
            // optionRemoveDuplicates
            // 
            this.optionRemoveDuplicates.AutoSize = true;
            this.optionRemoveDuplicates.Enabled = false;
            this.optionRemoveDuplicates.Location = new System.Drawing.Point(104, 187);
            this.optionRemoveDuplicates.Name = "optionRemoveDuplicates";
            this.optionRemoveDuplicates.Size = new System.Drawing.Size(117, 17);
            this.optionRemoveDuplicates.TabIndex = 13;
            this.optionRemoveDuplicates.Text = "Remove duplicates";
            this.optionRemoveDuplicates.UseVisualStyleBackColor = true;
            this.optionRemoveDuplicates.CheckedChanged += new System.EventHandler(this.optionRemoveDuplicates_CheckedChanged);
            // 
            // optionsLabel
            // 
            this.optionsLabel.AutoSize = true;
            this.optionsLabel.Location = new System.Drawing.Point(12, 142);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(46, 13);
            this.optionsLabel.TabIndex = 0;
            this.optionsLabel.Text = "Options:";
            // 
            // optionPauseOnDuplicate
            // 
            this.optionPauseOnDuplicate.AutoSize = true;
            this.optionPauseOnDuplicate.Enabled = false;
            this.optionPauseOnDuplicate.Location = new System.Drawing.Point(104, 210);
            this.optionPauseOnDuplicate.Name = "optionPauseOnDuplicate";
            this.optionPauseOnDuplicate.Size = new System.Drawing.Size(165, 17);
            this.optionPauseOnDuplicate.TabIndex = 14;
            this.optionPauseOnDuplicate.Text = "Pause on duplicate discovery";
            this.optionPauseOnDuplicate.UseVisualStyleBackColor = true;
            // 
            // filenameRuleLabel
            // 
            this.filenameRuleLabel.AutoSize = true;
            this.filenameRuleLabel.Location = new System.Drawing.Point(12, 117);
            this.filenameRuleLabel.Name = "filenameRuleLabel";
            this.filenameRuleLabel.Size = new System.Drawing.Size(72, 13);
            this.filenameRuleLabel.TabIndex = 0;
            this.filenameRuleLabel.Text = "Filename rule:";
            // 
            // filenameRule
            // 
            this.filenameRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filenameRule.FormattingEnabled = true;
            this.filenameRule.Items.AddRange(new object[] {
            "Original (files with same name not moved/copied)",
            "Increment (unique number appended to filename)"});
            this.filenameRule.Location = new System.Drawing.Point(105, 114);
            this.filenameRule.Name = "filenameRule";
            this.filenameRule.Size = new System.Drawing.Size(267, 21);
            this.filenameRule.TabIndex = 10;
            this.filenameRule.SelectedIndexChanged += new System.EventHandler(this.filenameRule_SelectedIndexChanged);
            // 
            // optionLog
            // 
            this.optionLog.AutoSize = true;
            this.optionLog.Location = new System.Drawing.Point(104, 164);
            this.optionLog.Name = "optionLog";
            this.optionLog.Size = new System.Drawing.Size(95, 17);
            this.optionLog.TabIndex = 12;
            this.optionLog.Text = "Log processes";
            this.optionLog.UseVisualStyleBackColor = true;
            // 
            // workerThread
            // 
            this.workerThread.WorkerReportsProgress = true;
            this.workerThread.WorkerSupportsCancellation = true;
            this.workerThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerThread_DoWork);
            this.workerThread.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.workerThread_ProgressChanged);
            this.workerThread.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerThread_RunWorkerCompleted);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 322);
            this.Controls.Add(this.optionLog);
            this.Controls.Add(this.filenameRuleLabel);
            this.Controls.Add(this.filenameRule);
            this.Controls.Add(this.optionPauseOnDuplicate);
            this.Controls.Add(this.optionsLabel);
            this.Controls.Add(this.optionRemoveDuplicates);
            this.Controls.Add(this.direcotryFormatLabel);
            this.Controls.Add(this.directoryFormat3);
            this.Controls.Add(this.spacerLabel2);
            this.Controls.Add(this.directoryFormat2);
            this.Controls.Add(this.spacerLabel1);
            this.Controls.Add(this.directoryFormat1);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.optionMove);
            this.Controls.Add(this.optionCopy);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationButton);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.sourceBrowseButton);
            this.Controls.Add(this.optionRecursive);
            this.Controls.Add(this.sourceDirectoryLabel);
            this.Controls.Add(this.sourceDirectory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Image Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceDirectory;
        private System.Windows.Forms.Label sourceDirectoryLabel;
        private System.Windows.Forms.CheckBox optionRecursive;
        private System.Windows.Forms.Button sourceBrowseButton;
        private System.Windows.Forms.TextBox destination;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.RadioButton optionCopy;
        private System.Windows.Forms.RadioButton optionMove;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.ComboBox directoryFormat1;
        private System.Windows.Forms.Label spacerLabel1;
        private System.Windows.Forms.ComboBox directoryFormat2;
        private System.Windows.Forms.ComboBox directoryFormat3;
        private System.Windows.Forms.Label spacerLabel2;
        private System.Windows.Forms.Label direcotryFormatLabel;
        private System.Windows.Forms.CheckBox optionRemoveDuplicates;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.CheckBox optionPauseOnDuplicate;
        private System.Windows.Forms.Label filenameRuleLabel;
        private System.Windows.Forms.ComboBox filenameRule;
        private System.Windows.Forms.CheckBox optionLog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.ComponentModel.BackgroundWorker workerThread;
    }
}
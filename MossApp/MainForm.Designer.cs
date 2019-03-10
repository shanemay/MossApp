namespace MossApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SubmissionTab = new System.Windows.Forms.TabPage();
            this.RestrictFileTypesLabel = new System.Windows.Forms.Label();
            this.RestrictFileTypeTextBox = new System.Windows.Forms.TextBox();
            this.RestrictFileTypesCheckBox = new System.Windows.Forms.CheckBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.MossLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SendRequestButton = new System.Windows.Forms.Button();
            this.FilesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DirectoryModeCheckBox = new System.Windows.Forms.CheckBox();
            this.SourceFilesButton = new System.Windows.Forms.Button();
            this.BaseFilesButton = new System.Windows.Forms.Button();
            this.ExperimentalServerCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionCTextBox = new System.Windows.Forms.TextBox();
            this.OptionCLabel = new System.Windows.Forms.Label();
            this.OptionNTextBox = new System.Windows.Forms.TextBox();
            this.OptionNLabel = new System.Windows.Forms.Label();
            this.OptionMTextBox = new System.Windows.Forms.TextBox();
            this.OptionMLabel = new System.Windows.Forms.Label();
            this.LanguagesComboBox = new System.Windows.Forms.ComboBox();
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.UserIdTextBox = new System.Windows.Forms.TextBox();
            this.UserIdLinkLabel = new System.Windows.Forms.LinkLabel();
            this.BrowserTab = new System.Windows.Forms.TabPage();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.UserIdTab = new System.Windows.Forms.TabPage();
            this.MossMailLabel = new System.Windows.Forms.Label();
            this.UserIdInstructionsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.OptionToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ClearFilesButton = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.SubmissionTab.SuspendLayout();
            this.BrowserTab.SuspendLayout();
            this.UserIdTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabControl.Controls.Add(this.SubmissionTab);
            this.TabControl.Controls.Add(this.BrowserTab);
            this.TabControl.Controls.Add(this.UserIdTab);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(804, 637);
            this.TabControl.TabIndex = 0;
            // 
            // SubmissionTab
            // 
            this.SubmissionTab.Controls.Add(this.ClearFilesButton);
            this.SubmissionTab.Controls.Add(this.RestrictFileTypesLabel);
            this.SubmissionTab.Controls.Add(this.RestrictFileTypeTextBox);
            this.SubmissionTab.Controls.Add(this.RestrictFileTypesCheckBox);
            this.SubmissionTab.Controls.Add(this.InstructionsLabel);
            this.SubmissionTab.Controls.Add(this.ErrorLabel);
            this.SubmissionTab.Controls.Add(this.MossLinkLabel);
            this.SubmissionTab.Controls.Add(this.SendRequestButton);
            this.SubmissionTab.Controls.Add(this.FilesRichTextBox);
            this.SubmissionTab.Controls.Add(this.DirectoryModeCheckBox);
            this.SubmissionTab.Controls.Add(this.SourceFilesButton);
            this.SubmissionTab.Controls.Add(this.BaseFilesButton);
            this.SubmissionTab.Controls.Add(this.ExperimentalServerCheckBox);
            this.SubmissionTab.Controls.Add(this.OptionCTextBox);
            this.SubmissionTab.Controls.Add(this.OptionCLabel);
            this.SubmissionTab.Controls.Add(this.OptionNTextBox);
            this.SubmissionTab.Controls.Add(this.OptionNLabel);
            this.SubmissionTab.Controls.Add(this.OptionMTextBox);
            this.SubmissionTab.Controls.Add(this.OptionMLabel);
            this.SubmissionTab.Controls.Add(this.LanguagesComboBox);
            this.SubmissionTab.Controls.Add(this.LanguageLabel);
            this.SubmissionTab.Controls.Add(this.UserIdTextBox);
            this.SubmissionTab.Controls.Add(this.UserIdLinkLabel);
            this.SubmissionTab.Location = new System.Drawing.Point(4, 25);
            this.SubmissionTab.Name = "SubmissionTab";
            this.SubmissionTab.Padding = new System.Windows.Forms.Padding(3);
            this.SubmissionTab.Size = new System.Drawing.Size(796, 608);
            this.SubmissionTab.TabIndex = 0;
            this.SubmissionTab.Text = "Submission Info";
            this.SubmissionTab.UseVisualStyleBackColor = true;
            // 
            // RestrictFileTypesLabel
            // 
            this.RestrictFileTypesLabel.AutoSize = true;
            this.RestrictFileTypesLabel.Location = new System.Drawing.Point(513, 139);
            this.RestrictFileTypesLabel.Name = "RestrictFileTypesLabel";
            this.RestrictFileTypesLabel.Size = new System.Drawing.Size(15, 13);
            this.RestrictFileTypesLabel.TabIndex = 22;
            this.RestrictFileTypesLabel.Text = "R";
            // 
            // RestrictFileTypeTextBox
            // 
            this.RestrictFileTypeTextBox.Location = new System.Drawing.Point(516, 116);
            this.RestrictFileTypeTextBox.Name = "RestrictFileTypeTextBox";
            this.RestrictFileTypeTextBox.Size = new System.Drawing.Size(255, 20);
            this.RestrictFileTypeTextBox.TabIndex = 21;
            // 
            // RestrictFileTypesCheckBox
            // 
            this.RestrictFileTypesCheckBox.AutoSize = true;
            this.RestrictFileTypesCheckBox.Location = new System.Drawing.Point(516, 93);
            this.RestrictFileTypesCheckBox.Name = "RestrictFileTypesCheckBox";
            this.RestrictFileTypesCheckBox.Size = new System.Drawing.Size(110, 17);
            this.RestrictFileTypesCheckBox.TabIndex = 20;
            this.RestrictFileTypesCheckBox.Text = "Restrict FileTypes";
            this.RestrictFileTypesCheckBox.UseVisualStyleBackColor = true;
            this.RestrictFileTypesCheckBox.CheckedChanged += new System.EventHandler(this.RestrictFileTypesCheckBox_CheckedChanged);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoSize = true;
            this.InstructionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.ForeColor = System.Drawing.Color.Red;
            this.InstructionsLabel.Location = new System.Drawing.Point(513, 178);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(11, 13);
            this.InstructionsLabel.TabIndex = 19;
            this.InstructionsLabel.Text = "I";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(513, 221);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 18;
            // 
            // MossLinkLabel
            // 
            this.MossLinkLabel.AutoSize = true;
            this.MossLinkLabel.Location = new System.Drawing.Point(524, 38);
            this.MossLinkLabel.Name = "MossLinkLabel";
            this.MossLinkLabel.Size = new System.Drawing.Size(0, 13);
            this.MossLinkLabel.TabIndex = 17;
            this.MossLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MossLinkLabel_LinkClicked);
            // 
            // SendRequestButton
            // 
            this.SendRequestButton.Location = new System.Drawing.Point(516, 62);
            this.SendRequestButton.Name = "SendRequestButton";
            this.SendRequestButton.Size = new System.Drawing.Size(255, 23);
            this.SendRequestButton.TabIndex = 15;
            this.SendRequestButton.Text = "Send Request";
            this.SendRequestButton.UseVisualStyleBackColor = true;
            this.SendRequestButton.Click += new System.EventHandler(this.SendRequestButton_Click);
            // 
            // FilesRichTextBox
            // 
            this.FilesRichTextBox.Location = new System.Drawing.Point(9, 91);
            this.FilesRichTextBox.Name = "FilesRichTextBox";
            this.FilesRichTextBox.Size = new System.Drawing.Size(498, 490);
            this.FilesRichTextBox.TabIndex = 14;
            this.FilesRichTextBox.Text = "";
            // 
            // DirectoryModeCheckBox
            // 
            this.DirectoryModeCheckBox.AutoSize = true;
            this.DirectoryModeCheckBox.Location = new System.Drawing.Point(371, 66);
            this.DirectoryModeCheckBox.Name = "DirectoryModeCheckBox";
            this.DirectoryModeCheckBox.Size = new System.Drawing.Size(120, 17);
            this.DirectoryModeCheckBox.TabIndex = 13;
            this.DirectoryModeCheckBox.Text = "Use Directory Mode";
            this.DirectoryModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SourceFilesButton
            // 
            this.SourceFilesButton.Location = new System.Drawing.Point(141, 62);
            this.SourceFilesButton.Name = "SourceFilesButton";
            this.SourceFilesButton.Size = new System.Drawing.Size(126, 23);
            this.SourceFilesButton.TabIndex = 12;
            this.SourceFilesButton.Text = "Choose Source Files";
            this.SourceFilesButton.UseVisualStyleBackColor = true;
            this.SourceFilesButton.Click += new System.EventHandler(this.SourceFilesButton_Click);
            // 
            // BaseFilesButton
            // 
            this.BaseFilesButton.Location = new System.Drawing.Point(9, 62);
            this.BaseFilesButton.Name = "BaseFilesButton";
            this.BaseFilesButton.Size = new System.Drawing.Size(126, 23);
            this.BaseFilesButton.TabIndex = 11;
            this.BaseFilesButton.Text = "Choose Base File(s)";
            this.BaseFilesButton.UseVisualStyleBackColor = true;
            this.BaseFilesButton.Click += new System.EventHandler(this.BaseFilesButton_Click);
            // 
            // ExperimentalServerCheckBox
            // 
            this.ExperimentalServerCheckBox.AutoSize = true;
            this.ExperimentalServerCheckBox.Location = new System.Drawing.Point(349, 37);
            this.ExperimentalServerCheckBox.Name = "ExperimentalServerCheckBox";
            this.ExperimentalServerCheckBox.Size = new System.Drawing.Size(142, 17);
            this.ExperimentalServerCheckBox.TabIndex = 10;
            this.ExperimentalServerCheckBox.Text = "Use Experimental Server";
            this.ExperimentalServerCheckBox.UseVisualStyleBackColor = true;
            // 
            // OptionCTextBox
            // 
            this.OptionCTextBox.Location = new System.Drawing.Point(411, 9);
            this.OptionCTextBox.Name = "OptionCTextBox";
            this.OptionCTextBox.Size = new System.Drawing.Size(363, 20);
            this.OptionCTextBox.TabIndex = 9;
            // 
            // OptionCLabel
            // 
            this.OptionCLabel.AutoSize = true;
            this.OptionCLabel.Location = new System.Drawing.Point(346, 12);
            this.OptionCLabel.Name = "OptionCLabel";
            this.OptionCLabel.Size = new System.Drawing.Size(57, 13);
            this.OptionCLabel.TabIndex = 8;
            this.OptionCLabel.Text = "Option C : ";
            // 
            // OptionNTextBox
            // 
            this.OptionNTextBox.Location = new System.Drawing.Point(280, 35);
            this.OptionNTextBox.Name = "OptionNTextBox";
            this.OptionNTextBox.Size = new System.Drawing.Size(47, 20);
            this.OptionNTextBox.TabIndex = 7;
            // 
            // OptionNLabel
            // 
            this.OptionNLabel.AutoSize = true;
            this.OptionNLabel.Location = new System.Drawing.Point(215, 38);
            this.OptionNLabel.Name = "OptionNLabel";
            this.OptionNLabel.Size = new System.Drawing.Size(58, 13);
            this.OptionNLabel.TabIndex = 6;
            this.OptionNLabel.Text = "Option N : ";
            // 
            // OptionMTextBox
            // 
            this.OptionMTextBox.Location = new System.Drawing.Point(280, 9);
            this.OptionMTextBox.Name = "OptionMTextBox";
            this.OptionMTextBox.Size = new System.Drawing.Size(47, 20);
            this.OptionMTextBox.TabIndex = 5;
            // 
            // OptionMLabel
            // 
            this.OptionMLabel.AutoSize = true;
            this.OptionMLabel.Location = new System.Drawing.Point(215, 12);
            this.OptionMLabel.Name = "OptionMLabel";
            this.OptionMLabel.Size = new System.Drawing.Size(59, 13);
            this.OptionMLabel.TabIndex = 4;
            this.OptionMLabel.Text = "Option M : ";
            // 
            // LanguagesComboBox
            // 
            this.LanguagesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguagesComboBox.FormattingEnabled = true;
            this.LanguagesComboBox.Location = new System.Drawing.Point(76, 35);
            this.LanguagesComboBox.Name = "LanguagesComboBox";
            this.LanguagesComboBox.Size = new System.Drawing.Size(121, 21);
            this.LanguagesComboBox.TabIndex = 3;
            this.LanguagesComboBox.SelectedIndexChanged += new System.EventHandler(this.LanguagesComboBox_SelectedIndexChanged);
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(6, 38);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(64, 13);
            this.LanguageLabel.TabIndex = 2;
            this.LanguageLabel.Text = "Language : ";
            // 
            // UserIdTextBox
            // 
            this.UserIdTextBox.Location = new System.Drawing.Point(76, 9);
            this.UserIdTextBox.Name = "UserIdTextBox";
            this.UserIdTextBox.Size = new System.Drawing.Size(121, 20);
            this.UserIdTextBox.TabIndex = 1;
            // 
            // UserIdLinkLabel
            // 
            this.UserIdLinkLabel.AutoSize = true;
            this.UserIdLinkLabel.Location = new System.Drawing.Point(6, 12);
            this.UserIdLinkLabel.Name = "UserIdLinkLabel";
            this.UserIdLinkLabel.Size = new System.Drawing.Size(50, 13);
            this.UserIdLinkLabel.TabIndex = 0;
            this.UserIdLinkLabel.TabStop = true;
            this.UserIdLinkLabel.Text = "User Id : ";
            this.UserIdLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UserIdLinkLabel_LinkClicked);
            // 
            // BrowserTab
            // 
            this.BrowserTab.Controls.Add(this.WebBrowser);
            this.BrowserTab.Location = new System.Drawing.Point(4, 25);
            this.BrowserTab.Name = "BrowserTab";
            this.BrowserTab.Padding = new System.Windows.Forms.Padding(3);
            this.BrowserTab.Size = new System.Drawing.Size(804, 608);
            this.BrowserTab.TabIndex = 1;
            this.BrowserTab.Text = "Browser";
            this.BrowserTab.UseVisualStyleBackColor = true;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(3, 3);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.Size = new System.Drawing.Size(798, 602);
            this.WebBrowser.TabIndex = 0;
            // 
            // UserIdTab
            // 
            this.UserIdTab.Controls.Add(this.MossMailLabel);
            this.UserIdTab.Controls.Add(this.UserIdInstructionsRichTextBox);
            this.UserIdTab.Controls.Add(this.EmailTextBox);
            this.UserIdTab.Controls.Add(this.EmailLabel);
            this.UserIdTab.Location = new System.Drawing.Point(4, 25);
            this.UserIdTab.Name = "UserIdTab";
            this.UserIdTab.Padding = new System.Windows.Forms.Padding(3);
            this.UserIdTab.Size = new System.Drawing.Size(804, 608);
            this.UserIdTab.TabIndex = 2;
            this.UserIdTab.Text = "Get User Id";
            this.UserIdTab.UseVisualStyleBackColor = true;
            // 
            // MossMailLabel
            // 
            this.MossMailLabel.AutoSize = true;
            this.MossMailLabel.Location = new System.Drawing.Point(91, 292);
            this.MossMailLabel.Name = "MossMailLabel";
            this.MossMailLabel.Size = new System.Drawing.Size(0, 13);
            this.MossMailLabel.TabIndex = 3;
            // 
            // UserIdInstructionsRichTextBox
            // 
            this.UserIdInstructionsRichTextBox.Location = new System.Drawing.Point(9, 6);
            this.UserIdInstructionsRichTextBox.Name = "UserIdInstructionsRichTextBox";
            this.UserIdInstructionsRichTextBox.ReadOnly = true;
            this.UserIdInstructionsRichTextBox.Size = new System.Drawing.Size(765, 229);
            this.UserIdInstructionsRichTextBox.TabIndex = 2;
            this.UserIdInstructionsRichTextBox.Text = "";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(94, 241);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(175, 20);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(6, 244);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(82, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Email Address : ";
            // 
            // OptionToolTip
            // 
            this.OptionToolTip.IsBalloon = true;
            // 
            // ClearFilesButton
            // 
            this.ClearFilesButton.Location = new System.Drawing.Point(273, 63);
            this.ClearFilesButton.Name = "ClearFilesButton";
            this.ClearFilesButton.Size = new System.Drawing.Size(92, 22);
            this.ClearFilesButton.TabIndex = 23;
            this.ClearFilesButton.Text = "Clear Files";
            this.ClearFilesButton.UseVisualStyleBackColor = true;
            this.ClearFilesButton.Click += new System.EventHandler(this.ClearFilesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 637);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "MOSS App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.SubmissionTab.ResumeLayout(false);
            this.SubmissionTab.PerformLayout();
            this.BrowserTab.ResumeLayout(false);
            this.UserIdTab.ResumeLayout(false);
            this.UserIdTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage SubmissionTab;
        private System.Windows.Forms.TextBox OptionNTextBox;
        private System.Windows.Forms.Label OptionNLabel;
        private System.Windows.Forms.TextBox OptionMTextBox;
        private System.Windows.Forms.Label OptionMLabel;
        private System.Windows.Forms.ComboBox LanguagesComboBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.TextBox UserIdTextBox;
        private System.Windows.Forms.LinkLabel UserIdLinkLabel;
        private System.Windows.Forms.TabPage BrowserTab;
        private System.Windows.Forms.TabPage UserIdTab;
        private System.Windows.Forms.LinkLabel MossLinkLabel;
        private System.Windows.Forms.Button SendRequestButton;
        private System.Windows.Forms.RichTextBox FilesRichTextBox;
        private System.Windows.Forms.CheckBox DirectoryModeCheckBox;
        private System.Windows.Forms.Button SourceFilesButton;
        private System.Windows.Forms.Button BaseFilesButton;
        private System.Windows.Forms.CheckBox ExperimentalServerCheckBox;
        private System.Windows.Forms.TextBox OptionCTextBox;
        private System.Windows.Forms.Label OptionCLabel;
        private System.Windows.Forms.RichTextBox UserIdInstructionsRichTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label MossMailLabel;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ToolTip OptionToolTip;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.WebBrowser WebBrowser;
        private System.Windows.Forms.Label RestrictFileTypesLabel;
        private System.Windows.Forms.TextBox RestrictFileTypeTextBox;
        private System.Windows.Forms.CheckBox RestrictFileTypesCheckBox;
        private System.Windows.Forms.Button ClearFilesButton;
    }
}


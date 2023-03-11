// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainForm.cs" company="NWACC">
//   The MIT License (MIT)
//
// Copyright(c) 2014 Shane Carroll May
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </copyright>
// <summary>
//   Main form of the MOSS (Measure Of Software Similarity) App.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace MossApp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    using MossApp.Properties;

    using static MossApp.Properties.Settings;

    /// <summary>
    /// Main form for the MOSS App.
    /// </summary>namespace MossApp
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
            this.RequestProgressBar = new System.Windows.Forms.ProgressBar();
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
            this.SubmissionTab.Controls.Add(this.RequestProgressBar);
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
            // RequestProgressBar
            // 
            this.RequestProgressBar.AccessibleDescription = "A request to the Moss server is in progress.";
            this.RequestProgressBar.Cursor = System.Windows.Forms.Cursors.Default;
            this.RequestProgressBar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RequestProgressBar.Location = new System.Drawing.Point(516, 40);
            this.RequestProgressBar.MarqueeAnimationSpeed = 30;
            this.RequestProgressBar.Name = "RequestProgressBar";
            this.RequestProgressBar.Size = new System.Drawing.Size(255, 16);
            this.RequestProgressBar.Step = 5;
            this.RequestProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.RequestProgressBar.TabIndex = 24;
            this.OptionToolTip.SetToolTip(this.RequestProgressBar, "Waiting for a response from Moss server.");
            this.RequestProgressBar.Visible = false;
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
        private System.Windows.Forms.ProgressBar RequestProgressBar;
    }
}


    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        /// <summary>
        /// All files command
        /// </summary>
        private const string AllFiles = "*.*";

        /// <summary>
        /// The dialog box used to find base and source files. 
        /// </summary>
        private FolderBrowserDialog dialog;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the base file list.
        /// </summary>
        /// <value>
        /// The base file list.
        /// </value>
        private List<string> BaseFileList { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the source file list.
        /// </summary>
        /// <value>
        /// The source file list.
        /// </value>
        private List<string> SourceFileList { get; set; } = new List<string>();

        /// <summary>
        /// Gets or sets the languages.
        /// </summary>
        /// <value>
        /// The languages and their associated file extensions.
        /// </value>
        private Dictionary<string, List<string>> Languages { get; set; } = new Dictionary<string, List<string>>();

        #region "Event Handlers"

        /// <summary>
        /// Handles the LinkClicked event of the UserIdLinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void UserIdLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.TabControl.SelectedTab = this.UserIdTab;
        }

        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set instructions on the form. 
            this.UserIdInstructionsRichTextBox.Text = Resources.Moss_Requesting_Instructions;
            this.InstructionsLabel.Text = Resources.Tool_Tip_Insructions;
            this.RestrictFileTypesLabel.Text = Resources.Restrict_Files_Instructions;

            // Read default values from setting file. 
            int setting = Default.UserId;
            this.UserIdTextBox.Text = setting == 0 ? string.Empty : setting.ToString();
            setting = Default.OptionM;
            this.OptionMTextBox.Text = setting == 0 ? string.Empty : setting.ToString();
            setting = Default.OptionN;
            this.OptionNTextBox.Text = setting == 0 ? string.Empty : setting.ToString();
            this.OptionCTextBox.Text = Default.OptionC;

            // Set up dialog box. 
            this.dialog = new FolderBrowserDialog
                              {
                                  ShowNewFolderButton = false, RootFolder = Environment.SpecialFolder.Desktop
                              };

            // Set up languages
            // this.LanguagesComboBox.DataSource = Default.Languages;
            this.ParseLanguageSettings();
            this.LanguagesComboBox.SelectedIndexChanged -= this.LanguagesComboBox_SelectedIndexChanged;
            this.LanguagesComboBox.DataSource = new BindingSource(this.Languages, null);
            this.LanguagesComboBox.DisplayMember = "Key";
            this.LanguagesComboBox.ValueMember = "Key";
            this.LanguagesComboBox.SelectedIndexChanged += this.LanguagesComboBox_SelectedIndexChanged;
            this.RestrictFileTypeTextBox.Text = string.Join(",", this.Languages[this.Languages.First().Key]);

            // Set up tool tips. 
            this.OptionToolTip.SetToolTip(this.OptionMLabel, Resources.Option_M_Tool_Tip);
            this.OptionToolTip.SetToolTip(this.BaseFilesButton, Resources.Option_B_Tool_Tip);
            this.OptionToolTip.SetToolTip(this.ExperimentalServerCheckBox, Resources.Option_Beta_Tool_Tip);
            this.OptionToolTip.SetToolTip(this.OptionNLabel, Resources.Option_N_Tool_Tip);
            this.OptionToolTip.SetToolTip(this.OptionCLabel, Resources.Option_C_Tool_Tip);
            this.OptionToolTip.SetToolTip(this.DirectoryModeCheckBox, Resources.Option_D_Tool_Tip);
            this.OptionToolTip.SetToolTip(this.UserIdLinkLabel, Resources.User_Id_Tool_Tip);
        }

        /// <summary>
        /// Handles the TextChanged event of the EmailTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            this.MossMailLabel.Text = string.Format(
                Resources.Moss_Email_Format_String,
                Resources.Email_Moss_ID_Request,
                this.EmailTextBox.Text);

            Clipboard.SetText($"{Resources.Email_Clip_Board}{this.EmailTextBox.Text}");
        }

        /// <summary>
        /// Handles the Click event of the SendRequestButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SendRequestButton_Click(object sender, EventArgs e)
        {
            if (this.IsValidForm())
            {
                this.ErrorLabel.Text = string.Empty;
                Default.UserId = Convert.ToInt32(this.UserIdTextBox.Text);
                Default.OptionM = Convert.ToInt32(this.OptionMTextBox.Text);
                Default.OptionN = Convert.ToInt32(this.OptionNTextBox.Text);
                Default.OptionC = this.OptionCTextBox.Text;
                Default.Save();

                var request = new MossRequest
                                  {
                                      UserId = Convert.ToInt32(this.UserIdTextBox.Text),
                                      IsDirectoryMode = this.DirectoryModeCheckBox.Checked,
                                      IsBetaRequest = this.ExperimentalServerCheckBox.Checked,
                                      Comments = this.OptionCTextBox.Text,
                                      Language = this.LanguagesComboBox.SelectedValue.ToString(),
                                      NumberOfResultsToShow = Convert.ToInt32(this.OptionNTextBox.Text),
                                      MaxMatches = Convert.ToInt32(this.OptionMTextBox.Text)
                                  };

                request.BaseFile.AddRange(this.BaseFileList);
                request.Files.AddRange(this.SourceFileList);

                if (request.SendRequest(out var response))
                {
                    this.MossLinkLabel.Text = response;
                    this.WebBrowser.Navigate(new Uri(response));
                }
                else
                {
                    MessageBox.Show(
                        response,
                        Resources.Request_Error_Caption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Handles the LinkClicked event of the MossLinkLabel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void MossLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(this.MossLinkLabel.Text);
            Process.Start(this.MossLinkLabel.Text);
        }

        /// <summary>
        /// Handles the Click event of the BaseFilesButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BaseFilesButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dialog.Description = Resources.BaseFile_Dialog_Description;
                var result = this.dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    // var folderName = this.dialog.SelectedPath;
                    // this.BaseFileList = Directory.GetFiles(folderName, AllFiles, SearchOption.AllDirectories).ToList();
                    var folderName = this.dialog.SelectedPath;
                    if (this.RestrictFileTypesCheckBox.Checked)
                    {
                        var extensions = this.GetRestrictedFileTypes();
                        this.BaseFileList = Directory.GetFiles(folderName, AllFiles, SearchOption.AllDirectories)
                            .Where(ext => extensions.Contains(Path.GetExtension(ext))).ToList();
                    }
                    else
                    {
                        this.BaseFileList = Directory.GetFiles(folderName, AllFiles, SearchOption.AllDirectories).ToList();
                    }
                } // else, user did not click ok DoNothing();

                this.UpdateFileList();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    Resources.Unauthorized_Access_Error,
                    Resources.Unauthorized_Access_Error_Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the Click event of the SourceFilesButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SourceFilesButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dialog.Description = Resources.SourceFile_Dialog_Description;
                var result = this.dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var folderName = this.dialog.SelectedPath;
                    if (this.RestrictFileTypesCheckBox.Checked)
                    {
                        var extensions = this.GetRestrictedFileTypes();
                        this.SourceFileList = Directory.GetFiles(folderName, AllFiles, SearchOption.AllDirectories)
                            .Where(ext => extensions.Contains(Path.GetExtension(ext))).ToList();
                    }
                    else
                    {
                        this.SourceFileList = Directory.GetFiles(folderName, AllFiles, SearchOption.AllDirectories)
                            .ToList();
                    }
                } // else, user did not click ok DoNothing();

                this.UpdateFileList();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    Resources.Unauthorized_Access_Error,
                    Resources.Unauthorized_Access_Error_Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /// <summary>Handles the CheckedChanged event of the RestrictFileTypesCheckBox control.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void RestrictFileTypesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var extensions = this.GetRestrictedFileTypes();
            if (extensions.Count > 0)
            {
                if (this.SourceFileList.Count > 0)
                {
                    this.SourceFileList = this.SourceFileList.Where(file => extensions.Any(file.EndsWith)).ToList();
                } // else, no source files to filter, DoNothing();

                if (this.BaseFileList.Count > 0)
                {
                    this.BaseFileList = this.BaseFileList.Where(file => extensions.Any(file.EndsWith)).ToList();
                } // else, no base files to filter, DoNothing();

                this.UpdateFileList();
            } // else, no extensions, DoNothing();
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the LanguagesComboBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void LanguagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PopulateRestrictedFiles();
        }

        /// <summary>
        /// Handles the Click event of the ClearFilesButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearFilesButton_Click(object sender, EventArgs e)
        {
            this.SourceFileList.Clear();
            this.BaseFileList.Clear();
            this.FilesRichTextBox.Clear();
        }

        #endregion

        /// <summary>
        /// Updates the file list.
        /// </summary>
        private void UpdateFileList()
        {
            var builder = new StringBuilder();
            if (this.BaseFileList.Count > 0)
            {
                builder.AppendLine(Resources.FileList_BaseFiles);
                builder.AppendLine("----------------------------------------------");
                foreach (var file in this.BaseFileList)
                {
                    builder.AppendLine(file);
                }
            }

            builder.AppendLine(string.Empty);
            if (this.SourceFileList.Count > 0)
            {
                builder.AppendLine(Resources.FileList_SourceFile);
                builder.AppendLine("----------------------------------------------");
                foreach (var file in this.SourceFileList)
                {
                    builder.AppendLine(file);
                }
            }

            this.FilesRichTextBox.Text = builder.ToString();
        }

        /// <summary>
        /// Determines whether the form is valid.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the form is valid; otherwise, <c>false</c>.
        /// </returns>
        private bool IsValidForm()
        {
            if (!this.IsValidPositiveInteger(this.UserIdTextBox))
            {
                this.ErrorLabel.Text = Resources.UserId_Error;
                return false;
            } // else this field is valid DoNothing();

            if (!this.IsValidPositiveInteger(this.OptionMTextBox))
            {
                this.ErrorLabel.Text = Resources.OptionM_Error;
                return false;
            } // else this field is valid DoNothing();

            if (!this.IsValidPositiveInteger(this.OptionNTextBox))
            {
                this.ErrorLabel.Text = Resources.OptionN_Error;
                return false;
            } // else this field is valid DoNothing();

            if (this.SourceFileList.Count == 0)
            {
                this.ErrorLabel.Text = Resources.File_List_Empty_Error;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Determines whether the text box contains is a valid positive integer value.
        /// </summary>
        /// <param name="textBox">The text box.</param>
        /// <returns>
        ///   <c>true</c> if the text box contains is a valid positive integer value; otherwise, <c>false</c>.
        /// </returns>
        private bool IsValidPositiveInteger(Control textBox)
        {
            return int.TryParse(textBox?.Text, out var value) && value >= 0;
        }

        /// <summary>
        /// Parses the language settings into the Language Dictionary of
        /// Languages => extensions.
        /// </summary>
        private void ParseLanguageSettings()
        {
            var languageList = Default.Languages;
            foreach (var language in languageList)
            {
                var tokens = language.Split(',');
                this.Languages.Add(tokens[0], new List<string>());
                for (var index = 1; index < tokens.Length; index++)
                {
                    this.Languages[tokens[0]].Add(tokens[index]);
                }

                // because this setting is created with a specific format, this 
                // should never fail. If it does, the underlying data source needs to be 
                // fixed. 
            }
        }

        /// <summary>
        /// Gets the restricted file types as a list.
        /// </summary>
        /// <returns>
        /// A list of files types to accept.
        /// </returns>
        private List<string> GetRestrictedFileTypes()
        {
            var files = this.RestrictFileTypeTextBox.Text;
            return files.Length > 0 ? files.Split(',').ToList() : new List<string>();
        }

        /// <summary>
        /// Populates the restricted files based on the selected file type.
        /// </summary>
        private void PopulateRestrictedFiles()
        {
            var chosenLanguage = this.LanguagesComboBox.SelectedValue.ToString();
            this.RestrictFileTypeTextBox.Text = string.Join(",", this.Languages[chosenLanguage]);
        }
    }
}

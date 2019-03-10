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
    /// </summary>
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
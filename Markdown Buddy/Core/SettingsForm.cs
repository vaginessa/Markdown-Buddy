using Markdown_Buddy.Properties;
using System;
using System.Windows.Forms;

namespace Markdown_Buddy.Core
{
    public partial class SettingsForm : Form
    {
        /// <summary>
        /// Settings changed event delegate
        /// </summary>
        public delegate void SettingsChangedEvent();
        public SettingsChangedEvent SettingsChanged;

        public SettingsForm()
        {
            InitializeComponent();

            // Load the settings
            this.loadSettings();
        }

        /// <summary>
        /// Loads settings and populates necessary controls
        /// </summary>
        private void loadSettings()
        {
            this.loadFontSettings();
        }

        /// <summary>
        /// Loads the font settings and populates controls
        /// </summary>
        private void loadFontSettings()
        {
            lblFontValue.Text = Settings.Default.font;
            lblFontSizeValue.Text = Settings.Default.fontSize.ToString();
            lblFontStyleValue.Text = Settings.Default.fontStyle;
        }

        /// <summary>
        /// Handles click event for the cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();
            this.Close();
        }

        /// <summary>
        /// Handles the select font button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFont_Click(object sender, EventArgs e)
        {
            // Load the font dialog
            DialogResult result = fontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.Drawing.Font font = fontDialog.Font;

                Settings.Default.font = font.Name;
                Settings.Default.fontSize = (int)font.Size;
                Settings.Default.fontStyle = font.Style.ToString();

                // Update settings display
                this.loadFontSettings();
            }
        }

        /// <summary>
        /// Handles the click event for the save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            SettingsChanged();
            this.Close();
        }
    }
}

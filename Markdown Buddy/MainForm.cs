using Markdown_Buddy.Core;
using Markdown_Buddy.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Markdown_Buddy
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// The app controller reference
        /// </summary>
        private Editor editor = new Editor();

        /// <summary>
        /// The markdown preview controller
        /// </summary>
        private MarkdownPreview preview = new MarkdownPreview();

        public MainForm()
        {
            InitializeComponent();
            editor.SetViewPane(editorPane);
            preview.SetMarkdownPreviewPane(markdownPreviewPane);

            // Load settings
            this.settingsChanged();

            // Create a default, empty document
            editor.UpdateDocument(new Document(null));
        }

        /// <summary>
        /// Triggered when settings change
        /// </summary>
        private void settingsChanged()
        {
            this.updateFont();
        }

        /// <summary>
        /// Updates the font settings.
        /// </summary>
        private void updateFont()
        {
            // Adjust editor font
            Font editorFont = new Font(new FontFamily(Settings.Default.font), Settings.Default.fontSize);
            this.editorPane.Font = editorFont;
        }

        /// <summary>
        /// Handles click event for menu items
        /// </summary>
        /// <param name="sender">The sender</param>
        /// <param name="e">The event args</param>
        private void toolstripMenuItem_Click(object sender, EventArgs e)
        {
            string menuItem = ((ToolStripMenuItem)sender).Name;
            switch (menuItem)
            {
                ////
                // File Menu
                ////

                // File->New
                case "newMenuItem":
                    editor.CloseRequested();
                    editor.UpdateDocument(new Document(null));
                    break;
                // File->Open
                case "openMenuItem":
                    Document doc = Document.Open();
                    if (doc != null)
                    {
                        editor.UpdateDocument(doc);
                    }
                    break;
                // File->Save
                case "saveMenuItem":
                    editor.Save();
                    break;
                // File->Save As
                case "saveAsMenuItem":
                    editor.Save(true);
                    break;
                // File->Exit
                case "exitMenuItem":
                    editor.CloseRequested();
                    Application.Exit();
                    break;

                ////
                // Edit Menu
                ////

                // Edit->Settings
                case "settingsMenuItem":
                    SettingsForm settingsForm = new SettingsForm();
                    settingsForm.SettingsChanged += settingsChanged;
                    settingsForm.Show(this);
                    break;

                ////
                // View Menu
                ////

                // View->Toggle Preview
                case "togglePreviewMenuItem":
                    // Toggles the visibility of the preview pane
                    if (markdownSplitContainer.Panel2Collapsed)
                    {
                        markdownSplitContainer.Panel2Collapsed = false;
                        markdownSplitContainer.Panel2.Show();
                    }
                    else
                    {
                        markdownSplitContainer.Panel2Collapsed = true;
                        markdownSplitContainer.Panel2.Hide();
                    }
                    break;
            }
        }

        /// <summary>
        /// Handles the form closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            editor.CloseRequested();
        }

        /// <summary>
        /// Handles the text change event for the editor pane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editorPane_TextChanged(object sender, EventArgs e)
        {
            editor.TextChangedCallback();

            // Update the preview
            if (!markdownSplitContainer.Panel2Collapsed)
            {
                preview.UpdatePreview(editor.GetText());
            }
        }

    }
}

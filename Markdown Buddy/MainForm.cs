using Markdown_Buddy.Core;
using System;
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

            // Create a default, empty document
            editor.UpdateDocument(new Document(null));
        }

        /// <summary>
        /// Handles the exit menu item from the file menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.CloseRequested();
            Application.Exit();
        }

        /// <summary>
        /// Handles the open menu item click within the file menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Document doc = Document.Open();
            if (doc != null)
            {
                editor.UpdateDocument(doc);
            }
        }

        /// <summary>
        /// Handles the new menu item click in the file menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.CloseRequested();
            editor.UpdateDocument(new Document(null));
        }

        /// <summary>
        /// Handles the toggle preview menu item click in View menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void togglePreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Toggles the visibility of the preview pane
            if (markdownSplitContainer.Panel2Collapsed)
            {
                markdownSplitContainer.Panel2Collapsed = false;
                markdownSplitContainer.Panel2.Show();
            } else
            {
                markdownSplitContainer.Panel2Collapsed = true;
                markdownSplitContainer.Panel2.Hide();
            }
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
        /// Handles save button file menu click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Save();
        }
    }
}

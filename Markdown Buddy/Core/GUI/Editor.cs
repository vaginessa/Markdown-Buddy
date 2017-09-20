using System.Windows.Forms;

namespace Markdown_Buddy.Core
{
    /// <summary>
    /// Acts as a controller for the editor
    /// </summary>
    class Editor
    {

        private bool unsavedChanges = false;

        /// <summary>
        /// reference to the editor pane
        /// </summary>
        private RichTextBox editorPane;

        /// <summary>
        /// The currently open document
        /// </summary>
        private Document _currentDocument = null;
        public Document CurrentDocument
        {
            get { return _currentDocument; }
            set { _currentDocument = value; }
        }

        /// <summary>
        /// Sets the GUI editor pane reference
        /// </summary>
        /// <param name="editorPane">Reference to the editor pane</param>
        public void SetViewPane(RichTextBox editorPane)
        {
            this.editorPane = editorPane;
        }

        /// <summary>
        /// Updates the current document
        /// </summary>
        /// <param name="document">The current document</param>
        public void UpdateDocument(Document document)
        {
            this.CurrentDocument = document;
            this.Refresh();
            this.unsavedChanges = false;
        }

        /// <summary>
        /// Callback for when text in our editor is changed
        /// </summary>
        public void TextChangedCallback()
        {
            unsavedChanges = true;
            CurrentDocument.Text = editorPane.Text;
        }

        /// <summary>
        /// Refreshes the editor
        /// </summary>
        public void Refresh()
        {
            editorPane.Text = CurrentDocument.Text;
        }

        /// <summary>
        /// Saves the current document
        /// </summary>
        public void Save()
        {
            CurrentDocument.Save();
            unsavedChanges = false;
        }

        /// <summary>
        /// Handles end cleanup when a close is requested
        /// </summary>
        public void CloseRequested()
        {
            // Ask to save unsaved changes
            if (unsavedChanges)
            {
                var confirmDialog = MessageBox.Show("Save changes before closing?",
                    "Unsaved Changes", MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    this.Save();
                }
            }
        }

        /// <summary>
        /// Gets the text of the current document
        /// </summary>
        /// <returns>The text of the current document</returns>
        public string GetText()
        {
            return CurrentDocument.Text;
        }

    }
}

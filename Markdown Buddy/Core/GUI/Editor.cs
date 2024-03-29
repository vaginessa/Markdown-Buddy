﻿using Markdown_Buddy.Core.Util;
using System.Windows.Forms;

namespace Markdown_Buddy.Core
{
    /// <summary>
    /// Acts as a controller for the editor
    /// </summary>
    class Editor
    {
        /// <summary>
        /// Tracks rather the document has unsaved changes
        /// </summary>
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
        public void Save(bool saveAs=false)
        {
            CurrentDocument.Save(saveAs);
            unsavedChanges = false;
        }

        /// <summary>
        /// Handles end cleanup when a close is requested
        /// </summary>
        public void CloseRequested()
        {
            // Ask to save unsaved changes
            if (unsavedChanges && CurrentDocument.Text != "")
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

        /// <summary>
        /// Inserts into the editor based on a code
        /// </summary>
        /// <param name="code">Signifies what to insert I.E. Bold, Italic, etc.</param>
        public void insert(string code)
        {
            switch (code)
            {
                case "bold":
                    editorPane.SelectedText = TextUtil.InsertBeginningEnd(editorPane.SelectedText, "**");
                    break;
                case "italic":
                    editorPane.SelectedText = TextUtil.InsertBeginningEnd(editorPane.SelectedText, "*");
                    break;
                case "h1":
                    editorPane.SelectedText = TextUtil.InsertBeginning(editorPane.SelectedText, "# ");
                    break;
                case "h2":
                    editorPane.SelectedText = TextUtil.InsertBeginning(editorPane.SelectedText, "## ");
                    break;
                case "h3":
                    editorPane.SelectedText = TextUtil.InsertBeginning(editorPane.SelectedText, "### ");
                    break;
                case "h4":
                    editorPane.SelectedText = TextUtil.InsertBeginning(editorPane.SelectedText, "#### ");
                    break;
                case "h5":
                    editorPane.SelectedText = TextUtil.InsertBeginning(editorPane.SelectedText, "##### ");
                    break;
            }
        }

    }
}

using Markdown_Buddy.Core.GUI;

namespace Markdown_Buddy.Core.IO
{
    /// <summary>
    /// Handles saving files to disk
    /// </summary>
    class SaveHandler
    {

        /// <summary>
        /// Document saved event delegate
        /// </summary>
        public delegate void DocumentSavedEvent(string path);
        public DocumentSavedEvent DocumentSaved;

        /// <summary>
        /// Saves a string to given path
        /// </summary>
        /// <param name="text">The string to write</param>
        /// <param name="path">The path to write to</param>
        public void SaveString(string text, string path)
        {
            if (path == null)
            {
                string getPath = SaveDialogHandler.SaveDialog();
                if (getPath != "")
                    // TODO: Fix crash when no path selected!
                    path = getPath;
                else
                    return;
            }

            System.IO.File.WriteAllText(path, text);

            // Emit the document saved signal
            DocumentSaved(path);
        }

    }
}

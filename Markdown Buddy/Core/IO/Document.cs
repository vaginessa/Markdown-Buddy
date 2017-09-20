using Markdown_Buddy.Core.IO;
using System.Windows.Forms;

namespace Markdown_Buddy.Core
{
    class Document
    {
        /// <summary>
        /// The text stored in this document
        /// </summary>
        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        /// <summary>
        /// The path on disk to the physical file
        /// </summary>
        private string _path;
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        /// <summary>
        /// Initializes document with text but no path
        /// </summary>
        /// <param name="text">The text to set</param>
        public Document(string text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes document with given text
        /// </summary>
        /// <param name="text">The text to set</param>
        /// <param name="path">The path on disk to the file</param>
        public Document(string text, string path)
        {
            this.Text = text;
            this.Path = path;
        }

        /// <summary>
        /// Saves the document to disk
        /// </summary>
        public void Save()
        {
            SaveHandler.SaveString(this.Text, this.Path);
        }

        /// <summary>
        /// Opens and returns a reference to a document on disk
        /// </summary>
        /// <returns>Reference to the document, else null</returns>
        public static Document Open()
        {
            string path = GUI.OpenDialogHandler.Open();

            if (path != null)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(path);
                Document doc = new Document(sr.ReadToEnd(), path);
                sr.Close();
                return doc;
            }
            return null;
        }
    }
}

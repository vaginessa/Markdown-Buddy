using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (this.Path != null)
            {
                // Save to original path
                this.write(this.Path);
            } else
            {
                // We need to prompt for a save path
            }
        }

        /// <summary>
        /// Writes all text to file on disk
        /// </summary>
        /// <param name="path"> The path to write to</param>
        private void write(string path)
        {
            System.IO.File.WriteAllText(path, this.Text);
        }
    }
}

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
        /// Initializes document with given text
        /// </summary>
        /// <param name="text">The text to set</param>
        public Document(string text)
        {
            this.Text = text;
        }
    }
}

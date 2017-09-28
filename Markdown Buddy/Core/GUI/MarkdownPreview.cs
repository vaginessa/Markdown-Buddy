using Markdown_Buddy.Properties;
using System.Windows.Forms;

namespace Markdown_Buddy.Core
{
    class MarkdownPreview
    {

        /// <summary>
        /// Reference to the markdown preview pane
        /// </summary>
        private WebBrowser markdownPreviewPane;

        /// <summary>
        /// Sets the reference to the markdown preview pane
        /// </summary>
        /// <param name="markdownPreviewPane">The markdown preview pane</param>
        public void SetMarkdownPreviewPane(WebBrowser markdownPreviewPane)
        {
            this.markdownPreviewPane = markdownPreviewPane;
        }

        /// <summary>
        /// Updates the preview
        /// </summary>
        /// <param name="text">The markdown text to preview</param>
        public void UpdatePreview(string text)
        {
            string preview = "<style>*{font-family: " + Settings.Default.font + "; font-size:" + Settings.Default.fontSize + "pt;}</style>";
            string compiledMd = this.generatePreview(text);
            preview += compiledMd;

            markdownPreviewPane.DocumentText = this.generatePreview(preview);
        }

        /// <summary>
        /// Generates a markdown preview
        /// </summary>
        /// <param name="text">The text to generate a preview for</param>
        /// <returns>The compiled markdown</returns>
        private string generatePreview(string text)
        {
            return CommonMark.CommonMarkConverter.Convert(text);
        }

    }
}

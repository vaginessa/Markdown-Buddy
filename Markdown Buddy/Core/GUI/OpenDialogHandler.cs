using System.Windows.Forms;

namespace Markdown_Buddy.Core.GUI
{
    class OpenDialogHandler
    {

        /// <summary>
        /// Displays an open file dialog and returns result
        /// </summary>
        /// <returns>Path to file to open</returns>
        public static string Open()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Document";
            dialog.Filter = "Markdown Files|*.md;*.markdown;*.mdown;*.mkdn;*.mkd;*.mdwn;*.mdtxt;*.mdtext;*.text;*.Rmd|Text Files|*.txt|All Files|*.*";

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }

    }
}

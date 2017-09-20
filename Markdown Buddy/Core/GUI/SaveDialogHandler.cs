using System.Windows.Forms;

namespace Markdown_Buddy.Core.GUI
{
    /// <summary>
    /// A simple handler class for save file dialogs
    /// </summary>
    class SaveDialogHandler
    {
       
        /// <summary>
        /// Displays and returns result from save file dialog
        /// </summary>
        /// <returns>Result from save file dialog</returns>
        public static string SaveDialog()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save Document";
            dialog.ShowDialog();

            return dialog.FileName;
        }

    }
}

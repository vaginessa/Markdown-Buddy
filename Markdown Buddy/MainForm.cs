﻿using Markdown_Buddy.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Markdown_Buddy
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// The app controller reference
        /// </summary>
        private Editor editor = new Editor();

        public MainForm()
        {
            InitializeComponent();
            editor.SetViewPane(editorPane);
        }

        /// <summary>
        /// Handles the exit menu item from the file menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Handles the open menu item click within the file menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opens a document for editing
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                Document doc = new Document(sr.ReadToEnd());
                editor.UpdateDocument(doc);
                sr.Close();
            }
        }

        /// <summary>
        /// Handles the new menu item click in the file menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
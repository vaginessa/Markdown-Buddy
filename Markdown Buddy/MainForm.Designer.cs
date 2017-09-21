namespace Markdown_Buddy
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.togglePreviewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markdownSplitContainer = new System.Windows.Forms.SplitContainer();
            this.editorPane = new System.Windows.Forms.RichTextBox();
            this.markdownPreviewPane = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markdownSplitContainer)).BeginInit();
            this.markdownSplitContainer.Panel1.SuspendLayout();
            this.markdownSplitContainer.Panel2.SuspendLayout();
            this.markdownSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newMenuItem.Text = "New";
            this.newMenuItem.Click += new System.EventHandler(this.toolstripMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.toolstripMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.toolstripMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.toolstripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.togglePreviewMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // togglePreviewMenuItem
            // 
            this.togglePreviewMenuItem.Name = "togglePreviewMenuItem";
            this.togglePreviewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.togglePreviewMenuItem.Size = new System.Drawing.Size(227, 22);
            this.togglePreviewMenuItem.Text = "Toggle Preview";
            this.togglePreviewMenuItem.Click += new System.EventHandler(this.toolstripMenuItem_Click);
            // 
            // markdownSplitContainer
            // 
            this.markdownSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markdownSplitContainer.Location = new System.Drawing.Point(0, 24);
            this.markdownSplitContainer.Name = "markdownSplitContainer";
            // 
            // markdownSplitContainer.Panel1
            // 
            this.markdownSplitContainer.Panel1.Controls.Add(this.editorPane);
            // 
            // markdownSplitContainer.Panel2
            // 
            this.markdownSplitContainer.Panel2.Controls.Add(this.markdownPreviewPane);
            this.markdownSplitContainer.Size = new System.Drawing.Size(917, 655);
            this.markdownSplitContainer.SplitterDistance = 517;
            this.markdownSplitContainer.TabIndex = 1;
            // 
            // editorPane
            // 
            this.editorPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorPane.Location = new System.Drawing.Point(0, 0);
            this.editorPane.Name = "editorPane";
            this.editorPane.Size = new System.Drawing.Size(517, 655);
            this.editorPane.TabIndex = 0;
            this.editorPane.Text = "";
            this.editorPane.TextChanged += new System.EventHandler(this.editorPane_TextChanged);
            // 
            // markdownPreviewPane
            // 
            this.markdownPreviewPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markdownPreviewPane.Location = new System.Drawing.Point(0, 0);
            this.markdownPreviewPane.MinimumSize = new System.Drawing.Size(20, 20);
            this.markdownPreviewPane.Name = "markdownPreviewPane";
            this.markdownPreviewPane.Size = new System.Drawing.Size(396, 655);
            this.markdownPreviewPane.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 679);
            this.Controls.Add(this.markdownSplitContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Markdown Buddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.markdownSplitContainer.Panel1.ResumeLayout(false);
            this.markdownSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.markdownSplitContainer)).EndInit();
            this.markdownSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.SplitContainer markdownSplitContainer;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem togglePreviewMenuItem;
        private System.Windows.Forms.RichTextBox editorPane;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.WebBrowser markdownPreviewPane;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
    }
}


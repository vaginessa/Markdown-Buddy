namespace Markdown_Buddy.Core
{
    partial class SettingsForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxFonts = new System.Windows.Forms.GroupBox();
            this.lblFontStyleValue = new System.Windows.Forms.Label();
            this.lblFontStyle = new System.Windows.Forms.Label();
            this.lblFontSizeValue = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblFontValue = new System.Windows.Forms.Label();
            this.lblFont = new System.Windows.Forms.Label();
            this.btnSelectFont = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.groupBoxFonts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(247, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(166, 176);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxFonts
            // 
            this.groupBoxFonts.Controls.Add(this.lblFontStyleValue);
            this.groupBoxFonts.Controls.Add(this.lblFontStyle);
            this.groupBoxFonts.Controls.Add(this.lblFontSizeValue);
            this.groupBoxFonts.Controls.Add(this.lblFontSize);
            this.groupBoxFonts.Controls.Add(this.lblFontValue);
            this.groupBoxFonts.Controls.Add(this.lblFont);
            this.groupBoxFonts.Controls.Add(this.btnSelectFont);
            this.groupBoxFonts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxFonts.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFonts.Name = "groupBoxFonts";
            this.groupBoxFonts.Size = new System.Drawing.Size(309, 152);
            this.groupBoxFonts.TabIndex = 2;
            this.groupBoxFonts.TabStop = false;
            this.groupBoxFonts.Text = "Font";
            // 
            // lblFontStyleValue
            // 
            this.lblFontStyleValue.AutoSize = true;
            this.lblFontStyleValue.Location = new System.Drawing.Point(66, 84);
            this.lblFontStyleValue.Name = "lblFontStyleValue";
            this.lblFontStyleValue.Size = new System.Drawing.Size(91, 13);
            this.lblFontStyleValue.TabIndex = 7;
            this.lblFontStyleValue.Text = "Current Font Style";
            // 
            // lblFontStyle
            // 
            this.lblFontStyle.AutoSize = true;
            this.lblFontStyle.Location = new System.Drawing.Point(3, 84);
            this.lblFontStyle.Name = "lblFontStyle";
            this.lblFontStyle.Size = new System.Drawing.Size(57, 13);
            this.lblFontStyle.TabIndex = 6;
            this.lblFontStyle.Text = "Font Style:";
            // 
            // lblFontSizeValue
            // 
            this.lblFontSizeValue.AutoSize = true;
            this.lblFontSizeValue.Location = new System.Drawing.Point(66, 56);
            this.lblFontSizeValue.Name = "lblFontSizeValue";
            this.lblFontSizeValue.Size = new System.Drawing.Size(88, 13);
            this.lblFontSizeValue.TabIndex = 5;
            this.lblFontSizeValue.Text = "Current Font Size";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(6, 56);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(54, 13);
            this.lblFontSize.TabIndex = 3;
            this.lblFontSize.Text = "Font Size:";
            // 
            // lblFontValue
            // 
            this.lblFontValue.AutoSize = true;
            this.lblFontValue.Location = new System.Drawing.Point(66, 30);
            this.lblFontValue.Name = "lblFontValue";
            this.lblFontValue.Size = new System.Drawing.Size(65, 13);
            this.lblFontValue.TabIndex = 4;
            this.lblFontValue.Text = "Current Font";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(26, 30);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(34, 13);
            this.lblFont.TabIndex = 3;
            this.lblFont.Text = "Font: ";
            // 
            // btnSelectFont
            // 
            this.btnSelectFont.Location = new System.Drawing.Point(228, 118);
            this.btnSelectFont.Name = "btnSelectFont";
            this.btnSelectFont.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFont.TabIndex = 0;
            this.btnSelectFont.Text = "Select...";
            this.btnSelectFont.UseVisualStyleBackColor = true;
            this.btnSelectFont.Click += new System.EventHandler(this.btnSelectFont_Click);
            // 
            // fontDialog
            // 
            this.fontDialog.AllowScriptChange = false;
            this.fontDialog.AllowVerticalFonts = false;
            this.fontDialog.ShowEffects = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.groupBoxFonts);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximumSize = new System.Drawing.Size(350, 250);
            this.MinimumSize = new System.Drawing.Size(350, 250);
            this.Name = "SettingsForm";
            this.Text = "Markdown Buddy Settings";
            this.groupBoxFonts.ResumeLayout(false);
            this.groupBoxFonts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBoxFonts;
        private System.Windows.Forms.Button btnSelectFont;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.Label lblFontValue;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblFontSizeValue;
        private System.Windows.Forms.Label lblFontStyleValue;
        private System.Windows.Forms.Label lblFontStyle;
    }
}
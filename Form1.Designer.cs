namespace ADitor
{
    partial class Aditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aditor));
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutThisEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpVersion = new System.Windows.Forms.ToolStripTextBox();
            this.ActivePanel = new System.Windows.Forms.Panel();
            this.WritingArea = new System.Windows.Forms.RichTextBox();
            this.FileSave = new System.Windows.Forms.SaveFileDialog();
            this.FileOpen = new System.Windows.Forms.OpenFileDialog();
            this.FilePrint = new System.Windows.Forms.PrintDialog();
            this.FilePrintPrev = new System.Windows.Forms.PrintPreviewDialog();
            this.MenuBar.SuspendLayout();
            this.ActivePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.MenuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aBOUTToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(1314, 36);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.toolStripSeparator3,
            this.themeToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 32);
            this.fileToolStripMenuItem.Text = "FILE";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkThemeToolStripMenuItem,
            this.lightThemeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.darkThemeToolStripMenuItem.Text = "Dark Theme";
            this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.darkThemeToolStripMenuItem_Click);
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(196, 32);
            this.lightThemeToolStripMenuItem.Text = "Light Theme";
            this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.lightThemeToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(204, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aBOUTToolStripMenuItem
            // 
            this.aBOUTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisEditorToolStripMenuItem,
            this.toolStripSeparator4,
            this.versionToolStripMenuItem});
            this.aBOUTToolStripMenuItem.Name = "aBOUTToolStripMenuItem";
            this.aBOUTToolStripMenuItem.Size = new System.Drawing.Size(71, 32);
            this.aBOUTToolStripMenuItem.Text = "HELP";
            // 
            // aboutThisEditorToolStripMenuItem
            // 
            this.aboutThisEditorToolStripMenuItem.Name = "aboutThisEditorToolStripMenuItem";
            this.aboutThisEditorToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.aboutThisEditorToolStripMenuItem.Text = "About this Editor - ADitor";
            this.aboutThisEditorToolStripMenuItem.Click += new System.EventHandler(this.aboutThisEditorToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(309, 6);
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpVersion});
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(312, 32);
            this.versionToolStripMenuItem.Text = "Version";
            // 
            // HelpVersion
            // 
            this.HelpVersion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.HelpVersion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpVersion.ForeColor = System.Drawing.SystemColors.Window;
            this.HelpVersion.MaxLength = 40;
            this.HelpVersion.Name = "HelpVersion";
            this.HelpVersion.ReadOnly = true;
            this.HelpVersion.Size = new System.Drawing.Size(150, 27);
            this.HelpVersion.Text = "This is version 1.0.1";
            this.HelpVersion.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HelpVersion.ToolTipText = "Aditor : TextEditor Version";
            // 
            // ActivePanel
            // 
            this.ActivePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActivePanel.AutoSize = true;
            this.ActivePanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ActivePanel.Controls.Add(this.WritingArea);
            this.ActivePanel.Location = new System.Drawing.Point(0, 39);
            this.ActivePanel.Name = "ActivePanel";
            this.ActivePanel.Size = new System.Drawing.Size(1353, 604);
            this.ActivePanel.TabIndex = 2;
            // 
            // WritingArea
            // 
            this.WritingArea.AcceptsTab = true;
            this.WritingArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WritingArea.AutoWordSelection = true;
            this.WritingArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WritingArea.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WritingArea.Location = new System.Drawing.Point(0, 0);
            this.WritingArea.Name = "WritingArea";
            this.WritingArea.ShowSelectionMargin = true;
            this.WritingArea.Size = new System.Drawing.Size(1314, 584);
            this.WritingArea.TabIndex = 0;
            this.WritingArea.Text = "";
            this.WritingArea.TextChanged += new System.EventHandler(this.WritingArea_TextChanged);
            // 
            // FileSave
            // 
            this.FileSave.CheckFileExists = true;
            this.FileSave.RestoreDirectory = true;
            this.FileSave.Title = "ADitor : Save";
            // 
            // FileOpen
            // 
            this.FileOpen.Title = "ADitor : Open";
            // 
            // FilePrint
            // 
            this.FilePrint.AllowSelection = true;
            this.FilePrint.AllowSomePages = true;
            this.FilePrint.PrintToFile = true;
            this.FilePrint.ShowHelp = true;
            this.FilePrint.UseEXDialog = true;
            // 
            // FilePrintPrev
            // 
            this.FilePrintPrev.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.FilePrintPrev.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.FilePrintPrev.ClientSize = new System.Drawing.Size(400, 300);
            this.FilePrintPrev.Enabled = true;
            this.FilePrintPrev.Icon = ((System.Drawing.Icon)(resources.GetObject("FilePrintPrev.Icon")));
            this.FilePrintPrev.Name = "FilePrintPrev";
            this.FilePrintPrev.Visible = false;
            // 
            // Aditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1314, 635);
            this.ControlBox = false;
            this.Controls.Add(this.ActivePanel);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Aditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADitor : TextEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ActivePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel ActivePanel;
        private System.Windows.Forms.RichTextBox WritingArea;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutThisEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox HelpVersion;
        private System.Windows.Forms.SaveFileDialog FileSave;
        private System.Windows.Forms.OpenFileDialog FileOpen;
        private System.Windows.Forms.PrintDialog FilePrint;
        private System.Windows.Forms.PrintPreviewDialog FilePrintPrev;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
    }
}


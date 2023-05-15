
namespace WebBrowser
{
    partial class WebBrowser
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
            this.TopMenu = new System.Windows.Forms.MenuStrip();
            this.Bingus = new System.Windows.Forms.ToolStripTextBox();
            this.ExitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MaximizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MinimizeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ReverseButton = new System.Windows.Forms.ToolStripMenuItem();
            this.ForwardButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchButton = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTabButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveTabButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GoHomeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BookmarkButton = new System.Windows.Forms.ToolStripMenuItem();
            this.NicknameBox = new System.Windows.Forms.ToolStripTextBox();
            this.SaveBookmarksButton = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadBookmarksButton = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchEngineBox = new System.Windows.Forms.ToolStripComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage = new System.Windows.Forms.TabPage();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.BookmarksBox = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.HistoryBox = new System.Windows.Forms.RichTextBox();
            this.ClearHistoryButton = new System.Windows.Forms.Button();
            this.DeleteBookmarksButton = new System.Windows.Forms.Button();
            this.TopMenu.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.AutoSize = false;
            this.TopMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bingus,
            this.ExitButton,
            this.MaximizeButton,
            this.MinimizeButton});
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1448, 35);
            this.TopMenu.TabIndex = 0;
            // 
            // Bingus
            // 
            this.Bingus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Bingus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Bingus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bingus.Name = "Bingus";
            this.Bingus.ReadOnly = true;
            this.Bingus.Size = new System.Drawing.Size(180, 31);
            this.Bingus.Text = "Bingus Explorer🐾";
            this.Bingus.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExitButton
            // 
            this.ExitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(36, 31);
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(44, 31);
            this.MaximizeButton.Text = "🗖";
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(44, 31);
            this.MinimizeButton.Text = "🗕";
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenu.AutoSize = false;
            this.MainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReverseButton,
            this.ForwardButton,
            this.RefreshButton,
            this.SearchButton,
            this.AddTabButton,
            this.RemoveTabButton,
            this.GoHomeButton,
            this.RegisterButton,
            this.BookmarkButton,
            this.SearchEngineBox});
            this.MainMenu.Location = new System.Drawing.Point(0, 33);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1449, 35);
            this.MainMenu.TabIndex = 1;
            // 
            // ReverseButton
            // 
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(50, 31);
            this.ReverseButton.Text = "<<";
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(50, 31);
            this.ForwardButton.Text = ">>";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(41, 31);
            this.RefreshButton.Text = "↻";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(46, 31);
            this.SearchButton.Text = "🔎";
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddTabButton
            // 
            this.AddTabButton.Name = "AddTabButton";
            this.AddTabButton.Size = new System.Drawing.Size(37, 31);
            this.AddTabButton.Text = "+";
            this.AddTabButton.Click += new System.EventHandler(this.AddTabButton_Click);
            // 
            // RemoveTabButton
            // 
            this.RemoveTabButton.Name = "RemoveTabButton";
            this.RemoveTabButton.Size = new System.Drawing.Size(32, 31);
            this.RemoveTabButton.Text = "-";
            this.RemoveTabButton.Click += new System.EventHandler(this.RemoveTabButton_Click);
            // 
            // GoHomeButton
            // 
            this.GoHomeButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.GoHomeButton.Name = "GoHomeButton";
            this.GoHomeButton.Size = new System.Drawing.Size(44, 31);
            this.GoHomeButton.Text = "🏠";
            this.GoHomeButton.Click += new System.EventHandler(this.GoHomeButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(42, 31);
            this.RegisterButton.Text = "👤";
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BookmarkButton
            // 
            this.BookmarkButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BookmarkButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NicknameBox,
            this.SaveBookmarksButton,
            this.LoadBookmarksButton});
            this.BookmarkButton.Name = "BookmarkButton";
            this.BookmarkButton.Size = new System.Drawing.Size(42, 31);
            this.BookmarkButton.Text = "📄";
            // 
            // NicknameBox
            // 
            this.NicknameBox.AutoSize = false;
            this.NicknameBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NicknameBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NicknameBox.Name = "NicknameBox";
            this.NicknameBox.Size = new System.Drawing.Size(105, 25);
            // 
            // SaveBookmarksButton
            // 
            this.SaveBookmarksButton.Name = "SaveBookmarksButton";
            this.SaveBookmarksButton.Size = new System.Drawing.Size(165, 30);
            this.SaveBookmarksButton.Text = "Save";
            this.SaveBookmarksButton.Click += new System.EventHandler(this.SaveBookmarksButton_Click);
            // 
            // LoadBookmarksButton
            // 
            this.LoadBookmarksButton.Name = "LoadBookmarksButton";
            this.LoadBookmarksButton.Size = new System.Drawing.Size(165, 30);
            this.LoadBookmarksButton.Text = "Load";
            this.LoadBookmarksButton.Click += new System.EventHandler(this.LoadBookmarksButton_Click);
            // 
            // SearchEngineBox
            // 
            this.SearchEngineBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SearchEngineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchEngineBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEngineBox.Items.AddRange(new object[] {
            "Bing",
            "Google"});
            this.SearchEngineBox.Name = "SearchEngineBox";
            this.SearchEngineBox.Size = new System.Drawing.Size(121, 31);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(265, 39);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(905, 26);
            this.SearchBox.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Location = new System.Drawing.Point(158, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1291, 703);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.Browser);
            this.tabPage.Location = new System.Drawing.Point(4, 22);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage.Size = new System.Drawing.Size(1283, 677);
            this.tabPage.TabIndex = 0;
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // Browser
            // 
            this.Browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Browser.Location = new System.Drawing.Point(0, 0);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.Size = new System.Drawing.Size(1550, 836);
            this.Browser.TabIndex = 0;
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // BookmarksBox
            // 
            this.BookmarksBox.BackColor = System.Drawing.SystemColors.Control;
            this.BookmarksBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookmarksBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookmarksBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookmarksBox.Location = new System.Drawing.Point(0, 93);
            this.BookmarksBox.Name = "BookmarksBox";
            this.BookmarksBox.ReadOnly = true;
            this.BookmarksBox.Size = new System.Drawing.Size(156, 307);
            this.BookmarksBox.TabIndex = 4;
            this.BookmarksBox.Text = "";
            this.BookmarksBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.BookmarksBox_LinkClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // HistoryBox
            // 
            this.HistoryBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.HistoryBox.BackColor = System.Drawing.SystemColors.Control;
            this.HistoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistoryBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HistoryBox.Location = new System.Drawing.Point(0, 430);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.ReadOnly = true;
            this.HistoryBox.Size = new System.Drawing.Size(156, 290);
            this.HistoryBox.TabIndex = 5;
            this.HistoryBox.Text = "";
            this.HistoryBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.HistoryBox_LinkClicked);
            // 
            // ClearHistoryButton
            // 
            this.ClearHistoryButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClearHistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearHistoryButton.FlatAppearance.BorderSize = 0;
            this.ClearHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearHistoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearHistoryButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ClearHistoryButton.Location = new System.Drawing.Point(0, 402);
            this.ClearHistoryButton.Name = "ClearHistoryButton";
            this.ClearHistoryButton.Size = new System.Drawing.Size(156, 31);
            this.ClearHistoryButton.TabIndex = 10;
            this.ClearHistoryButton.Text = "CLEAR";
            this.ClearHistoryButton.UseVisualStyleBackColor = false;
            this.ClearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
            // 
            // DeleteBookmarksButton
            // 
            this.DeleteBookmarksButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DeleteBookmarksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBookmarksButton.FlatAppearance.BorderSize = 0;
            this.DeleteBookmarksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBookmarksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBookmarksButton.ForeColor = System.Drawing.SystemColors.Window;
            this.DeleteBookmarksButton.Location = new System.Drawing.Point(0, 65);
            this.DeleteBookmarksButton.Name = "DeleteBookmarksButton";
            this.DeleteBookmarksButton.Size = new System.Drawing.Size(156, 31);
            this.DeleteBookmarksButton.TabIndex = 11;
            this.DeleteBookmarksButton.Text = "DELETE";
            this.DeleteBookmarksButton.UseVisualStyleBackColor = false;
            this.DeleteBookmarksButton.Click += new System.EventHandler(this.DeleteBookmarksButton_Click);
            // 
            // WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1448, 719);
            this.Controls.Add(this.DeleteBookmarksButton);
            this.Controls.Add(this.ClearHistoryButton);
            this.Controls.Add(this.HistoryBox);
            this.Controls.Add(this.BookmarksBox);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.TopMenu;
            this.Name = "WebBrowser";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.WebBrowser_Load);
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip TopMenu;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitButton;
        private System.Windows.Forms.ToolStripMenuItem MaximizeButton;
        private System.Windows.Forms.ToolStripMenuItem MinimizeButton;
        private System.Windows.Forms.ToolStripMenuItem ReverseButton;
        private System.Windows.Forms.ToolStripMenuItem ForwardButton;
        private System.Windows.Forms.ToolStripMenuItem RefreshButton;
        private System.Windows.Forms.ToolStripMenuItem SearchButton;
        private System.Windows.Forms.ToolStripMenuItem AddTabButton;
        private System.Windows.Forms.ToolStripMenuItem RemoveTabButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.RichTextBox BookmarksBox;
        private System.Windows.Forms.ToolStripMenuItem GoHomeButton;
        private System.Windows.Forms.ToolStripMenuItem RegisterButton;
        private System.Windows.Forms.ToolStripComboBox SearchEngineBox;
        private System.Windows.Forms.ToolStripMenuItem BookmarkButton;
        private System.Windows.Forms.ToolStripTextBox NicknameBox;
        private System.Windows.Forms.ToolStripMenuItem SaveBookmarksButton;
        private System.Windows.Forms.ToolStripMenuItem LoadBookmarksButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.RichTextBox HistoryBox;
        private System.Windows.Forms.ToolStripTextBox Bingus;
        private System.Windows.Forms.Button ClearHistoryButton;
        private System.Windows.Forms.Button DeleteBookmarksButton;
    }
}


namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.BookmarksListBox = new System.Windows.Forms.ListBox();
            this.BookmarksLabel = new System.Windows.Forms.Label();
            this.DeleteBookmarkItemButton = new System.Windows.Forms.Button();
            this.BookmarkSearchButton = new System.Windows.Forms.Button();
            this.BookmarkSearchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BookmarksListBox
            // 
            this.BookmarksListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BookmarksListBox.FormattingEnabled = true;
            this.BookmarksListBox.ItemHeight = 20;
            this.BookmarksListBox.Location = new System.Drawing.Point(0, 208);
            this.BookmarksListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookmarksListBox.Name = "BookmarksListBox";
            this.BookmarksListBox.Size = new System.Drawing.Size(1200, 484);
            this.BookmarksListBox.TabIndex = 0;
            this.BookmarksListBox.SelectedIndexChanged += new System.EventHandler(this.BookmarksListBox_SelectedIndexChanged);
            // 
            // BookmarksLabel
            // 
            this.BookmarksLabel.AutoSize = true;
            this.BookmarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookmarksLabel.Location = new System.Drawing.Point(502, 55);
            this.BookmarksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BookmarksLabel.Name = "BookmarksLabel";
            this.BookmarksLabel.Size = new System.Drawing.Size(187, 37);
            this.BookmarksLabel.TabIndex = 1;
            this.BookmarksLabel.Text = "Bookmarks";
            this.BookmarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteBookmarkItemButton
            // 
            this.DeleteBookmarkItemButton.Location = new System.Drawing.Point(481, 139);
            this.DeleteBookmarkItemButton.Name = "DeleteBookmarkItemButton";
            this.DeleteBookmarkItemButton.Size = new System.Drawing.Size(223, 41);
            this.DeleteBookmarkItemButton.TabIndex = 8;
            this.DeleteBookmarkItemButton.Text = "Delete Selected Item";
            this.DeleteBookmarkItemButton.UseVisualStyleBackColor = true;
            this.DeleteBookmarkItemButton.Click += new System.EventHandler(this.DeleteBookmarkItemButton_Click);
            // 
            // BookmarkSearchButton
            // 
            this.BookmarkSearchButton.Location = new System.Drawing.Point(350, 139);
            this.BookmarkSearchButton.Name = "BookmarkSearchButton";
            this.BookmarkSearchButton.Size = new System.Drawing.Size(125, 41);
            this.BookmarkSearchButton.TabIndex = 7;
            this.BookmarkSearchButton.Text = "Search";
            this.BookmarkSearchButton.UseVisualStyleBackColor = true;
            this.BookmarkSearchButton.Click += new System.EventHandler(this.BookmarkSearchButton_Click);
            // 
            // BookmarkSearchTextBox
            // 
            this.BookmarkSearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BookmarkSearchTextBox.Location = new System.Drawing.Point(51, 146);
            this.BookmarkSearchTextBox.Name = "BookmarkSearchTextBox";
            this.BookmarkSearchTextBox.Size = new System.Drawing.Size(293, 26);
            this.BookmarkSearchTextBox.TabIndex = 6;
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.DeleteBookmarkItemButton);
            this.Controls.Add(this.BookmarkSearchButton);
            this.Controls.Add(this.BookmarkSearchTextBox);
            this.Controls.Add(this.BookmarksLabel);
            this.Controls.Add(this.BookmarksListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BookmarkManagerForm";
            this.Text = "Bookmarks";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookmarksListBox;
        private System.Windows.Forms.Label BookmarksLabel;
        private System.Windows.Forms.Button DeleteBookmarkItemButton;
        private System.Windows.Forms.Button BookmarkSearchButton;
        private System.Windows.Forms.TextBox BookmarkSearchTextBox;
    }
}
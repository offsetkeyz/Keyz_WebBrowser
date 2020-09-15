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
            this.SuspendLayout();
            // 
            // BookmarksListBox
            // 
            this.BookmarksListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BookmarksListBox.FormattingEnabled = true;
            this.BookmarksListBox.Location = new System.Drawing.Point(0, 108);
            this.BookmarksListBox.Name = "BookmarksListBox";
            this.BookmarksListBox.Size = new System.Drawing.Size(800, 342);
            this.BookmarksListBox.TabIndex = 0;
            // 
            // BookmarksLabel
            // 
            this.BookmarksLabel.AutoSize = true;
            this.BookmarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookmarksLabel.Location = new System.Drawing.Point(335, 36);
            this.BookmarksLabel.Name = "BookmarksLabel";
            this.BookmarksLabel.Size = new System.Drawing.Size(128, 25);
            this.BookmarksLabel.TabIndex = 1;
            this.BookmarksLabel.Text = "Bookmarks";
            this.BookmarksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookmarksLabel);
            this.Controls.Add(this.BookmarksListBox);
            this.Name = "BookmarkManagerForm";
            this.Text = "Bookmarks";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BookmarksListBox;
        private System.Windows.Forms.Label BookmarksLabel;
    }
}
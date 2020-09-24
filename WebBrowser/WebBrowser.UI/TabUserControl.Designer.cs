namespace WebBrowser.UI
{
    partial class TabUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.addressTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.bookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 43);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(11, 13);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(576, 473);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.webBrowser1_ProgressChanged_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 32);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 24);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            this.toolStripProgressBar1.VisibleChanged += new System.EventHandler(this.toolStripProgressBar1_VisibleChanged);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // addressTextBox
            // 
            this.addressTextBox.AcceptsReturn = true;
            this.addressTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addressTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.addressTextBox.Size = new System.Drawing.Size(340, 33);
            this.addressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressTextBox_KeyDown);
            this.addressTextBox.Click += new System.EventHandler(this.addressTextBox_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.refreshButton,
            this.homeButton,
            this.addressTextBox,
            this.goButton,
            this.bookmarkButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 10);
            this.toolStrip1.Size = new System.Drawing.Size(576, 43);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = global::WebBrowser.UI.Properties.Resources.iconmonstr_arrow_68_240;
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(34, 28);
            this.backButton.Text = "Back Button";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Image = global::WebBrowser.UI.Properties.Resources.iconmonstr_arrow_27_240;
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(34, 28);
            this.forwardButton.Text = "Forward Button";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = global::WebBrowser.UI.Properties.Resources.iconmonstr_refresh_1_240;
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(34, 28);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Image = global::WebBrowser.UI.Properties.Resources.iconmonstr_home_6_240;
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(34, 28);
            this.homeButton.Text = "Home";
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // goButton
            // 
            this.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goButton.Image = global::WebBrowser.UI.Properties.Resources.iconmonstr_arrow_25_240;
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(34, 28);
            this.goButton.Text = "Go";
            this.goButton.Click += new System.EventHandler(this.goButton_Click_1);
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkButton.Image = global::WebBrowser.UI.Properties.Resources.iconmonstr_bookmark_1_240;
            this.bookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(34, 28);
            this.bookmarkButton.Text = "Bookmark";
            this.bookmarkButton.Click += new System.EventHandler(this.bookmarkButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::WebBrowser.UI.Properties.Resources.icons8_clear_formatting_30;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "ClearURLButton";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // TabUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TabUserControl";
            this.Size = new System.Drawing.Size(576, 516);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton homeButton;
        private System.Windows.Forms.ToolStripTextBox addressTextBox;
        private System.Windows.Forms.ToolStripButton goButton;
        private System.Windows.Forms.ToolStripButton bookmarkButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

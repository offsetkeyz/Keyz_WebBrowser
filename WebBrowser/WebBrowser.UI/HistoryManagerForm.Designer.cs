namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HistorySearchTextBox = new System.Windows.Forms.TextBox();
            this.HistorySearchButton = new System.Windows.Forms.Button();
            this.ClearHistoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 20;
            this.HistoryListBox.Location = new System.Drawing.Point(0, 188);
            this.HistoryListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(1200, 504);
            this.HistoryListBox.TabIndex = 0;
            this.HistoryListBox.SelectedIndexChanged += new System.EventHandler(this.HistoryListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "History Manager";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistorySearchTextBox
            // 
            this.HistorySearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HistorySearchTextBox.Location = new System.Drawing.Point(70, 137);
            this.HistorySearchTextBox.Name = "HistorySearchTextBox";
            this.HistorySearchTextBox.Size = new System.Drawing.Size(293, 26);
            this.HistorySearchTextBox.TabIndex = 2;
            this.HistorySearchTextBox.TextChanged += new System.EventHandler(this.HistorySearchTextBox_TextChanged);
            // 
            // HistorySearchButton
            // 
            this.HistorySearchButton.Location = new System.Drawing.Point(369, 130);
            this.HistorySearchButton.Name = "HistorySearchButton";
            this.HistorySearchButton.Size = new System.Drawing.Size(125, 41);
            this.HistorySearchButton.TabIndex = 3;
            this.HistorySearchButton.Text = "Search";
            this.HistorySearchButton.UseVisualStyleBackColor = true;
            this.HistorySearchButton.Click += new System.EventHandler(this.HistorySearchButton_Click);
            // 
            // ClearHistoryButton
            // 
            this.ClearHistoryButton.Location = new System.Drawing.Point(1043, 130);
            this.ClearHistoryButton.Name = "ClearHistoryButton";
            this.ClearHistoryButton.Size = new System.Drawing.Size(125, 41);
            this.ClearHistoryButton.TabIndex = 4;
            this.ClearHistoryButton.Text = "Clear History";
            this.ClearHistoryButton.UseVisualStyleBackColor = true;
            this.ClearHistoryButton.Click += new System.EventHandler(this.ClearHistoryButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ClearHistoryButton);
            this.Controls.Add(this.HistorySearchButton);
            this.Controls.Add(this.HistorySearchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HistoryListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HistoryManagerForm";
            this.Text = "History Manager";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HistorySearchTextBox;
        private System.Windows.Forms.Button HistorySearchButton;
        private System.Windows.Forms.Button ClearHistoryButton;
    }
}
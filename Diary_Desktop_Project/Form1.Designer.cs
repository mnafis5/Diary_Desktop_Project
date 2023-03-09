namespace Diary_Desktop_Project
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Diaries = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.ListSearchBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ButtonControl = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditor = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bold = new System.Windows.Forms.CheckBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.underline = new System.Windows.Forms.CheckBox();
            this.View = new System.Windows.Forms.GroupBox();
            this.Details = new System.Windows.Forms.GroupBox();
            this.contentDiary = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Diaries.SuspendLayout();
            this.ButtonControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.textEditor.SuspendLayout();
            this.View.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Diaries);
            this.splitContainer1.Panel1.Controls.Add(this.ButtonControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.Details);
            this.splitContainer1.Panel2.Controls.Add(this.View);
            this.splitContainer1.Panel2.Controls.Add(this.textEditor);
            this.splitContainer1.Size = new System.Drawing.Size(1500, 798);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            // 
            // Diaries
            // 
            this.Diaries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Diaries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Diaries.Controls.Add(this.searchButton);
            this.Diaries.Controls.Add(this.ListSearchBox);
            this.Diaries.Controls.Add(this.listBox1);
            this.Diaries.Location = new System.Drawing.Point(3, 45);
            this.Diaries.Name = "Diaries";
            this.Diaries.Size = new System.Drawing.Size(494, 756);
            this.Diaries.TabIndex = 1;
            this.Diaries.TabStop = false;
            this.Diaries.Text = "List of Diaries";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(259, 20);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(56, 20);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ListSearchBox
            // 
            this.ListSearchBox.Location = new System.Drawing.Point(16, 20);
            this.ListSearchBox.Name = "ListSearchBox";
            this.ListSearchBox.Size = new System.Drawing.Size(237, 20);
            this.ListSearchBox.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 693);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ButtonControl
            // 
            this.ButtonControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonControl.Controls.Add(this.menuStrip1);
            this.ButtonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonControl.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonControl.Location = new System.Drawing.Point(0, 0);
            this.ButtonControl.Name = "ButtonControl";
            this.ButtonControl.Size = new System.Drawing.Size(500, 50);
            this.ButtonControl.TabIndex = 0;
            this.ButtonControl.TabStop = false;
            this.ButtonControl.Text = "Navigation";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BlueViolet;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.addToolStripMenuItem.Text = "Add/Modify";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // textEditor
            // 
            this.textEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textEditor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.textEditor.Controls.Add(this.underline);
            this.textEditor.Controls.Add(this.italic);
            this.textEditor.Controls.Add(this.bold);
            this.textEditor.Controls.Add(this.richTextBox1);
            this.textEditor.Location = new System.Drawing.Point(5, 3);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(476, 792);
            this.textEditor.TabIndex = 0;
            this.textEditor.TabStop = false;
            this.textEditor.Text = "Text Editor";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(456, 706);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.Location = new System.Drawing.Point(9, 52);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(47, 17);
            this.bold.TabIndex = 1;
            this.bold.Text = "Bold";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // italic
            // 
            this.italic.AutoSize = true;
            this.italic.Location = new System.Drawing.Point(62, 52);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(48, 17);
            this.italic.TabIndex = 2;
            this.italic.Text = "Italic";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // underline
            // 
            this.underline.AutoSize = true;
            this.underline.Location = new System.Drawing.Point(116, 52);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(71, 17);
            this.underline.TabIndex = 3;
            this.underline.Text = "Underline";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.CheckedChanged += new System.EventHandler(this.underline_CheckedChanged);
            // 
            // View
            // 
            this.View.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.View.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.View.Controls.Add(this.contentDiary);
            this.View.Location = new System.Drawing.Point(486, 3);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(507, 543);
            this.View.TabIndex = 1;
            this.View.TabStop = false;
            this.View.Text = "Inspector";
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(486, 555);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(506, 162);
            this.Details.TabIndex = 2;
            this.Details.TabStop = false;
            this.Details.Text = "Details";
            // 
            // contentDiary
            // 
            this.contentDiary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contentDiary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentDiary.Location = new System.Drawing.Point(19, 28);
            this.contentDiary.Name = "contentDiary";
            this.contentDiary.Size = new System.Drawing.Size(487, 500);
            this.contentDiary.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1500, 798);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Diary App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Diaries.ResumeLayout(false);
            this.Diaries.PerformLayout();
            this.ButtonControl.ResumeLayout(false);
            this.ButtonControl.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.textEditor.ResumeLayout(false);
            this.textEditor.PerformLayout();
            this.View.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox ButtonControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.GroupBox Diaries;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox ListSearchBox;
        private System.Windows.Forms.GroupBox textEditor;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox underline;
        private System.Windows.Forms.CheckBox italic;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.GroupBox View;
        private System.Windows.Forms.GroupBox Details;
        private System.Windows.Forms.Label contentDiary;
    }
}


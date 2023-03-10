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
            this.underline = new System.Windows.Forms.CheckBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.bold = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Diaries.SuspendLayout();
            this.ButtonControl.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.textEditor.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.textEditor);
            this.splitContainer1.Size = new System.Drawing.Size(1370, 749);
            this.splitContainer1.SplitterDistance = 456;
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
            this.Diaries.Size = new System.Drawing.Size(450, 707);
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
            this.listBox1.Size = new System.Drawing.Size(339, 654);
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
            this.ButtonControl.Size = new System.Drawing.Size(456, 50);
            this.ButtonControl.TabIndex = 0;
            this.ButtonControl.TabStop = false;
            this.ButtonControl.Text = "Navigation";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.BlueViolet;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 18);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(450, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
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
            this.textEditor.Controls.Add(this.fontLabel);
            this.textEditor.Controls.Add(this.button1);
            this.textEditor.Controls.Add(this.button2);
            this.textEditor.Controls.Add(this.label1);
            this.textEditor.Controls.Add(this.underline);
            this.textEditor.Controls.Add(this.italic);
            this.textEditor.Controls.Add(this.bold);
            this.textEditor.Controls.Add(this.richTextBox1);
            this.textEditor.Location = new System.Drawing.Point(5, 3);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(902, 743);
            this.textEditor.TabIndex = 0;
            this.textEditor.TabStop = false;
            this.textEditor.Text = "Text Editor";
            // 
            // underline
            // 
            this.underline.AutoSize = true;
            this.underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underline.Location = new System.Drawing.Point(116, 52);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(71, 17);
            this.underline.TabIndex = 3;
            this.underline.Text = "Underline";
            this.underline.UseVisualStyleBackColor = true;
            this.underline.CheckedChanged += new System.EventHandler(this.underline_CheckedChanged);
            // 
            // italic
            // 
            this.italic.AutoSize = true;
            this.italic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic.Location = new System.Drawing.Point(62, 52);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(48, 17);
            this.italic.TabIndex = 2;
            this.italic.Text = "Italic";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold.Location = new System.Drawing.Point(9, 52);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(51, 17);
            this.bold.TabIndex = 1;
            this.bold.Text = "Bold";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(9, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(884, 657);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.modifyToolStripMenuItem.Text = "Modify";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(84, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 84);
            this.label1.TabIndex = 4;
            this.label1.Text = "Are you sure to delete it?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "No";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "Yes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fontLabel
            // 
            this.fontLabel.Location = new System.Drawing.Point(183, 49);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(64, 20);
            this.fontLabel.TabIndex = 7;
            this.fontLabel.Text = "Font";
            this.fontLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fontLabel.Click += new System.EventHandler(this.fontLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1370, 749);
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
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}


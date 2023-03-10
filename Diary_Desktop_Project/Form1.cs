using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Diary_Desktop_Project
{
    public partial class Form1 : Form   
    {
        private string folderpath = "C:\\Users\\HP\\source\\repos\\Diary_Desktop_Project\\data";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateFileList(folderpath);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int index = listBox1.FindString(ListSearchBox.Text);
            if (index != ListBox.NoMatches)
            {
                listBox1.SetSelected(index, true);
            }
            else
            {
                MessageBox.Show("There is no such list item");
            }
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            if(bold.Checked == true)
            {
                if (richTextBox1.SelectionFont != null)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                        richTextBox1.SelectionFont.Style | FontStyle.Bold);
                }
            }
            else
            {
                if (richTextBox1.SelectionFont != null)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                        richTextBox1.SelectionFont.Style & ~FontStyle.Bold);
                }
            }
        }

        private void italic_CheckedChanged(object sender, EventArgs e)
        {
            if(italic.Checked == true)
            {
                // Set the font style of the selected text to italic
                if (richTextBox1.SelectionFont != null)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                        richTextBox1.SelectionFont.Style | FontStyle.Italic);
                }
            }
            else
            {
                if (richTextBox1.SelectionFont != null)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                        richTextBox1.SelectionFont.Style & ~FontStyle.Italic);
                }
            }
        }

        private void underline_CheckedChanged(object sender, EventArgs e)
        {
            if(underline.Checked == true)
            {
                // Set the font style of the selected text to underline
                if (richTextBox1.SelectionFont != null)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                        richTextBox1.SelectionFont.Style | FontStyle.Underline);
                }
            }
            else
            {
                if (richTextBox1.SelectionFont != null)
                {
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                        richTextBox1.SelectionFont.Style & ~FontStyle.Underline);
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text Files|*.txt";
                saveFileDialog.Title = "Save File As...";
                saveFileDialog.InitialDirectory = folderpath;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter write = new StreamWriter(saveFileDialog.FileName))
                    {

                        write.Write(richTextBox1.Text);
                        richTextBox1.Clear();
                        PopulateFileList(folderpath);
                        richTextBox1.ReadOnly = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("No text");
            }
        }

        private void PopulateFileList(string folderPath)
        {
            //clear the listbox control
            listBox1.Items.Clear();

            //get the files in the directory
            string[] files = Directory.GetFiles(folderPath);

            //loop
            foreach (string file in files)
            {
                // Add the file name to the ListBox control
                string explodedFile = Path.GetFileName(file);
                listBox1.Items.Add(explodedFile);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //Get the selected file name from the listbox control
                string file = (string)listBox1.SelectedItem;

                // Load the contents of the file into a string
                string filePath = Path.Combine(folderpath, file); // replace with the path to your directory
                string text = File.ReadAllText(filePath);

                // Display the contents of the file in the richtextbox control
                if (File.Exists(filePath))
                {
                    richTextBox1.Text = text;
                    richTextBox1.ReadOnly = true;
                }
            }
            catch 
            {
                MessageBox.Show("Empty");
            }
           
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count <= 0)
            {
                MessageBox.Show("No files detected");
            }
            else
            {
            button1.Visible = true;
            button2.Visible = true;
            label1.Visible = true;

            }
        }

        private void modifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            this.Refresh();
            richTextBox1.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Get the selected file path from the list box
            string filepath = listBox1.SelectedItem.ToString();
            filepath = Path.Combine(folderpath, filepath);

            // Delete the selected file
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
                richTextBox1.Clear();
                MessageBox.Show("File deleted successfully");
                PopulateFileList(folderpath);
                label1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                richTextBox1.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("the file is not found");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible=false;
            button1.Visible=false;
            button2.Visible=false;

        }

        private void fontLabel_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // User clicked OK, so get the selected font
                Font selectedFont = fontDialog1.Font;

                // Do something with the selected font, such as setting the font of a label control
                richTextBox1.Font = selectedFont;
            }
        }
    }
}

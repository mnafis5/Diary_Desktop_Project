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
        private string folderpath = "C:\\Users\\User\\source\\repos\\Diary_Desktop_Project\\data";
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
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.Title = "Save File As...";
            saveFileDialog.InitialDirectory = folderpath;
            if(saveFileDialog.ShowDialog() == DialogResult.OK) 
            {
                using (StreamWriter write = new StreamWriter(saveFileDialog.FileName))
                {
                    if(richTextBox1!= null)
                    {
                        write.Write(richTextBox1.Text);
                        richTextBox1.Clear();
                        contentDiary.Text = "";
                        PopulateFileList(folderpath);
                    }
                }
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
            //Get the selected file name from the listbox control
            string file = (string)listBox1.SelectedItem;

            // Load the contents of the file into a string
            string filePath = Path.Combine(folderpath, file); // replace with the path to your directory
            string text = File.ReadAllText(filePath);

            // Display the contents of the file in the richtextbox control
            if (File.Exists(filePath))
            {
            richTextBox1.Text = text;
            contentDiary.Text = text;
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get the selected file path from the list box
            string filepath = listBox1.SelectedItem.ToString();
            filepath = Path.Combine(folderpath, filepath);

            // Delete the selected file
            if(File.Exists(filepath))
            {
                File.Delete(filepath);
                richTextBox1.Clear();
                contentDiary.Text = "";
                MessageBox.Show("File deleted successfully");
                PopulateFileList(folderpath);
            }
            else
            {
                MessageBox.Show("the file is not found");
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary_Desktop_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Item 3");
            listBox1.Items.Add("Hangout");
            listBox1.Items.Add("riding");

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

        private void bold_Click(object sender, EventArgs e)
        {
            // Set the font style of the selected text to bold
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void italic_Click(object sender, EventArgs e)
        {
            // Set the font style of the selected text to italic
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style | FontStyle.Italic);
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

        private void underline_Click(object sender, EventArgs e)
        {
            // Set the font style of the selected text to underline
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont,
                    richTextBox1.SelectionFont.Style | FontStyle.Underline);
            }
        }
    }
}

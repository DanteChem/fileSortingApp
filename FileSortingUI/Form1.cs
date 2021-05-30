using fileSortingApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSortingUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialogResult2 = folderBrowserDialog1.ShowDialog();
            if (dialogResult2 == DialogResult.OK)
            {
                textBox2.Text = folderBrowserDialog1.SelectedPath;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            var sort = new ArchiveSorter(); // create instanse of my core sorting method
            var checkBoxOn = new CheckBox1();
            sort.Sort(textBox1.Text, textBox2.Text);  // set to the method 2 string variables from textBox(es)
            if (checkBox1.Checked)
            {
                checkBoxOn.FilesDeleter(textBox1.Text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //var checkBoxOn = new CheckBox1();
            //if (checkBox1.Checked)
            //{
            //    checkBoxOn.FilesDeleter(textBox1.Text);
            //}
        }










        //var dialogResult = FileBrowser.ShowDialog();
        //if(dialogResult == DialogResult.OK)
        //{
        //    textBox1.Text = FileBrowser.SelectedPath;
        //}


        //var sort = new ArchiveSorter(); // button 3 
        //sort.Sort(textBox1.Text);
    }
}

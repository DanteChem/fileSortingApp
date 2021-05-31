using fileSortingApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            string pathFromDialogBox1 = textBox1.Text;
            string[] doesSourceHasZip = Directory.GetFiles(pathFromDialogBox1);
            int zipCounter = 0;
            foreach (string fileInDialog1Folder in doesSourceHasZip)
            {
                var fileExtensionCheck = Path.GetExtension(fileInDialog1Folder);
                if (fileExtensionCheck == ".zip")
                {
                    zipCounter = zipCounter + 1;
                }
            }
            if (zipCounter == 0)
            {
                textBox3.Text += $"The folder {pathFromDialogBox1} does not contain Zip-files";
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


    }


}

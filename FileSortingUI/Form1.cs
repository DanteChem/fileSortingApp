using fileSortingApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSortingUI
{
    public partial class Form1 : Form
    {
        public int zipCounter; // add this variable for progress-bar 
        public Form1()
        {
            InitializeComponent();
        }

        private void initialPathSelect_Click(object sender, EventArgs e)
        {

            var dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                initialPathTextBox.Text = folderBrowserDialog1.SelectedPath;

                //cancel-fix in dialog box block start
                string pathFromDialogBox1 = initialPathTextBox.Text;
                string[] doesSourceHasZip = Directory.GetFiles(pathFromDialogBox1);
                zipCounter = 0; // originally it was "int zipCounter = 0"
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
                    infoTextBox.Text += $"The folder {pathFromDialogBox1} does not contain Zip-files";
                }
                //cancel-fix in dialog box block end
            }
            else
            {
                dialogResult = DialogResult.Cancel;
            }
            // cancel-fix bloack was taken from this place
        }

        private void sourcePathSelect_Click(object sender, EventArgs e)
        {
            var dialogResult2 = folderBrowserDialog1.ShowDialog();
            if (dialogResult2 == DialogResult.OK)
            {
                sourcePathTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void startSortingButton_Click(object sender, EventArgs e)
        {
            var sort = new ArchiveSorter(); // create instanse of my core sorting method
            var checkBoxOn = new CheckBox1();
            sort.Sort(initialPathTextBox.Text, sourcePathTextBox.Text);  // set to the method 2 string variables from textBox(es)
            if (checkBox1.Checked)
            {
                checkBoxOn.FilesDeleter(initialPathTextBox.Text);
            }

            // progress bar (does not work correct) 
            sortingProgressBar.Step = 1;
            sortingProgressBar.Maximum = zipCounter; // have to pickup values from method above
            for (int i = 0; i < sortingProgressBar.Maximum; i++)
            {
                Thread.Sleep(100);
                sortingProgressBar.PerformStep();
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

        private void infoTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            initialPathTextBox.Clear();
            sourcePathTextBox.Clear();
        }

    }


}

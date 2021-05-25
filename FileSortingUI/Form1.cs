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
            var sort = new ArchiveSorter();
            sort.Sort(textBox1.Text, textBox2.Text);
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

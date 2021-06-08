
namespace FileSortingUI
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
            this.initialPathSelect = new System.Windows.Forms.Button();
            this.initialPathTextBox = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.sourcePathSelect = new System.Windows.Forms.Button();
            this.sourcePathTextBox = new System.Windows.Forms.TextBox();
            this.startSortingButton = new System.Windows.Forms.Button();
            this.initialPathSelectLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.sortingProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // initialPathSelect
            // 
            this.initialPathSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initialPathSelect.Location = new System.Drawing.Point(56, 42);
            this.initialPathSelect.Name = "initialPathSelect";
            this.initialPathSelect.Size = new System.Drawing.Size(109, 32);
            this.initialPathSelect.TabIndex = 0;
            this.initialPathSelect.Text = "Browse:";
            this.initialPathSelect.UseVisualStyleBackColor = true;
            this.initialPathSelect.Click += new System.EventHandler(this.initialPathSelect_Click);
            // 
            // initialPathTextBox
            // 
            this.initialPathTextBox.Location = new System.Drawing.Point(53, 80);
            this.initialPathTextBox.Name = "initialPathTextBox";
            this.initialPathTextBox.Size = new System.Drawing.Size(434, 22);
            this.initialPathTextBox.TabIndex = 1;
            // 
            // sourcePathSelect
            // 
            this.sourcePathSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourcePathSelect.Location = new System.Drawing.Point(53, 154);
            this.sourcePathSelect.Name = "sourcePathSelect";
            this.sourcePathSelect.Size = new System.Drawing.Size(109, 32);
            this.sourcePathSelect.TabIndex = 2;
            this.sourcePathSelect.Text = "Browse:";
            this.sourcePathSelect.UseVisualStyleBackColor = true;
            this.sourcePathSelect.Click += new System.EventHandler(this.sourcePathSelect_Click);
            // 
            // sourcePathTextBox
            // 
            this.sourcePathTextBox.Location = new System.Drawing.Point(53, 192);
            this.sourcePathTextBox.Name = "sourcePathTextBox";
            this.sourcePathTextBox.Size = new System.Drawing.Size(434, 22);
            this.sourcePathTextBox.TabIndex = 3;
            // 
            // startSortingButton
            // 
            this.startSortingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startSortingButton.Location = new System.Drawing.Point(56, 280);
            this.startSortingButton.Name = "startSortingButton";
            this.startSortingButton.Size = new System.Drawing.Size(109, 38);
            this.startSortingButton.TabIndex = 4;
            this.startSortingButton.Text = "Start sorting";
            this.startSortingButton.UseVisualStyleBackColor = true;
            this.startSortingButton.Click += new System.EventHandler(this.startSortingButton_Click);
            // 
            // initialPathSelectLabel
            // 
            this.initialPathSelectLabel.AutoSize = true;
            this.initialPathSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.initialPathSelectLabel.Location = new System.Drawing.Point(52, 19);
            this.initialPathSelectLabel.Name = "initialPathSelectLabel";
            this.initialPathSelectLabel.Size = new System.Drawing.Size(304, 20);
            this.initialPathSelectLabel.TabIndex = 5;
            this.initialPathSelectLabel.Text = "Select the folder with compressed files:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select the folder where to sort files:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(56, 232);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(300, 24);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Delete the original compressed files";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(392, 280);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(95, 38);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(28, 382);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(496, 99);
            this.infoTextBox.TabIndex = 9;
            this.infoTextBox.TextChanged += new System.EventHandler(this.infoTextBox_TextChanged);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(220, 280);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 38);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // sortingProgressBar
            // 
            this.sortingProgressBar.Location = new System.Drawing.Point(28, 345);
            this.sortingProgressBar.Name = "sortingProgressBar";
            this.sortingProgressBar.Size = new System.Drawing.Size(496, 23);
            this.sortingProgressBar.TabIndex = 11;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(552, 493);
            this.Controls.Add(this.sortingProgressBar);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.initialPathSelectLabel);
            this.Controls.Add(this.startSortingButton);
            this.Controls.Add(this.sourcePathTextBox);
            this.Controls.Add(this.sourcePathSelect);
            this.Controls.Add(this.initialPathTextBox);
            this.Controls.Add(this.initialPathSelect);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initialPathSelect;
        private System.Windows.Forms.TextBox initialPathTextBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button sourcePathSelect;
        private System.Windows.Forms.TextBox sourcePathTextBox;
        private System.Windows.Forms.Button startSortingButton;
        private System.Windows.Forms.Label initialPathSelectLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ProgressBar sortingProgressBar;
    }
}


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
using MyHeshtable;

namespace CourseProject
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            if (File.Exists(fldRecipeFile.Text) && File.Exists(fldReviewFile.Text))
            {
                Form2 form2 = new(fldRecipeFile.Text, fldReviewFile.Text, (int)numHeshtableSize.Value);
                form2.Location = this.Location;
                this.Hide();
                form2.Show();
            }
        }

        private void butSelectRecipeFile_Click(object sender, EventArgs e)
        {
            string selectedFile = SelectFile();
            if (selectedFile != null)
                fldRecipeFile.Text = selectedFile;
        }

        private void butSelectReviewFile_Click(object sender, EventArgs e)
        {
            string selectedFile = SelectFile();
            if (selectedFile != null)
                fldReviewFile.Text = selectedFile;
        }

        private static string SelectFile()
        {
            OpenFileDialog dlg = new();
            dlg.Filter = "Текстовые файлы|*.txt|Все файлы|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                return dlg.FileName;
            }
            else return null;
        }

        private void butHelp_Click(object sender, EventArgs e)
        {
            Help1 help = new();
            help.ShowDialog();
            if (help.DialogResult == DialogResult.OK)
            {
                help.Dispose();
            }    
        }
    }
}

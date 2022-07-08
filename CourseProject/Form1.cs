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
                form2.Location = Location;
                Hide();
                form2.Show();
            }
        }

        private void butSelectRecipeFile_Click(object sender, EventArgs e)
        {
            fldRecipeFile.Text = SelectFile();
        }

        private void butSelectReviewFile_Click(object sender, EventArgs e)
        {
            fldReviewFile.Text = SelectFile();
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
        
    }
}

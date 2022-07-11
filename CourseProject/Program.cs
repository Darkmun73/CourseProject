using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyHeshtable;

namespace CourseProject
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GenerateInput.GenerateRandomRecipesIn("recipesInputRandom.txt", 100);
            GenerateInput.GenerateRandomReviewsIn("reviewsInputRandom.txt", 100);
            Application.Run(new Form1());
        }
    }
}

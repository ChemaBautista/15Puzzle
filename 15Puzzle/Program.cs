using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Puzzle
{
    static class Program
    {
   
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

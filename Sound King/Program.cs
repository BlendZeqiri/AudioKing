using System;
using System.Windows.Forms;

namespace SoundKing
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Enable visual styles for the application
            Application.EnableVisualStyles();

            // Set compatible text rendering default
            Application.SetCompatibleTextRenderingDefault(false);

            // Run the main form
            Application.Run(new MainForm());
        }
    }
}

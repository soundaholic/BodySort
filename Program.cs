using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BodySort
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

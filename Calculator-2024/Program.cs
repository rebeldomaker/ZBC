using System;
using System.Windows.Forms;

namespace GuiCalculator
{
    static class Program
    {
        /// <summary>
        /// Hovedindgangspunktet for applikationen.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}

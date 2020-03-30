using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spreadsheet_assignment
{
    static class Program
    {
        /// <Summary>
        /// The main entry point for the application.
        /// </Summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Spreadsheet());
        }
    }
}

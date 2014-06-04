using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TechnicalStockScan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            try
            {
                Application.Run(new MainForm());
            }
            finally{FullScreenForm.SetHHTaskBar();}
        }
    }
}
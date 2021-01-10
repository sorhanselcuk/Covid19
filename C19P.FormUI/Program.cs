using C19P.Is.Abstract;
using C19P.Is.Concrete;
using C19P.Is.Observer;
using C19P.VeriErisim.Concrete.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19P.FormUI
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            
        }
    }
}

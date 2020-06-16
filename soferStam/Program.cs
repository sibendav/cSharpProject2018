using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using soferStam.GUI;


namespace soferStam
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
            DAL.dal.ConnectToDB();
            Application.Run(new Form1());
           
        }
    }
}

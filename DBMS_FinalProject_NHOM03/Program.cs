using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.Runtime.Versioning;
using DBMS_FinalProject_NHOM03.DB_Layer;
namespace DBMS_FinalProject_NHOM03
{
    internal static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu_ManagementForm());
        }
        [DllImport("user32.dll")]
        [SupportedOSPlatform("windows6.1")]
        private static extern bool SetProcessDPIAware();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassVault
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Main_frm());
            //Application.Run(new Login_frm());
            //Application.Run(new Add_Edit_Clients_frm());
            //Application.Run(new Add_Edit_PassVault_Records_frm());
            Application.Run(new Add_Edit_frm());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPharmacy
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
           
            DataLayer.createLog();
            if (DataLayer.Connected())
            {
                frmLogin formLogin = new frmLogin();
                formLogin.Show();
                Application.Run();
            }
            else
            {
                frmMessageBox formMessage = new frmMessageBox("Database Connection Error", "Failed to connect to the database.\nPlease make sure that the server is online.");
                Application.Run(formMessage);
            }

        }
    }
}

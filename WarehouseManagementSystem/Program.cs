using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseManagementSystem.Forms;

namespace WarehouseManagementSystem
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

            while (true)
            {
                using (LoginForm login = new LoginForm())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                }

                MainForm mainForm = new MainForm();
                Application.Run(mainForm);

                if (!mainForm.logoutRequested)
                {
                    return;
                }
            }
        }
    }
}

using InformationSystem.BL;
using InformationSystem.BLL;
using InformationSystem.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationSystem.PL
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["main"].ConnectionString;

            IAccess dal = new AccessBD(connectionString);
            ILogic logic = new Logic(dal);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(logic));
        }
    }
}

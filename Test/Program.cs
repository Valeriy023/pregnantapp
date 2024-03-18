using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public static class Globals 
    {
        public static DBrepository Repos = new DBrepository();
        public static string id = "";
        public static Form2 PatientAddForm = new Form2();
        public static Form3 PatientEditForm = new Form3();
    }
}

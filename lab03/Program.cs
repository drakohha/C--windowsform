using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFlab03
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserU u = new UserU();
            u.login = "drakohha";
            u.Password = "drakonlol4";
            FileStream file = new FileStream(Path.Combine(Directory.GetCurrentDirectory(), "logins.txt"), FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file, Encoding.UTF8);
            //StreamReader reader = new StreamReader(file, Encoding.UTF8);
            writer.WriteLine(u.login);
            writer.WriteLine(u.Password);
            writer.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

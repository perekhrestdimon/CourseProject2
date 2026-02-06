using System;
using System.Windows.Forms;

namespace BoardGameShop_Lab1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm login = new LoginForm();

            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1(login.IsAdmin));
            }
        }
    }
}
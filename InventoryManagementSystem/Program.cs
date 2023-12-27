using System;

using System.Windows.Forms;

using MySql.Data.MySqlClient;



namespace InventoryManagementSystem
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


           
        }
    }
}



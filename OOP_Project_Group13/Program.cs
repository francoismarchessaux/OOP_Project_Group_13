﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Théotime\Desktop\OOP_Project\Code\OOP_Project_Group_13\OOP_Project_Group13\Database1.mdf;Integrated Security=True");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginWindow(connection));
            Console.ReadLine();
        }
    }
}

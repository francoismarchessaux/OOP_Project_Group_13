﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
namespace OOP_Project_Group13.Users
{
    public class Administrator : User
    {
        MySqlConnection con = Program.GetConnection();
        DateTime birthday { get; set; }
        string address { get; set; }
        public Administrator()
        {

        }

        public Administrator(int Id)
        {
            String query = "SELECT * FROM users WHERE userID='" + Id + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            string[] info = new string[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
                info[i] = dt.Rows[0][i].ToString();
            ID = Convert.ToInt32(info[0]);
            name = info[1];
            firstName = info[2];
            status = info[4];
            password = info[5];
            mail = info[6];
            profilePicture = info[3];
            birthday = Convert.ToDateTime(info[7]);
            phone = info[8];
            address = info[9];
        }
    }
}
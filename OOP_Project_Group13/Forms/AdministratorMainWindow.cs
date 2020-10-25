﻿using OOP_Project_Group13.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Group13
{
    public partial class AdministratorMainWindow : Form
    {
        SqlConnection connection;
        public AdministratorMainWindow(string fullName, int ID, string link, SqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            AdminName_Label.Text = fullName;
            AdminID_Label.Text = ID.ToString();
            AdminPP_PictureBox.ImageLocation = link;
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            CreateStudentWindow studentCreationWindow = new CreateStudentWindow(connection);
            studentCreationWindow.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
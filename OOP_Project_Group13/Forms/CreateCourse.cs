﻿using MySqlConnector;
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
    public partial class CreateCourse : Form
    {
        MySqlConnection connection;
        public CreateCourse(MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTeacher_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPeriodique_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAssignment_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePickerDate.Value;
            string jour = date.ToString("yyyy/MM/dd");
            connection.Open();
            String query = "INSERT INTO [Course] (Subject, Class, Teacher, Date,Time) VALUES ('" + textBoxSubject.Text + "', '" + textBoxClass.Text + "', '" + textBoxTeacher.Text + "','" + jour + "','" + textBoxTime.Text + "')";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Course created succesfully !");
            this.Hide();
        }

        private void CreateCourse_Load(object sender, EventArgs e)
        {

        }
    }
}

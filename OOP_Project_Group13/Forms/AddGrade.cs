﻿using MySqlConnector;
using OOP_Project_Group13.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//23202 François Marchessaux 23410 Théotime Froget 22839 Louis Faverjon 23215 Victor Guy 23194 César Maurey
namespace OOP_Project_Group13
{
    public partial class AddGrade2 : Form
    {
        MySqlConnection connection;
        Class groupName;
        public AddGrade2(MySqlConnection _connection, Class _groupName)
        {
            InitializeComponent();
            connection = _connection;
            groupName = _groupName;
        }
        /// <summary>
        /// Displays the name of the group when the page loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGrade_Load(object sender, EventArgs e)
        {
           
            classNameLabel.Text = "Class Name : " + groupName.name;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Displays the exams already created for a subject and checks if it is not already present in the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Subject = SubjectList.Text;
            bool presence = false;
            String query = "SELECT AssesmentName from Grade WHERE Subject = '" + Subject + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable GradeTable = new DataTable();
            SDA.Fill(GradeTable);
            this.comboBox1.Items.Clear();
            for (int i = 0; i < GradeTable.Rows.Count; i++)
            {
                for (int j = 0; j < comboBox1.Items.Count; j++)
                {
                    presence = false;
                    if (comboBox1.Items[j].ToString() == GradeTable.Rows[i]["AssesmentName"].ToString())
                    {
                        presence = true;
                    }
                }
                if (presence == false)
                {
                    this.comboBox1.Items.Add(GradeTable.Rows[i]["AssesmentName"].ToString());
                }

            }
        }
        
        private void classNameLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Displays people waiting for a grade for a precis exam in a datagridview
        /// Offers the possibility for the user to enter the grade of the students directly into the datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String query = "SELECT * from grade WHERE Subject = '" + SubjectList.Text + "' AND AssesmentName = '" + comboBox1.Text + "' AND Class='"+groupName.name+"'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable GradeTable = new DataTable();
            SDA.Fill(GradeTable);
            for (int i = 0; i < GradeTable.Rows.Count; i++)
            {
                Student Etudiant = new Student(Convert.ToInt32(GradeTable.Rows[i]["studentID"]));

                string Name = Etudiant.name;
                string Surname = Etudiant.firstName;
                string NumberID = GradeTable.Rows[i]["studentID"].ToString();

                dataGridView1.Rows.Add(Name, Surname,NumberID);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        /// <summary>
        /// Adds the grade entered in the datagridview to the grades of the student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            connection.Open();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    string Grade = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    String query = "UPDATE grade SET studentGrade = '" + Grade + "' WHERE  Subject = '" + SubjectList.Text + "' AND AssesmentName = '" + comboBox1.Text + "' AND studentID = '" + dataGridView1.Rows[i].Cells[2].Value + "'";
                    MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
                    SDA.SelectCommand.ExecuteNonQuery();
                }
            }
            connection.Close();
            MessageBox.Show("Grades added successfully !");
            this.Close();
        }
    }
}

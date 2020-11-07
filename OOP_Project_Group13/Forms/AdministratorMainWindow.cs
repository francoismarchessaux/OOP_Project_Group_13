﻿using MySqlConnector;
using OOP_Project_Group13.Forms;
using OOP_Project_Group13.Users;
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
        MySqlConnection connection;
        Administrator admin;
        public AdministratorMainWindow(Administrator _admin, MySqlConnection _connection)
        {
            InitializeComponent();
            connection = _connection;
            admin = _admin;
            AdminName_Label.Text = admin.firstName + " " + admin.name;
            AdminID_Label.Text = admin.ID.ToString();
            AdminPP_PictureBox.ImageLocation = admin.profilePicture;
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            CreateUser studentCreationWindow = new CreateUser(connection, "Student", admin);
            studentCreationWindow.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] studentInfo = this.StudentList.Text.Split(' ');
            String query = "Select * from users Where userID = '" + studentInfo[2] + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable studentTable = new DataTable();
            SDA.Fill(studentTable);
            Student selectedStudent = new Student(studentTable.Rows[0]["name"].ToString(), studentTable.Rows[0]["firstName"].ToString(), studentTable.Rows[0]["status"].ToString(), studentTable.Rows[0]["password"].ToString(), Convert.ToInt32(studentTable.Rows[0]["userID"]), studentTable.Rows[0]["mail"].ToString(), studentTable.Rows[0]["phone"].ToString(), studentTable.Rows[0]["profilePicture"].ToString(), Convert.ToDateTime(studentTable.Rows[0]["birthday"]), studentTable.Rows[0]["address"].ToString());
            StudentInformationsWindow studentInfoWin = new StudentInformationsWindow(connection, selectedStudent);
            studentInfoWin.Show();
        }

        private void AdministratorMainWindow_Load(object sender, EventArgs e)
        {
            String query = "Select name, firstName, userID from Users Where status = 'Student'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable userTable = new DataTable();
            SDA.Fill(userTable);
            for (int i = 0; i < userTable.Rows.Count; i++)
            {
                this.StudentList.Items.Add(userTable.Rows[i]["name"].ToString() + " " + userTable.Rows[i]["firstName"].ToString() + " " + userTable.Rows[i]["userID"].ToString());
            }
            query = "Select name, firstName, userID from Users Where status = 'Faculty'";
            SDA = new MySqlDataAdapter(query, connection);
            DataTable TeacherTable = new DataTable();
            SDA.Fill(TeacherTable);
            for (int i = 0; i < TeacherTable.Rows.Count; i++)
            {
                this.TeacherList.Items.Add(TeacherTable.Rows[i]["name"].ToString() + " " + TeacherTable.Rows[i]["firstName"].ToString() + " " + TeacherTable.Rows[i]["userID"].ToString());
            }
            query = "Select className from class";
            SDA = new MySqlDataAdapter(query, connection);
            DataTable ClassTable = new DataTable();
            SDA.Fill(ClassTable);
            for (int i = 0; i < ClassTable.Rows.Count; i++)
            {
                this.ClassesList.Items.Add(ClassTable.Rows[i]["className"]);
            }
        }

        private void CreateCourseButton_Click(object sender, EventArgs e)
        {
            CreateCourse ccWin = new CreateCourse(connection, admin);
            ccWin.Show();
            this.Hide();
        }

        private void TeacherList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] teacherInfo = this.TeacherList.Text.Split(' ');
            String query = "Select * from users Where userID = '" + teacherInfo[2] + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable teacherTable = new DataTable();
            SDA.Fill(teacherTable);
            Faculty selectedTeacher = new Faculty(teacherTable.Rows[0]["name"].ToString(), teacherTable.Rows[0]["firstName"].ToString(), teacherTable.Rows[0]["status"].ToString(), teacherTable.Rows[0]["password"].ToString(), Convert.ToInt32(teacherTable.Rows[0]["userID"]), teacherTable.Rows[0]["mail"].ToString(), teacherTable.Rows[0]["phone"].ToString(), teacherTable.Rows[0]["profilePicture"].ToString());
            FacultyInformationsWindows TeacherInfoWin = new FacultyInformationsWindows(connection, selectedTeacher);
            TeacherInfoWin.Show();
        }

        private void CreateTeacherBtn_Click(object sender, EventArgs e)
        {
            CreateUser teacherCreationWindow = new CreateUser(connection, "Faculty", admin);
            teacherCreationWindow.Show();
            this.Hide();
        }

        private void ClassesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string classNameStr = ClassesList.Text;
            String query = "Select * from class Where className = '" + classNameStr + "'";
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            DataTable classTable = new DataTable();
            SDA.Fill(classTable);
            Class selectedClass = new Class(classTable.Rows[0]["className"].ToString(), classTable.Rows[0]["studentsIDs"].ToString());
            ManageClassWindow classMngWin = new ManageClassWindow(selectedClass, connection);
            classMngWin.Show();
        }

        private void CreateClassButton_Click(object sender, EventArgs e)
        {
            CreateClass ClassCreationWindow = new CreateClass(connection);
            ClassCreationWindow.Show();
            Hide();
        }
    }
}
﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP_Project_Group13.Users;
using System.Windows;

namespace OOP_Project_Group13.Forms
{
    public partial class CreateExamButton : Form
    {
        MySqlConnection connection;
        Class group;
        TimeTable tbl;
        public CreateExamButton(Class _class, MySqlConnection _connection)
        {
            InitializeComponent();
            group = _class;
            connection = _connection;
        }

        private void ManageClassWindow_Load(object sender, EventArgs e)
        {
            classNameLabel.Text = "Class Name : " + group.name;
            for (int i = 0; i < group.students.Count; i++)
                dataGridView1.Rows.Add(group.students[i].ID, group.students[i].name, group.students[i].firstName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCourse createCoursewin = new CreateCourse(connection, group.name);
            createCoursewin.Show();
        }

        private void ModifyCourseBtn_Click(object sender, EventArgs e)
        {
            CreateCourse createCoursewin = new CreateCourse(connection, group.name);
            createCoursewin.Show();
        }

        private void TimetableBtn_Click(object sender, EventArgs e)
        {
            TimeTablePnl.Visible = true;
            dataGridView1.Visible = false;
            TimeTable classTimetable = new TimeTable(group.students[0], TimeTablePnl, "Admin");
            classTimetable.InitializeTimeTable();
            classTimetable.GetTimetable();
        }

        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            TimeTablePnl.Visible = false;
        }

        private void buttonCreateExam_Click_1(object sender, EventArgs e)
        {
            CreateExam createExamwin = new CreateExam(connection, group);
            createExamwin.Show();
        }
    }
}

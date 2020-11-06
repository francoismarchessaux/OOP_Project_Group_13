using MySqlConnector;
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

namespace OOP_Project_Group13.Forms
{
    public partial class CreateUser : Form
    {
        MySqlConnection connection;
        string status;

        public CreateUser(MySqlConnection _connection, string _status)
        {
            InitializeComponent();
            connection = _connection;
            status = _status;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            bool continueID = true;
            int IDbase = Convert.ToInt32(DateTime.Now.Year.ToString() + "01");
            while(continueID == true)
            {
                String queryID = "Select * from users Where userID = ' " + IDbase + "'";
                MySqlDataAdapter sdaID = new MySqlDataAdapter(queryID, connection);
                DataTable idTable = new DataTable();
                sdaID.Fill(idTable);
                if (idTable.Rows.Count != 0 )
                {
                    IDbase++;
                }
                else
                {
                    continueID = false;
                }
            }
            connection.Open();
            String query;
            if(status == "Student")
            {
                query = "INSERT INTO users (userID, name, firstName, mail, status) VALUES ('" + IDbase + "', '" + LastName_TxtBox.Text.ToUpper() + "', '" + FirstName_TxtBox.Text + "', '" + FirstName_TxtBox.Text.ToLower() + "." + LastName_TxtBox.Text.ToLower() + "@college.ie', 'Student')";
            }
            else
            {
                query = "INSERT INTO users (userID, name, firstName, mail, status) VALUES ('" + IDbase + "', '" + LastName_TxtBox.Text.ToUpper() + "', '" + FirstName_TxtBox.Text + "', '" + FirstName_TxtBox.Text.ToLower() + "." + LastName_TxtBox.Text.ToLower() + "@college.ie', 'Faculty')";
            }
            MySqlDataAdapter SDA = new MySqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            if(status == "Student")
            {
                MessageBox.Show("Student created succesfully !");
            }
            else
            {
                MessageBox.Show("Teacher created succesfully !");
            }
            this.Hide();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
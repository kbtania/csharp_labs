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

namespace DBLab13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Phonebook.mdf;Integrated Security=True";

        // відобразити дані
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Friends", ConnectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            //SqlCommand command = new SqlCommand("insert into Friends (Surname,Name,MiddleName,Phone,BirthDate,Street,House)Values(@Surname,@Name,@MiddleName,@Phone,@BirthDate,@Street,@House)", connection);
            //command.Parameters.Add("@Surname", textBox_surname.Text);
            //command.Parameters.Add("@Name", textBox_name.Text);
            //command.Parameters.Add("@MiddleName", textBox_middleName.Text);
            //command.Parameters.Add("@Phone", textBox_phone.Text);
            //command.Parameters.Add("@BirthDate", Convert.ToDateTime(textBox_birthDate.Text));
            //command.Parameters.Add("@Street", textBox_street.Text);
            //command.Parameters.Add("@House", Convert.ToInt32(textBox_house.Text));

            string query = "INSERT INTO Friends (Surname,Name,MiddleName,Phone,BirthDate,Street,House)";
            query += " VALUES (@Surname,@Name,@MiddleName,@Phone,@BirthDate,@Street,@House)";

            SqlCommand myCommand = new SqlCommand(query,connection);
            myCommand.Parameters.AddWithValue("@Surname", textBox_surname.Text);
            myCommand.Parameters.AddWithValue("@Name", textBox_name.Text);
            myCommand.Parameters.AddWithValue("@MiddleName", textBox_middleName.Text);
            myCommand.Parameters.AddWithValue("@Phone", textBox_phone.Text);
            myCommand.Parameters.AddWithValue("@BirthDate", Convert.ToDateTime(textBox_birthDate.Text));
            myCommand.Parameters.AddWithValue("@Street", textBox_street.Text);
            myCommand.Parameters.AddWithValue("@House", Convert.ToInt32(textBox_house.Text));
            // ... other parameters
            myCommand.ExecuteNonQuery();


            //command.ExecuteNonQuery();
            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from Friends where Id=@Id", connection);
            command.Parameters.Add("@Id", id);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("Update Friends Set Surname=@Surname,Name=@Name,MiddleName=@MiddleName," +
                    "Phone=@Phone,BirthDate=@BirthDate,Street=@Street,House=@House where Id=@Id", connection);
                command.Parameters.Add("@Id", Convert.ToInt32(dataGridView1[0, i].Value));
                //string s = dataGridView1[1, i].Value.ToString();
                command.Parameters.Add("@Surname", Convert.ToString(dataGridView1[1, i].Value));
                command.Parameters.Add("@Name", Convert.ToString(dataGridView1[2, i].Value));
                command.Parameters.Add("@MiddleName", Convert.ToString(dataGridView1[3, i].Value));
                command.Parameters.Add("@Phone", Convert.ToString(dataGridView1[4, i].Value));
                command.Parameters.Add("@BirthDate", new DateTime(2012, 10, 9));
                command.Parameters.Add("@Street", Convert.ToString(dataGridView1[6, i].Value));
                command.Parameters.Add("@House", Convert.ToInt32(dataGridView1[7, i].Value));

                command.ExecuteNonQuery();
                connection.Close();





            }

        }
       

        
    }
}

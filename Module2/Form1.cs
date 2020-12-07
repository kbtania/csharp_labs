using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Module2
{
    public partial class Form1 : Form
    {
        string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Module2\Gallery.mdf;Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        // displays all data
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Gallery", CONNECTION_STRING);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        // get data by Id
        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            string query = "SELECT Id, Author, [Name], Price " +
                "FROM Gallery " +
                "WHERE Id = @id";

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            da.SelectCommand = cmd;
            cmd.Parameters.Add("@id", SqlDbType.Int, 30).Value = id;

            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        // dispays general price of all items with Status = 2
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            string query = "SELECT SUM(Price) AS [General Price] FROM Gallery WHERE[Status] = 2";

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            da.SelectCommand = cmd;
            
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
        
        // delete item from table
        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.Value);
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Gallery WHERE Id=@Id", connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

        // add new item
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            
            string query = "INSERT INTO Gallery (Author, [Name], Price, [Status])";
            query += " VALUES (@Author,@Name,@Price,@Status)";

            SqlCommand myCommand = new SqlCommand(query, connection);
            myCommand.Parameters.AddWithValue("@Author", textBox2.Text);
            myCommand.Parameters.AddWithValue("@Name", textBox3.Text);
            myCommand.Parameters.AddWithValue("@Price", Convert.ToDecimal(textBox4.Text));
            myCommand.Parameters.AddWithValue("@Status", Convert.ToInt32(comboBox1.Text));
            myCommand.ExecuteNonQuery();
            connection.Close();
        }

        // update table
        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                SqlConnection connection = new SqlConnection(CONNECTION_STRING);
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Gallery SET Author=@Author,Name=@Name,Price=@Price," +
                    "Status=@Status WHERE Id=@Id", connection);
                command.Parameters.AddWithValue ("@Id", Convert.ToInt32(dataGridView1[0, i].Value));
                command.Parameters.AddWithValue("@Author", Convert.ToString(dataGridView1[1, i].Value));
                command.Parameters.AddWithValue("@Name", Convert.ToString(dataGridView1[2, i].Value));
                command.Parameters.AddWithValue("@Price", Convert.ToDecimal(dataGridView1[3, i].Value));
                command.Parameters.AddWithValue("@Status", Convert.ToInt32(dataGridView1[4, i].Value));
                
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}

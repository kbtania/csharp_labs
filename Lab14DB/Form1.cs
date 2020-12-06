using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab14DB
{
    public partial class Form1 : Form
    {
        string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Lab14DB\Shops.mdf;Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Shop", CONNECTION_STRING);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
            MessageBox.Show(CONNECTION_STRING);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                SqlConnection connection = new SqlConnection(CONNECTION_STRING);
                connection.Open();
                SqlCommand command = new SqlCommand("Update Shop Set Name=@Name,Profile=@Profile,City=@City," +
                    "Street=@Street,HouseNum=@HouseNum,Capital=@Capital,Phone=@Phone where Id=@Id", connection);
                command.Parameters.AddWithValue("@Id", Convert.ToInt32(dataGridView1[0, i].Value));
                command.Parameters.AddWithValue("@Name", Convert.ToString(dataGridView1[1, i].Value));
                command.Parameters.AddWithValue("@Profile", Convert.ToString(dataGridView1[2, i].Value));
                command.Parameters.AddWithValue("@City", Convert.ToString(dataGridView1[3, i].Value));
                command.Parameters.AddWithValue("@Street", Convert.ToString(dataGridView1[4, i].Value));
                command.Parameters.AddWithValue("@HouseNum", Convert.ToInt32(dataGridView1[5, 1].Value));
                command.Parameters.AddWithValue("@Capital", Convert.ToDecimal(dataGridView1[6, i].Value));
                command.Parameters.AddWithValue("@Phone", Convert.ToInt32(dataGridView1[7, i].Value));
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        // наймолодший підприємець, що має власність у вказаному місті 
        private void button3_Click(object sender, EventArgs e)
        {
            string city = textBox1.Text;
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            string query = "SELECT TOP 1[Owner].[Name] AS Власник, [Owner].BirthDate, Shop.[Name], Shop.City " +
                "FROM[Owner] " +
                "JOIN OwnerShop ON[Owner].Id = OwnerShop.OwnerId " +
                "JOIN Shop ON OwnerShop.ShopId = Shop.Id " +
                "WHERE Shop.City = @city " +
                "ORDER BY [Owner].BirthDate DESC" ;

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            da.SelectCommand = cmd;
            cmd.Parameters.Add("@city", SqlDbType.NVarChar, 30).Value = city;

            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        // випадки, коли реєструвалося володіння особами, які не доягли 18 років
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            string query = "SELECT [Owner].[Name], [Owner].BirthDate, [Owner].RegistrationDate " +
                "FROM[Owner] " +
                "WHERE DATEDIFF(YEAR, [Owner].BirthDate, [Owner].RegistrationDate) <= 18";

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        // випадки, коли більше 50% статутного капіталу магазину внесено підприємцем,
        // який проживає в іншому місті
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            string query = "SELECT [Owner].[Name], [Owner].City, Shop.[Name], Shop.City, OwnerShop.Investment " +
                "FROM[Owner] JOIN OwnerShop ON[Owner].Id = OwnerShop.OwnerId " +
                "JOIN Shop ON OwnerShop.ShopId = Shop.Id " +
                "Where[Owner].City != Shop.City AND(Shop.Capital / 2) < OwnerShop.Investment";

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        // список магазинів, якими володіє Особа в порядку спадання 
        // вкладеного в них капіталу
        private void button6_Click(object sender, EventArgs e)
        {
            string person = textBox2.Text;
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            string query = "SELECT [Owner].[Name], Shop.[Name], Shop.Profile, OwnerShop.Investment " +
                "FROM[Owner] JOIN OwnerShop ON[Owner].Id = OwnerShop.OwnerId " +
                "JOIN Shop ON OwnerShop.ShopId = Shop.Id " +
                "WHERE[Owner].[Name] LIKE @person " +
                "ORDER BY [OwnerShop].Investment DESC";

            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand(query, connection);
            da.SelectCommand = cmd;
            cmd.Parameters.Add("@person", SqlDbType.NVarChar, 100).Value = $"%{person}%";

            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(
                "SELECT S.[Name], S.City, O.[Name] " +
                "FROM OwnerShop AS OS " +
                "INNER JOIN Shop AS S " +
                "ON OS.ShopId = S.Id LEFT JOIN[Owner] AS O " +
                "ON O.Id = OS.OwnerId", CONNECTION_STRING);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }
    }
}

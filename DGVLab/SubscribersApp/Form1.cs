using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SubscribersApp
{
    public partial class Form1 : Form
    {
        List<Subscriber> SubscribersList;
        BindingSource BindSource;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SubscribersList = new List<Subscriber>(); //create list of Subscribers
            BindSource = new BindingSource(); //create binding source
            BindSource.DataSource = SubscribersList; //connect SubscribersList with binding source
            dataGridView1.DataSource = BindSource;
            dataGridView1.Columns["Name"].HeaderText = "Name";
            dataGridView1.Columns["Number"].HeaderText = "Number";
            dataGridView1.Columns["Year"].HeaderText = "Year";
            dataGridView1.Columns["Debt"].HeaderText = "Debt";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subscriber item = new Subscriber(textBox_name.Text, Convert.ToInt32(textBox_number.Text), Convert.ToInt32(textBox_year.Text), checkBox_debt.Checked);
            BindSource.Add(item);
            textBox_name.Text = "";
            textBox_number.Text = "";
            textBox_year.Text = "";
            checkBox_debt.Checked = false;
        }

        private void button_rangeByYears_Click(object sender, EventArgs e)
        // displays the amount of subscribers in range of specified years
        {
            int count = SubscribersList.Where(s => s.Year<=Convert.ToInt32(textBox_to.Text)&&s.Year>=Convert.ToInt32(textBox_from.Text)).Count();
            MessageBox.Show(Convert.ToString(count));
        }

        private void button_showDebt_Click(object sender, EventArgs e)
        // displays the amount of subscribers with debt
        {
            var subscribersWithDebt = SubscribersList.Where(s => s.Debt == true);
            int count = subscribersWithDebt.Count();
            foreach (var s in subscribersWithDebt)
                MessageBox.Show(Convert.ToString(s));
        }

        private void button_findByNumber_Click(object sender, EventArgs e)
        // find subsriber by number
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((Convert.ToString(row.Cells["Number"].Value) == textBox_findByNumber.Text))
                {
                    row.Cells["Number"].Style.BackColor = System.Drawing.Color.Green;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter bf = new BinaryFormatter();
                BindSource.Clear();
                foreach (Subscriber b in (List<Subscriber>)bf.Deserialize(fs))
                {
                    BindSource.Add(b);
                }
                fs.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, SubscribersList);
                fs.Close();
            }
        }

        
    }
}

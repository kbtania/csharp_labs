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
using System.Xml;
//using System.Text.Json;
using System.Runtime.Serialization.Json;
//using Newtonsoft.Json;

using Excel = Microsoft.Office.Interop.Excel;

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
            SubscribersList = new List<Subscriber>();
            BindSource = new BindingSource();
            BindSource.DataSource = SubscribersList;
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

        // displays the amount of subscribers in range of specified years
        private void button_rangeByYears_Click(object sender, EventArgs e)
        {
            int count = SubscribersList.Where(s => s.Year <= Convert.ToInt32(textBox_to.Text) && s.Year >= Convert.ToInt32(textBox_from.Text)).Count();
            MessageBox.Show(Convert.ToString(count));
        }

        // displays the amount of subscribers with debt
        private void button_showDebt_Click(object sender, EventArgs e)
        {
            var subscribersWithDebt = SubscribersList.Where(s => s.Debt == true);
            int count = subscribersWithDebt.Count();
            foreach (var s in subscribersWithDebt)
                MessageBox.Show(Convert.ToString(s));
        }

        // find subsriber by number
        private void button_findByNumber_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if ((Convert.ToString(row.Cells["Number"].Value) == textBox_findByNumber.Text))
                {
                    row.Cells["Number"].Style.BackColor = System.Drawing.Color.Green;
                }
            }
        }

        private void saveToXMLDocument(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            doc.AppendChild(declaration);
            doc.AppendChild(createXmlSubscriberList(doc));
            doc.Save(fileName);
        }

        private XmlElement createXmlSubscriberList(XmlDocument doc)
        {
            XmlElement subscriberList = doc.CreateElement("subscriberList");
            foreach (var item in SubscribersList)
                subscriberList.AppendChild(item.ToXmlElement(doc));
            return subscriberList;
        }

        // save as Xml file
        private void saveWithXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                saveToXMLDocument(saveFileDialog.FileName);
        }

        // open Xml file
        private void openWithXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(openFileDialog.FileName);

                XmlNodeList subscribersXmlList = doc.GetElementsByTagName("subscriber");
                List<Subscriber> list = new List<Subscriber>();
                foreach (XmlElement item in subscribersXmlList)
                    list.Add(Subscriber.FromXmlElement(item));
                foreach (Subscriber s in list)
                    BindSource.Add(s);
            }
        }

        // open binary file
        private void openWithBinaryFormatToolStripMenuItem_Click(object sender, EventArgs e)
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

        // save binary file
        private void saveWithBinaryFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, SubscribersList);
                fs.Close();
            }
        }

        // save Excel
        private void saveToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Excel.Worksheet wsh = (Excel.Worksheet)exApp.ActiveSheet;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    wsh.Cells[i + 1, j + 1] = dataGridView1[j, i].Value.ToString();
                }
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                exApp.Application.ActiveWorkbook.SaveAs(saveFileDialog.FileName, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            //exApp.Application.ActiveWorkbook.Close(false);
            exApp.Application.Quit();
        }

        private void openWithExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                exApp.Workbooks.Open(openFileDialog.FileName,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);    
            }
            exApp.Visible = true;
            
            exApp.Application.ActiveWorkbook.Close(false);
            exApp.Application.Quit();

        }
        
        private async void saveAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Subscriber>));
                using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(file, SubscribersList);
                }
            }

        }
        
        private async void openWithJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            dataGridView1.Rows.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Subscriber>));
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    SubscribersList = jsonFormatter.ReadObject(file) as List<Subscriber>;
                    if (SubscribersList != null)
                    {
                        for (int i = 0; i < SubscribersList.Count; i++)
                        {
                            BindSource.Add(SubscribersList[i]);
                        }
                    }
                }
            }


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}

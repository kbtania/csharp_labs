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
using System.Runtime.Serialization.Json;


namespace Module1
{
    public partial class Form1 : Form
    {
        List<Gallery> GalleryList;
        BindingSource BindSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GalleryList = new List<Gallery>();
            BindSource = new BindingSource();
            var item1 = new Gallery(1, "Pablo Picasso", "Guernica", 200, 1);
            var item2 = new Gallery(2, "Vincent van Gogh", "The Starry Night", 100, 2);
            var item3 = new Gallery(3, "Leonardo da Vinci", "Mona Lisa", 100, 1);
            var item4 = new Gallery(4, "Michelangelo", "Doni Madonna", 300, 1);
            var item5 = new Gallery(5, "Edvard Munch", "Train Smoke", 400, 1);
            GalleryList.Add(item1);
            GalleryList.Add(item2);
            GalleryList.Add(item3);
            GalleryList.Add(item4);
            GalleryList.Add(item5);
            BindSource.DataSource = GalleryList;
            dataGridView1.DataSource = BindSource;
            dataGridView1.Columns["Id"].HeaderText = "Id";
            dataGridView1.Columns["Painter"].HeaderText = "Painter";
            dataGridView1.Columns["NameOfPicture"].HeaderText = "NameOfPicture";
            dataGridView1.Columns["Price"].HeaderText = "Price";
            dataGridView1.Columns["Status"].HeaderText = "Status";
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gallery item = new Gallery(Convert.ToInt32(textBox_id.Text), textBox_painter.Text,
                textBox_nameOfPicture.Text, Convert.ToDouble(textBox_price.Text),
                Convert.ToInt32(textBox_status.Text));
            BindSource.Add(item);
            textBox_id.Text = "";
            textBox_painter.Text = "";
            textBox_nameOfPicture.Text = "";
            textBox_price.Text = "";
            textBox_status.Text = "";
        }

        // calculates sum of all prices
        private void button2_Click(object sender, EventArgs e)
        {
            double s = 0;
            foreach (var item in GalleryList)
            {
                s += item.Price;
            }
            MessageBox.Show($"General price: {s.ToString()}");
        }

        // open binary
        private void asBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                BinaryFormatter bf = new BinaryFormatter();
                BindSource.Clear();
                foreach (Gallery b in (List<Gallery>)bf.Deserialize(fs))
                {
                    BindSource.Add(b);
                }
                fs.Close();
            }
        }

        // save binary
        private void saveAsBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, GalleryList);
                fs.Close();
            }
        }

        private void saveToXMLDocument(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            doc.AppendChild(declaration);
            doc.AppendChild(createXmlGalleryList(doc));
            doc.Save(fileName);
        }

        private XmlElement createXmlGalleryList(XmlDocument doc)
        {
            XmlElement subscriberList = doc.CreateElement("galleryList");
            foreach (var item in GalleryList)
                subscriberList.AppendChild(item.ToXmlElement(doc));
            return subscriberList;
        }

        private void openAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(openFileDialog.FileName);

                XmlNodeList galleriesXmlList = doc.GetElementsByTagName("gallery");
                List<Gallery> list = new List<Gallery>();
                foreach (XmlElement item in galleriesXmlList)
                    list.Add(Gallery.FromXmlElement(item));
                foreach (Gallery g in list)
                    BindSource.Add(g);
            }
        }

        private void saveAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                saveToXMLDocument(saveFileDialog.FileName);
        }

        private void openAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            dataGridView1.Rows.Clear();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Gallery>));
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    GalleryList = jsonFormatter.ReadObject(file) as List<Gallery>;
                    if (GalleryList != null)
                    {
                        for (int i = 0; i < GalleryList.Count; i++)
                        {
                            BindSource.Add(GalleryList[i]);
                        }
                    }
                }
            }
        }

        private void saveAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Gallery>));
                using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(file, GalleryList);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                chart1.Series[0].Points.AddY(dataGridView1.Rows[i].Cells["Price"].Value);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (var item in GalleryList)
            {
                if (item.Id.ToString()==textBox_id.Text)
                {
                    MessageBox.Show(item.ToString());
                }
            }
        }
    }
}

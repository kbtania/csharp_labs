# ЛАБОРАТОРНА РОБОТА 
## Тема: Елемент управління DataGridView

## Завдання:
**У заданій цілочисловій прямокутній матриці визначити:**
- добуток елементів у тих рядках, які не містять від’ємних елементів;
- максимум серед сум елементів діагоналей, паралельних головній діагоналі.

## Form1.cs
```cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 2;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)numericUpDown1.Value;
            dataGridView1.ColumnCount = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        // product of elements in raw with all positive elements
        {
            int[,] matrix = WriteToArray();

            int n = dataGridView1.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                int j;
                for (j = 0; j < n; j++)
                    if (matrix[i, j] < 0) break;
                if (j < n) continue;
                int product = 1;
                for (j = 0; j < n; j++)
                {
                    product *= matrix[i, j];
                }
                MessageBox.Show($"Row {i}:, product = {product}");
            }
        }

        public int[,] WriteToArray()
        {
            int[,] DataValue = new int[dataGridView1.Rows.Count, dataGridView1.Columns.Count];
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    DataValue[row.Index, col.Index] = Convert.ToInt32(dataGridView1.Rows[row.Index].Cells[col.Index].Value);
                }
            }
            return DataValue;
        }
        private void button2_Click(object sender, EventArgs e)
        // max of sums of diagonals parallel to the main one
        {
            int[,] matrix = WriteToArray();   
            int maxSum = -10;
            int size = dataGridView1.Rows.Count;

            // looping through elements above main diagonal
            for (int k = 0; k < size; k++)
            {
                int i = 0;
                int sum = 0;
                for (int j = k; j < size; j++)
                {
                    sum += matrix[i, j];
                    i++;
                }
                if (sum > maxSum)
                    maxSum = sum;
            }

            // looping through elemnts below main diagonal
            for (int k = 1; k < size; k++)
            {
                int j = 0;
                int sum = 0;
                for (int i = k; i < size; i++)
                {
                    sum += matrix[i, j];
                    j++;
                }
                if (sum > maxSum)
                    maxSum = sum;
            }
            MessageBox.Show($"max sum = {maxSum}");
        }
    }
}
```

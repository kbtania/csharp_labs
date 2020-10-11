# ЛАБОРАТОРНА РОБОТА 17
## Завдання:
**З клавіатури послідовно вводяться дійсні числа до тих пір, поки їх сума не буде
перевищувати величину d . Використовуючи динамічну структуру даних для їх
збереження вивести всі елементи кратні 3 у порядку їх введення.**

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

namespace Lab17
{
    public partial class Form1 : Form
    {
        Queue<double> numbers = new Queue<double>();
        double sum = 0;
        double userInput;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int d = Convert.ToInt32(textBox1.Text);
            if(sum <= d)
            {
                userInput = Convert.ToDouble(textBox2.Text);
                textBox2.Text = "";
                sum += userInput;
                numbers.Enqueue(userInput);
                textBox3.Text += $"{userInput}  ";
            }
            else
            {
                MessageBox.Show($"Sum is greater than {d}");
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            foreach (var item in numbers)
            {
                if (item % 3 == 0)
                {
                    textBox3.Text += $"{item}  ";
                }
            }
        }
    }
}
```

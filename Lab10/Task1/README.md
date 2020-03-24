# ЛАБОРАТОРНА РОБОТА № 10

## Завдання 1

| **Клас** | **Число** |
| ------ | ------ |
| **Поля** | для зберігання натурального числа; |
| **Методи** | виведення числа;|
|    | введення числа;; |
|    | визначення площі; |
|    | знаходження кількості цифр; |
|    | пзнаходження суми цифр. |

Number.cs
```cs
using System;

namespace Lab10Task1
{
    class Number
    {
        private int num;

        public int Num
        {
            get { return num; }
            set
            {
                if (value < 0)
                    throw new Exception("Number must be positive integer.");
                num = value;
            }
        }

        public Number(int userNum)
        {
            Num = userNum;
        }

        public override string ToString()
        {
            return $"{num}";
        }

        public int CountOfNums()
        {
            return num.ToString().Length;
        }

        public int SumOfDigits()
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
```
Program.cs
```cs
using System;

namespace Lab10Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                Number n = new Number(number);

                Console.WriteLine($"The number: {n.ToString()}"); // string output of an object
                Console.WriteLine($"Count of digits: {n.CountOfNums()}");
                Console.WriteLine($"Sum of digits: {n.SumOfDigits()}");
            }
            
            catch
            {
                Console.WriteLine("Number must be positive integer.");
            }
        }
    }
}
```

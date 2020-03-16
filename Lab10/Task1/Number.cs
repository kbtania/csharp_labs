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


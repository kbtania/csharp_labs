# ЛАБОРАТОРНА РОБОТА № 14

## Завдання 1
- Створити клас **TBody**, який представляє просторову геометричну фігуру з
методами обчислення площі поверхні та об’єму. На основі цього класу створити
класи нащадки **TParallelepiped** та **TBall**. Випадковим чином створити певну
кількість паралелепіпедів та куль, щоб їх сумарна кількість дорівнювала **n** . Знайти
сумарну площу поверхонь усіх геометричних тіл.

- Body.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14
{
    public abstract class Body
    {
        private protected int data;
        public  int Data
        {
            get { return data; }
            set
            {
                if (value < 0)
                    throw new Exception("Cannot be negative");
                data = value;
            }
        }
        public Body(int data)
        {
            Data = data;
        }

        public abstract double Area();

        public abstract double Volume();
    }
}
```

- Parallelepiped.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14
{
    class Parallelepiped:Body
    {
        private int a;
        private int b;
        public int A
        {
            get { return a; }
            set
            {
                if (value < 0)
                    throw new Exception("Cannot be negative");
                a = value;
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                if (value < 0)
                    throw new Exception("Cannot be negative");
                b = value;
            }
        }
    
        public Parallelepiped(int a, int b, int side) : base(side) 
        {
            A = a;
            B = b;
        }

        public override double Area()
        {
            double P = 2 * (a + b);
            double S = a * b;
            return P * Data + 2 * S;
        }

        public override double Volume()
        {
            return a * b * Data;
        }

        public override string ToString()
        {
            return $"Parallelepiped: Sides = {a}, {b}, {Data}";
        }

    }
}
```

- Ball.cs
```cs
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14
{
    class Ball:Body
    {
        public Ball(int r) : base(r) { }

        public override double Area()
        {
            return 4 * Math.PI * Math.Pow(Data, 2);
        }

        public override double Volume()
        {
            return (4 * Math.PI * Data) / 3;
        }

        public override string ToString()
        {
            return $"Ball: R = {Data}";
        }
    }
}
```

- Program.cs
```cs
using System;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Write("Enter the amount of figures: ");
                int n = Convert.ToInt32(Console.ReadLine());

                Body[] figures = new Body[n];
                Random rnd = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < figures.Length; i++)
                {
                    switch (rnd.Next(1,3))
                    {
                        case 1: figures[i] = new Parallelepiped(rnd.Next(1,10), rnd.Next(1,10), rnd.Next(1,10));
                            break;
                        case 2: figures[i] = new Ball(rnd.Next(1, 10));
                            break;
                    }
                }

                // outputs every figure
                for (int i = 0; i < figures.Length; i++)
                {
                    Console.WriteLine(figures[i]);
                }

                // calculates the general area
                double sum = 0;
                for (int i = 0; i < figures.Length; i++)
                {
                    sum += figures[i].Area();
                }

                Console.WriteLine(" ");
                Console.WriteLine($"SUM = {sum}");
            }
            catch
            {
                Console.WriteLine("Cannot be negative");
            }
        }
    }
}
```

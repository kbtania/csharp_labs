using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15Test
{
    class Equation : IMatrix2x2, IMatrix3x3
    {
        private double[,] matrix = new double[3,4];
        
        public double[,] Matrix {get;set;}

        public Equation()
        {
            Matrix = matrix;
        }
        
        public double this[int i, int j]
        {
            get
            {
                return Matrix[i, j];
            }
            set
            {
                Matrix[i, j] = value;
            }
        }

        // set values of coefficients of the system of TWO linear equations
        void IMatrix2x2.SetValues(ref Equation mtrx)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Coefficient {i}{j} = ");
                    mtrx[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        // finds the roots of the system of TWO linear equations using determinant
        void IMatrix2x2.Solution(out double x1, out double x2)
        {
            double det = Matrix[0, 0] * Matrix[1, 1] - Matrix[0, 1] * Matrix[1, 0];
            double det1 = Matrix[0, 2] * Matrix[1, 1] - Matrix[1, 2] * Matrix[0, 1];
            double det2 = Matrix[0, 0] * Matrix[1, 2] - Matrix[1, 0] * Matrix[0, 2];

            x1 = det1 / det;
            x2 = det2 / det;
        }

        // outputs the system of TWO linear equations
        void IMatrix2x2.EquationOutput()
        {
            Console.WriteLine($" {Matrix[0,0]}x+{Matrix[0,1]}y = {Matrix[0,2]}\n {Matrix[1,0]}x+{Matrix[1,1]}y = {Matrix[1,2]}");
        }


        // set values of coefficients of the system of THREE linear equations
        void IMatrix3x3.SetValues(ref Equation mtrx)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"Coefficient {i}{j} = ");
                    mtrx[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }

        // finds the roots of the system of THREE linear equations using determinant
        void IMatrix3x3.Solution(out double x1, out double x2, out double x3)
        {
            
            double det = Matrix[0, 0] * Matrix[1, 1] * Matrix[2, 2] + 
                Matrix[0, 1] * Matrix[1, 2] * Matrix[2, 0] + 
                Matrix[1, 0] * Matrix[2, 1] * Matrix[0, 2] - 
                Matrix[2, 0] * Matrix[1, 1] * Matrix[0, 2] - 
                Matrix[1, 0] * Matrix[0, 1] * Matrix[2, 2] - 
                Matrix[2, 1] * Matrix[1, 2] * Matrix[0, 0]; 
            
            double det1 = Matrix[0, 2] * Matrix[1, 1] * Matrix[2, 2] + 
                Matrix[0, 1] * Matrix[1, 2] * Matrix[2, 3] +
                Matrix[1, 3] * Matrix[2, 1] * Matrix[0, 2] - 
                Matrix[2, 3] * Matrix[1, 1] * Matrix[0, 2] -
                Matrix[1, 3] * Matrix[0, 1] * Matrix[2, 2] -
                Matrix[2, 1] * Matrix[1, 2] * Matrix[0, 3];
            
            double det2 = Matrix[0, 0] * Matrix[1, 3] * Matrix[2, 2] + 
                Matrix[0, 3] * Matrix[1, 2] * Matrix[2, 0] + 
                Matrix[1, 0] * Matrix[2, 3] * Matrix[0, 2] - 
                Matrix[2, 0] * Matrix[1, 3] * Matrix[0, 2] -
                Matrix[1, 0] * Matrix[0, 3] * Matrix[2, 2] - 
                Matrix[2, 3] * Matrix[1, 2] * Matrix[0, 0];
            
            double det3 = Matrix[0, 0] * Matrix[1, 1] * Matrix[2, 3] +
                Matrix[0, 1] * Matrix[1, 3] * Matrix[2, 0] + 
                Matrix[1, 0] * Matrix[2, 1] * Matrix[0, 3] -
                Matrix[2, 0] * Matrix[1, 1] * Matrix[0, 3] -
                Matrix[1, 0] * Matrix[0, 1] * Matrix[2, 3] - 
                Matrix[2, 1] * Matrix[1, 3] * Matrix[0, 0];
            x1 = det1 / det;
            x2 = det2 / det;
            x3 = det3 / det;
        }

        // outputs the system of THREE linear equations
        void IMatrix3x3.EquationOutput()
        {
            Console.WriteLine($" {Matrix[0, 0]}x+{Matrix[0, 1]}y + {Matrix[0, 2]}z = {Matrix[0,3]}\n " +
                $"{Matrix[1, 0]}x+{Matrix[1, 1]}y + {Matrix[1, 2]}z = {Matrix[1,3]}\n" +
                $" {Matrix[2,0]}x + {Matrix[2,1]}y + {Matrix[2,2]}z = {Matrix[2,3]}");
        }

    }
}

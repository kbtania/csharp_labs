using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15Test
{
    interface IMatrix2x2
    {
        void SetValues(ref Equation mtrx);
        void EquationOutput();
        void Solution(out double x1, out double x2);
    }
}

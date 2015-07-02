using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlayingWithShouldly
{
    public class Calculator
    {
        public static int AddInts(int a, int b)
        {
            Thread.Sleep(98);
            return a + b;
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Divide(int number, int by)
        {
            if (number > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(number));
            }

            return number / by;
        }
    }
}

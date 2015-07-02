using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shouldly;

namespace PlayingWithShouldly.Tests
{
    public class CalculatorTests
    {
        public void ShouldThrowExceptionWhenDivideByZero()
        {
            var calculator = new Calculator();
            Should.Throw<DivideByZeroException>(() => calculator.Divide(100, 0));
        }

        public void ShouldThrowExceptionWhenNumberTooBig()
        {
            var calculator = new Calculator();
            var ex = Should.Throw<ArgumentOutOfRangeException>(() => calculator.Divide(101, 0));
            ex.ParamName.ShouldBe("number");
        }

        public void ShouldAddNumbers()
        {
            var calculator = new Calculator();
            Should.CompleteIn(() => Calculator.AddInts(1, 2), TimeSpan.FromMilliseconds(100));
        }

    }
}

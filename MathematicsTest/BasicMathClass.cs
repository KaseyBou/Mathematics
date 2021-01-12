using Mathematics;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MathematicsTest
{
    public class BasicMathClass
    {
        [Fact]
        public void testAddNumbers()
        {
            var math = new BasicMath();
            var result = math.addNumbers(5, 5);
            Assert.True(result == 10);
        }

        [Fact]
        public void testSubtractNumbers()
        {
            var math = new BasicMath();
            var result = math.subtractNumbers(5, 5);
            Assert.True(result == 0);
        }

        [Fact]
        public void testMultiplyNumbers()
        {
            var math = new BasicMath();
            var result = math.multiplyNumbers(5, 5);
            Assert.True(result == 25);
        }

        [Fact]
        public void testDivideNumbers()
        {
            var math = new BasicMath();
            var result = math.divideNumbers(10, 2);
            Assert.True(result == 5);
        }


    }
}

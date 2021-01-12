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

        //Advanced Math

        [Fact]
        public void testcalculateArea()
        {
            var math = new AdvMath();
            var result = math.calculateArea(3, 7);
            Assert.True(result == 21);
        }

        [Fact]
        public void testListAverage()
        {
            var math = new AdvMath();
            var result = math.calculateListAverage(2, 3.5, 4, 7.5);
            Assert.True(result == 4.25);
        }

        [Fact]
        public void testValueSquared()
        {
            var math = new AdvMath();
            var result = math.calculateValueSquared(3);
            Assert.True(result == 9);
        }

        [Fact]
        public void testPythagoreanTheorem()
        {
            var math = new AdvMath();
            var result = math.calculatePythagoreanTheorem(3, 4);
            Assert.True(result == 5);
        }
    }
}

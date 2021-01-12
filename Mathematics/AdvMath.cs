using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mathematics
{
    public class AdvMath
    {
        public double calculateArea(double height, double width)
        {
            return height * width;
        }

        public double calculateListAverage(double num1, double num2, double num3, double num4)
        {
            var list = new List<double> { num1, num2, num3, num4 };

            double result = list.Average();

            return result;

        }

        public double calculateValueSquared(double num)
        {
            return num * num;
        }

        public double calculatePythagoreanTheorem(double side1, double side2)
        {
            double hypo = Math.Sqrt(Math.Pow(side1, 2) + Math.Pow(side2, 2));

            return hypo;
        }

    }
}

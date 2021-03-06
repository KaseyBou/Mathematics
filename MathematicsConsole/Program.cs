using System;
using Mathematics;

namespace MathematicsConsole
{
    class Program
    {
        private static double _num1;
        private static double _num2;
        private static double _num3;
        private static double _num4;
        private static double _operand;
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();

            /*  foreach(var a in args)
              {
                  Console.WriteLine(a);
              }

              Console.ReadLine(); */

            AreArgumentsValid(args);

            var Math = new BasicMath();
            var advMath = new AdvMath();


            switch (_operand.ToString())
            {
                case "add":
                    Console.WriteLine($"{_num1} + {_num2} = {Math.addNumbers(_num1, _num2)}");
                    break;
                case "sub":
                    Console.WriteLine($"{_num1} - {_num2} = {Math.subtractNumbers(_num1, _num2)}");
                    break;
                case "mult":
                    Console.WriteLine($"{_num1} * {_num2} = {Math.multiplyNumbers(_num1, _num2)}");
                    break;
                case "div":
                    Console.WriteLine($"{_num1} / {_num2} = {Math.divideNumbers(_num1, _num2)}");
                    break;
                case "area":
                    Console.WriteLine($"{_num1} * {_num2} H = {advMath.calculateArea(_num1, _num2)}.");
                    break;
                case "avg":
                    Console.WriteLine($"{_num1}, {_num2}, {_num3}, {_num4} = {advMath.calculateListAverage(_num1, _num2, _num3, _num4)}");
                    break;
                case "squared":
                    Console.WriteLine($"{_num1}^2 = {advMath.calculateValueSquared(_num1)}");
                    break;
                case "pyth":
                    Console.WriteLine($"{_num1}^2 + {_num2}^2 = {advMath.calculatePythagoreanTheorem(_num1, _num2)}");
                    break;
                default:
                    Console.WriteLine($"{_operand} is not a valid operator. Please enter Add, Sub, Mul, Div, area, avg, squared, pyth");
                    break;
            }

            Console.ReadLine();
        }

        public static void AreArgumentsValid(string[] args)
        {
            _operand = NumParser(args[1].ToLower());
            _num1 = NumParser(args[2]);
            _num2 = NumParser(args[3]);
            _num3 = NumParser(args[4]);
            _num4 = NumParser(args[5]);

            Console.WriteLine("All Arguments are valid!");
           // Console.ReadLine();
        }

        public static double  NumParser(string arg)
        {
            double number;
            if (Double.TryParse(arg, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine($"Unable to parse {arg}.");
                Environment.Exit(99);
            }

            return 0;
        }
    }
}

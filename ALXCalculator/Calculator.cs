﻿namespace ALXCalculator
{
    public class Calculator
    {
        public void Run()
        {
            Console.WriteLine("Running calculator.......");
            Console.WriteLine();
            Console.WriteLine("OPERTAIONS:");
            Console.WriteLine("+\taddition");
            Console.WriteLine("-\tsubstraction");
            Console.WriteLine("*\tmultiplication");
            Console.WriteLine("/\tdivision \n");
            Console.WriteLine();
            Console.WriteLine("Choose opertion:");
            Console.WriteLine();
            var operationCharacterInfo = Console.ReadKey();
            Console.Write("\nX number: ");
            var x = Double.Parse(Console.ReadLine());
            //var x = Int32.Parse(Console.ReadLine());    //x typu string parsujemy na int
            //var xInt=Int32.Parse(x);//konwrsja na typ int
            Console.Write("Y number: ");
            var y = Double.Parse(Console.ReadLine());
            //var y = Int32.Parse(Console.ReadLine());
            //var y = Console.ReadLine();
            //var yInt=Int32.Parse(y);
            //Console.WriteLine($"{x} + {y}={xInt+yInt}");
            //Console.WriteLine($"{x} + {y}={x + y}");
            // Console.WriteLine($"{x} + {y} = {Add(x, y)}");
            // Console.WriteLine($"{x} - {y} = {Substract(x, y)}");
            // Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
            // Console.WriteLine($"{x} / {y} = {Divide(x, y)}");

            PerformOperation(operationCharacterInfo.KeyChar,x, y);
        }

        private void PerformOperation(char operationChar, double x, double y)
        {
            switch(operationChar)
            {
                case '+':
                   Console.WriteLine($"{x} + {y} = {Add(x, y)}");
                    break;
                case '-':
                    Console.WriteLine($"{x} - {y} = {Substract(x, y)}");
                    break;
                case '*':
                    Console.WriteLine($"{x} * {y} = {Multiply(x, y)}");
                    break;
                case '/':
                    Console.WriteLine($"{x} / {y} = {Divide(x, y)}");
                    break;

                default:
                    Console.WriteLine("Invalid operation.......");
                    break;
            }
        }

        private double Add(double x, double y)
        {
            return x + y;
        }
        private double Substract(double x, double y)
        {
            return x - y;
        }

        private double Multiply(double x, double y)
        {
            return x * y;
        }

        private double Divide(double x, double y)
        {
            return x / y;
        }
    }
}

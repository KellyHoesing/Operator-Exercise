using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine($"{a} divided by {b} is {quotient} with a remainder of {remainder}");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle = CalculateArea(20);
            Console.WriteLine($"The area of a circle with a Radius of {radius} is {areaOfCircle}");
        }
        public static double CalculateArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

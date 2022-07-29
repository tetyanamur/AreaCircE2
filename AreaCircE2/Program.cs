using System;

namespace OperatorExercise
{
    class Exercise2
    {
        public static double AreaoOfCircle(double radius)
        {
            return Math.PI * radius * radius;

        }
        static void Main(string[] args)
        {


            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle in this radius is {AreaoOfCircle(radius)} ");
        }
    }
}

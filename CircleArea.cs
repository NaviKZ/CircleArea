using System;

namespace CircleArea
{
    internal class CircleArea
    {
        static void Main(string[] args)
        {
            double radius = 20; //TODO: Осуществить ввод с консоли
            double circleArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine("Площадь круга равна: {0:f3}", circleArea);

            Console.ReadKey();
        }
    }
}

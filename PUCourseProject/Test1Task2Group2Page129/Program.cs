using System;

namespace Test1Task2Group2Page129
{
    class Program
    {
        static void Main(string[] args)
        {
            int Beta = 16;
            int y = 1;
            double result = 0;
            double chislitel = 0;
            double znamenatel = 0;

            chislitel = Math.Pow(Math.Sin(Math.Pow(Math.PI, 4)), 2);
            chislitel += Beta;
            znamenatel = Math.Pow(Math.Cos(6), 1 / 5) + Math.Abs(1 / Math.Tan(y));
            result = chislitel / znamenatel;

            Console.WriteLine(result);
        }
    }
}

using System;
using System.Text;

namespace Task395Page219
{
    class Program
    {
        static double CelF(double f)
        {
            return 5.0 / 9 * (f - 32);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Въведете градуси по Фаренхайт = ");

            double Fahrenheit = double.Parse(Console.ReadLine());
            double Celsius = 0;

            Celsius = CelF(Fahrenheit);

            Console.WriteLine(Celsius);
            Console.WriteLine();
            // ..............................................

            // int[31] FH = { -20, -17, -90, -10, 0, 12, 36, 39, 50, 66, 90, 100 };


            int[] FH = new int[31];

            for (int i = 1; i <= 31; i++)
            {
                Console.Write("Въведете градуси по Фаренхайт [-100,100] за ден " + i + " = ");
                FH[i - 1] = int.Parse(Console.ReadLine());

                while (FH[i - 1] < -100 || FH[i - 1] > 100)
                {
                    Console.WriteLine($"{(char)07}");
                    Console.Write("Въведете градуси по Фаренхайт [-100,100] за ден " + i + " = ");
                    FH[i - 1] = int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine();
            //....................................................

            for (int i = 1; i < FH.Length; i++)
                for (int j = FH.Length - 1; j >= 1; j--)
                    if (FH[j - 1] > FH[j])
                    {
                        int x = FH[j - 1];
                        FH[j - 1] = FH[j];
                        FH[j] = x;
                    }


            Console.WriteLine("Максимална среднодневна стойност по Фаренхайт = " + FH[30]);
            Console.WriteLine("Максимална среднодневна стойност по Целзий = " + CelF(FH[30]));

            Console.WriteLine();

            //...........................................................

            for (int i = 0; i < FH.Length; i++)
            {
                Celsius = CelF(FH[i]);

                if (Celsius < -10)
                {
                    Console.WriteLine("Стойности по целзий по-малки от -10 градуса: " + Celsius);
                }

            }
        }
    }
}

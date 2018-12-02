using System;
using System.Text;

namespace Task213aPage126
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int sum = 0;
            for (int i = 1; i < 10; i += 2)
                sum += i;

            Console.WriteLine("Сумата е = " + sum);
        }
    }
}
